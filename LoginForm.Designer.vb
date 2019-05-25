<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.loginPane = New System.Windows.Forms.Panel()
        Me.Login = New System.Windows.Forms.Button()
        Me.Password = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UserId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Register = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.loginPane.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(797, 53)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(297, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADMIN LOGIN"
        '
        'loginPane
        '
        Me.loginPane.BackColor = System.Drawing.SystemColors.ControlLight
        Me.loginPane.Controls.Add(Me.Register)
        Me.loginPane.Controls.Add(Me.Login)
        Me.loginPane.Controls.Add(Me.Password)
        Me.loginPane.Controls.Add(Me.Label3)
        Me.loginPane.Controls.Add(Me.UserId)
        Me.loginPane.Controls.Add(Me.Label2)
        Me.loginPane.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginPane.Location = New System.Drawing.Point(245, 90)
        Me.loginPane.Name = "loginPane"
        Me.loginPane.Size = New System.Drawing.Size(339, 284)
        Me.loginPane.TabIndex = 1
        '
        'Login
        '
        Me.Login.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Login.Location = New System.Drawing.Point(106, 191)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(124, 32)
        Me.Login.TabIndex = 4
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = False
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(140, 113)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(174, 23)
        Me.Password.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PASSWORD"
        '
        'UserId
        '
        Me.UserId.Location = New System.Drawing.Point(140, 60)
        Me.UserId.Name = "UserId"
        Me.UserId.Size = New System.Drawing.Size(174, 23)
        Me.UserId.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "USER LOGIN"
        '
        'Register
        '
        Me.Register.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Register.Location = New System.Drawing.Point(106, 242)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(124, 32)
        Me.Register.TabIndex = 5
        Me.Register.Text = "Register ?"
        Me.Register.UseVisualStyleBackColor = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.loginPane)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.loginPane.ResumeLayout(False)
        Me.loginPane.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents loginPane As Panel
    Friend WithEvents Login As Button
    Friend WithEvents Password As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents UserId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Register As Button
End Class
