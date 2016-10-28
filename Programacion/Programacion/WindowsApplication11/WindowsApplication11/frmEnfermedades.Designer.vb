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
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.frameEnfermedades = New System.Windows.Forms.GroupBox()
        Me.lblIdEnfermedad = New System.Windows.Forms.Label()
        Me.txtIdEnfermedad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBuscID = New System.Windows.Forms.TextBox()
        Me.lblIdAnimal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.frameEnfermedades.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(333, 197)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(148, 27)
        Me.btnCancelar.TabIndex = 51
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(16, 197)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(148, 27)
        Me.btnCrear.TabIndex = 50
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
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
        Me.frameEnfermedades.Controls.Add(Me.txtNombre)
        Me.frameEnfermedades.Controls.Add(Me.Label1)
        Me.frameEnfermedades.Controls.Add(Me.lblIdEnfermedad)
        Me.frameEnfermedades.Controls.Add(Me.txtIdEnfermedad)
        Me.frameEnfermedades.Location = New System.Drawing.Point(16, 60)
        Me.frameEnfermedades.Name = "frameEnfermedades"
        Me.frameEnfermedades.Size = New System.Drawing.Size(428, 110)
        Me.frameEnfermedades.TabIndex = 48
        Me.frameEnfermedades.TabStop = False
        Me.frameEnfermedades.Text = "Información"
        '
        'lblIdEnfermedad
        '
        Me.lblIdEnfermedad.AutoSize = True
        Me.lblIdEnfermedad.Location = New System.Drawing.Point(48, 59)
        Me.lblIdEnfermedad.Name = "lblIdEnfermedad"
        Me.lblIdEnfermedad.Size = New System.Drawing.Size(80, 13)
        Me.lblIdEnfermedad.TabIndex = 2
        Me.lblIdEnfermedad.Text = "ID enfermedad:"
        '
        'txtIdEnfermedad
        '
        Me.txtIdEnfermedad.Location = New System.Drawing.Point(172, 52)
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
        Me.lblIdAnimal.Location = New System.Drawing.Point(64, 19)
        Me.lblIdAnimal.Name = "lblIdAnimal"
        Me.lblIdAnimal.Size = New System.Drawing.Size(95, 13)
        Me.lblIdAnimal.TabIndex = 45
        Me.lblIdAnimal.Text = "ID de enfermedad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(172, 26)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(170, 20)
        Me.txtNombre.TabIndex = 18
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(178, 197)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(148, 27)
        Me.btnModificar.TabIndex = 52
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'frmEnfermedades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(493, 236)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.frameEnfermedades)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBuscID)
        Me.Controls.Add(Me.lblIdAnimal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmEnfermedades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":. Enfermedades"
        Me.frameEnfermedades.ResumeLayout(False)
        Me.frameEnfermedades.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents frameEnfermedades As System.Windows.Forms.GroupBox
    Friend WithEvents lblIdEnfermedad As System.Windows.Forms.Label
    Friend WithEvents txtIdEnfermedad As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBuscID As System.Windows.Forms.TextBox
    Friend WithEvents lblIdAnimal As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
End Class
