Public Class Serien

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RB01.Checked Then
            Me.Close()
            S01.Show()
        End If
        If SB02.Checked Then
            Me.Close()
            S02.Show()
        End If
    End Sub
End Class