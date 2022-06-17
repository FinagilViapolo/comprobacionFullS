<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarjetas
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
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim IdTarjetaLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTarjetas))
        Me.ProductionDataSet = New comprobacionFullS.ProductionDataSet()
        Me.FULL_TarjetasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FULL_TarjetasTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.FULL_TarjetasTableAdapter()
        Me.TableAdapterManager = New comprobacionFullS.ProductionDataSetTableAdapters.TableAdapterManager()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.cmbEstatus = New System.Windows.Forms.ComboBox()
        Me.FULLEstatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.FULLProveedorTarjetaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbTipoTarjeta = New System.Windows.Forms.ComboBox()
        Me.FULLTipoTarjetaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.FULL_EstatusTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.FULL_EstatusTableAdapter()
        Me.FULL_ProveedorTarjetaTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.FULL_ProveedorTarjetaTableAdapter()
        Me.FULL_TipoTarjetaTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.FULL_TipoTarjetaTableAdapter()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.FULLClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FULL_ClientesTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.FULL_ClientesTableAdapter()
        Me.FULLServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FULL_ServiciosTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.FULL_ServiciosTableAdapter()
        Me.FULL_TarjetasConceptosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FULL_TarjetasConceptosTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.FULL_TarjetasConceptosTableAdapter()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.FULL_TarjetasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FULL_TarjetasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.IdTarjetaTextBox = New System.Windows.Forms.TextBox()
        Me.FULL_TarjetasConceptosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        DescripcionLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        IdTarjetaLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULL_TarjetasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULLEstatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULLProveedorTarjetaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULLTipoTarjetaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULLClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULLServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULL_TarjetasConceptosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULL_TarjetasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FULL_TarjetasBindingNavigator.SuspendLayout()
        CType(Me.FULL_TarjetasConceptosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(19, 43)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 1
        DescripcionLabel.Text = "Descripción:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(40, 69)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(45, 13)
        Label1.TabIndex = 8
        Label1.Text = "Estatus:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(14, 96)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(71, 13)
        Label2.TabIndex = 9
        Label2.Text = "No de tarjeta:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(26, 123)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(59, 13)
        Label3.TabIndex = 10
        Label3.Text = "Proveedor:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(19, 150)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(68, 13)
        Label4.TabIndex = 11
        Label4.Text = "Tipo de disp:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(40, 177)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(42, 13)
        Label5.TabIndex = 16
        Label5.Text = "Cliente:"
        '
        'IdTarjetaLabel
        '
        IdTarjetaLabel.AutoSize = True
        IdTarjetaLabel.Location = New System.Drawing.Point(254, 70)
        IdTarjetaLabel.Name = "IdTarjetaLabel"
        IdTarjetaLabel.Size = New System.Drawing.Size(54, 13)
        IdTarjetaLabel.TabIndex = 16
        IdTarjetaLabel.Text = "id Tarjeta:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(26, 201)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(61, 13)
        Label6.TabIndex = 18
        Label6.Text = "Conceptos:"
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FULL_TarjetasBindingSource
        '
        Me.FULL_TarjetasBindingSource.DataMember = "FULL_Tarjetas"
        Me.FULL_TarjetasBindingSource.DataSource = Me.ProductionDataSet
        '
        'FULL_TarjetasTableAdapter
        '
        Me.FULL_TarjetasTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.FULL_TarjetasTableAdapter = Me.FULL_TarjetasTableAdapter
        Me.TableAdapterManager.FULL_TipoTarjetaTableAdapter = Nothing
        Me.TableAdapterManager.FULL_UsuarioClienteTableAdapter = Nothing
        Me.TableAdapterManager.FULL_UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.GEN_Correos_SistemaFinagilTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = comprobacionFullS.ProductionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FULL_TarjetasBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(91, 40)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(561, 20)
        Me.DescripcionTextBox.TabIndex = 2
        '
        'cmbEstatus
        '
        Me.cmbEstatus.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FULL_TarjetasBindingSource, "idEstatus", True))
        Me.cmbEstatus.DataSource = Me.FULLEstatusBindingSource
        Me.cmbEstatus.DisplayMember = "descripcion"
        Me.cmbEstatus.FormattingEnabled = True
        Me.cmbEstatus.Location = New System.Drawing.Point(91, 66)
        Me.cmbEstatus.Name = "cmbEstatus"
        Me.cmbEstatus.Size = New System.Drawing.Size(143, 21)
        Me.cmbEstatus.TabIndex = 3
        Me.cmbEstatus.ValueMember = "idEstatus"
        '
        'FULLEstatusBindingSource
        '
        Me.FULLEstatusBindingSource.DataMember = "FULL_Estatus"
        Me.FULLEstatusBindingSource.DataSource = Me.ProductionDataSet
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FULL_TarjetasBindingSource, "noTarjeta", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(91, 93)
        Me.MaskedTextBox1.Mask = "####-####-####-####"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(270, 20)
        Me.MaskedTextBox1.TabIndex = 4
        '
        'cmbProveedor
        '
        Me.cmbProveedor.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FULL_TarjetasBindingSource, "idProveedor", True))
        Me.cmbProveedor.DataSource = Me.FULLProveedorTarjetaBindingSource
        Me.cmbProveedor.DisplayMember = "nombreProveedor"
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(91, 120)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(561, 21)
        Me.cmbProveedor.TabIndex = 5
        Me.cmbProveedor.ValueMember = "idProvtarjeta"
        '
        'FULLProveedorTarjetaBindingSource
        '
        Me.FULLProveedorTarjetaBindingSource.DataMember = "FULL_ProveedorTarjeta"
        Me.FULLProveedorTarjetaBindingSource.DataSource = Me.ProductionDataSet
        '
        'cmbTipoTarjeta
        '
        Me.cmbTipoTarjeta.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FULL_TarjetasBindingSource, "idTipoTarjeta", True))
        Me.cmbTipoTarjeta.DataSource = Me.FULLTipoTarjetaBindingSource
        Me.cmbTipoTarjeta.DisplayMember = "descripcion"
        Me.cmbTipoTarjeta.FormattingEnabled = True
        Me.cmbTipoTarjeta.Location = New System.Drawing.Point(91, 147)
        Me.cmbTipoTarjeta.Name = "cmbTipoTarjeta"
        Me.cmbTipoTarjeta.Size = New System.Drawing.Size(561, 21)
        Me.cmbTipoTarjeta.TabIndex = 6
        Me.cmbTipoTarjeta.ValueMember = "idTipoTarjeta"
        '
        'FULLTipoTarjetaBindingSource
        '
        Me.FULLTipoTarjetaBindingSource.DataMember = "FULL_TipoTarjeta"
        Me.FULLTipoTarjetaBindingSource.DataSource = Me.ProductionDataSet
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(577, 350)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'FULL_EstatusTableAdapter
        '
        Me.FULL_EstatusTableAdapter.ClearBeforeFill = True
        '
        'FULL_ProveedorTarjetaTableAdapter
        '
        Me.FULL_ProveedorTarjetaTableAdapter.ClearBeforeFill = True
        '
        'FULL_TipoTarjetaTableAdapter
        '
        Me.FULL_TipoTarjetaTableAdapter.ClearBeforeFill = True
        '
        'cmbCliente
        '
        Me.cmbCliente.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FULL_TarjetasBindingSource, "idcliente", True))
        Me.cmbCliente.DataSource = Me.FULLClientesBindingSource
        Me.cmbCliente.DisplayMember = "descripcion"
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(91, 174)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(561, 21)
        Me.cmbCliente.TabIndex = 12
        Me.cmbCliente.ValueMember = "idCliente"
        '
        'FULLClientesBindingSource
        '
        Me.FULLClientesBindingSource.DataMember = "FULL_Clientes"
        Me.FULLClientesBindingSource.DataSource = Me.ProductionDataSet
        '
        'FULL_ClientesTableAdapter
        '
        Me.FULL_ClientesTableAdapter.ClearBeforeFill = True
        '
        'FULLServiciosBindingSource
        '
        Me.FULLServiciosBindingSource.DataMember = "FULL_Servicios"
        Me.FULLServiciosBindingSource.DataSource = Me.ProductionDataSet
        '
        'FULL_ServiciosTableAdapter
        '
        Me.FULL_ServiciosTableAdapter.ClearBeforeFill = True
        '
        'FULL_TarjetasConceptosBindingSource
        '
        Me.FULL_TarjetasConceptosBindingSource.DataMember = "FULL_TarjetasConceptos"
        Me.FULL_TarjetasConceptosBindingSource.DataSource = Me.ProductionDataSet
        '
        'FULL_TarjetasConceptosTableAdapter
        '
        Me.FULL_TarjetasConceptosTableAdapter.ClearBeforeFill = True
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
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
        'FULL_TarjetasBindingNavigatorSaveItem
        '
        Me.FULL_TarjetasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FULL_TarjetasBindingNavigatorSaveItem.Image = CType(resources.GetObject("FULL_TarjetasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FULL_TarjetasBindingNavigatorSaveItem.Name = "FULL_TarjetasBindingNavigatorSaveItem"
        Me.FULL_TarjetasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FULL_TarjetasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'FULL_TarjetasBindingNavigator
        '
        Me.FULL_TarjetasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FULL_TarjetasBindingNavigator.BindingSource = Me.FULL_TarjetasBindingSource
        Me.FULL_TarjetasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FULL_TarjetasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FULL_TarjetasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FULL_TarjetasBindingNavigatorSaveItem})
        Me.FULL_TarjetasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FULL_TarjetasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FULL_TarjetasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FULL_TarjetasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FULL_TarjetasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FULL_TarjetasBindingNavigator.Name = "FULL_TarjetasBindingNavigator"
        Me.FULL_TarjetasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FULL_TarjetasBindingNavigator.Size = New System.Drawing.Size(668, 25)
        Me.FULL_TarjetasBindingNavigator.TabIndex = 0
        Me.FULL_TarjetasBindingNavigator.Text = "BindingNavigator1"
        '
        'IdTarjetaTextBox
        '
        Me.IdTarjetaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FULL_TarjetasBindingSource, "idTarjeta", True))
        Me.IdTarjetaTextBox.Location = New System.Drawing.Point(314, 67)
        Me.IdTarjetaTextBox.Name = "IdTarjetaTextBox"
        Me.IdTarjetaTextBox.ReadOnly = True
        Me.IdTarjetaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTarjetaTextBox.TabIndex = 17
        '
        'FULL_TarjetasConceptosDataGridView
        '
        Me.FULL_TarjetasConceptosDataGridView.AutoGenerateColumns = False
        Me.FULL_TarjetasConceptosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FULL_TarjetasConceptosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.FULL_TarjetasConceptosDataGridView.DataSource = Me.FULL_TarjetasConceptosBindingSource
        Me.FULL_TarjetasConceptosDataGridView.Location = New System.Drawing.Point(91, 201)
        Me.FULL_TarjetasConceptosDataGridView.Name = "FULL_TarjetasConceptosDataGridView"
        Me.FULL_TarjetasConceptosDataGridView.Size = New System.Drawing.Size(561, 143)
        Me.FULL_TarjetasConceptosDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idTarjeta"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idTarjeta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idConcepto"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.FULLServiciosBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "Descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Concepto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "ID_Servicio"
        Me.DataGridViewTextBoxColumn2.Width = 350
        '
        'frmTarjetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 384)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.FULL_TarjetasConceptosDataGridView)
        Me.Controls.Add(IdTarjetaLabel)
        Me.Controls.Add(Me.IdTarjetaTextBox)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.cmbTipoTarjeta)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.cmbEstatus)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Me.FULL_TarjetasBindingNavigator)
        Me.Name = "frmTarjetas"
        Me.Text = "Alta de tarjetas"
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULL_TarjetasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULLEstatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULLProveedorTarjetaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULLTipoTarjetaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULLClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULLServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULL_TarjetasConceptosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULL_TarjetasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FULL_TarjetasBindingNavigator.ResumeLayout(False)
        Me.FULL_TarjetasBindingNavigator.PerformLayout()
        CType(Me.FULL_TarjetasConceptosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductionDataSet As ProductionDataSet
    Friend WithEvents FULL_TarjetasBindingSource As BindingSource
    Friend WithEvents FULL_TarjetasTableAdapter As ProductionDataSetTableAdapters.FULL_TarjetasTableAdapter
    Friend WithEvents TableAdapterManager As ProductionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents cmbEstatus As ComboBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents cmbProveedor As ComboBox
    Friend WithEvents cmbTipoTarjeta As ComboBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents FULLEstatusBindingSource As BindingSource
    Friend WithEvents FULL_EstatusTableAdapter As ProductionDataSetTableAdapters.FULL_EstatusTableAdapter
    Friend WithEvents FULLProveedorTarjetaBindingSource As BindingSource
    Friend WithEvents FULL_ProveedorTarjetaTableAdapter As ProductionDataSetTableAdapters.FULL_ProveedorTarjetaTableAdapter
    Friend WithEvents FULLTipoTarjetaBindingSource As BindingSource
    Friend WithEvents FULL_TipoTarjetaTableAdapter As ProductionDataSetTableAdapters.FULL_TipoTarjetaTableAdapter
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents FULLClientesBindingSource As BindingSource
    Friend WithEvents FULL_ClientesTableAdapter As ProductionDataSetTableAdapters.FULL_ClientesTableAdapter
    Friend WithEvents FULLServiciosBindingSource As BindingSource
    Friend WithEvents FULL_ServiciosTableAdapter As ProductionDataSetTableAdapters.FULL_ServiciosTableAdapter
    Friend WithEvents FULL_TarjetasConceptosBindingSource As BindingSource
    Friend WithEvents FULL_TarjetasConceptosTableAdapter As ProductionDataSetTableAdapters.FULL_TarjetasConceptosTableAdapter
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents FULL_TarjetasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FULL_TarjetasBindingNavigator As BindingNavigator
    Friend WithEvents IdTarjetaTextBox As TextBox
    Friend WithEvents FULL_TarjetasConceptosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewComboBoxColumn
End Class
