Public Class frmConsulta
    Dim servicio As New ServiceReference1.WebService1SoapClient
    Private Sub btnSalir2_Click(sender As Object, e As EventArgs) Handles btnSalir2.Click
        Close()
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim lista As DataSet = servicio.Listar()
        dgvSunat.DataSource = lista.Tables(0)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim texto = Convert.ToString(txtTexto)
        Dim Criterio = Convert.ToString(cmbCriterio)
        If (Criterio = "Ruc") Then
            Dim buscar = servicio.Buscar(texto, Criterio)
            dgvSunat.DataSource = buscar.Tables(0)
        End If


    End Sub
End Class