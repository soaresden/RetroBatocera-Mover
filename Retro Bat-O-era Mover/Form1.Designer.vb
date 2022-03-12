<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FromBatoToRetrobat = New System.Windows.Forms.Button()
        Me.FromRetrobatToBato = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.logobato = New System.Windows.Forms.PictureBox()
        Me.batoceramusic = New System.Windows.Forms.TextBox()
        Me.batocerathemes = New System.Windows.Forms.TextBox()
        Me.batocerasaves = New System.Windows.Forms.TextBox()
        Me.batoceracollection = New System.Windows.Forms.TextBox()
        Me.batoceraroms = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkcollectionbatocera = New System.Windows.Forms.CheckBox()
        Me.chkthemesbatocera = New System.Windows.Forms.CheckBox()
        Me.chkmusicbatocera = New System.Windows.Forms.CheckBox()
        Me.chksavesbatocera = New System.Windows.Forms.CheckBox()
        Me.chkromsbatocera = New System.Windows.Forms.CheckBox()
        Me.Browsebatocera = New System.Windows.Forms.Button()
        Me.rootpathbatocera = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.logoretrobat = New System.Windows.Forms.PictureBox()
        Me.retrobatmusic = New System.Windows.Forms.TextBox()
        Me.retrobatthemes = New System.Windows.Forms.TextBox()
        Me.retrobatsaves = New System.Windows.Forms.TextBox()
        Me.retrobatcollection = New System.Windows.Forms.TextBox()
        Me.Retrobatroms = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkcollectionretrobat = New System.Windows.Forms.CheckBox()
        Me.chkthemesretrobat = New System.Windows.Forms.CheckBox()
        Me.chkmusicretrobat = New System.Windows.Forms.CheckBox()
        Me.chksavesretrobat = New System.Windows.Forms.CheckBox()
        Me.chkromsretrobat = New System.Windows.Forms.CheckBox()
        Me.BrowseRetroBat = New System.Windows.Forms.Button()
        Me.rootpathRetrobat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox2.SuspendLayout()
        CType(Me.logobato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.logoretrobat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FromBatoToRetrobat
        '
        Me.FromBatoToRetrobat.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FromBatoToRetrobat.Location = New System.Drawing.Point(359, 174)
        Me.FromBatoToRetrobat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FromBatoToRetrobat.Name = "FromBatoToRetrobat"
        Me.FromBatoToRetrobat.Size = New System.Drawing.Size(86, 32)
        Me.FromBatoToRetrobat.TabIndex = 10
        Me.FromBatoToRetrobat.Text = "<--"
        Me.FromBatoToRetrobat.UseVisualStyleBackColor = False
        '
        'FromRetrobatToBato
        '
        Me.FromRetrobatToBato.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FromRetrobatToBato.Location = New System.Drawing.Point(359, 138)
        Me.FromRetrobatToBato.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FromRetrobatToBato.Name = "FromRetrobatToBato"
        Me.FromRetrobatToBato.Size = New System.Drawing.Size(86, 32)
        Me.FromRetrobatToBato.TabIndex = 9
        Me.FromRetrobatToBato.Text = "-->"
        Me.FromRetrobatToBato.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.logobato)
        Me.GroupBox2.Controls.Add(Me.batoceramusic)
        Me.GroupBox2.Controls.Add(Me.batocerathemes)
        Me.GroupBox2.Controls.Add(Me.batocerasaves)
        Me.GroupBox2.Controls.Add(Me.batoceracollection)
        Me.GroupBox2.Controls.Add(Me.batoceraroms)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.chkcollectionbatocera)
        Me.GroupBox2.Controls.Add(Me.chkthemesbatocera)
        Me.GroupBox2.Controls.Add(Me.chkmusicbatocera)
        Me.GroupBox2.Controls.Add(Me.chksavesbatocera)
        Me.GroupBox2.Controls.Add(Me.chkromsbatocera)
        Me.GroupBox2.Controls.Add(Me.Browsebatocera)
        Me.GroupBox2.Controls.Add(Me.rootpathbatocera)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(451, 96)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(339, 284)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Batocera"
        '
        'logobato
        '
        Me.logobato.Image = CType(resources.GetObject("logobato.Image"), System.Drawing.Image)
        Me.logobato.Location = New System.Drawing.Point(6, 19)
        Me.logobato.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.logobato.Name = "logobato"
        Me.logobato.Size = New System.Drawing.Size(91, 86)
        Me.logobato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logobato.TabIndex = 31
        Me.logobato.TabStop = False
        '
        'batoceramusic
        '
        Me.batoceramusic.Font = New System.Drawing.Font("Segoe UI", 6.0!)
        Me.batoceramusic.Location = New System.Drawing.Point(150, 248)
        Me.batoceramusic.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.batoceramusic.Name = "batoceramusic"
        Me.batoceramusic.Size = New System.Drawing.Size(183, 21)
        Me.batoceramusic.TabIndex = 30
        Me.batoceramusic.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'batocerathemes
        '
        Me.batocerathemes.Font = New System.Drawing.Font("Segoe UI", 6.0!)
        Me.batocerathemes.Location = New System.Drawing.Point(150, 226)
        Me.batocerathemes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.batocerathemes.Name = "batocerathemes"
        Me.batocerathemes.Size = New System.Drawing.Size(183, 21)
        Me.batocerathemes.TabIndex = 29
        Me.batocerathemes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'batocerasaves
        '
        Me.batocerasaves.Font = New System.Drawing.Font("Segoe UI", 6.0!)
        Me.batocerasaves.Location = New System.Drawing.Point(150, 177)
        Me.batocerasaves.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.batocerasaves.Name = "batocerasaves"
        Me.batocerasaves.Size = New System.Drawing.Size(183, 21)
        Me.batocerasaves.TabIndex = 28
        Me.batocerasaves.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'batoceracollection
        '
        Me.batoceracollection.Font = New System.Drawing.Font("Segoe UI", 6.0!)
        Me.batoceracollection.Location = New System.Drawing.Point(150, 154)
        Me.batoceracollection.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.batoceracollection.Name = "batoceracollection"
        Me.batoceracollection.Size = New System.Drawing.Size(183, 21)
        Me.batoceracollection.TabIndex = 27
        Me.batoceracollection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'batoceraroms
        '
        Me.batoceraroms.Font = New System.Drawing.Font("Segoe UI", 6.0!)
        Me.batoceraroms.Location = New System.Drawing.Point(150, 129)
        Me.batoceraroms.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.batoceraroms.Name = "batoceraroms"
        Me.batoceraroms.Size = New System.Drawing.Size(183, 21)
        Me.batoceraroms.TabIndex = 26
        Me.batoceraroms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 17)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Emulation Station"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Library :"
        '
        'chkcollectionbatocera
        '
        Me.chkcollectionbatocera.AutoSize = True
        Me.chkcollectionbatocera.Checked = True
        Me.chkcollectionbatocera.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkcollectionbatocera.Location = New System.Drawing.Point(16, 154)
        Me.chkcollectionbatocera.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkcollectionbatocera.Name = "chkcollectionbatocera"
        Me.chkcollectionbatocera.Size = New System.Drawing.Size(98, 21)
        Me.chkcollectionbatocera.TabIndex = 23
        Me.chkcollectionbatocera.Text = "Collections"
        Me.chkcollectionbatocera.UseVisualStyleBackColor = True
        '
        'chkthemesbatocera
        '
        Me.chkthemesbatocera.AutoSize = True
        Me.chkthemesbatocera.Checked = True
        Me.chkthemesbatocera.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkthemesbatocera.Location = New System.Drawing.Point(16, 226)
        Me.chkthemesbatocera.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkthemesbatocera.Name = "chkthemesbatocera"
        Me.chkthemesbatocera.Size = New System.Drawing.Size(81, 21)
        Me.chkthemesbatocera.TabIndex = 22
        Me.chkthemesbatocera.Text = "Themes"
        Me.chkthemesbatocera.UseVisualStyleBackColor = True
        '
        'chkmusicbatocera
        '
        Me.chkmusicbatocera.AutoSize = True
        Me.chkmusicbatocera.Checked = True
        Me.chkmusicbatocera.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkmusicbatocera.Location = New System.Drawing.Point(16, 248)
        Me.chkmusicbatocera.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkmusicbatocera.Name = "chkmusicbatocera"
        Me.chkmusicbatocera.Size = New System.Drawing.Size(66, 21)
        Me.chkmusicbatocera.TabIndex = 21
        Me.chkmusicbatocera.Text = "Music"
        Me.chkmusicbatocera.UseVisualStyleBackColor = True
        '
        'chksavesbatocera
        '
        Me.chksavesbatocera.AutoSize = True
        Me.chksavesbatocera.Checked = True
        Me.chksavesbatocera.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chksavesbatocera.Location = New System.Drawing.Point(16, 178)
        Me.chksavesbatocera.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chksavesbatocera.Name = "chksavesbatocera"
        Me.chksavesbatocera.Size = New System.Drawing.Size(69, 21)
        Me.chksavesbatocera.TabIndex = 20
        Me.chksavesbatocera.Text = "Saves"
        Me.chksavesbatocera.UseVisualStyleBackColor = True
        '
        'chkromsbatocera
        '
        Me.chkromsbatocera.AutoSize = True
        Me.chkromsbatocera.Checked = True
        Me.chkromsbatocera.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkromsbatocera.Location = New System.Drawing.Point(16, 130)
        Me.chkromsbatocera.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkromsbatocera.Name = "chkromsbatocera"
        Me.chkromsbatocera.Size = New System.Drawing.Size(66, 21)
        Me.chkromsbatocera.TabIndex = 19
        Me.chkromsbatocera.Text = "Roms"
        Me.chkromsbatocera.UseVisualStyleBackColor = True
        '
        'Browsebatocera
        '
        Me.Browsebatocera.ForeColor = System.Drawing.Color.Black
        Me.Browsebatocera.Location = New System.Drawing.Point(264, 13)
        Me.Browsebatocera.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Browsebatocera.Name = "Browsebatocera"
        Me.Browsebatocera.Size = New System.Drawing.Size(69, 23)
        Me.Browsebatocera.TabIndex = 18
        Me.Browsebatocera.Text = "Browse"
        Me.Browsebatocera.UseVisualStyleBackColor = True
        '
        'rootpathbatocera
        '
        Me.rootpathbatocera.Location = New System.Drawing.Point(99, 43)
        Me.rootpathbatocera.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rootpathbatocera.Multiline = True
        Me.rootpathbatocera.Name = "rootpathbatocera"
        Me.rootpathbatocera.Size = New System.Drawing.Size(234, 62)
        Me.rootpathbatocera.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(103, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "RootPath :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.logoretrobat)
        Me.GroupBox1.Controls.Add(Me.retrobatmusic)
        Me.GroupBox1.Controls.Add(Me.retrobatthemes)
        Me.GroupBox1.Controls.Add(Me.retrobatsaves)
        Me.GroupBox1.Controls.Add(Me.retrobatcollection)
        Me.GroupBox1.Controls.Add(Me.Retrobatroms)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.chkcollectionretrobat)
        Me.GroupBox1.Controls.Add(Me.chkthemesretrobat)
        Me.GroupBox1.Controls.Add(Me.chkmusicretrobat)
        Me.GroupBox1.Controls.Add(Me.chksavesretrobat)
        Me.GroupBox1.Controls.Add(Me.chkromsretrobat)
        Me.GroupBox1.Controls.Add(Me.BrowseRetroBat)
        Me.GroupBox1.Controls.Add(Me.rootpathRetrobat)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(14, 96)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(339, 284)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RetroBat"
        '
        'logoretrobat
        '
        Me.logoretrobat.Image = CType(resources.GetObject("logoretrobat.Image"), System.Drawing.Image)
        Me.logoretrobat.Location = New System.Drawing.Point(6, 19)
        Me.logoretrobat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.logoretrobat.Name = "logoretrobat"
        Me.logoretrobat.Size = New System.Drawing.Size(138, 55)
        Me.logoretrobat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logoretrobat.TabIndex = 15
        Me.logoretrobat.TabStop = False
        '
        'retrobatmusic
        '
        Me.retrobatmusic.Font = New System.Drawing.Font("Segoe UI", 6.0!)
        Me.retrobatmusic.Location = New System.Drawing.Point(150, 250)
        Me.retrobatmusic.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.retrobatmusic.Name = "retrobatmusic"
        Me.retrobatmusic.Size = New System.Drawing.Size(183, 21)
        Me.retrobatmusic.TabIndex = 14
        Me.retrobatmusic.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'retrobatthemes
        '
        Me.retrobatthemes.Font = New System.Drawing.Font("Segoe UI", 6.0!)
        Me.retrobatthemes.Location = New System.Drawing.Point(150, 227)
        Me.retrobatthemes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.retrobatthemes.Name = "retrobatthemes"
        Me.retrobatthemes.Size = New System.Drawing.Size(183, 21)
        Me.retrobatthemes.TabIndex = 13
        Me.retrobatthemes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'retrobatsaves
        '
        Me.retrobatsaves.Font = New System.Drawing.Font("Segoe UI", 6.0!)
        Me.retrobatsaves.Location = New System.Drawing.Point(150, 178)
        Me.retrobatsaves.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.retrobatsaves.Name = "retrobatsaves"
        Me.retrobatsaves.Size = New System.Drawing.Size(183, 21)
        Me.retrobatsaves.TabIndex = 12
        Me.retrobatsaves.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'retrobatcollection
        '
        Me.retrobatcollection.Font = New System.Drawing.Font("Segoe UI", 6.0!)
        Me.retrobatcollection.Location = New System.Drawing.Point(150, 156)
        Me.retrobatcollection.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.retrobatcollection.Name = "retrobatcollection"
        Me.retrobatcollection.Size = New System.Drawing.Size(183, 21)
        Me.retrobatcollection.TabIndex = 11
        Me.retrobatcollection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Retrobatroms
        '
        Me.Retrobatroms.Font = New System.Drawing.Font("Segoe UI", 6.0!)
        Me.Retrobatroms.Location = New System.Drawing.Point(150, 130)
        Me.Retrobatroms.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Retrobatroms.Name = "Retrobatroms"
        Me.Retrobatroms.Size = New System.Drawing.Size(183, 21)
        Me.Retrobatroms.TabIndex = 10
        Me.Retrobatroms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Emulation Station"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Library :"
        '
        'chkcollectionretrobat
        '
        Me.chkcollectionretrobat.AutoSize = True
        Me.chkcollectionretrobat.Checked = True
        Me.chkcollectionretrobat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkcollectionretrobat.Location = New System.Drawing.Point(16, 156)
        Me.chkcollectionretrobat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkcollectionretrobat.Name = "chkcollectionretrobat"
        Me.chkcollectionretrobat.Size = New System.Drawing.Size(98, 21)
        Me.chkcollectionretrobat.TabIndex = 7
        Me.chkcollectionretrobat.Text = "Collections"
        Me.chkcollectionretrobat.UseVisualStyleBackColor = True
        '
        'chkthemesretrobat
        '
        Me.chkthemesretrobat.AutoSize = True
        Me.chkthemesretrobat.Checked = True
        Me.chkthemesretrobat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkthemesretrobat.Location = New System.Drawing.Point(16, 227)
        Me.chkthemesretrobat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkthemesretrobat.Name = "chkthemesretrobat"
        Me.chkthemesretrobat.Size = New System.Drawing.Size(81, 21)
        Me.chkthemesretrobat.TabIndex = 6
        Me.chkthemesretrobat.Text = "Themes"
        Me.chkthemesretrobat.UseVisualStyleBackColor = True
        '
        'chkmusicretrobat
        '
        Me.chkmusicretrobat.AutoSize = True
        Me.chkmusicretrobat.Checked = True
        Me.chkmusicretrobat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkmusicretrobat.Location = New System.Drawing.Point(16, 250)
        Me.chkmusicretrobat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkmusicretrobat.Name = "chkmusicretrobat"
        Me.chkmusicretrobat.Size = New System.Drawing.Size(66, 21)
        Me.chkmusicretrobat.TabIndex = 5
        Me.chkmusicretrobat.Text = "Music"
        Me.chkmusicretrobat.UseVisualStyleBackColor = True
        '
        'chksavesretrobat
        '
        Me.chksavesretrobat.AutoSize = True
        Me.chksavesretrobat.Checked = True
        Me.chksavesretrobat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chksavesretrobat.Location = New System.Drawing.Point(16, 180)
        Me.chksavesretrobat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chksavesretrobat.Name = "chksavesretrobat"
        Me.chksavesretrobat.Size = New System.Drawing.Size(69, 21)
        Me.chksavesretrobat.TabIndex = 4
        Me.chksavesretrobat.Text = "Saves"
        Me.chksavesretrobat.UseVisualStyleBackColor = True
        '
        'chkromsretrobat
        '
        Me.chkromsretrobat.AutoSize = True
        Me.chkromsretrobat.Checked = True
        Me.chkromsretrobat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkromsretrobat.Location = New System.Drawing.Point(16, 132)
        Me.chkromsretrobat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkromsretrobat.Name = "chkromsretrobat"
        Me.chkromsretrobat.Size = New System.Drawing.Size(66, 21)
        Me.chkromsretrobat.TabIndex = 3
        Me.chkromsretrobat.Text = "Roms"
        Me.chkromsretrobat.UseVisualStyleBackColor = True
        '
        'BrowseRetroBat
        '
        Me.BrowseRetroBat.ForeColor = System.Drawing.Color.Black
        Me.BrowseRetroBat.Location = New System.Drawing.Point(264, 19)
        Me.BrowseRetroBat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BrowseRetroBat.Name = "BrowseRetroBat"
        Me.BrowseRetroBat.Size = New System.Drawing.Size(69, 23)
        Me.BrowseRetroBat.TabIndex = 2
        Me.BrowseRetroBat.Text = "Browse"
        Me.BrowseRetroBat.UseVisualStyleBackColor = True
        '
        'rootpathRetrobat
        '
        Me.rootpathRetrobat.Location = New System.Drawing.Point(150, 46)
        Me.rootpathRetrobat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rootpathRetrobat.Multiline = True
        Me.rootpathRetrobat.Name = "rootpathRetrobat"
        Me.rootpathRetrobat.Size = New System.Drawing.Size(183, 64)
        Me.rootpathRetrobat.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(150, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RootPath :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(0, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(801, 74)
        Me.Panel2.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(40, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(665, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "v1.1 by Soaresden"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label7.Location = New System.Drawing.Point(116, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(630, 65)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "RETROBAT-OCERA MOVER"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(801, 389)
        Me.Controls.Add(Me.FromBatoToRetrobat)
        Me.Controls.Add(Me.FromRetrobatToBato)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.logobato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.logoretrobat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FromBatoToRetrobat As Button
    Friend WithEvents FromRetrobatToBato As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents logobato As PictureBox
    Friend WithEvents batoceramusic As TextBox
    Friend WithEvents batocerathemes As TextBox
    Friend WithEvents batocerasaves As TextBox
    Friend WithEvents batoceracollection As TextBox
    Friend WithEvents batoceraroms As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents chkcollectionbatocera As CheckBox
    Friend WithEvents chkthemesbatocera As CheckBox
    Friend WithEvents chkmusicbatocera As CheckBox
    Friend WithEvents chksavesbatocera As CheckBox
    Friend WithEvents chkromsbatocera As CheckBox
    Friend WithEvents Browsebatocera As Button
    Friend WithEvents rootpathbatocera As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents logoretrobat As PictureBox
    Friend WithEvents retrobatmusic As TextBox
    Friend WithEvents retrobatthemes As TextBox
    Friend WithEvents retrobatsaves As TextBox
    Friend WithEvents retrobatcollection As TextBox
    Friend WithEvents Retrobatroms As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chkcollectionretrobat As CheckBox
    Friend WithEvents chkthemesretrobat As CheckBox
    Friend WithEvents chkmusicretrobat As CheckBox
    Friend WithEvents chksavesretrobat As CheckBox
    Friend WithEvents chkromsretrobat As CheckBox
    Friend WithEvents BrowseRetroBat As Button
    Friend WithEvents rootpathRetrobat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog2 As FolderBrowserDialog
End Class