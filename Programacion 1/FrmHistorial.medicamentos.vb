﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'sistemaclinicodbDataSet.encargar_medicamento' Puede moverla o quitarla según sea necesario.
        Me.encargar_medicamentoTableAdapter.Fill(Me.sistemaclinicodbDataSet.encargar_medicamento)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class