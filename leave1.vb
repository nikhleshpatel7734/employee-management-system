Imports System.Data.SqlClient
Public Class leave1
    Dim connectionstring As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WindowsApplication1\employ.mdf;Integrated Security=True;Connect Timeout=30"
    Dim connection As New SqlConnection(connectionstring)
    Sub view()
        connection.Open()
        Dim adp As New SqlDataAdapter("select * from LEAVE", connection)
        Dim ds As New DataSet
        adp.Fill(ds, "dd")
        DataGridView1.DataSource = ds.Tables("dd")
        connection.Close()


    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployDataSet2.LEAVE' table. You can move, or remove it, as needed.
        Me.LEAVETableAdapter.Fill(Me.EmployDataSet2.LEAVE)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            connection.Open()
            Dim insertstatement As String = "insert into LEAVE(emp_id,leavetype,todate,fromdate,daysofleave,status,shifttime,description)values(@emp_id,@leavetype,@todate,@fromdate,@daysofleave,@status,@shifttime,@description)"
            Dim insertcommand As New SqlCommand(insertstatement, connection)
            insertcommand.Parameters.AddWithValue("@emp_id", emid.Text)
            insertcommand.Parameters.AddWithValue("@leavetype", lt.Text)
            insertcommand.Parameters.AddWithValue("@todate", td.Text)
            insertcommand.Parameters.AddWithValue("@fromdate", fd.Text)
            insertcommand.Parameters.AddWithValue("@daysofleave", dol.Text)
            insertcommand.Parameters.AddWithValue("@status", sta.Text)
            insertcommand.Parameters.AddWithValue("@shifttime", st.Text)
            insertcommand.Parameters.AddWithValue("@description", d.Text)




            insertcommand.ExecuteNonQuery()
            DataGridView1.Refresh()
            MsgBox("employee added successfully")
        Catch ex As Exception
            MsgBox(ex.ToString)
            connection.Close()
            view()
            emid.Text = ""
            lt.Text = ""
            td.Text = ""
            fd.Text = ""
            dol.Text = ""
            sta.Text = ""
            st.Text = ""
            d.Text = ""



        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Modules.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connection.Open()

        Dim empid As String
        empid = emid.Text
        Dim ROWCOUNT As Integer
        ROWCOUNT = 0
        Dim sqlquery As String = "select count(*) from LEAVE where EMP_ID = @empid"
        Dim command1 As New SqlCommand(sqlquery, connection)
        command1.Parameters.AddWithValue("@empid", empid)
        ROWCOUNT = CInt(command1.ExecuteScalar())

        Try

            If ROWCOUNT > 0 Then

                Dim deletestatement As String = "delete from LEAVE where EMP_ID = @empid"
                Dim command As New SqlCommand(deletestatement, connection)
                command.Parameters.AddWithValue("@empid", empid)
                command.ExecuteNonQuery()
                MsgBox("LEAVE DETAILS REMOVED SUCCESSFULLY")
            Else
                MsgBox("LEAVE INFORMATION NOT FOUND")
            End If
            connection.Close()
            view()
            emid.Text = ""
            lt.Text = ""
            td.Text = ""
            fd.Text = ""
            dol.Text = ""
            sta.Text = ""
            st.Text = ""
            d.Text = ""


        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
End Class