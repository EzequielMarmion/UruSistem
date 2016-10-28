Public Class frmMenu

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
    Private Sub ZxczToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmTambo.MdiParent = Me
        frmTambo.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Está seguro que desea salir del programa", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub ZxcToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZxcToolStripMenuItem.Click
        frmUsu.MdiParent = Me
        frmUsu.Show()
    End Sub

    Private Sub ZxcToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZxcToolStripMenuItem1.Click
        frmTambo.MdiParent = Me
        frmTambo.Show()
    End Sub

    Private Sub AgregarAnimalToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAnimales.MdiParent = Me
        frmAnimales.Show()
    End Sub
    Private Sub InformacionDelAnimalToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmEstados.MdiParent = Me
        frmEstados.Show()
    End Sub

    Private Sub EnfermedadesToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmEnfermedades.MdiParent = Me
        frmEnfermedades.Show()
    End Sub

    Private Sub VacaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VacaToolStripMenuItem.Click
        frmVaca.MdiParent = Me
        frmVaca.Show()
    End Sub

    Private Sub ToroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToroToolStripMenuItem.Click
        frmToro.MdiParent = Me
        frmToro.Show()
    End Sub

    Private Sub CriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CriaToolStripMenuItem.Click
        frmCria.MdiParent = Me
        frmCria.Show()
    End Sub

    Private Sub AnimalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnimalesToolStripMenuItem.Click
        frmAnimales.MdiParent = Me
        frmAnimales.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        If MsgBox("Está seguro que desea cerrar sesión del programa", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            cn.Close()
            Me.Close()
            frmLogin.Show()


        End If
    End Sub

    Private Sub EntoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntoreToolStripMenuItem.Click
        frmEntore.MdiParent = Me
        frmEntore.Show()
    End Sub

    Private Sub EnfermedadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnfermedadesToolStripMenuItem.Click
        frmEnfermedades.MdiParent = Me
        frmEnfermedades.Show()
    End Sub

    Private Sub ControlesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlesToolStripMenuItem.Click
        frmControl.MdiParent = Me
        frmControl.Show()
    End Sub

    Private Sub ZxcToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZxcToolStripMenuItem2.Click

    End Sub

    Private Sub LoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoteToolStripMenuItem.Click
        frmLeche.MdiParent = Me
        frmLeche.Show()
    End Sub

    Private Sub AgregarLoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarLoteToolStripMenuItem.Click
        frmLote.MdiParent = Me
        frmLote.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        frmCarga.Close()

    End Sub
End Class