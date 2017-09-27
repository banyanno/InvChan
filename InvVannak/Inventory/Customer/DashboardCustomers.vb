Public Class DashboardCustomers
    Dim DACustomer As New DSInventoryTableAdapters.CUSTOMERTableAdapter
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim FrmCustomer As New NewCostomer(Me)
        FrmCustomer.lblStatus.Text = 0
        If FrmCustomer.ShowDialog() = DialogResult.OK Then
            RefreshData()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim FrmFindCustomer As New FindCustomer(Me)
        FrmFindCustomer.ShowDialog()
    End Sub

    Private Sub ToolCostomers_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolCostomers.ItemClicked

    End Sub
    Sub RefreshData()
        Me.CustomerList.DataSource = DACustomer.SelectAllCustomers
    End Sub
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        If Me.CustomerList.RowCount >= 1 Then
            If MsgBox("Do you want to delete the customer?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DACustomer.DeleteCustomer(Me.CustomerList.CurrentRow.Cells("CUST_ID").Value)
                RefreshData()
            End If
        End If
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        RefreshData()
    End Sub

    Private Sub DashboardCustomers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RefreshData()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If Me.CustomerList.RowCount >= 1 Then
            Dim TblCustomer As New DataTable
            TblCustomer = DACustomer.SelectCustomerByID(CInt(Me.CustomerList.CurrentRow.Cells("CUST_ID").Value))
            Dim FrmCustomer As New NewCostomer(Me)
            FrmCustomer.txtname.Text = TblCustomer.Rows(0).Item("CUST_NAME").ToString
            FrmCustomer.cbogender.Text = TblCustomer.Rows(0).Item("CUST_GENDER").ToString
            FrmCustomer.txtshop.Text = TblCustomer.Rows(0).Item("CUST_SHOP").ToString
            FrmCustomer.txtaddress.Text = TblCustomer.Rows(0).Item("CUST_ADDRESS").ToString
            FrmCustomer.txtphone.Text = TblCustomer.Rows(0).Item("CUST_PHONE").ToString
            FrmCustomer.txtemail.Text = TblCustomer.Rows(0).Item("CUST_EMAIL").ToString
            FrmCustomer.txtwebsite.Text = TblCustomer.Rows(0).Item("CUST_WEBSITE").ToString
            FrmCustomer.cbolocation.SelectedValue = CInt(TblCustomer.Rows(0).Item("LOCA_ID"))
            FrmCustomer.txtnote.Text = TblCustomer.Rows(0).Item("CUST_NOTE").ToString
            FrmCustomer.lblStatus.Text = 1
            FrmCustomer.ShowDialog()
        End If
    End Sub
End Class
