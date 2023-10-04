Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim MyText As String
        MyText = "Visual Basic 2022"
        MsgBox(Len(MyText))
    End Sub
End Class
