Public Class Form19
    Private Sub Form19_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim procList As List(Of Process) = Diagnostics.Process.GetProcesses.ToList


        Dim q = From pc In procList
                Order By pc.PagedMemorySize64 Descending
                Select pc.ProcessName

        ListBox1.DataSource = q.ToArray


    End Sub
End Class