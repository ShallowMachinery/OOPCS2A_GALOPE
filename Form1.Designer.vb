<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        btnInsert = New Button()
        txtCourse = New TextBox()
        txtLname = New TextBox()
        txtFname = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        txtUserID = New TextBox()
        Label7 = New Label()
        btnSearch = New Button()
        txtCCatch = New TextBox()
        txtLCatch = New TextBox()
        txtFCatch = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnDisplay = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnInsert)
        GroupBox1.Controls.Add(txtCourse)
        GroupBox1.Controls.Add(txtLname)
        GroupBox1.Controls.Add(txtFname)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.ForeColor = SystemColors.ControlText
        GroupBox1.Location = New Point(10, 11)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(235, 235)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Save Record"
        ' 
        ' btnInsert
        ' 
        btnInsert.Location = New Point(90, 158)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(123, 51)
        btnInsert.TabIndex = 6
        btnInsert.Text = "Insert Record"
        btnInsert.UseVisualStyleBackColor = True
        ' 
        ' txtCourse
        ' 
        txtCourse.Location = New Point(113, 106)
        txtCourse.Name = "txtCourse"
        txtCourse.Size = New Size(100, 23)
        txtCourse.TabIndex = 5
        ' 
        ' txtLname
        ' 
        txtLname.Location = New Point(113, 71)
        txtLname.Name = "txtLname"
        txtLname.Size = New Size(100, 23)
        txtLname.TabIndex = 4
        ' 
        ' txtFname
        ' 
        txtFname.Location = New Point(113, 38)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(100, 23)
        txtFname.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 15)
        Label3.TabIndex = 2
        Label3.Text = "Course:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 15)
        Label2.TabIndex = 1
        Label2.Text = "Last name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 15)
        Label1.TabIndex = 0
        Label1.Text = "First name:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtUserID)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(btnSearch)
        GroupBox2.Controls.Add(txtCCatch)
        GroupBox2.Controls.Add(txtLCatch)
        GroupBox2.Controls.Add(txtFCatch)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Location = New Point(251, 11)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(235, 235)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "Search Record"
        ' 
        ' txtUserID
        ' 
        txtUserID.Location = New Point(113, 29)
        txtUserID.Name = "txtUserID"
        txtUserID.Size = New Size(100, 23)
        txtUserID.TabIndex = 8
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(19, 32)
        Label7.Name = "Label7"
        Label7.Size = New Size(65, 15)
        Label7.TabIndex = 7
        Label7.Text = "Student ID:"
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(90, 173)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(123, 36)
        btnSearch.TabIndex = 6
        btnSearch.Text = "Search Record"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtCCatch
        ' 
        txtCCatch.Enabled = False
        txtCCatch.Location = New Point(113, 127)
        txtCCatch.Name = "txtCCatch"
        txtCCatch.Size = New Size(100, 23)
        txtCCatch.TabIndex = 5
        ' 
        ' txtLCatch
        ' 
        txtLCatch.Enabled = False
        txtLCatch.Location = New Point(113, 94)
        txtLCatch.Name = "txtLCatch"
        txtLCatch.Size = New Size(100, 23)
        txtLCatch.TabIndex = 4
        ' 
        ' txtFCatch
        ' 
        txtFCatch.Enabled = False
        txtFCatch.Location = New Point(113, 61)
        txtFCatch.Name = "txtFCatch"
        txtFCatch.Size = New Size(100, 23)
        txtFCatch.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 130)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 15)
        Label4.TabIndex = 2
        Label4.Text = "Course:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(19, 97)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 15)
        Label5.TabIndex = 1
        Label5.Text = "Last name:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(19, 64)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 15)
        Label6.TabIndex = 0
        Label6.Text = "First name:"
        ' 
        ' btnDisplay
        ' 
        btnDisplay.Location = New Point(128, 253)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(117, 34)
        btnDisplay.TabIndex = 8
        btnDisplay.Text = "Display by Course"
        btnDisplay.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        ClientSize = New Size(503, 299)
        Controls.Add(btnDisplay)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnInsert As Button
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtCCatch As TextBox
    Friend WithEvents txtLCatch As TextBox
    Friend WithEvents txtFCatch As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnDisplay As Button
End Class
