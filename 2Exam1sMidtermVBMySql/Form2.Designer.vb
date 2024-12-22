<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        btn_SignOut = New Button()
        Label1 = New Label()
        txtBox_eID = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtBox_Name = New TextBox()
        txtBox_Surname = New TextBox()
        txtBox_Age = New TextBox()
        btn_Save = New Button()
        btn_Update = New Button()
        btn_Delete = New Button()
        ComboBox1 = New ComboBox()
        ListBox1 = New ListBox()
        DataGridView1 = New DataGridView()
        btn_LoadTable = New Button()
        txt_Search = New TextBox()
        Chart1 = New DataVisualization.Charting.Chart()
        btn_LoadChart = New Button()
        btn_rad_M = New RadioButton()
        btn_rad_F = New RadioButton()
        DateTimePicker1 = New DateTimePicker()
        Label5 = New Label()
        Label6 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_SignOut
        ' 
        btn_SignOut.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_SignOut.Location = New Point(12, 6)
        btn_SignOut.Name = "btn_SignOut"
        btn_SignOut.Size = New Size(70, 28)
        btn_SignOut.TabIndex = 1
        btn_SignOut.Text = "Sign Out"
        btn_SignOut.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(13, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 15)
        Label1.TabIndex = 2
        Label1.Text = "e-ID"
        ' 
        ' txtBox_eID
        ' 
        txtBox_eID.Location = New Point(78, 57)
        txtBox_eID.Name = "txtBox_eID"
        txtBox_eID.Size = New Size(138, 23)
        txtBox_eID.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(13, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 15)
        Label2.TabIndex = 2
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(13, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 2
        Label3.Text = "Surname"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 157)
        Label4.Name = "Label4"
        Label4.Size = New Size(29, 15)
        Label4.TabIndex = 2
        Label4.Text = "Age"
        ' 
        ' txtBox_Name
        ' 
        txtBox_Name.Location = New Point(78, 88)
        txtBox_Name.Name = "txtBox_Name"
        txtBox_Name.Size = New Size(138, 23)
        txtBox_Name.TabIndex = 3
        ' 
        ' txtBox_Surname
        ' 
        txtBox_Surname.Location = New Point(78, 123)
        txtBox_Surname.Name = "txtBox_Surname"
        txtBox_Surname.Size = New Size(138, 23)
        txtBox_Surname.TabIndex = 3
        ' 
        ' txtBox_Age
        ' 
        txtBox_Age.Location = New Point(78, 157)
        txtBox_Age.Name = "txtBox_Age"
        txtBox_Age.Size = New Size(138, 23)
        txtBox_Age.TabIndex = 3
        ' 
        ' btn_Save
        ' 
        btn_Save.BackColor = Color.PaleGreen
        btn_Save.FlatStyle = FlatStyle.Flat
        btn_Save.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Save.Location = New Point(23, 273)
        btn_Save.Name = "btn_Save"
        btn_Save.Size = New Size(92, 28)
        btn_Save.TabIndex = 1
        btn_Save.Text = "Save"
        btn_Save.UseVisualStyleBackColor = False
        ' 
        ' btn_Update
        ' 
        btn_Update.BackColor = Color.LemonChiffon
        btn_Update.FlatStyle = FlatStyle.Flat
        btn_Update.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Update.Location = New Point(121, 273)
        btn_Update.Name = "btn_Update"
        btn_Update.Size = New Size(92, 28)
        btn_Update.TabIndex = 1
        btn_Update.Text = "Update"
        btn_Update.UseVisualStyleBackColor = False
        ' 
        ' btn_Delete
        ' 
        btn_Delete.BackColor = Color.LightCoral
        btn_Delete.FlatStyle = FlatStyle.Flat
        btn_Delete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Delete.Location = New Point(23, 307)
        btn_Delete.Name = "btn_Delete"
        btn_Delete.Size = New Size(92, 28)
        btn_Delete.TabIndex = 1
        btn_Delete.Text = "Delete"
        btn_Delete.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.AllowDrop = True
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(88, 10)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(128, 23)
        ComboBox1.TabIndex = 4
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(222, 12)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(164, 19)
        ListBox1.TabIndex = 5
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(232, 59)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(554, 164)
        DataGridView1.TabIndex = 6
        ' 
        ' btn_LoadTable
        ' 
        btn_LoadTable.FlatStyle = FlatStyle.Flat
        btn_LoadTable.Location = New Point(487, 13)
        btn_LoadTable.Name = "btn_LoadTable"
        btn_LoadTable.Size = New Size(92, 28)
        btn_LoadTable.TabIndex = 7
        btn_LoadTable.Text = "Load Table"
        btn_LoadTable.UseVisualStyleBackColor = True
        ' 
        ' txt_Search
        ' 
        txt_Search.BorderStyle = BorderStyle.FixedSingle
        txt_Search.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_Search.Location = New Point(585, 12)
        txt_Search.Name = "txt_Search"
        txt_Search.Size = New Size(201, 29)
        txt_Search.TabIndex = 8
        ' 
        ' Chart1
        ' 
        ChartArea1.AxisX.Interval = 1R
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Angle = -90
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New Point(232, 229)
        Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Name vs. Age"
        Chart1.Series.Add(Series1)
        Chart1.Size = New Size(554, 183)
        Chart1.TabIndex = 9
        Chart1.Text = "Chart1"
        ' 
        ' btn_LoadChart
        ' 
        btn_LoadChart.FlatStyle = FlatStyle.Flat
        btn_LoadChart.Location = New Point(121, 307)
        btn_LoadChart.Name = "btn_LoadChart"
        btn_LoadChart.Size = New Size(92, 28)
        btn_LoadChart.TabIndex = 7
        btn_LoadChart.Text = "Load Chart"
        btn_LoadChart.UseVisualStyleBackColor = True
        ' 
        ' btn_rad_M
        ' 
        btn_rad_M.AutoSize = True
        btn_rad_M.Location = New Point(76, 220)
        btn_rad_M.Name = "btn_rad_M"
        btn_rad_M.Size = New Size(51, 19)
        btn_rad_M.TabIndex = 10
        btn_rad_M.TabStop = True
        btn_rad_M.Text = "Male"
        btn_rad_M.UseVisualStyleBackColor = True
        ' 
        ' btn_rad_F
        ' 
        btn_rad_F.AutoSize = True
        btn_rad_F.Location = New Point(133, 220)
        btn_rad_F.Name = "btn_rad_F"
        btn_rad_F.Size = New Size(63, 19)
        btn_rad_F.TabIndex = 10
        btn_rad_F.TabStop = True
        btn_rad_F.Text = "Female"
        btn_rad_F.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(78, 186)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(138, 23)
        DateTimePicker1.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(15, 191)
        Label5.Name = "Label5"
        Label5.Size = New Size(33, 15)
        Label5.TabIndex = 2
        Label5.Text = "DOB"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(15, 220)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 15)
        Label6.TabIndex = 2
        Label6.Text = "Gender"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(798, 429)
        Controls.Add(DateTimePicker1)
        Controls.Add(btn_rad_F)
        Controls.Add(btn_rad_M)
        Controls.Add(Chart1)
        Controls.Add(txt_Search)
        Controls.Add(btn_LoadChart)
        Controls.Add(btn_LoadTable)
        Controls.Add(DataGridView1)
        Controls.Add(ListBox1)
        Controls.Add(ComboBox1)
        Controls.Add(txtBox_Age)
        Controls.Add(txtBox_Surname)
        Controls.Add(txtBox_Name)
        Controls.Add(txtBox_eID)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_Delete)
        Controls.Add(btn_Update)
        Controls.Add(btn_Save)
        Controls.Add(btn_SignOut)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Data"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btn_SignOut As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBox_eID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBox_Name As TextBox
    Friend WithEvents txtBox_Surname As TextBox
    Friend WithEvents txtBox_Age As TextBox
    Friend WithEvents btn_Save As Button
    Friend WithEvents btn_Update As Button
    Friend WithEvents btn_Delete As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_LoadTable As Button
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents btn_LoadChart As Button
    Friend WithEvents btn_rad_M As RadioButton
    Friend WithEvents btn_rad_F As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
