Public Class Form32
    Dim eier As New EierUhr
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        eier.StartUhr(1)
        Button1.BackColor = Color.Red
    End Sub

    Private Sub Form32_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler eier.Fertig, Sub() MessageBox.Show("Eier fertig")
    End Sub
End Class