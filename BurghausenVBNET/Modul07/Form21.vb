Public Class Form21
    Dim liste As New List(Of pkw)
    Private Sub Form21_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim p As New Pkw()
        p.Hersteller = "BMW"
        p.Schaltung = Schaltung.Automatik
        p.Fahrgestellnummer = "DX234234324"
        p.Verschrotten()


        liste.Add(p)

        liste.Add(New Pkw With {.Hersteller = "AUDI", .Schaltung = Schaltung.Manuell, .Fahrgestellnummer = "TU133434"})
        liste.Add(New Pkw With {.Hersteller = "AUDI", .Schaltung = Schaltung.Manuell, .Fahrgestellnummer = "TU134434"})
        liste.Add(New Pkw() With {.Hersteller = "AUDI", .Schaltung = Schaltung.Manuell})
        liste.Add(New Pkw("BMW", Schaltung.Manuell, "DX9877899989"))


        Dim p2 As New Pkw()
        p2.Hersteller = "BMW"
        p2.Schaltung = Schaltung.Automatik





    End Sub
End Class