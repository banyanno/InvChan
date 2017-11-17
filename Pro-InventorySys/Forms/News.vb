Public Class News

    Dim DABroadcast As New DSItemTableAdapters.POST_TEXTTableAdapter
    Dim PBroadcast As UC_Broadcast
    'Declare the variables

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Sub New(ByVal MyPanel As UC_Broadcast)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.PBroadcast = MyPanel

    End Sub

    Private Sub lblHeader_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblHeader.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub lblHeader_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblHeader.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub lblHeader_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblHeader.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim news As String = Me.txtnews.Text.Trim.Replace("'", "''")
        If news = "" Then
            MsgBox("Please enter news", MsgBoxStyle.Information)
            Me.txtnews.Focus()
            Exit Sub
        End If
        If Me.lblstatus.Text = 1 Then
            ''INSERT
            DABroadcast.InsertText(news, getCurrentUserID, FormatDateTime(Now, DateFormat.ShortDate))
            MsgBox("News was added", MsgBoxStyle.Information)
            ClearBox()
            PBroadCast.RefreshList()
            Me.txtnews.Focus()
        Else
        ''UPDATE
            DABroadcast.UpdateText(news, getCurrentUserID, FormatDateTime(Now, DateFormat.ShortDate), CLng(PBroadcast.NewsList.CurrentRow.Cells("TEXT_ID").Value))
            MsgBox("News was updated", MsgBoxStyle.Information)
            PBroadcast.RefreshList()
            ClearBox()
            Me.Close()
        End If
        Dim FrmMain As New main
        Dim MaxTextID As Long = 0
        MaxTextID = DABroadcast.getMaxID
        FrmMain.lbltest.Text = DABroadcast.SelectByID(MaxTextID).Rows(0).Item("TEXT_DESC").ToString
    End Sub
    Sub ClearBox()
        Me.txtnews.Text = ""
    End Sub
End Class