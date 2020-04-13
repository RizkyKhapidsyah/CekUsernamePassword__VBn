Public Class FormUtama
    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .LabelUsername.Text = "User Name"
            .LabelPassword.Text = "Password"
            .ltd1.Text = ":"
            .ltd2.Text = ":"
            .TextBoxUsername.Text = ""
            .TextBoxPassword.Text = ""
            .TextBoxPassword.PasswordChar = "*"
            .ButtonLogin.Text = "Login"
        End With
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim Username, Password As String
        Username = TextBoxUsername.Text
        Password = TextBoxPassword.Text

        If Username = "rizkykhapidsyah" And Password = "12345" Then
            MsgBox("Anda Mendapatkan Hak Akses")
        Else
            If Username = "" Then
                MsgBox("Silahkan Isi Username!")
            ElseIf Password = "" Then
                MsgBox("Silahkan Isi Password!")
            End If
        End If
    End Sub
End Class
