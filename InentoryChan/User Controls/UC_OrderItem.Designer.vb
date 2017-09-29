<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_OrderItem
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
        Dim OrderList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_OrderItem))
        Dim MyOrderList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Order = New System.Windows.Forms.TabControl
        Me.TabNewOrder = New System.Windows.Forms.TabPage
        Me.Label12 = New System.Windows.Forms.Label
        Me.cboLocation = New System.Windows.Forms.ComboBox
        Me.picItem = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLastCost = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.chkBarcode = New System.Windows.Forms.CheckBox
        Me.btnPreview = New System.Windows.Forms.Button
        Me.btnOrder = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.txttotal = New System.Windows.Forms.TextBox
        Me.btnRemove = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.OrderList = New Janus.Windows.GridEX.GridEX
        Me.cboCategory = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtIQty = New System.Windows.Forms.TextBox
        Me.CboItem = New System.Windows.Forms.ComboBox
        Me.txtCurQty = New System.Windows.Forms.TextBox
        Me.CboUnit = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tabMyOrder = New System.Windows.Forms.TabPage
        Me.btnView = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboOrderNo = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboStatus = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtTo = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtFrom = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtTotalMyOrder = New System.Windows.Forms.TextBox
        Me.MyOrderList = New Janus.Windows.GridEX.GridEX
        Me.Order.SuspendLayout()
        Me.TabNewOrder.SuspendLayout()
        CType(Me.picItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMyOrder.SuspendLayout()
        CType(Me.MyOrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Order
        '
        Me.Order.Controls.Add(Me.TabNewOrder)
        Me.Order.Controls.Add(Me.tabMyOrder)
        Me.Order.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Order.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Order.Location = New System.Drawing.Point(0, 0)
        Me.Order.Name = "Order"
        Me.Order.SelectedIndex = 0
        Me.Order.Size = New System.Drawing.Size(953, 651)
        Me.Order.TabIndex = 0
        '
        'TabNewOrder
        '
        Me.TabNewOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TabNewOrder.Controls.Add(Me.Label12)
        Me.TabNewOrder.Controls.Add(Me.cboLocation)
        Me.TabNewOrder.Controls.Add(Me.picItem)
        Me.TabNewOrder.Controls.Add(Me.Label5)
        Me.TabNewOrder.Controls.Add(Me.Label2)
        Me.TabNewOrder.Controls.Add(Me.txtLastCost)
        Me.TabNewOrder.Controls.Add(Me.Label1)
        Me.TabNewOrder.Controls.Add(Me.txtBarcode)
        Me.TabNewOrder.Controls.Add(Me.chkBarcode)
        Me.TabNewOrder.Controls.Add(Me.btnPreview)
        Me.TabNewOrder.Controls.Add(Me.btnOrder)
        Me.TabNewOrder.Controls.Add(Me.Label10)
        Me.TabNewOrder.Controls.Add(Me.txttotal)
        Me.TabNewOrder.Controls.Add(Me.btnRemove)
        Me.TabNewOrder.Controls.Add(Me.btnAdd)
        Me.TabNewOrder.Controls.Add(Me.OrderList)
        Me.TabNewOrder.Controls.Add(Me.cboCategory)
        Me.TabNewOrder.Controls.Add(Me.Label4)
        Me.TabNewOrder.Controls.Add(Me.txtIQty)
        Me.TabNewOrder.Controls.Add(Me.CboItem)
        Me.TabNewOrder.Controls.Add(Me.txtCurQty)
        Me.TabNewOrder.Controls.Add(Me.CboUnit)
        Me.TabNewOrder.Controls.Add(Me.Label3)
        Me.TabNewOrder.Location = New System.Drawing.Point(4, 25)
        Me.TabNewOrder.Name = "TabNewOrder"
        Me.TabNewOrder.Padding = New System.Windows.Forms.Padding(3)
        Me.TabNewOrder.Size = New System.Drawing.Size(945, 622)
        Me.TabNewOrder.TabIndex = 0
        Me.TabNewOrder.Text = "New Order"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(12, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 16)
        Me.Label12.TabIndex = 126
        Me.Label12.Text = "Select Location:"
        '
        'cboLocation
        '
        Me.cboLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLocation.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.Location = New System.Drawing.Point(153, 53)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(147, 26)
        Me.cboLocation.TabIndex = 125
        '
        'picItem
        '
        Me.picItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picItem.Location = New System.Drawing.Point(738, 17)
        Me.picItem.Name = "picItem"
        Me.picItem.Size = New System.Drawing.Size(188, 120)
        Me.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picItem.TabIndex = 124
        Me.picItem.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(382, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "Unit:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(454, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "Price:"
        '
        'txtLastCost
        '
        Me.txtLastCost.Enabled = False
        Me.txtLastCost.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastCost.Location = New System.Drawing.Point(457, 113)
        Me.txtLastCost.Name = "txtLastCost"
        Me.txtLastCost.ReadOnly = True
        Me.txtLastCost.Size = New System.Drawing.Size(73, 26)
        Me.txtLastCost.TabIndex = 120
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(303, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "QTY:"
        '
        'txtBarcode
        '
        Me.txtBarcode.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(153, 17)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(147, 23)
        Me.txtBarcode.TabIndex = 118
        Me.txtBarcode.Visible = False
        '
        'chkBarcode
        '
        Me.chkBarcode.AutoSize = True
        Me.chkBarcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.chkBarcode.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBarcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkBarcode.Location = New System.Drawing.Point(15, 19)
        Me.chkBarcode.Name = "chkBarcode"
        Me.chkBarcode.Size = New System.Drawing.Size(118, 20)
        Me.chkBarcode.TabIndex = 117
        Me.chkBarcode.Text = "Scan Barcode"
        Me.chkBarcode.UseVisualStyleBackColor = False
        '
        'btnPreview
        '
        Me.btnPreview.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPreview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnPreview.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.ForeColor = System.Drawing.Color.Black
        Me.btnPreview.Location = New System.Drawing.Point(738, 567)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(91, 31)
        Me.btnPreview.TabIndex = 116
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnOrder.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.ForeColor = System.Drawing.Color.Black
        Me.btnOrder.Location = New System.Drawing.Point(835, 567)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(91, 31)
        Me.btnOrder.TabIndex = 114
        Me.btnOrder.Text = "Send"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(657, 521)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 18)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "TOTAL :"
        '
        'txttotal
        '
        Me.txttotal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttotal.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(746, 515)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(180, 31)
        Me.txttotal.TabIndex = 112
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRemove
        '
        Me.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnRemove.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.Location = New System.Drawing.Point(623, 112)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(81, 27)
        Me.btnRemove.TabIndex = 111
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(536, 112)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(81, 27)
        Me.btnAdd.TabIndex = 110
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'OrderList
        '
        Me.OrderList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        OrderList_DesignTimeLayout.LayoutString = resources.GetString("OrderList_DesignTimeLayout.LayoutString")
        Me.OrderList.DesignTimeLayout = OrderList_DesignTimeLayout
        Me.OrderList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderList.GroupByBoxVisible = False
        Me.OrderList.Location = New System.Drawing.Point(13, 158)
        Me.OrderList.Name = "OrderList"
        Me.OrderList.Size = New System.Drawing.Size(913, 339)
        Me.OrderList.TabIndex = 108
        Me.OrderList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'cboCategory
        '
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(13, 113)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(134, 26)
        Me.cboCategory.TabIndex = 107
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(10, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Category:"
        '
        'txtIQty
        '
        Me.txtIQty.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIQty.Location = New System.Drawing.Point(306, 113)
        Me.txtIQty.Name = "txtIQty"
        Me.txtIQty.Size = New System.Drawing.Size(73, 26)
        Me.txtIQty.TabIndex = 105
        '
        'CboItem
        '
        Me.CboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboItem.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.CboItem.FormattingEnabled = True
        Me.CboItem.Location = New System.Drawing.Point(153, 113)
        Me.CboItem.Name = "CboItem"
        Me.CboItem.Size = New System.Drawing.Size(147, 26)
        Me.CboItem.TabIndex = 104
        '
        'txtCurQty
        '
        Me.txtCurQty.Enabled = False
        Me.txtCurQty.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurQty.Location = New System.Drawing.Point(675, 17)
        Me.txtCurQty.Name = "txtCurQty"
        Me.txtCurQty.ReadOnly = True
        Me.txtCurQty.Size = New System.Drawing.Size(56, 26)
        Me.txtCurQty.TabIndex = 102
        Me.txtCurQty.Visible = False
        '
        'CboUnit
        '
        Me.CboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboUnit.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.CboUnit.FormattingEnabled = True
        Me.CboUnit.Location = New System.Drawing.Point(385, 113)
        Me.CboUnit.Name = "CboUnit"
        Me.CboUnit.Size = New System.Drawing.Size(66, 26)
        Me.CboUnit.TabIndex = 101
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(150, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Item Name: "
        '
        'tabMyOrder
        '
        Me.tabMyOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.tabMyOrder.Controls.Add(Me.btnView)
        Me.tabMyOrder.Controls.Add(Me.Label11)
        Me.tabMyOrder.Controls.Add(Me.cboOrderNo)
        Me.tabMyOrder.Controls.Add(Me.Label9)
        Me.tabMyOrder.Controls.Add(Me.cboStatus)
        Me.tabMyOrder.Controls.Add(Me.Label8)
        Me.tabMyOrder.Controls.Add(Me.dtTo)
        Me.tabMyOrder.Controls.Add(Me.Label7)
        Me.tabMyOrder.Controls.Add(Me.dtFrom)
        Me.tabMyOrder.Controls.Add(Me.Label6)
        Me.tabMyOrder.Controls.Add(Me.txtTotalMyOrder)
        Me.tabMyOrder.Controls.Add(Me.MyOrderList)
        Me.tabMyOrder.Location = New System.Drawing.Point(4, 25)
        Me.tabMyOrder.Name = "tabMyOrder"
        Me.tabMyOrder.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMyOrder.Size = New System.Drawing.Size(945, 622)
        Me.tabMyOrder.TabIndex = 2
        Me.tabMyOrder.Text = "My Orders"
        '
        'btnView
        '
        Me.btnView.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnView.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.Black
        Me.btnView.Location = New System.Drawing.Point(840, 557)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(89, 32)
        Me.btnView.TabIndex = 129
        Me.btnView.Text = "Preview"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(457, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 128
        Me.Label11.Text = "Order No:"
        '
        'cboOrderNo
        '
        Me.cboOrderNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrderNo.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.cboOrderNo.FormattingEnabled = True
        Me.cboOrderNo.Location = New System.Drawing.Point(460, 41)
        Me.cboOrderNo.Name = "cboOrderNo"
        Me.cboOrderNo.Size = New System.Drawing.Size(145, 26)
        Me.cboOrderNo.TabIndex = 127
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(298, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 16)
        Me.Label9.TabIndex = 126
        Me.Label9.Text = "Status:"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"All", "Pending", "Accepted", "Rejected"})
        Me.cboStatus.Location = New System.Drawing.Point(301, 41)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(145, 26)
        Me.cboStatus.TabIndex = 125
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(153, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 16)
        Me.Label8.TabIndex = 124
        Me.Label8.Text = "To:"
        '
        'dtTo
        '
        Me.dtTo.CalendarFont = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo.CustomFormat = "dd/MM/yyyy"
        Me.dtTo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTo.Location = New System.Drawing.Point(158, 41)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(129, 27)
        Me.dtTo.TabIndex = 123
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(13, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 16)
        Me.Label7.TabIndex = 122
        Me.Label7.Text = "From:"
        '
        'dtFrom
        '
        Me.dtFrom.CalendarFont = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtFrom.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFrom.Location = New System.Drawing.Point(16, 41)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(129, 27)
        Me.dtFrom.TabIndex = 121
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(660, 508)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 118
        Me.Label6.Text = "TOTAL :"
        '
        'txtTotalMyOrder
        '
        Me.txtTotalMyOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtTotalMyOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalMyOrder.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalMyOrder.Location = New System.Drawing.Point(749, 502)
        Me.txtTotalMyOrder.Name = "txtTotalMyOrder"
        Me.txtTotalMyOrder.ReadOnly = True
        Me.txtTotalMyOrder.Size = New System.Drawing.Size(180, 31)
        Me.txtTotalMyOrder.TabIndex = 117
        Me.txtTotalMyOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MyOrderList
        '
        Me.MyOrderList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        MyOrderList_DesignTimeLayout.LayoutString = resources.GetString("MyOrderList_DesignTimeLayout.LayoutString")
        Me.MyOrderList.DesignTimeLayout = MyOrderList_DesignTimeLayout
        Me.MyOrderList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyOrderList.GroupByBoxVisible = False
        Me.MyOrderList.Location = New System.Drawing.Point(16, 86)
        Me.MyOrderList.Name = "MyOrderList"
        Me.MyOrderList.Size = New System.Drawing.Size(913, 395)
        Me.MyOrderList.TabIndex = 109
        Me.MyOrderList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'UC_OrderItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Order)
        Me.Name = "UC_OrderItem"
        Me.Size = New System.Drawing.Size(953, 651)
        Me.Order.ResumeLayout(False)
        Me.TabNewOrder.ResumeLayout(False)
        Me.TabNewOrder.PerformLayout()
        CType(Me.picItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMyOrder.ResumeLayout(False)
        Me.tabMyOrder.PerformLayout()
        CType(Me.MyOrderList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Order As System.Windows.Forms.TabControl
    Friend WithEvents TabNewOrder As System.Windows.Forms.TabPage
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtIQty As System.Windows.Forms.TextBox
    Friend WithEvents CboItem As System.Windows.Forms.ComboBox
    Friend WithEvents txtCurQty As System.Windows.Forms.TextBox
    Friend WithEvents CboUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OrderList As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents tabMyOrder As System.Windows.Forms.TabPage
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents chkBarcode As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLastCost As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents picItem As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotalMyOrder As System.Windows.Forms.TextBox
    Friend WithEvents MyOrderList As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboOrderNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboLocation As System.Windows.Forms.ComboBox

End Class
