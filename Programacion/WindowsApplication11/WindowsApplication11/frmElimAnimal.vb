Public Class frmElimAnimal

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        frameElimAnimal.Enabled = False
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtBuscID.Enabled = False
        frameElimAnimal.Enabled = True
    End Sub
End Class