<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradeComputation
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCalculus = New System.Windows.Forms.TextBox()
        Me.txtDSA = New System.Windows.Forms.TextBox()
        Me.txtLinearAlgebra = New System.Windows.Forms.TextBox()
        Me.txtOOP = New System.Windows.Forms.TextBox()
        Me.btnComputeGrade = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(328, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grading System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Calculus"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(110, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DSA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(110, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Linear Algebra"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(110, 382)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "OOP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(136, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(287, 29)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Enter your marks below"
        '
        'txtCalculus
        '
        Me.txtCalculus.Location = New System.Drawing.Point(281, 182)
        Me.txtCalculus.Name = "txtCalculus"
        Me.txtCalculus.Size = New System.Drawing.Size(222, 26)
        Me.txtCalculus.TabIndex = 6
        '
        'txtDSA
        '
        Me.txtDSA.Location = New System.Drawing.Point(281, 249)
        Me.txtDSA.Name = "txtDSA"
        Me.txtDSA.Size = New System.Drawing.Size(222, 26)
        Me.txtDSA.TabIndex = 7
        '
        'txtLinearAlgebra
        '
        Me.txtLinearAlgebra.Location = New System.Drawing.Point(281, 313)
        Me.txtLinearAlgebra.Name = "txtLinearAlgebra"
        Me.txtLinearAlgebra.Size = New System.Drawing.Size(222, 26)
        Me.txtLinearAlgebra.TabIndex = 8
        '
        'txtOOP
        '
        Me.txtOOP.Location = New System.Drawing.Point(281, 378)
        Me.txtOOP.Name = "txtOOP"
        Me.txtOOP.Size = New System.Drawing.Size(222, 26)
        Me.txtOOP.TabIndex = 9
        '
        'btnComputeGrade
        '
        Me.btnComputeGrade.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnComputeGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComputeGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComputeGrade.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnComputeGrade.Location = New System.Drawing.Point(141, 491)
        Me.btnComputeGrade.Name = "btnComputeGrade"
        Me.btnComputeGrade.Size = New System.Drawing.Size(161, 48)
        Me.btnComputeGrade.TabIndex = 10
        Me.btnComputeGrade.Text = "Compute Grade"
        Me.btnComputeGrade.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.Location = New System.Drawing.Point(597, 479)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(173, 51)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'GradeComputation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(959, 643)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnComputeGrade)
        Me.Controls.Add(Me.txtOOP)
        Me.Controls.Add(Me.txtLinearAlgebra)
        Me.Controls.Add(Me.txtDSA)
        Me.Controls.Add(Me.txtCalculus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GradeComputation"
        Me.Text = "GradeComputation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCalculus As TextBox
    Friend WithEvents txtDSA As TextBox
    Friend WithEvents txtLinearAlgebra As TextBox
    Friend WithEvents txtOOP As TextBox
    Friend WithEvents btnComputeGrade As Button
    Friend WithEvents btnCancel As Button
End Class
