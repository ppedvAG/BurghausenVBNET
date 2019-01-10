Public Class Rechnung
    Public Property Kunde As String
    Public Property Summe As Integer
    Public Property RechnungPositionen() As List(Of Positionen)
    Public Sub New()
        _RechnungPositionen = New List(Of Positionen)
    End Sub
    Public Sub AddPosition(p As Positionen)
        Dim max As Integer
        If RechnungPositionen.Count > 0 Then
            max = _rechnungPositionen.Max(Function(x) x.Id)
        Else
            max = 0
        End If
        p.Id = max + 1
        RechnungPositionen.Add(p)
        Summe = _rechnungPositionen.Sum(Function(r) r.Anzahl * r.Preis)

    End Sub
End Class
