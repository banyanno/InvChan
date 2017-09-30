<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewSale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewSale))
        Dim OrderList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.ListProduct = New System.Windows.Forms.ListView
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnRemove = New System.Windows.Forms.Button
        Me.ImgListDashbord = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.OrderList = New Janus.Windows.GridEX.GridEX
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.BtnCorrectItem = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnShopList = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnNewInvoice = New System.Windows.Forms.Button
        Me.BtnBarcode = New System.Windows.Forms.Button
        Me.BtnCalculation = New System.Windows.Forms.Button
        Me.lblUser = New System.Windows.Forms.Label
        Me.LblRate = New System.Windows.Forms.Label
        Me.dtInvoice = New System.Windows.Forms.DateTimePicker
        Me.TxtTotalKHR = New System.Windows.Forms.Label
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox
        Me.TxtTotalUSD = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ErrSale = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LblProfile = New System.Windows.Forms.Label
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.OrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.ErrSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 115)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer3.Panel2.Controls.Add(Me.lblUser)
        Me.SplitContainer3.Panel2.Controls.Add(Me.LblRate)
        Me.SplitContainer3.Panel2.Controls.Add(Me.dtInvoice)
        Me.SplitContainer3.Panel2.Controls.Add(Me.TxtTotalKHR)
        Me.SplitContainer3.Panel2.Controls.Add(Me.txtInvoiceNo)
        Me.SplitContainer3.Panel2.Controls.Add(Me.TxtTotalUSD)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer3.Size = New System.Drawing.Size(1440, 759)
        Me.SplitContainer3.SplitterDistance = 672
        Me.SplitContainer3.SplitterWidth = 1
        Me.SplitContainer3.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtBarcode)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ListProduct)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.OrderList)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1440, 672)
        Me.SplitContainer2.SplitterDistance = 276
        Me.SplitContainer2.SplitterWidth = 1
        Me.SplitContainer2.TabIndex = 1
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(376, 452)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(167, 37)
        Me.txtBarcode.TabIndex = 45
        '
        'ListProduct
        '
        Me.ListProduct.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListProduct.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ListProduct.BackgroundImage = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.Bk2
        Me.ListProduct.BackgroundImageTiled = True
        Me.ListProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListProduct.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListProduct.ForeColor = System.Drawing.Color.Blue
        Me.ListProduct.HoverSelection = True
        Me.ListProduct.Location = New System.Drawing.Point(0, 34)
        Me.ListProduct.MultiSelect = False
        Me.ListProduct.Name = "ListProduct"
        Me.ListProduct.Size = New System.Drawing.Size(276, 604)
        Me.ListProduct.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListProduct.TabIndex = 0
        Me.ListProduct.UseCompatibleStateImageBehavior = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(276, 34)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "មុខទំនិញ"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.BtnRemove)
        Me.Panel1.Controls.Add(Me.BtnAdd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 638)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(276, 34)
        Me.Panel1.TabIndex = 2
        '
        'BtnRemove
        '
        Me.BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRemove.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemove.ForeColor = System.Drawing.Color.Green
        Me.BtnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRemove.ImageIndex = 3
        Me.BtnRemove.ImageList = Me.ImgListDashbord
        Me.BtnRemove.Location = New System.Drawing.Point(86, 2)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(42, 29)
        Me.BtnRemove.TabIndex = 40
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'ImgListDashbord
        '
        Me.ImgListDashbord.ImageStream = CType(resources.GetObject("ImgListDashbord.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgListDashbord.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgListDashbord.Images.SetKeyName(0, "Checkout.png")
        Me.ImgListDashbord.Images.SetKeyName(1, "Closed Sign.png")
        Me.ImgListDashbord.Images.SetKeyName(2, "Right-80.png")
        Me.ImgListDashbord.Images.SetKeyName(3, "Left-80.png")
        Me.ImgListDashbord.Images.SetKeyName(4, "Delete-100.png")
        Me.ImgListDashbord.Images.SetKeyName(5, "Cash Register-100.png")
        Me.ImgListDashbord.Images.SetKeyName(6, "Land Sales-100.png")
        Me.ImgListDashbord.Images.SetKeyName(7, "Productlist.png")
        Me.ImgListDashbord.Images.SetKeyName(8, "Barcode Scanner-50.png")
        Me.ImgListDashbord.Images.SetKeyName(9, "Delete Message-50.png")
        Me.ImgListDashbord.Images.SetKeyName(10, "Create New-80.png")
        '
        'BtnAdd
        '
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAdd.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.Green
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.ImageIndex = 2
        Me.BtnAdd.ImageList = Me.ImgListDashbord
        Me.BtnAdd.Location = New System.Drawing.Point(139, 2)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(42, 29)
        Me.BtnAdd.TabIndex = 39
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'OrderList
        '
        Me.OrderList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.OrderList.BackColor = System.Drawing.SystemColors.Control
        OrderList_DesignTimeLayout.LayoutString = resources.GetString("OrderList_DesignTimeLayout.LayoutString")
        Me.OrderList.DesignTimeLayout = OrderList_DesignTimeLayout
        Me.OrderList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.OrderList.GroupByBoxVisible = False
        Me.OrderList.HeaderFormatStyle.FontSize = 10.0!
        Me.OrderList.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.OrderList.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.OrderList.Location = New System.Drawing.Point(0, 0)
        Me.OrderList.Name = "OrderList"
        Me.OrderList.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.OrderList.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.OrderList.RowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.OrderList.Size = New System.Drawing.Size(971, 672)
        Me.OrderList.TabIndex = 2
        Me.OrderList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnCorrectItem)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.BtnClose)
        Me.Panel3.Controls.Add(Me.BtnShopList)
        Me.Panel3.Controls.Add(Me.BtnCancel)
        Me.Panel3.Controls.Add(Me.BtnNewInvoice)
        Me.Panel3.Controls.Add(Me.BtnBarcode)
        Me.Panel3.Controls.Add(Me.BtnCalculation)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(971, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(192, 672)
        Me.Panel3.TabIndex = 3
        '
        'BtnCorrectItem
        '
        Me.BtnCorrectItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCorrectItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCorrectItem.Font = New System.Drawing.Font("Khmer OS Fasthand", 13.0!)
        Me.BtnCorrectItem.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.BtnCorrectItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCorrectItem.ImageIndex = 10
        Me.BtnCorrectItem.ImageList = Me.ImgListDashbord
        Me.BtnCorrectItem.Location = New System.Drawing.Point(8, 472)
        Me.BtnCorrectItem.Name = "BtnCorrectItem"
        Me.BtnCorrectItem.Size = New System.Drawing.Size(177, 84)
        Me.BtnCorrectItem.TabIndex = 41
        Me.BtnCorrectItem.Text = "កែប្រែ ចំនួនលក់"
        Me.BtnCorrectItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnCorrectItem.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 638)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 34)
        Me.Label3.TabIndex = 44
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 34)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "មុខងារ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnClose
        '
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnClose.Font = New System.Drawing.Font("Khmer OS Fasthand", 13.0!)
        Me.BtnClose.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnClose.ImageIndex = 1
        Me.BtnClose.ImageList = Me.ImgListDashbord
        Me.BtnClose.Location = New System.Drawing.Point(8, 559)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(177, 84)
        Me.BtnClose.TabIndex = 37
        Me.BtnClose.Text = "... បិត Esc"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnShopList
        '
        Me.BtnShopList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnShopList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnShopList.Font = New System.Drawing.Font("Khmer OS Fasthand", 13.0!)
        Me.BtnShopList.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnShopList.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnShopList.ImageIndex = 7
        Me.BtnShopList.ImageList = Me.ImgListDashbord
        Me.BtnShopList.Location = New System.Drawing.Point(8, 308)
        Me.BtnShopList.Name = "BtnShopList"
        Me.BtnShopList.Size = New System.Drawing.Size(177, 77)
        Me.BtnShopList.TabIndex = 39
        Me.BtnShopList.Text = "បង្ហាញ់ ទំនិញ F4"
        Me.BtnShopList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnShopList.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Font = New System.Drawing.Font("Khmer OS Fasthand", 13.0!)
        Me.BtnCancel.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancel.ImageIndex = 9
        Me.BtnCancel.ImageList = Me.ImgListDashbord
        Me.BtnCancel.Location = New System.Drawing.Point(8, 386)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(177, 84)
        Me.BtnCancel.TabIndex = 41
        Me.BtnCancel.Text = "លុបចោល F12"
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnNewInvoice
        '
        Me.BtnNewInvoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNewInvoice.Font = New System.Drawing.Font("Khmer OS Fasthand", 13.0!)
        Me.BtnNewInvoice.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnNewInvoice.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNewInvoice.ImageIndex = 0
        Me.BtnNewInvoice.ImageList = Me.ImgListDashbord
        Me.BtnNewInvoice.Location = New System.Drawing.Point(8, 210)
        Me.BtnNewInvoice.Name = "BtnNewInvoice"
        Me.BtnNewInvoice.Size = New System.Drawing.Size(177, 95)
        Me.BtnNewInvoice.TabIndex = 42
        Me.BtnNewInvoice.Text = "ស្វែងរកមុខ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ទំនិញ F3"
        Me.BtnNewInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnNewInvoice.UseVisualStyleBackColor = True
        '
        'BtnBarcode
        '
        Me.BtnBarcode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBarcode.Font = New System.Drawing.Font("Khmer OS Fasthand", 12.0!)
        Me.BtnBarcode.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnBarcode.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBarcode.ImageIndex = 8
        Me.BtnBarcode.ImageList = Me.ImgListDashbord
        Me.BtnBarcode.Location = New System.Drawing.Point(8, 124)
        Me.BtnBarcode.Name = "BtnBarcode"
        Me.BtnBarcode.Size = New System.Drawing.Size(177, 84)
        Me.BtnBarcode.TabIndex = 40
        Me.BtnBarcode.Text = "   Barcode F2"
        Me.BtnBarcode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnBarcode.UseVisualStyleBackColor = True
        '
        'BtnCalculation
        '
        Me.BtnCalculation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCalculation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCalculation.Font = New System.Drawing.Font("Khmer OS Fasthand", 13.0!)
        Me.BtnCalculation.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnCalculation.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCalculation.ImageIndex = 6
        Me.BtnCalculation.ImageList = Me.ImgListDashbord
        Me.BtnCalculation.Location = New System.Drawing.Point(8, 38)
        Me.BtnCalculation.Name = "BtnCalculation"
        Me.BtnCalculation.Size = New System.Drawing.Size(177, 84)
        Me.BtnCalculation.TabIndex = 38
        Me.BtnCalculation.Text = "គិតលុយ F1"
        Me.BtnCalculation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnCalculation.UseVisualStyleBackColor = True
        '
        'lblUser
        '
        Me.lblUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Khmer OS Battambang", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUser.Location = New System.Drawing.Point(3, 42)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(221, 36)
        Me.lblUser.TabIndex = 48
        Me.lblUser.Text = "អត្រាប្តូប្រាក់:​ 1$ = 4100៛"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblRate
        '
        Me.LblRate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblRate.AutoSize = True
        Me.LblRate.BackColor = System.Drawing.Color.Transparent
        Me.LblRate.Font = New System.Drawing.Font("Khmer OS Battambang", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblRate.Location = New System.Drawing.Point(3, -1)
        Me.LblRate.Name = "LblRate"
        Me.LblRate.Size = New System.Drawing.Size(221, 36)
        Me.LblRate.TabIndex = 47
        Me.LblRate.Text = "អត្រាប្តូប្រាក់:​ 1$ = 4100៛"
        Me.LblRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtInvoice
        '
        Me.dtInvoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtInvoice.CustomFormat = "dd/MM/yyyy"
        Me.dtInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtInvoice.Location = New System.Drawing.Point(230, 49)
        Me.dtInvoice.Name = "dtInvoice"
        Me.dtInvoice.ShowCheckBox = True
        Me.dtInvoice.Size = New System.Drawing.Size(133, 26)
        Me.dtInvoice.TabIndex = 44
        Me.dtInvoice.Visible = False
        '
        'TxtTotalKHR
        '
        Me.TxtTotalKHR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtTotalKHR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalKHR.Font = New System.Drawing.Font("Khmer OS Battambang", 19.0!)
        Me.TxtTotalKHR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTotalKHR.Location = New System.Drawing.Point(459, 35)
        Me.TxtTotalKHR.Name = "TxtTotalKHR"
        Me.TxtTotalKHR.Size = New System.Drawing.Size(299, 49)
        Me.TxtTotalKHR.TabIndex = 5
        Me.TxtTotalKHR.Text = "0"
        Me.TxtTotalKHR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNo.Location = New System.Drawing.Point(230, 3)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.ReadOnly = True
        Me.txtInvoiceNo.Size = New System.Drawing.Size(133, 26)
        Me.txtInvoiceNo.TabIndex = 43
        Me.txtInvoiceNo.Visible = False
        '
        'TxtTotalUSD
        '
        Me.TxtTotalUSD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtTotalUSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalUSD.Font = New System.Drawing.Font("Khmer OS Battambang", 19.0!)
        Me.TxtTotalUSD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTotalUSD.Location = New System.Drawing.Point(763, 35)
        Me.TxtTotalUSD.Name = "TxtTotalUSD"
        Me.TxtTotalUSD.Size = New System.Drawing.Size(299, 49)
        Me.TxtTotalUSD.TabIndex = 4
        Me.TxtTotalUSD.Text = "0"
        Me.TxtTotalUSD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer OS Battambang", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(520, -9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 47)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ចំនួន សរុប(៛):"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Khmer OS Battambang", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(822, -9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 47)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ចំនួន សរុប($):"
        '
        'ErrSale
        '
        Me.ErrSale.ContainerControl = Me
        '
        'LblProfile
        '
        Me.LblProfile.BackColor = System.Drawing.Color.Transparent
        Me.LblProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblProfile.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblProfile.Font = New System.Drawing.Font("Khmer OS Fasthand", 12.0!)
        Me.LblProfile.ForeColor = System.Drawing.Color.SeaGreen
        Me.LblProfile.Location = New System.Drawing.Point(0, 0)
        Me.LblProfile.Name = "LblProfile"
        Me.LblProfile.Size = New System.Drawing.Size(1440, 115)
        Me.LblProfile.TabIndex = 7
        Me.LblProfile.Text = "លោក. គឹម ហាក់" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "មានលក់ ភេសជ្ជៈ គ្រឿងអគ្គិសនី លីហួរវេរលុយ នឹង វីងវេរលុយ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "មុខក្លោងទ្" & _
            "វា រោងចក្រកាត់ដេរសម្លៀកបំពាក់ ស្រុកក្រគរ"
        Me.LblProfile.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NewSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.Bk2
        Me.ClientSize = New System.Drawing.Size(1440, 874)
        Me.Controls.Add(Me.SplitContainer3)
        Me.Controls.Add(Me.LblProfile)
        Me.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "NewSale"
        Me.ShowInTaskbar = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.OrderList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.ErrSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents OrderList As Janus.Windows.GridEX.GridEX
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents ImgListDashbord As System.Windows.Forms.ImageList
    Friend WithEvents BtnCalculation As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents ListProduct As System.Windows.Forms.ListView
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnRemove As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnShopList As System.Windows.Forms.Button
    Friend WithEvents BtnBarcode As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnNewInvoice As System.Windows.Forms.Button
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents dtInvoice As System.Windows.Forms.DateTimePicker
    Friend WithEvents ErrSale As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalKHR As System.Windows.Forms.Label
    Friend WithEvents TxtTotalUSD As System.Windows.Forms.Label
    Friend WithEvents BtnCorrectItem As System.Windows.Forms.Button
    Friend WithEvents LblProfile As System.Windows.Forms.Label
    Friend WithEvents LblRate As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
