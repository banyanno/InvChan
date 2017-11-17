Public Class NewProduct
    Dim DAItem As New DSInventoryTableAdapters.ITEMSTableAdapter
    Dim DABalance As New DSInventoryTableAdapters.ITEM_BALANCETableAdapter
    Dim DACategory As New DSInventoryTableAdapters.CATEGORIESTableAdapter
    Dim DACurrency As New DSInventoryTableAdapters.CURRENCIESTableAdapter
    Dim DAUnit As New DSInventoryTableAdapters.UNITSTableAdapter
    Dim DAUnit1 As New DSInventoryTableAdapters.UNITSTableAdapter
    Dim DAPrice As New DSInventoryTableAdapters.ITEM_PRICESTableAdapter
    Dim DACost As New DSInventoryTableAdapters.ITEM_COSTSTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.CboCategory.DataSource = DACategory.SelectAllCategories
        Me.CboCategory.DisplayMember = "CATE_NAME"
        Me.CboCategory.ValueMember = "CATE_ID"
        Me.CboCategory.SelectedIndex = -1

        Me.CboMUnit.DataSource = DAUnit.SelectAllUnits
        Me.CboMUnit.DisplayMember = "UNIT_NAME"
        Me.CboMUnit.ValueMember = "UNIT_ID"
        Me.CboMUnit.SelectedIndex = -1

        Me.CboSUnit.DataSource = DAUnit1.SelectAllUnits
        Me.CboSUnit.DisplayMember = "UNIT_NAME"
        Me.CboSUnit.ValueMember = "UNIT_ID"
        Me.CboSUnit.SelectedIndex = -1
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtBarcode, "", ErrorUpdate) = False Then Exit Sub
        If ValidateTextField(txtItemName, "", ErrorUpdate) = False Then Exit Sub
        If ValidateCombobox(CboCategory, "", ErrorUpdate) = False Then Exit Sub
        If ValidateCombobox(CboMUnit, "", ErrorUpdate) = False Then Exit Sub
        If ValidateCombobox(CboSUnit, "", ErrorUpdate) = False Then Exit Sub
        If ProdImg.Image Is Nothing Then
            UiTab2.SelectedIndex = 1
            Exit Sub
        End If

        Dim ItemBarcode As String = TxtBarcode.Text
        Dim ItemName As String = Me.txtItemName.Text.Replace("'", "''")
        Dim CategoryID As Integer = CInt(Me.CboCategory.SelectedValue)
        Dim ItemImage() As Byte = ImageToByArray(ReductImageSize(ProdImg.Image))
        Dim MainUnit As String = CboMUnit.Text
        Dim MainRatioQty As Integer = CInt(EmptyString(Me.txtMRatioQty.Text))
        Dim SubUnit As String = CboSUnit.Text
        Dim SubRatioQty As Integer = CInt(EmptyString(Me.txtSRatioQty.Text))

        If MessageBox.Show("Do you want to update product information?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DAItem.UpdateItem(ItemBarcode, ItemName, CategoryID, ItemImage, getCurrentUserID, FormatDateTime(Now, DateFormat.ShortDate), lblStatus.Text) = 1 Then
                ' Update Main Unit
                DABalance.UpdateUnit(MainUnit, 1, lblStatus.Text, "Main Unit")
                ' Update Sub Unit
                DABalance.UpdateUnit(SubUnit, SubRatioQty, lblStatus.Text, "Sub Unit")
                ' DAItem.Impge(ItemImage)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub NewProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtBarcode.Focus()
    End Sub

    Private Sub CboMUnit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        SetDisableKey(e)
    End Sub

    Private Sub CboSUnit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        SetDisableKey(e)
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
End Class