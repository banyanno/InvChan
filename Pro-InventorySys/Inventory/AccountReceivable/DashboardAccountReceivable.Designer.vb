<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardAccountReceivable
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
        Dim ARList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardAccountReceivable))
        Dim PaymentList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ARList = New Janus.Windows.GridEX.GridEX
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PaymentList = New Janus.Windows.GridEX.GridEX
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtResultTHB = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtTotalPaidTHB = New System.Windows.Forms.TextBox
        Me.TxtTotalTHB = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtResultKHR = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtTotalPaidKHR = New System.Windows.Forms.TextBox
        Me.TxtTotalKHR = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtResultUSD = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtTotalPaidUSD = New System.Windows.Forms.TextBox
        Me.TxtTotalUSD = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.BtnFindByPurchase = New System.Windows.Forms.Button
        Me.TxtPurchaseNo = New System.Windows.Forms.TextBox
        Me.RadPurchaseNo = New System.Windows.Forms.RadioButton
        Me.ChSupplier = New System.Windows.Forms.CheckBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.RadCompleted = New System.Windows.Forms.RadioButton
        Me.RadNotYet = New System.Windows.Forms.RadioButton
        Me.RadAll = New System.Windows.Forms.RadioButton
        Me.BntFind = New System.Windows.Forms.Button
        Me.TxtCustomer = New System.Windows.Forms.ComboBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.BtnNewPayment = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnUpdateCompleted = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnReportReceivable = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDeletePayment = New System.Windows.Forms.ToolStripButton
        Me.ImgListDashbord = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ARList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PaymentList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 47)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1019, 583)
        Me.SplitContainer2.SplitterDistance = 793
        Me.SplitContainer2.TabIndex = 16
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ARList)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(793, 583)
        Me.SplitContainer1.SplitterDistance = 363
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 15
        '
        'ARList
        '
        Me.ARList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        ARList_DesignTimeLayout.LayoutString = resources.GetString("ARList_DesignTimeLayout.LayoutString")
        Me.ARList.DesignTimeLayout = ARList_DesignTimeLayout
        Me.ARList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ARList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ARList.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.ARList.GroupByBoxVisible = False
        Me.ARList.HeaderFormatStyle.Font = New System.Drawing.Font("Kh Battambang", 9.75!)
        Me.ARList.HeaderFormatStyle.FontSize = 8.0!
        Me.ARList.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.ARList.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.ARList.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.ARList.Hierarchical = True
        Me.ARList.Location = New System.Drawing.Point(0, 0)
        Me.ARList.Name = "ARList"
        Me.ARList.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.ARList.RecordNavigator = True
        Me.ARList.Size = New System.Drawing.Size(791, 361)
        Me.ARList.TabIndex = 14
        Me.ARList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.ARList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer3.Size = New System.Drawing.Size(791, 215)
        Me.SplitContainer3.SplitterDistance = 435
        Me.SplitContainer3.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PaymentList)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(435, 215)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment"
        '
        'PaymentList
        '
        Me.PaymentList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        PaymentList_DesignTimeLayout.LayoutString = resources.GetString("PaymentList_DesignTimeLayout.LayoutString")
        Me.PaymentList.DesignTimeLayout = PaymentList_DesignTimeLayout
        Me.PaymentList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PaymentList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PaymentList.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.PaymentList.GroupByBoxVisible = False
        Me.PaymentList.HeaderFormatStyle.Font = New System.Drawing.Font("Kh Battambang", 8.25!)
        Me.PaymentList.HeaderFormatStyle.FontSize = 8.0!
        Me.PaymentList.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.PaymentList.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.PaymentList.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.PaymentList.Location = New System.Drawing.Point(2, 27)
        Me.PaymentList.Name = "PaymentList"
        Me.PaymentList.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.PaymentList.RecordNavigator = True
        Me.PaymentList.Size = New System.Drawing.Size(431, 186)
        Me.PaymentList.TabIndex = 15
        Me.PaymentList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TxtResultTHB)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TxtTotalPaidTHB)
        Me.GroupBox2.Controls.Add(Me.TxtTotalTHB)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TxtResultKHR)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtTotalPaidKHR)
        Me.GroupBox2.Controls.Add(Me.TxtTotalKHR)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtResultUSD)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtTotalPaidUSD)
        Me.GroupBox2.Controls.Add(Me.TxtTotalUSD)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(352, 215)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Paid Detail"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!)
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(162, 118)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 27)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "ចំនួននៅសល់"
        '
        'TxtResultTHB
        '
        Me.TxtResultTHB.BackColor = System.Drawing.Color.White
        Me.TxtResultTHB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResultTHB.ForeColor = System.Drawing.Color.Red
        Me.TxtResultTHB.Location = New System.Drawing.Point(748, 32)
        Me.TxtResultTHB.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtResultTHB.Name = "TxtResultTHB"
        Me.TxtResultTHB.ReadOnly = True
        Me.TxtResultTHB.Size = New System.Drawing.Size(104, 26)
        Me.TxtResultTHB.TabIndex = 19
        Me.TxtResultTHB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtResultTHB.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(724, 34)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 27)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "="
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(600, 34)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 27)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "-"
        Me.Label10.Visible = False
        '
        'TxtTotalPaidTHB
        '
        Me.TxtTotalPaidTHB.BackColor = System.Drawing.Color.White
        Me.TxtTotalPaidTHB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPaidTHB.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalPaidTHB.Location = New System.Drawing.Point(620, 32)
        Me.TxtTotalPaidTHB.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalPaidTHB.Name = "TxtTotalPaidTHB"
        Me.TxtTotalPaidTHB.ReadOnly = True
        Me.TxtTotalPaidTHB.Size = New System.Drawing.Size(100, 26)
        Me.TxtTotalPaidTHB.TabIndex = 16
        Me.TxtTotalPaidTHB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTotalPaidTHB.Visible = False
        '
        'TxtTotalTHB
        '
        Me.TxtTotalTHB.BackColor = System.Drawing.Color.White
        Me.TxtTotalTHB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalTHB.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalTHB.Location = New System.Drawing.Point(500, 32)
        Me.TxtTotalTHB.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalTHB.Name = "TxtTotalTHB"
        Me.TxtTotalTHB.ReadOnly = True
        Me.TxtTotalTHB.Size = New System.Drawing.Size(100, 26)
        Me.TxtTotalTHB.TabIndex = 15
        Me.TxtTotalTHB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTotalTHB.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(445, 35)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 27)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Paid B:"
        Me.Label11.Visible = False
        '
        'TxtResultKHR
        '
        Me.TxtResultKHR.BackColor = System.Drawing.Color.White
        Me.TxtResultKHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResultKHR.ForeColor = System.Drawing.Color.Red
        Me.TxtResultKHR.Location = New System.Drawing.Point(748, 29)
        Me.TxtResultKHR.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtResultKHR.Name = "TxtResultKHR"
        Me.TxtResultKHR.ReadOnly = True
        Me.TxtResultKHR.Size = New System.Drawing.Size(104, 26)
        Me.TxtResultKHR.TabIndex = 13
        Me.TxtResultKHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtResultKHR.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(724, 32)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 27)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "="
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(600, 32)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 27)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "-"
        Me.Label7.Visible = False
        '
        'TxtTotalPaidKHR
        '
        Me.TxtTotalPaidKHR.BackColor = System.Drawing.Color.White
        Me.TxtTotalPaidKHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPaidKHR.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalPaidKHR.Location = New System.Drawing.Point(620, 29)
        Me.TxtTotalPaidKHR.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalPaidKHR.Name = "TxtTotalPaidKHR"
        Me.TxtTotalPaidKHR.ReadOnly = True
        Me.TxtTotalPaidKHR.Size = New System.Drawing.Size(100, 26)
        Me.TxtTotalPaidKHR.TabIndex = 10
        Me.TxtTotalPaidKHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTotalPaidKHR.Visible = False
        '
        'TxtTotalKHR
        '
        Me.TxtTotalKHR.BackColor = System.Drawing.Color.White
        Me.TxtTotalKHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalKHR.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalKHR.Location = New System.Drawing.Point(500, 29)
        Me.TxtTotalKHR.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalKHR.Name = "TxtTotalKHR"
        Me.TxtTotalKHR.ReadOnly = True
        Me.TxtTotalKHR.Size = New System.Drawing.Size(100, 26)
        Me.TxtTotalKHR.TabIndex = 9
        Me.TxtTotalKHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTotalKHR.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(445, 31)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 27)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Paid ៛:"
        Me.Label8.Visible = False
        '
        'TxtResultUSD
        '
        Me.TxtResultUSD.BackColor = System.Drawing.Color.White
        Me.TxtResultUSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtResultUSD.Font = New System.Drawing.Font("Khmer OS Battambang", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResultUSD.ForeColor = System.Drawing.Color.Red
        Me.TxtResultUSD.Location = New System.Drawing.Point(57, 147)
        Me.TxtResultUSD.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtResultUSD.Name = "TxtResultUSD"
        Me.TxtResultUSD.ReadOnly = True
        Me.TxtResultUSD.Size = New System.Drawing.Size(288, 42)
        Me.TxtResultUSD.TabIndex = 7
        Me.TxtResultUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(6, 158)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 24)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(200, 78)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "-"
        '
        'TxtTotalPaidUSD
        '
        Me.TxtTotalPaidUSD.BackColor = System.Drawing.Color.White
        Me.TxtTotalPaidUSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalPaidUSD.Font = New System.Drawing.Font("Khmer OS Battambang", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPaidUSD.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalPaidUSD.Location = New System.Drawing.Point(222, 65)
        Me.TxtTotalPaidUSD.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalPaidUSD.Name = "TxtTotalPaidUSD"
        Me.TxtTotalPaidUSD.ReadOnly = True
        Me.TxtTotalPaidUSD.Size = New System.Drawing.Size(123, 42)
        Me.TxtTotalPaidUSD.TabIndex = 4
        Me.TxtTotalPaidUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTotalUSD
        '
        Me.TxtTotalUSD.BackColor = System.Drawing.Color.White
        Me.TxtTotalUSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalUSD.Font = New System.Drawing.Font("Khmer OS Battambang", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalUSD.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalUSD.Location = New System.Drawing.Point(61, 65)
        Me.TxtTotalUSD.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalUSD.Name = "TxtTotalUSD"
        Me.TxtTotalUSD.ReadOnly = True
        Me.TxtTotalUSD.Size = New System.Drawing.Size(134, 42)
        Me.TxtTotalUSD.TabIndex = 3
        Me.TxtTotalUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(245, 40)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ចំនួនសង់"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(90, 40)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ចំនួនសរុប"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(6, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Paid $:"
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.ChSupplier)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.BntFind)
        Me.GroupBox3.Controls.Add(Me.TxtCustomer)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Font = New System.Drawing.Font("Kh Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(236, 559)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ស្វែងរក ដោយ"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BtnFindByPurchase)
        Me.GroupBox6.Controls.Add(Me.TxtPurchaseNo)
        Me.GroupBox6.Controls.Add(Me.RadPurchaseNo)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 386)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(214, 143)
        Me.GroupBox6.TabIndex = 17
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "By Invoice"
        '
        'BtnFindByPurchase
        '
        Me.BtnFindByPurchase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFindByPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFindByPurchase.Location = New System.Drawing.Point(5, 100)
        Me.BtnFindByPurchase.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnFindByPurchase.Name = "BtnFindByPurchase"
        Me.BtnFindByPurchase.Size = New System.Drawing.Size(96, 33)
        Me.BtnFindByPurchase.TabIndex = 14
        Me.BtnFindByPurchase.Text = "ស្វែង រក"
        Me.BtnFindByPurchase.UseVisualStyleBackColor = True
        '
        'TxtPurchaseNo
        '
        Me.TxtPurchaseNo.Location = New System.Drawing.Point(6, 62)
        Me.TxtPurchaseNo.Name = "TxtPurchaseNo"
        Me.TxtPurchaseNo.Size = New System.Drawing.Size(173, 32)
        Me.TxtPurchaseNo.TabIndex = 2
        '
        'RadPurchaseNo
        '
        Me.RadPurchaseNo.AutoSize = True
        Me.RadPurchaseNo.Checked = True
        Me.RadPurchaseNo.Location = New System.Drawing.Point(13, 27)
        Me.RadPurchaseNo.Name = "RadPurchaseNo"
        Me.RadPurchaseNo.Size = New System.Drawing.Size(97, 29)
        Me.RadPurchaseNo.TabIndex = 0
        Me.RadPurchaseNo.TabStop = True
        Me.RadPurchaseNo.Text = "Invoice No:"
        Me.RadPurchaseNo.UseVisualStyleBackColor = True
        '
        'ChSupplier
        '
        Me.ChSupplier.AutoSize = True
        Me.ChSupplier.Location = New System.Drawing.Point(12, 140)
        Me.ChSupplier.Name = "ChSupplier"
        Me.ChSupplier.Size = New System.Drawing.Size(81, 29)
        Me.ChSupplier.TabIndex = 16
        Me.ChSupplier.Text = "អតិថិជន"
        Me.ChSupplier.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadCompleted)
        Me.GroupBox4.Controls.Add(Me.RadNotYet)
        Me.GroupBox4.Controls.Add(Me.RadAll)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(15, 210)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(216, 133)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Status Paid"
        '
        'RadCompleted
        '
        Me.RadCompleted.AutoSize = True
        Me.RadCompleted.Location = New System.Drawing.Point(17, 96)
        Me.RadCompleted.Margin = New System.Windows.Forms.Padding(2)
        Me.RadCompleted.Name = "RadCompleted"
        Me.RadCompleted.Size = New System.Drawing.Size(95, 29)
        Me.RadCompleted.TabIndex = 12
        Me.RadCompleted.Text = "Completed"
        Me.RadCompleted.UseVisualStyleBackColor = True
        '
        'RadNotYet
        '
        Me.RadNotYet.AutoSize = True
        Me.RadNotYet.Location = New System.Drawing.Point(17, 63)
        Me.RadNotYet.Margin = New System.Windows.Forms.Padding(2)
        Me.RadNotYet.Name = "RadNotYet"
        Me.RadNotYet.Size = New System.Drawing.Size(104, 29)
        Me.RadNotYet.TabIndex = 11
        Me.RadNotYet.Text = "Not yet paid"
        Me.RadNotYet.UseVisualStyleBackColor = True
        '
        'RadAll
        '
        Me.RadAll.AutoSize = True
        Me.RadAll.Checked = True
        Me.RadAll.Location = New System.Drawing.Point(17, 30)
        Me.RadAll.Margin = New System.Windows.Forms.Padding(2)
        Me.RadAll.Name = "RadAll"
        Me.RadAll.Size = New System.Drawing.Size(48, 29)
        Me.RadAll.TabIndex = 10
        Me.RadAll.TabStop = True
        Me.RadAll.Text = "All "
        Me.RadAll.UseVisualStyleBackColor = True
        '
        'BntFind
        '
        Me.BntFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BntFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BntFind.Location = New System.Drawing.Point(15, 348)
        Me.BntFind.Margin = New System.Windows.Forms.Padding(2)
        Me.BntFind.Name = "BntFind"
        Me.BntFind.Size = New System.Drawing.Size(96, 33)
        Me.BntFind.TabIndex = 13
        Me.BntFind.Text = "ស្វែង រក"
        Me.BntFind.UseVisualStyleBackColor = True
        '
        'TxtCustomer
        '
        Me.TxtCustomer.Enabled = False
        Me.TxtCustomer.FormattingEnabled = True
        Me.TxtCustomer.Location = New System.Drawing.Point(12, 174)
        Me.TxtCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCustomer.Name = "TxtCustomer"
        Me.TxtCustomer.Size = New System.Drawing.Size(207, 32)
        Me.TxtCustomer.TabIndex = 14
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DateTo)
        Me.GroupBox5.Controls.Add(Me.DateFrom)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Location = New System.Drawing.Point(5, 22)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(222, 113)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(63, 64)
        Me.DateTo.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(128, 32)
        Me.DateTo.TabIndex = 3
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(63, 26)
        Me.DateFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(128, 32)
        Me.DateFrom.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 69)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 25)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "To:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 33)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 25)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "From:"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewPayment, Me.ToolStripSeparator4, Me.BtnUpdateCompleted, Me.ToolStripSeparator2, Me.BtnRefresh, Me.ToolStripSeparator1, Me.BtnReportReceivable, Me.ToolStripSeparator3, Me.BtnDeletePayment})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1019, 47)
        Me.ToolStrip2.TabIndex = 13
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'BtnNewPayment
        '
        Me.BtnNewPayment.ForeColor = System.Drawing.Color.Blue
        Me.BtnNewPayment.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.Save
        Me.BtnNewPayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewPayment.Name = "BtnNewPayment"
        Me.BtnNewPayment.Size = New System.Drawing.Size(100, 44)
        Me.BtnNewPayment.Text = "   New Payment  "
        Me.BtnNewPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 47)
        '
        'BtnUpdateCompleted
        '
        Me.BtnUpdateCompleted.ForeColor = System.Drawing.Color.Red
        Me.BtnUpdateCompleted.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.Complet
        Me.BtnUpdateCompleted.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUpdateCompleted.Name = "BtnUpdateCompleted"
        Me.BtnUpdateCompleted.Size = New System.Drawing.Size(137, 44)
        Me.BtnUpdateCompleted.Text = "Update Paid Completed"
        Me.BtnUpdateCompleted.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 47)
        '
        'BtnRefresh
        '
        Me.BtnRefresh.ForeColor = System.Drawing.Color.Blue
        Me.BtnRefresh.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.refresh
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(77, 44)
        Me.BtnRefresh.Text = "Refresh Data"
        Me.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 47)
        '
        'BtnReportReceivable
        '
        Me.BtnReportReceivable.ForeColor = System.Drawing.Color.Blue
        Me.BtnReportReceivable.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources._1409830465_Income
        Me.BtnReportReceivable.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnReportReceivable.Name = "BtnReportReceivable"
        Me.BtnReportReceivable.Size = New System.Drawing.Size(111, 44)
        Me.BtnReportReceivable.Text = "Report Receiveable"
        Me.BtnReportReceivable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 47)
        '
        'BtnDeletePayment
        '
        Me.BtnDeletePayment.ForeColor = System.Drawing.Color.Blue
        Me.BtnDeletePayment.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.delete_appointment
        Me.BtnDeletePayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeletePayment.Name = "BtnDeletePayment"
        Me.BtnDeletePayment.Size = New System.Drawing.Size(94, 44)
        Me.BtnDeletePayment.Text = "Delete Payment"
        Me.BtnDeletePayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ImgListDashbord
        '
        Me.ImgListDashbord.ImageStream = CType(resources.GetObject("ImgListDashbord.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgListDashbord.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgListDashbord.Images.SetKeyName(0, "Exterior_26.png")
        Me.ImgListDashbord.Images.SetKeyName(1, "Settings-50.png")
        Me.ImgListDashbord.Images.SetKeyName(2, "Checkout-50.png")
        Me.ImgListDashbord.Images.SetKeyName(3, "Accounting.png")
        Me.ImgListDashbord.Images.SetKeyName(4, "Checked Truck.png")
        Me.ImgListDashbord.Images.SetKeyName(5, "Checkout.png")
        Me.ImgListDashbord.Images.SetKeyName(6, "Closed Sign.png")
        Me.ImgListDashbord.Images.SetKeyName(7, "Exterior_2.png")
        Me.ImgListDashbord.Images.SetKeyName(8, "Google Alerts.png")
        Me.ImgListDashbord.Images.SetKeyName(9, "Hand Down.png")
        Me.ImgListDashbord.Images.SetKeyName(10, "In Transit.png")
        Me.ImgListDashbord.Images.SetKeyName(11, "Industrial Scales Connecting.png")
        Me.ImgListDashbord.Images.SetKeyName(12, "Industrial Scales Connecting_2.png")
        Me.ImgListDashbord.Images.SetKeyName(13, "NFC Sign.png")
        Me.ImgListDashbord.Images.SetKeyName(14, "Recycle Sign.png")
        Me.ImgListDashbord.Images.SetKeyName(15, "Refund.png")
        Me.ImgListDashbord.Images.SetKeyName(16, "Settings.png")
        Me.ImgListDashbord.Images.SetKeyName(17, "Sewing Tape Measure.png")
        Me.ImgListDashbord.Images.SetKeyName(18, "Theatre Mask.png")
        Me.ImgListDashbord.Images.SetKeyName(19, "Weight.png")
        Me.ImgListDashbord.Images.SetKeyName(20, "Categorize-50.png")
        Me.ImgListDashbord.Images.SetKeyName(21, "Money Bag-96.png")
        Me.ImgListDashbord.Images.SetKeyName(22, "Handle With Care-96.png")
        Me.ImgListDashbord.Images.SetKeyName(23, "Transfer Between Users-96.png")
        Me.ImgListDashbord.Images.SetKeyName(24, "Logout Rounded Up-96.png")
        '
        'DashboardAccountReceivable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "DashboardAccountReceivable"
        Me.Size = New System.Drawing.Size(1019, 630)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ARList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PaymentList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ARList As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewPayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeletePayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PaymentList As Janus.Windows.GridEX.GridEX
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents BtnUpdateCompleted As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFindByPurchase As System.Windows.Forms.Button
    Friend WithEvents TxtPurchaseNo As System.Windows.Forms.TextBox
    Friend WithEvents RadPurchaseNo As System.Windows.Forms.RadioButton
    Friend WithEvents ChSupplier As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadCompleted As System.Windows.Forms.RadioButton
    Friend WithEvents RadNotYet As System.Windows.Forms.RadioButton
    Friend WithEvents RadAll As System.Windows.Forms.RadioButton
    Friend WithEvents BntFind As System.Windows.Forms.Button
    Friend WithEvents TxtCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtResultTHB As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalPaidTHB As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalTHB As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtResultKHR As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalPaidKHR As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalKHR As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtResultUSD As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalPaidUSD As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalUSD As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnReportReceivable As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImgListDashbord As System.Windows.Forms.ImageList
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer

End Class
