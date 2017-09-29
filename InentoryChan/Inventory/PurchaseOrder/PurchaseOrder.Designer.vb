<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseOrder
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
        Dim GridSupplier_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PurchaseOrder))
        Dim GridOrderDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.BtnSave = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnAddProduct = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRemoveProduct = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnFindProduct = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnCancel = New System.Windows.Forms.ToolStripButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.TxtNote = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtTotalB = New System.Windows.Forms.TextBox
        Me.TxtTotalD = New System.Windows.Forms.TextBox
        Me.TxtTotalR = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtnAddSupply = New System.Windows.Forms.Button
        Me.GridSupplier = New Janus.Windows.GridEX.GridEX
        Me.TxtSupplierName = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GridOrderDetail = New Janus.Windows.GridEX.GridEX
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.DatePurchaseOrder = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtPuchaseOrderNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtSupplierNameDis = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtSupTelephone = New System.Windows.Forms.TextBox
        Me.TxtSuppAddress = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ErrorPurchaseOrder = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label14 = New System.Windows.Forms.Label
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GridOrderDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorPurchaseOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiTab1
        '
        Me.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab1.Location = New System.Drawing.Point(0, 0)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom
        Me.UiTab1.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UiTab1.Size = New System.Drawing.Size(1282, 703)
        Me.UiTab1.TabIndex = 1
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1})
        Me.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.ToolStrip2)
        Me.UiTabPage1.Controls.Add(Me.GroupBox5)
        Me.UiTabPage1.Controls.Add(Me.SplitContainer1)
        Me.UiTabPage1.Controls.Add(Me.TxtTotalB)
        Me.UiTabPage1.Controls.Add(Me.GroupBox2)
        Me.UiTabPage1.Controls.Add(Me.GroupBox1)
        Me.UiTabPage1.Controls.Add(Me.Label8)
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(1280, 681)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Purchash Order Information"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnSave, Me.ToolStripSeparator4, Me.BtnAddProduct, Me.ToolStripSeparator6, Me.BtnRemoveProduct, Me.ToolStripSeparator7, Me.BtnFindProduct, Me.ToolStripSeparator8, Me.BtnCancel})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1280, 47)
        Me.ToolStrip2.TabIndex = 12
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'BtnSave
        '
        Me.BtnSave.ForeColor = System.Drawing.Color.Blue
        Me.BtnSave.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.Save
        Me.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(65, 44)
        Me.BtnSave.Text = "     Save     "
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 47)
        '
        'BtnAddProduct
        '
        Me.BtnAddProduct.ForeColor = System.Drawing.Color.Blue
        Me.BtnAddProduct.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources._1404566949_7
        Me.BtnAddProduct.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAddProduct.Name = "BtnAddProduct"
        Me.BtnAddProduct.Size = New System.Drawing.Size(78, 44)
        Me.BtnAddProduct.Text = "Add Product"
        Me.BtnAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 47)
        '
        'BtnRemoveProduct
        '
        Me.BtnRemoveProduct.ForeColor = System.Drawing.Color.Blue
        Me.BtnRemoveProduct.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources._1404566816_8
        Me.BtnRemoveProduct.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRemoveProduct.Name = "BtnRemoveProduct"
        Me.BtnRemoveProduct.Size = New System.Drawing.Size(99, 44)
        Me.BtnRemoveProduct.Text = "Remove Product"
        Me.BtnRemoveProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 47)
        Me.ToolStripSeparator7.Visible = False
        '
        'BtnFindProduct
        '
        Me.BtnFindProduct.ForeColor = System.Drawing.Color.Blue
        Me.BtnFindProduct.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.Search1
        Me.BtnFindProduct.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFindProduct.Name = "BtnFindProduct"
        Me.BtnFindProduct.Size = New System.Drawing.Size(79, 44)
        Me.BtnFindProduct.Text = "Find Product"
        Me.BtnFindProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnFindProduct.Visible = False
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 47)
        '
        'BtnCancel
        '
        Me.BtnCancel.ForeColor = System.Drawing.Color.Blue
        Me.BtnCancel.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.delete_appointment
        Me.BtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(68, 44)
        Me.BtnCancel.Text = "    Cancel   "
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.TxtNote)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.TxtTotalD)
        Me.GroupBox5.Controls.Add(Me.TxtTotalR)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Red
        Me.GroupBox5.Location = New System.Drawing.Point(592, 49)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(590, 134)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "ចំនួន លុយសរុប"
        '
        'TxtNote
        '
        Me.TxtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNote.Location = New System.Drawing.Point(242, 51)
        Me.TxtNote.Multiline = True
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.Size = New System.Drawing.Size(335, 63)
        Me.TxtNote.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(238, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 24)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "កំណត់សំគាល់"
        '
        'TxtTotalB
        '
        Me.TxtTotalB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalB.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalB.Location = New System.Drawing.Point(1188, 124)
        Me.TxtTotalB.Name = "TxtTotalB"
        Me.TxtTotalB.ReadOnly = True
        Me.TxtTotalB.Size = New System.Drawing.Size(47, 27)
        Me.TxtTotalB.TabIndex = 5
        Me.TxtTotalB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTotalB.Visible = False
        '
        'TxtTotalD
        '
        Me.TxtTotalD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalD.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalD.Location = New System.Drawing.Point(67, 51)
        Me.TxtTotalD.Name = "TxtTotalD"
        Me.TxtTotalD.ReadOnly = True
        Me.TxtTotalD.Size = New System.Drawing.Size(169, 27)
        Me.TxtTotalD.TabIndex = 4
        Me.TxtTotalD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotalR
        '
        Me.TxtTotalR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalR.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalR.Location = New System.Drawing.Point(67, 88)
        Me.TxtTotalR.Name = "TxtTotalR"
        Me.TxtTotalR.ReadOnly = True
        Me.TxtTotalR.Size = New System.Drawing.Size(169, 27)
        Me.TxtTotalR.TabIndex = 3
        Me.TxtTotalR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1180, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Total THB:"
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 24)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "សរុប($) :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "សរុប(៛) :"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 193)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Size = New System.Drawing.Size(1594, 482)
        Me.SplitContainer1.SplitterDistance = 336
        Me.SplitContainer1.TabIndex = 11
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.BtnAddSupply)
        Me.GroupBox3.Controls.Add(Me.GridSupplier)
        Me.GroupBox3.Controls.Add(Me.TxtSupplierName)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Kh Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(334, 480)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "អ្នកផ្គត់ផ្គង់"
        '
        'BtnAddSupply
        '
        Me.BtnAddSupply.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddSupply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddSupply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddSupply.Location = New System.Drawing.Point(280, 31)
        Me.BtnAddSupply.Name = "BtnAddSupply"
        Me.BtnAddSupply.Size = New System.Drawing.Size(48, 35)
        Me.BtnAddSupply.TabIndex = 2
        Me.BtnAddSupply.Text = "..."
        Me.BtnAddSupply.UseVisualStyleBackColor = True
        '
        'GridSupplier
        '
        Me.GridSupplier.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridSupplier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridSupplier_DesignTimeLayout.LayoutString = resources.GetString("GridSupplier_DesignTimeLayout.LayoutString")
        Me.GridSupplier.DesignTimeLayout = GridSupplier_DesignTimeLayout
        Me.GridSupplier.FlatBorderInHeaders = False
        Me.GridSupplier.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridSupplier.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridSupplier.GroupByBoxVisible = False
        Me.GridSupplier.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridSupplier.Location = New System.Drawing.Point(3, 72)
        Me.GridSupplier.Name = "GridSupplier"
        Me.GridSupplier.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.GridSupplier.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridSupplier.RecordNavigator = True
        Me.GridSupplier.Size = New System.Drawing.Size(325, 405)
        Me.GridSupplier.TabIndex = 1
        Me.GridSupplier.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'TxtSupplierName
        '
        Me.TxtSupplierName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSupplierName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSupplierName.Location = New System.Drawing.Point(3, 31)
        Me.TxtSupplierName.Name = "TxtSupplierName"
        Me.TxtSupplierName.Size = New System.Drawing.Size(271, 35)
        Me.TxtSupplierName.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.GridOrderDetail)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1252, 480)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "តារាងមុខទំនិញ"
        '
        'GridOrderDetail
        '
        Me.GridOrderDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridOrderDetail_DesignTimeLayout.LayoutString = resources.GetString("GridOrderDetail_DesignTimeLayout.LayoutString")
        Me.GridOrderDetail.DesignTimeLayout = GridOrderDetail_DesignTimeLayout
        Me.GridOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridOrderDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.GridOrderDetail.GroupByBoxVisible = False
        Me.GridOrderDetail.HeaderFormatStyle.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridOrderDetail.HeaderFormatStyle.FontSize = 9.0!
        Me.GridOrderDetail.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridOrderDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridOrderDetail.Location = New System.Drawing.Point(3, 32)
        Me.GridOrderDetail.Name = "GridOrderDetail"
        Me.GridOrderDetail.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.GridOrderDetail.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridOrderDetail.RecordNavigator = True
        Me.GridOrderDetail.Size = New System.Drawing.Size(1246, 445)
        Me.GridOrderDetail.TabIndex = 1
        Me.GridOrderDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.DatePurchaseOrder)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtPuchaseOrderNo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(321, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(265, 134)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "បញ្ជាទិញ ទំនិញ"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(240, 42)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 24)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "*"
        '
        'DatePurchaseOrder
        '
        Me.DatePurchaseOrder.CustomFormat = "dd/MM/yyyy"
        Me.DatePurchaseOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePurchaseOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatePurchaseOrder.Location = New System.Drawing.Point(109, 76)
        Me.DatePurchaseOrder.Name = "DatePurchaseOrder"
        Me.DatePurchaseOrder.Size = New System.Drawing.Size(127, 26)
        Me.DatePurchaseOrder.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 24)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ថ្ងៃបញ្ជាទិញ:"
        '
        'TxtPuchaseOrderNo
        '
        Me.TxtPuchaseOrderNo.BackColor = System.Drawing.Color.White
        Me.TxtPuchaseOrderNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPuchaseOrderNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPuchaseOrderNo.Location = New System.Drawing.Point(109, 40)
        Me.TxtPuchaseOrderNo.Name = "TxtPuchaseOrderNo"
        Me.TxtPuchaseOrderNo.ReadOnly = True
        Me.TxtPuchaseOrderNo.Size = New System.Drawing.Size(127, 26)
        Me.TxtPuchaseOrderNo.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "លេខបញ្ជាទិញ:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtSupplierNameDis)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtSupTelephone)
        Me.GroupBox1.Controls.Add(Me.TxtSuppAddress)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(5, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 134)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Supplyer"
        '
        'TxtSupplierNameDis
        '
        Me.TxtSupplierNameDis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSupplierNameDis.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSupplierNameDis.Location = New System.Drawing.Point(97, 19)
        Me.TxtSupplierNameDis.Name = "TxtSupplierNameDis"
        Me.TxtSupplierNameDis.ReadOnly = True
        Me.TxtSupplierNameDis.Size = New System.Drawing.Size(196, 30)
        Me.TxtSupplierNameDis.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(298, 97)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(298, 64)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(298, 28)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "*"
        '
        'TxtSupTelephone
        '
        Me.TxtSupTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSupTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSupTelephone.Location = New System.Drawing.Point(97, 89)
        Me.TxtSupTelephone.Name = "TxtSupTelephone"
        Me.TxtSupTelephone.ReadOnly = True
        Me.TxtSupTelephone.Size = New System.Drawing.Size(197, 26)
        Me.TxtSupTelephone.TabIndex = 5
        '
        'TxtSuppAddress
        '
        Me.TxtSuppAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSuppAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSuppAddress.Location = New System.Drawing.Point(97, 55)
        Me.TxtSuppAddress.Name = "TxtSuppAddress"
        Me.TxtSuppAddress.ReadOnly = True
        Me.TxtSuppAddress.Size = New System.Drawing.Size(197, 26)
        Me.TxtSuppAddress.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Telephone:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "អ្នកផ្គត់ផ្គង់"
        '
        'ErrorPurchaseOrder
        '
        Me.ErrorPurchaseOrder.ContainerControl = Me
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(357, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(137, 24)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "អត្រាប្តូរប្រាក់ 1$=4,100៛"
        '
        'PurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1282, 703)
        Me.Controls.Add(Me.UiTab1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PurchaseOrder"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Order"
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
        CType(Me.GridSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.GridOrderDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorPurchaseOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GridOrderDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtSupTelephone As System.Windows.Forms.TextBox
    Friend WithEvents TxtSuppAddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtPuchaseOrderNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DatePurchaseOrder As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtTotalB As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalD As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalR As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents TxtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ErrorPurchaseOrder As System.Windows.Forms.ErrorProvider
    Friend WithEvents BtnAddProduct As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRemoveProduct As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnFindProduct As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TxtSupplierName As System.Windows.Forms.TextBox
    Friend WithEvents GridSupplier As Janus.Windows.GridEX.GridEX
    Friend WithEvents TxtSupplierNameDis As System.Windows.Forms.TextBox
    Friend WithEvents BtnAddSupply As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
