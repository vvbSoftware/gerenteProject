Public Class FrmPrincipal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'cierro totalmente la app
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        'log out
    End Sub
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        OpenChildForm(New FrmIngresar, PanelChildForm)
    End Sub

    Private Sub btnIngresarMedico_Click(sender As Object, e As EventArgs) Handles btnIngresarMedico.Click
        OpenChildForm(New FrmMedico, PanelChildForm)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        OpenChildForm(New FrmModificar, PanelChildForm)
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        OpenChildForm(New FrmEliminar, PanelChildForm)
    End Sub
End Class