Public Class SetSintomas
    Inherits ConexionBD
    Public Function SetSintoma(nombreSintoma As String) As Boolean
        Dim _consultaSQL As String

        _consultaSQL = "SELECT * FROM sintoma WHERE EXISTS ( SELECT nombre FROM sintoma WHERE nombre='" & nombreSintoma & "' );"

        If ConsultaComprobarExistencia(_consultaSQL) Then
            Return True
        Else
            _consultaSQL = "INSERT	INTO sintoma(id,nombre) VALUES(null,'" & nombreSintoma & "');"
            consultaEjecutar(_consultaSQL)
            Return False
        End If
    End Function

End Class
