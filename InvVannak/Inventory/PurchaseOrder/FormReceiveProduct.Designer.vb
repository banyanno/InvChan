<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReceiveProduct
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
        Dim GridOrderDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReceiveProduct))
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.BtnClose = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnCancel = New System.Windows.Forms.ToolStripButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BtnAddSupply = New System.Windows.Forms.Button
        Me.cboSupplier = New System.Windows.Forms.ComboBox
        Me.LblSuppID = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtSupTelephone = New System.Windows.Forms.TextBox
        Me.TxtSuppAddress = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.LblPurchaseID = New System.Windows.Forms.Label
        Me.txtInvoiceReferrent = New System.Windows.Forms.TextBox
        Me.TxtDateOrder = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.DateReceived = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtPuchaseOrderNo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GridOrderDetail = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnAddProduct = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRemoveProduct = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtTotalKHR = New System.Windows.Forms.TextBox
        Me.TxtTotalUSD = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtTotalTHB = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ErrReceive = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.GridOrderDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.ErrReceive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnClose, Me.ToolStripSeparator4, Me.BtnCancel})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1110, 53)
        Me.ToolStrip2.TabIndex = 14
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'BtnClose
        '
        Me.BtnClose.ForeColor = System.Drawing.Color.Blue
        Me.BtnClose.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.Save
        Me.BtnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(87, 50)
        Me.BtnClose.Text = "     Save     "
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 53)
        '
        'BtnCancel
        '
        Me.BtnCancel.ForeColor = System.Drawing.Color.Blue
        Me.BtnCancel.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.delete_appointment
        Me.BtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(88, 50)
        Me.BtnCancel.Text = "    Cancel   "
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.BtnAddSupply)
        Me.GroupBox4.Controls.Add(Me.cboSupplier)
        Me.GroupBox4.Controls.Add(Me.LblSuppID)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.TxtSupTelephone)
        Me.GroupBox4.Controls.Add(Me.TxtSuppAddress)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(4, 53)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(434, 153)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Select Supplyer"
        '
        'BtnAddSupply
        '
        Me.BtnAddSupply.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddSupply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddSupply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddSupply.Location = New System.Drawing.Point(380, 32)
        Me.BtnAddSupply.Name = "BtnAddSupply"
        Me.BtnAddSupply.Size = New System.Drawing.Size(48, 32)
        Me.BtnAddSupply.TabIndex = 12
        Me.BtnAddSupply.Text = "..."
        Me.BtnAddSupply.UseVisualStyleBackColor = True
        '
        'cboSupplier
        '
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.Location = New System.Drawing.Point(97, 31)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.Size = New System.Drawing.Size(255, 35)
        Me.cboSupplier.TabIndex = 11
        '
        'LblSuppID
        '
        Me.LblSuppID.AutoSize = True
        Me.LblSuppID.Location = New System.Drawing.Point(64, 39)
        Me.LblSuppID.Name = "LblSuppID"
        Me.LblSuppID.Size = New System.Drawing.Size(20, 27)
        Me.LblSuppID.TabIndex = 10
        Me.LblSuppID.Text = "0"
        Me.LblSuppID.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(357, 39)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 27)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "*"
        '
        'TxtSupTelephone
        '
        Me.TxtSupTelephone.BackColor = System.Drawing.Color.White
        Me.TxtSupTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSupTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSupTelephone.Location = New System.Drawing.Point(96, 110)
        Me.TxtSupTelephone.Name = "TxtSupTelephone"
        Me.TxtSupTelephone.ReadOnly = True
        Me.TxtSupTelephone.Size = New System.Drawing.Size(256, 26)
        Me.TxtSupTelephone.TabIndex = 5
        '
        'TxtSuppAddress
        '
        Me.TxtSuppAddress.BackColor = System.Drawing.Color.White
        Me.TxtSuppAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSuppAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSuppAddress.Location = New System.Drawing.Point(96, 75)
        Me.TxtSuppAddress.Name = "TxtSuppAddress"
        Me.TxtSuppAddress.ReadOnly = True
        Me.TxtSuppAddress.Size = New System.Drawing.Size(256, 26)
        Me.TxtSuppAddress.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 27)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Telephone:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 27)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Address:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(7, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 22)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "អ្នកផ្គត់ផ្គង់"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.LblPurchaseID)
        Me.GroupBox3.Controls.Add(Me.txtInvoiceReferrent)
        Me.GroupBox3.Controls.Add(Me.TxtDateOrder)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.DateReceived)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TxtPuchaseOrderNo)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(444, 55)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(655, 151)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Order Info"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(620, 43)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 27)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(326, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 27)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "លេខ យោង:"
        '
        'LblPurchaseID
        '
        Me.LblPurchaseID.AutoSize = True
        Me.LblPurchaseID.Location = New System.Drawing.Point(12, 107)
        Me.LblPurchaseID.Name = "LblPurchaseID"
        Me.LblPurchaseID.Size = New System.Drawing.Size(20, 27)
        Me.LblPurchaseID.TabIndex = 11
        Me.LblPurchaseID.Text = "0"
        Me.LblPurchaseID.Visible = False
        '
        'txtInvoiceReferrent
        '
        Me.txtInvoiceReferrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInvoiceReferrent.Location = New System.Drawing.Point(421, 34)
        Me.txtInvoiceReferrent.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInvoiceReferrent.Name = "txtInvoiceReferrent"
        Me.txtInvoiceReferrent.Size = New System.Drawing.Size(195, 36)
        Me.txtInvoiceReferrent.TabIndex = 11
        '
        'TxtDateOrder
        '
        Me.TxtDateOrder.CustomFormat = "dd/MM/yyyy"
        Me.TxtDateOrder.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDateOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtDateOrder.Location = New System.Drawing.Point(142, 88)
        Me.TxtDateOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDateOrder.Name = "TxtDateOrder"
        Me.TxtDateOrder.Size = New System.Drawing.Size(151, 32)
        Me.TxtDateOrder.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(620, 93)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 27)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(306, 43)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 27)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "*"
        '
        'DateReceived
        '
        Me.DateReceived.Checked = False
        Me.DateReceived.CustomFormat = "dd/MM/yyyy"
        Me.DateReceived.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateReceived.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateReceived.Location = New System.Drawing.Point(421, 94)
        Me.DateReceived.Margin = New System.Windows.Forms.Padding(2)
        Me.DateReceived.Name = "DateReceived"
        Me.DateReceived.ShowCheckBox = True
        Me.DateReceived.Size = New System.Drawing.Size(195, 26)
        Me.DateReceived.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(326, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ថ្ងៃ ទទួល:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 27)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "ថ្ងៃ បញ្ជាទិញ:"
        '
        'TxtPuchaseOrderNo
        '
        Me.TxtPuchaseOrderNo.BackColor = System.Drawing.Color.White
        Me.TxtPuchaseOrderNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPuchaseOrderNo.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!)
        Me.TxtPuchaseOrderNo.Location = New System.Drawing.Point(142, 34)
        Me.TxtPuchaseOrderNo.Name = "TxtPuchaseOrderNo"
        Me.TxtPuchaseOrderNo.ReadOnly = True
        Me.TxtPuchaseOrderNo.Size = New System.Drawing.Size(151, 36)
        Me.TxtPuchaseOrderNo.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 27)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "លេខ បញ្ជាទិញ:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.GridOrderDetail)
        Me.GroupBox5.Controls.Add(Me.ToolStrip1)
        Me.GroupBox5.Location = New System.Drawing.Point(4, 211)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(1090, 403)
        Me.GroupBox5.TabIndex = 17
        Me.GroupBox5.TabStop = False
        '
        'GridOrderDetail
        '
        Me.GridOrderDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridOrderDetail_DesignTimeLayout.LayoutString = resources.GetString("GridOrderDetail_DesignTimeLayout.LayoutString")
        Me.GridOrderDetail.DesignTimeLayout = GridOrderDetail_DesignTimeLayout
        Me.GridOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridOrderDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.GridOrderDetail.GroupByBoxFormatStyle.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GridOrderDetail.GroupByBoxFormatStyle.BackColorGradient = System.Drawing.SystemColors.ControlDark
        Me.GridOrderDetail.GroupByBoxVisible = False
        Me.GridOrderDetail.HeaderFormatStyle.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridOrderDetail.HeaderFormatStyle.FontSize = 9.0!
        Me.GridOrderDetail.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridOrderDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridOrderDetail.Location = New System.Drawing.Point(2, 78)
        Me.GridOrderDetail.Name = "GridOrderDetail"
        Me.GridOrderDetail.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.GridOrderDetail.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridOrderDetail.RecordNavigator = True
        Me.GridOrderDetail.Size = New System.Drawing.Size(1086, 323)
        Me.GridOrderDetail.TabIndex = 14
        Me.GridOrderDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAddProduct, Me.ToolStripSeparator6, Me.BtnRemoveProduct, Me.ToolStripSeparator7})
        Me.ToolStrip1.Location = New System.Drawing.Point(2, 31)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1086, 47)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.TxtTotalKHR)
        Me.GroupBox2.Controls.Add(Me.TxtTotalUSD)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(4, 630)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(657, 158)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ចំននួនទឹកប្រាក់សរុប ត្រូវបង់"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox6.Location = New System.Drawing.Point(328, 20)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Size = New System.Drawing.Size(315, 126)
        Me.GroupBox6.TabIndex = 12
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "កំណត់សំគាល់"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Kh Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(13, 34)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(246, 75)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "- និងត្រូវsave ចូលក្នុង Account Payable" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- និងត្រូវ Update inventory " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtTotalKHR
        '
        Me.TxtTotalKHR.BackColor = System.Drawing.Color.White
        Me.TxtTotalKHR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalKHR.Font = New System.Drawing.Font("Kh Battambang", 12.0!)
        Me.TxtTotalKHR.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalKHR.Location = New System.Drawing.Point(129, 102)
        Me.TxtTotalKHR.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalKHR.Name = "TxtTotalKHR"
        Me.TxtTotalKHR.ReadOnly = True
        Me.TxtTotalKHR.Size = New System.Drawing.Size(185, 37)
        Me.TxtTotalKHR.TabIndex = 10
        Me.TxtTotalKHR.Text = "0"
        Me.TxtTotalKHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotalUSD
        '
        Me.TxtTotalUSD.BackColor = System.Drawing.Color.White
        Me.TxtTotalUSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalUSD.Font = New System.Drawing.Font("Kh Battambang", 12.0!)
        Me.TxtTotalUSD.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalUSD.Location = New System.Drawing.Point(129, 42)
        Me.TxtTotalUSD.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalUSD.Name = "TxtTotalUSD"
        Me.TxtTotalUSD.ReadOnly = True
        Me.TxtTotalUSD.Size = New System.Drawing.Size(185, 37)
        Me.TxtTotalUSD.TabIndex = 9
        Me.TxtTotalUSD.Text = "0"
        Me.TxtTotalUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 112)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 27)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "តំលៃ សរុប KHR:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 52)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 27)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "តំលៃ សរុប USD:"
        '
        'TxtTotalTHB
        '
        Me.TxtTotalTHB.BackColor = System.Drawing.Color.White
        Me.TxtTotalTHB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalTHB.Font = New System.Drawing.Font("Kh Battambang", 10.0!)
        Me.TxtTotalTHB.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalTHB.Location = New System.Drawing.Point(794, 683)
        Me.TxtTotalTHB.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalTHB.Name = "TxtTotalTHB"
        Me.TxtTotalTHB.ReadOnly = True
        Me.TxtTotalTHB.Size = New System.Drawing.Size(185, 32)
        Me.TxtTotalTHB.TabIndex = 11
        Me.TxtTotalTHB.Text = "0"
        Me.TxtTotalTHB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTotalTHB.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(676, 688)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 27)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "តំលៃ សរុប THB:"
        Me.Label5.Visible = False
        '
        'ErrReceive
        '
        Me.ErrReceive.ContainerControl = Me
        '
        'FormReceiveProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1110, 790)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.TxtTotalTHB)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "FormReceiveProduct"
        Me.ShowInTaskbar = False
        Me.Text = "Receive Product"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.GridOrderDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.ErrReceive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LblSuppID As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtSupTelephone As System.Windows.Forms.TextBox
    Friend WithEvents TxtSuppAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LblPurchaseID As System.Windows.Forms.Label
    Friend WithEvents TxtDateOrder As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPuchaseOrderNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceReferrent As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateReceived As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalTHB As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalKHR As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalUSD As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnAddProduct As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRemoveProduct As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GridOrderDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnAddSupply As System.Windows.Forms.Button
    Friend WithEvents ErrReceive As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
