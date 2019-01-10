Imports System.Text

Public Class Form20
    Private Sub Form20_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim d = Date.Now

        Dim s2 = "zeile 1" + Environment.NewLine
        s2 += "Zeile 2" + Environment.NewLine

        Dim sb = New StringBuilder
        sb.AppendLine("hallo")
        sb.AppendLine("Welt")
        add(sb, "Subfunktion")
        For index = 1 To 1000
            sb.AppendLine("hallo")
        Next
        Dim sb1 = sb 'Zeiger
        Dim s = sb.ToString
    End Sub

    Public Sub add(sb3 As StringBuilder, WernerParameter As String)
        sb3.AppendLine(WernerParameter)
    End Sub
End Class