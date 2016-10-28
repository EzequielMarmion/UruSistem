Public Class frmControl
    Private Sub btnCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrear.Click
        sql = "insert into controles (id_control, nombre, id_animal) Values (" & txtIdControl.Text & ",'" & txtNombre.Text & "','" & txtIdAnimal.Text & "')"
        Try
            cn.Execute(sql)
            MsgBox("Control guardado correctamente.", MsgBoxStyle.Information, "UruSistem")
        Catch ex As Exception
            MsgBox("No se ha podido guardar el Id del control.", MsgBoxStyle.Exclamation, "UruSistem")
            Exit Sub
        End Try
        txtIdControl.Text = ""
        txtNombre.Text = ""
        txtIdAnimal.Text = ""
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        sql = "select * from controles where id_control=" & Val(txtBuscID.Text)
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al buscar el Id del control.", MsgBoxStyle.Information, "UruSistem")
            Exit Sub
        End Try
        If rs.RecordCount = 1 Then
            txtIdControl.Text = rs("id_control").Value
            txtNombre.Text = rs("nombre").Value
            txtIdAnimal.Text = rs("id_animal").Value
        Else
            MsgBox("No se encontro la Id del control.", MsgBoxStyle.Information, "UruSistem")
        End If
        rs.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        txtIdControl.Text = ""
        txtNombre.Text = ""
        txtIdAnimal.Text = ""
    End Sub
End Class