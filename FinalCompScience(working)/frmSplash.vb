Public Class frmSplash

    Private Sub frmSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tmrProgress.Enabled = True
        tmrSwitch1.Enabled = True

    End Sub

    Private Sub tmrProgress_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrProgress.Tick

        prgSwitch.Increment(30)

    End Sub

    Private Sub tmrSwitch1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSwitch1.Tick

        tmrSwitch1.Enabled = False
        tmrProgress.Enabled = False
        Me.Hide()
        frmlogin.Show()

    End Sub

End Class
