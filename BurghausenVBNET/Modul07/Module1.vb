Imports System.Runtime.CompilerServices

Module Module1
    <Extension()>
    Public Function ToDate(wert As Integer) As Date
        Return Date.Parse("01/01/1970").AddSeconds(wert)
    End Function

End Module
