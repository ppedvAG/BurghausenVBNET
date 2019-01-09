Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = TextBox1.Text.Replace(" ", "-")

    End Sub
End Class