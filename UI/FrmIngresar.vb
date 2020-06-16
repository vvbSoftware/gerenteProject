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

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        TextBox1.Text = ""
        TextBox1.ForeColor = Color.FromArgb(240, 240, 240)
    End Sub
    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        TextBox2.Text = ""
        TextBox2.ForeColor = Color.FromArgb(240, 240, 240)
    End Sub
    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave, TextBox1.Leave
        TextBox2.Text = "Nombre"
        TextBox2.ForeColor = Color.FromArgb(240, 240, 240)
        TextBox1.Text = "Nombre"
        TextBox1.ForeColor = Color.FromArgb(240, 240, 240)
    End Sub
End Class