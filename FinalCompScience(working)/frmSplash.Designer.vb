<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Me.components = New System.ComponentModel.Container
        Me.tmrProgress = New System.Windows.Forms.Timer(Me.components)
        Me.tmrSwitch1 = New System.Windows.Forms.Timer(Me.components)
        Me.prgSwitch = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'tmrProgress
        '
        Me.tmrProgress.Interval = 500
        '
        'tmrSwitch1
        '
        Me.tmrSwitch1.Interval = 5500
        '
        'prgSwitch
        '
        Me.prgSwitch.Location = New System.Drawing.Point(250, 184)
        Me.prgSwitch.Name = "prgSwitch"
        Me.prgSwitch.Size = New System.Drawing.Size(232, 23)
        Me.prgSwitch.TabIndex = 0
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FinalCompScience.My.Resources.Resources.Click2Go
        Me.ClientSize = New System.Drawing.Size(494, 300)
        Me.Controls.Add(Me.prgSwitch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splash"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrProgress As System.Windows.Forms.Timer
    Friend WithEvents tmrSwitch1 As System.Windows.Forms.Timer
    Friend WithEvents prgSwitch As System.Windows.Forms.ProgressBar

End Class
