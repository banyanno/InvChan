Public Class AddMoreProductSale
    Dim DACurrency As New DSInventoryTableAdapters.CURRENCIESTableAdapter
    Dim DAUnit As New DSInventoryTableAdapters.UNITSTableAdapter
    Dim DABalance As New DSInventoryTableAdapters.ITEM_BALANCETableAdapter
    Dim DAPrice As New DSInventoryTableAdapters.ITEM_PRICESTableAdapter

    ' Dim DAPreInvoice As New DSInventoryTableAdapters.PRE_INVOICE_DETAILSTableAdapter
    Dim PSale As New ProductSale(New DashboardProductSale)
    Dim DAItem As New DSInventoryTableAdapters.ITEMSTableAdapter

    Dim DAInvoice As New DSInventoryTableAdapters.INVOICETableAdapter
    Dim DAInvoiceDetail As New DSInventoryTableAdapters.INVOICE_DETAILSTableAdapter
    Dim DAAccReceiveAble As New DSAccountReceivableTableAdapters.ACCOUNT_RECEIVABLETableAdapter


    Dim DAIssue As New DSStockTableAdapters.STOCK_ISSUETableAdapter
    Dim DAIssueDetail As New DSStockTableAdapters.STOCK_ISSUE_DETAILTableAdapter
    Dim DAReceive As New DSStockTableAdapters.STOCK_RECEIVETableAdapter
    Dim DAReceiveDetail As New DSStockTableAdapters.STOCK_RECEIVE_DETAILTableAdapter
    Dim DAStore As New DSInventoryTableAdapters.ITEM_BALANCETableAdapter
    Dim DATransaction As New DSStockTableAdapters.STOCK_TRANSACTIONTableAdapter

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        GridProductList.DataSource = DAItem.SelectByAllProduct

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub LoadItemPrice(ByVal ItemID As Integer)
        Try
            Dim Qty As Decimal = 0
            Dim PriceTable As New DataTable
            PriceTable = DAPrice.SelectPrice(ItemID)
            'If Me.txtQty.Text <> "" And IsNumeric(Me.txtQty.Text) Then
            '    Qty = CDec(Me.txtQty.Text)
            'End If
            'If PSale.ChIsCustomer.Checked = True Then
            '    'cboUnit.SelectedIndex = 0
            '    'cboUnit.Enabled = False
            'Else
            '    cboUnit.SelectedIndex = 1
            '    cboUnit.Enabled = False
            '    'ChQTYFree.Enabled = False

            'End If
            If Me.cboUnit.SelectedIndex = 1 Then
                'If PSale.ChIsCustomer.Checked = False Then
                '    Me.txtPrice.Text = PriceTable.Rows(0).Item("RETAIL_PRICE").ToString
                '    Me.CboCurrency.SelectedValue = "$"
                '    Me.CboCurrency.Enabled = False
                'End If
            Else
                Me.CboCurrency.Enabled = True
                Dim CurCode As String = Me.CboCurrency.Text 'SelectedValue.ToString
                If CurCode = "៛" Then
                    Me.txtPrice.Text = PriceTable.Rows(0).Item("KHR_PRICE").ToString
                ElseIf CurCode = "$" Then
                    Me.txtPrice.Text = PriceTable.Rows(0).Item("USD_PRICE").ToString
                ElseIf CurCode = "B" Then
                    Me.txtPrice.Text = PriceTable.Rows(0).Item("THB_PRICE").ToString
                End If
            End If
        Catch ex As Exception
            CboCurrency.Text = ""
        End Try

    End Sub
    Private Sub CalculateTotalPrice()
        'If Me.txtQty.Text <> "" And Me.txtPrice.Text <> "" Then
        Me.txtAmount.Text = FormatNumber(EmptyString(txtQty.Text) * CDec(EmptyString(Me.txtPrice.Text)))
        'End If
    End Sub
  

    'Private Sub CboCurrency_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboCurrency.SelectionChangeCommitted
    '    If GridProductList.SelectedItems.Count = 0 Then Exit Sub
    '    LoadItemPrice(CInt(GridProductList.GetRow.Cells("ITEM_ID").Value))
    '    CalculateTotalPrice()
    'End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        SetEnglishLanguage()
        Me.Close()
    End Sub



    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ' If ValidateCombobox(CboProduct, "", ErrorProvider1) = False Then Exit Sub
        If GridProductList.SelectedItems.Count = 0 Then Exit Sub
        If ValidateCombobox(cboUnit, "", ErrorProvider1) = False Then Exit Sub
        If ValidateCombobox(CboCurrency, "", ErrorProvider1) = False Then Exit Sub
        If ValidateTextField(txtQty, "", ErrorProvider1) = False Then Exit Sub
        If ValidateTextField(txtAmount, "", ErrorProvider1) = False Then Exit Sub
        If CDbl(EmptyString(txtPrice.Text)) = 0 Then
            MsgBox("Please enter price of product!", MsgBoxStyle.Critical)
            txtPrice.Focus()
            txtPrice.SelectAll()
            Exit Sub
        End If
        If ChQTYFree.Checked = True Then
            If ValidateTextField(TxtQTYFree, "", ErrorProvider1) = False Then Exit Sub
            If ValidateCombobox(cboUnitFree, "", ErrorProvider1) = False Then Exit Sub
            If CDbl(TxtQTYFree.Text) <= 0 Then
                MessageBox.Show("The qty can not smal than or equal 0", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        If DAInvoiceDetail.CheckExistingItem(LblInvoiceNo.Text, CInt(GridProductList.GetRow.Cells("ITEM_ID").Value)) > 0 Then
            MessageBox.Show("Product already add into list.Pleas check again!", "Sale", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim KHRAmount As Decimal = 0
        Dim THBAmount As Decimal = 0
        Dim USDAmount As Decimal = 0
        Dim Discount As Decimal = 0
        Dim Amount As Decimal = 0
        If Me.TxtDiscount.Text = "" Then
            Discount = 0
        Else
            Discount = CDec(Me.TxtDiscount.Text)
        End If
        Dim PriceAfterDiscount As Decimal = CDec(EmptyString(Me.txtPrice.Text)) - CDec(EmptyString(Me.TxtDiscount.Text))
        Amount = CDec(EmptyString(Me.txtQty.Text)) * PriceAfterDiscount
        Me.txtAmount.Text = Amount
        If Me.CboCurrency.SelectedValue.ToString = "$" Then
            USDAmount = CDec(EmptyString(Me.txtAmount.Text))
        ElseIf Me.CboCurrency.SelectedValue.ToString = "៛" Then
            KHRAmount = CDec(EmptyString(Me.txtAmount.Text))
        Else
            THBAmount = CDec(EmptyString(Me.txtAmount.Text))
        End If

        Dim ItemID As Integer = CInt(GridProductList.GetRow.Cells("ITEM_ID").Value)

        Dim CurrCode As String
        Dim UnitName As String
        Dim Cost As Decimal
        Dim Qty As Decimal
        Dim UnitNameFree As String
        Dim QtyFree As Decimal
        Dim Price As Decimal
        Dim USD_Amount As Decimal
        Dim KHR_Amount As Decimal
        Dim THB_Amount As Decimal


        CurrCode = Me.CboCurrency.SelectedValue.ToString
        UnitName = Me.cboUnit.SelectedValue.ToString
        Qty = CDec(Me.txtQty.Text)
        UnitNameFree = Me.cboUnitFree.Text
        'Me.cboUnitFree.Text
        QtyFree = EmptyString(TxtQTYFree.Text)
        Price = CDec(Me.txtPrice.Text)
        Discount = Discount
        USD_Amount = USDAmount
        KHR_Amount = KHRAmount
        THB_Amount = THBAmount


        If DAInvoiceDetail.InsertDetail(LblInvoiceNo.Text, ItemID, UnitName, Qty, Price, Discount, CurrCode, KHR_Amount, USD_Amount, THB_Amount, QtyFree, UnitNameFree, False, Cost) = 1 Then
            If ChQTYFree.Checked = True Then
                DAInvoiceDetail.InsertDetail(LblInvoiceNo.Text, ItemID, UnitName, Qty, 0, Discount, CurrCode, 0, 0, 0, QtyFree, UnitNameFree, True, Cost)
            End If
            'Incase update total KHR, USD, THB.
            If DAInvoice.UpdateTotalPrice(LblKHRTotal.Text + KHR_Amount, LblUSDTotal.Text + USD_Amount, LblTHBTotal.Text + THB_Amount, LblKHRTotal.Text + KHR_Amount, LblUSDTotal.Text + USD_Amount, LblTHBTotal.Text + THB_Amount, LblInvoiceNo.Text) = 1 Then
                DAAccReceiveAble.UpdateAccReceiveAble(LblKHRTotal.Text + KHR_Amount, LblTHBTotal.Text + THB_Amount, LblUSDTotal.Text + USD_Amount, LblInvoiceNo.Text)

                '========================================
                '===================== Process   ===================
                '===================== Cut stock ===================
                DAIssue.InsertIssue(LblInvoiceNo.Text, "Sale", Now.Date, getCurrentUserID)
                Dim IssueID As Long = DAIssue.getMaxID

                Dim StoreID As Integer = CInt(DAStore.SelectByItemAndUnit(ItemID).Rows(0).Item("STORE_ID"))
                Dim StoreFeeID As Integer
                If ChQTYFree.Checked = True Then
                    StoreFeeID = CInt(DAStore.SelectByItemAndUnit(ItemID).Rows(0).Item("STORE_ID"))
                End If

                Dim UnitType As String
                Dim UnitTypeFree As String
                Dim CurrentBalance As Decimal
                Dim CurrentBalanceFree As Decimal

                CurrentBalance = CDec(DAStore.SelectByStoreID(StoreID).Rows(0).Item("BALANCE"))
                UnitType = CStr(DAStore.SelectByStoreID(StoreID).Rows(0).Item("UNIT_TYPE"))

                Try
                    CurrentBalanceFree = CDec(DAStore.SelectByStoreID(StoreFeeID).Rows(0).Item("BALANCE"))
                    UnitTypeFree = CStr(DAStore.SelectByStoreID(StoreFeeID).Rows(0).Item("UNIT_TYPE"))
                Catch ex As Exception

                End Try

                ''If UnitTYpe='Sub Unit' and Issue Qty>Current Balance
                ' In case sale wale
                If UnitType = "Sub Unit" Then
                    If Qty > CurrentBalance Then
                        ''Deduct 1 From the Main Unit
                        Dim MainBalance As Decimal = CDec(DAStore.SelectByItemAndUnitType(ItemID, "Main Unit").Rows(0).Item("BALANCE"))
                        DAStore.Deduct1FromMain(ItemID)

                        Dim MainStoreID As Integer = CInt(DAStore.SelectByItemAndUnitType(ItemID, "Main Unit").Rows(0).Item("STORE_ID"))

                        ''Recorded as Issue and Add Issue Transaction
                        DAIssue.InsertIssue(DAInvoice.getMaxID, "To Sub Unit", Now.Date, getCurrentUserID)
                        DAIssueDetail.InsertDetail(DAIssue.getMaxID, CInt(DAStore.SelectByItemAndUnitType(ItemID, "Main Unit").Rows(0).Item("STORE_ID")), ItemID, 1)
                        DATransaction.InsertTransaction(MainStoreID, ItemID, DAIssue.getMaxID, "ISSUE", MainBalance, 1, MainBalance - 1, Now.Date, getCurrentUserID)

                        ''Add Retail Balance To Sub Unit (Update Balance of Sub Unit) 
                        Dim RatioQty As Decimal = CDec(DAStore.SelectByStoreID(StoreID).Rows(0).Item("RATIO_QTY"))
                        DAStore.UpdateBalance(CurrentBalance + RatioQty, StoreID)

                        ''Record as Receive and Add Receive Transaction
                        DAReceive.InsertReceive(DAInvoice.getMaxID, "From Main Unit", Now.Date, getCurrentUserID)
                        DAReceiveDetail.InsertDetail(DAReceive.getMaxID, StoreID, ItemID, RatioQty)
                        DATransaction.InsertTransaction(StoreID, ItemID, DAReceive.getMaxID, "RECEIVE", CurrentBalance, RatioQty, CurrentBalance + RatioQty, Now.Date, getCurrentUserID)

                        ''Issue For Sale and Add Issue Transaction
                        DAIssueDetail.InsertDetail(IssueID, StoreID, ItemID, Qty)
                        DAStore.UpdateBalance(CurrentBalance + RatioQty - Qty, StoreID)
                        DATransaction.InsertTransaction(StoreID, ItemID, IssueID, "ISSUE", CurrentBalance + RatioQty, Qty, CurrentBalance + RatioQty - Qty, Now.Date, getCurrentUserID)

                    Else
                        DAIssueDetail.InsertDetail(IssueID, StoreID, ItemID, Qty)
                        DATransaction.InsertTransaction(StoreID, ItemID, IssueID, "ISSUE", CurrentBalance, Qty + QtyFree, CurrentBalance - (Qty + QtyFree), Now.Date, getCurrentUserID)
                        DAStore.UpdateBalance(CurrentBalance - (Qty + QtyFree), StoreID)
                    End If
                Else
                    ' លក់ដុំ មានចំនួនថែមជា sub Unit
                    If UnitTypeFree = "Sub Unit" And UnitTypeFree <> "" Then
                        DAIssueDetail.InsertDetail(IssueID, StoreFeeID, ItemID, (QtyFree))
                        DATransaction.InsertTransaction(StoreFeeID, ItemID, IssueID, "ISSUE", CurrentBalanceFree, QtyFree, CurrentBalanceFree - (QtyFree), Now.Date, getCurrentUserID)
                        DAStore.UpdateBalance(CurrentBalanceFree - (QtyFree), StoreFeeID)
                    End If

                    DAIssueDetail.InsertDetail(IssueID, StoreID, ItemID, CDec(IIf(UnitTypeFree <> "Sub Unit", Qty + QtyFree, Qty)))
                    DATransaction.InsertTransaction(StoreID, ItemID, IssueID, "ISSUE", CurrentBalance, CDec(IIf(UnitTypeFree <> "Sub Unit", Qty + QtyFree, Qty)), CurrentBalance - CDec(IIf(UnitTypeFree <> "Sub Unit", Qty + QtyFree, Qty)), Now.Date, getCurrentUserID)
                    DAStore.UpdateBalance(CurrentBalance - CDec(IIf(UnitTypeFree <> "Sub Unit", Qty + QtyFree, Qty)), StoreID)

                End If



                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        Else
            MessageBox.Show("Error add more product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub



    Private Sub txtQty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty.GotFocus
        SetEnglishLanguage()
    End Sub


    Private Sub txtQty_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyUp
        'If CDbl(EmptyString(txtQty.Text)) > CDbl(EmptyString(TxtMainStock.Text)) Then
        '    MessageBox.Show("ចំនួន លក់មិនអាចធំជាងចំនួនៅក្នុង Stock!", "Stock Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtQty.Focus()
        '    txtQty.Text = "0"
        '    Exit Sub
        'Else
        If e.KeyValue = 190 Then
            MessageBox.Show("You are can not type .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtQty.Text = 0
            txtQty.Focus()
            txtQty.SelectAll()
            Exit Sub
        End If
        If CDbl(EmptyString(txtPrice.Text)) = 0 Then
            MsgBox("Please enter price of product!", MsgBoxStyle.Critical)
            txtPrice.Focus()
            txtPrice.SelectAll()
            Exit Sub
        Else
            CalculateTotalPrice()
        End If

    End Sub

    Private Sub CboCurrency_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCurrency.SelectedIndexChanged
        'txtQty.Select()
        'txtQty.Focus()
        LblCurrency.Visible = True
        LblCurrency.Text = CboCurrency.Text
        If GridProductList.SelectedItems.Count = 0 Then Exit Sub
        LoadItemPrice(CInt(GridProductList.GetRow.Cells("ITEM_ID").Value))
        CalculateTotalPrice()
    End Sub
    Private Sub CleanInterface()
        'txtSearchProduct.Text = ""
        TxtProductName.Text = ""
        cboUnit.SelectedIndex = -1
        cboUnitFree.SelectedIndex = -1
        cboUnit.Text = ""
        cboUnitFree.Text = ""
        CboCurrency.SelectedIndex = -1
        TxtMainStock.Text = ""
        TxtSubStock.Text = ""
        txtPrice.Text = ""
        txtQty.Text = ""
        TxtQTYFree.Text = ""
        ChQTYFree.Checked = False
        txtPrice.Text = ""
        txtAmount.Text = ""
        TxtDiscount.Text = ""
        GridProductList.DataSource = Nothing
    End Sub



    Private Sub AddProductSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSearchProduct.Select()
        txtSearchProduct.Focus()
        LblMainStcok.Text = ""
        LblSub.Text = ""
        Me.CboCurrency.DataSource = DACurrency.SelectAllCurrencies
        Me.CboCurrency.DisplayMember = "CURR_CODE"
        Me.CboCurrency.ValueMember = "CURR_CODE"
        Me.CboCurrency.SelectedIndex = -1
    End Sub

    Private Sub txtAmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub txtPrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrice.GotFocus
        SetEnglishLanguage()
    End Sub

    Private Sub txtPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrice.KeyPress
        SetDisableKeyString(e)
    End Sub


    Private Sub TxtDiscount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDiscount.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub txtPrice_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPrice.KeyUp
        'LoadItem()
        CalculateTotalPrice()
    End Sub

   

    Private Sub TxtQTYFree_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtQTYFree.GotFocus
        SetEnglishLanguage()
    End Sub

    Private Sub TxtQTYFree_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtQTYFree.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub cboUnit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboUnit.KeyPress
        SetDisableKey(e)
    End Sub

    Private Sub CboCurrency_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboCurrency.KeyPress
        SetDisableKey(e)
    End Sub



    Private Sub cboUnitFree_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboUnitFree.KeyPress
        SetDisableKey(e)
    End Sub

    Private Sub ChQTYFree_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChQTYFree.CheckedChanged
        If ChQTYFree.Checked = True Then
            If GridProductList.SelectedItems.Count = 0 Then Exit Sub
            Me.cboUnitFree.DataSource = DABalance.SelectStoreByItemID(CInt(GridProductList.GetRow.Cells("ITEM_ID").Value))
            Me.cboUnitFree.DisplayMember = "UNIT_NAME"
            Me.cboUnitFree.ValueMember = "UNIT_NAME"
            Me.cboUnitFree.SelectedIndex = -1
            TxtQTYFree.Text = ""
            cboUnitFree.Text = ""
            GroupQTYFree.Enabled = ChQTYFree.Checked
        Else
            'If GridProductList.SelectedItems.Count = 0 Then Exit Sub
            'Me.cboUnitFree.DataSource = DABalance.SelectStoreByItemID(CInt(GridProductList.GetRow.Cells("ITEM_ID").Value))
            'Me.cboUnitFree.DisplayMember = "UNIT_NAME"
            'Me.cboUnitFree.ValueMember = "UNIT_NAME"
            'Me.cboUnitFree.SelectedIndex = -1
            Me.cboUnitFree.DataSource = Nothing
            TxtQTYFree.Text = ""
            cboUnitFree.Text = ""
            GroupQTYFree.Enabled = ChQTYFree.Checked
        End If


    End Sub

    Private Sub TxtQTYFree_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtQTYFree.KeyUp
        If e.KeyValue = 190 Then
            MessageBox.Show("You can not enter word . ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtQTYFree.Text = ""
            TxtQTYFree.Focus()
            TxtQTYFree.SelectAll()
            Exit Sub
        End If
    End Sub



    Private Sub GridProductList_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridProductList.SelectionChanged
        Try
            Dim TblCurrentPrice As DataTable = DAItem.SelectByItemID(GridProductList.GetRow.Cells("ITEM_ID").Value)
            TxtProductName.Text = GridProductList.GetRow.Cells("ITEM_NAME").Value
            For Each rows As DataRow In TblCurrentPrice.Rows
                TxtMainStock.Text = rows("MAIN_QTY")
                LblMainStcok.Text = rows("MAIN_UNIT")
                TxtSubStock.Text = rows("SUB_QTY")
                LblSub.Text = rows("SUB_UNIT")
            Next
            Me.cboUnit.DataSource = DABalance.SelectStoreByItemID(CInt(GridProductList.GetRow.Cells("ITEM_ID").Value))
            Me.cboUnit.DisplayMember = "UNIT_NAME"
            Me.cboUnit.ValueMember = "UNIT_NAME"
            Me.cboUnit.SelectedIndex = -1
            CboCurrency.Text = ""
            txtPrice.Text = ""
            ChQTYFree.Checked = False
            ' LoadItem()
            'cboUnit.Focus()
            'cboUnit.SelectAll()
            'Me.cboUnit.SelectedIndex = -1
            'txtQty.Focus()
            'txtQty.SelectAll()
        Catch ex As Exception
            CboCurrency.Text = ""
            txtPrice.Text = ""
            'CboCurrency.Select()
            'CboCurrency.Focus()
        End Try
    End Sub

    Private Sub txtSearchProduct_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchProduct.GotFocus
        SetKhmerLanguage()
    End Sub

    Private Sub txtSearchProduct_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearchProduct.KeyUp
        'CleanInterface()
        Try
            If txtSearchProduct.Text = "" Then
                GridProductList.DataSource = DAItem.SelectByAllProduct
            Else
                GridProductList.DataSource = DAItem.SelectAutoComplet(txtSearchProduct.Text)
            End If
        Catch ex As Exception

        End Try
    End Sub

   

    Private Sub BtnAddProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddProduct.Click
        Dim FNewProduct1 As New NewProductV1
        FNewProduct1.IS_AddFromSale = True
        If FNewProduct1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            GridProductList.DataSource = DAItem.SelectByAllProduct
        End If

    End Sub
End Class