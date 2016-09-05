Public Class ControlDelAnimal

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        txtBuscID.Enabled = False
        frameControl.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        frameControl.Enabled = False
        Me.Close()
    End Sub

    Private Sub txtBuscID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscID.TextChanged

    End Sub
End Class