Public Class UC_Adjustment
    Dim DAAdjust As New DSItemTableAdapters.ADJUSTMENTTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RefreshList()
    End Sub
    Sub RefreshList()
        Me.AdjustList.DataSource = DAAdjust.SelectAdjustFrom(FormatDateTime(Now.AddDays(-30), DateFormat.ShortDate))
    End Sub
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim FrmAdjust As New Adjust(Me)
        FrmAdjust.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        RefreshList()
    End Sub
End Class
