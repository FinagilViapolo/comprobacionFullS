Public Class frmContratos
    Private Sub frmContratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.FULL_Clientes' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.Vw_Full_DatosServicioCXP_Clientes' Puede moverla o quitarla según sea necesario.
        Me.Vw_Full_DatosServicioCXP_ClientesTableAdapter.Fill(Me.ProductionDataSet.Vw_Full_DatosServicioCXP_Clientes)
    End Sub

    Private Sub cmbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClientes.SelectedIndexChanged
        If Not IsNothing(cmbClientes.SelectedValue) Then
            Me.Vw_Full_DatosServicioCXP_SucursalTableAdapter.Sucursal_Fill(Me.ProductionDataSet.Vw_Full_DatosServicioCXP_Sucursal, cmbClientes.SelectedValue)
            Me.FULL_ClientesTableAdapter.clientes_FillBy(Me.ProductionDataSet.FULL_Clientes, cmbClientes.SelectedValue)
            cmbClientes.Enabled = False
            cmbSucursal.Enabled = True
        End If
    End Sub

    Private Sub cmbSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSucursal.SelectedIndexChanged
        If Not IsNothing(cmbSucursal.SelectedValue) Then
            Me.Vw_Full_DatosServicioCXP_AnexosTableAdapter.Anexo_Fill(Me.ProductionDataSet.Vw_Full_DatosServicioCXP_Anexos, cmbSucursal.SelectedValue, VwFullDatosServicioCXPSucursalBindingSource.Current("LugarEntrega"))
            cmbSucursal.Enabled = False
            cmbContratos.Enabled = True
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbContratos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbContratos.SelectedIndexChanged
        cmbContratos.Enabled = False
        btnAgregar.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnAgregar.Enabled = False
        cmbClientes.Enabled = True
        cmbSucursal.Enabled = False
        cmbContratos.Enabled = False
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim taClientes As New ProductionDataSetTableAdapters.FULL_ClientesTableAdapter
        Dim rowClientes As ProductionDataSet.FULL_ClientesRow
        btnAgregar.Enabled = False
        cmbClientes.Enabled = True
        If taClientes.existeCliente_ScalarQuery(cmbContratos.Text, cmbClientes.SelectedValue, VwFullDatosServicioCXPClientesBindingSource.Current("RFC")) = 0 Then
            rowClientes = ProductionDataSet.FULL_Clientes.NewFULL_ClientesRow
            rowClientes.nombre = VwFullDatosServicioCXPClientesBindingSource.Current("Descr")
            rowClientes.rfc = VwFullDatosServicioCXPClientesBindingSource.Current("RFC")
            rowClientes.clienteFinagil = cmbClientes.SelectedValue
            rowClientes.sucursal = cmbSucursal.Text
            rowClientes.contrato = cmbContratos.Text
            ProductionDataSet.FULL_Clientes.AddFULL_ClientesRow(rowClientes)
            Me.FULL_ClientesTableAdapter.Update(Me.ProductionDataSet)
        Else
            MsgBox("Los datos ya existen", MsgBoxStyle.Information, "")
        End If
    End Sub

    Private Sub FULL_ClientesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles FULL_ClientesDataGridView.CellContentClick
        If e.ColumnIndex = 1 Then
            Dim frmMdiUsuarios As New frmUsuarios
            Dim mdiUsuarios As New mdiGastosFS
            Me.Enabled = False
            mdiUsuarios = MdiParent
            frmMdiUsuarios.MdiParent = mdiUsuarios
            frmMdiUsuarios.idCliente = FULL_ClientesBindingSource.Current("idCliente")
            frmMdiUsuarios.Show()
        End If
    End Sub
End Class
