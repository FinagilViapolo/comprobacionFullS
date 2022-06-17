Imports System.ComponentModel

Public Class frmAltaDeUsuarios
    Dim idCliente As Integer
    Dim taClientes As New ProductionDataSetTableAdapters.FULL_ClientesTableAdapter
    Dim FULL_ClientesTableAdapter As New ProductionDataSetTableAdapters.FULL_ClientesTableAdapter
    Dim utils As New utilerias

    Private Sub FULL_UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FULL_UsuariosBindingNavigatorSaveItem.Click
        If cmbRazonSocial.SelectedIndex > -1 And cmbSucursal.SelectedIndex > -1 And cmbAnexo.SelectedIndex > -1 Then
            idCliente = taClientes.obtieneIdCliente_ScalarQuery(cmbSucursal.Text, cmbAnexo.Text, cmbRazonSocial.SelectedValue)
        Else
            idCliente = -1
        End If
        If idCliente > 0 Then
            Me.FULL_UsuariosBindingSource.Current("idEmpresa") = idCliente
            Me.Validate()
            Me.FULL_UsuariosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ProductionDataSet)
        Else
            MsgBox("El cliente indicado no existe, es necesario agregarlo desde el apartado Clientes, se guardará la información adicional", MsgBoxStyle.Information, "")
            Me.Validate()
            Me.FULL_UsuariosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ProductionDataSet)
        End If
    End Sub

    Private Sub frmAltaDeUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet1.FULL_Clientes' Puede moverla o quitarla según sea necesario.
        Me.FULL_ClientesTableAdapter.Fill(Me.ProductionDataSet.FULL_Clientes)
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.Vw_Full_DatosServicioCXP_Clientes' Puede moverla o quitarla según sea necesario.
        Me.Vw_Full_DatosServicioCXP_ClientesTableAdapter.Fill(Me.ProductionDataSet.Vw_Full_DatosServicioCXP_Clientes)
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.FULL_Usuarios' Puede moverla o quitarla según sea necesario.
        Me.FULL_UsuariosTableAdapter.Fill(Me.ProductionDataSet.FULL_Usuarios)
        Me.FULL_EstatusTableAdapter.Fill(Me.ProductionDataSet.FULL_Estatus, "USUARIOS")

    End Sub

    Private Sub cmbRazonSocial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRazonSocial.SelectedIndexChanged
        If Not IsNothing(cmbRazonSocial.SelectedValue) Then
            Me.Vw_Full_DatosServicioCXP_SucursalTableAdapter.Sucursal_Fill(Me.ProductionDataSet.Vw_Full_DatosServicioCXP_Sucursal, cmbRazonSocial.SelectedValue)
            Me.FULL_ClientesTableAdapter.clientes_FillBy(Me.ProductionDataSet.FULL_Clientes, cmbRazonSocial.SelectedValue)
            cmbSucursal.Enabled = True
        End If
    End Sub

    Private Sub cmbSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSucursal.SelectedIndexChanged
        If Not IsNothing(cmbSucursal.SelectedValue) Then
            Me.Vw_Full_DatosServicioCXP_AnexosTableAdapter.Anexo_Fill(Me.ProductionDataSet.Vw_Full_DatosServicioCXP_Anexos, cmbSucursal.SelectedValue, VwFullDatosServicioCXPSucursalBindingSource.Current("LugarEntrega"))
            cmbAnexo.Enabled = True
        End If
    End Sub

    Private Sub btnReestablecerContr_Click(sender As Object, e As EventArgs) Handles btnReestablecerContr.Click
        If CDec(IdUsuarioTextBox.Text) > 0 And cmbEstatus.Text = "ACTIVO" Then
            Dim url As String = "https://finagil.com.mx/WEBtasas/frmReestPw.aspx?ID=" & IdUsuarioTextBox.Text.Trim
            utils.sentMailPasswordUsuario(MailTextBox.Text.Trim, url)
        Else
            MsgBox("El cliente debe de existir y estar activo")
        End If
    End Sub

    Private Sub btnTarjetas_Click(sender As Object, e As EventArgs) Handles btnTarjetas.Click
        Dim frmHijo As New frmTarjetas
        Dim mdiPadre As New mdiGastosFS

        mdiPadre = MdiParent
        frmHijo.MdiParent = mdiPadre
        Me.Cursor = Cursors.WaitCursor
        frmTarjetas.idUsuario = CInt(IdUsuarioTextBox.Text)
        frmHijo.Show()
        Me.Cursor = Cursors.Default
    End Sub
End Class