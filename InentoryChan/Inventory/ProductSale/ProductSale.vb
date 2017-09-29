Imports CrystalDecisions.Shared

Public Class ProductSale
    Dim DAItem As New DSInventoryTableAdapters.ITEMSTableAdapter
    Dim DAAR As New DSAccountReceivableTableAdapters.ACCOUNT_RECEIVABLETableAdapter
    Dim DAInvoice As New DSInventoryTableAdapters.INVOICETableAdapter
    Dim DAInvoiceDetail As New DSInventoryTableAdapters.INVOICE_DETAILSTableAdapter
    Dim DARptInvoice As New DSInventoryTableAdapters.RPT_INVOICETableAdapter
    Dim DAPreInvoice As New DSInventoryTableAdapters.PRE_INVOICE_DETAILSTableAdapter
    Dim DACustomer As New DSInventoryTableAdapters.CUSTOMERTableAdapter
    Dim PProductSale As DashboardProductSale
    Dim DAIssue As New DSStockTableAdapters.STOCK_ISSUETableAdapter
    Dim DAIssueDetail As New DSStockTableAdapters.STOCK_ISSUE_DETAILTableAdapter
    Dim DAReceive As New DSStockTableAdapters.STOCK_RECEIVETableAdapter
    Dim DAReceiveDetail As New DSStockTableAdapters.STOCK_RECEIVE_DETAILTableAdapter
    Dim DAStore As New DSInventoryTableAdapters.ITEM_BALANCETableAdapter
    Dim DATransaction As New DSStockTableAdapters.STOCK_TRANSACTIONTableAdapter
    Dim DAPayment As New DSAccountReceivableTableAdapters.AR_PAYMENTTableAdapter
    Sub New(ByVal MyPanel As DashboardProductSale)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PProductSale = MyPanel
    End Sub
    Private Sub BtnRefreshProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshProduct.Click
        SplitContainer1.Panel1Collapsed = False
    End Sub

    Private Sub ProductSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtInvoiceNo.Text = GetSaleNo()
        Me.OrderList.DataSource = DAPreInvoice.SelectByUserID(getCurrentUserID)
        lblExchangeRate.Text = "អត្រាប្តូរប្រាក់ 1$= " & FormatNumber(GetExchangeRage, 2) & "៛"
        'Me.cboCustName.DataSource = DACustomer.SelectAllCustomers
        'Me.cboCustName.ValueMember = "CUST_ID"
        'Me.cboCustName.DisplayMember = "CUST_NAME"
        'Me.cboCustName.SelectedIndex = -1
        If ChIsCustomer.Checked = False Then
            TxtCustomer.Text = ""
            txtSearchCustomer.Enabled = False
        Else
            GridCustomer.DataSource = DACustomer.SelectAllCustomers
        End If

        RefreshOrderList()
    End Sub

    Private Function GetSaleNo() As String
        Dim Years As Integer = Date.Now.Year
        Dim Month As String = Date.Now.Month.ToString
        Dim Days As String = Date.Now.Day.ToString
        Dim CountOrderNo As Double
        If Month.Length = 1 Then
            Month = "0" & Month
        Else
            Month = Month
        End If
        If Days.Length = 1 Then
            Days = "0" & Days
        Else
            Days = Days
        End If
        Try
            CountOrderNo = CDbl(DAInvoice.SelectInvoiceCountNo(Years))
            If CountOrderNo = 0 Then
                CountOrderNo = 1
            Else
                CountOrderNo = CountOrderNo + 1
            End If
        Catch ex As Exception
            CountOrderNo = 1
        End Try
        Return Years & Month & Days & CountOrderNo.ToString
    End Function
    Sub RefreshOrderList()
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

        Me.TxtTotalTHB.Text = THBAmount
        Me.TxtTotalUSD.Text = USDAmount
        Me.TxtTotalKHR.Text = (USDAmount * GetExchangeRage())
    End Sub


    Private Sub BtnAddProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddProduct.Click

        Dim FrmAdd As New AddProductSale(Me)
        'Dim FrmAdd As New FormAddProductSale
        FrmAdd.txtSearchProduct.Focus()
        FrmAdd.ShowDialog()

    End Sub

    Private Sub BtnRemoveProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveProduct.Click
        If Me.OrderList.RecordCount >= 1 Then
            If MsgBox("Do you want to remove this invoice record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DAPreInvoice.DeleteByID(Me.OrderList.CurrentRow.Cells("PRE_ID").Value)
                RefreshOrderList()
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        'If Me.OrderList.RecordCount >= 1 Then
        If MsgBox("Do you want to cancel this invoice?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DAPreInvoice.DeleteByUserID(getCurrentUserID)
            Me.Close()
            'RefreshOrderList()
        End If
        'Else
        'DAPreInvoice.DeleteByUserID(getCurrentUserID)
        '
        'End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If Me.OrderList.RecordCount <= 0 Then
            MessageBox.Show("Please add item before save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If ChIsCustomer.Checked = True Then
            'If ValidateCombobox(cboCustName, "", ErrSale) = False Then Exit Sub
            If GridCustomer.SelectedItems.Count = 0 Then
                MessageBox.Show("Please select customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        If DAInvoice.CheckExistInvoiceNo(txtInvoiceNo.Text) > 0 Then
            txtInvoiceNo.Text = GetSaleNo()
        End If
        If ValidateDateTimePicker(dtInvoice, "", ErrSale) = False Then Exit Sub
        Dim KHRTotal As Double = 0
        Dim USDTotal As Double = 0
        Dim THBTotal As Double = 0
        If Me.OrderList.RecordCount >= 1 Then
            If MessageBox.Show("Do you want to save?", "Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim OrderTable As New DataTable
                OrderTable = DAPreInvoice.SelectByUserID(getCurrentUserID)
                KHRTotal = CDbl(Me.TxtTotalKHR.Text)
                USDTotal = CDbl(Me.TxtTotalUSD.Text)
                THBTotal = CDbl(Me.TxtTotalTHB.Text)
                'OrderTable = Nothing
                '' INSERT INVOICE
                Dim CustID As Integer = 0
                If ChIsCustomer.Checked = True Then
                    CustID = CInt(GridCustomer.GetRow.Cells("CUST_ID").Value)
                End If
                ' Insert into Tatable Inovioce 
                DAInvoice.InsertInvoice(CustID, IIf(CustID = 0, "លក់រាយ", Me.TxtCustomer.Text), KHRTotal, USDTotal, THBTotal, 0, "", KHRTotal, USDTotal, THBTotal, getCurrentUserID, Me.dtInvoice.Value.Date, IIf(CustID = 0, 1, 0), txtInvoiceNo.Text, Now.Year, GetExchangeRage, 0, 0, 0, 0)
                '' INSERT ISSUE
                DAIssue.InsertIssue(DAInvoice.getMaxID, "Sale", dtInvoice.Value, getCurrentUserID)
                Dim IssueID As Long = DAIssue.getMaxID

                '' INSERT INVOICE DETAILS & ISSUE DETAIL
                Dim DetailTable As New DataTable
                DetailTable = DAPreInvoice.SelectByUserID(getCurrentUserID)
                Dim ItemID As Integer
                Dim CurrCode As String
                Dim UnitName As String
                Dim UnitNameFree As String
                Dim Cost As Decimal
                Dim Qty As Decimal
                Dim QtyFree As Decimal
                Dim Price As Decimal
                Dim Discount As Double
                Dim USD_Amount As Double
                Dim KHR_Amount As Double
                Dim THB_Amount As Double
                Dim IS_ItemFree As Boolean
                Dim UnitType As String
                Dim UnitTypeFree As String
                Dim CurrentBalance As Decimal
                Dim CurrentBalanceFree As Decimal
                ' Loop Get from Table Pre-Invoice get
                For j As Integer = 0 To DetailTable.Rows.Count - 1
                    ItemID = CInt(DetailTable.Rows(j).Item("ITEM_ID"))
                    CurrCode = DetailTable.Rows(j).Item("CURR_CODE").ToString
                    UnitName = DetailTable.Rows(j).Item("UNIT_NAME").ToString
                    Cost = DetailTable.Rows(j).Item("COST")
                    Qty = CDec(DetailTable.Rows(j).Item("QTY"))
                    'UnitNameFree = DetailTable.Rows(j).Item("INIT_NAME_FREE").ToString
                    QtyFree = CDec(DetailTable.Rows(j).Item("QTY_FREE"))
                    Price = CDbl(DetailTable.Rows(j).Item("PRICE"))
                    Discount = CDec(DetailTable.Rows(j).Item("DISCOUNT"))
                    USD_Amount = CDbl(DetailTable.Rows(j).Item("USD_AMOUNT"))
                    KHR_Amount = CDec(DetailTable.Rows(j).Item("KHR_AMOUNT"))
                    THB_Amount = CDec(DetailTable.Rows(j).Item("THB_AMOUNT"))
                    IS_ItemFree = CBool(DetailTable.Rows(j).Item("IS_EXTRA"))

                    ' Loop to insert for invoice Dedaitl.
                    DAInvoiceDetail.InsertDetail(DAInvoice.getMaxID, ItemID, UnitName, Qty, Price, Discount, CurrCode, KHR_Amount, USD_Amount, THB_Amount, QtyFree, UnitNameFree, IS_ItemFree, Cost)

                    '========================================
                    '===================== Process   ===================
                    '===================== Cut stock ===================

                    Dim StoreID As Integer = CInt(DAStore.SelectByItemAndUnit(ItemID).Rows(0).Item("STORE_ID"))
                    ' ======================== Freeeeeeeeeeeee ===================
                    'Dim StoreFeeID As Integer = 0
                    'Try
                    '    StoreFeeID = CInt(DAStore.SelectByItemAndUnit(ItemID, UnitNameFree).Rows(0).Item("STORE_ID"))
                    'Catch ex As Exception

                    'End Try

                    CurrentBalance = CDec(DAStore.SelectByStoreID(StoreID).Rows(0).Item("BALANCE"))
                 
                    DAIssueDetail.InsertDetail(IssueID, StoreID, ItemID, Qty)
                    DATransaction.InsertTransaction(StoreID, ItemID, IssueID, "ISSUE", CurrentBalance, Qty, CurrentBalance - Qty, dtInvoice.Value.Date, getCurrentUserID)
                    DAStore.UpdateBalance(CurrentBalance - Qty, StoreID)
                Next

                ''INSERT INTO ACCOUNT RECEIVABLE
                Dim InvoiceNo As Long = DAInvoice.getMaxID
                If DAAR.InsertReceivable(InvoiceNo, CustID, KHRTotal, THBTotal, USDTotal, 0, 0, 0, "លក់អោយម៉ូយ", CInt(IIf(CustID = 0, 1, 0)), dtInvoice.Value.Date) = 1 Then
                    ' In case sell រាយ
                    If CustID = 0 Then
                        DAPayment.InsertPayment(DAAR.GetMaxAccReID, 0, USDTotal, 0, dtInvoice.Value.Date, "ទទួលពីកាលក់រាយ", getCurrentUserID)
                        DAAR.UpdatePaidAmount(0, 0, USDTotal, 1, DAAR.GetMaxAccReID)
                    Else
                        DAPayment.InsertPayment(DAAR.GetMaxAccReID, 0, 0, 0, dtInvoice.Value.Date, "", getCurrentUserID)
                        DAAR.UpdatePaidAmount(0, 0, 0, 0, DAAR.GetMaxAccReID)
                    End If
                End If

                MsgBox("The invoice was saved", MsgBoxStyle.Information)
                DAPreInvoice.DeleteByUserID(getCurrentUserID)
                Dim RAccPayable As New ReportViewer
                'Dim MyReport As New RptInvoiceSmalBK
                'Dim TblAccPayable As DataTable = DARptInvoice.SelectDetailsByInvoiceID(CInt(InvoiceNo))
                'MyReport.SetDataSource(TblAccPayable)
                'Dim CrExportOptionsBig As ExportOptions
                'Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
                'Dim CrFormatTypeOptionsBig As New PdfRtfWordFormatOptions()
                'CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\InvoiceSmalBK.pdf"
                'CrExportOptionsBig = MyReport.ExportOptions
                'With CrExportOptionsBig
                '    .ExportDestinationType = ExportDestinationType.DiskFile
                '    .ExportFormatType = ExportFormatType.PortableDocFormat
                '    .DestinationOptions = CrDiskFileDestinationOptionsBig
                '    .FormatOptions = CrFormatTypeOptionsBig
                'End With
                'MyReport.Export()
                'Application.DoEvents()
                'Application.DoEvents()
                'RAccPayable.AxAcroPDF1.src = My.Application.Info.DirectoryPath & "\InvoiceSmalBK.pdf"
                'RAccPayable.AxAcroPDF1.setZoom(100)


                Dim MyReport As New RptInvoiceSmalBK
                Dim TblAccPayable As DataTable = DARptInvoice.SelectDetailsByInvoiceID(CInt(InvoiceNo))
                MyReport.SetDataSource(TblAccPayable)
                MyReport.SetParameterValue("ExchangeRate", FormatNumber(GetExchangeRage, 2))
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

                RefreshOrderList()
                PProductSale.RefreshList()
                Me.Close()



                'Dim ResultTable As New DataTable
                'Dim MyReport As New RptInvoice
                'Dim ReportViewer As New Report_Viewer
                'ResultTable = DARptInvoice.SelectDetailsByInvoiceID(InvoiceNo)
                'If ResultTable.Rows.Count >= 1 Then
                '    MyReport.SetDataSource(ResultTable)
                '    ReportViewer.CrystalReportViewer1.ReportSource = MyReport
                '    ReportViewer.ShowDialog()
                'Else
                '    MsgBox("No record to preview", MsgBoxStyle.Information)
                'End If
            End If

        End If
    End Sub



    Private Sub ProductSale_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'If MsgBox("Do you want to cancel this invoice?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        DAPreInvoice.DeleteByUserID(getCurrentUserID)
        'Me.Close()
        'RefreshOrderList()
        'End If
    End Sub

    Private Sub txtSearchCustomer_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchCustomer.GotFocus
        SetKhmerLanguage()
    End Sub

    Private Sub txtSearchCustomer_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearchCustomer.KeyUp
        If txtSearchCustomer.Text = "" Then
            GridCustomer.DataSource = DACustomer.SelectAllCustomers
        Else
            GridCustomer.DataSource = DACustomer.SelectAutoCustomer(txtSearchCustomer.Text.ToUpper)
        End If
    End Sub

    Private Sub GridCustomer_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridCustomer.SelectionChanged
        Try
            Dim CustTable As New DataTable
            CustTable = DACustomer.SelectCustomerByID(CInt(GridCustomer.GetRow.Cells("CUST_ID").Value))
            TxtCustomer.Text = GridCustomer.GetRow.Cells("CUST_NAME").Value
            Me.txtAddress.Text = CustTable.Rows(0).Item("CUST_ADDRESS").ToString
            Me.txtPhone.Text = CustTable.Rows(0).Item("CUST_PHONE").ToString
        Catch ex As Exception
            TxtCustomer.Text = ""
            Me.txtAddress.Text = ""
            Me.txtPhone.Text = ""
        End Try
    End Sub

    
    Private Sub BtnNewCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewCustomer.Click
        Dim FnewCustomer As New NewCostomer
        If FnewCustomer.ShowDialog = Windows.Forms.DialogResult.OK Then
           GridCustomer.DataSource = DACustomer.SelectAllCustomers
        End If
    End Sub
End Class