<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmselection
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
        Me.lblDifficulty = New System.Windows.Forms.Label()
        Me.lblPlayers = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtDifficulty = New System.Windows.Forms.ComboBox()
        Me.txtNumbers = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblDifficulty
        '
        Me.lblDifficulty.AutoSize = True
        Me.lblDifficulty.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDifficulty.Location = New System.Drawing.Point(321, 78)
        Me.lblDifficulty.Name = "lblDifficulty"
        Me.lblDifficulty.Size = New System.Drawing.Size(84, 13)
        Me.lblDifficulty.TabIndex = 3
        Me.lblDifficulty.Text = "Select difficulty?"
        '
        'lblPlayers
        '
        Me.lblPlayers.AutoSize = True
        Me.lblPlayers.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPlayers.Location = New System.Drawing.Point(82, 78)
        Me.lblPlayers.Name = "lblPlayers"
        Me.lblPlayers.Size = New System.Drawing.Size(99, 13)
        Me.lblPlayers.TabIndex = 6
        Me.lblPlayers.Text = "How many players?"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(337, 314)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(155, 68)
        Me.btnNext.TabIndex = 12
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'txtDifficulty
        '
        Me.txtDifficulty.FormattingEnabled = True
        Me.txtDifficulty.Location = New System.Drawing.Point(309, 123)
        Me.txtDifficulty.Name = "txtDifficulty"
        Me.txtDifficulty.Size = New System.Drawing.Size(183, 21)
        Me.txtDifficulty.TabIndex = 13
        '
        'txtNumbers
        '
        Me.txtNumbers.FormattingEnabled = True
        Me.txtNumbers.Location = New System.Drawing.Point(12, 123)
        Me.txtNumbers.Name = "txtNumbers"
        Me.txtNumbers.Size = New System.Drawing.Size(183, 21)
        Me.txtNumbers.TabIndex = 14
        '
        'frmselection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 400)
        Me.Controls.Add(Me.txtNumbers)
        Me.Controls.Add(Me.txtDifficulty)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblPlayers)
        Me.Controls.Add(Me.lblDifficulty)
        Me.Name = "frmselection"
        Me.Text = "frmSelection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDifficulty As Label
    Friend WithEvents lblPlayers As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents txtDifficulty As ComboBox
    Friend WithEvents txtNumbers As ComboBox
End Class
