<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedorTarjeta
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
        Dim NombreProveedorLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedorTarjeta))
        Me.ProductionDataSet = New comprobacionFullS.ProductionDataSet()
        Me.FULL_ProveedorTarjetaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FULL_ProveedorTarjetaTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.FULL_ProveedorTarjetaTableAdapter()
        Me.TableAdapterManager = New comprobacionFullS.ProductionDataSetTableAdapters.TableAdapterManager()
        Me.FULL_ProveedorTarjetaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FULL_ProveedorTarjetaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NombreProveedorTextBox = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        NombreProveedorLabel = New System.Windows.Forms.Label()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULL_ProveedorTarjetaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULL_ProveedorTarjetaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FULL_ProveedorTarjetaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreProveedorLabel
        '
        NombreProveedorLabel.AutoSize = True
        NombreProveedorLabel.Location = New System.Drawing.Point(10, 43)
        NombreProveedorLabel.Name = "NombreProveedorLabel"
        NombreProveedorLabel.Size = New System.Drawing.Size(59, 13)
        NombreProveedorLabel.TabIndex = 1
        NombreProveedorLabel.Text = "Proveedor:"
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FULL_ProveedorTarjetaBindingSource
        '
        Me.FULL_ProveedorTarjetaBindingSource.DataMember = "FULL_ProveedorTarjeta"
        Me.FULL_ProveedorTarjetaBindingSource.DataSource = Me.ProductionDataSet
        '
        'FULL_ProveedorTarjetaTableAdapter
        '
        Me.FULL_ProveedorTarjetaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FULL_AutorizantesTableAdapter = Nothing
        Me.TableAdapterManager.FULL_ClientesTableAdapter = Nothing
        Me.TableAdapterManager.FULL_EstatusTableAdapter = Nothing
        Me.TableAdapterManager.FULL_ProveedorTarjetaTableAdapter = Me.FULL_ProveedorTarjetaTableAdapter
        Me.TableAdapterManager.FULL_ServiciosTableAdapter = Nothing
        Me.TableAdapterManager.FULL_TarjetasConceptosTableAdapter = Nothing
        Me.TableAdapterManager.FULL_TarjetasTableAdapter = Nothing
        Me.TableAdapterManager.FULL_TipoTarjetaTableAdapter = Nothing
        Me.TableAdapterManager.FULL_UsuarioClienteTableAdapter = Nothing
        Me.TableAdapterManager.FULL_UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.GEN_Correos_SistemaFinagilTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = comprobacionFullS.ProductionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FULL_ProveedorTarjetaBindingNavigator
        '
        Me.FULL_ProveedorTarjetaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FULL_ProveedorTarjetaBindingNavigator.BindingSource = Me.FULL_ProveedorTarjetaBindingSource
        Me.FULL_ProveedorTarjetaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FULL_ProveedorTarjetaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FULL_ProveedorTarjetaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FULL_ProveedorTarjetaBindingNavigatorSaveItem})
        Me.FULL_ProveedorTarjetaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FULL_ProveedorTarjetaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FULL_ProveedorTarjetaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FULL_ProveedorTarjetaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FULL_ProveedorTarjetaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FULL_ProveedorTarjetaBindingNavigator.Name = "FULL_ProveedorTarjetaBindingNavigator"
        Me.FULL_ProveedorTarjetaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FULL_ProveedorTarjetaBindingNavigator.Size = New System.Drawing.Size(489, 25)
        Me.FULL_ProveedorTarjetaBindingNavigator.TabIndex = 0
        Me.FULL_ProveedorTarjetaBindingNavigator.Text = "BindingNavigator1"
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
        'FULL_ProveedorTarjetaBindingNavigatorSaveItem
        '
        Me.FULL_ProveedorTarjetaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FULL_ProveedorTarjetaBindingNavigatorSaveItem.Image = CType(resources.GetObject("FULL_ProveedorTarjetaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FULL_ProveedorTarjetaBindingNavigatorSaveItem.Name = "FULL_ProveedorTarjetaBindingNavigatorSaveItem"
        Me.FULL_ProveedorTarjetaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FULL_ProveedorTarjetaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NombreProveedorTextBox
        '
        Me.NombreProveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FULL_ProveedorTarjetaBindingSource, "nombreProveedor", True))
        Me.NombreProveedorTextBox.Location = New System.Drawing.Point(75, 40)
        Me.NombreProveedorTextBox.Name = "NombreProveedorTextBox"
        Me.NombreProveedorTextBox.Size = New System.Drawing.Size(408, 20)
        Me.NombreProveedorTextBox.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(408, 66)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmProveedorTarjeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 96)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(NombreProveedorLabel)
        Me.Controls.Add(Me.NombreProveedorTextBox)
        Me.Controls.Add(Me.FULL_ProveedorTarjetaBindingNavigator)
        Me.Name = "frmProveedorTarjeta"
        Me.Text = "Proveedor de tarjetas"
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULL_ProveedorTarjetaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULL_ProveedorTarjetaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FULL_ProveedorTarjetaBindingNavigator.ResumeLayout(False)
        Me.FULL_ProveedorTarjetaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductionDataSet As ProductionDataSet
    Friend WithEvents FULL_ProveedorTarjetaBindingSource As BindingSource
    Friend WithEvents FULL_ProveedorTarjetaTableAdapter As ProductionDataSetTableAdapters.FULL_ProveedorTarjetaTableAdapter
    Friend WithEvents TableAdapterManager As ProductionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FULL_ProveedorTarjetaBindingNavigator As BindingNavigator
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
    Friend WithEvents FULL_ProveedorTarjetaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NombreProveedorTextBox As TextBox
    Friend WithEvents btnSalir As Button
End Class
