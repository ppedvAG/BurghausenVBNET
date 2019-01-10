Public Class Form17
    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim liste As New List(Of String) From {"Hannes", "Franz", "Sepp"}

        Dim dict As New Dictionary(Of String, String)
        Dim txtbx As New List(Of TextBox)


        liste.Add("Maria")

        'LINQ 
        Dim ergebnis = liste.Skip(2).Take(1)

        Dim ichschaudrauf = ergebnis.ToList


        'lambda Expression 

        Dim add = Function(num As Integer) num + 1
        Dim summe = add(15)

        summe = AddOldSchool(15)
        ' Dim liste As New List(Of String) From {"Hannes", "Franz", "Sepp"}
        Dim q = liste.Where(Function(x) x.Contains("i")).ToList



        Dim tmp As New List(Of String)
        For Each item As String In liste
            If item.Contains("i") Then
                tmp.Add(item)
            End If
        Next


    End Sub
    Function AddOldSchool(num As Integer) As Integer

        Return num + 1
    End Function
End Class