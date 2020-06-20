Public Class DeleteSintoma
    Inherits ConexionBD
    Public Function BorrarSintoma(nombreSintoma As String) As Boolean
        Dim _consultaSQL As String

        _consultaSQL = "SELECT * FROM sintoma WHERE EXISTS (SELECT nombre FROM sintoma WHERE nombre=" & nombreSintoma & ")"

        If ConsultaComprobarExistencia(_consultaSQL) Then
            Return True
            _consultaSQL = "Delete * FROM sintoma WHERE nombre=" & nombreSintoma & ""
            consultaEjecutar(_consultaSQL)
        Else
            Return False
        End If
    End Function
End Class
