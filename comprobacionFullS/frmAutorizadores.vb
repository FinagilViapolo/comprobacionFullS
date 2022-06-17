Public Class frmAutorizadores
    Dim taClientes As New ProductionDataSetTableAdapters.FULL_ClientesTableAdapter

    Private Sub FULL_AutorizantesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FULL_AutorizantesBindingNavigatorSaveItem.Click

        Me.FULL_AutorizantesBindingSource.Current("clienteFinagil") = cmbCliente.SelectedValue
        Me.FULL_AutorizantesBindingSource.Current("sucursal") = cmbSucursal.SelectedValue
        Me.FULL_AutorizantesBindingSource.Current("contrato") = cmbAnexo.SelectedValue
        Me.Validate()
        Me.FULL_AutorizantesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProductionDataSet)

    End Sub

    Private Sub frmAutorizadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.Vw_Full_DatosServicioCXP_Clientes' Puede moverla o quitarla según sea necesario.
        Me.Vw_Full_DatosServicioCXP_ClientesTableAdapter.Fill(Me.ProductionDataSet.Vw_Full_DatosServicioCXP_Clientes)
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.FULL_Autorizantes' Puede moverla o quitarla según sea necesario.
        'Me.Vw_Full_DatosServicioCXP_AnexosTableAdapter.FillBy(Me.ProductionDataSet.Vw_Full_DatosServicioCXP_Anexos)
        Me.Vw_Full_DatosServicioCXP_AnexosTableAdapter.Anexo_Fill(Me.ProductionDataSet.Vw_Full_DatosServicioCXP_Anexos, cmbCliente.SelectedValue, cmbSucursal.SelectedValue)

        Me.FULL_AutorizantesTableAdapter.Fill(Me.ProductionDataSet.FULL_Autorizantes)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSucursal.SelectedIndexChanged
        If Not IsNothing(cmbSucursal.SelectedValue) And Not IsNothing(cmbCliente.SelectedValue) Then
            Me.Vw_Full_DatosServicioCXP_AnexosTableAdapter.Anexo_Fill(Me.ProductionDataSet.Vw_Full_DatosServicioCXP_Anexos, cmbCliente.SelectedValue, cmbSucursal.SelectedValue)
        End If
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCliente.SelectedIndexChanged
        If Not IsNothing(cmbCliente.SelectedValue) Then
            Me.Vw_Full_DatosServicioCXP_SucursalTableAdapter.Sucursal_Fill(Me.ProductionDataSet.Vw_Full_DatosServicioCXP_Sucursal, cmbCliente.SelectedValue)
        End If
    End Sub
End Class