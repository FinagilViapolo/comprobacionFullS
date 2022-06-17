Public Class frmUsuarios
    Public idCliente As Integer
    Private Sub FULL_UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FULL_UsuariosBindingNavigatorSaveItem.Click
        FULL_UsuariosBindingSource.Current("idEmpresa") = idCliente
        Me.Validate()
        Me.FULL_UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProductionDataSet)
    End Sub

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProductionDataSet.FULL_Usuarios' Puede moverla o quitarla según sea necesario.
        Me.FULL_UsuariosTableAdapter.porCliente_FillBy(Me.ProductionDataSet.FULL_Usuarios, idCliente)
        If FULL_UsuariosDataGridView.Rows.Count > 0 Then
            FULL_UsuariosBindingNavigator.Enabled = False
        End If
    End Sub

    Private Sub frmUsuarios_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmContratos.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Dim frmMdiHijo As New frmAltaDeUsuarios
        Dim mdiPadre As New mdiGastosFS
        mdiPadre = MdiParent
        frmMdiHijo.MdiParent = mdiPadre
        frmMdiHijo.Show()
    End Sub
End Class