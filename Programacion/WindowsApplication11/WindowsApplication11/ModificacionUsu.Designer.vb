<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificacionUsu
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
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.cmdBuscar = New System.Windows.Forms.TextBox()
        Me.frameModUsu = New System.Windows.Forms.GroupBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscCIModUsu = New System.Windows.Forms.TextBox()
        Me.lblCiUsuario = New System.Windows.Forms.Label()
        Me.frameModUsu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(41, 113)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 3
        Me.lblTelefono.Text = "Teléfono:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Dirección:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(124, 80)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 15
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(124, 106)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(100, 20)
        Me.cmdBuscar.TabIndex = 18
        '
        'frameModUsu
        '
        Me.frameModUsu.Controls.Add(Me.lblApellido)
        Me.frameModUsu.Controls.Add(Me.lblNombre)
        Me.frameModUsu.Controls.Add(Me.TextBox1)
        Me.frameModUsu.Controls.Add(Me.TextBox5)
        Me.frameModUsu.Controls.Add(Me.cmdBuscar)
        Me.frameModUsu.Controls.Add(Me.lblTelefono)
        Me.frameModUsu.Controls.Add(Me.Label6)
        Me.frameModUsu.Controls.Add(Me.TextBox2)
        Me.frameModUsu.Enabled = False
        Me.frameModUsu.Location = New System.Drawing.Point(15, 66)
        Me.frameModUsu.Name = "frameModUsu"
        Me.frameModUsu.Size = New System.Drawing.Size(338, 147)
        Me.frameModUsu.TabIndex = 20
        Me.frameModUsu.TabStop = False
        Me.frameModUsu.Text = "Información"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(41, 61)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(47, 13)
        Me.lblApellido.TabIndex = 20
        Me.lblApellido.Text = "Apellido:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(38, 31)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 19
        Me.lblNombre.Text = "Nombre:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(124, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 22
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(124, 54)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 21
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(15, 237)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(148, 27)
        Me.btnAceptar.TabIndex = 22
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(188, 237)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(148, 27)
        Me.btnCancelar.TabIndex = 23
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(194, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(58, 27)
        Me.btnBuscar.TabIndex = 21
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscCIModUsu
        '
        Me.txtBuscCIModUsu.Location = New System.Drawing.Point(75, 12)
        Me.txtBuscCIModUsu.Multiline = True
        Me.txtBuscCIModUsu.Name = "txtBuscCIModUsu"
        Me.txtBuscCIModUsu.Size = New System.Drawing.Size(100, 27)
        Me.txtBuscCIModUsu.TabIndex = 14
        '
        'lblCiUsuario
        '
        Me.lblCiUsuario.AutoSize = True
        Me.lblCiUsuario.Location = New System.Drawing.Point(12, 19)
        Me.lblCiUsuario.Name = "lblCiUsuario"
        Me.lblCiUsuario.Size = New System.Drawing.Size(57, 13)
        Me.lblCiUsuario.TabIndex = 29
        Me.lblCiUsuario.Text = "CI usuario:"
        '
        'ModificacionUsu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 292)
        Me.Controls.Add(Me.lblCiUsuario)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.frameModUsu)
        Me.Controls.Add(Me.txtBuscCIModUsu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ModificacionUsu"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar usuario"
        Me.frameModUsu.ResumeLayout(False)
        Me.frameModUsu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.TextBox
    Friend WithEvents frameModUsu As System.Windows.Forms.GroupBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtBuscCIModUsu As System.Windows.Forms.TextBox
    Friend WithEvents lblCiUsuario As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
End Class
