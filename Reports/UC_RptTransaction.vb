Public Class UC_RptTransaction
    Dim DATransaction As New DSItemTableAdapters.TRANSACTIONTableAdapter

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        RefreshList()
    End Sub
    Sub RefreshList()
        Me.TransactionList.DataSource = DATransaction.SelectTransactionFrom(FormatDateTime(Now.AddDays(-30), DateFormat.ShortDate))
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        Dim FrmTransaction As New Search_Transaction(Me)
        FrmTransaction.ShowDialog()
    End Sub
End Class
