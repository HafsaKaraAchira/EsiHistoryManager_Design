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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.SideBar = New System.Windows.Forms.TableLayoutPanel()
        Me.BT_CLASS = New System.Windows.Forms.Button()
        Me.BT_STAT = New System.Windows.Forms.Button()
        Me.BT_RECH = New System.Windows.Forms.Button()
        Me.BT_PV = New System.Windows.Forms.Button()
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.ProfilePane = New System.Windows.Forms.Panel()
        Me.BT_modif_mdp = New System.Windows.Forms.Button()
        Me.BT_LOGOUT = New System.Windows.Forms.Button()
        Me.mode_photo = New System.Windows.Forms.PictureBox()
        Me.LBL_MODE = New System.Windows.Forms.Label()
        Me.NavBar = New System.Windows.Forms.TableLayoutPanel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ModifButton = New System.Windows.Forms.Button()
        Me.BT_HELP = New System.Windows.Forms.LinkLabel()
        Me.logo_bleu = New System.Windows.Forms.PictureBox()
        Me.SideBar.SuspendLayout()
        Me.ProfilePane.SuspendLayout()
        CType(Me.mode_photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBar.SuspendLayout()
        CType(Me.logo_bleu, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SideBar.Location = New System.Drawing.Point(0, 90)
        Me.SideBar.Margin = New System.Windows.Forms.Padding(0)
        Me.SideBar.Name = "SideBar"
        Me.SideBar.RowCount = 6
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SideBar.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SideBar.Size = New System.Drawing.Size(215, 648)
        Me.SideBar.TabIndex = 8
        Me.SideBar.TabStop = True
        '
        'BT_CLASS
        '
        Me.BT_CLASS.Dock = System.Windows.Forms.DockStyle.Left
        Me.BT_CLASS.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.BT_CLASS.FlatAppearance.BorderSize = 0
        Me.BT_CLASS.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BT_CLASS.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BT_CLASS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_CLASS.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_CLASS.ForeColor = System.Drawing.SystemColors.Window
        Me.BT_CLASS.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources._006_line_chart_bj
        Me.BT_CLASS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_CLASS.Location = New System.Drawing.Point(2, 102)
        Me.BT_CLASS.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_CLASS.MinimumSize = New System.Drawing.Size(45, 49)
        Me.BT_CLASS.Name = "BT_CLASS"
        Me.BT_CLASS.Size = New System.Drawing.Size(213, 70)
        Me.BT_CLASS.TabIndex = 2
        Me.BT_CLASS.Text = "Classement"
        Me.BT_CLASS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_CLASS.UseVisualStyleBackColor = True
        '
        'BT_STAT
        '
        Me.BT_STAT.Dock = System.Windows.Forms.DockStyle.Left
        Me.BT_STAT.FlatAppearance.BorderSize = 0
        Me.BT_STAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_STAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_STAT.ForeColor = System.Drawing.SystemColors.Window
        Me.BT_STAT.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources._099_diagram_bej
        Me.BT_STAT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_STAT.Location = New System.Drawing.Point(2, 176)
        Me.BT_STAT.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_STAT.MinimumSize = New System.Drawing.Size(45, 49)
        Me.BT_STAT.Name = "BT_STAT"
        Me.BT_STAT.Size = New System.Drawing.Size(213, 64)
        Me.BT_STAT.TabIndex = 3
        Me.BT_STAT.Text = "Statistiques"
        Me.BT_STAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_STAT.UseVisualStyleBackColor = True
        '
        'BT_RECH
        '
        Me.BT_RECH.FlatAppearance.BorderSize = 0
        Me.BT_RECH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_RECH.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_RECH.ForeColor = System.Drawing.SystemColors.Window
        Me.BT_RECH.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources._014_search_bej
        Me.BT_RECH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_RECH.Location = New System.Drawing.Point(2, 244)
        Me.BT_RECH.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_RECH.MinimumSize = New System.Drawing.Size(45, 49)
        Me.BT_RECH.Name = "BT_RECH"
        Me.BT_RECH.Size = New System.Drawing.Size(213, 67)
        Me.BT_RECH.TabIndex = 4
        Me.BT_RECH.Text = "Recherche"
        Me.BT_RECH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BT_RECH.UseVisualStyleBackColor = True
        '
        'BT_PV
        '
        Me.BT_PV.FlatAppearance.BorderSize = 0
        Me.BT_PV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_PV.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_PV.ForeColor = System.Drawing.SystemColors.Window
        Me.BT_PV.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources._002_gantt_chart1
        Me.BT_PV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_PV.Location = New System.Drawing.Point(2, 315)
        Me.BT_PV.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_PV.MinimumSize = New System.Drawing.Size(45, 49)
        Me.BT_PV.Name = "BT_PV"
        Me.BT_PV.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.BT_PV.Size = New System.Drawing.Size(213, 64)
        Me.BT_PV.TabIndex = 5
        Me.BT_PV.Text = "           PV"
        Me.BT_PV.UseVisualStyleBackColor = True
        '
        'MenuButton
        '
        Me.MenuButton.AutoSize = True
        Me.MenuButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.MenuButton.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.menu
        Me.MenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.MenuButton.FlatAppearance.BorderSize = 2
        Me.MenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.MenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuButton.ForeColor = System.Drawing.Color.Transparent
        Me.MenuButton.Location = New System.Drawing.Point(0, 0)
        Me.MenuButton.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuButton.MinimumSize = New System.Drawing.Size(45, 49)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(75, 90)
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
        Me.ProfilePane.Location = New System.Drawing.Point(878, 0)
        Me.ProfilePane.Margin = New System.Windows.Forms.Padding(2)
        Me.ProfilePane.Name = "ProfilePane"
        Me.ProfilePane.Size = New System.Drawing.Size(146, 738)
        Me.ProfilePane.TabIndex = 1
        '
        'BT_modif_mdp
        '
        Me.BT_modif_mdp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BT_modif_mdp.AutoSize = True
        Me.BT_modif_mdp.BackColor = System.Drawing.Color.Transparent
        Me.BT_modif_mdp.Enabled = False
        Me.BT_modif_mdp.FlatAppearance.BorderSize = 0
        Me.BT_modif_mdp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BT_modif_mdp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BT_modif_mdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_modif_mdp.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.gear__1_
        Me.BT_modif_mdp.Location = New System.Drawing.Point(110, 211)
        Me.BT_modif_mdp.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_modif_mdp.Name = "BT_modif_mdp"
        Me.BT_modif_mdp.Size = New System.Drawing.Size(30, 30)
        Me.BT_modif_mdp.TabIndex = 0
        Me.BT_modif_mdp.UseVisualStyleBackColor = False
        Me.BT_modif_mdp.Visible = False
        '
        'BT_LOGOUT
        '
        Me.BT_LOGOUT.AutoSize = True
        Me.BT_LOGOUT.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.BT_LOGOUT.FlatAppearance.BorderSize = 0
        Me.BT_LOGOUT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BT_LOGOUT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.BT_LOGOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_LOGOUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_LOGOUT.ForeColor = System.Drawing.Color.White
        Me.BT_LOGOUT.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.exit5
        Me.BT_LOGOUT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BT_LOGOUT.Location = New System.Drawing.Point(12, 461)
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
        Me.mode_photo.Location = New System.Drawing.Point(13, 90)
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
        Me.LBL_MODE.Location = New System.Drawing.Point(2, 229)
        Me.LBL_MODE.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_MODE.Name = "LBL_MODE"
        Me.LBL_MODE.Size = New System.Drawing.Size(142, 77)
        Me.LBL_MODE.TabIndex = 5
        Me.LBL_MODE.Text = "Agent"
        Me.LBL_MODE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NavBar
        '
        Me.NavBar.BackColor = System.Drawing.Color.Transparent
        Me.NavBar.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.Path
        Me.NavBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NavBar.ColumnCount = 6
        Me.NavBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.NavBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.NavBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.NavBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.NavBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.NavBar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.NavBar.Controls.Add(Me.Button3, 2, 0)
        Me.NavBar.Controls.Add(Me.Button4, 1, 0)
        Me.NavBar.Controls.Add(Me.Button1, 0, 0)
        Me.NavBar.Controls.Add(Me.ModifButton, 4, 0)
        Me.NavBar.Controls.Add(Me.BT_HELP, 5, 0)
        Me.NavBar.Location = New System.Drawing.Point(225, 676)
        Me.NavBar.Margin = New System.Windows.Forms.Padding(10)
        Me.NavBar.Name = "NavBar"
        Me.NavBar.RowCount = 1
        Me.NavBar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.NavBar.Size = New System.Drawing.Size(641, 60)
        Me.NavBar.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(194, 2)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.MinimumSize = New System.Drawing.Size(45, 49)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 56)
        Me.Button3.TabIndex = 6
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(98, 2)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.MinimumSize = New System.Drawing.Size(45, 49)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 56)
        Me.Button4.TabIndex = 5
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(19, 2)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.MinimumSize = New System.Drawing.Size(45, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 56)
        Me.Button1.TabIndex = 3
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ModifButton
        '
        Me.ModifButton.AutoSize = True
        Me.ModifButton.Enabled = False
        Me.ModifButton.FlatAppearance.BorderSize = 0
        Me.ModifButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ModifButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ModifButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModifButton.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.content
        Me.ModifButton.Location = New System.Drawing.Point(450, 2)
        Me.ModifButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ModifButton.MinimumSize = New System.Drawing.Size(45, 49)
        Me.ModifButton.Name = "ModifButton"
        Me.ModifButton.Size = New System.Drawing.Size(89, 56)
        Me.ModifButton.TabIndex = 8
        Me.ModifButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ModifButton.UseVisualStyleBackColor = True
        Me.ModifButton.Visible = False
        '
        'BT_HELP
        '
        Me.BT_HELP.ActiveLinkColor = System.Drawing.Color.Transparent
        Me.BT_HELP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BT_HELP.BackColor = System.Drawing.Color.Transparent
        Me.BT_HELP.DisabledLinkColor = System.Drawing.Color.Transparent
        Me.BT_HELP.ForeColor = System.Drawing.Color.Transparent
        Me.BT_HELP.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.info__4_
        Me.BT_HELP.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.BT_HELP.LinkColor = System.Drawing.Color.Pink
        Me.BT_HELP.Location = New System.Drawing.Point(547, 1)
        Me.BT_HELP.Name = "BT_HELP"
        Me.BT_HELP.Size = New System.Drawing.Size(67, 58)
        Me.BT_HELP.TabIndex = 4
        Me.BT_HELP.TabStop = True
        Me.BT_HELP.Text = "                                                                   "
        Me.BT_HELP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'logo_bleu
        '
        Me.logo_bleu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.logo_bleu.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.loGO_ART_BLEU
        Me.logo_bleu.Location = New System.Drawing.Point(75, 0)
        Me.logo_bleu.Name = "logo_bleu"
        Me.logo_bleu.Size = New System.Drawing.Size(140, 91)
        Me.logo_bleu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo_bleu.TabIndex = 9
        Me.logo_bleu.TabStop = False
        Me.logo_bleu.Visible = False
        '
        'Home
        '
        Me.AcceptButton = Me.MenuButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackgroundImage = Global.EsistHistoryManagement_v1.My.Resources.Resources.background
        Me.CancelButton = Me.BT_LOGOUT
        Me.ClientSize = New System.Drawing.Size(1024, 738)
        Me.Controls.Add(Me.MenuButton)
        Me.Controls.Add(Me.SideBar)
        Me.Controls.Add(Me.NavBar)
        Me.Controls.Add(Me.logo_bleu)
        Me.Controls.Add(Me.ProfilePane)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(1024, 738)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1024, 726)
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ModifButton As System.Windows.Forms.Button
    Friend WithEvents BT_HELP As System.Windows.Forms.LinkLabel
    Friend WithEvents MenuButton As System.Windows.Forms.Button
    Friend WithEvents logo_bleu As System.Windows.Forms.PictureBox

End Class
