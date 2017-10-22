Public Class FormReceiveProduct

    Dim DAPurchasOrderDetailTem As New DSPurchaseOrderTableAdapters.ORDER_DETAILS_TEMTableAdapter
    Dim DASupplier As New DSInventoryTableAdapters.SUPPLIERTableAdapter
    Dim DAPurchasOrder As New DSPurchaseOrderTableAdapters.ORDERSTableAdapter
    Dim DAPurchaseOrderDetail As New DSPurchaseOrderTableAdapters.ORDER_DETAILSTableAdapter
    Dim DA_AccPayable As New DSACCOUNTPAYABLETableAdapters.ACC_PAYABLETableAdapter
    Dim DA_Payabll As New DSACCOUNTPAYABLETableAdapters.ACC_PAY_ABLE_DETAILTableAdapter
    Dim DAPurcahseDetail As New DSPurchaseOrderTableAdapters.ORDER_DETAILSTableAdapter
    Private Sub BtnAddProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddProduct.Click
        Dim FAddPurchase As New AddPurchaseOrder(Me)
        FAddPurchase.lblOrderNo.Text = TxtPuchaseOrderNo.Text
        FAddPurchase.ShowDialog()
    End Sub
    Public Sub AddTotolCast()
        TxtTotalUSD.Text = 0
        TxtTotalKHR.Text = 0
       
        Dim TotalUSD As Double = 0
        For i As Integer = 0 To GridOrderDetail.RowCount - 1
            'TotalTHB = TotalTHB + CDbl(GridOrderDetail.GetRow(i).Cells("ORDE_PRICE_B").Value)
            'TotalKHR = TotalKHR + CDbl(GridOrderDetail.GetRow(i).Cells("ORDE_PRICE_R").Value)
            TotalUSD = TotalUSD + CDbl(GridOrderDetail.GetRow(i).Cells("ORDE_PRICE_D").Value)
        Next


        TxtTotalUSD.Text = TotalUSD
        TxtTotalKHR.Text = (TotalUSD * GetExchangeRage())
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        DAPurchasOrderDetailTem.DeleteByOrderNo(EmptyString(TxtPuchaseOrderNo.Text))
        Me.Close()
    End Sub

    Private Sub BtnRemoveProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveProduct.Click
        Try
            If MessageBox.Show("តើអ្នកចង់លប់ទំនិញចេញពីបញ្ជីបញ្ជាទីញ?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                DAPurchasOrderDetailTem.DeleteByDetailID(GridOrderDetail.GetRow.Cells("DETA_ID").Value)
                SelectDetailOrder(EmptyString(TxtPuchaseOrderNo.Text))
                AddTotolCast()
            End If

        Catch ex As Exception

        End Try
    End Sub
    Public Sub SelectDetailOrder(ByVal OrderNo As Double)
        GridOrderDetail.DataSource = DAPurchasOrderDetailTem.SelectByOrderNo(OrderNo)
    End Sub
    Private Function GetPurchaseNo() As String
        Dim Years As Integer = Date.Now.Year
        Dim Month As String = Date.Now.Month.ToString
        Dim CountOrderNo As Double
        If Month.Length = 1 Then
            Month = "0" & Month
        Else
            Month = Month
        End If
        Try
            CountOrderNo = CDbl(DAPurchasOrder.SelectOrderNoByYear(Years))
            If CountOrderNo = 0 Then
                CountOrderNo = 1
            Else
                CountOrderNo = CountOrderNo + 1
            End If
        Catch ex As Exception
            CountOrderNo = 1
        End Try
        Return Years & Month & CountOrderNo.ToString
    End Function
  
    Private Sub FormReceiveProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtPuchaseOrderNo.Text = GetPurchaseNo()
        With cboSupplier
            .DataSource = DASupplier.GetData
            .ValueMember = "SUPP_ID"
            .DisplayMember = "SUPP_NAME"
            .SelectedIndex = -1
        End With
        cboSupplier.Focus()
        cboSupplier.SelectAll()
    End Sub

    Private Sub BtnAddSupply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddSupply.Click
        Dim FSupplyer As New NewSupplyer
        FSupplyer.IS_AddFromPuchase = True
        If FSupplyer.ShowDialog() = Windows.Forms.DialogResult.OK Then
            With cboSupplier
                .DataSource = DASupplier.GetData
                .ValueMember = "SUPP_ID"
                .DisplayMember = "SUPP_NAME"
                .SelectedIndex = -1
            End With
        End If
    End Sub

    Private Sub FormReceiveProduct_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        DAPurchasOrderDetailTem.DeleteByOrderNo(EmptyString(TxtPuchaseOrderNo.Text))
    End Sub

  
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        If ValidateCombobox(cboSupplier, "", ErrReceive) = False Then Exit Sub
        If ValidateTextField(TxtPuchaseOrderNo, "", ErrReceive) = False Then Exit Sub
        If ValidateTextField(txtInvoiceReferrent, "", ErrReceive) = False Then Exit Sub
        If ValidateDateTimePicker(DateReceived, "", ErrReceive) = False Then Exit Sub
        If GridOrderDetail.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to receive product?", "Receive", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If SaveNewPuchaseOrder() = 1 Then
                If DA_AccPayable.InsertNewAccountPayable(TxtPuchaseOrderNo.Text, txtInvoiceReferrent.Text, CDec(cboSupplier.SelectedValue), cboSupplier.Text, TxtDateOrder.Value.Date, DateReceived.Value.Date, "Receive Product", EmptyString(TxtTotalUSD.Text), EmptyString(TxtTotalKHR.Text), EmptyString(TxtTotalTHB.Text), "0") = 1 Then
                    DA_Payabll.InsertNewPayable(DA_AccPayable.GetMaxAccPayable, DateReceived.Value.Date, 0, 0, 0, "Not yet pay")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub
    Private Function SaveNewPuchaseOrder() As Integer
        Dim DAReceive As New DSStockTableAdapters.STOCK_RECEIVETableAdapter
        Dim DAReceiveDetail As New DSStockTableAdapters.STOCK_RECEIVE_DETAILTableAdapter
        Dim DATransaction As New DSStockTableAdapters.STOCK_TRANSACTIONTableAdapter
        Dim DAStore As New DSInventoryTableAdapters.ITEM_BALANCETableAdapter
        Dim ProductID As Double = 0
        Dim UnitName As String = ""
        Dim UnitNameFee As String = ""
        Dim Cost As Double = 0
        Dim QTY_Order As Double = 0
        Dim QTY_Free As Double = 0
        Dim TotalTHB As Double = 0
        Dim TotalKHR As Double = 0
        Dim TotalUSD As Double = 0
        Dim IS_Currency As String = ""
        Dim StoreID As Integer
        Dim CurrentQty As Double
        If DAPurchasOrder.InsertReceiveProduct(CDbl(TxtPuchaseOrderNo.Text), CInt(cboSupplier.SelectedValue), TxtDateOrder.Value.Date, 0, CDbl(TxtTotalUSD.Text), 0, "", 4, "1", TxtDateOrder.Value.Year, "0", DateReceived.Value.Date, txtInvoiceReferrent.Text) = 1 Then
            For i As Integer = 0 To GridOrderDetail.RowCount - 1
                ProductID = GridOrderDetail.GetRow(i).Cells("ITEM_ID").Value
                Cost = GridOrderDetail.GetRow(i).Cells("COST").Value
                QTY_Order = GridOrderDetail.GetRow(i).Cells("ORDE_QTY").Value
                TotalUSD = GridOrderDetail.GetRow(i).Cells("ORDE_PRICE_D").Value

                StoreID = CInt(DAStore.SelectByItemAndUnit(ProductID).Rows(0).Item("ITEM_ID"))
                CurrentQty = CDec(DAStore.SelectByStoreID(StoreID).Rows(0).Item("BALANCE"))


                DAPurchaseOrderDetail.InsertPurchaseOrderDetail(TxtPuchaseOrderNo.Text, ProductID, "Main Unit", QTY_Order, Cost, TotalUSD, 0, 0, "$", 0, "Main Unit", QTY_Order)

                'Insert to recieve 

                DAReceive.InsertReceive(TxtPuchaseOrderNo.Text, "Order", DateReceived.Value.Date, getCurrentUserID)
                Dim ReceiveID As Long = DAReceive.getMaxID

                StoreID = DAStore.SelectByItemAndUnit(ProductID).Rows(0).Item("STORE_ID")

                DAReceiveDetail.InsertDetail(ReceiveID, StoreID, GridOrderDetail.GetRow(i).Cells("ITEM_ID").Value, QTY_Order)


                ' Update stock

                DAStore.UpdateBalance(CurrentQty + QTY_Order, StoreID)

                DATransaction.InsertTransaction(StoreID, ProductID, ReceiveID, "RECEIVE", CurrentQty, QTY_Order, CurrentQty + QTY_Order, DateReceived.Value.Date, getCurrentUserID)

            Next
            DAPurchasOrderDetailTem.DeleteByOrderNo(EmptyString(TxtPuchaseOrderNo.Text))
            Return 1
        End If
    End Function

End Class