Public Class DeleteEnfermedad
    Inherits ConexionBD
    Public Function BorrarEnfermedad(nombreEnfermedad As String) As Boolean
        Dim _consultaSQL As String

        _consultaSQL = "SELECT * FROM enfermedad WHERE EXISTS (SELECT nombre FROM enfermedad WHERE nombre=" & nombreEnfermedad & ")"

        If ConsultaComprobarExistencia(_consultaSQL) Then
            _consultaSQL = "Delete * FROM enfermedad WHERE nombre=" & nombreEnfermedad & ""
            consultaEjecutar(_consultaSQL)
            Return True
        Else
            Return False
        End If
    End Function
End Class
