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
        SuspendLayout()
        ' 
        ' btn_SignOut
        ' 
        btn_SignOut.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_SignOut.Location = New Point(13, 6)
        btn_SignOut.Name = "btn_SignOut"
        btn_SignOut.Size = New Size(92, 28)
        btn_SignOut.TabIndex = 1
        btn_SignOut.Text = "Sign Out"
        btn_SignOut.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(13, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 15)
        Label1.TabIndex = 2
        Label1.Text = "e-ID"
        ' 
        ' txtBox_eID
        ' 
        txtBox_eID.Location = New Point(78, 63)
        txtBox_eID.Name = "txtBox_eID"
        txtBox_eID.Size = New Size(138, 23)
        txtBox_eID.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(13, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 15)
        Label2.TabIndex = 2
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(13, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 2
        Label3.Text = "Surname"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 163)
        Label4.Name = "Label4"
        Label4.Size = New Size(29, 15)
        Label4.TabIndex = 2
        Label4.Text = "Age"
        ' 
        ' txtBox_Name
        ' 
        txtBox_Name.Location = New Point(78, 94)
        txtBox_Name.Name = "txtBox_Name"
        txtBox_Name.Size = New Size(138, 23)
        txtBox_Name.TabIndex = 3
        ' 
        ' txtBox_Surname
        ' 
        txtBox_Surname.Location = New Point(78, 129)
        txtBox_Surname.Name = "txtBox_Surname"
        txtBox_Surname.Size = New Size(138, 23)
        txtBox_Surname.TabIndex = 3
        ' 
        ' txtBox_Age
        ' 
        txtBox_Age.Location = New Point(78, 163)
        txtBox_Age.Name = "txtBox_Age"
        txtBox_Age.Size = New Size(138, 23)
        txtBox_Age.TabIndex = 3
        ' 
        ' btn_Save
        ' 
        btn_Save.BackColor = Color.PaleGreen
        btn_Save.FlatStyle = FlatStyle.Flat
        btn_Save.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Save.Location = New Point(13, 201)
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
        btn_Update.Location = New Point(111, 201)
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
        btn_Delete.Location = New Point(13, 235)
        btn_Delete.Name = "btn_Delete"
        btn_Delete.Size = New Size(92, 28)
        btn_Delete.TabIndex = 1
        btn_Delete.Text = "Delete"
        btn_Delete.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(253, 295)
        ControlBox = False
        Controls.Add(txtBox_Age)
        Controls.Add(txtBox_Surname)
        Controls.Add(txtBox_Name)
        Controls.Add(txtBox_eID)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_Delete)
        Controls.Add(btn_Update)
        Controls.Add(btn_Save)
        Controls.Add(btn_SignOut)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Data"
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
End Class
