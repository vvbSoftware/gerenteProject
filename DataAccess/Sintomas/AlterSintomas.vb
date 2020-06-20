Public Class AlterSintomas
    Inherits ConexionBD

    Public Function ModifSintomas(nombreSintoma As String) As Boolean
        Dim _consultaSQL As String
        Try
            _consultaSQL = "UPDATE sintoma SET nombre='" & nombreSintoma & "'"
            consultaEjecutar(_consultaSQL)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
