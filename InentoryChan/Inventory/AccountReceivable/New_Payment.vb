Public Class New_Payment

    Dim DACategory As New DSInventoryTableAdapters.CATEGORIESTableAdapter
    Dim PReceivable As DashboardAccountReceivable
    Dim DAPayment As New DSAccountReceivableTableAdapters.AR_PAYMENTTableAdapter
    Dim DAAR As New DSAccountReceivableTableAdapters.ACCOUNT_RECEIVABLETableAdapter

    Sub New(ByVal MyPanel As DashboardAccountReceivable)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PReceivable = MyPanel
    End Sub

    Private Sub TxtTotalKHR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalKHR.TextChanged

    End Sub

    Private Sub ChkPayAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPayAll.CheckedChanged
        If ChkPayAll.Checked = True Then
            Me.txtUnpaidUSD.Text = 0
            Me.txtUnpaidTHB.Text = 0
            Me.txtUnpaidKHR.Text = 0
            Me.TxtTotalPaidUSD.Text = PReceivable.TxtResultUSD.Text
            Me.TxtTotalPaidKHR.Text = PReceivable.TxtResultKHR.Text
            Me.TxtTotalPaidTHB.Text = PReceivable.TxtResultTHB.Text

            Me.TxtTotalPaidUSD.Enabled = False
            Me.TxtTotalPaidKHR.Enabled = False
            Me.TxtTotalPaidTHB.Enabled = False
        Else

            Me.txtUnpaidUSD.Text = PReceivable.TxtResultUSD.Text
            Me.txtUnpaidTHB.Text = PReceivable.TxtResultTHB.Text
            Me.txtUnpaidKHR.Text = PReceivable.TxtResultKHR.Text

            Me.TxtTotalPaidUSD.Text = 0
            Me.TxtTotalPaidKHR.Text = 0
            Me.TxtTotalPaidTHB.Text = 0

            Me.TxtTotalPaidUSD.Enabled = True
            Me.TxtTotalPaidKHR.Enabled = True
            Me.TxtTotalPaidTHB.Enabled = True
        End If
    End Sub

    'Private Sub TxtTotalPaidKHR_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTotalPaidKHR.LostFocus
    '    If Me.TxtTotalPaidKHR.Text = "" Then
    '        Me.TxtTotalPaidKHR.Text = 0
    '    End If
    '    Me.txtUnpaidKHR.Text = CDbl(PReceivable.TxtResultKHR.Text) - CDbl(Me.TxtTotalPaidKHR.Text)
    'End Sub

    'Private Sub TxtTotalPaidUSD_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTotalPaidUSD.LostFocus
    '    If Me.TxtTotalPaidUSD.Text = "" Then
    '        Me.TxtTotalPaidUSD.Text = 0
    '    End If
    '    Me.txtUnpaidUSD.Text = CDbl(PReceivable.TxtResultUSD.Text) - CDbl(Me.TxtTotalPaidUSD.Text)
    'End Sub

    'Private Sub TxtTotalPaidTHB_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTotalPaidTHB.LostFocus
    '    If Me.TxtTotalPaidTHB.Text = "" Then
    '        Me.TxtTotalPaidTHB.Text = 0
    '    End If
    '    Me.txtUnpaidTHB.Text = CDbl(PReceivable.TxtResultTHB.Text) - CDbl(Me.TxtTotalPaidTHB.Text)
    'End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateDateTimePicker(DatePaid, "", ErrPaid) = False Then Exit Sub
        If EmptyString(Me.TxtMoreUSD.Text) = 0 And EmptyString(Me.TxtMoreTHB.Text) = 0 And EmptyString(Me.TxtMoreKHR.Text) = 0 Then
            MsgBox("Please input the payment", MsgBoxStyle.Information)
            Me.TxtMoreUSD.Focus()
            Me.TxtMoreUSD.SelectAll()
        Else
            If MessageBox.Show("Do you want to save new Receive able", "Receive able", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim ARID As Long = PReceivable.ARList.CurrentRow.Cells("ACCR_ID").Value
                Dim PaidUSD As Decimal = CDec(Me.txtTotalUSD.Text) - CDec(Me.txtUnpaidUSD.Text)
                Dim PaidKHR As Decimal = CDec(Me.txtTotalKHR.Text) - CDec(Me.txtUnpaidKHR.Text)
                Dim PaidTHB As Decimal = CDec(Me.txtTotalTHB.Text) - CDec(Me.txtUnpaidTHB.Text)
                Dim Completed As Integer = 0
                'If Me.txtUnpaidUSD.Text = 0 And Me.txtUnpaidTHB.Text = 0 And Me.txtUnpaidKHR.Text = 0 Then
                '    Completed = 1
                'End If
                If DAPayment.InsertPayment(ARID, CDec(EmptyString(TxtMoreKHR.Text)), CDec(EmptyString(TxtMoreUSD.Text)), CDec(EmptyString(TxtMoreTHB.Text)), DatePaid.Value.Date, Me.TxtNote.Text.Replace("'", "''"), getCurrentUserID) = 1 Then
                    DAAR.UpdatePaidAmount(PaidKHR, PaidTHB, PaidUSD, Completed, ARID)
                    MsgBox("The payment was made", MsgBoxStyle.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
          

            'PReceivable.RefreshList()
            'Me.Close()

        End If
    End Sub

   
    Private Sub TxtMoreUSD_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtMoreUSD.KeyUp
        If CDbl(EmptyString(TxtMoreUSD.Text)) > CDbl(EmptyString(txtUnpaidUSD.Text)) Then
            MessageBox.Show("ចំនួន បង់មិនអាចធំជាង ចំនួននៅសល់!", "Receive able", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMoreUSD.Text = 0
            TxtMoreUSD.Focus()
            TxtMoreUSD.SelectAll()
        End If
    End Sub

    Private Sub TxtMoreUSD_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMoreUSD.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtMoreKHR_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMoreKHR.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtMoreKHR_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtMoreKHR.KeyUp
        If CDbl(EmptyString(TxtMoreKHR.Text)) > CDbl(EmptyString(txtUnpaidKHR.Text)) Then
            MessageBox.Show("ចំនួន បង់មិនអាចធំជាង ចំនួននៅសល់!", "Payable", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMoreKHR.Text = 0
            TxtMoreKHR.Focus()
            TxtMoreKHR.SelectAll()
        End If
    End Sub

    Private Sub TxtMoreTHB_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtMoreTHB.KeyUp
        If CDbl(EmptyString(TxtMoreTHB.Text)) > CDbl(EmptyString(txtUnpaidTHB.Text)) Then
            MessageBox.Show("ចំនួន បង់មិនអាចធំជាង ចំនួននៅសល់!", "Payable", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMoreTHB.Text = 0
            TxtMoreTHB.Focus()
            TxtMoreTHB.SelectAll()
        End If
    End Sub

    Private Sub TxtMoreTHB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMoreTHB.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class