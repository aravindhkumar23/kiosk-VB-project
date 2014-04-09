<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceipt
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
        Me.lblprinting = New System.Windows.Forms.Label()
        Me.lblAddfood = New System.Windows.Forms.Label()
        Me.picBanner = New System.Windows.Forms.PictureBox()
        Me.picPrinter = New System.Windows.Forms.PictureBox()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPrinter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblprinting
        '
        Me.lblprinting.BackColor = System.Drawing.Color.Gainsboro
        Me.lblprinting.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprinting.Location = New System.Drawing.Point(12, 101)
        Me.lblprinting.Name = "lblprinting"
        Me.lblprinting.Size = New System.Drawing.Size(296, 86)
        Me.lblprinting.TabIndex = 1
        '
        'lblAddfood
        '
        Me.lblAddfood.BackColor = System.Drawing.Color.Gainsboro
        Me.lblAddfood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddfood.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddfood.Location = New System.Drawing.Point(16, 174)
        Me.lblAddfood.Name = "lblAddfood"
        Me.lblAddfood.Size = New System.Drawing.Size(332, 59)
        Me.lblAddfood.TabIndex = 25
        Me.lblAddfood.Text = "Thank you for using our Kiosk Service!"
        Me.lblAddfood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picBanner
        '
        Me.picBanner.Image = Global.FinalCompScience.My.Resources.Resources.techcinemas
        Me.picBanner.Location = New System.Drawing.Point(2, 7)
        Me.picBanner.Name = "picBanner"
        Me.picBanner.Size = New System.Drawing.Size(364, 88)
        Me.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBanner.TabIndex = 13
        Me.picBanner.TabStop = False
        '
        'picPrinter
        '
        Me.picPrinter.Image = Global.FinalCompScience.My.Resources.Resources.printer
        Me.picPrinter.Location = New System.Drawing.Point(299, 101)
        Me.picPrinter.Name = "picPrinter"
        Me.picPrinter.Size = New System.Drawing.Size(57, 60)
        Me.picPrinter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPrinter.TabIndex = 0
        Me.picPrinter.TabStop = False
        '
        'frmReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 240)
        Me.Controls.Add(Me.lblAddfood)
        Me.Controls.Add(Me.picBanner)
        Me.Controls.Add(Me.lblprinting)
        Me.Controls.Add(Me.picPrinter)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(384, 278)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(384, 278)
        Me.Name = "frmReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thankyou!"
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPrinter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picPrinter As System.Windows.Forms.PictureBox
    Friend WithEvents lblprinting As System.Windows.Forms.Label
    Friend WithEvents picBanner As System.Windows.Forms.PictureBox
    Friend WithEvents lblAddfood As System.Windows.Forms.Label
End Class
