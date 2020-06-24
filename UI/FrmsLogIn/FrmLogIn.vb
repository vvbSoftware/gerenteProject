﻿Imports System.Runtime.InteropServices
Imports Logic
Public Class FrmLogIn
    ' Las letras In y Es al final de los labels significan Ingles y Español
    Private _languageState As String
    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim gerente As New Gerente(txtUser.Text, txtPass.Text)
        Dim validLogin As Boolean = gerente.ComprobarLogin(gerente)

        If validLogin = True Then
            Dim form As New FrmPrincipal
            form.Show()
            AddHandler form.FormClosed, AddressOf Me.Logout
            Me.Hide()
        Else
            ErrorProvider1.SetError(Me.txtUser, "Nombre de usuario o contraseña INCORRECTOS.")
            'MessageBox.Show("Nombre de usuario o contraseña INCORRECTOS." + vbNewLine + "Por favor intente de nuevo.")
            txtPass.Clear()
            txtPass.Focus()
        End If

    End Sub
    Private Sub Logout(sender As Object, e As FormClosedEventArgs)
        txtUser.Clear()
        txtPass.Clear()
        Me.Show()
        txtUser.Focus()
    End Sub

    Private Sub llbForgotPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbForgotPassIn.LinkClicked, llbForgotPassEs.LinkClicked

    End Sub

    Private Sub btnChangeLanguage_Click(sender As Object, e As EventArgs) Handles btnChangeLanguage.Click
        If txtUser.Text = "USER" Then
            llbForgotPassIn.Visible = False
            txtUser.Text = "USUARIO"
            txtPass.Text = "CONTRASEÑA"
            btnLogin.Text = "INICIAR"
            llbForgotPassEs.Visible = True
            _languageState = "español"
        ElseIf txtUser.Text = "USUARIO" Then
            llbForgotPassEs.Visible = False
            txtUser.Text = "USER"
            txtPass.Text = "PASSWORD"
            btnLogin.Text = "LOGIN"
            llbForgotPassIn.Visible = True
            _languageState = "ingles"
        End If
    End Sub
#Region "Estilisado"
    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles btnLogin.Paint
        BotonRedondeado(btnLogin)
    End Sub
#Region "funcionamiento text area"
    Private Sub txtUser_Enter(sender As Object, e As EventArgs) Handles txtUser.Enter
        With txtUser
            If .Text = "USER" Or .Text = "USUARIO" Then
                .Text = ""
                .ForeColor = Color.FromArgb(240, 240, 240)
            End If
        End With
    End Sub

    Private Sub txtUser_Leave(sender As Object, e As EventArgs) Handles txtUser.Leave
        'si el campo esta vacio lo relleno
        With txtUser
            If .Text = "" Then
                If _languageState = "ingles" Then
                    .Text = "USER"
                Else
                    .Text = "USUARIO"
                End If
                .ForeColor = Color.Silver
            End If
        End With
    End Sub

    Private Sub txtPass_Enter(sender As Object, e As EventArgs) Handles txtPass.Enter
        With txtPass
            If .Text = "PASSWORD" Or .Text = "CONTRASEÑA" Then
                .Text = ""
                .UseSystemPasswordChar = True 'coloco los caracteres de contraseña
                .ForeColor = Color.FromArgb(240, 240, 240)
            End If
        End With
    End Sub

    Private Sub txtPass_Leave(sender As Object, e As EventArgs) Handles txtPass.Leave
        'si el campo esta vacio lo relleno
        With txtPass
            If .Text = "" Then
                If _languageState = "ingles" Then
                    .Text = "PASSWORD"
                Else
                    .Text = "CONTRASEÑA"
                End If
                .UseSystemPasswordChar = False 'quito los caracteres de contraseña para poder ver el texto
                .ForeColor = Color.Silver
            End If
        End With
    End Sub
#End Region 'region estilos text area
#Region "poder mover el form"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub titleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles topPanel.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    'DLLImport,Significa que el método declarado a 
    'continuación no está en .NET, sino en un archivo DLL externo (nativo). 
    'En este caso, se encuentra en el archivo User32.dll, que es un componente 
    'estándar de Windows. El cual nos permite utilizar los eventos/método del sistema 
    'operativo, en este caso capturar las señales del mouse.

#End Region 'region de mover form
#End Region 'region de estilos
End Class
