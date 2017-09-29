Public Class UC_Issue
    Dim DAIssue As New DSItemTableAdapters.ISSUETableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RefreshList()
    End Sub
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim FrmIssue As New Issue(Me)
        FrmIssue.ShowDialog()
    End Sub
    Sub RefreshList()
        ''Me.IssueList.DataSource = DAIssue.SelectIssueFrom(FormatDateTime(Now.AddDays(-30), DateFormat.ShortDate))
    End Sub

    Private Sub ToolStrip2_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip2.ItemClicked

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        RefreshList()
    End Sub
End Class
