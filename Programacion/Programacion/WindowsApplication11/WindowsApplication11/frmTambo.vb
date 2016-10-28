Public Class frmTambo
    Private Sub btnCanelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frameTambo.Enabled = False
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        sql = "select * from tambo where id_tambo=" & Val(txtBuscID.Text)
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al buscar el Tambo.", MsgBoxStyle.Information, "UruSistem")
            Exit Sub
        End Try
        If rs.RecordCount = 1 Then
            txtBuscID.Text = rs("id_tambo").Value
            txtIdTambo.Text = rs("id_tambo").Value
            txtNombreDelTambo.Text = rs("nombre").Value
            txtUbicacion.Text = rs("ubicacion").Value
            txtCantHectareas.Text = rs("cant_hectareas").Value
            txtDepartament.Text = rs("departamento").Value
            btnCrear.Enabled = False
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        Else
            MsgBox("No se encontro el Tambo.", MsgBoxStyle.Information, "UruSistem")
        End If
        rs.Close()
    End Sub

    Private Sub btnCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrear.Click
        sql = "insert into tambo (id_tambo, nombre, cant_hectareas, departamento, ubicacion) Values (" & txtBuscID.Text & ",'" & txtNombreDelTambo.Text & "'," & txtCantHectareas.Text & ",'" & txtDepartament.Text & "','" & txtUbicacion.Text & "')"
        Try
            cn.Execute(sql)
            MsgBox("Tambo guardado correctamente.", MsgBoxStyle.Information, "UruSistem")
        Catch ex As Exception
            MsgBox("El Id ya existe.", MsgBoxStyle.Exclamation, "UruSistem")
            Exit Sub
        End Try
        txtBuscID.Text = ""
        txtNombreDelTambo.Text = ""
        txtUbicacion.Text = ""
        txtCantHectareas.Text = ""
        txtDepartament.Text = ""
        btnModificar.Enabled = False
        btnCrear.Enabled = True
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        sql = "update tambo set id_tambo=" & txtIdTambo.Text & ", nombre='" & txtNombreDelTambo.Text & "', cant_hectareas='" & txtCantHectareas.Text & "', departamento='" & txtDepartament.Text & "', ubicacion='" & txtUbicacion.Text & "' where id_tambo=" & txtBuscID.Text
        Try
            cn.Execute(sql)
            MsgBox("Modificación exitosa.", MsgBoxStyle.Information, "Atención")
        Catch ex As Exception
            MsgBox(sql + "No se pudo Modificar el Tambo.", MsgBoxStyle.Information, "Error")
            Exit Sub
        End Try
        txtBuscID.Text = ""
        txtNombreDelTambo.Text = ""
        txtUbicacion.Text = ""
        txtCantHectareas.Text = ""
        txtDepartament.Text = ""
        btnModificar.Enabled = False
        btnCrear.Enabled = True
       
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        sql = "delete from tambo where id_tambo=" & Val(txtBuscID.Text)
        Try
            If MsgBox("¿Está seguro que quiere eliminar el Tambo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Execute(sql)
                MsgBox("Tambo ha sido eliminado correctamente.", MsgBoxStyle.Information, "UruSistem")
                btnModificar.Enabled = False
                btnEliminar.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("No se ha podido eliminar el Tambo.", MsgBoxStyle.Information, "UruSistem")
            Exit Sub
        End Try
        btnCrear.Enabled = True
        txtIdTambo.Text = ""
        txtNombreDelTambo.Text = ""
        txtUbicacion.Text = ""
        txtDepartament.Text = ""
        txtCantHectareas.Text = ""
    End Sub
End Class