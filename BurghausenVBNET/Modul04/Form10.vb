Public Class Form10
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim a(5) As Integer

        For i = 0 To 5 Step 1
            a(i) = CInt(Rnd() * 49) + 1
        Next
        ListBox1.DataSource = a
    End Sub
End Class