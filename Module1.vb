Imports System.DirectoryServices
Imports MySql.Data.MySqlClient

Module Module1
    Dim con As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim mysqlcmd As New MySqlCommand

    Dim host, uname, pwd, dbname As String
    Dim sqlquery As String

    Public Sub ConnectDbase()
        host = "127.0.0.1"
        dbname = "cs2aoop"
        uname = "root"
        pwd = "password"

        If Not con Is Nothing Then
            con.Close()
            con.ConnectionString = "server = " & host & "; user id = " & uname & "; password = " & pwd & "; database = " & dbname & ""
            Try
                con.Open()
                MessageBox.Show("Connected!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Public Sub SaveRecord()
        Dim Fname, Lname, Course As String
        Fname = Form1.txtFname.Text
        Lname = Form1.txtLname.Text
        Course = Form1.txtCourse.Text
        sqlquery = "INSERT INTO Students (StudFName, StudLName, Course) VALUES (@fname, @lname, @course)"
        'pass the query and connection to mysqlcommand
        mysqlcmd = New MySqlCommand(sqlquery, con)
        'add parameter value
        mysqlcmd.Parameters.AddWithValue("@fname", Fname)
        mysqlcmd.Parameters.AddWithValue("@lname", Lname)
        mysqlcmd.Parameters.AddWithValue("@course", Course)
        Try
            mysqlcmd.ExecuteNonQuery()
            MsgBox("Record saved successfuley!")
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        Finally
            Form1.txtFname.Clear()
            Form1.txtLname.Clear()
            Form1.txtCourse.Clear()
        End Try
    End Sub
End Module
