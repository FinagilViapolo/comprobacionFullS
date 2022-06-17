<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAltaDeUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NombreLabel As System.Windows.Forms.Label
        Dim MailLabel As System.Windows.Forms.Label
        Dim EstatusLabel As System.Windows.Forms.Label
        Dim IdUsuarioLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAltaDeUsuarios))
        Me.ProductionDataSet = New comprobacionFullS.ProductionDataSet()
        Me.FULL_UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FULL_UsuariosTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.FULL_UsuariosTableAdapter()
        Me.TableAdapterManager = New comprobacionFullS.ProductionDataSetTableAdapters.TableAdapterManager()
        Me.FULL_UsuariosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FULL_UsuariosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.MailTextBox = New System.Windows.Forms.TextBox()
        Me.cmbRazonSocial = New System.Windows.Forms.ComboBox()
        Me.VwFullDatosServicioCXPClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.VwFullDatosServicioCXPSucursalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbAnexo = New System.Windows.Forms.ComboBox()
        Me.VwFullDatosServicioCXPAnexosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_Full_DatosServicioCXP_ClientesTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.Vw_Full_DatosServicioCXP_ClientesTableAdapter()
        Me.Vw_Full_DatosServicioCXP_SucursalTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.Vw_Full_DatosServicioCXP_SucursalTableAdapter()
        Me.Vw_Full_DatosServicioCXP_AnexosTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.Vw_Full_DatosServicioCXP_AnexosTableAdapter()
        Me.cmbEstatus = New System.Windows.Forms.ComboBox()
        Me.FULLEstatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.FULL_EstatusTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.FULL_EstatusTableAdapter()
        Me.btnReestablecerContr = New System.Windows.Forms.Button()
        Me.IdUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.btnTarjetas = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FULL_ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FULL_ClientesTableAdapter1 = New comprobacionFullS.ProductionDataSetTableAdapters.FULL_ClientesTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        NombreLabel = New System.Windows.Forms.Label()
        MailLabel = New System.Windows.Forms.Label()
        EstatusLabel = New System.Windows.Forms.Label()
        IdUsuarioLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULL_UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULL_UsuariosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FULL_UsuariosBindingNavigator.SuspendLayout()
        CType(Me.VwFullDatosServicioCXPClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwFullDatosServicioCXPSucursalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwFullDatosServicioCXPAnexosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULLEstatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FULL_ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(57, 42)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 1
        NombreLabel.Text = "Nombre:"
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(75, 183)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(29, 13)
        MailLabel.TabIndex = 5
        MailLabel.Text = "Mail:"
        '
        'EstatusLabel
        '
        EstatusLabel.AutoSize = True
        EstatusLabel.Location = New System.Drawing.Point(59, 209)
        EstatusLabel.Name = "EstatusLabel"
        EstatusLabel.Size = New System.Drawing.Size(45, 13)
        EstatusLabel.TabIndex = 7
        EstatusLabel.Text = "Estatus:"
        '
        'IdUsuarioLabel
        '
        IdUsuarioLabel.AutoSize = True
        IdUsuarioLabel.Location = New System.Drawing.Point(47, 236)
        IdUsuarioLabel.Name = "IdUsuarioLabel"
        IdUsuarioLabel.Size = New System.Drawing.Size(56, 13)
        IdUsuarioLabel.TabIndex = 15
        IdUsuarioLabel.Text = "Id usuario:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(16, 157)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(88, 13)
        DescripcionLabel.TabIndex = 18
        DescripcionLabel.Text = "Cliente asignado:"
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FULL_UsuariosBindingSource
        '
        Me.FULL_UsuariosBindingSource.DataMember = "FULL_Usuarios"
        Me.FULL_UsuariosBindingSource.DataSource = Me.ProductionDataSet
        '
        'FULL_UsuariosTableAdapter
        '
        Me.FULL_UsuariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FULL_AutorizantesTableAdapter = Nothing
        Me.TableAdapterManager.FULL_ClientesTableAdapter = Nothing
        Me.TableAdapterManager.FULL_EstatusTableAdapter = Nothing
        Me.TableAdapterManager.FULL_ProveedorTarjetaTableAdapter = Nothing
        Me.TableAdapterManager.FULL_ServiciosTableAdapter = Nothing
        Me.TableAdapterManager.FULL_TarjetasConceptosTableAdapter = Nothing
        Me.TableAdapterManager.FULL_TarjetasTableAdapter = Nothing
        Me.TableAdapterManager.FULL_TipoTarjetaTableAdapter = Nothing
        Me.TableAdapterManager.FULL_UsuarioClienteTableAdapter = Nothing
        Me.TableAdapterManager.FULL_UsuariosTableAdapter = Me.FULL_UsuariosTableAdapter
        Me.TableAdapterManager.GEN_Correos_SistemaFinagilTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = comprobacionFullS.ProductionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FULL_UsuariosBindingNavigator
        '
        Me.FULL_UsuariosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FULL_UsuariosBindingNavigator.BindingSource = Me.FULL_UsuariosBindingSource
        Me.FULL_UsuariosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FULL_UsuariosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FULL_UsuariosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FULL_UsuariosBindingNavigatorSaveItem})
        Me.FULL_UsuariosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FULL_UsuariosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FULL_UsuariosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FULL_UsuariosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FULL_UsuariosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FULL_UsuariosBindingNavigator.Name = "FULL_UsuariosBindingNavigator"
        Me.FULL_UsuariosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FULL_UsuariosBindingNavigator.Size = New System.Drawing.Size(852, 25)
        Me.FULL_UsuariosBindingNavigator.TabIndex = 0
        Me.FULL_UsuariosBindingNavigator.Text = "BindingNavigator1"
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
        'FULL_UsuariosBindingNavigatorSaveItem
        '
        Me.FULL_UsuariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FULL_UsuariosBindingNavigatorSaveItem.Image = CType(resources.GetObject("FULL_UsuariosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FULL_UsuariosBindingNavigatorSaveItem.Name = "FULL_UsuariosBindingNavigatorSaveItem"
        Me.FULL_UsuariosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FULL_UsuariosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FULL_UsuariosBindingSource, "nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NombreTextBox.Location = New System.Drawing.Point(110, 39)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(326, 20)
        Me.NombreTextBox.TabIndex = 2
        '
        'MailTextBox
        '
        Me.MailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FULL_UsuariosBindingSource, "mail", True))
        Me.MailTextBox.Location = New System.Drawing.Point(110, 180)
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.Size = New System.Drawing.Size(326, 20)
        Me.MailTextBox.TabIndex = 6
        '
        'cmbRazonSocial
        '
        Me.cmbRazonSocial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbRazonSocial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRazonSocial.DataSource = Me.VwFullDatosServicioCXPClientesBindingSource
        Me.cmbRazonSocial.DisplayMember = "Descr"
        Me.cmbRazonSocial.FormattingEnabled = True
        Me.cmbRazonSocial.Location = New System.Drawing.Point(16, 19)
        Me.cmbRazonSocial.Name = "cmbRazonSocial"
        Me.cmbRazonSocial.Size = New System.Drawing.Size(326, 21)
        Me.cmbRazonSocial.TabIndex = 9
        Me.cmbRazonSocial.ValueMember = "Cliente"
        '
        'VwFullDatosServicioCXPClientesBindingSource
        '
        Me.VwFullDatosServicioCXPClientesBindingSource.DataMember = "Vw_Full_DatosServicioCXP_Clientes"
        Me.VwFullDatosServicioCXPClientesBindingSource.DataSource = Me.ProductionDataSet
        '
        'cmbSucursal
        '
        Me.cmbSucursal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbSucursal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSucursal.DataSource = Me.VwFullDatosServicioCXPSucursalBindingSource
        Me.cmbSucursal.DisplayMember = "LugarEntrega"
        Me.cmbSucursal.Enabled = False
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(349, 19)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(213, 21)
        Me.cmbSucursal.TabIndex = 10
        Me.cmbSucursal.ValueMember = "Cliente"
        '
        'VwFullDatosServicioCXPSucursalBindingSource
        '
        Me.VwFullDatosServicioCXPSucursalBindingSource.DataMember = "Vw_Full_DatosServicioCXP_Sucursal"
        Me.VwFullDatosServicioCXPSucursalBindingSource.DataSource = Me.ProductionDataSet
        '
        'cmbAnexo
        '
        Me.cmbAnexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAnexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAnexo.DataSource = Me.VwFullDatosServicioCXPAnexosBindingSource
        Me.cmbAnexo.DisplayMember = "Anexo"
        Me.cmbAnexo.Enabled = False
        Me.cmbAnexo.FormattingEnabled = True
        Me.cmbAnexo.Location = New System.Drawing.Point(568, 19)
        Me.cmbAnexo.Name = "cmbAnexo"
        Me.cmbAnexo.Size = New System.Drawing.Size(121, 21)
        Me.cmbAnexo.TabIndex = 11
        Me.cmbAnexo.ValueMember = "Cliente"
        '
        'VwFullDatosServicioCXPAnexosBindingSource
        '
        Me.VwFullDatosServicioCXPAnexosBindingSource.DataMember = "Vw_Full_DatosServicioCXP_Anexos"
        Me.VwFullDatosServicioCXPAnexosBindingSource.DataSource = Me.ProductionDataSet
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
        'cmbEstatus
        '
        Me.cmbEstatus.DataSource = Me.FULLEstatusBindingSource
        Me.cmbEstatus.DisplayMember = "descripcion"
        Me.cmbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstatus.FormattingEnabled = True
        Me.cmbEstatus.Location = New System.Drawing.Point(110, 206)
        Me.cmbEstatus.Name = "cmbEstatus"
        Me.cmbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.cmbEstatus.TabIndex = 13
        Me.cmbEstatus.ValueMember = "idEstatus"
        '
        'FULLEstatusBindingSource
        '
        Me.FULLEstatusBindingSource.DataMember = "FULL_Estatus"
        Me.FULLEstatusBindingSource.DataSource = Me.ProductionDataSet
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(709, 268)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'FULL_EstatusTableAdapter
        '
        Me.FULL_EstatusTableAdapter.ClearBeforeFill = True
        '
        'btnReestablecerContr
        '
        Me.btnReestablecerContr.Location = New System.Drawing.Point(110, 268)
        Me.btnReestablecerContr.Name = "btnReestablecerContr"
        Me.btnReestablecerContr.Size = New System.Drawing.Size(142, 23)
        Me.btnReestablecerContr.TabIndex = 15
        Me.btnReestablecerContr.Text = "Reestablecer contraseña"
        Me.btnReestablecerContr.UseVisualStyleBackColor = True
        '
        'IdUsuarioTextBox
        '
        Me.IdUsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FULL_UsuariosBindingSource, "idUsuario", True))
        Me.IdUsuarioTextBox.Location = New System.Drawing.Point(110, 233)
        Me.IdUsuarioTextBox.Name = "IdUsuarioTextBox"
        Me.IdUsuarioTextBox.ReadOnly = True
        Me.IdUsuarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdUsuarioTextBox.TabIndex = 16
        '
        'btnTarjetas
        '
        Me.btnTarjetas.Location = New System.Drawing.Point(663, 226)
        Me.btnTarjetas.Name = "btnTarjetas"
        Me.btnTarjetas.Size = New System.Drawing.Size(121, 23)
        Me.btnTarjetas.TabIndex = 17
        Me.btnTarjetas.Text = "Tarjetas"
        Me.btnTarjetas.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbAnexo)
        Me.GroupBox1.Controls.Add(Me.cmbSucursal)
        Me.GroupBox1.Controls.Add(Me.cmbRazonSocial)
        Me.GroupBox1.Location = New System.Drawing.Point(110, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(695, 55)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por datos del cliente:"
        '
        'FULL_ClientesBindingSource
        '
        Me.FULL_ClientesBindingSource.DataMember = "FULL_Clientes"
        Me.FULL_ClientesBindingSource.DataSource = Me.ProductionDataSet
        '
        'FULL_ClientesTableAdapter1
        '
        Me.FULL_ClientesTableAdapter1.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FULL_UsuariosBindingSource, "idEmpresa", True))
        Me.ComboBox1.DataSource = Me.FULL_ClientesBindingSource
        Me.ComboBox1.DisplayMember = "descripcion"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(110, 154)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(694, 21)
        Me.ComboBox1.TabIndex = 19
        Me.ComboBox1.ValueMember = "idCliente"
        '
        'frmAltaDeUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 344)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnTarjetas)
        Me.Controls.Add(IdUsuarioLabel)
        Me.Controls.Add(Me.IdUsuarioTextBox)
        Me.Controls.Add(Me.btnReestablecerContr)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.cmbEstatus)
        Me.Controls.Add(EstatusLabel)
        Me.Controls.Add(MailLabel)
        Me.Controls.Add(Me.MailTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.FULL_UsuariosBindingNavigator)
        Me.Name = "frmAltaDeUsuarios"
        Me.Text = "Alta de usuarios"
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULL_UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULL_UsuariosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FULL_UsuariosBindingNavigator.ResumeLayout(False)
        Me.FULL_UsuariosBindingNavigator.PerformLayout()
        CType(Me.VwFullDatosServicioCXPClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwFullDatosServicioCXPSucursalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwFullDatosServicioCXPAnexosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULLEstatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.FULL_ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductionDataSet As ProductionDataSet
    Friend WithEvents FULL_UsuariosBindingSource As BindingSource
    Friend WithEvents FULL_UsuariosTableAdapter As ProductionDataSetTableAdapters.FULL_UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As ProductionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FULL_UsuariosBindingNavigator As BindingNavigator
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
    Friend WithEvents FULL_UsuariosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents MailTextBox As TextBox
    Friend WithEvents cmbRazonSocial As ComboBox
    Friend WithEvents cmbSucursal As ComboBox
    Friend WithEvents cmbAnexo As ComboBox
    Friend WithEvents VwFullDatosServicioCXPClientesBindingSource As BindingSource
    Friend WithEvents Vw_Full_DatosServicioCXP_ClientesTableAdapter As ProductionDataSetTableAdapters.Vw_Full_DatosServicioCXP_ClientesTableAdapter
    Friend WithEvents VwFullDatosServicioCXPSucursalBindingSource As BindingSource
    Friend WithEvents VwFullDatosServicioCXPAnexosBindingSource As BindingSource
    Friend WithEvents Vw_Full_DatosServicioCXP_SucursalTableAdapter As ProductionDataSetTableAdapters.Vw_Full_DatosServicioCXP_SucursalTableAdapter
    Friend WithEvents Vw_Full_DatosServicioCXP_AnexosTableAdapter As ProductionDataSetTableAdapters.Vw_Full_DatosServicioCXP_AnexosTableAdapter
    Friend WithEvents cmbEstatus As ComboBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents FULLEstatusBindingSource As BindingSource
    Friend WithEvents FULL_EstatusTableAdapter As ProductionDataSetTableAdapters.FULL_EstatusTableAdapter
    Friend WithEvents btnReestablecerContr As Button
    Friend WithEvents IdUsuarioTextBox As TextBox
    Friend WithEvents btnTarjetas As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FULL_ClientesBindingSource As BindingSource
    Friend WithEvents FULL_ClientesTableAdapter1 As ProductionDataSetTableAdapters.FULL_ClientesTableAdapter
    Friend WithEvents ComboBox1 As ComboBox
End Class
