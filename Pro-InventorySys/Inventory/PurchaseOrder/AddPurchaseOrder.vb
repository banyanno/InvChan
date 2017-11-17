Public Class AddPurchaseOrder
    Dim DAItem As New DSInventoryTableAdapters.ITEMSTableAdapter
    Dim DAItemUnit As New DSPurchaseOrderTableAdapters.ITEM_BALANCETableAdapter
    Dim DACost As New DSPurchaseOrderTableAdapters.ITEM_COSTSTableAdapter
    Dim DAItemcheck As New DSPurchaseOrderTableAdapters.ORDER_DETAILS_TEMTableAdapter
    Dim DABalance As New DSInventoryTableAdapters.ITEM_BALANCETableAdapter
    Dim POrder As New PurchaseOrder
    Dim FReceiveItme As FormReceiveProduct
    Dim DAPurchasOrderDetailTem As New DSPurchaseOrderTableAdapters.ORDER_DETAILS_TEMTableAdapter
    Sub New(ByVal FReceiveItme As FormReceiveProduct)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.FReceiveItme = FReceiveItme
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal POrder As PurchaseOrder)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.POrder = POrder
      
        ' Add any initialization after the InitializeComponent() call.
        'With cboUnit
        '    .DataSource = TblUnit
        '    .DisplayMember = "UNIT_NAME"
        'End With
        'With cboUnitFree
        '    .DataSource = DABalance.SelectStoreByItemID(CInt(ItemID))
        '    .DisplayMember = "UNIT_NAME"
        '    .SelectedIndex = -1
        'End With

    End Sub
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
    Private Sub ShowSubUnit(ByVal ItemID As Integer)
        Dim tblSubUint As DataTable = DAItemUnit.SelectSubUnit(ItemID)
        For Each rows As DataRow In tblSubUint.Rows
            txtContain.Text = rows("RATIO_QTY") & " " & rows("UNIT_NAME")
        Next
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

        'If ValidateCombobox(CboCurrency, "", ErrProduct) = False Then Exit Sub
        If ValidateTextField(txtCost, "", ErrProduct) = False Then Exit Sub
        If ValidateTextField(txtQTY, "", ErrProduct) = False Then Exit Sub
        If ValidateTextField(TxtTotalCost, "", ErrProduct) = False Then Exit Sub
        If DAItemcheck.CheckExitingItem(lblOrderNo.Text, GridProductList.GetRow.Cells("ITEM_ID").Value).Rows.Count > 0 Then
            MessageBox.Show("មុខទំនិញ៉ (" & TxtProductName.Text & ") មាននៅក្នុងតារាង បញ្ជាទិញហើយ អ្នកមិនអាចបន្ថែមទៀតបានទេ!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim TotalCostUSD As Double = 0
        Dim TotalCostKHR As Double = 0
        Dim TotalCostTHB As Double = 0
    
        TotalCostUSD = EmptyString(txtQTY.Text) * EmptyString(txtCost.Text)
        If Me.AddItemDetial(lblOrderNo.Text, CDbl(GridProductList.GetRow.Cells("ITEM_ID").Value), TxtProductName.Text, "Main Unit", EmptyString(txtQTY.Text), 0, EmptyString(txtCost.Text), 0, TotalCostUSD, 0, "$", "") = 1 Then
            FReceiveItme.SelectDetailOrder(lblOrderNo.Text)
            FReceiveItme.AddTotolCast()
            ClearnForm()
        End If
    End Sub
    Public Function AddItemDetial(ByVal OrderNo As Double, ByVal ProductID As Integer, ByVal ProductName As String, ByVal UnitName As String, _
                            ByVal QTY As Double, ByVal ProQTY As Double, ByVal Cost As Double, ByVal TotalCostR As Double, _
                            ByVal TotalCostD As Double, ByVal TotalCostB As Double, ByVal IS_Currency As String, ByVal UNIT_NAME_FREE As String) As Integer
        If DAPurchasOrderDetailTem.InsertPreOrder(OrderNo, ProductID, UnitName, QTY, Cost, TotalCostD, TotalCostR, TotalCostB, IS_Currency, ProQTY, UNIT_NAME_FREE) = 1 Then
            Return 1
        Else
            Return 0
        End If

    End Function
  
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
            'Dim tbl As DataTable = DACost.SelectCostOfItem(GridProductList.GetRow.Cells("ITEM_ID").Value, CboCurrency.Text)
            'For Each row As DataRow In tbl.Rows
            '    txtCost.Text = row("COST")
            'Next
            'txtQTY.Select()
            'txtQTY.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtQTY_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQTY.KeyUp
        'If e.KeyValue = 190 Then
        '    MessageBox.Show("You are can not type .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtQTY.Text = 0
        '    txtQTY.Focus()
        '    txtQTY.SelectAll()

        'End If
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
        ShowSubUnit(GridProductList.GetRow.Cells("ITEM_ID").Value)
        TxtProductName.Text = GridProductList.GetRow.Cells("ITEM_NAME").Value
        txtCost.Text = DACost.SelectCurrencyUSD(GridProductList.GetRow.Cells("ITEM_ID").Value)
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
        Try
            If txtSearchProduct.Text = "" Then
                GridProductList.DataSource = DAItem.SelectByAllProduct
            Else
                GridProductList.DataSource = DAItem.SelectAutoComplet(txtSearchProduct.Text)
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

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub BtnAddProduct_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddProduct.Click
        Dim FrmItem As New NewProductV1
        FrmItem.lblStatus.Text = 0
        FrmItem.ShowDialog()
    End Sub
End Class