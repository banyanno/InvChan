Public Class UC_Unit
    Dim DAUnit As New DSItemTableAdapters.UNITTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RefreshList()

    End Sub
    Sub RefreshList()
        Me.UnitList.DataSource = DAUnit.SelectUnits
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Do you want to delete the unit :" & Me.UnitList.CurrentRow.Cells("UNIT_NAME").Value & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DAUnit.DeleteUnit(CInt(Me.UnitList.CurrentRow.Cells("UNIT_ID").Value))
            Me.RefreshList()
        End If
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Dim FrmUnit As New Unit(Me)
        FrmUnit.txtEngName.Text = Me.UnitList.CurrentRow.Cells("UNIT_NAME").Value
        FrmUnit.txtChnName.Text = Me.UnitList.CurrentRow.Cells("UNIT_NAME_CHN").Value
        FrmUnit.lblstatus.Text = 2
        FrmUnit.ShowDialog()
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim FrmUnit As New Unit(Me)
        FrmUnit.lblstatus.Text = 1
        FrmUnit.ShowDialog()
    End Sub

    Private Sub ToolStripSeparator2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSeparator2.Click

    End Sub

    Private Sub ToolStripSeparator1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSeparator1.Click

    End Sub

    Private Sub UnitList_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles UnitList.FormattingRow

    End Sub

    Private Sub ToolStrip2_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip2.ItemClicked

    End Sub
End Class
