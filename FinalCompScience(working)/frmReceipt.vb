Public Class frmReceipt

    Private Sub frmReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim x As Integer

        Randomize()
        x = Int(Rnd() * 4) + 1  
        lblprinting.Text = "Printing your receipt and tickets. Please bring printed ticket and collect your ordered food items from counter" & x


    End Sub

    Private Sub picPrinter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPrinter.Click

    End Sub
End Class