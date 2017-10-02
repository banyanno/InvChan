Public Class AdjustInventory
    Dim PAdjust As DashboardAdjustStock
    Dim DAAdjust As New DSStockTableAdapters.STOCK_ADJUSTMENTTableAdapter
    Dim DAItem As New DSInventoryTableAdapters.ITEMSTableAdapter
    Dim DABalance As New DSInventoryTableAdapters.ITEM_BALANCETableAdapter

    Dim DAIssue As New DSStockTableAdapters.STOCK_ISSUETableAdapter
    Dim DAIssueDetail As New DSStockTableAdapters.STOCK_ISSUE_DETAILTableAdapter

    Dim DAReceive As New DSStockTableAdapters.STOCK_RECEIVETableAdapter
    Dim DAReceiveDetail As New DSStockTableAdapters.STOCK_RECEIVE_DETAILTableAdapter
    Dim DATransaction As New DSStockTableAdapters.STOCK_TRANSACTIONTableAdapter
    Dim IS_RefreshDSAdjust As Boolean = False

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.CboProductName.DataSource = DAItem.SelectAllItems
        Me.CboProductName.DisplayMember = "ITEM_NAME"
        Me.CboProductName.ValueMember = "ITEM_ID"
        CboProductName.SelectedIndex = -1
        ' Add any initialization after the InitializeComponent() call.
        IS_RefreshDSAdjust = True
    End Sub
    Sub New(ByVal MyPanel As DashboardAdjustStock)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PAdjust = MyPanel

        Me.CboProductName.DataSource = DAItem.SelectAllItems
        Me.CboProductName.DisplayMember = "ITEM_NAME"
        Me.CboProductName.ValueMember = "ITEM_ID"
        CboProductName.SelectedIndex = -1
    End Sub

   

   

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateCombobox(CboProductName, "", ErrorProvider1) = False Then Exit Sub
        If ValidateDateTimePicker(dtAdjust, "", ErrorProvider1) = False Then Exit Sub


        If Me.txtnewmainstock.Text = "" Then
            Me.txtnewmainstock.Text = 0
        End If
        If Me.txtnewsubstock.Text = "" Then
            Me.txtnewsubstock.Text = 0
        End If
        If MessageBox.Show("Do you want to save stock adjustment?", "Adjust", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim ItemID As Integer = CInt(Me.CboProductName.SelectedValue)
            Dim MainStoreID As Integer = DABalance.SelectCurrentBalance(ItemID).Rows(0).Item("STORE_ID") 'SelectByItemAndUnitType(ItemID, "Main Unit").Rows(0).Item("STORE_ID")
            'Dim SubStoreID As Integer = DABalance.SelectByItemAndUnitType(ItemID, "Sub Unit").Rows(0).Item("STORE_ID")

            Dim OldMain As Double = CDbl(Me.TxtMainStock.Text)
            'Dim OldSub As Decimal = CDec(Me.TxtSubStock.Text)
            Dim NewMain As Double = CDbl(Me.txtnewmainstock.Text)
            ' Dim NewSub As Decimal = CDec(Me.txtnewsubstock.Text)

            '' About Main QTY
            If OldMain > NewMain Then
                ''Record as Issue
                DAIssue.InsertIssue("", "Adjustment", dtAdjust.Value.Date, getCurrentUserID)
                DAIssueDetail.InsertDetail(DAIssue.getMaxID, MainStoreID, ItemID, OldMain - NewMain)
                DATransaction.InsertTransaction(MainStoreID, ItemID, DAIssue.getMaxID, "ISSUE", OldMain, OldMain - NewMain, NewMain, dtAdjust.Value.Date, getCurrentUserID)
                DABalance.UpdateBalance(NewMain, MainStoreID)

            ElseIf OldMain < NewMain Then
                '' Record as Receive
                DAReceive.InsertReceive("", "Adjustment", dtAdjust.Value.Date, getCurrentUserID)
                DAReceiveDetail.InsertDetail(DAReceive.getMaxID, MainStoreID, ItemID, NewMain - OldMain)
                DATransaction.InsertTransaction(MainStoreID, ItemID, DAReceive.getMaxID, "RECEIVE", OldMain, NewMain - OldMain, NewMain, dtAdjust.Value.Date, getCurrentUserID)
                DABalance.UpdateBalance(NewMain, MainStoreID)
            End If

            ' '' About Sub QTY
            'If OldSub > NewSub Then
            '    ''Record as Issue
            '    DAIssue.InsertIssue("", "Adjustment", dtAdjust.Value, getCurrentUserID)
            '    DAIssueDetail.InsertDetail(DAIssue.getMaxID, SubStoreID, ItemID, OldSub - NewSub)
            '    DATransaction.InsertTransaction(SubStoreID, ItemID, DAIssue.getMaxID, "ISSUE", OldSub, OldSub - NewSub, NewSub, dtAdjust.Value.Date, getCurrentUserID)
            '    DABalance.UpdateBalance(NewSub, SubStoreID)
            'ElseIf OldSub < NewSub Then
            '    '' Record as Receive
            '    DAReceive.InsertReceive("", "Adjustment", dtAdjust.Value, getCurrentUserID)
            '    DAReceiveDetail.InsertDetail(DAReceive.getMaxID, SubStoreID, ItemID, NewSub - OldSub)
            '    DATransaction.InsertTransaction(SubStoreID, ItemID, DAReceive.getMaxID, "RECEIVE", OldSub, NewSub - OldSub, NewSub, dtAdjust.Value.Date, getCurrentUserID)
            '    DABalance.UpdateBalance(NewSub, SubStoreID)
            'End If
            If DAAdjust.InsertAdjustment(ItemID, OldMain, NewMain, 0, 0, Me.txtnote.Text.Replace("'", "''"), dtAdjust.Value.Date, getCurrentUserID) = 1 Then

                MsgBox("The store was adjusted", MsgBoxStyle.Information)
                If IS_RefreshDSAdjust = False Then
                    PAdjust.RefreshList()
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
            
        End If
        
    End Sub

    Private Sub txtnewmainstock_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnewmainstock.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub txtnewsubstock_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnewsubstock.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub CboProductName_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboProductName.SelectedValueChanged
        Try
            ' MsgBox(DABalance.SelectByItemAndUnitType(CInt(Me.CboProductName.SelectedValue), "Main Unit").Rows(0).Item("BALANCE"))
            Me.TxtMainStock.Text = DABalance.SelectCurrentBalance(CInt(Me.CboProductName.SelectedValue)).Rows(0).Item("BALANCE") 'SelectByItemAndUnitType(CInt(Me.CboProductName.SelectedValue), "Main Unit").Rows(0).Item("BALANCE")
            ' Me.TxtSubStock.Text = DABalance.SelectByItemAndUnitType(CInt(Me.CboProductName.SelectedValue), "Sub Unit").Rows(0).Item("BALANCE")

            Me.txtnewmainstock.Text = DABalance.SelectCurrentBalance(CInt(Me.CboProductName.SelectedValue)).Rows(0).Item("BALANCE")
            ' Me.txtnewsubstock.Text = DABalance.SelectByItemAndUnitType(CInt(Me.CboProductName.SelectedValue), "Sub Unit").Rows(0).Item("BALANCE")
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub AdjustInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CboProductName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboProductName.SelectedIndexChanged

    End Sub
End Class