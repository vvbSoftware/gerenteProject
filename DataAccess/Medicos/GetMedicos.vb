Public Class GetMedicos
    Inherits ConexionBD
    Public Function ObtenerMedicos() As DataTable
        Dim _consultaSQL As String
        _consultaSQL = "SELECT * FROM medico"
        Return DevolverTabla(_consultaSQL)
    End Function
End Class
