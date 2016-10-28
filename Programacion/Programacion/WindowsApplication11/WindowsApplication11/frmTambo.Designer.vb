<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTambo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNombreTambo = New System.Windows.Forms.Label()
        Me.txtCantHectareas = New System.Windows.Forms.TextBox()
        Me.lblIdTambo = New System.Windows.Forms.Label()
        Me.txtDepartament = New System.Windows.Forms.TextBox()
        Me.lblUbicacion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDepartamento = New System.Windows.Forms.Label()
        Me.txtNombreDelTambo = New System.Windows.Forms.TextBox()
        Me.txtIdTambo = New System.Windows.Forms.TextBox()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.frameTambo = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.frameTambo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNombreTambo
        '
        Me.lblNombreTambo.AutoSize = True
        Me.lblNombreTambo.Location = New System.Drawing.Point(78, 37)
        Me.lblNombreTambo.Name = "lblNombreTambo"
        Me.lblNombreTambo.Size = New System.Drawing.Size(96, 13)
        Me.lblNombreTambo.TabIndex = 16
        Me.lblNombreTambo.Text = "Nombre del tambo:"
        '
        'txtCantHectareas
        '
        Me.txtCantHectareas.Location = New System.Drawing.Point(224, 182)
        Me.txtCantHectareas.Name = "txtCantHectareas"
        Me.txtCantHectareas.Size = New System.Drawing.Size(171, 20)
        Me.txtCantHectareas.TabIndex = 27
        '
        'lblIdTambo
        '
        Me.lblIdTambo.AutoSize = True
        Me.lblIdTambo.Location = New System.Drawing.Point(78, 79)
        Me.lblIdTambo.Name = "lblIdTambo"
        Me.lblIdTambo.Size = New System.Drawing.Size(70, 13)
        Me.lblIdTambo.TabIndex = 17
        Me.lblIdTambo.Text = "ID del tambo:"
        '
        'txtDepartament
        '
        Me.txtDepartament.Location = New System.Drawing.Point(224, 146)
        Me.txtDepartament.Name = "txtDepartament"
        Me.txtDepartament.Size = New System.Drawing.Size(171, 20)
        Me.txtDepartament.TabIndex = 26
        '
        'lblUbicacion
        '
        Me.lblUbicacion.AutoSize = True
        Me.lblUbicacion.Location = New System.Drawing.Point(78, 117)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(58, 13)
        Me.lblUbicacion.TabIndex = 18
        Me.lblUbicacion.Text = "Ubicación:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Cantidad de hectáreas:"
        '
        'txtDepartamento
        '
        Me.txtDepartamento.AutoSize = True
        Me.txtDepartamento.Location = New System.Drawing.Point(78, 153)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(77, 13)
        Me.txtDepartamento.TabIndex = 24
        Me.txtDepartamento.Text = "Departamento:"
        '
        'txtNombreDelTambo
        '
        Me.txtNombreDelTambo.Location = New System.Drawing.Point(224, 37)
        Me.txtNombreDelTambo.Name = "txtNombreDelTambo"
        Me.txtNombreDelTambo.Size = New System.Drawing.Size(171, 20)
        Me.txtNombreDelTambo.TabIndex = 20
        '
        'txtIdTambo
        '
        Me.txtIdTambo.Location = New System.Drawing.Point(224, 72)
        Me.txtIdTambo.Name = "txtIdTambo"
        Me.txtIdTambo.Size = New System.Drawing.Size(171, 20)
        Me.txtIdTambo.TabIndex = 21
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Location = New System.Drawing.Point(224, 110)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(171, 20)
        Me.txtUbicacion.TabIndex = 22
        '
        'frameTambo
        '
        Me.frameTambo.Controls.Add(Me.lblNombreTambo)
        Me.frameTambo.Controls.Add(Me.txtUbicacion)
        Me.frameTambo.Controls.Add(Me.txtCantHectareas)
        Me.frameTambo.Controls.Add(Me.txtIdTambo)
        Me.frameTambo.Controls.Add(Me.lblIdTambo)
        Me.frameTambo.Controls.Add(Me.txtDepartament)
        Me.frameTambo.Controls.Add(Me.txtNombreDelTambo)
        Me.frameTambo.Controls.Add(Me.lblUbicacion)
        Me.frameTambo.Controls.Add(Me.txtDepartamento)
        Me.frameTambo.Controls.Add(Me.Label1)
        Me.frameTambo.Location = New System.Drawing.Point(12, 45)
        Me.frameTambo.Name = "frameTambo"
        Me.frameTambo.Size = New System.Drawing.Size(481, 264)
        Me.frameTambo.TabIndex = 49
        Me.frameTambo.TabStop = False
        Me.frameTambo.Text = "Datos"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(298, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(58, 27)
        Me.btnBuscar.TabIndex = 62
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscID
        '
        Me.txtBuscID.Location = New System.Drawing.Point(188, 16)
        Me.txtBuscID.Name = "txtBuscID"
        Me.txtBuscID.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscID.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "ID del Tambo:"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(186, 328)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(148, 27)
        Me.btnModificar.TabIndex = 66
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(25, 328)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(148, 27)
        Me.btnCrear.TabIndex = 65
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(345, 328)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(148, 27)
        Me.btnEliminar.TabIndex = 63
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'frmTambo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(511, 399)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.frameTambo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmTambo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":. Tambo"
        Me.frameTambo.ResumeLayout(False)
        Me.frameTambo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombreTambo As System.Windows.Forms.Label
    Friend WithEvents txtCantHectareas As System.Windows.Forms.TextBox
    Friend WithEvents lblIdTambo As System.Windows.Forms.Label
    Friend WithEvents txtDepartament As System.Windows.Forms.TextBox
    Friend WithEvents lblUbicacion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDepartamento As System.Windows.Forms.Label
    Friend WithEvents txtNombreDelTambo As System.Windows.Forms.TextBox
    Friend WithEvents txtIdTambo As System.Windows.Forms.TextBox
    Friend WithEvents txtUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents frameTambo As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtBuscID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
End Class
