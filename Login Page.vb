Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim id As String, p As String
        id = Textuser.Text
        p = Textpass.Text
        If (id = "user" And p = "pass") Then
            Modules.show()
            Me.Hide()
        Else
            MsgBox("your id and password is incorrect.please try again.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Textuser.Text = ""
        Textpass.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()

    End Sub
End Class
