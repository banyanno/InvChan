Public Class NewCostomer
    Dim DALocation As New DSInventoryTableAdapters.LOCATIONSTableAdapter
    Dim DACustomer As New DSInventoryTableAdapters.CUSTOMERTableAdapter
    Dim PCustomer As DashboardCustomers
    Public IS_AddFromSale As Boolean = True
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.cbolocation.DataSource = DALocation.SelectAllLocations
        Me.cbolocation.DisplayMember = "LOCA_NAME"
        Me.cbolocation.ValueMember = "LOCA_ID"
    End Sub
    Sub New(ByVal MyPanel As DashboardCustomers)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PCustomer = MyPanel
        Me.cbolocation.DataSource = DALocation.SelectAllLocations
        Me.cbolocation.DisplayMember = "LOCA_NAME"
        Me.cbolocation.ValueMember = "LOCA_ID"
    End Sub
    Sub ClearData()
        Me.txtname.Text = ""
        Me.txtshop.Text = ""
        Me.txtphone.Text = ""
        Me.txtemail.Text = ""
        Me.cbogender.SelectedIndex = -1
        Me.txtwebsite.Text = ""
        Me.txtaddress.Text = ""
        Me.txtnote.Text = ""
        Me.cbolocation.SelectedIndex = -1
        txtname.Select()
        txtname.Focus()
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(txtname, "", ErrCustomer) = False Then Exit Sub
        If ValidateTextField(txtphone, "", ErrCustomer) = False Then Exit Sub
        'If ValidateTextField(txtemail, "", ErrCustomer) = False Then Exit Sub
        Dim tName As String = Me.txtname.Text.Replace("'", "''")
        Dim tGender As String = Me.cbogender.Text.Replace("'", "''")
        Dim tShopName As String = Me.txtshop.Text.Replace("'", "''")
        Dim tLocation As Integer = CInt(Me.cbolocation.SelectedValue)
        Dim tPhone As String = Me.txtphone.Text.Replace("'", "''")
        Dim tEmail As String = Me.txtemail.Text.Replace("'", "''")
        Dim tWebsite As String = Me.txtwebsite.Text.Replace("'", "''")
        Dim tAddress As String = Me.txtaddress.Text.Replace("'", "''")
        Dim tNote As String = Me.txtnote.Text.Replace("'", "''")
        If Me.lblStatus.Text = 0 Then
            If DACustomer.InsertCustomer(tName, tGender, tShopName, tAddress, tPhone, tEmail, tWebsite, tLocation, getCurrentUserID, tNote, FormatDateTime(Now, DateFormat.ShortDate)) = 1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                'ClearData()
                'MsgBox("The customer was added", MsgBoxStyle.Information)
                'PCustomer.RefreshData()
            End If
            
        Else
            DACustomer.UpdateCustomer(tName, tGender, tShopName, tAddress, tPhone, tEmail, tWebsite, tLocation, getCurrentUserID, tNote, FormatDateTime(Now, DateFormat.ShortDate), CInt(PCustomer.CustomerList.CurrentRow.Cells("CUST_ID").Value))
            ClearData()
            MsgBox("The customer was updated", MsgBoxStyle.Information)
            PCustomer.RefreshData()
            Me.Close()
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub NewCostomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtname.Select()
        txtname.Focus()

    End Sub
End Class