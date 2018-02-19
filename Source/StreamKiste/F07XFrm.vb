Public Class F07XFrm

    Private Sub F07C_CheckedChanged(sender As Object, e As EventArgs) Handles F07C.CheckedChanged
        If F07C.Checked Then
            Me.Close()
            F07.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Filme.Show()
    End Sub
End Class