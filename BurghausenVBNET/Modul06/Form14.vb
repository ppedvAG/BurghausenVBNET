Public Class Form14
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i = Anrede.Firma.ToString
        Dim a = System.Enum.GetValues(GetType(Anrede))


        MessageBox.Show(Nothing, "Message", "Überschrift",
        MessageBoxButtons.OKCancel, MessageBoxIcon.Hand)


    End Sub
    Enum Anrede
        Herr = 1
        Frau = 5
        Firma=10
    End Enum
End Class
