<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.TextBoxNum1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNum2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxResult = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonSubtract = New System.Windows.Forms.Button()
        Me.ButtonMultiply = New System.Windows.Forms.Button()
        Me.ButtonDivide = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter First Number"
        '
        'TextBoxNum1
        '
        Me.TextBoxNum1.Location = New System.Drawing.Point(243, 34)
        Me.TextBoxNum1.Name = "TextBoxNum1"
        Me.TextBoxNum1.Size = New System.Drawing.Size(148, 26)
        Me.TextBoxNum1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter Second Number"
        '
        'TextBoxNum2
        '
        Me.TextBoxNum2.Location = New System.Drawing.Point(243, 81)
        Me.TextBoxNum2.Name = "TextBoxNum2"
        Me.TextBoxNum2.Size = New System.Drawing.Size(148, 26)
        Me.TextBoxNum2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Result"
        '
        'TextBoxResult
        '
        Me.TextBoxResult.Location = New System.Drawing.Point(243, 124)
        Me.TextBoxResult.Name = "TextBoxResult"
        Me.TextBoxResult.Size = New System.Drawing.Size(148, 26)
        Me.TextBoxResult.TabIndex = 5
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(45, 201)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(109, 41)
        Me.ButtonAdd.TabIndex = 6
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonSubtract
        '
        Me.ButtonSubtract.Location = New System.Drawing.Point(223, 201)
        Me.ButtonSubtract.Name = "ButtonSubtract"
        Me.ButtonSubtract.Size = New System.Drawing.Size(106, 41)
        Me.ButtonSubtract.TabIndex = 7
        Me.ButtonSubtract.Text = "Subtract"
        Me.ButtonSubtract.UseVisualStyleBackColor = True
        '
        'ButtonMultiply
        '
        Me.ButtonMultiply.Location = New System.Drawing.Point(412, 200)
        Me.ButtonMultiply.Name = "ButtonMultiply"
        Me.ButtonMultiply.Size = New System.Drawing.Size(124, 42)
        Me.ButtonMultiply.TabIndex = 8
        Me.ButtonMultiply.Text = "Multiply"
        Me.ButtonMultiply.UseVisualStyleBackColor = True
        '
        'ButtonDivide
        '
        Me.ButtonDivide.Location = New System.Drawing.Point(45, 278)
        Me.ButtonDivide.Name = "ButtonDivide"
        Me.ButtonDivide.Size = New System.Drawing.Size(109, 37)
        Me.ButtonDivide.TabIndex = 9
        Me.ButtonDivide.Text = "Divide"
        Me.ButtonDivide.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(223, 278)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(106, 37)
        Me.ButtonClear.TabIndex = 10
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(412, 278)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(124, 37)
        Me.ButtonExit.TabIndex = 11
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonDivide)
        Me.Controls.Add(Me.ButtonMultiply)
        Me.Controls.Add(Me.ButtonSubtract)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.TextBoxResult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxNum2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxNum1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Compute Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNum1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNum2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxResult As TextBox
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonSubtract As Button
    Friend WithEvents ButtonMultiply As Button
    Friend WithEvents ButtonDivide As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonExit As Button
End Class
