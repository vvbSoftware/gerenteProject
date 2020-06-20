Public Class AlterMedicos
    Inherits ConexionBD
    Public Function ModifMedico(ciMedico As String, especialidad As String, numMedico As Integer) As Boolean
        Dim _consultaSQL As String
        Try
            _consultaSQL = "UPDATE enfermedad SET "
            _consultaSQL &= "ciM = '" & ciMedico & "',"
            _consultaSQL &= "numMed = " & numMedico & "',"
            _consultaSQL &= "especialidad = '" & especialidad & " ')"
            _consultaSQL &= "where ciM= " & ciMedico
            consultaEjecutar(_consultaSQL)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
