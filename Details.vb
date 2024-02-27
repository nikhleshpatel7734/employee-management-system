Imports System.Data.SqlClient
Public Class Details
    Dim connectionstring As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\WindowsApplication1\employ.mdf;Integrated Security=True;Connect Timeout=30"
    Dim connection As New SqlConnection(connectionstring)

    Sub view()
        connection.Open()
        Dim adp As New SqlDataAdapter("select * from EMP_DETAILS", connection)
        Dim ds As New DataSet
        adp.Fill(ds, "dd")
        DataGridView1.DataSource = ds.Tables("dd")
        connection.Close()


    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployDataSet.EMP_DETAILS' table. You can move, or remove it, as needed.
        Me.EMP_DETAILSTableAdapter1.Fill(Me.EmployDataSet.EMP_DETAILS)
        'TODO: This line of code loads data into the 'EmpDataSet1.EMP_DETAILS' table. You can move, or remove it, as needed.
        Me.EMP_DETAILSTableAdapter.Fill(Me.EmpDataSet1.EMP_DETAILS)
       

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String
        a = Convert.ToDateTime(db.Text)
       
        Try

            connection.Open()
            Dim insertstatement As String = "insert into emp_details(emp_id,firstname,lastname,address,contact,email,dob,age,education,designation,gender,salary)values(@emp_id,@firstname,@lastname,@address,@contact,@email,@dob,@age,@education,@designation,@gender,@salary)"
            Dim insertcommand As New SqlCommand(insertstatement, connection)
            insertcommand.Parameters.AddWithValue("@emp_id", etxt.Text)
            insertcommand.Parameters.AddWithValue("@address", addtxt.Text)
            insertcommand.Parameters.AddWithValue("@contact", ctxt.Text)
            insertcommand.Parameters.AddWithValue("@email", emtxt.Text)
            insertcommand.Parameters.AddWithValue("@firstname", fntxt.Text)
            insertcommand.Parameters.AddWithValue("@lastname", lntxt.Text)
            insertcommand.Parameters.AddWithValue("@dob", db.Text)
            insertcommand.Parameters.AddWithValue("@age", atxt.Text)
            insertcommand.Parameters.AddWithValue("@education", edtxt.Text)
            insertcommand.Parameters.AddWithValue("@designation", detxt.Text)
            insertcommand.Parameters.AddWithValue("@gender", gentxt.Text)
            insertcommand.Parameters.AddWithValue("@salary", satxt.Text)

            insertcommand.ExecuteNonQuery()
            DataGridView1.Refresh()
            MsgBox("employee added successfully")
            connection.Close()
            view()

            etxt.Text = ""
            addtxt.Text = ""
            ctxt.Text = ""
            emtxt.Text = ""
            fntxt.Text = ""
            lntxt.Text = ""
            db.Text = ""
            atxt.Text = ""
            edtxt.Text = ""
            detxt.Text = ""
            gentxt.Text = ""
            satxt.Text = ""



        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        
        connection.Open()

        Dim empid As String
        empid = etxt.Text
        Dim ROWCOUNT As Integer
        ROWCOUNT = 0
        Dim sqlquery As String = "select count(*) from EMP_DETAILS where EMP_ID = @empid"
        Dim command1 As New SqlCommand(sqlquery, connection)
        command1.Parameters.AddWithValue("@empid", empid)
        ROWCOUNT = CInt(command1.ExecuteScalar())

        Try

            If ROWCOUNT > 0 Then

                Dim deletestatement As String = "delete from EMP_DETAILS where EMP_ID = @empid"
                Dim command As New SqlCommand(deletestatement, connection)
                command.Parameters.AddWithValue("@empid", empid)
                command.ExecuteNonQuery()
                MsgBox("EMPLOYEE REMOVED SUCCESSFULLY")
            Else
                MsgBox("EMPLOYEE NOT FOUND")
            End If
            connection.Close()
            view()
            etxt.Text = ""
            addtxt.Text = ""
            ctxt.Text = ""
            emtxt.Text = ""
            fntxt.Text = ""
            lntxt.Text = ""
            db.Text = ""
            atxt.Text = ""
            edtxt.Text = ""
            detxt.Text = ""
            gentxt.Text = ""
            satxt.Text = ""



        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
      
        Dim a As Date
        a = Convert.ToDateTime(db.Value)

        connection.Open()


        Dim empid As String
        empid = etxt.Text


        Dim sqlquery As String = "update EMP_DETAILS set FIRSTNAME=@newfirstname,LASTNAME=@newlastname,ADDRESS=@newaddress,CONTACT=@newcontact,EMAIL=@newemail,DOB=@newdob,AGE=@newage,EDUCATION=@neweducation,DESIGNATION=@newdesignation,GENDER=@newgender,SALARY=@newsalary where EMP_ID=@NEWEMP"
        Dim command As New SqlCommand(sqlquery, connection)
        command.Parameters.AddWithValue("@NEWEMP", empid)
        command.Parameters.AddWithValue("@newaddress", addtxt.Text)
        command.Parameters.AddWithValue("@newcontact", ctxt.Text)
        command.Parameters.AddWithValue("@newemail", emtxt.Text)
        command.Parameters.AddWithValue("@newfirstname", fntxt.Text)
        command.Parameters.AddWithValue("@newlastname", lntxt.Text)
        command.Parameters.AddWithValue("@newdob", db.Text)
        command.Parameters.AddWithValue("@newage", atxt.Text)
        command.Parameters.AddWithValue("@neweducation", edtxt.Text)
        command.Parameters.AddWithValue("@newdesignation", detxt.Text)
        command.Parameters.AddWithValue("@newgender", gentxt.Text)
        command.Parameters.AddWithValue("@newsalary", Convert.ToInt32(satxt.Text))

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
        etxt.Text = ""
        addtxt.Text = ""
        ctxt.Text = ""
        emtxt.Text = ""
        fntxt.Text = ""
        lntxt.Text = ""
        db.Text = ""
        atxt.Text = ""
        edtxt.Text = ""
        detxt.Text = ""
        gentxt.Text = ""
        satxt.Text = ""


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim empid As String
        empid = etxt.Text

        Dim query As String = "SELECT EMP_ID,FIRSTNAME,LASTNAME,ADDRESS,CONTACT,EMAIL,DOB,AGE,EDUCATION,DESIGNATION,GENDER,SALARY FROM EMP_DETAILS WHERE EMP_ID= @EID"
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@EID", empid)
        Dim A As Date
        A = Convert.ToDateTime(db.Value)
        connection.Open()
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            etxt.Text = reader.GetString(0).ToString()
            fntxt.Text = reader.GetString(1).ToString()
            lntxt.Text = reader.GetString(2).ToString()
            addtxt.Text = reader.GetString(3).ToString()
            ctxt.Text = reader.GetString(4).ToString()
            emtxt.Text = reader.GetString(5).ToString()
            db.Text = reader.GetValue(6).ToString()
            atxt.Text = reader.GetString(7).ToString()
            edtxt.Text = reader.GetString(8).ToString()
            detxt.Text = reader.GetString(9).ToString()
            gentxt.Text = reader.GetString(10).ToString()
            satxt.Text = reader.GetInt32(11).ToString()
            MsgBox("employee is found...")
            Button2.Visible = False
        Else
            MsgBox(" employee is not in database...")
        End If
        reader.Close()
        connection.Close()
        view()

     

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Modules.Show()
        Me.Hide()

    End Sub
End Class