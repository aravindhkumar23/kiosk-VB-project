Imports System.Data.OleDb
Imports System.Data
Public Class frmSelect
    Inherits System.Windows.Forms.Form
    Dim Conn As System.Data.OleDb.OleDbConnection
    Dim dbprovider, dbsource As String
    Dim ds As DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim sql As String
    Dim currenttotal As Integer

    Private Sub listPlaying_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstPlaying.SelectedIndexChanged

        If lstPlaying.SelectedIndex = 0 Then
            grpOverview.Visible = True
            grpCart.Visible = True
            lblClickshowtime.Visible = False
            lblStartadding.Visible = False
            picMovie.Image = My.Resources.vc
            lblmovie.Text = "Vanakam Chennai"
            lblRelease.Text = "October 11, 2013"
            lblRating.Text = " Kiruthiga Udhayanidhi"
            lblGenre.Text = "Romance Film, Comedy"
            lbllength.Text = "152 minutes"

            lblSynopsis.Text = "Vanakkam Chennai is an Indian Tamil comedy film written and directed by debutant Kiruthiga Udhayanidhi." & _
            "Produced by her husband Udhayanidhi Stalin under the banner Red Giant Movies, the film features Shiva and Priya Anand in the lead roles."
            lblShow1.Text = "03:00 pm"
            lblShow2.Text = "05:30 pm"
            lblShow3.Text = "08:15 pm"
            lblShow4.Text = "10:20 pm"

        ElseIf lstPlaying.SelectedIndex = 1 Then
            grpOverview.Visible = True
            grpCart.Visible = True
            lblClickshowtime.Visible = False
            lblStartadding.Visible = False
            picMovie.Image = My.Resources.oa
            lblmovie.Text = "Onaium Atukutium"
            lblRelease.Text = "September 27, 2013"
            lblRating.Text = "Myshkin"
            lblGenre.Text = "Crime Fiction, Thriller, Drama, Mystery, Adventure"
            lbllength.Text = "120 minutes"

            lblSynopsis.Text = "Onaayum Aattukkuttiyum is a 2013 Tamil thriller film written, directed and produced by Mysskin." & _
                " Sricharan of Vazhakku Enn 18/9 fame, Mysskin and Adithya play the lead roles in the film. The film score was composed by Ilaiyaraaja."
            lblShow1.Text = "12:45 am"
            lblShow2.Text = "01:00 pm"
            lblShow3.Text = "04:15 pm"
            lblShow4.Text = "06:00 pm"

        ElseIf lstPlaying.SelectedIndex = 2 Then
            grpOverview.Visible = True
            grpCart.Visible = True
            lblClickshowtime.Visible = False
            lblStartadding.Visible = False
            picMovie.Image = My.Resources.nai
            lblmovie.Text = "Naiyandi"
            lblRelease.Text = "October 11, 2013"
            lblRating.Text = "A. Sarkunam"
            lblGenre.Text = "Romance Film, Comedy"
            lbllength.Text = "158 minutes"
            lblSynopsis.Text = "Naiyaandi is a 2013 Indian Tamil comedy film written and directed by A. Sarkunam. The film features Dhanush and Nazriya Nazim in the lead roles. The plot focuses on a love story between a Kuthu Vilakku shop owner and a BDS student."
            lblShow1.Text = "05:00 pm"
            lblShow2.Text = "07:30 pm"
            lblShow3.Text = "08:15 pm"
            lblShow4.Text = "10:00 pm"

        ElseIf lstPlaying.SelectedIndex = 3 Then
            grpOverview.Visible = True
            grpCart.Visible = True
            lblClickshowtime.Visible = False
            lblStartadding.Visible = False
            picMovie.Image = My.Resources.ff6
            lblmovie.Text = "Fast and Furious 6"
            lblRelease.Text = "May 7, 2013 "
            lblRating.Text = "Justin Lin"
            lblGenre.Text = "Action,Romance"
            lbllength.Text = "130 minutes"
            lblSynopsis.Text = "Fast & Furious 6 is a 2013 action film written by Chris Morgan and directed by Justin Lin. It is the sixth installment in the Fast and the Furious film series."
            lblShow1.Text = "04:00 pm"
            lblShow2.Text = "07:15 pm"
            lblShow3.Text = "09:10 pm"
            lblShow4.Text = "11:30 pm"

        ElseIf lstPlaying.SelectedIndex = 4 Then
            grpOverview.Visible = True
            grpCart.Visible = True
            lblClickshowtime.Visible = False
            lblStartadding.Visible = False
            picMovie.Image = My.Resources.mos
            lblmovie.Text = "Man of Steel"
            lblRelease.Text = "June 10, 2013"
            lblRating.Text = "Zack Snyder"
            lblGenre.Text = "Action"
            lbllength.Text = "143 minutes"
            lblSynopsis.Text = "Man of Steel is a 2013 superhero film directed by Zack Snyder, produced by Christopher Nolan, and written by David S. Goyer."
            lblShow1.Text = "02:00 pm"
            lblShow2.Text = "04:45 pm"
            lblShow3.Text = "06:15 pm"
            lblShow4.Text = "08:00 pm"

        ElseIf lstPlaying.SelectedIndex = 5 Then
            grpOverview.Visible = True
            grpCart.Visible = True
            lblClickshowtime.Visible = False
            lblStartadding.Visible = False
            picMovie.Image = My.Resources.conj
            lblmovie.Text = "The Conjuring"
            lblRelease.Text = "July 19, 2013"
            lblRating.Text = "James Wan"
            lblGenre.Text = "Thriller, Horror"
            lbllength.Text = "112 minutes"
            lblSynopsis.Text = "The Conjuring is a 2013 American supernatural horror film directed by James Wan. Vera Farmiga and Patrick Wilson star as Ed and Lorraine Warren who were American paranormal investigators and authors associated with prominent cases of haunting."
            lblShow1.Text = "03:30 pm"
            lblShow2.Text = "05:00 pm"
            lblShow3.Text = "07:20 pm"
            lblShow4.Text = "09:15 pm"

        ElseIf lstPlaying.SelectedIndex = 6 Then
            grpOverview.Visible = True
            grpCart.Visible = True
            lblClickshowtime.Visible = False
            lblStartadding.Visible = False
            picMovie.Image = My.Resources.marley
            lblmovie.Text = "Marley and Me"
            lblRelease.Text = "march 25, 2013"
            lblRating.Text = "PG"
            lblGenre.Text = "Comedy"
            lbllength.Text = "2hrs 0min"
            lblSynopsis.Text = "A family learns important life lessons from their adorable, but naughty and neurotic dog."
            lblShow1.Text = "01:00 pm"
            lblShow2.Text = "04:40 pm"
            lblShow3.Text = "06:45 pm"
            lblShow4.Text = "08:00 pm"

        ElseIf lstPlaying.SelectedIndex = 7 Then
            grpOverview.Visible = True
            grpCart.Visible = True
            lblClickshowtime.Visible = False
            lblStartadding.Visible = False
            picMovie.Image = My.Resources.mall_cop
            lblmovie.Text = "Mall Cop"
            lblRelease.Text = "January 16, 2013"
            lblRating.Text = "PG"
            lblGenre.Text = "Comedy"
            lbllength.Text = "1hr 27min"
            lblSynopsis.Text = "When a shopping mall is overtaken by a gang of organized crooks, it's up to the a mild-mannered security guard to save the day."
            lblShow1.Text = "06:00 pm"
            lblShow2.Text = "08:50 pm"
            lblShow3.Text = "10:00 pm"
            lblShow4.Text = "11:30 pm"
        End If

    End Sub

    Private Sub AboutClick2GoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutClick2GoToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    Private Sub btnProceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProceed.Click

        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult

        If lstCart.Items.Count = 0 Then

            msg = "You have not chosen any movie. Click 'Ok' to continue, or click 'Cancel' to review your choices"""
            style = MsgBoxStyle.OkCancel
            title = "Alert!"
            response = MsgBox(msg, style, title)

            If response = MsgBoxResult.Ok Then
                Me.Hide()
                frmFood.Show()
                frmFood.BringToFront()
            Else
                Me.Show()
            End If

        Else

            Me.Hide()
            frmFood.Show()
            frmFood.BringToFront()

        End If

        Dim newList As New List(Of String)
        Dim itemsToRemove As New List(Of String)

        For i As Integer = 0 To lstCart.Items.Count - 1

            If newList.Contains(lstCart.Items(i).ToString) Then

                itemsToRemove.Add(lstCart.Items(i).ToString)
            Else

                newList.Add(lstCart.Items(i).ToString)
            End If
        Next

        'For each item in the list itemstoremove
        For Each element As String In itemsToRemove
            lstCart.Items.Remove(element)
            currenttotal = Val(lstCart.Items.Count * 100)
            Me.lblCurrentotal.Text = currenttotal

            'MsgBox("Multiple entries of the same ticket within the same time frame have been removed", MsgBoxStyle.Information, "Alert!")
        Next
        ' If TextBox4.Text = "" Or TextBox3.Text = "" Then
        'MessageBox.Show("Please complete the required fields..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '  Else
        Dim conn As New System.Data.OleDb.OleDbConnection()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Aravindh\Documents\kiosk.accdb"

        Try
            Dim sql As String = "insert into booked values('" & frmlogin.TextBox1.Text & "','" & lblmovie.Text & "','" & lblShow1.Text & "')"
            Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)

            sqlCom.Connection = conn
            conn.Open()

            Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()

            sqlRead.Read()
            ' MsgBox("updated")
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Failed to connect to Database..", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' End If

    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        'If the remove button is clicked
        lstCart.Items.Remove(lstCart.SelectedItem)
        currenttotal = Val(lstCart.Items.Count * 100)
        Me.lblCurrentotal.Text = currenttotal

    End Sub

    Sub lblShow1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblShow1.Click

        'If you click on the Show1 button
        lstCart.Items.Add(lblmovie.Text & " at " & lblShow1.Text)
        currenttotal = Val(lstCart.Items.Count * 100)
        Me.lblCurrentotal.Text = currenttotal

    End Sub

    Private Sub lblShow2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblShow2.Click

        'If you click on the Show2 button
        lstCart.Items.Add(lblmovie.Text & " at " & lblShow2.Text)
        currenttotal = Val(lstCart.Items.Count * 100)
        Me.lblCurrentotal.Text = currenttotal

    End Sub

    Private Sub lblShow3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblShow3.Click

        'If you click on the Show3 button
        lstCart.Items.Add(lblmovie.Text & " at " & lblShow3.Text)
        currenttotal = Val(lstCart.Items.Count * 100)
        Me.lblCurrentotal.Text = currenttotal

    End Sub

    Private Sub lblShow4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblShow4.Click

        'If you click on the Show4 button
        lstCart.Items.Add(lblmovie.Text & " at " & lblShow4.Text)
        currenttotal = Val(lstCart.Items.Count * 100)
        Me.lblCurrentotal.Text = currenttotal

    End Sub



End Class