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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ConexionButton = New System.Windows.Forms.Button()
        Me.MotDePasseTextField = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.TypeDeConnexion = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.avertissemnt = New System.Windows.Forms.Label()
        Me.profile_photo_login = New System.Windows.Forms.PictureBox()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.bagrd_ellipse = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TypeDeConnexion.SuspendLayout()
        CType(Me.profile_photo_login, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bagrd_ellipse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ConexionButton)
        Me.Panel2.Controls.Add(Me.MotDePasseTextField)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(301, 342)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(384, 209)
        Me.Panel2.TabIndex = 4
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
        'Label2
        '
        Me.Label2.CausesValidation = False
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(384, 51)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mot de passe"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Controls.Add(Me.TypeDeConnexion)
        Me.Panel1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Location = New System.Drawing.Point(30, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(222, 728)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(0, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 95)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Connecter en tant que"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.TypeDeConnexion.Controls.Add(Me.RadioButton1)
        Me.TypeDeConnexion.Controls.Add(Me.RadioButton2)
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
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.RadioButton1.CheckAlign = System.Drawing.ContentAlignment.BottomRight
        Me.RadioButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.RadioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.RadioButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.RadioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.Pink
        Me.RadioButton1.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.Rectangle_rose
        Me.RadioButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadioButton1.Location = New System.Drawing.Point(3, 109)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(216, 96)
        Me.RadioButton1.TabIndex = 10
        Me.RadioButton1.Text = "Agent"
        Me.RadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.CheckAlign = System.Drawing.ContentAlignment.BottomRight
        Me.RadioButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.RadioButton2.FlatAppearance.BorderSize = 0
        Me.RadioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.RadioButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.RadioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.LavenderBlush
        Me.RadioButton2.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.Rectangle_blanc
        Me.RadioButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadioButton2.Location = New System.Drawing.Point(3, 233)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(216, 97)
        Me.RadioButton2.TabIndex = 11
        Me.RadioButton2.Text = "Agent Administratif"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton2.UseVisualStyleBackColor = False
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
        Me.logo.Image = Global.EsistHistoryManagement_v1.My.Resources.Resources.logo_art_name
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
        Me.ClientSize = New System.Drawing.Size(1018, 719)
        Me.Controls.Add(Me.avertissemnt)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.profile_photo_login)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bagrd_ellipse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1024, 726)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TypeDeConnexion.ResumeLayout(False)
        CType(Me.profile_photo_login, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bagrd_ellipse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents bagrd_ellipse As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents profile_photo_login As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MotDePasseTextField As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ConexionButton As System.Windows.Forms.Button
    Friend WithEvents TypeDeConnexion As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents avertissemnt As System.Windows.Forms.Label

End Class
