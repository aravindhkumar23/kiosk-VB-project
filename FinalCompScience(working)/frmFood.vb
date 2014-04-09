Public Class frmFood

    Private Sub frmFood_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        grpFood.Visible = False
        grpBeverages.Visible = False
        grpCart.Visible = False
        lblClickshowtime.Visible = True
        lblAddfood.Visible = True
        lblAddbeverage.Visible = True
        lblCurrentotal.Text = "0"
        cboFood1.SelectedItem = "0"
        cboFood2.SelectedItem = "0"
        cboFood3.SelectedItem = "0"
        cboBeverage1.SelectedItem = "0"
        cboBeverage2.SelectedItem = "0"
        cboBeverage3.SelectedItem = "0"

    End Sub

    Private Sub AboutClick2GoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutClick2GoToolStripMenuItem.Click

        frmAbout.Show()

    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click

        Me.Hide()
        frmSelect.Show()
        frmSelect.BringToFront()

    End Sub

    Private Sub btnProceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProceed.Click

        Me.Hide()
        frmBill.Show()
        frmBill.BringToFront()

    End Sub

    Private Sub lstFood_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstFood.Click

        grpFood.Visible = True
        lblAddfood.Visible = False
        grpCart.Visible = True
        lblClickshowtime.Visible = False

    End Sub

    Private Sub lstBeverages_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstBeverages.Click

        grpBeverages.Visible = True
        lblAddbeverage.Visible = False
        grpCart.Visible = True
        lblClickshowtime.Visible = False

    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        Dim x As Integer
        Dim finalremove As Double

        For x = 1 To 4

            If lstFoodandBeverages.SelectedItem = x & " Small Popcorn" Then
                finalremove = (Val(lblCurrentotal.Text) - Val(x * 10))

                lblCurrentotal.Text = finalremove

            ElseIf lstFoodandBeverages.SelectedItem = x & " Medium Popcorn" Then
                finalremove = (Val(lblCurrentotal.Text) - Val(x * 15))

                lblCurrentotal.Text = finalremove

            ElseIf lstFoodandBeverages.SelectedItem = x & " Large Popcorn" Then
                finalremove = (Val(lblCurrentotal.Text) - Val(x * 20))

                lblCurrentotal.Text = finalremove

            ElseIf lstFoodandBeverages.SelectedItem = x & " Small Fries" Then
                finalremove = (Val(lblCurrentotal.Text) - Val(x * 125))

                lblCurrentotal.Text = finalremove

            ElseIf lstFoodandBeverages.SelectedItem = x & " Medium Fries" Then
                finalremove = (Val(lblCurrentotal.Text) - Val(x * 175))

                lblCurrentotal.Text = finalremove

            ElseIf lstFoodandBeverages.SelectedItem = x & " Large Fries" Then
                finalremove = (Val(lblCurrentotal.Text) - Val(x * 250))

                lblCurrentotal.Text = finalremove

            ElseIf lstFoodandBeverages.SelectedItem = x & " Small Candy" Then
                finalremove = (Val(lblCurrentotal.Text) - Val(x * 5))

                lblCurrentotal.Text = finalremove

            ElseIf lstFoodandBeverages.SelectedItem = x & " Medium Candy" Then
                finalremove = (Val(lblCurrentotal.Text) - Val(x * 10))

                lblCurrentotal.Text = finalremove

            ElseIf lstFoodandBeverages.SelectedItem = x & " Large Candy" Then
                finalremove = (Val(lblCurrentotal.Text) - Val(x * 25))

                lblCurrentotal.Text = finalremove
 
            ElseIf lstFoodandBeverages.SelectedItem = x & " Small Chips" Then
                finalremove = (Val(lblCurrentotal.Text) - Val(x * 15))

                lblCurrentotal.Text = finalremove

            ElseIf lstFoodandBeverages.SelectedItem = x & " Medium Chips" Then
                finalremove = (Val(lblCurrentotal.Text) - Val(x * 20))

                lblCurrentotal.Text = finalremove

            ElseIf lstFoodandBeverages.SelectedItem = x & " Large Chips" Then
                finalremove = (Val(lblCurrentotal.Text) - Val(x * 35))

                lblCurrentotal.Text = finalremove

            ElseIf lstFoodandBeverages.SelectedItem = x & " Small Pepsi" Then
                finalremove = (Val(lblCurrentotal.Text) - Val(x * 25))

                lblCurrentotal.Text = finalremove

            ElseIf lstFoodandBeverages.SelectedItem = x & " Medium Pepsi" Then
                finalremove = (Val(lblCurrentotal.Text) - Val(x * 75))

                lblCurrentotal.Text = finalremove

            ElseIf lstFoodandBeverages.SelectedItem = x & " Large Pepsi" Then
                finalremove = (Val(lblCurrentotal.Text) - Val(x * 100))

                lblCurrentotal.Text = finalremove

            ElseIf lstFoodandBeverages.SelectedItem = x & " Small Coke" Then
                finalremove = (Val(lblCurrentotal.Text) - Val(x * 25))

                lblCurrentotal.Text = finalremove

            ElseIf lstFoodandBeverages.SelectedItem = x & " Medium Coke" Then
                finalremove = (Val(lblCurrentotal.Text) - Val(x * 75))

                lblCurrentotal.Text = finalremove

            ElseIf lstFoodandBeverages.SelectedItem = x & " Large Coke" Then
                finalremove = (Val(lblCurrentotal.Text) - Val(x * 125))

                lblCurrentotal.Text = finalremove

            ElseIf lstFoodandBeverages.SelectedItem = x & " Small Sprite" Then
                finalremove = (Val(lblCurrentotal.Text) - Val(x * 25))

                lblCurrentotal.Text = finalremove

            ElseIf lstFoodandBeverages.SelectedItem = x & " Medium Sprite" Then
                finalremove = (Val(lblCurrentotal.Text) - Val(x * 75))

                lblCurrentotal.Text = finalremove

            ElseIf lstFoodandBeverages.SelectedItem = x & " Large Sprite" Then
                finalremove = (Val(lblCurrentotal.Text) - Val(x * 125))

                lblCurrentotal.Text = finalremove

            ElseIf lstFoodandBeverages.SelectedItem = x & " Small KoolAid" Then
                finalremove = (Val(lblCurrentotal.Text) - Val(x * 15))

                lblCurrentotal.Text = finalremove

            ElseIf lstFoodandBeverages.SelectedItem = x & " Medium KoolAid" Then
                finalremove = (Val(lblCurrentotal.Text) - Val(x * 20))

                lblCurrentotal.Text = finalremove

            ElseIf lstFoodandBeverages.SelectedItem = x & " Large KoolAid" Then
                finalremove = (Val(lblCurrentotal.Text) - Val(x * 25))

                lblCurrentotal.Text = finalremove
            End If
        Next


        lstFoodandBeverages.Items.Remove(lstFoodandBeverages.SelectedItem)

    End Sub

    Private Sub btnAddfood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddfood.Click

        Dim food As String = lstFood.SelectedItem
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        Dim processed As Boolean = False


        If cboFood1.SelectedItem <> "0" And cboFood1.SelectedItem <> "1" And _
        cboFood1.SelectedItem <> "2" And cboFood1.SelectedItem <> "3" And _
        cboFood1.SelectedItem <> "4" And cboFood2.SelectedItem <> "0" And _
        cboFood2.SelectedItem <> "1" And cboFood2.SelectedItem <> "2" And _
        cboFood2.SelectedItem <> "3" And cboFood2.SelectedItem <> "4" And _
        cboFood3.SelectedItem <> "0" And cboFood3.SelectedItem <> "1" And _
        cboFood3.SelectedItem <> "2" And cboFood3.SelectedItem <> "3" And _
        cboFood3.SelectedItem <> "4" Then

            processed = True
            msg = "Invalid quantity. Please choose 1,2,3 or 4"
            style = MsgBoxStyle.OkOnly
            title = "Alert!"
            response = MsgBox(msg, style, title)


        ElseIf cboFood1.SelectedItem = "0" And cboFood2.SelectedItem = "0" And _
        cboFood3.SelectedItem = "0" Then

            processed = True
            msg = "Invalid quantity. Please choose at least 1"
            style = MsgBoxStyle.OkOnly
            title = "Alert!"
            response = MsgBox(msg, style, title)


        Else
            processed = False
        End If


        If processed = False And cboFood1.SelectedItem <> "0" Then
            lstFoodandBeverages.Items.Add(cboFood1.SelectedItem & " " & lblfood1.Text & " " & food)
        End If

        If processed = False And cboFood2.SelectedItem <> "0" Then
            lstFoodandBeverages.Items.Add(cboFood2.SelectedItem & " " & lblFood2.Text & " " & food)
        End If

        If processed = False And cboFood3.SelectedItem <> "0" Then
            lstFoodandBeverages.Items.Add(cboFood3.SelectedItem & " " & lblFood3.Text & " " & food)
        End If


        If processed = False Then
            Call calculatefoodprice()
        End If

        If response = MsgBoxResult.Ok Then
            Me.Show()
            Me.BringToFront()
        End If

    End Sub

    Private Sub btnAddbeverage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddbeverage.Click

        Dim beverages As String = lstBeverages.SelectedItem
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        Dim processed2 As Boolean = False


        If cboBeverage1.SelectedItem <> "0" And cboBeverage1.SelectedItem <> "1" And _
        cboBeverage1.SelectedItem <> "2" And cboBeverage1.SelectedItem <> "3" And _
        cboBeverage1.SelectedItem <> "4" And cboBeverage2.SelectedItem <> "0" And _
        cboBeverage2.SelectedItem <> "1" And cboBeverage2.SelectedItem <> "2" And _
        cboBeverage2.SelectedItem <> "3" And cboBeverage2.SelectedItem <> "4" And _
        cboBeverage3.SelectedItem <> "0" And cboBeverage3.SelectedItem <> "1" And _
        cboBeverage3.SelectedItem <> "2" And cboBeverage3.SelectedItem <> "3" And _
        cboBeverage3.SelectedItem <> "4" Then

            processed2 = True
            msg = "Invalid quantity. Please choose 1,2,3 or 4"
            style = MsgBoxStyle.OkOnly
            title = "Alert!"
            response = MsgBox(msg, style, title)



        ElseIf cboBeverage1.SelectedItem = "0" And cboBeverage2.SelectedItem = "0" And _
        cboBeverage3.SelectedItem = "0" Then

            processed2 = True
            msg = "Invalid quantity. Please choose at least 1"
            style = MsgBoxStyle.OkOnly
            title = "Alert!"
            response = MsgBox(msg, style, title)


        Else
            processed2 = False
        End If


        If processed2 = False And cboBeverage1.SelectedItem <> "0" Then
            lstFoodandBeverages.Items.Add(cboBeverage1.SelectedItem & " " & lblBeverage1.Text & " " & beverages)
        End If

        If processed2 = False And cboBeverage2.SelectedItem <> "0" Then
            lstFoodandBeverages.Items.Add(cboBeverage2.SelectedItem & " " & lblBeverage2.Text & " " & beverages)
        End If

        If processed2 = False And cboBeverage3.SelectedItem <> "0" Then
            lstFoodandBeverages.Items.Add(cboBeverage3.SelectedItem & " " & lblBeverage3.Text & " " & beverages)
        End If

        If processed2 = False Then
            Call calculatebeverageprice()
        End If

        If response = MsgBoxResult.Ok Then
            Me.Show()
            Me.BringToFront()
        End If

    End Sub

    Sub calculatefoodprice()

        Dim pricetext As Double

        If lstFood.SelectedItem = "Popcorn" Then

            Dim smallcorn As Double = Val((cboFood1.SelectedIndex) * 10)
            Dim mediumcorn As Double = Val((cboFood2.SelectedIndex) * 15)
            Dim largecorn As Double = Val((cboFood3.SelectedIndex) * 20)
            Dim totalcorn As Double = Val(smallcorn + mediumcorn + largecorn)
            pricetext = Val(lblCurrentotal.Text) + totalcorn
        ElseIf lstFood.SelectedItem = "Fries" Then

            Dim smallfries As Double = Val((cboFood1.SelectedIndex) * 125)
            Dim mediumfries As Double = Val((cboFood2.SelectedIndex) * 175)
            Dim largefries As Double = Val((cboFood3.SelectedIndex) * 250)
            Dim totalfries As Double = Val(smallfries + mediumfries + largefries)
            pricetext = Val(lblCurrentotal.Text) + totalfries
        ElseIf lstFood.SelectedItem = "Candy" Then

            Dim smallcandy As Double = Val((cboFood1.SelectedIndex) * 5)
            Dim mediumcandy As Double = Val((cboFood2.SelectedIndex) * 10)
            Dim largecandy As Double = Val((cboFood3.SelectedIndex) * 25)
            Dim totalcandy As Double = Val(smallcandy + mediumcandy + largecandy)
            pricetext = Val(lblCurrentotal.Text) + totalcandy
        ElseIf lstFood.SelectedItem = "Chips" Then

            Dim smallchips As Double = Val((cboFood1.SelectedIndex) * 15)
            Dim mediumchips As Double = Val((cboFood2.SelectedIndex) * 20)
            Dim largechips As Double = Val((cboFood3.SelectedIndex) * 35)
            Dim totalchips As Double = Val(smallchips + mediumchips + largechips)
            pricetext = Val(lblCurrentotal.Text) + totalchips
        End If

        lblCurrentotal.Text = pricetext

    End Sub

    Sub calculatebeverageprice()

        Dim pricetext2 As Double

        If lstBeverages.SelectedItem = "Pepsi" Then

            Dim smallpepsi As Double = Val(cboBeverage1.SelectedIndex) * 25
            Dim mediumpepsi As Double = Val(cboBeverage2.SelectedIndex) * 75
            Dim largepepsi As Double = Val(cboBeverage3.SelectedIndex) * 100
            Dim totalpepsi As Double = Val(smallpepsi + mediumpepsi + largepepsi)
            pricetext2 = Val(lblCurrentotal.Text) + totalpepsi
        ElseIf lstBeverages.SelectedItem = "Coke" Then

            Dim smallcoke As Double = Val(cboBeverage1.SelectedIndex) * 25
            Dim mediumcoke As Double = Val(cboBeverage2.SelectedIndex) * 75
            Dim largecoke As Double = Val(cboBeverage3.SelectedIndex) * 125
            Dim totalcoke As Double = Val(smallcoke + mediumcoke + largecoke)
            pricetext2 = Val(lblCurrentotal.Text) + totalcoke
        ElseIf lstBeverages.SelectedItem = "Sprite" Then

            Dim smallsprite As Double = Val(cboBeverage1.SelectedIndex) * 25
            Dim mediumsprite As Double = Val(cboBeverage2.SelectedIndex) * 75
            Dim largesprite As Double = Val(cboBeverage3.SelectedIndex) * 125
            Dim totalsprite As Double = Val(smallsprite + mediumsprite + largesprite)
            pricetext2 = Val(lblCurrentotal.Text) + totalsprite
        ElseIf lstBeverages.SelectedItem = "KoolAid" Then

            Dim smallkoolaid As Double = Val(cboBeverage1.SelectedIndex) * 15
            Dim mediumkoolaid As Double = Val(cboBeverage2.SelectedIndex) * 20
            Dim largekoolaid As Double = Val(cboBeverage3.SelectedIndex) * 25
            Dim totalkoolaid As Double = Val(smallkoolaid + mediumkoolaid + largekoolaid)
            pricetext2 = Val(lblCurrentotal.Text) + totalkoolaid
        End If


        lblCurrentotal.Text = pricetext2

    End Sub

    Private Sub RefreshPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshPageToolStripMenuItem.Click



        Dim x As Integer

        lstFood.SetSelected(x, False)
        lstBeverages.SetSelected(x, False)


        grpFood.Visible = False
        grpBeverages.Visible = False
        grpCart.Visible = False


        lblClickshowtime.Visible = True
        lblAddfood.Visible = True
        lblAddbeverage.Visible = True


        lblCurrentotal.Text = "0"
        lstFoodandBeverages.Items.Clear()


        cboFood1.SelectedItem = "0"
        cboFood2.SelectedItem = "0"
        cboFood3.SelectedItem = "0"
        cboBeverage1.SelectedItem = "0"
        cboBeverage2.SelectedItem = "0"
        cboBeverage3.SelectedItem = "0"

    End Sub

    Private Sub lstFood_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFood.SelectedIndexChanged


        If lstFood.SelectedItem = "Popcorn" Then
            picFood.Image = My.Resources.popcorn
        ElseIf lstFood.SelectedItem = "Fries" Then
            picFood.Image = My.Resources.fries
        ElseIf lstFood.SelectedItem = "Candy" Then
            picFood.Image = My.Resources.candy
        ElseIf lstFood.SelectedItem = "Chips" Then
            picFood.Image = My.Resources.chips
        End If

    End Sub

    Private Sub lstBeverages_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstBeverages.SelectedIndexChanged


        If lstBeverages.SelectedItem = "Pepsi" Then
            picBeverage.Image = My.Resources.pepsi
        ElseIf lstBeverages.SelectedItem = "Coke" Then
            picBeverage.Image = My.Resources.coke
        ElseIf lstBeverages.SelectedItem = "Sprite" Then
            picBeverage.Image = My.Resources.sprite
        ElseIf lstBeverages.SelectedItem = "KooAid" Then
            picBeverage.Image = My.Resources.koolaid
        End If
    End Sub

End Class