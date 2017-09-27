Public Class Adjust
    Dim DAAdjust As New DSItemTableAdapters.ADJUSTMENTTableAdapter
    Dim DAReceive As New DSItemTableAdapters.RECEIVETableAdapter
    Dim DAIssue As New DSItemTableAdapters.ISSUETableAdapter
    Dim DAStore As New DSItemTableAdapters.ITEM_STORETableAdapter
    Dim DATransaction As New DSItemTableAdapters.TRANSACTIONTableAdapter
    Dim DAUnit As New DSItemTableAdapters.UNITTableAdapter
    Dim DAItem As New DSItemTableAdapters.ITEMTableAdapter
    Dim DALocation As New DSItemTableAdapters.LOCATIONTableAdapter
    Dim PAdjust As UC_Adjustment

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

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
    Sub New(ByVal MyPanel As UC_Adjustment)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.PAdjust = MyPanel
        ' Add any initialization after the InitializeComponent() call.
        Me.cboItem.DataSource = DAItem.SelectItems
        Me.cboItem.DisplayMember = "ITEM_NAME_CHN"
        Me.cboItem.ValueMember = "ITEM_ID"

        Me.cboUnit.DataSource = DAUnit.SelectUnits
        Me.cboUnit.DisplayMember = "UNIT_NAME_CHN"
        Me.cboUnit.ValueMember = "UNIT_ID"
        CboItem_Changed()
    End Sub

    Sub ClearBox()
        Me.txtAdjustQty.Text = ""
        Me.txtReason.Text = ""
    End Sub

    Private Sub CboItem_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboItem.SelectionChangeCommitted
        CboItem_Changed()
    End Sub
    Sub CboItem_Changed()
        If DAStore.SelectStoreByItemID(Me.cboItem.SelectedValue).Rows.Count >= 1 Then

            Me.cboUnit.DataSource = DAStore.SelectStoreByItemID(CInt(Me.cboItem.SelectedValue))
            Me.cboUnit.DisplayMember = "UNIT_NAME_CHN"
            Me.cboUnit.ValueMember = "UNIT_ID"

            Dim StoreID As Integer = GetStoreID(CInt(Me.cboItem.SelectedValue), CInt(Me.cboUnit.SelectedValue))
            Me.txtcurQty.Text = DAStore.SelectStoreByID(StoreID).Rows(0).Item("ITEM_BALANCE")
            Me.txtAdjustQty.Text = ""
            Me.txtReason.Text = ""
        End If
    End Sub
    Sub CboUnit_Change()
        Me.txtAdjustQty.Text = ""
        Me.txtReason.Text = ""
        Dim StoreID As Integer = GetStoreID(CInt(Me.CboItem.SelectedValue), CInt(Me.CboUnit.SelectedValue))
        Me.txtCurQty.Text = DAStore.SelectStoreByID(StoreID).Rows(0).Item("ITEM_BALANCE")
    End Sub

    Private Sub CboUnit_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboUnit.SelectionChangeCommitted
        CboUnit_Change()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim CurrentBalance As Double
        Dim AdjustBalance As Double
        Dim UpdatedBalance As Double
        Dim MaxReceiveID As Long
        Dim MaxIssueID As Long
        Dim StoreID As Long
        Dim Reason As String = Me.txtReason.Text.Trim.Replace("'", "''")
        If Me.txtAdjustQty.Text = "" Then
            MsgBox("Please enter quantity to adjust", MsgBoxStyle.Information)
            Me.txtAdjustQty.Focus()
            Exit Sub
        Else
            If IsNumeric(Me.txtAdjustQty.Text) = False Then
                MsgBox("Please enter quantity to adjust as number only", MsgBoxStyle.Information)
                Me.txtAdjustQty.Focus()
                Me.txtAdjustQty.SelectAll()
                Exit Sub
            End If
        End If
        CurrentBalance = CDbl(Me.txtcurQty.Text)
        UpdatedBalance = CDbl(Me.txtAdjustQty.Text)
        StoreID = GetStoreID(CInt(Me.cboItem.SelectedValue), CInt(Me.cboUnit.SelectedValue))
        AdjustBalance = UpdatedBalance - CurrentBalance

        If UpdatedBalance > CurrentBalance Then
            '' Receive Store

            '' Add to Receive
            DAReceive.InsertReceive(StoreID, CInt(DALocation.SelectByName("Main Stock").Rows(0).Item("LOCA_ID")), AdjustBalance, CDbl(DAStore.SelectStoreByID(StoreID).Rows(0).Item("LAST_COST")), Reason, FormatDateTime(Now, DateFormat.ShortDate), getCurrentUserID)
            '' Add to Transaction
            MaxReceiveID = DAReceive.getMaxID
            DATransaction.InsertTransaction(StoreID, CurrentBalance, AdjustBalance, UpdatedBalance, MaxReceiveID, 1, CInt(DALocation.SelectByName("Main Stock").Rows(0).Item("LOCA_ID")), FormatDateTime(Now, DateFormat.ShortDate), getCurrentUserID)
            '' Update Store Balance
            DAStore.UpdateBalance(UpdatedBalance, StoreID)
            '' Add to Adjustment
            DAAdjust.InsertAdjust(StoreID, CurrentBalance, UpdatedBalance, Reason, FormatDateTime(Now, DateFormat.ShortDate), getCurrentUserID)
            MsgBox("Item store was adjusted", MsgBoxStyle.Information)

        ElseIf UpdatedBalance < CurrentBalance Then
            '' Issue Store

            '' Add to Issue

            DAIssue.InsertIssue(StoreID, CInt(DALocation.SelectByName("Main Stock").Rows(0).Item("LOCA_ID")), AdjustBalance * (-1), CDbl(DAStore.SelectStoreByID(StoreID).Rows(0).Item("LAST_COST")), Reason, FormatDateTime(Now, DateFormat.ShortDate), getCurrentUserID)
            '' Add to Transaction
            MaxIssueID = DAIssue.getMaxID
            DATransaction.InsertTransaction(StoreID, CurrentBalance, AdjustBalance * (-1), UpdatedBalance, MaxIssueID, 2, CInt(DALocation.SelectByName("Main Stock").Rows(0).Item("LOCA_ID")), FormatDateTime(Now, DateFormat.ShortDate), getCurrentUserID)
            '' Update Store Balance
            DAStore.UpdateBalance(UpdatedBalance, StoreID)
            '' Add to Adjustment
            DAAdjust.InsertAdjust(StoreID, CurrentBalance, UpdatedBalance, Reason, FormatDateTime(Now, DateFormat.ShortDate), getCurrentUserID)
            MsgBox("Item store was adjusted", MsgBoxStyle.Information)
        Else
            MsgBox("Nothing updated", MsgBoxStyle.Information)
        End If
        PAdjust.RefreshList()
    End Sub
End Class