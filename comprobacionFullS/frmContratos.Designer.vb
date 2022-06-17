<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmContratos
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
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        Me.VwFullDatosServicioCXPClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionDataSet = New comprobacionFullS.ProductionDataSet()
        Me.cmbContratos = New System.Windows.Forms.ComboBox()
        Me.VwFullDatosServicioCXPAnexosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.VwFullDatosServicioCXPSucursalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.FULL_ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FULL_ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Vw_Full_DatosServicioCXP_ClientesTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.Vw_Full_DatosServicioCXP_ClientesTableAdapter()
        Me.Vw_Full_DatosServicioCXP_SucursalTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.Vw_Full_DatosServicioCXP_SucursalTableAdapter()
        Me.Vw_Full_DatosServicioCXP_AnexosTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.Vw_Full_DatosServicioCXP_AnexosTableAdapter()
        Me.FULL_ClientesTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.FULL_ClientesTableAdapter()
        Me.TableAdapterManager = New comprobacionFullS.ProductionDataSetTableAdapters.TableAdapterManager()
        CType(Me.VwFullDatosServicioCXPClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwFullDatosServicioCXPAnexosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwFullDatosServicioCXPSucursalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULL_ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULL_ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbClientes
        '
        Me.cmbClientes.DataSource = Me.VwFullDatosServicioCXPClientesBindingSource
        Me.cmbClientes.DisplayMember = "Descr"
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Location = New System.Drawing.Point(60, 11)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(675, 21)
        Me.cmbClientes.TabIndex = 0
        Me.cmbClientes.ValueMember = "Cliente"
        '
        'VwFullDatosServicioCXPClientesBindingSource
        '
        Me.VwFullDatosServicioCXPClientesBindingSource.DataMember = "Vw_Full_DatosServicioCXP_Clientes"
        Me.VwFullDatosServicioCXPClientesBindingSource.DataSource = Me.ProductionDataSet
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbContratos
        '
        Me.cmbContratos.DataSource = Me.VwFullDatosServicioCXPAnexosBindingSource
        Me.cmbContratos.DisplayMember = "Anexo"
        Me.cmbContratos.Enabled = False
        Me.cmbContratos.FormattingEnabled = True
        Me.cmbContratos.Location = New System.Drawing.Point(362, 46)
        Me.cmbContratos.Name = "cmbContratos"
        Me.cmbContratos.Size = New System.Drawing.Size(196, 21)
        Me.cmbContratos.TabIndex = 2
        Me.cmbContratos.ValueMember = "Cliente"
        '
        'VwFullDatosServicioCXPAnexosBindingSource
        '
        Me.VwFullDatosServicioCXPAnexosBindingSource.DataMember = "Vw_Full_DatosServicioCXP_Anexos"
        Me.VwFullDatosServicioCXPAnexosBindingSource.DataSource = Me.ProductionDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(306, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contrato:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sucursal:"
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DataSource = Me.VwFullDatosServicioCXPSucursalBindingSource
        Me.cmbSucursal.DisplayMember = "LugarEntrega"
        Me.cmbSucursal.Enabled = False
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(60, 46)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(238, 21)
        Me.cmbSucursal.TabIndex = 1
        Me.cmbSucursal.ValueMember = "Cliente"
        '
        'VwFullDatosServicioCXPSucursalBindingSource
        '
        Me.VwFullDatosServicioCXPSucursalBindingSource.DataMember = "Vw_Full_DatosServicioCXP_Sucursal"
        Me.VwFullDatosServicioCXPSucursalBindingSource.DataSource = Me.ProductionDataSet
        '
        'btnAgregar
        '
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.Location = New System.Drawing.Point(573, 46)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'FULL_ClientesDataGridView
        '
        Me.FULL_ClientesDataGridView.AllowUserToAddRows = False
        Me.FULL_ClientesDataGridView.AllowUserToDeleteRows = False
        Me.FULL_ClientesDataGridView.AutoGenerateColumns = False
        Me.FULL_ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FULL_ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.FULL_ClientesDataGridView.DataSource = Me.FULL_ClientesBindingSource
        Me.FULL_ClientesDataGridView.Location = New System.Drawing.Point(12, 88)
        Me.FULL_ClientesDataGridView.Name = "FULL_ClientesDataGridView"
        Me.FULL_ClientesDataGridView.ReadOnly = True
        Me.FULL_ClientesDataGridView.Size = New System.Drawing.Size(1023, 236)
        Me.FULL_ClientesDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idCliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idCliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.Width = 69
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "contrato"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Contrato"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 72
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "rfc"
        Me.DataGridViewTextBoxColumn3.HeaderText = "RFC"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 53
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "clienteFinagil"
        Me.DataGridViewTextBoxColumn4.HeaderText = "# Cliente"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 74
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "sucursal"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Sucursal"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 73
        '
        'FULL_ClientesBindingSource
        '
        Me.FULL_ClientesBindingSource.DataMember = "FULL_Clientes"
        Me.FULL_ClientesBindingSource.DataSource = Me.ProductionDataSet
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(960, 330)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(660, 46)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
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
        'FULL_ClientesTableAdapter
        '
        Me.FULL_ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FULL_AutorizantesTableAdapter = Nothing
        Me.TableAdapterManager.FULL_ClientesTableAdapter = Me.FULL_ClientesTableAdapter
        Me.TableAdapterManager.FULL_UsuarioClienteTableAdapter = Nothing
        Me.TableAdapterManager.FULL_UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = comprobacionFullS.ProductionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmContratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 365)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.FULL_ClientesDataGridView)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbContratos)
        Me.Controls.Add(Me.cmbClientes)
        Me.Name = "frmContratos"
        Me.Text = "Contratos - Clientes"
        CType(Me.VwFullDatosServicioCXPClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwFullDatosServicioCXPAnexosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwFullDatosServicioCXPSucursalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULL_ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULL_ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbClientes As ComboBox
    Friend WithEvents cmbContratos As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbSucursal As ComboBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents ProductionDataSet As ProductionDataSet
    Friend WithEvents VwFullDatosServicioCXPClientesBindingSource As BindingSource
    Friend WithEvents Vw_Full_DatosServicioCXP_ClientesTableAdapter As ProductionDataSetTableAdapters.Vw_Full_DatosServicioCXP_ClientesTableAdapter
    Friend WithEvents VwFullDatosServicioCXPSucursalBindingSource As BindingSource
    Friend WithEvents Vw_Full_DatosServicioCXP_SucursalTableAdapter As ProductionDataSetTableAdapters.Vw_Full_DatosServicioCXP_SucursalTableAdapter
    Friend WithEvents VwFullDatosServicioCXPAnexosBindingSource As BindingSource
    Friend WithEvents Vw_Full_DatosServicioCXP_AnexosTableAdapter As ProductionDataSetTableAdapters.Vw_Full_DatosServicioCXP_AnexosTableAdapter
    Friend WithEvents FULL_ClientesBindingSource As BindingSource
    Friend WithEvents FULL_ClientesTableAdapter As ProductionDataSetTableAdapters.FULL_ClientesTableAdapter
    Friend WithEvents TableAdapterManager As ProductionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FULL_ClientesDataGridView As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewLinkColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
