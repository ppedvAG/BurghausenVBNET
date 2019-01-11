Imports System.IO

Public Class Form23
    Private Sub Form23_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim r = New Rechnung
        Dim rr = New With {.ID = 1, .Text = "Text"}

        Using writer As TextWriter = File.CreateText("log.txt")
            Dim i = 1
            writer.WriteLine("This is line one.")
            writer.WriteLine("This is line two.")
        End Using

        Dim writer2 As TextWriter = File.CreateText("log.txt")

    End Sub
End Class