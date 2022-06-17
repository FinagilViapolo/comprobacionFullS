<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiGastosFS
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ContratosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutorizantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarjetasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeTarjetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedorDeTarjetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContratosToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.AutorizantesToolStripMenuItem, Me.TarjetasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1063, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ContratosToolStripMenuItem
        '
        Me.ContratosToolStripMenuItem.Name = "ContratosToolStripMenuItem"
        Me.ContratosToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ContratosToolStripMenuItem.Text = "Contratos"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'AutorizantesToolStripMenuItem
        '
        Me.AutorizantesToolStripMenuItem.Name = "AutorizantesToolStripMenuItem"
        Me.AutorizantesToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.AutorizantesToolStripMenuItem.Text = "Autorizadores"
        '
        'TarjetasToolStripMenuItem
        '
        Me.TarjetasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoDeTarjetaToolStripMenuItem, Me.ProveedorDeTarjetaToolStripMenuItem, Me.InventarioToolStripMenuItem})
        Me.TarjetasToolStripMenuItem.Name = "TarjetasToolStripMenuItem"
        Me.TarjetasToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.TarjetasToolStripMenuItem.Text = "Tarjetas"
        '
        'TipoDeTarjetaToolStripMenuItem
        '
        Me.TipoDeTarjetaToolStripMenuItem.Name = "TipoDeTarjetaToolStripMenuItem"
        Me.TipoDeTarjetaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TipoDeTarjetaToolStripMenuItem.Text = "Tipo de tarjeta"
        '
        'ProveedorDeTarjetaToolStripMenuItem
        '
        Me.ProveedorDeTarjetaToolStripMenuItem.Name = "ProveedorDeTarjetaToolStripMenuItem"
        Me.ProveedorDeTarjetaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProveedorDeTarjetaToolStripMenuItem.Text = "Proveedor de tarjeta"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1063, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'mdiGastosFS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "mdiGastosFS"
        Me.Text = "Comprobación de gastos Fullservice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ContratosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutorizantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TarjetasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoDeTarjetaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedorDeTarjetaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
