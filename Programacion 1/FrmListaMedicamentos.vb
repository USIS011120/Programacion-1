﻿Public Class FrmListaMedicamentos
    Private Sub FrmListaMedicamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dsMedicamentos.medicamento' Puede moverla o quitarla según sea necesario.
        Me.medicamentoTableAdapter.Fill(Me.dsMedicamentos.medicamento)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class