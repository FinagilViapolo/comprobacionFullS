Public Class frmProveedorTarjeta
    Private Sub FULL_ProveedorTarjetaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FULL_ProveedorTarjetaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FULL_ProveedorTarjetaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProductionDataSet)

    End Sub

    Private Sub frmProveedorTarjeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.FULL_ProveedorTarjeta' Puede moverla o quitarla según sea necesario.
        Me.FULL_ProveedorTarjetaTableAdapter.Fill(Me.ProductionDataSet.FULL_ProveedorTarjeta)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class