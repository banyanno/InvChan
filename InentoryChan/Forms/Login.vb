Public Class Login
    Dim DAUser As New DSItemTableAdapters.USERTableAdapter

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim UserName As String = Me.txtUserName.Text.Replace("'", "''")
        Dim Password As String = Me.txtPassword.Text.Replace("'", "''")
        If UserName = "" Then
            MsgBox("Please entery User Name", MsgBoxStyle.Information)
            Me.txtUserName.Focus()
            Me.txtUserName.SelectAll()
            Exit Sub
        End If
        If Password = "" Then
            MsgBox("Please entery Password", MsgBoxStyle.Information)
            Me.txtPassword.Focus()
            Me.txtPassword.SelectAll()
            Exit Sub
        End If
        If VerifyUser(UserName, Password) = True Then
            'If DAUser.CheckExistingLog(getCurrentUserID) = 1 Then
            '    MessageBox.Show("The user already login. Please logout if you want to use system.", "Lock user", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Else
            Dim MInventory As New MainInventoyV2(Me)
            MInventory.Show()
            'Dim DAUser As New DSItemTableAdapters.USERTableAdapter
            DAUser.UpdateLockUser(1, getCurrentUserID)
            'Dim FrmMain As New main
            'FrmMain.Show()
            Me.Hide()
            'End If

        Else
            MsgBox("Invalid User Name or Password, please try again.", MsgBoxStyle.Exclamation)
            Me.txtUserName.Focus()
            Me.txtUserName.SelectAll()
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Login_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.txtUserName.Focus()
    End Sub

    Private Sub Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtUserName.Focus()
    End Sub

    Private Sub txtUserName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class