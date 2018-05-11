Public Class HorasTrabajadas
    Private Sub HorasTrabajadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Adherir_Validacion(txtHorasTrabajadas, TipoValidacion.Solo_numeros)
    End Sub
    Private Function Calcular(cant_horas As Integer) As String
        If cant_horas < 161 Then
            Return (cant_horas * 6.5).ToString()
        Else
            Return "$ " & ((160 * 6.5) + ((cant_horas - 160) * 7.5)).ToString()
        End If
    End Function

    Private Sub txtHorasTrabajadas_TextChanged(sender As Object, e As EventArgs) Handles txtHorasTrabajadas.TextChanged
        lblSueldoResultado.Text = Calcular(Val(sender.Text))
    End Sub
End Class