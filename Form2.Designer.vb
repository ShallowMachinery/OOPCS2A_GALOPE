<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dgvData = New DataGridView()
        btnDisplay = New Button()
        btnHome = New Button()
        cboCourse = New ComboBox()
        CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvData
        ' 
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvData.Location = New Point(12, 41)
        dgvData.Name = "dgvData"
        dgvData.RowTemplate.Height = 25
        dgvData.Size = New Size(441, 218)
        dgvData.TabIndex = 0
        ' 
        ' btnDisplay
        ' 
        btnDisplay.Location = New Point(378, 12)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(75, 23)
        btnDisplay.TabIndex = 1
        btnDisplay.Text = "Display"
        btnDisplay.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.Location = New Point(369, 265)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(84, 35)
        btnHome.TabIndex = 2
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' cboCourse
        ' 
        cboCourse.FormattingEnabled = True
        cboCourse.Location = New Point(12, 12)
        cboCourse.Name = "cboCourse"
        cboCourse.Size = New Size(152, 23)
        cboCourse.TabIndex = 3
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        ClientSize = New Size(465, 312)
        ControlBox = False
        Controls.Add(cboCourse)
        Controls.Add(btnHome)
        Controls.Add(btnDisplay)
        Controls.Add(dgvData)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Database"
        CType(dgvData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvData As DataGridView
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents cboCourse As ComboBox
End Class
