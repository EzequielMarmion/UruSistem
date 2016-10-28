<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstados
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCanelar = New System.Windows.Forms.Button()
        Me.frameAnimal = New System.Windows.Forms.GroupBox()
        Me.txtRaza = New System.Windows.Forms.TextBox()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.lblKg = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.frameAnimal.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(290, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(58, 27)
        Me.btnBuscar.TabIndex = 62
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscID
        '
        Me.txtBuscID.Location = New System.Drawing.Point(180, 16)
        Me.txtBuscID.Name = "txtBuscID"
        Me.txtBuscID.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscID.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "ID del animal:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(74, 252)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(148, 27)
        Me.btnAceptar.TabIndex = 66
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCanelar
        '
        Me.btnCanelar.Location = New System.Drawing.Point(248, 252)
        Me.btnCanelar.Name = "btnCanelar"
        Me.btnCanelar.Size = New System.Drawing.Size(149, 27)
        Me.btnCanelar.TabIndex = 65
        Me.btnCanelar.Text = "Cancelar"
        Me.btnCanelar.UseVisualStyleBackColor = True
        '
        'frameAnimal
        '
        Me.frameAnimal.Controls.Add(Me.txtRaza)
        Me.frameAnimal.Controls.Add(Me.lblRaza)
        Me.frameAnimal.Controls.Add(Me.txtPeso)
        Me.frameAnimal.Controls.Add(Me.lblKg)
        Me.frameAnimal.Controls.Add(Me.DateTimePicker2)
        Me.frameAnimal.Controls.Add(Me.lblFechaNacimiento)
        Me.frameAnimal.Controls.Add(Me.lblPeso)
        Me.frameAnimal.Controls.Add(Me.ComboBox2)
        Me.frameAnimal.Controls.Add(Me.lblEstado)
        Me.frameAnimal.Controls.Add(Me.ComboBox1)
        Me.frameAnimal.Controls.Add(Me.lblTipo)
        Me.frameAnimal.Controls.Add(Me.lblNombre)
        Me.frameAnimal.Controls.Add(Me.txtNombre)
        Me.frameAnimal.Enabled = False
        Me.frameAnimal.Location = New System.Drawing.Point(15, 48)
        Me.frameAnimal.Name = "frameAnimal"
        Me.frameAnimal.Size = New System.Drawing.Size(468, 189)
        Me.frameAnimal.TabIndex = 64
        Me.frameAnimal.TabStop = False
        Me.frameAnimal.Text = "Datos"
        '
        'txtRaza
        '
        Me.txtRaza.Location = New System.Drawing.Point(214, 72)
        Me.txtRaza.Name = "txtRaza"
        Me.txtRaza.Size = New System.Drawing.Size(142, 20)
        Me.txtRaza.TabIndex = 65
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Location = New System.Drawing.Point(89, 79)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(35, 13)
        Me.lblRaza.TabIndex = 64
        Me.lblRaza.Text = "Raza:"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(214, 126)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(69, 20)
        Me.txtPeso.TabIndex = 63
        '
        'lblKg
        '
        Me.lblKg.AutoSize = True
        Me.lblKg.Location = New System.Drawing.Point(253, 126)
        Me.lblKg.Name = "lblKg"
        Me.lblKg.Size = New System.Drawing.Size(20, 13)
        Me.lblKg.TabIndex = 60
        Me.lblKg.Text = "Kg"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(214, 152)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(69, 20)
        Me.DateTimePicker2.TabIndex = 58
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(89, 158)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(109, 13)
        Me.lblFechaNacimiento.TabIndex = 57
        Me.lblFechaNacimiento.Text = "Fecha de nacimiento:"
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(89, 133)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(34, 13)
        Me.lblPeso.TabIndex = 59
        Me.lblPeso.Text = "Peso:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Servicio", "Secada", "Preniada"})
        Me.ComboBox2.Location = New System.Drawing.Point(214, 98)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(142, 21)
        Me.ComboBox2.TabIndex = 54
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(89, 106)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(43, 13)
        Me.lblEstado.TabIndex = 53
        Me.lblEstado.Text = "Estado:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Vaca", "Toro", "Cria"})
        Me.ComboBox1.Location = New System.Drawing.Point(214, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(143, 21)
        Me.ComboBox1.TabIndex = 52
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(89, 53)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(79, 13)
        Me.lblTipo.TabIndex = 41
        Me.lblTipo.Text = "Tipo de animal:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(89, 23)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(213, 16)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(143, 20)
        Me.txtNombre.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(247, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 63
        '
        'frmEstados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(498, 305)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCanelar)
        Me.Controls.Add(Me.frameAnimal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscID)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmEstados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":. Informacion del Animal"
        Me.frameAnimal.ResumeLayout(False)
        Me.frameAnimal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtBuscID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCanelar As System.Windows.Forms.Button
    Friend WithEvents frameAnimal As System.Windows.Forms.GroupBox
    Friend WithEvents txtRaza As System.Windows.Forms.TextBox
    Friend WithEvents lblRaza As System.Windows.Forms.Label
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents lblKg As System.Windows.Forms.Label
    Friend WithEvents lblPeso As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
