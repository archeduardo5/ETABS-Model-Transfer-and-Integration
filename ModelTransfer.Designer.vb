<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModelTransfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModelTransfer))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ExportTab = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ExportOKButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CsvFileLocBrowse = New System.Windows.Forms.TextBox()
        Me.CsvFileBrowseBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExportFileLocBrowse = New System.Windows.Forms.TextBox()
        Me.ExportFileBrowseBtn = New System.Windows.Forms.Button()
        Me.ImportTab = New System.Windows.Forms.TabPage()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ExportFileLoc = New System.Windows.Forms.OpenFileDialog()
        Me.CSVFileLoc = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.ExportTab.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ImportTab.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.ExportTab)
        Me.TabControl1.Controls.Add(Me.ImportTab)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(739, 441)
        Me.TabControl1.TabIndex = 0
        '
        'ExportTab
        '
        Me.ExportTab.BackColor = System.Drawing.SystemColors.Control
        Me.ExportTab.Controls.Add(Me.GroupBox4)
        Me.ExportTab.Controls.Add(Me.btnCancel)
        Me.ExportTab.Controls.Add(Me.ExportOKButton)
        Me.ExportTab.Controls.Add(Me.GroupBox1)
        Me.ExportTab.Controls.Add(Me.Label2)
        Me.ExportTab.Controls.Add(Me.CsvFileLocBrowse)
        Me.ExportTab.Controls.Add(Me.CsvFileBrowseBtn)
        Me.ExportTab.Controls.Add(Me.Label1)
        Me.ExportTab.Controls.Add(Me.ExportFileLocBrowse)
        Me.ExportTab.Controls.Add(Me.ExportFileBrowseBtn)
        Me.ExportTab.Location = New System.Drawing.Point(4, 22)
        Me.ExportTab.Name = "ExportTab"
        Me.ExportTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ExportTab.Size = New System.Drawing.Size(731, 415)
        Me.ExportTab.TabIndex = 0
        Me.ExportTab.Text = "Export"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button8)
        Me.GroupBox4.Controls.Add(Me.Button7)
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Location = New System.Drawing.Point(60, 264)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(595, 96)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Direct Export"
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(303, 38)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(83, 36)
        Me.Button8.TabIndex = 16
        Me.Button8.Text = "Rhino"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(170, 38)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(83, 36)
        Me.Button7.TabIndex = 15
        Me.Button7.Text = "RAM"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(26, 38)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(83, 36)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = " Etabs"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(640, 386)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseCompatibleTextRendering = True
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ExportOKButton
        '
        Me.ExportOKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExportOKButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ExportOKButton.Location = New System.Drawing.Point(559, 386)
        Me.ExportOKButton.Name = "ExportOKButton"
        Me.ExportOKButton.Size = New System.Drawing.Size(75, 23)
        Me.ExportOKButton.TabIndex = 11
        Me.ExportOKButton.Text = "OK"
        Me.ExportOKButton.UseCompatibleTextRendering = True
        Me.ExportOKButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox11)
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(60, 153)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 97)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Export Options"
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Checked = True
        Me.CheckBox11.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox11.Location = New System.Drawing.Point(479, 38)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(66, 17)
        Me.CheckBox11.TabIndex = 10
        Me.CheckBox11.Text = "Footings"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Checked = True
        Me.CheckBox5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox5.Location = New System.Drawing.Point(126, 38)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(66, 17)
        Me.CheckBox5.TabIndex = 9
        Me.CheckBox5.Text = "Columns"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Checked = True
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.Location = New System.Drawing.Point(234, 38)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(52, 17)
        Me.CheckBox4.TabIndex = 8
        Me.CheckBox4.Text = "Slabs"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Location = New System.Drawing.Point(303, 38)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(52, 17)
        Me.CheckBox3.TabIndex = 7
        Me.CheckBox3.Text = "Walls"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(396, 38)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(50, 17)
        Me.CheckBox2.TabIndex = 6
        Me.CheckBox2.Text = "Grids"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(26, 38)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(58, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Beams"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Save Transfer File to:"
        '
        'CsvFileLocBrowse
        '
        Me.CsvFileLocBrowse.Location = New System.Drawing.Point(204, 101)
        Me.CsvFileLocBrowse.Name = "CsvFileLocBrowse"
        Me.CsvFileLocBrowse.Size = New System.Drawing.Size(351, 20)
        Me.CsvFileLocBrowse.TabIndex = 7
        '
        'CsvFileBrowseBtn
        '
        Me.CsvFileBrowseBtn.Location = New System.Drawing.Point(617, 97)
        Me.CsvFileBrowseBtn.Name = "CsvFileBrowseBtn"
        Me.CsvFileBrowseBtn.Size = New System.Drawing.Size(75, 23)
        Me.CsvFileBrowseBtn.TabIndex = 6
        Me.CsvFileBrowseBtn.Text = "Browse"
        Me.CsvFileBrowseBtn.UseCompatibleTextRendering = True
        Me.CsvFileBrowseBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "File to Export:"
        '
        'ExportFileLocBrowse
        '
        Me.ExportFileLocBrowse.Location = New System.Drawing.Point(204, 65)
        Me.ExportFileLocBrowse.Name = "ExportFileLocBrowse"
        Me.ExportFileLocBrowse.Size = New System.Drawing.Size(351, 20)
        Me.ExportFileLocBrowse.TabIndex = 3
        '
        'ExportFileBrowseBtn
        '
        Me.ExportFileBrowseBtn.Location = New System.Drawing.Point(617, 61)
        Me.ExportFileBrowseBtn.Name = "ExportFileBrowseBtn"
        Me.ExportFileBrowseBtn.Size = New System.Drawing.Size(75, 23)
        Me.ExportFileBrowseBtn.TabIndex = 2
        Me.ExportFileBrowseBtn.Text = "Browse"
        Me.ExportFileBrowseBtn.UseCompatibleTextRendering = True
        Me.ExportFileBrowseBtn.UseVisualStyleBackColor = True
        '
        'ImportTab
        '
        Me.ImportTab.BackColor = System.Drawing.SystemColors.Control
        Me.ImportTab.Controls.Add(Me.RadioButton6)
        Me.ImportTab.Controls.Add(Me.RadioButton5)
        Me.ImportTab.Controls.Add(Me.Label3)
        Me.ImportTab.Controls.Add(Me.TextBox3)
        Me.ImportTab.Controls.Add(Me.Button4)
        Me.ImportTab.Controls.Add(Me.GroupBox3)
        Me.ImportTab.Controls.Add(Me.Button2)
        Me.ImportTab.Controls.Add(Me.Button3)
        Me.ImportTab.Controls.Add(Me.GroupBox2)
        Me.ImportTab.Controls.Add(Me.Label4)
        Me.ImportTab.Controls.Add(Me.TextBox4)
        Me.ImportTab.Controls.Add(Me.Button5)
        Me.ImportTab.Location = New System.Drawing.Point(4, 22)
        Me.ImportTab.Name = "ImportTab"
        Me.ImportTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ImportTab.Size = New System.Drawing.Size(731, 415)
        Me.ImportTab.TabIndex = 1
        Me.ImportTab.Text = "Import"
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(98, 360)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(83, 17)
        Me.RadioButton6.TabIndex = 28
        Me.RadioButton6.Text = "Overwrite all"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Checked = True
        Me.RadioButton5.Location = New System.Drawing.Point(98, 328)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(60, 17)
        Me.RadioButton5.TabIndex = 27
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Update"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Save New Model to:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(199, 95)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(351, 20)
        Me.TextBox3.TabIndex = 25
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(612, 91)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "Browse"
        Me.Button4.UseCompatibleTextRendering = True
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton3)
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Location = New System.Drawing.Point(47, 142)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(570, 46)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Import to"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(331, 19)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(53, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Rhino"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(207, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(49, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "RAM"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(89, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(60, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "ETABS"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(635, 375)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Cancel"
        Me.Button2.UseCompatibleTextRendering = True
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button3.Location = New System.Drawing.Point(554, 375)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "OK"
        Me.Button3.UseCompatibleTextRendering = True
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox12)
        Me.GroupBox2.Controls.Add(Me.CheckBox6)
        Me.GroupBox2.Controls.Add(Me.CheckBox7)
        Me.GroupBox2.Controls.Add(Me.CheckBox8)
        Me.GroupBox2.Controls.Add(Me.CheckBox9)
        Me.GroupBox2.Controls.Add(Me.CheckBox10)
        Me.GroupBox2.Location = New System.Drawing.Point(55, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(563, 85)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Import Options"
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Checked = True
        Me.CheckBox12.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox12.Location = New System.Drawing.Point(461, 38)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(66, 17)
        Me.CheckBox12.TabIndex = 11
        Me.CheckBox12.Text = "Footings"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Checked = True
        Me.CheckBox6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox6.Location = New System.Drawing.Point(126, 38)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(66, 17)
        Me.CheckBox6.TabIndex = 9
        Me.CheckBox6.Text = "Columns"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Checked = True
        Me.CheckBox7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox7.Location = New System.Drawing.Point(234, 38)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(52, 17)
        Me.CheckBox7.TabIndex = 8
        Me.CheckBox7.Text = "Slabs"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Checked = True
        Me.CheckBox8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox8.Location = New System.Drawing.Point(303, 38)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(52, 17)
        Me.CheckBox8.TabIndex = 7
        Me.CheckBox8.Text = "Walls"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Checked = True
        Me.CheckBox9.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox9.Location = New System.Drawing.Point(396, 38)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(50, 17)
        Me.CheckBox9.TabIndex = 6
        Me.CheckBox9.Text = "Grids"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Checked = True
        Me.CheckBox10.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox10.Location = New System.Drawing.Point(26, 38)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(58, 17)
        Me.CheckBox10.TabIndex = 5
        Me.CheckBox10.Text = "Beams"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "File to Import:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(199, 54)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(351, 20)
        Me.TextBox4.TabIndex = 14
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(612, 50)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "Browse"
        Me.Button5.UseCompatibleTextRendering = True
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ExportFileLoc
        '
        Me.ExportFileLoc.FileName = "OpenFileDialog1"
        '
        'CSVFileLoc
        '
        Me.CSVFileLoc.FileName = "OpenFileDialog1"
        '
        'ModelTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 465)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "ModelTransfer"
        Me.Text = "Model Transfer"
        Me.TabControl1.ResumeLayout(False)
        Me.ExportTab.ResumeLayout(False)
        Me.ExportTab.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ImportTab.ResumeLayout(False)
        Me.ImportTab.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ExportTab As TabPage
    Private WithEvents btnCancel As Button
    Private WithEvents ExportOKButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CsvFileLocBrowse As TextBox
    Private WithEvents CsvFileBrowseBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ExportFileLocBrowse As TextBox
    Private WithEvents ExportFileBrowseBtn As Button
    Friend WithEvents ImportTab As TabPage
    Private WithEvents Button2 As Button
    Private WithEvents Button3 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Private WithEvents Button5 As Button
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Private WithEvents Button4 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ExportFileLoc As OpenFileDialog
    Friend WithEvents CSVFileLoc As OpenFileDialog
End Class
