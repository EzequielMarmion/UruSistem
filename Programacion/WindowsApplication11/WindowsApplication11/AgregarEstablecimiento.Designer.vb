<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarEstablecimiento
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
        Me.lblNombreDelTambo = New System.Windows.Forms.Label()
        Me.lblIdTambo = New System.Windows.Forms.Label()
        Me.lblLocalizacion = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtNombreDelTambo = New System.Windows.Forms.TextBox()
        Me.txtIdTambo = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtLocalizacion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblNombreDelTambo
        '
        Me.lblNombreDelTambo.AutoSize = True
        Me.lblNombreDelTambo.Location = New System.Drawing.Point(12, 9)
        Me.lblNombreDelTambo.Name = "lblNombreDelTambo"
        Me.lblNombreDelTambo.Size = New System.Drawing.Size(96, 13)
        Me.lblNombreDelTambo.TabIndex = 0
        Me.lblNombreDelTambo.Text = "Nombre del tambo:"
        '
        'lblIdTambo
        '
        Me.lblIdTambo.AutoSize = True
        Me.lblIdTambo.Location = New System.Drawing.Point(12, 51)
        Me.lblIdTambo.Name = "lblIdTambo"
        Me.lblIdTambo.Size = New System.Drawing.Size(114, 13)
        Me.lblIdTambo.TabIndex = 1
        Me.lblIdTambo.Text = "ID del establecimiento:"
        '
        'lblLocalizacion
        '
        Me.lblLocalizacion.AutoSize = True
        Me.lblLocalizacion.Location = New System.Drawing.Point(12, 89)
        Me.lblLocalizacion.Name = "lblLocalizacion"
        Me.lblLocalizacion.Size = New System.Drawing.Size(69, 13)
        Me.lblLocalizacion.TabIndex = 2
        Me.lblLocalizacion.Text = "Localización:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(12, 125)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 3
        Me.lblTelefono.Text = "Teléfono:"
        '
        'txtNombreDelTambo
        '
        Me.txtNombreDelTambo.Location = New System.Drawing.Point(158, 9)
        Me.txtNombreDelTambo.Name = "txtNombreDelTambo"
        Me.txtNombreDelTambo.Size = New System.Drawing.Size(171, 20)
        Me.txtNombreDelTambo.TabIndex = 4
        '
        'txtIdTambo
        '
        Me.txtIdTambo.Location = New System.Drawing.Point(158, 44)
        Me.txtIdTambo.Name = "txtIdTambo"
        Me.txtIdTambo.Size = New System.Drawing.Size(171, 20)
        Me.txtIdTambo.TabIndex = 7
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(15, 190)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(148, 28)
        Me.btnAceptar.TabIndex = 8
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(181, 190)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(148, 28)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtLocalizacion
        '
        Me.txtLocalizacion.Location = New System.Drawing.Point(158, 82)
        Me.txtLocalizacion.Name = "txtLocalizacion"
        Me.txtLocalizacion.Size = New System.Drawing.Size(171, 20)
        Me.txtLocalizacion.TabIndex = 10
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(158, 118)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(171, 20)
        Me.txtTelefono.TabIndex = 11
        '
        'AgregarEstablecimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 242)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtLocalizacion)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtIdTambo)
        Me.Controls.Add(Me.txtNombreDelTambo)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblLocalizacion)
        Me.Controls.Add(Me.lblIdTambo)
        Me.Controls.Add(Me.lblNombreDelTambo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AgregarEstablecimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar tambo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombreDelTambo As System.Windows.Forms.Label
    Friend WithEvents lblIdTambo As System.Windows.Forms.Label
    Friend WithEvents lblLocalizacion As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtNombreDelTambo As System.Windows.Forms.TextBox
    Friend WithEvents txtIdTambo As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtLocalizacion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
End Class
