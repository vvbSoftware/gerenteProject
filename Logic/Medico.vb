Imports DataAccess
Public Class Medico
    Inherits Persona
    Property _ciM As String
    Property _numMed As Integer
    Property _especialidad As String
    Property _lugarTrabajo As String

    Public Sub New()
    End Sub

    Public Sub New(ci As String, tel_cel As Integer, edad As Integer,
                   domicilio As String, sexo As String, sNom As String,
                   pNom As String, pApe As String, sApe As String, especialidad As String, lugarTrabajo As String)

        MyBase.New(ci, tel_cel, edad, domicilio, sexo, pNom, pApe, sNom, sApe)
        _ciM = ci
        _especialidad = especialidad
        _lugarTrabajo = lugarTrabajo
    End Sub

    Public Function ObtenerMedicos() As DataTable
        Dim consu As New GetMedicos()
        Return consu.ObtenerMedicos()
    End Function

    Public Function GuardarMedico() As Boolean
        Dim consu As New SetMedicos()
        Return consu.SetMedico(_ciM, _especialidad, _numMed)
    End Function

    Public Function ModificarMedico() As Boolean
        Dim consu As New AlterMedicos()
        Return consu.ModifMedico(_ciM, _especialidad, _numMed)
    End Function

End Class
