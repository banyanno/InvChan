Public Class UC_Receive
    Dim DAReceive As New DSItemTableAdapters.RECEIVETableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RefreshList()
    End Sub
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim FrmReceive As New Receive(Me)
        FrmReceive.ShowDialog()
    End Sub
    Sub RefreshList()
        Me.ReceiveList.DataSource = DAReceive.SelectReceiveFrom(FormatDateTime(Now.AddDays(-30), DateFormat.ShortDate))
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        RefreshList()
    End Sub

    Private Sub ToolStrip2_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip2.ItemClicked

    End Sub
End Class
