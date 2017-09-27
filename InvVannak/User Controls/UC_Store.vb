Public Class UC_Store
    Dim DAStore As New DSItemTableAdapters.ITEM_STORETableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RefreshList()

    End Sub
    Sub RefreshList()
        Me.StoreList.DataSource = DAStore.SelectStores
    End Sub
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Do you want to delete the item store :" & Me.StoreList.CurrentRow.Cells("ITEM_NAME").Value & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DAStore.DeleteStore(CInt(Me.StoreList.CurrentRow.Cells("STOR_ID").Value))
            Me.RefreshList()
        End If
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        If Me.StoreList.RowCount = 0 Then
            MsgBox("No store record was selected", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim FrmStore As New Item_Store(Me)
        FrmStore.cboCategory.Text = Me.StoreList.CurrentRow.Cells("CATE_NAME").Value
        FrmStore.CboItemChnName.SelectedValue = Me.StoreList.CurrentRow.Cells("ITEM_ID").Value
        FrmStore.CboUnitChnName.SelectedValue = Me.StoreList.CurrentRow.Cells("UNIT_ID").Value
        FrmStore.txtRatioQty.Text = Me.StoreList.CurrentRow.Cells("RATIO_QTY").Value
        FrmStore.txtBalance.Text = Me.StoreList.CurrentRow.Cells("ITEM_BALANCE").Value
        FrmStore.txtCost.Text = Me.StoreList.CurrentRow.Cells("LAST_COST").Value
        FrmStore.txtPrice.Text = Me.StoreList.CurrentRow.Cells("LAST_PRICE").Value
        FrmStore.lblstatus.Text = 2
        FrmStore.cboCategory.Enabled = False
        FrmStore.CboItemChnName.Enabled = False
        FrmStore.CboUnitChnName.Enabled = False
        FrmStore.txtBalance.Enabled = False
        FrmStore.txtBarcode.Visible = False
        FrmStore.chkBarcode.Visible = False
        FrmStore.ShowDialog()
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim FrmStore As New Item_Store(Me)
        FrmStore.txtRatioQty.Text = 1
        FrmStore.lblstatus.Text = 1
        FrmStore.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        RefreshList()
    End Sub
End Class
