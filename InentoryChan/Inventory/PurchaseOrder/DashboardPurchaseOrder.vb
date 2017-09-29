Public Class DashboardPurchaseOrder
    Dim DAVPurchaseMaster As New DSPurchaseOrderTableAdapters.PURCHASE_ORDER_MASTER_VIEWTableAdapter
    Dim DAVPurchaseDetail As New DSPurchaseOrderTableAdapters.PURCHASE_ORDER_MASTER_DETAIL_VIEWTableAdapter
    Dim DAPurcahseDetail As New DSPurchaseOrderTableAdapters.ORDER_DETAILSTableAdapter
    Dim DASupplier As New DSInventoryTableAdapters.SUPPLIERTableAdapter
    Dim DAStore As New DSInventoryTableAdapters.ITEM_BALANCETableAdapter
    Dim DAReceiveDetail As New DSStockTableAdapters.STOCK_RECEIVE_DETAILTableAdapter
    Dim DAReceive As New DSStockTableAdapters.STOCK_RECEIVETableAdapter
    Dim DATransaction As New DSStockTableAdapters.STOCK_TRANSACTIONTableAdapter
    Dim DAOrder As New DSPurchaseOrderTableAdapters.ORDERSTableAdapter
    Dim DAOrderDetail As New DSPurchaseOrderTableAdapters.ORDER_DETAILSTableAdapter

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        With TxtSupplier
            .DataSource = DASupplier.GetData
            .ValueMember = "SUPP_ID"
            .DisplayMember = "SUPP_NAME"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Dim FPurchaseOrder As New PurchaseOrder
        If FPurchaseOrder.ShowDialog = DialogResult.OK Then
            FindByOrderNo(FPurchaseOrder.TxtPuchaseOrderNo.Text)
        End If
    End Sub

    Private Sub ViewPurchaseOrder()
        'GridPurchaseOrder.DataSource = DAVPurchaseMaster.GetData
        GridPurchaseOrder.DataSource = DAVPurchaseMaster.SelectOrderDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
    End Sub

    Private Sub DashboardPurchaseOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ViewPurchaseOrder()
    End Sub
    Public Sub ViewPurchaseDetail(ByVal PurchaseID As Double)
        GridPurchaseDetail.DataSource = DAVPurchaseDetail.SelectOrderDetailByID(PurchaseID)
    End Sub

    Private Sub GridPurchaseOrder_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridPurchaseOrder.SelectionChanged
        Try
            If GridPurchaseOrder.GetRow.Cells("ORDE_STATUS").Value = 0 Then
                BtnDeleteOrder.Enabled = True
            Else
                BtnDeleteOrder.Enabled = False

            End If

            ViewPurchaseDetail(GridPurchaseOrder.GetRow.Cells("ORDER_NO").Value)
            If GridPurchaseOrder.GetRow.Cells("ORDE_STATUS").Value = "1" Then
                GridPurchaseDetail.RootTable.Columns(0).Visible = False
            Else
                GridPurchaseDetail.RootTable.Columns(0).Visible = True
            End If
        Catch ex As Exception
            GridPurchaseOrder.DataSource = Nothing
        End Try
    End Sub

 
    Private Sub FindByOrderNo(ByVal OrderNo As Double)
        GridPurchaseOrder.DataSource = DAVPurchaseMaster.SelectPurchaseNo(OrderNo)
    End Sub
    Private Sub FindBySupplier()
        GridPurchaseOrder.DataSource = DAVPurchaseMaster.SelectBySupplier(TxtSupplier.Text)
    End Sub
    Private Sub FindByOrderDataToDate(ByVal dateFrom As Date, ByVal DateTo As Date)
        GridPurchaseOrder.DataSource = DAVPurchaseMaster.SelectOrderDateToDate(dateFrom.Date, DateTo.Date)
    End Sub

    Private Sub TxtOrderNo_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetEnglishLanguage()
    End Sub
    'Dim TotalKHR1 As Double = 0
    'Dim TotalUSD2 As Double = 0
    'Dim TotalTHB2 As Double = 0
    Private Sub GridPurchaseDetail_RowCheckStateChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles GridPurchaseDetail.RowCheckStateChanged

        Dim ISCheck As Boolean = GridPurchaseDetail.GetRow.Cells(0).Value
        Dim IS_CUR As String = ""
        If ISCheck = True Then
            GridPurchaseDetail.GetRow.BeginEdit()

            IS_CUR = GridPurchaseDetail.GetRow.Cells("IS_CURRENCY").Value

            GridPurchaseDetail.GetRow.Cells("RECEIVE_QTY").Value = GridPurchaseDetail.GetRow.Cells("ORDE_QTY").Value
            GridPurchaseDetail.GetRow.EndEdit()
            'If IS_CUR = "KHR" Then
            '    TotalKHR1 = TotalKHR1 + (GridPurchaseDetail.GetRow.Cells("RECEIVE_QTY").Value * GridPurchaseDetail.GetRow.Cells("Cost").Value)
            'ElseIf IS_CUR = "USD" Then
            '    TotalUSD2 = TotalUSD2 + (GridPurchaseDetail.GetRow.Cells("RECEIVE_QTY").Value * GridPurchaseDetail.GetRow.Cells("Cost").Value)
            'ElseIf IS_CUR = "THB" Then
            '    TotalTHB2 = TotalTHB2 + (GridPurchaseDetail.GetRow.Cells("RECEIVE_QTY").Value * GridPurchaseDetail.GetRow.Cells("Cost").Value)
            'End If

            'CalculateLastTotal(TotalUSD2, TotalKHR1, TotalTHB2)
        End If
        If ISCheck = False Then
            GridPurchaseDetail.GetRow.BeginEdit()
            IS_CUR = GridPurchaseDetail.GetRow.Cells("IS_CURRENCY").Value
            GridPurchaseDetail.GetRow.Cells("RECEIVE_QTY").Value = 0
            GridPurchaseDetail.GetRow.EndEdit()
            'TotalKHR1 = 0
            'TotalUSD2 = 0
            'TotalTHB2 = 0
            'CalculateLastTotal(TotalUSD2, TotalKHR1, TotalTHB2)
        End If

    End Sub




    Private Sub GridPurchaseDetail_ColumnHeaderClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridPurchaseDetail.ColumnHeaderClick
        Dim TotalKHR As Double = 0
        Dim TotalUSD As Double = 0
        Dim TotalTHB As Double = 0
        If e.Column.ActAsSelector = True Then
            For i As Integer = 0 To GridPurchaseDetail.RowCount - 1
                Dim ISCheck As Boolean = GridPurchaseDetail.GetRow(i).Cells(0).Value
                'GridPurchaseDetail.EditMode = Janus.Windows.GridEX.EditMode.EditOn
                Dim IS_CUR As String = ""
                If ISCheck = True Then
                    GridPurchaseDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True
                    GridPurchaseDetail.GetRow(i).BeginEdit()
                    IS_CUR = GridPurchaseDetail.GetRow(i).Cells("IS_CURRENCY").Value
                    GridPurchaseDetail.GetRow(i).Cells("RECEIVE_QTY").Value = GridPurchaseDetail.GetRow(i).Cells("ORDE_QTY").Value

                    'If IS_CUR = "USD" Then
                    '    TotalUSD = TotalUSD + (GridPurchaseDetail.GetRow(i).Cells("RECEIVE_QTY").Value * GridPurchaseDetail.GetRow(i).Cells("Cost").Value)
                    'ElseIf IS_CUR = "KHR" Then
                    '    TotalKHR = TotalKHR + (GridPurchaseDetail.GetRow(i).Cells("RECEIVE_QTY").Value * GridPurchaseDetail.GetRow(i).Cells("Cost").Value)
                    'ElseIf IS_CUR = "THB" Then
                    '    TotalTHB = TotalTHB + (GridPurchaseDetail.GetRow(i).Cells("RECEIVE_QTY").Value * GridPurchaseDetail.GetRow(i).Cells("Cost").Value)
                    'End If


                    GridPurchaseDetail.GetRow(i).EndEdit()
                    'GridPurchaseDetail.Refresh()
                End If
                If ISCheck = False Then
                    GridPurchaseDetail.GetRow(i).BeginEdit()
                    IS_CUR = GridPurchaseDetail.GetRow(i).Cells("IS_CURRENCY").Value
                    GridPurchaseDetail.GetRow(i).Cells("RECEIVE_QTY").Value = 0
                    GridPurchaseDetail.GetRow(i).EndEdit()
                    'TotalKHR = 0
                    'TotalUSD = 0
                    'TotalTHB = 0
                    GridPurchaseDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
                End If
                'GridPurchaseDetail.EditMode = Janus.Windows.GridEX.EditMode.EditOff
            Next
        End If

        ' CalculateLastTotal(TotalUSD, TotalKHR, TotalTHB)
    End Sub
    Private Sub CalculateLastTotal(ByVal TotalUSD As Double, ByVal TotalKHR As Double, ByVal TotalTHB As Double)

        'TxtTotalUSD.Text = TotalUSD

        'TxtTotalKHR.Text = TotalKHR

        'TxtTotalTHB.Text = TotalTHB

    End Sub

    Private Sub GridPurchaseDetail_CellEdited(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridPurchaseDetail.CellEdited
        ''Try
        'Dim IS_CUR As String = GridPurchaseDetail.GetRow.Cells("IS_CURRENCY").Value
        'CalculateLastTotal(IS_CUR, IIf(IsDBNull(GridPurchaseDetail.GetRow.Cells("RECEIVE_QTY").Value), 0, GridPurchaseDetail.GetRow.Cells("RECEIVE_QTY").Value), GridPurchaseDetail.GetRow.Cells("Cost").Value)
        ''Catch ex As Exception

        'End Try

    End Sub

    Private Sub GridPurchaseDetail_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridPurchaseDetail.KeyPress
        SetDisableKeyString(e)
    End Sub


    Private Sub BtnReceiveStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReceiveStock.Click
        If GridPurchaseOrder.SelectedItems.Count = 0 Then Exit Sub
        If GridPurchaseOrder.GetRow.Cells("IS_DEL").Value = 1 Then
            MessageBox.Show("You can receive this purchase order. Becoz your purchase order have deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If GridPurchaseOrder.GetRow.Cells("ORDE_STATUS").Value = "1" Then
            MessageBox.Show("កាបញ្ជាទិញ ត្រូវបានទទួលរួចហើយ! មេត្តាត្រួតពិនិត្យម្តង់ទៀត", "Purchase Order", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'Column.ActAsSelector
        Dim s As Boolean = False
        For i As Integer = 0 To GridPurchaseDetail.RowCount - 1

            Dim ISCheck As Boolean = GridPurchaseDetail.GetRow(i).Cells(0).Value
            If ISCheck = False Then
                s = False
                Exit For
            Else
                s = True
            End If
        Next
        If s = False Then
            MessageBox.Show("Please Check item list to before click receive purchase order.", "Error Receive", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim TotalKHR As Double = 0
        Dim TotalUSD As Double = 0
        Dim TotalTHB As Double = 0

        Dim StoreID As Integer
        Dim StoreIDFree As Integer
        Dim CurrentQty As Decimal
        Dim CurrentQTYFree As Decimal

        Dim FReceiveStock As New ReceiveStock
        For i As Integer = 0 To GridPurchaseDetail.RowCount - 1
            Dim ISCheck As Boolean = GridPurchaseDetail.GetRow(i).Cells(0).Value
            GridPurchaseDetail.EditMode = Janus.Windows.GridEX.EditMode.EditOn
            Dim IS_CUR As String = ""
            If ISCheck = True Then

                GridPurchaseDetail.GetRow(i).BeginEdit()
                IS_CUR = GridPurchaseDetail.GetRow(i).Cells("IS_CURRENCY").Value
                If IS_CUR = "$" Then
                    TotalUSD = TotalUSD + (GridPurchaseDetail.GetRow(i).Cells("RECEIVE_QTY").Value * GridPurchaseDetail.GetRow(i).Cells("Cost").Value)
                ElseIf IS_CUR = "៛" Then
                    TotalKHR = TotalKHR + (GridPurchaseDetail.GetRow(i).Cells("RECEIVE_QTY").Value * GridPurchaseDetail.GetRow(i).Cells("Cost").Value)
                ElseIf IS_CUR = "B" Then
                    TotalTHB = TotalTHB + (GridPurchaseDetail.GetRow(i).Cells("RECEIVE_QTY").Value * GridPurchaseDetail.GetRow(i).Cells("Cost").Value)
                End If
            End If
        Next
        FReceiveStock.TxtTotalKHR.Text = TotalKHR
        FReceiveStock.TxtTotalTHB.Text = TotalTHB
        FReceiveStock.TxtTotalUSD.Text = TotalUSD
        FReceiveStock.LblPurchaseID.Text = GridPurchaseOrder.GetRow.Cells("ORDE_ID").Value
        FReceiveStock.LblSuppID.Text = GridPurchaseOrder.GetRow.Cells("SUPPLIER_NO").Value
        FReceiveStock.TxtSupplier.Text = GridPurchaseOrder.GetRow.Cells("SUPP_NAME").Value
        FReceiveStock.TxtSuppAddress.Text = GridPurchaseOrder.GetRow.Cells("SUPP_ADDRESS").Value
        FReceiveStock.TxtSupTelephone.Text = GridPurchaseOrder.GetRow.Cells("SUPP_PHONE").Value
        FReceiveStock.TxtPuchaseOrderNo.Text = GridPurchaseOrder.GetRow.Cells("ORDER_NO").Value
        FReceiveStock.TxtDateOrder.Value = GridPurchaseOrder.GetRow.Cells("ORDE_DATE").Value
        Dim UnitTypeFree As String
        If FReceiveStock.ShowDialog = DialogResult.OK Then
            ' Todo update received item
            Dim isCheck As Boolean
            DAReceive.InsertReceive(GridPurchaseOrder.GetRow.Cells("ORDER_NO").Value, "Order", FReceiveStock.DateReceived.Value.Date, getCurrentUserID)
            Dim ReceiveID As Long = DAReceive.getMaxID
            Dim QTYReceived As Integer = 0
            Dim QTYPromotion As Integer
            Dim ItemID As Double = 0
            For i As Integer = 0 To GridPurchaseDetail.RowCount - 1
                isCheck = GridPurchaseDetail.GetRow(i).Cells(0).Value
                If isCheck = True Then
                    QTYReceived = GridPurchaseDetail.GetRow(i).Cells("RECEIVE_QTY").Value
                    QTYPromotion = GridPurchaseDetail.GetRow(i).Cells("PROMOTION_QTY").Value
                    ItemID = GridPurchaseDetail.GetRow(i).Cells("ITEM_ID").Value
                    DAPurcahseDetail.UpdateQTYReceived(QTYReceived, QTYPromotion, GridPurchaseDetail.GetRow(i).Cells("DETA_ID").Value)
                End If
                StoreID = DAStore.SelectByItemAndUnit(ItemID).Rows(0).Item("STORE_ID")
                CurrentQty = CDec(DAStore.SelectByStoreID(StoreID).Rows(0).Item("BALANCE"))
                Try
                    StoreIDFree = DAStore.SelectByItemAndUnit(ItemID).Rows(0).Item("STORE_ID")
                    CurrentQTYFree = CDec(DAStore.SelectByStoreID(StoreIDFree).Rows(0).Item("BALANCE"))
                    UnitTypeFree = CStr(DAStore.SelectByStoreID(StoreIDFree).Rows(0).Item("UNIT_TYPE"))
                Catch ex As Exception

                End Try
              
                ' Insert Received detail
                DAReceiveDetail.InsertDetail(ReceiveID, StoreID, GridPurchaseDetail.GetRow(i).Cells("ITEM_ID").Value, CDec(IIf(UnitTypeFree <> "Sub Unit", QTYReceived + QTYPromotion, QTYReceived)))
                If UnitTypeFree = "Sub Unit" And UnitTypeFree <> "" Then
                    DAReceiveDetail.InsertDetail(ReceiveID, StoreIDFree, GridPurchaseDetail.GetRow(i).Cells("ITEM_ID").Value, QTYPromotion)
                End If

                ' Update stock


                DAStore.UpdateBalance(CurrentQty + CDec(IIf(UnitTypeFree <> "Sub Unit", QTYReceived + QTYPromotion, QTYReceived)), StoreID)
                If UnitTypeFree = "Sub Unit" And UnitTypeFree <> "" Then
                    DAStore.UpdateBalance(CurrentQTYFree + QTYPromotion, StoreIDFree)
                End If
                DATransaction.InsertTransaction(StoreID, ItemID, ReceiveID, "RECEIVE", CurrentQty, CDec(IIf(UnitTypeFree <> "Sub Unit", QTYReceived + QTYPromotion, QTYReceived)), CurrentQty + CDec(IIf(UnitTypeFree <> "Sub Unit", QTYReceived + QTYPromotion, QTYReceived)), FReceiveStock.DateReceived.Value.Date, getCurrentUserID)

                If UnitTypeFree = "Sub Unit" And UnitTypeFree <> "" Then
                    DATransaction.InsertTransaction(StoreIDFree, ItemID, ReceiveID, "RECEIVE", CurrentQTYFree, CurrentQTYFree + QTYPromotion, CurrentQTYFree + QTYPromotion, FReceiveStock.DateReceived.Value.Date, getCurrentUserID)
                End If

            Next
            'DA_Payabll.InsertNewPayable(LblAccountPayID.Text, FReceiveStock.DateReceived.Value.Date, 0, 0, 0, "") = 1
            GridPurchaseOrder.DataSource = DAVPurchaseMaster.SelectPurchaseNo(FReceiveStock.TxtPuchaseOrderNo.Text)
        End If
    End Sub



    Private Sub ChSupplier_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChSupplier.CheckedChanged
        TxtSupplier.Enabled = ChSupplier.Checked
    End Sub

    Private Sub BntFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BntFind.Click
        Try
            If RadAll.Checked = True Then
                If ChSupplier.Checked = True Then
                    GridPurchaseOrder.DataSource = DAVPurchaseMaster.SelectDateToDateWithSupplier(DateFrom.Value.Date, DateTo.Value.Date, "0", CInt(TxtSupplier.SelectedValue))
                Else
                    GridPurchaseOrder.DataSource = DAVPurchaseMaster.SelectOrderDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
                End If

            ElseIf RadNotYet.Checked = True Then
                If ChSupplier.Checked = True Then
                    GridPurchaseOrder.DataSource = DAVPurchaseMaster.SelectDateToDateWithSupplier(DateFrom.Value.Date, DateTo.Value.Date, "0", CInt(TxtSupplier.SelectedValue))
                Else
                    GridPurchaseOrder.DataSource = DAVPurchaseMaster.SelectDataToDateWithStatus(DateFrom.Value.Date, DateTo.Value.Date, "0")
                End If
            ElseIf RadReceived.Checked = True Then
                If ChSupplier.Checked = True Then
                    GridPurchaseOrder.DataSource = DAVPurchaseMaster.SelectDateToDateWithSupplier(DateFrom.Value.Date, DateTo.Value.Date, "1", CInt(TxtSupplier.SelectedValue))
                Else
                    GridPurchaseOrder.DataSource = DAVPurchaseMaster.SelectDataToDateWithStatus(DateFrom.Value.Date, DateTo.Value.Date, "1")
                End If
            End If
            If ChPurchaseNo.Checked = True Then
                GridPurchaseOrder.DataSource = DAVPurchaseMaster.SelectDateToDateWithPurchaseNo(DateFrom.Value.Date, DateTo.Value.Date, EmptyString(TxtPurchashNo.Text))
            End If
        Catch ex As Exception
            GridPurchaseOrder.DataSource = Nothing
            GridPurchaseDetail.DataSource = Nothing
        End Try
        
    End Sub

    Private Sub ChPurchaseNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChPurchaseNo.CheckedChanged
        TxtPurchashNo.Enabled = ChPurchaseNo.Checked
    End Sub

    Private Sub TxtPurchashNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPurchashNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnDeleteOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteOrder.Click
        If GridPurchaseOrder.SelectedItems.Count = 0 Then Exit Sub
        If GridPurchaseOrder.GetRow.Cells("ORDE_STATUS").Value = 1 Then
            MessageBox.Show("You can not delete this puchase order!. Becoz this puchase already received product", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("Do you want to delete this purchase order?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DAOrder.DeleteOrder(1, GridPurchaseOrder.GetRow.Cells("ORDE_ID").Value) Then
                GridPurchaseOrder.DataSource = DAVPurchaseMaster.SelectDateToDateWithPurchaseNo(DateFrom.Value.Date, DateTo.Value.Date, GridPurchaseOrder.GetRow.Cells("ORDER_NO").Value)
            End If
        End If
    End Sub

    Private Sub BtnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUndo.Click
        If GridPurchaseOrder.SelectedItems.Count = 0 Then Exit Sub
        'If GridPurchaseOrder.GetRow.Cells("ORDE_STATUS").Value = 1 Then
        '    MessageBox.Show("You can not delete this puchase order!. Becoz this puchase already received product", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        If MessageBox.Show("Do you want to undo delete this purchase order?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DAOrder.DeleteOrder(0, GridPurchaseOrder.GetRow.Cells("ORDE_ID").Value) Then
                GridPurchaseOrder.DataSource = DAVPurchaseMaster.SelectDateToDateWithPurchaseNo(DateFrom.Value.Date, DateTo.Value.Date, GridPurchaseOrder.GetRow.Cells("ORDER_NO").Value)
            End If
        End If
    End Sub

    Private Sub BtnRemoveProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveProduct.Click
        If GridPurchaseDetail.SelectedItems.Count = 0 Then Exit Sub
        If GridPurchaseOrder.GetRow.Cells("ORDE_STATUS").Value = 1 Then
            MessageBox.Show("you can not remove this item. Because the item receive already!", "Receive", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("Do you want to delete this item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DAOrderDetail.DeleteOrderDetailByItem(GridPurchaseDetail.GetRow.Cells("DETA_ID").Value) = 1 Then
                ViewPurchaseDetail(GridPurchaseOrder.GetRow.Cells("ORDER_NO").Value)
            End If
        End If
    End Sub

    Private Sub BtnAddProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddProduct.Click
        If GridPurchaseDetail.SelectedItems.Count = 0 Then Exit Sub
        If GridPurchaseOrder.GetRow.Cells("ORDE_STATUS").Value = 1 Then
            MessageBox.Show("you can not remove this item. Because the item receive already!", "Receive", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim FAddPurchaseOrder As New AddMorePurchaseOrder
        FAddPurchaseOrder.lblOrderNo.Text = GridPurchaseOrder.GetRow.Cells("ORDER_NO").Value
        FAddPurchaseOrder.LblTHBTotal.Text = GridPurchaseOrder.GetRow.Cells("TOTAL_B").Value
        FAddPurchaseOrder.LblKHRTotal.Text = GridPurchaseOrder.GetRow.Cells("TOTAL_R").Value
        FAddPurchaseOrder.LblUSDTotal.Text = GridPurchaseOrder.GetRow.Cells("TOTAL_D").Value
        If FAddPurchaseOrder.ShowDialog() = DialogResult.OK Then
            Me.ChPurchaseNo.Checked = True
            TxtPurchashNo.Text = GridPurchaseOrder.GetRow.Cells("ORDER_NO").Value
            BntFind_Click(sender, e)
        End If
    End Sub

    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click

    End Sub

    Private Sub BtnReceiveProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReceiveProduct.Click
        Dim FReceive As New FormReceiveProduct
        If FReceive.ShowDialog() = DialogResult.OK Then
            GridPurchaseOrder.DataSource = DAVPurchaseMaster.SelectPurchaseNo(FReceive.TxtPuchaseOrderNo.Text)
        End If
    End Sub
End Class
