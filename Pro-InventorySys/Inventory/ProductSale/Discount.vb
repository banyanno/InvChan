Public Class Discount
    Dim MSale As NewSale
    Dim DAPreOder As New DSInventoryTableAdapters.PRE_INVOICE_DETAILSTableAdapter
    Sub New(ByVal MSale As NewSale)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MSale = MSale
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub Discount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtDiscount.Focus()
        TxtDiscount.SelectAll()
    End Sub

    Private Sub TxtDiscount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDiscount.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub Discount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TxtDiscount.Text <= 0 Then
                MessageBox.Show("Please enter QTY >0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            DAPreOder.UpdateQTY(CDbl(EmptyString(TxtDiscount.Text)), (CDbl(EmptyString(TxtDiscount.Text)) * CDbl(LblPrice.Text)), LblItemID.Text)
            Me.MSale.RefreshOrderList()
            Me.Close()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class