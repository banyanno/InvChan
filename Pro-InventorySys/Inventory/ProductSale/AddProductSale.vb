Public Class AddProductSale

    Dim DACurrency As New DSInventoryTableAdapters.CURRENCIESTableAdapter
    Dim DAUnit As New DSInventoryTableAdapters.UNITSTableAdapter
    Dim DABalance As New DSInventoryTableAdapters.ITEM_BALANCETableAdapter
    Dim DAPrice As New DSInventoryTableAdapters.ITEM_PRICESTableAdapter
    Dim DAPreInvoice As New DSInventoryTableAdapters.PRE_INVOICE_DETAILSTableAdapter
    Dim PSale As New ProductSale(New DashboardProductSale)
    Dim DAItem As New DSInventoryTableAdapters.ITEMSTableAdapter
    Dim DaItemCost As New DSInventoryTableAdapters.ITEM_COSTSTableAdapter


    Sub New(ByVal MyPanel As ProductSale)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PSale = MyPanel



        'With CboProduct
        '    .DataSource = DAItem.GetData
        '    .ValueMember = "ITEM_ID"
        '    .DisplayMember = "ITEM_NAME"
        '    .SelectedIndex = -1
        'End With
        GridProductList.DataSource = DAItem.SelectByAllProduct

    End Sub

    Sub LoadItemPrice(ByVal ItemID As Integer)
        'Try
        Dim Qty As Decimal = 0
        Dim PriceTable As DataTable = DAPrice.SelectPrice(ItemID)
        'If Me.txtQty.Text <> "" And IsNumeric(Me.txtQty.Text) Then
        '    Qty = CDec(Me.txtQty.Text)
        'End If
        If PSale.ChIsCustomer.Checked = True Then
            'cboUnit.SelectedIndex = 0
            'cboUnit.Enabled = False
        Else
            cboUnit.SelectedIndex = 1
            cboUnit.Enabled = False
            'ChQTYFree.Enabled = False

        End If
        If Me.cboUnit.SelectedIndex = 1 Then
            If PSale.ChIsCustomer.Checked = False Then
                Me.txtPrice.Text = PriceTable.Rows(0).Item("RETAIL_PRICE").ToString
                Me.CboCurrency.SelectedValue = "$"
                Me.CboCurrency.Enabled = False
            End If
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
        'Catch ex As Exception
        '    CboCurrency.Text = ""
        'End Try

    End Sub
    Private Sub CalculateTotalPrice()
        'If Me.txtQty.Text <> "" And Me.txtPrice.Text <> "" Then
        Me.txtAmount.Text = CDec(EmptyString(txtQty.Text)) * CDec(EmptyString(Me.txtPrice.Text))
        'End If
    End Sub
    Private Sub cboUnit_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboUnit.SelectionChangeCommitted
        'If GridProductList.SelectedItems.Count = 0 Then Exit Sub
        'LoadItem(CInt(GridProductList.GetRow.Cells("ITEM_ID").Value))
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
        'If ValidateCombobox(cboUnit, "", ErrorProvider1) = False Then Exit Sub
        ' If ValidateCombobox(CboCurrency, "", ErrorProvider1) = False Then Exit Sub
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
        If DAPreInvoice.CheckExistingItem(GridProductList.GetRow.Cells("ITEM_ID").Value, 4) > 0 Then
            MessageBox.Show("Product already add into list.Pleas check again!", "Sale", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim KHRAmount As Double = 0
        Dim THBAmount As Double = 0
        Dim USDAmount As Double = 0
        Dim Discount As Double = 0
        Dim Cost As Double = txtCost.Text
        Dim Amount As Double = 0
        If Me.TxtDiscount.Text = "" Then
            Discount = 0
        Else
            Discount = CDec(Me.TxtDiscount.Text)
        End If
        Dim PriceAfterDiscount As Double = CDbl(EmptyString(Me.txtPrice.Text)) - CDbl(EmptyString(Me.TxtDiscount.Text))
        Amount = CDbl(EmptyString(Me.txtQty.Text)) * PriceAfterDiscount
        Me.txtAmount.Text = Amount
        'If Me.CboCurrency.SelectedValue.ToString = "$" Then
        '    USDAmount = CDec(EmptyString(Me.txtAmount.Text))
        'ElseIf Me.CboCurrency.SelectedValue.ToString = "៛" Then
        '    KHRAmount = CDec(EmptyString(Me.txtAmount.Text))
        'Else
        '    THBAmount = CDec(EmptyString(Me.txtAmount.Text))
        'End If
        If DAPreInvoice.InsertDetail(GridProductList.GetRow.Cells("ITEM_ID").Value, LblMainStcok.Text, _
                                     CDbl(EmptyString(Me.txtQty.Text)), CDbl(EmptyString(Me.txtPrice.Text)), Discount, "$", _
                                     0, EmptyString(txtAmount.Text), 0, getCurrentUserID, 0, 0, False, Cost, Nothing) = 1 Then
            'If ChQTYFree.Checked = True Then
            '    DAPreInvoice.InsertDetail(GridProductList.GetRow.Cells("ITEM_ID").Value, Me.cboUnitFree.Text, _
            '                              EmptyString(TxtQTYFree.Text), 0, Discount, Me.CboCurrency.SelectedValue.ToString, _
            '                              0, 0, 0, getCurrentUserID, EmptyString(TxtQTYFree.Text), Me.cboUnitFree.Text, True)
            'End If
            PSale.RefreshOrderList()
            txtBarcode.Select()
            txtBarcode.SelectAll()
            txtBarcode.Focus()
            CleanInterface()
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
        txtCost.Text = "0"
        GridProductList.DataSource = Nothing
    End Sub



    Private Sub AddProductSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        LblMainStcok.Text = ""
        LblSub.Text = ""
        Me.CboCurrency.DataSource = DACurrency.SelectAllCurrencies
        Me.CboCurrency.DisplayMember = "CURR_CODE"
        Me.CboCurrency.ValueMember = "CURR_CODE"
        Me.CboCurrency.SelectedIndex = -1
        GridProductList.DataSource = DAItem.SelectByAllProduct
        txtBarcode.Select()
        txtBarcode.SelectAll()
        txtBarcode.Focus()
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

    Private Sub LblCurrency_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblCurrency.Click

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
            cboUnitFree.DataSource = Nothing
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
                txtPrice.Text = rows("USD_PRICE")
            Next
            Me.cboUnit.DataSource = DABalance.SelectStoreByItemID(CInt(GridProductList.GetRow.Cells("ITEM_ID").Value))
            Me.cboUnit.DisplayMember = "UNIT_NAME"
            Me.cboUnit.ValueMember = "UNIT_NAME"
            Me.cboUnit.SelectedIndex = -1
            Dim tblCost As DataTable = DaItemCost.SelectCurrentPrice(GridProductList.GetRow.Cells("ITEM_ID").Value, 1)
            For Each rowCost As DataRow In tblCost.Rows
                Me.txtCost.Text = rowCost("USD_COST")
            Next
            PictProduct.Image = byteArrayToImage(DAItem.SelectImageID(GridProductList.CurrentRow.Cells("ITEM_ID").Value))
            'CboCurrency.Text = ""
            ' LoadItem()
            'cboUnit.Focus()
            'cboUnit.SelectAll()
            'Me.cboUnit.SelectedIndex = -1
            'txtQty.Focus()
            'txtQty.SelectAll()
            ' txtPrice.Text = ""
            'txtQty.SelectAll()
            'txtQty.Focus()
        Catch ex As Exception
            PictProduct.Image = Nothing
            ' CboCurrency.Text = ""
            'CboCurrency.Select()
            'CboCurrency.Focus()
            txtPrice.Text = "0"
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
                GridProductList.DataSource = DAItem.SelectAutoComplet(txtSearchProduct.Text.ToUpper)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnAddProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FNewProduct1 As New NewProductV1
        FNewProduct1.IS_AddFromSale = True
        If FNewProduct1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            GridProductList.DataSource = DAItem.SelectByAllProduct
        End If
    End Sub

    Private Sub txtBarcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If txtBarcode.Text = "" Then
                    GridProductList.DataSource = DAItem.SelectByAllProduct
                Else
                    GridProductList.DataSource = DAItem.SelectItemByBarode(txtBarcode.Text)
                    txtBarcode.Select()
                    txtBarcode.SelectAll()
                    txtQty.Focus()
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class