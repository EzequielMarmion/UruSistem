<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControl
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
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.frameControles = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdAnimal = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblIdContol = New System.Windows.Forms.Label()
        Me.lblIdControl = New System.Windows.Forms.Label()
        Me.txtIdControl = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscID = New System.Windows.Forms.TextBox()
        Me.lblIdAnimal = New System.Windows.Forms.Label()
        Me.frameControles.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(206, 182)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(148, 27)
        Me.btnCancelar.TabIndex = 56
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(34, 182)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(148, 27)
        Me.btnCrear.TabIndex = 55
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'frameControles
        '
        Me.frameControles.Controls.Add(Me.Label1)
        Me.frameControles.Controls.Add(Me.txtIdAnimal)
        Me.frameControles.Controls.Add(Me.txtNombre)
        Me.frameControles.Controls.Add(Me.lblIdContol)
        Me.frameControles.Controls.Add(Me.lblIdControl)
        Me.frameControles.Controls.Add(Me.txtIdControl)
        Me.frameControles.Location = New System.Drawing.Point(12, 55)
        Me.frameControles.Name = "frameControles"
        Me.frameControles.Size = New System.Drawing.Size(396, 110)
        Me.frameControles.TabIndex = 54
        Me.frameControles.TabStop = False
        Me.frameControles.Text = "Información"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "ID animal:"
        '
        'txtIdAnimal
        '
        Me.txtIdAnimal.Location = New System.Drawing.Point(173, 70)
        Me.txtIdAnimal.Name = "txtIdAnimal"
        Me.txtIdAnimal.Size = New System.Drawing.Size(170, 20)
        Me.txtIdAnimal.TabIndex = 20
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(173, 18)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(170, 20)
        Me.txtNombre.TabIndex = 18
        '
        'lblIdContol
        '
        Me.lblIdContol.AutoSize = True
        Me.lblIdContol.Location = New System.Drawing.Point(49, 25)
        Me.lblIdContol.Name = "lblIdContol"
        Me.lblIdContol.Size = New System.Drawing.Size(47, 13)
        Me.lblIdContol.TabIndex = 17
        Me.lblIdContol.Text = "Nombre:"
        '
        'lblIdControl
        '
        Me.lblIdControl.AutoSize = True
        Me.lblIdControl.Location = New System.Drawing.Point(49, 51)
        Me.lblIdControl.Name = "lblIdControl"
        Me.lblIdControl.Size = New System.Drawing.Size(53, 13)
        Me.lblIdControl.TabIndex = 2
        Me.lblIdControl.Text = "IDcontrol:"
        '
        'txtIdControl
        '
        Me.txtIdControl.Location = New System.Drawing.Point(173, 44)
        Me.txtIdControl.Name = "txtIdControl"
        Me.txtIdControl.Size = New System.Drawing.Size(170, 20)
        Me.txtIdControl.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(216, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 53
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(276, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(58, 20)
        Me.btnBuscar.TabIndex = 60
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 59
        '
        'txtBuscID
        '
        Me.txtBuscID.Location = New System.Drawing.Point(152, 12)
        Me.txtBuscID.Name = "txtBuscID"
        Me.txtBuscID.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscID.TabIndex = 58
        '
        'lblIdAnimal
        '
        Me.lblIdAnimal.AutoSize = True
        Me.lblIdAnimal.Location = New System.Drawing.Point(61, 15)
        Me.lblIdAnimal.Name = "lblIdAnimal"
        Me.lblIdAnimal.Size = New System.Drawing.Size(73, 13)
        Me.lblIdAnimal.TabIndex = 57
        Me.lblIdAnimal.Text = "ID del control:"
        '
        'frmControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(432, 244)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscID)
        Me.Controls.Add(Me.lblIdAnimal)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.frameControles)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":. Controles"
        Me.frameControles.ResumeLayout(False)
        Me.frameControles.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnCrear As System.Windows.Forms.Button
    Friend WithEvents frameControles As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblIdContol As System.Windows.Forms.Label
    Friend WithEvents lblIdControl As System.Windows.Forms.Label
    Friend WithEvents txtIdControl As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIdAnimal As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBuscID As System.Windows.Forms.TextBox
    Friend WithEvents lblIdAnimal As System.Windows.Forms.Label
End Class
