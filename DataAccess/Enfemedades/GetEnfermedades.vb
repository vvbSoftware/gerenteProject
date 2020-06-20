Public Class GetEnfermedades
    Inherits ConexionBD
    Public Function ObtenerEnfermedad() As DataTable
        Dim _consultaSQL As String
        _consultaSQL = "SELECT * FROM enfermedad"
        Return DevolverTabla(_consultaSQL)
    End Function
End Class
