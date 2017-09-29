Imports CrystalDecisions.Shared

Public Class FormReportReceivable
    Dim DS_ACC_ReceiveAble As New DSAccountReceivable

    Dim DAPayment As New DSAccountReceivableTableAdapters.AR_PAYMENTTableAdapter
    Dim DACustomer As New DSInventoryTableAdapters.CUSTOMERTableAdapter
    Dim DA_Invoice_Detail As New DSAccountReceivableTableAdapters.INVOICE_DETAILSTableAdapter
    Dim DA_ACC_ReceiveAbleDetail As New DSAccountReceivableTableAdapters.ACC_RECEIVED_ABLE_VIEWTableAdapter
    Dim DA_ACC_ReceiveSummary As New DSAccountReceivableTableAdapters.ACC_RECEIVED_ABLE_VIEW1TableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboCustomerReport
            .DataSource = DACustomer.SelectAllCustomers
            .DisplayMember = "CUST_NAME"
            .ValueMember = "CUST_ID"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        If ChIsSummary.Checked = True Then
            Dim RAccReceive As New ReportAccRecceiveAbleSummary
            Dim tblReceiveAble As DataTable
            Dim Status_Paid As Integer
            Dim Title As String
            If RadStatusNotyet.Checked = True Then
                Status_Paid = 0
            ElseIf RadStatusComplet.Checked = True Then
                Status_Paid = 1
            End If
            Title = "From:" & DFrom.Text & " To:" & DTo.Text

            If ChCustomer.Checked = True Then
                Title = Title & vbCrLf & " By Supplyer: " & CboCustomerReport.Text
            Else
                Title = Title & vbCrLf & " All Customer"
            End If

            If RadAllStatus.Checked = True And ChCustomer.Checked = False Then
                tblReceiveAble = DA_ACC_ReceiveSummary.SelectDateToDateAllStatus(DFrom.Value.Date, DTo.Value.Date, 0)
            ElseIf RadAllStatus.Checked = False And ChCustomer.Checked = False Then
                tblReceiveAble = DA_ACC_ReceiveSummary.SelectDateToDateWhithStatus(DFrom.Value.Date, DTo.Value.Date, Status_Paid, 0)
            End If
            If RadAllStatus.Checked = True And ChCustomer.Checked = True Then
                tblReceiveAble = DA_ACC_ReceiveSummary.SelectDateToDateByCustomerAllStatus(DFrom.Value.Date, DTo.Value.Date, CboCustomerReport.SelectedValue, 0)
            ElseIf RadAllStatus.Checked = False And ChCustomer.Checked = True Then
                tblReceiveAble = DA_ACC_ReceiveAbleDetail.SelectDateToDateWithCustomerAndStatus(DFrom.Value.Date, DTo.Value.Date, CboCustomerReport.SelectedValue, Status_Paid, 0)
            End If
            RAccReceive.SetDataSource(tblReceiveAble)
            RAccReceive.SetParameterValue("Title", Title)
            Dim CrExportOptionsBig As ExportOptions
            Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
            Dim CrFormatTypeOptionsBig As New PdfRtfWordFormatOptions()
            CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\AccReceiveAbleSummary.pdf"
            CrExportOptionsBig = RAccReceive.ExportOptions
            With CrExportOptionsBig
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = CrDiskFileDestinationOptionsBig
                .FormatOptions = CrFormatTypeOptionsBig
            End With
            RAccReceive.Export()
            Application.DoEvents()
            Application.DoEvents()
            AxAcroPDF1.src = My.Application.Info.DirectoryPath & "\AccReceiveAbleSummary.pdf"
            AxAcroPDF1.setZoom(100)

        Else
            Dim RAccReceiveAble As New ReportAccReceivedable
            Dim tblReceiveAble As DataTable
            Dim Status_Paid As Integer
            Dim Title As String
            If RadStatusNotyet.Checked = True Then
                Status_Paid = 0
            ElseIf RadStatusComplet.Checked = True Then
                Status_Paid = 1
            End If
            If RadAllStatus.Checked = True And ChCustomer.Checked = False Then
                tblReceiveAble = DA_ACC_ReceiveAbleDetail.SelectDateToDateAllCustomerAndAllStatus(DFrom.Value.Date, DTo.Value.Date, 0)
            ElseIf RadAllStatus.Checked = False And ChCustomer.Checked = False Then
                tblReceiveAble = DA_ACC_ReceiveAbleDetail.SelectDateToDateAllCustomerWithStatus(DFrom.Value.Date, DTo.Value.Date, Status_Paid, 0)
            End If
            If RadAllStatus.Checked = True And ChCustomer.Checked = True Then
                tblReceiveAble = DA_ACC_ReceiveAbleDetail.SelectDateToDateWithCustomerAllStatus(DFrom.Value.Date, DTo.Value.Date, CboCustomerReport.SelectedValue, 0)
            ElseIf RadAllStatus.Checked = False And ChCustomer.Checked = True Then
                tblReceiveAble = DA_ACC_ReceiveAbleDetail.SelectDateToDateWithCustomerAndStatus(DFrom.Value.Date, DTo.Value.Date, CboCustomerReport.SelectedValue, Status_Paid, 0)
            End If

            RAccReceiveAble.SetDataSource(tblReceiveAble)
            Title = "From:" & DFrom.Text & " To:" & DTo.Text

            If ChCustomer.Checked = True Then
                Title = Title & vbCrLf & " By Supplyer: " & CboCustomerReport.Text
            Else
                Title = Title & vbCrLf & " All Customer"
            End If
            RAccReceiveAble.SetParameterValue("Title", Title)
            Dim CrExportOptionsBig As ExportOptions
            Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
            Dim CrFormatTypeOptionsBig As New PdfRtfWordFormatOptions()
            CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\AccReceiveAble.pdf"
            CrExportOptionsBig = RAccReceiveAble.ExportOptions
            With CrExportOptionsBig
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = CrDiskFileDestinationOptionsBig
                .FormatOptions = CrFormatTypeOptionsBig
            End With
            RAccReceiveAble.Export()
            Application.DoEvents()
            Application.DoEvents()
            AxAcroPDF1.src = My.Application.Info.DirectoryPath & "\AccReceiveAble.pdf"
            AxAcroPDF1.setZoom(100)
        End If
    End Sub

    Private Sub ChCustomer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChCustomer.CheckedChanged
        CboCustomerReport.Enabled = ChCustomer.Checked
        CboCustomerReport.SelectedIndex = -1
        With CboCustomerReport
            .DataSource = DACustomer.SelectAllCustomers
            .DisplayMember = "CUST_NAME"
            .ValueMember = "CUST_ID"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub FormReportReceivable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class