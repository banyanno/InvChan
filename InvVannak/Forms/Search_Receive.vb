Public Class Search_Receive

    'Declare the variables
    Dim DAReceive As New DSItemTableAdapters.RECEIVETableAdapter
    Dim DACategory As New DSItemTableAdapters.CATEGORYTableAdapter
    Dim DAItem As New DSItemTableAdapters.ITEMTableAdapter
    Dim DALocation As New DSItemTableAdapters.LOCATIONTableAdapter
    Dim PReceive As UC_RptReceive

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Sub New(ByVal MyPanel As UC_RptReceive)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PReceive = MyPanel
        Me.cboCategory.DataSource = DACategory.SelectCategories
        Me.cboCategory.DisplayMember = "CATE_NAME_CHN"
        Me.cboCategory.ValueMember = "CATE_ID"

        Me.CboItem.DataSource = DAItem.SelectItems
        Me.CboItem.DisplayMember = "ITEM_NAME_CHN"
        Me.CboItem.ValueMember = "ITEM_ID"

        Dim LocationTable As New DataTable
        LocationTable = DALocation.SelectLocations
        Me.CboLocation.Items.Add("All Locations")
        For i As Integer = 0 To LocationTable.Rows.Count - 1
            Me.CboLocation.Items.Add(LocationTable.Rows(i).Item("LOCA_NAME"))
        Next


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
        If Me.RadSum.Checked = True Then
            Dim DAReceive As New DSReportTableAdapters.RECEIVE_SUMTableAdapter
            Dim ResultTable As New DataTable
            Dim MyReport As New RptReceive_Sum
            Dim ReportViewer As New Report_Viewer
            If Me.CboLocation.Text = "All Locations" Then
                If RadByAll.Checked = True Then
                    ResultTable = DAReceive.SelectAllLocationByDate(FormatDateTime(Me.DtFrom.Value, DateFormat.ShortDate), FormatDateTime(Me.DtTo.Value, DateFormat.ShortDate))
                ElseIf RadByItem.Checked = True Then
                    ResultTable = DAReceive.SelectAllocationByItemIDAndDate(CInt(Me.CboItem.SelectedValue), FormatDateTime(Me.DtFrom.Value, DateFormat.ShortDate), FormatDateTime(Me.DtTo.Value, DateFormat.ShortDate))
                Else
                    ResultTable = DAReceive.SelectAllLocationByCategoryAndDate(Me.cboCategory.Text, FormatDateTime(Me.DtFrom.Value, DateFormat.ShortDate), FormatDateTime(Me.DtTo.Value, DateFormat.ShortDate))
                End If
            Else
                If RadByAll.Checked = True Then
                    ResultTable = DAReceive.SelectByDate(Me.CboLocation.Text, FormatDateTime(Me.DtFrom.Value, DateFormat.ShortDate), FormatDateTime(Me.DtTo.Value, DateFormat.ShortDate))
                ElseIf RadByItem.Checked = True Then
                    ResultTable = DAReceive.SelectByItemIDAndDate(Me.CboLocation.Text, CInt(Me.CboItem.SelectedValue), FormatDateTime(Me.DtFrom.Value, DateFormat.ShortDate), FormatDateTime(Me.DtTo.Value, DateFormat.ShortDate))
                Else
                    ResultTable = DAReceive.SelectByCategoryAndDate(Me.CboLocation.Text, Me.cboCategory.Text, FormatDateTime(Me.DtFrom.Value, DateFormat.ShortDate), FormatDateTime(Me.DtTo.Value, DateFormat.ShortDate))
                End If
            End If

            If ResultTable.Rows.Count <= 0 Then
                MsgBox("No record was found", MsgBoxStyle.Information)
            Else
                PReceive.ReceiveList.DataSource = ResultTable
                MsgBox(ResultTable.Rows.Count & " record(s) were found", MsgBoxStyle.Information)
                MyReport.SetDataSource(ResultTable)
                MyReport.SetParameterValue("fromdate", Me.DtFrom.Value)
                MyReport.SetParameterValue("todate", Me.DtTo.Value)
                ReportViewer.CrystalReportViewer1.ReportSource = MyReport
                ReportViewer.ShowDialog()
            End If
        Else
            Dim ResultTable As New DataTable
            Dim MyReport As New RptReceive
            Dim ReportViewer As New Report_Viewer
            If Me.CboLocation.Text = "All Locations" Then
                If RadByAll.Checked = True Then
                    ResultTable = DAReceive.SelectAllLocationsByDate(FormatDateTime(Me.DtFrom.Value, DateFormat.ShortDate), FormatDateTime(Me.DtTo.Value, DateFormat.ShortDate))
                ElseIf RadByItem.Checked = True Then
                    ResultTable = DAReceive.SelectAllLocationByItemIDAndDate(CInt(Me.CboItem.SelectedValue), FormatDateTime(Me.DtFrom.Value, DateFormat.ShortDate), FormatDateTime(Me.DtTo.Value, DateFormat.ShortDate))
                Else
                    ResultTable = DAReceive.SelectAllLocationsByCategoryNameAndDate(Me.cboCategory.Text, FormatDateTime(Me.DtFrom.Value, DateFormat.ShortDate), FormatDateTime(Me.DtTo.Value, DateFormat.ShortDate))
                End If
            Else
                If RadByAll.Checked = True Then
                    ResultTable = DAReceive.SelectReceiveByDate(Me.CboLocation.Text, FormatDateTime(Me.DtFrom.Value, DateFormat.ShortDate), FormatDateTime(Me.DtTo.Value, DateFormat.ShortDate))
                ElseIf RadByItem.Checked = True Then
                    ResultTable = DAReceive.SelectRecevieByItemIDAndDate(Me.CboLocation.Text, CInt(Me.CboItem.SelectedValue), FormatDateTime(Me.DtFrom.Value, DateFormat.ShortDate), FormatDateTime(Me.DtTo.Value, DateFormat.ShortDate))
                Else
                    ResultTable = DAReceive.SelectReceiveByCategroyNameAndDate(Me.CboLocation.Text, Me.cboCategory.Text, FormatDateTime(Me.DtFrom.Value, DateFormat.ShortDate), FormatDateTime(Me.DtTo.Value, DateFormat.ShortDate))
                End If
            End If

            If ResultTable.Rows.Count <= 0 Then
                MsgBox("No record was found", MsgBoxStyle.Information)
            Else
                PReceive.ReceiveList.DataSource = ResultTable
                MsgBox(ResultTable.Rows.Count & " record(s) were found", MsgBoxStyle.Information)
                MyReport.SetDataSource(ResultTable)
                MyReport.SetParameterValue("fromdate", Me.DtFrom.Value)
                MyReport.SetParameterValue("todate", Me.DtTo.Value)
                ReportViewer.CrystalReportViewer1.ReportSource = MyReport
                ReportViewer.ShowDialog()
            End If
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