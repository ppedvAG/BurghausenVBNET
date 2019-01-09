Public Class Form7

    Dim a(5) As String 'höchstes Element 

    Dim anrede() As String = {"Frau", "Herr", "Firma"}

    Dim zähler As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        a(zähler) = Rnd().ToString
        Dim x = a(5)
        ListBox1.DataSource = Nothing
        ListBox1.DataSource = a

        zähler += 1

    End Sub
    Sub MySub()
        ReDim a(10)

    End Sub
End Class