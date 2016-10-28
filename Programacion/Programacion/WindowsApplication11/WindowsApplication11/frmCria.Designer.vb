<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCria
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
        Me.frameAnimal = New System.Windows.Forms.GroupBox()
        Me.txtRaza = New System.Windows.Forms.ComboBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.txtIdAnimal = New System.Windows.Forms.TextBox()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblIdAnimal = New System.Windows.Forms.Label()
        Me.lblIdPais = New System.Windows.Forms.Label()
        Me.txtIdPais = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnCanelar = New System.Windows.Forms.Button()
        Me.frameAnimal.SuspendLayout()
        Me.SuspendLayout()
        '
        'frameAnimal
        '
        Me.frameAnimal.Controls.Add(Me.txtRaza)
        Me.frameAnimal.Controls.Add(Me.txtNombre)
        Me.frameAnimal.Controls.Add(Me.lblNombre)
        Me.frameAnimal.Controls.Add(Me.lblRaza)
        Me.frameAnimal.Controls.Add(Me.txtIdAnimal)
        Me.frameAnimal.Controls.Add(Me.DateTimePicker)
        Me.frameAnimal.Controls.Add(Me.lblFechaNacimiento)
        Me.frameAnimal.Controls.Add(Me.lblIdAnimal)
        Me.frameAnimal.Controls.Add(Me.lblIdPais)
        Me.frameAnimal.Controls.Add(Me.txtIdPais)
        Me.frameAnimal.Location = New System.Drawing.Point(23, 58)
        Me.frameAnimal.Name = "frameAnimal"
        Me.frameAnimal.Size = New System.Drawing.Size(458, 184)
        Me.frameAnimal.TabIndex = 52
        Me.frameAnimal.TabStop = False
        Me.frameAnimal.Text = "Datos"
        '
        'txtRaza
        '
        Me.txtRaza.FormattingEnabled = True
        Me.txtRaza.Items.AddRange(New Object() {"Horlando", "Jersey", "Primer Show"})
        Me.txtRaza.Location = New System.Drawing.Point(236, 89)
        Me.txtRaza.Name = "txtRaza"
        Me.txtRaza.Size = New System.Drawing.Size(143, 21)
        Me.txtRaza.TabIndex = 70
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(235, 11)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(142, 20)
        Me.txtNombre.TabIndex = 67
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(110, 18)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 66
        Me.lblNombre.Text = "Nombre:"
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Location = New System.Drawing.Point(110, 97)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(35, 13)
        Me.lblRaza.TabIndex = 64
        Me.lblRaza.Text = "Raza:"
        '
        'txtIdAnimal
        '
        Me.txtIdAnimal.Location = New System.Drawing.Point(236, 37)
        Me.txtIdAnimal.Name = "txtIdAnimal"
        Me.txtIdAnimal.Size = New System.Drawing.Size(142, 20)
        Me.txtIdAnimal.TabIndex = 61
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker.Location = New System.Drawing.Point(236, 116)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(78, 20)
        Me.DateTimePicker.TabIndex = 58
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(110, 122)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(109, 13)
        Me.lblFechaNacimiento.TabIndex = 57
        Me.lblFechaNacimiento.Text = "Fecha de nacimiento:"
        '
        'lblIdAnimal
        '
        Me.lblIdAnimal.AutoSize = True
        Me.lblIdAnimal.Location = New System.Drawing.Point(110, 44)
        Me.lblIdAnimal.Name = "lblIdAnimal"
        Me.lblIdAnimal.Size = New System.Drawing.Size(71, 13)
        Me.lblIdAnimal.TabIndex = 55
        Me.lblIdAnimal.Text = "ID del animal:"
        '
        'lblIdPais
        '
        Me.lblIdPais.AutoSize = True
        Me.lblIdPais.Location = New System.Drawing.Point(111, 70)
        Me.lblIdPais.Name = "lblIdPais"
        Me.lblIdPais.Size = New System.Drawing.Size(42, 13)
        Me.lblIdPais.TabIndex = 1
        Me.lblIdPais.Text = "Id Pais:"
        '
        'txtIdPais
        '
        Me.txtIdPais.Location = New System.Drawing.Point(236, 63)
        Me.txtIdPais.Name = "txtIdPais"
        Me.txtIdPais.Size = New System.Drawing.Size(143, 20)
        Me.txtIdPais.TabIndex = 17
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(301, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(78, 25)
        Me.btnBuscar.TabIndex = 55
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscId
        '
        Me.txtBuscId.Location = New System.Drawing.Point(140, 15)
        Me.txtBuscId.Multiline = True
        Me.txtBuscId.Name = "txtBuscId"
        Me.txtBuscId.Size = New System.Drawing.Size(143, 20)
        Me.txtBuscId.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "ID animal:"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(178, 248)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(149, 27)
        Me.btnModificar.TabIndex = 60
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(349, 248)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(145, 27)
        Me.btnEliminar.TabIndex = 59
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(10, 248)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(148, 27)
        Me.btnCrear.TabIndex = 58
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'btnCanelar
        '
        Me.btnCanelar.Location = New System.Drawing.Point(178, 292)
        Me.btnCanelar.Name = "btnCanelar"
        Me.btnCanelar.Size = New System.Drawing.Size(145, 27)
        Me.btnCanelar.TabIndex = 57
        Me.btnCanelar.Text = "Cancelar"
        Me.btnCanelar.UseVisualStyleBackColor = True
        '
        'frmCria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(505, 337)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.btnCanelar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.frameAnimal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmCria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":. Cria"
        Me.frameAnimal.ResumeLayout(False)
        Me.frameAnimal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents frameAnimal As System.Windows.Forms.GroupBox
    Friend WithEvents txtRaza As System.Windows.Forms.ComboBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblRaza As System.Windows.Forms.Label
    Friend WithEvents txtIdAnimal As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblIdAnimal As System.Windows.Forms.Label
    Friend WithEvents lblIdPais As System.Windows.Forms.Label
    Friend WithEvents txtIdPais As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtBuscId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents btnCanelar As System.Windows.Forms.Button
End Class
