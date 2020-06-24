Public Class DeleteMedico
    Inherits ConexionBD
    Public Function BorarMedico(ciMedico As String) As Boolean
        Dim _consultaSQL As String

        _consultaSQL = "SELECT * FROM medico WHERE EXISTS (SELECT ciM FROM medico WHERE ciM=" & ciMedico & ")"
        Try
            If ConsultaComprobarExistencia(_consultaSQL) Then
                _consultaSQL = "Delete FROM medico WHERE ciM=" & ciMedico & ""
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
