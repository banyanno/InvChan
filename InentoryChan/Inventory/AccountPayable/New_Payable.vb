Public Class New_Payable

    Dim DA_Payabll As New DSACCOUNTPAYABLETableAdapters.ACC_PAY_ABLE_DETAILTableAdapter
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateDateTimePicker(DatePaid, "", ErrPaid) = False Then Exit Sub
        If MessageBox.Show("Do you want to pay this amount?", "Payable", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_Payabll.InsertNewPayable(LblAccountPayID.Text, DatePaid.Value.Date, EmptyString(TxtMoreUSD.Text), EmptyString(TxtMoreKHR.Text), EmptyString(TxtMoreTHB.Text), TxtNote.Text) = 1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

   
    Private Sub TxtMoreUSD_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtMoreUSD.KeyUp
        If CDbl(EmptyString(TxtMoreUSD.Text)) > CDbl(EmptyString(TxtUnPaidUSD.Text)) Then
            MessageBox.Show("ចំនួន បង់មិនអាចធំជាង ចំនួននៅសល់!", "Payable", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMoreUSD.Text = 0
            TxtMoreUSD.Focus()
            TxtMoreUSD.SelectAll()
        End If
    End Sub

    Private Sub TxtMoreKHR_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtMoreKHR.KeyUp
        If CDbl(EmptyString(TxtMoreKHR.Text)) > CDbl(EmptyString(TxtUnPaidKHR.Text)) Then
            MessageBox.Show("ចំនួន បង់មិនអាចធំជាង ចំនួននៅសល់!", "Payable", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMoreKHR.Text = 0
            TxtMoreKHR.Focus()
            TxtMoreKHR.SelectAll()
        End If
    End Sub

    Private Sub TxtMoreTHB_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtMoreTHB.KeyUp
        If CDbl(EmptyString(TxtMoreTHB.Text)) > CDbl(EmptyString(TxtUnPaidTHB.Text)) Then
            MessageBox.Show("ចំនួន បង់មិនអាចធំជាង ចំនួននៅសល់!", "Payable", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMoreTHB.Text = 0
            TxtMoreTHB.Focus()
            TxtMoreTHB.SelectAll()
        End If
    End Sub

    Private Sub TxtMoreUSD_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMoreUSD.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtMoreKHR_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMoreKHR.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtMoreTHB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMoreTHB.KeyPress
        SetDisableKeyString(e)
    End Sub

    
End Class