Public Class FrmModificar
    Private Sub FrmModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnFiltrar_Paint(sender As Object, e As PaintEventArgs) Handles btnFiltrar.Paint
        BotonRedondeado(btnFiltrar)
    End Sub

    Private Sub cbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltro.SelectedIndexChanged

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Select Case cbFiltro.Text
            Case "Sintomas"
                PanelModSintoma.Visible = True
                PanelModifMedico.Visible = False
                PanelModEnfermedad.Visible = False
            Case "Medicos"
                PanelModifMedico.Visible = True
                PanelModSintoma.Visible = False
                PanelModEnfermedad.Visible = False
            Case "Enfermedades"
                PanelModEnfermedad.Visible = True
                PanelModSintoma.Visible = False
                PanelModifMedico.Visible = False
        End Select
    End Sub
End Class