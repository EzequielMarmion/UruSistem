<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmElimAnimal
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
        Me.lblIdAnimal = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.frameElimAnimal = New System.Windows.Forms.GroupBox()
        Me.txtRaza = New System.Windows.Forms.TextBox()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblKg = New System.Windows.Forms.Label()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBuscID = New System.Windows.Forms.TextBox()
        Me.frameElimAnimal.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblIdAnimal
        '
        Me.lblIdAnimal.AutoSize = True
        Me.lblIdAnimal.Location = New System.Drawing.Point(67, 22)
        Me.lblIdAnimal.Name = "lblIdAnimal"
        Me.lblIdAnimal.Size = New System.Drawing.Size(54, 13)
        Me.lblIdAnimal.TabIndex = 0
        Me.lblIdAnimal.Text = "ID animal:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(247, 278)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(148, 27)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(93, 278)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(148, 27)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(305, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 20)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frameElimAnimal
        '
        Me.frameElimAnimal.Controls.Add(Me.txtRaza)
        Me.frameElimAnimal.Controls.Add(Me.lblRaza)
        Me.frameElimAnimal.Controls.Add(Me.txtPeso)
        Me.frameElimAnimal.Controls.Add(Me.TextBox1)
        Me.frameElimAnimal.Controls.Add(Me.lblKg)
        Me.frameElimAnimal.Controls.Add(Me.lblPeso)
        Me.frameElimAnimal.Controls.Add(Me.DateTimePicker2)
        Me.frameElimAnimal.Controls.Add(Me.lblFechaNacimiento)
        Me.frameElimAnimal.Controls.Add(Me.Label1)
        Me.frameElimAnimal.Controls.Add(Me.ComboBox2)
        Me.frameElimAnimal.Controls.Add(Me.lblEstado)
        Me.frameElimAnimal.Controls.Add(Me.ComboBox1)
        Me.frameElimAnimal.Controls.Add(Me.lblTipo)
        Me.frameElimAnimal.Controls.Add(Me.lblNombre)
        Me.frameElimAnimal.Controls.Add(Me.txtNombre)
        Me.frameElimAnimal.Enabled = False
        Me.frameElimAnimal.Location = New System.Drawing.Point(22, 49)
        Me.frameElimAnimal.Name = "frameElimAnimal"
        Me.frameElimAnimal.Size = New System.Drawing.Size(466, 213)
        Me.frameElimAnimal.TabIndex = 51
        Me.frameElimAnimal.TabStop = False
        Me.frameElimAnimal.Text = "Datos"
        '
        'txtRaza
        '
        Me.txtRaza.Location = New System.Drawing.Point(213, 88)
        Me.txtRaza.Name = "txtRaza"
        Me.txtRaza.Size = New System.Drawing.Size(142, 20)
        Me.txtRaza.TabIndex = 65
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Location = New System.Drawing.Point(88, 95)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(35, 13)
        Me.lblRaza.TabIndex = 64
        Me.lblRaza.Text = "Raza:"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(213, 114)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(69, 20)
        Me.txtPeso.TabIndex = 63
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(214, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(142, 20)
        Me.TextBox1.TabIndex = 61
        '
        'lblKg
        '
        Me.lblKg.AutoSize = True
        Me.lblKg.Location = New System.Drawing.Point(252, 114)
        Me.lblKg.Name = "lblKg"
        Me.lblKg.Size = New System.Drawing.Size(20, 13)
        Me.lblKg.TabIndex = 60
        Me.lblKg.Text = "Kg"
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(88, 121)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(34, 13)
        Me.lblPeso.TabIndex = 59
        Me.lblPeso.Text = "Peso:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(213, 168)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(142, 20)
        Me.DateTimePicker2.TabIndex = 58
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(88, 175)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(109, 13)
        Me.lblFechaNacimiento.TabIndex = 57
        Me.lblFechaNacimiento.Text = "Fecha de nacimiento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "ID de animal:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Servicio", "Secada", "Preniada"})
        Me.ComboBox2.Location = New System.Drawing.Point(213, 141)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(142, 21)
        Me.ComboBox2.TabIndex = 54
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(88, 149)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(102, 13)
        Me.lblEstado.TabIndex = 53
        Me.lblEstado.Text = "Estado (Si es vaca):"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Vaca", "Toro", "Cria"})
        Me.ComboBox1.Location = New System.Drawing.Point(213, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(143, 21)
        Me.ComboBox1.TabIndex = 52
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(88, 43)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(79, 13)
        Me.lblTipo.TabIndex = 41
        Me.lblTipo.Text = "Tipo de animal:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(88, 69)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(213, 62)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(143, 20)
        Me.txtNombre.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(254, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 50
        '
        'txtBuscID
        '
        Me.txtBuscID.Location = New System.Drawing.Point(148, 19)
        Me.txtBuscID.Multiline = True
        Me.txtBuscID.Name = "txtBuscID"
        Me.txtBuscID.Size = New System.Drawing.Size(143, 20)
        Me.txtBuscID.TabIndex = 49
        '
        'frmElimAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 329)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.frameElimAnimal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBuscID)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblIdAnimal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmElimAnimal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":. Eliminar animal"
        Me.frameElimAnimal.ResumeLayout(False)
        Me.frameElimAnimal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIdAnimal As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents frameElimAnimal As System.Windows.Forms.GroupBox
    Friend WithEvents txtRaza As System.Windows.Forms.TextBox
    Friend WithEvents lblRaza As System.Windows.Forms.Label
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblKg As System.Windows.Forms.Label
    Friend WithEvents lblPeso As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBuscID As System.Windows.Forms.TextBox
End Class
