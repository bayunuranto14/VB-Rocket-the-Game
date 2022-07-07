Imports MySql.Data.MySqlClient
Public Class score
    Private Sub score_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        tampil_data()
    End Sub

    Sub tampil_data()
        '------- Untuk menampilkan data di datagrid -----------
        da = New MySqlDataAdapter("select * from score order by score desc", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "score")
        Me.DataGridView1.DataSource = (ds.Tables("score"))
        '-------------- diatas codingnya ---------------
    End Sub

    Private Sub Btn_ResetScore_Click(sender As Object, e As EventArgs) Handles Btn_ResetScore.Click
        AppRun.deletescore()
        tampil_data()
    End Sub


End Class