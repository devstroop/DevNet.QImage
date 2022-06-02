using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_CSharp_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var result = await DevNet.QImage.Query(this.textBox1.Text, (int)this.numericUpDown1.Value);
            dataGridView1.DataSource = result;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(2) && e.RowIndex != -1)
            {
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                {
                    if (MessageBox.Show("Do you want to save this image?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try {
                            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                            //saveFileDialog1.InitialDirectory = @"C:\";      
                            saveFileDialog1.Title = "Save Image";
                            //saveFileDialog1.CheckFileExists = true;
                            saveFileDialog1.CheckPathExists = true;
                            saveFileDialog1.DefaultExt = "png";
                            saveFileDialog1.Filter = "Image (*.png)|*.png|All files (*.*)|*.*";
                            saveFileDialog1.FilterIndex = 0;
                            saveFileDialog1.RestoreDirectory = true;
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                Image image = (Image)dataGridView1.CurrentCell.Value;
                                image.Save(saveFileDialog1.FileName);
                                MessageBox.Show("Successfully saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Failed","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
    }
}
