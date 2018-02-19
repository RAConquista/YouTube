Public Class LiveTV

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Sender01.Checked Then
            AxVLCPlugin21.playlist.items.clear()
            AxVLCPlugin21.playlist.add("https://daserstelive-lh.akamaihd.net/i/daserste_de@38086/index_2692_av-p.m3u8")
            AxVLCPlugin21.playlist.next()
            AxVLCPlugin21.playlist.play()
        End If
        If Sender02.Checked Then
            AxVLCPlugin21.playlist.items.clear()
            AxVLCPlugin21.playlist.add("http://zdf1314-lh.akamaihd.net/i/de14_v1@392878/index_3096_av-p.m3u8")
            AxVLCPlugin21.playlist.next()
            AxVLCPlugin21.playlist.play()
        End If
        If Sender03.Checked Then
            AxVLCPlugin21.playlist.items.clear()
            AxVLCPlugin21.playlist.add("http://zdf1112-lh.akamaihd.net/i/de12_v1@392882/index_3096_av-p.m3u8")
            AxVLCPlugin21.playlist.next()
            AxVLCPlugin21.playlist.play()
        End If
        If Sender04.Checked Then
            AxVLCPlugin21.playlist.items.clear()
            AxVLCPlugin21.playlist.add("http://zdf1314-lh.akamaihd.net/i/de13_v1@392877/index_3096_av-p.m3u8")
            AxVLCPlugin21.playlist.next()
            AxVLCPlugin21.playlist.play()
        End If
        If Sender05.Checked Then
            AxVLCPlugin21.playlist.items.clear()
            AxVLCPlugin21.playlist.add("https://artelive-lh.akamaihd.net/i/artelive_de@393591/index_1_av-p.m3u8")
            AxVLCPlugin21.playlist.next()
            AxVLCPlugin21.playlist.play()
        End If
        If Sender06.Checked Then
            AxVLCPlugin21.playlist.items.clear()
            AxVLCPlugin21.playlist.add("https://zdf0910-lh.akamaihd.net/i/dach10_v1@392872/index_1496_av-p.m3u8")
            AxVLCPlugin21.playlist.next()
            AxVLCPlugin21.playlist.play()
        End If
        If Sender07.Checked Then
            AxVLCPlugin21.playlist.items.clear()
            AxVLCPlugin21.playlist.add("http://orf2.orf.cdn.ors.at/orf2/q6a.sdp/chunklist.m3u8")
            AxVLCPlugin21.playlist.next()
            AxVLCPlugin21.playlist.play()
        End If
        If Sender08.Checked Then
            AxVLCPlugin21.playlist.items.clear()
            AxVLCPlugin21.playlist.add("https://brlive-lh.akamaihd.net/i/bralpha_germany@119899/index_3776_av-p.m3u8")
            AxVLCPlugin21.playlist.next()
            AxVLCPlugin21.playlist.play()
        End If
        If Sender09.Checked Then
            AxVLCPlugin21.playlist.items.clear()
            AxVLCPlugin21.playlist.add("https://rbblive-lh.akamaihd.net/i/rbb_brandenburg@349369/index_8_av-p.m3u8")
            AxVLCPlugin21.playlist.next()
            AxVLCPlugin21.playlist.play()
        End If
        If Sender10.Checked Then
            AxVLCPlugin21.playlist.items.clear()
            AxVLCPlugin21.playlist.add("http://mdrthuhls-lh.akamaihd.net/i/livetvmdrthueringen_de@514027/index_3776_av-p.m3u8")
            AxVLCPlugin21.playlist.next()
            AxVLCPlugin21.playlist.play()
        End If
        If Sender11.Checked Then
            AxVLCPlugin21.playlist.items.clear()
            AxVLCPlugin21.playlist.add("https://ndrfs-lh.akamaihd.net/i/ndrfs_mv@430232/index_3776_av-p.m3u8")
            AxVLCPlugin21.playlist.next()
            AxVLCPlugin21.playlist.play()
        End If
        If Sender12.Checked Then
            AxVLCPlugin21.playlist.items.clear()
            AxVLCPlugin21.playlist.add("https://sdn-global-live-http-cache.3qsdn.com/live/_definst_/mp4:5654_9rRqfHQLh4Yd6pm/playlist.m3u8")
            AxVLCPlugin21.playlist.next()
            AxVLCPlugin21.playlist.play()
        End If
        If Sender13.Checked Then
            AxVLCPlugin21.playlist.items.clear()
            AxVLCPlugin21.playlist.add("https://zdf0910-lh.akamaihd.net/i/de09_v1@392871/index_1496_av-p.m3u8")
            AxVLCPlugin21.playlist.next()
            AxVLCPlugin21.playlist.play()
        End If
        If Sender14.Checked Then
            AxVLCPlugin21.playlist.items.clear()
            AxVLCPlugin21.playlist.add("http://live2weltcms-lh.akamaihd.net/i/Live2WeltCMS_1@444563/index_1_av-p.m3u8")
            AxVLCPlugin21.playlist.next()
            AxVLCPlugin21.playlist.play()
        End If
        If Sender15.Checked Then
            AxVLCPlugin21.playlist.items.clear()
            AxVLCPlugin21.playlist.add("http://p.live.akamai.n-tv.de/hls-live/ntvlive/ntvlive_1500.m3u8")
            AxVLCPlugin21.playlist.next()
            AxVLCPlugin21.playlist.play()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Guide.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Time.Show()
    End Sub
End Class