Public Class UC_Chat
    Dim DAChat As New DSItemTableAdapters.CHATTableAdapter
    Private Sub UC_Chat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Timer2.Start()
        Me.CboFrom.SelectedIndex = 0
        ''RefreshList()
    End Sub
    Private Sub RefreshList()
        Dim ChatTable As New DataTable
        If Me.CboFrom.SelectedIndex = 0 Then
            ''From Yesterday
            ChatTable = DAChat.SelectFromDate(FormatDateTime(Now.AddDays(-1), DateFormat.ShortDate))
        ElseIf Me.CboFrom.SelectedIndex = 1 Then
            ChatTable = DAChat.SelectFromDate(FormatDateTime(Now.AddDays(-7), DateFormat.ShortDate))
        ElseIf Me.CboFrom.SelectedIndex = 2 Then
            ChatTable = DAChat.SelectFromDate(FormatDateTime(Now.AddDays(-30), DateFormat.ShortDate))
        ElseIf Me.CboFrom.SelectedIndex = 3 Then
            ChatTable = DAChat.SelectFromDate(FormatDateTime(Now.AddMonths(-3), DateFormat.ShortDate))
        ElseIf Me.CboFrom.SelectedIndex = 4 Then
            ChatTable = DAChat.SelectFromDate(FormatDateTime(Now.AddMonths(-6), DateFormat.ShortDate))
        Else
            ChatTable = DAChat.SelectAllChat
        End If
        Me.ChatList.DataSource = ChatTable
        If ChatList.RowCount >= 1 Then
            Me.ChatList.MoveToRowIndex(Me.ChatList.RowCount - 1)
        End If
    End Sub
    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Dim ChatText As String = Me.txtChat.Text.Replace("'", "''")
        If ChatText = "" Then
            MsgBox("Please enter message", MsgBoxStyle.Information)
            Me.txtChat.Text = ""
            Me.txtChat.Focus()
        Else
            DAChat.InsertChat(ChatText, getCurrentUserID, FormatDateTime(Now, DateFormat.GeneralDate))
            Me.txtChat.Text = ""
            Me.txtChat.Focus()
            RefreshList()
        End If
    End Sub

    Private Sub txtChat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChat.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnSend_Click(sender, e)
            Me.txtChat.Text = ""
        End If
    End Sub

    Private Sub CboFrom_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboFrom.SelectionChangeCommitted
        RefreshList()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        RefreshList()
    End Sub

    Private Sub CboFrom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboFrom.SelectedIndexChanged

    End Sub
End Class
