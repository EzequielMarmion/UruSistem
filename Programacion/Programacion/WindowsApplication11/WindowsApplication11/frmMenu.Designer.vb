<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ZxcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZxcToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZxcToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VacaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnimalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnfermedadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProducciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarLoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformacionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZxcToolStripMenuItem, Me.ZxcToolStripMenuItem1, Me.ZxcToolStripMenuItem2, Me.EventosToolStripMenuItem, Me.ProducciónToolStripMenuItem, Me.InformacionToolStripMenuItem1, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(889, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ZxcToolStripMenuItem
        '
        Me.ZxcToolStripMenuItem.Image = CType(resources.GetObject("ZxcToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ZxcToolStripMenuItem.Name = "ZxcToolStripMenuItem"
        Me.ZxcToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.ZxcToolStripMenuItem.Text = "Usuarios"
        '
        'ZxcToolStripMenuItem1
        '
        Me.ZxcToolStripMenuItem1.Image = CType(resources.GetObject("ZxcToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ZxcToolStripMenuItem1.Name = "ZxcToolStripMenuItem1"
        Me.ZxcToolStripMenuItem1.Size = New System.Drawing.Size(78, 20)
        Me.ZxcToolStripMenuItem1.Text = "Tambos"
        '
        'ZxcToolStripMenuItem2
        '
        Me.ZxcToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VacaToolStripMenuItem, Me.ToroToolStripMenuItem, Me.CriaToolStripMenuItem, Me.AnimalesToolStripMenuItem})
        Me.ZxcToolStripMenuItem2.Image = CType(resources.GetObject("ZxcToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ZxcToolStripMenuItem2.Name = "ZxcToolStripMenuItem2"
        Me.ZxcToolStripMenuItem2.Size = New System.Drawing.Size(84, 20)
        Me.ZxcToolStripMenuItem2.Text = "Animales"
        '
        'VacaToolStripMenuItem
        '
        Me.VacaToolStripMenuItem.Name = "VacaToolStripMenuItem"
        Me.VacaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VacaToolStripMenuItem.Text = "Vaca"
        '
        'ToroToolStripMenuItem
        '
        Me.ToroToolStripMenuItem.Name = "ToroToolStripMenuItem"
        Me.ToroToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ToroToolStripMenuItem.Text = "Toro"
        '
        'CriaToolStripMenuItem
        '
        Me.CriaToolStripMenuItem.Name = "CriaToolStripMenuItem"
        Me.CriaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CriaToolStripMenuItem.Text = "Cria"
        '
        'AnimalesToolStripMenuItem
        '
        Me.AnimalesToolStripMenuItem.Name = "AnimalesToolStripMenuItem"
        Me.AnimalesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AnimalesToolStripMenuItem.Text = "Listado de Animales"
        '
        'EventosToolStripMenuItem
        '
        Me.EventosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntoreToolStripMenuItem, Me.EnfermedadesToolStripMenuItem, Me.ControlesToolStripMenuItem})
        Me.EventosToolStripMenuItem.Image = CType(resources.GetObject("EventosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EventosToolStripMenuItem.Name = "EventosToolStripMenuItem"
        Me.EventosToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.EventosToolStripMenuItem.Text = "Eventos"
        '
        'EntoreToolStripMenuItem
        '
        Me.EntoreToolStripMenuItem.Name = "EntoreToolStripMenuItem"
        Me.EntoreToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.EntoreToolStripMenuItem.Text = "Entore"
        '
        'EnfermedadesToolStripMenuItem
        '
        Me.EnfermedadesToolStripMenuItem.Name = "EnfermedadesToolStripMenuItem"
        Me.EnfermedadesToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.EnfermedadesToolStripMenuItem.Text = "Enfermedades"
        '
        'ControlesToolStripMenuItem
        '
        Me.ControlesToolStripMenuItem.Name = "ControlesToolStripMenuItem"
        Me.ControlesToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ControlesToolStripMenuItem.Text = "Controles"
        '
        'ProducciónToolStripMenuItem
        '
        Me.ProducciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarLoteToolStripMenuItem, Me.LoteToolStripMenuItem})
        Me.ProducciónToolStripMenuItem.Image = CType(resources.GetObject("ProducciónToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProducciónToolStripMenuItem.Name = "ProducciónToolStripMenuItem"
        Me.ProducciónToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.ProducciónToolStripMenuItem.Text = "Producción"
        '
        'AgregarLoteToolStripMenuItem
        '
        Me.AgregarLoteToolStripMenuItem.Name = "AgregarLoteToolStripMenuItem"
        Me.AgregarLoteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AgregarLoteToolStripMenuItem.Text = "Lote"
        '
        'LoteToolStripMenuItem
        '
        Me.LoteToolStripMenuItem.Name = "LoteToolStripMenuItem"
        Me.LoteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoteToolStripMenuItem.Text = "Leche"
        '
        'InformacionToolStripMenuItem1
        '
        Me.InformacionToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.InformacionToolStripMenuItem1.Image = CType(resources.GetObject("InformacionToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.InformacionToolStripMenuItem1.Name = "InformacionToolStripMenuItem1"
        Me.InformacionToolStripMenuItem1.Size = New System.Drawing.Size(100, 20)
        Me.InformacionToolStripMenuItem1.Text = "Información"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(103, 20)
        Me.ToolStripMenuItem1.Text = "Cerrar sesion"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 579)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(889, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel1.Text = "Status"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(889, 601)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UruSistem"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ZxcToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZxcToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZxcToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents InformacionToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VacaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnimalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnfermedadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProducciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarLoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
