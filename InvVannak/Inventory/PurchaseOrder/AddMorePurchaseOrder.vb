Public Class AddMorePurchaseOrder
    Dim DAItem As New DSInventoryTableAdapters.ITEMSTableAdapter
    Dim DAItemUnit As New DSPurchaseOrderTableAdapters.ITEM_BALANCETableAdapter
    Dim DACost As New DSPurchaseOrderTableAdapters.ITEM_COSTSTableAdapter
    Dim DAItemcheck As New DSPurchaseOrderTableAdapters.ORDER_DETAILS_TEMTableAdapter
    Dim DABalance As New DSInventoryTableAdapters.ITEM_BALANCETableAdapter
    Dim POrder As PurchaseOrder
    Dim DAPurchaseOrderDetail As New DSPurchaseOrderTableAdapters.ORDER_DETAILSTableAdapter
    Dim DAPurchaseOrder As New DSPurchaseOrderTableAdapters.ORDERSTableAdapter
    Private Sub ShowUnit(ByVal ItemID As Integer)
        Dim TblUnit As DataTable = DAItemUnit.SelectMainUnit(ItemID)
        With cboUnit
            .DataSource = TblUnit
            .DisplayMember = "UNIT_NAME"
        End With
        With cboUnitFree
            .DataSource = DABalance.SelectStoreByItemID(CInt(ItemID))
            .DisplayMember = "UNIT_NAME"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Private Sub cleanInterface()
        CboCurrency.SelectedIndex = -1
        CboCurrency.Text = ""
        TxtProductName.Text = ""
        txtCost.Text = ""
        txtQTY.Text = ""
        TxtTotalCost.Text = ""
    End Sub

    Private Sub txtQTY_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQTY.GotFocus
        SetEnglishLanguage()
    End Sub

    Private Sub txtQTY_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQTY.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click

        If ValidateCombobox(CboCurrency, "", ErrProduct) = False Then Exit Sub
        If ValidateTextField(txtCost, "", ErrProduct) = False Then Exit Sub
        If ValidateTextField(txtQTY, "", ErrProduct) = False Then Exit Sub
        If ValidateTextField(TxtTotalCost, "", ErrProduct) = False Then Exit Sub
        If DAPurchaseOrderDetail.CheckExistItem(lblOrderNo.Text, GridProductList.GetRow.Cells("ITEM_ID").Value) > 0 Then
            MessageBox.Show("មុខទំនិញ៉ (" & TxtProductName.Text & ") មាននៅក្នុងតារាង បញ្ជាទិញហើយ អ្នកមិនអាចបន្ថែមទៀតបានទេ!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim TotalCostUSD As Double = 0
        Dim TotalCostKHR As Double = 0
        Dim TotalCostTHB As Double = 0
        If CboCurrency.Text = "៛" Then
            TotalCostKHR = txtQTY.Text * txtCost.Text
            TotalCostTHB = 0
            TotalCostUSD = 0
        ElseIf CboCurrency.Text = "B" Then
            TotalCostTHB = txtQTY.Text * txtCost.Text
            TotalCostKHR = 0
            TotalCostUSD = 0

        ElseIf CboCurrency.Text = "$" Then
            TotalCostUSD = txtQTY.Text * txtCost.Text
            TotalCostKHR = 0
            TotalCostTHB = 0
        End If
        If ChQTYFree.Checked = True Then
            If ValidateTextField(TxtQTYFree, "", ErrProduct) = False Then Exit Sub
            If ValidateCombobox(cboUnitFree, "", ErrProduct) = False Then Exit Sub
        End If

        Dim ProductID As Double = 0
        Dim UnitName As String = ""
        Dim UnitNameFee As String = ""
        Dim Cost As Double = 0
        Dim QTY_Order As Integer = 0
        Dim QTY_Free As Integer = 0
     
        Dim IS_Currency As String = ""


        ProductID = GridProductList.GetRow.Cells("ITEM_ID").Value
        UnitName = cboUnit.Text
        UnitNameFee = cboUnitFree.Text
        IS_Currency = CboCurrency.Text
        Cost = EmptyString(txtCost.Text)
        QTY_Order = EmptyString(txtQTY.Text)
        QTY_Free = EmptyString(TxtQTYFree.Text)
        If MessageBox.Show("Do you want to add more product", "Add product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DAPurchaseOrderDetail.InsertPurchaseOrderDetail(lblOrderNo.Text, ProductID, UnitName, QTY_Order, Cost, TotalCostUSD, TotalCostKHR, TotalCostTHB, IS_Currency, QTY_Free, UnitNameFee, 0) = 1 Then
                If DAPurchaseOrder.UpdateTotalPrice(LblKHRTotal.Text + TotalCostKHR, LblUSDTotal.Text + TotalCostUSD, LblTHBTotal.Text + TotalCostTHB, lblOrderNo.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub


    Private Sub CboCurrency_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCurrency.SelectedIndexChanged
        Try
            LblTotalCost.Text = "Total Cost:(" & CboCurrency.Text & ")"
            If CboCurrency.Text = "$" Then
                txtCost.Text = DACost.SelectCurrencyUSD(GridProductList.GetRow.Cells("ITEM_ID").Value)

            ElseIf CboCurrency.Text = "B" Then
                txtCost.Text = DACost.SelectCurrencyTHB(GridProductList.GetRow.Cells("ITEM_ID").Value)
            ElseIf CboCurrency.Text = "៛" Then
                txtCost.Text = DACost.SelectCurrencyKHR(GridProductList.GetRow.Cells("ITEM_ID").Value)
            End If
            'Dim tbl As DataTable = DACost.SelectCostOfItem(CboProduct.SelectedValue, CboCurrency.Text)
            'For Each row As DataRow In tbl.Rows
            '    txtCost.Text = row("COST")
            'Next
            'txtQTY.Select()
            'txtQTY.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtQTY_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQTY.KeyUp
        If e.KeyValue = 190 Then
            MessageBox.Show("You are can not type .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtQTY.Text = 0
            txtQTY.Focus()
            txtQTY.SelectAll()
            Exit Sub
        End If
        Try
            TxtTotalCost.Text = EmptyString(txtQTY.Text) * EmptyString(txtCost.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCost_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCost.GotFocus
        SetEnglishLanguage()
    End Sub

    Private Sub txtCost_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCost.KeyPress
        SetDisableKeyString(e)
    End Sub


    Private Sub ClearnForm()
        TxtProductName.Text = ""
        cboUnit.Text = ""
        CboCurrency.SelectedIndex = -1
        txtCost.Text = ""
        txtQTY.Text = ""
        TxtQTYFree.Text = ""
        cboUnitFree.Text = ""
        ChQTYFree.Checked = False
        TxtTotalCost.Text = ""

    End Sub

    Private Sub txtQTY_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQTY.Enter
        SetEnglishLanguage()
    End Sub




    Private Sub txtCost_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCost.KeyUp
        Try
            TxtTotalCost.Text = EmptyString(txtQTY.Text) * EmptyString(txtCost.Text)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub TxtQTYPromotion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        SetDisableKeyString(e)
    End Sub

    Private Sub CboCurrency_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboCurrency.KeyPress
        SetDisableKey(e)
    End Sub

    Private Sub TxtQTYFree_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtQTYFree.KeyUp
        If e.KeyValue = 190 Then
            MessageBox.Show("You are can not type .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtQTYFree.Text = 0
            TxtQTYFree.Focus()
            TxtQTYFree.SelectAll()
        End If
    End Sub

    Private Sub TxtQTYFree_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtQTYFree.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub ChQTYFree_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChQTYFree.CheckedChanged
        GroupQTYFree.Enabled = ChQTYFree.Checked
        TxtQTYFree.Text = ""
        cboUnitFree.Text = ""
    End Sub

    Private Sub cboUnitFree_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboUnitFree.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub txtSearchProduct_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchProduct.GotFocus
        SetKhmerLanguage()
    End Sub

    Private Sub txtSearchProduct_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearchProduct.KeyUp
        Try
            If txtSearchProduct.Text = "" Then
                GridProductList.DataSource = DAItem.SelectByAllProduct
            Else
                GridProductList.DataSource = DAItem.SelectAutoComplet(txtSearchProduct.Text)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridProductList_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridProductList.SelectionChanged
        ClearnForm()
        If GridProductList.SelectedItems.Count = 0 Then Exit Sub
        'Try
        ShowUnit(GridProductList.GetRow.Cells("ITEM_ID").Value)
        TxtProductName.Text = GridProductList.GetRow.Cells("ITEM_NAME").Value
        '    Try
        '        'LblTotalCost.Text = "Total Cost:(" & CboCurrency.Text & ")"
        '        'Dim tbl As DataTable = DACost.SelectCostOfItem(CboProduct.SelectedValue, CboCurrency.Text)
        '        'For Each row As DataRow In tbl.Rows
        '        '    txtCost.Text = row("COST")
        '        'Next
        '        'CboCurrency.Select()
        '        'CboCurrency.Focus()
        '    Catch ex As Exception

        '    End Try
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub AddPurchaseOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSearchProduct.Select()
        txtSearchProduct.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FNewProduct1 As New NewProductV1
        FNewProduct1.IS_AddFromSale = True
        If FNewProduct1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            GridProductList.DataSource = DAItem.SelectByAllProduct
        End If
    End Sub
End Class