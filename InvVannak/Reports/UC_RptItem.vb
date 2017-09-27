Public Class UC_RptItem
    Dim DAItem As New DSItemTableAdapters.ITEMTableAdapter
    Sub RefreshList()
        Me.ItemList.DataSource = DAItem.SelectItems
    End Sub

    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        Dim ResultTable As New DataTable
        Dim MyReport As New RptItem
        Dim ReportViewer As New Report_Viewer
        ResultTable = DAItem.SelectItems
        MyReport.SetDataSource(ResultTable)
        ReportViewer.CrystalReportViewer1.ReportSource = MyReport
        ReportViewer.ShowDialog()
    End Sub

    Private Sub ToolStrip2_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip2.ItemClicked

    End Sub
End Class
