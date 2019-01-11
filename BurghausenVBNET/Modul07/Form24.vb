Public Class Form24
    Private Sub Form24_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mylotto As New Lotto
        Dim zahl = mylotto.GetZahl

        Dim d = Date.Today
        Dim z = Lotto.Zahl

    End Sub
End Class