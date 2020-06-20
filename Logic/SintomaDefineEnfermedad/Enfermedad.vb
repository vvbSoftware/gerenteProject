Imports DataAccess
Public Class Enfermedad
    Property _nombre As String
    Property _riesgo As String
    Property _descripcion As String

    Public Sub New()
    End Sub

    Public Sub New(nombre As String, riesgo As String, descripcion As String)
        _nombre = nombre
        _riesgo = riesgo
        _descripcion = descripcion
    End Sub

    Public Function ObtenerEnfermedades() As DataTable
        Dim consu As New GetEnfermedades()
        Return consu.ObtenerEnfermedad()
    End Function

    Public Function GuardarEnfermedad() As Boolean
        Dim consu As New SetEnfermedades()
        Return consu.SetEnfermedad(_nombre, _riesgo, _descripcion)
    End Function

    Public Function ModificarEnfermedad() As Boolean
        Dim consu As New AlterEnfermedades()
        Return consu.ModifEnfermedad(_nombre, _riesgo, _descripcion)
    End Function


End Class
