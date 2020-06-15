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
        OpenChildForm(New FrmIngresar)
    End Sub

    Private Sub btnIngresarMedico_Click(sender As Object, e As EventArgs) Handles btnIngresarMedico.Click

    End Sub

    Private currentForm As Form = Nothing 'form en el panel no esta visible porque es el inicio de la app
    'Metodo para abrir ventanas dentro de la principal
    Public Sub OpenChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close() 'prenguto si hay un form abierto
        currentForm = childForm 'cargo el form que quiero abrir
        'Le pongo los estilos que necesito
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        'muestro el form
        childForm.BringToFront()
        childForm.Show()
    End Sub
End Class