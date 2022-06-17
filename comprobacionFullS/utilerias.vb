Public Class utilerias
    'Envio de correos
    Dim taEnviaCorreos As New ProductionDataSetTableAdapters.GEN_Correos_SistemaFinagilTableAdapter

    Public Sub sentMailPasswordUsuario(ByVal destinatario As String, ByVal url As String)
        taEnviaCorreos.Insert("NotificacionesFS@cmoderna.com", destinatario, "Solicitud de cambio de contraseña", modVariables.cuerpoMensajeCambioPw_a & url & modVariables.cuerpoMensajeCambioPw_b, False, Date.Now, "")
    End Sub
End Class
