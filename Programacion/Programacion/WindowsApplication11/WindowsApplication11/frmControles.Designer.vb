<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControles
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCanelar = New System.Windows.Forms.Button()
        Me.frameControles = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFinControl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaInicioControl = New System.Windows.Forms.Label()
        Me.lblIdControl = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtIdControl = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.frameControles.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(74, 199)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(148, 26)
        Me.btnAceptar.TabIndex = 54
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCanelar
        '
        Me.btnCanelar.Location = New System.Drawing.Point(248, 199)
        Me.btnCanelar.Name = "btnCanelar"
        Me.btnCanelar.Size = New System.Drawing.Size(149, 26)
        Me.btnCanelar.TabIndex = 53
        Me.btnCanelar.Text = "Cancelar"
        Me.btnCanelar.UseVisualStyleBackColor = True
        '
        'frameControles
        '
        Me.frameControles.Controls.Add(Me.DateTimePicker1)
        Me.frameControles.Controls.Add(Me.lblFechaFinControl)
        Me.frameControles.Controls.Add(Me.Label2)
        Me.frameControles.Controls.Add(Me.DateTimePicker3)
        Me.frameControles.Controls.Add(Me.lblFechaInicioControl)
        Me.frameControles.Controls.Add(Me.lblIdControl)
        Me.frameControles.Controls.Add(Me.TextBox1)
        Me.frameControles.Controls.Add(Me.txtIdControl)
        Me.frameControles.Controls.Add(Me.Label3)
        Me.frameControles.Enabled = False
        Me.frameControles.Location = New System.Drawing.Point(25, 42)
        Me.frameControles.Name = "frameControles"
        Me.frameControles.Size = New System.Drawing.Size(468, 142)
        Me.frameControles.TabIndex = 51
        Me.frameControles.TabStop = False
        Me.frameControles.Text = "Datos"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(203, 77)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(70, 20)
        Me.DateTimePicker1.TabIndex = 24
        '
        'lblFechaFinControl
        '
        Me.lblFechaFinControl.AutoSize = True
        Me.lblFechaFinControl.Location = New System.Drawing.Point(44, 83)
        Me.lblFechaFinControl.Name = "lblFechaFinControl"
        Me.lblFechaFinControl.Size = New System.Drawing.Size(89, 13)
        Me.lblFechaFinControl.TabIndex = 23
        Me.lblFechaFinControl.Text = "Fecha fin control:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(286, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Kg"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(203, 51)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(70, 20)
        Me.DateTimePicker3.TabIndex = 21
        '
        'lblFechaInicioControl
        '
        Me.lblFechaInicioControl.AutoSize = True
        Me.lblFechaInicioControl.Location = New System.Drawing.Point(44, 56)
        Me.lblFechaInicioControl.Name = "lblFechaInicioControl"
        Me.lblFechaInicioControl.Size = New System.Drawing.Size(119, 13)
        Me.lblFechaInicioControl.TabIndex = 19
        Me.lblFechaInicioControl.Text = "Fecha inicio del control:"
        '
        'lblIdControl
        '
        Me.lblIdControl.AutoSize = True
        Me.lblIdControl.Location = New System.Drawing.Point(43, 28)
        Me.lblIdControl.Name = "lblIdControl"
        Me.lblIdControl.Size = New System.Drawing.Size(56, 13)
        Me.lblIdControl.TabIndex = 2
        Me.lblIdControl.Text = "ID control:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(203, 103)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(70, 20)
        Me.TextBox1.TabIndex = 17
        '
        'txtIdControl
        '
        Me.txtIdControl.Location = New System.Drawing.Point(203, 25)
        Me.txtIdControl.Name = "txtIdControl"
        Me.txtIdControl.Size = New System.Drawing.Size(170, 20)
        Me.txtIdControl.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Peso:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(257, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 50
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(290, 16)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(58, 20)
        Me.btnBuscar.TabIndex = 59
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscID
        '
        Me.txtBuscID.Location = New System.Drawing.Point(174, 16)
        Me.txtBuscID.Name = "txtBuscID"
        Me.txtBuscID.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscID.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(85, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "ID del animal:"
        '
        'frmControles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 240)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCanelar)
        Me.Controls.Add(Me.frameControles)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmControles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":. Controles"
        Me.frameControles.ResumeLayout(False)
        Me.frameControles.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCanelar As System.Windows.Forms.Button
    Friend WithEvents frameControles As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFinControl As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaInicioControl As System.Windows.Forms.Label
    Friend WithEvents lblIdControl As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtIdControl As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtBuscID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
