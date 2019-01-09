Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As String
        i = "1"
        Const pi = 3.1415926

        Dim d = 10.0R

        Dim farbe = &HFF00FF
        Dim b = &B10101010101

        Dim s = "heute ist der: " +
            Date.Now.ToString
        'string literal
        Dim heute = Date.Now.ToShortDateString
        heute = "Mittowch"
        Dim s1 = $"heute ist der {heute} Tag und pi ist noch immer {pi} {d:0000.00}" 'VB 14

        'string formater
        Dim neu = d.ToString("n9")


    End Sub
End Class