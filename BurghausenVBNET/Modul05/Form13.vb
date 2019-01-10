Public Class Form13
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Console.Beep(CInt(TextBox1.Text),
                     CInt(TextBox2.Text) * 1000)
    End Sub
End Class