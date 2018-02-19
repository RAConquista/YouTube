Public Class H02

    Private Sub DimBtn_CheckedChanged(sender As Object, e As EventArgs) Handles DimBtn.CheckedChanged
        If DimBtn.Checked Then
            DimBG.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Books.Show()
    End Sub
End Class