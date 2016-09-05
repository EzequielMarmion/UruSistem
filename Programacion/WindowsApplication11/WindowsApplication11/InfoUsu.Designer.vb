<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoUsu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblCiUsuario = New System.Windows.Forms.Label()
        Me.txtCiUsuario = New System.Windows.Forms.TextBox()
        Me.lblDatos = New System.Windows.Forms.Label()
        Me.txtDatos = New System.Windows.Forms.TextBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCiUsuario
        '
        Me.lblCiUsuario.AutoSize = True
        Me.lblCiUsuario.Location = New System.Drawing.Point(12, 19)
        Me.lblCiUsuario.Name = "lblCiUsuario"
        Me.lblCiUsuario.Size = New System.Drawing.Size(74, 13)
        Me.lblCiUsuario.TabIndex = 0
        Me.lblCiUsuario.Text = "CI del usuario:"
        '
        'txtCiUsuario
        '
        Me.txtCiUsuario.Location = New System.Drawing.Point(101, 12)
        Me.txtCiUsuario.Multiline = True
        Me.txtCiUsuario.Name = "txtCiUsuario"
        Me.txtCiUsuario.Size = New System.Drawing.Size(152, 27)
        Me.txtCiUsuario.TabIndex = 1
        '
        'lblDatos
        '
        Me.lblDatos.AutoSize = True
        Me.lblDatos.Location = New System.Drawing.Point(48, 69)
        Me.lblDatos.Name = "lblDatos"
        Me.lblDatos.Size = New System.Drawing.Size(38, 13)
        Me.lblDatos.TabIndex = 2
        Me.lblDatos.Text = "Datos:"
        '
        'txtDatos
        '
        Me.txtDatos.Location = New System.Drawing.Point(101, 69)
        Me.txtDatos.Multiline = True
        Me.txtDatos.Name = "txtDatos"
        Me.txtDatos.Size = New System.Drawing.Size(324, 208)
        Me.txtDatos.TabIndex = 3
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(277, 302)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(148, 27)
        Me.btnAtras.TabIndex = 4
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'InfoUsu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 351)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.txtDatos)
        Me.Controls.Add(Me.lblDatos)
        Me.Controls.Add(Me.txtCiUsuario)
        Me.Controls.Add(Me.lblCiUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "InfoUsu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información del usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCiUsuario As System.Windows.Forms.Label
    Friend WithEvents txtCiUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblDatos As System.Windows.Forms.Label
    Friend WithEvents txtDatos As System.Windows.Forms.TextBox
    Friend WithEvents btnAtras As System.Windows.Forms.Button
End Class
