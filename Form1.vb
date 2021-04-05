Imports WMPLib
Public Class Form1
    Dim player As WindowsMediaPlayer = New WindowsMediaPlayer
    Dim SongLocation = "C:\Users\TiOluwanimi\Music\New folder\15. Nancy Mulligan.mp3"

    Dim song As WindowsMediaPlayer = New WindowsMediaPlayer
    Dim SongPlace = "C:\Users\TiOluwanimi\Music\New folder\01 Chandelier.mp3"

    Dim plays As WindowsMediaPlayer = New WindowsMediaPlayer
    Dim playPlaces = "C:\Users\TiOluwanimi\Music\New folder\reeves_jim_blueboy.mp3"

    Dim playsong As WindowsMediaPlayer = New WindowsMediaPlayer
    Dim playsongs = "C:\Users\TiOluwanimi\Music\New folder\can_help_falling_in_love.mp3"

    Dim e1 As WindowsMediaPlayer = New WindowsMediaPlayer
    Dim e2 = "C:\Users\TiOluwanimi\Music\New folder\15. Nancy Mulligan.mp3"


    Dim e4 = "C:\Users\TiOluwanimi\Music\New folder\reeves_jim_blueboy.mp3"


    Dim e6 = "C:\Users\TiOluwanimi\Music\New folder\can_help_falling_in_love.mp3"


    Dim e8 = "C:\Users\TiOluwanimi\Music\New folder\01 Chandelier.mp3"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 2000
        Timer1.Start()

        Timer2.Interval = 8000
        Timer2.Start()

        Timer3.Interval = 15000
        Timer3.Start()

        Timer4.Interval = 30000
        Timer4.Start()

        Timer5.Interval = 45000
        Timer5.Start()

        Timer6.Interval = 60000
        Timer6.Start()


        player.URL = SongLocation
        player.controls.play()


        song.URL = SongPlace
        song.controls.play()


        plays.URL = playPlaces
        plays.controls.play()


        playsong.URL = playsongs
        playsong.controls.play()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        player.URL = SongLocation
        player.controls.stop()
        Label12.Text = "CRITICAL SECTION"

        song.URL = SongPlace
        song.controls.stop()
        Label13.Text = "WAITING"

        plays.URL = playPlaces
        plays.controls.stop()
        Label14.Text = "WAITING"

        playsong.URL = playsongs
        playsong.controls.stop()
        Label15.Text = "WAITING"
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        e1.URL = e2
        e1.controls.play()
        Label12.Text = "CRITICAL SECTION"
        Timer2.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label12.Text = "EXECUTED"
        Label13.Text = "CRITICAL SECTION"

        e1.URL = e4
        e1.controls.play()
        Label13.Text = "CRITICAL SECTION"
        Timer3.Stop()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Label13.Text = "EXECUTED"
        Label14.Text = "CRITICAL SECTION"

        e1.URL = e6
        e1.controls.play()
        Label14.Text = "CRITICAL SECTION"
        Timer4.Stop()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick

        Label14.Text = "EXECUTED"
        Label15.Text = "CRITICAL SECTION"

        e1.URL = e8
        e1.controls.play()
        Label15.Text = "CRITICAL SECTION"
        Timer5.Stop()
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Label15.Text = "EXECUTED"
        MsgBox("ALL PROCESSES HAVE BEEN EXECUTED!", MsgBoxStyle.Information)
        e1.controls.stop()
        Timer6.Stop()
    End Sub
End Class
