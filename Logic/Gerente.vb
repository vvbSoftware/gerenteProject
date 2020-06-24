Imports DataAccess
Public Class Gerente
    Inherits Persona

    Protected _password As String

    Public Sub New(ci As String, password As String)
        MyBase.New(ci)
        _password = password
    End Sub


    Public Function ComprobarLogin(gerente As Gerente) As Boolean
        Dim log As New Login
        Return log.Login(gerente._ci, gerente._password)
    End Function

End Class
