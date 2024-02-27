Public Class Form3
    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        'Terminates the application. Closes the window
        Application.Exit()
    End Sub

    Private num1, num2 As Double

    'Subtract sub routine: performs the subtraction
    Private Sub ButtonSubtract_Click(sender As Object, e As EventArgs) Handles ButtonSubtract.Click
        Dim difference As Integer

        'Condition checks whether the value entered is valid. If true computation is performed, else an error message is displayed
        If Integer.TryParse(TextBoxNum1.Text, num1) And Integer.TryParse(TextBoxNum2.Text, num2) Then
            difference = num1 - num2
            TextBoxResult.Text = difference.ToString() 'ToString method converts our result to a string for it to be displayed

        Else
            MessageBox.Show("Invalid data entry. Please enter valid numbers")

        End If
    End Sub

    Private Sub ButtonMultiply_Click(sender As Object, e As EventArgs) Handles ButtonMultiply.Click
        Dim product As Double
        If Integer.TryParse(TextBoxNum1.Text, num1) And Integer.TryParse(TextBoxNum2.Text, num2) Then
            product = num1 * num2
            TextBoxResult.Text = product.ToString()

        Else
            MessageBox.Show("Invalid data entry. Please enter valid numbers")
        End If
    End Sub

    Private Sub ButtonDivide_Click(sender As Object, e As EventArgs) Handles ButtonDivide.Click
        Dim quotient As Double
        If Integer.TryParse(TextBoxNum1.Text, num1) And Integer.TryParse(TextBoxNum2.Text, num2) Then
            If num2 = 0 Then
                MessageBox.Show("Error! Cannot divide by zero.")
                'Clears the entries for new data entry
                TextBoxNum1.Clear()
                TextBoxNum2.Clear()
                TextBoxResult.Clear()
            End If
            quotient = num1 / num2
            TextBoxResult.Text = quotient.ToString()

        Else
                MessageBox.Show("Invalid data entry. Please enter valid numbers")
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxNum1.Clear()
        TextBoxNum2.Clear()
        TextBoxResult.Clear()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim mySum As Integer
        If Integer.TryParse(TextBoxNum1.Text, num1) And Integer.TryParse(TextBoxNum2.Text, num2) Then
            mySum = num1 + num2
            TextBoxResult.Text = mySum.ToString()

        Else
            MessageBox.Show("Invalid data entry. Please enter valid numbers")

        End If
    End Sub
End Class