<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lstBoxOne = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalPayroll = New System.Windows.Forms.Label()
        Me.btnCalculatePayroll = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstBoxOne
        '
        Me.lstBoxOne.FormattingEnabled = True
        Me.lstBoxOne.ItemHeight = 20
        Me.lstBoxOne.Location = New System.Drawing.Point(129, 33)
        Me.lstBoxOne.Name = "lstBoxOne"
        Me.lstBoxOne.Size = New System.Drawing.Size(328, 244)
        Me.lstBoxOne.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 339)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Payroll :"
        '
        'lblTotalPayroll
        '
        Me.lblTotalPayroll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPayroll.Location = New System.Drawing.Point(217, 325)
        Me.lblTotalPayroll.Name = "lblTotalPayroll"
        Me.lblTotalPayroll.Size = New System.Drawing.Size(158, 42)
        Me.lblTotalPayroll.TabIndex = 2
        '
        'btnCalculatePayroll
        '
        Me.btnCalculatePayroll.Location = New System.Drawing.Point(84, 445)
        Me.btnCalculatePayroll.Name = "btnCalculatePayroll"
        Me.btnCalculatePayroll.Size = New System.Drawing.Size(160, 42)
        Me.btnCalculatePayroll.TabIndex = 3
        Me.btnCalculatePayroll.Text = "Calculate Payroll"
        Me.btnCalculatePayroll.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(335, 445)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 42)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(507, 445)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 42)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 655)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculatePayroll)
        Me.Controls.Add(Me.lblTotalPayroll)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstBoxOne)
        Me.Name = "Form1"
        Me.Text = "simple Payroll"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstBoxOne As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalPayroll As Label
    Friend WithEvents btnCalculatePayroll As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
End Class
