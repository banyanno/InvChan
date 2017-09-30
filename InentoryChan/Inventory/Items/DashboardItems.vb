Imports CrystalDecisions.Shared

Public Class DashboardItems
    Dim DACategory As New DSInventoryTableAdapters.CATEGORIESTableAdapter
    Dim DAItem As New DSInventoryTableAdapters.ITEMSTableAdapter
    Dim DAPrice As New DSInventoryTableAdapters.ITEM_PRICESTableAdapter
    Dim DACost As New DSInventoryTableAdapters.ITEM_COSTSTableAdapter
    Dim DAProductList As New DSProductsTableAdapters.ITEMSTableAdapter
    Private Sub PopulateNodeCategory(ByVal TblCategory As DataTable, ByVal treeNods As TreeNodeCollection)
        treeNods.Clear()
        Dim lImage As New ImageList
        lImage.ImageSize = New Size(35, 35)
        lImage.ColorDepth = ColorDepth.Depth32Bit
        Dim ImgIndex As Integer = 0
        For Each dr As DataRow In TblCategory.Rows
            'Dim imageData As Byte() =Nothing 
            'lImage.Images.Add(Nothing, Nothing)
            Dim tn As New TreeNode
            tn.Name = dr("CATE_ID").ToString
            tn.Text = dr("CATE_NAME").ToString
            tn.Tag = dr("CATE_ID").ToString
            'tn.ImageIndex = ImgIndex 
            treeNods.Add(tn)
            ImgIndex = ImgIndex + 1
        Next
    End Sub

    Private Sub DashboardItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshTree()

    End Sub
    Private Sub RefreshTree()
        Dim tblCategory As DataTable = DACategory.GetData
        PopulateNodeCategory(tblCategory, TreeCategory.Nodes)
        TreeCategory.Select()
        TreeCategory.Focus()
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Dim FrmItem As New NewProductV1(Me)
        FrmItem.lblStatus.Text = 0
        FrmItem.ShowDialog()
    End Sub


    Sub RefreshData()
        Me.StoreList.DataSource = DAItem.SelectStores
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        Try
            'Dim FrmItem As New NewProductV1(Me)
            'FrmItem.lblStatus.Text = 1
            'FrmItem.txtItemName.Text = StoreList.CurrentRow.Cells("ITEM_NAME").Value
            'FrmItem.CboCategory.SelectedValue = StoreList.CurrentRow.Cells("CATE_ID").Value
            'FrmItem.txtMBalance.Text = StoreList.CurrentRow.Cells("MAIN_QTY").Value
            'FrmItem.txtSBalance.Text = StoreList.CurrentRow.Cells("SUB_QTY").Value
            'FrmItem.CboMUnit.Text = StoreList.CurrentRow.Cells("MAIN_UNIT").Value
            'FrmItem.CboSUnit.Text = StoreList.CurrentRow.Cells("SUB_UNIT").Value
            'FrmItem.CboMUnit.Text = StoreList.CurrentRow.Cells("MAIN_RATIO").Value
            'FrmItem.CboSUnit.Text = StoreList.CurrentRow.Cells("SUB_RATIO").Value
            'FrmItem.txtRPrice.Text = StoreList.CurrentRow.Cells("RETAIL_PRICE").Value.ToString
            'FrmItem.txtWUSDPrice.Text = StoreList.CurrentRow.Cells("USD_PRICE").Value.ToString
            'FrmItem.txtWKHRPrice.Text = StoreList.CurrentRow.Cells("KHR_PRICE").Value.ToString
            'FrmItem.txtWTHBPrice.Text = StoreList.CurrentRow.Cells("THB_PRICE").Value.ToString
            'FrmItem.txtUSDCost.Text = StoreList.CurrentRow.Cells("USD_COST").Value.ToString
            'FrmItem.txtKHRCost.Text = StoreList.CurrentRow.Cells("KHR_COST").Value.ToString
            'FrmItem.txtTHBCost.Text = StoreList.CurrentRow.Cells("THB_COST").Value.ToString

            'FrmItem.txtMBalance.ReadOnly = True
            'FrmItem.txtSBalance.ReadOnly = True
            'FrmItem.CboMUnit.Enabled = False
            'FrmItem.CboSUnit.Enabled = False
            'FrmItem.txtMRatioQty.ReadOnly = False
            'FrmItem.txtSRatioQty.ReadOnly = False

            'FrmItem.ShowDialog()
            Dim FUpdateProduct As New NewProduct
            FUpdateProduct.lblStatus.Text = StoreList.CurrentRow.Cells("ITEM_ID").Value
            FUpdateProduct.TxtBarcode.Text = StoreList.CurrentRow.Cells("ITEM_BARCODE").Value
            FUpdateProduct.txtItemName.Text = StoreList.CurrentRow.Cells("ITEM_NAME").Value
            FUpdateProduct.CboCategory.SelectedIndex = -1
            'FUpdateProduct.CboCategory.SelectedValue = StoreList.CurrentRow.Cells("CATE_ID").Value
            'FUpdateProduct.CboMUnit.Text = StoreList.CurrentRow.Cells("MAIN_UNIT").Value
            'FUpdateProduct.CboSUnit.Text = StoreList.CurrentRow.Cells("SUB_UNIT").Value
            'FUpdateProduct.CboMUnit.Text = StoreList.CurrentRow.Cells("MAIN_RATIO").Value
            'FUpdateProduct.CboSUnit.Text = StoreList.CurrentRow.Cells("SUB_RATIO").Value
            FUpdateProduct.txtSRatioQty.Text = StoreList.CurrentRow.Cells("SUB_RATIO").Value
            FUpdateProduct.ProdImg.Image = byteArrayToImage(DAItem.SelectImageID(StoreList.CurrentRow.Cells("ITEM_ID").Value))
            If FUpdateProduct.ShowDialog = DialogResult.OK Then
                StoreList.DataSource = DAItem.SelectByItemID(FUpdateProduct.lblStatus.Text)
            End If
        Catch ex As Exception

        End Try
        
    End Sub

    

    Private Sub StoreList_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles StoreList.SelectionChanged
        If StoreList.SelectedItems.Count = 0 Then Exit Sub
        Me.PriceList.DataSource = DAPrice.SelectByItemID(CInt(Me.StoreList.CurrentRow.Cells("ITEM_ID").Value))
        Me.CostList.DataSource = DACost.SelectByItemID(CInt(Me.StoreList.CurrentRow.Cells("ITEM_ID").Value))
        Try
            PictProduct.Image = byteArrayToImage(DAItem.SelectImageID(StoreList.CurrentRow.Cells("ITEM_ID").Value))
        Catch ex As Exception
            PictProduct.Image = Nothing
        End Try
       

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If Me.PriceList.RecordCount >= 1 Then
            DAPrice.ResetLastPrice(CInt(Me.StoreList.CurrentRow.Cells("ITEM_ID").Value))
            DAPrice.SetAsLastPrice(CInt(Me.PriceList.CurrentRow.Cells("PRICE_ID").Value))
            StoreList.DataSource = DAItem.SelectByItemID(PriceList.GetRow.Cells("ITEM_ID").Value)
            Me.PriceList.DataSource = DAPrice.SelectByItemID(CInt(Me.StoreList.CurrentRow.Cells("ITEM_ID").Value))
            MsgBox("The last price was set", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If Me.PriceList.RecordCount >= 1 Then
            If MsgBox("Do you want to delete the price?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DAPrice.DeletePrice(CInt(Me.PriceList.CurrentRow.Cells("PRICE_ID").Value))
                Me.PriceList.DataSource = DAPrice.SelectByItemID(CInt(Me.StoreList.CurrentRow.Cells("ITEM_ID").Value))
            End If
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If StoreList.SelectedItems.Count = 0 Then Exit Sub
        Dim FrmNewPrice As New PriceAndCost(Me)
        FrmNewPrice.txtItemName.Text = Me.StoreList.GetRow.Cells("ITEM_NAME").Value
        FrmNewPrice.TxtCost.Text = Me.StoreList.GetRow.Cells("USD_COST").Value
        If FrmNewPrice.ShowDialog() = DialogResult.OK Then
            Me.StoreList.DataSource = DAItem.SelectByItemID(StoreList.GetRow.Cells("ITEM_ID").Value)
        End If

    End Sub

    Dim IS_Filter As Boolean = True
    Private Sub BtnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFilter.Click
        If IS_Filter = True Then
            StoreList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
            StoreList.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
            IS_Filter = False
            BtnFilter.Text = "Un-Filter Product"
        Else
            StoreList.FilterMode = Janus.Windows.GridEX.FilterMode.None
            StoreList.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.Default
            IS_Filter = True
            BtnFilter.Text = "Filter Product"
        End If

    End Sub


    Private Sub BtnRefreshProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshProduct.Click
        RefreshTree()
        RefreshData()
        StoreList.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
    End Sub

    Private Sub BtnNewStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdjustment.Click
        Try
            If StoreList.SelectedItems.Count = 0 Then Exit Sub
            Dim AInventory As New AdjustInventory
            AInventory.CboProductName.SelectedValue = StoreList.GetRow.Cells("ITEM_ID").Value
            If AInventory.ShowDialog() = DialogResult.OK Then
                RefreshData()
            End If
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub BtnPrintProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintProduct.Click
        Dim FRViewer As New ReportViewer
        Dim ListOfProduct As New ReportListOfProduct
        Dim tblProductlist As DataTable = DAProductList.GetData
        ListOfProduct.SetDataSource(tblProductlist)

        Dim CrExportOptionsBig As ExportOptions
        Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
        Dim CrFormatTypeOptionsBig As New PdfRtfWordFormatOptions()
        CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\ProductList.pdf"
        CrExportOptionsBig = ListOfProduct.ExportOptions
        With CrExportOptionsBig
            .ExportDestinationType = ExportDestinationType.DiskFile
            .ExportFormatType = ExportFormatType.PortableDocFormat
            .DestinationOptions = CrDiskFileDestinationOptionsBig
            .FormatOptions = CrFormatTypeOptionsBig
        End With
        ListOfProduct.Export()
        Application.DoEvents()
        Application.DoEvents()
        FRViewer.AxAcroPDF1.src = My.Application.Info.DirectoryPath & "\ProductList.pdf"
        FRViewer.AxAcroPDF1.setZoom(100)
        FRViewer.ShowDialog()
    End Sub

    Private Sub TreeCategory_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeCategory.AfterSelect
        Me.StoreList.DataSource = DAItem.SelectItemByCateID(e.Node.Name)
        StoreList.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        If RadProductName.Checked = True Then
            Me.StoreList.DataSource = DAItem.SelectItemName(TxtProductname.Text)
            StoreList.GroupMode = Janus.Windows.GridEX.GroupMode.Expanded
        End If
        If RadBardCode.Checked = True Then
            Me.StoreList.DataSource = DAItem.SelectItemByBarode(TxtFindBardCode.Text)
            StoreList.GroupMode = Janus.Windows.GridEX.GroupMode.Expanded
        End If
    End Sub

    Private Sub BtnNewCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewCost.Click
        If StoreList.SelectedItems.Count = 0 Then Exit Sub
        Dim FProductCost As New ProductCost(Me)
        FProductCost.txtItemName.Text = Me.StoreList.CurrentRow.Cells("ITEM_NAME").Value
        If FProductCost.ShowDialog() = DialogResult.OK Then
            Me.StoreList.DataSource = DAItem.SelectByItemID(StoreList.GetRow.Cells("ITEM_ID").Value)
        End If
    End Sub

    Private Sub bntDeleteCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntDeleteCost.Click
        If Me.CostList.RecordCount >= 1 Then
            If MsgBox("Do you want to delete the cost?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If DACost.DeleteCost(CInt(Me.CostList.CurrentRow.Cells("COST_ID").Value)) = 1 Then
                    Me.CostList.DataSource = DACost.SelectByItemID(CInt(Me.StoreList.CurrentRow.Cells("ITEM_ID").Value))
                End If

            End If
        End If
    End Sub

    Private Sub ToolProduct_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolProduct.ItemClicked

    End Sub

    Private Sub RadBardCode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBardCode.CheckedChanged
        TxtFindBardCode.Focus()
        TxtFindBardCode.SelectAll()
    End Sub

    Private Sub RadProductName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadProductName.CheckedChanged
        TxtProductname.Focus()
        TxtProductname.SelectAll()
    End Sub

   
    Private Sub TxtFindBardCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtFindBardCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.StoreList.DataSource = DAItem.SelectItemByBarode(TxtFindBardCode.Text)
            StoreList.GroupMode = Janus.Windows.GridEX.GroupMode.Expanded
        End If
    End Sub

    Private Sub TxtProductname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtProductname.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.StoreList.DataSource = DAItem.SelectItemName(TxtProductname.Text)
            StoreList.GroupMode = Janus.Windows.GridEX.GroupMode.Expanded
        End If
    End Sub
    Dim DSBarcodde As New DSProducts

    Dim TblBarcodePrint As DataTable = DSBarcodde.Tables("ITEMS")
    Private Sub BtnBardCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub UpdateImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateImg.Click
        If StoreList.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to update image size?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            For Each GXRow As Janus.Windows.GridEX.GridEXRow In StoreList.GetRows
                Dim img As Image = ReductImageSize(byteArrayToImage(DAItem.SelectImageID(GXRow.Cells("ITEM_ID").Value)))
                'StoreList.CurrentRow.Cells("ITEM_ID").Value))
                DAItem.Impge(ImageToByArray(img), CInt(GXRow.Cells("ITEM_ID").Value))
            Next
        End If
        
    End Sub

    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim Drow As DataRow

        TblBarcodePrint.Clear()
        Try
            For Each row As Janus.Windows.GridEX.GridEXRow In StoreList.GetRows
                Drow = TblBarcodePrint.NewRow
                Drow("ITEM_BARCODE") = "*" & row.Cells("ITEM_BARCODE").Value & "*"
                Drow("ITEM_IMAGE") = ImageToByArray(byteArrayToImage(DAItem.SelectImageID(row.Cells("ITEM_ID").Value)))
                Drow("ITEM_NAME") = row.Cells("ITEM_NAME").Value
                TblBarcodePrint.Rows.Add(Drow)
            Next
        Catch ex As Exception

        End Try
        'For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Temp", FileIO.SearchOption.SearchAllSubDirectories, "*.*")
        '    My.Computer.FileSystem.DeleteFile(foundFile, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        'Next

        'Dim SQL As String = "SELECT * FROM ViewAproduct"

        'Dim DS As New DataSet
        'Dim dt As New DataTable
        'Dim cnn As New SqlClient.SqlConnection(My.Settings.INV_Database)

        'Application.DoEvents()

        'Dim Da As New SqlClient.SqlDataAdapter(SQL, cnn)
        'Application.DoEvents()
        'System.Threading.Thread.Sleep(100)
        'Da.Fill(DS, "ITEMS")
        'Application.DoEvents()
        'Dim RptName As String = Application.StartupPath & "\ListProductWithBarcode.rpt"

        'Dim RAccPayable As New ReportPreview

        'Dim myReportObj As New clsCrystalReport()


        'myReportObj.ReportPath(RptName)

        'Application.DoEvents()
        'myReportObj.SetDataSource(DS, "ITEMS")
        ''myReportObj.SetParameterValue("DateReport", "ចាប់ពីថ្ងៃទី  " & Format(DateFrom.Value, "dd/MM/yyyy") & " ដល់ " & Format(DateTo.Value.Date, "dd/MM/yyyy"))
        'RAccPayable.ReportViewer.Refresh()
        'RAccPayable.ReportViewer.ReportSource = myReportObj.Report
        'RAccPayable.ReportViewer.ViewReport()
        'RAccPayable.ReportViewer.Zoom(100)
        'RAccPayable.ShowDialog()





        ''==============


        Dim FRViewer As New ReportViewer
        Dim ListOfProduct As New ListProductWithBarcode

        Dim tblProductlist As DataTable = DAProductList.GetData
        ListOfProduct.SetDataSource(TblBarcodePrint)
        '' ListOfProduct.SetDataSource(tblProductlist)

        Dim CrExportOptionsBig As ExportOptions
        Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
        Dim CrFormatTypeOptionsBig As New PdfRtfWordFormatOptions()
        CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\ProductListBarcode.pdf"
        CrExportOptionsBig = ListOfProduct.ExportOptions
        With CrExportOptionsBig
            .ExportDestinationType = ExportDestinationType.DiskFile
            .ExportFormatType = ExportFormatType.PortableDocFormat
            .DestinationOptions = CrDiskFileDestinationOptionsBig
            .FormatOptions = CrFormatTypeOptionsBig
        End With
        ListOfProduct.Export()
        Application.DoEvents()
        Application.DoEvents()
        FRViewer.AxAcroPDF1.src = My.Application.Info.DirectoryPath & "\ProductListBarcode.pdf"
        FRViewer.AxAcroPDF1.setZoom(100)
        FRViewer.ShowDialog()
    End Sub

    Private Sub PrintBarcodeNoImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintBarcodeNoImageToolStripMenuItem.Click

        Dim Drow As DataRow

        TblBarcodePrint.Clear()
        Try
            For Each row As Janus.Windows.GridEX.GridEXRow In StoreList.GetRows
                Drow = TblBarcodePrint.NewRow
                Drow("ITEM_BARCODE") = "*" & row.Cells("ITEM_BARCODE").Value & "*"
                Drow("ITEM_IMAGE") = ImageToByArray(byteArrayToImage(DAItem.SelectImageID(row.Cells("ITEM_ID").Value)))
                Drow("ITEM_NAME") = row.Cells("ITEM_NAME").Value
                TblBarcodePrint.Rows.Add(Drow)
            Next
        Catch ex As Exception

        End Try
        


        Dim FRViewer As New ReportViewer
        Dim ListOfProduct As New ListProductWithBarcodeNoPic

        Dim tblProductlist As DataTable = DAProductList.GetData
        ListOfProduct.SetDataSource(TblBarcodePrint)
        '' ListOfProduct.SetDataSource(tblProductlist)

        Dim CrExportOptionsBig As ExportOptions
        Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
        Dim CrFormatTypeOptionsBig As New PdfRtfWordFormatOptions()
        CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\ProductListBarcodeNopic.pdf"
        CrExportOptionsBig = ListOfProduct.ExportOptions
        With CrExportOptionsBig
            .ExportDestinationType = ExportDestinationType.DiskFile
            .ExportFormatType = ExportFormatType.PortableDocFormat
            .DestinationOptions = CrDiskFileDestinationOptionsBig
            .FormatOptions = CrFormatTypeOptionsBig
        End With
        ListOfProduct.Export()
        Application.DoEvents()
        Application.DoEvents()
        FRViewer.AxAcroPDF1.src = My.Application.Info.DirectoryPath & "\ProductListBarcodeNopic.pdf"
        FRViewer.AxAcroPDF1.setZoom(70)
        FRViewer.ShowDialog()
    End Sub

    Private Sub PrintBarcodeWithImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintBarcodeWithImageToolStripMenuItem.Click

        Dim Drow As DataRow

        TblBarcodePrint.Clear()
        Try
            For Each row As Janus.Windows.GridEX.GridEXRow In StoreList.GetRows
                Drow = TblBarcodePrint.NewRow
                Drow("ITEM_BARCODE") = "*" & row.Cells("ITEM_BARCODE").Value & "*"
                Drow("ITEM_IMAGE") = ImageToByArray(byteArrayToImage(DAItem.SelectImageID(row.Cells("ITEM_ID").Value)))
                Drow("ITEM_NAME") = row.Cells("ITEM_NAME").Value
                TblBarcodePrint.Rows.Add(Drow)
            Next
        Catch ex As Exception

        End Try
        'For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Temp", FileIO.SearchOption.SearchAllSubDirectories, "*.*")
        '    My.Computer.FileSystem.DeleteFile(foundFile, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        'Next

        'Dim SQL As String = "SELECT * FROM ViewAproduct"

        'Dim DS As New DataSet
        'Dim dt As New DataTable
        'Dim cnn As New SqlClient.SqlConnection(My.Settings.INV_Database)

        'Application.DoEvents()

        'Dim Da As New SqlClient.SqlDataAdapter(SQL, cnn)
        'Application.DoEvents()
        'System.Threading.Thread.Sleep(100)
        'Da.Fill(DS, "ITEMS")
        'Application.DoEvents()
        'Dim RptName As String = Application.StartupPath & "\ListProductWithBarcode.rpt"

        'Dim RAccPayable As New ReportPreview

        'Dim myReportObj As New clsCrystalReport()


        'myReportObj.ReportPath(RptName)

        'Application.DoEvents()
        'myReportObj.SetDataSource(DS, "ITEMS")
        ''myReportObj.SetParameterValue("DateReport", "ចាប់ពីថ្ងៃទី  " & Format(DateFrom.Value, "dd/MM/yyyy") & " ដល់ " & Format(DateTo.Value.Date, "dd/MM/yyyy"))
        'RAccPayable.ReportViewer.Refresh()
        'RAccPayable.ReportViewer.ReportSource = myReportObj.Report
        'RAccPayable.ReportViewer.ViewReport()
        'RAccPayable.ReportViewer.Zoom(100)
        'RAccPayable.ShowDialog()





        ''==============


        Dim FRViewer As New ReportViewer
        Dim ListOfProduct As New ListProductWithBarcode

        Dim tblProductlist As DataTable = DAProductList.GetData
        ListOfProduct.SetDataSource(TblBarcodePrint)
        '' ListOfProduct.SetDataSource(tblProductlist)

        Dim CrExportOptionsBig As ExportOptions
        Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
        Dim CrFormatTypeOptionsBig As New PdfRtfWordFormatOptions()
        CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\ProductListBarcode.pdf"
        CrExportOptionsBig = ListOfProduct.ExportOptions
        With CrExportOptionsBig
            .ExportDestinationType = ExportDestinationType.DiskFile
            .ExportFormatType = ExportFormatType.PortableDocFormat
            .DestinationOptions = CrDiskFileDestinationOptionsBig
            .FormatOptions = CrFormatTypeOptionsBig
        End With
        ListOfProduct.Export()
        Application.DoEvents()
        Application.DoEvents()
        FRViewer.AxAcroPDF1.src = My.Application.Info.DirectoryPath & "\ProductListBarcode.pdf"
        FRViewer.AxAcroPDF1.setZoom(70)
        FRViewer.ShowDialog()
    End Sub
End Class
