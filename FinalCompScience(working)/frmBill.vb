Public Class frmBill

    Private Sub AboutClick2GoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutClick2GoToolStripMenuItem.Click

        frmAbout.Show()

    End Sub

    Private Sub RefreshPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshPageToolStripMenuItem.Click

        Me.Refresh()

    End Sub

    Private Sub frmBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim moviecharge As Double
        Dim foodcharge As Double
        Dim subtotal As Double
        Dim taxes As Double
        Dim total As Double

        moviecharge = Val(frmSelect.lblCurrentotal.Text)
        foodcharge = Val(frmFood.lblCurrentotal.Text)
        subtotal = Val(moviecharge + foodcharge)
        taxes = Val(subtotal * 0.13)
        total = Val(subtotal + taxes)

        lblMoviecharge.Text = moviecharge
        lblFoodcharge.Text = foodcharge
        lblSubtotal.Text = subtotal
        lblTaxes.Text = taxes
        lblTotal.Text = total

        lstBill.Items.AddRange(frmSelect.lstCart.Items)
        lstBill.Items.AddRange(frmFood.lstFoodandBeverages.Items)


    End Sub

    Private Sub radAmerican_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAmerican.CheckedChanged
        grpCredit.Visible = True
        lblCredittpye.Text = "Mastro"
    End Sub

    Private Sub radVisa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radVisa.CheckedChanged
        grpCredit.Visible = True
        lblCredittpye.Text = "VISA"
    End Sub

    Private Sub btnProceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProceed.Click
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        Dim datelength As Boolean = True


        If Val(txtMonth.Text) > 0 And Val(txtMonth.Text) < 13 And _
        txtCreditnumber.Text <> "" And Val(txtYear.Text) >= 2009 Then
            datelength = True
        Else
            datelength = False
            MsgBox("Please enter a valid credit card number", MsgBoxStyle.Critical, "Error!")

        End If


        If Val(txtYear.Text) >= 2009 And datelength = True Then
            msg = "Credit Holder: " & txtCreditname.Text & "; Code: " & txtCreditnumber.Text & _
            "; Expiry: " & txtMonth.Text & "/" & txtYear.Text & _
            ". Click Ok to Confirm Order, or click Cancel to review information"
            style = MsgBoxStyle.OkCancel
            title = "Alert!"
            response = MsgBox(msg, style, title)
        End If

        If response = MsgBoxResult.Ok Then

            Me.Hide()
            frmReceipt.Show()
            frmReceipt.BringToFront()

        ElseIf response = MsgBoxResult.Cancel Then
            Me.Show()
        End If

    End Sub

    Private Sub txtcreditnumber_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCreditnumber.KeyPress


        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

            MessageBox.Show("Please enter a valid credit card number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

    End Sub

    Private Sub txtclick_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonth.KeyPress, txtYear.KeyPress


        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then

            e.Handled = True
            MessageBox.Show("Please enter a valid expiry date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

    End Sub

   
End Class