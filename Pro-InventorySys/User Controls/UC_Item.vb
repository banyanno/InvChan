Public Class UC_Item
    Dim DAItem As New DSItemTableAdapters.ITEMTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RefreshList()

    End Sub
    Sub RefreshList()
        Me.ItemList.DataSource = DAItem.SelectItems
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Do you want to delete the item :" & Me.ItemList.CurrentRow.Cells("ITEM_NAME").Value & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DAItem.DeleteItem(CInt(Me.ItemList.CurrentRow.Cells("ITEM_ID").Value))
            Me.RefreshList()
        End If
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        If Me.ItemList.RowCount >= 1 Then
            If Me.ItemList.CurrentRow.Cells("ID").Value <> "" Then
                Dim FrmItem As New Item(Me)
                FrmItem.txtid.Text = Me.ItemList.CurrentRow.Cells("ID").Value
                FrmItem.txtEngName.Text = Me.ItemList.CurrentRow.Cells("ITEM_NAME").Value.ToString
                FrmItem.txtChnName.Text = Me.ItemList.CurrentRow.Cells("ITEM_NAME_CHN").Value.ToString
                FrmItem.txtBarCode.Text = Me.ItemList.CurrentRow.Cells("ITEM_BARCODE").Value.ToString
                FrmItem.CboCategory.SelectedValue = CInt(Me.ItemList.CurrentRow.Cells("CATE_ID").Value)

                If IsDBNull(ItemList.CurrentRow.Cells("ITEM_IMAGE").Value) = False Then
                    Dim MS As New IO.MemoryStream(CType(Me.ItemList.CurrentRow.Cells("ITEM_IMAGE").Value, Byte()))
                    Dim img As Image = Image.FromStream(MS)
                    FrmItem.PicItem.Image = img
                End If
                FrmItem.lblstatus.Text = 2
                FrmItem.txtBarCode.Focus()
                FrmItem.ShowDialog()
            End If
        End If

    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim FrmItem As New Item(Me)
        FrmItem.lblstatus.Text = 1
        FrmItem.txtBarCode.Focus()
        FrmItem.ShowDialog()
    End Sub

    Private Sub ToolStrip2_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip2.ItemClicked

    End Sub

    Private Sub ItemList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItemList.DoubleClick
        BtnEdit_Click(sender, e)
    End Sub

    Private Sub ItemList_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles ItemList.FormattingRow

    End Sub
End Class
