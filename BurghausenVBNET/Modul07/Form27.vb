Public Class Form27
    Private Sub Form27_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 23423423
        Dim d = i.ToDate

        Dim dd = Module1.ToDate(i) 'kompiler macht daraus
    End Sub
End Class