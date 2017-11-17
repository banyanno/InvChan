Public Class FindCustomer

    Dim DALocation As New DSInventoryTableAdapters.LOCATIONSTableAdapter
    Dim DACustomer As New DSInventoryTableAdapters.CUSTOMERTableAdapter
    Dim PCustomer As DashboardCustomers
    Sub New(ByVal MyPanel As DashboardCustomers)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PCustomer = MyPanel
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
            ResultTable = DACustomer.SelectByName(Me.txtName.Text.Replace("'", "''"))
        ElseIf RadByPhone.Checked = True Then
            ResultTable = DACustomer.SelectByPhone(Me.txtphone.Text.Replace("'", "''"))
        ElseIf RadBySex.Checked = True Then
            ResultTable = DACustomer.SelectByGender(Me.cbogender.Text)
        ElseIf RadByLocation.Checked = True Then
            ResultTable = DACustomer.SelectByLocation(Me.cbolocation.SelectedValue)
        End If
        If ResultTable.Rows.Count <= 0 Then
            MsgBox("No result was found", MsgBoxStyle.Information)
        Else
            PCustomer.CustomerList.DataSource = ResultTable
            Me.Close()
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FindCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class