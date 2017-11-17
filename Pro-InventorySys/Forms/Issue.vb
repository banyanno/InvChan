Public Class Issue

    Dim DAIssue As New DSItemTableAdapters.ISSUETableAdapter
    Dim DAPreIssue As New DSItemTableAdapters.PRE_ISSUETableAdapter
    Dim DAStore As New DSItemTableAdapters.ITEM_STORETableAdapter
    Dim DATransaction As New DSItemTableAdapters.TRANSACTIONTableAdapter
    Dim DAUnit As New DSItemTableAdapters.UNITTableAdapter
    Dim DAItem As New DSItemTableAdapters.ITEMTableAdapter
    Dim DALocation As New DSItemTableAdapters.LOCATIONTableAdapter
    Dim PIssue As UC_Issue

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
    Sub New(ByVal MyPanel As UC_Issue)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.PIssue = MyPanel
        ' Add any initialization after the InitializeComponent() call.
        Me.RefreshList()
        Me.cboItem.DataSource = DAItem.SelectItems
        Me.cboItem.DisplayMember = "ITEM_NAME_CHN"
        Me.cboItem.ValueMember = "ITEM_ID"

        Me.cboUnit.DataSource = DAUnit.SelectUnits
        Me.cboUnit.DisplayMember = "UNIT_NAME_CHN"
        Me.cboUnit.ValueMember = "UNIT_ID"

        Me.cboTo.DataSource = DALocation.SelectByNot("Main Stock", "")
        Me.cboTo.DisplayMember = "LOCA_NAME"
        Me.cboTo.ValueMember = "LOCA_ID"
        CboItem_Changed()
    End Sub
    Sub RefreshList()
        Me.IssueList.DataSource = DAPreIssue.SelectIssueByUserID(getCurrentUserID)
    End Sub

    Sub ClearBox()
        Me.txtIQty.Text = ""
        Me.txtReason.Text = ""
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub CboItem_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboItem.SelectionChangeCommitted
        CboItem_Changed()
        Me.txtIQty.Focus()
    End Sub
    Sub CboItem_Changed()
        Me.CboUnit.DataSource = DAStore.SelectStoreByItemID(CInt(Me.CboItem.SelectedValue))
        Me.CboUnit.DisplayMember = "UNIT_NAME_CHN"
        Me.CboUnit.ValueMember = "UNIT_ID"

        Me.txtIQty.Text = ""
        Me.txtReason.Text = ""
        If DAStore.SelectStoreID(CInt(Me.cboItem.SelectedValue), CInt(Me.cboUnit.SelectedValue)).Rows.Count >= 1 Then
            Dim StoreID As Integer = GetStoreID(CInt(Me.cboItem.SelectedValue), CInt(Me.cboUnit.SelectedValue))
            Me.txtCurQty.Text = DAStore.SelectStoreByID(StoreID).Rows(0).Item("ITEM_BALANCE")
            Me.txtLastCost.Text = DAStore.SelectStoreByID(StoreID).Rows(0).Item("ITEM_BALANCE")
            Me.txtRatio.Text = DAStore.SelectStoreByID(StoreID).Rows(0).Item("RATIO_QTY")
            Me.txtLastCost.Text = DAStore.SelectStoreByID(StoreID).Rows(0).Item("LAST_PRICE")
        End If
        Dim ItemTable As New DataTable
        ItemTable = DAItem.SelectItemByID(CInt(Me.cboItem.SelectedValue))
        If IsDBNull(ItemTable.Rows(0).Item("ITEM_IMAGE")) = False Then
            Dim MS As New IO.MemoryStream(CType(ItemTable.Rows(0).Item("ITEM_IMAGE"), Byte()))
            Dim img As Image = Image.FromStream(MS)
            Me.PicItem.Image = img
        End If
    End Sub
    Sub CboUnit_Change()
        Me.txtIQty.Text = ""
        Me.txtReason.Text = ""
        If DAStore.SelectStoreID(CInt(Me.cboItem.SelectedValue), CInt(Me.cboUnit.SelectedValue)).Rows.Count >= 1 Then
            Dim StoreID As Integer = GetStoreID(CInt(Me.cboItem.SelectedValue), CInt(Me.cboUnit.SelectedValue))
            Me.txtCurQty.Text = DAStore.SelectStoreByID(StoreID).Rows(0).Item("ITEM_BALANCE")
            Me.txtLastCost.Text = DAStore.SelectStoreByID(StoreID).Rows(0).Item("ITEM_BALANCE")
            Me.txtRatio.Text = DAStore.SelectStoreByID(StoreID).Rows(0).Item("RATIO_QTY")
            Me.txtLastCost.Text = DAStore.SelectStoreByID(StoreID).Rows(0).Item("LAST_PRICE")
        End If
    End Sub

    Private Sub CboUnit_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboUnit.SelectionChangeCommitted
        CboUnit_Change()
        Me.txtIQty.Focus()
    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Me.txtIQty.Text = "" Then
            MsgBox("Please enter Issue Qty", MsgBoxStyle.Information)
            Me.txtIQty.Focus()
            Exit Sub
        End If
        If Me.txtLastCost.Text = "" Then
            MsgBox("Please enter Price", MsgBoxStyle.Information)
            Me.txtLastCost.Focus()
            Exit Sub
        End If
        If IsNumeric(Me.txtIQty.Text) = False Then
            MsgBox("Please enter Issue Qty as number only", MsgBoxStyle.Information)
            Me.txtIQty.Focus()
            Me.txtIQty.SelectAll()
            Exit Sub
        End If
        If IsNumeric(Me.txtLastCost.Text) = False Then
            MsgBox("Please enter price as number only", MsgBoxStyle.Information)
            Me.txtLastCost.Focus()
            Me.txtLastCost.SelectAll()
            Exit Sub
        End If
        If Me.txtRatio.Text = 1 Then
            If CDbl(Me.txtIQty.Text) > CDbl(Me.txtCurQty.Text) Then
                MsgBox("Sorry, the current quantity of this item is not sufficient to issue.", MsgBoxStyle.Information)
                Me.txtIQty.Focus()
                Me.txtIQty.SelectAll()
                Exit Sub
            End If
        Else
            If CDbl(Me.txtIQty.Text) >= CDbl(Me.txtRatio.Text) Then
                MsgBox("The quantity to issue for this item can not be equal or greater than " & CDbl(Me.txtRatio.Text), MsgBoxStyle.Information)
                Me.txtIQty.Focus()
                Me.txtIQty.SelectAll()
                Exit Sub
            End If
            If GetMainStoreQty(CInt(Me.cboItem.SelectedValue)) <= 0 Then
                MsgBox("Sorry, the current quantity of this item is not sufficient to issue.", MsgBoxStyle.Information)
                Me.txtIQty.Focus()
                Me.txtIQty.SelectAll()
                Exit Sub
            End If
        End If
        If DAStore.SelectStoreID(CInt(Me.cboItem.SelectedValue), CInt(Me.cboUnit.SelectedValue)).Rows.Count <= 0 Then
            MsgBox("There is no store for this item, please add its store first.", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim StoreID As Integer = GetStoreID(CInt(Me.cboItem.SelectedValue), CInt(Me.cboUnit.SelectedValue))
        Dim LocationID As Integer = CInt(Me.cboTo.SelectedValue)
        Dim IQty As Double = CDbl(Me.txtIQty.Text)
        Dim Reason As String = Me.txtReason.Text.Trim.Replace("'", "''")
        Dim Cost As Double = CDbl(Me.txtLastCost.Text)
        DAPreIssue.InsertIssue(StoreID, LocationID, IQty, Cost, Reason, Me.dtIssueDate.Value, getCurrentUserID)
        RefreshList()
        CalculateAmount()
        If Me.chkBarcode.Checked = True Then
            Me.txtBarcode.Text = ""
            Me.txtBarcode.Focus()
        End If
    End Sub
    Sub CalculateAmount()
        Dim Total As Double = 0
        If Me.IssueList.RowCount >= 1 Then
            For i As Integer = 0 To IssueList.RowCount - 1
                Total = Total + CDbl(Me.IssueList.GetRow(i).Cells("AMOUNT").Value)
            Next
        End If
        Me.txttotal.Text = FormatCurrency(Total, 2)
    End Sub
    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If Me.IssueList.RowCount >= 1 Then
            DAPreIssue.DeleteIssue(IssueList.CurrentRow.Cells("ISSU_ID").Value)
            RefreshList()
            CalculateAmount()
        End If
        If Me.chkBarcode.Checked = True Then
            Me.txtBarcode.Text = ""
            Me.txtBarcode.Focus()
        End If
    End Sub

    Private Sub btnClearList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearList.Click
        If Me.IssueList.RowCount >= 1 Then
            If MsgBox("Do you want to clear data in the list below?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DAPreIssue.DeleteAllIssueByUserID(getCurrentUserID)
                RefreshList()
                Me.txttotal.Text = 0
            End If
        End If
        If Me.chkBarcode.Checked = True Then
            Me.txtBarcode.Text = ""
            Me.txtBarcode.Focus()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim DAReceive As New DSItemTableAdapters.RECEIVETableAdapter
        If IssueList.RowCount >= 1 Then
            Dim UpdatedBalance As Double
            Dim CurrentBalance As Double
            Dim IssueBalance As Double
            Dim RatioQty As Integer
            Dim MaxIssueID As Long
            Dim MaxReceiveID As Long
            Dim PreIssueTable As New DataTable
            Dim MainStoreID As Integer
            Dim MainStoreQty As Double
            Dim UnitID As Integer
            Dim ItemID As Integer
            PreIssueTable = DAPreIssue.SelectIssueByUserID(getCurrentUserID)
            For i As Integer = 0 To PreIssueTable.Rows.Count - 1
                ItemID = CInt(DAStore.SelectStoreByID(PreIssueTable.Rows(i).Item("STOR_ID")).Rows(0).Item("ITEM_ID"))
                UnitID = CInt(DAStore.SelectStoreByID(PreIssueTable.Rows(i).Item("STOR_ID")).Rows(0).Item("UNIT_ID"))
                RatioQty = CInt(DAStore.SelectStoreByID(PreIssueTable.Rows(i).Item("STOR_ID")).Rows(0).Item("RATIO_QTY"))
                CurrentBalance = CDbl(DAStore.SelectStoreByID(PreIssueTable.Rows(i).Item("STOR_ID")).Rows(0).Item("ITEM_BALANCE"))
                IssueBalance = CDbl(PreIssueTable.Rows(i).Item("ISSU_QTY"))
                UpdatedBalance = CurrentBalance - IssueBalance
                ''Check If SubStore and Issue Qty is greater than the CurrentBalance (Case 1)
                If RatioQty > 1 And IssueBalance > CurrentBalance Then
                    ''Withdraw 1 From MainStore Quantity
                    MainStoreID = GetMainStoreID(ItemID)
                    MainStoreQty = GetMainStoreQty(ItemID)
                    ''Update MainStore and SubStore Balance
                    DAStore.UpdateBalance(MainStoreQty - 1, MainStoreID)
                    DAStore.UpdateBalance(CurrentBalance + RatioQty, CInt(PreIssueTable.Rows(i).Item("STOR_ID")))
                    ''Record as Issue To Current Store (5=Current)

                    DAIssue.InsertIssue(MainStoreID, 5, 1, CDbl(DAStore.SelectStoreByID(MainStoreID).Rows(0).Item("LAST_COST")), "Add to current substore", FormatDateTime(Now, DateFormat.ShortDate), getCurrentUserID)
                    ''Record as Receive From Current Store (5=Current)
                    DAReceive.InsertReceive(CInt(PreIssueTable.Rows(i).Item("STOR_ID")), 5, RatioQty, CDbl(PreIssueTable.Rows(i).Item("ISSU_COST")), "Receive from current mainstore", FormatDateTime(Now, DateFormat.ShortDate), getCurrentUserID)
                    ' Add to Transaction as Issue
                    MaxIssueID = DAIssue.getMaxID
                    DATransaction.InsertTransaction(MainStoreID, MainStoreQty, 1, MainStoreQty - 1, MaxIssueID, 2, 5, FormatDateTime(Now, DateFormat.ShortDate), getCurrentUserID)
                    ' Add to Transaction as Receive
                    MaxReceiveID = DAReceive.getMaxID
                    DATransaction.InsertTransaction(PreIssueTable.Rows(i).Item("STOR_ID"), CurrentBalance, RatioQty, CurrentBalance + RatioQty, MaxReceiveID, 1, 5, FormatDateTime(Now, DateFormat.ShortDate), getCurrentUserID)

                End If
                ' Add to Issue
                DAIssue.InsertIssue(PreIssueTable.Rows(i).Item("STOR_ID"), PreIssueTable.Rows(i).Item("LOCA_ID"), IssueBalance, CDbl(PreIssueTable.Rows(i).Item("ISSU_COST")), PreIssueTable.Rows(i).Item("ISSU_REASON"), PreIssueTable.Rows(i).Item("ISSU_DATE"), PreIssueTable.Rows(i).Item("USER_ID"))
                ' Refresh Balance if in Case 1
                CurrentBalance = CDbl(DAStore.SelectStoreByID(PreIssueTable.Rows(i).Item("STOR_ID")).Rows(0).Item("ITEM_BALANCE"))
                UpdatedBalance = CurrentBalance - IssueBalance
                ' Add to Transaction
                MaxIssueID = DAIssue.getMaxID
                DATransaction.InsertTransaction(PreIssueTable.Rows(i).Item("STOR_ID"), CurrentBalance, IssueBalance, UpdatedBalance, MaxIssueID, 2, CInt(PreIssueTable.Rows(i).Item("LOCA_ID")), FormatDateTime(Now, DateFormat.ShortDate), getCurrentUserID)
                ' Update Store Balance
                DAStore.UpdateBalance(UpdatedBalance, PreIssueTable.Rows(i).Item("STOR_ID"))
            Next
            DAPreIssue.DeleteAllIssueByUserID(getCurrentUserID)
            PIssue.RefreshList()
            MsgBox("Items was issued", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub

    Private Sub cboItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboItem.SelectedIndexChanged

    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim ResultTable As New DataTable
        Dim MyReport As New RptPreIssue
        Dim ReportViewer As New Report_Viewer
        ResultTable = DAPreIssue.SelectIssueByUserID(getCurrentUserID)
        If ResultTable.Rows.Count >= 1 Then
            MyReport.SetDataSource(ResultTable)
            ReportViewer.CrystalReportViewer1.ReportSource = MyReport
            ReportViewer.ShowDialog()
        Else
            MsgBox("No record to preview", MsgBoxStyle.Information)
        End If
        If Me.chkBarcode.Checked = True Then
            Me.txtBarcode.Text = ""
            Me.txtBarcode.Focus()
        End If
    End Sub

    Private Sub cboUnit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUnit.SelectedIndexChanged

    End Sub

    Private Sub txtIQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIQty.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnAdd_Click(sender, e)
        End If
    End Sub

    Private Sub txtLastCost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLastCost.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnAdd_Click(sender, e)
        End If
    End Sub

    Private Sub cboTo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTo.SelectedIndexChanged

    End Sub

    Private Sub cboTo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTo.SelectionChangeCommitted
        Me.txtIQty.Focus()
    End Sub

    Private Sub chkBarcode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBarcode.CheckedChanged
        If Me.chkBarcode.Checked Then
            Me.txtBarcode.Visible = True
            Me.txtBarcode.Text = ""
            Me.txtBarcode.Focus()
            Me.cboItem.Enabled = False
            Me.cboUnit.Enabled = False
        Else
            Me.txtBarcode.Visible = False
            Me.cboItem.Enabled = True
            Me.cboUnit.Enabled = True
        End If
    End Sub

    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        If Me.txtBarcode.Text <> "" Then
            If Asc(e.KeyChar) = 13 Then
                If DAItem.ExistingBarcode(Me.txtBarcode.Text) >= 1 Then
                    Dim ItemTable As New DataTable
                    ItemTable = DAItem.SelectItemByBarcode(Me.txtBarcode.Text)
                    Me.cboItem.SelectedValue = ItemTable.Rows(0).Item("ITEM_ID")
                    CboItem_Changed()
                    Me.txtIQty.Focus()
                Else
                    MsgBox("No such item barcode, please try again", MsgBoxStyle.Exclamation)
                    Me.txtBarcode.Focus()
                    Me.txtBarcode.SelectAll()
                End If
            End If
        End If
    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged

    End Sub

    Private Sub txtIQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIQty.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class