Public Class frmToro

    Private Sub txtBuscId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscId.TextChanged
        'CCCCCCCCCCCCCCCC
    End Sub

    Private Sub btnCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrear.Click
        sql = "insert into animales (id_animal, id_pais, nombre, raza, fecha_nacimiento) Values (" & txtIdAnimal.Text & ", " & txtIdPais.Text & ",'" & txtNombre.Text & "','" & txtRaza.Text & "'," & DateTimePicker.Text & ")"
        Try
            cn.Execute(sql)
        Catch ex As Exception
            MsgBox("No se pudo conectar con la base de datos.")
            Exit Sub
        End Try


        sql = "insert into toro (id_animal, id_pais, raza) Values (" & txtIdAnimal.Text & ", " & txtIdPais.Text & ",'" & txtRaza.Text & "')"
        Try
            cn.Execute(sql)
            MsgBox("Animal guardado correctamente.", MsgBoxStyle.Information, "UruSistem")
        Catch ex As Exception
            MsgBox("No se pudo conectar con la base de datos.", MsgBoxStyle.Exclamation, "UruSistem")
            Exit Sub
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        sql = "delete from animales where id_animal=" & Val(txtBuscId.Text)
        Try
            'If MsgBox("¿Está seguro que quiere eliminar el animal?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            cn.Execute(sql)
            'MsgBox("El animal ha sido eliminado correctamente.", MsgBoxStyle.Information, "UruSistem")
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            'End If
        Catch ex As Exception
            'MsgBox("No se ha podido eliminar el animal.", MsgBoxStyle.Information, "UruSistem")
            Exit Sub
        End Try

        sql = "delete from toro where id_animal=" & Val(txtBuscId.Text)
        Try
            If MsgBox("¿Está seguro que quiere eliminar el animal?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Execute(sql)
                MsgBox("El animal ha sido eliminado correctamente.", MsgBoxStyle.Information, "UruSistem")
                btnModificar.Enabled = False
                btnEliminar.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("No se ha podido eliminar el animal.", MsgBoxStyle.Information, "UruSistem")
            Exit Sub
        End Try

        btnCrear.Enabled = True
        txtIdAnimal.Text = ""
        txtIdPais.Text = ""
        txtNombre.Text = ""
        txtRaza.Text = ""
        DateTimePicker.Text = ""
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        sql = "select * from animales where id_animal=" & Val(txtBuscId.Text)
        Try
            MsgBox(sql)
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al buscar el Animal.", MsgBoxStyle.Information, "UruSistem")
            Exit Sub
        End Try
        If rs.RecordCount = 1 Then
            txtIdAnimal.Text = rs("id_animal").Value
            txtIdPais.Text = rs("id_pais").Value
            txtNombre.Text = rs("nombre").Value
            txtRaza.Text = rs("raza").Value
            DateTimePicker.Value = rs("fecha_nacimiento").Value
            btnCrear.Enabled = False
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        Else
            MsgBox("No se encontro el animal.1", MsgBoxStyle.Information, "UruSistem")
        End If
        rs.Close()

        sql = "select * from toro where id_animal=" & Val(txtBuscId.Text)
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al buscar el Animal.", MsgBoxStyle.Information, "UruSistem")
            Exit Sub
        End Try
        If rs.RecordCount = 1 Then
            txtIdAnimal.Text = rs("id_animal").Value
            txtIdPais.Text = rs("id_pais").Value
            txtRaza.Text = rs("raza").Value
            btnCrear.Enabled = False
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        Else
            MsgBox("No se encontro el Animal.", MsgBoxStyle.Information, "UruSistem")
        End If
        rs.Close()

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        sql = "update toro set id_animal=" & txtIdAnimal.Text & ", id_pais='" & txtIdPais.Text & "', raza='" & txtRaza.Text & "',  where id_animal=" & txtBuscId.Text
        Try
            cn.Execute(sql)
            MsgBox("Modificación exitosa.", MsgBoxStyle.Information, "Atención")
        Catch ex As Exception
            MsgBox(sql + "No se pudo Modificar el Animal.", MsgBoxStyle.Information, "Error")
            Exit Sub
        End Try
        txtIdAnimal.Text = ""
        txtIdPais.Text = ""
        txtRaza.Text = ""
        btnModificar.Enabled = False
        btnCrear.Enabled = True
    End Sub

    Private Sub btnCanelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanelar.Click
        txtIdAnimal.Text = ""
        txtIdPais.Text = ""
        txtNombre.Text = ""
        txtRaza.Text = ""
        DateTimePicker.Text = ""
    End Sub

    Private Sub frmToro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class