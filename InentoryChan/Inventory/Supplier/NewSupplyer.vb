Public Class NewSupplyer

    Dim DALocation As New DSInventoryTableAdapters.LOCATIONSTableAdapter
    Dim DASupplier As New DSInventoryTableAdapters.SUPPLIERTableAdapter
    Dim PSupplier As DashboardSupplier
    Public IS_AddFromPuchase As Boolean = False
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.cbolocation.DataSource = DALocation.SelectAllLocations
        Me.cbolocation.DisplayMember = "LOCA_NAME"
        Me.cbolocation.ValueMember = "LOCA_ID"
    End Sub
    Sub New(ByVal MyPanel As DashboardSupplier)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PSupplier = MyPanel
        Me.cbolocation.DataSource = DALocation.SelectAllLocations
        Me.cbolocation.DisplayMember = "LOCA_NAME"
        Me.cbolocation.ValueMember = "LOCA_ID"
    End Sub
    Sub ClearData()
        Me.txtname.Text = ""
        Me.txtshop.Text = ""
        Me.txtphone.Text = ""
        Me.txtemail.Text = ""
        Me.txtwebsite.Text = ""
        Me.txtaddress.Text = ""
        Me.txtnote.Text = ""
        Me.txtname.Focus()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(txtname, "", ErrSupler) = False Then Exit Sub
        If ValidateTextField(txtphone, "", ErrSupler) = False Then Exit Sub

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
            DASupplier.InsertSupplier(tName, tGender, tShopName, tAddress, tPhone, tEmail, tWebsite, tLocation, getCurrentUserID, tNote, FormatDateTime(Now, DateFormat.ShortDate))
            ClearData()
            MsgBox("The supplier was added", MsgBoxStyle.Information)
            If IS_AddFromPuchase = False Then
                PSupplier.RefreshData()
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        Else
            DASupplier.UpdateSupplier(tName, tGender, tShopName, tAddress, tPhone, tEmail, tWebsite, tLocation, getCurrentUserID, tNote, FormatDateTime(Now, DateFormat.ShortDate), CInt(PSupplier.SupplierList.CurrentRow.Cells("SUPP_ID").Value))
            ClearData()
            MsgBox("The supplier was updated", MsgBoxStyle.Information)
            PSupplier.RefreshData()
            Me.Close()
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class