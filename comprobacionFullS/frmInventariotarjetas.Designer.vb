<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventariotarjetas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventariotarjetas))
        Me.ProductionDataSet = New comprobacionFullS.ProductionDataSet()
        Me.FULL_TarjetasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FULL_TarjetasTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.FULL_TarjetasTableAdapter()
        Me.TableAdapterManager = New comprobacionFullS.ProductionDataSetTableAdapters.TableAdapterManager()
        Me.FULL_EstatusTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.FULL_EstatusTableAdapter()
        Me.FULL_ProveedorTarjetaTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.FULL_ProveedorTarjetaTableAdapter()
        Me.FULL_TipoTarjetaTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.FULL_TipoTarjetaTableAdapter()
        Me.FULL_UsuariosTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.FULL_UsuariosTableAdapter()
        Me.FULL_TarjetasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FULL_TarjetasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FULL_TarjetasDataGridView = New System.Windows.Forms.DataGridView()
        Me.FULLEstatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FULLUsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FULLProveedorTarjetaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FULLTipoTarjetaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idEstatus = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.idUsuario = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.idProveedor = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.idTipoTarjeta = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULL_TarjetasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULL_TarjetasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FULL_TarjetasBindingNavigator.SuspendLayout()
        CType(Me.FULL_TarjetasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULLEstatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULLUsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULLProveedorTarjetaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULLTipoTarjetaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.FULL_EstatusTableAdapter = Me.FULL_EstatusTableAdapter
        Me.TableAdapterManager.FULL_ProveedorTarjetaTableAdapter = Me.FULL_ProveedorTarjetaTableAdapter
        Me.TableAdapterManager.FULL_TarjetasTableAdapter = Me.FULL_TarjetasTableAdapter
        Me.TableAdapterManager.FULL_TipoTarjetaTableAdapter = Me.FULL_TipoTarjetaTableAdapter
        Me.TableAdapterManager.FULL_UsuarioClienteTableAdapter = Nothing
        Me.TableAdapterManager.FULL_UsuariosTableAdapter = Me.FULL_UsuariosTableAdapter
        Me.TableAdapterManager.GEN_Correos_SistemaFinagilTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = comprobacionFullS.ProductionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'FULL_UsuariosTableAdapter
        '
        Me.FULL_UsuariosTableAdapter.ClearBeforeFill = True
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
        Me.FULL_TarjetasBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.FULL_TarjetasBindingNavigator.TabIndex = 0
        Me.FULL_TarjetasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Enabled = False
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
        Me.BindingNavigatorDeleteItem.Enabled = False
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
        'FULL_TarjetasBindingNavigatorSaveItem
        '
        Me.FULL_TarjetasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FULL_TarjetasBindingNavigatorSaveItem.Enabled = False
        Me.FULL_TarjetasBindingNavigatorSaveItem.Image = CType(resources.GetObject("FULL_TarjetasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FULL_TarjetasBindingNavigatorSaveItem.Name = "FULL_TarjetasBindingNavigatorSaveItem"
        Me.FULL_TarjetasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FULL_TarjetasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'FULL_TarjetasDataGridView
        '
        Me.FULL_TarjetasDataGridView.AllowUserToAddRows = False
        Me.FULL_TarjetasDataGridView.AllowUserToDeleteRows = False
        Me.FULL_TarjetasDataGridView.AutoGenerateColumns = False
        Me.FULL_TarjetasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FULL_TarjetasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.descripcion, Me.DataGridViewTextBoxColumn5, Me.idEstatus, Me.idUsuario, Me.idProveedor, Me.idTipoTarjeta})
        Me.FULL_TarjetasDataGridView.DataSource = Me.FULL_TarjetasBindingSource
        Me.FULL_TarjetasDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.FULL_TarjetasDataGridView.Name = "FULL_TarjetasDataGridView"
        Me.FULL_TarjetasDataGridView.ReadOnly = True
        Me.FULL_TarjetasDataGridView.Size = New System.Drawing.Size(776, 431)
        Me.FULL_TarjetasDataGridView.TabIndex = 1
        '
        'FULLEstatusBindingSource
        '
        Me.FULLEstatusBindingSource.DataMember = "FULL_Estatus"
        Me.FULLEstatusBindingSource.DataSource = Me.ProductionDataSet
        '
        'FULLUsuariosBindingSource
        '
        Me.FULLUsuariosBindingSource.DataMember = "FULL_Usuarios"
        Me.FULLUsuariosBindingSource.DataSource = Me.ProductionDataSet
        '
        'FULLProveedorTarjetaBindingSource
        '
        Me.FULLProveedorTarjetaBindingSource.DataMember = "FULL_ProveedorTarjeta"
        Me.FULLProveedorTarjetaBindingSource.DataSource = Me.ProductionDataSet
        '
        'FULLTipoTarjetaBindingSource
        '
        Me.FULLTipoTarjetaBindingSource.DataMember = "FULL_TipoTarjeta"
        Me.FULLTipoTarjetaBindingSource.DataSource = Me.ProductionDataSet
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(713, 465)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'descripcion
        '
        Me.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 5
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "noTarjeta"
        Me.DataGridViewTextBoxColumn5.HeaderText = "No tarjeta"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 5
        '
        'idEstatus
        '
        Me.idEstatus.DataPropertyName = "idEstatus"
        Me.idEstatus.DataSource = Me.FULLEstatusBindingSource
        Me.idEstatus.DisplayMember = "descripcion"
        Me.idEstatus.HeaderText = "Estatus"
        Me.idEstatus.Name = "idEstatus"
        Me.idEstatus.ReadOnly = True
        Me.idEstatus.ValueMember = "idEstatus"
        '
        'idUsuario
        '
        Me.idUsuario.DataPropertyName = "idUsuario"
        Me.idUsuario.DataSource = Me.FULLUsuariosBindingSource
        Me.idUsuario.DisplayMember = "nombre"
        Me.idUsuario.HeaderText = "Usuario"
        Me.idUsuario.Name = "idUsuario"
        Me.idUsuario.ReadOnly = True
        Me.idUsuario.ValueMember = "idUsuario"
        Me.idUsuario.Width = 200
        '
        'idProveedor
        '
        Me.idProveedor.DataPropertyName = "idProveedor"
        Me.idProveedor.DataSource = Me.FULLProveedorTarjetaBindingSource
        Me.idProveedor.DisplayMember = "nombreProveedor"
        Me.idProveedor.HeaderText = "Proveedor"
        Me.idProveedor.Name = "idProveedor"
        Me.idProveedor.ReadOnly = True
        Me.idProveedor.ValueMember = "idProvtarjeta"
        '
        'idTipoTarjeta
        '
        Me.idTipoTarjeta.DataPropertyName = "idTipoTarjeta"
        Me.idTipoTarjeta.DataSource = Me.FULLTipoTarjetaBindingSource
        Me.idTipoTarjeta.DisplayMember = "descripcion"
        Me.idTipoTarjeta.HeaderText = "Tipo Tarjeta"
        Me.idTipoTarjeta.Name = "idTipoTarjeta"
        Me.idTipoTarjeta.ReadOnly = True
        Me.idTipoTarjeta.ValueMember = "idTipoTarjeta"
        '
        'frmInventariotarjetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 497)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.FULL_TarjetasDataGridView)
        Me.Controls.Add(Me.FULL_TarjetasBindingNavigator)
        Me.Name = "frmInventariotarjetas"
        Me.Text = "frmInventariotarjetas"
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULL_TarjetasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULL_TarjetasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FULL_TarjetasBindingNavigator.ResumeLayout(False)
        Me.FULL_TarjetasBindingNavigator.PerformLayout()
        CType(Me.FULL_TarjetasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULLEstatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULLUsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULLProveedorTarjetaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULLTipoTarjetaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductionDataSet As ProductionDataSet
    Friend WithEvents FULL_TarjetasBindingSource As BindingSource
    Friend WithEvents FULL_TarjetasTableAdapter As ProductionDataSetTableAdapters.FULL_TarjetasTableAdapter
    Friend WithEvents TableAdapterManager As ProductionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FULL_TarjetasBindingNavigator As BindingNavigator
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
    Friend WithEvents FULL_TarjetasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FULL_TarjetasDataGridView As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents FULL_EstatusTableAdapter As ProductionDataSetTableAdapters.FULL_EstatusTableAdapter
    Friend WithEvents FULL_UsuariosTableAdapter As ProductionDataSetTableAdapters.FULL_UsuariosTableAdapter
    Friend WithEvents FULLEstatusBindingSource As BindingSource
    Friend WithEvents FULLUsuariosBindingSource As BindingSource
    Friend WithEvents FULL_ProveedorTarjetaTableAdapter As ProductionDataSetTableAdapters.FULL_ProveedorTarjetaTableAdapter
    Friend WithEvents FULLProveedorTarjetaBindingSource As BindingSource
    Friend WithEvents FULL_TipoTarjetaTableAdapter As ProductionDataSetTableAdapters.FULL_TipoTarjetaTableAdapter
    Friend WithEvents FULLTipoTarjetaBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents idEstatus As DataGridViewComboBoxColumn
    Friend WithEvents idUsuario As DataGridViewComboBoxColumn
    Friend WithEvents idProveedor As DataGridViewComboBoxColumn
    Friend WithEvents idTipoTarjeta As DataGridViewComboBoxColumn
End Class
