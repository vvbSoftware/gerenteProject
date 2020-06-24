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
    Public Function DevolverSintomaComboBox() As DataSet
        Dim consu As New GetSintomas()
        Return consu.DevolverSintomaComboBox()
    End Function
    Public Function GuardarSintomas(obj As Sintoma) As Boolean
        Dim consu As New SetSintomas()
        Return consu.SetSintoma(obj._nombre)
    End Function

    Public Function ModificarSintoma(obj As Sintoma) As Boolean
        Dim consu As New AlterSintomas()
        Return consu.ModifSintomas(obj._nombre)
    End Function

    Public Function BorrarSintoma(dato As String) As Boolean
        Dim consu As New DeleteSintoma()
        Return consu.BorrarSintoma(dato)
    End Function


End Class
