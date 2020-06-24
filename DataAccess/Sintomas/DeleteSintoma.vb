Public Class DeleteSintoma
    Inherits ConexionBD
    Public Function BorrarSintoma(nombreSintoma As String) As Boolean
        Dim _consultaSQL As String

        _consultaSQL = "SELECT * FROM sintoma WHERE EXISTS (SELECT nombre FROM sintoma WHERE nombre='" & nombreSintoma & "')"
        Try

            If ConsultaComprobarExistencia(_consultaSQL) Then
                _consultaSQL = "delete from define where nomSint='" & nombreSintoma & "';"
                _consultaSQL &= "Delete FROM sintoma WHERE nombre='" & nombreSintoma & "';"
                consultaEjecutar(_consultaSQL)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("ERROR::" & ex.Message)
        End Try
    End Function
End Class
