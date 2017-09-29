Public Class DashboardCategory
    Dim DACategory As New DSInventoryTableAdapters.CATEGORIESTableAdapter
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim FrmCategory As New NewCategory(Me)
        FrmCategory.lblStatus.Text = 0
        FrmCategory.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If Me.CategoryList.RowCount >= 1 Then
            Dim FrmCategory As New NewCategory(Me)
            FrmCategory.txtname.Text = CategoryList.CurrentRow.Cells("CATE_NAME").Value
            FrmCategory.lblStatus.Text = 1
            FrmCategory.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        If Me.CategoryList.RowCount >= 1 Then
            If MsgBox("Do you want to delete the category?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DACategory.DeleteCategory(Me.CategoryList.CurrentRow.Cells("CATE_ID").Value)
                RefreshData()
            End If
        End If
    End Sub
    Sub RefreshData()
        CategoryList.DataSource = DACategory.SelectAllCategories
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        RefreshData()
    End Sub



    Private Sub ToolSupplier_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolSupplier.ItemClicked

    End Sub

    Private Sub DashboardCategory_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RefreshData()
    End Sub
End Class
