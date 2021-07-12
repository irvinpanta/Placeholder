Module Metodos

    Public Sub eventoGotFocus(ByVal e As System.EventArgs, caja As TextBox, texto As String)
        If caja.Text = texto Then
            caja.ForeColor = Color.Black
            caja.Text = ""
        End If
    End Sub

    Public Sub eventoLostFocus(ByVal e As System.EventArgs, caja As TextBox, texto As String)
        If caja.Text = Nothing Then
            caja.ForeColor = Color.Gray
            caja.Text = texto
        End If
    End Sub

End Module
