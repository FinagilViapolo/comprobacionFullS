Public Class frmInventariotarjetas

    Private Sub frmInventariotarjetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.FULL_TipoTarjeta' Puede moverla o quitarla según sea necesario.
        Me.FULL_TipoTarjetaTableAdapter.Fill(Me.ProductionDataSet.FULL_TipoTarjeta)
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.FULL_ProveedorTarjeta' Puede moverla o quitarla según sea necesario.
        Me.FULL_ProveedorTarjetaTableAdapter.Fill(Me.ProductionDataSet.FULL_ProveedorTarjeta)
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.FULL_Usuarios' Puede moverla o quitarla según sea necesario.
        Me.FULL_UsuariosTableAdapter.Fill(Me.ProductionDataSet.FULL_Usuarios)
        Me.FULL_EstatusTableAdapter.Fill(Me.ProductionDataSet.FULL_Estatus, "TARJETAS")
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.FULL_Tarjetas' Puede moverla o quitarla según sea necesario.
        'Me.FULL_TarjetasTableAdapter.Fill(Me.ProductionDataSet.FULL_Tarjetas)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class