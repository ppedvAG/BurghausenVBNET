
Public Class Rootobject
    Public Property coord As Coord
    Public Property weather() As Weather
    Public Property base As String
    Public Property main As Main
    Public Property visibility As Integer
    Public Property wind As Wind
    Public Property clouds As Clouds
    Public Property dt As Integer
    Public Property sys As Sys
    Public Property id As Integer
    Public Property name As String
    Public Property cod As Integer
End Class

Public Class Coord
    Public Property lon As Single
    Public Property lat As Single
End Class

Public Class Main
    Public Property temp As Single
    Public Property pressure As Integer
    Public Property humidity As Integer
    Public Property temp_min As Single
    Public Property temp_max As Single
End Class

Public Class Wind
    Public Property speed As Single
    Public Property deg As Integer
End Class

Public Class Clouds
    Public Property all As Integer
End Class

Public Class Sys
    Public Property type As Integer
    Public Property id As Integer
    Public Property message As Single
    Public Property country As String
    Public Property sunrise As Integer
    Public Property sunset As Integer
End Class

Public Class Weather
    Public Property id As Integer
    Public Property main As String
    Public Property description As String
    Public Property icon As String
End Class

