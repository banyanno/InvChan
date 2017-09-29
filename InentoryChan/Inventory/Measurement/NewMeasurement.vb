Public Class NewMeasurement
    Dim DAUnit As New DSInventoryTableAdapters.UNITSTableAdapter
    Dim PUnit As DashboardMeasurement

    Sub New(ByVal MyPanel As DashboardMeasurement)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PUnit = MyPanel
    End Sub
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub ClearData()
        Me.txtname.Text = ""
        Me.txtname.Focus()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(txtname, "", ErrSupler) = False Then Exit Sub
        Dim tName As String = Me.txtname.Text.Replace("'", "''")
        If Me.lblStatus.Text = 0 Then
            DAUnit.InsertUnit(tName)
            ClearData()
            MsgBox("The unit was added", MsgBoxStyle.Information)
            'PUnit.RefreshData()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            DAUnit.UpdateUnit(tName, CInt(PUnit.UnitList.CurrentRow.Cells("UNIT_ID").Value))
            ClearData()
            MsgBox("The unit was updated", MsgBoxStyle.Information)
            'PUnit.RefreshData()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class