﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaMedicamentos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dsMedicamentos = New Programacion_1.dsMedicamentos()
        Me.medicamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.medicamentoTableAdapter = New Programacion_1.dsMedicamentosTableAdapters.medicamentoTableAdapter()
        CType(Me.dsMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.medicamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "dsListamedicamentos"
        ReportDataSource1.Value = Me.medicamentoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Programacion_1.ifmListaMedicamentos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(49, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(712, 470)
        Me.ReportViewer1.TabIndex = 0
        '
        'dsMedicamentos
        '
        Me.dsMedicamentos.DataSetName = "dsMedicamentos"
        Me.dsMedicamentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'medicamentoBindingSource
        '
        Me.medicamentoBindingSource.DataMember = "medicamento"
        Me.medicamentoBindingSource.DataSource = Me.dsMedicamentos
        '
        'medicamentoTableAdapter
        '
        Me.medicamentoTableAdapter.ClearBeforeFill = True
        '
        'FrmListaMedicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 494)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmListaMedicamentos"
        Me.Text = "Lista de Medicamentos"
        CType(Me.dsMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.medicamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents medicamentoBindingSource As BindingSource
    Friend WithEvents dsMedicamentos As dsMedicamentos
    Friend WithEvents medicamentoTableAdapter As dsMedicamentosTableAdapters.medicamentoTableAdapter
End Class