<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoEstablecimiento
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
        Me.lblIdEstablecimiento = New System.Windows.Forms.Label()
        Me.txtIdEstablecimiento = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblIdEstablecimiento
        '
        Me.lblIdEstablecimiento.AutoSize = True
        Me.lblIdEstablecimiento.Location = New System.Drawing.Point(12, 28)
        Me.lblIdEstablecimiento.Name = "lblIdEstablecimiento"
        Me.lblIdEstablecimiento.Size = New System.Drawing.Size(114, 13)
        Me.lblIdEstablecimiento.TabIndex = 0
        Me.lblIdEstablecimiento.Text = "ID del establecimiento:"
        '
        'txtIdEstablecimiento
        '
        Me.txtIdEstablecimiento.Location = New System.Drawing.Point(141, 25)
        Me.txtIdEstablecimiento.Multiline = True
        Me.txtIdEstablecimiento.Name = "txtIdEstablecimiento"
        Me.txtIdEstablecimiento.Size = New System.Drawing.Size(202, 23)
        Me.txtIdEstablecimiento.TabIndex = 1
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(60, 84)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 2
        Me.lblDescripcion.Text = "Descripción:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(317, 306)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(148, 27)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Atras"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(141, 81)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(324, 208)
        Me.txtDescripcion.TabIndex = 5
        '
        'InfoEstablecimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 356)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtIdEstablecimiento)
        Me.Controls.Add(Me.lblIdEstablecimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "InfoEstablecimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información del establecimiento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIdEstablecimiento As System.Windows.Forms.Label
    Friend WithEvents txtIdEstablecimiento As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
End Class
