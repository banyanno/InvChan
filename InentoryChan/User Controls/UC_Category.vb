Public Class UC_Category
    Dim DACategory As New DSItemTableAdapters.CATEGORYTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RefreshList()

    End Sub
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim FrmCategory As New Category(Me)
        FrmCategory.lblstatus.Text = 1
        FrmCategory.ShowDialog()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Dim FrmCategory As New Category(Me)
        FrmCategory.txtEngName.Text = Me.CategoryList.CurrentRow.Cells("CATE_NAME").Value
        FrmCategory.txtChnName.Text = Me.CategoryList.CurrentRow.Cells("CATE_NAME_CHN").Value
        FrmCategory.lblstatus.Text = 2
        FrmCategory.ShowDialog()
    End Sub
    Sub RefreshList()
        Me.CategoryList.DataSource = DACategory.SelectCategories
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Do you want to delete the category :" & Me.CategoryList.CurrentRow.Cells("CATE_NAME").Value & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DACategory.DeleteCategory(CInt(Me.CategoryList.CurrentRow.Cells("CATE_ID").Value))
            Me.RefreshList()
        End If
    End Sub
End Class
