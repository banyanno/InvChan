Public Class UC_Location
    Dim DALocation As New DSItemTableAdapters.LOCATIONTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RefreshList()

    End Sub
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim FrmLocation As New Location(Me)
        FrmLocation.lblstatus.Text = 1
        FrmLocation.ShowDialog()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Dim FrmLocation As New Location(Me)
        FrmLocation.txtLocation.Text = Me.LocationList.CurrentRow.Cells("LOCA_NAME").Value
        FrmLocation.cboMainLocation.SelectedValue = Me.LocationList.CurrentRow.Cells("MLOC_ID").Value
        FrmLocation.lblstatus.Text = 2
        FrmLocation.ShowDialog()
    End Sub
    Sub RefreshList()
        Me.LocationList.DataSource = DALocation.SelectLocations
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Do you want to delete the location :" & Me.LocationList.CurrentRow.Cells("LOCA_NAME").Value & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DALocation.DeleteLocation(CInt(Me.LocationList.CurrentRow.Cells("LOCA_ID").Value))
            Me.RefreshList()
        End If
    End Sub

    Private Sub ToolStrip2_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip2.ItemClicked

    End Sub
End Class
