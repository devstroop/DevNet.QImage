<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.label1 = New System.Windows.Forms.Label()
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox1
        '
        Me.pictureBox1.Location = New System.Drawing.Point(950, 17)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(100, 94)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 12
        Me.pictureBox1.TabStop = False
        '
        'dataGridView1
        '
        Me.dataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(17, 118)
        Me.dataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.RowHeadersWidth = 51
        Me.dataGridView1.RowTemplate.Height = 140
        Me.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridView1.Size = New System.Drawing.Size(1033, 423)
        Me.dataGridView1.TabIndex = 11
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(821, 56)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(34, 16)
        Me.label1.TabIndex = 10
        Me.label1.Text = "Limit"
        '
        'numericUpDown1
        '
        Me.numericUpDown1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numericUpDown1.Location = New System.Drawing.Point(863, 50)
        Me.numericUpDown1.Margin = New System.Windows.Forms.Padding(4)
        Me.numericUpDown1.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(80, 22)
        Me.numericUpDown1.TabIndex = 9
        Me.numericUpDown1.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'button1
        '
        Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button1.Location = New System.Drawing.Point(850, 14)
        Me.button1.Margin = New System.Windows.Forms.Padding(4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(93, 28)
        Me.button1.TabIndex = 8
        Me.button1.Text = "Search"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox1
        '
        Me.textBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBox1.Location = New System.Drawing.Point(16, 17)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(826, 22)
        Me.textBox1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.numericUpDown1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents label1 As Label
    Private WithEvents numericUpDown1 As NumericUpDown
    Private WithEvents button1 As Button
    Private WithEvents textBox1 As TextBox
End Class
