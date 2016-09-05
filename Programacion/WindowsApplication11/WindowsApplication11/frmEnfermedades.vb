Public Class frmEnfermedades

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        frameEnfermedades.Enabled = False
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        txtBuscID.Enabled = False
        frameEnfermedades.Enabled = True
    End Sub
End Class