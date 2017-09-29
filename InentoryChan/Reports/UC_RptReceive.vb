Public Class UC_RptReceive

    Dim DAReceive As New DSItemTableAdapters.RECEIVETableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RefreshList()
    End Sub
    Sub RefreshList()
        Me.ReceiveList.DataSource = DAReceive.SelectReceiveFrom(FormatDateTime(Now.AddDays(-30), DateFormat.ShortDate))
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        RefreshList()
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        Dim FrmSearchReceive As New Search_Receive(Me)
        FrmSearchReceive.ShowDialog()
    End Sub
End Class
