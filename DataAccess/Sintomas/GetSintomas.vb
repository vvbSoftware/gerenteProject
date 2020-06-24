Public Class GetSintomas
    Inherits ConexionBD

    Public Sub New()
    End Sub

    Public Function ObtenerSintomas() As DataTable
        Dim _consultaSQL As String
        _consultaSQL = "SELECT nombre FROM sintoma"
        Return DevolverTabla(_consultaSQL)
            Return Nothing
    End Function
    Public Function DevolverSintomaComboBox() As DataSet
        Dim _consultaSQL As String
        _consultaSQL = "SELECT * FROM sintoma"
        Return DevolverParaComboBox(_consultaSQL)
    End Function
End Class
