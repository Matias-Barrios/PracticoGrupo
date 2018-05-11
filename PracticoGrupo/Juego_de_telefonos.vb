Public Class Juego_de_telefonos
    Private Sub Juego_de_telefonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Adherir_Validacion(txtTel1, TipoValidacion.Solo_numeros)
        Adherir_Validacion(txtTel2, TipoValidacion.Solo_numeros)
        Adherir_Validacion(txtTel3, TipoValidacion.Solo_numeros)
        Adherir_Validacion(txtTel4, TipoValidacion.Solo_numeros)
        Adherir_Validacion(txtTel5, TipoValidacion.Solo_numeros)
    End Sub
    Public Function Seleccionar_Ganador(numeros As Array) As String
        Return numeros(CInt(Math.Ceiling(Rnd() * numeros.Length)))
    End Function

    Private Sub btnSeleccionarGanador_Click(sender As Object, e As EventArgs) Handles btnSeleccionarGanador.Click
        If Not String.IsNullOrEmpty(txtTel1.Text & txtTel2.Text & txtTel3.Text & txtTel4.Text & txtTel5.Text) Then
            MsgBox("El ganador es  " & Seleccionar_Ganador({txtTel1.Text, txtTel2.Text, txtTel3.Text, txtTel4.Text, txtTel5.Text}))
        Else
            MsgBox("No puede haber numeros vacios!!")
        End If
    End Sub
End Class