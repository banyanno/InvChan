Public Class ReceiveStock
    Dim DA_PurchaseOrder As New DSPurchaseOrderTableAdapters.ORDERSTableAdapter
    Dim DA_AccPayable As New DSACCOUNTPAYABLETableAdapters.ACC_PAYABLETableAdapter
    Dim DA_Payabll As New DSACCOUNTPAYABLETableAdapters.ACC_PAY_ABLE_DETAILTableAdapter
    Private Sub ChAllPaid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'IS_Paid(ChAllPaid.Checked)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If ValidateDateTimePicker(DateReceived, "", ErrReceiveOrder) = False Then Exit Sub
        If MessageBox.Show("តើអ្នកចង់ ទទួល ចំនួននេះ?", "Receive Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_PurchaseOrder.UpdateDateReceiveAndStatus("1", DateReceived.Value.Date, txtInvoiceReferrent.Text, TxtNote.Text, LblPurchaseID.Text) = 1 Then
                If DA_AccPayable.InsertNewAccountPayable(TxtPuchaseOrderNo.Text, txtInvoiceReferrent.Text, LblSuppID.Text, TxtSupplier.Text, TxtDateOrder.Value.Date, DateReceived.Value.Date, TxtNote.Text, EmptyString(TxtTotalUSD.Text), EmptyString(TxtTotalKHR.Text), EmptyString(TxtTotalTHB.Text), "0") = 1 Then
                    DA_Payabll.InsertNewPayable(DA_AccPayable.GetMaxAccPayable, DateReceived.Value.Date, 0, 0, 0, "")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class