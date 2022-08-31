Public Class Form1
    Private Sub btnSalir1_Click(sender As Object, e As EventArgs) Handles btnSalir1.Click
        Close()
    End Sub

    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        frmConsulta.Show()
        Me.Hide()
    End Sub
End Class
