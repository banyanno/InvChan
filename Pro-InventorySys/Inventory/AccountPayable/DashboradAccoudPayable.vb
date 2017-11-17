Imports CrystalDecisions.Shared

Public Class DashboradAccoudPayable

    Dim DA_AccountPayable As New DSACCOUNTPAYABLETableAdapters.ACC_PAYABLETableAdapter
    Dim DA_AccountPayableDetail As New DSACCOUNTPAYABLETableAdapters.ACC_PAY_ABLE_DETAILTableAdapter
    Dim DASupplier As New DSInventoryTableAdapters.SUPPLIERTableAdapter
    Dim DA_AccPayable As New DSACCOUNTPAYABLETableAdapters.ACC_PAYABLE_VIEWTableAdapter
    Dim DA_AccPayableSummary As New DSACCOUNTPAYABLETableAdapters.ACC_PAYABLE_VIEW1TableAdapter
    Dim DA_PurchaseDetail As New DSACCOUNTPAYABLETableAdapters.PURCHASE_ORDER_MASTER_DETAIL_VIEWTableAdapter
    Dim DA_ACCPAY_ABLE As New DSACCOUNTPAYABLE
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        With TxtSupplier
            .DataSource = DASupplier.GetData
            .ValueMember = "SUPP_ID"
            .DisplayMember = "SUPP_NAME"
            .SelectedIndex = -1
        End With
       
      
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnNewPayable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewPayable.Click
        'Try
        If GridAccountPayable.SelectedItems.Count = 0 Then Exit Sub
        Dim FNewPayable As New New_Payable
        FNewPayable.TxtPuchaseOrderNo.Text = GridAccountPayable.GetRow.Cells("PURCHASE_NO").Value
        FNewPayable.TxtDateOrder.Text = Format(GridAccountPayable.GetRow.Cells("DATE_ORDER").Value, "dd/MM/yyyy")
        FNewPayable.TxtSupplier.Text = GridAccountPayable.GetRow.Cells("SUPPLIER_NAME").Value

        FNewPayable.LblAccountPayID.Text = GridAccountPayable.GetRow.Cells("ACC_PAY_ID").Value
        FNewPayable.TxtTotalKHR.Text = GridAccountPayable.GetRow.Cells("TOTAL_AMOUNT_KHR").Value
        FNewPayable.TxtTotalTHB.Text = GridAccountPayable.GetRow.Cells("TOTAL_AMOUNT_THB").Value
        FNewPayable.TxtTotalUSD.Text = GridAccountPayable.GetRow.Cells("TOTAL_AMOUNT_USD").Value


        FNewPayable.TxtTotalPaidUSD.Text = TxtTotalPaidUSD.Text
        FNewPayable.TxtTotalPaidKHR.Text = TxtTotalPaidKHR.Text
        FNewPayable.TxtTotalPaidTHB.Text = TxtTotalPaidTHB.Text

        FNewPayable.TxtUnPaidKHR.Text = TxtResultKHR.Text
        FNewPayable.TxtUnPaidTHB.Text = TxtResultTHB.Text
        FNewPayable.TxtUnPaidUSD.Text = TxtResultUSD.Text
        If FNewPayable.ShowDialog = DialogResult.OK Then
            GetByAccountID(FNewPayable.LblAccountPayID.Text)
            DisplayTotalPayable()
        End If
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub DashboradAccoudPayable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'DA_AccountPayable.GetData()
        DA_AccountPayable.FillBySelectByStatusPay(DA_ACCPAY_ABLE.ACC_PAYABLE, "0")
        GridAccountPayable.DataSource = DA_ACCPAY_ABLE.ACC_PAYABLE   'DA_AccountPayable.SelectByStatusPay("Not yet paid")
        'DA_PurchaseDetail.GetData()
        DA_PurchaseDetail.Fill(DA_ACCPAY_ABLE.PURCHASE_ORDER_MASTER_DETAIL_VIEW)
        GridAccountPayable.RootTable.ChildTables(0).DataMember = "PurcasheDetail"
    End Sub
    Private Sub GetByAccountID(ByVal PayableID As Double)
        GridPayableDetail.DataSource = DA_AccountPayableDetail.SelectByAccountPayID(PayableID)

    End Sub

    Private Sub GridAccountPayable_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridAccountPayable.SelectionChanged
        Try
            If GridAccountPayable.SelectedItems.Count = 0 Then
                CleandForm()
                Exit Sub
            End If

            GetByAccountID(GridAccountPayable.GetRow.Cells("ACC_PAY_ID").Value)
            DisplayTotalPayable()
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub DisplayTotalPayable()
        TxtTotalKHR.Text = GridAccountPayable.GetRow.Cells("TOTAL_AMOUNT_KHR").Value
        TxtTotalTHB.Text = GridAccountPayable.GetRow.Cells("TOTAL_AMOUNT_THB").Value
        TxtTotalUSD.Text = GridAccountPayable.GetRow.Cells("TOTAL_AMOUNT_USD").Value
        Dim TotalPaidUSD As Double = 0
        Dim TotalPaidKHR As Double = 0
        Dim totalPaidTHB As Double = 0
        For i As Integer = 0 To GridPayableDetail.RowCount - 2
            TotalPaidUSD = TotalPaidUSD + CDbl(GridPayableDetail.GetRow(i).Cells("PAID_USD").Value)
            TotalPaidKHR = TotalPaidKHR + CDbl(GridPayableDetail.GetRow(i).Cells("PAID_KHT").Value)
            totalPaidTHB = totalPaidTHB + CDbl(GridPayableDetail.GetRow(i).Cells("PAID_THB").Value)
        Next
        TxtTotalPaidKHR.Text = TotalPaidKHR
        TxtTotalPaidUSD.Text = TotalPaidUSD
        TxtTotalPaidTHB.Text = totalPaidTHB

        TxtResultKHR.Text = EmptyString(TxtTotalKHR.Text) - EmptyString(TxtTotalPaidKHR.Text)
        TxtResultTHB.Text = EmptyString(TxtTotalTHB.Text) - EmptyString(TxtTotalPaidTHB.Text)
        TxtResultUSD.Text = (EmptyString(TxtTotalUSD.Text) - EmptyString(TxtTotalPaidUSD.Text))
    End Sub


    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click

        'DA_AccountPayable.FillBySelectByStatusPay(DA_ACCPAY_ABLE.ACC_PAYABLE, "0")
        'GridAccountPayable.DataSource = DA_ACCPAY_ABLE.ACC_PAYABLE   'DA_AccountPayable.SelectByStatusPay("Not yet paid")
        'DA_PurchaseDetail.Fill(DA_ACCPAY_ABLE.PURCHASE_ORDER_MASTER_DETAIL_VIEW)
        'GridAccountPayable.RootTable.ChildTables(0).DataMember = "PurcasheDetail"
    End Sub

    Private Sub BtnDeletePayable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeletePayable.Click
        If GridPayableDetail.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete payable?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_AccountPayableDetail.DeleteAccountPayable(GridPayableDetail.GetRow.Cells("ACC_PAY_DETAIL_ID").Value) = 1 Then
                GetByAccountID(GridAccountPayable.GetRow.Cells("ACC_PAY_ID").Value)
                DisplayTotalPayable()
            End If
        End If
    End Sub

    Private Sub BntFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BntFind.Click
        If RadAll.Checked = True Then
            If ChSupplier.Checked = True Then
                DA_AccountPayable.FillBySelectAccWithSupplier(DA_ACCPAY_ABLE.ACC_PAYABLE, DateFrom.Value.Date, DateTo.Value.Date, "", CInt(TxtSupplier.SelectedValue))
                GridAccountPayable.DataSource = DA_ACCPAY_ABLE.ACC_PAYABLE
                DA_PurchaseDetail.Fill(DA_ACCPAY_ABLE.PURCHASE_ORDER_MASTER_DETAIL_VIEW)
                GridAccountPayable.RootTable.ChildTables(0).DataMember = "PurcasheDetail"
            Else
                ' GridAccountPayable.DataSource = DA_AccountPayable.SelectAccPayable(DateFrom.Value.Date, DateTo.Value.Date)

                DA_AccountPayable.FillBySelectAccPayable(DA_ACCPAY_ABLE.ACC_PAYABLE, DateFrom.Value.Date, DateTo.Value.Date)
                GridAccountPayable.DataSource = DA_ACCPAY_ABLE.ACC_PAYABLE
                DA_PurchaseDetail.Fill(DA_ACCPAY_ABLE.PURCHASE_ORDER_MASTER_DETAIL_VIEW)
                GridAccountPayable.RootTable.ChildTables(0).DataMember = "PurcasheDetail"
            End If
        ElseIf RadNotYet.Checked = True Then
            If ChSupplier.Checked = True Then
                'GridAccountPayable.DataSource = DA_AccountPayable.SelectAccWithSupplier(DateFrom.Value.Date, DateTo.Value.Date, "Not yet paid", CInt(TxtSupplier.SelectedValue))

                DA_AccountPayable.FillBySelectAccWithSupplier(DA_ACCPAY_ABLE.ACC_PAYABLE, DateFrom.Value.Date, DateTo.Value.Date, "0", CInt(TxtSupplier.SelectedValue))
                GridAccountPayable.DataSource = DA_ACCPAY_ABLE.ACC_PAYABLE
                DA_PurchaseDetail.Fill(DA_ACCPAY_ABLE.PURCHASE_ORDER_MASTER_DETAIL_VIEW)
                GridAccountPayable.RootTable.ChildTables(0).DataMember = "PurcasheDetail"

            Else
                'GridAccountPayable.DataSource = DA_AccountPayable.SelectAccDateToDateWithStatus(DateFrom.Value.Date, DateTo.Value.Date, "Not yet paid")

                DA_AccountPayable.FillBySelectAccDateToDateWithStatus(DA_ACCPAY_ABLE.ACC_PAYABLE, DateFrom.Value.Date, DateTo.Value.Date, "0")
                GridAccountPayable.DataSource = DA_ACCPAY_ABLE.ACC_PAYABLE
                DA_PurchaseDetail.Fill(DA_ACCPAY_ABLE.PURCHASE_ORDER_MASTER_DETAIL_VIEW)
                GridAccountPayable.RootTable.ChildTables(0).DataMember = "PurcasheDetail"
            End If
        ElseIf RadReceived.Checked = True Then
            If ChSupplier.Checked = True Then
                'GridAccountPayable.DataSource = DA_AccountPayable.SelectAccWithSupplier(DateFrom.Value.Date, DateTo.Value.Date, "Completed", CInt(TxtSupplier.SelectedValue))
                DA_AccountPayable.FillBySelectAccWithSupplier(DA_ACCPAY_ABLE.ACC_PAYABLE, DateFrom.Value.Date, DateTo.Value.Date, "1", CInt(TxtSupplier.SelectedValue))
                GridAccountPayable.DataSource = DA_ACCPAY_ABLE.ACC_PAYABLE
                DA_PurchaseDetail.Fill(DA_ACCPAY_ABLE.PURCHASE_ORDER_MASTER_DETAIL_VIEW)
                GridAccountPayable.RootTable.ChildTables(0).DataMember = "PurcasheDetail"
            Else
                'GridAccountPayable.DataSource = DA_AccountPayable.SelectAccDateToDateWithStatus(DateFrom.Value.Date, DateTo.Value.Date, "Completed")
                DA_AccountPayable.FillBySelectAccDateToDateWithStatus(DA_ACCPAY_ABLE.ACC_PAYABLE, DateFrom.Value.Date, DateTo.Value.Date, "1")
                GridAccountPayable.DataSource = DA_ACCPAY_ABLE.ACC_PAYABLE
                DA_PurchaseDetail.Fill(DA_ACCPAY_ABLE.PURCHASE_ORDER_MASTER_DETAIL_VIEW)
                GridAccountPayable.RootTable.ChildTables(0).DataMember = "PurcasheDetail"
            End If
        End If

    End Sub

    Private Sub ChSupplier_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChSupplier.CheckedChanged
        TxtSupplier.Enabled = ChSupplier.Checked
        With TxtSupplier
            .DataSource = DASupplier.GetData
            .ValueMember = "SUPP_ID"
            .DisplayMember = "SUPP_NAME"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub RadPurchaseNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadPurchaseNo.CheckedChanged
        TxtPurchaseNo.Enabled = RadPurchaseNo.Checked
    End Sub

    Private Sub RadReferrentNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadReferrentNo.CheckedChanged
        TxtReferentNo.Enabled = RadReferrentNo.Checked
    End Sub
    Private Sub CleandForm()
        GridPayableDetail.DataSource = Nothing
        TxtTotalPaidKHR.Text = 0
        TxtTotalPaidTHB.Text = 0
        TxtTotalPaidUSD.Text = 0
        TxtTotalTHB.Text = 0
        TxtTotalUSD.Text = 0
        TxtTotalKHR.Text = 0
        TxtResultKHR.Text = 0
        TxtResultTHB.Text = 0
        TxtResultUSD.Text = 0
    End Sub

    Private Sub TxtPurchaseNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPurchaseNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnFindByPurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindByPurchase.Click
        If RadPurchaseNo.Checked = True Then
            GridAccountPayable.DataSource = DA_AccountPayable.SelectByPurchaseOrder(EmptyString(TxtPurchaseNo.Text))
        End If
        If RadReferrentNo.Checked = True Then
            GridAccountPayable.DataSource = DA_AccountPayable.SelectByReferrentNo(TxtReferentNo.Text)
        End If
    End Sub

    Private Sub BtnCompleted_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCompleted.Click
        If GridAccountPayable.SelectedItems.Count = 0 Then Exit Sub
        If CheckUpdatePaid(EmptyString(TxtResultUSD.Text), EmptyString(TxtResultKHR.Text), EmptyString(TxtResultTHB.Text)) > 0 Then
            MessageBox.Show("You can not set complet payable!. Please check total paid agian", "Paid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If MessageBox.Show("Do you want to update to completed payable?", "Paid", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If DA_AccountPayable.UpdateAccountPayable("1", GridAccountPayable.GetRow.Cells("ACC_PAY_ID").Value) = 1 Then
                    GridAccountPayable.DataSource = DA_AccountPayable.SelectByStatusPay("0")
                End If
            End If
        End If

    End Sub

    Private Function CheckUpdatePaid(ByVal TotalUSD As Double, ByVal TotalKHR As Double, ByVal TotalTHB As Double) As Double
        Return TotalKHR + TotalTHB + TotalUSD
    End Function

    Private Sub BtnReportAccPayable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReportAccPayable.Click
        Dim RPayAble As New FromReportAccPayable
        RPayAble.ShowDialog()
    End Sub
End Class
