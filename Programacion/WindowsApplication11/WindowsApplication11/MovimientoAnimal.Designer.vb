<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovimientoAnimal
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.frameMov = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtLugarUltimoMov = New System.Windows.Forms.TextBox()
        Me.lblLugarUltimoMov = New System.Windows.Forms.Label()
        Me.lblFechaUltimoMov = New System.Windows.Forms.Label()
        Me.lblHoraUltimoMov = New System.Windows.Forms.Label()
        Me.lblIdPais = New System.Windows.Forms.Label()
        Me.txtIdPais = New System.Windows.Forms.TextBox()
        Me.txtHoraUltimoMov = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBuscIDMov = New System.Windows.Forms.TextBox()
        Me.lblIdAnimal = New System.Windows.Forms.Label()
        Me.frameMov.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(230, 217)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 27)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(72, 217)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 27)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Aceptar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(190, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(58, 27)
        Me.btnBuscar.TabIndex = 35
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'frameMov
        '
        Me.frameMov.Controls.Add(Me.DateTimePicker1)
        Me.frameMov.Controls.Add(Me.txtLugarUltimoMov)
        Me.frameMov.Controls.Add(Me.lblLugarUltimoMov)
        Me.frameMov.Controls.Add(Me.lblFechaUltimoMov)
        Me.frameMov.Controls.Add(Me.lblHoraUltimoMov)
        Me.frameMov.Controls.Add(Me.lblIdPais)
        Me.frameMov.Controls.Add(Me.txtIdPais)
        Me.frameMov.Controls.Add(Me.txtHoraUltimoMov)
        Me.frameMov.Enabled = False
        Me.frameMov.Location = New System.Drawing.Point(11, 59)
        Me.frameMov.Name = "frameMov"
        Me.frameMov.Size = New System.Drawing.Size(444, 143)
        Me.frameMov.TabIndex = 34
        Me.frameMov.TabStop = False
        Me.frameMov.Text = "Información"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(204, 104)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(225, 20)
        Me.DateTimePicker1.TabIndex = 21
        '
        'txtLugarUltimoMov
        '
        Me.txtLugarUltimoMov.Location = New System.Drawing.Point(204, 77)
        Me.txtLugarUltimoMov.Name = "txtLugarUltimoMov"
        Me.txtLugarUltimoMov.Size = New System.Drawing.Size(170, 20)
        Me.txtLugarUltimoMov.TabIndex = 20
        '
        'lblLugarUltimoMov
        '
        Me.lblLugarUltimoMov.AutoSize = True
        Me.lblLugarUltimoMov.Location = New System.Drawing.Point(45, 84)
        Me.lblLugarUltimoMov.Name = "lblLugarUltimoMov"
        Me.lblLugarUltimoMov.Size = New System.Drawing.Size(140, 13)
        Me.lblLugarUltimoMov.TabIndex = 19
        Me.lblLugarUltimoMov.Text = "Lugar del ultimo movimiento:"
        '
        'lblFechaUltimoMov
        '
        Me.lblFechaUltimoMov.AutoSize = True
        Me.lblFechaUltimoMov.Location = New System.Drawing.Point(48, 111)
        Me.lblFechaUltimoMov.Name = "lblFechaUltimoMov"
        Me.lblFechaUltimoMov.Size = New System.Drawing.Size(126, 13)
        Me.lblFechaUltimoMov.TabIndex = 18
        Me.lblFechaUltimoMov.Text = "Fecha ultimo movimiento:"
        '
        'lblHoraUltimoMov
        '
        Me.lblHoraUltimoMov.AutoSize = True
        Me.lblHoraUltimoMov.Location = New System.Drawing.Point(48, 55)
        Me.lblHoraUltimoMov.Name = "lblHoraUltimoMov"
        Me.lblHoraUltimoMov.Size = New System.Drawing.Size(134, 13)
        Me.lblHoraUltimoMov.TabIndex = 2
        Me.lblHoraUltimoMov.Text = "Hora de ultimo movimiento:"
        '
        'lblIdPais
        '
        Me.lblIdPais.AutoSize = True
        Me.lblIdPais.Location = New System.Drawing.Point(48, 28)
        Me.lblIdPais.Name = "lblIdPais"
        Me.lblIdPais.Size = New System.Drawing.Size(46, 13)
        Me.lblIdPais.TabIndex = 1
        Me.lblIdPais.Text = "ID País:"
        '
        'txtIdPais
        '
        Me.txtIdPais.Location = New System.Drawing.Point(204, 21)
        Me.txtIdPais.Name = "txtIdPais"
        Me.txtIdPais.Size = New System.Drawing.Size(170, 20)
        Me.txtIdPais.TabIndex = 17
        '
        'txtHoraUltimoMov
        '
        Me.txtHoraUltimoMov.Location = New System.Drawing.Point(204, 48)
        Me.txtHoraUltimoMov.Name = "txtHoraUltimoMov"
        Me.txtHoraUltimoMov.Size = New System.Drawing.Size(170, 20)
        Me.txtHoraUltimoMov.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(95, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 33
        '
        'txtBuscIDMov
        '
        Me.txtBuscIDMov.Location = New System.Drawing.Point(74, 12)
        Me.txtBuscIDMov.Multiline = True
        Me.txtBuscIDMov.Name = "txtBuscIDMov"
        Me.txtBuscIDMov.Size = New System.Drawing.Size(100, 27)
        Me.txtBuscIDMov.TabIndex = 32
        '
        'lblIdAnimal
        '
        Me.lblIdAnimal.AutoSize = True
        Me.lblIdAnimal.Location = New System.Drawing.Point(14, 19)
        Me.lblIdAnimal.Name = "lblIdAnimal"
        Me.lblIdAnimal.Size = New System.Drawing.Size(54, 13)
        Me.lblIdAnimal.TabIndex = 31
        Me.lblIdAnimal.Text = "ID animal:"
        '
        'MovimientoAnimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 264)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.frameMov)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBuscIDMov)
        Me.Controls.Add(Me.lblIdAnimal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MovimientoAnimal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MovimientoAnimal"
        Me.frameMov.ResumeLayout(False)
        Me.frameMov.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents frameMov As System.Windows.Forms.GroupBox
    Friend WithEvents lblHoraUltimoMov As System.Windows.Forms.Label
    Friend WithEvents lblIdPais As System.Windows.Forms.Label
    Friend WithEvents txtIdPais As System.Windows.Forms.TextBox
    Friend WithEvents txtHoraUltimoMov As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBuscIDMov As System.Windows.Forms.TextBox
    Friend WithEvents lblIdAnimal As System.Windows.Forms.Label
    Friend WithEvents lblLugarUltimoMov As System.Windows.Forms.Label
    Friend WithEvents lblFechaUltimoMov As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtLugarUltimoMov As System.Windows.Forms.TextBox
End Class
