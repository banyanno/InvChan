Imports System.IO

Public Class NewProductV1

    Dim DAItem As New DSInventoryTableAdapters.ITEMSTableAdapter
    Dim DABalance As New DSInventoryTableAdapters.ITEM_BALANCETableAdapter
    Dim DACategory As New DSInventoryTableAdapters.CATEGORIESTableAdapter
    Dim DACurrency As New DSInventoryTableAdapters.CURRENCIESTableAdapter
    Dim DAUnit As New DSInventoryTableAdapters.UNITSTableAdapter
    Dim DAPrice As New DSInventoryTableAdapters.ITEM_PRICESTableAdapter
    Dim DACost As New DSInventoryTableAdapters.ITEM_COSTSTableAdapter
    Dim PItem As DashboardItems
    Dim DAITEM1 As New DSInventoryTableAdapters.CentralStoreTableAdapter
    Public IS_AddFromSale As Boolean = False

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.CboCategory.DataSource = DACategory.SelectAllCategories
        Me.CboCategory.DisplayMember = "CATE_NAME"
        Me.CboCategory.ValueMember = "CATE_ID"

        Me.CboMUnit.DataSource = DAUnit.SelectAllUnits
        Me.CboMUnit.DisplayMember = "UNIT_NAME"
        Me.CboMUnit.ValueMember = "UNIT_NAME"

        Me.CboSUnit.DataSource = DAUnit.SelectAllUnits
        Me.CboSUnit.DisplayMember = "UNIT_NAME"
        Me.CboSUnit.ValueMember = "UNIT_NAME"

        CleanInterface()
    End Sub
    Sub New(ByVal MyPanel As DashboardItems)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PItem = MyPanel

        Me.CboCategory.DataSource = DACategory.SelectAllCategories
        Me.CboCategory.DisplayMember = "CATE_NAME"
        Me.CboCategory.ValueMember = "CATE_ID"

        Me.CboMUnit.DataSource = DAUnit.SelectAllUnits
        Me.CboMUnit.DisplayMember = "UNIT_NAME"
        Me.CboMUnit.ValueMember = "UNIT_NAME"

        Me.CboSUnit.DataSource = DAUnit.SelectAllUnits
        Me.CboSUnit.DisplayMember = "UNIT_NAME"
        Me.CboSUnit.ValueMember = "UNIT_NAME"

        CleanInterface()
    End Sub


   
    Sub ClearData()
        Me.txtItemName.Text = ""
        Me.txtMBalance.Text = "0"
        Me.txtSBalance.Text = "0"
        'Me.txtMRatioQty.Text = ""
        Me.txtSRatioQty.Text = ""
        Me.txtRPrice.Text = ""
        Me.txtWUSDPrice.Text = ""
        Me.txtWTHBPrice.Text = "0"
        Me.txtWKHRPrice.Text = "0"
        Me.txtUSDCost.Text = ""
        Me.txtKHRCost.Text = "0"
        Me.txtTHBCost.Text = "0"
        Me.txtItemName.Focus()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If ValidateTextField(TxtBarcode, "", ErrProduct) = False Then Exit Sub
        If ValidateTextField(txtItemName, "", ErrProduct) = False Then Exit Sub
        If ValidateCombobox(CboCategory, "", ErrProduct) = False Then
            UiTab2.SelectedIndex = 0
            Exit Sub
        End If
        If ValidateCombobox(CboMUnit, "", ErrProduct) = False Then
            UiTab2.SelectedIndex = 0
            Exit Sub
        End If
        If ValidateCombobox(CboSUnit, "", ErrProduct) = False Then
            UiTab2.SelectedIndex = 0
            Exit Sub
        End If
        'If ValidateTextField(txtSBalance, "", ErrProduct) = False Then Exit Sub
        If ValidateTextField(txtMRatioQty, "", ErrProduct) = False Then Exit Sub
        If ValidateTextField(txtSRatioQty, "", ErrProduct) = False Then Exit Sub

        If ValidateTextField(txtWUSDPrice, "", ErrProduct) = False Then
            UiTab2.SelectedIndex = 1
            Exit Sub
        End If

        'If ValidateTextField(txtUSDCost, "", ErrProduct) = False Then
        '    If ValidateTextField(txtWUSDPrice, "", ErrProduct) = False Then
        '        UiTab2.SelectedIndex = 1
        '        Exit Sub
        '    End If
        'End If

        If ValidateTextField(txtWUSDPrice, "", ErrProduct) = False Then
            UiTab2.SelectedIndex = 1
            Exit Sub
        End If
        If ValidateTextField(txtUSDCost, "", ErrProduct) = False Then
            UiTab2.SelectedIndex = 1
            Exit Sub
        End If

        If ValidateTextField(txtRPrice, "", ErrProduct) = False Then
            UiTab2.SelectedIndex = 1
            Exit Sub
        End If


        'If ValidateTextField(txtWKHRPrice, "", ErrProduct) = False Then Exit Sub
        'If ValidateTextField(txtWTHBPrice, "", ErrProduct) = False Then Exit Sub



        'If ValidateTextField(txtKHRCost, "", ErrProduct) = False Then Exit Sub
        'If ValidateTextField(txtTHBCost, "", ErrProduct) = False Then Exit Sub


        'If ValidateTextField(txtRPrice, "", ErrProduct) = False Then Exit Sub
        ' If ValidateTextField(txtMBalance, "", ErrProduct) = False Then Exit Sub
        If DAITEM1.CheckExistingBardcode(TxtBarcode.Text) > 0 Then
            MessageBox.Show("Bard code aready exist in system. Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtBarcode.Focus()
            TxtBarcode.SelectAll()
            Exit Sub
        End If

        If CDbl(EmptyString(txtUSDCost.Text)) <= CDbl(EmptyString(txtWUSDPrice.Text)) Then
            MessageBox.Show("តំលៃលក់មិនអាច តូចជាង តំលៃដើម", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtUSDCost.Focus()
            txtUSDCost.SelectAll()
            Exit Sub
        End If
        If CDbl(EmptyString(txtRPrice.Text)) <= CDbl(EmptyString(txtWUSDPrice.Text)) Then
            MessageBox.Show("តំលៃលក់មិនអាច តូចជាង តំលៃដើម", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtRPrice.Focus()
            txtRPrice.SelectAll()
            Exit Sub
        End If
        If ProdImg.Image Is Nothing Then
            MessageBox.Show("Please select image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UiTab2.SelectedIndex = 2
            Exit Sub
            ProdImg.Select()
            ProdImg.Focus()
            Exit Sub
        End If
        Dim ItemBarcode As String = TxtBarcode.Text
        Dim ItemName As String = Me.txtItemName.Text.Replace("'", "''")
        Dim CategoryID As Integer = CInt(Me.CboCategory.SelectedValue)
        Dim ItemImage() As Byte = ImageToByArray(ReductImageSize(ProdImg.Image))
        Dim MainUnit As String = CboMUnit.Text
        Dim MainRatioQty As Decimal = CDec(EmptyString(Me.txtMRatioQty.Text))
        Dim MainBalance As Decimal = CDec(EmptyString(Me.txtMBalance.Text))
        Dim SubUnit As String = CboSUnit.Text
        Dim SubRatioQty As Integer = CInt(EmptyString(Me.txtSRatioQty.Text))
        Dim SubBalance As Integer = CInt(EmptyString(Me.txtSBalance.Text))
        Dim RetailPrice As Decimal = CDec(EmptyString(Me.txtRPrice.Text))
        Dim WUSDPrice As Decimal = CDec(EmptyString(Me.txtWUSDPrice.Text))
        Dim WTHBPrice As Decimal = CDec(EmptyString(Me.txtWTHBPrice.Text))
        Dim WKHRPrice As Decimal = CDec(EmptyString(Me.txtWKHRPrice.Text))
        Dim USDCost As Decimal = CDec(EmptyString(Me.txtUSDCost.Text))
        Dim THBCost As Decimal = CDec(EmptyString(Me.txtTHBCost.Text))
        Dim KHRCost As Decimal = CDec(EmptyString(Me.txtKHRCost.Text))
        If MessageBox.Show("Do you want save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If Me.lblStatus.Text = 0 Then
                '' INSERT ITEM
                DAItem.InsertItem(ItemBarcode, ItemName, CategoryID, ItemImage, getCurrentUserID, FormatDateTime(Now, DateFormat.ShortDate))
                '' INSERT BALANCE
                DABalance.InsertBalance(DAItem.SelectMaxItemID, "Main Unit", MainUnit, MainRatioQty, MainBalance)
                DABalance.InsertBalance(DAItem.SelectMaxItemID, "Sub Unit", SubUnit, SubRatioQty, SubBalance)
                '' INSERT PRICE
                DAPrice.InsertPrice(DAItem.SelectMaxItemID, USDCost, WKHRPrice, WTHBPrice, RetailPrice, 1, getCurrentUserID, FormatDateTime(Now, DateFormat.ShortDate))
                '' INSERT COST
                DACost.InsertCost(DAItem.SelectMaxItemID, WUSDPrice, KHRCost, THBCost, 1, getCurrentUserID, FormatDateTime(Now, DateFormat.ShortDate))
                CleanInterface()
                'ClearData()
                MsgBox("The item was added successfully", MsgBoxStyle.Information)
                If IS_AddFromSale = False Then
                    Try
                        PItem.RefreshData()
                    Catch ex As Exception

                    End Try

                Else
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            Else
                ''UPDATE ITEM
                DAItem.UpdateItem(ItemBarcode, ItemName, CategoryID, ItemImage, getCurrentUserID, FormatDateTime(Now, DateFormat.ShortDate), CInt(PItem.StoreList.CurrentRow.Cells("ITEM_ID").Value))
                ''UPDATE LAST PRICE & COST
                DAPrice.UpdateLastPrice(CInt(PItem.StoreList.CurrentRow.Cells("ITEM_ID").Value), WUSDPrice, WKHRPrice, WTHBPrice, RetailPrice, getCurrentUserID, FormatDateTime(Now, DateFormat.ShortDate))
                DACost.UpdateLastCost(CInt(PItem.StoreList.CurrentRow.Cells("ITEM_ID").Value), USDCost, KHRCost, THBCost, getCurrentUserID, FormatDateTime(Now, DateFormat.ShortDate))
                CleanInterface()
                'ClearData()
                MsgBox("The item was updated successfully", MsgBoxStyle.Information)

                PItem.RefreshData()

                Me.Close()
            End If
        End If

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub NewCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtBarcode.Select()
        TxtBarcode.Focus()
    End Sub
    Private Sub CleanInterface()
        lblStatus.Text = "0"
        TxtBarcode.Text = ""
        ProdImg.Image = Nothing
        txtItemName.Text = ""
        CboCategory.SelectedIndex = -1
        txtMBalance.Text = ""
        CboMUnit.SelectedIndex = -1
        txtSBalance.Text = ""
        CboSUnit.SelectedIndex = -1
        'txtMRatioQty.Text = "0"
        txtSRatioQty.Text = ""
        txtRPrice.Text = ""
        txtWKHRPrice.Text = ""
        txtWTHBPrice.Text = ""
        txtWUSDPrice.Text = ""

        txtUSDCost.Text = ""
        txtTHBCost.Text = ""
        txtKHRCost.Text = ""

        TxtBarcode.Select()
        TxtBarcode.Focus()

    End Sub

    Private Sub txtMBalance_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMBalance.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub txtSBalance_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSBalance.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub txtMRatioQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMRatioQty.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub txtSRatioQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSRatioQty.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub txtRPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        SetDisableKeyString(e)
    End Sub

    Private Sub txtWUSDPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWUSDPrice.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub txtWTHBPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWTHBPrice.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub txtWKHRPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWKHRPrice.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub txtUSDCost_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUSDCost.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub txtTHBCost_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTHBCost.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub txtKHRCost_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKHRCost.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub CboMUnit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboMUnit.SelectedIndexChanged
        LblMeasur1.Text = CboMUnit.Text
    End Sub

    Private Sub CboSUnit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSUnit.SelectedIndexChanged
        LblMeasur2.Text = CboSUnit.Text
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BtnNewCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewCategory.Click
        Dim NCat As New NewCategory
        If NCat.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.CboCategory.DataSource = DACategory.SelectAllCategories
            Me.CboCategory.DisplayMember = "CATE_NAME"
            Me.CboCategory.ValueMember = "CATE_ID"
        End If
    End Sub

    Private Sub BtnMainUnit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMainUnit.Click
        Dim NUnit As New NewMeasurement
        If NUnit.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.CboMUnit.DataSource = DAUnit.SelectAllUnits
            Me.CboMUnit.DisplayMember = "UNIT_NAME"
            Me.CboMUnit.ValueMember = "UNIT_NAME"

            Me.CboSUnit.DataSource = DAUnit.SelectAllUnits
            Me.CboSUnit.DisplayMember = "UNIT_NAME"
            Me.CboSUnit.ValueMember = "UNIT_NAME"
        End If
    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub



    Private Sub ProdImg_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdImg.DoubleClick
        OpenFileDialog1.Filter = "Image Files (JPG,PNG,GIF)|*.JPG;*.PNG;*.GIF"
        'OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Title = "Please select an image file"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each FName As String In OpenFileDialog1.FileNames
                'DA_ImageDiagnosis.InsertNewConsult(LblWaitingNo.Text, ReadFileToBye(FName))
                ProdImg.Image = byteArrayToImage(ReadFile(FName))
            Next
            'GridImageList.DataSource = DA_ImageDiagnosis.SelectByWaitingNo(LblWaitingNo.Text)
            'Else
            '    ProdImg.Image = Nothing
        End If
    End Sub

    Private Sub txtRPrice_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRPrice.KeyPress
        SetDisableKeyString(e)
    End Sub

    'Private Sub txtMBalance_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMBalance.KeyUp
    '    If e.KeyValue = 190 Then
    '        MessageBox.Show("You are can not type .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        txtMBalance.Text = 0
    '        txtMBalance.Focus()
    '        txtMBalance.SelectAll()
    '    End If
    'End Sub

    'Private Sub txtSRatioQty_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSRatioQty.KeyUp
    '    If e.KeyValue = 190 Then
    '        MessageBox.Show("You are can not type .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        txtSRatioQty.Text = 0
    '        txtSRatioQty.Focus()
    '        txtSRatioQty.SelectAll()
    '    End If
    'End Sub
End Class