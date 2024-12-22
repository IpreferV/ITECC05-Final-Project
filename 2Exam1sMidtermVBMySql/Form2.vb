Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

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

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password='';database=itecc05DB"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query = "UPDATE itecc05DB.eData SET eid='" & txtBox_eID.Text & "', name='" & txtBox_Name.Text & "', surname='" & txtBox_Surname.Text & "', age='" & txtBox_Age.Text & "' WHERE eid = '" & txtBox_eID.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data updated.")

            MySqlConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MySqlConn.Close()
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password='';database=itecc05DB"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query = "DELETE FROM itecc05DB.edata WHERE eid='" & txtBox_eID.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data deleted.")

            MySqlConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MySqlConn.Close()
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub
End Class