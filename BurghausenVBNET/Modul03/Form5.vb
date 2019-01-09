Imports System.Globalization

Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d = Date.Now
        ' Label1.Text = d.ToString("d", CultureInfo.CreateSpecificCulture("fr-fr"))
        CultureInfo.CurrentCulture = New CultureInfo("de-at")
        Label1.Text = d.ToShortDateString
        Label1.Text = d.ToString("d.MMM yy") 'date format expressions
        Label1.Text = d.AddDays(10).ToLongDateString
    End Sub
End Class