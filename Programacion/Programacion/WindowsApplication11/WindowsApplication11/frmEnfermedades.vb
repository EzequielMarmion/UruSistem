Public Class frmEnfermedades

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        txtIdEnfermedad.Text = ""
        txtNombre.Text = ""
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        sql = "select * from enfermedades where id_enfermedad=" & Val(txtBuscID.Text)
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al buscar el Id de la enfermedad.", MsgBoxStyle.Information, "UruSistem")
            Exit Sub
        End Try
        If rs.RecordCount = 1 Then
            txtIdEnfermedad.Text = rs("id_enfermedad").Value
            txtNombre.Text = rs("nombre").Value
        Else
            MsgBox("No se encontro el usuario.", MsgBoxStyle.Information, "UruSistem")
        End If
        rs.Close()
    End Sub

    Private Sub txtIdEnfermedad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdEnfermedad.TextChanged

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrear.Click
        sql = "insert into enfermedades (id_enfermedad, nombre) Values (" & txtIdEnfermedad.Text & ",'" & txtNombre.Text & "')"
        Try
            cn.Execute(sql)
            MsgBox("Enfermedad guardada correctamente.", MsgBoxStyle.Information, "UruSistem")
        Catch ex As Exception
            MsgBox("No se ha podido gusrdar el Id de la enfermedad.", MsgBoxStyle.Exclamation, "UruSistem")
            Exit Sub
        End Try
        txtIdEnfermedad.Text = ""
        txtNombre.Text = ""
    End Sub

    Private Sub frmEnfermedades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        sql = "update enfermedades set id_enfermedad=" & txtIdEnfermedad.Text & ", nombre='" & txtNombre.Text & "' where id_enfermedad=" & txtBuscID.Text
        Try
            cn.Execute(sql)
            MsgBox("Modificación exitosa.", MsgBoxStyle.Information, "Atención")
        Catch ex As Exception
            MsgBox(sql + "No se pudo Modificar el Usuario.", MsgBoxStyle.Information, "Error")
            Exit Sub
        End Try
        txtIdEnfermedad.Text = ""
        txtNombre.Text = ""

    End Sub
End Class