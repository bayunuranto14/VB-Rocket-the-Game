Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        Panel6.Hide()
        MainBGsound()
    End Sub

    Sub EpicBGSound()

        My.Computer.Audio.Play(My.Resources.audiobg, AudioPlayMode.BackgroundLoop)
    End Sub

    Sub MainBGsound()
        My.Computer.Audio.Play(My.Resources.mainbg, AudioPlayMode.BackgroundLoop)
    End Sub

    Sub ClickSound()
        My.Computer.Audio.Play(My.Resources.mouse_click, AudioPlayMode.Background)
    End Sub

    Sub AudioStop()
        My.Computer.Audio.Stop()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If TextBox1.Text = "" Then
            MsgBox("Nama Belom di isi!!", vbInformation, "Peringatan")
            TextBox1.Focus()
        Else
            ClickSound()
            MsgBox("Selamat Datang " + TextBox1.Text)
            EpicBGSound()
            AppRun.Show()
            Panel6.Show()
            Panel4.Hide()
            welcome.Show()
            Panel4.Visible = False
            welcome.TopLevel = False
            Panel7.Controls.Add(welcome)

            welcome.BringToFront()
            welcome.Show()
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result = MessageBox.Show(" Apakah Anda ingin keluar Game ini?", "Apa Anda yakin??", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox1.Text = "Music On"
            AudioStop()
        Else
            CheckBox1.Text = "Music Off"
            MainBGsound()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AppRun.Show()
        EpicBGSound()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        score.Show()
    End Sub


End Class
