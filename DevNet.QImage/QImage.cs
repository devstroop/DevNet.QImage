using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace DevNet
{
    public class QImage
    {
        private static string RootDomain = "www.google.co.in";
        public async static Task<List<WebImage>> Query(string query, int limit = 1) 
        {
            string queryURL = $"https://{RootDomain}/search?q={query}&source=lnms&tbm=isch";
            string html = await CallUrl(queryURL);

            //List<string> urls = new List<string>();
            List<WebImage> webImages = new List<WebImage>();

            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            HtmlNodeCollection blocks = htmlDoc.DocumentNode.SelectNodes("//img");

            Console.WriteLine(blocks.Count);
            limit += 1;
            if (blocks != null)
            {
                int count = 0;
                if (blocks.Count > limit)
                {
                    count = limit;
                }
                else
                {
                    count = blocks.Count;
                }
                for (int index = 1; index < count; index++)
                {
                    WebImage webImage = new WebImage();
                    webImage.Index = index;
                    webImage.URL = blocks[index].Attributes["src"].Value.StartsWith("http") ? blocks[index].Attributes["src"].Value : $"https://{RootDomain}" + blocks[index].Attributes["src"].Value;
                    WebClient wc = new WebClient();
                    byte[] bytes = wc.DownloadData(webImage.URL);
                    MemoryStream ms = new MemoryStream(bytes);
                    webImage.Image = System.Drawing.Image.FromStream(ms);
                    webImages.Add(webImage);
                }
            }

            return webImages;
        }
        private static async Task<string> CallUrl(string fullUrl)
        {
            HttpClient client = new HttpClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.102 Safari/537.36 Edge/18.19582");
            var response = client.GetStringAsync(fullUrl);
            return await response;
        }
    }
}
