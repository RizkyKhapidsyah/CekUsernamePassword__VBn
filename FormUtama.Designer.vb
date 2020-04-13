<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.ltd1 = New System.Windows.Forms.Label()
        Me.ltd2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(123, 12)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxUsername.TabIndex = 0
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(123, 38)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxPassword.TabIndex = 1
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Location = New System.Drawing.Point(276, 65)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(78, 24)
        Me.ButtonLogin.TabIndex = 2
        Me.ButtonLogin.Text = "Button1"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Location = New System.Drawing.Point(12, 14)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(39, 13)
        Me.LabelUsername.TabIndex = 3
        Me.LabelUsername.Text = "Label1"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Location = New System.Drawing.Point(12, 41)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(39, 13)
        Me.LabelPassword.TabIndex = 4
        Me.LabelPassword.Text = "Label2"
        '
        'ltd1
        '
        Me.ltd1.AutoSize = True
        Me.ltd1.Location = New System.Drawing.Point(100, 15)
        Me.ltd1.Name = "ltd1"
        Me.ltd1.Size = New System.Drawing.Size(39, 13)
        Me.ltd1.TabIndex = 5
        Me.ltd1.Text = "Label1"
        '
        'ltd2
        '
        Me.ltd2.AutoSize = True
        Me.ltd2.Location = New System.Drawing.Point(100, 41)
        Me.ltd2.Name = "ltd2"
        Me.ltd2.Size = New System.Drawing.Size(39, 13)
        Me.ltd2.TabIndex = 6
        Me.ltd2.Text = "Label1"
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 96)
        Me.Controls.Add(Me.ltd2)
        Me.Controls.Add(Me.ltd1)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Name = "FormUtama"
        Me.Text = "Cek Username Dan Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents ltd1 As Label
    Friend WithEvents ltd2 As Label
End Class
