<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPurchaseOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPurchaseOrder))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblOrderNo = New System.Windows.Forms.Label
        Me.txtContain = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtProductName = New System.Windows.Forms.TextBox
        Me.GroupQTYFree = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtQTYFree = New System.Windows.Forms.TextBox
        Me.cboUnitFree = New System.Windows.Forms.ComboBox
        Me.ChQTYFree = New System.Windows.Forms.CheckBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cboUnit = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtTotalCost = New System.Windows.Forms.TextBox
        Me.LblTotalCost = New System.Windows.Forms.Label
        Me.txtQTY = New System.Windows.Forms.TextBox
        Me.txtCost = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CboCurrency = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.ErrProduct = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GridProductList = New Janus.Windows.GridEX.GridEX
        Me.txtSearchProduct = New System.Windows.Forms.TextBox
        Me.BtnAddProduct = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupQTYFree.SuspendLayout()
        CType(Me.ErrProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridProductList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblOrderNo)
        Me.GroupBox1.Controls.Add(Me.txtContain)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtProductName)
        Me.GroupBox1.Controls.Add(Me.GroupQTYFree)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cboUnit)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtTotalCost)
        Me.GroupBox1.Controls.Add(Me.LblTotalCost)
        Me.GroupBox1.Controls.Add(Me.txtQTY)
        Me.GroupBox1.Controls.Add(Me.txtCost)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CboCurrency)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(407, 1)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(512, 515)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Info"
        '
        'lblOrderNo
        '
        Me.lblOrderNo.AutoSize = True
        Me.lblOrderNo.Location = New System.Drawing.Point(25, 362)
        Me.lblOrderNo.Name = "lblOrderNo"
        Me.lblOrderNo.Size = New System.Drawing.Size(22, 29)
        Me.lblOrderNo.TabIndex = 3
        Me.lblOrderNo.Text = "0"
        Me.lblOrderNo.Visible = False
        '
        'txtContain
        '
        Me.txtContain.BackColor = System.Drawing.Color.White
        Me.txtContain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContain.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!)
        Me.txtContain.Location = New System.Drawing.Point(367, 77)
        Me.txtContain.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtContain.Name = "txtContain"
        Me.txtContain.ReadOnly = True
        Me.txtContain.Size = New System.Drawing.Size(135, 37)
        Me.txtContain.TabIndex = 29
        Me.txtContain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(299, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 29)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "ចំណុះ"
        '
        'TxtProductName
        '
        Me.TxtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProductName.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!)
        Me.TxtProductName.Location = New System.Drawing.Point(133, 33)
        Me.TxtProductName.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TxtProductName.Name = "TxtProductName"
        Me.TxtProductName.Size = New System.Drawing.Size(370, 36)
        Me.TxtProductName.TabIndex = 27
        '
        'GroupQTYFree
        '
        Me.GroupQTYFree.Controls.Add(Me.Label16)
        Me.GroupQTYFree.Controls.Add(Me.TxtQTYFree)
        Me.GroupQTYFree.Controls.Add(Me.cboUnitFree)
        Me.GroupQTYFree.Controls.Add(Me.ChQTYFree)
        Me.GroupQTYFree.Controls.Add(Me.Label15)
        Me.GroupQTYFree.Enabled = False
        Me.GroupQTYFree.Location = New System.Drawing.Point(381, 339)
        Me.GroupQTYFree.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupQTYFree.Name = "GroupQTYFree"
        Me.GroupQTYFree.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupQTYFree.Size = New System.Drawing.Size(223, 170)
        Me.GroupQTYFree.TabIndex = 25
        Me.GroupQTYFree.TabStop = False
        Me.GroupQTYFree.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Kh Battambang", 7.8!)
        Me.Label16.Location = New System.Drawing.Point(17, 111)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 19)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "ឯក្តា"
        '
        'TxtQTYFree
        '
        Me.TxtQTYFree.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtQTYFree.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQTYFree.Location = New System.Drawing.Point(61, 42)
        Me.TxtQTYFree.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TxtQTYFree.Name = "TxtQTYFree"
        Me.TxtQTYFree.Size = New System.Drawing.Size(131, 26)
        Me.TxtQTYFree.TabIndex = 22
        Me.TxtQTYFree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboUnitFree
        '
        Me.cboUnitFree.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnitFree.Location = New System.Drawing.Point(61, 100)
        Me.cboUnitFree.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cboUnitFree.Name = "cboUnitFree"
        Me.cboUnitFree.Size = New System.Drawing.Size(131, 30)
        Me.cboUnitFree.TabIndex = 24
        '
        'ChQTYFree
        '
        Me.ChQTYFree.AutoSize = True
        Me.ChQTYFree.ForeColor = System.Drawing.Color.Red
        Me.ChQTYFree.Location = New System.Drawing.Point(14, 14)
        Me.ChQTYFree.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ChQTYFree.Name = "ChQTYFree"
        Me.ChQTYFree.Size = New System.Drawing.Size(95, 33)
        Me.ChQTYFree.TabIndex = 26
        Me.ChQTYFree.Text = "Qty Free"
        Me.ChQTYFree.UseVisualStyleBackColor = True
        Me.ChQTYFree.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(17, 61)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 29)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Qty:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(300, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 29)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!)
        Me.Label14.Location = New System.Drawing.Point(10, 85)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 29)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "ឯកក្តា:"
        '
        'cboUnit
        '
        Me.cboUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboUnit.Enabled = False
        Me.cboUnit.Font = New System.Drawing.Font("Kh Battambang", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnit.FormattingEnabled = True
        Me.cboUnit.Items.AddRange(New Object() {"KHR", "USD", "THB"})
        Me.cboUnit.Location = New System.Drawing.Point(133, 81)
        Me.cboUnit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cboUnit.Name = "cboUnit"
        Me.cboUnit.Size = New System.Drawing.Size(156, 33)
        Me.cboUnit.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(301, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 29)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(437, 221)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 29)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "*"
        Me.Label9.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(300, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 29)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(505, 641)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 29)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(525, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 29)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "*"
        '
        'TxtTotalCost
        '
        Me.TxtTotalCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalCost.Enabled = False
        Me.TxtTotalCost.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!)
        Me.TxtTotalCost.Location = New System.Drawing.Point(134, 241)
        Me.TxtTotalCost.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TxtTotalCost.Name = "TxtTotalCost"
        Me.TxtTotalCost.ReadOnly = True
        Me.TxtTotalCost.Size = New System.Drawing.Size(158, 37)
        Me.TxtTotalCost.TabIndex = 5
        Me.TxtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblTotalCost
        '
        Me.LblTotalCost.AutoSize = True
        Me.LblTotalCost.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!)
        Me.LblTotalCost.Location = New System.Drawing.Point(14, 249)
        Me.LblTotalCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTotalCost.Name = "LblTotalCost"
        Me.LblTotalCost.Size = New System.Drawing.Size(82, 29)
        Me.LblTotalCost.TabIndex = 8
        Me.LblTotalCost.Text = "តំលៃសរុប:"
        '
        'txtQTY
        '
        Me.txtQTY.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQTY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQTY.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!)
        Me.txtQTY.Location = New System.Drawing.Point(133, 192)
        Me.txtQTY.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(157, 37)
        Me.txtQTY.TabIndex = 3
        Me.txtQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCost
        '
        Me.txtCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCost.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!)
        Me.txtCost.Location = New System.Drawing.Point(133, 143)
        Me.txtCost.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(157, 37)
        Me.txtCost.TabIndex = 2
        Me.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(14, 151)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "តំលៃទិញ​:"
        '
        'CboCurrency
        '
        Me.CboCurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboCurrency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboCurrency.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCurrency.Items.AddRange(New Object() {"$", "៛", "B"})
        Me.CboCurrency.Location = New System.Drawing.Point(339, 613)
        Me.CboCurrency.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CboCurrency.Name = "CboCurrency"
        Me.CboCurrency.Size = New System.Drawing.Size(156, 32)
        Me.CboCurrency.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(229, 624)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ប្រភេទប្រាក់៖"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(14, 200)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ចំនួនទទួល:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(11, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ឈ្មោះទំនិញ:"
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Location = New System.Drawing.Point(806, 528)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(112, 40)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Close"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Location = New System.Drawing.Point(692, 528)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(105, 40)
        Me.BtnAdd.TabIndex = 1
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'ErrProduct
        '
        Me.ErrProduct.ContainerControl = Me
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnAddProduct)
        Me.GroupBox3.Controls.Add(Me.GridProductList)
        Me.GroupBox3.Controls.Add(Me.txtSearchProduct)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(397, 517)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Product Name:"
        '
        'GridProductList
        '
        Me.GridProductList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridProductList.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridProductList_DesignTimeLayout.LayoutString = resources.GetString("GridProductList_DesignTimeLayout.LayoutString")
        Me.GridProductList.DesignTimeLayout = GridProductList_DesignTimeLayout
        Me.GridProductList.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.GridProductList.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridProductList.GroupByBoxVisible = False
        Me.GridProductList.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridProductList.Location = New System.Drawing.Point(3, 80)
        Me.GridProductList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridProductList.Name = "GridProductList"
        Me.GridProductList.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.GridProductList.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridProductList.RecordNavigator = True
        Me.GridProductList.Size = New System.Drawing.Size(387, 431)
        Me.GridProductList.TabIndex = 3
        Me.GridProductList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'txtSearchProduct
        '
        Me.txtSearchProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSearchProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchProduct.Font = New System.Drawing.Font("Kh Battambang", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchProduct.Location = New System.Drawing.Point(3, 28)
        Me.txtSearchProduct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSearchProduct.Name = "txtSearchProduct"
        Me.txtSearchProduct.Size = New System.Drawing.Size(335, 42)
        Me.txtSearchProduct.TabIndex = 2
        '
        'BtnAddProduct
        '
        Me.BtnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddProduct.Location = New System.Drawing.Point(344, 28)
        Me.BtnAddProduct.Name = "BtnAddProduct"
        Me.BtnAddProduct.Size = New System.Drawing.Size(46, 42)
        Me.BtnAddProduct.TabIndex = 4
        Me.BtnAddProduct.Text = "..."
        Me.BtnAddProduct.UseVisualStyleBackColor = True
        '
        'AddPurchaseOrder
        '
        Me.AcceptButton = Me.BtnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(931, 579)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(0, 250)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddPurchaseOrder"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Product"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupQTYFree.ResumeLayout(False)
        Me.GroupQTYFree.PerformLayout()
        CType(Me.ErrProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.GridProductList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboCurrency As System.Windows.Forms.ComboBox
    Friend WithEvents LblTotalCost As System.Windows.Forms.Label
    Friend WithEvents txtQTY As System.Windows.Forms.TextBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ErrProduct As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblOrderNo As System.Windows.Forms.Label
    Friend WithEvents cboUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ChQTYFree As System.Windows.Forms.CheckBox
    Friend WithEvents GroupQTYFree As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtQTYFree As System.Windows.Forms.TextBox
    Friend WithEvents cboUnitFree As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GridProductList As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtSearchProduct As System.Windows.Forms.TextBox
    Friend WithEvents TxtProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtContain As System.Windows.Forms.TextBox
    Friend WithEvents BtnAddProduct As System.Windows.Forms.Button
End Class
