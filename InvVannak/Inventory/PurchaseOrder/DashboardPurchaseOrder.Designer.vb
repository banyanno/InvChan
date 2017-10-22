<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardPurchaseOrder
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim GridPurchaseOrder_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardPurchaseOrder))
        Dim GridPurchaseDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolProduct = New System.Windows.Forms.ToolStrip
        Me.BtnReceiveProduct = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPrintPreview = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnReceiveStock = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDeleteOrder = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnUndo = New System.Windows.Forms.ToolStripButton
        Me.GridPurchaseOrder = New Janus.Windows.GridEX.GridEX
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GridPurchaseDetail = New Janus.Windows.GridEX.GridEX
        Me.ContextAddRemoveItem = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnAddProduct = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRemoveProduct = New System.Windows.Forms.ToolStripMenuItem
        Me.UiPanelManager1 = New Janus.Windows.UI.Dock.UIPanelManager(Me.components)
        Me.uiPanel0 = New Janus.Windows.UI.Dock.UIPanel
        Me.uiPanel0Container = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtPurchashNo = New System.Windows.Forms.TextBox
        Me.ChPurchaseNo = New System.Windows.Forms.CheckBox
        Me.ChSupplier = New System.Windows.Forms.CheckBox
        Me.TxtSupplier = New System.Windows.Forms.ComboBox
        Me.BntFind = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.RadReceived = New System.Windows.Forms.RadioButton
        Me.RadNotYet = New System.Windows.Forms.RadioButton
        Me.RadAll = New System.Windows.Forms.RadioButton
        Me.ToolProduct.SuspendLayout()
        CType(Me.GridPurchaseOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridPurchaseDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextAddRemoveItem.SuspendLayout()
        CType(Me.UiPanelManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uiPanel0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uiPanel0.SuspendLayout()
        Me.uiPanel0Container.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolProduct
        '
        Me.ToolProduct.BackColor = System.Drawing.Color.Transparent
        Me.ToolProduct.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolProduct.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnReceiveProduct, Me.ToolStripSeparator2, Me.ToolStripButton7, Me.ToolStripSeparator6, Me.ToolStripButton8, Me.ToolStripSeparator5, Me.BtnPrintPreview, Me.ToolStripSeparator7, Me.BtnReceiveStock, Me.ToolStripSeparator8, Me.BtnDeleteOrder, Me.ToolStripSeparator1, Me.BtnUndo})
        Me.ToolProduct.Location = New System.Drawing.Point(0, 0)
        Me.ToolProduct.Name = "ToolProduct"
        Me.ToolProduct.Size = New System.Drawing.Size(1151, 62)
        Me.ToolProduct.TabIndex = 4
        Me.ToolProduct.Text = "ToolStrip1"
        '
        'BtnReceiveProduct
        '
        Me.BtnReceiveProduct.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.BtnReceiveProduct.ForeColor = System.Drawing.Color.Blue
        Me.BtnReceiveProduct.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.Checkout_50
        Me.BtnReceiveProduct.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnReceiveProduct.Name = "BtnReceiveProduct"
        Me.BtnReceiveProduct.Size = New System.Drawing.Size(128, 59)
        Me.BtnReceiveProduct.Text = "​​     ទទួល ទំនិញ     "
        Me.BtnReceiveProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 62)
        Me.ToolStripSeparator2.Visible = False
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton7.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton7.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.shoping_cart
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(119, 59)
        Me.ToolStripButton7.Text = "     បញ្ជាទិញថ្មី     "
        Me.ToolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton7.Visible = False
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 62)
        Me.ToolStripSeparator6.Visible = False
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton8.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton8.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources._1404739440_Money
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(121, 59)
        Me.ToolStripButton8.Text = "Paid To Supplier"
        Me.ToolStripButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton8.Visible = False
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 62)
        Me.ToolStripSeparator5.Visible = False
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintPreview.ForeColor = System.Drawing.Color.Blue
        Me.BtnPrintPreview.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources._1403851475_printer
        Me.BtnPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(109, 59)
        Me.BtnPrintPreview.Text = "Print Purchase"
        Me.BtnPrintPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnPrintPreview.Visible = False
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 62)
        Me.ToolStripSeparator7.Visible = False
        '
        'BtnReceiveStock
        '
        Me.BtnReceiveStock.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReceiveStock.ForeColor = System.Drawing.Color.Red
        Me.BtnReceiveStock.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.ReceiveReport
        Me.BtnReceiveStock.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnReceiveStock.Name = "BtnReceiveStock"
        Me.BtnReceiveStock.Size = New System.Drawing.Size(137, 59)
        Me.BtnReceiveStock.Text = "ទទួលទំនិញបញ្ជាទិញ"
        Me.BtnReceiveStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnReceiveStock.Visible = False
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 62)
        '
        'BtnDeleteOrder
        '
        Me.BtnDeleteOrder.Enabled = False
        Me.BtnDeleteOrder.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteOrder.ForeColor = System.Drawing.Color.Red
        Me.BtnDeleteOrder.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.delete_appointment
        Me.BtnDeleteOrder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeleteOrder.Name = "BtnDeleteOrder"
        Me.BtnDeleteOrder.Size = New System.Drawing.Size(133, 59)
        Me.BtnDeleteOrder.Text = "     លប់បញ្ជាទិញ     "
        Me.BtnDeleteOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 62)
        '
        'BtnUndo
        '
        Me.BtnUndo.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUndo.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.refresh
        Me.BtnUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUndo.Name = "BtnUndo"
        Me.BtnUndo.Size = New System.Drawing.Size(136, 59)
        Me.BtnUndo.Text = "​   ត្រឡប់ បញ្ជាទិញ   "
        Me.BtnUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnUndo.Visible = False
        '
        'GridPurchaseOrder
        '
        Me.GridPurchaseOrder.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridPurchaseOrder.ColumnAutoResize = True
        GridPurchaseOrder_DesignTimeLayout.LayoutString = resources.GetString("GridPurchaseOrder_DesignTimeLayout.LayoutString")
        Me.GridPurchaseOrder.DesignTimeLayout = GridPurchaseOrder_DesignTimeLayout
        Me.GridPurchaseOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPurchaseOrder.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridPurchaseOrder.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!)
        Me.GridPurchaseOrder.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridPurchaseOrder.GroupByBoxVisible = False
        Me.GridPurchaseOrder.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridPurchaseOrder.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridPurchaseOrder.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridPurchaseOrder.Location = New System.Drawing.Point(0, 0)
        Me.GridPurchaseOrder.Name = "GridPurchaseOrder"
        Me.GridPurchaseOrder.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.GridPurchaseOrder.RecordNavigator = True
        Me.GridPurchaseOrder.Size = New System.Drawing.Size(877, 293)
        Me.GridPurchaseOrder.TabIndex = 5
        Me.GridPurchaseOrder.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridPurchaseOrder.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!)
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 65)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridPurchaseOrder)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(879, 644)
        Me.SplitContainer1.SplitterDistance = 295
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridPurchaseDetail)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(877, 344)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "បញ្ជី បញ្ជាទិញ"
        '
        'GridPurchaseDetail
        '
        Me.GridPurchaseDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridPurchaseDetail.ColumnAutoResize = True
        Me.GridPurchaseDetail.ContextMenuStrip = Me.ContextAddRemoveItem
        GridPurchaseDetail_DesignTimeLayout.LayoutString = resources.GetString("GridPurchaseDetail_DesignTimeLayout.LayoutString")
        Me.GridPurchaseDetail.DesignTimeLayout = GridPurchaseDetail_DesignTimeLayout
        Me.GridPurchaseDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPurchaseDetail.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPurchaseDetail.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridPurchaseDetail.GroupByBoxVisible = False
        Me.GridPurchaseDetail.HeaderFormatStyle.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPurchaseDetail.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridPurchaseDetail.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridPurchaseDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridPurchaseDetail.Location = New System.Drawing.Point(2, 31)
        Me.GridPurchaseDetail.Name = "GridPurchaseDetail"
        Me.GridPurchaseDetail.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.GridPurchaseDetail.RecordNavigator = True
        Me.GridPurchaseDetail.RowHeaderFormatStyle.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridPurchaseDetail.Size = New System.Drawing.Size(873, 311)
        Me.GridPurchaseDetail.TabIndex = 6
        Me.GridPurchaseDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridPurchaseDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'ContextAddRemoveItem
        '
        Me.ContextAddRemoveItem.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAddProduct, Me.ToolStripMenuItem1, Me.BtnRemoveProduct})
        Me.ContextAddRemoveItem.Name = "ContextMenuStrip1"
        Me.ContextAddRemoveItem.Size = New System.Drawing.Size(227, 58)
        '
        'BtnAddProduct
        '
        Me.BtnAddProduct.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddProduct.ForeColor = System.Drawing.Color.Blue
        Me.BtnAddProduct.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.add
        Me.BtnAddProduct.Name = "BtnAddProduct"
        Me.BtnAddProduct.Size = New System.Drawing.Size(226, 24)
        Me.BtnAddProduct.Text = "Add product order"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(223, 6)
        '
        'BtnRemoveProduct
        '
        Me.BtnRemoveProduct.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemoveProduct.ForeColor = System.Drawing.Color.Blue
        Me.BtnRemoveProduct.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.delete_appointment
        Me.BtnRemoveProduct.Name = "BtnRemoveProduct"
        Me.BtnRemoveProduct.Size = New System.Drawing.Size(226, 24)
        Me.BtnRemoveProduct.Text = "Remove product order"
        '
        'UiPanelManager1
        '
        Me.UiPanelManager1.BackColorAutoHideStrip = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UiPanelManager1.BackColorGradientAutoHideStrip = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UiPanelManager1.BackColorGradientResizeBar = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UiPanelManager1.BackColorResizeBar = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UiPanelManager1.BackColorSplitter = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UiPanelManager1.ContainerControl = Me
        Me.UiPanelManager1.DefaultPanelSettings.InnerContainerFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UiPanelManager1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom
        Me.UiPanelManager1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
        Me.uiPanel0.Id = New System.Guid("d73850b8-646e-4db3-947a-b31100fe458d")
        Me.UiPanelManager1.Panels.Add(Me.uiPanel0)
        '
        'Design Time Panel Info:
        '
        Me.UiPanelManager1.BeginPanelInfo()
        Me.UiPanelManager1.AddDockPanelInfo(New System.Guid("d73850b8-646e-4db3-947a-b31100fe458d"), Janus.Windows.UI.Dock.PanelDockStyle.Right, New System.Drawing.Size(266, 644), True)
        Me.UiPanelManager1.AddFloatingPanelInfo(New System.Guid("d73850b8-646e-4db3-947a-b31100fe458d"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.UiPanelManager1.EndPanelInfo()
        '
        'uiPanel0
        '
        Me.uiPanel0.CaptionFormatStyle.FontSize = 12.0!
        Me.uiPanel0.CaptionFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.uiPanel0.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.[False]
        Me.uiPanel0.InnerContainer = Me.uiPanel0Container
        Me.uiPanel0.Location = New System.Drawing.Point(882, 65)
        Me.uiPanel0.Margin = New System.Windows.Forms.Padding(2)
        Me.uiPanel0.Name = "uiPanel0"
        Me.uiPanel0.Size = New System.Drawing.Size(266, 644)
        Me.uiPanel0.TabIndex = 4
        Me.uiPanel0.Text = "Purchase order Utility"
        '
        'uiPanel0Container
        '
        Me.uiPanel0Container.Controls.Add(Me.GroupBox2)
        Me.uiPanel0Container.Controls.Add(Me.GroupBox4)
        Me.uiPanel0Container.Location = New System.Drawing.Point(5, 25)
        Me.uiPanel0Container.Margin = New System.Windows.Forms.Padding(2)
        Me.uiPanel0Container.Name = "uiPanel0Container"
        Me.uiPanel0Container.Size = New System.Drawing.Size(260, 618)
        Me.uiPanel0Container.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtPurchashNo)
        Me.GroupBox2.Controls.Add(Me.ChPurchaseNo)
        Me.GroupBox2.Controls.Add(Me.ChSupplier)
        Me.GroupBox2.Controls.Add(Me.TxtSupplier)
        Me.GroupBox2.Controls.Add(Me.BntFind)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Kh Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(260, 618)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ស្វែងរក ដោយ"
        '
        'TxtPurchashNo
        '
        Me.TxtPurchashNo.Enabled = False
        Me.TxtPurchashNo.Location = New System.Drawing.Point(15, 259)
        Me.TxtPurchashNo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPurchashNo.Name = "TxtPurchashNo"
        Me.TxtPurchashNo.Size = New System.Drawing.Size(217, 32)
        Me.TxtPurchashNo.TabIndex = 4
        '
        'ChPurchaseNo
        '
        Me.ChPurchaseNo.AutoSize = True
        Me.ChPurchaseNo.Location = New System.Drawing.Point(15, 226)
        Me.ChPurchaseNo.Margin = New System.Windows.Forms.Padding(2)
        Me.ChPurchaseNo.Name = "ChPurchaseNo"
        Me.ChPurchaseNo.Size = New System.Drawing.Size(114, 29)
        Me.ChPurchaseNo.TabIndex = 3
        Me.ChPurchaseNo.Text = "Purchase No:"
        Me.ChPurchaseNo.UseVisualStyleBackColor = True
        '
        'ChSupplier
        '
        Me.ChSupplier.AutoSize = True
        Me.ChSupplier.Location = New System.Drawing.Point(12, 140)
        Me.ChSupplier.Name = "ChSupplier"
        Me.ChSupplier.Size = New System.Drawing.Size(91, 29)
        Me.ChSupplier.TabIndex = 16
        Me.ChSupplier.Text = "អ្នកផ្គត់ផ្គង់"
        Me.ChSupplier.UseVisualStyleBackColor = True
        '
        'TxtSupplier
        '
        Me.TxtSupplier.Enabled = False
        Me.TxtSupplier.FormattingEnabled = True
        Me.TxtSupplier.Location = New System.Drawing.Point(12, 174)
        Me.TxtSupplier.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSupplier.Name = "TxtSupplier"
        Me.TxtSupplier.Size = New System.Drawing.Size(220, 32)
        Me.TxtSupplier.TabIndex = 1
        '
        'BntFind
        '
        Me.BntFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BntFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BntFind.Location = New System.Drawing.Point(15, 297)
        Me.BntFind.Margin = New System.Windows.Forms.Padding(2)
        Me.BntFind.Name = "BntFind"
        Me.BntFind.Size = New System.Drawing.Size(96, 36)
        Me.BntFind.TabIndex = 5
        Me.BntFind.Text = "ស្វែង រក"
        Me.BntFind.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DateTo)
        Me.GroupBox3.Controls.Add(Me.DateFrom)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 22)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(222, 113)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(63, 64)
        Me.DateTo.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(128, 32)
        Me.DateTo.TabIndex = 1
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(63, 26)
        Me.DateFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(128, 32)
        Me.DateFrom.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadReceived)
        Me.GroupBox4.Controls.Add(Me.RadNotYet)
        Me.GroupBox4.Controls.Add(Me.RadAll)
        Me.GroupBox4.Location = New System.Drawing.Point(17, 530)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(216, 133)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Status Receive:"
        Me.GroupBox4.Visible = False
        '
        'RadReceived
        '
        Me.RadReceived.AutoSize = True
        Me.RadReceived.Location = New System.Drawing.Point(17, 96)
        Me.RadReceived.Margin = New System.Windows.Forms.Padding(2)
        Me.RadReceived.Name = "RadReceived"
        Me.RadReceived.Size = New System.Drawing.Size(83, 17)
        Me.RadReceived.TabIndex = 2
        Me.RadReceived.Text = "Recieved(1)"
        Me.RadReceived.UseVisualStyleBackColor = True
        '
        'RadNotYet
        '
        Me.RadNotYet.AutoSize = True
        Me.RadNotYet.ForeColor = System.Drawing.Color.Blue
        Me.RadNotYet.Location = New System.Drawing.Point(17, 63)
        Me.RadNotYet.Margin = New System.Windows.Forms.Padding(2)
        Me.RadNotYet.Name = "RadNotYet"
        Me.RadNotYet.Size = New System.Drawing.Size(71, 17)
        Me.RadNotYet.TabIndex = 1
        Me.RadNotYet.Text = "Not yet(0)"
        Me.RadNotYet.UseVisualStyleBackColor = True
        '
        'RadAll
        '
        Me.RadAll.AutoSize = True
        Me.RadAll.Checked = True
        Me.RadAll.Location = New System.Drawing.Point(17, 30)
        Me.RadAll.Margin = New System.Windows.Forms.Padding(2)
        Me.RadAll.Name = "RadAll"
        Me.RadAll.Size = New System.Drawing.Size(143, 17)
        Me.RadAll.TabIndex = 0
        Me.RadAll.TabStop = True
        Me.RadAll.Text = "All (Receive and Not yet)"
        Me.RadAll.UseVisualStyleBackColor = True
        '
        'DashboardPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.uiPanel0)
        Me.Controls.Add(Me.ToolProduct)
        Me.Name = "DashboardPurchaseOrder"
        Me.Size = New System.Drawing.Size(1151, 712)
        Me.ToolProduct.ResumeLayout(False)
        Me.ToolProduct.PerformLayout()
        CType(Me.GridPurchaseOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridPurchaseDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextAddRemoveItem.ResumeLayout(False)
        CType(Me.UiPanelManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uiPanel0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uiPanel0.ResumeLayout(False)
        Me.uiPanel0Container.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolProduct As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnReceiveStock As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GridPurchaseOrder As Janus.Windows.GridEX.GridEX
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridPurchaseDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiPanelManager1 As Janus.Windows.UI.Dock.UIPanelManager
    Friend WithEvents uiPanel0 As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents uiPanel0Container As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents BntFind As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadReceived As System.Windows.Forms.RadioButton
    Friend WithEvents RadNotYet As System.Windows.Forms.RadioButton
    Friend WithEvents RadAll As System.Windows.Forms.RadioButton
    Friend WithEvents ChSupplier As System.Windows.Forms.CheckBox
    Friend WithEvents TxtPurchashNo As System.Windows.Forms.TextBox
    Friend WithEvents ChPurchaseNo As System.Windows.Forms.CheckBox
    Friend WithEvents BtnDeleteOrder As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUndo As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnAddProduct As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRemoveProduct As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents ContextAddRemoveItem As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnReceiveProduct As System.Windows.Forms.ToolStripButton

End Class
