Public Class NewCategory
    Dim DACategory As New DSInventoryTableAdapters.CATEGORIESTableAdapter
    Dim PCategory As DashboardCategory

    Sub New(ByVal MyPanel As DashboardCategory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PCategory = MyPanel
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
            DACategory.InsertCategory(tName)
            ClearData()
            MsgBox("The category was added", MsgBoxStyle.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            'PCategory.RefreshData()
        Else
            DACategory.UpdateCategory(tName, CInt(PCategory.CategoryList.CurrentRow.Cells("CATE_ID").Value))
            ClearData()
            MsgBox("The category was updated", MsgBoxStyle.Information)

            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub NewCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class