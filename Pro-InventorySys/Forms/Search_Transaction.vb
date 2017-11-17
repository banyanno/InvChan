Public Class Search_Transaction
    'Declare the variables
    Dim DATransaction As New DSItemTableAdapters.TRANSACTIONTableAdapter
    Dim DACategory As New DSItemTableAdapters.CATEGORYTableAdapter
    Dim DAItem As New DSItemTableAdapters.ITEMTableAdapter
    Dim PTransaction As UC_RptTransaction

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Sub New(ByVal MyPanel As UC_RptTransaction)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PTransaction = MyPanel
        Me.cboCategory.DataSource = DACategory.SelectCategories
        Me.cboCategory.DisplayMember = "CATE_NAME_CHN"
        Me.cboCategory.ValueMember = "CATE_ID"

        Me.CboItem.DataSource = DAItem.SelectItems
        Me.CboItem.DisplayMember = "ITEM_NAME_CHN"
        Me.CboItem.ValueMember = "ITEM_ID"


    End Sub
    Private Sub lblHeader_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblHeader.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub lblHeader_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblHeader.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub lblHeader_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblHeader.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim ResultTable As New DataTable
        Dim MyReport As New RptTransaction
        Dim ReportViewere As New Report_Viewer
        If RadByAll.Checked = True Then
            ResultTable = DATransaction.SelectByDate(FormatDateTime(Me.DtFrom.Value, DateFormat.ShortDate), FormatDateTime(Me.DtTo.Value, DateFormat.ShortDate))
        ElseIf RadByItem.Checked = True Then
            ResultTable = DATransaction.SelectByItem(CInt(Me.CboItem.SelectedValue), FormatDateTime(Me.DtFrom.Value, DateFormat.ShortDate), FormatDateTime(Me.DtTo.Value, DateFormat.ShortDate))
        Else
            ResultTable = DATransaction.SelectByCategory(Me.cboCategory.Text, FormatDateTime(Me.DtFrom.Value, DateFormat.ShortDate), FormatDateTime(Me.DtTo.Value, DateFormat.ShortDate))
        End If
        If ResultTable.Rows.Count <= 0 Then
            MsgBox("No record was found", MsgBoxStyle.Information)
        Else
            PTransaction.TransactionList.DataSource = ResultTable
            MsgBox(ResultTable.Rows.Count & " record(s) were found", MsgBoxStyle.Information)
            MyReport.SetDataSource(ResultTable)
            MyReport.SetParameterValue("fromdate", Me.DtFrom.Value)
            MyReport.SetParameterValue("todate", Me.DtTo.Value)
            ReportViewere.CrystalReportViewer1.ReportSource = MyReport
            ReportViewere.ShowDialog()
        End If
    End Sub

    Private Sub RadByAll_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadByAll.CheckedChanged
        If Me.RadByAll.Checked = True Then
            Me.cboCategory.Visible = False
            Me.CboItem.Visible = False
            Me.lblChoose.Visible = False
        End If
    End Sub

    Private Sub RadByAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadByAll.Click

    End Sub

    Private Sub RadByCategory_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadByCategory.CheckedChanged
        If Me.RadByCategory.Checked = True Then
            Me.cboCategory.Visible = True
            Me.CboItem.Visible = False
            Me.lblChoose.Visible = True
        End If
    End Sub

    Private Sub RadByItem_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadByItem.CheckedChanged
        If Me.RadByItem.Checked = True Then
            Me.cboCategory.Visible = False
            Me.CboItem.Visible = True
            Me.lblChoose.Visible = True
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class