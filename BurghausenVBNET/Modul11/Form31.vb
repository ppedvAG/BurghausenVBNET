Public Class Form31
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Form31_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Interval = 1000
        AddHandler Timer1.Tick, AddressOf RefreshClock

        Timer1.Start()
    End Sub

    Public Sub RefreshClock(sender As Object, e As EventArgs)
        Label1.Text = Date.Now.ToString("HH:mm:ss")
    End Sub
End Class