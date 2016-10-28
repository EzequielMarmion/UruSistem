Public Class frmLote
    Public Sub cargargrilla()
        sql = "select * from lote"
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

    Private Sub frmLote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargargrilla()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        sql = "insert into lote (id_lote, cant_animales) Values (" & txtIdLote.Text & ",'" & txtCantAnimales.Text & "')"
        Try
            cn.Execute(sql)
            MsgBox("Entore guardado correctamente.", MsgBoxStyle.Information, "UruSistem")
        Catch ex As Exception
            MsgBox("No se ha podido guardar los datos.", MsgBoxStyle.Exclamation, "UruSistem")
            Exit Sub
        End Try
        cargargrilla()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        txtIdLote.Text = ""
        txtCantAnimales.Text = ""
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class