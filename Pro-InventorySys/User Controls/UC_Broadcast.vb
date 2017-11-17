Public Class UC_Broadcast

    Dim DABroadcast As New DSItemTableAdapters.POST_TEXTTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RefreshList()

    End Sub
    Sub RefreshList()
        Me.NewsList.DataSource = DABroadcast.SelectNews(getCurrentUserID)
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If Me.NewsList.RowCount >= 1 Then
            If MsgBox("Do you want to delete this news?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DABroadcast.DeleteText(CInt(Me.NewsList.CurrentRow.Cells("TEXT_ID").Value))
                Me.RefreshList()
                Dim FrmMain As New main
                Dim MaxTextID As Long = 0
                MaxTextID = DABroadcast.getMaxID
                FrmMain.lbltest.Text = DABroadcast.SelectByID(MaxTextID).Rows(0).Item("TEXT_DESC").ToString
            End If
        End If
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Dim FrmNews As New News(Me)
        FrmNews.txtnews.Text = Me.NewsList.CurrentRow.Cells("TEXT_DESC").Value
        FrmNews.lblstatus.Text = 2
        FrmNews.ShowDialog()
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim FrmNews As New News(Me)
        FrmNews.lblstatus.Text = 1
        FrmNews.ShowDialog()
    End Sub

    Private Sub btnBroadcast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBroadcast.Click
        If Me.NewsList.RowCount >= 1 Then
            If MsgBox("Do you want to broadcast this news?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim TableMax As New DataTable
                Dim MaxText As String
                Dim CurrentText As String
                Dim CurrentID As Integer = CInt(Me.NewsList.CurrentRow.Cells("TEXT_ID").Value)
                TableMax = DABroadcast.SelectByID(DABroadcast.getMaxID)
                MaxText = TableMax.Rows(0).Item("TEXT_DESC")
                CurrentText = Me.NewsList.CurrentRow.Cells("TEXT_DESC").Value.ToString
                DABroadcast.UpdateText(MaxText, getCurrentUserID, FormatDateTime(Now, DateFormat.ShortDate), CurrentID)
                DABroadcast.UpdateText(CurrentText, getCurrentUserID, FormatDateTime(Now, DateFormat.ShortDate), DABroadcast.getMaxID)
                MsgBox("Your message was broadcasted", MsgBoxStyle.Information)
                Me.RefreshList()
                Dim FrmMain As New main
                Dim MaxTextID As Long = 0
                MaxTextID = DABroadcast.getMaxID
                FrmMain.lbltest.Text = DABroadcast.SelectByID(MaxTextID).Rows(0).Item("TEXT_DESC").ToString
            End If
        End If
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        RefreshList()
    End Sub
End Class
