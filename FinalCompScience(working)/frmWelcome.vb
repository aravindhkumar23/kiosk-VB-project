Public Class frmWelcome

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProceed.Click
        Me.Hide()
        frmSelect.Show()
    End Sub

    Private Sub AboutClick2GoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutClick2GoToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    Private Sub RefreshPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshPageToolStripMenuItem.Click
        Me.Refresh()
    End Sub
End Class