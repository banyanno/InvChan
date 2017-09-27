Public Class ProductCost
    Dim DACost As New DSInventoryTableAdapters.ITEM_COSTSTableAdapter
    Dim PItem As DashboardItems
    Sub New(ByVal PItem As DashboardItems)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.PItem = PItem
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub ProductCost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtItemName.Select()
        txtItemName.Focus()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(txtUSDCost, "", ErrorProvider1) = False Then Exit Sub
        If MessageBox.Show("Do you want to save new cost?", "Cost", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim ItemId As Integer = CInt(PItem.StoreList.CurrentRow.Cells("ITEM_ID").Value)
            DACost.ResetLastCost(ItemId)
            DACost.InsertCost(ItemId, EmptyString(txtUSDCost.Text), EmptyString(txtKHRCost.Text), EmptyString(txtTHBCost.Text), 1, getCurrentUserID, Now.Date)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtUSDCost_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUSDCost.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class