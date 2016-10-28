Public Class frmAnimales

    Public Sub cargargrilla()
        sql = "select * from animales"
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al abrir Grilla")
            Exit Sub
        End Try
        If Not cargoGrilla(rs, DataGridView1) Then
            MsgBox("No se pudo cargar grilla")
        End If
        rs.Close()
    End Sub

    Private Sub frmAnimales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargargrilla()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class