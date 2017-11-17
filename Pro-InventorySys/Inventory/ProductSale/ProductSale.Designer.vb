<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductSale
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
        Dim GridCustomer_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductSale))
        Dim OrderList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.BtnSave = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnAddProduct = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRemoveProduct = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefreshProduct = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnCancel = New System.Windows.Forms.ToolStripButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.lblExchangeRate = New System.Windows.Forms.Label
        Me.TxtTotalTHB = New System.Windows.Forms.TextBox
        Me.TxtTotalUSD = New System.Windows.Forms.TextBox
        Me.TxtTotalKHR = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtnNewCustomer = New System.Windows.Forms.Button
        Me.GridCustomer = New Janus.Windows.GridEX.GridEX
        Me.txtSearchCustomer = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.OrderList = New Janus.Windows.GridEX.GridEX
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.dtInvoice = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtCustomer = New System.Windows.Forms.TextBox
        Me.ChIsCustomer = New System.Windows.Forms.CheckBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ErrSale = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.OrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiTab1
        '
        Me.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab1.FlatBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UiTab1.Location = New System.Drawing.Point(0, 0)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom
        Me.UiTab1.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UiTab1.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UiTab1.PanelFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UiTab1.Size = New System.Drawing.Size(1260, 667)
        Me.UiTab1.TabIndex = 2
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1})
        Me.UiTab1.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.ToolStrip2)
        Me.UiTabPage1.Controls.Add(Me.GroupBox5)
        Me.UiTabPage1.Controls.Add(Me.SplitContainer1)
        Me.UiTabPage1.Controls.Add(Me.GroupBox2)
        Me.UiTabPage1.Controls.Add(Me.GroupBox1)
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(1258, 645)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Sale Information"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnSave, Me.ToolStripSeparator4, Me.BtnAddProduct, Me.ToolStripSeparator6, Me.BtnRemoveProduct, Me.ToolStripSeparator8, Me.BtnRefreshProduct, Me.ToolStripSeparator5, Me.BtnCancel})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1258, 61)
        Me.ToolStrip2.TabIndex = 13
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.Blue
        Me.BtnSave.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.Save
        Me.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(85, 58)
        Me.BtnSave.Text = "     Save     "
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 61)
        '
        'BtnAddProduct
        '
        Me.BtnAddProduct.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddProduct.ForeColor = System.Drawing.Color.Blue
        Me.BtnAddProduct.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources._1404566949_7
        Me.BtnAddProduct.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAddProduct.Name = "BtnAddProduct"
        Me.BtnAddProduct.Size = New System.Drawing.Size(105, 58)
        Me.BtnAddProduct.Text = "   បន្តែម ទំនិញ   "
        Me.BtnAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 61)
        '
        'BtnRemoveProduct
        '
        Me.BtnRemoveProduct.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoveProduct.ForeColor = System.Drawing.Color.Blue
        Me.BtnRemoveProduct.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources._1404566816_8
        Me.BtnRemoveProduct.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRemoveProduct.Name = "BtnRemoveProduct"
        Me.BtnRemoveProduct.Size = New System.Drawing.Size(97, 58)
        Me.BtnRemoveProduct.Text = "   លប់ ទំនិញ​​   "
        Me.BtnRemoveProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 61)
        '
        'BtnRefreshProduct
        '
        Me.BtnRefreshProduct.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefreshProduct.ForeColor = System.Drawing.Color.Blue
        Me.BtnRefreshProduct.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.refresh
        Me.BtnRefreshProduct.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefreshProduct.Name = "BtnRefreshProduct"
        Me.BtnRefreshProduct.Size = New System.Drawing.Size(92, 58)
        Me.BtnRefreshProduct.Text = "View Product"
        Me.BtnRefreshProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnRefreshProduct.Visible = False
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 61)
        Me.ToolStripSeparator5.Visible = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.Blue
        Me.BtnCancel.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.delete_appointment
        Me.BtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(81, 58)
        Me.BtnCancel.Text = "    Cancel   "
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.lblExchangeRate)
        Me.GroupBox5.Controls.Add(Me.TxtTotalTHB)
        Me.GroupBox5.Controls.Add(Me.TxtTotalUSD)
        Me.GroupBox5.Controls.Add(Me.TxtTotalKHR)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Red
        Me.GroupBox5.Location = New System.Drawing.Point(608, 67)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(626, 141)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        '
        'lblExchangeRate
        '
        Me.lblExchangeRate.AutoSize = True
        Me.lblExchangeRate.Location = New System.Drawing.Point(299, 88)
        Me.lblExchangeRate.Name = "lblExchangeRate"
        Me.lblExchangeRate.Size = New System.Drawing.Size(166, 29)
        Me.lblExchangeRate.TabIndex = 6
        Me.lblExchangeRate.Text = "អត្រាប្តូរប្រាក់ 1$=4100៛"
        '
        'TxtTotalTHB
        '
        Me.TxtTotalTHB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalTHB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalTHB.Location = New System.Drawing.Point(358, 20)
        Me.TxtTotalTHB.Name = "TxtTotalTHB"
        Me.TxtTotalTHB.Size = New System.Drawing.Size(143, 26)
        Me.TxtTotalTHB.TabIndex = 5
        Me.TxtTotalTHB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTotalTHB.Visible = False
        '
        'TxtTotalUSD
        '
        Me.TxtTotalUSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalUSD.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!)
        Me.TxtTotalUSD.Location = New System.Drawing.Point(104, 29)
        Me.TxtTotalUSD.Name = "TxtTotalUSD"
        Me.TxtTotalUSD.ReadOnly = True
        Me.TxtTotalUSD.Size = New System.Drawing.Size(174, 37)
        Me.TxtTotalUSD.TabIndex = 4
        Me.TxtTotalUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotalKHR
        '
        Me.TxtTotalKHR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalKHR.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!)
        Me.TxtTotalKHR.Location = New System.Drawing.Point(104, 80)
        Me.TxtTotalKHR.Name = "TxtTotalKHR"
        Me.TxtTotalKHR.ReadOnly = True
        Me.TxtTotalKHR.Size = New System.Drawing.Size(174, 37)
        Me.TxtTotalKHR.TabIndex = 3
        Me.TxtTotalKHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(353, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 29)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Total THB:"
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 29)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "សរុប($)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 29)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "សរុប(៛)"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(5, 220)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Size = New System.Drawing.Size(1250, 422)
        Me.SplitContainer1.SplitterDistance = 389
        Me.SplitContainer1.TabIndex = 11
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.BtnNewCustomer)
        Me.GroupBox3.Controls.Add(Me.GridCustomer)
        Me.GroupBox3.Controls.Add(Me.txtSearchCustomer)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(387, 420)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SearchCustomer"
        '
        'BtnNewCustomer
        '
        Me.BtnNewCustomer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNewCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewCustomer.Location = New System.Drawing.Point(325, 20)
        Me.BtnNewCustomer.Name = "BtnNewCustomer"
        Me.BtnNewCustomer.Size = New System.Drawing.Size(56, 36)
        Me.BtnNewCustomer.TabIndex = 6
        Me.BtnNewCustomer.Text = "..."
        Me.BtnNewCustomer.UseVisualStyleBackColor = True
        '
        'GridCustomer
        '
        Me.GridCustomer.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridCustomer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridCustomer.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridCustomer_DesignTimeLayout.LayoutString = resources.GetString("GridCustomer_DesignTimeLayout.LayoutString")
        Me.GridCustomer.DesignTimeLayout = GridCustomer_DesignTimeLayout
        Me.GridCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.GridCustomer.GroupByBoxVisible = False
        Me.GridCustomer.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridCustomer.Location = New System.Drawing.Point(3, 60)
        Me.GridCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.GridCustomer.Name = "GridCustomer"
        Me.GridCustomer.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.GridCustomer.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridCustomer.OwnerDrawnAreas = CType((((Janus.Windows.GridEX.GridEXOwnerDrawnArea.GroupByBoxBackground Or Janus.Windows.GridEX.GridEXOwnerDrawnArea.GroupByBoxInfoText) _
                    Or Janus.Windows.GridEX.GridEXOwnerDrawnArea.GroupByBoxTableInfo) _
                    Or Janus.Windows.GridEX.GridEXOwnerDrawnArea.RowHeaders), Janus.Windows.GridEX.GridEXOwnerDrawnArea)
        Me.GridCustomer.RecordNavigator = True
        Me.GridCustomer.Size = New System.Drawing.Size(378, 355)
        Me.GridCustomer.TabIndex = 5
        Me.GridCustomer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'txtSearchCustomer
        '
        Me.txtSearchCustomer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearchCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSearchCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchCustomer.Font = New System.Drawing.Font("Kh Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchCustomer.Location = New System.Drawing.Point(3, 20)
        Me.txtSearchCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearchCustomer.Name = "txtSearchCustomer"
        Me.txtSearchCustomer.Size = New System.Drawing.Size(317, 37)
        Me.txtSearchCustomer.TabIndex = 4
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.OrderList)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(855, 420)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "តារាង ទំនិញលក់ដុំ"
        '
        'OrderList
        '
        Me.OrderList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        OrderList_DesignTimeLayout.LayoutString = resources.GetString("OrderList_DesignTimeLayout.LayoutString")
        Me.OrderList.DesignTimeLayout = OrderList_DesignTimeLayout
        Me.OrderList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderList.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.OrderList.GroupByBoxVisible = False
        Me.OrderList.HeaderFormatStyle.FontSize = 10.0!
        Me.OrderList.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.OrderList.Location = New System.Drawing.Point(3, 33)
        Me.OrderList.Name = "OrderList"
        Me.OrderList.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.OrderList.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.OrderList.RecordNavigator = True
        Me.OrderList.RowFormatStyle.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderList.RowHeaderFormatStyle.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!)
        Me.OrderList.Size = New System.Drawing.Size(849, 384)
        Me.OrderList.TabIndex = 1
        Me.OrderList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.dtInvoice)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtInvoiceNo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(366, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(235, 140)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sale Info"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(213, 76)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(11, 13)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "*"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(213, 35)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(11, 13)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "*"
        '
        'dtInvoice
        '
        Me.dtInvoice.CustomFormat = "dd/MM/yyyy"
        Me.dtInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtInvoice.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtInvoice.Location = New System.Drawing.Point(76, 67)
        Me.dtInvoice.Name = "dtInvoice"
        Me.dtInvoice.ShowCheckBox = True
        Me.dtInvoice.Size = New System.Drawing.Size(133, 26)
        Me.dtInvoice.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Sale Date:"
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNo.Location = New System.Drawing.Point(76, 26)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.ReadOnly = True
        Me.txtInvoiceNo.Size = New System.Drawing.Size(133, 26)
        Me.txtInvoiceNo.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Invoice No:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtCustomer)
        Me.GroupBox1.Controls.Add(Me.ChIsCustomer)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(3, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 140)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Customer"
        '
        'TxtCustomer
        '
        Me.TxtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomer.Font = New System.Drawing.Font("Kh Battambang", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomer.Location = New System.Drawing.Point(117, 14)
        Me.TxtCustomer.Name = "TxtCustomer"
        Me.TxtCustomer.ReadOnly = True
        Me.TxtCustomer.Size = New System.Drawing.Size(218, 34)
        Me.TxtCustomer.TabIndex = 11
        '
        'ChIsCustomer
        '
        Me.ChIsCustomer.AutoSize = True
        Me.ChIsCustomer.Location = New System.Drawing.Point(9, 26)
        Me.ChIsCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.ChIsCustomer.Name = "ChIsCustomer"
        Me.ChIsCustomer.Size = New System.Drawing.Size(104, 17)
        Me.ChIsCustomer.TabIndex = 10
        Me.ChIsCustomer.Text = "Customer Name:"
        Me.ChIsCustomer.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(340, 120)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(11, 13)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "*"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(340, 77)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(11, 13)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(340, 20)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(11, 13)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "*"
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Font = New System.Drawing.Font("Kh Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(116, 98)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(218, 36)
        Me.txtPhone.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Kh Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(116, 55)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(218, 36)
        Me.txtAddress.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Telephone:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Address:"
        '
        'ErrSale
        '
        Me.ErrSale.ContainerControl = Me
        '
        'ProductSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1260, 667)
        Me.Controls.Add(Me.UiTab1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProductSale"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Sale"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage1.ResumeLayout(False)
        Me.UiTabPage1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.GridCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.OrderList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents OrderList As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtTotalTHB As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalUSD As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalKHR As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtInvoice As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnAddProduct As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRemoveProduct As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ChIsCustomer As System.Windows.Forms.CheckBox
    Friend WithEvents ErrSale As System.Windows.Forms.ErrorProvider
    Friend WithEvents BtnRefreshProduct As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridCustomer As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtSearchCustomer As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents BtnNewCustomer As System.Windows.Forms.Button
    Friend WithEvents lblExchangeRate As System.Windows.Forms.Label
End Class
