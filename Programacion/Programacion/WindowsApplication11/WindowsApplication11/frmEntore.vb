Public Class frmEntore

    Public Sub cargargrilla()
        sql = "select * from entore"
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

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        sql = "insert into entore (id_animal_toro, id_animal_vaca, fecha_entore) Values (" & txtIdToro.Text & ",'" & txtIdVaca.Text & "','" & DateTimePicker.Value.ToString("dd/MM/yyyy") & "')"
        Try
            cn.Execute(sql)
            MsgBox("Entore guardado correctamente.", MsgBoxStyle.Information, "UruSistem")
        Catch ex As Exception
            MsgBox("No se ha podido guardar los datos.", MsgBoxStyle.Exclamation, "UruSistem")
            Exit Sub
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        txtIdToro.Text = ""
        txtIdVaca.Text = ""
        DateTimePicker.Text = ""
    End Sub

    Private Sub frmEntore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargargrilla()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cargargrilla()
    End Sub
End Class