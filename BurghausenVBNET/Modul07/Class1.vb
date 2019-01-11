Imports BurghausenVBNET

Public Class Class1
    Implements IDisposable, ppedvInterface

    Public Sub Dispose() Implements IDisposable.Dispose
        Throw New NotImplementedException()
    End Sub

    Public Function Add(i As Integer) As Integer Implements ppedvInterface.Add
        Throw New NotImplementedException()
    End Function
End Class
Interface ppedvInterface
    Function Add(i As Integer) As Integer
End Interface
