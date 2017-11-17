Imports CrystalDecisions.Shared

Public Class DashboardAdjustStock
    Dim DAAdjust As New DSStockTableAdapters.STOCK_ADJUSTMENTTableAdapter
    Dim DA_ProductTraction As New DSStockTableAdapters.STOCK_TRANSACTION1TableAdapter
    Dim DAItem As New DSInventoryTableAdapters.ITEMSTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.CboProduct.DataSource = DAItem.SelectAllItems
        Me.CboProduct.DisplayMember = "ITEM_NAME"
        Me.CboProduct.ValueMember = "ITEM_ID"
        CboProduct.SelectedIndex = -1
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnAdjustment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdjustment.Click
        Dim AdInventory As New AdjustInventory(Me)
        AdInventory.ShowDialog()
    End Sub
    Sub RefreshList()
        Me.AdjustList.DataSource = DAAdjust.SelectAdjustmentsDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
        Me.StoreTransaction.DataSource = DA_ProductTraction.SelectAllProductDateTodate(DateFrom.Value.Date, DateTo.Value.Date)
    End Sub


    Private Sub DashboardAdjustStock_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RefreshList()
    End Sub

    Private Sub BtnRefreshProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshProduct.Click
        RefreshList()
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        If ChProduct.Checked = False Then
            RefreshList()
        Else
            Me.AdjustList.DataSource = DAAdjust.SelectAdjustmentDateToDateByItem(DateFrom.Value.Date, DateTo.Value.Date, EmptyString(CboProduct.SelectedValue))
            Me.StoreTransaction.DataSource = DA_ProductTraction.SelectByProductDateToDate(DateFrom.Value.Date, DateTo.Value.Date, CboProduct.SelectedValue)
        End If
    End Sub

    Private Sub ChProduct_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChProduct.CheckedChanged
        CboProduct.Enabled = ChProduct.Checked
    End Sub

    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        Dim FRViewer As New ReportViewer
        Dim CVProductTransaction As New ReportProductTransaction
        Dim ProductName As String
        Dim TblProductTransaction As DataTable
        If ChProduct.Checked = True Then
            TblProductTransaction = DA_ProductTraction.SelectByProductDateToDate(DateFrom.Value.Date, DateTo.Value.Date, CboProduct.SelectedValue)
            ProductName = " Product Name: " & CboProduct.Text
        Else
            TblProductTransaction = DA_ProductTraction.SelectAllProductDateTodate(DateFrom.Value.Date, DateTo.Value.Date)
        End If
        CVProductTransaction.SetDataSource(TblProductTransaction)
        CVProductTransaction.SetParameterValue("Title", "From: " & DateFrom.Text & " To: " & DateTo.Text & "" & ProductName)
        Dim CrExportOptionsBig As ExportOptions
        Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
        Dim CrFormatTypeOptionsBig As New PdfRtfWordFormatOptions()
        CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\ProductTransaction.pdf"
        CrExportOptionsBig = CVProductTransaction.ExportOptions
        With CrExportOptionsBig
            .ExportDestinationType = ExportDestinationType.DiskFile
            .ExportFormatType = ExportFormatType.PortableDocFormat
            .DestinationOptions = CrDiskFileDestinationOptionsBig
            .FormatOptions = CrFormatTypeOptionsBig
        End With
        CVProductTransaction.Export()
        Application.DoEvents()
        Application.DoEvents()
        FRViewer.AxAcroPDF1.src = My.Application.Info.DirectoryPath & "\ProductTransaction.pdf"
        FRViewer.AxAcroPDF1.setZoom(100)
        FRViewer.ShowDialog()
    End Sub
End Class
