<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLote
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
        Me.lblIdVaca = New System.Windows.Forms.Label()
        Me.lblIdLote = New System.Windows.Forms.Label()
        Me.txtIdLote = New System.Windows.Forms.TextBox()
        Me.txtCantAnimales = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.frameEntore.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'frameEntore
        '
        Me.frameEntore.Controls.Add(Me.lblIdVaca)
        Me.frameEntore.Controls.Add(Me.lblIdLote)
        Me.frameEntore.Controls.Add(Me.txtIdLote)
        Me.frameEntore.Controls.Add(Me.txtCantAnimales)
        Me.frameEntore.Location = New System.Drawing.Point(25, 23)
        Me.frameEntore.Name = "frameEntore"
        Me.frameEntore.Size = New System.Drawing.Size(356, 112)
        Me.frameEntore.TabIndex = 36
        Me.frameEntore.TabStop = False
        Me.frameEntore.Text = "Datos"
        '
        'lblIdVaca
        '
        Me.lblIdVaca.AutoSize = True
        Me.lblIdVaca.Location = New System.Drawing.Point(52, 66)
        Me.lblIdVaca.Name = "lblIdVaca"
        Me.lblIdVaca.Size = New System.Drawing.Size(111, 13)
        Me.lblIdVaca.TabIndex = 2
        Me.lblIdVaca.Text = "Cantidad de animales:"
        '
        'lblIdLote
        '
        Me.lblIdLote.AutoSize = True
        Me.lblIdLote.Location = New System.Drawing.Point(52, 35)
        Me.lblIdLote.Name = "lblIdLote"
        Me.lblIdLote.Size = New System.Drawing.Size(56, 13)
        Me.lblIdLote.TabIndex = 1
        Me.lblIdLote.Text = "Id del lote:"
        '
        'txtIdLote
        '
        Me.txtIdLote.Location = New System.Drawing.Point(169, 24)
        Me.txtIdLote.Name = "txtIdLote"
        Me.txtIdLote.Size = New System.Drawing.Size(143, 20)
        Me.txtIdLote.TabIndex = 17
        '
        'txtCantAnimales
        '
        Me.txtCantAnimales.Location = New System.Drawing.Point(169, 59)
        Me.txtCantAnimales.Name = "txtCantAnimales"
        Me.txtCantAnimales.Size = New System.Drawing.Size(143, 20)
        Me.txtCantAnimales.TabIndex = 16
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(56, 170)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(148, 27)
        Me.btnAceptar.TabIndex = 63
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(245, 170)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(148, 27)
        Me.btnCancelar.TabIndex = 62
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(427, 33)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(368, 130)
        Me.DataGridView1.TabIndex = 66
        '
        'frmLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 222)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.frameEntore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmLote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":. Lote"
        Me.frameEntore.ResumeLayout(False)
        Me.frameEntore.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frameEntore As System.Windows.Forms.GroupBox
    Friend WithEvents lblIdVaca As System.Windows.Forms.Label
    Friend WithEvents lblIdLote As System.Windows.Forms.Label
    Friend WithEvents txtIdLote As System.Windows.Forms.TextBox
    Friend WithEvents txtCantAnimales As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
