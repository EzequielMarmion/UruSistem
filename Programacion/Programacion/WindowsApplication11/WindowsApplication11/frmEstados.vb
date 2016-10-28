Public Class frmEstados

    Private Sub btnCanelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanelar.Click
        frameAnimal.Enabled = False
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        txtBuscID.Enabled = False
        frameAnimal.Enabled = True
    End Sub

    Private Sub txtBuscID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscID.TextChanged

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

    End Sub

    Private Sub frmEstados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class