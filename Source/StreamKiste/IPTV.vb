Public Class IPTV

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Process.Start("Data\Prog01.exe")
        Catch ex As Exception
            MsgBox("Dieser Service steht momentan nicht zur Verfügung")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Process.Start("Data\Prog02.exe")
        Catch ex As Exception
            MsgBox("Dieser Service steht momentan nicht zur Verfügung")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Process.Start("Data\Prog03.exe")
        Catch ex As Exception
            MsgBox("Dieser Service steht momentan nicht zur Verfügung")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Process.Start("Data\Prog04.exe")
        Catch ex As Exception
            MsgBox("Dieser Service steht momentan nicht zur Verfügung")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Process.Start("Data\Prog05.exe")
        Catch ex As Exception
            MsgBox("Dieser Service steht momentan nicht zur Verfügung")
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Process.Start("Data\Prog06.exe")
        Catch ex As Exception
            MsgBox("Dieser Service steht momentan nicht zur Verfügung")
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Process.Start("Data\Prog07.exe")
        Catch ex As Exception
            MsgBox("Dieser Service steht momentan nicht zur Verfügung")
        End Try
    End Sub
End Class