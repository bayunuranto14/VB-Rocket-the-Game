Imports MySql.Data.MySqlClient
Module Module1
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public str As String


    Sub connect()
        Try
            Dim str As String = "Server=localhost;user id=root;password=;database=db_finalproject-game"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Function SQLTable(ByVal Source As String) As DataTable
        Try
            Dim adp As New MySqlDataAdapter(Source, conn)
            Dim DT As New DataTable
            adp.Fill(DT)
            SQLTable = DT
        Catch ex As Exception
            MsgBox(ex.Message)
            SQLTable = Nothing
        End Try
    End Function
End Module
