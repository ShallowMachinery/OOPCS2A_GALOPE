Imports MySql.Data.MySqlClient

Module Module1
    Dim con As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim mysqlcmd As New MySqlCommand

    Dim host, uname, pwd, dbname As String
    Dim sqlquery As String
    Dim dbTable As New DataTable
    Dim adapter As New MySqlDataAdapter

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
                ' MessageBox.Show("Connected!")
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
            MsgBox("Record saved successfully!")
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        Finally
            TextClear()
        End Try
    End Sub
    Sub TextClear()
        Form1.txtFname.Clear()
        Form1.txtLname.Clear()
        Form1.txtCourse.Clear()
    End Sub
    Public Sub SearchData()
        Dim uid As String
        uid = Form1.txtUserID.Text
        sqlquery = "SELECT * FROM Students WHERE StudID = @uid"
        mysqlcmd = New MySqlCommand(sqlquery, con)
        mysqlcmd.Parameters.AddWithValue("@uid", uid)
        Try
            reader = mysqlcmd.ExecuteReader()

            If reader.Read Then
                Form1.txtFCatch.Text = reader("StudFName").ToString()
                Form1.txtLCatch.Text = reader("StudLName").ToString()
                Form1.txtCCatch.Text = reader("Course").ToString()
            Else
                Form1.txtFCatch.Text = "No"
                Form1.txtLCatch.Text = "student"
                Form1.txtCCatch.Text = "found"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            reader.Close()
        End Try
    End Sub
    Public Sub LoadAllData()
        sqlquery = "SELECT * FROM Students"
        adapter = New MySqlDataAdapter(sqlquery, con)
        Try
            dbTable = New DataTable
            adapter.Fill(dbTable)
            With Form2.dgvData
                .DataSource = dbTable
                .AutoResizeColumns()
            End With
            'display the record in datagridview
            ' reader = mysqlcmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub LoadCourse()
        sqlquery = "SELECT DISTINCT Course FROM Students"
        Try
            mysqlcmd = New MySqlCommand(sqlquery, con)
            reader = mysqlcmd.ExecuteReader
            While reader.Read
                Form2.cboCourse.Items.Add(reader("course").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub DisplayData(kurso As String)
        sqlquery = "SELECT * FROM Students WHERE course = @kurso"
        adapter = New MySqlDataAdapter(sqlquery, con)
        adapter.SelectCommand.Parameters.AddWithValue("@kurso", kurso)
        Try
            dbTable = New DataTable
            adapter.Fill(dbTable)
            With Form2.dgvData
                .DataSource = dbTable
                .AutoResizeColumns()
            End With
            'display the record in datagridview
            ' reader = mysqlcmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Module
