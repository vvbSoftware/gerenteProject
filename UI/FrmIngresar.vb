Public Class FrmIngresar
    Private Sub FrmIngresar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnIngresarSintoma_Click(sender As Object, e As EventArgs) Handles btnIngresarSintoma.Click

    End Sub

    Private Sub btnIngresarEnfermedad_Click(sender As Object, e As EventArgs) Handles btnIngresarEnfermedad.Click

    End Sub

    Private Sub btnIngresarSintoma_Paint(sender As Object, e As PaintEventArgs) Handles btnIngresarSintoma.Paint, btnIngresarEnfermedad.Paint
        BotonRedondeado(btnIngresarEnfermedad)
        BotonRedondeado(btnIngresarSintoma)
    End Sub
End Class