Public Class Home

    Public _ModeConnexion As Boolean = Login.RadioButton2.Checked

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MenuButton.Location = New System.Drawing.Point(0, 0)
        SideBar.Width = 75
        SideBar.Enabled = False
        NavBar.Enabled = False


        If _ModeConnexion Then
            Me.mode_photo.Image = My.Resources.admin_mode
            BT_modif_mdp.Visible = True
            BT_modif_mdp.Enabled = True
            With LBL_MODE
                .Text = "Agent administarteur"
                .TextAlign = ContentAlignment.MiddleCenter
            End With

            With ModifButton
                .Enabled = True
                .Visible = True
            End With

        End If

        Login.Close()

    End Sub

    Private Sub BT_LOGOUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_LOGOUT.Click
        Me.Close()
    End Sub

    'Private Sub BT_HELP_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles BT_HELP.MouseHover
    '   BT_HELP.BackColor = Color.Pink
    'End Sub

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

        If logo_bleu.Visible Then
            SideBar.Width = 215
        Else : SideBar.Width = 75
        End If
    End Sub


    Private Sub BT_CLASS_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BT_CLASS.MouseClick
        BT_CLASS.BackColor = Color.FromKnownColor(KnownColor.MenuHighlight)
        BT_STAT.BackColor = Color.FromArgb(255, 0, 64, 104)
        BT_RECH.BackColor = Color.FromArgb(255, 0, 64, 104)
        BT_PV.BackColor = Color.FromArgb(255, 0, 64, 104)

    End Sub

    Private Sub BT_STAT_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BT_STAT.MouseClick
        BT_CLASS.BackColor = Color.FromArgb(255, 0, 64, 104)
        BT_STAT.BackColor = Color.FromKnownColor(KnownColor.MenuHighlight)
        BT_RECH.BackColor = Color.FromArgb(255, 0, 64, 104)
        BT_PV.BackColor = Color.FromArgb(255, 0, 64, 104)
    End Sub

    Private Sub BT_RECH_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BT_RECH.MouseClick
        BT_CLASS.BackColor = Color.FromArgb(255, 0, 64, 104)
        BT_STAT.BackColor = Color.FromArgb(255, 0, 64, 104)
        BT_RECH.BackColor = Color.FromKnownColor(KnownColor.MenuHighlight)
        BT_PV.BackColor = Color.FromArgb(255, 0, 64, 104)
    End Sub

    Private Sub BT_PV_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BT_PV.MouseClick
        BT_CLASS.BackColor = Color.FromArgb(255, 0, 64, 104)
        BT_STAT.BackColor = Color.FromArgb(255, 0, 64, 104)
        BT_RECH.BackColor = Color.FromArgb(255, 0, 64, 104)
        BT_PV.BackColor = Color.FromKnownColor(KnownColor.MenuHighlight)
    End Sub
End Class
