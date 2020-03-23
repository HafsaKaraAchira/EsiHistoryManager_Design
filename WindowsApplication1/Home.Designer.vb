<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.SideBar = New System.Windows.Forms.TableLayoutPanel()
        Me.BT_CLASS = New System.Windows.Forms.Button()
        Me.ClassIconsList = New System.Windows.Forms.ImageList(Me.components)
        Me.BT_STAT = New System.Windows.Forms.Button()
        Me.StaticIconsList = New System.Windows.Forms.ImageList(Me.components)
        Me.BT_RECH = New System.Windows.Forms.Button()
        Me.SearchIconsList = New System.Windows.Forms.ImageList(Me.components)
        Me.BT_PV = New System.Windows.Forms.Button()
        Me.PVIconsList = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.ProfilePane = New System.Windows.Forms.Panel()
        Me.BT_modif_mdp = New System.Windows.Forms.Button()
        Me.BT_LOGOUT = New System.Windows.Forms.Button()
        Me.mode_photo = New System.Windows.Forms.PictureBox()
        Me.LBL_MODE = New System.Windows.Forms.Label()
        Me.NavBar = New System.Windows.Forms.TableLayoutPanel()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.HistoryButton = New System.Windows.Forms.Button()
        Me.DetailButton = New System.Windows.Forms.Button()
        Me.RNGButton = New System.Windows.Forms.Button()
        Me.ModifButton = New System.Windows.Forms.Button()
        Me.RNButton = New System.Windows.Forms.Button()
        Me.HelpButton = New System.Windows.Forms.LinkLabel()
        Me.logo_bleu = New System.Windows.Forms.PictureBox()
        Me.PN_FORUMRECH = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BT_CANCELRECH = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BT_LANCERRECH = New System.Windows.Forms.Button()
        Me.LB_SERI = New System.Windows.Forms.Label()
        Me.LB_WILAYAB = New System.Windows.Forms.Label()
        Me.LB_CODEPOS = New System.Windows.Forms.Label()
        Me.LB_MOYBAC = New System.Windows.Forms.Label()
        Me.LB_ANNEEB = New System.Windows.Forms.Label()
        Me.LB_WILAYA = New System.Windows.Forms.Label()
        Me.LB_NOM = New System.Windows.Forms.Label()
        Me.LB_NOMA = New System.Windows.Forms.Label()
        Me.LB_PRENOMA = New System.Windows.Forms.Label()
        Me.LB_SEXE = New System.Windows.Forms.Label()
        Me.LB_LIEUNA = New System.Windows.Forms.Label()
        Me.LB_LIEUN = New System.Windows.Forms.Label()
        Me.LB_PRENOM = New System.Windows.Forms.Label()
        Me.LB_WILAYANA = New System.Windows.Forms.Label()
        Me.LB_DATEN = New System.Windows.Forms.Label()
        Me.LB_WILAYAN = New System.Windows.Forms.Label()
        Me.LB_VILLE = New System.Windows.Forms.Label()
        Me.LB_ADR = New System.Windows.Forms.Label()
        Me.LB_MATRICULB = New System.Windows.Forms.Label()
        Me.LB_MATRICUL = New System.Windows.Forms.Label()
        Me.CB_WILAYAB = New System.Windows.Forms.ComboBox()
        Me.CB_ANNEEB = New System.Windows.Forms.ComboBox()
        Me.CB_SERI = New System.Windows.Forms.ComboBox()
        Me.CB_WILAYA = New System.Windows.Forms.ComboBox()
        Me.CB_WILAYANA = New System.Windows.Forms.ComboBox()
        Me.CB_WILAYAN = New System.Windows.Forms.ComboBox()
        Me.CB_SEXE = New System.Windows.Forms.ComboBox()
        Me.DTP_DATEN = New System.Windows.Forms.DateTimePicker()
        Me.TXT_NOM = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TXT_NOMA = New System.Windows.Forms.TextBox()
        Me.TXT_PRENOMA = New System.Windows.Forms.TextBox()
        Me.TXT_LIEUN = New System.Windows.Forms.TextBox()
        Me.TXT_LIEUNA = New System.Windows.Forms.TextBox()
        Me.TXT_ADR = New System.Windows.Forms.TextBox()
        Me.TXT_VILLE = New System.Windows.Forms.TextBox()
        Me.TXT_CODEPOS = New System.Windows.Forms.TextBox()
        Me.TXT_MOYBAC = New System.Windows.Forms.TextBox()
        Me.TXT_MATRICULB = New System.Windows.Forms.TextBox()
        Me.TXT_MATRICUL = New System.Windows.Forms.TextBox()
        Me.PN_BIENVENUE = New System.Windows.Forms.Panel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SideBar.SuspendLayout()
        Me.ProfilePane.SuspendLayout()
        CType(Me.mode_photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBar.SuspendLayout()
        CType(Me.logo_bleu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PN_FORUMRECH.SuspendLayout()
        Me.PN_BIENVENUE.SuspendLayout()
        Me.SuspendLayout()
        '
        'SideBar
        '
        Me.SideBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.SideBar.ColumnCount = 1
        Me.SideBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.SideBar.Controls.Add(Me.BT_CLASS, 0, 1)
        Me.SideBar.Controls.Add(Me.BT_STAT, 0, 2)
        Me.SideBar.Controls.Add(Me.BT_RECH, 0, 3)
        Me.SideBar.Controls.Add(Me.BT_PV, 0, 4)
        Me.SideBar.Location = New System.Drawing.Point(0, 144)
        Me.SideBar.Margin = New System.Windows.Forms.Padding(0)
        Me.SideBar.Name = "SideBar"
        Me.SideBar.RowCount = 6
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123.0!))
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SideBar.Size = New System.Drawing.Size(247, 764)
        Me.SideBar.TabIndex = 8
        Me.SideBar.TabStop = True
        '
        'BT_CLASS
        '
        Me.BT_CLASS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_CLASS.Dock = System.Windows.Forms.DockStyle.Left
        Me.BT_CLASS.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.BT_CLASS.FlatAppearance.BorderSize = 0
        Me.BT_CLASS.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BT_CLASS.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BT_CLASS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_CLASS.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_CLASS.ForeColor = System.Drawing.SystemColors.Window
        Me.BT_CLASS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_CLASS.ImageIndex = 0
        Me.BT_CLASS.ImageList = Me.ClassIconsList
        Me.BT_CLASS.Location = New System.Drawing.Point(3, 125)
        Me.BT_CLASS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_CLASS.MinimumSize = New System.Drawing.Size(60, 60)
        Me.BT_CLASS.Name = "BT_CLASS"
        Me.BT_CLASS.Size = New System.Drawing.Size(239, 86)
        Me.BT_CLASS.TabIndex = 2
        Me.BT_CLASS.Text = "Classement"
        Me.BT_CLASS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_CLASS.UseVisualStyleBackColor = True
        '
        'ClassIconsList
        '
        Me.ClassIconsList.ImageStream = CType(resources.GetObject("ClassIconsList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ClassIconsList.TransparentColor = System.Drawing.Color.Transparent
        Me.ClassIconsList.Images.SetKeyName(0, "line_chart_bj.png")
        Me.ClassIconsList.Images.SetKeyName(1, "line_chart.png")
        '
        'BT_STAT
        '
        Me.BT_STAT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_STAT.Dock = System.Windows.Forms.DockStyle.Left
        Me.BT_STAT.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.BT_STAT.FlatAppearance.BorderSize = 0
        Me.BT_STAT.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BT_STAT.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BT_STAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_STAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_STAT.ForeColor = System.Drawing.SystemColors.Window
        Me.BT_STAT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_STAT.ImageKey = "diagram.png"
        Me.BT_STAT.ImageList = Me.StaticIconsList
        Me.BT_STAT.Location = New System.Drawing.Point(3, 215)
        Me.BT_STAT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_STAT.MinimumSize = New System.Drawing.Size(60, 60)
        Me.BT_STAT.Name = "BT_STAT"
        Me.BT_STAT.Size = New System.Drawing.Size(239, 79)
        Me.BT_STAT.TabIndex = 3
        Me.BT_STAT.Text = "Statistiques"
        Me.BT_STAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_STAT.UseVisualStyleBackColor = True
        '
        'StaticIconsList
        '
        Me.StaticIconsList.ImageStream = CType(resources.GetObject("StaticIconsList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.StaticIconsList.TransparentColor = System.Drawing.Color.Transparent
        Me.StaticIconsList.Images.SetKeyName(0, "diagram.png")
        Me.StaticIconsList.Images.SetKeyName(1, "diagram_bl.png")
        '
        'BT_RECH
        '
        Me.BT_RECH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_RECH.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.BT_RECH.FlatAppearance.BorderSize = 0
        Me.BT_RECH.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BT_RECH.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BT_RECH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_RECH.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_RECH.ForeColor = System.Drawing.SystemColors.Window
        Me.BT_RECH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_RECH.ImageKey = "search.png"
        Me.BT_RECH.ImageList = Me.SearchIconsList
        Me.BT_RECH.Location = New System.Drawing.Point(3, 298)
        Me.BT_RECH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_RECH.MinimumSize = New System.Drawing.Size(60, 60)
        Me.BT_RECH.Name = "BT_RECH"
        Me.BT_RECH.Size = New System.Drawing.Size(239, 82)
        Me.BT_RECH.TabIndex = 4
        Me.BT_RECH.Text = "Recherche"
        Me.BT_RECH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_RECH.UseVisualStyleBackColor = True
        '
        'SearchIconsList
        '
        Me.SearchIconsList.ImageStream = CType(resources.GetObject("SearchIconsList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.SearchIconsList.TransparentColor = System.Drawing.Color.Transparent
        Me.SearchIconsList.Images.SetKeyName(0, "search.png")
        Me.SearchIconsList.Images.SetKeyName(1, "search_blue.png")
        '
        'BT_PV
        '
        Me.BT_PV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_PV.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.BT_PV.FlatAppearance.BorderSize = 0
        Me.BT_PV.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BT_PV.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BT_PV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_PV.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_PV.ForeColor = System.Drawing.SystemColors.Window
        Me.BT_PV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_PV.ImageKey = "gantt_chart_bj.png"
        Me.BT_PV.ImageList = Me.PVIconsList
        Me.BT_PV.Location = New System.Drawing.Point(3, 384)
        Me.BT_PV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_PV.MinimumSize = New System.Drawing.Size(60, 60)
        Me.BT_PV.Name = "BT_PV"
        Me.BT_PV.Size = New System.Drawing.Size(239, 79)
        Me.BT_PV.TabIndex = 5
        Me.BT_PV.Text = "           PV"
        Me.BT_PV.UseVisualStyleBackColor = True
        '
        'PVIconsList
        '
        Me.PVIconsList.ImageStream = CType(resources.GetObject("PVIconsList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.PVIconsList.TransparentColor = System.Drawing.Color.Transparent
        Me.PVIconsList.Images.SetKeyName(0, "gantt_chart_bj.png")
        Me.PVIconsList.Images.SetKeyName(1, "chart_blue.png")
        '
        'MenuButton
        '
        Me.MenuButton.AutoSize = True
        Me.MenuButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.MenuButton.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.hamburger
        Me.MenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.MenuButton.FlatAppearance.BorderSize = 0
        Me.MenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuButton.ForeColor = System.Drawing.Color.Transparent
        Me.MenuButton.Location = New System.Drawing.Point(0, 0)
        Me.MenuButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MenuButton.MinimumSize = New System.Drawing.Size(60, 60)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(73, 144)
        Me.MenuButton.TabIndex = 0
        Me.MenuButton.UseVisualStyleBackColor = True
        '
        'ProfilePane
        '
        Me.ProfilePane.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.ProfilePane.Controls.Add(Me.BT_modif_mdp)
        Me.ProfilePane.Controls.Add(Me.BT_LOGOUT)
        Me.ProfilePane.Controls.Add(Me.mode_photo)
        Me.ProfilePane.Controls.Add(Me.LBL_MODE)
        Me.ProfilePane.Dock = System.Windows.Forms.DockStyle.Right
        Me.ProfilePane.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfilePane.Location = New System.Drawing.Point(1140, 0)
        Me.ProfilePane.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProfilePane.Name = "ProfilePane"
        Me.ProfilePane.Size = New System.Drawing.Size(201, 850)
        Me.ProfilePane.TabIndex = 1
        '
        'BT_modif_mdp
        '
        Me.BT_modif_mdp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BT_modif_mdp.AutoSize = True
        Me.BT_modif_mdp.BackColor = System.Drawing.Color.Transparent
        Me.BT_modif_mdp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_modif_mdp.Enabled = False
        Me.BT_modif_mdp.FlatAppearance.BorderSize = 0
        Me.BT_modif_mdp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BT_modif_mdp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BT_modif_mdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_modif_mdp.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.gear
        Me.BT_modif_mdp.Location = New System.Drawing.Point(152, 231)
        Me.BT_modif_mdp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_modif_mdp.Name = "BT_modif_mdp"
        Me.BT_modif_mdp.Size = New System.Drawing.Size(40, 37)
        Me.BT_modif_mdp.TabIndex = 0
        Me.BT_modif_mdp.UseVisualStyleBackColor = False
        Me.BT_modif_mdp.Visible = False
        '
        'BT_LOGOUT
        '
        Me.BT_LOGOUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_LOGOUT.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.BT_LOGOUT.FlatAppearance.BorderSize = 0
        Me.BT_LOGOUT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BT_LOGOUT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BT_LOGOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_LOGOUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_LOGOUT.ForeColor = System.Drawing.Color.White
        Me.BT_LOGOUT.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.exit_picture
        Me.BT_LOGOUT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_LOGOUT.Location = New System.Drawing.Point(19, 663)
        Me.BT_LOGOUT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BT_LOGOUT.Name = "BT_LOGOUT"
        Me.BT_LOGOUT.Size = New System.Drawing.Size(163, 124)
        Me.BT_LOGOUT.TabIndex = 3
        Me.BT_LOGOUT.Text = "Deconnecter"
        Me.BT_LOGOUT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_LOGOUT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BT_LOGOUT.UseVisualStyleBackColor = True
        '
        'mode_photo
        '
        Me.mode_photo.BackColor = System.Drawing.Color.Transparent
        Me.mode_photo.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.agent_mode
        Me.mode_photo.Location = New System.Drawing.Point(20, 95)
        Me.mode_photo.Margin = New System.Windows.Forms.Padding(4)
        Me.mode_photo.Name = "mode_photo"
        Me.mode_photo.Size = New System.Drawing.Size(160, 170)
        Me.mode_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mode_photo.TabIndex = 4
        Me.mode_photo.TabStop = False
        '
        'LBL_MODE
        '
        Me.LBL_MODE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_MODE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_MODE.ForeColor = System.Drawing.Color.White
        Me.LBL_MODE.Location = New System.Drawing.Point(1, 268)
        Me.LBL_MODE.Name = "LBL_MODE"
        Me.LBL_MODE.Size = New System.Drawing.Size(199, 97)
        Me.LBL_MODE.TabIndex = 5
        Me.LBL_MODE.Text = "Agent"
        Me.LBL_MODE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NavBar
        '
        Me.NavBar.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.NavBar.BackColor = System.Drawing.Color.Transparent
        Me.NavBar.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.Path
        Me.NavBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NavBar.ColumnCount = 7
        Me.NavBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.NavBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.NavBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.NavBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.NavBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.NavBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.NavBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.NavBar.Controls.Add(Me.PrintButton, 4, 0)
        Me.NavBar.Controls.Add(Me.HistoryButton, 3, 0)
        Me.NavBar.Controls.Add(Me.DetailButton, 2, 0)
        Me.NavBar.Controls.Add(Me.RNGButton, 1, 0)
        Me.NavBar.Controls.Add(Me.ModifButton, 5, 0)
        Me.NavBar.Controls.Add(Me.RNButton, 0, 0)
        Me.NavBar.Controls.Add(Me.HelpButton, 6, 0)
        Me.NavBar.Location = New System.Drawing.Point(251, 790)
        Me.NavBar.Margin = New System.Windows.Forms.Padding(20, 18, 20, 18)
        Me.NavBar.Name = "NavBar"
        Me.NavBar.RowCount = 1
        Me.NavBar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.NavBar.Size = New System.Drawing.Size(888, 66)
        Me.NavBar.TabIndex = 2
        '
        'PrintButton
        '
        Me.PrintButton.AutoSize = True
        Me.PrintButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PrintButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintButton.Enabled = False
        Me.PrintButton.FlatAppearance.BorderSize = 0
        Me.PrintButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.PrintButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintButton.Image = CType(resources.GetObject("PrintButton.Image"), System.Drawing.Image)
        Me.PrintButton.Location = New System.Drawing.Point(454, 2)
        Me.PrintButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PrintButton.MinimumSize = New System.Drawing.Size(60, 60)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(100, 62)
        Me.PrintButton.TabIndex = 10
        Me.PrintButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'HistoryButton
        '
        Me.HistoryButton.AutoSize = True
        Me.HistoryButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HistoryButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HistoryButton.Enabled = False
        Me.HistoryButton.FlatAppearance.BorderSize = 0
        Me.HistoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.HistoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.HistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HistoryButton.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.historique
        Me.HistoryButton.Location = New System.Drawing.Point(348, 2)
        Me.HistoryButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HistoryButton.MinimumSize = New System.Drawing.Size(60, 60)
        Me.HistoryButton.Name = "HistoryButton"
        Me.HistoryButton.Size = New System.Drawing.Size(100, 62)
        Me.HistoryButton.TabIndex = 9
        Me.HistoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.HistoryButton.UseVisualStyleBackColor = True
        '
        'DetailButton
        '
        Me.DetailButton.AutoSize = True
        Me.DetailButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DetailButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DetailButton.Enabled = False
        Me.DetailButton.FlatAppearance.BorderSize = 0
        Me.DetailButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.DetailButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.DetailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DetailButton.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.details
        Me.DetailButton.Location = New System.Drawing.Point(242, 2)
        Me.DetailButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DetailButton.MinimumSize = New System.Drawing.Size(60, 60)
        Me.DetailButton.Name = "DetailButton"
        Me.DetailButton.Size = New System.Drawing.Size(100, 62)
        Me.DetailButton.TabIndex = 6
        Me.DetailButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.DetailButton.UseVisualStyleBackColor = True
        '
        'RNGButton
        '
        Me.RNGButton.AutoSize = True
        Me.RNGButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RNGButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RNGButton.Enabled = False
        Me.RNGButton.FlatAppearance.BorderSize = 0
        Me.RNGButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.RNGButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.RNGButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RNGButton.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.RNG
        Me.RNGButton.Location = New System.Drawing.Point(136, 2)
        Me.RNGButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RNGButton.MinimumSize = New System.Drawing.Size(60, 60)
        Me.RNGButton.Name = "RNGButton"
        Me.RNGButton.Size = New System.Drawing.Size(100, 62)
        Me.RNGButton.TabIndex = 5
        Me.RNGButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.RNGButton.UseVisualStyleBackColor = True
        '
        'ModifButton
        '
        Me.ModifButton.AutoSize = True
        Me.ModifButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ModifButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ModifButton.Enabled = False
        Me.ModifButton.FlatAppearance.BorderSize = 0
        Me.ModifButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ModifButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ModifButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModifButton.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.modifier
        Me.ModifButton.Location = New System.Drawing.Point(560, 2)
        Me.ModifButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ModifButton.MinimumSize = New System.Drawing.Size(60, 60)
        Me.ModifButton.Name = "ModifButton"
        Me.ModifButton.Size = New System.Drawing.Size(100, 62)
        Me.ModifButton.TabIndex = 8
        Me.ModifButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ModifButton.UseVisualStyleBackColor = True
        Me.ModifButton.Visible = False
        '
        'RNButton
        '
        Me.RNButton.AutoSize = True
        Me.RNButton.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.RN
        Me.RNButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RNButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RNButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.RNButton.Enabled = False
        Me.RNButton.FlatAppearance.BorderSize = 0
        Me.RNButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.RNButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.RNButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RNButton.Location = New System.Drawing.Point(46, 2)
        Me.RNButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RNButton.MinimumSize = New System.Drawing.Size(60, 60)
        Me.RNButton.Name = "RNButton"
        Me.RNButton.Size = New System.Drawing.Size(84, 62)
        Me.RNButton.TabIndex = 3
        Me.RNButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.RNButton.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.ActiveLinkColor = System.Drawing.Color.Transparent
        Me.HelpButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HelpButton.BackColor = System.Drawing.Color.Transparent
        Me.HelpButton.Cursor = System.Windows.Forms.Cursors.Help
        Me.HelpButton.DisabledLinkColor = System.Drawing.Color.Transparent
        Me.HelpButton.ForeColor = System.Drawing.Color.Transparent
        Me.HelpButton.Image = CType(resources.GetObject("HelpButton.Image"), System.Drawing.Image)
        Me.HelpButton.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.HelpButton.LinkColor = System.Drawing.Color.Pink
        Me.HelpButton.Location = New System.Drawing.Point(738, 1)
        Me.HelpButton.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(75, 64)
        Me.HelpButton.TabIndex = 4
        Me.HelpButton.TabStop = True
        Me.HelpButton.Text = "                                                                   "
        Me.HelpButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HelpButton.VisitedLinkColor = System.Drawing.Color.Teal
        '
        'logo_bleu
        '
        Me.logo_bleu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.logo_bleu.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.logo_white
        Me.logo_bleu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.logo_bleu.Location = New System.Drawing.Point(72, 0)
        Me.logo_bleu.Margin = New System.Windows.Forms.Padding(4)
        Me.logo_bleu.Name = "logo_bleu"
        Me.logo_bleu.Size = New System.Drawing.Size(175, 145)
        Me.logo_bleu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo_bleu.TabIndex = 9
        Me.logo_bleu.TabStop = False
        Me.logo_bleu.Visible = False
        '
        'PN_FORUMRECH
        '
        Me.PN_FORUMRECH.AutoScroll = True
        Me.PN_FORUMRECH.BackColor = System.Drawing.Color.Transparent
        Me.PN_FORUMRECH.Controls.Add(Me.Panel1)
        Me.PN_FORUMRECH.Controls.Add(Me.Label2)
        Me.PN_FORUMRECH.Controls.Add(Me.BT_CANCELRECH)
        Me.PN_FORUMRECH.Controls.Add(Me.Label1)
        Me.PN_FORUMRECH.Controls.Add(Me.BT_LANCERRECH)
        Me.PN_FORUMRECH.Controls.Add(Me.LB_SERI)
        Me.PN_FORUMRECH.Controls.Add(Me.LB_WILAYAB)
        Me.PN_FORUMRECH.Controls.Add(Me.LB_CODEPOS)
        Me.PN_FORUMRECH.Controls.Add(Me.LB_MOYBAC)
        Me.PN_FORUMRECH.Controls.Add(Me.LB_ANNEEB)
        Me.PN_FORUMRECH.Controls.Add(Me.LB_WILAYA)
        Me.PN_FORUMRECH.Controls.Add(Me.LB_NOM)
        Me.PN_FORUMRECH.Controls.Add(Me.LB_NOMA)
        Me.PN_FORUMRECH.Controls.Add(Me.LB_PRENOMA)
        Me.PN_FORUMRECH.Controls.Add(Me.LB_SEXE)
        Me.PN_FORUMRECH.Controls.Add(Me.LB_LIEUNA)
        Me.PN_FORUMRECH.Controls.Add(Me.LB_LIEUN)
        Me.PN_FORUMRECH.Controls.Add(Me.LB_PRENOM)
        Me.PN_FORUMRECH.Controls.Add(Me.LB_WILAYANA)
        Me.PN_FORUMRECH.Controls.Add(Me.LB_DATEN)
        Me.PN_FORUMRECH.Controls.Add(Me.LB_WILAYAN)
        Me.PN_FORUMRECH.Controls.Add(Me.LB_VILLE)
        Me.PN_FORUMRECH.Controls.Add(Me.LB_ADR)
        Me.PN_FORUMRECH.Controls.Add(Me.LB_MATRICULB)
        Me.PN_FORUMRECH.Controls.Add(Me.LB_MATRICUL)
        Me.PN_FORUMRECH.Controls.Add(Me.CB_WILAYAB)
        Me.PN_FORUMRECH.Controls.Add(Me.CB_ANNEEB)
        Me.PN_FORUMRECH.Controls.Add(Me.CB_SERI)
        Me.PN_FORUMRECH.Controls.Add(Me.CB_WILAYA)
        Me.PN_FORUMRECH.Controls.Add(Me.CB_WILAYANA)
        Me.PN_FORUMRECH.Controls.Add(Me.CB_WILAYAN)
        Me.PN_FORUMRECH.Controls.Add(Me.CB_SEXE)
        Me.PN_FORUMRECH.Controls.Add(Me.DTP_DATEN)
        Me.PN_FORUMRECH.Controls.Add(Me.TXT_NOM)
        Me.PN_FORUMRECH.Controls.Add(Me.TextBox11)
        Me.PN_FORUMRECH.Controls.Add(Me.TXT_NOMA)
        Me.PN_FORUMRECH.Controls.Add(Me.TXT_PRENOMA)
        Me.PN_FORUMRECH.Controls.Add(Me.TXT_LIEUN)
        Me.PN_FORUMRECH.Controls.Add(Me.TXT_LIEUNA)
        Me.PN_FORUMRECH.Controls.Add(Me.TXT_ADR)
        Me.PN_FORUMRECH.Controls.Add(Me.TXT_VILLE)
        Me.PN_FORUMRECH.Controls.Add(Me.TXT_CODEPOS)
        Me.PN_FORUMRECH.Controls.Add(Me.TXT_MOYBAC)
        Me.PN_FORUMRECH.Controls.Add(Me.TXT_MATRICULB)
        Me.PN_FORUMRECH.Controls.Add(Me.TXT_MATRICUL)
        Me.PN_FORUMRECH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PN_FORUMRECH.Location = New System.Drawing.Point(248, 1)
        Me.PN_FORUMRECH.Name = "PN_FORUMRECH"
        Me.PN_FORUMRECH.Size = New System.Drawing.Size(891, 786)
        Me.PN_FORUMRECH.TabIndex = 10
        Me.PN_FORUMRECH.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(166, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(458, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Rmplissez seulement les champs dont vous etes sur !"
        '
        'BT_CANCELRECH
        '
        Me.BT_CANCELRECH.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BT_CANCELRECH.FlatAppearance.BorderSize = 0
        Me.BT_CANCELRECH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_CANCELRECH.ForeColor = System.Drawing.Color.LightGray
        Me.BT_CANCELRECH.Location = New System.Drawing.Point(27, 1280)
        Me.BT_CANCELRECH.Name = "BT_CANCELRECH"
        Me.BT_CANCELRECH.Size = New System.Drawing.Size(200, 40)
        Me.BT_CANCELRECH.TabIndex = 41
        Me.BT_CANCELRECH.Text = "Cancel"
        Me.BT_CANCELRECH.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(190, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(417, 44)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Formulaire de recherche"
        '
        'BT_LANCERRECH
        '
        Me.BT_LANCERRECH.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BT_LANCERRECH.FlatAppearance.BorderSize = 0
        Me.BT_LANCERRECH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_LANCERRECH.ForeColor = System.Drawing.Color.LightGray
        Me.BT_LANCERRECH.Location = New System.Drawing.Point(584, 1280)
        Me.BT_LANCERRECH.Name = "BT_LANCERRECH"
        Me.BT_LANCERRECH.Size = New System.Drawing.Size(200, 40)
        Me.BT_LANCERRECH.TabIndex = 40
        Me.BT_LANCERRECH.Text = "rechercher"
        Me.BT_LANCERRECH.UseVisualStyleBackColor = False
        '
        'LB_SERI
        '
        Me.LB_SERI.AutoSize = True
        Me.LB_SERI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_SERI.Location = New System.Drawing.Point(76, 1164)
        Me.LB_SERI.Name = "LB_SERI"
        Me.LB_SERI.Size = New System.Drawing.Size(96, 18)
        Me.LB_SERI.TabIndex = 39
        Me.LB_SERI.Text = "Serie de BAC"
        '
        'LB_WILAYAB
        '
        Me.LB_WILAYAB.AutoSize = True
        Me.LB_WILAYAB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_WILAYAB.Location = New System.Drawing.Point(76, 1054)
        Me.LB_WILAYAB.Name = "LB_WILAYAB"
        Me.LB_WILAYAB.Size = New System.Drawing.Size(106, 18)
        Me.LB_WILAYAB.TabIndex = 38
        Me.LB_WILAYAB.Text = "Wilaya de BAC"
        '
        'LB_CODEPOS
        '
        Me.LB_CODEPOS.AutoSize = True
        Me.LB_CODEPOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_CODEPOS.Location = New System.Drawing.Point(76, 999)
        Me.LB_CODEPOS.Name = "LB_CODEPOS"
        Me.LB_CODEPOS.Size = New System.Drawing.Size(93, 18)
        Me.LB_CODEPOS.TabIndex = 37
        Me.LB_CODEPOS.Text = "code postale"
        '
        'LB_MOYBAC
        '
        Me.LB_MOYBAC.AutoSize = True
        Me.LB_MOYBAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_MOYBAC.Location = New System.Drawing.Point(76, 1109)
        Me.LB_MOYBAC.Name = "LB_MOYBAC"
        Me.LB_MOYBAC.Size = New System.Drawing.Size(123, 18)
        Me.LB_MOYBAC.TabIndex = 36
        Me.LB_MOYBAC.Text = "Moyenne de BAC"
        '
        'LB_ANNEEB
        '
        Me.LB_ANNEEB.AutoSize = True
        Me.LB_ANNEEB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ANNEEB.Location = New System.Drawing.Point(76, 1220)
        Me.LB_ANNEEB.Name = "LB_ANNEEB"
        Me.LB_ANNEEB.Size = New System.Drawing.Size(103, 18)
        Me.LB_ANNEEB.TabIndex = 35
        Me.LB_ANNEEB.Text = "Annee de BAC"
        '
        'LB_WILAYA
        '
        Me.LB_WILAYA.AutoSize = True
        Me.LB_WILAYA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_WILAYA.Location = New System.Drawing.Point(76, 944)
        Me.LB_WILAYA.Name = "LB_WILAYA"
        Me.LB_WILAYA.Size = New System.Drawing.Size(106, 18)
        Me.LB_WILAYA.TabIndex = 34
        Me.LB_WILAYA.Text = "Wilaya actuelle"
        '
        'LB_NOM
        '
        Me.LB_NOM.AutoSize = True
        Me.LB_NOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_NOM.Location = New System.Drawing.Point(76, 284)
        Me.LB_NOM.Name = "LB_NOM"
        Me.LB_NOM.Size = New System.Drawing.Size(44, 20)
        Me.LB_NOM.TabIndex = 33
        Me.LB_NOM.Text = "Nom"
        '
        'LB_NOMA
        '
        Me.LB_NOMA.AutoSize = True
        Me.LB_NOMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_NOMA.Location = New System.Drawing.Point(76, 394)
        Me.LB_NOMA.Name = "LB_NOMA"
        Me.LB_NOMA.Size = New System.Drawing.Size(102, 18)
        Me.LB_NOMA.TabIndex = 32
        Me.LB_NOMA.Text = "Nom en arabe"
        '
        'LB_PRENOMA
        '
        Me.LB_PRENOMA.AutoSize = True
        Me.LB_PRENOMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_PRENOMA.Location = New System.Drawing.Point(76, 449)
        Me.LB_PRENOMA.Name = "LB_PRENOMA"
        Me.LB_PRENOMA.Size = New System.Drawing.Size(122, 18)
        Me.LB_PRENOMA.TabIndex = 31
        Me.LB_PRENOMA.Text = "Prenom en arabe"
        '
        'LB_SEXE
        '
        Me.LB_SEXE.AutoSize = True
        Me.LB_SEXE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_SEXE.Location = New System.Drawing.Point(76, 559)
        Me.LB_SEXE.Name = "LB_SEXE"
        Me.LB_SEXE.Size = New System.Drawing.Size(41, 18)
        Me.LB_SEXE.TabIndex = 30
        Me.LB_SEXE.Text = "Sexe"
        '
        'LB_LIEUNA
        '
        Me.LB_LIEUNA.AutoSize = True
        Me.LB_LIEUNA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_LIEUNA.Location = New System.Drawing.Point(76, 669)
        Me.LB_LIEUNA.Name = "LB_LIEUNA"
        Me.LB_LIEUNA.Size = New System.Drawing.Size(187, 18)
        Me.LB_LIEUNA.TabIndex = 29
        Me.LB_LIEUNA.Text = "Lieu de naissance en arabe"
        '
        'LB_LIEUN
        '
        Me.LB_LIEUN.AutoSize = True
        Me.LB_LIEUN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_LIEUN.Location = New System.Drawing.Point(76, 614)
        Me.LB_LIEUN.Name = "LB_LIEUN"
        Me.LB_LIEUN.Size = New System.Drawing.Size(126, 18)
        Me.LB_LIEUN.TabIndex = 28
        Me.LB_LIEUN.Text = "Lieu de naissance"
        '
        'LB_PRENOM
        '
        Me.LB_PRENOM.AutoSize = True
        Me.LB_PRENOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_PRENOM.Location = New System.Drawing.Point(76, 339)
        Me.LB_PRENOM.Name = "LB_PRENOM"
        Me.LB_PRENOM.Size = New System.Drawing.Size(72, 20)
        Me.LB_PRENOM.TabIndex = 27
        Me.LB_PRENOM.Text = "Prenom "
        '
        'LB_WILAYANA
        '
        Me.LB_WILAYANA.AutoSize = True
        Me.LB_WILAYANA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_WILAYANA.Location = New System.Drawing.Point(76, 779)
        Me.LB_WILAYANA.Name = "LB_WILAYANA"
        Me.LB_WILAYANA.Size = New System.Drawing.Size(204, 18)
        Me.LB_WILAYANA.TabIndex = 26
        Me.LB_WILAYANA.Text = "Wilaya de naissance en arabe"
        '
        'LB_DATEN
        '
        Me.LB_DATEN.AutoSize = True
        Me.LB_DATEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_DATEN.Location = New System.Drawing.Point(76, 504)
        Me.LB_DATEN.Name = "LB_DATEN"
        Me.LB_DATEN.Size = New System.Drawing.Size(130, 18)
        Me.LB_DATEN.TabIndex = 25
        Me.LB_DATEN.Text = "Date de naissance"
        '
        'LB_WILAYAN
        '
        Me.LB_WILAYAN.AutoSize = True
        Me.LB_WILAYAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_WILAYAN.Location = New System.Drawing.Point(76, 724)
        Me.LB_WILAYAN.Name = "LB_WILAYAN"
        Me.LB_WILAYAN.Size = New System.Drawing.Size(151, 18)
        Me.LB_WILAYAN.TabIndex = 24
        Me.LB_WILAYAN.Text = "Wialaya de naissance"
        '
        'LB_VILLE
        '
        Me.LB_VILLE.AutoSize = True
        Me.LB_VILLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_VILLE.Location = New System.Drawing.Point(76, 889)
        Me.LB_VILLE.Name = "LB_VILLE"
        Me.LB_VILLE.Size = New System.Drawing.Size(88, 18)
        Me.LB_VILLE.TabIndex = 23
        Me.LB_VILLE.Text = "Ville actuelle"
        '
        'LB_ADR
        '
        Me.LB_ADR.AutoSize = True
        Me.LB_ADR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_ADR.Location = New System.Drawing.Point(76, 834)
        Me.LB_ADR.Name = "LB_ADR"
        Me.LB_ADR.Size = New System.Drawing.Size(105, 18)
        Me.LB_ADR.TabIndex = 22
        Me.LB_ADR.Text = "Adresse actuel"
        '
        'LB_MATRICULB
        '
        Me.LB_MATRICULB.AutoSize = True
        Me.LB_MATRICULB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_MATRICULB.Location = New System.Drawing.Point(76, 229)
        Me.LB_MATRICULB.Name = "LB_MATRICULB"
        Me.LB_MATRICULB.Size = New System.Drawing.Size(141, 20)
        Me.LB_MATRICULB.TabIndex = 21
        Me.LB_MATRICULB.Text = "Matricule de BAC"
        '
        'LB_MATRICUL
        '
        Me.LB_MATRICUL.AutoSize = True
        Me.LB_MATRICUL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_MATRICUL.Location = New System.Drawing.Point(76, 174)
        Me.LB_MATRICUL.Name = "LB_MATRICUL"
        Me.LB_MATRICUL.Size = New System.Drawing.Size(78, 20)
        Me.LB_MATRICUL.TabIndex = 20
        Me.LB_MATRICUL.Text = "Matricule"
        '
        'CB_WILAYAB
        '
        Me.CB_WILAYAB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_WILAYAB.FormattingEnabled = True
        Me.CB_WILAYAB.Location = New System.Drawing.Point(369, 1054)
        Me.CB_WILAYAB.Name = "CB_WILAYAB"
        Me.CB_WILAYAB.Size = New System.Drawing.Size(350, 33)
        Me.CB_WILAYAB.TabIndex = 19
        '
        'CB_ANNEEB
        '
        Me.CB_ANNEEB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_ANNEEB.FormattingEnabled = True
        Me.CB_ANNEEB.Location = New System.Drawing.Point(369, 1220)
        Me.CB_ANNEEB.Name = "CB_ANNEEB"
        Me.CB_ANNEEB.Size = New System.Drawing.Size(350, 33)
        Me.CB_ANNEEB.TabIndex = 18
        '
        'CB_SERI
        '
        Me.CB_SERI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_SERI.FormattingEnabled = True
        Me.CB_SERI.Location = New System.Drawing.Point(369, 1164)
        Me.CB_SERI.Name = "CB_SERI"
        Me.CB_SERI.Size = New System.Drawing.Size(350, 33)
        Me.CB_SERI.TabIndex = 17
        '
        'CB_WILAYA
        '
        Me.CB_WILAYA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_WILAYA.FormattingEnabled = True
        Me.CB_WILAYA.Location = New System.Drawing.Point(369, 944)
        Me.CB_WILAYA.Name = "CB_WILAYA"
        Me.CB_WILAYA.Size = New System.Drawing.Size(350, 33)
        Me.CB_WILAYA.TabIndex = 16
        '
        'CB_WILAYANA
        '
        Me.CB_WILAYANA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_WILAYANA.FormattingEnabled = True
        Me.CB_WILAYANA.Location = New System.Drawing.Point(369, 779)
        Me.CB_WILAYANA.Name = "CB_WILAYANA"
        Me.CB_WILAYANA.Size = New System.Drawing.Size(350, 33)
        Me.CB_WILAYANA.TabIndex = 15
        '
        'CB_WILAYAN
        '
        Me.CB_WILAYAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_WILAYAN.FormattingEnabled = True
        Me.CB_WILAYAN.Location = New System.Drawing.Point(369, 724)
        Me.CB_WILAYAN.Name = "CB_WILAYAN"
        Me.CB_WILAYAN.Size = New System.Drawing.Size(350, 33)
        Me.CB_WILAYAN.TabIndex = 14
        '
        'CB_SEXE
        '
        Me.CB_SEXE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_SEXE.FormattingEnabled = True
        Me.CB_SEXE.Location = New System.Drawing.Point(369, 559)
        Me.CB_SEXE.Name = "CB_SEXE"
        Me.CB_SEXE.Size = New System.Drawing.Size(204, 33)
        Me.CB_SEXE.TabIndex = 13
        '
        'DTP_DATEN
        '
        Me.DTP_DATEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_DATEN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_DATEN.Location = New System.Drawing.Point(369, 504)
        Me.DTP_DATEN.Name = "DTP_DATEN"
        Me.DTP_DATEN.Size = New System.Drawing.Size(350, 30)
        Me.DTP_DATEN.TabIndex = 12
        '
        'TXT_NOM
        '
        Me.TXT_NOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOM.Location = New System.Drawing.Point(369, 284)
        Me.TXT_NOM.Name = "TXT_NOM"
        Me.TXT_NOM.Size = New System.Drawing.Size(350, 30)
        Me.TXT_NOM.TabIndex = 11
        '
        'TextBox11
        '
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(369, 339)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(350, 30)
        Me.TextBox11.TabIndex = 10
        '
        'TXT_NOMA
        '
        Me.TXT_NOMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOMA.Location = New System.Drawing.Point(369, 394)
        Me.TXT_NOMA.Name = "TXT_NOMA"
        Me.TXT_NOMA.Size = New System.Drawing.Size(350, 30)
        Me.TXT_NOMA.TabIndex = 9
        '
        'TXT_PRENOMA
        '
        Me.TXT_PRENOMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PRENOMA.Location = New System.Drawing.Point(369, 449)
        Me.TXT_PRENOMA.Name = "TXT_PRENOMA"
        Me.TXT_PRENOMA.Size = New System.Drawing.Size(350, 30)
        Me.TXT_PRENOMA.TabIndex = 8
        '
        'TXT_LIEUN
        '
        Me.TXT_LIEUN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_LIEUN.Location = New System.Drawing.Point(369, 614)
        Me.TXT_LIEUN.Name = "TXT_LIEUN"
        Me.TXT_LIEUN.Size = New System.Drawing.Size(350, 30)
        Me.TXT_LIEUN.TabIndex = 7
        '
        'TXT_LIEUNA
        '
        Me.TXT_LIEUNA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_LIEUNA.Location = New System.Drawing.Point(369, 669)
        Me.TXT_LIEUNA.Name = "TXT_LIEUNA"
        Me.TXT_LIEUNA.Size = New System.Drawing.Size(350, 30)
        Me.TXT_LIEUNA.TabIndex = 6
        '
        'TXT_ADR
        '
        Me.TXT_ADR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ADR.Location = New System.Drawing.Point(369, 834)
        Me.TXT_ADR.Name = "TXT_ADR"
        Me.TXT_ADR.Size = New System.Drawing.Size(350, 30)
        Me.TXT_ADR.TabIndex = 5
        '
        'TXT_VILLE
        '
        Me.TXT_VILLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_VILLE.Location = New System.Drawing.Point(369, 889)
        Me.TXT_VILLE.Name = "TXT_VILLE"
        Me.TXT_VILLE.Size = New System.Drawing.Size(350, 30)
        Me.TXT_VILLE.TabIndex = 4
        '
        'TXT_CODEPOS
        '
        Me.TXT_CODEPOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CODEPOS.Location = New System.Drawing.Point(369, 999)
        Me.TXT_CODEPOS.Name = "TXT_CODEPOS"
        Me.TXT_CODEPOS.Size = New System.Drawing.Size(350, 30)
        Me.TXT_CODEPOS.TabIndex = 3
        '
        'TXT_MOYBAC
        '
        Me.TXT_MOYBAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_MOYBAC.Location = New System.Drawing.Point(369, 1109)
        Me.TXT_MOYBAC.Name = "TXT_MOYBAC"
        Me.TXT_MOYBAC.Size = New System.Drawing.Size(350, 30)
        Me.TXT_MOYBAC.TabIndex = 2
        '
        'TXT_MATRICULB
        '
        Me.TXT_MATRICULB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_MATRICULB.Location = New System.Drawing.Point(369, 224)
        Me.TXT_MATRICULB.Name = "TXT_MATRICULB"
        Me.TXT_MATRICULB.Size = New System.Drawing.Size(350, 30)
        Me.TXT_MATRICULB.TabIndex = 1
        '
        'TXT_MATRICUL
        '
        Me.TXT_MATRICUL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_MATRICUL.Location = New System.Drawing.Point(369, 169)
        Me.TXT_MATRICUL.Name = "TXT_MATRICUL"
        Me.TXT_MATRICUL.Size = New System.Drawing.Size(350, 30)
        Me.TXT_MATRICUL.TabIndex = 0
        '
        'PN_BIENVENUE
        '
        Me.PN_BIENVENUE.BackColor = System.Drawing.Color.Transparent
        Me.PN_BIENVENUE.Controls.Add(Me.Label8)
        Me.PN_BIENVENUE.Controls.Add(Me.Label7)
        Me.PN_BIENVENUE.Controls.Add(Me.Label6)
        Me.PN_BIENVENUE.Controls.Add(Me.Label5)
        Me.PN_BIENVENUE.Controls.Add(Me.Label4)
        Me.PN_BIENVENUE.Controls.Add(Me.Label3)
        Me.PN_BIENVENUE.Controls.Add(Me.ShapeContainer1)
        Me.PN_BIENVENUE.Location = New System.Drawing.Point(95, 4)
        Me.PN_BIENVENUE.Name = "PN_BIENVENUE"
        Me.PN_BIENVENUE.Size = New System.Drawing.Size(937, 774)
        Me.PN_BIENVENUE.TabIndex = 11
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape3, Me.OvalShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(937, 774)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape3
        '
        Me.OvalShape3.BorderColor = System.Drawing.Color.Transparent
        Me.OvalShape3.FillColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.OvalShape3.FillGradientColor = System.Drawing.Color.Transparent
        Me.OvalShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape3.Location = New System.Drawing.Point(228, 487)
        Me.OvalShape3.Name = "OvalShape3"
        Me.OvalShape3.Size = New System.Drawing.Size(29, 26)
        '
        'OvalShape2
        '
        Me.OvalShape2.BorderColor = System.Drawing.Color.Transparent
        Me.OvalShape2.FillColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.OvalShape2.FillGradientColor = System.Drawing.Color.Transparent
        Me.OvalShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape2.Location = New System.Drawing.Point(75, 523)
        Me.OvalShape2.Name = "OvalShape2"
        Me.OvalShape2.Size = New System.Drawing.Size(125, 101)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(89, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 46)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Bienvenue a"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(68, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(804, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Un outil de gestion du cursus des anciens étudiants de l’ESI durant leur parcours" & _
            " universitaire,  "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(74, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(406, 46)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Esist Histroy Manager "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(68, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(645, 24)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "on sert a l’obtention de données sur l’historique individuel ou par promotion."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(78, 417)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(349, 24)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Nouveau en Esist History Manager ?"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(112, 455)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(483, 24)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "il existe un guide en ligne, vous pouvez le consulter *__*"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(244, 1319)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(313, 22)
        Me.Panel1.TabIndex = 42
        '
        'Home
        '
        Me.AcceptButton = Me.MenuButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background
        Me.CancelButton = Me.BT_LOGOUT
        Me.ClientSize = New System.Drawing.Size(1341, 850)
        Me.Controls.Add(Me.MenuButton)
        Me.Controls.Add(Me.SideBar)
        Me.Controls.Add(Me.NavBar)
        Me.Controls.Add(Me.logo_bleu)
        Me.Controls.Add(Me.ProfilePane)
        Me.Controls.Add(Me.PN_BIENVENUE)
        Me.Controls.Add(Me.PN_FORUMRECH)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximumSize = New System.Drawing.Size(1359, 897)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1359, 883)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.SideBar.ResumeLayout(False)
        Me.ProfilePane.ResumeLayout(False)
        Me.ProfilePane.PerformLayout()
        CType(Me.mode_photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBar.ResumeLayout(False)
        Me.NavBar.PerformLayout()
        CType(Me.logo_bleu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PN_FORUMRECH.ResumeLayout(False)
        Me.PN_FORUMRECH.PerformLayout()
        Me.PN_BIENVENUE.ResumeLayout(False)
        Me.PN_BIENVENUE.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SideBar As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ProfilePane As System.Windows.Forms.Panel
    Friend WithEvents BT_PV As System.Windows.Forms.Button
    Friend WithEvents BT_RECH As System.Windows.Forms.Button
    Friend WithEvents BT_STAT As System.Windows.Forms.Button
    Friend WithEvents BT_CLASS As System.Windows.Forms.Button
    Friend WithEvents BT_LOGOUT As System.Windows.Forms.Button
    Friend WithEvents BT_modif_mdp As System.Windows.Forms.Button
    Friend WithEvents mode_photo As System.Windows.Forms.PictureBox
    Friend WithEvents NavBar As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LBL_MODE As System.Windows.Forms.Label
    Friend WithEvents RNButton As System.Windows.Forms.Button
    Friend WithEvents RNGButton As System.Windows.Forms.Button
    Friend WithEvents DetailButton As System.Windows.Forms.Button
    Friend WithEvents ModifButton As System.Windows.Forms.Button
    Friend WithEvents HelpButton As System.Windows.Forms.LinkLabel
    Friend WithEvents MenuButton As System.Windows.Forms.Button
    Friend WithEvents logo_bleu As System.Windows.Forms.PictureBox
    Friend WithEvents HistoryButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ClassIconsList As System.Windows.Forms.ImageList
    Friend WithEvents StaticIconsList As System.Windows.Forms.ImageList
    Friend WithEvents SearchIconsList As System.Windows.Forms.ImageList
    Friend WithEvents PVIconsList As System.Windows.Forms.ImageList
    Friend WithEvents PN_FORUMRECH As System.Windows.Forms.Panel
    Friend WithEvents TXT_MATRICULB As System.Windows.Forms.TextBox
    Friend WithEvents TXT_MATRICUL As System.Windows.Forms.TextBox
    Friend WithEvents LB_MATRICUL As System.Windows.Forms.Label
    Friend WithEvents CB_WILAYAB As System.Windows.Forms.ComboBox
    Friend WithEvents CB_ANNEEB As System.Windows.Forms.ComboBox
    Friend WithEvents CB_SERI As System.Windows.Forms.ComboBox
    Friend WithEvents CB_WILAYA As System.Windows.Forms.ComboBox
    Friend WithEvents CB_WILAYANA As System.Windows.Forms.ComboBox
    Friend WithEvents CB_WILAYAN As System.Windows.Forms.ComboBox
    Friend WithEvents CB_SEXE As System.Windows.Forms.ComboBox
    Friend WithEvents DTP_DATEN As System.Windows.Forms.DateTimePicker
    Friend WithEvents TXT_NOM As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TXT_NOMA As System.Windows.Forms.TextBox
    Friend WithEvents TXT_PRENOMA As System.Windows.Forms.TextBox
    Friend WithEvents TXT_LIEUN As System.Windows.Forms.TextBox
    Friend WithEvents TXT_LIEUNA As System.Windows.Forms.TextBox
    Friend WithEvents TXT_ADR As System.Windows.Forms.TextBox
    Friend WithEvents TXT_VILLE As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CODEPOS As System.Windows.Forms.TextBox
    Friend WithEvents TXT_MOYBAC As System.Windows.Forms.TextBox
    Friend WithEvents BT_LANCERRECH As System.Windows.Forms.Button
    Friend WithEvents LB_SERI As System.Windows.Forms.Label
    Friend WithEvents LB_WILAYAB As System.Windows.Forms.Label
    Friend WithEvents LB_CODEPOS As System.Windows.Forms.Label
    Friend WithEvents LB_MOYBAC As System.Windows.Forms.Label
    Friend WithEvents LB_ANNEEB As System.Windows.Forms.Label
    Friend WithEvents LB_WILAYA As System.Windows.Forms.Label
    Friend WithEvents LB_NOM As System.Windows.Forms.Label
    Friend WithEvents LB_NOMA As System.Windows.Forms.Label
    Friend WithEvents LB_PRENOMA As System.Windows.Forms.Label
    Friend WithEvents LB_SEXE As System.Windows.Forms.Label
    Friend WithEvents LB_LIEUNA As System.Windows.Forms.Label
    Friend WithEvents LB_LIEUN As System.Windows.Forms.Label
    Friend WithEvents LB_PRENOM As System.Windows.Forms.Label
    Friend WithEvents LB_WILAYANA As System.Windows.Forms.Label
    Friend WithEvents LB_DATEN As System.Windows.Forms.Label
    Friend WithEvents LB_WILAYAN As System.Windows.Forms.Label
    Friend WithEvents LB_VILLE As System.Windows.Forms.Label
    Friend WithEvents LB_ADR As System.Windows.Forms.Label
    Friend WithEvents LB_MATRICULB As System.Windows.Forms.Label
    Friend WithEvents BT_CANCELRECH As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PN_BIENVENUE As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents OvalShape3 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape2 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
