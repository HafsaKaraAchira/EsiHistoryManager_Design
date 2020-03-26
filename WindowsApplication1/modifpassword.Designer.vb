<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modifpassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modifpassword))
        Me.avertissemnt = New System.Windows.Forms.Label()
        Me.profile_photo_login = New System.Windows.Forms.PictureBox()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.ModeDeConnexionPanel = New System.Windows.Forms.Panel()
        Me.ConnecterLabel = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.TypeDeConnexion = New System.Windows.Forms.GroupBox()
        Me.AgentButton = New System.Windows.Forms.RadioButton()
        Me.AdminButton = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.changer = New System.Windows.Forms.Button()
        Me.TXT_PasswordNC = New System.Windows.Forms.TextBox()
        Me.TXT_PasswordN = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_Password = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.profile_photo_login, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ModeDeConnexionPanel.SuspendLayout()
        Me.TypeDeConnexion.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'avertissemnt
        '
        Me.avertissemnt.AutoSize = True
        Me.avertissemnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avertissemnt.ForeColor = System.Drawing.Color.Red
        Me.avertissemnt.Location = New System.Drawing.Point(409, 794)
        Me.avertissemnt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.avertissemnt.Name = "avertissemnt"
        Me.avertissemnt.Size = New System.Drawing.Size(423, 25)
        Me.avertissemnt.TabIndex = 10
        Me.avertissemnt.Text = "Mot de passe errone ! ressayez a nouveau"
        Me.avertissemnt.Visible = False
        '
        'profile_photo_login
        '
        Me.profile_photo_login.BackColor = System.Drawing.Color.Gainsboro
        Me.profile_photo_login.Image = CType(resources.GetObject("profile_photo_login.Image"), System.Drawing.Image)
        Me.profile_photo_login.Location = New System.Drawing.Point(1063, 294)
        Me.profile_photo_login.Margin = New System.Windows.Forms.Padding(4)
        Me.profile_photo_login.Name = "profile_photo_login"
        Me.profile_photo_login.Size = New System.Drawing.Size(241, 245)
        Me.profile_photo_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.profile_photo_login.TabIndex = 8
        Me.profile_photo_login.TabStop = False
        '
        'logo
        '
        Me.logo.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.logo
        Me.logo.Location = New System.Drawing.Point(414, 22)
        Me.logo.Margin = New System.Windows.Forms.Padding(4)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(483, 250)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 7
        Me.logo.TabStop = False
        '
        'ModeDeConnexionPanel
        '
        Me.ModeDeConnexionPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.ModeDeConnexionPanel.Controls.Add(Me.ConnecterLabel)
        Me.ModeDeConnexionPanel.Controls.Add(Me.ShapeContainer1)
        Me.ModeDeConnexionPanel.Controls.Add(Me.TypeDeConnexion)
        Me.ModeDeConnexionPanel.ForeColor = System.Drawing.Color.DarkBlue
        Me.ModeDeConnexionPanel.Location = New System.Drawing.Point(53, -12)
        Me.ModeDeConnexionPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ModeDeConnexionPanel.Name = "ModeDeConnexionPanel"
        Me.ModeDeConnexionPanel.Size = New System.Drawing.Size(296, 896)
        Me.ModeDeConnexionPanel.TabIndex = 6
        '
        'ConnecterLabel
        '
        Me.ConnecterLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConnecterLabel.BackColor = System.Drawing.Color.Transparent
        Me.ConnecterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConnecterLabel.ForeColor = System.Drawing.Color.Transparent
        Me.ConnecterLabel.Location = New System.Drawing.Point(0, 34)
        Me.ConnecterLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ConnecterLabel.Name = "ConnecterLabel"
        Me.ConnecterLabel.Size = New System.Drawing.Size(296, 117)
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
        Me.ShapeContainer1.Size = New System.Drawing.Size(296, 896)
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
        Me.LineShape2.X1 = 224
        Me.LineShape2.X2 = 294
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
        Me.TypeDeConnexion.Location = New System.Drawing.Point(0, 160)
        Me.TypeDeConnexion.Margin = New System.Windows.Forms.Padding(4)
        Me.TypeDeConnexion.Name = "TypeDeConnexion"
        Me.TypeDeConnexion.Padding = New System.Windows.Forms.Padding(4)
        Me.TypeDeConnexion.Size = New System.Drawing.Size(296, 736)
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
        Me.AgentButton.Location = New System.Drawing.Point(4, 134)
        Me.AgentButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AgentButton.Name = "AgentButton"
        Me.AgentButton.Size = New System.Drawing.Size(288, 118)
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
        Me.AdminButton.Location = New System.Drawing.Point(4, 287)
        Me.AdminButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AdminButton.Name = "AdminButton"
        Me.AdminButton.Size = New System.Drawing.Size(288, 119)
        Me.AdminButton.TabIndex = 11
        Me.AdminButton.Text = "Agent Administratif"
        Me.AdminButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AdminButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.changer)
        Me.Panel1.Controls.Add(Me.TXT_PasswordNC)
        Me.Panel1.Controls.Add(Me.TXT_PasswordN)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TXT_Password)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(356, 294)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(641, 480)
        Me.Panel1.TabIndex = 11
        '
        'changer
        '
        Me.changer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.changer.FlatAppearance.BorderSize = 0
        Me.changer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.changer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.changer.Location = New System.Drawing.Point(183, 394)
        Me.changer.Name = "changer"
        Me.changer.Size = New System.Drawing.Size(233, 47)
        Me.changer.TabIndex = 9
        Me.changer.Text = "Changer"
        Me.changer.UseVisualStyleBackColor = False
        '
        'TXT_PasswordNC
        '
        Me.TXT_PasswordNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PasswordNC.Location = New System.Drawing.Point(336, 320)
        Me.TXT_PasswordNC.Name = "TXT_PasswordNC"
        Me.TXT_PasswordNC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_PasswordNC.Size = New System.Drawing.Size(300, 34)
        Me.TXT_PasswordNC.TabIndex = 8
        '
        'TXT_PasswordN
        '
        Me.TXT_PasswordN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PasswordN.Location = New System.Drawing.Point(336, 250)
        Me.TXT_PasswordN.Name = "TXT_PasswordN"
        Me.TXT_PasswordN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_PasswordN.Size = New System.Drawing.Size(300, 34)
        Me.TXT_PasswordN.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(309, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Confirmer le nouveau mot de passe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(205, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nouveau mot de passe"
        '
        'TXT_Password
        '
        Me.TXT_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Password.Location = New System.Drawing.Point(336, 150)
        Me.TXT_Password.Name = "TXT_Password"
        Me.TXT_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_Password.Size = New System.Drawing.Size(300, 34)
        Me.TXT_Password.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(109, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(407, 44)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Changer le mot de passe"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mot de passe actuel"
        '
        'modifpassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1357, 873)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.avertissemnt)
        Me.Controls.Add(Me.profile_photo_login)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.ModeDeConnexionPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1363, 937)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1363, 885)
        Me.Name = "modifpassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "modifpassword"
        CType(Me.profile_photo_login, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ModeDeConnexionPanel.ResumeLayout(False)
        Me.TypeDeConnexion.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents avertissemnt As System.Windows.Forms.Label
    Friend WithEvents profile_photo_login As System.Windows.Forms.PictureBox
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents ModeDeConnexionPanel As System.Windows.Forms.Panel
    Friend WithEvents ConnecterLabel As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents TypeDeConnexion As System.Windows.Forms.GroupBox
    Friend WithEvents AgentButton As System.Windows.Forms.RadioButton
    Friend WithEvents AdminButton As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXT_Password As System.Windows.Forms.TextBox
    Friend WithEvents TXT_PasswordNC As System.Windows.Forms.TextBox
    Friend WithEvents TXT_PasswordN As System.Windows.Forms.TextBox
    Friend WithEvents changer As System.Windows.Forms.Button
End Class
