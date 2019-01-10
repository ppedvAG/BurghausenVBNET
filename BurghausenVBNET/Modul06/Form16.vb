Public Class Form16
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = ReplaceSonderzeichen(TextBox1.Text)


    End Sub
    Function ReplaceSonderzeichen(text As String) As String
        Dim ht As New Hashtable() From
            {{"Ö", "Oe"},
            {"Ä", "Ae"},
            {"Ü", "Ue"},
           {"ö", "oe"},
           {"ü", "ue"},
            {"ä", "ae"},
           {"ß", "ss"}
             }
        '  ht.Add("Ö", "OE")




        For Each item As DictionaryEntry In ht
            text = text.Replace(item.Key.ToString, item.Value.ToString)
        Next
        Return text
    End Function
End Class