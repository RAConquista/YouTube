Public Class Books

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If HB1.Checked Then
            Me.Close()
            H01.Show()
        End If
        If HB2.Checked Then
            Me.Close()
            H02.Show()
        End If
    End Sub
End Class