Public Class frmLogin

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If MsgBox("Está seguro que desea salir del programa", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        Try
            cn.Open("US", txtUsuario.Text, txtPass.Text)
            MsgBox("Bienvenido:  " & txtUsuario.Text & "", MsgBoxStyle.Information)
            Me.Hide()
            System.Threading.Thread.Sleep(2000)
            frmMenu.Show()
        Catch ex As Exception
            MsgBox("Usuario o Contraseña incorrecta.")
            Exit Sub
        End Try
        cn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    End Sub
End Class