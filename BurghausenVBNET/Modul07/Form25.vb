Public Class Form25
    Private Sub Form25_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim p As New Person
        p.Size = 100
        Dim m As New Mitarbeiter

        Dim x As Mensch = CType(p, Mensch) 'TODO: klären
    End Sub
End Class