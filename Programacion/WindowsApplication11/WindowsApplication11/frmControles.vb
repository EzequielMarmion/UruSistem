Public Class frmControles

    Private Sub frameUsu_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frameControles.Enter

    End Sub

    Private Sub frmControles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCanelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanelar.Click
        frameControles.Enabled = False
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        txtBuscID.Enabled = False
        frameControles.Enabled = True
    End Sub
End Class