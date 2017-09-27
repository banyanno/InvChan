<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_OrderControl
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
        Dim MyOrderList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_OrderControl))
        Dim OrderList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
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
        Me.btnPreview = New System.Windows.Forms.Button
        Me.btnAccept = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.txttotal = New System.Windows.Forms.TextBox
        Me.OrderList = New Janus.Windows.GridEX.GridEX
        Me.cboLocation = New System.Windows.Forms.ComboBox
        Me.TabNewOrder = New System.Windows.Forms.TabPage
        Me.BtnReject = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboNo = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Order = New System.Windows.Forms.TabControl
        Me.tabMyOrder.SuspendLayout()
        CType(Me.MyOrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNewOrder.SuspendLayout()
        Me.Order.SuspendLayout()
        Me.SuspendLayout()
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
        Me.tabMyOrder.Size = New System.Drawing.Size(969, 595)
        Me.tabMyOrder.TabIndex = 2
        Me.tabMyOrder.Text = "Order History"
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
        'btnPreview
        '
        Me.btnPreview.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPreview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnPreview.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.ForeColor = System.Drawing.Color.Black
        Me.btnPreview.Location = New System.Drawing.Point(641, 512)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(91, 31)
        Me.btnPreview.TabIndex = 116
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnAccept
        '
        Me.btnAccept.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAccept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnAccept.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccept.ForeColor = System.Drawing.Color.Black
        Me.btnAccept.Location = New System.Drawing.Point(738, 512)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(91, 31)
        Me.btnAccept.TabIndex = 114
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(657, 466)
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
        Me.txttotal.Location = New System.Drawing.Point(746, 460)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(180, 31)
        Me.txttotal.TabIndex = 112
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OrderList
        '
        Me.OrderList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        OrderList_DesignTimeLayout.LayoutString = resources.GetString("OrderList_DesignTimeLayout.LayoutString")
        Me.OrderList.DesignTimeLayout = OrderList_DesignTimeLayout
        Me.OrderList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderList.GroupByBoxVisible = False
        Me.OrderList.Location = New System.Drawing.Point(13, 85)
        Me.OrderList.Name = "OrderList"
        Me.OrderList.Size = New System.Drawing.Size(913, 357)
        Me.OrderList.TabIndex = 108
        Me.OrderList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'cboLocation
        '
        Me.cboLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLocation.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.Location = New System.Drawing.Point(13, 41)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(196, 26)
        Me.cboLocation.TabIndex = 107
        '
        'TabNewOrder
        '
        Me.TabNewOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TabNewOrder.Controls.Add(Me.BtnReject)
        Me.TabNewOrder.Controls.Add(Me.btnRefresh)
        Me.TabNewOrder.Controls.Add(Me.btnPreview)
        Me.TabNewOrder.Controls.Add(Me.btnAccept)
        Me.TabNewOrder.Controls.Add(Me.Label10)
        Me.TabNewOrder.Controls.Add(Me.txttotal)
        Me.TabNewOrder.Controls.Add(Me.OrderList)
        Me.TabNewOrder.Controls.Add(Me.cboLocation)
        Me.TabNewOrder.Controls.Add(Me.Label4)
        Me.TabNewOrder.Controls.Add(Me.cboNo)
        Me.TabNewOrder.Controls.Add(Me.Label3)
        Me.TabNewOrder.Location = New System.Drawing.Point(4, 25)
        Me.TabNewOrder.Name = "TabNewOrder"
        Me.TabNewOrder.Padding = New System.Windows.Forms.Padding(3)
        Me.TabNewOrder.Size = New System.Drawing.Size(969, 595)
        Me.TabNewOrder.TabIndex = 0
        Me.TabNewOrder.Text = "Recent Orders"
        '
        'BtnReject
        '
        Me.BtnReject.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnReject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnReject.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReject.ForeColor = System.Drawing.Color.Black
        Me.BtnReject.Location = New System.Drawing.Point(835, 512)
        Me.BtnReject.Name = "BtnReject"
        Me.BtnReject.Size = New System.Drawing.Size(91, 31)
        Me.BtnReject.TabIndex = 126
        Me.BtnReject.Text = "Reject"
        Me.BtnReject.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnRefresh.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Black
        Me.btnRefresh.Location = New System.Drawing.Point(382, 40)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(81, 27)
        Me.btnRefresh.TabIndex = 125
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(10, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Location:"
        '
        'cboNo
        '
        Me.cboNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNo.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.cboNo.FormattingEnabled = True
        Me.cboNo.Location = New System.Drawing.Point(222, 41)
        Me.cboNo.Name = "cboNo"
        Me.cboNo.Size = New System.Drawing.Size(147, 26)
        Me.cboNo.TabIndex = 104
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(219, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Order No: "
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
        Me.Order.Size = New System.Drawing.Size(977, 624)
        Me.Order.TabIndex = 1
        '
        'UC_OrderControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Order)
        Me.Name = "UC_OrderControl"
        Me.Size = New System.Drawing.Size(977, 624)
        Me.tabMyOrder.ResumeLayout(False)
        Me.tabMyOrder.PerformLayout()
        CType(Me.MyOrderList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNewOrder.ResumeLayout(False)
        Me.TabNewOrder.PerformLayout()
        Me.Order.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMyOrder As System.Windows.Forms.TabPage
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboOrderNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotalMyOrder As System.Windows.Forms.TextBox
    Friend WithEvents MyOrderList As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents OrderList As Janus.Windows.GridEX.GridEX
    Friend WithEvents cboLocation As System.Windows.Forms.ComboBox
    Friend WithEvents TabNewOrder As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Order As System.Windows.Forms.TabControl
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents BtnReject As System.Windows.Forms.Button

End Class
