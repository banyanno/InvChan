Public Class PurchaseOrder
    Dim DASupplier As New DSInventoryTableAdapters.SUPPLIERTableAdapter
    Dim DAPurchasOrderDetailTem As New DSPurchaseOrderTableAdapters.ORDER_DETAILS_TEMTableAdapter
    Dim DAPurchasOrder As New DSPurchaseOrderTableAdapters.ORDERSTableAdapter
    Dim DAPurchaseOrderDetail As New DSPurchaseOrderTableAdapters.ORDER_DETAILSTableAdapter
    Dim DAItem As New DSInventoryTableAdapters.ITEMSTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
  
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Public Function AddItemDetial(ByVal OrderNo As Double, ByVal ProductID As Integer, ByVal ProductName As String, ByVal UnitName As String, _
                             ByVal QTY As Integer, ByVal ProQTY As Integer, ByVal Cost As Double, ByVal TotalCostR As Double, _
                             ByVal TotalCostD As Double, ByVal TotalCostB As Double, ByVal IS_Currency As String, ByVal UNIT_NAME_FREE As String) As Integer
        If DAPurchasOrderDetailTem.InsertPreOrder(OrderNo, ProductID, UnitName, QTY, Cost, TotalCostD, TotalCostR, TotalCostB, IS_Currency, ProQTY, UNIT_NAME_FREE) = 1 Then
            Return 1
        Else
            Return 0
        End If

    End Function
    Public Sub AddTotolCast()
        TxtTotalB.Text = 0
        TxtTotalR.Text = 0
        TxtTotalD.Text = 0
        Dim TotalTHB As Double = 0
        Dim TotalKHR As Double = 0
        Dim TotalUSD As Double = 0
        For i As Integer = 0 To GridOrderDetail.RowCount - 1
            TotalTHB = TotalTHB + CDbl(GridOrderDetail.GetRow(i).Cells("ORDE_PRICE_B").Value)
            TotalKHR = TotalKHR + CDbl(GridOrderDetail.GetRow(i).Cells("ORDE_PRICE_R").Value)
            TotalUSD = TotalUSD + CDbl(GridOrderDetail.GetRow(i).Cells("ORDE_PRICE_D").Value)
        Next
        TxtTotalB.Text = TotalTHB

        TxtTotalD.Text = FormatNumber(TotalUSD, 2)
        TxtTotalR.Text = FormatNumber(TotalUSD * 4100, 0)
    End Sub
    Public Sub SelectDetailOrder(ByVal OrderNo As Double)
        GridOrderDetail.DataSource = DAPurchasOrderDetailTem.SelectByOrderNo(OrderNo)
    End Sub


   



    Private Sub PurchaseOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtPuchaseOrderNo.Text = GetPurchaseNo()
        GridSupplier.DataSource = DASupplier.GetData
        TxtSupplierName.Select()
        TxtSupplierName.Focus()
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        DAPurchasOrderDetailTem.DeleteByOrderNo(EmptyString(TxtPuchaseOrderNo.Text))
        Me.Close()
    End Sub

    

    Private Sub BtnFindProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindProduct.Click
        Dim FProduct As New FindProduct
        If FProduct.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub BtnAddProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddProduct.Click

        Dim FAddPurchase As New AddPurchaseOrder(Me)
        FAddPurchase.lblOrderNo.Text = TxtPuchaseOrderNo.Text
        FAddPurchase.Show()
        'If FAddPurchase.ShowDialog = Windows.Forms.DialogResult.OK Then

        'End If

    End Sub

    

    Private Sub PurchaseOrder_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        DAPurchasOrderDetailTem.DeleteByOrderNo(EmptyString(TxtPuchaseOrderNo.Text))
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

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If GridSupplier.SelectedItems.Count = 0 Then Exit Sub
        If ValidateTextField(TxtPuchaseOrderNo, "", ErrorPurchaseOrder) = False Then Exit Sub
        If ValidateDateField(DatePurchaseOrder, "", ErrorPurchaseOrder) = False Then Exit Sub
        If DAPurchasOrder.CheckExistPurchasNo(TxtPuchaseOrderNo.Text) > 0 Then
            TxtPuchaseOrderNo.Text = GetPurchaseNo()
        End If
        If GridOrderDetail.SelectedItems.Count = 0 Then
            MessageBox.Show("ត្រូវមាន ទំនិញនៅក្នុងបញ្ជីបញ្ជាទិញ!", "List Order", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("តើអ្នកចង់រក្សាទុក បញ្ជាទិញ?", "Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If SaveNewPuchaseOrder() = 1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub
    Private Function SaveNewPuchaseOrder() As Integer
        'Dim DAReceive As New DSStockTableAdapters.STOCK_RECEIVETableAdapter
        'Dim DAReceiveDetail As New DSStockTableAdapters.STOCK_RECEIVE_DETAILTableAdapter
        Dim DATransaction As New DSStockTableAdapters.STOCK_TRANSACTIONTableAdapter
        ' Dim DAStore As New DSInventoryTableAdapters.ITEM_BALANCETableAdapter
        Dim ProductID As Double = 0
        Dim UnitName As String = ""
        Dim UnitNameFee As String = ""
        Dim Cost As Double = 0
        Dim QTY_Order As Integer = 0
        Dim QTY_Free As Integer = 0
        Dim TotalTHB As Double = 0
        Dim TotalKHR As Double = 0
        Dim TotalUSD As Double = 0
        Dim IS_Currency As String = ""
        Dim StoreID As Integer
        Dim CurrentQty As Decimal
        If DAPurchasOrder.InsertPurchaseOrder(CDbl(TxtPuchaseOrderNo.Text), CInt(GridSupplier.GetRow.Cells("SUPP_ID").Value), DatePurchaseOrder.Value.Date, CDbl(TxtTotalR.Text), CDbl(TxtTotalD.Text), CDbl(TxtTotalB.Text), TxtNote.Text, 4, "0", DatePurchaseOrder.Value.Year, "0") = 1 Then
            For i As Integer = 0 To GridOrderDetail.RowCount - 1
                ProductID = GridOrderDetail.GetRow(i).Cells("ITEM_ID").Value
                UnitName = GridOrderDetail.GetRow(i).Cells("UNIT_NAME").Value
                UnitNameFee = GridOrderDetail.GetRow(i).Cells("UNIT_NAME_FREE").Value
                IS_Currency = GridOrderDetail.GetRow(i).Cells("IS_CURRENCY").Value
                Cost = GridOrderDetail.GetRow(i).Cells("COST").Value
                QTY_Order = GridOrderDetail.GetRow(i).Cells("ORDE_QTY").Value
                QTY_Free = GridOrderDetail.GetRow(i).Cells("ORDER_QTY_PROM").Value
                TotalKHR = GridOrderDetail.GetRow(i).Cells("ORDE_PRICE_R").Value
                TotalUSD = GridOrderDetail.GetRow(i).Cells("ORDE_PRICE_D").Value
                TotalTHB = GridOrderDetail.GetRow(i).Cells("ORDE_PRICE_B").Value
                'StoreID = DAStore.SelectByItemAndUnit(ProductID, UnitName).Rows(0).Item("STORE_ID")
                'CurrentQty = CDec(DAStore.SelectByStoreID(StoreID).Rows(0).Item("BALANCE"))
                DAPurchaseOrderDetail.InsertPurchaseOrderDetail(TxtPuchaseOrderNo.Text, ProductID, UnitName, QTY_Order, Cost, TotalUSD, TotalKHR, TotalTHB, IS_Currency, QTY_Free, UnitNameFee, 0)
                'DAReceiveDetail.InsertDetail(ReceiveID, StoreID, ProductID, QTY_Order)
                'DAStore.UpdateBalance(CurrentQty + QTY_Order, StoreID)
                'DATransaction.InsertTransaction(StoreID, ProductID, Me.TxtPuchaseOrderNo.Text, "RECEIVE", CurrentQty, QTY_Order, CurrentQty + QTY_Order, DatePurchaseOrder.Value, getCurrentUserID)
            Next
            DAPurchasOrderDetailTem.DeleteByOrderNo(EmptyString(TxtPuchaseOrderNo.Text))

            Return 1
        End If
    End Function

    Private Sub GridSupplier_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridSupplier.SelectionChanged
        TxtSupplierNameDis.Text = ""
        TxtSupTelephone.Text = ""
        TxtSuppAddress.Text = ""
        If GridSupplier.SelectedItems.Count = 0 Then Exit Sub
        TxtSupplierNameDis.Text = GridSupplier.GetRow.Cells("SUPP_NAME").Value
        TxtSupTelephone.Text = GridSupplier.GetRow.Cells("SUPP_PHONE").Value
        TxtSuppAddress.Text = GridSupplier.GetRow.Cells("SUPP_ADDRESS").Value
    End Sub

    Private Sub TxtSupplierName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSupplierName.GotFocus
        SetKhmerLanguage()
    End Sub

    Private Sub TxtSupplier_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSupplierName.KeyUp
        If TxtSupplierName.Text = "" Then
            GridSupplier.DataSource = DASupplier.GetData
        Else
            GridSupplier.DataSource = DASupplier.SelectAutoNameSupplier(TxtSupplierName.Text)
        End If
    End Sub

    Private Sub BtnAddSupply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddSupply.Click
        Dim FSupplyer As New NewSupplyer
        FSupplyer.IS_AddFromPuchase = True
        If FSupplyer.ShowDialog() = Windows.Forms.DialogResult.OK Then
            GridSupplier.DataSource = DASupplier.GetData
        End If
    End Sub
End Class