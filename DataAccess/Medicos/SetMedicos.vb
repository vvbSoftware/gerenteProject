Public Class SetMedicos
    Inherits ConexionBD
    Public Function SetMedico(ciMedico As String, especialidad As String, numMedico As Integer) As Boolean
        Dim _consultaSQL As String

        _consultaSQL = "SELECT * FROM medico WHERE EXISTS (SELECT ciM FROM medico WHERE ciM=" & ciMedico & ")"

        If ConsultaComprobarExistencia(_consultaSQL) Then
            Return True
        Else
            _consultaSQL = "INSERT INTO sintoma(ciM,numMed,especialidad)"
            _consultaSQL &= " VALUES ( "
            _consultaSQL &= "'" & ciMedico & "',"
            _consultaSQL &= "'" & numMedico & "',"
            _consultaSQL &= "'" & especialidad & "')"
            consultaEjecutar(_consultaSQL)
            Return False
        End If
    End Function
End Class
