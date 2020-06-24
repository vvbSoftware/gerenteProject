Public Class GetEnfermedades
    Inherits ConexionBD
    Public Function ObtenerEnfermedades() As DataTable
        Dim _consultaSQL As String
        _consultaSQL = "select idEnf,nombre,riesgo,descripcion,nomSint FROM enfermedad join define ON nombre=nomENf Group by nomEnf;"
        Return DevolverTabla(_consultaSQL)
    End Function
End Class
