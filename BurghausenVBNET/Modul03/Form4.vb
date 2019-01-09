Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Label1.Text = (CDbl(TextBox1.Text) + Double.Parse(TextBox2.Text)).ToString

        Label1.Text = CStr(CDbl(TextBox1.Text) + Double.Parse(TextBox2.Text))

    End Sub
End Class