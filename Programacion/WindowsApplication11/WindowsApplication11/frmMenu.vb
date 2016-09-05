Public Class frmMenu

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ZxcToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZxcToolStripMenuItem2.Click

    End Sub

    Private Sub InformacionDelToroToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub ZxcToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  

    End Sub

    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EliminarUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub ModificarUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    
    End Sub

    Private Sub ZxczToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub XcToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ZxczToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmTambo.MdiParent = Me
        frmTambo.Show()
    End Sub

    Private Sub XcToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub AgregarVacaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub InformacionDeLaVacaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AgregarAnimalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub EliminarAnimalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarAnimalToolStripMenuItem.Click
        frmElimAnimal.MdiParent = Me
        frmElimAnimal.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Está seguro que desea salir del programa", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ControlDeAnimalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub MovimientoDelAnimalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientoDelAnimalToolStripMenuItem.Click
        frmMovAnimal.MdiParent = Me
        frmMovAnimal.Show()
    End Sub

    Private Sub ControlesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
   
    End Sub

    Private Sub EnfermedadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub EnfermedadesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
     
    End Sub

    Private Sub EnfermedadesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
   
    End Sub

    Private Sub ControlesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
     
    End Sub

    Private Sub ControlesToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
   
    End Sub

    Private Sub ControlesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub ZxcToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZxcToolStripMenuItem.Click
        frmUsu.MdiParent = Me
        frmUsu.Show()
    End Sub

    Private Sub ZxcToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZxcToolStripMenuItem1.Click
        frmTambo.MdiParent = Me
        frmTambo.Show()
    End Sub

    Private Sub AgregarAnimalToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarAnimalToolStripMenuItem.Click
        frmAgregarAnimal.MdiParent = Me
        frmAgregarAnimal.Show()
    End Sub

    Private Sub ControlesToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlesToolStripMenuItem.Click
        frmControles.MdiParent = Me
        frmControles.Show()
    End Sub

    Private Sub InformacionDelAnimalToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformacionDelAnimalToolStripMenuItem1.Click
        frmInfoAnimal.MdiParent = Me
        frmInfoAnimal.Show()
    End Sub

    Private Sub EnfermedadesToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnfermedadesToolStripMenuItem.Click
        frmEnfermedades.MdiParent = Me
        frmEnfermedades.Show()
    End Sub
End Class