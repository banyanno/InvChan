Public Class Item_Store
    'Declare the variables
    Dim DAStore As New DSItemTableAdapters.ITEM_STORETableAdapter
    Dim DAItem As New DSItemTableAdapters.ITEMTableAdapter
    Dim DACategory As New DSItemTableAdapters.CATEGORYTableAdapter
    Dim DAUnit As New DSItemTableAdapters.UNITTableAdapter
    Dim PStore As UC_Store

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Sub New(ByVal MyPanel As UC_Store)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PStore = MyPanel

        Me.cboCategory.DataSource = DACategory.SelectCategories
        Me.cboCategory.ValueMember = "CATE_ID"
        Me.cboCategory.DisplayMember = "CATE_NAME_CHN"

        Me.CboItemChnName.DataSource = DAItem.SelectItems
        Me.CboItemChnName.DisplayMember = "ITEM_NAME_CHN"
        Me.CboItemChnName.ValueMember = "ITEM_ID"

        Me.CboUnitChnName.DataSource = DAUnit.SelectUnits
        Me.CboUnitChnName.DisplayMember = "UNIT_NAME_CHN"
        Me.CboUnitChnName.ValueMember = "UNIT_ID"

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

    Private Sub lblHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHeader.Click

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim DAReceive As New DSItemTableAdapters.RECEIVETableAdapter
        Dim DATransaction As New DSItemTableAdapters.TRANSACTIONTableAdapter
        If Me.txtRatioQty.Text = "" Then
            MsgBox("Please enter Ratio Qty", MsgBoxStyle.Information)
            Me.txtRatioQty.Focus()
            Exit Sub
        Else
            If IsNumeric(Me.txtRatioQty.Text) = False Then
                MsgBox("Please enter Ratio Qty as number only", MsgBoxStyle.Information)
                Me.txtRatioQty.Focus()
                Me.txtRatioQty.SelectAll()
                Exit Sub
            End If
        End If

        If Me.txtBalance.Text = "" Then
            MsgBox("Please enter Balance", MsgBoxStyle.Information)
            Me.txtBalance.Focus()
            Exit Sub
        Else
            If IsNumeric(Me.txtBalance.Text) = False Then
                MsgBox("Please enter Balance as number only", MsgBoxStyle.Information)
                Me.txtBalance.Focus()
                Me.txtBalance.SelectAll()
                Exit Sub
            End If
        End If
        If Me.CboUnitChnName.Text = "" Then
            MsgBox("Please select unit", MsgBoxStyle.Information)
            Me.CboUnitChnName.Focus()
            Exit Sub
        End If
        If Me.txtCost.Text = "" Then
            MsgBox("Please enter Last Cost", MsgBoxStyle.Information)
            Me.txtCost.Focus()
            Exit Sub
        Else
            If IsNumeric(Me.txtCost.Text) = False Then
                MsgBox("Please enter Last Cost as number only", MsgBoxStyle.Information)
                Me.txtCost.Focus()
                Me.txtCost.SelectAll()
                Exit Sub
            End If
        End If
        If Me.txtPrice.Text = "" Then
            MsgBox("Please enter Price", MsgBoxStyle.Information)
            Me.txtPrice.Focus()
            Exit Sub
        Else
            If IsNumeric(Me.txtPrice.Text) = False Then
                MsgBox("Please enter Price as number only", MsgBoxStyle.Information)
                Me.txtPrice.Focus()
                Me.txtPrice.SelectAll()
                Exit Sub
            End If
        End If
        Dim ItemID As Integer = CInt(Me.CboItemChnName.SelectedValue)
        Dim UnitID As Integer = CInt(Me.CboUnitChnName.SelectedValue)
        Dim RatioQty As Integer = CInt(Me.txtRatioQty.Text)
        Dim Balance As Double = CDbl(Me.txtBalance.Text)
        Dim Cost As Double = CDbl(Me.txtCost.Text)
        Dim Price As Double = CDbl(Me.txtPrice.Text)
        Dim CateName = GetCategoryNameByID(DAItem.SelectItemByID(ItemID).Rows(0).Item("CATE_ID"))

        If Me.lblstatus.Text = 1 Then
            'INSERT
            If DAStore.ExistingStore(ItemID, UnitID) >= 1 Then
                MsgBox("This store already exists", MsgBoxStyle.Information)
                Exit Sub
            End If

            If DAStore.ExistingStore(ItemID, UnitID) >= 1 Then
                MsgBox("This item store already exists", MsgBoxStyle.Information)
                Exit Sub
            Else
                Dim StoreID As Integer
                Dim MaxReceiveID As Long
                DAStore.InsertStore(ItemID, CateName, UnitID, RatioQty, Price, Cost, Balance)
                StoreID = GetStoreID(ItemID, UnitID)
                DAReceive.InsertReceive(StoreID, 1, Balance, Cost, "New Store", FormatDateTime(Now, DateFormat.ShortDate), getCurrentUserID)
                '' Add to Transaction
                MaxReceiveID = DAReceive.getMaxID
                DATransaction.InsertTransaction(StoreID, 0, Balance, Balance, MaxReceiveID, 1, 1, FormatDateTime(Now, DateFormat.ShortDate), getCurrentUserID)
                MsgBox("Store added", MsgBoxStyle.Information)
                ClearBox()
                Me.txtRatioQty.Text = 1
                PStore.RefreshList()
            End If
        Else
            'UPDATE
            DAStore.UpdateStore(ItemID, CateName, UnitID, RatioQty, Price, Cost, Balance, PStore.StoreList.CurrentRow.Cells("STOR_ID").Value)
            MsgBox("Store updated", MsgBoxStyle.Information)
            ClearBox()
            PStore.RefreshList()
            Me.Close()
        End If
        If Me.chkBarcode.Checked = True Then
            Me.txtBarcode.Text = ""
            Me.txtBarcode.Focus()
        End If
    End Sub
    Sub ClearBox()
        Me.txtBalance.Text = 0
        Me.txtRatioQty.Text = ""
        Me.txtCost.Text = ""
    End Sub

    Private Sub cboCategory_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCategory.SelectionChangeCommitted
        Me.CboItemChnName.DataSource = DAItem.SelectByCategoryID(CInt(Me.cboCategory.SelectedValue))
        Me.CboItemChnName.DisplayMember = "ITEM_NAME_CHN"
        Me.CboItemChnName.ValueMember = "ITEM_ID"
    End Sub

    Private Sub CboUnitChnName_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboUnitChnName.SelectionChangeCommitted
        CboUnit_Change()
    End Sub
    Sub CboUnit_Change()
        If DAStore.SelectStoreID(CInt(Me.CboItemChnName.SelectedValue), CInt(Me.CboUnitChnName.SelectedValue)).Rows.Count >= 1 Then
            Dim StoreID As Integer = GetStoreID(CInt(Me.CboItemChnName.SelectedValue), CInt(Me.CboUnitChnName.SelectedValue))
            Me.txtBalance.Text = DAStore.SelectStoreByID(StoreID).Rows(0).Item("ITEM_BALANCE")
            Me.txtCost.Text = DAStore.SelectStoreByID(StoreID).Rows(0).Item("LAST_COST")
        End If
    End Sub

    Private Sub CboItemChnName_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboItemChnName.SelectionChangeCommitted
        CboItem_Changed()
    End Sub

    Private Sub chkBarcode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBarcode.CheckedChanged
        If Me.chkBarcode.Checked Then
            Me.txtBarcode.Visible = True
            Me.txtBarcode.Text = ""
            Me.txtBarcode.Focus()
        Else
            Me.txtBarcode.Visible = False
        End If
    End Sub
    Sub CboItem_Changed()
        Me.txtBalance.Text = ""
        Me.txtCost.Text = ""
        Dim UnitTable As New DataTable
        UnitTable = DAStore.SelectStoreByItemID(CInt(Me.CboItemChnName.SelectedValue))
        If UnitTable.Rows.Count >= 1 Then
            Me.CboUnitChnName.SelectedValue = UnitTable.Rows(0).Item("UNIT_ID")
            If DAStore.SelectStoreID(CInt(Me.CboItemChnName.SelectedValue), CInt(Me.CboUnitChnName.SelectedValue)).Rows.Count >= 1 Then
                Dim StoreID As Integer = GetStoreID(CInt(Me.CboItemChnName.SelectedValue), CInt(Me.CboUnitChnName.SelectedValue))
                Me.txtBalance.Text = DAStore.SelectStoreByID(StoreID).Rows(0).Item("ITEM_BALANCE")
                Me.txtCost.Text = DAStore.SelectStoreByID(StoreID).Rows(0).Item("LAST_COST")
                Me.txtBalance.Focus()
            End If
            MsgBox("This item store already exists.", MsgBoxStyle.Information)
        End If


        Dim ItemTable As New DataTable
        ItemTable = DAItem.SelectItemByID(CInt(Me.CboItemChnName.SelectedValue))
        If ItemTable.Rows.Count >= 1 Then
            If IsDBNull(ItemTable.Rows(0).Item("ITEM_IMAGE")) = False Then
                Dim MS As New IO.MemoryStream(CType(ItemTable.Rows(0).Item("ITEM_IMAGE"), Byte()))
                Dim img As Image = Image.FromStream(MS)
                Me.PicItem.Image = img
            End If
        End If
        Me.CboUnitChnName.Focus()
    End Sub
    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        If Me.txtBarcode.Text <> "" Then
            If Asc(e.KeyChar) = 13 Then
                If DAItem.ExistingBarcode(Me.txtBarcode.Text) >= 1 Then
                    Dim ItemTable As New DataTable
                    ItemTable = DAItem.SelectItemByBarcode(Me.txtBarcode.Text)
                    Me.cboCategory.SelectedValue = ItemTable.Rows(0).Item("CATE_ID")
                    cboCategory_SelectionChangeCommitted(sender, e)
                    Me.CboItemChnName.SelectedValue = ItemTable.Rows(0).Item("ITEM_ID")
                    CboItem_Changed()
                    Me.txtBalance.Focus()
                Else
                    MsgBox("No such item barcode, please try again", MsgBoxStyle.Exclamation)
                    Me.txtBarcode.Focus()
                    Me.txtBarcode.SelectAll()
                End If
            End If
        End If
    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged

    End Sub

    Private Sub CboItemChnName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboItemChnName.SelectedIndexChanged

    End Sub
End Class