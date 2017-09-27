<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProductSale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddProductSale))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictProduct = New System.Windows.Forms.PictureBox
        Me.TxtProductName = New System.Windows.Forms.TextBox
        Me.txtCost = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LblSub = New System.Windows.Forms.Label
        Me.LblMainStcok = New System.Windows.Forms.Label
        Me.TxtMainStock = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.LblCurrency = New System.Windows.Forms.Label
        Me.TxtSubStock = New System.Windows.Forms.TextBox
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.ChQTYFree = New System.Windows.Forms.CheckBox
        Me.GroupQTYFree = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtQTYFree = New System.Windows.Forms.TextBox
        Me.cboUnitFree = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxtDiscount = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboUnit = New System.Windows.Forms.ComboBox
        Me.CboCurrency = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.GridProductList = New Janus.Windows.GridEX.GridEX
        Me.txtSearchProduct = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupQTYFree.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridProductList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictProduct)
        Me.GroupBox1.Controls.Add(Me.TxtProductName)
        Me.GroupBox1.Controls.Add(Me.txtCost)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(422, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(518, 580)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Info"
        '
        'PictProduct
        '
        Me.PictProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictProduct.Location = New System.Drawing.Point(9, 365)
        Me.PictProduct.Name = "PictProduct"
        Me.PictProduct.Size = New System.Drawing.Size(243, 206)
        Me.PictProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictProduct.TabIndex = 27
        Me.PictProduct.TabStop = False
        '
        'TxtProductName
        '
        Me.TxtProductName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProductName.Font = New System.Drawing.Font("Kh Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProductName.Location = New System.Drawing.Point(173, 30)
        Me.TxtProductName.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TxtProductName.Name = "TxtProductName"
        Me.TxtProductName.ReadOnly = True
        Me.TxtProductName.Size = New System.Drawing.Size(314, 37)
        Me.TxtProductName.TabIndex = 26
        '
        'txtCost
        '
        Me.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCost.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!)
        Me.txtCost.Location = New System.Drawing.Point(173, 77)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(228, 27)
        Me.txtCost.TabIndex = 25
        Me.txtCost.Text = "0"
        Me.txtCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 27)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "ថ្លៃដើម:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 27)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Product Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblSub)
        Me.GroupBox2.Controls.Add(Me.LblMainStcok)
        Me.GroupBox2.Controls.Add(Me.TxtMainStock)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.LblCurrency)
        Me.GroupBox2.Controls.Add(Me.TxtSubStock)
        Me.GroupBox2.Controls.Add(Me.txtPrice)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtQty)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtAmount)
        Me.GroupBox2.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 108)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(500, 250)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Current Stock:"
        '
        'LblSub
        '
        Me.LblSub.AutoSize = True
        Me.LblSub.Location = New System.Drawing.Point(415, 223)
        Me.LblSub.Name = "LblSub"
        Me.LblSub.Size = New System.Drawing.Size(63, 27)
        Me.LblSub.TabIndex = 3
        Me.LblSub.Text = "Label16"
        Me.LblSub.Visible = False
        '
        'LblMainStcok
        '
        Me.LblMainStcok.AutoSize = True
        Me.LblMainStcok.Location = New System.Drawing.Point(398, 41)
        Me.LblMainStcok.Name = "LblMainStcok"
        Me.LblMainStcok.Size = New System.Drawing.Size(63, 27)
        Me.LblMainStcok.TabIndex = 2
        Me.LblMainStcok.Text = "Label15"
        Me.LblMainStcok.Visible = False
        '
        'TxtMainStock
        '
        Me.TxtMainStock.BackColor = System.Drawing.Color.White
        Me.TxtMainStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMainStock.Enabled = False
        Me.TxtMainStock.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMainStock.ForeColor = System.Drawing.Color.Red
        Me.TxtMainStock.Location = New System.Drawing.Point(164, 37)
        Me.TxtMainStock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtMainStock.Name = "TxtMainStock"
        Me.TxtMainStock.Size = New System.Drawing.Size(228, 37)
        Me.TxtMainStock.TabIndex = 0
        Me.TxtMainStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 27)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "ចំនួនក្នុង Stock:"
        '
        'LblCurrency
        '
        Me.LblCurrency.AutoSize = True
        Me.LblCurrency.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCurrency.Location = New System.Drawing.Point(119, 142)
        Me.LblCurrency.Name = "LblCurrency"
        Me.LblCurrency.Size = New System.Drawing.Size(17, 22)
        Me.LblCurrency.TabIndex = 20
        Me.LblCurrency.Text = "0"
        '
        'TxtSubStock
        '
        Me.TxtSubStock.BackColor = System.Drawing.Color.White
        Me.TxtSubStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSubStock.Enabled = False
        Me.TxtSubStock.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSubStock.ForeColor = System.Drawing.Color.Red
        Me.TxtSubStock.Location = New System.Drawing.Point(403, 127)
        Me.TxtSubStock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtSubStock.Name = "TxtSubStock"
        Me.TxtSubStock.Size = New System.Drawing.Size(170, 26)
        Me.TxtSubStock.TabIndex = 1
        Me.TxtSubStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtSubStock.Visible = False
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.White
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.ForeColor = System.Drawing.Color.Black
        Me.txtPrice.Location = New System.Drawing.Point(164, 84)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(228, 36)
        Me.txtPrice.TabIndex = 4
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 157)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ចំនួនលក់:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 93)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 27)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "តំលៃលក់ដុំ($):"
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.LightCoral
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty.Font = New System.Drawing.Font("Khmer OS Battambang", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(164, 142)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(228, 42)
        Me.txtQty.TabIndex = 5
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(399, 184)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 27)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "ចំនួនរាយក្នុង Stock:"
        Me.Label12.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(396, 157)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 27)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 205)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 27)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Sub Total Price($):"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(398, 93)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 27)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "*"
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.Color.White
        Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmount.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.ForeColor = System.Drawing.Color.Red
        Me.txtAmount.Location = New System.Drawing.Point(164, 196)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(228, 36)
        Me.txtAmount.TabIndex = 6
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ChQTYFree
        '
        Me.ChQTYFree.AutoSize = True
        Me.ChQTYFree.ForeColor = System.Drawing.Color.Red
        Me.ChQTYFree.Location = New System.Drawing.Point(1233, 422)
        Me.ChQTYFree.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ChQTYFree.Name = "ChQTYFree"
        Me.ChQTYFree.Size = New System.Drawing.Size(89, 31)
        Me.ChQTYFree.TabIndex = 24
        Me.ChQTYFree.Text = "Qty Free"
        Me.ChQTYFree.UseVisualStyleBackColor = True
        Me.ChQTYFree.Visible = False
        '
        'GroupQTYFree
        '
        Me.GroupQTYFree.Controls.Add(Me.Label16)
        Me.GroupQTYFree.Controls.Add(Me.TxtQTYFree)
        Me.GroupQTYFree.Controls.Add(Me.cboUnitFree)
        Me.GroupQTYFree.Controls.Add(Me.Label15)
        Me.GroupQTYFree.Enabled = False
        Me.GroupQTYFree.Location = New System.Drawing.Point(1226, 424)
        Me.GroupQTYFree.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupQTYFree.Name = "GroupQTYFree"
        Me.GroupQTYFree.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupQTYFree.Size = New System.Drawing.Size(255, 231)
        Me.GroupQTYFree.TabIndex = 23
        Me.GroupQTYFree.TabStop = False
        Me.GroupQTYFree.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Kh Battambang", 7.8!)
        Me.Label16.Location = New System.Drawing.Point(44, 125)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 19)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "ឯក្តា"
        '
        'TxtQTYFree
        '
        Me.TxtQTYFree.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtQTYFree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQTYFree.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQTYFree.Location = New System.Drawing.Point(93, 48)
        Me.TxtQTYFree.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TxtQTYFree.Name = "TxtQTYFree"
        Me.TxtQTYFree.Size = New System.Drawing.Size(148, 26)
        Me.TxtQTYFree.TabIndex = 22
        Me.TxtQTYFree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboUnitFree
        '
        Me.cboUnitFree.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnitFree.Location = New System.Drawing.Point(93, 112)
        Me.cboUnitFree.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cboUnitFree.Name = "cboUnitFree"
        Me.cboUnitFree.Size = New System.Drawing.Size(146, 30)
        Me.cboUnitFree.TabIndex = 24
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(44, 69)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 27)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Qty:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Kh Battambang", 7.8!)
        Me.Label14.Location = New System.Drawing.Point(1119, 719)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 19)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "ឯក្តា"
        Me.Label14.Visible = False
        '
        'TxtDiscount
        '
        Me.TxtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiscount.Location = New System.Drawing.Point(1318, 804)
        Me.TxtDiscount.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TxtDiscount.Name = "TxtDiscount"
        Me.TxtDiscount.Size = New System.Drawing.Size(62, 26)
        Me.TxtDiscount.TabIndex = 7
        Me.TxtDiscount.Text = "0"
        Me.TxtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtDiscount.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1370, 744)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 27)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Discount:"
        Me.Label11.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(1329, 723)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 27)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "*"
        Me.Label7.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(1359, 320)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 27)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "*"
        Me.Label6.Visible = False
        '
        'cboUnit
        '
        Me.cboUnit.BackColor = System.Drawing.Color.White
        Me.cboUnit.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnit.Location = New System.Drawing.Point(1168, 708)
        Me.cboUnit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cboUnit.Name = "cboUnit"
        Me.cboUnit.Size = New System.Drawing.Size(146, 30)
        Me.cboUnit.TabIndex = 2
        Me.cboUnit.Visible = False
        '
        'CboCurrency
        '
        Me.CboCurrency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCurrency.FormattingEnabled = True
        Me.CboCurrency.Location = New System.Drawing.Point(1198, 295)
        Me.CboCurrency.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CboCurrency.Name = "CboCurrency"
        Me.CboCurrency.Size = New System.Drawing.Size(145, 28)
        Me.CboCurrency.TabIndex = 3
        Me.CboCurrency.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kh Battambang", 7.8!)
        Me.Label3.Location = New System.Drawing.Point(1094, 307)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ប្រភេទប្រាក់:"
        Me.Label3.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.Blue
        Me.btnAdd.Location = New System.Drawing.Point(681, 585)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(123, 42)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.Blue
        Me.btnCancel.Location = New System.Drawing.Point(817, 585)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(123, 42)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtBarcode)
        Me.GroupBox3.Controls.Add(Me.GridProductList)
        Me.GroupBox3.Controls.Add(Me.txtSearchProduct)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 1)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(411, 581)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Product Name:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 98)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(110, 27)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "Product Name:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 30)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 27)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "Product Code:"
        '
        'txtBarcode
        '
        Me.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBarcode.Location = New System.Drawing.Point(8, 58)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(391, 36)
        Me.txtBarcode.TabIndex = 46
        '
        'GridProductList
        '
        Me.GridProductList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridProductList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        GridProductList_DesignTimeLayout.LayoutString = resources.GetString("GridProductList_DesignTimeLayout.LayoutString")
        Me.GridProductList.DesignTimeLayout = GridProductList_DesignTimeLayout
        Me.GridProductList.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
        Me.GridProductList.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.GridProductList.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridProductList.GroupByBoxVisible = False
        Me.GridProductList.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridProductList.Location = New System.Drawing.Point(3, 180)
        Me.GridProductList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridProductList.Name = "GridProductList"
        Me.GridProductList.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.GridProductList.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridProductList.RecordNavigator = True
        Me.GridProductList.Size = New System.Drawing.Size(393, 387)
        Me.GridProductList.TabIndex = 3
        Me.GridProductList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'txtSearchProduct
        '
        Me.txtSearchProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSearchProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchProduct.Font = New System.Drawing.Font("Kh Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchProduct.Location = New System.Drawing.Point(8, 129)
        Me.txtSearchProduct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSearchProduct.Name = "txtSearchProduct"
        Me.txtSearchProduct.Size = New System.Drawing.Size(393, 37)
        Me.txtSearchProduct.TabIndex = 2
        '
        'AddProductSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(948, 630)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ChQTYFree)
        Me.Controls.Add(Me.GroupQTYFree)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtDiscount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboUnit)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CboCurrency)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(0, 400)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddProductSale"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Product"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupQTYFree.ResumeLayout(False)
        Me.GroupQTYFree.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.GridProductList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cboUnit As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents CboCurrency As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtSubStock As System.Windows.Forms.TextBox
    Friend WithEvents TxtMainStock As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LblSub As System.Windows.Forms.Label
    Friend WithEvents LblMainStcok As System.Windows.Forms.Label
    Friend WithEvents LblCurrency As System.Windows.Forms.Label
    Friend WithEvents TxtQTYFree As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupQTYFree As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cboUnitFree As System.Windows.Forms.ComboBox
    Friend WithEvents ChQTYFree As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearchProduct As System.Windows.Forms.TextBox
    Friend WithEvents GridProductList As Janus.Windows.GridEX.GridEX
    Friend WithEvents TxtProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCost As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictProduct As System.Windows.Forms.PictureBox
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
