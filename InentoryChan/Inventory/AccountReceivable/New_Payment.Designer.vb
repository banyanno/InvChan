<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(New_Payment))
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.BtnSave = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnCancel = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtMoreTHB = New System.Windows.Forms.TextBox
        Me.TxtMoreKHR = New System.Windows.Forms.TextBox
        Me.TxtMoreUSD = New System.Windows.Forms.TextBox
        Me.ChkPayAll = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtUnpaidTHB = New System.Windows.Forms.TextBox
        Me.TxtTotalPaidTHB = New System.Windows.Forms.TextBox
        Me.txtTotalTHB = New System.Windows.Forms.TextBox
        Me.txtUnpaidKHR = New System.Windows.Forms.TextBox
        Me.TxtTotalPaidKHR = New System.Windows.Forms.TextBox
        Me.txtTotalKHR = New System.Windows.Forms.TextBox
        Me.txtUnpaidUSD = New System.Windows.Forms.TextBox
        Me.TxtTotalPaidUSD = New System.Windows.Forms.TextBox
        Me.txtTotalUSD = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.TxtNote = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtDateInvoice = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCustName = New System.Windows.Forms.TextBox
        Me.DatePaid = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.ErrPaid = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ErrPaid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiTab1
        '
        Me.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab1.Location = New System.Drawing.Point(0, 0)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Size = New System.Drawing.Size(627, 508)
        Me.UiTab1.TabIndex = 4
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1})
        Me.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.ToolStrip2)
        Me.UiTabPage1.Controls.Add(Me.GroupBox1)
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(625, 486)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Payment Information"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnSave, Me.ToolStripSeparator4, Me.BtnCancel})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(625, 47)
        Me.ToolStrip2.TabIndex = 13
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.TxtNote)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(3, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(615, 445)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TxtMoreKHR)
        Me.GroupBox5.Controls.Add(Me.TxtMoreTHB)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.GroupBox2)
        Me.GroupBox5.Controls.Add(Me.ChkPayAll)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txtUnpaidTHB)
        Me.GroupBox5.Controls.Add(Me.TxtTotalPaidTHB)
        Me.GroupBox5.Controls.Add(Me.txtTotalTHB)
        Me.GroupBox5.Controls.Add(Me.txtUnpaidKHR)
        Me.GroupBox5.Controls.Add(Me.TxtTotalPaidKHR)
        Me.GroupBox5.Controls.Add(Me.txtTotalKHR)
        Me.GroupBox5.Controls.Add(Me.txtUnpaidUSD)
        Me.GroupBox5.Controls.Add(Me.TxtTotalPaidUSD)
        Me.GroupBox5.Controls.Add(Me.txtTotalUSD)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Font = New System.Drawing.Font("Kh Battambang", 9.75!)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(7, 129)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(592, 131)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Payment Details"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(354, 149)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(18, 24)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "="
        Me.Label17.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(354, 147)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 24)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "="
        Me.Label16.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(249, 73)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 27)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "="
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(237, 149)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 24)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "-"
        Me.Label11.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(237, 147)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 24)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "-"
        Me.Label9.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(125, 73)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 27)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "-"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtMoreUSD)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(381, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 90)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ចំនួនបង់បន្ថែម"
        '
        'TxtMoreTHB
        '
        Me.TxtMoreTHB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMoreTHB.ForeColor = System.Drawing.Color.Red
        Me.TxtMoreTHB.Location = New System.Drawing.Point(252, 149)
        Me.TxtMoreTHB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtMoreTHB.Name = "TxtMoreTHB"
        Me.TxtMoreTHB.Size = New System.Drawing.Size(126, 26)
        Me.TxtMoreTHB.TabIndex = 10
        Me.TxtMoreTHB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtMoreTHB.Visible = False
        '
        'TxtMoreKHR
        '
        Me.TxtMoreKHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMoreKHR.ForeColor = System.Drawing.Color.Red
        Me.TxtMoreKHR.Location = New System.Drawing.Point(70, 147)
        Me.TxtMoreKHR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtMoreKHR.Name = "TxtMoreKHR"
        Me.TxtMoreKHR.Size = New System.Drawing.Size(126, 26)
        Me.TxtMoreKHR.TabIndex = 9
        Me.TxtMoreKHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtMoreKHR.Visible = False
        '
        'TxtMoreUSD
        '
        Me.TxtMoreUSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMoreUSD.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!)
        Me.TxtMoreUSD.ForeColor = System.Drawing.Color.Red
        Me.TxtMoreUSD.Location = New System.Drawing.Point(8, 38)
        Me.TxtMoreUSD.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtMoreUSD.Name = "TxtMoreUSD"
        Me.TxtMoreUSD.Size = New System.Drawing.Size(185, 36)
        Me.TxtMoreUSD.TabIndex = 8
        Me.TxtMoreUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ChkPayAll
        '
        Me.ChkPayAll.AutoSize = True
        Me.ChkPayAll.Location = New System.Drawing.Point(512, 143)
        Me.ChkPayAll.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ChkPayAll.Name = "ChkPayAll"
        Me.ChkPayAll.Size = New System.Drawing.Size(91, 28)
        Me.ChkPayAll.TabIndex = 5
        Me.ChkPayAll.Text = "បង់ទាំងអស់"
        Me.ChkPayAll.UseVisualStyleBackColor = True
        Me.ChkPayAll.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 149)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "តំលៃ សរុប THB:"
        Me.Label5.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Kh Battambang", 9.75!)
        Me.Label12.Location = New System.Drawing.Point(285, 32)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 24)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "ចំនួននៅសល់"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 147)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "តំលៃ សរុប KHR:"
        Me.Label4.Visible = False
        '
        'txtUnpaidTHB
        '
        Me.txtUnpaidTHB.BackColor = System.Drawing.Color.White
        Me.txtUnpaidTHB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnpaidTHB.ForeColor = System.Drawing.Color.Red
        Me.txtUnpaidTHB.Location = New System.Drawing.Point(372, 147)
        Me.txtUnpaidTHB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUnpaidTHB.Name = "txtUnpaidTHB"
        Me.txtUnpaidTHB.ReadOnly = True
        Me.txtUnpaidTHB.Size = New System.Drawing.Size(104, 26)
        Me.txtUnpaidTHB.TabIndex = 19
        Me.txtUnpaidTHB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtUnpaidTHB.Visible = False
        '
        'TxtTotalPaidTHB
        '
        Me.TxtTotalPaidTHB.BackColor = System.Drawing.Color.White
        Me.TxtTotalPaidTHB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPaidTHB.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalPaidTHB.Location = New System.Drawing.Point(252, 147)
        Me.TxtTotalPaidTHB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtTotalPaidTHB.Name = "TxtTotalPaidTHB"
        Me.TxtTotalPaidTHB.ReadOnly = True
        Me.TxtTotalPaidTHB.Size = New System.Drawing.Size(100, 26)
        Me.TxtTotalPaidTHB.TabIndex = 16
        Me.TxtTotalPaidTHB.Text = "0"
        Me.TxtTotalPaidTHB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTotalPaidTHB.Visible = False
        '
        'txtTotalTHB
        '
        Me.txtTotalTHB.BackColor = System.Drawing.Color.White
        Me.txtTotalTHB.Enabled = False
        Me.txtTotalTHB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalTHB.ForeColor = System.Drawing.Color.Red
        Me.txtTotalTHB.Location = New System.Drawing.Point(133, 147)
        Me.txtTotalTHB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTotalTHB.Name = "txtTotalTHB"
        Me.txtTotalTHB.ReadOnly = True
        Me.txtTotalTHB.Size = New System.Drawing.Size(100, 26)
        Me.txtTotalTHB.TabIndex = 15
        Me.txtTotalTHB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalTHB.Visible = False
        '
        'txtUnpaidKHR
        '
        Me.txtUnpaidKHR.BackColor = System.Drawing.Color.White
        Me.txtUnpaidKHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnpaidKHR.ForeColor = System.Drawing.Color.Red
        Me.txtUnpaidKHR.Location = New System.Drawing.Point(372, 145)
        Me.txtUnpaidKHR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUnpaidKHR.Name = "txtUnpaidKHR"
        Me.txtUnpaidKHR.ReadOnly = True
        Me.txtUnpaidKHR.Size = New System.Drawing.Size(104, 26)
        Me.txtUnpaidKHR.TabIndex = 13
        Me.txtUnpaidKHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtUnpaidKHR.Visible = False
        '
        'TxtTotalPaidKHR
        '
        Me.TxtTotalPaidKHR.BackColor = System.Drawing.Color.White
        Me.TxtTotalPaidKHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPaidKHR.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalPaidKHR.Location = New System.Drawing.Point(252, 145)
        Me.TxtTotalPaidKHR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtTotalPaidKHR.Name = "TxtTotalPaidKHR"
        Me.TxtTotalPaidKHR.ReadOnly = True
        Me.TxtTotalPaidKHR.Size = New System.Drawing.Size(100, 26)
        Me.TxtTotalPaidKHR.TabIndex = 10
        Me.TxtTotalPaidKHR.Text = "0"
        Me.TxtTotalPaidKHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTotalPaidKHR.Visible = False
        '
        'txtTotalKHR
        '
        Me.txtTotalKHR.BackColor = System.Drawing.Color.White
        Me.txtTotalKHR.Enabled = False
        Me.txtTotalKHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalKHR.ForeColor = System.Drawing.Color.Red
        Me.txtTotalKHR.Location = New System.Drawing.Point(133, 145)
        Me.txtTotalKHR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTotalKHR.Name = "txtTotalKHR"
        Me.txtTotalKHR.ReadOnly = True
        Me.txtTotalKHR.Size = New System.Drawing.Size(100, 26)
        Me.txtTotalKHR.TabIndex = 9
        Me.txtTotalKHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalKHR.Visible = False
        '
        'txtUnpaidUSD
        '
        Me.txtUnpaidUSD.BackColor = System.Drawing.Color.Red
        Me.txtUnpaidUSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnpaidUSD.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnpaidUSD.ForeColor = System.Drawing.Color.Red
        Me.txtUnpaidUSD.Location = New System.Drawing.Point(272, 71)
        Me.txtUnpaidUSD.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUnpaidUSD.Name = "txtUnpaidUSD"
        Me.txtUnpaidUSD.ReadOnly = True
        Me.txtUnpaidUSD.Size = New System.Drawing.Size(104, 36)
        Me.txtUnpaidUSD.TabIndex = 7
        Me.txtUnpaidUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotalPaidUSD
        '
        Me.TxtTotalPaidUSD.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTotalPaidUSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalPaidUSD.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPaidUSD.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalPaidUSD.Location = New System.Drawing.Point(146, 71)
        Me.TxtTotalPaidUSD.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtTotalPaidUSD.Name = "TxtTotalPaidUSD"
        Me.TxtTotalPaidUSD.ReadOnly = True
        Me.TxtTotalPaidUSD.Size = New System.Drawing.Size(100, 36)
        Me.TxtTotalPaidUSD.TabIndex = 4
        Me.TxtTotalPaidUSD.Text = "0"
        Me.TxtTotalPaidUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalUSD
        '
        Me.txtTotalUSD.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalUSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalUSD.Enabled = False
        Me.txtTotalUSD.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalUSD.ForeColor = System.Drawing.Color.Red
        Me.txtTotalUSD.Location = New System.Drawing.Point(18, 71)
        Me.txtTotalUSD.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTotalUSD.Name = "txtTotalUSD"
        Me.txtTotalUSD.ReadOnly = True
        Me.txtTotalUSD.Size = New System.Drawing.Size(100, 36)
        Me.txtTotalUSD.TabIndex = 3
        Me.txtTotalUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(157, 31)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(81, 24)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "ចំនួនប្រាក់បង់"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(34, 28)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(63, 24)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "ចំនួនសរុប"
        '
        'TxtNote
        '
        Me.TxtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNote.Location = New System.Drawing.Point(10, 308)
        Me.TxtNote.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtNote.Multiline = True
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.Size = New System.Drawing.Size(586, 130)
        Me.TxtNote.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Kh Battambang", 9.75!)
        Me.Label18.Location = New System.Drawing.Point(7, 278)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 24)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "កំណត់សំគាល់"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtDateInvoice)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtInvoiceNo)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Kh Battambang", 9.75!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(330, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(269, 110)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Invoice Info"
        '
        'txtDateInvoice
        '
        Me.txtDateInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDateInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateInvoice.Location = New System.Drawing.Point(99, 67)
        Me.txtDateInvoice.Name = "txtDateInvoice"
        Me.txtDateInvoice.Size = New System.Drawing.Size(152, 26)
        Me.txtDateInvoice.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(248, 36)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 24)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "ថ្ងៃ បញ្ជាទិញ:"
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNo.Location = New System.Drawing.Point(99, 32)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.ReadOnly = True
        Me.txtInvoiceNo.Size = New System.Drawing.Size(152, 26)
        Me.txtInvoiceNo.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "លេខ វិក័យប័ត្រ:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtCustName)
        Me.GroupBox4.Controls.Add(Me.DatePaid)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(7, 11)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(317, 110)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Customer Info"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(292, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "*"
        '
        'txtCustName
        '
        Me.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustName.Font = New System.Drawing.Font("Kh Battambang", 9.75!)
        Me.txtCustName.Location = New System.Drawing.Point(93, 67)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(195, 32)
        Me.txtCustName.TabIndex = 9
        '
        'DatePaid
        '
        Me.DatePaid.Checked = False
        Me.DatePaid.CustomFormat = "dd/MM/yyyy"
        Me.DatePaid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePaid.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatePaid.Location = New System.Drawing.Point(93, 33)
        Me.DatePaid.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DatePaid.Name = "DatePaid"
        Me.DatePaid.ShowCheckBox = True
        Me.DatePaid.Size = New System.Drawing.Size(195, 26)
        Me.DatePaid.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ថ្ងៃបង់ប្រាក់"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(292, 74)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 24)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Kh Battambang", 9.75!)
        Me.Label14.Location = New System.Drawing.Point(7, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 24)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "អតិថិជន"
        '
        'ErrPaid
        '
        Me.ErrPaid.ContainerControl = Me
        '
        'New_Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 508)
        Me.Controls.Add(Me.UiTab1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "New_Payment"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Payment"
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage1.ResumeLayout(False)
        Me.UiTabPage1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ErrPaid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUnpaidTHB As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalPaidTHB As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalTHB As System.Windows.Forms.TextBox
    Friend WithEvents txtUnpaidKHR As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalPaidKHR As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalKHR As System.Windows.Forms.TextBox
    Friend WithEvents txtUnpaidUSD As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalPaidUSD As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalUSD As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TxtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDateInvoice As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkPayAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCustName As System.Windows.Forms.TextBox
    Friend WithEvents DatePaid As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtMoreTHB As System.Windows.Forms.TextBox
    Friend WithEvents TxtMoreKHR As System.Windows.Forms.TextBox
    Friend WithEvents TxtMoreUSD As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ErrPaid As System.Windows.Forms.ErrorProvider
End Class
