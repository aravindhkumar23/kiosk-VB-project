<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBill
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
        Me.mnuBill = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutClick2GoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstBill = New System.Windows.Forms.ListBox()
        Me.lblMoviecharge = New System.Windows.Forms.Label()
        Me.lblMoviechargesheader = New System.Windows.Forms.Label()
        Me.lblFoodchargesheader = New System.Windows.Forms.Label()
        Me.lblFoodcharge = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblSubtotalheader = New System.Windows.Forms.Label()
        Me.lblTaxesheader = New System.Windows.Forms.Label()
        Me.lblTaxes = New System.Windows.Forms.Label()
        Me.lblTotalheader = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.grpBill = New System.Windows.Forms.GroupBox()
        Me.grpCredittype = New System.Windows.Forms.GroupBox()
        Me.picVisa = New System.Windows.Forms.PictureBox()
        Me.picAmex = New System.Windows.Forms.PictureBox()
        Me.radVisa = New System.Windows.Forms.RadioButton()
        Me.radAmerican = New System.Windows.Forms.RadioButton()
        Me.grpCredit = New System.Windows.Forms.GroupBox()
        Me.lblCredittpye = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtCreditnumber = New System.Windows.Forms.TextBox()
        Me.txtCreditname = New System.Windows.Forms.TextBox()
        Me.lblnameheader = New System.Windows.Forms.Label()
        Me.lblnumberheader = New System.Windows.Forms.Label()
        Me.lblexpiryheader = New System.Windows.Forms.Label()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.picBanner = New System.Windows.Forms.PictureBox()
        Me.mnuBill.SuspendLayout()
        Me.grpBill.SuspendLayout()
        Me.grpCredittype.SuspendLayout()
        CType(Me.picVisa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAmex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCredit.SuspendLayout()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuBill
        '
        Me.mnuBill.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.mnuBill.Location = New System.Drawing.Point(0, 0)
        Me.mnuBill.Name = "mnuBill"
        Me.mnuBill.Size = New System.Drawing.Size(678, 24)
        Me.mnuBill.TabIndex = 13
        Me.mnuBill.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshPageToolStripMenuItem, Me.AboutClick2GoToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'RefreshPageToolStripMenuItem
        '
        Me.RefreshPageToolStripMenuItem.Name = "RefreshPageToolStripMenuItem"
        Me.RefreshPageToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RefreshPageToolStripMenuItem.Text = "Refresh Page"
        '
        'AboutClick2GoToolStripMenuItem
        '
        Me.AboutClick2GoToolStripMenuItem.Name = "AboutClick2GoToolStripMenuItem"
        Me.AboutClick2GoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutClick2GoToolStripMenuItem.Text = "About"
        '
        'lstBill
        '
        Me.lstBill.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBill.FormattingEnabled = True
        Me.lstBill.ItemHeight = 20
        Me.lstBill.Location = New System.Drawing.Point(6, 32)
        Me.lstBill.Name = "lstBill"
        Me.lstBill.ScrollAlwaysVisible = True
        Me.lstBill.Size = New System.Drawing.Size(301, 144)
        Me.lstBill.TabIndex = 14
        '
        'lblMoviecharge
        '
        Me.lblMoviecharge.BackColor = System.Drawing.Color.Silver
        Me.lblMoviecharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMoviecharge.Font = New System.Drawing.Font("Copperplate Gothic Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoviecharge.Location = New System.Drawing.Point(545, 32)
        Me.lblMoviecharge.Name = "lblMoviecharge"
        Me.lblMoviecharge.Size = New System.Drawing.Size(91, 31)
        Me.lblMoviecharge.TabIndex = 16
        Me.lblMoviecharge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMoviechargesheader
        '
        Me.lblMoviechargesheader.BackColor = System.Drawing.Color.Silver
        Me.lblMoviechargesheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMoviechargesheader.Font = New System.Drawing.Font("Copperplate Gothic Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoviechargesheader.Location = New System.Drawing.Point(313, 32)
        Me.lblMoviechargesheader.Name = "lblMoviechargesheader"
        Me.lblMoviechargesheader.Size = New System.Drawing.Size(234, 31)
        Me.lblMoviechargesheader.TabIndex = 15
        Me.lblMoviechargesheader.Text = "Movie Ticket Charges"
        Me.lblMoviechargesheader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFoodchargesheader
        '
        Me.lblFoodchargesheader.BackColor = System.Drawing.Color.Silver
        Me.lblFoodchargesheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFoodchargesheader.Font = New System.Drawing.Font("Copperplate Gothic Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodchargesheader.Location = New System.Drawing.Point(313, 63)
        Me.lblFoodchargesheader.Name = "lblFoodchargesheader"
        Me.lblFoodchargesheader.Size = New System.Drawing.Size(234, 31)
        Me.lblFoodchargesheader.TabIndex = 17
        Me.lblFoodchargesheader.Text = "Food and Beverages"
        Me.lblFoodchargesheader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFoodcharge
        '
        Me.lblFoodcharge.BackColor = System.Drawing.Color.Silver
        Me.lblFoodcharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFoodcharge.Font = New System.Drawing.Font("Copperplate Gothic Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodcharge.Location = New System.Drawing.Point(545, 63)
        Me.lblFoodcharge.Name = "lblFoodcharge"
        Me.lblFoodcharge.Size = New System.Drawing.Size(91, 31)
        Me.lblFoodcharge.TabIndex = 18
        Me.lblFoodcharge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BackColor = System.Drawing.Color.Silver
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubtotal.Font = New System.Drawing.Font("Copperplate Gothic Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(545, 94)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(91, 31)
        Me.lblSubtotal.TabIndex = 19
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSubtotalheader
        '
        Me.lblSubtotalheader.BackColor = System.Drawing.Color.Silver
        Me.lblSubtotalheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubtotalheader.Font = New System.Drawing.Font("Copperplate Gothic Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotalheader.Location = New System.Drawing.Point(313, 94)
        Me.lblSubtotalheader.Name = "lblSubtotalheader"
        Me.lblSubtotalheader.Size = New System.Drawing.Size(234, 31)
        Me.lblSubtotalheader.TabIndex = 20
        Me.lblSubtotalheader.Text = "Subtotal"
        Me.lblSubtotalheader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTaxesheader
        '
        Me.lblTaxesheader.BackColor = System.Drawing.Color.Silver
        Me.lblTaxesheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTaxesheader.Font = New System.Drawing.Font("Copperplate Gothic Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxesheader.Location = New System.Drawing.Point(313, 125)
        Me.lblTaxesheader.Name = "lblTaxesheader"
        Me.lblTaxesheader.Size = New System.Drawing.Size(234, 31)
        Me.lblTaxesheader.TabIndex = 22
        Me.lblTaxesheader.Text = "Taxes"
        Me.lblTaxesheader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTaxes
        '
        Me.lblTaxes.BackColor = System.Drawing.Color.Silver
        Me.lblTaxes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTaxes.Font = New System.Drawing.Font("Copperplate Gothic Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxes.Location = New System.Drawing.Point(545, 125)
        Me.lblTaxes.Name = "lblTaxes"
        Me.lblTaxes.Size = New System.Drawing.Size(91, 31)
        Me.lblTaxes.TabIndex = 21
        Me.lblTaxes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalheader
        '
        Me.lblTotalheader.BackColor = System.Drawing.Color.Silver
        Me.lblTotalheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalheader.Font = New System.Drawing.Font("Copperplate Gothic Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalheader.Location = New System.Drawing.Point(313, 156)
        Me.lblTotalheader.Name = "lblTotalheader"
        Me.lblTotalheader.Size = New System.Drawing.Size(234, 31)
        Me.lblTotalheader.TabIndex = 24
        Me.lblTotalheader.Text = "Total Bill"
        Me.lblTotalheader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Silver
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Copperplate Gothic Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(545, 156)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(91, 31)
        Me.lblTotal.TabIndex = 23
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpBill
        '
        Me.grpBill.BackColor = System.Drawing.Color.LightGray
        Me.grpBill.Controls.Add(Me.lblMoviechargesheader)
        Me.grpBill.Controls.Add(Me.lstBill)
        Me.grpBill.Controls.Add(Me.lblTotalheader)
        Me.grpBill.Controls.Add(Me.lblMoviecharge)
        Me.grpBill.Controls.Add(Me.lblTotal)
        Me.grpBill.Controls.Add(Me.lblFoodchargesheader)
        Me.grpBill.Controls.Add(Me.lblTaxesheader)
        Me.grpBill.Controls.Add(Me.lblFoodcharge)
        Me.grpBill.Controls.Add(Me.lblTaxes)
        Me.grpBill.Controls.Add(Me.lblSubtotal)
        Me.grpBill.Controls.Add(Me.lblSubtotalheader)
        Me.grpBill.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBill.Location = New System.Drawing.Point(17, 215)
        Me.grpBill.Name = "grpBill"
        Me.grpBill.Size = New System.Drawing.Size(652, 198)
        Me.grpBill.TabIndex = 25
        Me.grpBill.TabStop = False
        Me.grpBill.Text = "Bill"
        '
        'grpCredittype
        '
        Me.grpCredittype.BackColor = System.Drawing.Color.LightGray
        Me.grpCredittype.Controls.Add(Me.picVisa)
        Me.grpCredittype.Controls.Add(Me.picAmex)
        Me.grpCredittype.Controls.Add(Me.radVisa)
        Me.grpCredittype.Controls.Add(Me.radAmerican)
        Me.grpCredittype.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCredittype.Location = New System.Drawing.Point(20, 419)
        Me.grpCredittype.Name = "grpCredittype"
        Me.grpCredittype.Size = New System.Drawing.Size(649, 72)
        Me.grpCredittype.TabIndex = 26
        Me.grpCredittype.TabStop = False
        Me.grpCredittype.Text = "Select Payment Method"
        '
        'picVisa
        '
        Me.picVisa.Image = Global.FinalCompScience.My.Resources.Resources.visa
        Me.picVisa.Location = New System.Drawing.Point(432, 20)
        Me.picVisa.Name = "picVisa"
        Me.picVisa.Size = New System.Drawing.Size(75, 46)
        Me.picVisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVisa.TabIndex = 3
        Me.picVisa.TabStop = False
        '
        'picAmex
        '
        Me.picAmex.Image = Global.FinalCompScience.My.Resources.Resources.mas
        Me.picAmex.Location = New System.Drawing.Point(174, 20)
        Me.picAmex.Name = "picAmex"
        Me.picAmex.Size = New System.Drawing.Size(75, 46)
        Me.picAmex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAmex.TabIndex = 2
        Me.picAmex.TabStop = False
        '
        'radVisa
        '
        Me.radVisa.AutoSize = True
        Me.radVisa.Location = New System.Drawing.Point(352, 28)
        Me.radVisa.Name = "radVisa"
        Me.radVisa.Size = New System.Drawing.Size(59, 25)
        Me.radVisa.TabIndex = 1
        Me.radVisa.TabStop = True
        Me.radVisa.Text = "Visa"
        Me.radVisa.UseVisualStyleBackColor = True
        '
        'radAmerican
        '
        Me.radAmerican.AutoSize = True
        Me.radAmerican.Location = New System.Drawing.Point(86, 28)
        Me.radAmerican.Name = "radAmerican"
        Me.radAmerican.Size = New System.Drawing.Size(82, 25)
        Me.radAmerican.TabIndex = 0
        Me.radAmerican.TabStop = True
        Me.radAmerican.Text = "Mastro"
        Me.radAmerican.UseVisualStyleBackColor = True
        '
        'grpCredit
        '
        Me.grpCredit.BackColor = System.Drawing.Color.LightGray
        Me.grpCredit.Controls.Add(Me.lblCredittpye)
        Me.grpCredit.Controls.Add(Me.txtYear)
        Me.grpCredit.Controls.Add(Me.txtMonth)
        Me.grpCredit.Controls.Add(Me.txtCreditnumber)
        Me.grpCredit.Controls.Add(Me.txtCreditname)
        Me.grpCredit.Controls.Add(Me.lblnameheader)
        Me.grpCredit.Controls.Add(Me.lblnumberheader)
        Me.grpCredit.Controls.Add(Me.lblexpiryheader)
        Me.grpCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpCredit.Location = New System.Drawing.Point(20, 494)
        Me.grpCredit.Margin = New System.Windows.Forms.Padding(0)
        Me.grpCredit.Name = "grpCredit"
        Me.grpCredit.Size = New System.Drawing.Size(649, 117)
        Me.grpCredit.TabIndex = 27
        Me.grpCredit.TabStop = False
        Me.grpCredit.Visible = False
        '
        'lblCredittpye
        '
        Me.lblCredittpye.BackColor = System.Drawing.Color.Gray
        Me.lblCredittpye.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredittpye.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCredittpye.Location = New System.Drawing.Point(538, 86)
        Me.lblCredittpye.Name = "lblCredittpye"
        Me.lblCredittpye.Size = New System.Drawing.Size(108, 28)
        Me.lblCredittpye.TabIndex = 37
        Me.lblCredittpye.Text = "Label1"
        Me.lblCredittpye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(385, 76)
        Me.txtYear.MaxLength = 4
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(56, 20)
        Me.txtYear.TabIndex = 36
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(338, 76)
        Me.txtMonth.MaxLength = 2
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(41, 20)
        Me.txtMonth.TabIndex = 35
        '
        'txtCreditnumber
        '
        Me.txtCreditnumber.Location = New System.Drawing.Point(338, 48)
        Me.txtCreditnumber.MaxLength = 15
        Me.txtCreditnumber.Name = "txtCreditnumber"
        Me.txtCreditnumber.Size = New System.Drawing.Size(228, 20)
        Me.txtCreditnumber.TabIndex = 33
        '
        'txtCreditname
        '
        Me.txtCreditname.Location = New System.Drawing.Point(338, 19)
        Me.txtCreditname.MaxLength = 40
        Me.txtCreditname.Name = "txtCreditname"
        Me.txtCreditname.Size = New System.Drawing.Size(228, 20)
        Me.txtCreditname.TabIndex = 32
        '
        'lblnameheader
        '
        Me.lblnameheader.BackColor = System.Drawing.Color.Silver
        Me.lblnameheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnameheader.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnameheader.Location = New System.Drawing.Point(70, 18)
        Me.lblnameheader.Name = "lblnameheader"
        Me.lblnameheader.Size = New System.Drawing.Size(262, 29)
        Me.lblnameheader.TabIndex = 29
        Me.lblnameheader.Text = "Card Holder Name"
        Me.lblnameheader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblnumberheader
        '
        Me.lblnumberheader.BackColor = System.Drawing.Color.Silver
        Me.lblnumberheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnumberheader.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumberheader.Location = New System.Drawing.Point(70, 47)
        Me.lblnumberheader.Name = "lblnumberheader"
        Me.lblnumberheader.Size = New System.Drawing.Size(262, 29)
        Me.lblnumberheader.TabIndex = 30
        Me.lblnumberheader.Text = "Card No. "
        Me.lblnumberheader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblexpiryheader
        '
        Me.lblexpiryheader.BackColor = System.Drawing.Color.Silver
        Me.lblexpiryheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblexpiryheader.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexpiryheader.Location = New System.Drawing.Point(70, 76)
        Me.lblexpiryheader.Name = "lblexpiryheader"
        Me.lblexpiryheader.Size = New System.Drawing.Size(262, 29)
        Me.lblexpiryheader.TabIndex = 31
        Me.lblexpiryheader.Text = "Expiry Date (mm/year)"
        Me.lblexpiryheader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnProceed
        '
        Me.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProceed.Location = New System.Drawing.Point(529, 626)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(126, 32)
        Me.btnProceed.TabIndex = 28
        Me.btnProceed.Text = "Proceed  >>"
        Me.btnProceed.UseVisualStyleBackColor = True
        '
        'picBanner
        '
        Me.picBanner.Image = Global.FinalCompScience.My.Resources.Resources.techcinemas
        Me.picBanner.Location = New System.Drawing.Point(0, 46)
        Me.picBanner.Name = "picBanner"
        Me.picBanner.Size = New System.Drawing.Size(678, 145)
        Me.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBanner.TabIndex = 12
        Me.picBanner.TabStop = False
        '
        'frmBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 670)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.grpCredit)
        Me.Controls.Add(Me.grpCredittype)
        Me.Controls.Add(Me.grpBill)
        Me.Controls.Add(Me.mnuBill)
        Me.Controls.Add(Me.picBanner)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Your Total Bill"
        Me.mnuBill.ResumeLayout(False)
        Me.mnuBill.PerformLayout()
        Me.grpBill.ResumeLayout(False)
        Me.grpCredittype.ResumeLayout(False)
        Me.grpCredittype.PerformLayout()
        CType(Me.picVisa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAmex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCredit.ResumeLayout(False)
        Me.grpCredit.PerformLayout()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBanner As System.Windows.Forms.PictureBox
    Friend WithEvents mnuBill As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutClick2GoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstBill As System.Windows.Forms.ListBox
    Friend WithEvents lblMoviecharge As System.Windows.Forms.Label
    Friend WithEvents lblMoviechargesheader As System.Windows.Forms.Label
    Friend WithEvents lblFoodchargesheader As System.Windows.Forms.Label
    Friend WithEvents lblFoodcharge As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblSubtotalheader As System.Windows.Forms.Label
    Friend WithEvents lblTaxesheader As System.Windows.Forms.Label
    Friend WithEvents lblTaxes As System.Windows.Forms.Label
    Friend WithEvents lblTotalheader As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents grpBill As System.Windows.Forms.GroupBox
    Friend WithEvents grpCredittype As System.Windows.Forms.GroupBox
    Friend WithEvents radVisa As System.Windows.Forms.RadioButton
    Friend WithEvents radAmerican As System.Windows.Forms.RadioButton
    Friend WithEvents grpCredit As System.Windows.Forms.GroupBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents txtMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtCreditnumber As System.Windows.Forms.TextBox
    Friend WithEvents txtCreditname As System.Windows.Forms.TextBox
    Friend WithEvents lblnameheader As System.Windows.Forms.Label
    Friend WithEvents lblnumberheader As System.Windows.Forms.Label
    Friend WithEvents lblexpiryheader As System.Windows.Forms.Label
    Friend WithEvents lblCredittpye As System.Windows.Forms.Label
    Friend WithEvents btnProceed As System.Windows.Forms.Button
    Friend WithEvents picVisa As System.Windows.Forms.PictureBox
    Friend WithEvents picAmex As System.Windows.Forms.PictureBox
End Class
