Public Class MainDashBaord
    Dim Main As MainInventoyV2

    'Init UI
    Dim DProductSale As New DashboardProductSale
    Dim DPuchaseOrder As New DashboardPurchaseOrder
    Dim DProduct As New DashboardItems
    Dim DCategory As New DashboardCategory
    Dim DSupplier As New DashboardSupplier
    Dim DCustomer As New DashboardCustomers
    Dim DAccountReceivable As New DashboardAccountReceivable
    Dim DAccountPayable As New DashboradAccoudPayable
    Dim DSRevenues As New DashbordRevenue
    Dim URight As New UC_AccessRight
    Dim UUser As New UC_User
    Dim DAAdjustment As New DashboardAdjustStock
    Dim DMeasurement As New DashboardMeasurement
    Dim DAUserRight As New DSProductsTableAdapters.USER_RIGHTTableAdapter
    Dim DAUser As New DSItemTableAdapters.USERTableAdapter

    Sub New(ByVal Main As MainInventoyV2)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Main = Main
        LoadingComProfile()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub CheckAccessRight()
        If DAUser.SelectUserByID(getCurrentUserID).Rows(0).Item("USER_GROUP") = "Administrator" Then
            BtnSale.Enabled = True
            BtnProductOrder.Enabled = True
            BtnCustomer.Enabled = True
            BtnSupplyer.Enabled = True
            BtnTransact.Enabled = True
            BtnRevenue.Enabled = True
            BtnProducts.Enabled = True
            BtnMeaser.Enabled = True
            BtnCategory.Enabled = True
            BtnAccessRight.Enabled = True
            btnuser.Enabled = True
            BtnAccReAble.Enabled = True
            BtnPayAble.Enabled = True
        Else
            Dim TblRigh As DataTable = DAUserRight.SelectUserPermistion(getCurrentUserID)
            For Each rowRight As DataRow In TblRigh.Rows
                If BtnSale.Text = rowRight("ACCESS_NAME") Then
                    BtnSale.Enabled = True
                End If
                If BtnProductOrder.Text = rowRight("ACCESS_NAME") Then
                    BtnProductOrder.Enabled = True
                End If
                If BtnCustomer.Text = rowRight("ACCESS_NAME") Then
                    BtnCustomer.Enabled = True
                End If
                If BtnSupplyer.Text = rowRight("ACCESS_NAME") Then
                    BtnSupplyer.Enabled = True
                End If

                If BtnTransact.Text = rowRight("ACCESS_NAME") Then
                    BtnTransact.Enabled = True
                End If
                If BtnRevenue.Text = rowRight("ACCESS_NAME") Then
                    BtnRevenue.Enabled = True
                End If
                If BtnProducts.Text = rowRight("ACCESS_NAME") Then
                    BtnProducts.Enabled = True
                End If
                If BtnMeaser.Text = rowRight("ACCESS_NAME") Then
                    BtnMeaser.Enabled = True
                End If

                If BtnCategory.Text = rowRight("ACCESS_NAME") Then
                    BtnCategory.Enabled = True
                End If

                If BtnAccessRight.Text = rowRight("ACCESS_NAME") Then
                    BtnAccessRight.Enabled = True
                End If
                If btnuser.Text = rowRight("ACCESS_NAME") Then
                    btnuser.Enabled = True
                End If
                If BtnAccReAble.Text = rowRight("ACCESS_NAME") Then
                    BtnAccReAble.Enabled = True
                End If
                If BtnPayAble.Text = rowRight("ACCESS_NAME") Then
                    BtnPayAble.Enabled = True
                End If
            Next
        End If
        
    End Sub
    Sub AddUserControl(ByVal PanelMain As Panel, ByVal UI As UserControl, ByVal Info As String)
        Me.Cursor = Cursors.WaitCursor
        PanelMain.Controls.Clear()
        PanelMain.AutoScroll = True
        'PMainContainer.AutoScrollMinSize = New Size(UI.Width, UI.Height)
        UI.Dock = DockStyle.Fill
        PanelMain.Controls.Add(UI)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BtnSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSale.Click
        AddUserControl(Main.MainPanel, DProductSale, "")
        Main.Panel1.Visible = False
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        DAUser.UpdateLockUser(0, getCurrentUserID)
        Application.Exit()
    End Sub

    Private Sub BtnProductOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProductOrder.Click
        AddUserControl(Main.MainPanel, DPuchaseOrder, "Purchase Order បញ្ជាទិញ")
        Main.Panel1.Visible = False
    End Sub

    Private Sub BtnProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProducts.Click
        AddUserControl(Main.MainPanel, DProduct, "")
        Main.Panel1.Visible = False
    End Sub

    Private Sub BtnCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCategory.Click
        AddUserControl(Main.MainPanel, DCategory, "")
        Main.Panel1.Visible = False
    End Sub

    Private Sub BtnSupplyer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupplyer.Click
        AddUserControl(Main.MainPanel, DSupplier, "")
        Main.Panel1.Visible = False
    End Sub

    Private Sub BtnCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCustomer.Click
        AddUserControl(Main.MainPanel, DCustomer, "")
        Main.Panel1.Visible = False
    End Sub

    Private Sub BtnAccReAble_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAccReAble.Click
        AddUserControl(Main.MainPanel, DAccountReceivable, "")
        Main.Panel1.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPayAble.Click
        AddUserControl(Main.MainPanel, DAccountPayable, "")
        Main.Panel1.Visible = False
    End Sub

    Private Sub BtnRevenue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRevenue.Click
        'AddUserControl(Main.MainPanel, DSRevenues, "")
        'Main.Panel1.Visible = False
        Dim FExRate As New FormExchangeRate
        FExRate.ShowDialog()
    End Sub

    Private Sub BtnAccessRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAccessRight.Click
        AddUserControl(Main.MainPanel, URight, "")
        Main.Panel1.Visible = False
    End Sub

    Private Sub btnuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnuser.Click
        AddUserControl(Main.MainPanel, UUser, "")
        Main.Panel1.Visible = False
    End Sub

    Private Sub BtnTransact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTransact.Click
        AddUserControl(Main.MainPanel, DAAdjustment, "")
        Main.Panel1.Visible = False
    End Sub

    Private Sub BtnMeaser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMeaser.Click
        AddUserControl(Main.MainPanel, DMeasurement, "")
        Main.Panel1.Visible = False
    End Sub

    Private Sub MainDashBaord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        CheckAccessRight()
        LoadingProfile()
    End Sub
    Private Sub LoadingProfile()
        LblComProfile.Text = "Dev By : KTG Team" & _
vbCrLf & "Tel        : 012 238 738" & _
vbCrLf & "Email:  ban.yanno@gmail.com" & _
vbCrLf & "All right reserved copyright by Mr.BAN YANNO" & _
vbCrLf & "អាជ្ញាប័ណ្ណ Software ជូន" & _
vbCrLf & _
vbCrLf & GetComName() & _
vbCrLf & GetComAddress()

    End Sub

    Private Sub BtnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim FrmLogin As New Login
        FrmLogin.txtUserName.Text = ""
        FrmLogin.txtPassword.Text = ""
        Login.Show()
    End Sub

    Private Sub BtnComProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnComProfile.Click
        Dim FProfile As New FormCompanyProfile
        FProfile.ShowDialog()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = Now
    End Sub
End Class
