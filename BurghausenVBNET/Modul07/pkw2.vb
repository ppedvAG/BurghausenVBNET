Imports System.ComponentModel.DataAnnotations
Imports System.Runtime.InteropServices

Public Class pkw2
    <Key>
    Property id As Integer
    <StringLength(50)>
    Property Text As String

    Function add() As Integer

    End Function
    '<DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    'Public Shared Function CreatePipe(<Out()> ByRef hReadPipe As SafeFileHandle, <Out()> ByRef hWritePipe As SafeFileHandle, ByRef lpPipeAttributes As SECURITY_ATTRIBUTES, ByVal nSize As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
    'End Function

End Class
