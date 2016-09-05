Public Class EliminacionUsu

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanelar.Click
        frameEliUsu.Enabled = False
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtBuscCIEliUsu.Enabled = False
        frameEliUsu.Enabled = True

    End Sub

    Private Sub frameModUsu_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frameEliUsu.Enter

    End Sub

    Private Sub txtBuscCIModUsu_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscCIEliUsu.TextChanged

    End Sub
End Class