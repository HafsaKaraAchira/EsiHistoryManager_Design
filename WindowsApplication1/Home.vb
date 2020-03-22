Public Class Home

    Public _ModeConnexion As Boolean = Login.AdminButton.Checked

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MenuButton.Location = New System.Drawing.Point(0, 0)

        SideBar.Width = 55
        SideBar.Enabled = False

        SideBar.Enabled = False
        NavBar.Width = 795
        NavBar.Location = New System.Drawing.Point(58, 639)

        If _ModeConnexion Then
            Me.mode_photo.Image = My.Resources.admin_mode
            BT_modif_mdp.Visible = True
            BT_modif_mdp.Enabled = True
            With LBL_MODE
                .Text = "Agent administarteur"
                .TextAlign = ContentAlignment.MiddleCenter
            End With

            With ModifButton
                .Visible = True
            End With

        End If

        Login.Close()

    End Sub

    Private Sub BT_LOGOUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_LOGOUT.Click
        Me.Close()
    End Sub


    Private Sub Home_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MsgBox("Voulez-vous quitter la session ?", MessageBoxButtons.YesNo, "Quitter la session")
        If (dialog = Windows.Forms.DialogResult.No) Then
            e.Cancel = True
        Else
            Login.Show()
        End If
    End Sub

    Private Sub MenuButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuButton.Click
        logo_bleu.Visible = Not logo_bleu.Visible
        SideBar.Enabled = True
        NavBar.Width = 666
        NavBar.Location = New System.Drawing.Point(188, 639)

        If logo_bleu.Visible Then
            SideBar.Width = 185
            NavBar.Width = 666
            NavBar.Location = New System.Drawing.Point(188, 639)
        Else
            SideBar.Width = 55
            NavBar.Width = 795
            NavBar.Location = New System.Drawing.Point(58, 639)
        End If
    End Sub


    Private Sub BT_CLASS_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BT_CLASS.MouseClick

        For Each b As Button In Me.SideBar.Controls
            b.BackColor = Color.FromArgb(255, 0, 64, 104)
            b.ForeColor = Color.LavenderBlush
            b.Font = New Font(b.Font, FontStyle.Regular)
            b.ImageIndex = 0
        Next

        With BT_CLASS
            .BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
            .ForeColor = Color.Black
            .Font = New Font(.Font, FontStyle.Bold)
            .ImageIndex = 1
        End With

        'With BT_CLASS
        '.BackColor = Color.FromArgb(255, 0, 64, 104)
        '.ForeColor = Color.LavenderBlush
        '.Font = New Font(.Font, FontStyle.Regular)
        '.Image = My.Resources.line_chart_bl
        'End With
        'With BT_STAT
        '.BackColor = Color.FromArgb(255, 0, 64, 104)
        '.ForeColor = Color.LavenderBlush
        '.Font = New Font(.Font, FontStyle.Regular)
        'End With
        'With BT_RECH
        '.BackColor = Color.FromArgb(255, 0, 64, 104)
        '.ForeColor = Color.LavenderBlush
        '.Font = New Font(.Font, FontStyle.Regular)
        'End With
        'With BT_PV
        '.BackColor = Color.FromArgb(255, 0, 64, 104)
        '.ForeColor = Color.LavenderBlush
        '.Font = New Font(.Font, FontStyle.Regular)
        'End With

    End Sub

    Private Sub BT_STAT_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BT_STAT.MouseClick

        For Each b As Button In Me.SideBar.Controls
            b.BackColor = Color.FromArgb(255, 0, 64, 104)
            b.ForeColor = Color.LavenderBlush
            b.Font = New Font(b.Font, FontStyle.Regular)
            b.ImageIndex = 0
        Next

        With BT_STAT
            .BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
            .ForeColor = Color.Black
            .Font = New Font(.Font, FontStyle.Bold)
            .ImageIndex = 1
        End With
    End Sub

    Private Sub BT_RECH_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BT_RECH.MouseClick
        For Each b As Button In Me.SideBar.Controls
            b.BackColor = Color.FromArgb(255, 0, 64, 104)
            b.ForeColor = Color.LavenderBlush
            b.Font = New Font(b.Font, FontStyle.Regular)
            b.ImageIndex = 0
        Next

        With BT_RECH
            .BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
            .ForeColor = Color.Black
            .Font = New Font(.Font, FontStyle.Bold)
            .ImageIndex = 1
        End With

    End Sub

    Private Sub BT_PV_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BT_PV.MouseClick

        For Each b As Button In Me.SideBar.Controls
            b.BackColor = Color.FromArgb(255, 0, 64, 104)
            b.ForeColor = Color.LavenderBlush
            b.Font = New Font(b.Font, FontStyle.Regular)
            b.ImageIndex = 0
        Next

        With BT_PV
            .BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
            .ForeColor = Color.Black
            .Font = New Font(.Font, FontStyle.Bold)
            .ImageIndex = 1
        End With

    End Sub

    Private Sub HelpButton_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles HelpButton.MouseHover
        HelpButton.BackColor = Color.Pink
    End Sub

    Private Sub HelpButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles HelpButton.MouseLeave
        HelpButton.BackColor = Color.Transparent
    End Sub
End Class
