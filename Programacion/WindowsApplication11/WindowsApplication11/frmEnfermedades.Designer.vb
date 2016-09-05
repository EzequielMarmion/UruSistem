<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnfermedades
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.frameEnfermedades = New System.Windows.Forms.GroupBox()
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
        Me.frameEnfermedades.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(260, 220)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(148, 27)
        Me.btnCancelar.TabIndex = 51
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(102, 220)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(148, 27)
        Me.btnAceptar.TabIndex = 50
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(300, 16)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(58, 20)
        Me.btnBuscar.TabIndex = 49
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'frameEnfermedades
        '
        Me.frameEnfermedades.Controls.Add(Me.DateTimePicker2)
        Me.frameEnfermedades.Controls.Add(Me.lblFechaFinEnfermedad)
        Me.frameEnfermedades.Controls.Add(Me.DateTimePicker1)
        Me.frameEnfermedades.Controls.Add(Me.txtIdMedicamento)
        Me.frameEnfermedades.Controls.Add(Me.lblFechaInicioenfermedad)
        Me.frameEnfermedades.Controls.Add(Me.lblIdMedicamento)
        Me.frameEnfermedades.Controls.Add(Me.lblIdEnfermedad)
        Me.frameEnfermedades.Controls.Add(Me.txtIdEnfermedad)
        Me.frameEnfermedades.Enabled = False
        Me.frameEnfermedades.Location = New System.Drawing.Point(16, 60)
        Me.frameEnfermedades.Name = "frameEnfermedades"
        Me.frameEnfermedades.Size = New System.Drawing.Size(450, 140)
        Me.frameEnfermedades.TabIndex = 48
        Me.frameEnfermedades.TabStop = False
        Me.frameEnfermedades.Text = "Información"
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
        Me.Label7.Location = New System.Drawing.Point(220, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 47
        '
        'txtBuscID
        '
        Me.txtBuscID.Location = New System.Drawing.Point(178, 16)
        Me.txtBuscID.Name = "txtBuscID"
        Me.txtBuscID.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscID.TabIndex = 46
        '
        'lblIdAnimal
        '
        Me.lblIdAnimal.AutoSize = True
        Me.lblIdAnimal.Location = New System.Drawing.Point(99, 19)
        Me.lblIdAnimal.Name = "lblIdAnimal"
        Me.lblIdAnimal.Size = New System.Drawing.Size(54, 13)
        Me.lblIdAnimal.TabIndex = 45
        Me.lblIdAnimal.Text = "ID animal:"
        '
        'frmEnfermedades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 259)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.frameEnfermedades)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBuscID)
        Me.Controls.Add(Me.lblIdAnimal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEnfermedades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":. Enfermedades"
        Me.frameEnfermedades.ResumeLayout(False)
        Me.frameEnfermedades.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents frameEnfermedades As System.Windows.Forms.GroupBox
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
