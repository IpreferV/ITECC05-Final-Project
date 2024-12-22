Imports System.Security.Cryptography
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports LiveCharts
Imports LiveCharts.Helpers
Imports LiveCharts.Wpf.Charts.Base
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class Form2
    Dim gender As String
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
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
            Dim Query = "INSERT INTO itecc05DB.eData (eID, name, surname, age, gender, dob) VALUES ('" & txtBox_eID.Text & "', '" & txtBox_Name.Text & "', '" & txtBox_Surname.Text & "', '" & txtBox_Age.Text & "', '" & gender & "', '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "')"
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

        LoadTable()
    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password='';database=itecc05DB"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query = "UPDATE itecc05DB.eData SET eid='" & txtBox_eID.Text & "', name='" & txtBox_Name.Text & "', surname='" & txtBox_Surname.Text & "', age='" & txtBox_Age.Text & "', gender='" & gender & "', dob='" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' WHERE eid = '" & txtBox_eID.Text & "'"
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

        LoadTable()
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

        LoadTable()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password='';database=itecc05DB"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query = "SELECT * FROM itecc05DB.edata"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim sName = READER.GetString("name")
                ComboBox1.Items.Add(sName)
                ListBox1.Items.Add(sName)
            End While

            MySqlConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MySqlConn.Close()
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password='';database=itecc05DB"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query = "SELECT * FROM itecc05DB.edata WHERE name = '" & ComboBox1.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                txtBox_eID.Text = READER.GetInt32("eID")
                txtBox_Name.Text = READER.GetString("name")
                txtBox_Surname.Text = READER.GetString("surname")
                txtBox_Age.Text = READER.GetInt32("eID")
            End While


            MySqlConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MySqlConn.Close()
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password='';database=itecc05DB"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query = "SELECT * FROM itecc05DB.edata WHERE name = '" & ListBox1.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                txtBox_eID.Text = READER.GetInt32("eID")
                txtBox_Name.Text = READER.GetString("name")
                txtBox_Surname.Text = READER.GetString("surname")
                txtBox_Age.Text = READER.GetInt32("eID")
            End While


            MySqlConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MySqlConn.Close()
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub LoadTable()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password='';database=itecc05DB"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MySqlConn.Open()
            Dim Query = "SELECT eid as 'Employee ID', name as 'First Name', surname as 'Last Name', age as 'Age', gender as 'Gender', DATE_FORMAT(dob, '%Y-%m-%d') as 'Date of Birth' FROM itecc05DB.edata"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)

            MySqlConn.Close()

        Catch ex As MySqlException
            MsgBox(ex.Message)
            MySqlConn.Close()
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub btn_LoadTable_Click(sender As Object, e As EventArgs) Handles btn_LoadTable.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password='';database=itecc05DB"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MySqlConn.Open()
            Dim Query = "SELECT eid as 'Employee ID', name as 'First Name', surname as 'Last Name', age as 'Age', gender as 'Gender', DATE_FORMAT(dob, '%Y-%m-%d') as 'Date of Birth' FROM itecc05DB.edata"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)

            MySqlConn.Close()

        Catch ex As MySqlException
            MsgBox(ex.Message)
            MySqlConn.Close()
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub btn_LoadChart_Click(sender As Object, e As EventArgs) Handles btn_LoadChart.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password='';database=itecc05DB"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query = "SELECT * FROM itecc05DB.edata"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            Chart1.Series("Name vs. Age").Points.Clear()
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim pointIndex As Integer = Chart1.Series("Name vs. Age").Points.AddXY(READER.GetInt32("eid"), READER.GetInt32("age"))
                Chart1.Series("Name vs. Age").Points(pointIndex).AxisLabel = READER.GetString("name")
            End While

        Catch ex As MySqlException
            MySqlConn.Close()
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            txtBox_eID.Text = row.Cells("Employee ID").Value.ToString
            txtBox_Name.Text = row.Cells("First Name").Value.ToString
            txtBox_Surname.Text = row.Cells("Last Name").Value.ToString
            txtBox_Age.Text = row.Cells("Age").Value.ToString
        End If
    End Sub

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("[First Name] LIKE '%{0}%'", txt_Search.Text)
        DataGridView1.DataSource = DV
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialogue As DialogResult
        dialogue = MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo)
        If dialogue = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub btn_rad_M_CheckedChanged(sender As Object, e As EventArgs) Handles btn_rad_M.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub btn_rad_F_CheckedChanged(sender As Object, e As EventArgs) Handles btn_rad_F.CheckedChanged
        gender = "Female"
    End Sub
End Class