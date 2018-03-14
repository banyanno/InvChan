
Imports CrystalDecisions.Shared
Public Class NewSale
    Dim DAItem As New DSInventoryTableAdapters.CentralStoreTableAdapter
    Dim DAPreInvoice As New DSInventoryTableAdapters.PRE_INVOICE_DETAILSTableAdapter
    Dim DAIssue As New DSStockTableAdapters.STOCK_ISSUETableAdapter
    Dim DAInvoice As New DSInventoryTableAdapters.INVOICETableAdapter
    Dim DAInvoiceDetail As New DSInventoryTableAdapters.INVOICE_DETAILSTableAdapter
    Dim DAStore As New DSInventoryTableAdapters.ITEM_BALANCETableAdapter
    Dim DAIssueDetail As New DSStockTableAdapters.STOCK_ISSUE_DETAILTableAdapter
    Dim DATransaction As New DSStockTableAdapters.STOCK_TRANSACTIONTableAdapter
    Dim DAAR As New DSAccountReceivableTableAdapters.ACCOUNT_RECEIVABLETableAdapter
    Dim DAReceive As New DSStockTableAdapters.STOCK_RECEIVETableAdapter
    Dim DAReceiveDetail As New DSStockTableAdapters.STOCK_RECEIVE_DETAILTableAdapter
    Dim DARptInvoice As New DSInventoryTableAdapters.RPT_INVOICETableAdapter
    Dim DAPayment As New DSAccountReceivableTableAdapters.AR_PAYMENTTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' RefreshProductList()
    End Sub
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

        Me.TxtTotalUSD.Text = FormatNumber(USDAmount, 2)
        Me.TxtTotalKHR.Text = FormatNumber(USDAmount * GetExchangeRage(), 0)
        secondScreen.RefreshOrderList()
        txtBarcode.Select()
        txtBarcode.Focus()
        txtBarcode.SelectAll()
    End Sub
    Private Sub RefreshProductList()

        Dim tbl As DataTable = DAItem.GetData
        PopulateNodesFloor(tbl, ListProduct)
        txtBarcode.Select()
        txtBarcode.Focus()
        txtBarcode.SelectAll()
    End Sub
    Public Sub SearchByProductName(ByVal Product As String)
        Dim tbl As DataTable = DAItem.SelectFullName(Product)
        'If tbl.Rows.Count > 0 Then
        PopulateNodesFloor(tbl, ListProduct)
        'End If

    End Sub
    Private Sub SearchByBarCode(ByVal BarCode As String)
        Dim tbl As DataTable = DAItem.SelectByBarCode(BarCode)
        PopulateNodesFloor(tbl, ListProduct)
    End Sub
   
    Private Sub PopulateNodesFloor(ByVal dtbl As DataTable, ByVal lv As ListView)
        lv.Clear()
        lv.Items.Clear()

        lv.Groups.Clear()
        lv.Refresh()
        'Dim lvGroup As ListViewGroup
        Dim lvItem As New ListViewItem
        Dim li As New ImageList()

        li.ImageSize = New Size(85, 85)
        li.ColorDepth = ColorDepth.Depth32Bit
        lv.LargeImageList = li

        Dim ImgIndex As Integer = 0

        For Each dr As DataRow In dtbl.Rows
            Application.DoEvents()
            Threading.Thread.Sleep(30)
            'If TypeOf dr("ITEM_IMAGE") Is DBNull Then
            '    imageData = Nothing
            'Else

            'End If
            Try
                Dim imageData As Byte() = CType(dr("ITEM_IMAGE"), Byte())
                li.Images.Add(dr("ITEM_ID").ToString, byteArrayToImage(imageData))
            Catch ex As Exception
                li.Images.Add(dr("ITEM_ID").ToString, Bitmap.FromFile(My.Application.Info.DirectoryPath & "\NewProduct.png"))
            End Try
            'PicturePatient.ImageLocation = My.Application.Info.DirectoryPath & "\patient.jpg"

            lvItem = lv.Items.Add(dr("ITEM_NAME").ToString & " " & dr("RETAIL_PRICE").ToString & "$")
            ' lvGroup = lv.Groups.Add(dr("ITEM_NAME").ToString, dr("CATE_NAME").ToString)
            lvItem.ImageIndex = ImgIndex
            lvItem.Name = dr("ITEM_ID").ToString
            'If RowRooms("IS_KTV") = True Then
            '    lvItem.ImageIndex = 1
            'Else
            '    lvItem.ImageIndex = 0
            'End If
            lvItem.Tag = dr
            ' lvGroup.Items.Add(lvItem)
            ImgIndex = ImgIndex + 1
        Next
    End Sub

    Private Sub NewSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        'LblProfile.Text = GetComName() & vbCrLf & GetComAddress()
        LblRate.Text = "អត្រាប្តូប្រាក់:​ 1$ = " & FormatNumber(GetExchangeRage(), 2) & "៛"
        ''SplitContainer2.SplitterDistance = (Me.Width / 2) + 30
        lblUser.Text = "អ្នកប្រើប្រាស់: " & GetCurrentUserName()
        txtInvoiceNo.Text = GetSaleNo()
        'RefreshProductList()
        txtBarcode.Select()
        txtBarcode.Focus()
        txtBarcode.SelectAll()
    End Sub



   
    Sub InsertPreInvoice(ByVal BarCode As String)

        If BarCode = "" Then
            Exit Sub
        Else
            Try
                Dim tbl As DataTable = DAItem.SelectByBarCode(BarCode)
                'Dim ItemImage() As Byte ' = ImageToByArray(ReductImageSize(ProdImg.Image))
                For Each rows As DataRow In tbl.Rows
                    Dim TblExistItem As DataTable = DAPreInvoice.ChExistPreInvoice(rows("ITEM_ID"), getCurrentUserID)
                    'ItemImage = rows("ITEM_IMAGE") 'ImageToByArray(CType(rows("ITEM_IMAGE"), Image))
                    If TblExistItem.Rows.Count > 0 Then
                        For Each rowsExit As DataRow In TblExistItem.Rows
                            Dim qty = rowsExit("QTY") + 1
                            Dim TotalPrice As Double = ((CDbl(rowsExit("PRICE"))) * qty)
                            DAPreInvoice.PreUpdateExistingItem(qty, CDbl(TotalPrice), rowsExit("ITEM_ID"), getCurrentUserID)
                        Next
                    Else
                        DAPreInvoice.InsertDetail(rows("ITEM_ID"), "", 1, CDbl(rows("RETAIL_PRICE")), 0, "$", 0, CDbl(rows("RETAIL_PRICE")), 0, getCurrentUserID, 0, "", False, CDbl(rows("USD_COST")), rows("ITEM_IMAGE"))
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
           
        End If

        RefreshOrderList()
    End Sub

  

   

  





  



    Private Sub ListProduct_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListProduct.MouseMove
        txtBarcode.SelectAll()
        txtBarcode.Focus()
    End Sub

    Private Sub BtnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemove.Click
        If OrderList.SelectedItems.Count = 0 Then Exit Sub
        DAPreInvoice.RePreInvoiceByItem(OrderList.GetRow.Cells("PRE_ID").Value, OrderList.GetRow.Cells("ITEM_ID").Value)
        RefreshOrderList()
        txtBarcode.SelectAll()
        txtBarcode.Focus()
    End Sub




    Private Sub AddProductFrogList()
        Try
            Dim Rows As DataRow = CType(ListProduct.SelectedItems.Item(0).Tag, DataRow)
            InsertPreInvoice(Rows("ITEM_BARCODE"))
        Catch ex As Exception
            MessageBox.Show("Please select product name. Before sale.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ListProduct.Select()
            ListProduct.Focus()
        End Try
        txtBarcode.SelectAll()
        txtBarcode.Focus()
    End Sub



    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
       
        AddProductFrogList()
    End Sub

    Private Sub NewSale_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.F1 Then
            If OrderList.SelectedItems.Count = 0 Then Exit Sub
            Dim IssueInvoice As New ISSUE_INVOICE
            Try
                If TxtTotalUSD.Text = "0" Then
                    MessageBox.Show("You can not issue bill. Please select product to sale!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                IssueInvoice.TxtTotalUSD.Text = FormatNumber(EmptyString(TxtTotalUSD.Text), 2) 'EmptyString(TxtTotalUSD.Text, 2) '
                IssueInvoice.TxtTotalKHR.Text = FormatNumber(EmptyString(TxtTotalKHR.Text), 0) 'EmptyString(TxtTotalKHR.Text, 2) ' 
                If IssueInvoice.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                    SaveNewInvoice(GetExchangeRage, EmptyString(IssueInvoice.TxtReceivedR.Text), EmptyString(IssueInvoice.TxtReceiveDollar.Text), EmptyString(IssueInvoice.TxtExchangeKHR.Text), EmptyString(IssueInvoice.TxtExchangeUSD.Text))
                    IssueInvoice.Close()
                    IssueInvoice.Dispose()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            txtBarcode.Focus()
            txtBarcode.SelectAll()

            'IssueInvoice.Close()
            'IssueInvoice.Dispose()
        ElseIf e.KeyCode = Keys.F2 Then
            Dim FEnterBarcode As New EnterBarcode(Me)
            If FEnterBarcode.ShowDialog = Windows.Forms.DialogResult.OK Then
                InsertPreInvoice(FEnterBarcode.TxtBarCode.Text)
            End If
            txtBarcode.SelectAll()
            txtBarcode.Focus()
        ElseIf e.KeyCode = Keys.F3 Then
            Dim FEnterProduct As New EnterProductName(Me)
            FEnterProduct.ShowDialog()
            txtBarcode.Focus()
            txtBarcode.SelectAll()
            'If FEnterProduct.ShowDialog = Windows.Forms.DialogResult.OK Then
            '    SearchByProductName(FEnterProduct.TxtBarProductName.Text)
            'End If
            'txtBarcode.SelectAll()
            'txtBarcode.Focus()
        ElseIf e.KeyCode = Keys.F12 Then
            If MsgBox("Do you want to cancel this invoice?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DAPreInvoice.DeleteByUserID(getCurrentUserID)
                RefreshOrderList()
            End If
            txtBarcode.Focus()
            txtBarcode.SelectAll()
        ElseIf e.KeyCode = Keys.Delete Then
            If MessageBox.Show("Do you want to remove  this item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If OrderList.SelectedItems.Count = 0 Then Exit Sub
                DAPreInvoice.DeleteByID(OrderList.GetRow.Cells("PRE_ID").Value)
                RefreshOrderList()
            End If
            txtBarcode.Select()
            txtBarcode.Focus()
            txtBarcode.SelectAll()
        ElseIf e.KeyCode = Keys.F4 Then
            If SplitContainer2.Panel1Collapsed = True Then
                SplitContainer2.Panel1Collapsed = False
                RefreshProductList()
            Else
                SplitContainer2.Panel1Collapsed = True
            End If

            txtBarcode.Focus()
            txtBarcode.SelectAll()
        ElseIf e.KeyCode = Keys.Escape Then
            If MessageBox.Show("Do you want to close sale?", "Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                DAPreInvoice.DeleteByUserID(getCurrentUserID)
                Me.Close()
            End If

        End If

    End Sub

   

    Private Sub BtnCalculation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Try
        '    If TxtTotalUSD.Text = "0" Then
        '        MessageBox.Show("You can not issue bill. Please select product to sale!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Exit Sub
        '    End If
        '    Dim IssueInvoice As New ISSUE_INVOICE
        '    IssueInvoice.TxtTotalUSD.Text = FormatNumber(TxtTotalUSD.Text, 2)
        '    IssueInvoice.TxtTotalKHR.Text = FormatNumber(TxtTotalKHR.Text, 0)
        '    If IssueInvoice.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '        SaveNewInvoice(GetExchangeRage, IssueInvoice.TxtReceivedR.Text, EmptyString(IssueInvoice.TxtReceiveDollar.Text), IssueInvoice.TxtExchangeKHR.Text, IssueInvoice.TxtExchangeUSD.Text)
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'txtBarcode.SelectAll()
        'txtBarcode.Focus()




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
    Sub SaveNewInvoice(ByVal Rate As Double, ByVal MoneyReceive As Double, ByVal MoneyReceiveDolar As Double, ByVal ReturnKHR As Double, ByVal ReturnUSD As Double)
        If Me.OrderList.RecordCount <= 0 Then
            MessageBox.Show("Please add item before save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If DAInvoice.CheckExistInvoiceNo(txtInvoiceNo.Text) > 0 Then
            txtInvoiceNo.Text = GetSaleNo()
        End If
        If ValidateDateTimePicker(dtInvoice, "", ErrSale) = False Then Exit Sub

        Dim USDTotal As Decimal = 0
        If Me.OrderList.RecordCount >= 1 Then
            ' If MessageBox.Show("Do you want to save?", "Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim OrderTable As New DataTable
            OrderTable = DAPreInvoice.SelectByUserID(getCurrentUserID)
            'KHRTotal = CDec(Me.TxtTotalKHR.Text)
            USDTotal = CDec(Me.TxtTotalUSD.Text)
            ' THBTotal = CDec(Me.TxtTotalTHB.Text)
            'OrderTable = Nothing
            '' INSERT INVOICE
            Dim CustID As Integer = 0

            ' Insert into Tatable Inovioce 
            DAInvoice.InsertInvoice(CustID, "លក់រាយ", 0, USDTotal, 0, 0, "", 0, USDTotal, 0, getCurrentUserID, Me.dtInvoice.Value.Date, 1, txtInvoiceNo.Text, Now.Year, Rate, MoneyReceive, ReturnKHR, ReturnUSD, MoneyReceiveDolar)
            '' INSERT ISSUE
            DAIssue.InsertIssue(txtInvoiceNo.Text, "Sale", dtInvoice.Value, getCurrentUserID)

            Dim IssueID As Long = txtInvoiceNo.Text

            '' INSERT INVOICE DETAILS & ISSUE DETAIL
            Dim DetailTable As New DataTable
            DetailTable = DAPreInvoice.SelectByUserID(getCurrentUserID)
            Dim ItemID As Integer
            Dim CurrCode As String
            Dim UnitName As String
            Dim UnitNameFree As String
            Dim Qty As Double
            Dim Cost As Double
            Dim QtyFree As Decimal
            Dim Price As Double
            Dim Discount As Decimal
            Dim USD_Amount As Double
            Dim KHR_Amount As Decimal
            Dim THB_Amount As Decimal
            Dim IS_ItemFree As Boolean
            Dim CurrentBalance As Decimal
            ' Loop Get from Table Pre-Invoice get
            For j As Integer = 0 To DetailTable.Rows.Count - 1
                ItemID = CInt(DetailTable.Rows(j).Item("ITEM_ID"))
                CurrCode = DetailTable.Rows(j).Item("CURR_CODE").ToString
                UnitName = DetailTable.Rows(j).Item("UNIT_NAME").ToString
                Cost = DetailTable.Rows(j).Item("COST")
                Qty = CDec(DetailTable.Rows(j).Item("QTY"))
                UnitNameFree = DetailTable.Rows(j).Item("INIT_NAME_FREE").ToString
                QtyFree = CDec(DetailTable.Rows(j).Item("QTY_FREE"))
                Price = CDec(DetailTable.Rows(j).Item("PRICE"))
                Discount = CDec(DetailTable.Rows(j).Item("DISCOUNT"))
                USD_Amount = CDec(DetailTable.Rows(j).Item("USD_AMOUNT"))
                KHR_Amount = CDec(DetailTable.Rows(j).Item("KHR_AMOUNT"))
                THB_Amount = CDec(DetailTable.Rows(j).Item("THB_AMOUNT"))
                IS_ItemFree = CBool(DetailTable.Rows(j).Item("IS_EXTRA"))
                ' Loop to insert for invoice Dedaitl.
                DAInvoiceDetail.InsertDetail(DAInvoice.getMaxID, ItemID, UnitName, Qty, Price, Discount, CurrCode, KHR_Amount, USD_Amount, THB_Amount, QtyFree, UnitNameFree, IS_ItemFree, Cost)
                '========================================
                '===================== Process   ===================
                '===================== Cut stock ===================

                Dim StoreID As Integer = CInt(DAStore.SelectByItemAndUnit(ItemID).Rows(0).Item("STORE_ID"))
                CurrentBalance = CDec(DAStore.SelectByStoreID(StoreID).Rows(0).Item("BALANCE"))
                'End If
                DAIssueDetail.InsertDetail(IssueID, StoreID, ItemID, Qty) ' CDec(IIf(UnitTypeFree <> "Sub Unit", Qty + QtyFree, Qty)))
                DATransaction.InsertTransaction(StoreID, ItemID, IssueID, "ISSUE", CurrentBalance, Qty, CurrentBalance - Qty, dtInvoice.Value.Date, getCurrentUserID)
                DAStore.UpdateBalance(CurrentBalance - Qty, StoreID)
            Next

            ''INSERT INTO ACCOUNT RECEIVABLE
            Dim InvoiceNo As Long = DAInvoice.getMaxID
            If DAAR.InsertReceivable(InvoiceNo, CustID, 0, 0, USDTotal, 0, 0, 0, "", CInt(IIf(CustID = 0, 1, 0)), dtInvoice.Value.Date) = 1 Then
                ' In case sell រាយ
                Dim ID_Max_Acc As Integer = DAAR.GetMaxAccReID
                If CustID = 0 Then
                    DAPayment.InsertPayment(ID_Max_Acc, 0, USDTotal, 0, dtInvoice.Value.Date, "ទទួលពីកាលក់រាយ", getCurrentUserID)
                    DAAR.UpdatePaidAmount(0, 0, USDTotal, 1, DAAR.GetMaxAccReID)
                Else
                    DAPayment.InsertPayment(ID_Max_Acc, 0, 0, 0, dtInvoice.Value.Date, "", getCurrentUserID)
                    DAAR.UpdatePaidAmount(0, 0, 0, 0, ID_Max_Acc)
                End If
            End If

            ' MsgBox("The invoice was saved", MsgBoxStyle.Information)
            DAPreInvoice.DeleteByUserID(getCurrentUserID)

            Application.DoEvents()

            For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Temp", FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                My.Computer.FileSystem.DeleteFile(foundFile, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            Next

            

            Application.DoEvents()
            If MessageBox.Show("Do you want to print invoice?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim DS As New DataSet
                Dim dt As New DataTable
                Dim sql As String = "SELECT INVOICE_ID,INVOICE_NO,CUST_ID,CUST_NAME,USD_AMOUNT,USD_TOTAL,INVOICE_DATE,RATE,MONEY_RECEIVED,RETURN_KHR,RETURN_USD,DETAIL_ID,ITEM_ID,QTY,PRICE,USD_SUPTOTAL,ITEM_NAME,USER_ID,USER_NAME,MONEY_RECEIVEDOLAR FROM ViewInvoice WHERE INVOICE_ID=" & InvoiceNo
                Dim cnn As New SqlClient.SqlConnection(My.Settings.INV_Database)
                cnn.Open()
                Dim Da As New SqlClient.SqlDataAdapter(sql, cnn)
                'Application.DoEvents()
                'System.Threading.Thread.Sleep(100)
                Da.Fill(DS, "ViewInvoice")
                Application.DoEvents()
                Dim RptName As String = Application.StartupPath & "\RptInvoice.rpt"
                Dim myReportObj As New clsCrystalReport()
                myReportObj.ReportPath(RptName)
                Application.DoEvents()
                myReportObj.SetDataSource(DS, "ViewInvoice")
                myReportObj.PrintToPrinter()
                'myReportObj.PrintToPrinter()
                cnn.Close()
                myReportObj.Close()
            End If
            

            RefreshOrderList()

            ' Me.Close()

            'End If

        End If
    End Sub

    
    Private Sub txtBarcod_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub SplitContainer1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        txtBarcode.SelectAll()
        txtBarcode.Focus()
    End Sub

    Private Sub SplitContainer2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SplitContainer2.MouseMove
        txtBarcode.SelectAll()
        txtBarcode.Focus()
    End Sub

    Private Sub UiTab1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        txtBarcode.SelectAll()
        txtBarcode.Focus()
    End Sub

    Private Sub OrderList_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles OrderList.MouseMove
        txtBarcode.SelectAll()
        txtBarcode.Focus()
    End Sub

    Private Sub SplitContainer2_Panel2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SplitContainer2.Panel2.MouseMove
        txtBarcode.SelectAll()
        txtBarcode.Focus()
    End Sub

    Private Sub SplitContainer3_Panel2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SplitContainer3.Panel2.MouseMove
        txtBarcode.SelectAll()
        txtBarcode.Focus()
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        txtBarcode.SelectAll()
        txtBarcode.Focus()
    End Sub

    Private Sub UiTabPage2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        txtBarcode.SelectAll()
        txtBarcode.Focus()
    End Sub

    

   
    Private Sub LinkCalculation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinkCalculation.Click
        If OrderList.SelectedItems.Count = 0 Then Exit Sub
        Try
            Dim IssueInvoice As New ISSUE_INVOICE

            If TxtTotalUSD.Text = "0" Then
                MessageBox.Show("You can not issue bill. Please select product to sale!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            IssueInvoice.TxtTotalUSD.Text = FormatNumber(EmptyString(TxtTotalUSD.Text), 2) 'EmptyString(TxtTotalUSD.Text, 2) '
            IssueInvoice.TxtTotalKHR.Text = FormatNumber(EmptyString(TxtTotalKHR.Text), 0) 'EmptyString(TxtTotalKHR.Text, 2) ' 
            If IssueInvoice.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                SaveNewInvoice(GetExchangeRage, EmptyString(IssueInvoice.TxtReceivedR.Text), EmptyString(IssueInvoice.TxtReceiveDollar.Text), EmptyString(IssueInvoice.TxtExchangeKHR.Text), EmptyString(IssueInvoice.TxtExchangeUSD.Text))
                IssueInvoice.Close()
                IssueInvoice.Dispose()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        txtBarcode.Select()
        txtBarcode.Focus()
        txtBarcode.SelectAll()
    End Sub

    Private Sub LinkLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinkLabel2.Click
        Dim FEnterBarcode As New EnterBarcode(Me)
        FEnterBarcode.ShowDialog()
        ' If FEnterBarcode.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    InsertPreInvoice(FEnterBarcode.TxtBarCode.Text)
        'End If
        txtBarcode.Select()
        txtBarcode.Focus()
        txtBarcode.SelectAll()
    End Sub

    Private Sub LinkLabel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinkLabel4.Click
        Dim FEnterProduct As New EnterProductName(Me)
        'FEnterProduct.ShowDialog()
        If FEnterProduct.ShowDialog = Windows.Forms.DialogResult.OK Then
            SearchByProductName(FEnterProduct.TxtBarProductName.Text)
        End If
        txtBarcode.Select()
        txtBarcode.Focus()
        txtBarcode.SelectAll()
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        If SplitContainer2.Panel1Collapsed = True Then
            SplitContainer2.Panel1Collapsed = False
            RefreshProductList()
        Else
            SplitContainer2.Panel1Collapsed = True
        End If

        txtBarcode.Select()
        txtBarcode.Focus()
        txtBarcode.SelectAll()
       
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        If MsgBox("Do you want to cancel this invoice?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DAPreInvoice.DeleteByUserID(getCurrentUserID)
            RefreshOrderList()
        End If
        txtBarcode.Select()
        txtBarcode.Focus()
        txtBarcode.SelectAll()
    End Sub

    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        If OrderList.SelectedItems.Count = 0 Then
            MessageBox.Show("សុំជ្រើសរើសមុខទំនិញដើម្បីកែប្រែរ ចំនួនលក់", "QTY", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim FExitQTY As New FormEditQTY(Me)
        FExitQTY.LblItemID.Text = OrderList.GetRow.Cells("PRE_ID").Value
        FExitQTY.TxtItemName.Text = OrderList.GetRow.Cells("ITEM_NAME").Value
        FExitQTY.LblPrice.Text = OrderList.GetRow.Cells("ITEM_PRICE").Value
        FExitQTY.TxtQTY.Text = "0"
        FExitQTY.ShowDialog()
        txtBarcode.Select()
        txtBarcode.Focus()
        txtBarcode.SelectAll()
    End Sub

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        DAPreInvoice.DeleteByUserID(getCurrentUserID)
        Me.Close()
    End Sub

   

    
    Private Sub ListProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListProduct.Click
        AddProductFrogList()
    End Sub
    Dim secondScreen As New SecondScreen
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim screen1 As Screen
        'screen1 = Screen.AllScreens(1)
        secondScreen.StartPosition = FormStartPosition.Manual
        secondScreen.Location = Screen.AllScreens(UBound(Screen.AllScreens)).Bounds.Location + New Point(0, 0)
        secondScreen.ShowInTaskbar = False
        secondScreen.WindowState = FormWindowState.Maximized
        secondScreen.Show()

    End Sub

    Private Sub OrderList_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles OrderList.RowDoubleClick
        If MessageBox.Show("Do you want to remove  this item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If OrderList.SelectedItems.Count = 0 Then Exit Sub
            DAPreInvoice.DeleteByID(OrderList.GetRow.Cells("PRE_ID").Value)
            RefreshOrderList()
        End If
        txtBarcode.Select()
        txtBarcode.SelectAll()
        txtBarcode.Focus()
    End Sub

    Private Sub LinkCalculation_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkCalculation.LinkClicked
        If OrderList.SelectedItems.Count = 0 Then Exit Sub
        Dim IssueInvoice As New ISSUE_INVOICE
        Try
            If TxtTotalUSD.Text = "0" Then
                MessageBox.Show("You can not issue bill. Please select product to sale!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            IssueInvoice.TxtTotalUSD.Text = FormatNumber(EmptyString(TxtTotalUSD.Text), 2) 'EmptyString(TxtTotalUSD.Text, 2) '
            IssueInvoice.TxtTotalKHR.Text = FormatNumber(EmptyString(TxtTotalKHR.Text), 0) 'EmptyString(TxtTotalKHR.Text, 2) ' 
            If IssueInvoice.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                SaveNewInvoice(GetExchangeRage, EmptyString(IssueInvoice.TxtReceivedR.Text), EmptyString(IssueInvoice.TxtReceiveDollar.Text), EmptyString(IssueInvoice.TxtExchangeKHR.Text), EmptyString(IssueInvoice.TxtExchangeUSD.Text))
                IssueInvoice.Close()
                IssueInvoice.Dispose()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        txtBarcode.Select()
        txtBarcode.Focus()
        txtBarcode.SelectAll()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim FEnterBarcode As New EnterBarcode(Me)
        If FEnterBarcode.ShowDialog = Windows.Forms.DialogResult.OK Then
            InsertPreInvoice(FEnterBarcode.TxtBarCode.Text)
        End If
        txtBarcode.Select()
        txtBarcode.Focus()
        txtBarcode.SelectAll()
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Dim FEnterProduct As New EnterProductName(Me)
        FEnterProduct.ShowDialog()
        txtBarcode.Select()
        txtBarcode.Focus()
        txtBarcode.SelectAll()
        'If FEnterProduct.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    SearchByProductName(FEnterProduct.TxtBarProductName.Text)
        'End If
        'txtBarcode.SelectAll()
        'txtBarcode.Focus()
    End Sub

  
    Private Sub OrderList_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs)
        MessageBox.Show("Helloe world")
    End Sub

    Private Sub txtBarcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            ''MsgBox(txtBarcode.Text.Trim)
            'Dim tbl As DataTable = DAItem.SelectByBarCode(txtBarcode.Text)
            'Dim FEnterBarcode As New EnterBarcode(Me)
            'For Each rows As DataRow In tbl.Rows
            '    FEnterBarcode.TxtProducName.Text = rows("ITEM_NAME")
            '    FEnterBarcode.TxtPrice.Text = CDbl(rows("RETAIL_PRICE"))
            'Next

            'FEnterBarcode.TxtBarCode.Text = Me.txtBarcode.Text
            'FEnterBarcode.txtQTY.Focus()
            'FEnterBarcode.txtQTY.SelectAll()
            'FEnterBarcode.ShowDialog()
            'FEnterBarcode.Close()
            '' If FEnterBarcode.ShowDialog = Windows.Forms.DialogResult.OK Then
            ''    InsertPreInvoice(FEnterBarcode.TxtBarCode.Text)
            ''End If

            'txtBarcode.Focus()
            'txtBarcode.SelectAll()
            InsertPreInvoice(txtBarcode.Text.Trim)
            txtBarcode.Select()
            txtBarcode.SelectAll()
            txtBarcode.Focus()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = Now
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        EditeItemDiscount()
    End Sub
    Private Sub EditeItemDiscount()
        If OrderList.SelectedItems.Count = 0 Then
            MessageBox.Show("សុំជ្រើសរើសមុខទំនិញដើម្បីកែប្រែរ ចំនួនលក់", "QTY", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim FExitQTY As New Discount(Me)
        FExitQTY.LblItemID.Text = OrderList.GetRow.Cells("PRE_ID").Value
        FExitQTY.TxtItemName.Text = OrderList.GetRow.Cells("ITEM_NAME").Value
        FExitQTY.LblPrice.Text = OrderList.GetRow.Cells("ITEM_PRICE").Value
        FExitQTY.TxtDiscount.Text = "0"
        FExitQTY.ShowDialog()
        txtBarcode.Select()
        txtBarcode.Focus()
        txtBarcode.SelectAll()
    End Sub
End Class