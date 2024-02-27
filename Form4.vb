Imports System.Data.SqlClient
Public Class Form4



    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmpDataSet1.EMP_DETAILS' table. You can move, or remove it, as needed.
        Me.EMP_DETAILSTableAdapter.Fill(Me.EmpDataSet1.EMP_DETAILS)


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String
        a = Convert.ToDateTime(dtxt.Text)
        Dim connectionstring As String = "D:\WINDOWSAPPLICATION1\EMP.MDF"
        Dim connection As New SqlConnection(connectionstring)
        Try

            connection.Open()
            Dim insertstatement As String = "insert into emp_details(emp_id,firstname,lastname,address,contact_no,email,dob,age,education,designation,gender)values(@emp_id,@firstname,@lastname,@address,@contact_no,@email,@dob,@age,@education,@designation,@gender)"
            Dim insertcommand As New SqlCommand(insertstatement, connection)
            insertcommand.Parameters.AddWithValue("@emp_id", etxt.Text)
            insertcommand.Parameters.AddWithValue("@address", addtxt.Text)
            insertcommand.Parameters.AddWithValue("@contact_no", ctxt.Text)
            insertcommand.Parameters.AddWithValue("@email", emtxt.Text)
            insertcommand.Parameters.AddWithValue("@firstname", fntxt.Text)
            insertcommand.Parameters.AddWithValue("@lastname", lntxt.Text)
            insertcommand.Parameters.AddWithValue("@dob", dtxt.Text)
            insertcommand.Parameters.AddWithValue("@age", atxt.Text)
            insertcommand.Parameters.AddWithValue("@education", edtxt.Text)
            insertcommand.Parameters.AddWithValue("@designation", detxt.Text)
            insertcommand.Parameters.AddWithValue("@gender", gentxt.Text)
            insertcommand.Parameters.AddWithValue("@salary", satxt.Text)

            insertcommand.ExecuteNonQuery()
            DataGridView1.Refresh()
            MsgBox("employee added successfully")
            connection.Close()


        Catch ex As Exception
            MsgBox("error")

        End Try
       
    End Sub
End Class