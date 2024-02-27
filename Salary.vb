Imports System.Data.SqlClient
Public Class V

    Dim connectionstring As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WindowsApplication1\employ.mdf;Integrated Security=True;Connect Timeout=30"
    Dim connection As New SqlConnection(connectionstring)

    Sub view()
        connection.Open()
        Dim adp As New SqlDataAdapter("select * from EMP_SALARY", connection)
        Dim ds As New DataSet
        adp.Fill(ds, "dd")
        DataGridView1.DataSource = ds.Tables("dd")
        connection.Close()



    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub V_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployDataSet4.EMP_SALARY' table. You can move, or remove it, as needed.
        Me.EMP_SALARYTableAdapter2.Fill(Me.EmployDataSet4.EMP_SALARY)
        'TODO: This line of code loads data into the 'EmployDataSet3.EMP_SALARY' table. You can move, or remove it, as needed.
        Me.EMP_SALARYTableAdapter1.Fill(Me.EmployDataSet3.EMP_SALARY)
      

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connection.Open()


        Dim empid As String
        empid = IDTXT.Text


        Dim sqlquery As String = "update EMP_SALARY set FIRSTNAME=@newfirstname,LASTNAME=@newlastname,CONTACT=@newcontact,POSITION=@newposition,WORKDAYS=@newworkdays,TOTALSALARY=@newtotalsalary where EMP_ID = @NEWEMP "
        Dim command As New SqlCommand(sqlquery, connection)
        command.Parameters.AddWithValue("@NEWEMP", empid)
        command.Parameters.AddWithValue("@newfirstname", FNTXT.Text)
        command.Parameters.AddWithValue("@newlastname", LNTXT.Text)
        command.Parameters.AddWithValue("@newcontact", CTXT.Text)
        command.Parameters.AddWithValue("@newposition", PTXT.Text)
        command.Parameters.AddWithValue("@newworkdays", WDTXT.Text)
        command.Parameters.AddWithValue("@newtotalsalary", TSTXT.Text)

        Dim rowcount As Integer = command.ExecuteNonQuery()
        If rowcount > 0 Then
            Console.WriteLine(" EMP ID " & empid & " WAS UPDATED IN DATABASE.")
            MsgBox("EMPLOYEE UPDATED SUCCESSFULLY")
        Else
            Console.WriteLine(" EMP ID " & empid & " WAS NOT FOUND IN DATABASE.")
            MsgBox(" EMPLOYEE NOT FOUND")
        End If


        connection.Close()
        Update()





    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try

            connection.Open()
            Dim insertstatement As String = "insert into EMP_SALARY(firstname,contact,workdays,lastname,position,totalsalary,emp_id)values(@firstname,@contact,@workdays,@lastname,@position,@totalsalary,@emp_id)"
            Dim insertcommand As New SqlCommand(insertstatement, connection)
            insertcommand.Parameters.AddWithValue("@firstname", FNTXT.Text)
            insertcommand.Parameters.AddWithValue("@contact", CTXT.Text)
            insertcommand.Parameters.AddWithValue("@workdays", WDTXT.Text)
            insertcommand.Parameters.AddWithValue("@lastname", LNTXT.Text)
            insertcommand.Parameters.AddWithValue("@position", PTXT.Text)
            insertcommand.Parameters.AddWithValue("@totalsalary", TSTXT.Text)
            insertcommand.Parameters.AddWithValue("@emp_id", IDTXT.Text)
            insertcommand.ExecuteNonQuery()
            MsgBox("employee added successfully")


        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        connection.Close()
        view()
        IDTXT.Text = ""
        FNTXT.Text = ""
        LNTXT.Text = ""
        CTXT.Text = ""
        PTXT.Text = ""
        WDTXT.Text = ""
        TSTXT.Text = ""

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Modules.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim empid As String
        empid = IDTXT.Text

        Dim query As String = "SELECT EMP_ID,FIRSTNAME,LASTNAME,CONTACT,POSITION,WORKDAYS,TOTALSALARY FROM EMP_SALARY WHERE EMP_ID= @EID"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@EID", empid)

        connection.Open()
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            IDTXT.Text = reader.GetString(0).ToString()
            FNTXT.Text = reader.GetString(1).ToString()
            LNTXT.Text = reader.GetString(2).ToString()
            CTXT.Text = reader.GetString(3).ToString()
            PTXT.Text = reader.GetString(4).ToString()
            WDTXT.Text = reader.GetInt32(5).ToString()
            TSTXT.Text = reader.GetInt32(6).ToString()
           
            MsgBox("employee is found...")
            Button2.Visible = False
        Else
            MsgBox(" employee is not in database...")
        End If
        reader.Close()
        connection.Close()
        view()
      

    End Sub

    Private Sub PTXT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PTXT.SelectedIndexChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        connection.Open()

        Dim empid As String
        empid = IDTXT.Text
        Dim ROWCOUNT As Integer
        ROWCOUNT = 0
        Dim sqlquery As String = "select count(*) from EMP_SALARY where EMP_ID = @empid"
        Dim command1 As New SqlCommand(sqlquery, connection)
        command1.Parameters.AddWithValue("@empid", empid)
        ROWCOUNT = CInt(command1.ExecuteScalar())

        Try

            If ROWCOUNT > 0 Then

                Dim deletestatement As String = "delete from EMP_SALARY where EMP_ID = @empid"
                Dim command As New SqlCommand(deletestatement, connection)
                command.Parameters.AddWithValue("@empid", empid)
                command.ExecuteNonQuery()
                MsgBox("EMPLOYEE SALARY DETAILS REMOVED SUCCESSFULLY")
            Else
                MsgBox("EMPLOYEE SALARY INFORMATION NOT FOUND")
            End If
            connection.Close()
            view()
            IDTXT.Text = ""
            FNTXT.Text = ""
            LNTXT.Text = ""
            CTXT.Text = ""
            PTXT.Text = ""
            WDTXT.Text = ""
            TSTXT.Text = ""


        Catch ex As Exception
            MsgBox(ex.ToString)
           
        End Try
    End Sub
End Class