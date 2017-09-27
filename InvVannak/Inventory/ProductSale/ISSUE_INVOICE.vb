Public Class ISSUE_INVOICE
    Dim IsDolar As Boolean = True
    Private Sub ISSUE_INVOICE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblRate.Text = GetExchangeRage() & "៛"
        TxtReceivedR.Select()
        TxtReceivedR.Focus()
    End Sub

    Private Sub ISSUE_INVOICE_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            If IsDolar = True Then
                If CDbl(EmptyString(TxtReceiveDollar.Text)) < CDbl(EmptyString(TxtTotalUSD.Text)) Then
                    MessageBox.Show("សូមបញ្ជូល ចំនួនលុយដែលទទួលជា ដុលារ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TxtReceiveDollar.Focus()
                    TxtReceiveDollar.SelectAll()
                Else
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            Else
                If CDbl(EmptyString(TxtReceivedR.Text)) < CDbl(EmptyString(TxtTotalKHR.Text)) Then
                    MessageBox.Show("សូមបញ្ជូល ចំនួនលុយដែលទទួលជា រៀល", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TxtReceivedR.Focus()
                    TxtReceiveDollar.SelectAll()
                Else
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If

           
        ElseIf e.KeyCode = Keys.D Then
            TxtReceiveDollar.Enabled = True
            TxtReceivedR.Enabled = False
            IsDolar = True
            TxtReceiveDollar.Text = "0"
            TxtReceivedR.Text = "0"
            TxtReceiveDollar.Focus()
            TxtReceiveDollar.SelectAll()
        ElseIf e.KeyCode = Keys.R Then
            IsDolar = False
            TxtReceivedR.Enabled = True
            TxtReceiveDollar.Enabled = False
            TxtReceivedR.Text = "0"
            TxtReceiveDollar.Text = "0"
            TxtReceivedR.Focus()
            TxtReceivedR.SelectAll()
        End If
    End Sub

    Private Sub TxtReceived_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtReceivedR.KeyUp
        TxtExchangeUSD.Text = FormatNumber(((EmptyString(TxtReceivedR.Text) / GetExchangeRage()) - EmptyString(TxtTotalUSD.Text)), 2)
        TxtExchangeKHR.Text = FormatNumber((EmptyString(TxtReceivedR.Text) - EmptyString(TxtTotalKHR.Text)), 0)
    End Sub

    Private Sub TxtReceived_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtReceivedR.KeyPress
        SetDisableKeyString(e)
    End Sub

    
    Private Sub TxtReceiveDollar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtReceiveDollar.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtReceiveDollar_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtReceiveDollar.KeyUp
        TxtExchangeUSD.Text = ((EmptyString(TxtReceiveDollar.Text)) - EmptyString(TxtTotalUSD.Text))
        TxtExchangeKHR.Text = ((EmptyString(TxtReceiveDollar.Text) * GetExchangeRage()) - EmptyString(TxtTotalKHR.Text))
    End Sub
  

    
End Class