<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLeche
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.frameEntore = New System.Windows.Forms.GroupBox()
        Me.lblIdVaca = New System.Windows.Forms.Label()
        Me.lblIdLote = New System.Windows.Forms.Label()
        Me.txtIdLeche = New System.Windows.Forms.TextBox()
        Me.txtTipoLeche = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdLote = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frameEntore.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(453, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(368, 130)
        Me.DataGridView1.TabIndex = 70
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(66, 198)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(148, 27)
        Me.btnAceptar.TabIndex = 69
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(244, 198)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(148, 27)
        Me.btnCancelar.TabIndex = 68
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frameEntore
        '
        Me.frameEntore.Controls.Add(Me.Label1)
        Me.frameEntore.Controls.Add(Me.txtIdLote)
        Me.frameEntore.Controls.Add(Me.lblIdVaca)
        Me.frameEntore.Controls.Add(Me.lblIdLote)
        Me.frameEntore.Controls.Add(Me.txtIdLeche)
        Me.frameEntore.Controls.Add(Me.txtTipoLeche)
        Me.frameEntore.Location = New System.Drawing.Point(55, 43)
        Me.frameEntore.Name = "frameEntore"
        Me.frameEntore.Size = New System.Drawing.Size(356, 132)
        Me.frameEntore.TabIndex = 67
        Me.frameEntore.TabStop = False
        Me.frameEntore.Text = "Datos"
        '
        'lblIdVaca
        '
        Me.lblIdVaca.AutoSize = True
        Me.lblIdVaca.Location = New System.Drawing.Point(52, 66)
        Me.lblIdVaca.Name = "lblIdVaca"
        Me.lblIdVaca.Size = New System.Drawing.Size(71, 13)
        Me.lblIdVaca.TabIndex = 2
        Me.lblIdVaca.Text = "tipo de leche:"
        '
        'lblIdLote
        '
        Me.lblIdLote.AutoSize = True
        Me.lblIdLote.Location = New System.Drawing.Point(52, 35)
        Me.lblIdLote.Name = "lblIdLote"
        Me.lblIdLote.Size = New System.Drawing.Size(74, 13)
        Me.lblIdLote.TabIndex = 1
        Me.lblIdLote.Text = "Id de la leche:"
        '
        'txtIdLeche
        '
        Me.txtIdLeche.Location = New System.Drawing.Point(169, 24)
        Me.txtIdLeche.Name = "txtIdLeche"
        Me.txtIdLeche.Size = New System.Drawing.Size(143, 20)
        Me.txtIdLeche.TabIndex = 17
        '
        'txtTipoLeche
        '
        Me.txtTipoLeche.Location = New System.Drawing.Point(169, 59)
        Me.txtTipoLeche.Name = "txtTipoLeche"
        Me.txtTipoLeche.Size = New System.Drawing.Size(143, 20)
        Me.txtTipoLeche.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Id del lote:"
        '
        'txtIdLote
        '
        Me.txtIdLote.Location = New System.Drawing.Point(169, 85)
        Me.txtIdLote.Name = "txtIdLote"
        Me.txtIdLote.Size = New System.Drawing.Size(143, 20)
        Me.txtIdLote.TabIndex = 19
        '
        'frmLeche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 249)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.frameEntore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmLeche"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":. Leche"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frameEntore.ResumeLayout(False)
        Me.frameEntore.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents frameEntore As System.Windows.Forms.GroupBox
    Friend WithEvents lblIdVaca As System.Windows.Forms.Label
    Friend WithEvents lblIdLote As System.Windows.Forms.Label
    Friend WithEvents txtIdLeche As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoLeche As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIdLote As System.Windows.Forms.TextBox
End Class
