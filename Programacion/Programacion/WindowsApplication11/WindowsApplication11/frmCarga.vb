Public Class frmCarga

    Dim Contador As Byte = 25

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value < 100 Then
            Contador = Contador + 25
            ProgressBar1.Value = Contador
        Else
            Me.Hide()
            frmLogin.Show()
            Timer1.Enabled = False
        End If


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class