<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboradAccoudPayable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboradAccoudPayable))
        Dim GridAccountPayable_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridPayableDetail_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GridAccountPayable = New Janus.Windows.GridEX.GridEX
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GridPayableDetail = New Janus.Windows.GridEX.GridEX
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
        Me.TxtReferentNo = New System.Windows.Forms.TextBox
        Me.TxtPurchaseNo = New System.Windows.Forms.TextBox
        Me.RadReferrentNo = New System.Windows.Forms.RadioButton
        Me.RadPurchaseNo = New System.Windows.Forms.RadioButton
        Me.ChSupplier = New System.Windows.Forms.CheckBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.RadReceived = New System.Windows.Forms.RadioButton
        Me.RadNotYet = New System.Windows.Forms.RadioButton
        Me.RadAll = New System.Windows.Forms.RadioButton
        Me.BntFind = New System.Windows.Forms.Button
        Me.TxtSupplier = New System.Windows.Forms.ComboBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.BtnNewPayable = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnCompleted = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnFilter = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnReportAccPayable = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDeletePayable = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridAccountPayable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridPayableDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "3d_orange_man_magnifying_glass.jpg")
        Me.ImageList1.Images.SetKeyName(1, "teams-icon-250x250.jpg")
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 52)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1208, 1514)
        Me.SplitContainer2.SplitterDistance = 962
        Me.SplitContainer2.TabIndex = 16
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridAccountPayable)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(962, 1514)
        Me.SplitContainer1.SplitterDistance = 1276
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 15
        '
        'GridAccountPayable
        '
        Me.GridAccountPayable.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridAccountPayable.BackColor = System.Drawing.SystemColors.Control
        GridAccountPayable_DesignTimeLayout.LayoutString = resources.GetString("GridAccountPayable_DesignTimeLayout.LayoutString")
        Me.GridAccountPayable.DesignTimeLayout = GridAccountPayable_DesignTimeLayout
        Me.GridAccountPayable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAccountPayable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridAccountPayable.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridAccountPayable.GroupByBoxVisible = False
        Me.GridAccountPayable.HeaderFormatStyle.FontSize = 8.0!
        Me.GridAccountPayable.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridAccountPayable.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridAccountPayable.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridAccountPayable.Hierarchical = True
        Me.GridAccountPayable.KeepRowSettings = True
        Me.GridAccountPayable.Location = New System.Drawing.Point(0, 0)
        Me.GridAccountPayable.Name = "GridAccountPayable"
        Me.GridAccountPayable.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.GridAccountPayable.RecordNavigator = True
        Me.GridAccountPayable.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridAccountPayable.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridAccountPayable.Size = New System.Drawing.Size(960, 1274)
        Me.GridAccountPayable.TabIndex = 14
        Me.GridAccountPayable.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridAccountPayable.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
        Me.SplitContainer3.Size = New System.Drawing.Size(960, 233)
        Me.SplitContainer3.SplitterDistance = 543
        Me.SplitContainer3.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridPayableDetail)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(543, 233)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payable Info"
        '
        'GridPayableDetail
        '
        Me.GridPayableDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridPayableDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        GridPayableDetail_DesignTimeLayout.LayoutString = resources.GetString("GridPayableDetail_DesignTimeLayout.LayoutString")
        Me.GridPayableDetail.DesignTimeLayout = GridPayableDetail_DesignTimeLayout
        Me.GridPayableDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPayableDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridPayableDetail.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridPayableDetail.GroupByBoxVisible = False
        Me.GridPayableDetail.HeaderFormatStyle.FontSize = 8.0!
        Me.GridPayableDetail.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridPayableDetail.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridPayableDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridPayableDetail.Location = New System.Drawing.Point(2, 21)
        Me.GridPayableDetail.Name = "GridPayableDetail"
        Me.GridPayableDetail.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.GridPayableDetail.RecordNavigator = True
        Me.GridPayableDetail.Size = New System.Drawing.Size(539, 210)
        Me.GridPayableDetail.TabIndex = 15
        Me.GridPayableDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'GroupBox2
        '
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
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(413, 233)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Paid Detail"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(196, 99)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 29)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "នៅសល់"
        '
        'TxtResultTHB
        '
        Me.TxtResultTHB.BackColor = System.Drawing.Color.White
        Me.TxtResultTHB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResultTHB.ForeColor = System.Drawing.Color.Red
        Me.TxtResultTHB.Location = New System.Drawing.Point(836, 88)
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
        Me.Label9.Location = New System.Drawing.Point(804, 90)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "="
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(684, 92)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "-"
        Me.Label10.Visible = False
        '
        'TxtTotalPaidTHB
        '
        Me.TxtTotalPaidTHB.BackColor = System.Drawing.Color.White
        Me.TxtTotalPaidTHB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPaidTHB.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalPaidTHB.Location = New System.Drawing.Point(700, 88)
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
        Me.TxtTotalTHB.Location = New System.Drawing.Point(580, 88)
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
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(509, 92)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 20)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Paid B:"
        Me.Label11.Visible = False
        '
        'TxtResultKHR
        '
        Me.TxtResultKHR.BackColor = System.Drawing.Color.White
        Me.TxtResultKHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResultKHR.ForeColor = System.Drawing.Color.Red
        Me.TxtResultKHR.Location = New System.Drawing.Point(836, 48)
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
        Me.Label6.Location = New System.Drawing.Point(804, 50)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "="
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(684, 52)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "-"
        Me.Label7.Visible = False
        '
        'TxtTotalPaidKHR
        '
        Me.TxtTotalPaidKHR.BackColor = System.Drawing.Color.White
        Me.TxtTotalPaidKHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPaidKHR.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalPaidKHR.Location = New System.Drawing.Point(700, 48)
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
        Me.TxtTotalKHR.Location = New System.Drawing.Point(580, 48)
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
        Me.Label8.Font = New System.Drawing.Font("Kh Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(509, 52)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 29)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Paid ៛:"
        Me.Label8.Visible = False
        '
        'TxtResultUSD
        '
        Me.TxtResultUSD.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtResultUSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtResultUSD.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResultUSD.ForeColor = System.Drawing.Color.Red
        Me.TxtResultUSD.Location = New System.Drawing.Point(77, 130)
        Me.TxtResultUSD.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtResultUSD.Name = "TxtResultUSD"
        Me.TxtResultUSD.ReadOnly = True
        Me.TxtResultUSD.Size = New System.Drawing.Size(323, 37)
        Me.TxtResultUSD.TabIndex = 7
        Me.TxtResultUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 132)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 29)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(228, 59)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "-"
        '
        'TxtTotalPaidUSD
        '
        Me.TxtTotalPaidUSD.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTotalPaidUSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalPaidUSD.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPaidUSD.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalPaidUSD.Location = New System.Drawing.Point(250, 51)
        Me.TxtTotalPaidUSD.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalPaidUSD.Name = "TxtTotalPaidUSD"
        Me.TxtTotalPaidUSD.ReadOnly = True
        Me.TxtTotalPaidUSD.Size = New System.Drawing.Size(150, 37)
        Me.TxtTotalPaidUSD.TabIndex = 4
        Me.TxtTotalPaidUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotalUSD
        '
        Me.TxtTotalUSD.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTotalUSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalUSD.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalUSD.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalUSD.Location = New System.Drawing.Point(82, 51)
        Me.TxtTotalUSD.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalUSD.Name = "TxtTotalUSD"
        Me.TxtTotalUSD.ReadOnly = True
        Me.TxtTotalUSD.Size = New System.Drawing.Size(142, 37)
        Me.TxtTotalUSD.TabIndex = 3
        Me.TxtTotalUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(293, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ចំនួនបង់"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(121, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ចំនួនសរុប"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Paid $:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.ChSupplier)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.BntFind)
        Me.GroupBox3.Controls.Add(Me.TxtSupplier)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Kh Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(240, 1512)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ស្វែងរក ដោយ"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BtnFindByPurchase)
        Me.GroupBox6.Controls.Add(Me.TxtReferentNo)
        Me.GroupBox6.Controls.Add(Me.TxtPurchaseNo)
        Me.GroupBox6.Controls.Add(Me.RadReferrentNo)
        Me.GroupBox6.Controls.Add(Me.RadPurchaseNo)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 386)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(214, 221)
        Me.GroupBox6.TabIndex = 17
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "By Purchase"
        '
        'BtnFindByPurchase
        '
        Me.BtnFindByPurchase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFindByPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFindByPurchase.Location = New System.Drawing.Point(16, 178)
        Me.BtnFindByPurchase.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnFindByPurchase.Name = "BtnFindByPurchase"
        Me.BtnFindByPurchase.Size = New System.Drawing.Size(96, 33)
        Me.BtnFindByPurchase.TabIndex = 14
        Me.BtnFindByPurchase.Text = "ស្វែង រក"
        Me.BtnFindByPurchase.UseVisualStyleBackColor = True
        '
        'TxtReferentNo
        '
        Me.TxtReferentNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtReferentNo.Enabled = False
        Me.TxtReferentNo.Location = New System.Drawing.Point(16, 132)
        Me.TxtReferentNo.Name = "TxtReferentNo"
        Me.TxtReferentNo.Size = New System.Drawing.Size(173, 32)
        Me.TxtReferentNo.TabIndex = 3
        '
        'TxtPurchaseNo
        '
        Me.TxtPurchaseNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPurchaseNo.Location = New System.Drawing.Point(16, 61)
        Me.TxtPurchaseNo.Name = "TxtPurchaseNo"
        Me.TxtPurchaseNo.Size = New System.Drawing.Size(173, 32)
        Me.TxtPurchaseNo.TabIndex = 2
        '
        'RadReferrentNo
        '
        Me.RadReferrentNo.AutoSize = True
        Me.RadReferrentNo.Location = New System.Drawing.Point(16, 97)
        Me.RadReferrentNo.Name = "RadReferrentNo"
        Me.RadReferrentNo.Size = New System.Drawing.Size(110, 29)
        Me.RadReferrentNo.TabIndex = 1
        Me.RadReferrentNo.Text = "Referrent No:"
        Me.RadReferrentNo.UseVisualStyleBackColor = True
        '
        'RadPurchaseNo
        '
        Me.RadPurchaseNo.AutoSize = True
        Me.RadPurchaseNo.Checked = True
        Me.RadPurchaseNo.Location = New System.Drawing.Point(13, 27)
        Me.RadPurchaseNo.Name = "RadPurchaseNo"
        Me.RadPurchaseNo.Size = New System.Drawing.Size(113, 29)
        Me.RadPurchaseNo.TabIndex = 0
        Me.RadPurchaseNo.TabStop = True
        Me.RadPurchaseNo.Text = "Purchase No:"
        Me.RadPurchaseNo.UseVisualStyleBackColor = True
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadReceived)
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
        'RadReceived
        '
        Me.RadReceived.AutoSize = True
        Me.RadReceived.Location = New System.Drawing.Point(17, 96)
        Me.RadReceived.Margin = New System.Windows.Forms.Padding(2)
        Me.RadReceived.Name = "RadReceived"
        Me.RadReceived.Size = New System.Drawing.Size(95, 29)
        Me.RadReceived.TabIndex = 12
        Me.RadReceived.Text = "Completed"
        Me.RadReceived.UseVisualStyleBackColor = True
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
        'TxtSupplier
        '
        Me.TxtSupplier.Enabled = False
        Me.TxtSupplier.FormattingEnabled = True
        Me.TxtSupplier.Location = New System.Drawing.Point(12, 174)
        Me.TxtSupplier.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSupplier.Name = "TxtSupplier"
        Me.TxtSupplier.Size = New System.Drawing.Size(220, 32)
        Me.TxtSupplier.TabIndex = 14
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
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewPayable, Me.ToolStripSeparator4, Me.BtnCompleted, Me.ToolStripSeparator5, Me.BtnFilter, Me.ToolStripSeparator3, Me.BtnRefresh, Me.ToolStripSeparator2, Me.BtnReportAccPayable, Me.ToolStripSeparator1, Me.BtnDeletePayable})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1208, 52)
        Me.ToolStrip2.TabIndex = 13
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'BtnNewPayable
        '
        Me.BtnNewPayable.ForeColor = System.Drawing.Color.Blue
        Me.BtnNewPayable.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.Save
        Me.BtnNewPayable.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewPayable.Name = "BtnNewPayable"
        Me.BtnNewPayable.Size = New System.Drawing.Size(97, 49)
        Me.BtnNewPayable.Text = "   New Payable   "
        Me.BtnNewPayable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 52)
        '
        'BtnCompleted
        '
        Me.BtnCompleted.ForeColor = System.Drawing.Color.Red
        Me.BtnCompleted.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.Complet
        Me.BtnCompleted.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCompleted.Name = "BtnCompleted"
        Me.BtnCompleted.Size = New System.Drawing.Size(124, 49)
        Me.BtnCompleted.Text = "Update Paid Complet"
        Me.BtnCompleted.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 52)
        '
        'BtnFilter
        '
        Me.BtnFilter.ForeColor = System.Drawing.Color.Blue
        Me.BtnFilter.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.Filter
        Me.BtnFilter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFilter.Name = "BtnFilter"
        Me.BtnFilter.Size = New System.Drawing.Size(61, 49)
        Me.BtnFilter.Text = "    Filter    "
        Me.BtnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 52)
        '
        'BtnRefresh
        '
        Me.BtnRefresh.ForeColor = System.Drawing.Color.Blue
        Me.BtnRefresh.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.refresh
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(77, 49)
        Me.BtnRefresh.Text = "Refresh Data"
        Me.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnRefresh.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 52)
        Me.ToolStripSeparator2.Visible = False
        '
        'BtnReportAccPayable
        '
        Me.BtnReportAccPayable.ForeColor = System.Drawing.Color.Blue
        Me.BtnReportAccPayable.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources._1409830465_Income
        Me.BtnReportAccPayable.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnReportAccPayable.Name = "BtnReportAccPayable"
        Me.BtnReportAccPayable.Size = New System.Drawing.Size(115, 49)
        Me.BtnReportAccPayable.Text = "Report Acc-Payable"
        Me.BtnReportAccPayable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 52)
        '
        'BtnDeletePayable
        '
        Me.BtnDeletePayable.ForeColor = System.Drawing.Color.Blue
        Me.BtnDeletePayable.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.delete_appointment
        Me.BtnDeletePayable.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeletePayable.Name = "BtnDeletePayable"
        Me.BtnDeletePayable.Size = New System.Drawing.Size(88, 49)
        Me.BtnDeletePayable.Text = "Delete Payable"
        Me.BtnDeletePayable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DashboradAccoudPayable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "DashboradAccoudPayable"
        Me.Size = New System.Drawing.Size(1208, 1566)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridAccountPayable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridPayableDetail, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewPayable As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeletePayable As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridAccountPayable As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalPaidUSD As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalUSD As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
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
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents BtnFilter As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ChSupplier As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadReceived As System.Windows.Forms.RadioButton
    Friend WithEvents RadNotYet As System.Windows.Forms.RadioButton
    Friend WithEvents RadAll As System.Windows.Forms.RadioButton
    Friend WithEvents TxtSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents BntFind As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtReferentNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtPurchaseNo As System.Windows.Forms.TextBox
    Friend WithEvents RadReferrentNo As System.Windows.Forms.RadioButton
    Friend WithEvents RadPurchaseNo As System.Windows.Forms.RadioButton
    Friend WithEvents BtnFindByPurchase As System.Windows.Forms.Button
    Friend WithEvents BtnCompleted As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnReportAccPayable As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridPayableDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer

End Class
