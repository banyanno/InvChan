Public Class PriceAndCost
    Dim DAPrice As New DSInventoryTableAdapters.ITEM_PRICESTableAdapter
    Dim PItem As DashboardItems

    Sub New(ByVal MyPanel As DashboardItems)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PItem = MyPanel
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(txtUSDPrice, "", ErrorProvider1) = False Then Exit Sub
        If ValidateTextField(txtRetailPrice, "", ErrorProvider1) = False Then Exit Sub
        If CDbl(EmptyString(txtUSDPrice.Text)) <= CDbl(EmptyString(TxtCost.Text)) Then
            MessageBox.Show("Please enter sale price > cost", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUSDPrice.Focus()
            Exit Sub
        End If
        If CDbl(EmptyString(txtRetailPrice.Text)) <= EmptyString(EmptyString(TxtCost.Text)) Then
            MessageBox.Show("Please enter sale price > cost", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRetailPrice.Focus()
            Exit Sub
        End If
        Dim ItemID As Integer = CInt(PItem.StoreList.CurrentRow.Cells("ITEM_ID").Value)
        Dim RetailPrice As Decimal = CDec(EmptyString(Me.txtRetailPrice.Text))
        Dim USDPrice As Decimal = CDec(EmptyString(Me.txtUSDPrice.Text))
        Dim THBPrice As Decimal = CDec(EmptyString(Me.txtTHBPrice.Text))
        Dim KHRPrice As Decimal = CDec(EmptyString(Me.txtKHRPrice.Text))
        DAPrice.ResetLastPrice(ItemID)
        DAPrice.InsertPrice(ItemID, USDPrice, KHRPrice, THBPrice, RetailPrice, 1, getCurrentUserID, FormatDateTime(Now, DateFormat.ShortDate))
        MsgBox("The price was added successfully", MsgBoxStyle.Information)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        'PItem.PriceList.DataSource = DAPrice.SelectByItemID(ItemID)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub PriceAndCost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtItemName.Select()
        txtItemName.Focus()
    End Sub

    Private Sub txtUSDPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUSDPrice.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub txtRetailPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRetailPrice.KeyPress
        SetDisableKeyString(e)
    End Sub

    
    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        SetDisableKeyString(e)
    End Sub
End Class