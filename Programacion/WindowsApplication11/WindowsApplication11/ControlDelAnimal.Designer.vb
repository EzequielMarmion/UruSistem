<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlDelAnimal
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
        Me.lblFechaFinControl = New System.Windows.Forms.Label()
        Me.lblKg = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaInicioControl = New System.Windows.Forms.Label()
        Me.lblIdControl = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtIdControl = New System.Windows.Forms.TextBox()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBuscID = New System.Windows.Forms.TextBox()
        Me.lblIdAnimal = New System.Windows.Forms.Label()
        Me.frameControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(226, 233)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(148, 27)
        Me.btnCancelar.TabIndex = 51
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(68, 233)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(148, 27)
        Me.btnAceptar.TabIndex = 50
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(211, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(58, 27)
        Me.btnBuscar.TabIndex = 49
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'frameControl
        '
        Me.frameControl.Controls.Add(Me.DateTimePicker2)
        Me.frameControl.Controls.Add(Me.lblFechaFinControl)
        Me.frameControl.Controls.Add(Me.lblKg)
        Me.frameControl.Controls.Add(Me.DateTimePicker1)
        Me.frameControl.Controls.Add(Me.lblFechaInicioControl)
        Me.frameControl.Controls.Add(Me.lblIdControl)
        Me.frameControl.Controls.Add(Me.txtPeso)
        Me.frameControl.Controls.Add(Me.txtIdControl)
        Me.frameControl.Controls.Add(Me.lblPeso)
        Me.frameControl.Enabled = False
        Me.frameControl.Location = New System.Drawing.Point(15, 54)
        Me.frameControl.Name = "frameControl"
        Me.frameControl.Size = New System.Drawing.Size(450, 162)
        Me.frameControl.TabIndex = 48
        Me.frameControl.TabStop = False
        Me.frameControl.Text = "Información"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(205, 78)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(225, 20)
        Me.DateTimePicker2.TabIndex = 24
        '
        'lblFechaFinControl
        '
        Me.lblFechaFinControl.AutoSize = True
        Me.lblFechaFinControl.Location = New System.Drawing.Point(46, 84)
        Me.lblFechaFinControl.Name = "lblFechaFinControl"
        Me.lblFechaFinControl.Size = New System.Drawing.Size(89, 13)
        Me.lblFechaFinControl.TabIndex = 23
        Me.lblFechaFinControl.Text = "Fecha fin control:"
        '
        'lblKg
        '
        Me.lblKg.AutoSize = True
        Me.lblKg.Location = New System.Drawing.Point(288, 107)
        Me.lblKg.Name = "lblKg"
        Me.lblKg.Size = New System.Drawing.Size(20, 13)
        Me.lblKg.TabIndex = 22
        Me.lblKg.Text = "Kg"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(205, 52)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(225, 20)
        Me.DateTimePicker1.TabIndex = 21
        '
        'lblFechaInicioControl
        '
        Me.lblFechaInicioControl.AutoSize = True
        Me.lblFechaInicioControl.Location = New System.Drawing.Point(46, 57)
        Me.lblFechaInicioControl.Name = "lblFechaInicioControl"
        Me.lblFechaInicioControl.Size = New System.Drawing.Size(119, 13)
        Me.lblFechaInicioControl.TabIndex = 19
        Me.lblFechaInicioControl.Text = "Fecha inicio del control:"
        '
        'lblIdControl
        '
        Me.lblIdControl.AutoSize = True
        Me.lblIdControl.Location = New System.Drawing.Point(45, 29)
        Me.lblIdControl.Name = "lblIdControl"
        Me.lblIdControl.Size = New System.Drawing.Size(56, 13)
        Me.lblIdControl.TabIndex = 2
        Me.lblIdControl.Text = "ID control:"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(205, 104)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(62, 20)
        Me.txtPeso.TabIndex = 17
        '
        'txtIdControl
        '
        Me.txtIdControl.Location = New System.Drawing.Point(205, 26)
        Me.txtIdControl.Name = "txtIdControl"
        Me.txtIdControl.Size = New System.Drawing.Size(170, 20)
        Me.txtIdControl.TabIndex = 16
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(46, 107)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(34, 13)
        Me.lblPeso.TabIndex = 1
        Me.lblPeso.Text = "Peso:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(99, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 47
        '
        'txtBuscID
        '
        Me.txtBuscID.Location = New System.Drawing.Point(89, 12)
        Me.txtBuscID.Multiline = True
        Me.txtBuscID.Name = "txtBuscID"
        Me.txtBuscID.Size = New System.Drawing.Size(100, 27)
        Me.txtBuscID.TabIndex = 46
        '
        'lblIdAnimal
        '
        Me.lblIdAnimal.AutoSize = True
        Me.lblIdAnimal.Location = New System.Drawing.Point(12, 19)
        Me.lblIdAnimal.Name = "lblIdAnimal"
        Me.lblIdAnimal.Size = New System.Drawing.Size(71, 13)
        Me.lblIdAnimal.TabIndex = 45
        Me.lblIdAnimal.Text = "ID del animal:"
        '
        'ControlDelAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 278)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.frameControl)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBuscID)
        Me.Controls.Add(Me.lblIdAnimal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ControlDelAnimal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control del animal"
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
    Friend WithEvents lblFechaFinControl As System.Windows.Forms.Label
    Friend WithEvents lblKg As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaInicioControl As System.Windows.Forms.Label
    Friend WithEvents lblIdControl As System.Windows.Forms.Label
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents txtIdControl As System.Windows.Forms.TextBox
    Friend WithEvents lblPeso As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBuscID As System.Windows.Forms.TextBox
    Friend WithEvents lblIdAnimal As System.Windows.Forms.Label
End Class
