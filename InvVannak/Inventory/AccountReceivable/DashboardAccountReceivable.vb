Imports CrystalDecisions.Shared

Public Class DashboardAccountReceivable
    Dim DS_ACC_ReceiveAble As New DSAccountReceivable
    Dim DAAR As New DSAccountReceivableTableAdapters.ACCOUNT_RECEIVABLETableAdapter
    Dim DAARV1 As New DSAccountReceivableTableAdapters.ACCOUNT_RECEIVABLE1TableAdapter
    Dim DAPayment As New DSAccountReceivableTableAdapters.AR_PAYMENTTableAdapter
    Dim DACustomer As New DSInventoryTableAdapters.CUSTOMERTableAdapter
    Dim DA_Invoice_Detail As New DSAccountReceivableTableAdapters.INVOICE_DETAILSTableAdapter
    Dim DA_ACC_ReceiveAbleDetail As New DSAccountReceivableTableAdapters.ACC_RECEIVED_ABLE_VIEWTableAdapter
    Dim DA_ACC_ReceiveSummary As New DSAccountReceivableTableAdapters.ACC_RECEIVED_ABLE_VIEW1TableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.TxtCustomer.DataSource = DACustomer.SelectAllCustomers
        Me.TxtCustomer.ValueMember = "CUST_ID"
        Me.TxtCustomer.DisplayMember = "CUST_NAME"
        Me.TxtCustomer.SelectedIndex = -1
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub ARList_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ARList.SelectionChanged
        Try
            Me.TxtTotalUSD.Text = "0"
            Me.TxtTotalKHR.Text = "0"
            Me.TxtTotalTHB.Text = "0"

            Me.TxtTotalPaidUSD.Text = "0"
            Me.TxtTotalPaidKHR.Text = "0"
            Me.TxtTotalPaidTHB.Text = "0"

            Me.TxtResultUSD.Text = "0"
            Me.TxtResultKHR.Text = "0"
            Me.TxtResultTHB.Text = "0"
            If ARList.SelectedItems.Count = 0 Then Exit Sub
            Dim ARID As Long = CLng(ARList.CurrentRow.Cells("ACCR_ID").Value)
            Dim ARTable As New DataTable
            ARTable = DAAR.SelectByID(ARID)
            PaymentList.DataSource = DAPayment.SelectByARID(CLng(Me.ARList.CurrentRow.Cells("ACCR_ID").Value))
            DisplayTotalPayable()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DashboardAccountReceivable_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RefreshList()
    End Sub
    Sub RefreshList()
        'Try
        DAARV1.FillBySelectAllStatusDateToDate(DS_ACC_ReceiveAble.ACCOUNT_RECEIVABLE1, DateFrom.Value.Date, DateTo.Value.Date)
        Me.ARList.DataSource = DS_ACC_ReceiveAble.ACCOUNT_RECEIVABLE1
        DA_Invoice_Detail.Fill(DS_ACC_ReceiveAble.INVOICE_DETAILS)
        ARList.RootTable.ChildTables(0).DataMember = "ACCOUNT_RECEIVABLE1_INVOICE_DETAILS"
        '    If ARList.RowCount >= 1 Then
        '        PaymentList.DataSource = DAPayment.SelectByARID(CLng(Me.ARList.CurrentRow.Cells("ACCR_ID").Value))
        '    End If
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub BtnDeletePayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeletePayment.Click
        If PaymentList.SelectedItems.Count = 0 Then Exit Sub
        If ARList.GetRow.Cells("COMPLETED").Value = 1 Then
            MsgBox("The customer was pay complete. Can not delete payment")
            Exit Sub
        End If

        If MsgBox("Do you want to delete the selected payment?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ''Update Paid Amount
            DAAR.DeductPayment(CDec(Me.PaymentList.CurrentRow.Cells("KHR_AMOUNT").Value), CDec(Me.PaymentList.CurrentRow.Cells("THB_AMOUNT").Value), CDec(Me.PaymentList.CurrentRow.Cells("USD_AMOUNT").Value), Me.PaymentList.CurrentRow.Cells("ACCR_ID").Value)
            '' Delete Payment
            DAPayment.DeletePayment(Me.PaymentList.CurrentRow.Cells("PAYMENT_ID").Value)
            RefreshList()
        End If

    End Sub

    Private Sub BtnNewPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewPayment.Click
        Try
            If ARList.GetRow.Cells("COMPLETED").Value = 1 Then
                MessageBox.Show("You can not new receiveable. Becoz the customer paid ready!", "Receivable", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If Me.ARList.RecordCount >= 1 Then
                Dim FrmNewPayment As New New_Payment(Me)
                FrmNewPayment.txtCustName.Text = ARList.CurrentRow.Cells("CUST_NAME").Value
                FrmNewPayment.txtInvoiceNo.Text = Format(ARList.CurrentRow.Cells("INVOICE_ID").Value, "000000")
                FrmNewPayment.txtDateInvoice.Text = FormatDateTime(ARList.CurrentRow.Cells("INVOICE_DATE").Value.ToString, DateFormat.ShortDate)

                FrmNewPayment.txtTotalKHR.Text = Me.TxtTotalKHR.Text
                FrmNewPayment.txtTotalUSD.Text = Me.TxtTotalUSD.Text
                FrmNewPayment.txtTotalTHB.Text = Me.TxtTotalTHB.Text

                FrmNewPayment.TxtTotalPaidUSD.Text = TxtTotalPaidUSD.Text
                FrmNewPayment.TxtTotalPaidKHR.Text = TxtTotalPaidKHR.Text
                FrmNewPayment.TxtTotalPaidTHB.Text = TxtTotalPaidTHB.Text

                FrmNewPayment.txtUnpaidUSD.Text = Me.TxtResultUSD.Text
                FrmNewPayment.txtUnpaidKHR.Text = Me.TxtResultKHR.Text
                FrmNewPayment.txtUnpaidTHB.Text = Me.TxtResultTHB.Text


                If FrmNewPayment.ShowDialog() = DialogResult.OK Then
                    ARList.DataSource = DAAR.SelectByAccID(ARList.GetRow.Cells("ACCR_ID").Value)
                End If

            End If
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        RefreshList()
    End Sub
    Private Sub DisplayTotalPayable()
        TxtTotalKHR.Text = ARList.GetRow.Cells("KHR_AMOUNT").Value
        TxtTotalTHB.Text = ARList.GetRow.Cells("THB_AMOUNT").Value
        TxtTotalUSD.Text = FormatNumber(ARList.GetRow.Cells("USD_AMOUNT").Value, 2)
        Dim TotalPaidUSD As Double = 0
        Dim TotalPaidKHR As Double = 0
        Dim totalPaidTHB As Double = 0
        For i As Integer = 0 To PaymentList.RowCount - 2
            TotalPaidUSD = TotalPaidUSD + CDbl(PaymentList.GetRow(i).Cells("USD_AMOUNT").Value)
            TotalPaidKHR = TotalPaidKHR + CDbl(PaymentList.GetRow(i).Cells("KHR_AMOUNT").Value)
            totalPaidTHB = totalPaidTHB + CDbl(PaymentList.GetRow(i).Cells("THB_AMOUNT").Value)
        Next
        TxtTotalPaidKHR.Text = TotalPaidKHR
        TxtTotalPaidUSD.Text = FormatNumber(TotalPaidUSD, 2)
        TxtTotalPaidTHB.Text = totalPaidTHB

        TxtResultKHR.Text = EmptyString(TxtTotalKHR.Text) - EmptyString(TxtTotalPaidKHR.Text)
        TxtResultTHB.Text = EmptyString(TxtTotalTHB.Text) - EmptyString(TxtTotalPaidTHB.Text)
        TxtResultUSD.Text = FormatNumber(EmptyString(TxtTotalUSD.Text) - EmptyString(TxtTotalPaidUSD.Text), 2)
    End Sub

    Private Sub ChSupplier_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChSupplier.CheckedChanged
        TxtCustomer.SelectedIndex = -1
        TxtCustomer.Enabled = ChSupplier.Checked
    End Sub

    Private Sub BntFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BntFind.Click

        If ChSupplier.Checked = True Then
            If RadAll.Checked = True Then
                ' Me.ARList.DataSource = DAAR.SelectInvoiceWithCustomerDateToDate(TxtCustomer.SelectedValue, DateFrom.Value.Date, DateTo.Value.Date)
                DAARV1.FillBySelectInvoiceWithCustomerDateToDate(DS_ACC_ReceiveAble.ACCOUNT_RECEIVABLE1, TxtCustomer.SelectedValue, DateFrom.Value.Date, DateTo.Value.Date)
                Me.ARList.DataSource = DS_ACC_ReceiveAble.ACCOUNT_RECEIVABLE1
                DA_Invoice_Detail.Fill(DS_ACC_ReceiveAble.INVOICE_DETAILS)
                ARList.RootTable.ChildTables(0).DataMember = "ACCOUNT_RECEIVABLE1_INVOICE_DETAILS"
            ElseIf RadNotYet.Checked = True Then
                ' Me.ARList.DataSource = DAAR.SelectInvoiceWithCustomerAndStatusPaid(TxtCustomer.SelectedValue, DateFrom.Value.Date, DateTo.Value.Date, 0)
                DAARV1.FillBySelectInvoiceWithCustomerAndStatusPaid(DS_ACC_ReceiveAble.ACCOUNT_RECEIVABLE1, TxtCustomer.SelectedValue, DateFrom.Value.Date, DateTo.Value.Date, 0)
                Me.ARList.DataSource = DS_ACC_ReceiveAble.ACCOUNT_RECEIVABLE1
                DA_Invoice_Detail.Fill(DS_ACC_ReceiveAble.INVOICE_DETAILS)
                ARList.RootTable.ChildTables(0).DataMember = "ACCOUNT_RECEIVABLE1_INVOICE_DETAILS"
            ElseIf RadCompleted.Checked = True Then
                'Me.ARList.DataSource = DAAR.SelectInvoiceWithCustomerAndStatusPaid(TxtCustomer.SelectedValue, DateFrom.Value.Date, DateTo.Value.Date, 1)
                DAARV1.FillBySelectInvoiceWithCustomerAndStatusPaid(DS_ACC_ReceiveAble.ACCOUNT_RECEIVABLE1, TxtCustomer.SelectedValue, DateFrom.Value.Date, DateTo.Value.Date, 1)
                Me.ARList.DataSource = DS_ACC_ReceiveAble.ACCOUNT_RECEIVABLE1
                DA_Invoice_Detail.Fill(DS_ACC_ReceiveAble.INVOICE_DETAILS)
                ARList.RootTable.ChildTables(0).DataMember = "ACCOUNT_RECEIVABLE1_INVOICE_DETAILS"
            End If
        Else
            RefreshList()
        End If
    End Sub

 

    

  

    Private Sub BtnUpdateCompleted_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateCompleted.Click
        If ARList.SelectedItems.Count = 0 Then Exit Sub
        If EmptyString(TxtResultKHR.Text) = 0 And EmptyString(TxtResultTHB.Text) = 0 And EmptyString(TxtResultUSD.Text) = 0 Then
            If MessageBox.Show("Do you want to update receivable complete?", "Acc-Receivable", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                DAAR.UpdatePaidAmount(EmptyString(TxtTotalPaidKHR.Text), EmptyString(TxtTotalPaidTHB.Text), EmptyString(TxtTotalPaidUSD.Text), 1, ARList.GetRow.Cells("ACCR_ID").Value)
            End If
        Else
            MessageBox.Show("The customer not complete pay. Please check again!", "Acc-Receivable", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnReportReceivable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReportReceivable.Click
        Dim FReportReceiveable As New FormReportReceivable
        FReportReceiveable.ShowDialog()
    End Sub
End Class
