Imports System.ComponentModel
Public Class Pkw

    Public intern As Integer
    Public Property Fahrgestellnummer As String
    Public Property Schaltung As Integer
    ' Public Property Hersteller As String Kurzform
    Private _Hersteller As String
    Public Property Hersteller() As String
        Get
            Return _Hersteller
        End Get
        Set(ByVal value As String)
            Dim tmp As String
            Select Case value
                Case "BMW"
                    tmp = "DX"
                Case "AUDI"
                    tmp = "TU"
                Case Else
                    tmp = "XX"
            End Select
            tmp += CInt((Rnd() * 10000000)).ToString
            Fahrgestellnummer = tmp
            _Hersteller = value
        End Set
    End Property

















    Public Function Verschrotten() As Boolean
        Fahrgestellnummer = ""
        Return True
    End Function
    Public Sub New()

    End Sub
    Public Sub New(hersteller As String, schaltung As Integer, fahrgestellnummer As String)
        Me.Fahrgestellnummer = fahrgestellnummer
        Me.Schaltung = schaltung
        Me.Hersteller = hersteller
    End Sub
End Class

Enum Schaltung
    Automatik
    Manuell
End Enum

