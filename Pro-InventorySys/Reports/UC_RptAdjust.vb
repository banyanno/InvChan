Public Class UC_RptAdjust
    Dim DAAdjust As New DSItemTableAdapters.ADJUSTMENTTableAdapter
    Sub RefreshList()
        Me.AdjustList.DataSource = DAAdjust.SelectAdjustFrom(FormatDateTime(Now.AddDays(-30), DateFormat.ShortDate))
    End Sub
    Private Sub ToolStrip2_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip2.ItemClicked

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        RefreshList()
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        Dim FrmAdjust As New Search_Adjust(Me)
        FrmAdjust.ShowDialog()
    End Sub
End Class
