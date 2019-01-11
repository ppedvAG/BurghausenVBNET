Public Class Lotto
    Public Function GetZahl() As Integer
        Return CInt(Rnd() * 49)

    End Function

    Public Shared Function Zahl() As Integer
        Return CInt(Rnd() * 49)

    End Function
End Class
