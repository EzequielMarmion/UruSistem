<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsu
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
        Me.btnCanelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.frameUsu = New System.Windows.Forms.GroupBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.lblCi = New System.Windows.Forms.Label()
        Me.cboRol = New System.Windows.Forms.ComboBox()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblTe = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.frameUsu.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCanelar
        '
        Me.btnCanelar.Location = New System.Drawing.Point(179, 343)
        Me.btnCanelar.Name = "btnCanelar"
        Me.btnCanelar.Size = New System.Drawing.Size(149, 27)
        Me.btnCanelar.TabIndex = 37
        Me.btnCanelar.Text = "Cancelar"
        Me.btnCanelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(333, 298)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(148, 27)
        Me.btnEliminar.TabIndex = 36
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(317, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(78, 20)
        Me.btnBuscar.TabIndex = 35
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'frameUsu
        '
        Me.frameUsu.Controls.Add(Me.txtDireccion)
        Me.frameUsu.Controls.Add(Me.lblDireccion)
        Me.frameUsu.Controls.Add(Me.txtCI)
        Me.frameUsu.Controls.Add(Me.lblCi)
        Me.frameUsu.Controls.Add(Me.cboRol)
        Me.frameUsu.Controls.Add(Me.lblRol)
        Me.frameUsu.Controls.Add(Me.lblApellido)
        Me.frameUsu.Controls.Add(Me.txtTel)
        Me.frameUsu.Controls.Add(Me.txtLogin)
        Me.frameUsu.Controls.Add(Me.lblNombre)
        Me.frameUsu.Controls.Add(Me.txtNombre)
        Me.frameUsu.Controls.Add(Me.txtApellido)
        Me.frameUsu.Controls.Add(Me.lblTe)
        Me.frameUsu.Controls.Add(Me.lblLogin)
        Me.frameUsu.Location = New System.Drawing.Point(28, 42)
        Me.frameUsu.Name = "frameUsu"
        Me.frameUsu.Size = New System.Drawing.Size(468, 235)
        Me.frameUsu.TabIndex = 34
        Me.frameUsu.TabStop = False
        Me.frameUsu.Text = "Datos"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(198, 99)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(143, 20)
        Me.txtDireccion.TabIndex = 56
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(112, 106)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(55, 13)
        Me.lblDireccion.TabIndex = 55
        Me.lblDireccion.Text = "Dirección:"
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(198, 73)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(143, 20)
        Me.txtCI.TabIndex = 54
        '
        'lblCi
        '
        Me.lblCi.AutoSize = True
        Me.lblCi.Location = New System.Drawing.Point(112, 80)
        Me.lblCi.Name = "lblCi"
        Me.lblCi.Size = New System.Drawing.Size(20, 13)
        Me.lblCi.TabIndex = 53
        Me.lblCi.Text = "CI:"
        '
        'cboRol
        '
        Me.cboRol.FormattingEnabled = True
        Me.cboRol.Items.AddRange(New Object() {"Administrador", "Gerente de cooperativa", "Gerente de tambo", "Auxiliar Veterinario", "Auxiliar"})
        Me.cboRol.Location = New System.Drawing.Point(198, 155)
        Me.cboRol.Name = "cboRol"
        Me.cboRol.Size = New System.Drawing.Size(143, 21)
        Me.cboRol.TabIndex = 52
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Location = New System.Drawing.Point(112, 163)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(26, 13)
        Me.lblRol.TabIndex = 41
        Me.lblRol.Text = "Rol:"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(112, 51)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(47, 13)
        Me.lblApellido.TabIndex = 2
        Me.lblApellido.Text = "Apellido:"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(198, 129)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(143, 20)
        Me.txtTel.TabIndex = 50
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(198, 183)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(143, 20)
        Me.txtLogin.TabIndex = 49
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(112, 24)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(198, 21)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(143, 20)
        Me.txtNombre.TabIndex = 17
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(198, 47)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(143, 20)
        Me.txtApellido.TabIndex = 16
        '
        'lblTe
        '
        Me.lblTe.AutoSize = True
        Me.lblTe.Location = New System.Drawing.Point(112, 136)
        Me.lblTe.Name = "lblTe"
        Me.lblTe.Size = New System.Drawing.Size(52, 13)
        Me.lblTe.TabIndex = 44
        Me.lblTe.Text = "Teléfono:"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Location = New System.Drawing.Point(112, 190)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(36, 13)
        Me.lblLogin.TabIndex = 45
        Me.lblLogin.Text = "Login:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(264, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 33
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(160, 13)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(143, 20)
        Me.txtBuscar.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "CI:"
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(12, 298)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(148, 27)
        Me.btnCrear.TabIndex = 38
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(179, 298)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(148, 27)
        Me.btnModificar.TabIndex = 39
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(544, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(417, 167)
        Me.DataGridView1.TabIndex = 66
        '
        'frmUsu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1019, 380)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.btnCanelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.frameUsu)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmUsu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":. Usuario"
        Me.frameUsu.ResumeLayout(False)
        Me.frameUsu.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCanelar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents frameUsu As System.Windows.Forms.GroupBox
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents lblTe As System.Windows.Forms.Label
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents cboRol As System.Windows.Forms.ComboBox
    Friend WithEvents lblRol As System.Windows.Forms.Label
    Friend WithEvents txtCI As System.Windows.Forms.TextBox
    Friend WithEvents lblCi As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
