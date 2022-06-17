Public Class frmTarjetas
    Public idUsuario As Integer = CInt(frmAltaDeUsuarios.IdUsuarioTextBox.Text)
    Dim taTarjetasConceptos As New ProductionDataSetTableAdapters.FULL_TarjetasConceptosTableAdapter
    Private Sub FULL_TarjetasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FULL_TarjetasBindingNavigatorSaveItem.Click
        If CInt(IdTarjetaTextBox.Text) > 0 Then
            Me.FULL_TarjetasConceptosBindingSource.Current("idTarjeta") = IdTarjetaTextBox.Text
            Me.FULL_TarjetasBindingSource.Current("idUsuario") = idUsuario 'IdTarjetaTextBox.Text

            Me.Validate()
            Me.FULL_TarjetasBindingSource.EndEdit()
            Me.FULL_TarjetasConceptosBindingSource.EndEdit()
            FULL_TarjetasConceptosTableAdapter.Update(ProductionDataSet.FULL_TarjetasConceptos)
            Me.TableAdapterManager.UpdateAll(Me.ProductionDataSet)
        Else
            MsgBox("Favor de guardar la tarjeta antes de insertar un concepto", MsgBoxStyle.Information, "")
        End If
    End Sub

    Private Sub frmTarjetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.FULL_TarjetasConceptos' Puede moverla o quitarla según sea necesario.
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.FULL_Servicios' Puede moverla o quitarla según sea necesario.
        Me.FULL_ServiciosTableAdapter.Fill(Me.ProductionDataSet.FULL_Servicios)
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.FULL_Clientes' Puede moverla o quitarla según sea necesario.
        Me.FULL_ClientesTableAdapter.Fill(Me.ProductionDataSet.FULL_Clientes)
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.FULL_TipoTarjeta' Puede moverla o quitarla según sea necesario.
        Me.FULL_TipoTarjetaTableAdapter.Fill(Me.ProductionDataSet.FULL_TipoTarjeta)
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.FULL_ProveedorTarjeta' Puede moverla o quitarla según sea necesario.
        Me.FULL_ProveedorTarjetaTableAdapter.Fill(Me.ProductionDataSet.FULL_ProveedorTarjeta)
        Me.FULL_EstatusTableAdapter.Fill(Me.ProductionDataSet.FULL_Estatus, "TARJETAS")
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.FULL_Tarjetas' Puede moverla o quitarla según sea necesario.
        Me.FULL_TarjetasTableAdapter.Fill(Me.ProductionDataSet.FULL_Tarjetas, idUsuario)

        'Me.FULL_TarjetasConceptosTableAdapter.Fill(Me.ProductionDataSet.FULL_TarjetasConceptos, Me.FULL_TarjetasBindingSource.Current("idTarjeta"))

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub IdTarjetaTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdTarjetaTextBox.TextChanged
        taTarjetasConceptos.Fill(Me.ProductionDataSet.FULL_TarjetasConceptos, IdTarjetaTextBox.Text)
    End Sub
End Class