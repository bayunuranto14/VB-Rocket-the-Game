Public Class welcome
    Private Sub welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Form1.TextBox1.Text
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox2.Text = "Music On"
            Form1.AudioStop()
        Else
            CheckBox2.Text = "Music Off"
            Form1.MainBGsound()
        End If
    End Sub
End Class