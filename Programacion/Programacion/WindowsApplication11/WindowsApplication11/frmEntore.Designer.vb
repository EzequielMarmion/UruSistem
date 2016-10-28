<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntore
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
        Me.frameEntore = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaEntore = New System.Windows.Forms.Label()
        Me.lblIdVaca = New System.Windows.Forms.Label()
        Me.lblIdToro = New System.Windows.Forms.Label()
        Me.txtIdToro = New System.Windows.Forms.TextBox()
        Me.txtIdVaca = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.frameEntore.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'frameEntore
        '
        Me.frameEntore.Controls.Add(Me.DateTimePicker)
        Me.frameEntore.Controls.Add(Me.lblFechaEntore)
        Me.frameEntore.Controls.Add(Me.lblIdVaca)
        Me.frameEntore.Controls.Add(Me.lblIdToro)
        Me.frameEntore.Controls.Add(Me.txtIdToro)
        Me.frameEntore.Controls.Add(Me.txtIdVaca)
        Me.frameEntore.Location = New System.Drawing.Point(14, 18)
        Me.frameEntore.Name = "frameEntore"
        Me.frameEntore.Size = New System.Drawing.Size(386, 130)
        Me.frameEntore.TabIndex = 35
        Me.frameEntore.TabStop = False
        Me.frameEntore.Text = "Datos"
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker.Location = New System.Drawing.Point(162, 83)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(78, 20)
        Me.DateTimePicker.TabIndex = 59
        '
        'lblFechaEntore
        '
        Me.lblFechaEntore.AutoSize = True
        Me.lblFechaEntore.Location = New System.Drawing.Point(59, 90)
        Me.lblFechaEntore.Name = "lblFechaEntore"
        Me.lblFechaEntore.Size = New System.Drawing.Size(88, 13)
        Me.lblFechaEntore.TabIndex = 18
        Me.lblFechaEntore.Text = "Fecha de entore:"
        '
        'lblIdVaca
        '
        Me.lblIdVaca.AutoSize = True
        Me.lblIdVaca.Location = New System.Drawing.Point(59, 61)
        Me.lblIdVaca.Name = "lblIdVaca"
        Me.lblIdVaca.Size = New System.Drawing.Size(72, 13)
        Me.lblIdVaca.TabIndex = 2
        Me.lblIdVaca.Text = "Id de la vaca:"
        '
        'lblIdToro
        '
        Me.lblIdToro.AutoSize = True
        Me.lblIdToro.Location = New System.Drawing.Point(59, 30)
        Me.lblIdToro.Name = "lblIdToro"
        Me.lblIdToro.Size = New System.Drawing.Size(57, 13)
        Me.lblIdToro.TabIndex = 1
        Me.lblIdToro.Text = "Id del toro:"
        '
        'txtIdToro
        '
        Me.txtIdToro.Location = New System.Drawing.Point(162, 23)
        Me.txtIdToro.Name = "txtIdToro"
        Me.txtIdToro.Size = New System.Drawing.Size(143, 20)
        Me.txtIdToro.TabIndex = 17
        '
        'txtIdVaca
        '
        Me.txtIdVaca.Location = New System.Drawing.Point(162, 54)
        Me.txtIdVaca.Name = "txtIdVaca"
        Me.txtIdVaca.Size = New System.Drawing.Size(143, 20)
        Me.txtIdVaca.TabIndex = 16
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(43, 162)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(148, 27)
        Me.btnAceptar.TabIndex = 61
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(232, 162)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(148, 27)
        Me.btnCancelar.TabIndex = 60
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(191, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 64
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(190, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 61
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(445, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(368, 130)
        Me.DataGridView1.TabIndex = 65
        '
        'frmEntore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(856, 224)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.frameEntore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmEntore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":. Entore"
        Me.frameEntore.ResumeLayout(False)
        Me.frameEntore.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents frameEntore As System.Windows.Forms.GroupBox
    Friend WithEvents lblFechaEntore As System.Windows.Forms.Label
    Friend WithEvents lblIdVaca As System.Windows.Forms.Label
    Friend WithEvents lblIdToro As System.Windows.Forms.Label
    Friend WithEvents txtIdToro As System.Windows.Forms.TextBox
    Friend WithEvents txtIdVaca As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
