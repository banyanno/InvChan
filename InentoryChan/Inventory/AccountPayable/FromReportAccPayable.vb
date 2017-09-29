Imports CrystalDecisions.Shared

Public Class FromReportAccPayable
    Dim DA_AccountPayable As New DSACCOUNTPAYABLETableAdapters.ACC_PAYABLETableAdapter
    Dim DA_AccountPayableDetail As New DSACCOUNTPAYABLETableAdapters.ACC_PAY_ABLE_DETAILTableAdapter
    Dim DASupplier As New DSInventoryTableAdapters.SUPPLIERTableAdapter
    Dim DA_AccPayable As New DSACCOUNTPAYABLETableAdapters.ACC_PAYABLE_VIEWTableAdapter
    Dim DA_AccPayableSummary As New DSACCOUNTPAYABLETableAdapters.ACC_PAYABLE_VIEW1TableAdapter
    Dim DA_PurchaseDetail As New DSACCOUNTPAYABLETableAdapters.PURCHASE_ORDER_MASTER_DETAIL_VIEWTableAdapter
    Dim DA_ACCPAY_ABLE As New DSACCOUNTPAYABLE
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        With CboSupplierReport
            .DataSource = DASupplier.GetData
            .ValueMember = "SUPP_ID"
            .DisplayMember = "SUPP_NAME"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ACC_PAY_Status As String
        If ChReportSummary.Checked = True Then
            Dim RAccPayable As New ReportAccPayableSumery
            Dim Title As String = ""
            If RadPaidAll.Checked = True Then
                ACC_PAY_Status = ""
            ElseIf RadNotPaid.Checked = True Then
                ACC_PAY_Status = "0"
            ElseIf RadCompletPaid.Checked = True Then
                ACC_PAY_Status = "1"
            End If
            Dim TblAccPayable As DataTable
            If RadPaidAll.Checked = True And RadViewAll.Checked = True Then
                TblAccPayable = DA_AccPayableSummary.SelectByDateToDateSupplierWithAllStatus(DFrom1.Value.Date, DTo1.Value.Date)
            ElseIf RadPaidAll.Checked = False And RadViewAll.Checked = True Then
                TblAccPayable = DA_AccPayableSummary.SelectDateToDateAllSupplyWithStatus(DFrom1.Value.Date, DTo1.Value.Date, ACC_PAY_Status)
            End If

            If RadPaidAll.Checked = True And RadBySupplier.Checked = True Then
                TblAccPayable = DA_AccPayableSummary.GetDataByDateToDateSupplyAllStatus(CboSupplierReport.SelectedValue, DFrom1.Value.Date, DTo1.Value.Date)
            ElseIf RadPaidAll.Checked = False And RadBySupplier.Checked = True Then
                TblAccPayable = DA_AccPayableSummary.GetDataByDateToDaySupplierWithStatus(CboSupplierReport.SelectedValue, DFrom1.Value.Date, DTo1.Value.Date, ACC_PAY_Status)
            End If
            RAccPayable.SetDataSource(TblAccPayable)
            Title = "From:" & DFrom1.Text & " To:" & DTo1.Text
            If RadViewAll.Checked = True Then
                Title = Title & vbCrLf & " All Supplier"
            End If
            If RadBySupplier.Checked = True Then
                Title = Title & vbCrLf & " By Supplyer: " & CboSupplierReport.Text
            End If
            RAccPayable.SetParameterValue("Title", Title)
            Dim CrExportOptionsBig As ExportOptions
            Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
            Dim CrFormatTypeOptionsBig As New PdfRtfWordFormatOptions()
            CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\AccPayable.pdf"
            CrExportOptionsBig = RAccPayable.ExportOptions
            With CrExportOptionsBig
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = CrDiskFileDestinationOptionsBig
                .FormatOptions = CrFormatTypeOptionsBig
            End With
            RAccPayable.Export()
            Application.DoEvents()
            Application.DoEvents()
            AxAcroPDF1.src = My.Application.Info.DirectoryPath & "\AccPayable.pdf"
            AxAcroPDF1.setZoom(100)
        Else
            Dim RAccPayable As New ReportAccPayable
            Dim Title As String = ""

            Dim TblAccPayable As DataTable
            If RadPaidAll.Checked = True Then
                ACC_PAY_Status = ""
            ElseIf RadNotPaid.Checked = True Then
                ACC_PAY_Status = "0"
            ElseIf RadCompletPaid.Checked = True Then
                ACC_PAY_Status = "1"
            End If
            If RadPaidAll.Checked = True And RadBySupplier.Checked = True Then
                TblAccPayable = DA_AccPayable.SelectAllPaidWithSupplier(DFrom1.Value.Date, DTo1.Value.Date, CboSupplierReport.SelectedValue)
            ElseIf RadPaidAll.Checked = False And RadBySupplier.Checked = True Then
                TblAccPayable = DA_AccPayable.SelectDateToDateWithSupplier(ACC_PAY_Status, DFrom1.Value.Date, DTo1.Value.Date, CboSupplierReport.SelectedValue)
            End If
            If RadPaidAll.Checked = True And RadViewAll.Checked = True Then
                TblAccPayable = DA_AccPayable.SelectDateToDate(DFrom1.Value.Date, DTo1.Value.Date)
            ElseIf RadPaidAll.Checked = False And RadViewAll.Checked = True Then
                TblAccPayable = DA_AccPayable.SelectDateToDateWithStatus(DFrom1.Value.Date, DTo1.Value.Date, ACC_PAY_Status)
            End If

            RAccPayable.SetDataSource(TblAccPayable)

            Title = "From:" & DFrom1.Text & " To:" & DTo1.Text
            If RadViewAll.Checked = True Then
                Title = Title & vbCrLf & " All Supplier"
            End If
            If RadBySupplier.Checked = True Then
                Title = Title & vbCrLf & " By Supplyer: " & CboSupplierReport.Text
            End If
            RAccPayable.SetParameterValue("Title", Title)
            Dim CrExportOptionsBig As ExportOptions
            Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
            Dim CrFormatTypeOptionsBig As New PdfRtfWordFormatOptions()
            CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\AccPayable.pdf"
            CrExportOptionsBig = RAccPayable.ExportOptions
            With CrExportOptionsBig
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = CrDiskFileDestinationOptionsBig
                .FormatOptions = CrFormatTypeOptionsBig
            End With
            RAccPayable.Export()
            Application.DoEvents()
            Application.DoEvents()
            AxAcroPDF1.src = My.Application.Info.DirectoryPath & "\AccPayable.pdf"
            AxAcroPDF1.setZoom(100)
        End If
    End Sub

    Private Sub FromReportAccPayable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadBySupplier_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBySupplier.CheckedChanged
        CboSupplierReport.Enabled = RadBySupplier.Checked
        CboSupplierReport.SelectedIndex = -1
    End Sub
End Class