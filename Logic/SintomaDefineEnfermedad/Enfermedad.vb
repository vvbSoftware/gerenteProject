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
        Return consu.ObtenerEnfermedades()
    End Function
    Public Function GuardarEnfermedad(enf As Enfermedad) As Boolean
        Dim consu As New SetEnfermedades()
        With enf
            Return consu.SetEnfermedad(._nombre, ._riesgo, ._descripcion)
        End With
    End Function

    Public Function ModificarEnfermedad(enf As Enfermedad) As Boolean
        Dim consu As New AlterEnfermedades()
        With enf
            Return consu.ModifEnfermedad(._nombre, ._riesgo, ._descripcion)
        End With
    End Function

    Public Function BorrarEnfermedad(dato As String) As Boolean
        Dim consu As New DeleteEnfermedad()
        Return consu.BorrarEnfermedad(dato)
    End Function

End Class
