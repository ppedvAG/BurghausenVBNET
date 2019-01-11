Imports System.IO
Imports System.Text

Public Class Form29
    Dim liste As New List(Of Orte)
    Private Sub Form29_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datei = "C:\vb.net\BurghausenVBNET\BurghausenVBNET\modul10\germany_de.csv"
        Try
            Using sr = New StreamReader(datei, Encoding.UTF7)
                sr.ReadLine()

                While sr.Peek >= 0
                    Dim s = sr.ReadLine
                    s = s.Replace("""", "")
                    Dim a = s.Split(CType(";", Char()))
                    Dim ort As New Orte
                    ort.Plz = CInt(a(3))
                    ort.Name = a(4)
                    ort.Longitude = CDbl(a(16))
                    ort.Latitude = CDbl(a(17))
                    liste.Add(ort)
                End While
            End Using

        Catch ex As Exception
            MessageBox.Show("Fehler beim lesen der Datei Germany_de.csv")
            liste.Add(New Orte With {.Name = "Importfehler"})
        End Try
    End Sub
End Class