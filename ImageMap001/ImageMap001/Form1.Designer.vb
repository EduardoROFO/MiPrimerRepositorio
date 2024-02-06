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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        RichTextBox1 = New RichTextBox()
        PictureBox3 = New PictureBox()
        ComboBox4 = New ComboBox()
        PictureBox4 = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewImageColumn()
        Column9 = New DataGridViewTextBoxColumn()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Cuerpo_Maping
        PictureBox1.Location = New Point(28, 38)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(557, 612)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(28, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 20)
        Label1.TabIndex = 1
        Label1.Text = "RGB: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(298, 5)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 20)
        Label3.TabIndex = 3
        Label3.Text = "Coordenadas:"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Cuerpo_MapingSide
        PictureBox2.Location = New Point(28, 38)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(557, 612)
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(624, 28)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 20)
        Label4.TabIndex = 5
        Label4.Text = "Región cuerpo:"
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(624, 51)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(216, 27)
        TextBox1.TabIndex = 6
        TextBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(624, 101)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 20)
        Label5.TabIndex = 7
        Label5.Text = "Tipo:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(624, 173)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 20)
        Label6.TabIndex = 9
        Label6.Text = "Lado:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(624, 248)
        Label7.Name = "Label7"
        Label7.Size = New Size(44, 20)
        Label7.TabIndex = 11
        Label7.Text = "Vista:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(624, 330)
        Label8.Name = "Label8"
        Label8.Size = New Size(72, 20)
        Label8.TabIndex = 13
        Label8.Text = "Cantidad:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(624, 413)
        Label9.Name = "Label9"
        Label9.Size = New Size(90, 20)
        Label9.TabIndex = 15
        Label9.Text = "Descripción:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FlatStyle = FlatStyle.Popup
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"ARETE/PERFORACIONES", "CICATRIZ", "CIRCUNCISION", "CORTES DECORATIVOS", "GEFECTO FISICO", "LUNARES O MANCHAS", "MARCAS TEMPORALES", "PROTESIS", "TATUAJE", "OTRO"})
        ComboBox1.Location = New Point(624, 124)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(186, 28)
        ComboBox1.TabIndex = 17
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.FlatStyle = FlatStyle.Popup
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"IZQUIERDO", "DERECHO", "NO ESPECIFICA", "UNICO"})
        ComboBox2.Location = New Point(624, 196)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(151, 28)
        ComboBox2.TabIndex = 18
        ' 
        ' ComboBox3
        ' 
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.FlatStyle = FlatStyle.Popup
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        ComboBox3.Location = New Point(624, 353)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(151, 28)
        ComboBox3.TabIndex = 20
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Cursor = Cursors.IBeam
        RichTextBox1.Location = New Point(624, 440)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(216, 210)
        RichTextBox1.TabIndex = 21
        RichTextBox1.Text = ""
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Cursor = Cursors.Cross
        PictureBox3.Image = My.Resources.Resources.CuerpoUNIX
        PictureBox3.Location = New Point(28, 38)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(557, 612)
        PictureBox3.TabIndex = 22
        PictureBox3.TabStop = False
        ' 
        ' ComboBox4
        ' 
        ComboBox4.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox4.FlatStyle = FlatStyle.Popup
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"DORSAL", "FRONTAL", "COSTADO", "NO ESPECIFICA"})
        ComboBox4.Location = New Point(624, 271)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(151, 28)
        ComboBox4.TabIndex = 23
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BorderStyle = BorderStyle.FixedSingle
        PictureBox4.Image = My.Resources.Resources.loadIcon
        PictureBox4.Location = New Point(865, 196)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(231, 185)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 24
        PictureBox4.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(877, 495)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 25
        Button1.Text = "Guardar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(999, 495)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 27
        Button2.Text = "Eliminar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(877, 550)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 28
        Button3.Text = "Importar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(999, 550)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 29
        Button4.Text = "Exportar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9})
        DataGridView1.Location = New Point(28, 682)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1068, 188)
        DataGridView1.TabIndex = 30
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Noº"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 50
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Región del cuerpo"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Tipo"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Lado"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Vista"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 130
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Cantidad"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 80
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Descripción"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 355
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Imagen"
        Column8.ImageLayout = DataGridViewImageCellLayout.Zoom
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 125
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Coordenadas"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 125
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(120.0F, 120.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1132, 903)
        Controls.Add(DataGridView1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox4)
        Controls.Add(ComboBox4)
        Controls.Add(PictureBox3)
        Controls.Add(RichTextBox1)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(PictureBox2)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Private WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewImageColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn

End Class