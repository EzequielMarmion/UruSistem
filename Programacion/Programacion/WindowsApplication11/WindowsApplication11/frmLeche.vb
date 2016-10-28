Public Class frmLeche
    Public Sub cargargrilla()
        sql = "select * from Leche"
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
    Private Sub frmLeche_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargargrilla()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        sql = "insert into leche (id_leche, tipo_leche, id_lote) Values (" & txtIdLeche.Text & ",'" & txtTipoLeche.Text & "'," & txtIdLote.Text & ")"
        Try
            cn.Execute(sql)
            MsgBox("Leche guardada correctamente.", MsgBoxStyle.Information, "UruSistem")
        Catch ex As Exception
            MsgBox("No se ha podido guardar los datos.", MsgBoxStyle.Exclamation, "UruSistem")
            Exit Sub
        End Try
        cargargrilla()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        txtIdLeche.Text = ""
        txtTipoLeche.Text = ""
        txtIdLote.Text = ""
    End Sub
End Class