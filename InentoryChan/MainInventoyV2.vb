Public Class MainInventoyV2
    Dim HomeDashBoard As New MainDashBaord(Me)
    Dim DAUser As New DSItemTableAdapters.USERTableAdapter
    Dim FLogIn As Login

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub
    Sub AddUserControl(ByVal PanelMain As Panel, ByVal UI As UserControl, ByVal Info As String, ByVal VisHeader As Boolean)
        Me.Cursor = Cursors.WaitCursor
        Panel1.Visible = VisHeader
        PanelMain.Controls.Clear()
        PanelMain.AutoScroll = True
        'PMainContainer.AutoScrollMinSize = New Size(UI.Width, UI.Height)
        UI.Dock = DockStyle.Fill
        PanelMain.Controls.Add(UI)
        Me.Cursor = Cursors.Default
    End Sub
    Sub New(ByVal FLogIn As Login)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.FLogIn = FLogIn
        'AddUserControl(MainPanel, HomeDashBoard, "")
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub LblClose_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Application.Exit()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserControl(MainPanel, HomeDashBoard, "", True)
    End Sub

    Private Sub MainInventoyV2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DAUser.UpdateLockUser(1, getCurrentUserID)
        AddUserControl(MainPanel, HomeDashBoard, "", True)
    End Sub

    Private Sub BtnClosed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClosed.Click

        DAUser.UpdateLockUser(0, getCurrentUserID)
        Application.Exit()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AddUserControl(MainPanel, HomeDashBoard, "", True)
    End Sub

    Private Sub BtnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogout.Click

        DAUser.UpdateLockUser(0, getCurrentUserID)
        Me.Close()
        Me.Dispose()
        'Dim FrmLogin As New Login
        'FrmLogin.txtUserName.Text = ""
        'FrmLogin.txtPassword.Text = ""
        'FrmLogin.Show()
        FLogIn.txtUserName.Text = ""
        FLogIn.txtPassword.Text = ""
        Me.FLogIn.Show()
    End Sub

    Private Sub MainInventoyV2_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'DAUser.UpdateLockUser(0, getCurrentUserID)
        'Application.Exit()
    End Sub
End Class