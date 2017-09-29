Public Class FormExchangeRate
    Dim DA_Rate As New DSRevenueTableAdapters.EXCHANGE_RATETableAdapter
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtCurrency, "", ErrRate) = False Then
            Exit Sub
        End If
        If TxtCurrency.Text = "0" Then Exit Sub


        If MessageBox.Show("Do you want to set new rate?", "Exchange Rate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            DA_Rate.UpdateStatus(0)
            If DA_Rate.InsertNewRate(EmptyString(TxtCurrency.Text), Now.Date, 1) = 1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub TxtCurrency_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCurrency.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class