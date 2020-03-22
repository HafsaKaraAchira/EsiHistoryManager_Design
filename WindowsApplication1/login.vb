Public Class Login

    Public Const _agent_mdp As String = "agent"
    Public Const _admin_mdp As String = "admin"

    Function Connexion(ByVal mdp As String) As Boolean
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



    Private Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AgentButton.CheckedChanged
        If AgentButton.Checked Then
            Me.profile_photo_login.Image = My.Resources.user_profile
            AgentButton.ForeColor = Color.Pink
            AgentButton.Image = My.Resources.Rectangle_rose

            AdminButton.ForeColor = Color.LavenderBlush
            AdminButton.Image = My.Resources.Rectangle_blanc

        ElseIf AdminButton.Checked Then
            Me.profile_photo_login.Image = My.Resources.administrator_profile

            AdminButton.ForeColor = Color.Pink
            AdminButton.Image = My.Resources.Rectangle_rose

            AgentButton.ForeColor = Color.LavenderBlush
            AgentButton.Image = My.Resources.Rectangle_blanc
        End If
    End Sub

    Private Sub ConexionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConexionButton.Click
        If Connexion(Me.MotDePasseTextField.Text) Then
            Home.Show()
        Else
            Me.avertissemnt.Visible = True
        End If

    End Sub

    Private Sub MotDePasseTextField_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MotDePasseTextField.GotFocus, MotDePasseTextField.TextChanged, MotDePasseTextField.Click
        Me.avertissemnt.Visible = False
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AgentButton.Checked = True

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ModeDeConnexionPanel.Paint

    End Sub
End Class
