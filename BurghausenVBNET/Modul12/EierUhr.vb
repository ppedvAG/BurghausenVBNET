Public Class EierUhr
    Private meinTimer As New Timer
    Public Sub StartUhr(Minuten As Integer)
        meinTimer.Interval = Minuten * 60000
        AddHandler meinTimer.Tick, AddressOf EierFertig
        meinTimer.Start()
    End Sub

    Private Sub EierFertig(sender As Object, e As EventArgs)
        meinTimer.Stop()
        RemoveHandler meinTimer.Tick, AddressOf EierFertig
        RaiseEvent Fertig()
    End Sub

    Public Event Fertig()


End Class
