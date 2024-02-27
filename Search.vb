Imports System.Data.SqlClient
Public Class Search

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WindowsApplication1\employ.mdf;Integrated Security=True;Connect Timeout=30")
        If (id.Text IsNot "") Then
            Dim cmd As New SqlCommand("select * from EMP_DETAILS WHERE EMP_ID = @empid", conn)
            cmd.Parameters.AddWithValue("@empid", id.Text)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            DataGridView1.Visible = True
        Else
            Dim cmd1 As New SqlCommand(" select * from EMP_DETAILS ", conn)
            Dim adapter As New SqlDataAdapter(cmd1)
            Dim table1 As New DataTable()
            adapter.Fill(table1)
            DataGridView1.DataSource = table1
            DataGridView1.Visible = True
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim conn As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WindowsApplication1\employ.mdf;Integrated Security=True;Connect Timeout=30")
        If (id.Text IsNot "") Then
            Dim cmd As New SqlCommand("select * from EMP_SALARY WHERE EMP_ID = @empid", conn)
            cmd.Parameters.AddWithValue("@empid", id.Text)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            DataGridView1.Visible = True
        Else
            Dim cmd1 As New SqlCommand(" select *from EMP_SALARY ", conn)
            Dim adapter As New SqlDataAdapter(cmd1)
            Dim table1 As New DataTable()
            adapter.Fill(table1)
            DataGridView1.DataSource = table1
            DataGridView1.Visible = True
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Modules.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
End Class