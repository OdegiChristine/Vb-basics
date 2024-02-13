Public Class Form2
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub radGaramond_CheckedChanged(sender As Object, e As EventArgs) Handles radGaramond.CheckedChanged
        TextBox1.Font = New Font("Garamond", TextBox1.Font.Size, FontStyle.Regular)
    End Sub

    Private Sub radMagneto_CheckedChanged(sender As Object, e As EventArgs) Handles radMagneto.CheckedChanged
        TextBox1.Font = New Font("Magneto", TextBox1.Font.Size, FontStyle.Regular)
    End Sub

    Private Sub radTahoma_CheckedChanged(sender As Object, e As EventArgs) Handles radTahoma.CheckedChanged
        TextBox1.Font = New Font("Tahoma", TextBox1.Font.Size, TextBox1.Font.Style)
    End Sub

    Private Sub chkItalic_CheckedChanged(sender As Object, e As EventArgs) Handles chkItalic.CheckedChanged
        TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, FontStyle.Italic)
    End Sub

    Private Sub chkBold_CheckedChanged(sender As Object, e As EventArgs) Handles chkBold.CheckedChanged
        TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, FontStyle.Bold)
    End Sub

    Private Sub chkBoldItalic_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoldItalic.CheckedChanged
        TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, FontStyle.Bold Or FontStyle.Italic)
    End Sub

    Private Sub radGreen_CheckedChanged(sender As Object, e As EventArgs) Handles radGreen.CheckedChanged
        TextBox1.ForeColor = Color.Green
    End Sub

    Private Sub radBlue_CheckedChanged(sender As Object, e As EventArgs) Handles radBlue.CheckedChanged
        TextBox1.ForeColor = Color.Blue
    End Sub

    Private Sub radRed_CheckedChanged(sender As Object, e As EventArgs) Handles radRed.CheckedChanged
        TextBox1.ForeColor = Color.Red
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLoadPicture_Click(sender As Object, e As EventArgs) Handles btnLoadPicture.Click
        ' Show an OpenFileDialog to let the user choose an image file
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.png;*.gif|All Files|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Load the selected image into the PictureBox
            PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub
End Class