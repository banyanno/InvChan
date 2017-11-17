Imports CrystalDecisions.Shared

Public Class DashbordRevenue
    Dim DARevenue As New DSRevenueTableAdapters.RevenueTableAdapter
    Dim ReportRevenue As New RevenueInventory
    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        CalculateRevenue()

    End Sub
    Sub CalculateRevenue()
        Dim TblRevenue As DataTable = DARevenue.SelectRevenueDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
        For Each rows As DataRow In TblRevenue.Rows
            TxtCashInB.Text = FormatNumber(IIf(IsDBNull(rows("THB_RECEIVED")), 0, rows("THB_RECEIVED")))
            TxtCashinD.Text = FormatNumber(IIf(IsDBNull(rows("USD_RECEIVED")), 0, rows("USD_RECEIVED")))
            TxtCashInR.Text = FormatNumber(IIf(IsDBNull(rows("KHR_RECEIVED")), 0, rows("KHR_RECEIVED")))
            TxtCashOutB.Text = FormatNumber(IIf(IsDBNull(rows("THB_PAID")), 0, rows("THB_PAID")))
            TxtCashOutD.Text = FormatNumber(IIf(IsDBNull(rows("USD_PAID")), 0, rows("USD_PAID")))
            TxtCashOutR.Text = FormatNumber(IIf(IsDBNull(rows("KHR_PAID")), 0, rows("KHR_PAID")))
        Next
        TxtNetIncomeB.Text = FormatNumber(CDbl(EmptyString(TxtCashInB.Text)) - CDbl(EmptyString(TxtCashOutB.Text)))
        TxtNetIncomeD.Text = FormatNumber(CDbl(EmptyString(TxtCashinD.Text)) - CDbl(EmptyString(TxtCashOutD.Text)))
        TxtNetIncomeR.Text = FormatNumber(CDbl(EmptyString(TxtCashInR.Text)) - CDbl(EmptyString(TxtCashOutR.Text)))

        ReportRevenue.SetDataSource(TblRevenue)
        ReportRevenue.SetParameterValue("Title", "From: " & DateFrom.Text & " To : " & DateTo.Text)
        Dim CrExportOptionsBig As ExportOptions
        Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
        Dim CrFormatTypeOptionsBig As New PdfRtfWordFormatOptions()
        CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\Revenue.pdf"
        CrExportOptionsBig = ReportRevenue.ExportOptions
        With CrExportOptionsBig
            .ExportDestinationType = ExportDestinationType.DiskFile
            .ExportFormatType = ExportFormatType.PortableDocFormat
            .DestinationOptions = CrDiskFileDestinationOptionsBig
            .FormatOptions = CrFormatTypeOptionsBig
        End With
        ReportRevenue.Export()
        Application.DoEvents()
        Application.DoEvents()
        AxAcroPDF1.src = My.Application.Info.DirectoryPath & "\Revenue.pdf"
        AxAcroPDF1.setZoom(100)
    End Sub
End Class
