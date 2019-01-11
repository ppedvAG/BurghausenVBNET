Public Class Rechnung
    Public Property Kunde As String
    Public ReadOnly Property Summe As Integer
    Public Property RechnungPositionen() As List(Of Positionen)
    Public Sub New()
        _RechnungPositionen = New List(Of Positionen)
    End Sub
    Public Sub AddPosition(p As Positionen)
        Dim max As Integer
        If _RechnungPositionen.Count > 0 Then
            max = _RechnungPositionen.Max(Function(x) x.Id)
        Else
            max = 0
        End If
        p.Id = max + 1
        _RechnungPositionen.Add(p)
        _Summe = _RechnungPositionen.Sum(Function(r) r.Anzahl * r.Preis)

    End Sub

End Class
