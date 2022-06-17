Public Class frmTipoTarjeta
    Private Sub FULL_TipoTarjetaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FULL_TipoTarjetaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FULL_TipoTarjetaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProductionDataSet)

    End Sub

    Private Sub frmTipoTarjeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.FULL_TipoTarjeta' Puede moverla o quitarla según sea necesario.
        Me.FULL_TipoTarjetaTableAdapter.Fill(Me.ProductionDataSet.FULL_TipoTarjeta)

    End Sub
End Class