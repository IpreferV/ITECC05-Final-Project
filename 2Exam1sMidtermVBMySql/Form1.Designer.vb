<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btn_Test = New Button()
        txtBox_userName = New TextBox()
        Label1 = New Label()
        txtBox_password = New TextBox()
        Label2 = New Label()
        btn_Login = New Button()
        SuspendLayout()
        ' 
        ' btn_Test
        ' 
        btn_Test.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Test.Location = New Point(12, 12)
        btn_Test.Name = "btn_Test"
        btn_Test.Size = New Size(269, 53)
        btn_Test.TabIndex = 0
        btn_Test.Text = "Test Connection"
        btn_Test.UseVisualStyleBackColor = True
        ' 
        ' txtBox_userName
        ' 
        txtBox_userName.Location = New Point(99, 101)
        txtBox_userName.Name = "txtBox_userName"
        txtBox_userName.Size = New Size(182, 23)
        txtBox_userName.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 99)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 21)
        Label1.TabIndex = 2
        Label1.Text = "Username"
        ' 
        ' txtBox_password
        ' 
        txtBox_password.Location = New Point(99, 157)
        txtBox_password.Name = "txtBox_password"
        txtBox_password.PasswordChar = "*"c
        txtBox_password.Size = New Size(182, 23)
        txtBox_password.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 155)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 21)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' btn_Login
        ' 
        btn_Login.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Login.Location = New Point(206, 186)
        btn_Login.Name = "btn_Login"
        btn_Login.Size = New Size(75, 37)
        btn_Login.TabIndex = 4
        btn_Login.Text = "Login"
        btn_Login.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_Login)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtBox_password)
        Controls.Add(txtBox_userName)
        Controls.Add(btn_Test)
        Name = "Form1"
        Text = "Login Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_Test As Button
    Friend WithEvents txtBox_userName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBox_password As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_Login As Button

End Class
