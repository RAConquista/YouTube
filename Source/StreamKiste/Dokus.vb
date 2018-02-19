Public Class Dokus

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DB01.Checked Then
            Me.Close()
            D01.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Main.Show()
    End Sub
End Class