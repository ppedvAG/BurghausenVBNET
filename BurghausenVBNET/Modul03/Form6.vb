Public Class Form6
    Public i As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer?
        Dim o As Object
        Dim b = IsNothing(i)
        i = 12
        i = Nothing

        Dim s As String

        Dim isnix = String.IsNullOrEmpty(s) '"" oder nothing


    End Sub
    Sub MySub()
        ' i ist 1
        i = 2

    End Sub
End Class