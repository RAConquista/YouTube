Public Class F07

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Filme.Show()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles F07X.CheckedChanged
        If F07X.Checked Then
            Me.Close()
            F07XFrm.Show()
        End If
    End Sub
End Class