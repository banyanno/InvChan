Public Class SecondScreen
    Dim DAPreInvoice As New DSInventoryTableAdapters.PRE_INVOICE_DETAILSTableAdapter
    Public Sub RefreshOrderList()
        Dim OrderTable As New DataTable
        OrderTable = DAPreInvoice.SelectByUserID(getCurrentUserID)
        Me.OrderList.DataSource = OrderTable
        Dim KHRAmount As Double = 0
        Dim USDAmount As Double = 0
        Dim THBAmount As Double = 0

        If Me.OrderList.RecordCount >= 1 Then
            For i As Integer = 0 To OrderTable.Rows.Count - 1
                KHRAmount = KHRAmount + CDbl(OrderTable.Rows(i).Item("KHR_AMOUNT"))
                USDAmount = USDAmount + CDbl(OrderTable.Rows(i).Item("USD_AMOUNT"))
                THBAmount = THBAmount + CDbl(OrderTable.Rows(i).Item("THB_AMOUNT"))
            Next
        End If

        Me.LblTotalD.Text = "$ " & FormatNumber(USDAmount, 2)
        Me.LblTotalR.Text = "៛​ " & FormatNumber(USDAmount * GetExchangeRage(), 0)
    End Sub
End Class