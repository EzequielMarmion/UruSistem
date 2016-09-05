Public Class frmAgregarAnimal

    Private Sub btnCanelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanelar.Click
        frameAnimal.Enabled = False
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtBuscId.Enabled = False
        frameAnimal.Enabled = True
    End Sub
End Class