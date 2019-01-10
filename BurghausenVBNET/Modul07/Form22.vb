Imports System.IO
Imports Newtonsoft.Json

Public Class Form22
    Dim neueRechnung As New Rechnung

    Private Sub Form22_Load(sender As Object, e As EventArgs) Handles Me.Load


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim p As New Positionen
        p.Anzahl = CInt(txtAnzahl.Text)
        p.Preis = CInt(txtPreis.Text)
        p.Text = txtBezeichnung.Text
        neueRechnung.AddPosition(p)
        refreshUI()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim id = CInt(txtID.Text)
        Dim r = neueRechnung.RechnungPositionen.First(Function(c) c.Id = id)
        neueRechnung.RechnungPositionen.Remove(r)
        refreshUI()
    End Sub
    Public Sub refreshUI()
        lblSumme.Text = CStr(neueRechnung.Summe)
        Dim bs As New BindingSource
        bs.DataSource = neueRechnung.RechnungPositionen
        DataGridView1.DataSource = bs
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        neueRechnung.Kunde = txtFirma.Text
        File.WriteAllText("C:\vb.net\BurghausenVBNET\BurghausenVBNET\rechnung.json",
                         JsonConvert.SerializeObject(neueRechnung))


    End Sub

    Private Sub bntLaden_Click(sender As Object, e As EventArgs) Handles bntLaden.Click
        neueRechnung = JsonConvert.DeserializeObject(Of Rechnung)(
            File.ReadAllText("C:\vb.net\BurghausenVBNET\BurghausenVBNET\rechnung.json"))
        txtFirma.Text = neueRechnung.Kunde
        refreshUI()
    End Sub
End Class