Public Class Menu

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ZxcToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZxcToolStripMenuItem2.Click

    End Sub

    Private Sub InformacionDelToroToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformacionDelToroToolStripMenuItem1.Click
        InfoToro.MdiParent = Me
        InfoToro.Show()
    End Sub

    Private Sub ZxcToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZxcToolStripMenuItem3.Click
        frmCrearUsu.MdiParent = Me
        frmCrearUsu.Show()
        
    End Sub

    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EliminarUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarUsuarioToolStripMenuItem.Click
        EliminacionUsu.MdiParent = Me
        EliminacionUsu.Show()
    End Sub

    Private Sub ModificarUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarUsuarioToolStripMenuItem.Click
        ModificacionUsu.MdiParent = Me
        ModificacionUsu.Show()
    End Sub

    Private Sub ZxczToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZxczToolStripMenuItem1.Click
        InfoUsu.MdiParent = Me
        InfoUsu.Show()
    End Sub

    Private Sub XcToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ZxczToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZxczToolStripMenuItem2.Click
        AgregarEstablecimiento.MdiParent = Me
        AgregarEstablecimiento.Show()
    End Sub

    Private Sub XcToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XcToolStripMenuItem2.Click
        InfoEstablecimiento.MdiParent = Me
        InfoEstablecimiento.Show()
    End Sub

    Private Sub AgregarVacaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarVacaToolStripMenuItem.Click
        AgregarVaca.MdiParent = Me
        AgregarVaca.Show()
    End Sub

    Private Sub InformacionDeLaVacaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformacionDeLaVacaToolStripMenuItem.Click
        frmInfoVaca.MdiParent = Me
        frmInfoVaca.Show()
    End Sub

    Private Sub AgregarAnimalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarAnimalToolStripMenuItem.Click
        AgregarToro.MdiParent = Me
        AgregarToro.Show()
    End Sub

    Private Sub EliminarAnimalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarAnimalToolStripMenuItem.Click
        ElimAnimal.MdiParent = Me
        ElimAnimal.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Está seguro que desea salir del programa", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ControlDeAnimalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Enfermedades.MdiParent = Me
        Enfermedades.Show()
    End Sub

    Private Sub MovimientoDelAnimalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientoDelAnimalToolStripMenuItem.Click
        MovimientoAnimal.MdiParent = Me
        MovimientoAnimal.Show()
    End Sub

    Private Sub ControlesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ControlDelAnimal.MdiParent = Me
        ControlDelAnimal.Show()
    End Sub

    Private Sub EnfermedadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnfermedadesToolStripMenuItem.Click
        Enfermedades.MdiParent = Me
        Enfermedades.Show()
    End Sub

    Private Sub EnfermedadesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnfermedadesToolStripMenuItem1.Click
        Enfermedades.MdiParent = Me
        Enfermedades.Show()
    End Sub

    Private Sub EnfermedadesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnfermedadesToolStripMenuItem2.Click
        Enfermedades.MdiParent = Me
        Enfermedades.Show()
    End Sub

    Private Sub ControlesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlesToolStripMenuItem2.Click
        ControlDelAnimal.MdiParent = Me
        ControlDelAnimal.Show()
    End Sub

    Private Sub ControlesToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlesToolStripMenuItem1.Click
        ControlDelAnimal.MdiParent = Me
        ControlDelAnimal.Show()
    End Sub

    Private Sub ControlesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlesToolStripMenuItem.Click
        ControlDelAnimal.MdiParent = Me
        ControlDelAnimal.Show()
    End Sub
End Class