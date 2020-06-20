Imports Logic
Public Class FrmIngresar
    Private Sub FrmIngresar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnIngresarSintoma_Click(sender As Object, e As EventArgs) Handles btnIngresarSintoma.Click
        Dim sintoma As Sintoma
        Dim sintomaIngresar As String = txtNombreSintoma.Text

        If sintomaIngresar = "Nombre" Then
            MsgBox("DebeIngresar un nombre")
        Else
            'guardo el nombre del sintoma en una instacia
            'para no tener que pasarlo por parametro
            sintoma = New Sintoma(sintomaIngresar)
            If sintoma.GuardarSintomas() Then
                MsgBox("Ya existe ese sintoma")
            Else
                MsgBox("Se guardo con exito")
            End If
        End If
    End Sub

    Private Sub btnIngresarEnfermedad_Click(sender As Object, e As EventArgs) Handles btnIngresarEnfermedad.Click
        Dim enfermedad As Enfermedad
        Dim enfermedadIngresar As String = txtNombreEnfermedad.Text
        Dim riesgo As String = cbRiesgo.Text
        Dim descripcion As String = txtDescripcion.Text

        If enfermedadIngresar = "Nombre" Or riesgo = "Riesgo" Or descripcion = "Descripcion" Then
            MsgBox("Los campos Nombre, Riesgo y Descripcion son obligatorios")
        Else
            'guardo el nombre del sintoma en una instacia
            'para no tener que pasarlo por parametro
            enfermedad = New Enfermedad(enfermedadIngresar, riesgo, descripcion)

            If enfermedad.GuardarEnfermedad() Then
                MsgBox("Ya existe ese sintoma")
            Else
                MsgBox("Se guardo con exito")
            End If
        End If
    End Sub

#Region "Estilos"
    Private Sub btnIngresarSintoma_Paint(sender As Object, e As PaintEventArgs) Handles btnIngresarSintoma.Paint, btnIngresarEnfermedad.Paint
        BotonRedondeado(btnIngresarEnfermedad)
        BotonRedondeado(btnIngresarSintoma)
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles txtNombreEnfermedad.Enter, txtDescripcion.Enter
        txtNombreEnfermedad.Text = ""
        txtNombreEnfermedad.ForeColor = Color.FromArgb(240, 240, 240)
    End Sub
    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles txtNombreSintoma.Enter
        txtNombreSintoma.Text = ""
        txtNombreSintoma.ForeColor = Color.FromArgb(240, 240, 240)
    End Sub
    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles txtNombreSintoma.Leave, txtNombreEnfermedad.Leave, txtDescripcion.Leave
        txtNombreSintoma.Text = "Nombre"
        txtNombreSintoma.ForeColor = Color.FromArgb(240, 240, 240)
        txtNombreEnfermedad.Text = "Nombre"
        txtNombreEnfermedad.ForeColor = Color.FromArgb(240, 240, 240)
    End Sub
#End Region
End Class