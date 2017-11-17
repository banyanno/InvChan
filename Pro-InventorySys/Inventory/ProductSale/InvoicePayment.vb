Public Class InvoicePayment

    Dim DACategory As New DSInventoryTableAdapters.CATEGORIESTableAdapter
    Dim PSale As DashboardProductSale
    Dim DAPayment As New DSAccountReceivableTableAdapters.AR_PAYMENTTableAdapter
    Dim DAAR As New DSAccountReceivableTableAdapters.ACCOUNT_RECEIVABLETableAdapter

    Sub New(ByVal MyPanel As DashboardProductSale)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PSale = MyPanel
    End Sub

    Private Sub TxtTotalKHR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalKHR.TextChanged

    End Sub

    Private Sub ChkPayAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPayAll.CheckedChanged
        If ChkPayAll.Checked = True Then
            Me.txtUnpaidUSD.Text = 0
            Me.txtUnpaidTHB.Text = 0
            Me.txtUnpaidKHR.Text = 0
            Me.TxtTotalPaidUSD.Text = CDec(PSale.InvoiceList.CurrentRow.Cells("USD_AMOUNT").Value) - CDec(PSale.InvoiceList.CurrentRow.Cells("USD_PAID").Value)
            Me.TxtTotalPaidKHR.Text = CDec(PSale.InvoiceList.CurrentRow.Cells("KHR_AMOUNT").Value) - CDec(PSale.InvoiceList.CurrentRow.Cells("KHR_PAID").Value)
            Me.TxtTotalPaidTHB.Text = CDec(PSale.InvoiceList.CurrentRow.Cells("THB_AMOUNT").Value) - CDec(PSale.InvoiceList.CurrentRow.Cells("THB_PAID").Value)

            Me.TxtTotalPaidUSD.Enabled = False
            Me.TxtTotalPaidKHR.Enabled = False
            Me.TxtTotalPaidTHB.Enabled = False
        Else

            Me.txtUnpaidUSD.Text = CDec(PSale.InvoiceList.CurrentRow.Cells("USD_AMOUNT").Value) - CDec(PSale.InvoiceList.CurrentRow.Cells("USD_PAID").Value)
            Me.txtUnpaidTHB.Text = CDec(PSale.InvoiceList.CurrentRow.Cells("THB_AMOUNT").Value) - CDec(PSale.InvoiceList.CurrentRow.Cells("THB_PAID").Value)
            Me.txtUnpaidKHR.Text = CDec(PSale.InvoiceList.CurrentRow.Cells("KHR_AMOUNT").Value) - CDec(PSale.InvoiceList.CurrentRow.Cells("KHR_PAID").Value)

            Me.TxtTotalPaidUSD.Text = 0
            Me.TxtTotalPaidKHR.Text = 0
            Me.TxtTotalPaidTHB.Text = 0

            Me.TxtTotalPaidUSD.Enabled = True
            Me.TxtTotalPaidKHR.Enabled = True
            Me.TxtTotalPaidTHB.Enabled = True
        End If
    End Sub

    Private Sub TxtTotalPaidKHR_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTotalPaidKHR.LostFocus
        If Me.TxtTotalPaidKHR.Text = "" Then
            Me.TxtTotalPaidKHR.Text = 0
        End If
        Me.txtUnpaidKHR.Text = CDbl(CDec(PSale.InvoiceList.CurrentRow.Cells("KHR_AMOUNT").Value) - CDec(PSale.InvoiceList.CurrentRow.Cells("KHR_PAID").Value)) - CDbl(Me.TxtTotalPaidKHR.Text)
    End Sub

    Private Sub TxtTotalPaidUSD_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTotalPaidUSD.LostFocus
        If Me.TxtTotalPaidUSD.Text = "" Then
            Me.TxtTotalPaidUSD.Text = 0
        End If
        Me.txtUnpaidUSD.Text = CDbl(CDec(PSale.InvoiceList.CurrentRow.Cells("USD_AMOUNT").Value) - CDec(PSale.InvoiceList.CurrentRow.Cells("USD_PAID").Value)) - CDbl(Me.TxtTotalPaidUSD.Text)
    End Sub

    Private Sub TxtTotalPaidTHB_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTotalPaidTHB.LostFocus
        If Me.TxtTotalPaidTHB.Text = "" Then
            Me.TxtTotalPaidTHB.Text = 0
        End If
        Me.txtUnpaidTHB.Text = CDbl(CDec(PSale.InvoiceList.CurrentRow.Cells("THB_AMOUNT").Value) - CDec(PSale.InvoiceList.CurrentRow.Cells("THB_PAID").Value)) - CDbl(Me.TxtTotalPaidTHB.Text)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateDateTimePicker(Me.DatePaid, "", ErrSale) = False Then Exit Sub
        If Me.TxtTotalPaidUSD.Text = 0 And Me.TxtTotalPaidTHB.Text = 0 And Me.TxtTotalPaidKHR.Text = 0 Then
            MsgBox("Please input the payment", MsgBoxStyle.Information)
            Me.TxtTotalPaidUSD.Focus()
            Me.TxtTotalPaidUSD.SelectAll()
        Else
            Dim ARID As Long = PSale.InvoiceList.CurrentRow.Cells("ACCR_ID").Value
            Dim PaidUSD As Decimal = CDec(Me.txtTotalUSD.Text) - CDec(Me.txtUnpaidUSD.Text)
            Dim PaidKHR As Decimal = CDec(Me.txtTotalKHR.Text) - CDec(Me.txtUnpaidKHR.Text)
            Dim PaidTHB As Decimal = CDec(Me.txtTotalTHB.Text) - CDec(Me.txtUnpaidTHB.Text)
            Dim Completed As Integer = 0
            If Me.txtUnpaidUSD.Text = 0 And Me.txtUnpaidTHB.Text = 0 And Me.txtUnpaidKHR.Text = 0 Then
                Completed = 1
            End If
            DAPayment.InsertPayment(ARID, CDec(Me.TxtTotalPaidKHR.Text), CDec(Me.TxtTotalPaidUSD.Text), CDec(Me.TxtTotalPaidTHB.Text), DatePaid.Value.Date, Me.TxtNote.Text.Replace("'", "''"), getCurrentUserID)
            DAAR.UpdatePaidAmount(PaidKHR, PaidTHB, PaidUSD, Completed, ARID)
            MsgBox("The payment was made", MsgBoxStyle.Information)
            PSale.RefreshList()
            Me.Close()

        End If
    End Sub
End Class