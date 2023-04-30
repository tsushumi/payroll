<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayrollForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmployeeNameTextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HoursWorkedTextBox = New System.Windows.Forms.TextBox()
        Me.PayrateTextBox = New System.Windows.Forms.TextBox()
        Me.GrossPayTextBox = New System.Windows.Forms.TextBox()
        Me.ComputeButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Name"
        '
        'EmployeeNameTextbox
        '
        Me.EmployeeNameTextbox.Location = New System.Drawing.Point(232, 74)
        Me.EmployeeNameTextbox.Name = "EmployeeNameTextbox"
        Me.EmployeeNameTextbox.Size = New System.Drawing.Size(100, 20)
        Me.EmployeeNameTextbox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hours Worked"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Pay Rate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(113, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Gross Pay"
        '
        'HoursWorkedTextBox
        '
        Me.HoursWorkedTextBox.Location = New System.Drawing.Point(232, 128)
        Me.HoursWorkedTextBox.Name = "HoursWorkedTextBox"
        Me.HoursWorkedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HoursWorkedTextBox.TabIndex = 5
        '
        'PayrateTextBox
        '
        Me.PayrateTextBox.Location = New System.Drawing.Point(232, 182)
        Me.PayrateTextBox.Name = "PayrateTextBox"
        Me.PayrateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PayrateTextBox.TabIndex = 6
        '
        'GrossPayTextBox
        '
        Me.GrossPayTextBox.Location = New System.Drawing.Point(232, 236)
        Me.GrossPayTextBox.Name = "GrossPayTextBox"
        Me.GrossPayTextBox.ReadOnly = True
        Me.GrossPayTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GrossPayTextBox.TabIndex = 7
        '
        'ComputeButton
        '
        Me.ComputeButton.Location = New System.Drawing.Point(79, 319)
        Me.ComputeButton.Name = "ComputeButton"
        Me.ComputeButton.Size = New System.Drawing.Size(75, 23)
        Me.ComputeButton.TabIndex = 8
        Me.ComputeButton.Text = "Compute"
        Me.ComputeButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(306, 319)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PayrollForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ComputeButton)
        Me.Controls.Add(Me.GrossPayTextBox)
        Me.Controls.Add(Me.PayrateTextBox)
        Me.Controls.Add(Me.HoursWorkedTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EmployeeNameTextbox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PayrollForm"
        Me.Text = "Payroll"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents EmployeeNameTextbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents HoursWorkedTextBox As TextBox
    Friend WithEvents PayrateTextBox As TextBox
    Friend WithEvents GrossPayTextBox As TextBox
    Friend WithEvents ComputeButton As Button
    Friend WithEvents ExitButton As Button
End Class
