Public Class UC_OrderItem

    Dim DAItem As New DSItemTableAdapters.ITEMTableAdapter
    Dim DALocation As New DSItemTableAdapters.LOCATIONTableAdapter
    Dim DAUser As New DSItemTableAdapters.USERTableAdapter
    Dim DACategory As New DSItemTableAdapters.CATEGORYTableAdapter
    Dim DAUnit As New DSItemTableAdapters.UNITTableAdapter
    Dim DAStore As New DSItemTableAdapters.ITEM_STORETableAdapter
    Dim DAPreOrder As New DSItemTableAdapters.PRE_ORDERTableAdapter
    Dim DAOrder As New DSItemTableAdapters.ORDERTableAdapter
    Dim DAOrderDetail As New DSItemTableAdapters.ORDER_DETAILSTableAdapter
    Private Sub cboCategory_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCategory.SelectionChangeCommitted
        Me.CboItem.DataSource = DAItem.SelectByCategoryID(CInt(Me.cboCategory.SelectedValue))
        Me.CboItem.DisplayMember = "ITEM_NAME_CHN"
        Me.CboItem.ValueMember = "ITEM_ID"
        CboItem_Changed()
        Me.txtIQty.Focus()
    End Sub
    Sub RefreshList()
        Me.OrderList.DataSource = DAPreOrder.SelectOrderByUserID(getCurrentUserID)
    End Sub
    Sub CboItem_Changed()
        Me.CboUnit.DataSource = DAStore.SelectStoreByItemID(CInt(Me.CboItem.SelectedValue))
        Me.CboUnit.DisplayMember = "UNIT_NAME_CHN"
        Me.CboUnit.ValueMember = "UNIT_ID"

        Me.txtIQty.Text = ""
        If DAStore.SelectStoreID(CInt(Me.CboItem.SelectedValue), CInt(Me.CboUnit.SelectedValue)).Rows.Count >= 1 Then
            Dim StoreID As Integer = GetStoreID(CInt(Me.CboItem.SelectedValue), CInt(Me.CboUnit.SelectedValue))
            Me.txtCurQty.Text = DAStore.SelectStoreByID(StoreID).Rows(0).Item("ITEM_BALANCE")
            Me.txtLastCost.Text = DAStore.SelectStoreByID(StoreID).Rows(0).Item("LAST_PRICE")
        End If
        Dim ItemTable As New DataTable
        ItemTable = DAItem.SelectItemByID(CInt(Me.CboItem.SelectedValue))
        If IsDBNull(ItemTable.Rows(0).Item("ITEM_IMAGE")) = False Then
            Dim MS As New IO.MemoryStream(CType(ItemTable.Rows(0).Item("ITEM_IMAGE"), Byte()))
            Dim img As Image = Image.FromStream(MS)
            Me.picItem.Image = img
        End If
    End Sub
    Sub CboUnit_Change()
        Me.txtIQty.Text = ""
        If DAStore.SelectStoreID(CInt(Me.CboItem.SelectedValue), CInt(Me.CboUnit.SelectedValue)).Rows.Count >= 1 Then
            Dim StoreID As Integer = GetStoreID(CInt(Me.CboItem.SelectedValue), CInt(Me.CboUnit.SelectedValue))
            Me.txtCurQty.Text = DAStore.SelectStoreByID(StoreID).Rows(0).Item("ITEM_BALANCE")
            Me.txtLastCost.Text = DAStore.SelectStoreByID(StoreID).Rows(0).Item("LAST_PRICE")
        End If
    End Sub

    Private Sub CboItem_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboItem.SelectionChangeCommitted
        CboItem_Changed()
        Me.txtIQty.Focus()
    End Sub

    Private Sub UC_OrderItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RefreshList()
        CalculateAmount()
        Me.cboCategory.DataSource = DACategory.SelectCategories
        Me.cboCategory.DisplayMember = "CATE_NAME_CHN"
        Me.cboCategory.ValueMember = "CATE_ID"

        Me.CboItem.DataSource = DAItem.SelectItems
        Me.CboItem.DisplayMember = "ITEM_NAME_CHN"
        Me.CboItem.ValueMember = "ITEM_ID"

        Me.CboUnit.DataSource = DAUnit.SelectUnits
        Me.CboUnit.DisplayMember = "UNIT_NAME_CHN"
        Me.CboUnit.ValueMember = "UNIT_ID"

        Me.cboLocation.DataSource = DALocation.SelectByNot("Main Stock", "Supplier")
        Me.cboLocation.DisplayMember = "LOCA_NAME"
        Me.cboLocation.ValueMember = "LOCA_ID"
        Me.cboLocation.SelectedValue = GetLocationID(getCurrentUserID)
        CboItem_Changed()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Me.txtIQty.Text = "" Then
            MsgBox("Please enter item quantity to order", MsgBoxStyle.Information)
            Me.txtIQty.Focus()
            Exit Sub
        End If
        If Me.txtCurQty.Text = "" Then
            MsgBox("Please choose item to order", MsgBoxStyle.Information)
            Me.CboItem.Focus()
            Exit Sub
        End If
        If IsNumeric(Me.txtIQty.Text) = False Then
            MsgBox("Please enter quantity as number only", MsgBoxStyle.Information)
            Me.txtIQty.Focus()
            Me.txtIQty.SelectAll()
            Exit Sub
        End If
        Dim TotalPreOrderQty As Double = 0
        Dim TotalOrderQty As Double = 0

        If IsNumeric(DAPreOrder.SumQtyByStore(CInt(Me.CboItem.SelectedValue), CInt(Me.CboUnit.SelectedValue).ToString)) Then
            TotalPreOrderQty = DAPreOrder.SumQtyByStore(CInt(Me.CboItem.SelectedValue), CInt(Me.CboUnit.SelectedValue))
        End If
        If IsNumeric(DAOrderDetail.SumQtyByStore(CInt(Me.CboItem.SelectedValue), CInt(Me.CboUnit.SelectedValue))) Then
            TotalOrderQty = DAOrderDetail.SumQtyByStore(CInt(Me.CboItem.SelectedValue), CInt(Me.CboUnit.SelectedValue))
        End If

        Dim CurrentQty As Double = GetStoreBalance(CInt(Me.CboItem.SelectedValue), CInt(Me.CboUnit.SelectedValue))
        Dim RemainQty As Double = CurrentQty - TotalPreOrderQty - TotalOrderQty
        If CDbl(Me.txtIQty.Text) > RemainQty Then
            MsgBox("Sorry, the current quantity of this item is just only " + RemainQty.ToString + " " + CboUnit.Text.ToString + " which is not sufficient for your order.", MsgBoxStyle.Information)
            Me.txtIQty.Focus()
            Me.txtIQty.SelectAll()
            Exit Sub
        End If
        If DAStore.SelectStoreID(CInt(Me.CboItem.SelectedValue), CInt(Me.CboUnit.SelectedValue)).Rows.Count <= 0 Then
            MsgBox("There is no store for this item, please contact your local supplier to add its store first.", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim StoreID As Integer = GetStoreID(CInt(Me.CboItem.SelectedValue), CInt(Me.CboUnit.SelectedValue))
        Dim IQty As Double = CDbl(Me.txtIQty.Text)
        Dim ItemID As Integer = CInt(Me.CboItem.SelectedValue)
        Dim UnitID As Integer = CInt(Me.CboUnit.SelectedValue)
        Dim Price As Double = CDbl(Me.txtLastCost.Text)
        DAPreOrder.InsertOrder(ItemID, UnitID, IQty, Price, getCurrentUserID)
        RefreshList()
        CalculateAmount()
        Me.txtIQty.Text = ""
        Me.txtIQty.Focus()
        If Me.chkBarcode.Checked = True Then
            Me.txtBarcode.Text = ""
            Me.txtBarcode.Focus()
        End If
    End Sub
    Sub CalculateAmount()
        Dim Total As Double = 0
        If Me.OrderList.RowCount >= 1 Then
            For i As Integer = 0 To OrderList.RowCount - 1
                Total = Total + CDbl(Me.OrderList.GetRow(i).Cells("AMOUNT").Value)
            Next
        End If
        Me.txttotal.Text = FormatCurrency(Total, 2)
    End Sub

    Private Sub txtLastCost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLastCost.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnAdd_Click(sender, e)
        End If
    End Sub

    Private Sub txtLastCost_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLastCost.TextChanged

    End Sub

    Private Sub txtIQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIQty.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnAdd_Click(sender, e)
        End If
    End Sub

    Private Sub txtIQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIQty.TextChanged

    End Sub

    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        If Me.txtBarcode.Text <> "" Then
            If Asc(e.KeyChar) = 13 Then
                If DAItem.ExistingBarcode(Me.txtBarcode.Text) >= 1 Then
                    Dim ItemTable As New DataTable
                    ItemTable = DAItem.SelectItemByBarcode(Me.txtBarcode.Text)
                    Me.CboItem.SelectedValue = ItemTable.Rows(0).Item("ITEM_ID")
                    CboItem_Changed()
                    Me.txtIQty.Focus()
                Else
                    MsgBox("No such item barcode was found, please try again", MsgBoxStyle.Exclamation)
                    Me.txtBarcode.Focus()
                    Me.txtBarcode.SelectAll()
                End If
            End If
        End If
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If Me.OrderList.RowCount >= 1 Then
            DAPreOrder.DeleteOrderByID(OrderList.CurrentRow.Cells("ORDE_ID").Value)
            RefreshList()
            CalculateAmount()
        End If
        If Me.chkBarcode.Checked = True Then
            Me.txtBarcode.Text = ""
            Me.txtBarcode.Focus()
        End If
    End Sub

    Private Sub btnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder.Click
        If Me.OrderList.RowCount >= 1 Then
            Dim MaxOrderID As Long
            Dim ItemID As Integer
            Dim UnitID As Integer
            Dim Qty As Double
            Dim Price As Double
            Dim PreOrderTable As New DataTable
            DAOrder.InsertOrder(CInt(Me.cboLocation.SelectedValue), FormatDateTime(Now, DateFormat.ShortDate), CDbl(Me.txttotal.Text), getCurrentUserID, "Pending")
            PreOrderTable = DAPreOrder.SelectOrderByUserID(getCurrentUserID)
            MaxOrderID = DAOrder.getMaxID
            For i As Integer = 0 To PreOrderTable.Rows.Count - 1
                ItemID = CInt(PreOrderTable.Rows(i).Item("ITEM_ID"))
                UnitID = CInt(PreOrderTable.Rows(i).Item("UNIT_ID"))
                Qty = CDbl(PreOrderTable.Rows(i).Item("ORDE_QTY"))
                Price = CDbl(PreOrderTable.Rows(i).Item("ORDE_PRICE"))
                DAOrderDetail.InsertOrder(MaxOrderID, ItemID, UnitID, Qty, Price)
            Next
            DAPreOrder.DeleteOrderByUserID(getCurrentUserID)
            MsgBox("Your order (No." + MaxOrderID.ToString + ") was successfully sent. Please wait for the response from the stock controller... ", MsgBoxStyle.Information)
            RefreshList()
        Else
            MsgBox("No item was ordered", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub cboStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStatus.SelectedIndexChanged

    End Sub

    Private Sub cboStatus_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboStatus.SelectionChangeCommitted
        Dim OrderTable As New DataTable
        If Me.cboStatus.Text = "All" Then
            OrderTable = DAOrder.SelectByDate(getCurrentUserID, FormatDateTime(Me.dtFrom.Value, DateFormat.ShortDate), FormatDateTime(Me.dtTo.Value, DateFormat.ShortDate))
        Else
            OrderTable = DAOrder.SelectByStatus(getCurrentUserID, cboStatus.Text, FormatDateTime(Me.dtFrom.Value, DateFormat.ShortDate), FormatDateTime(Me.dtTo.Value, DateFormat.ShortDate))
        End If
        Me.cboOrderNo.DataSource = OrderTable
        Me.cboOrderNo.DisplayMember = "ORDE_ID"
        Me.cboOrderNo.ValueMember = "ORDE_ID"
        cboOrderNo_SelectionChangeCommitted(sender, e)
    End Sub

    Private Sub cboOrderNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOrderNo.SelectedIndexChanged

    End Sub

    Private Sub cboOrderNo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboOrderNo.SelectionChangeCommitted
        Dim OrderNo As Long = 0
        If Me.cboOrderNo.Text <> "" Then
            OrderNo = CLng(Me.cboOrderNo.Text)
        End If
        Me.MyOrderList.DataSource = DAOrderDetail.SelectByOrderID(OrderNo)
        Dim Total As Double = 0
        If Me.MyOrderList.RowCount >= 1 Then
            For i As Integer = 0 To MyOrderList.RowCount - 1
                Total = Total + CDbl(Me.MyOrderList.GetRow(i).Cells("AMOUNT").Value)
            Next
        End If
        Me.txtTotalMyOrder.Text = FormatCurrency(Total, 2)
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        If Me.OrderList.RowCount >= 1 Then
            Dim ResultTable As New DataTable
            Dim MyReport As New RptPreOrder
            Dim ReportViewer As New Report_Viewer
            ResultTable = DAPreOrder.SelectOrderByUserID(getCurrentUserID)
            MyReport.SetDataSource(ResultTable)
            ReportViewer.CrystalReportViewer1.ReportSource = MyReport
            ReportViewer.ShowDialog()
        Else
            MsgBox("No order to preview", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        If Me.MyOrderList.RowCount >= 1 Then
            Dim ResultTable As New DataTable
            Dim MyReport As New RptOrder
            Dim ReportViewer As New Report_Viewer
            ResultTable = DAOrderDetail.SelectByOrderID(CLng(Me.cboOrderNo.Text))
            MyReport.SetDataSource(ResultTable)
            MyReport.SetParameterValue("OrderNo", CLng(Me.cboOrderNo.Text))
            MyReport.SetParameterValue("OrderDate", DAOrder.SelectOrderByID(CLng(Me.cboOrderNo.Text)).Rows(0).Item("ORDE_DATE"))
            ReportViewer.CrystalReportViewer1.ReportSource = MyReport
            ReportViewer.ShowDialog()
        Else
            MsgBox("No order to preview", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub OrderList_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles OrderList.FormattingRow

    End Sub

    Private Sub OrderList_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OrderList.SelectionChanged
        If Me.OrderList.RowCount >= 1 Then
            Dim ItemTable As New DataTable
            ItemTable = DAItem.SelectItemByID(CInt(Me.OrderList.CurrentRow.Cells("ITEM_ID").Value))
            If IsDBNull(ItemTable.Rows(0).Item("ITEM_IMAGE")) = False Then
                Dim MS As New IO.MemoryStream(CType(ItemTable.Rows(0).Item("ITEM_IMAGE"), Byte()))
                Dim img As Image = Image.FromStream(MS)
                Me.picItem.Image = img
            End If
        End If
    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged

    End Sub

    Private Sub CboItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboItem.SelectedIndexChanged

    End Sub

    Private Sub chkBarcode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBarcode.CheckedChanged
        If Me.chkBarcode.Checked = True Then
            Me.txtBarcode.Visible = True
            Me.txtBarcode.Text = ""
            Me.txtBarcode.Focus()
        Else
            Me.txtBarcode.Visible = False
        End If
    End Sub

    Private Sub TabNewOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabNewOrder.Click

    End Sub

    Private Sub cboLocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLocation.SelectedIndexChanged

    End Sub
End Class
