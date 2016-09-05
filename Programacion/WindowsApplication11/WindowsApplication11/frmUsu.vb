Public Class frmUsu

    Private Sub frameUsu_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frameUsu.Enter

    End Sub

    Private Sub frmUsu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCanelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanelar.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        sql = "select * from usuario where ci=" & Val(txtBuscar.Text)
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al buscar el Usuario.", MsgBoxStyle.Information, "UruSistem")
            Exit Sub
        End Try
        If rs.RecordCount = 1 Then
            txtCI.Text = rs("ci").Value
            txtLogin.Text = rs("login").Value
            txtDireccion.Text = rs("direccion").Value
            txtTel.Text = rs("tel").Value
            txtNombre.Text = rs("nombre").Value
            txtApellido.Text = rs("apellido").Value
            cboRol.Text = rs("rol").Value
            btnCrear.Enabled = False
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        Else
            MsgBox("No se encontro el usuario.", MsgBoxStyle.Information, "UruSistem")
        End If
        rs.Close()

    End Sub

    Private Sub btnCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrear.Click
        sql = "insert into usuario (ci, rol, login, nombre, apellido, direccion, tel) Values (" & txtCI.Text & ",'" & cboRol.Text & "','" & txtLogin.Text & "','" & txtNombre.Text & "','" & txtApellido.Text & "','" & txtDireccion.Text & "'," & txtTel.Text & ")"
        Try
            cn.Execute(sql)
            MsgBox("Usuario guardado correctamente.", MsgBoxStyle.Information, "UruSistem")
        Catch ex As Exception
            MsgBox("La CI ya existe.", MsgBoxStyle.Exclamation, "UruSistem")
            Exit Sub
        End Try
        txtCI.Text = ""
        cboRol.Text = ""
        txtLogin.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtDireccion.Text = ""
        txtTel.Text = ""
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        sql = "delete from usuario where ci=" & Val(txtBuscar.Text)
        Try
            If MsgBox("¿Está seguro que quiere eliminar el usuario?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Execute(sql)
                MsgBox("Usuario ha sido eliminado correctamente.", MsgBoxStyle.Information, "UruSistem")
                btnModificar.Enabled = False
                btnEliminar.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("No se ha podido eliminar el usuario.", MsgBoxStyle.Information, "UruSistem")
            Exit Sub
        End Try
        btnCrear.Enabled = True
        txtCI.Text = ""
        cboRol.Text = ""
        txtLogin.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtDireccion.Text = ""
        txtTel.Text = ""
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        sql = "update usuario set cedula=" & txtCI.Text & ", login='" & txtLogin.Text & "', nombre='" & txtNombre.Text & "', apellido='" & txtApellido.Text & "', rol='" & cboRol.Text & "','" & txtDireccion.Text & "',"" & txtTel.Text & ""  where ci=" & txtBuscar.Text & ""
        Try
            cn.Execute(sql)
            MsgBox("Modificación exitosa.", MsgBoxStyle.Information, "Atención")
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
        txtCI.Text = ""
        cboRol.Text = ""
        txtLogin.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtDireccion.Text = ""
        txtTel.Text = ""
    End Sub
End Class
