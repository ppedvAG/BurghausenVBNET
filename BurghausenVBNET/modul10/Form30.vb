Imports System.Net.Http

Public Class Form30
    Private Sub Form30_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetWetterAsync()
        Dim x = 1
    End Sub
    Public Async Function GetWetterAsync() As Task
        Dim url = "https://samples.openweathermap.org/data/2.5/weather?q=London,uk&appid=b6907d289e10d714a6e88b30761fae22"

        Using hc As New HttpClient

            Dim ret = Await hc.GetStringAsync(url)
            Label1.Text = ret
        End Using
    End Function
End Class