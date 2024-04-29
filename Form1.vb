Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(TextBox1.Text) Then
            TextBox2.Text = Val(TextBox1.Text) * 1.61
        Else
            MessageBox.Show("Please enter a valid number.")
        End If
    End Sub

End Class
