Public Class Enfermedades

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        frameControl.Enabled = False
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        txtBuscID.Enabled = False
        frameControl.Enabled = True
    End Sub

    Private Sub frameControl_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frameControl.Enter

    End Sub
End Class