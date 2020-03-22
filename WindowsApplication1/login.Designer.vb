<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.ConnexionPanel = New System.Windows.Forms.Panel()
        Me.ConexionButton = New System.Windows.Forms.Button()
        Me.MotDePasseTextField = New System.Windows.Forms.MaskedTextBox()
        Me.MDP_Label = New System.Windows.Forms.Label()
        Me.ModeDeConnexionPanel = New System.Windows.Forms.Panel()
        Me.ConnecterLabel = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.TypeDeConnexion = New System.Windows.Forms.GroupBox()
        Me.AgentButton = New System.Windows.Forms.RadioButton()
        Me.AdminButton = New System.Windows.Forms.RadioButton()
        Me.avertissemnt = New System.Windows.Forms.Label()
        Me.profile_photo_login = New System.Windows.Forms.PictureBox()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.bagrd_ellipse = New System.Windows.Forms.PictureBox()
        Me.ConnexionPanel.SuspendLayout()
        Me.ModeDeConnexionPanel.SuspendLayout()
        Me.TypeDeConnexion.SuspendLayout()
        CType(Me.profile_photo_login, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bagrd_ellipse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConnexionPanel
        '
        Me.ConnexionPanel.Controls.Add(Me.ConexionButton)
        Me.ConnexionPanel.Controls.Add(Me.MotDePasseTextField)
        Me.ConnexionPanel.Controls.Add(Me.MDP_Label)
        Me.ConnexionPanel.Location = New System.Drawing.Point(301, 342)
        Me.ConnexionPanel.Name = "ConnexionPanel"
        Me.ConnexionPanel.Size = New System.Drawing.Size(384, 209)
        Me.ConnexionPanel.TabIndex = 4
        '
        'ConexionButton
        '
        Me.ConexionButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.ConexionButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ConexionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.ConexionButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack
        Me.ConexionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConexionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConexionButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ConexionButton.Location = New System.Drawing.Point(3, 142)
        Me.ConexionButton.Name = "ConexionButton"
        Me.ConexionButton.Size = New System.Drawing.Size(341, 55)
        Me.ConexionButton.TabIndex = 2
        Me.ConexionButton.Text = "Connecter"
        Me.ConexionButton.UseVisualStyleBackColor = False
        '
        'MotDePasseTextField
        '
        Me.MotDePasseTextField.BeepOnError = True
        Me.MotDePasseTextField.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MotDePasseTextField.Location = New System.Drawing.Point(6, 78)
        Me.MotDePasseTextField.Name = "MotDePasseTextField"
        Me.MotDePasseTextField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.MotDePasseTextField.Size = New System.Drawing.Size(338, 38)
        Me.MotDePasseTextField.TabIndex = 1
        Me.MotDePasseTextField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MotDePasseTextField.UseSystemPasswordChar = True
        '
        'MDP_Label
        '
        Me.MDP_Label.CausesValidation = False
        Me.MDP_Label.Dock = System.Windows.Forms.DockStyle.Top
        Me.MDP_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MDP_Label.Location = New System.Drawing.Point(0, 0)
        Me.MDP_Label.Margin = New System.Windows.Forms.Padding(3)
        Me.MDP_Label.Name = "MDP_Label"
        Me.MDP_Label.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.MDP_Label.Size = New System.Drawing.Size(384, 51)
        Me.MDP_Label.TabIndex = 0
        Me.MDP_Label.Text = "Mot de passe"
        Me.MDP_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ModeDeConnexionPanel
        '
        Me.ModeDeConnexionPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.ModeDeConnexionPanel.Controls.Add(Me.ConnecterLabel)
        Me.ModeDeConnexionPanel.Controls.Add(Me.ShapeContainer1)
        Me.ModeDeConnexionPanel.Controls.Add(Me.TypeDeConnexion)
        Me.ModeDeConnexionPanel.ForeColor = System.Drawing.Color.DarkBlue
        Me.ModeDeConnexionPanel.Location = New System.Drawing.Point(30, 0)
        Me.ModeDeConnexionPanel.Name = "ModeDeConnexionPanel"
        Me.ModeDeConnexionPanel.Size = New System.Drawing.Size(222, 728)
        Me.ModeDeConnexionPanel.TabIndex = 0
        '
        'ConnecterLabel
        '
        Me.ConnecterLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConnecterLabel.BackColor = System.Drawing.Color.Transparent
        Me.ConnecterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConnecterLabel.ForeColor = System.Drawing.Color.Transparent
        Me.ConnecterLabel.Location = New System.Drawing.Point(0, 28)
        Me.ConnecterLabel.Name = "ConnecterLabel"
        Me.ConnecterLabel.Size = New System.Drawing.Size(222, 95)
        Me.ConnecterLabel.TabIndex = 0
        Me.ConnecterLabel.Text = "Connecter en tant que"
        Me.ConnecterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(222, 728)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.LineShape2.BorderWidth = 4
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.SelectionColor = System.Drawing.SystemColors.ControlLightLight
        Me.LineShape2.X1 = 150
        Me.LineShape2.X2 = 220
        Me.LineShape2.Y1 = 130
        Me.LineShape2.Y2 = 130
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.LineShape1.BorderWidth = 4
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.SelectionColor = System.Drawing.SystemColors.ControlLightLight
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 70
        Me.LineShape1.Y1 = 130
        Me.LineShape1.Y2 = 130
        '
        'TypeDeConnexion
        '
        Me.TypeDeConnexion.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.TypeDeConnexion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.TypeDeConnexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TypeDeConnexion.Controls.Add(Me.AgentButton)
        Me.TypeDeConnexion.Controls.Add(Me.AdminButton)
        Me.TypeDeConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TypeDeConnexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 0.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeDeConnexion.ForeColor = System.Drawing.Color.Transparent
        Me.TypeDeConnexion.Location = New System.Drawing.Point(0, 130)
        Me.TypeDeConnexion.Name = "TypeDeConnexion"
        Me.TypeDeConnexion.Size = New System.Drawing.Size(222, 598)
        Me.TypeDeConnexion.TabIndex = 2
        Me.TypeDeConnexion.TabStop = False
        Me.TypeDeConnexion.Text = resources.GetString("TypeDeConnexion.Text")
        '
        'AgentButton
        '
        Me.AgentButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.AgentButton.BackColor = System.Drawing.Color.Transparent
        Me.AgentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.AgentButton.CheckAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AgentButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AgentButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.AgentButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.AgentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.AgentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.AgentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AgentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgentButton.ForeColor = System.Drawing.Color.Pink
        Me.AgentButton.Image = CType(resources.GetObject("AgentButton.Image"), System.Drawing.Image)
        Me.AgentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AgentButton.Location = New System.Drawing.Point(3, 109)
        Me.AgentButton.Name = "AgentButton"
        Me.AgentButton.Size = New System.Drawing.Size(216, 96)
        Me.AgentButton.TabIndex = 10
        Me.AgentButton.Text = "Agent"
        Me.AgentButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AgentButton.UseVisualStyleBackColor = False
        '
        'AdminButton
        '
        Me.AdminButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdminButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.AdminButton.BackColor = System.Drawing.Color.Transparent
        Me.AdminButton.CheckAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AdminButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AdminButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.AdminButton.FlatAppearance.BorderSize = 0
        Me.AdminButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.AdminButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.AdminButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdminButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminButton.ForeColor = System.Drawing.Color.LavenderBlush
        Me.AdminButton.Image = CType(resources.GetObject("AdminButton.Image"), System.Drawing.Image)
        Me.AdminButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AdminButton.Location = New System.Drawing.Point(3, 233)
        Me.AdminButton.Name = "AdminButton"
        Me.AdminButton.Size = New System.Drawing.Size(216, 97)
        Me.AdminButton.TabIndex = 11
        Me.AdminButton.Text = "Agent Administratif"
        Me.AdminButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AdminButton.UseVisualStyleBackColor = False
        '
        'avertissemnt
        '
        Me.avertissemnt.AutoSize = True
        Me.avertissemnt.Font = New System.Drawing.Font("Roboto Lt", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avertissemnt.ForeColor = System.Drawing.Color.LightCoral
        Me.avertissemnt.Location = New System.Drawing.Point(303, 595)
        Me.avertissemnt.Name = "avertissemnt"
        Me.avertissemnt.Size = New System.Drawing.Size(347, 19)
        Me.avertissemnt.TabIndex = 5
        Me.avertissemnt.Text = "Mot de passe errone ! ressayez a nouveau"
        Me.avertissemnt.Visible = False
        '
        'profile_photo_login
        '
        Me.profile_photo_login.BackColor = System.Drawing.Color.Gainsboro
        Me.profile_photo_login.Image = CType(resources.GetObject("profile_photo_login.Image"), System.Drawing.Image)
        Me.profile_photo_login.Location = New System.Drawing.Point(743, 249)
        Me.profile_photo_login.Name = "profile_photo_login"
        Me.profile_photo_login.Size = New System.Drawing.Size(225, 230)
        Me.profile_photo_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.profile_photo_login.TabIndex = 3
        Me.profile_photo_login.TabStop = False
        '
        'logo
        '
        Me.logo.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.logo
        Me.logo.Location = New System.Drawing.Point(301, 28)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(362, 203)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 1
        Me.logo.TabStop = False
        '
        'bagrd_ellipse
        '
        Me.bagrd_ellipse.Image = CType(resources.GetObject("bagrd_ellipse.Image"), System.Drawing.Image)
        Me.bagrd_ellipse.Location = New System.Drawing.Point(635, -333)
        Me.bagrd_ellipse.Name = "bagrd_ellipse"
        Me.bagrd_ellipse.Size = New System.Drawing.Size(1250, 1394)
        Me.bagrd_ellipse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bagrd_ellipse.TabIndex = 2
        Me.bagrd_ellipse.TabStop = False
        '
        'Login
        '
        Me.AcceptButton = Me.ConexionButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1018, 709)
        Me.Controls.Add(Me.avertissemnt)
        Me.Controls.Add(Me.ConnexionPanel)
        Me.Controls.Add(Me.profile_photo_login)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.ModeDeConnexionPanel)
        Me.Controls.Add(Me.bagrd_ellipse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1024, 726)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ConnexionPanel.ResumeLayout(False)
        Me.ConnexionPanel.PerformLayout()
        Me.ModeDeConnexionPanel.ResumeLayout(False)
        Me.TypeDeConnexion.ResumeLayout(False)
        CType(Me.profile_photo_login, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bagrd_ellipse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ModeDeConnexionPanel As System.Windows.Forms.Panel
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents bagrd_ellipse As System.Windows.Forms.PictureBox
    Friend WithEvents ConnecterLabel As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents profile_photo_login As System.Windows.Forms.PictureBox
    Friend WithEvents ConnexionPanel As System.Windows.Forms.Panel
    Friend WithEvents MDP_Label As System.Windows.Forms.Label
    Friend WithEvents MotDePasseTextField As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ConexionButton As System.Windows.Forms.Button
    Friend WithEvents TypeDeConnexion As System.Windows.Forms.GroupBox
    Friend WithEvents AgentButton As System.Windows.Forms.RadioButton
    Friend WithEvents AdminButton As System.Windows.Forms.RadioButton
    Friend WithEvents avertissemnt As System.Windows.Forms.Label

End Class
