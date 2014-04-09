<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFood
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
        Me.components = New System.ComponentModel.Container()
        Me.mnuFood = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutClick2GoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.grpFoodselect = New System.Windows.Forms.GroupBox()
        Me.picHelp = New System.Windows.Forms.PictureBox()
        Me.lblBeverageheader = New System.Windows.Forms.Label()
        Me.lblFoodheader = New System.Windows.Forms.Label()
        Me.lstBeverages = New System.Windows.Forms.ListBox()
        Me.lstFood = New System.Windows.Forms.ListBox()
        Me.grpFood = New System.Windows.Forms.GroupBox()
        Me.lblFood3 = New System.Windows.Forms.Label()
        Me.lblFood2 = New System.Windows.Forms.Label()
        Me.lblfood1 = New System.Windows.Forms.Label()
        Me.btnAddfood = New System.Windows.Forms.Button()
        Me.cboFood3 = New System.Windows.Forms.ComboBox()
        Me.cboFood2 = New System.Windows.Forms.ComboBox()
        Me.cboFood1 = New System.Windows.Forms.ComboBox()
        Me.picFood = New System.Windows.Forms.PictureBox()
        Me.grpBeverages = New System.Windows.Forms.GroupBox()
        Me.lblBeverage3 = New System.Windows.Forms.Label()
        Me.lblBeverage2 = New System.Windows.Forms.Label()
        Me.lblBeverage1 = New System.Windows.Forms.Label()
        Me.btnAddbeverage = New System.Windows.Forms.Button()
        Me.cboBeverage3 = New System.Windows.Forms.ComboBox()
        Me.cboBeverage2 = New System.Windows.Forms.ComboBox()
        Me.cboBeverage1 = New System.Windows.Forms.ComboBox()
        Me.picBeverage = New System.Windows.Forms.PictureBox()
        Me.grpCart = New System.Windows.Forms.GroupBox()
        Me.lblCurrentotal = New System.Windows.Forms.Label()
        Me.lblCurrentotalheader = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lstFoodandBeverages = New System.Windows.Forms.ListBox()
        Me.lblClickshowtime = New System.Windows.Forms.Label()
        Me.lblAddfood = New System.Windows.Forms.Label()
        Me.lblAddbeverage = New System.Windows.Forms.Label()
        Me.tooltiphelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.picBanner = New System.Windows.Forms.PictureBox()
        Me.mnuFood.SuspendLayout()
        Me.grpFoodselect.SuspendLayout()
        CType(Me.picHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFood.SuspendLayout()
        CType(Me.picFood, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBeverages.SuspendLayout()
        CType(Me.picBeverage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCart.SuspendLayout()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuFood
        '
        Me.mnuFood.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.mnuFood.Location = New System.Drawing.Point(0, 0)
        Me.mnuFood.Name = "mnuFood"
        Me.mnuFood.Size = New System.Drawing.Size(839, 24)
        Me.mnuFood.TabIndex = 1
        Me.mnuFood.Text = "MenuStrip1"
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
        'btnProceed
        '
        Me.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProceed.Location = New System.Drawing.Point(689, 575)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(126, 32)
        Me.btnProceed.TabIndex = 18
        Me.btnProceed.Text = "Proceed  >"
        Me.btnProceed.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrevious.Location = New System.Drawing.Point(557, 575)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(126, 32)
        Me.btnPrevious.TabIndex = 19
        Me.btnPrevious.Text = "< Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'grpFoodselect
        '
        Me.grpFoodselect.BackColor = System.Drawing.Color.Gainsboro
        Me.grpFoodselect.Controls.Add(Me.picHelp)
        Me.grpFoodselect.Controls.Add(Me.lblBeverageheader)
        Me.grpFoodselect.Controls.Add(Me.lblFoodheader)
        Me.grpFoodselect.Controls.Add(Me.lstBeverages)
        Me.grpFoodselect.Controls.Add(Me.lstFood)
        Me.grpFoodselect.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFoodselect.Location = New System.Drawing.Point(18, 237)
        Me.grpFoodselect.Name = "grpFoodselect"
        Me.grpFoodselect.Size = New System.Drawing.Size(310, 142)
        Me.grpFoodselect.TabIndex = 20
        Me.grpFoodselect.TabStop = False
        Me.grpFoodselect.Text = "Food and Beverages"
        '
        'picHelp
        '
        Me.picHelp.Image = Global.FinalCompScience.My.Resources.Resources.question
        Me.picHelp.Location = New System.Drawing.Point(183, 0)
        Me.picHelp.Name = "picHelp"
        Me.picHelp.Size = New System.Drawing.Size(26, 23)
        Me.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHelp.TabIndex = 4
        Me.picHelp.TabStop = False
        Me.tooltiphelp.SetToolTip(Me.picHelp, "Please choose a food or beverage item to view more details")
        '
        'lblBeverageheader
        '
        Me.lblBeverageheader.BackColor = System.Drawing.Color.DarkGray
        Me.lblBeverageheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBeverageheader.Font = New System.Drawing.Font("Microsoft YaHei", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeverageheader.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBeverageheader.Location = New System.Drawing.Point(167, 36)
        Me.lblBeverageheader.Name = "lblBeverageheader"
        Me.lblBeverageheader.Size = New System.Drawing.Size(125, 22)
        Me.lblBeverageheader.TabIndex = 3
        Me.lblBeverageheader.Text = "Beverages"
        Me.lblBeverageheader.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblFoodheader
        '
        Me.lblFoodheader.BackColor = System.Drawing.Color.DarkGray
        Me.lblFoodheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFoodheader.Font = New System.Drawing.Font("Microsoft YaHei", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodheader.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFoodheader.Location = New System.Drawing.Point(20, 36)
        Me.lblFoodheader.Name = "lblFoodheader"
        Me.lblFoodheader.Size = New System.Drawing.Size(125, 22)
        Me.lblFoodheader.TabIndex = 2
        Me.lblFoodheader.Text = "Food"
        Me.lblFoodheader.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lstBeverages
        '
        Me.lstBeverages.BackColor = System.Drawing.Color.DimGray
        Me.lstBeverages.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBeverages.ForeColor = System.Drawing.SystemColors.Info
        Me.lstBeverages.FormattingEnabled = True
        Me.lstBeverages.ItemHeight = 21
        Me.lstBeverages.Items.AddRange(New Object() {"Pepsi", "Coke", "Sprite", "KoolAid"})
        Me.lstBeverages.Location = New System.Drawing.Point(167, 58)
        Me.lstBeverages.Name = "lstBeverages"
        Me.lstBeverages.ScrollAlwaysVisible = True
        Me.lstBeverages.Size = New System.Drawing.Size(125, 67)
        Me.lstBeverages.TabIndex = 1
        '
        'lstFood
        '
        Me.lstFood.BackColor = System.Drawing.Color.DimGray
        Me.lstFood.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFood.ForeColor = System.Drawing.SystemColors.Info
        Me.lstFood.FormattingEnabled = True
        Me.lstFood.ItemHeight = 21
        Me.lstFood.Items.AddRange(New Object() {"Popcorn", "Fries", "Candy", "Chips"})
        Me.lstFood.Location = New System.Drawing.Point(20, 58)
        Me.lstFood.Name = "lstFood"
        Me.lstFood.ScrollAlwaysVisible = True
        Me.lstFood.Size = New System.Drawing.Size(125, 67)
        Me.lstFood.TabIndex = 0
        '
        'grpFood
        '
        Me.grpFood.BackColor = System.Drawing.Color.Gainsboro
        Me.grpFood.Controls.Add(Me.lblFood3)
        Me.grpFood.Controls.Add(Me.lblFood2)
        Me.grpFood.Controls.Add(Me.lblfood1)
        Me.grpFood.Controls.Add(Me.btnAddfood)
        Me.grpFood.Controls.Add(Me.cboFood3)
        Me.grpFood.Controls.Add(Me.cboFood2)
        Me.grpFood.Controls.Add(Me.cboFood1)
        Me.grpFood.Controls.Add(Me.picFood)
        Me.grpFood.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFood.Location = New System.Drawing.Point(334, 237)
        Me.grpFood.Name = "grpFood"
        Me.grpFood.Size = New System.Drawing.Size(238, 309)
        Me.grpFood.TabIndex = 21
        Me.grpFood.TabStop = False
        Me.grpFood.Text = "Food"
        '
        'lblFood3
        '
        Me.lblFood3.BackColor = System.Drawing.Color.Silver
        Me.lblFood3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFood3.Location = New System.Drawing.Point(40, 226)
        Me.lblFood3.Name = "lblFood3"
        Me.lblFood3.Size = New System.Drawing.Size(94, 30)
        Me.lblFood3.TabIndex = 23
        Me.lblFood3.Text = "Large"
        '
        'lblFood2
        '
        Me.lblFood2.BackColor = System.Drawing.Color.Silver
        Me.lblFood2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFood2.Location = New System.Drawing.Point(40, 199)
        Me.lblFood2.Name = "lblFood2"
        Me.lblFood2.Size = New System.Drawing.Size(94, 30)
        Me.lblFood2.TabIndex = 22
        Me.lblFood2.Text = "Medium"
        '
        'lblfood1
        '
        Me.lblfood1.BackColor = System.Drawing.Color.Silver
        Me.lblfood1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblfood1.Location = New System.Drawing.Point(40, 169)
        Me.lblfood1.Name = "lblfood1"
        Me.lblfood1.Size = New System.Drawing.Size(94, 30)
        Me.lblfood1.TabIndex = 21
        Me.lblfood1.Text = "Small"
        '
        'btnAddfood
        '
        Me.btnAddfood.Location = New System.Drawing.Point(59, 270)
        Me.btnAddfood.Name = "btnAddfood"
        Me.btnAddfood.Size = New System.Drawing.Size(126, 32)
        Me.btnAddfood.TabIndex = 20
        Me.btnAddfood.Text = "Add To List"
        Me.btnAddfood.UseVisualStyleBackColor = True
        '
        'cboFood3
        '
        Me.cboFood3.FormattingEnabled = True
        Me.cboFood3.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cboFood3.Location = New System.Drawing.Point(132, 226)
        Me.cboFood3.Name = "cboFood3"
        Me.cboFood3.Size = New System.Drawing.Size(68, 29)
        Me.cboFood3.TabIndex = 11
        '
        'cboFood2
        '
        Me.cboFood2.FormattingEnabled = True
        Me.cboFood2.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cboFood2.Location = New System.Drawing.Point(132, 199)
        Me.cboFood2.Name = "cboFood2"
        Me.cboFood2.Size = New System.Drawing.Size(68, 29)
        Me.cboFood2.TabIndex = 10
        '
        'cboFood1
        '
        Me.cboFood1.FormattingEnabled = True
        Me.cboFood1.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cboFood1.Location = New System.Drawing.Point(132, 169)
        Me.cboFood1.Name = "cboFood1"
        Me.cboFood1.Size = New System.Drawing.Size(68, 29)
        Me.cboFood1.TabIndex = 9
        '
        'picFood
        '
        Me.picFood.Location = New System.Drawing.Point(59, 28)
        Me.picFood.Name = "picFood"
        Me.picFood.Size = New System.Drawing.Size(120, 114)
        Me.picFood.TabIndex = 4
        Me.picFood.TabStop = False
        '
        'grpBeverages
        '
        Me.grpBeverages.BackColor = System.Drawing.Color.Gainsboro
        Me.grpBeverages.Controls.Add(Me.lblBeverage3)
        Me.grpBeverages.Controls.Add(Me.lblBeverage2)
        Me.grpBeverages.Controls.Add(Me.lblBeverage1)
        Me.grpBeverages.Controls.Add(Me.btnAddbeverage)
        Me.grpBeverages.Controls.Add(Me.cboBeverage3)
        Me.grpBeverages.Controls.Add(Me.cboBeverage2)
        Me.grpBeverages.Controls.Add(Me.cboBeverage1)
        Me.grpBeverages.Controls.Add(Me.picBeverage)
        Me.grpBeverages.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBeverages.Location = New System.Drawing.Point(578, 237)
        Me.grpBeverages.Name = "grpBeverages"
        Me.grpBeverages.Size = New System.Drawing.Size(238, 309)
        Me.grpBeverages.TabIndex = 22
        Me.grpBeverages.TabStop = False
        Me.grpBeverages.Text = "Beverages"
        '
        'lblBeverage3
        '
        Me.lblBeverage3.BackColor = System.Drawing.Color.Silver
        Me.lblBeverage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBeverage3.Location = New System.Drawing.Point(35, 225)
        Me.lblBeverage3.Name = "lblBeverage3"
        Me.lblBeverage3.Size = New System.Drawing.Size(94, 30)
        Me.lblBeverage3.TabIndex = 26
        Me.lblBeverage3.Text = "Large"
        '
        'lblBeverage2
        '
        Me.lblBeverage2.BackColor = System.Drawing.Color.Silver
        Me.lblBeverage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBeverage2.Location = New System.Drawing.Point(35, 198)
        Me.lblBeverage2.Name = "lblBeverage2"
        Me.lblBeverage2.Size = New System.Drawing.Size(94, 30)
        Me.lblBeverage2.TabIndex = 25
        Me.lblBeverage2.Text = "Medium"
        '
        'lblBeverage1
        '
        Me.lblBeverage1.BackColor = System.Drawing.Color.Silver
        Me.lblBeverage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBeverage1.Location = New System.Drawing.Point(35, 169)
        Me.lblBeverage1.Name = "lblBeverage1"
        Me.lblBeverage1.Size = New System.Drawing.Size(94, 30)
        Me.lblBeverage1.TabIndex = 24
        Me.lblBeverage1.Text = "Small"
        '
        'btnAddbeverage
        '
        Me.btnAddbeverage.Location = New System.Drawing.Point(59, 270)
        Me.btnAddbeverage.Name = "btnAddbeverage"
        Me.btnAddbeverage.Size = New System.Drawing.Size(126, 32)
        Me.btnAddbeverage.TabIndex = 21
        Me.btnAddbeverage.Text = "Add To List"
        Me.btnAddbeverage.UseVisualStyleBackColor = True
        '
        'cboBeverage3
        '
        Me.cboBeverage3.FormattingEnabled = True
        Me.cboBeverage3.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cboBeverage3.Location = New System.Drawing.Point(128, 226)
        Me.cboBeverage3.Name = "cboBeverage3"
        Me.cboBeverage3.Size = New System.Drawing.Size(68, 29)
        Me.cboBeverage3.TabIndex = 14
        '
        'cboBeverage2
        '
        Me.cboBeverage2.FormattingEnabled = True
        Me.cboBeverage2.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cboBeverage2.Location = New System.Drawing.Point(128, 199)
        Me.cboBeverage2.Name = "cboBeverage2"
        Me.cboBeverage2.Size = New System.Drawing.Size(68, 29)
        Me.cboBeverage2.TabIndex = 13
        '
        'cboBeverage1
        '
        Me.cboBeverage1.FormattingEnabled = True
        Me.cboBeverage1.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cboBeverage1.Location = New System.Drawing.Point(128, 169)
        Me.cboBeverage1.Name = "cboBeverage1"
        Me.cboBeverage1.Size = New System.Drawing.Size(68, 29)
        Me.cboBeverage1.TabIndex = 12
        '
        'picBeverage
        '
        Me.picBeverage.Location = New System.Drawing.Point(59, 28)
        Me.picBeverage.Name = "picBeverage"
        Me.picBeverage.Size = New System.Drawing.Size(120, 114)
        Me.picBeverage.TabIndex = 4
        Me.picBeverage.TabStop = False
        '
        'grpCart
        '
        Me.grpCart.BackColor = System.Drawing.Color.Gainsboro
        Me.grpCart.Controls.Add(Me.lblCurrentotal)
        Me.grpCart.Controls.Add(Me.lblCurrentotalheader)
        Me.grpCart.Controls.Add(Me.btnRemove)
        Me.grpCart.Controls.Add(Me.lstFoodandBeverages)
        Me.grpCart.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCart.Location = New System.Drawing.Point(19, 385)
        Me.grpCart.Name = "grpCart"
        Me.grpCart.Size = New System.Drawing.Size(309, 161)
        Me.grpCart.TabIndex = 23
        Me.grpCart.TabStop = False
        Me.grpCart.Text = "Food selected"
        Me.grpCart.Visible = False
        '
        'lblCurrentotal
        '
        Me.lblCurrentotal.BackColor = System.Drawing.Color.Silver
        Me.lblCurrentotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrentotal.Location = New System.Drawing.Point(148, 112)
        Me.lblCurrentotal.Name = "lblCurrentotal"
        Me.lblCurrentotal.Size = New System.Drawing.Size(60, 21)
        Me.lblCurrentotal.TabIndex = 13
        Me.lblCurrentotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentotalheader
        '
        Me.lblCurrentotalheader.BackColor = System.Drawing.Color.Silver
        Me.lblCurrentotalheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrentotalheader.Location = New System.Drawing.Point(6, 112)
        Me.lblCurrentotalheader.Name = "lblCurrentotalheader"
        Me.lblCurrentotalheader.Size = New System.Drawing.Size(141, 21)
        Me.lblCurrentotalheader.TabIndex = 12
        Me.lblCurrentotalheader.Text = "Current Total  Rs"
        Me.lblCurrentotalheader.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(214, 107)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(81, 32)
        Me.btnRemove.TabIndex = 1
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lstFoodandBeverages
        '
        Me.lstFoodandBeverages.BackColor = System.Drawing.Color.Gainsboro
        Me.lstFoodandBeverages.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFoodandBeverages.FormattingEnabled = True
        Me.lstFoodandBeverages.ItemHeight = 20
        Me.lstFoodandBeverages.Location = New System.Drawing.Point(5, 28)
        Me.lstFoodandBeverages.Name = "lstFoodandBeverages"
        Me.lstFoodandBeverages.ScrollAlwaysVisible = True
        Me.lstFoodandBeverages.Size = New System.Drawing.Size(298, 64)
        Me.lstFoodandBeverages.TabIndex = 0
        '
        'lblClickshowtime
        '
        Me.lblClickshowtime.BackColor = System.Drawing.Color.Gainsboro
        Me.lblClickshowtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClickshowtime.Font = New System.Drawing.Font("Microsoft YaHei", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClickshowtime.Location = New System.Drawing.Point(41, 436)
        Me.lblClickshowtime.Name = "lblClickshowtime"
        Me.lblClickshowtime.Size = New System.Drawing.Size(269, 49)
        Me.lblClickshowtime.TabIndex = 11
        Me.lblClickshowtime.Text = "Click the 'Add' buttons to add the item to your list"
        Me.lblClickshowtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAddfood
        '
        Me.lblAddfood.BackColor = System.Drawing.Color.Gainsboro
        Me.lblAddfood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddfood.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddfood.Location = New System.Drawing.Point(374, 273)
        Me.lblAddfood.Name = "lblAddfood"
        Me.lblAddfood.Size = New System.Drawing.Size(188, 212)
        Me.lblAddfood.TabIndex = 24
        Me.lblAddfood.Text = "Select a food item for more options to be visible"
        Me.lblAddfood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAddbeverage
        '
        Me.lblAddbeverage.BackColor = System.Drawing.Color.Gainsboro
        Me.lblAddbeverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddbeverage.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddbeverage.Location = New System.Drawing.Point(605, 273)
        Me.lblAddbeverage.Name = "lblAddbeverage"
        Me.lblAddbeverage.Size = New System.Drawing.Size(188, 212)
        Me.lblAddbeverage.TabIndex = 25
        Me.lblAddbeverage.Text = "Select a food item for more options to be visible"
        Me.lblAddbeverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picBanner
        '
        Me.picBanner.Image = Global.FinalCompScience.My.Resources.Resources.techcinemas
        Me.picBanner.Location = New System.Drawing.Point(18, 39)
        Me.picBanner.Name = "picBanner"
        Me.picBanner.Size = New System.Drawing.Size(797, 171)
        Me.picBanner.TabIndex = 11
        Me.picBanner.TabStop = False
        '
        'frmFood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 617)
        Me.Controls.Add(Me.lblAddbeverage)
        Me.Controls.Add(Me.grpBeverages)
        Me.Controls.Add(Me.lblClickshowtime)
        Me.Controls.Add(Me.lblAddfood)
        Me.Controls.Add(Me.grpCart)
        Me.Controls.Add(Me.grpFood)
        Me.Controls.Add(Me.grpFoodselect)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.picBanner)
        Me.Controls.Add(Me.mnuFood)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(855, 655)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(855, 655)
        Me.Name = "frmFood"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Food & Beverages"
        Me.mnuFood.ResumeLayout(False)
        Me.mnuFood.PerformLayout()
        Me.grpFoodselect.ResumeLayout(False)
        CType(Me.picHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFood.ResumeLayout(False)
        CType(Me.picFood, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBeverages.ResumeLayout(False)
        CType(Me.picBeverage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCart.ResumeLayout(False)
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuFood As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutClick2GoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picBanner As System.Windows.Forms.PictureBox
    Friend WithEvents btnProceed As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents grpFoodselect As System.Windows.Forms.GroupBox
    Friend WithEvents lstFood As System.Windows.Forms.ListBox
    Friend WithEvents lstBeverages As System.Windows.Forms.ListBox
    Friend WithEvents lblFoodheader As System.Windows.Forms.Label
    Friend WithEvents lblBeverageheader As System.Windows.Forms.Label
    Friend WithEvents grpFood As System.Windows.Forms.GroupBox
    Friend WithEvents picFood As System.Windows.Forms.PictureBox
    Friend WithEvents grpBeverages As System.Windows.Forms.GroupBox
    Friend WithEvents picBeverage As System.Windows.Forms.PictureBox
    Friend WithEvents grpCart As System.Windows.Forms.GroupBox
    Friend WithEvents lblCurrentotal As System.Windows.Forms.Label
    Friend WithEvents lblCurrentotalheader As System.Windows.Forms.Label
    Friend WithEvents lblClickshowtime As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents lstFoodandBeverages As System.Windows.Forms.ListBox
    Friend WithEvents lblAddfood As System.Windows.Forms.Label
    Friend WithEvents lblAddbeverage As System.Windows.Forms.Label
    Friend WithEvents cboFood3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboFood2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboFood1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddfood As System.Windows.Forms.Button
    Friend WithEvents btnAddbeverage As System.Windows.Forms.Button
    Friend WithEvents cboBeverage3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboBeverage2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboBeverage1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblFood3 As System.Windows.Forms.Label
    Friend WithEvents lblFood2 As System.Windows.Forms.Label
    Friend WithEvents lblfood1 As System.Windows.Forms.Label
    Friend WithEvents lblBeverage3 As System.Windows.Forms.Label
    Friend WithEvents lblBeverage2 As System.Windows.Forms.Label
    Friend WithEvents lblBeverage1 As System.Windows.Forms.Label
    Friend WithEvents picHelp As System.Windows.Forms.PictureBox
    Friend WithEvents tooltiphelp As System.Windows.Forms.ToolTip
End Class
