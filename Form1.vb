Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim form2Instance As New Form2()
        form2Instance.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Call application.Exit() to terminate the application
        Application.Exit()

    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        'Maximize the window when clicked
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.WindowState = FormWindowState.Maximized

        End If
        'Set background color to red
        Me.BackColor = Color.Red

    End Sub

    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click
        Dim form3Instance As New Form3()
        form3Instance.Show()
    End Sub
End Class
