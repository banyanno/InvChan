Imports CrystalDecisions.Shared

Public Class DashboardProductSale
    Dim DAInvoice As New DSInventoryTableAdapters.INVOICETableAdapter
    Dim DADetail As New DSInventoryTableAdapters.INVOICE_DETAILSTableAdapter
    Dim DARptInvoice As New DSInventoryTableAdapters.RPT_INVOICETableAdapter
    Dim DAPayment As New DSAccountReceivableTableAdapters.ACCOUNT_RECEIVABLETableAdapter
    Dim DAAccReceiveAble As New DSAccountReceivableTableAdapters.ACCOUNT_RECEIVABLETableAdapter

    ' Process cut stock
    Dim DAIssue As New DSStockTableAdapters.STOCK_ISSUETableAdapter
    Dim DAIssueDetail As New DSStockTableAdapters.STOCK_ISSUE_DETAILTableAdapter
    Dim DAReceive As New DSStockTableAdapters.STOCK_RECEIVETableAdapter
    Dim DAReceiveDetail As New DSStockTableAdapters.STOCK_RECEIVE_DETAILTableAdapter
    Dim DAStore As New DSInventoryTableAdapters.ITEM_BALANCETableAdapter
    Dim DATransaction As New DSStockTableAdapters.STOCK_TRANSACTIONTableAdapter

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Dim FProductSale As New ProductSale(Me)
        FProductSale.ChIsCustomer.Checked = True
        FProductSale.ChIsCustomer.Enabled = False
        If FProductSale.ShowDialog = DialogResult.OK Then

        End If
    End Sub

    Sub RefreshList()
        Me.InvoiceList.DataSource = DAInvoice.SelectAllInvoiceDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
        If Me.InvoiceList.SelectedItems.Count <> 0 Then
            DetailList.DataSource = DADetail.SelectByInvoiceID(Me.InvoiceList.CurrentRow.Cells("INVOICE_ID").Value)
        Else
            DetailList.DataSource = Nothing
        End If
    End Sub

    Private Sub ToolProduct_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolProduct.ItemClicked

    End Sub

    Private Sub InvoiceList_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs)

    End Sub

    Private Sub DashboardProductSale_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RefreshList()
    End Sub

    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click
        RefreshList()
    End Sub

  

    Private Sub InvoiceList_SelectionChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles InvoiceList.SelectionChanged
        If Me.InvoiceList.RowCount >= 1 Then
            DetailList.DataSource = DADetail.SelectByInvoiceID(Me.InvoiceList.CurrentRow.Cells("INVOICE_ID").Value)
        End If
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.InvoiceList.RecordCount >= 1 Then
            Dim FrmNewPayment As New InvoicePayment(Me)
            FrmNewPayment.txtCustName.Text = InvoiceList.CurrentRow.Cells("CUST_NAME").Value
            FrmNewPayment.txtInvoiceNo.Text = Format(InvoiceList.CurrentRow.Cells("INVOICE_ID").Value, "000000")
            FrmNewPayment.txtDateInvoice.Text = FormatDateTime(InvoiceList.CurrentRow.Cells("INVOICE_DATE").Value.ToString, DateFormat.ShortDate)

            FrmNewPayment.txtTotalKHR.Text = InvoiceList.CurrentRow.Cells("KHR_AMOUNT").Value
            FrmNewPayment.txtTotalUSD.Text = InvoiceList.CurrentRow.Cells("USD_AMOUNT").Value
            FrmNewPayment.txtTotalTHB.Text = InvoiceList.CurrentRow.Cells("THB_AMOUNT").Value

            FrmNewPayment.txtUnpaidUSD.Text = CDec(InvoiceList.CurrentRow.Cells("USD_AMOUNT").Value) - CDec(InvoiceList.CurrentRow.Cells("USD_PAID").Value)
            FrmNewPayment.txtUnpaidKHR.Text = CDec(InvoiceList.CurrentRow.Cells("KHR_AMOUNT").Value) - CDec(InvoiceList.CurrentRow.Cells("KHR_PAID").Value)
            FrmNewPayment.txtUnpaidTHB.Text = CDec(InvoiceList.CurrentRow.Cells("THB_AMOUNT").Value) - CDec(InvoiceList.CurrentRow.Cells("THB_PAID").Value)
            FrmNewPayment.ShowDialog()

        End If
    End Sub

    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click
        Try
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Temp", FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                My.Computer.FileSystem.DeleteFile(foundFile, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            Next

            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim sql As String = "SELECT INVOICE_ID,INVOICE_NO,CUST_ID,CUST_NAME,USD_AMOUNT,USD_TOTAL,INVOICE_DATE,RATE,MONEY_RECEIVED,RETURN_KHR,RETURN_USD,DETAIL_ID,ITEM_ID,QTY,PRICE,USD_SUPTOTAL,ITEM_NAME,USER_ID,USER_NAME,MONEY_RECEIVEDOLAR FROM ViewInvoice WHERE INVOICE_ID=" & InvoiceList.GetRow.Cells("INVOICE_ID").Value
            Dim cnn As New SqlClient.SqlConnection(My.Settings.INV_Database)

            Application.DoEvents()
            cnn.Open()
            Dim Da As New SqlClient.SqlDataAdapter(sql, cnn)
            Application.DoEvents()
            System.Threading.Thread.Sleep(100)
            Da.Fill(DS, "ViewInvoice")
            Application.DoEvents()
            Dim RptName As String = Application.StartupPath & "\RptInvoice.rpt"

            ' Dim RAccPayable As New ReportPreview
            ' Dim MyReport As New RptInvoice
            Dim myReportObj As New clsCrystalReport()
            myReportObj.ReportPath(RptName)
            Application.DoEvents()
            myReportObj.SetDataSource(DS, "ViewInvoice")

            myReportObj.PrintToPrinter()
            myReportObj.PrintToPrinter()
            cnn.Close()
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub BtnSaleWale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaleWale.Click
        Dim FNewSale As New NewSale
        FNewSale.ShowDialog()
        'Dim FProductSale As New ProductSale(Me)
        'FProductSale.ChIsCustomer.Enabled = False
        ''FProductSale.cboCustName.Enabled = False
        'If FProductSale.ShowDialog = DialogResult.OK Then

        'End If
    End Sub

    Private Sub TxtInvoiceNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtInvoiceNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        If ISInvoiceNo.Checked = True Then
            Me.InvoiceList.DataSource = DAInvoice.SelectByInvoiceDateToDate(DateFrom.Value.Date, DateTo.Value.Date, EmptyString(TxtInvoiceNo.Text))
            If Me.InvoiceList.SelectedItems.Count <> 0 Then
                DetailList.DataSource = DADetail.SelectByInvoiceID(Me.InvoiceList.CurrentRow.Cells("INVOICE_ID").Value)
            Else
                DetailList.DataSource = Nothing
            End If
        Else
            RefreshList()
        End If
    End Sub

    Private Sub ISInvoiceNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ISInvoiceNo.CheckedChanged
        TxtInvoiceNo.Enabled = ISInvoiceNo.Checked
    End Sub

    Private Sub BtnDeleteInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteInvoice.Click
        If InvoiceList.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete this invoice?", "Delete Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DAInvoice.DeleteInvoiceNo(1, InvoiceList.GetRow.Cells("INVOICE_ID").Value) = 1 Then
                DAPayment.DeletAccReceive(1, InvoiceList.GetRow.Cells("INVOICE_ID").Value)
                RefreshList()
            End If

        End If
    End Sub

    Private Sub BtnUndoDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUndoDelete.Click
        If InvoiceList.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete this invoice?", "Delete Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DAInvoice.DeleteInvoiceNo(0, InvoiceList.GetRow.Cells("INVOICE_ID").Value) = 1 Then
                DAPayment.DeletAccReceive(0, InvoiceList.GetRow.Cells("INVOICE_ID").Value)
                RefreshList()
            End If
        End If
    End Sub

    Private Sub BtnPrintA4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintA4.Click
        If Me.InvoiceList.RecordCount >= 1 Then
            Dim RAccPayable As New ReportViewer
            Dim MyReport As New RptInvoiceSmalBK
            Dim TblAccPayable As DataTable = DARptInvoice.SelectDetailsByInvoiceID(CInt(InvoiceList.CurrentRow.Cells("INVOICE_ID").Value))
            MyReport.SetDataSource(TblAccPayable)
            MyReport.SetParameterValue("ExchangeRate", InvoiceList.GetRow.Cells("RATE").Value)
            Dim CrExportOptionsBig As ExportOptions
            Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
            Dim CrFormatTypeOptionsBig As New PdfRtfWordFormatOptions()
            CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\InvoiceSmalBK.pdf"
            CrExportOptionsBig = MyReport.ExportOptions
            With CrExportOptionsBig
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = CrDiskFileDestinationOptionsBig
                .FormatOptions = CrFormatTypeOptionsBig
            End With
            MyReport.Export()
            Application.DoEvents()
            Application.DoEvents()
            RAccPayable.AxAcroPDF1.src = My.Application.Info.DirectoryPath & "\InvoiceSmalBK.pdf"
            RAccPayable.AxAcroPDF1.setZoom(100)
            RAccPayable.ShowDialog()
        End If
    End Sub

    Private Sub BtnAddProdut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddProdut.Click
        If InvoiceList.SelectedItems.Count = 0 Then Exit Sub
        Dim MoreSale As New AddMoreProductSale
        MoreSale.LblInvoiceNo.Text = InvoiceList.GetRow.Cells("INVOICE_ID").Value
        MoreSale.LblKHRTotal.Text = InvoiceList.GetRow.Cells("KHR_AMOUNT").Value
        MoreSale.LblUSDTotal.Text = InvoiceList.GetRow.Cells("USD_AMOUNT").Value
        MoreSale.LblTHBTotal.Text = InvoiceList.GetRow.Cells("THB_AMOUNT").Value
        If MoreSale.ShowDialog = DialogResult.OK Then
            ISInvoiceNo.Checked = True
            TxtInvoiceNo.Text = InvoiceList.GetRow.Cells("INVOICE_NO").Value
            BtnFind_Click(sender, e)
            'DetailList.DataSource = DADetail.SelectByInvoiceID(Me.InvoiceList.CurrentRow.Cells("INVOICE_ID").Value)
        End If
    End Sub

    Private Sub BtnRemoveProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveProduct.Click
        If DetailList.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to remove this item?", "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim QTYReceived As Integer = DetailList.GetRow.Cells("QTY").Value
            Dim QTYPromotion As Integer = DetailList.GetRow.Cells("QTY_FREE").Value
            Dim ItemID As Double = DetailList.GetRow.Cells("ITEM_ID").Value

          

            Dim StoreID As Integer
            Dim StoreIDFree As Integer
            Dim CurrentQty As Decimal
            Dim CurrentQTYFree As Decimal

            Dim UnitTypeFree As String
            Dim QtyFree As Decimal

            'Money ......
            Dim KHRAmount As Decimal = 0
            Dim THBAmount As Decimal = 0
            Dim USDAmount As Decimal = 0
            Dim Discount As Decimal = 0
            Dim Amount As Decimal = 0

            Dim Current As String = DetailList.GetRow.Cells("CURR_CODE").Value

            If Current = "$" Then
                USDAmount = CDec(DetailList.GetRow.Cells("USD_AMOUNT").Value)
            ElseIf Current = "៛" Then
                KHRAmount = CDec(DetailList.GetRow.Cells("KHR_AMOUNT").Value)
            Else
                THBAmount = CDec(DetailList.GetRow.Cells("THB_AMOUNT").Value)
            End If


            Dim USD_Amount As Decimal
            Dim KHR_Amount As Decimal
            Dim THB_Amount As Decimal

            Dim TotalKHR As Double = InvoiceList.GetRow.Cells("KHR_AMOUNT").Value
            Dim TotalUSD As Double = InvoiceList.GetRow.Cells("USD_AMOUNT").Value
            Dim TotalTHB As Double = InvoiceList.GetRow.Cells("THB_AMOUNT").Value


            USD_Amount = USDAmount
            KHR_Amount = KHRAmount
            THB_Amount = THBAmount



            StoreID = DAStore.SelectByItemAndUnit(ItemID).Rows(0).Item("STORE_ID")
            Try
                StoreIDFree = DAStore.SelectByItemAndUnit(ItemID).Rows(0).Item("STORE_ID")
            Catch ex As Exception

            End Try

            CurrentQty = CDec(DAStore.SelectByStoreID(StoreID).Rows(0).Item("BALANCE"))
            Try
                CurrentQTYFree = CDec(DAStore.SelectByStoreID(StoreIDFree).Rows(0).Item("BALANCE"))
            Catch ex As Exception

            End Try
            Try
                UnitTypeFree = CStr(DAStore.SelectByStoreID(StoreIDFree).Rows(0).Item("UNIT_TYPE"))
            Catch ex As Exception

            End Try

            ' Insert Received detail
            'DAReceiveDetail.InsertDetail(ReceiveID, StoreID, ItemID, CDec(IIf(UnitTypeFree <> "Sub Unit", QTYReceived + QTYPromotion, QTYReceived)))
            'If UnitTypeFree = "Sub Unit" And UnitTypeFree <> "" Then
            '    DAReceiveDetail.InsertDetail(ReceiveID, StoreIDFree, GridPurchaseDetail.GetRow(i).Cells("ITEM_ID").Value, QTYPromotion)
            'End If

            ' Update stock


            DAStore.UpdateBalance(CurrentQty + CDec(IIf(UnitTypeFree <> "Sub Unit", QTYReceived + QTYPromotion, QTYReceived)), StoreID)
            If UnitTypeFree = "Sub Unit" And UnitTypeFree <> "" Then
                DAStore.UpdateBalance(CurrentQTYFree + QTYPromotion, StoreIDFree)
            End If
            'DATransaction.InsertTransaction(StoreID, ItemID, ReceiveID, "RECEIVE", CurrentQty, CDec(IIf(UnitTypeFree <> "Sub Unit", QTYReceived + QTYPromotion, QTYReceived)), CurrentQty + CDec(IIf(UnitTypeFree <> "Sub Unit", QTYReceived + QTYPromotion, QTYReceived)), FReceiveStock.DateReceived.Value.Date, getCurrentUserID)

            'If UnitTypeFree = "Sub Unit" And UnitTypeFree <> "" Then
            '    DATransaction.InsertTransaction(StoreIDFree, ItemID, ReceiveID, "RECEIVE", CurrentQTYFree, CurrentQTYFree + QTYPromotion, CurrentQTYFree + QTYPromotion, FReceiveStock.DateReceived.Value.Date, getCurrentUserID)
            'End If
            DAInvoice.UpdateTotalPrice(TotalKHR - KHR_Amount, TotalUSD - USD_Amount, TotalTHB - THB_Amount, TotalKHR - KHR_Amount, TotalUSD - USD_Amount, TotalTHB - THB_Amount, Me.InvoiceList.CurrentRow.Cells("INVOICE_ID").Value)
            DAAccReceiveAble.UpdateAccReceiveAble(TotalKHR - KHR_Amount, TotalTHB - THB_Amount, TotalUSD - USD_Amount, Me.InvoiceList.CurrentRow.Cells("INVOICE_ID").Value)

            DADetail.DeleteItemID(DetailList.GetRow.Cells("DETAIL_ID").Value)
            ISInvoiceNo.Checked = True
            TxtInvoiceNo.Text = InvoiceList.GetRow.Cells("INVOICE_NO").Value
            BtnFind_Click(sender, e)
        End If
        


    End Sub

    Private Sub BtnRietalSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRietalSale.Click
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Temp", FileIO.SearchOption.SearchAllSubDirectories, "*.*")
            My.Computer.FileSystem.DeleteFile(foundFile, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        Next

        Dim SQL As String = "select ITEM_ID,ITEM_NAME,COST , Price ,sum(qty) as TotalQTY, (sum(qty)*Price) as saleHold,(sum(qty)*Price) as saleRetial from ViewDialySale " & _
        " where (VOIDE=1) and (invoice_date between '" & DateFrom.Value.Date & "' and '" & DateTo.Value.Date & "')" & _
        " group by ITEM_ID,ITEM_NAME,COST,Price ORDER BY ITEM_NAME"

        Dim DS As New DataSet
        Dim dt As New DataTable
        Dim cnn As New SqlClient.SqlConnection(My.Settings.INV_Database)

        Application.DoEvents()

        Dim Da As New SqlClient.SqlDataAdapter(sql, cnn)
        Application.DoEvents()
        System.Threading.Thread.Sleep(100)
        Da.Fill(DS, "IncomeSale")
        Application.DoEvents()
        Dim RptName As String = Application.StartupPath & "\DialySaleIncome.rpt"

        Dim RAccPayable As New ReportPreview

        Dim myReportObj As New clsCrystalReport()


        myReportObj.ReportPath(RptName)

        Application.DoEvents()
        myReportObj.SetDataSource(DS, "IncomeSale")
        myReportObj.SetParameterValue("DateReport", "ចាប់ពីថ្ងៃទី  " & Format(DateFrom.Value, "dd/MM/yyyy") & " ដល់ " & Format(DateTo.Value.Date, "dd/MM/yyyy"))
        RAccPayable.ReportViewer.Refresh()
        RAccPayable.ReportViewer.ReportSource = myReportObj.Report
        RAccPayable.ReportViewer.ViewReport()
        RAccPayable.ReportViewer.Zoom(100)
        RAccPayable.ShowDialog()

    End Sub

    Private Sub btnWholSaleReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWholSaleReport.Click
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Temp", FileIO.SearchOption.SearchAllSubDirectories, "*.*")
            My.Computer.FileSystem.DeleteFile(foundFile, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        Next

        Dim SQL As String = "select ITEM_ID,ITEM_NAME,COST , Price ,sum(qty) as TotalQTY, (sum(qty)*Price) as saleHold,(sum(qty)*Price) as saleRetial from ViewDialySale " & _
       " where VOIDE=0 and invoice_date between '" & DateFrom.Value.Date & "' and '" & DateTo.Value.Date & "'" & _
       " group by ITEM_ID,ITEM_NAME,COST,Price,VOIDE ORDER BY ITEM_NAME"

        Dim DS As New DataSet
        Dim dt As New DataTable
        Dim cnn As New SqlClient.SqlConnection(My.Settings.INV_Database)

        Application.DoEvents()

        Dim Da As New SqlClient.SqlDataAdapter(SQL, cnn)
        Application.DoEvents()
        System.Threading.Thread.Sleep(100)
        Da.Fill(DS, "IncomeSale")
        Application.DoEvents()
        Dim RptName As String = Application.StartupPath & "\WholdDialySaleIncome.rpt"

        Dim RAccPayable As New ReportPreview

        Dim myReportObj As New clsCrystalReport()

        myReportObj.ReportPath(RptName)

        Application.DoEvents()
        myReportObj.SetDataSource(DS, "IncomeSale")
        myReportObj.SetParameterValue("DateReport", "ចាប់ពីថ្ងៃទី  " & Format(DateFrom.Value, "dd/MM/yyyy") & " ដល់ " & Format(DateTo.Value.Date, "dd/MM/yyyy"))
        RAccPayable.ReportViewer.Refresh()
        RAccPayable.ReportViewer.ReportSource = myReportObj.Report
        RAccPayable.ReportViewer.ViewReport()
        RAccPayable.ReportViewer.Zoom(100)
        RAccPayable.ShowDialog()
    End Sub
End Class
