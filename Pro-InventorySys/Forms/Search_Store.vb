Public Class Search_Store

    'Declare the variables
    Dim DAStore As New DSItemTableAdapters.ITEM_STORETableAdapter
    Dim DACategory As New DSItemTableAdapters.CATEGORYTableAdapter
    Dim PStore As UC_RptStore

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Sub New(ByVal MyPanel As UC_RptStore)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PStore = MyPanel
        Dim CategoryTable As New DataTable
        CategoryTable = DACategory.SelectCategories
        Me.cboCategory.Items.Add("All Categories")
        For i As Integer = 0 To CategoryTable.Rows.Count - 1
            Me.cboCategory.Items.Add(CategoryTable.Rows(i).Item("CATE_NAME_CHN"))
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
        Dim ResultTable As New DataTable
        Dim MyReport As New RptStore
        Dim ReportViewer As New Report_Viewer
        If RadByBarcode.Checked Then
            If Me.txtBarcode.Text = "" Then
                MsgBox("No barcode was scanned", MsgBoxStyle.Information)
                Me.txtBarcode.Focus()
                Exit Sub
            End If
            ResultTable = DAStore.SelectStoreByBarcode(Me.txtBarcode.Text)
            If ResultTable.Rows.Count <= 0 Then
                MsgBox("No record was found", MsgBoxStyle.Information)
                Me.txtBarcode.Focus()
            Else
                PStore.StoreList.DataSource = ResultTable
                MsgBox(ResultTable.Rows.Count & " record(s) were found", MsgBoxStyle.Information)
                MyReport.SetDataSource(ResultTable)
                ReportViewer.CrystalReportViewer1.ReportSource = MyReport
                ReportViewer.ShowDialog()
            End If
        Else
            If Me.cboCategory.Text = "All Categories" Then
                ResultTable = DAStore.SelectStores
            Else
                ResultTable = DAStore.SelectStoreByCategoryName(Me.cboCategory.Text)
            End If
            If ResultTable.Rows.Count <= 0 Then
                MsgBox("No record was found", MsgBoxStyle.Information)
                Me.txtBarcode.Focus()
            Else
                PStore.StoreList.DataSource = ResultTable
                MsgBox(ResultTable.Rows.Count & " record(s) were found", MsgBoxStyle.Information)
                MyReport.SetDataSource(ResultTable)
                ReportViewer.CrystalReportViewer1.ReportSource = MyReport
                ReportViewer.ShowDialog()
            End If
        End If
    End Sub

    Private Sub lblHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHeader.Click

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class