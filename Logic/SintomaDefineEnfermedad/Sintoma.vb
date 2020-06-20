Imports DataAccess
Public Class Sintoma
    Property _nombre As String

    Public Sub New()
    End Sub

    Public Sub New(nombre As String)
        _nombre = nombre
    End Sub

    Public Function ObtenerSintomas() As DataTable
        Dim consu As New GetSintomas()
        Return consu.ObtenerSintomas()
    End Function

    Public Function GuardarSintomas() As Boolean
        Dim consu As New SetSintomas()
        Return consu.SetSintoma(_nombre)
    End Function

    Public Function ModificarSintoma() As Boolean
        Dim consu As New AlterSintomas()
        Return consu.ModifSintomas(_nombre)
    End Function


End Class
