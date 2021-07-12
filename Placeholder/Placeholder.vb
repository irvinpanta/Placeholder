Public Class Placeholder


    Private Sub Placeholder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Text = "Ingrese Usuario"
        txtPass.Text = "Ingrese Constraseña"
    End Sub


    Private Sub txtUsuario_GotFocus(sender As Object, e As EventArgs) Handles txtUsuario.GotFocus
        eventoGotFocus(e, txtUsuario, "Ingrese Usuario")
    End Sub

    Private Sub txtUsuario_LostFocus(sender As Object, e As EventArgs) Handles txtUsuario.LostFocus
        eventoLostFocus(e, txtUsuario, "Ingrese Usuario")
    End Sub

    Private Sub txtPass_GotFocus(sender As Object, e As EventArgs) Handles txtPass.GotFocus
        eventoGotFocus(e, txtPass, "Ingrese Constraseña")
    End Sub

    Private Sub txtPass_LostFocus(sender As Object, e As EventArgs) Handles txtPass.LostFocus
        eventoLostFocus(e, txtPass, "Ingrese Constraseña")
    End Sub
End Class
