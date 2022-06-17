Imports System.Windows.Forms

Public Class mdiGastosFS
    Private Sub ContratosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContratosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        frmContratos.MdiParent = Me
        frmContratos.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        frmAltaDeUsuarios.MdiParent = Me
        frmAltaDeUsuarios.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub AutorizantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutorizantesToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        frmAutorizadores.MdiParent = Me
        frmAutorizadores.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub TipoDeTarjetaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeTarjetaToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        frmTipoTarjeta.MdiParent = Me
        frmTipoTarjeta.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ProveedorDeTarjetaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedorDeTarjetaToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        frmProveedorTarjeta.MdiParent = Me
        frmProveedorTarjeta.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        frmInventariotarjetas.MdiParent = Me
        frmInventariotarjetas.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
