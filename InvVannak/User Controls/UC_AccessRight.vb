Public Class UC_AccessRight
    Dim DAUser As New DSItemTableAdapters.USERTableAdapter
    Dim DARight As New DSItemTableAdapters.ACCESS_RIGHTTableAdapter
    Dim DAUserRight As New DSItemTableAdapters.USER_RIGHTTableAdapter
    Private Sub UC_AccessRight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CboUser.DataSource = DAUser.SelectUserByGroup("User")
        Me.CboUser.DisplayMember = "USER_NAME"
        Me.CboUser.ValueMember = "USER_ID"
        Dim RightTable As New DataTable
        RightTable = DARight.SelectAllRights
        Me.AccessList.DataSource = RightTable
        LoadRight()
    End Sub
    Sub LoadRight()
        For i As Integer = 0 To Me.AccessList.RowCount - 1
            If DAUserRight.SelectRightByUserID(CInt(Me.CboUser.SelectedValue), Me.AccessList.GetRows(i).Cells("ACCESS_NAME").Value).Rows.Count >= 1 Then
                Me.AccessList.GetRows(i).IsChecked = True
            Else
                Me.AccessList.GetRows(i).IsChecked = False
            End If
        Next
    End Sub
    Private Sub CboUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboUser.SelectedIndexChanged

    End Sub

    Private Sub CboUser_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboUser.SelectionChangeCommitted
       LoadRight()
    End Sub

   
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If MessageBox.Show("Do you want to update access right?", "Right", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            DAUserRight.DeleteByUserID(CInt(Me.CboUser.SelectedValue))
            For i As Integer = 0 To Me.AccessList.RowCount - 1
                If Me.AccessList.GetRows(i).Cells("Select").Value = True Then
                    DAUserRight.InsertAccess(CInt(Me.CboUser.SelectedValue), Me.AccessList.GetRows(i).Cells("ACCESS_NAME").Value.ToString)
                End If
            Next
            MsgBox("User right updated", MsgBoxStyle.Information)
        End If
        
    End Sub
End Class
