Imports MySql.Data.MySqlClient

Public Class Form1
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub btn_Test_Click(sender As Object, e As EventArgs) Handles btn_Test.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password='';database=usercredentials"

        Try
            MySqlConn.Open()
            MessageBox.Show("Success!", "Testing UserCredentials DB Connection")
            MySqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            MySqlConn.Close()
        End Try
    End Sub

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password='';database=usercredentials"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query = "SELECT * FROM usercredentials.user_data WHERE userName = '" & txtBox_userName.Text & "' AND userPassword = '" & txtBox_password.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0

            While READER.Read
                count += 1
            End While

            If count = 1 Then
                'MessageBox.Show("Logged in successfully.")
                Form2.Show()
                Me.Hide()
            ElseIf count > 1 Then
                MessageBox.Show("Duplicate credential found.")
            Else
                MessageBox.Show("Invalid credentials.")
            End If

            MySqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            MySqlConn.Close()
        End Try
    End Sub
End Class
