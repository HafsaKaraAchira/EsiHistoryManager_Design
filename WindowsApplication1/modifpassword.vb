Public Class modifpassword

    ' a function to show the responce to the connexion request ( launch the home page or the error message )
    Private Sub Changer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles changer.Click
        If Connexion(Me.TXT_Password.Text) = False Or Me.TXT_PasswordN.Text <> Me.TXT_PasswordNC.Text Or TXT_PasswordN.Text = "" Then

            If Connexion(Me.TXT_Password.Text) = False Then
                Me.avertissemnt.Text = "Mot de passe errone ! ressayez a nouveau "
                Me.avertissemnt.Visible = True

            ElseIf (Me.TXT_PasswordN.Text <> Me.TXT_PasswordNC.Text Or TXT_PasswordN.Text = "") Then
                Me.avertissemnt.Visible = True
                Me.avertissemnt.Text = "Vous devez entrer le meme mot de passe deux fois pour que vous la confirmer "
            End If

        Else

            If AgentButton.Checked Then
                Login._agent_mdp = TXT_PasswordN.Text

            Else
                Login._admin_mdp = TXT_PasswordN.Text
            End If
            Me.Close()
        End If
    End Sub

    Function Connexion(ByVal mdp As String) As Boolean ' fnction that return the responce to the password according to the mode of connexion
        Dim correct As Boolean = False
        If AgentButton.Checked Then
            If mdp = "agent" Then
                correct = True
            End If
        End If

        If AdminButton.Checked Then
            If mdp = "admin" Then
                correct = True
            End If
        End If
        Return correct
    End Function

    ' handle the appearnace when focusing on the password inputs
    Private Sub TXT_Password_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_Password.GotFocus, TXT_Password.TextChanged, TXT_Password.Click
        Me.avertissemnt.Visible = False
    End Sub
    Private Sub TXT_PasswordN_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_PasswordN.GotFocus, TXT_PasswordN.TextChanged, TXT_PasswordN.Click
        Me.avertissemnt.Visible = False
    End Sub
    Private Sub TXT_PasswordNC_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_PasswordNC.GotFocus, TXT_PasswordNC.TextChanged, TXT_PasswordNC.Click
        Me.avertissemnt.Visible = False
    End Sub

    'a function that determine the mode of connexion
    Private Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AgentButton.CheckedChanged

        If AgentButton.Checked Then
            Me.profile_photo_login.Image = My.Resources.user_profile
            AgentButton.ForeColor = Color.Pink
            AgentButton.Image = My.Resources.Rectangle_rose

            AdminButton.ForeColor = Color.LavenderBlush                     ' change the appearance of the two radioButton according to the user' selection
            AdminButton.Image = My.Resources.Rectangle_blanc

        ElseIf AdminButton.Checked Then
            Me.profile_photo_login.Image = My.Resources.administrator_profile

            AdminButton.ForeColor = Color.Pink
            AdminButton.Image = My.Resources.Rectangle_rose

            AgentButton.ForeColor = Color.LavenderBlush
            AgentButton.Image = My.Resources.Rectangle_blanc
        End If
    End Sub


    Private Sub modifpassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(1024, 678)
        Me.MinimumSize = New System.Drawing.Size(1023, 595)
        Me.MaximumSize = New System.Drawing.Size(1025, 950)
        AgentButton.Checked = True
    End Sub

End Class