Public Class FindSupplyer

    Dim DALocation As New DSInventoryTableAdapters.LOCATIONSTableAdapter
    Dim DASupplier As New DSInventoryTableAdapters.SUPPLIERTableAdapter
    Dim PSupplier As DashboardSupplier
    Sub New(ByVal MyPanel As DashboardSupplier)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PSupplier = MyPanel
        Me.cbolocation.DataSource = DALocation.SelectAllLocations
        Me.cbolocation.DisplayMember = "LOCA_NAME"
        Me.cbolocation.ValueMember = "LOCA_ID"

        Me.txtphone.Enabled = False
        Me.cbogender.Enabled = False
        Me.cbolocation.Enabled = False
    End Sub


    Sub DisabledAllBoxes()
        Me.txtName.Enabled = False
        Me.txtphone.Enabled = False
        Me.cbogender.Enabled = False
        Me.cbolocation.Enabled = False
    End Sub

    Private Sub RadByName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByName.CheckedChanged
        DisabledAllBoxes()
        If Me.RadByName.Checked = True Then
            Me.txtName.Enabled = True
            Me.txtName.Text = ""
            Me.txtName.Focus()
        End If
    End Sub

    Private Sub RadByPhone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByPhone.CheckedChanged
        DisabledAllBoxes()
        If Me.RadByPhone.Checked = True Then
            Me.txtphone.Enabled = True
            Me.txtphone.Text = ""
            Me.txtphone.Focus()
        End If
    End Sub

    Private Sub RadBySex_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadBySex.CheckedChanged
        DisabledAllBoxes()
        If Me.RadBySex.Checked = True Then
            Me.cbogender.Enabled = True
            Me.cbogender.Text = ""
            Me.cbogender.Focus()
        End If
    End Sub

    Private Sub RadByLocation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadByLocation.CheckedChanged
        DisabledAllBoxes()
        If Me.RadByLocation.Checked = True Then
            Me.cbolocation.Enabled = True
            Me.cbolocation.Text = ""
            Me.cbolocation.Focus()
        End If
    End Sub

    Private Sub BtnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStart.Click
        Dim ResultTable As New DataTable
        If RadByName.Checked = True Then
            ResultTable = DASupplier.SelectByName(Me.txtName.Text.Replace("'", "''"))
        ElseIf RadByPhone.Checked = True Then
            ResultTable = DASupplier.SelectByPhone(Me.txtphone.Text.Replace("'", "''"))
        ElseIf RadBySex.Checked = True Then
            ResultTable = DASupplier.SelectByGender(Me.cbogender.Text)
        ElseIf RadByLocation.Checked = True Then
            ResultTable = DASupplier.SelectByLocation(Me.cbolocation.SelectedValue)
        End If
        If ResultTable.Rows.Count <= 0 Then
            MsgBox("No result was found", MsgBoxStyle.Information)
        Else
            PSupplier.SupplierList.DataSource = ResultTable
            Me.Close()
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class