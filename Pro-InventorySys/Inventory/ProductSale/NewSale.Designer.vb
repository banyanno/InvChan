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
        Me.lblUser = New System.Windows.Forms.Label
        Me.LblRate = New System.Windows.Forms.Label
        Me.dtInvoice = New System.Windows.Forms.DateTimePicker
        Me.TxtTotalKHR = New System.Windows.Forms.Label
        Me.TxtTotalUSD = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ErrSale = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LinkCalculation = New System.Windows.Forms.LinkLabel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel
        Me.Label9 = New System.Windows.Forms.Label
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.OrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 72)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SplitContainer3.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer3.Panel2Collapsed = True
        Me.SplitContainer3.Size = New System.Drawing.Size(1454, 777)
        Me.SplitContainer3.SplitterDistance = 370
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
        Me.SplitContainer2.Panel1Collapsed = True
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.OrderList)
        Me.SplitContainer2.Size = New System.Drawing.Size(1452, 775)
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
        Me.ListProduct.Size = New System.Drawing.Size(276, 574)
        Me.ListProduct.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListProduct.TabIndex = 0
        Me.ListProduct.UseCompatibleStateImageBehavior = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnRemove)
        Me.Panel1.Controls.Add(Me.BtnAdd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 608)
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
        Me.BtnRemove.ImageIndex = 19
        Me.BtnRemove.ImageList = Me.ImgListDashbord
        Me.BtnRemove.Location = New System.Drawing.Point(86, 2)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(43, 30)
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
        Me.ImgListDashbord.Images.SetKeyName(11, "money-48.png")
        Me.ImgListDashbord.Images.SetKeyName(12, "scanner-48.png")
        Me.ImgListDashbord.Images.SetKeyName(13, "buying-48.png")
        Me.ImgListDashbord.Images.SetKeyName(14, "icons8-buy-48.png")
        Me.ImgListDashbord.Images.SetKeyName(15, "delete-shield-48.png")
        Me.ImgListDashbord.Images.SetKeyName(16, "edit-profile-48.png")
        Me.ImgListDashbord.Images.SetKeyName(17, "delete-shield-48.png")
        Me.ImgListDashbord.Images.SetKeyName(18, "shutdown-48.png")
        Me.ImgListDashbord.Images.SetKeyName(19, "icons8-back-arrow-48.png")
        Me.ImgListDashbord.Images.SetKeyName(20, "icons8-forward-button-48.png")
        '
        'BtnAdd
        '
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAdd.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.Green
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.ImageIndex = 20
        Me.BtnAdd.ImageList = Me.ImgListDashbord
        Me.BtnAdd.Location = New System.Drawing.Point(139, 2)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(43, 30)
        Me.BtnAdd.TabIndex = 39
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'OrderList
        '
        Me.OrderList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.OrderList.BackColor = System.Drawing.SystemColors.Control
        Me.OrderList.CardCaptionFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.OrderList.CardCaptionFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.OrderList.CardCaptionPrefix = "Product"
        Me.OrderList.CardColumnHeaderFormatStyle.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!)
        Me.OrderList.CardColumnHeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.OrderList.CardSpacing = 10
        Me.OrderList.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Horizontal
        Me.OrderList.ColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.OrderList.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.OrderList.ContinuousScroll = False
        OrderList_DesignTimeLayout.LayoutString = resources.GetString("OrderList_DesignTimeLayout.LayoutString")
        Me.OrderList.DesignTimeLayout = OrderList_DesignTimeLayout
        Me.OrderList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.OrderList.GroupByBoxVisible = False
        Me.OrderList.HeaderFormatStyle.FontSize = 10.0!
        Me.OrderList.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.OrderList.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.OrderList.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.OrderList.Location = New System.Drawing.Point(0, 0)
        Me.OrderList.Name = "OrderList"
        Me.OrderList.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.OrderList.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.OrderList.RowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.OrderList.SelectOnExpand = False
        Me.OrderList.Size = New System.Drawing.Size(1452, 775)
        Me.OrderList.TabIndex = 2
        Me.OrderList.TableViewHorizontalScrollIncrement = 4
        Me.OrderList.View = Janus.Windows.GridEX.View.CardView
        Me.OrderList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.OrderList.WatermarkImage.Alpha = 250
        Me.OrderList.WatermarkImage.Image = CType(resources.GetObject("OrderList.WatermarkImage.Image"), System.Drawing.Image)
        Me.OrderList.WatermarkImage.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.OrderList.WatermarkImage.Size = New System.Drawing.Size(500, 500)
        Me.OrderList.WatermarkImage.WashMode = Janus.Windows.GridEX.WashMode.UseWashColor
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Khmer OS Battambang", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(5, 40)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(120, 19)
        Me.lblUser.TabIndex = 48
        Me.lblUser.Text = "អត្រាប្តូប្រាក់:​ 1$ = 4100៛"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblRate
        '
        Me.LblRate.AutoSize = True
        Me.LblRate.BackColor = System.Drawing.Color.Transparent
        Me.LblRate.Font = New System.Drawing.Font("Khmer OS Battambang", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRate.ForeColor = System.Drawing.Color.White
        Me.LblRate.Location = New System.Drawing.Point(5, 12)
        Me.LblRate.Name = "LblRate"
        Me.LblRate.Size = New System.Drawing.Size(120, 19)
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
        Me.dtInvoice.Location = New System.Drawing.Point(26, 9)
        Me.dtInvoice.Name = "dtInvoice"
        Me.dtInvoice.ShowCheckBox = True
        Me.dtInvoice.Size = New System.Drawing.Size(133, 26)
        Me.dtInvoice.TabIndex = 44
        Me.dtInvoice.Visible = False
        '
        'TxtTotalKHR
        '
        Me.TxtTotalKHR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtTotalKHR.BackColor = System.Drawing.Color.White
        Me.TxtTotalKHR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TxtTotalKHR.Font = New System.Drawing.Font("Khmer OS Battambang", 14.0!)
        Me.TxtTotalKHR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTotalKHR.Location = New System.Drawing.Point(402, 10)
        Me.TxtTotalKHR.Name = "TxtTotalKHR"
        Me.TxtTotalKHR.Size = New System.Drawing.Size(299, 34)
        Me.TxtTotalKHR.TabIndex = 5
        Me.TxtTotalKHR.Text = "0"
        Me.TxtTotalKHR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtTotalUSD
        '
        Me.TxtTotalUSD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtTotalUSD.BackColor = System.Drawing.Color.White
        Me.TxtTotalUSD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TxtTotalUSD.Font = New System.Drawing.Font("Khmer OS Battambang", 14.0!)
        Me.TxtTotalUSD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTotalUSD.Location = New System.Drawing.Point(812, 11)
        Me.TxtTotalUSD.Name = "TxtTotalUSD"
        Me.TxtTotalUSD.Size = New System.Drawing.Size(299, 34)
        Me.TxtTotalUSD.TabIndex = 4
        Me.TxtTotalUSD.Text = "0"
        Me.TxtTotalUSD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(302, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 25)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ចំនួន សរុប(៛):"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(709, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ចំនួន សរុប($):"
        '
        'ErrSale
        '
        Me.ErrSale.ContainerControl = Me
        '
        'LinkCalculation
        '
        Me.LinkCalculation.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkCalculation.ForeColor = System.Drawing.Color.White
        Me.LinkCalculation.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LinkCalculation.ImageIndex = 11
        Me.LinkCalculation.ImageList = Me.ImgListDashbord
        Me.LinkCalculation.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkCalculation.LinkColor = System.Drawing.Color.White
        Me.LinkCalculation.Location = New System.Drawing.Point(3, 4)
        Me.LinkCalculation.Name = "LinkCalculation"
        Me.LinkCalculation.Size = New System.Drawing.Size(140, 62)
        Me.LinkCalculation.TabIndex = 45
        Me.LinkCalculation.TabStop = True
        Me.LinkCalculation.Text = "គិតលុយ F1"
        Me.LinkCalculation.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.LinkLabel6)
        Me.Panel2.Controls.Add(Me.LinkLabel7)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.LinkLabel5)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.LinkLabel3)
        Me.Panel2.Controls.Add(Me.LinkLabel4)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.LinkLabel2)
        Me.Panel2.Controls.Add(Me.LinkCalculation)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1454, 72)
        Me.Panel2.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(942, 1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1, 68)
        Me.Label11.TabIndex = 57
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(781, 2)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1, 69)
        Me.Label10.TabIndex = 56
        '
        'LinkLabel6
        '
        Me.LinkLabel6.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel6.ForeColor = System.Drawing.Color.White
        Me.LinkLabel6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LinkLabel6.ImageIndex = 18
        Me.LinkLabel6.ImageList = Me.ImgListDashbord
        Me.LinkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel6.LinkColor = System.Drawing.Color.White
        Me.LinkLabel6.Location = New System.Drawing.Point(946, 4)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(140, 62)
        Me.LinkLabel6.TabIndex = 55
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = " បិត Esc"
        Me.LinkLabel6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LinkLabel7
        '
        Me.LinkLabel7.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel7.ForeColor = System.Drawing.Color.White
        Me.LinkLabel7.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LinkLabel7.ImageIndex = 16
        Me.LinkLabel7.ImageList = Me.ImgListDashbord
        Me.LinkLabel7.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel7.LinkColor = System.Drawing.Color.White
        Me.LinkLabel7.Location = New System.Drawing.Point(789, 2)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(140, 62)
        Me.LinkLabel7.TabIndex = 54
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "កែប្រែរ ចំនួនលក់"
        Me.LinkLabel7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(643, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1, 67)
        Me.Label9.TabIndex = 53
        '
        'LinkLabel5
        '
        Me.LinkLabel5.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel5.ForeColor = System.Drawing.Color.White
        Me.LinkLabel5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LinkLabel5.ImageIndex = 15
        Me.LinkLabel5.ImageList = Me.ImgListDashbord
        Me.LinkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel5.LinkColor = System.Drawing.Color.White
        Me.LinkLabel5.Location = New System.Drawing.Point(644, 4)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(131, 62)
        Me.LinkLabel5.TabIndex = 52
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "លុបចោល F12"
        Me.LinkLabel5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(307, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1, 67)
        Me.Label8.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(496, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1, 67)
        Me.Label7.TabIndex = 50
        '
        'LinkLabel3
        '
        Me.LinkLabel3.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.ForeColor = System.Drawing.Color.White
        Me.LinkLabel3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LinkLabel3.ImageIndex = 14
        Me.LinkLabel3.ImageList = Me.ImgListDashbord
        Me.LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel3.LinkColor = System.Drawing.Color.White
        Me.LinkLabel3.Location = New System.Drawing.Point(500, 4)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(140, 62)
        Me.LinkLabel3.TabIndex = 49
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "បង្ហាញ ទំនិញ F4"
        Me.LinkLabel3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LinkLabel4
        '
        Me.LinkLabel4.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.ForeColor = System.Drawing.Color.White
        Me.LinkLabel4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LinkLabel4.ImageIndex = 13
        Me.LinkLabel4.ImageList = Me.ImgListDashbord
        Me.LinkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel4.LinkColor = System.Drawing.Color.White
        Me.LinkLabel4.Location = New System.Drawing.Point(315, 4)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(178, 62)
        Me.LinkLabel4.TabIndex = 48
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "ស្វែងរកមុខ ទំនិញ F3"
        Me.LinkLabel4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(148, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1, 67)
        Me.Label1.TabIndex = 47
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.ForeColor = System.Drawing.Color.White
        Me.LinkLabel2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LinkLabel2.ImageIndex = 12
        Me.LinkLabel2.ImageList = Me.ImgListDashbord
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.White
        Me.LinkLabel2.Location = New System.Drawing.Point(158, 4)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(140, 62)
        Me.LinkLabel2.TabIndex = 46
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Barcode F2"
        Me.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNo.Location = New System.Drawing.Point(191, 33)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.ReadOnly = True
        Me.txtInvoiceNo.Size = New System.Drawing.Size(133, 26)
        Me.txtInvoiceNo.TabIndex = 43
        Me.txtInvoiceNo.Visible = False
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Controls.Add(Me.TxtTotalKHR)
        Me.Panel4.Controls.Add(Me.lblUser)
        Me.Panel4.Controls.Add(Me.txtInvoiceNo)
        Me.Panel4.Controls.Add(Me.TxtTotalUSD)
        Me.Panel4.Controls.Add(Me.LblRate)
        Me.Panel4.Controls.Add(Me.dtInvoice)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 849)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1454, 65)
        Me.Panel4.TabIndex = 3
        '
        'NewSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1454, 914)
        Me.Controls.Add(Me.SplitContainer3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "NewSale"
        Me.ShowInTaskbar = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.OrderList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents OrderList As Janus.Windows.GridEX.GridEX
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents ImgListDashbord As System.Windows.Forms.ImageList
    Friend WithEvents ListProduct As System.Windows.Forms.ListView
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnRemove As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtInvoice As System.Windows.Forms.DateTimePicker
    Friend WithEvents ErrSale As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalKHR As System.Windows.Forms.Label
    Friend WithEvents TxtTotalUSD As System.Windows.Forms.Label
    Friend WithEvents LblRate As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LinkCalculation As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel6 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel7 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel5 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
End Class
