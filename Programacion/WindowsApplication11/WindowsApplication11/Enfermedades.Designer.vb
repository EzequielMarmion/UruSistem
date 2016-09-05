<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enfermedades
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.frameControl = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFinEnfermedad = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtIdMedicamento = New System.Windows.Forms.TextBox()
        Me.lblFechaInicioenfermedad = New System.Windows.Forms.Label()
        Me.lblIdMedicamento = New System.Windows.Forms.Label()
        Me.lblIdEnfermedad = New System.Windows.Forms.Label()
        Me.txtIdEnfermedad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBuscID = New System.Windows.Forms.TextBox()
        Me.lblIdAnimal = New System.Windows.Forms.Label()
        Me.frameControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(218, 215)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(148, 27)
        Me.btnCancelar.TabIndex = 44
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(60, 215)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(148, 27)
        Me.btnAceptar.TabIndex = 43
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(218, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(58, 27)
        Me.btnBuscar.TabIndex = 42
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'frameControl
        '
        Me.frameControl.Controls.Add(Me.DateTimePicker2)
        Me.frameControl.Controls.Add(Me.lblFechaFinEnfermedad)
        Me.frameControl.Controls.Add(Me.DateTimePicker1)
        Me.frameControl.Controls.Add(Me.txtIdMedicamento)
        Me.frameControl.Controls.Add(Me.lblFechaInicioenfermedad)
        Me.frameControl.Controls.Add(Me.lblIdMedicamento)
        Me.frameControl.Controls.Add(Me.lblIdEnfermedad)
        Me.frameControl.Controls.Add(Me.txtIdEnfermedad)
        Me.frameControl.Enabled = False
        Me.frameControl.Location = New System.Drawing.Point(14, 59)
        Me.frameControl.Name = "frameControl"
        Me.frameControl.Size = New System.Drawing.Size(450, 140)
        Me.frameControl.TabIndex = 41
        Me.frameControl.TabStop = False
        Me.frameControl.Text = "Información"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(204, 103)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(225, 20)
        Me.DateTimePicker2.TabIndex = 24
        '
        'lblFechaFinEnfermedad
        '
        Me.lblFechaFinEnfermedad.AutoSize = True
        Me.lblFechaFinEnfermedad.Location = New System.Drawing.Point(45, 109)
        Me.lblFechaFinEnfermedad.Name = "lblFechaFinEnfermedad"
        Me.lblFechaFinEnfermedad.Size = New System.Drawing.Size(113, 13)
        Me.lblFechaFinEnfermedad.TabIndex = 23
        Me.lblFechaFinEnfermedad.Text = "Fecha fin enfermedad:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(204, 77)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(225, 20)
        Me.DateTimePicker1.TabIndex = 21
        '
        'txtIdMedicamento
        '
        Me.txtIdMedicamento.Location = New System.Drawing.Point(204, 51)
        Me.txtIdMedicamento.Name = "txtIdMedicamento"
        Me.txtIdMedicamento.Size = New System.Drawing.Size(170, 20)
        Me.txtIdMedicamento.TabIndex = 20
        '
        'lblFechaInicioenfermedad
        '
        Me.lblFechaInicioenfermedad.AutoSize = True
        Me.lblFechaInicioenfermedad.Location = New System.Drawing.Point(45, 82)
        Me.lblFechaInicioenfermedad.Name = "lblFechaInicioenfermedad"
        Me.lblFechaInicioenfermedad.Size = New System.Drawing.Size(156, 13)
        Me.lblFechaInicioenfermedad.TabIndex = 19
        Me.lblFechaInicioenfermedad.Text = "Fecha de inicio de enfermedad:"
        '
        'lblIdMedicamento
        '
        Me.lblIdMedicamento.AutoSize = True
        Me.lblIdMedicamento.Location = New System.Drawing.Point(45, 54)
        Me.lblIdMedicamento.Name = "lblIdMedicamento"
        Me.lblIdMedicamento.Size = New System.Drawing.Size(87, 13)
        Me.lblIdMedicamento.TabIndex = 18
        Me.lblIdMedicamento.Text = "ID medicamento:"
        '
        'lblIdEnfermedad
        '
        Me.lblIdEnfermedad.AutoSize = True
        Me.lblIdEnfermedad.Location = New System.Drawing.Point(45, 29)
        Me.lblIdEnfermedad.Name = "lblIdEnfermedad"
        Me.lblIdEnfermedad.Size = New System.Drawing.Size(80, 13)
        Me.lblIdEnfermedad.TabIndex = 2
        Me.lblIdEnfermedad.Text = "ID enfermedad:"
        '
        'txtIdEnfermedad
        '
        Me.txtIdEnfermedad.Location = New System.Drawing.Point(204, 22)
        Me.txtIdEnfermedad.Name = "txtIdEnfermedad"
        Me.txtIdEnfermedad.Size = New System.Drawing.Size(170, 20)
        Me.txtIdEnfermedad.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(138, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 40
        '
        'txtBuscID
        '
        Me.txtBuscID.Location = New System.Drawing.Point(102, 12)
        Me.txtBuscID.Multiline = True
        Me.txtBuscID.Name = "txtBuscID"
        Me.txtBuscID.Size = New System.Drawing.Size(100, 27)
        Me.txtBuscID.TabIndex = 39
        '
        'lblIdAnimal
        '
        Me.lblIdAnimal.AutoSize = True
        Me.lblIdAnimal.Location = New System.Drawing.Point(17, 19)
        Me.lblIdAnimal.Name = "lblIdAnimal"
        Me.lblIdAnimal.Size = New System.Drawing.Size(54, 13)
        Me.lblIdAnimal.TabIndex = 38
        Me.lblIdAnimal.Text = "ID animal:"
        '
        'Enfermedades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 283)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.frameControl)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBuscID)
        Me.Controls.Add(Me.lblIdAnimal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Enfermedades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enfermedades"
        Me.frameControl.ResumeLayout(False)
        Me.frameControl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents frameControl As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFinEnfermedad As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtIdMedicamento As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaInicioenfermedad As System.Windows.Forms.Label
    Friend WithEvents lblIdMedicamento As System.Windows.Forms.Label
    Friend WithEvents lblIdEnfermedad As System.Windows.Forms.Label
    Friend WithEvents txtIdEnfermedad As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBuscID As System.Windows.Forms.TextBox
    Friend WithEvents lblIdAnimal As System.Windows.Forms.Label
End Class
