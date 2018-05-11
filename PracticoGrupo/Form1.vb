Public Class VentanaPrincipal
    Private Sub btnJuegoTelefonos_Click(sender As Object, e As EventArgs) Handles btnJuegoTelefonos.Click
        Juego_de_telefonos.ShowDialog()
    End Sub

    Private Sub btnHorasTrabajadas_Click(sender As Object, e As EventArgs) Handles btnHorasTrabajadas.Click
        HorasTrabajadas.ShowDialog()
    End Sub
End Class
