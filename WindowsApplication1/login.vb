Public Class Login

    Public Const _agent_mdp As String = "agent"
    Public Const _admin_mdp As String = "admin"

    Function Connexion(ByVal mdp As String) As Boolean
        Dim correct As Boolean = False
        If RadioButton1.Checked Then
            If mdp = "agent" Then
                correct = True
            End If
        End If

        If RadioButton2.Checked Then
            If mdp = "admin" Then
                correct = True
            End If
        End If
        Return correct
    End Function



    Private Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Me.profile_photo_login.Image = My.Resources.user_profile
            RadioButton1.ForeColor = Color.Pink
            RadioButton1.Image = My.Resources.Rectangle_rose

            RadioButton2.ForeColor = Color.LavenderBlush
            RadioButton2.Image = My.Resources.Rectangle_blanc

        ElseIf RadioButton2.Checked Then
            Me.profile_photo_login.Image = My.Resources.administrator_profile

            RadioButton2.ForeColor = Color.Pink
            RadioButton2.Image = My.Resources.Rectangle_rose

            RadioButton1.ForeColor = Color.LavenderBlush
            RadioButton1.Image = My.Resources.Rectangle_blanc
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
        RadioButton1.Checked = True

    End Sub
End Class
