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
        Me.Help_Button = New System.Windows.Forms.LinkLabel()
        Me.logo_bleu = New System.Windows.Forms.PictureBox()
        Me.MainContainer = New System.Windows.Forms.Panel()
        Me.PN_BIENVENUE = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SideBar.SuspendLayout()
        Me.ProfilePane.SuspendLayout()
        CType(Me.mode_photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBar.SuspendLayout()
        CType(Me.logo_bleu, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SideBar.Location = New System.Drawing.Point(0, 117)
        Me.SideBar.Margin = New System.Windows.Forms.Padding(0)
        Me.SideBar.Name = "SideBar"
        Me.SideBar.RowCount = 6
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SideBar.Size = New System.Drawing.Size(185, 621)
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
        Me.BT_CLASS.Location = New System.Drawing.Point(2, 102)
        Me.BT_CLASS.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_CLASS.MinimumSize = New System.Drawing.Size(45, 49)
        Me.BT_CLASS.Name = "BT_CLASS"
        Me.BT_CLASS.Size = New System.Drawing.Size(179, 70)
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
        Me.BT_STAT.Location = New System.Drawing.Point(2, 176)
        Me.BT_STAT.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_STAT.MinimumSize = New System.Drawing.Size(45, 49)
        Me.BT_STAT.Name = "BT_STAT"
        Me.BT_STAT.Size = New System.Drawing.Size(179, 64)
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
        Me.BT_RECH.Location = New System.Drawing.Point(2, 244)
        Me.BT_RECH.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_RECH.MinimumSize = New System.Drawing.Size(45, 49)
        Me.BT_RECH.Name = "BT_RECH"
        Me.BT_RECH.Size = New System.Drawing.Size(179, 67)
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
        Me.BT_PV.Location = New System.Drawing.Point(2, 315)
        Me.BT_PV.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_PV.MinimumSize = New System.Drawing.Size(45, 49)
        Me.BT_PV.Name = "BT_PV"
        Me.BT_PV.Size = New System.Drawing.Size(179, 64)
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
        Me.MenuButton.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuButton.MinimumSize = New System.Drawing.Size(45, 49)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(55, 117)
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
        Me.ProfilePane.Location = New System.Drawing.Point(866, 0)
        Me.ProfilePane.Margin = New System.Windows.Forms.Padding(0)
        Me.ProfilePane.Name = "ProfilePane"
        Me.ProfilePane.Size = New System.Drawing.Size(151, 699)
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
        Me.BT_modif_mdp.Location = New System.Drawing.Point(114, 192)
        Me.BT_modif_mdp.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_modif_mdp.Name = "BT_modif_mdp"
        Me.BT_modif_mdp.Size = New System.Drawing.Size(30, 30)
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
        Me.BT_LOGOUT.Location = New System.Drawing.Point(14, 539)
        Me.BT_LOGOUT.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_LOGOUT.Name = "BT_LOGOUT"
        Me.BT_LOGOUT.Size = New System.Drawing.Size(122, 101)
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
        Me.mode_photo.Location = New System.Drawing.Point(15, 77)
        Me.mode_photo.Name = "mode_photo"
        Me.mode_photo.Size = New System.Drawing.Size(120, 138)
        Me.mode_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.mode_photo.TabIndex = 4
        Me.mode_photo.TabStop = False
        '
        'LBL_MODE
        '
        Me.LBL_MODE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_MODE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_MODE.ForeColor = System.Drawing.Color.White
        Me.LBL_MODE.Location = New System.Drawing.Point(1, 218)
        Me.LBL_MODE.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_MODE.Name = "LBL_MODE"
        Me.LBL_MODE.Size = New System.Drawing.Size(149, 79)
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
        Me.NavBar.Controls.Add(Me.Help_Button, 6, 0)
        Me.NavBar.Location = New System.Drawing.Point(185, 642)
        Me.NavBar.Margin = New System.Windows.Forms.Padding(15)
        Me.NavBar.Name = "NavBar"
        Me.NavBar.RowCount = 1
        Me.NavBar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.NavBar.Size = New System.Drawing.Size(680, 54)
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
        Me.PrintButton.Location = New System.Drawing.Point(347, 2)
        Me.PrintButton.Margin = New System.Windows.Forms.Padding(2)
        Me.PrintButton.MinimumSize = New System.Drawing.Size(45, 49)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(77, 50)
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
        Me.HistoryButton.Location = New System.Drawing.Point(266, 2)
        Me.HistoryButton.Margin = New System.Windows.Forms.Padding(2)
        Me.HistoryButton.MinimumSize = New System.Drawing.Size(45, 49)
        Me.HistoryButton.Name = "HistoryButton"
        Me.HistoryButton.Size = New System.Drawing.Size(77, 50)
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
        Me.DetailButton.Location = New System.Drawing.Point(185, 2)
        Me.DetailButton.Margin = New System.Windows.Forms.Padding(2)
        Me.DetailButton.MinimumSize = New System.Drawing.Size(45, 49)
        Me.DetailButton.Name = "DetailButton"
        Me.DetailButton.Size = New System.Drawing.Size(77, 50)
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
        Me.RNGButton.Location = New System.Drawing.Point(104, 2)
        Me.RNGButton.Margin = New System.Windows.Forms.Padding(2)
        Me.RNGButton.MinimumSize = New System.Drawing.Size(45, 49)
        Me.RNGButton.Name = "RNGButton"
        Me.RNGButton.Size = New System.Drawing.Size(77, 50)
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
        Me.ModifButton.Location = New System.Drawing.Point(428, 2)
        Me.ModifButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ModifButton.MinimumSize = New System.Drawing.Size(45, 49)
        Me.ModifButton.Name = "ModifButton"
        Me.ModifButton.Size = New System.Drawing.Size(77, 50)
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
        Me.RNButton.Location = New System.Drawing.Point(37, 2)
        Me.RNButton.Margin = New System.Windows.Forms.Padding(2)
        Me.RNButton.MinimumSize = New System.Drawing.Size(45, 49)
        Me.RNButton.Name = "RNButton"
        Me.RNButton.Size = New System.Drawing.Size(63, 50)
        Me.RNButton.TabIndex = 3
        Me.RNButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.RNButton.UseVisualStyleBackColor = True
        '
        'Help_Button
        '
        Me.Help_Button.ActiveLinkColor = System.Drawing.Color.Transparent
        Me.Help_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Help_Button.BackColor = System.Drawing.Color.Transparent
        Me.Help_Button.Cursor = System.Windows.Forms.Cursors.Help
        Me.Help_Button.DisabledLinkColor = System.Drawing.Color.Transparent
        Me.Help_Button.ForeColor = System.Drawing.Color.Transparent
        Me.Help_Button.Image = CType(resources.GetObject("Help_Button.Image"), System.Drawing.Image)
        Me.Help_Button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.Help_Button.LinkColor = System.Drawing.Color.Pink
        Me.Help_Button.Location = New System.Drawing.Point(565, 1)
        Me.Help_Button.Name = "Help_Button"
        Me.Help_Button.Size = New System.Drawing.Size(56, 52)
        Me.Help_Button.TabIndex = 4
        Me.Help_Button.TabStop = True
        Me.Help_Button.Text = "                                                                   "
        Me.Help_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Help_Button.VisitedLinkColor = System.Drawing.Color.Teal
        '
        'logo_bleu
        '
        Me.logo_bleu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.logo_bleu.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.logo_white
        Me.logo_bleu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.logo_bleu.Location = New System.Drawing.Point(54, 0)
        Me.logo_bleu.Name = "logo_bleu"
        Me.logo_bleu.Size = New System.Drawing.Size(131, 118)
        Me.logo_bleu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo_bleu.TabIndex = 9
        Me.logo_bleu.TabStop = False
        Me.logo_bleu.Visible = False
        '
        'MainContainer
        '
        Me.MainContainer.BackColor = System.Drawing.Color.Transparent
        Me.MainContainer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainContainer.Location = New System.Drawing.Point(185, 1)
        Me.MainContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.MainContainer.Name = "MainContainer"
        Me.MainContainer.Size = New System.Drawing.Size(680, 640)
        Me.MainContainer.TabIndex = 10
        Me.MainContainer.Visible = False
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
        Me.PN_BIENVENUE.Location = New System.Drawing.Point(71, 3)
        Me.PN_BIENVENUE.Margin = New System.Windows.Forms.Padding(2)
        Me.PN_BIENVENUE.Name = "PN_BIENVENUE"
        Me.PN_BIENVENUE.Size = New System.Drawing.Size(703, 629)
        Me.PN_BIENVENUE.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(84, 370)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(373, 18)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "il existe un guide en ligne, vous pouvez le consulter *__*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(58, 339)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(283, 18)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Nouveau en Esist History Manager ?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 275)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(502, 18)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "on sert a l’obtention de données sur l’historique individuel ou par promotion."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(56, 155)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(318, 36)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Esist History Manager "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 251)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(628, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Un outil de gestion du cursus des anciens étudiants de l’ESI durant leur parcours" & _
            " universitaire,  "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(67, 117)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 36)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Bienvenue a"
        '
        'Home
        '
        Me.AcceptButton = Me.MenuButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CancelButton = Me.BT_LOGOUT
        Me.ClientSize = New System.Drawing.Size(1017, 699)
        Me.Controls.Add(Me.MenuButton)
        Me.Controls.Add(Me.SideBar)
        Me.Controls.Add(Me.NavBar)
        Me.Controls.Add(Me.logo_bleu)
        Me.Controls.Add(Me.ProfilePane)
        Me.Controls.Add(Me.PN_BIENVENUE)
        Me.Controls.Add(Me.MainContainer)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(1023, 950)
        Me.MinimumSize = New System.Drawing.Size(1023, 700)
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
    Friend WithEvents Help_Button As System.Windows.Forms.LinkLabel
    Friend WithEvents MenuButton As System.Windows.Forms.Button
    Friend WithEvents logo_bleu As System.Windows.Forms.PictureBox
    Friend WithEvents HistoryButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ClassIconsList As System.Windows.Forms.ImageList
    Friend WithEvents StaticIconsList As System.Windows.Forms.ImageList
    Friend WithEvents SearchIconsList As System.Windows.Forms.ImageList
    Friend WithEvents PVIconsList As System.Windows.Forms.ImageList
    Friend WithEvents MainContainer As System.Windows.Forms.Panel
    Friend WithEvents PN_BIENVENUE As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
