Imports Mysqlx.XDevAPI.Relational

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDbase()
        LoadCourse()
        LoadAllData()
        With dgvData
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .RowsDefaultCellStyle.BackColor = Color.LightSkyBlue
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen
        End With
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Form1.Show()
        Me.Dispose()
        ConnectDbase()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim SelectedCourse As String
        SelectedCourse = cboCourse.SelectedItem.ToString
        DisplayData(SelectedCourse)
    End Sub
End Class