Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim result = Await DevNet.QImage.Query(Me.textBox1.Text, CInt(Me.numericUpDown1.Value))
        dataGridView1.DataSource = result
    End Sub

    Private Sub dataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellContentDoubleClick
        If dataGridView1.CurrentCell.ColumnIndex.Equals(2) AndAlso e.RowIndex <> -1 Then

            If dataGridView1.CurrentCell IsNot Nothing AndAlso dataGridView1.CurrentCell.Value IsNot Nothing Then
                'If MessageBox.Show("Do you want to save this image?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

                '    Try
                '        Dim saveFileDialog1 As SaveFileDialog = New SaveFileDialog()
                '        saveFileDialog1.Title = "Save Image"
                '        saveFileDialog1.CheckPathExists = True
                '        saveFileDialog1.DefaultExt = "png"
                '        saveFileDialog1.Filter = "Image (*.png)|*.png|All files (*.*)|*.*"
                '        saveFileDialog1.FilterIndex = 0
                '        saveFileDialog1.RestoreDirectory = True

                '        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                '            Dim image As Image = CType(dataGridView1.CurrentCell.Value, Image)
                '            image.Save(saveFileDialog1.FileName)
                '            MessageBox.Show("Successfully saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '        End If

                '    Catch
                '        MessageBox.Show("Failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                '    End Try
                'End If
                Dim image As Image = CType(dataGridView1.CurrentCell.Value, Image)
                Me.pictureBox1.Image = image
            End If
        End If
    End Sub
End Class
