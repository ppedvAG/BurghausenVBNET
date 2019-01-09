Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As List(Of String)
        Dim zahl As Integer?
        '= CInt(Rnd() * 49) + 1

        If Not CheckBox1.Checked = False And zahl < 26 And Not IsNothing(a) AndAlso a.Count > 1 Then
            Label1.Text = "checked"
        ElseIf CheckBox1.Checked And zahl > 25 Then
            Label1.Text = zahl.ToString

        Else
            Label1.Text = "unchecked"


        End If
        Dim x = If(IsNothing(a), "leer", "voll")

    End Sub
End Class