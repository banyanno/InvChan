Public Class User

    'Declare the variables
    Dim DAUser As New DSItemTableAdapters.USERTableAdapter
    Dim DALocation As New DSItemTableAdapters.LOCATIONTableAdapter
    Dim PUser As UC_User

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Sub New(ByVal MyPanel As UC_User)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.PUser = MyPanel
        Me.cbolocation.DataSource = DALocation.SelectLocations
        Me.cbolocation.DisplayMember = "LOCA_NAME"
        Me.cbolocation.ValueMember = "LOCA_ID"
    End Sub

    Private Sub lblHeader_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblHeader.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub lblHeader_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblHeader.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub lblHeader_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblHeader.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim UserName As String = Me.txtUserName.Text.Trim.Replace("'", "''")
        Dim PassWord As String = Me.txtPassword.Text.Trim.Replace("'", "''")
        Dim UserGroup As String = Me.CboGroup.Text
        Dim LocationID As Integer = CInt(Me.cbolocation.SelectedValue)
        If UserName = "" Then
            MsgBox("Please enter User Name", MsgBoxStyle.Information)
            Me.txtUserName.Focus()
            Exit Sub
        End If
        If PassWord = "" Then
            MsgBox("Please enter Password", MsgBoxStyle.Information)
            Me.txtPassword.Focus()
            Exit Sub
        End If
        If Me.lblstatus.Text = 1 Then
            ''INSERT
            If DAUser.ExistingUser(UserName) >= 1 Then
                MsgBox("This user name already exists", MsgBoxStyle.Information)
                Exit Sub
            Else
                DAUser.InsertUser(UserName, PassWord, UserGroup, LocationID)
                MsgBox("User added", MsgBoxStyle.Information)
                ClearBox()
                PUser.RefreshList()
                Me.txtUserName.Focus()
            End If
        Else
            ''UPDATE
            DAUser.UpdateUser(UserName, PassWord, UserGroup, LocationID, CInt(PUser.UserList.CurrentRow.Cells("USER_ID").Value))
            MsgBox("User updated", MsgBoxStyle.Information)
            ClearBox()
            Me.Close()
            PUser.RefreshList()
        End If
    End Sub
    Sub ClearBox()
        Me.txtUserName.Text = ""
        Me.txtPassword.Text = ""
    End Sub

    Private Sub lblstatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblstatus.Click

    End Sub
End Class