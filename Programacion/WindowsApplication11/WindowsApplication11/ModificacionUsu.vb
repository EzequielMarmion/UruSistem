Public Class ModificacionUsu

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscCIModUsu.TextChanged

    End Sub

    Private Sub ModificacionUsu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        txtBuscCIModUsu.Enabled = False
        frameModUsu.Enabled = True

        
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        frameModUsu.Enabled = False
        Me.Close()
    End Sub


    Private Sub frameModUsu_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frameModUsu.Enter

    End Sub
End Class