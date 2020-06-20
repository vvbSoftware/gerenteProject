Public Class DeleteMedico
    Inherits ConexionBD
    Public Function BorarMedico(ciMedico As String) As Boolean
        Dim _consultaSQL As String

        _consultaSQL = "SELECT * FROM medico WHERE EXISTS (SELECT ciM FROM medico WHERE ciM=" & ciMedico & ")"

        If ConsultaComprobarExistencia(_consultaSQL) Then
            _consultaSQL = "Delete * FROM medico WHERE ciM=" & ciMedico & ""
            consultaEjecutar(_consultaSQL)
            Return True
        Else
            Return False
        End If
    End Function
End Class
