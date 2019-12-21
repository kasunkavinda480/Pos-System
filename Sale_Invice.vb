Public Class Sale_Invice
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CrystalReportViewer1.ReportSource = Application.StartupPath + "\Report\Sale_invoice.rpt"
        CrystalReportViewer1.SelectionFormula = "{selling1.Inv_No} = '" & TextBox1.Text.ToString() & "'"
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class