Public Class DashboardSupplier
    Dim DASupplier As New DSInventoryTableAdapters.SUPPLIERTableAdapter
    
    Sub RefreshData()
        Me.SupplierList.DataSource = DASupplier.SelectAllSuppliers
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim FrmSupplier As New NewSupplyer(Me)
        FrmSupplier.lblStatus.Text = 0
        FrmSupplier.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If Me.SupplierList.RowCount >= 1 Then
            Dim TblSupplier As New DataTable
            TblSupplier = DASupplier.SelectSupplierByID(CInt(Me.SupplierList.CurrentRow.Cells("SUPP_ID").Value))
            Dim FrmSupplier As New NewSupplyer(Me)
            FrmSupplier.txtname.Text = TblSupplier.Rows(0).Item("SUPP_NAME").ToString
            FrmSupplier.cbogender.Text = TblSupplier.Rows(0).Item("SUPP_GENDER").ToString
            FrmSupplier.txtshop.Text = TblSupplier.Rows(0).Item("SUPP_SHOP").ToString
            FrmSupplier.txtaddress.Text = TblSupplier.Rows(0).Item("SUPP_ADDRESS").ToString
            FrmSupplier.txtphone.Text = TblSupplier.Rows(0).Item("SUPP_PHONE").ToString
            FrmSupplier.txtemail.Text = TblSupplier.Rows(0).Item("SUPP_EMAIL").ToString
            FrmSupplier.txtwebsite.Text = TblSupplier.Rows(0).Item("SUPP_WEBSITE").ToString
            FrmSupplier.cbolocation.SelectedValue = CInt(TblSupplier.Rows(0).Item("LOCA_ID"))
            FrmSupplier.txtnote.Text = TblSupplier.Rows(0).Item("SUPP_NOTE").ToString
            FrmSupplier.lblStatus.Text = 1
            FrmSupplier.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        RefreshData()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        If Me.SupplierList.RowCount >= 1 Then
            If MsgBox("Do you want to delete the supplier?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DASupplier.DeleteSupplier(Me.SupplierList.CurrentRow.Cells("SUPP_ID").Value)
                RefreshData()
            End If
        End If
    End Sub

    Private Sub DashboardSupplier_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RefreshData()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim FrmFindSupplier As New FindSupplyer(Me)
        FrmFindSupplier.ShowDialog()
    End Sub
End Class
