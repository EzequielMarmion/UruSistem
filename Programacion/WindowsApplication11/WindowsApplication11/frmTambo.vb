Public Class frmTambo

    Private Sub frameDatos_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frameTambo.Enter

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        txtBuscID.Enabled = False
        frameTambo.Enabled = True
    End Sub

    Private Sub txtBuscID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscID.TextChanged

    End Sub

    Private Sub btnCanelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanelar.Click
        frameTambo.Enabled = False
        Me.Close()
    End Sub
End Class