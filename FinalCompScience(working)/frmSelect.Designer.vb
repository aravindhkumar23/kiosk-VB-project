<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelect
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
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.grpPlaying = New System.Windows.Forms.GroupBox()
        Me.pichelpPlaying = New System.Windows.Forms.PictureBox()
        Me.lstPlaying = New System.Windows.Forms.ListBox()
        Me.grpOverview = New System.Windows.Forms.GroupBox()
        Me.lblShow4 = New System.Windows.Forms.Label()
        Me.lblStartadding = New System.Windows.Forms.Label()
        Me.lblShow3 = New System.Windows.Forms.Label()
        Me.lblShow2 = New System.Windows.Forms.Label()
        Me.lblShow1 = New System.Windows.Forms.Label()
        Me.lblShowtime = New System.Windows.Forms.Label()
        Me.lblShowtimeheader = New System.Windows.Forms.Label()
        Me.lblSynopsis = New System.Windows.Forms.Label()
        Me.lbllength = New System.Windows.Forms.Label()
        Me.lbllengthheader = New System.Windows.Forms.Label()
        Me.lblSynopsisheader = New System.Windows.Forms.Label()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.lblGenreheader = New System.Windows.Forms.Label()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.lblRatingheader = New System.Windows.Forms.Label()
        Me.lblRelease = New System.Windows.Forms.Label()
        Me.lblReleaseheader = New System.Windows.Forms.Label()
        Me.lblmovie = New System.Windows.Forms.Label()
        Me.lblnameheader = New System.Windows.Forms.Label()
        Me.picMovie = New System.Windows.Forms.PictureBox()
        Me.grpCart = New System.Windows.Forms.GroupBox()
        Me.lblCurrentotal = New System.Windows.Forms.Label()
        Me.lblCurrentotalheader = New System.Windows.Forms.Label()
        Me.lblClickshowtime = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lstCart = New System.Windows.Forms.ListBox()
        Me.mnuSelect = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutClick2GoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tooltiphelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.picBanner = New System.Windows.Forms.PictureBox()
        Me.grpPlaying.SuspendLayout()
        CType(Me.pichelpPlaying, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOverview.SuspendLayout()
        CType(Me.picMovie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCart.SuspendLayout()
        Me.mnuSelect.SuspendLayout()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnProceed
        '
        Me.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProceed.Location = New System.Drawing.Point(701, 575)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(126, 32)
        Me.btnProceed.TabIndex = 17
        Me.btnProceed.Text = "Proceed  >"
        Me.btnProceed.UseVisualStyleBackColor = True
        '
        'grpPlaying
        '
        Me.grpPlaying.BackColor = System.Drawing.Color.Gainsboro
        Me.grpPlaying.Controls.Add(Me.pichelpPlaying)
        Me.grpPlaying.Controls.Add(Me.lstPlaying)
        Me.grpPlaying.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPlaying.Location = New System.Drawing.Point(12, 228)
        Me.grpPlaying.Name = "grpPlaying"
        Me.grpPlaying.Size = New System.Drawing.Size(338, 183)
        Me.grpPlaying.TabIndex = 15
        Me.grpPlaying.TabStop = False
        Me.grpPlaying.Text = "Currently Playing"
        '
        'pichelpPlaying
        '
        Me.pichelpPlaying.Image = Global.FinalCompScience.My.Resources.Resources.question
        Me.pichelpPlaying.Location = New System.Drawing.Point(160, 1)
        Me.pichelpPlaying.Name = "pichelpPlaying"
        Me.pichelpPlaying.Size = New System.Drawing.Size(25, 22)
        Me.pichelpPlaying.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pichelpPlaying.TabIndex = 1
        Me.pichelpPlaying.TabStop = False
        Me.tooltiphelp.SetToolTip(Me.pichelpPlaying, "Click on a movie to view its details")
        '
        'lstPlaying
        '
        Me.lstPlaying.BackColor = System.Drawing.Color.Gainsboro
        Me.lstPlaying.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPlaying.FormattingEnabled = True
        Me.lstPlaying.ItemHeight = 21
        Me.lstPlaying.Items.AddRange(New Object() {"Vanakam Chennai", "Onaium Atukutium", "Naiyandi", "Fast and Furious 6", "Man of Steel", "The Conjuring", "Marley and Me", "Mall cop"})
        Me.lstPlaying.Location = New System.Drawing.Point(6, 29)
        Me.lstPlaying.Name = "lstPlaying"
        Me.lstPlaying.ScrollAlwaysVisible = True
        Me.lstPlaying.Size = New System.Drawing.Size(328, 151)
        Me.lstPlaying.TabIndex = 0
        '
        'grpOverview
        '
        Me.grpOverview.BackColor = System.Drawing.Color.Gainsboro
        Me.grpOverview.Controls.Add(Me.lblShow4)
        Me.grpOverview.Controls.Add(Me.lblStartadding)
        Me.grpOverview.Controls.Add(Me.lblShow3)
        Me.grpOverview.Controls.Add(Me.lblShow2)
        Me.grpOverview.Controls.Add(Me.lblShow1)
        Me.grpOverview.Controls.Add(Me.lblShowtime)
        Me.grpOverview.Controls.Add(Me.lblShowtimeheader)
        Me.grpOverview.Controls.Add(Me.lblSynopsis)
        Me.grpOverview.Controls.Add(Me.lbllength)
        Me.grpOverview.Controls.Add(Me.lbllengthheader)
        Me.grpOverview.Controls.Add(Me.lblSynopsisheader)
        Me.grpOverview.Controls.Add(Me.lblGenre)
        Me.grpOverview.Controls.Add(Me.lblGenreheader)
        Me.grpOverview.Controls.Add(Me.lblRating)
        Me.grpOverview.Controls.Add(Me.lblRatingheader)
        Me.grpOverview.Controls.Add(Me.lblRelease)
        Me.grpOverview.Controls.Add(Me.lblReleaseheader)
        Me.grpOverview.Controls.Add(Me.lblmovie)
        Me.grpOverview.Controls.Add(Me.lblnameheader)
        Me.grpOverview.Controls.Add(Me.picMovie)
        Me.grpOverview.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOverview.Location = New System.Drawing.Point(356, 228)
        Me.grpOverview.Name = "grpOverview"
        Me.grpOverview.Size = New System.Drawing.Size(471, 337)
        Me.grpOverview.TabIndex = 14
        Me.grpOverview.TabStop = False
        Me.grpOverview.Text = "Movie Overview"
        Me.grpOverview.Visible = False
        '
        'lblShow4
        '
        Me.lblShow4.BackColor = System.Drawing.Color.Gainsboro
        Me.lblShow4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShow4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblShow4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShow4.ForeColor = System.Drawing.Color.Blue
        Me.lblShow4.Location = New System.Drawing.Point(371, 293)
        Me.lblShow4.MaximumSize = New System.Drawing.Size(82, 21)
        Me.lblShow4.Name = "lblShow4"
        Me.lblShow4.Size = New System.Drawing.Size(82, 21)
        Me.lblShow4.TabIndex = 18
        Me.lblShow4.Text = "03:00 pm"
        '
        'lblStartadding
        '
        Me.lblStartadding.BackColor = System.Drawing.Color.Gainsboro
        Me.lblStartadding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStartadding.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartadding.Location = New System.Drawing.Point(28, 173)
        Me.lblStartadding.Name = "lblStartadding"
        Me.lblStartadding.Size = New System.Drawing.Size(419, 76)
        Me.lblStartadding.TabIndex = 10
        Me.lblStartadding.Text = "Click a movie to view showtimes and other details."
        Me.lblStartadding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblShow3
        '
        Me.lblShow3.BackColor = System.Drawing.Color.Gainsboro
        Me.lblShow3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShow3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblShow3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShow3.ForeColor = System.Drawing.Color.Blue
        Me.lblShow3.Location = New System.Drawing.Point(255, 293)
        Me.lblShow3.Name = "lblShow3"
        Me.lblShow3.Size = New System.Drawing.Size(82, 21)
        Me.lblShow3.TabIndex = 17
        Me.lblShow3.Text = "03:00 pm"
        '
        'lblShow2
        '
        Me.lblShow2.BackColor = System.Drawing.Color.Gainsboro
        Me.lblShow2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShow2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblShow2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShow2.ForeColor = System.Drawing.Color.Blue
        Me.lblShow2.Location = New System.Drawing.Point(138, 293)
        Me.lblShow2.Name = "lblShow2"
        Me.lblShow2.Size = New System.Drawing.Size(82, 21)
        Me.lblShow2.TabIndex = 16
        Me.lblShow2.Text = "03:00 pm"
        '
        'lblShow1
        '
        Me.lblShow1.BackColor = System.Drawing.Color.Gainsboro
        Me.lblShow1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShow1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblShow1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShow1.ForeColor = System.Drawing.Color.Blue
        Me.lblShow1.Location = New System.Drawing.Point(18, 293)
        Me.lblShow1.Name = "lblShow1"
        Me.lblShow1.Size = New System.Drawing.Size(82, 21)
        Me.lblShow1.TabIndex = 15
        Me.lblShow1.Text = "03:00 pm"
        '
        'lblShowtime
        '
        Me.lblShowtime.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblShowtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShowtime.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowtime.Location = New System.Drawing.Point(11, 283)
        Me.lblShowtime.Name = "lblShowtime"
        Me.lblShowtime.Size = New System.Drawing.Size(454, 43)
        Me.lblShowtime.TabIndex = 14
        '
        'lblShowtimeheader
        '
        Me.lblShowtimeheader.BackColor = System.Drawing.Color.Silver
        Me.lblShowtimeheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShowtimeheader.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowtimeheader.Location = New System.Drawing.Point(11, 260)
        Me.lblShowtimeheader.Name = "lblShowtimeheader"
        Me.lblShowtimeheader.Size = New System.Drawing.Size(80, 24)
        Me.lblShowtimeheader.TabIndex = 13
        Me.lblShowtimeheader.Text = "Showtimes"
        '
        'lblSynopsis
        '
        Me.lblSynopsis.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSynopsis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSynopsis.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSynopsis.Location = New System.Drawing.Point(11, 182)
        Me.lblSynopsis.Name = "lblSynopsis"
        Me.lblSynopsis.Size = New System.Drawing.Size(454, 67)
        Me.lblSynopsis.TabIndex = 12
        '
        'lbllength
        '
        Me.lbllength.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbllength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbllength.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllength.Location = New System.Drawing.Point(243, 125)
        Me.lbllength.Name = "lbllength"
        Me.lbllength.Size = New System.Drawing.Size(222, 24)
        Me.lbllength.TabIndex = 11
        '
        'lbllengthheader
        '
        Me.lbllengthheader.BackColor = System.Drawing.Color.Silver
        Me.lbllengthheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbllengthheader.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllengthheader.Location = New System.Drawing.Point(158, 125)
        Me.lbllengthheader.Name = "lbllengthheader"
        Me.lbllengthheader.Size = New System.Drawing.Size(89, 24)
        Me.lbllengthheader.TabIndex = 10
        Me.lbllengthheader.Text = "Length"
        '
        'lblSynopsisheader
        '
        Me.lblSynopsisheader.BackColor = System.Drawing.Color.Silver
        Me.lblSynopsisheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSynopsisheader.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSynopsisheader.Location = New System.Drawing.Point(11, 159)
        Me.lblSynopsisheader.Name = "lblSynopsisheader"
        Me.lblSynopsisheader.Size = New System.Drawing.Size(81, 24)
        Me.lblSynopsisheader.TabIndex = 9
        Me.lblSynopsisheader.Text = "Synopsis"
        '
        'lblGenre
        '
        Me.lblGenre.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGenre.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenre.Location = New System.Drawing.Point(243, 101)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(222, 24)
        Me.lblGenre.TabIndex = 8
        '
        'lblGenreheader
        '
        Me.lblGenreheader.BackColor = System.Drawing.Color.Silver
        Me.lblGenreheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGenreheader.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenreheader.Location = New System.Drawing.Point(158, 101)
        Me.lblGenreheader.Name = "lblGenreheader"
        Me.lblGenreheader.Size = New System.Drawing.Size(89, 24)
        Me.lblGenreheader.TabIndex = 7
        Me.lblGenreheader.Text = "Genre"
        '
        'lblRating
        '
        Me.lblRating.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRating.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRating.Location = New System.Drawing.Point(243, 77)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(222, 24)
        Me.lblRating.TabIndex = 6
        '
        'lblRatingheader
        '
        Me.lblRatingheader.BackColor = System.Drawing.Color.Silver
        Me.lblRatingheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRatingheader.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRatingheader.Location = New System.Drawing.Point(158, 77)
        Me.lblRatingheader.Name = "lblRatingheader"
        Me.lblRatingheader.Size = New System.Drawing.Size(89, 24)
        Me.lblRatingheader.TabIndex = 5
        Me.lblRatingheader.Text = "Director"
        '
        'lblRelease
        '
        Me.lblRelease.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblRelease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRelease.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRelease.Location = New System.Drawing.Point(243, 53)
        Me.lblRelease.Name = "lblRelease"
        Me.lblRelease.Size = New System.Drawing.Size(222, 24)
        Me.lblRelease.TabIndex = 4
        '
        'lblReleaseheader
        '
        Me.lblReleaseheader.BackColor = System.Drawing.Color.Silver
        Me.lblReleaseheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReleaseheader.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReleaseheader.Location = New System.Drawing.Point(158, 53)
        Me.lblReleaseheader.Name = "lblReleaseheader"
        Me.lblReleaseheader.Size = New System.Drawing.Size(89, 24)
        Me.lblReleaseheader.TabIndex = 3
        Me.lblReleaseheader.Text = "Release Date"
        '
        'lblmovie
        '
        Me.lblmovie.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblmovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmovie.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmovie.Location = New System.Drawing.Point(243, 29)
        Me.lblmovie.Name = "lblmovie"
        Me.lblmovie.Size = New System.Drawing.Size(222, 24)
        Me.lblmovie.TabIndex = 2
        '
        'lblnameheader
        '
        Me.lblnameheader.BackColor = System.Drawing.Color.Silver
        Me.lblnameheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnameheader.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnameheader.Location = New System.Drawing.Point(158, 29)
        Me.lblnameheader.Name = "lblnameheader"
        Me.lblnameheader.Size = New System.Drawing.Size(89, 24)
        Me.lblnameheader.TabIndex = 1
        Me.lblnameheader.Text = "Movie"
        '
        'picMovie
        '
        Me.picMovie.Image = Global.FinalCompScience.My.Resources.Resources.vc
        Me.picMovie.Location = New System.Drawing.Point(11, 28)
        Me.picMovie.Name = "picMovie"
        Me.picMovie.Size = New System.Drawing.Size(141, 123)
        Me.picMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMovie.TabIndex = 0
        Me.picMovie.TabStop = False
        '
        'grpCart
        '
        Me.grpCart.BackColor = System.Drawing.Color.Gainsboro
        Me.grpCart.Controls.Add(Me.lblCurrentotal)
        Me.grpCart.Controls.Add(Me.lblCurrentotalheader)
        Me.grpCart.Controls.Add(Me.lblClickshowtime)
        Me.grpCart.Controls.Add(Me.btnRemove)
        Me.grpCart.Controls.Add(Me.lstCart)
        Me.grpCart.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCart.Location = New System.Drawing.Point(12, 417)
        Me.grpCart.Name = "grpCart"
        Me.grpCart.Size = New System.Drawing.Size(337, 148)
        Me.grpCart.TabIndex = 13
        Me.grpCart.TabStop = False
        Me.grpCart.Text = "Selected Ticket"
        Me.grpCart.Visible = False
        '
        'lblCurrentotal
        '
        Me.lblCurrentotal.BackColor = System.Drawing.Color.Silver
        Me.lblCurrentotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrentotal.Location = New System.Drawing.Point(166, 116)
        Me.lblCurrentotal.Name = "lblCurrentotal"
        Me.lblCurrentotal.Size = New System.Drawing.Size(60, 21)
        Me.lblCurrentotal.TabIndex = 13
        Me.lblCurrentotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentotalheader
        '
        Me.lblCurrentotalheader.BackColor = System.Drawing.Color.Silver
        Me.lblCurrentotalheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrentotalheader.Location = New System.Drawing.Point(6, 116)
        Me.lblCurrentotalheader.Name = "lblCurrentotalheader"
        Me.lblCurrentotalheader.Size = New System.Drawing.Size(154, 21)
        Me.lblCurrentotalheader.TabIndex = 12
        Me.lblCurrentotalheader.Text = "Current Total  Rs"
        Me.lblCurrentotalheader.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblClickshowtime
        '
        Me.lblClickshowtime.BackColor = System.Drawing.Color.Gainsboro
        Me.lblClickshowtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClickshowtime.Font = New System.Drawing.Font("Microsoft YaHei", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClickshowtime.Location = New System.Drawing.Point(31, 56)
        Me.lblClickshowtime.Name = "lblClickshowtime"
        Me.lblClickshowtime.Size = New System.Drawing.Size(269, 49)
        Me.lblClickshowtime.TabIndex = 11
        Me.lblClickshowtime.Text = "Click on the desired showtime to buy your ticket"
        Me.lblClickshowtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(250, 101)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(81, 32)
        Me.btnRemove.TabIndex = 1
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lstCart
        '
        Me.lstCart.BackColor = System.Drawing.Color.Gainsboro
        Me.lstCart.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCart.FormattingEnabled = True
        Me.lstCart.ItemHeight = 20
        Me.lstCart.Location = New System.Drawing.Point(5, 28)
        Me.lstCart.Name = "lstCart"
        Me.lstCart.ScrollAlwaysVisible = True
        Me.lstCart.Size = New System.Drawing.Size(328, 64)
        Me.lstCart.TabIndex = 0
        '
        'mnuSelect
        '
        Me.mnuSelect.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.mnuSelect.Location = New System.Drawing.Point(0, 0)
        Me.mnuSelect.Name = "mnuSelect"
        Me.mnuSelect.Size = New System.Drawing.Size(839, 24)
        Me.mnuSelect.TabIndex = 18
        Me.mnuSelect.Text = "MenuStrip1"
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
        'tooltiphelp
        '
        Me.tooltiphelp.AutomaticDelay = 300
        '
        'picBanner
        '
        Me.picBanner.Image = Global.FinalCompScience.My.Resources.Resources.techcinemas
        Me.picBanner.Location = New System.Drawing.Point(18, 39)
        Me.picBanner.Name = "picBanner"
        Me.picBanner.Size = New System.Drawing.Size(797, 171)
        Me.picBanner.TabIndex = 16
        Me.picBanner.TabStop = False
        '
        'frmSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 617)
        Me.Controls.Add(Me.mnuSelect)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.picBanner)
        Me.Controls.Add(Me.grpPlaying)
        Me.Controls.Add(Me.grpOverview)
        Me.Controls.Add(Me.grpCart)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(855, 655)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(855, 655)
        Me.Name = "frmSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Movies!"
        Me.grpPlaying.ResumeLayout(False)
        CType(Me.pichelpPlaying, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOverview.ResumeLayout(False)
        CType(Me.picMovie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCart.ResumeLayout(False)
        Me.mnuSelect.ResumeLayout(False)
        Me.mnuSelect.PerformLayout()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProceed As System.Windows.Forms.Button
    Friend WithEvents picBanner As System.Windows.Forms.PictureBox
    Friend WithEvents grpPlaying As System.Windows.Forms.GroupBox
    Friend WithEvents lstPlaying As System.Windows.Forms.ListBox
    Friend WithEvents grpOverview As System.Windows.Forms.GroupBox
    Friend WithEvents lblShow4 As System.Windows.Forms.Label
    Friend WithEvents lblStartadding As System.Windows.Forms.Label
    Friend WithEvents lblShow3 As System.Windows.Forms.Label
    Friend WithEvents lblShow2 As System.Windows.Forms.Label
    Friend WithEvents lblShow1 As System.Windows.Forms.Label
    Friend WithEvents lblShowtime As System.Windows.Forms.Label
    Friend WithEvents lblShowtimeheader As System.Windows.Forms.Label
    Friend WithEvents lblSynopsis As System.Windows.Forms.Label
    Friend WithEvents lbllength As System.Windows.Forms.Label
    Friend WithEvents lbllengthheader As System.Windows.Forms.Label
    Friend WithEvents lblSynopsisheader As System.Windows.Forms.Label
    Friend WithEvents lblGenre As System.Windows.Forms.Label
    Friend WithEvents lblGenreheader As System.Windows.Forms.Label
    Friend WithEvents lblRating As System.Windows.Forms.Label
    Friend WithEvents lblRatingheader As System.Windows.Forms.Label
    Friend WithEvents lblRelease As System.Windows.Forms.Label
    Friend WithEvents lblReleaseheader As System.Windows.Forms.Label
    Friend WithEvents lblmovie As System.Windows.Forms.Label
    Friend WithEvents lblnameheader As System.Windows.Forms.Label
    Friend WithEvents picMovie As System.Windows.Forms.PictureBox
    Friend WithEvents grpCart As System.Windows.Forms.GroupBox
    Friend WithEvents lblClickshowtime As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents lstCart As System.Windows.Forms.ListBox
    Friend WithEvents mnuSelect As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutClick2GoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCurrentotal As System.Windows.Forms.Label
    Friend WithEvents lblCurrentotalheader As System.Windows.Forms.Label
    Friend WithEvents pichelpPlaying As System.Windows.Forms.PictureBox
    Friend WithEvents tooltiphelp As System.Windows.Forms.ToolTip
End Class
