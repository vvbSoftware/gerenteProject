Imports Mysql.Data.MySqlClient
Public Class ConexionBD
    'declaro MustInherits para que no se pueda crear una instancia(objeto) de esta clase
    'cadena de conexion a la bd
    Private connString As String = "server=192.168.1.2;database=mibasededatos;user id=root;password=holahola;port=3306;"
    Private conn As MySqlConnection

    Public Sub New()
        conn = New MySqlConnection(connString)
    End Sub
    Public Sub OpenConnection() 'Metodo para abrir conexion
        conn.Open()
    End Sub

    Public Sub CloseConnection() 'Metodo para cerrar conexion
        conn.Open()
    End Sub

    ' Para ejecutar las consultas
    Public Sub consultaEjecutar(consulta As String)
        Dim commandSQL As New MySqlCommand(consulta, conn)
        Try
            conn.Open()
            commandSQL.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox("ERROR::" & ex.Message)
            conn.Close()
        End Try
    End Sub

    'Para comprobar si el dato a ingresar existe
    Public Function ConsultaComprobarExistencia(consulta As String) As Boolean
        Dim commandSQL As New MySqlCommand(consulta, conn)
        Try
            conn.Open()
            commandSQL.ExecuteNonQuery()
            Dim resultadoSQL As MySqlDataReader = commandSQL.ExecuteReader()

            If resultadoSQL.Read() Then 'Encontro dato return true sino false
                Return True 'La consulta SE ejecuto correctamente
                conn.Close()
            Else
                Return False 'La consulta NO se ejecuto correctamente
                conn.Close()
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("ERROR::" & ex.Message)
            conn.Close()
        End Try
    End Function

    'Para obtener los datos de las tablas y mostrarlos por dataGridView
    Public Function DevolverTabla(consulta As String) As DataTable
        Dim dataTable As New DataTable
        Dim dataSet As New DataSet
        Dim adapter As MySqlDataAdapter

        Try
            adapter = New MySqlDataAdapter(consulta, conn)
            conn.Open()
            adapter.Fill(dataSet)
            dataTable = dataSet.Tables(0)
            conn.Close()
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
            conn.Close()
        End Try
        Return dataTable
    End Function

End Class
