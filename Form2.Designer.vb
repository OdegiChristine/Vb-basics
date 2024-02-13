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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radGaramond = New System.Windows.Forms.RadioButton()
        Me.radMagneto = New System.Windows.Forms.RadioButton()
        Me.radTahoma = New System.Windows.Forms.RadioButton()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLoadPicture = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ListView4 = New System.Windows.Forms.ListView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.radGreen = New System.Windows.Forms.RadioButton()
        Me.radBlue = New System.Windows.Forms.RadioButton()
        Me.radRed = New System.Windows.Forms.RadioButton()
        Me.chkItalic = New System.Windows.Forms.CheckBox()
        Me.chkBold = New System.Windows.Forms.CheckBox()
        Me.chkBoldItalic = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(383, 61)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(525, 64)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(410, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Font"
        '
        'radGaramond
        '
        Me.radGaramond.AutoSize = True
        Me.radGaramond.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.radGaramond.Location = New System.Drawing.Point(414, 82)
        Me.radGaramond.Name = "radGaramond"
        Me.radGaramond.Size = New System.Drawing.Size(110, 24)
        Me.radGaramond.TabIndex = 6
        Me.radGaramond.TabStop = True
        Me.radGaramond.Text = "Garamond"
        Me.radGaramond.UseVisualStyleBackColor = False
        '
        'radMagneto
        '
        Me.radMagneto.AutoSize = True
        Me.radMagneto.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.radMagneto.Location = New System.Drawing.Point(589, 81)
        Me.radMagneto.Name = "radMagneto"
        Me.radMagneto.Size = New System.Drawing.Size(97, 24)
        Me.radMagneto.TabIndex = 7
        Me.radMagneto.TabStop = True
        Me.radMagneto.Text = "Magneto"
        Me.radMagneto.UseVisualStyleBackColor = False
        '
        'radTahoma
        '
        Me.radTahoma.AutoSize = True
        Me.radTahoma.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.radTahoma.Location = New System.Drawing.Point(751, 82)
        Me.radTahoma.Name = "radTahoma"
        Me.radTahoma.Size = New System.Drawing.Size(92, 24)
        Me.radTahoma.TabIndex = 8
        Me.radTahoma.TabStop = True
        Me.radTahoma.Text = "Tahoma"
        Me.radTahoma.UseVisualStyleBackColor = False
        '
        'ListView2
        '
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(82, 61)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(252, 64)
        Me.ListView2.TabIndex = 12
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Display Text"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(114, 82)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(157, 26)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.Text = "Sample Test"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(82, 184)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(307, 344)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'btnLoadPicture
        '
        Me.btnLoadPicture.Location = New System.Drawing.Point(82, 587)
        Me.btnLoadPicture.Name = "btnLoadPicture"
        Me.btnLoadPicture.Size = New System.Drawing.Size(174, 33)
        Me.btnLoadPicture.TabIndex = 18
        Me.btnLoadPicture.Text = "Load Picture"
        Me.btnLoadPicture.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(708, 587)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 33)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ListView3
        '
        Me.ListView3.HideSelection = False
        Me.ListView3.Location = New System.Drawing.Point(708, 184)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(219, 344)
        Me.ListView3.TabIndex = 20
        Me.ListView3.UseCompatibleStateImageBehavior = False
        '
        'ListView4
        '
        Me.ListView4.HideSelection = False
        Me.ListView4.Location = New System.Drawing.Point(439, 184)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(224, 344)
        Me.ListView4.TabIndex = 21
        Me.ListView4.UseCompatibleStateImageBehavior = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(490, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Font Style"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(747, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Font Color"
        '
        'radGreen
        '
        Me.radGreen.AutoSize = True
        Me.radGreen.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.radGreen.Location = New System.Drawing.Point(735, 228)
        Me.radGreen.Name = "radGreen"
        Me.radGreen.Size = New System.Drawing.Size(79, 24)
        Me.radGreen.TabIndex = 24
        Me.radGreen.TabStop = True
        Me.radGreen.Text = "Green"
        Me.radGreen.UseVisualStyleBackColor = False
        '
        'radBlue
        '
        Me.radBlue.AutoSize = True
        Me.radBlue.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.radBlue.Location = New System.Drawing.Point(735, 297)
        Me.radBlue.Name = "radBlue"
        Me.radBlue.Size = New System.Drawing.Size(66, 24)
        Me.radBlue.TabIndex = 25
        Me.radBlue.TabStop = True
        Me.radBlue.Text = "Blue"
        Me.radBlue.UseVisualStyleBackColor = False
        '
        'radRed
        '
        Me.radRed.AutoSize = True
        Me.radRed.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.radRed.Location = New System.Drawing.Point(735, 366)
        Me.radRed.Name = "radRed"
        Me.radRed.Size = New System.Drawing.Size(64, 24)
        Me.radRed.TabIndex = 26
        Me.radRed.TabStop = True
        Me.radRed.Text = "Red"
        Me.radRed.UseVisualStyleBackColor = False
        '
        'chkItalic
        '
        Me.chkItalic.AutoSize = True
        Me.chkItalic.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkItalic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkItalic.Location = New System.Drawing.Point(461, 228)
        Me.chkItalic.Name = "chkItalic"
        Me.chkItalic.Size = New System.Drawing.Size(68, 24)
        Me.chkItalic.TabIndex = 27
        Me.chkItalic.Text = "Italic"
        Me.chkItalic.UseVisualStyleBackColor = False
        '
        'chkBold
        '
        Me.chkBold.AutoSize = True
        Me.chkBold.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkBold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBold.Location = New System.Drawing.Point(461, 297)
        Me.chkBold.Name = "chkBold"
        Me.chkBold.Size = New System.Drawing.Size(71, 24)
        Me.chkBold.TabIndex = 28
        Me.chkBold.Text = "Bold"
        Me.chkBold.UseVisualStyleBackColor = False
        '
        'chkBoldItalic
        '
        Me.chkBoldItalic.AutoSize = True
        Me.chkBoldItalic.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkBoldItalic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBoldItalic.Location = New System.Drawing.Point(461, 366)
        Me.chkBoldItalic.Name = "chkBoldItalic"
        Me.chkBoldItalic.Size = New System.Drawing.Size(115, 24)
        Me.chkBoldItalic.TabIndex = 29
        Me.chkBoldItalic.Text = "Bold Italic"
        Me.chkBoldItalic.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 661)
        Me.Controls.Add(Me.chkBoldItalic)
        Me.Controls.Add(Me.chkBold)
        Me.Controls.Add(Me.chkItalic)
        Me.Controls.Add(Me.radRed)
        Me.Controls.Add(Me.radBlue)
        Me.Controls.Add(Me.radGreen)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListView4)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLoadPicture)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.radTahoma)
        Me.Controls.Add(Me.radMagneto)
        Me.Controls.Add(Me.radGaramond)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Form2"
        Me.Text = "Object Demonstration"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents radGaramond As RadioButton
    Friend WithEvents radMagneto As RadioButton
    Friend WithEvents radTahoma As RadioButton
    Friend WithEvents ListView2 As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLoadPicture As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ListView3 As ListView
    Friend WithEvents ListView4 As ListView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents radGreen As RadioButton
    Friend WithEvents radBlue As RadioButton
    Friend WithEvents radRed As RadioButton
    Friend WithEvents chkItalic As CheckBox
    Friend WithEvents chkBold As CheckBox
    Friend WithEvents chkBoldItalic As CheckBox
End Class
