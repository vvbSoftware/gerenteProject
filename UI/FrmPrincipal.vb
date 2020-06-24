Public Class FrmPrincipal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        If MessageBox.Show("Seguro que desa salir?", "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click

    End Sub
End Class