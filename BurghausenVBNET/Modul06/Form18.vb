Public Class Form18
    Dim hersteller As New List(Of String) From {"BMW", "AUDI", "VW", "FORD", "Mazda", "Opel", "Renault", "GM", "Tesla", "Dacia", "Mercedes"}
    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.DataSource = hersteller
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        ListBox1.DataSource = hersteller.Where(Function(x) x.ToLower.Contains(TextBox1.Text.ToLower)).ToList
    End Sub
End Class