<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoTarjeta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTipoTarjeta))
        Me.ProductionDataSet = New comprobacionFullS.ProductionDataSet()
        Me.FULL_TipoTarjetaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FULL_TipoTarjetaTableAdapter = New comprobacionFullS.ProductionDataSetTableAdapters.FULL_TipoTarjetaTableAdapter()
        Me.TableAdapterManager = New comprobacionFullS.ProductionDataSetTableAdapters.TableAdapterManager()
        Me.FULL_TipoTarjetaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FULL_TipoTarjetaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        DescripcionLabel = New System.Windows.Forms.Label()
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULL_TipoTarjetaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FULL_TipoTarjetaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FULL_TipoTarjetaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(12, 41)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(98, 13)
        DescripcionLabel.TabIndex = 1
        DescripcionLabel.Text = "Tipo de dispositivo:"
        '
        'ProductionDataSet
        '
        Me.ProductionDataSet.DataSetName = "ProductionDataSet"
        Me.ProductionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FULL_TipoTarjetaBindingSource
        '
        Me.FULL_TipoTarjetaBindingSource.DataMember = "FULL_TipoTarjeta"
        Me.FULL_TipoTarjetaBindingSource.DataSource = Me.ProductionDataSet
        '
        'FULL_TipoTarjetaTableAdapter
        '
        Me.FULL_TipoTarjetaTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.FULL_TipoTarjetaTableAdapter = Me.FULL_TipoTarjetaTableAdapter
        Me.TableAdapterManager.FULL_UsuarioClienteTableAdapter = Nothing
        Me.TableAdapterManager.FULL_UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.GEN_Correos_SistemaFinagilTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = comprobacionFullS.ProductionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FULL_TipoTarjetaBindingNavigator
        '
        Me.FULL_TipoTarjetaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FULL_TipoTarjetaBindingNavigator.BindingSource = Me.FULL_TipoTarjetaBindingSource
        Me.FULL_TipoTarjetaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FULL_TipoTarjetaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FULL_TipoTarjetaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FULL_TipoTarjetaBindingNavigatorSaveItem})
        Me.FULL_TipoTarjetaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FULL_TipoTarjetaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FULL_TipoTarjetaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FULL_TipoTarjetaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FULL_TipoTarjetaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FULL_TipoTarjetaBindingNavigator.Name = "FULL_TipoTarjetaBindingNavigator"
        Me.FULL_TipoTarjetaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FULL_TipoTarjetaBindingNavigator.Size = New System.Drawing.Size(552, 25)
        Me.FULL_TipoTarjetaBindingNavigator.TabIndex = 0
        Me.FULL_TipoTarjetaBindingNavigator.Text = "BindingNavigator1"
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
        'FULL_TipoTarjetaBindingNavigatorSaveItem
        '
        Me.FULL_TipoTarjetaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FULL_TipoTarjetaBindingNavigatorSaveItem.Image = CType(resources.GetObject("FULL_TipoTarjetaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FULL_TipoTarjetaBindingNavigatorSaveItem.Name = "FULL_TipoTarjetaBindingNavigatorSaveItem"
        Me.FULL_TipoTarjetaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FULL_TipoTarjetaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FULL_TipoTarjetaBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(116, 38)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(421, 20)
        Me.DescripcionTextBox.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(462, 64)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmTipoTarjeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 114)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Me.FULL_TipoTarjetaBindingNavigator)
        Me.Name = "frmTipoTarjeta"
        Me.Text = "Tipo de tarjetas"
        CType(Me.ProductionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULL_TipoTarjetaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FULL_TipoTarjetaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FULL_TipoTarjetaBindingNavigator.ResumeLayout(False)
        Me.FULL_TipoTarjetaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductionDataSet As ProductionDataSet
    Friend WithEvents FULL_TipoTarjetaBindingSource As BindingSource
    Friend WithEvents FULL_TipoTarjetaTableAdapter As ProductionDataSetTableAdapters.FULL_TipoTarjetaTableAdapter
    Friend WithEvents TableAdapterManager As ProductionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FULL_TipoTarjetaBindingNavigator As BindingNavigator
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
    Friend WithEvents FULL_TipoTarjetaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents btnSalir As Button
End Class
