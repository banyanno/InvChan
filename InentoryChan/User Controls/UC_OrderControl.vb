Public Class UC_OrderControl
    Dim DAOrder As New DSItemTableAdapters.ORDERTableAdapter
    Dim DAOrderDetail As New DSItemTableAdapters.ORDER_DETAILSTableAdapter
    Dim DAIssue As New DSItemTableAdapters.ISSUETableAdapter
    Dim DAReceive As New DSItemTableAdapters.RECEIVETableAdapter
    Dim DATransaction As New DSItemTableAdapters.TRANSACTIONTableAdapter
    Dim DAStore As New DSItemTableAdapters.ITEM_STORETableAdapter
    Private Sub TabNewOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabNewOrder.Click

    End Sub

    Private Sub UC_OrderControl_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RefreshOrder()
    End Sub
    Sub RefreshOrder()
        Dim LocationTable As New DataTable
        LocationTable = DAOrder.SelectOrderLocation("Pending")
        Me.cboLocation.DataSource = LocationTable
        Me.cboLocation.DisplayMember = "LOCA_NAME"
        Me.cboLocation.ValueMember = "LOCA_ID"
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        RefreshOrder()
    End Sub

    Private Sub cboNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNo.SelectedIndexChanged

    End Sub

    Private Sub cboNo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboNo.SelectionChangeCommitted
        Me.OrderList.DataSource = DAOrderDetail.SelectByOrderID(Me.cboNo.SelectedValue)
        Dim Total As Double = 0
        If Me.OrderList.RowCount >= 1 Then
            For i As Integer = 0 To OrderList.RowCount - 1
                Total = Total + CDbl(Me.OrderList.GetRow(i).Cells("AMOUNT").Value)
            Next
        End If
        Me.txttotal.Text = FormatCurrency(Total, 2)
    End Sub

    Private Sub cboLocation_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLocation.SelectionChangeCommitted
        Me.cboNo.DataSource = DAOrder.SelectByLocationIDAndStatus(CInt(Me.cboLocation.SelectedValue), "Pending")
        Me.cboNo.DisplayMember = "ORDE_ID"
        Me.cboNo.ValueMember = "ORDE_ID"
    End Sub

    Private Sub cboLocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLocation.SelectedIndexChanged

    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        If Me.OrderList.RowCount >= 1 Then
            Dim ResultTable As New DataTable
            Dim MyReport As New RptOrder
            Dim ReportViewer As New Report_Viewer
            ResultTable = DAOrderDetail.SelectByOrderID(CLng(Me.cboNo.Text))
            MyReport.SetDataSource(ResultTable)
            MyReport.SetParameterValue("OrderNo", CLng(Me.cboNo.Text))
            MyReport.SetParameterValue("OrderDate", DAOrder.SelectOrderByID(CLng(Me.cboNo.Text)).Rows(0).Item("ORDE_DATE"))
            ReportViewer.CrystalReportViewer1.ReportSource = MyReport
            ReportViewer.ShowDialog()
        Else
            MsgBox("No order to preview", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        If Me.OrderList.RowCount >= 1 Then
            Dim UpdatedBalance As Double
            Dim CurrentBalance As Double
            Dim IssueBalance As Double
            Dim MaxIssueID As Long
            Dim PreIssueTable As New DataTable
            Dim UnitID As Integer
            Dim ItemID As Integer
            Dim StoreID As Integer
            PreIssueTable = DAOrderDetail.SelectByOrderID(CLng(Me.cboNo.SelectedValue))
            For i As Integer = 0 To PreIssueTable.Rows.Count - 1
                ItemID = CInt(PreIssueTable.Rows(i).Item("ITEM_ID"))
                UnitID = CInt(CInt(PreIssueTable.Rows(i).Item("UNIT_ID")))
                StoreID = GetStoreID(ItemID, UnitID)
                CurrentBalance = GetStoreBalance(ItemID, UnitID)
                IssueBalance = CDbl(PreIssueTable.Rows(i).Item("ORDE_QTY"))
                UpdatedBalance = CurrentBalance - IssueBalance
                ' Add to Issue
                DAIssue.InsertIssue(StoreID, CInt(Me.cboLocation.SelectedValue), IssueBalance, CDbl(PreIssueTable.Rows(i).Item("ORDE_PRICE")), "Order", FormatDateTime(Now, DateFormat.ShortDate), getCurrentUserID)
                ' Refresh Balance if in Case 1
                CurrentBalance = GetStoreBalance(ItemID, UnitID)
                UpdatedBalance = CurrentBalance - IssueBalance
                ' Add to Transaction
                MaxIssueID = DAIssue.getMaxID
                DATransaction.InsertTransaction(StoreID, CurrentBalance, IssueBalance, UpdatedBalance, MaxIssueID, 2, CInt(Me.cboLocation.SelectedValue), FormatDateTime(Now, DateFormat.ShortDate), getCurrentUserID)
                ' Update Store Balance
                DAStore.UpdateBalance(UpdatedBalance, StoreID)
            Next

            DAOrder.UpdateStatus("Accepted", CLng(Me.cboNo.Text))
            MsgBox("An order was successfully accepted", MsgBoxStyle.Information)
            RefreshOrder()
            Me.OrderList.DataSource = DAOrderDetail.SelectByOrderID(0)
            cboLocation_SelectionChangeCommitted(sender, e)
        Else
            MsgBox("No order to accept", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub BtnReject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReject.Click
        If Me.OrderList.RowCount >= 1 Then
            If MsgBox("Do you want to reject this order?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DAOrder.UpdateStatus("Rejected", CLng(Me.cboNo.Text))
                MsgBox("An order was rejected", MsgBoxStyle.Information)
                RefreshOrder()
                Me.OrderList.DataSource = DAOrderDetail.SelectByOrderID(0)
                cboLocation_SelectionChangeCommitted(sender, e)
            End If
        Else
            MsgBox("No order to reject", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub cboStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStatus.SelectedIndexChanged

    End Sub

    Private Sub cboStatus_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboStatus.SelectionChangeCommitted
        Dim OrderTable As New DataTable
        If Me.cboStatus.Text = "All" Then
            OrderTable = DAOrder.SelectAllByDate(FormatDateTime(Me.dtFrom.Value, DateFormat.ShortDate), FormatDateTime(Me.dtTo.Value, DateFormat.ShortDate))
        Else
            OrderTable = DAOrder.SelectAllByStatus(cboStatus.Text, FormatDateTime(Me.dtFrom.Value, DateFormat.ShortDate), FormatDateTime(Me.dtTo.Value, DateFormat.ShortDate))
        End If
        Me.cboOrderNo.DataSource = OrderTable
        Me.cboOrderNo.DisplayMember = "ORDE_ID"
        Me.cboOrderNo.ValueMember = "ORDE_ID"
        cboOrderNo_SelectionChangeCommitted(sender, e)
    End Sub

    Private Sub cboOrderNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOrderNo.SelectedIndexChanged

    End Sub

    Private Sub cboOrderNo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboOrderNo.SelectionChangeCommitted
        Dim OrderNo As Long = 0
        If Me.cboOrderNo.Text <> "" Then
            OrderNo = CLng(Me.cboOrderNo.Text)
        End If
        Me.MyOrderList.DataSource = DAOrderDetail.SelectByOrderID(OrderNo)
        Dim Total As Double = 0
        If Me.MyOrderList.RowCount >= 1 Then
            For i As Integer = 0 To MyOrderList.RowCount - 1
                Total = Total + CDbl(Me.MyOrderList.GetRow(i).Cells("AMOUNT").Value)
            Next
        End If
        Me.txtTotalMyOrder.Text = FormatCurrency(Total, 2)
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        If Me.MyOrderList.RowCount >= 1 Then
            Dim ResultTable As New DataTable
            Dim MyReport As New RptOrder
            Dim ReportViewer As New Report_Viewer
            ResultTable = DAOrderDetail.SelectByOrderID(CLng(Me.cboOrderNo.Text))
            MyReport.SetDataSource(ResultTable)
            MyReport.SetParameterValue("OrderNo", CLng(Me.cboOrderNo.Text))
            MyReport.SetParameterValue("OrderDate", DAOrder.SelectOrderByID(CLng(Me.cboOrderNo.Text)).Rows(0).Item("ORDE_DATE"))
            ReportViewer.CrystalReportViewer1.ReportSource = MyReport
            ReportViewer.ShowDialog()
        Else
            MsgBox("No order to preview", MsgBoxStyle.Information)
        End If
    End Sub
End Class
