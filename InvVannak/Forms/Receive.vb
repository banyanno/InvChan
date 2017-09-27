Public Class Receive
    Dim DAReceive As New DSItemTableAdapters.RECEIVETableAdapter
    Dim DAPreReceive As New DSItemTableAdapters.PRE_RECEIVETableAdapter
    Dim DAStore As New DSItemTableAdapters.ITEM_STORETableAdapter
    Dim DATransaction As New DSItemTableAdapters.TRANSACTIONTableAdapter
    Dim DAUnit As New DSItemTableAdapters.UNITTableAdapter
    Dim DACategory As New DSItemTableAdapters.CATEGORYTableAdapter
    Dim DAItem As New DSItemTableAdapters.ITEMTableAdapter
    Dim DALocation As New DSItemTableAdapters.LOCATIONTableAdapter
    Dim PReceive As UC_Receive

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
    Sub New(ByVal MyPanel As UC_Receive)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.PReceive = MyPanel
        ' Add any initialization after the InitializeComponent() call.
        Me.RefreshList()

        Me.cboCategory.DataSource = DACategory.SelectCategories
        Me.cboCategory.DisplayMember = "CATE_NAME_CHN"
        Me.cboCategory.ValueMember = "CATE_ID"

        Me.CboItem.DataSource = DAItem.SelectItems
        Me.CboItem.DisplayMember = "ITEM_NAME_CHN"
        Me.CboItem.ValueMember = "ITEM_ID"

        Me.CboUnit.DataSource = DAUnit.SelectUnits
        Me.CboUnit.DisplayMember = "UNIT_NAME_CHN"
        Me.CboUnit.ValueMember = "UNIT_ID"

        Me.CboFrom.DataSource = DALocation.SelectByNot("Main Stock", "")
        Me.CboFrom.DisplayMember = "LOCA_NAME"
        Me.CboFrom.ValueMember = "LOCA_ID"
        CboItem_Changed()
    End Sub
    Sub RefreshList()
        Me.ReceiveList.DataSource = DAPreReceive.SelectReceiveByUserID(getCurrentUserID)
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If Me.txtRQty.Text = "" Then
            MsgBox("Please enter quantity", MsgBoxStyle.Information)
            Me.txtRQty.Focus()
            Exit Sub
        End If
        If Me.txtCost.Text = "" Then
            MsgBox("Please enter cost", MsgBoxStyle.Information)
            Me.txtCost.Focus()
            Exit Sub
        End If
        If IsNumeric(Me.txtRQty.Text) = False Then
            MsgBox("Please enter quantity as number only", MsgBoxStyle.Information)
            Exit Sub
        End If
        If IsNumeric(Me.txtCost.Text) = False Then
            MsgBox("Please enter cost as number only", MsgBoxStyle.Information)
            Exit Sub
        End If
        If Me.CboUnit.Text = "" Then
            MsgBox("There is no store for this item, please add its store first.", MsgBoxStyle.Information)
            Exit Sub
        End If
        If DAStore.SelectStoreID(CInt(Me.CboItem.SelectedValue), CInt(Me.CboUnit.SelectedValue)).Rows.Count <= 0 Then
            MsgBox("There is no store for this item, please add its store first.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim StoreID As Integer = GetStoreID(CInt(Me.CboItem.SelectedValue), CInt(Me.CboUnit.SelectedValue))
        Dim LocationID As Integer = CInt(Me.CboFrom.SelectedValue)
        Dim RQty As Double = CDbl(Me.txtRQty.Text)
        Dim Cost As Double = CDbl(Me.txtCost.Text)
        Dim Reason As String = Me.txtReason.Text.Trim.Replace("'", "''")
        DAPreReceive.InsertReceive(StoreID, LocationID, RQty, Cost, Reason, Me.dtReceiveDate.Value, getCurrentUserID)
        RefreshList()
        Me.txtCost.Text = ""
        Me.txtRQty.Text = ""
        Me.txtReason.Text = ""
        CalculateAmount()
        If Me.chkBarcode.Checked = True Then
            Me.txtBarcode.Text = ""
            Me.txtBarcode.Focus()
        End If
        If Me.ChkByID.Checked = True Then
            Me.txtID.Text = ""
            Me.txtID.Focus()
        End If
    End Sub
    Sub CalculateAmount()
        Dim Total As Double = 0
        If Me.ReceiveList.RowCount >= 1 Then
            For i As Integer = 0 To ReceiveList.RowCount - 1
                Total = Total + CDbl(Me.ReceiveList.GetRow(i).Cells("AMOUNT").Value)
            Next
        End If
        Me.txttotal.Text = FormatCurrency(Total, 2)
    End Sub
    Sub ClearBox()
        Me.txtRQty.Text = ""
        Me.txtReason.Text = ""
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If Me.ReceiveList.RowCount >= 1 Then
            DAPreReceive.DeleteReceive(ReceiveList.CurrentRow.Cells("RECE_ID").Value)
            CalculateAmount()
            RefreshList()
        End If
        If Me.chkBarcode.Checked = True Then
            Me.txtBarcode.Text = ""
            Me.txtBarcode.Focus()
        End If
        If Me.ChkByID.Checked = True Then
            Me.txtID.Text = ""
            Me.txtID.Focus()
        End If
    End Sub

    Private Sub btnClearList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearList.Click
        If Me.ReceiveList.RowCount >= 1 Then
            If MsgBox("Do you want to clear data in the list below?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DAPreReceive.DeleteAllReceiveByUserID(getCurrentUserID)
                RefreshList()
                Me.txttotal.Text = 0
            End If
        End If
        If Me.chkBarcode.Checked = True Then
            Me.txtBarcode.Text = ""
            Me.txtBarcode.Focus()
        End If
        If Me.ChkByID.Checked = True Then
            Me.txtID.Text = ""
            Me.txtID.Focus()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub CboItem_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboItem.SelectionChangeCommitted
        CboItem_Changed()
        Me.txtRQty.Focus()
    End Sub
    Sub CboItem_Changed()
        Dim UnitTable As New DataTable
        UnitTable = DAStore.SelectStoreByItemID(CInt(Me.CboItem.SelectedValue))
        Me.CboUnit.DataSource = UnitTable
        Me.CboUnit.DisplayMember = "UNIT_NAME_CHN"
        Me.CboUnit.ValueMember = "UNIT_ID"

        Me.txtRQty.Text = ""
        Me.txtReason.Text = ""
        If DAStore.SelectStoreID(CInt(Me.CboItem.SelectedValue), CInt(Me.CboUnit.SelectedValue)).Rows.Count >= 1 Then
            Dim StoreID As Integer = GetStoreID(CInt(Me.CboItem.SelectedValue), CInt(Me.CboUnit.SelectedValue))
            Me.txtCurQty.Text = DAStore.SelectStoreByID(StoreID).Rows(0).Item("ITEM_BALANCE")
            Me.txtCost.Text = DAStore.SelectStoreByID(StoreID).Rows(0).Item("LAST_COST")
        End If

        Dim ItemTable As New DataTable
        ItemTable = DAItem.SelectItemByID(CInt(Me.CboItem.SelectedValue))
        If IsDBNull(ItemTable.Rows(0).Item("ITEM_IMAGE")) = False Then
            Dim MS As New IO.MemoryStream(CType(ItemTable.Rows(0).Item("ITEM_IMAGE"), Byte()))
            Dim img As Image = Image.FromStream(MS)
            Me.PicItem.Image = img
        End If

    End Sub
    Sub CboUnit_Change()
        Me.txtRQty.Text = ""
        Me.txtReason.Text = ""
        If DAStore.SelectStoreID(CInt(Me.CboItem.SelectedValue), CInt(Me.CboUnit.SelectedValue)).Rows.Count >= 1 Then
            Dim StoreID As Integer = GetStoreID(CInt(Me.CboItem.SelectedValue), CInt(Me.CboUnit.SelectedValue))
            Me.txtCurQty.Text = DAStore.SelectStoreByID(StoreID).Rows(0).Item("ITEM_BALANCE")
            Me.txtCost.Text = DAStore.SelectStoreByID(StoreID).Rows(0).Item("LAST_COST")
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ReceiveList.RowCount >= 1 Then
            Dim UpdatedBalance As Double
            Dim CurrentBalance As Double
            Dim ReceiveBalance As Double
            Dim MaxReceiveID As Long
            Dim PreReceiveTable As New DataTable
            PreReceiveTable = DAPreReceive.SelectReceiveByUserID(getCurrentUserID)
            For i As Integer = 0 To PreReceiveTable.Rows.Count - 1
                CurrentBalance = CDbl(DAStore.SelectStoreByID(PreReceiveTable.Rows(i).Item("STOR_ID")).Rows(0).Item("ITEM_BALANCE"))
                ReceiveBalance = CDbl(PreReceiveTable.Rows(i).Item("RECE_QTY"))
                UpdatedBalance = CurrentBalance + ReceiveBalance
                '' Add to Receive
                DAReceive.InsertReceive(PreReceiveTable.Rows(i).Item("STOR_ID"), PreReceiveTable.Rows(i).Item("LOCA_ID"), ReceiveBalance, CDbl(PreReceiveTable.Rows(i).Item("RECE_COST")), PreReceiveTable.Rows(i).Item("RECE_REASON"), PreReceiveTable.Rows(i).Item("RECE_DATE"), PreReceiveTable.Rows(i).Item("USER_ID"))
                '' Add to Transaction
                MaxReceiveID = DAReceive.getMaxID
                DATransaction.InsertTransaction(PreReceiveTable.Rows(i).Item("STOR_ID"), CurrentBalance, ReceiveBalance, UpdatedBalance, MaxReceiveID, 1, CInt(PreReceiveTable.Rows(i).Item("LOCA_ID")), FormatDateTime(Now, DateFormat.ShortDate), getCurrentUserID)
                '' Update Store Balance
                DAStore.UpdateBalance(UpdatedBalance, PreReceiveTable.Rows(i).Item("STOR_ID"))
                DAStore.UpdateCost(CDbl(PreReceiveTable.Rows(i).Item("RECE_COST")), PreReceiveTable.Rows(i).Item("STOR_ID"))
            Next
            DAPreReceive.DeleteAllReceiveByUserID(getCurrentUserID)
            PReceive.RefreshList()
            MsgBox("Items was received", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub


    Private Sub CboUnit_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboUnit.SelectionChangeCommitted
        CboUnit_Change()
        Me.txtRQty.Focus()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim ResultTable As New DataTable
        Dim MyReport As New RptPreReceive
        Dim ReportViewer As New Report_Viewer
        ResultTable = DAPreReceive.SelectReceiveByUserID(getCurrentUserID)
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

    Private Sub cboCategory_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCategory.SelectionChangeCommitted
        Me.CboItem.DataSource = DAItem.SelectByCategoryID(CInt(Me.cboCategory.SelectedValue))
        Me.CboItem.DisplayMember = "ITEM_NAME_CHN"
        Me.CboItem.ValueMember = "ITEM_ID"
        CboItem_Changed()
        Me.txtRQty.Focus()
    End Sub

    Private Sub CboItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboItem.SelectedIndexChanged

    End Sub

    Private Sub cboCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategory.SelectedIndexChanged

    End Sub

    Private Sub txtRQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRQty.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnAdd_Click(sender, e)
        End If
    End Sub

    Private Sub txtCost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCost.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnAdd_Click(sender, e)
        End If
    End Sub

    Private Sub txtCost_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCost.TextChanged

    End Sub

    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        If Me.txtBarcode.Text <> "" Then
            If Asc(e.KeyChar) = 13 Then
                If DAItem.ExistingBarcode(Me.txtBarcode.Text) >= 1 Then
                    Dim ItemTable As New DataTable
                    ItemTable = DAItem.SelectItemByBarcode(Me.txtBarcode.Text)
                    Me.CboItem.SelectedValue = ItemTable.Rows(0).Item("ITEM_ID")
                    CboItem_Changed()
                    Me.txtRQty.Focus()
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

    Private Sub chkBarcode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBarcode.CheckedChanged
        If Me.chkBarcode.Checked Then
            Me.txtBarcode.Visible = True
            Me.ChkByID.Checked = False
            Me.txtID.Visible = False
            Me.txtBarcode.Text = ""
            Me.txtBarcode.Focus()
            Me.CboItem.Enabled = False
            Me.CboUnit.Enabled = False
        Else
            Me.txtBarcode.Visible = False
            Me.CboItem.Enabled = True
            Me.CboUnit.Enabled = True
        End If
    End Sub

    Private Sub CboFrom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboFrom.SelectedIndexChanged

    End Sub

    Private Sub CboUnit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboUnit.SelectedIndexChanged

    End Sub

    Private Sub ChkByID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkByID.CheckedChanged
        If Me.ChkByID.Checked Then
            Me.txtID.Visible = True
            Me.chkBarcode.Checked = False
            Me.txtBarcode.Visible = False
            Me.txtID.Text = ""
            Me.txtID.Focus()
            Me.CboItem.Enabled = False
            Me.CboUnit.Enabled = False
        Else
            Me.txtID.Visible = False
            Me.CboItem.Enabled = True
            Me.CboUnit.Enabled = True
        End If
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress
        If Me.txtID.Text <> "" Then
            If Asc(e.KeyChar) = 13 Then
                If DAItem.ExistingID(Me.txtID.Text) >= 1 Then
                    Dim ItemTable As New DataTable
                    ItemTable = DAItem.SelectByItemID(Me.txtID.Text)
                    Me.CboItem.SelectedValue = ItemTable.Rows(0).Item("ITEM_ID")
                    CboItem_Changed()
                    Me.txtRQty.Focus()
                Else
                    MsgBox("No such Item ID, please try again", MsgBoxStyle.Exclamation)
                    Me.txtID.Focus()
                    Me.txtID.SelectAll()
                End If
            End If
        End If
    End Sub
End Class