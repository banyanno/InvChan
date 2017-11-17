<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMoreProductSale
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridProductList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddMoreProductSale))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtnAddProduct = New System.Windows.Forms.Button
        Me.GridProductList = New Janus.Windows.GridEX.GridEX
        Me.txtSearchProduct = New System.Windows.Forms.TextBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LblTHBTotal = New System.Windows.Forms.Label
        Me.LblUSDTotal = New System.Windows.Forms.Label
        Me.LblKHRTotal = New System.Windows.Forms.Label
        Me.LblInvoiceNo = New System.Windows.Forms.Label
        Me.TxtProductName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ChQTYFree = New System.Windows.Forms.CheckBox
        Me.GroupQTYFree = New System.Windows.Forms.GroupBox
        Me.cboUnitFree = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtQTYFree = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.LblCurrency = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LblSub = New System.Windows.Forms.Label
        Me.LblMainStcok = New System.Windows.Forms.Label
        Me.TxtSubStock = New System.Windows.Forms.TextBox
        Me.TxtMainStock = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TxtDiscount = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboUnit = New System.Windows.Forms.ComboBox
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CboCurrency = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridProductList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupQTYFree.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnAddProduct)
        Me.GroupBox3.Controls.Add(Me.GridProductList)
        Me.GroupBox3.Controls.Add(Me.txtSearchProduct)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 1)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(307, 437)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Product Name:"
        '
        'BtnAddProduct
        '
        Me.BtnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddProduct.Location = New System.Drawing.Point(256, 15)
        Me.BtnAddProduct.Name = "BtnAddProduct"
        Me.BtnAddProduct.Size = New System.Drawing.Size(49, 36)
        Me.BtnAddProduct.TabIndex = 4
        Me.BtnAddProduct.Text = "..."
        Me.BtnAddProduct.UseVisualStyleBackColor = True
        '
        'GridProductList
        '
        Me.GridProductList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridProductList_DesignTimeLayout.LayoutString = resources.GetString("GridProductList_DesignTimeLayout.LayoutString")
        Me.GridProductList.DesignTimeLayout = GridProductList_DesignTimeLayout
        Me.GridProductList.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.GridProductList.GroupByBoxVisible = False
        Me.GridProductList.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridProductList.Location = New System.Drawing.Point(2, 56)
        Me.GridProductList.Margin = New System.Windows.Forms.Padding(2)
        Me.GridProductList.Name = "GridProductList"
        Me.GridProductList.RecordNavigator = True
        Me.GridProductList.Size = New System.Drawing.Size(303, 379)
        Me.GridProductList.TabIndex = 3
        '
        'txtSearchProduct
        '
        Me.txtSearchProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSearchProduct.Font = New System.Drawing.Font("Kh Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchProduct.Location = New System.Drawing.Point(2, 15)
        Me.txtSearchProduct.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearchProduct.Name = "txtSearchProduct"
        Me.txtSearchProduct.Size = New System.Drawing.Size(249, 37)
        Me.txtSearchProduct.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.Blue
        Me.btnAdd.Location = New System.Drawing.Point(563, 443)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(82, 32)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.Blue
        Me.btnCancel.Location = New System.Drawing.Point(653, 443)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(82, 32)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblTHBTotal)
        Me.GroupBox1.Controls.Add(Me.LblUSDTotal)
        Me.GroupBox1.Controls.Add(Me.LblKHRTotal)
        Me.GroupBox1.Controls.Add(Me.LblInvoiceNo)
        Me.GroupBox1.Controls.Add(Me.TxtProductName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ChQTYFree)
        Me.GroupBox1.Controls.Add(Me.GroupQTYFree)
        Me.GroupBox1.Controls.Add(Me.LblCurrency)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.TxtDiscount)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cboUnit)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CboCurrency)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(316, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 436)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Info"
        '
        'LblTHBTotal
        '
        Me.LblTHBTotal.AutoSize = True
        Me.LblTHBTotal.Location = New System.Drawing.Point(370, 187)
        Me.LblTHBTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTHBTotal.Name = "LblTHBTotal"
        Me.LblTHBTotal.Size = New System.Drawing.Size(13, 13)
        Me.LblTHBTotal.TabIndex = 30
        Me.LblTHBTotal.Text = "0"
        Me.LblTHBTotal.Visible = False
        '
        'LblUSDTotal
        '
        Me.LblUSDTotal.AutoSize = True
        Me.LblUSDTotal.Location = New System.Drawing.Point(302, 204)
        Me.LblUSDTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblUSDTotal.Name = "LblUSDTotal"
        Me.LblUSDTotal.Size = New System.Drawing.Size(13, 13)
        Me.LblUSDTotal.TabIndex = 29
        Me.LblUSDTotal.Text = "0"
        Me.LblUSDTotal.Visible = False
        '
        'LblKHRTotal
        '
        Me.LblKHRTotal.AutoSize = True
        Me.LblKHRTotal.Location = New System.Drawing.Point(296, 176)
        Me.LblKHRTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblKHRTotal.Name = "LblKHRTotal"
        Me.LblKHRTotal.Size = New System.Drawing.Size(13, 13)
        Me.LblKHRTotal.TabIndex = 28
        Me.LblKHRTotal.Text = "0"
        Me.LblKHRTotal.Visible = False
        '
        'LblInvoiceNo
        '
        Me.LblInvoiceNo.AutoSize = True
        Me.LblInvoiceNo.Location = New System.Drawing.Point(398, 101)
        Me.LblInvoiceNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblInvoiceNo.Name = "LblInvoiceNo"
        Me.LblInvoiceNo.Size = New System.Drawing.Size(13, 13)
        Me.LblInvoiceNo.TabIndex = 27
        Me.LblInvoiceNo.Text = "0"
        Me.LblInvoiceNo.Visible = False
        '
        'TxtProductName
        '
        Me.TxtProductName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtProductName.Font = New System.Drawing.Font("Kh Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProductName.Location = New System.Drawing.Point(98, 28)
        Me.TxtProductName.Name = "TxtProductName"
        Me.TxtProductName.ReadOnly = True
        Me.TxtProductName.Size = New System.Drawing.Size(276, 37)
        Me.TxtProductName.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Product Name:"
        '
        'ChQTYFree
        '
        Me.ChQTYFree.AutoSize = True
        Me.ChQTYFree.ForeColor = System.Drawing.Color.Red
        Me.ChQTYFree.Location = New System.Drawing.Point(207, 223)
        Me.ChQTYFree.Margin = New System.Windows.Forms.Padding(2)
        Me.ChQTYFree.Name = "ChQTYFree"
        Me.ChQTYFree.Size = New System.Drawing.Size(66, 17)
        Me.ChQTYFree.TabIndex = 24
        Me.ChQTYFree.Text = "Qty Free"
        Me.ChQTYFree.UseVisualStyleBackColor = True
        '
        'GroupQTYFree
        '
        Me.GroupQTYFree.Controls.Add(Me.cboUnitFree)
        Me.GroupQTYFree.Controls.Add(Me.Label16)
        Me.GroupQTYFree.Controls.Add(Me.TxtQTYFree)
        Me.GroupQTYFree.Controls.Add(Me.Label15)
        Me.GroupQTYFree.Enabled = False
        Me.GroupQTYFree.Location = New System.Drawing.Point(202, 224)
        Me.GroupQTYFree.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupQTYFree.Name = "GroupQTYFree"
        Me.GroupQTYFree.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupQTYFree.Size = New System.Drawing.Size(172, 98)
        Me.GroupQTYFree.TabIndex = 23
        Me.GroupQTYFree.TabStop = False
        '
        'cboUnitFree
        '
        Me.cboUnitFree.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.cboUnitFree.FormattingEnabled = True
        Me.cboUnitFree.Location = New System.Drawing.Point(51, 59)
        Me.cboUnitFree.Margin = New System.Windows.Forms.Padding(2)
        Me.cboUnitFree.Name = "cboUnitFree"
        Me.cboUnitFree.Size = New System.Drawing.Size(98, 30)
        Me.cboUnitFree.TabIndex = 26
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Kh Battambang", 7.8!)
        Me.Label16.Location = New System.Drawing.Point(9, 65)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 19)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "ឯកក្តា:"
        '
        'TxtQTYFree
        '
        Me.TxtQTYFree.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtQTYFree.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQTYFree.Location = New System.Drawing.Point(50, 23)
        Me.TxtQTYFree.Name = "TxtQTYFree"
        Me.TxtQTYFree.Size = New System.Drawing.Size(99, 26)
        Me.TxtQTYFree.TabIndex = 22
        Me.TxtQTYFree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 33)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Qty:"
        '
        'LblCurrency
        '
        Me.LblCurrency.AutoSize = True
        Me.LblCurrency.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCurrency.Location = New System.Drawing.Point(346, 350)
        Me.LblCurrency.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCurrency.Name = "LblCurrency"
        Me.LblCurrency.Size = New System.Drawing.Size(17, 22)
        Me.LblCurrency.TabIndex = 20
        Me.LblCurrency.Text = "0"
        Me.LblCurrency.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Kh Battambang", 7.8!)
        Me.Label14.Location = New System.Drawing.Point(37, 198)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 19)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "ឯកក្តា:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblSub)
        Me.GroupBox2.Controls.Add(Me.LblMainStcok)
        Me.GroupBox2.Controls.Add(Me.TxtSubStock)
        Me.GroupBox2.Controls.Add(Me.TxtMainStock)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Font = New System.Drawing.Font("Kh Battambang", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 77)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(366, 92)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Current Stock:"
        '
        'LblSub
        '
        Me.LblSub.AutoSize = True
        Me.LblSub.Location = New System.Drawing.Point(226, 63)
        Me.LblSub.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSub.Name = "LblSub"
        Me.LblSub.Size = New System.Drawing.Size(46, 19)
        Me.LblSub.TabIndex = 3
        Me.LblSub.Text = "Label16"
        '
        'LblMainStcok
        '
        Me.LblMainStcok.AutoSize = True
        Me.LblMainStcok.Location = New System.Drawing.Point(226, 28)
        Me.LblMainStcok.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblMainStcok.Name = "LblMainStcok"
        Me.LblMainStcok.Size = New System.Drawing.Size(46, 19)
        Me.LblMainStcok.TabIndex = 2
        Me.LblMainStcok.Text = "Label15"
        '
        'TxtSubStock
        '
        Me.TxtSubStock.BackColor = System.Drawing.Color.White
        Me.TxtSubStock.Enabled = False
        Me.TxtSubStock.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSubStock.ForeColor = System.Drawing.Color.Red
        Me.TxtSubStock.Location = New System.Drawing.Point(109, 59)
        Me.TxtSubStock.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSubStock.Name = "TxtSubStock"
        Me.TxtSubStock.Size = New System.Drawing.Size(114, 26)
        Me.TxtSubStock.TabIndex = 1
        Me.TxtSubStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtMainStock
        '
        Me.TxtMainStock.BackColor = System.Drawing.Color.White
        Me.TxtMainStock.Enabled = False
        Me.TxtMainStock.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMainStock.ForeColor = System.Drawing.Color.Red
        Me.TxtMainStock.Location = New System.Drawing.Point(109, 24)
        Me.TxtMainStock.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtMainStock.Name = "TxtMainStock"
        Me.TxtMainStock.Size = New System.Drawing.Size(114, 26)
        Me.TxtMainStock.TabIndex = 0
        Me.TxtMainStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 63)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 19)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "ចំនួនរាយក្នុង Stock:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 28)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 19)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "ចំនួនដុំក្នុង Stock:"
        '
        'TxtDiscount
        '
        Me.TxtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiscount.Location = New System.Drawing.Point(368, 336)
        Me.TxtDiscount.Name = "TxtDiscount"
        Me.TxtDiscount.Size = New System.Drawing.Size(43, 26)
        Me.TxtDiscount.TabIndex = 7
        Me.TxtDiscount.Text = "0"
        Me.TxtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtDiscount.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(377, 318)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Discount:"
        Me.Label11.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(186, 314)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(186, 284)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(186, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(186, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "*"
        '
        'cboUnit
        '
        Me.cboUnit.BackColor = System.Drawing.Color.White
        Me.cboUnit.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnit.Location = New System.Drawing.Point(79, 192)
        Me.cboUnit.Name = "cboUnit"
        Me.cboUnit.Size = New System.Drawing.Size(99, 30)
        Me.cboUnit.TabIndex = 2
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.Color.White
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.ForeColor = System.Drawing.Color.Red
        Me.txtAmount.Location = New System.Drawing.Point(79, 347)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(264, 29)
        Me.txtAmount.TabIndex = 6
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 357)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total Price:"
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(79, 308)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(99, 26)
        Me.txtQty.TabIndex = 5
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.White
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.ForeColor = System.Drawing.Color.Black
        Me.txtPrice.Location = New System.Drawing.Point(79, 273)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(99, 26)
        Me.txtPrice.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Price"
        '
        'CboCurrency
        '
        Me.CboCurrency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCurrency.FormattingEnabled = True
        Me.CboCurrency.Location = New System.Drawing.Point(79, 234)
        Me.CboCurrency.Name = "CboCurrency"
        Me.CboCurrency.Size = New System.Drawing.Size(98, 28)
        Me.CboCurrency.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kh Battambang", 7.8!)
        Me.Label3.Location = New System.Drawing.Point(9, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ប្រភេទប្រាក់:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 318)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "QTY:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'AddMoreProductSale
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 478)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddMoreProductSale"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.GridProductList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupQTYFree.ResumeLayout(False)
        Me.GroupQTYFree.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GridProductList As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtSearchProduct As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChQTYFree As System.Windows.Forms.CheckBox
    Friend WithEvents GroupQTYFree As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtQTYFree As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LblCurrency As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LblSub As System.Windows.Forms.Label
    Friend WithEvents LblMainStcok As System.Windows.Forms.Label
    Friend WithEvents TxtSubStock As System.Windows.Forms.TextBox
    Friend WithEvents TxtMainStock As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboUnit As System.Windows.Forms.ComboBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboCurrency As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents LblTHBTotal As System.Windows.Forms.Label
    Friend WithEvents LblUSDTotal As System.Windows.Forms.Label
    Friend WithEvents LblKHRTotal As System.Windows.Forms.Label
    Friend WithEvents cboUnitFree As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAddProduct As System.Windows.Forms.Button
End Class
