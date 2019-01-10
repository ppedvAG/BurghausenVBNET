Public Class Form15
    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As ArrayList = New ArrayList()
        a.Add("Hannes")
        a.Add(1)
        a.Add(0)
        a.Add({"Hannes", "Preishuber"})
        If a.Count > 2 Then
            a.Item(0) = "dfdfsdf"
            a(0) = "sfdsd"
            a.Remove(0) 'Wert
            a.RemoveAt(0) 'index
            a.Insert(4, "Wert")
            If a.Contains("Hannes") Then

            End If
        End If


    End Sub
End Class