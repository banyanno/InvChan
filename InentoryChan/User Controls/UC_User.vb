Public Class UC_User

    Dim DAUser As New DSItemTableAdapters.USERTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RefreshList()

    End Sub
    Sub RefreshList()
        Me.UserList.DataSource = DAUser.SelectAllUsers
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Do you want to delete the user :" & Me.UserList.CurrentRow.Cells("USER_NAME").Value & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DAUser.DeleteUser(CInt(Me.UserList.CurrentRow.Cells("USER_ID").Value))
            Me.RefreshList()
        End If
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Dim FrmUser As New User(Me)
        FrmUser.txtUserName.Text = Me.UserList.CurrentRow.Cells("USER_NAME").Value
        FrmUser.txtPassword.Text = Me.UserList.CurrentRow.Cells("PASSWORD").Value
        FrmUser.CboGroup.Text = Me.UserList.CurrentRow.Cells("USER_GROUP").Value.ToString
        FrmUser.cbolocation.SelectedValue = Me.UserList.CurrentRow.Cells("LOCA_ID").Value
        FrmUser.lblstatus.Text = 2
        FrmUser.ShowDialog()
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Dim FrmUser As New User(Me)
        FrmUser.lblstatus.Text = 1
        FrmUser.ShowDialog()
    End Sub
End Class
