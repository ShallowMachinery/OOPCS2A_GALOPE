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
        GroupBox1.SuspendLayout()
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(258, 265)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
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
End Class
