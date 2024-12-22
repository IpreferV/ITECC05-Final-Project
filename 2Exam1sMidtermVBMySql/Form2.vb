Imports MySql.Data.MySqlClient

Public Class Form2
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub btn_SignOut_Click(sender As Object, e As EventArgs) Handles btn_SignOut.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password='';database=itecc05DB"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query = "INSERT INTO itecc05DB.eData (eID, name, surname, age) VALUES ('" & txtBox_eID.Text & "', '" & txtBox_Name.Text & "', '" & txtBox_Surname.Text & "', '" & txtBox_Age.Text & "')"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data saved.")

            MySqlConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MySqlConn.Close()
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

End Class