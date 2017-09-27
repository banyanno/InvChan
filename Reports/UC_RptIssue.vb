Public Class UC_RptIssue
    Dim DAIssue As New DSItemTableAdapters.ISSUETableAdapter
    Sub RefreshList()
        Me.IssueList.DataSource = DAIssue.SelectIssueFrom(FormatDateTime(Now.AddDays(-30), DateFormat.ShortDate))
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        RefreshList()
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        Dim FrmIssue As New Search_Issue(Me)
        FrmIssue.ShowDialog()
    End Sub
End Class
