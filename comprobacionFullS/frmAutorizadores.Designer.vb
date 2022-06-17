<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutorizadores
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim MailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutorizadores))
        Me.ProductionDataSet = New comprobacionFullS.ProductionDataSet()
        Me.FULL_AutorizantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FULL_AutorizantesTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.FULL_AutorizantesTableAdapter()
        Me.TableAdapterManager = New comprobacionFullS.ProductionDataSetTableAdapters.TableAdapterManager()
        Me.FULL_AutorizantesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FULL_AutorizantesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.MailTextBox = New System.Windows.Forms.TextBox()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.VwFullDatosServicioCXPClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.VwFullDatosServicioCXPSucursalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwFullDatosServicioCXPAnexosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Vw_Full_DatosServicioCXP_ClientesTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.Vw_Full_DatosServicioCXP_ClientesTableAdapter()
        Me.Vw_Full_DatosServicioCXP_SucursalTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.Vw_Full_DatosServicioCXP_SucursalTableAdapter()
        Me.Vw_Full_DatosServicioCXP_AnexosTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.Vw_Full_DatosServicioCXP_AnexosTableAdapter()
        Me.cmbAnexo = New System.Windows.Forms.ComboBox()
        Me.ContratoTextBox = New System.Windows.Forms.TextBox()
        Me.SucursalTextBox = New System.Windows.Forms.TextBox()
        NombreLabel = New System.Windows.Forms.Label()
        MailLabel = New System.Windows.Forms.Label()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULL_AutorizantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULL_AutorizantesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FULL_AutorizantesBindingNavigator.SuspendLayout()
        CType(Me.VwFullDatosServicioCXPClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwFullDatosServicioCXPSucursalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwFullDatosServicioCXPAnexosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(15, 40)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 1
        NombreLabel.Text = "Nombre:"
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(32, 66)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(28, 13)
        MailLabel.TabIndex = 3
        MailLabel.Text = "mail:"
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FULL_AutorizantesBindingSource
        '
        Me.FULL_AutorizantesBindingSource.DataMember = "FULL_Autorizantes"
        Me.FULL_AutorizantesBindingSource.DataSource = Me.ProductionDataSet
        '
        'FULL_AutorizantesTableAdapter
        '
        Me.FULL_AutorizantesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FULL_AutorizantesTableAdapter = Me.FULL_AutorizantesTableAdapter
        Me.TableAdapterManager.FULL_ClientesTableAdapter = Nothing
        Me.TableAdapterManager.FULL_EstatusTableAdapter = Nothing
        Me.TableAdapterManager.FULL_ProveedorTarjetaTableAdapter = Nothing
        Me.TableAdapterManager.FULL_ServiciosTableAdapter = Nothing
        Me.TableAdapterManager.FULL_TarjetasConceptosTableAdapter = Nothing
        Me.TableAdapterManager.FULL_TarjetasTableAdapter = Nothing
        Me.TableAdapterManager.FULL_TipoTarjetaTableAdapter = Nothing
        Me.TableAdapterManager.FULL_UsuarioClienteTableAdapter = Nothing
        Me.TableAdapterManager.FULL_UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.GEN_Correos_SistemaFinagilTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = comprobacionFullS.ProductionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FULL_AutorizantesBindingNavigator
        '
        Me.FULL_AutorizantesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FULL_AutorizantesBindingNavigator.BindingSource = Me.FULL_AutorizantesBindingSource
        Me.FULL_AutorizantesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FULL_AutorizantesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FULL_AutorizantesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FULL_AutorizantesBindingNavigatorSaveItem})
        Me.FULL_AutorizantesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FULL_AutorizantesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FULL_AutorizantesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FULL_AutorizantesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FULL_AutorizantesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FULL_AutorizantesBindingNavigator.Name = "FULL_AutorizantesBindingNavigator"
        Me.FULL_AutorizantesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FULL_AutorizantesBindingNavigator.Size = New System.Drawing.Size(503, 25)
        Me.FULL_AutorizantesBindingNavigator.TabIndex = 0
        Me.FULL_AutorizantesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'FULL_AutorizantesBindingNavigatorSaveItem
        '
        Me.FULL_AutorizantesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FULL_AutorizantesBindingNavigatorSaveItem.Image = CType(resources.GetObject("FULL_AutorizantesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FULL_AutorizantesBindingNavigatorSaveItem.Name = "FULL_AutorizantesBindingNavigatorSaveItem"
        Me.FULL_AutorizantesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FULL_AutorizantesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FULL_AutorizantesBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(66, 37)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(393, 20)
        Me.NombreTextBox.TabIndex = 2
        '
        'MailTextBox
        '
        Me.MailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FULL_AutorizantesBindingSource, "mail", True))
        Me.MailTextBox.Location = New System.Drawing.Point(66, 63)
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.Size = New System.Drawing.Size(393, 20)
        Me.MailTextBox.TabIndex = 4
        '
        'cmbCliente
        '
        Me.cmbCliente.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FULL_AutorizantesBindingSource, "clienteFinagil", True))
        Me.cmbCliente.DataSource = Me.VwFullDatosServicioCXPClientesBindingSource
        Me.cmbCliente.DisplayMember = "Descr"
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(66, 89)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(419, 21)
        Me.cmbCliente.TabIndex = 5
        Me.cmbCliente.ValueMember = "Cliente"
        '
        'VwFullDatosServicioCXPClientesBindingSource
        '
        Me.VwFullDatosServicioCXPClientesBindingSource.DataMember = "Vw_Full_DatosServicioCXP_Clientes"
        Me.VwFullDatosServicioCXPClientesBindingSource.DataSource = Me.ProductionDataSet
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FULL_AutorizantesBindingSource, "sucursal", True))
        Me.cmbSucursal.DataSource = Me.VwFullDatosServicioCXPSucursalBindingSource
        Me.cmbSucursal.DisplayMember = "LugarEntrega"
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(66, 116)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(248, 21)
        Me.cmbSucursal.TabIndex = 6
        Me.cmbSucursal.ValueMember = "LugarEntrega"
        '
        'VwFullDatosServicioCXPSucursalBindingSource
        '
        Me.VwFullDatosServicioCXPSucursalBindingSource.DataMember = "Vw_Full_DatosServicioCXP_Sucursal"
        Me.VwFullDatosServicioCXPSucursalBindingSource.DataSource = Me.ProductionDataSet
        '
        'VwFullDatosServicioCXPAnexosBindingSource
        '
        Me.VwFullDatosServicioCXPAnexosBindingSource.DataMember = "Vw_Full_DatosServicioCXP_Anexos"
        Me.VwFullDatosServicioCXPAnexosBindingSource.DataSource = Me.ProductionDataSet
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(410, 173)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Sucursal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Contrato:"
        '
        'Vw_Full_DatosServicioCXP_ClientesTableAdapter
        '
        Me.Vw_Full_DatosServicioCXP_ClientesTableAdapter.ClearBeforeFill = True
        '
        'Vw_Full_DatosServicioCXP_SucursalTableAdapter
        '
        Me.Vw_Full_DatosServicioCXP_SucursalTableAdapter.ClearBeforeFill = True
        '
        'Vw_Full_DatosServicioCXP_AnexosTableAdapter
        '
        Me.Vw_Full_DatosServicioCXP_AnexosTableAdapter.ClearBeforeFill = True
        '
        'cmbAnexo
        '
        Me.cmbAnexo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FULL_AutorizantesBindingSource, "contrato", True))
        Me.cmbAnexo.DataSource = Me.VwFullDatosServicioCXPAnexosBindingSource
        Me.cmbAnexo.DisplayMember = "Anexo"
        Me.cmbAnexo.FormattingEnabled = True
        Me.cmbAnexo.Location = New System.Drawing.Point(66, 143)
        Me.cmbAnexo.Name = "cmbAnexo"
        Me.cmbAnexo.Size = New System.Drawing.Size(248, 21)
        Me.cmbAnexo.TabIndex = 12
        Me.cmbAnexo.ValueMember = "Anexo"
        '
        'ContratoTextBox
        '
        Me.ContratoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FULL_AutorizantesBindingSource, "contrato", True))
        Me.ContratoTextBox.Location = New System.Drawing.Point(320, 144)
        Me.ContratoTextBox.Name = "ContratoTextBox"
        Me.ContratoTextBox.ReadOnly = True
        Me.ContratoTextBox.Size = New System.Drawing.Size(165, 20)
        Me.ContratoTextBox.TabIndex = 13
        '
        'SucursalTextBox
        '
        Me.SucursalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FULL_AutorizantesBindingSource, "sucursal", True))
        Me.SucursalTextBox.Location = New System.Drawing.Point(320, 117)
        Me.SucursalTextBox.Name = "SucursalTextBox"
        Me.SucursalTextBox.ReadOnly = True
        Me.SucursalTextBox.Size = New System.Drawing.Size(165, 20)
        Me.SucursalTextBox.TabIndex = 15
        '
        'frmAutorizadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 208)
        Me.Controls.Add(Me.SucursalTextBox)
        Me.Controls.Add(Me.ContratoTextBox)
        Me.Controls.Add(Me.cmbAnexo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(MailLabel)
        Me.Controls.Add(Me.MailTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.FULL_AutorizantesBindingNavigator)
        Me.Name = "frmAutorizadores"
        Me.Text = "Autorizadores"
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULL_AutorizantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULL_AutorizantesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FULL_AutorizantesBindingNavigator.ResumeLayout(False)
        Me.FULL_AutorizantesBindingNavigator.PerformLayout()
        CType(Me.VwFullDatosServicioCXPClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwFullDatosServicioCXPSucursalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwFullDatosServicioCXPAnexosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductionDataSet As ProductionDataSet
    Friend WithEvents FULL_AutorizantesBindingSource As BindingSource
    Friend WithEvents FULL_AutorizantesTableAdapter As ProductionDataSetTableAdapters.FULL_AutorizantesTableAdapter
    Friend WithEvents TableAdapterManager As ProductionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FULL_AutorizantesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents FULL_AutorizantesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents MailTextBox As TextBox
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents cmbSucursal As ComboBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents VwFullDatosServicioCXPClientesBindingSource As BindingSource
    Friend WithEvents Vw_Full_DatosServicioCXP_ClientesTableAdapter As ProductionDataSetTableAdapters.Vw_Full_DatosServicioCXP_ClientesTableAdapter
    Friend WithEvents VwFullDatosServicioCXPSucursalBindingSource As BindingSource
    Friend WithEvents VwFullDatosServicioCXPAnexosBindingSource As BindingSource
    Friend WithEvents Vw_Full_DatosServicioCXP_SucursalTableAdapter As ProductionDataSetTableAdapters.Vw_Full_DatosServicioCXP_SucursalTableAdapter
    Friend WithEvents Vw_Full_DatosServicioCXP_AnexosTableAdapter As ProductionDataSetTableAdapters.Vw_Full_DatosServicioCXP_AnexosTableAdapter
    Friend WithEvents cmbAnexo As ComboBox
    Friend WithEvents ContratoTextBox As TextBox
    Friend WithEvents SucursalTextBox As TextBox
End Class
