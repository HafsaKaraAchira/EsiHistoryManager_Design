Public Class Login

    Public _agent_mdp As String = "agent"
    Public _admin_mdp As String = "admin"     ' the two passwords

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

    ' a function to show the responce to the connexion request ( launch the home page or the error message )
    Private Sub ConexionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConexionButton.Click
        If Connexion(Me.MotDePasseTextField.Text) Then
            Home.Show()
        Else
            Me.avertissemnt.Visible = True
        End If

    End Sub

    ' handle the appearnace when focusing on the password input
    Private Sub MotDePasseTextField_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MotDePasseTextField.GotFocus, MotDePasseTextField.TextChanged, MotDePasseTextField.Click
        Me.avertissemnt.Visible = False
    End Sub
    ' initialize the mode of connexion to agent when entering the application 
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AgentButton.Checked = True

    End Sub
End Class
