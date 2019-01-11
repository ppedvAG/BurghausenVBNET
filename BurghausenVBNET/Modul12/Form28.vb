Public Class Form28
    Private Sub Form28_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On Error Resume Next 'mehr als obsolet

        Dim d As Date

        If Date.TryParse("30.02.2019", d) Then
            'erfolg
            GoTo Marke
        End If

        Dim a = CInt("aaaa")

        Try

            'Dim dd = CDate("30.02.2019")
            Dim i As Integer = Integer.MaxValue
            i += 1
        Catch ex As FormatException
            MessageBox.Show("das format ist jetzt aber unhübsch")
        Catch ex As OverflowException
            Throw ex
            MessageBox.Show(ex.Message)


        Catch ex As Exception
            Throw ex
        Finally


        End Try
        Dim x = "dfd"

Marke:
    End Sub
End Class