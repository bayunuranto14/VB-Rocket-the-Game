Imports MySql.Data.MySqlClient
Public Class AppRun

    Private Sub AppRun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        Form1.EpicBGSound()
        Label4.Text = Form1.TextBox1.Text
        tmr_score.Interval = 50
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TmrControl.Start()
        astronot.Top = astronot.Top - 50
    End Sub


    'bawah
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TmrControl.Start()
        astronot.Top = astronot.Top + 50
    End Sub


    Private Sub TmrControl_Tick(sender As Object, e As EventArgs) Handles TmrControl.Tick
        collicion()
    End Sub

    Sub inputdata()
        'save data
        Dim save As String
        save = "Insert into score(nama, score) values('" & Label4.Text _
                & "','" & Lb_score.Text & "')"
        cmd = New MySql.Data.MySqlClient.MySqlCommand(save, conn)
        cmd.ExecuteNonQuery()
    End Sub

    Sub gameover()
        TmrControl.Stop()
        Timer_obs.Stop()
        Timerbg.Stop()
        inputdata()


        My.Computer.Audio.Play(My.Resources.audiobg, AudioPlayMode.Background)

        Dim again = MessageBox.Show("Apakah Anda ingin mencoba mengulangi nya lagi ?", "Apa Anda yakin??", MessageBoxButtons.YesNo)
        If again = DialogResult.Yes Then
            TmrControl.Enabled = True
            Timer_obs.Enabled = True
            Timerbg.Enabled = True
            resetscore()
        Else
            My.Computer.Audio.Stop()
            My.Computer.Audio.Play(My.Resources.mainbg, AudioPlayMode.Background)
            score.Show()

        End If

    End Sub

    Sub resetscore()
        Lb_score.Text = 0
    End Sub

    Sub collicion()
        If astronot.Bounds.IntersectsWith(obs1.Bounds) Then
            TmrControl.Stop()
            Timerbg.Stop()
            tmr_score.Stop()
            gameover()

        End If
        If astronot.Bounds.IntersectsWith(obs2.Bounds) Then
            TmrControl.Stop()
            Timerbg.Stop()
            tmr_score.Stop()
            gameover()

        End If
        If astronot.Bounds.IntersectsWith(obs3.Bounds) Then
            TmrControl.Stop()
            Timerbg.Stop()
            tmr_score.Stop()
            gameover()

        End If
        If astronot.Bounds.IntersectsWith(obs4.Bounds) Then
            TmrControl.Stop()
            Timerbg.Stop()
            tmr_score.Stop()
            gameover()

        End If
        If astronot.Bounds.IntersectsWith(obs5.Bounds) Then
            TmrControl.Stop()
            Timerbg.Stop()
            tmr_score.Stop()
            gameover()

        End If
        If astronot.Bounds.IntersectsWith(obs6.Bounds) Then
            TmrControl.Stop()
            Timerbg.Stop()
            tmr_score.Stop()
            gameover()

        End If
        If astronot.Bounds.IntersectsWith(obs7.Bounds) Then
            TmrControl.Stop()
            Timerbg.Stop()
            tmr_score.Stop()
            gameover()

        End If
    End Sub

    Private Sub Timer_obs_Tick(sender As Object, e As EventArgs) Handles Timer_obs.Tick
        If obs1.Left < Me.Width And obs2.Left < Me.Width And obs3.Left < Me.Width Then
            obs1.Left = obs1.Left - 50
            obs2.Left = obs2.Left - 50
            obs3.Left = obs3.Left - 55
            obs4.Left = obs4.Left - 50
            obs5.Left = obs5.Left - 50
            obs6.Left = obs6.Left - 55
            obs7.Left = obs7.Left - 55
        Else
            obs1.Left = 0
            obs2.Left = 0
            obs3.Left = 0
            obs4.Left = 0
            obs5.Left = 0
            obs6.Left = 0
            obs7.Left = 0
        End If

        If (obs1.Left + obs1.Width) <= 0 Then
            obs1.Left = Me.Width
        End If
        obs1.Left = obs1.Left - 20

        If (obs2.Left + obs2.Width) <= 0 Then
            obs2.Left = Me.Width
        End If
        obs2.Left = obs2.Left - 20

        If (obs3.Left + obs3.Width) <= 0 Then
            obs3.Left = Me.Width
        End If
        obs3.Left = obs3.Left - 20

        If (obs4.Left + obs4.Width) <= 0 Then
            obs4.Left = Me.Width
        End If
        obs4.Left = obs4.Left - 20

        If (obs5.Left + obs5.Width) <= 0 Then
            obs5.Left = Me.Width
        End If
        obs5.Left = obs5.Left - 15

        If (obs6.Left + obs6.Width) <= 0 Then
            obs6.Left = Me.Width
        End If
        obs6.Left = obs6.Left - 10


        If (obs7.Left + obs7.Width) <= 0 Then
            obs7.Left = Me.Width
        End If
        obs7.Left = obs7.Left - 10
    End Sub


    Private Sub Timerbg_Tick(sender As Object, e As EventArgs) Handles Timerbg.Tick
        If Panel2.Left < Me.Width And Panel3.Left < Me.Width Then
            Panel2.Left = Panel2.Left - 50
            Panel3.Left = Panel3.Left - 50
        Else
            Panel2.Left = 0
            Panel3.Left = 0
        End If

        If Panel2.Left < Me.Width Then
            Panel2.Left = Panel2.Left - 10
        End If
        If Panel3.Left < Me.Width Then
            Panel3.Left = Panel3.Left - 10
        End If

        If (Panel2.Left + Panel2.Width) <= 0 Then
            Panel2.Left = Me.Width
        End If
        Panel2.Left = Panel2.Left - 10

        If (Panel3.Left + Panel3.Width) <= 0 Then
            Panel3.Left = Me.Width
        End If
        Panel3.Left = Panel3.Left - 10
    End Sub


    Private Sub tmr_score_Tick(sender As Object, e As EventArgs) Handles tmr_score.Tick
        Lb_score.Text += 1
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Label4.Text = Form1.TextBox1.Text
    End Sub

    Sub deletescore()
        connect()
        Dim delete As String = "truncate table score"
        cmd = New MySql.Data.MySqlClient.MySqlCommand(delete, conn)
        cmd.ExecuteNonQuery()
    End Sub
End Class