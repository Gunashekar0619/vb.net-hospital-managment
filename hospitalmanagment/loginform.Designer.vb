<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginform))
        Me.signupwin = New System.Windows.Forms.Panel()
        Me.login2 = New System.Windows.Forms.Button()
        Me.signup2 = New System.Windows.Forms.Button()
        Me.confpassword = New System.Windows.Forms.TextBox()
        Me.userid2 = New System.Windows.Forms.TextBox()
        Me.newpassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.loginwin = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.signup = New System.Windows.Forms.Button()
        Me.login = New System.Windows.Forms.Button()
        Me.password = New System.Windows.Forms.TextBox()
        Me.userid = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.signupwin.SuspendLayout()
        Me.loginwin.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'signupwin
        '
        Me.signupwin.Controls.Add(Me.login2)
        Me.signupwin.Controls.Add(Me.signup2)
        Me.signupwin.Controls.Add(Me.confpassword)
        Me.signupwin.Controls.Add(Me.userid2)
        Me.signupwin.Controls.Add(Me.newpassword)
        Me.signupwin.Controls.Add(Me.Label6)
        Me.signupwin.Controls.Add(Me.Label5)
        Me.signupwin.Controls.Add(Me.Label7)
        Me.signupwin.Controls.Add(Me.Label4)
        Me.signupwin.Location = New System.Drawing.Point(622, 77)
        Me.signupwin.Name = "signupwin"
        Me.signupwin.Size = New System.Drawing.Size(483, 388)
        Me.signupwin.TabIndex = 2
        Me.signupwin.Visible = False
        '
        'login2
        '
        Me.login2.Font = New System.Drawing.Font("Maiandra GD", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login2.Location = New System.Drawing.Point(274, 304)
        Me.login2.Name = "login2"
        Me.login2.Size = New System.Drawing.Size(105, 42)
        Me.login2.TabIndex = 2
        Me.login2.Text = "LogIn"
        Me.login2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.login2.UseVisualStyleBackColor = True
        '
        'signup2
        '
        Me.signup2.Font = New System.Drawing.Font("Maiandra GD", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signup2.Location = New System.Drawing.Point(75, 304)
        Me.signup2.Name = "signup2"
        Me.signup2.Size = New System.Drawing.Size(109, 42)
        Me.signup2.TabIndex = 2
        Me.signup2.Text = "SignUp "
        Me.signup2.UseVisualStyleBackColor = True
        '
        'confpassword
        '
        Me.confpassword.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.confpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.confpassword.Font = New System.Drawing.Font("Maiandra GD", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confpassword.ForeColor = System.Drawing.SystemColors.MenuText
        Me.confpassword.Location = New System.Drawing.Point(236, 234)
        Me.confpassword.Name = "confpassword"
        Me.confpassword.Size = New System.Drawing.Size(202, 33)
        Me.confpassword.TabIndex = 1
        '
        'userid2
        '
        Me.userid2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.userid2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.userid2.Font = New System.Drawing.Font("Maiandra GD", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userid2.ForeColor = System.Drawing.SystemColors.MenuText
        Me.userid2.Location = New System.Drawing.Point(236, 100)
        Me.userid2.Name = "userid2"
        Me.userid2.Size = New System.Drawing.Size(202, 33)
        Me.userid2.TabIndex = 1
        '
        'newpassword
        '
        Me.newpassword.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.newpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.newpassword.Font = New System.Drawing.Font("Maiandra GD", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newpassword.ForeColor = System.Drawing.SystemColors.MenuText
        Me.newpassword.Location = New System.Drawing.Point(236, 166)
        Me.newpassword.Name = "newpassword"
        Me.newpassword.Size = New System.Drawing.Size(202, 33)
        Me.newpassword.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Confirm Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Enter Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Marker", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(164, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 50)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "SignUp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(71, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Userid"
        '
        'loginwin
        '
        Me.loginwin.Controls.Add(Me.PictureBox2)
        Me.loginwin.Controls.Add(Me.PictureBox1)
        Me.loginwin.Controls.Add(Me.Label3)
        Me.loginwin.Controls.Add(Me.signup)
        Me.loginwin.Controls.Add(Me.login)
        Me.loginwin.Controls.Add(Me.password)
        Me.loginwin.Controls.Add(Me.userid)
        Me.loginwin.Location = New System.Drawing.Point(57, 77)
        Me.loginwin.Name = "loginwin"
        Me.loginwin.Size = New System.Drawing.Size(425, 368)
        Me.loginwin.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(34, 203)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(34, 128)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Marker", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(132, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 50)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Login"
        '
        'signup
        '
        Me.signup.Font = New System.Drawing.Font("Maiandra GD", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signup.Location = New System.Drawing.Point(223, 276)
        Me.signup.Name = "signup"
        Me.signup.Size = New System.Drawing.Size(115, 37)
        Me.signup.TabIndex = 5
        Me.signup.Text = "SignUP"
        Me.signup.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.login.Font = New System.Drawing.Font("Maiandra GD", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.Location = New System.Drawing.Point(47, 275)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(111, 38)
        Me.login.TabIndex = 4
        Me.login.Text = "Login "
        Me.login.UseVisualStyleBackColor = True
        '
        'password
        '
        Me.password.AccessibleDescription = "Enter Password"
        Me.password.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.password.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.SystemColors.MenuText
        Me.password.Location = New System.Drawing.Point(77, 203)
        Me.password.Multiline = True
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(46)
        Me.password.Size = New System.Drawing.Size(272, 36)
        Me.password.TabIndex = 3
        '
        'userid
        '
        Me.userid.AccessibleDescription = "Enter Userid"
        Me.userid.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.userid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.userid.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.userid.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userid.ForeColor = System.Drawing.SystemColors.InfoText
        Me.userid.Location = New System.Drawing.Point(77, 128)
        Me.userid.Multiline = True
        Me.userid.Name = "userid"
        Me.userid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.userid.Size = New System.Drawing.Size(272, 36)
        Me.userid.TabIndex = 0
        Me.userid.Text = "Enter Userid"
        Me.userid.UseWaitCursor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1076, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 39)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'loginform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1198, 539)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.loginwin)
        Me.Controls.Add(Me.signupwin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loginform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.signupwin.ResumeLayout(False)
        Me.signupwin.PerformLayout()
        Me.loginwin.ResumeLayout(False)
        Me.loginwin.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents signupwin As System.Windows.Forms.Panel
    Friend WithEvents login2 As System.Windows.Forms.Button
    Friend WithEvents signup2 As System.Windows.Forms.Button
    Friend WithEvents confpassword As System.Windows.Forms.TextBox
    Friend WithEvents userid2 As System.Windows.Forms.TextBox
    Friend WithEvents newpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents loginwin As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents signup As System.Windows.Forms.Button
    Friend WithEvents login As System.Windows.Forms.Button
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents userid As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
