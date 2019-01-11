Public Class Form26
    Private Sub Form26_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using u As New Class1
            u.Add(1)
        End Using
    End Sub
End Class