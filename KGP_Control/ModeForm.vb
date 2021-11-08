Public Class ModeForm
    Public Mode As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RBChoise.Checked = True Then
            Mode = True
        Else
            Mode = False
        End If
        Me.Close()
    End Sub
End Class