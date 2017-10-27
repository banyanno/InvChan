Public Class EnterBarcode
    Dim FNewSale As NewSale
    Dim _KhmerInput As InputLanguage
    Dim _englishInput As InputLanguage
    Dim DAPreInvoice As New DSInventoryTableAdapters.PRE_INVOICE_DETAILSTableAdapter
    Sub New(ByVal FNewSale As NewSale)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.FNewSale = FNewSale
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    

    Private Sub TxtBarCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtBarCode.GotFocus
        SetEnglishLanguage()
    End Sub
    Dim tbl As DataTable
    Private Sub TxtBarCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBarCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            
            tbl = DAItem.SelectByBarCode(TxtBarCode.Text)
            For Each rows As DataRow In tbl.Rows
                TxtProducName.Text = rows("ITEM_NAME")
                TxtPrice.Text = CDbl(rows("RETAIL_PRICE"))
            Next
            

        End If
    End Sub
    Dim DAItem As New DSInventoryTableAdapters.CentralStoreTableAdapter
    Private Sub EnterBarcode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtBarCode.Focus()
        TxtBarCode.SelectAll()
        
       
    End Sub

    Private Sub EnterBarcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            If ValidateTextField(TxtPrice, "", ErrAddProduct) = False Then
                TxtPrice.Focus()
                TxtPrice.SelectAll()
                Exit Sub
            End If
            If ValidateTextField(txtQTY, "", ErrAddProduct) = False Then
                txtQTY.Focus()
                txtQTY.SelectAll()
                Exit Sub
            End If


            For Each rows As DataRow In tbl.Rows


                Dim TblExistItem As DataTable = DAPreInvoice.ChExistPreInvoice(rows("ITEM_ID"), getCurrentUserID)
                If TblExistItem.Rows.Count > 0 Then
                    MessageBox.Show("Item already exist in list. Please check again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit For
                    'For Each rowsExit As DataRow In TblExistItem.Rows
                    '    Dim qty = rowsExit("QTY") + 1
                    '    Dim TotalPrice As Double = ((CDbl(rowsExit("PRICE"))) * qty)
                    '    DAPreInvoice.PreUpdateExistingItem(qty, CDbl(TotalPrice), rowsExit("ITEM_ID"), getCurrentUserID)
                    'Next
                Else
                    DAPreInvoice.InsertDetail(rows("ITEM_ID"), "", EmptyString(txtQTY.Text), EmptyString(TxtPrice.Text), 0, "$", 0, EmptyString(TxtPrice.Text), 0, getCurrentUserID, 0, "", False, CDbl(rows("USD_COST")))
                    'DAPreInvoice.InsertDetail(rows("ITEM_ID"), "", 1, CDbl(rows("RETAIL_PRICE")), 0, "$", 0, CDbl(rows("RETAIL_PRICE")), 0, getCurrentUserID, 0, "", False, CDbl(rows("USD_COST")))
                End If
            Next



            TxtBarCode.Focus()
            TxtBarCode.SelectAll()
            TxtBarCode.Text = ""
            TxtProducName.Text = ""
            TxtPrice.Text = ""
            txtQTY.Text = ""
            FNewSale.RefreshOrderList()
        End If
    End Sub

   
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

   
    Private Sub TxtPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrice.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub txtQTY_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQTY.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub EnterBarcode_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseHover
        TxtBarCode.Focus()
        TxtBarCode.SelectAll()
    End Sub
End Class