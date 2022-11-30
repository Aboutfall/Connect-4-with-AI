<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Me.TxtFirstname = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.txtsurname = New System.Windows.Forms.TextBox()
        Me.txtRePassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblrepassword = New System.Windows.Forms.Label()
        Me.Lblsurname = New System.Windows.Forms.Label()
        Me.lblFirstname = New System.Windows.Forms.Label()
        Me.Btnregister = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtFirstname
        '
        Me.TxtFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TxtFirstname.Location = New System.Drawing.Point(286, 94)
        Me.TxtFirstname.Name = "TxtFirstname"
        Me.TxtFirstname.Size = New System.Drawing.Size(187, 29)
        Me.TxtFirstname.TabIndex = 4
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TxtPassword.Location = New System.Drawing.Point(286, 200)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(187, 29)
        Me.TxtPassword.TabIndex = 5
        '
        'txtsurname
        '
        Me.txtsurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txtsurname.Location = New System.Drawing.Point(286, 150)
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.Size = New System.Drawing.Size(187, 29)
        Me.txtsurname.TabIndex = 6
        '
        'txtRePassword
        '
        Me.txtRePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.txtRePassword.Location = New System.Drawing.Point(286, 250)
        Me.txtRePassword.Name = "txtRePassword"
        Me.txtRePassword.Size = New System.Drawing.Size(187, 29)
        Me.txtRePassword.TabIndex = 7
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblPassword.Location = New System.Drawing.Point(166, 203)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(92, 24)
        Me.lblPassword.TabIndex = 8
        Me.lblPassword.Text = "Password"
        '
        'lblrepassword
        '
        Me.lblrepassword.AutoSize = True
        Me.lblrepassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblrepassword.Location = New System.Drawing.Point(90, 250)
        Me.lblrepassword.Name = "lblrepassword"
        Me.lblrepassword.Size = New System.Drawing.Size(168, 24)
        Me.lblrepassword.TabIndex = 9
        Me.lblrepassword.Text = "Re enter password"
        '
        'Lblsurname
        '
        Me.Lblsurname.AutoSize = True
        Me.Lblsurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Lblsurname.Location = New System.Drawing.Point(166, 153)
        Me.Lblsurname.Name = "Lblsurname"
        Me.Lblsurname.Size = New System.Drawing.Size(87, 24)
        Me.Lblsurname.TabIndex = 10
        Me.Lblsurname.Text = "Surname"
        '
        'lblFirstname
        '
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.lblFirstname.Location = New System.Drawing.Point(166, 99)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(93, 24)
        Me.lblFirstname.TabIndex = 11
        Me.lblFirstname.Text = "Firstname"
        '
        'Btnregister
        '
        Me.Btnregister.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Btnregister.Location = New System.Drawing.Point(580, 349)
        Me.Btnregister.Name = "Btnregister"
        Me.Btnregister.Size = New System.Drawing.Size(195, 89)
        Me.Btnregister.TabIndex = 12
        Me.Btnregister.Text = "Register"
        Me.Btnregister.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.BtnBack.Location = New System.Drawing.Point(12, 349)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(195, 89)
        Me.BtnBack.TabIndex = 13
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.Btnregister)
        Me.Controls.Add(Me.lblFirstname)
        Me.Controls.Add(Me.Lblsurname)
        Me.Controls.Add(Me.lblrepassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtRePassword)
        Me.Controls.Add(Me.txtsurname)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtFirstname)
        Me.Name = "frmRegister"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtFirstname As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents txtsurname As TextBox
    Friend WithEvents txtRePassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblrepassword As Label
    Friend WithEvents Lblsurname As Label
    Friend WithEvents lblFirstname As Label
    Friend WithEvents Btnregister As Button
    Friend WithEvents BtnBack As Button
End Class
