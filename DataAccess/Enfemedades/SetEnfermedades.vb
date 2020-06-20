Public Class SetEnfermedades
    Inherits ConexionBD
    Public Function SetEnfermedad(nombreEnfermedad As String, riesgo As String, descripcion As String) As Boolean
        Dim _consultaSQL As String

        _consultaSQL = "SELECT * FROM enfermedad WHERE EXISTS (SELECT nombre FROM enfermedad WHERE nombre=" & nombreEnfermedad & ")"

        If ConsultaComprobarExistencia(_consultaSQL) Then
            Return True
        Else
            _consultaSQL = "INSERT INTO sintoma(idEnf,nombre,riesgo,descripcion)"
            _consultaSQL &= " VALUES ( "
            _consultaSQL &= "'" & "null" & "'," 'valor null porque id es auto_incremente
            _consultaSQL &= "'" & nombreEnfermedad & "',"
            _consultaSQL &= "'" & riesgo & "',"
            _consultaSQL &= "'" & descripcion & "')"
            consultaEjecutar(_consultaSQL)
            Return False
        End If
    End Function
End Class
