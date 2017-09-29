Public Class DashboardMeasurement
    Dim DAUnit As New DSInventoryTableAdapters.UNITSTableAdapter
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim FrmUnit As New NewMeasurement(Me)
        FrmUnit.lblStatus.Text = 0
        FrmUnit.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If Me.UnitList.RowCount >= 1 Then
            Dim FrmUnit As New NewMeasurement(Me)
            FrmUnit.txtname.Text = UnitList.CurrentRow.Cells("UNIT_NAME").Value
            FrmUnit.lblStatus.Text = 1
            FrmUnit.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        If Me.UnitList.RowCount >= 1 Then
            If MsgBox("Do you want to delete the unit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DAUnit.DeleteUnit(Me.UnitList.CurrentRow.Cells("UNIT_ID").Value)
                RefreshData()
            End If
        End If
    End Sub
    Sub RefreshData()
        UnitList.DataSource = DAUnit.SelectAllUnits
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        RefreshData()
    End Sub

    Private Sub ToolSupplier_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolSupplier.ItemClicked

    End Sub

    Private Sub DashboardMeasurement_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RefreshData()
    End Sub
End Class
