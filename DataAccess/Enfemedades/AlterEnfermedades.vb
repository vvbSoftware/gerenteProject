Public Class AlterEnfermedades
    Inherits ConexionBD
    Public Function ModifEnfermedad(nombreEnfermedad As String, riesgo As String, descripcion As String) As Boolean
        Dim _consultaSQL As String
        Try
            _consultaSQL = "UPDATE enfermedad SET "
            _consultaSQL &= "nombre = '" & nombreEnfermedad & "',"
            _consultaSQL &= "riesgo = " & riesgo & ","
            _consultaSQL &= "descripcion = '" & descripcion & "' "
            _consultaSQL &= "where nombre= " & nombreEnfermedad
            consultaEjecutar(_consultaSQL)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
