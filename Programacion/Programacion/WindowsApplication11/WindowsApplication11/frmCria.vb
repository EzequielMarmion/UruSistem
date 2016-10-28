Public Class frmCria

    Private Sub txtRaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRaza.SelectedIndexChanged

    End Sub

    Private Sub btnCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrear.Click
        sql = "insert into animales (id_animal, id_pais, nombre, raza, fecha_nacimiento) Values (" & txtIdAnimal.Text & ", " & txtIdPais.Text & ",'" & txtNombre.Text & "','" & txtRaza.Text & "'," & DateTimePicker.Text & ")"
        Try

            cn.Execute(sql)
        Catch ex As Exception
            MsgBox(" No se pudo conectar con la base de datos.", MsgBoxStyle.Exclamation, "UruSistem")
            Exit Sub
        End Try

        sql = "insert into crias (id_cria, raza) Values (" & txtIdAnimal.Text & ", '" & txtRaza.Text & "')"
        Try

            cn.Execute(sql)
            MsgBox("Animal guardado correctamente.", MsgBoxStyle.Information, "UruSistem")
        Catch ex As Exception
            'MsgBox("No se pudo conectar con la base de datos.", MsgBoxStyle.Exclamation, "UruSistem")
            Exit Sub
        End Try
        btnModificar.Enabled = False
        btnCrear.Enabled = True
    End Sub

    Private Sub frmCria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class