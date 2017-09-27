<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoicePayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InvoicePayment))
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.BtnSave = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnCancel = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.ChkPayAll = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtUnpaidTHB = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
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
        Me.ErrSale = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ErrSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiTab1
        '
        Me.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab1.Location = New System.Drawing.Point(0, 0)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Size = New System.Drawing.Size(619, 493)
        Me.UiTab1.TabIndex = 5
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1})
        Me.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.ToolStrip2)
        Me.UiTabPage1.Controls.Add(Me.GroupBox1)
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(617, 471)
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
        Me.ToolStrip2.Size = New System.Drawing.Size(617, 47)
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
        Me.GroupBox1.Size = New System.Drawing.Size(608, 420)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ChkPayAll)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txtUnpaidTHB)
        Me.GroupBox5.Controls.Add(Me.Label3)
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
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(7, 129)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(588, 205)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Payment Details"
        '
        'ChkPayAll
        '
        Me.ChkPayAll.AutoSize = True
        Me.ChkPayAll.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.ChkPayAll.Location = New System.Drawing.Point(49, 37)
        Me.ChkPayAll.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkPayAll.Name = "ChkPayAll"
        Me.ChkPayAll.Size = New System.Drawing.Size(85, 26)
        Me.ChkPayAll.TabIndex = 5
        Me.ChkPayAll.Text = "បង់ទាំងអស់"
        Me.ChkPayAll.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(41, 162)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 22)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "តំលៃ សរុប THB:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(396, 64)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 22)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "នៅសល់"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(41, 127)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "តំលៃ សរុប KHR:"
        '
        'txtUnpaidTHB
        '
        Me.txtUnpaidTHB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnpaidTHB.ForeColor = System.Drawing.Color.Blue
        Me.txtUnpaidTHB.Location = New System.Drawing.Point(371, 160)
        Me.txtUnpaidTHB.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUnpaidTHB.Name = "txtUnpaidTHB"
        Me.txtUnpaidTHB.ReadOnly = True
        Me.txtUnpaidTHB.Size = New System.Drawing.Size(104, 26)
        Me.txtUnpaidTHB.TabIndex = 19
        Me.txtUnpaidTHB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(41, 90)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "តំលៃ សរុប USD:"
        '
        'TxtTotalPaidTHB
        '
        Me.TxtTotalPaidTHB.BackColor = System.Drawing.Color.White
        Me.TxtTotalPaidTHB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPaidTHB.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalPaidTHB.Location = New System.Drawing.Point(251, 160)
        Me.TxtTotalPaidTHB.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalPaidTHB.Name = "TxtTotalPaidTHB"
        Me.TxtTotalPaidTHB.Size = New System.Drawing.Size(100, 26)
        Me.TxtTotalPaidTHB.TabIndex = 16
        Me.TxtTotalPaidTHB.Text = "0"
        Me.TxtTotalPaidTHB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalTHB
        '
        Me.txtTotalTHB.BackColor = System.Drawing.Color.White
        Me.txtTotalTHB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalTHB.ForeColor = System.Drawing.Color.Red
        Me.txtTotalTHB.Location = New System.Drawing.Point(132, 160)
        Me.txtTotalTHB.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotalTHB.Name = "txtTotalTHB"
        Me.txtTotalTHB.ReadOnly = True
        Me.txtTotalTHB.Size = New System.Drawing.Size(100, 26)
        Me.txtTotalTHB.TabIndex = 15
        Me.txtTotalTHB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnpaidKHR
        '
        Me.txtUnpaidKHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnpaidKHR.ForeColor = System.Drawing.Color.Blue
        Me.txtUnpaidKHR.Location = New System.Drawing.Point(371, 124)
        Me.txtUnpaidKHR.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUnpaidKHR.Name = "txtUnpaidKHR"
        Me.txtUnpaidKHR.ReadOnly = True
        Me.txtUnpaidKHR.Size = New System.Drawing.Size(104, 26)
        Me.txtUnpaidKHR.TabIndex = 13
        Me.txtUnpaidKHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotalPaidKHR
        '
        Me.TxtTotalPaidKHR.BackColor = System.Drawing.Color.White
        Me.TxtTotalPaidKHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPaidKHR.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalPaidKHR.Location = New System.Drawing.Point(251, 124)
        Me.TxtTotalPaidKHR.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalPaidKHR.Name = "TxtTotalPaidKHR"
        Me.TxtTotalPaidKHR.Size = New System.Drawing.Size(100, 26)
        Me.TxtTotalPaidKHR.TabIndex = 10
        Me.TxtTotalPaidKHR.Text = "0"
        Me.TxtTotalPaidKHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalKHR
        '
        Me.txtTotalKHR.BackColor = System.Drawing.Color.White
        Me.txtTotalKHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalKHR.ForeColor = System.Drawing.Color.Red
        Me.txtTotalKHR.Location = New System.Drawing.Point(132, 124)
        Me.txtTotalKHR.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotalKHR.Name = "txtTotalKHR"
        Me.txtTotalKHR.ReadOnly = True
        Me.txtTotalKHR.Size = New System.Drawing.Size(100, 26)
        Me.txtTotalKHR.TabIndex = 9
        Me.txtTotalKHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnpaidUSD
        '
        Me.txtUnpaidUSD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnpaidUSD.ForeColor = System.Drawing.Color.Blue
        Me.txtUnpaidUSD.Location = New System.Drawing.Point(371, 88)
        Me.txtUnpaidUSD.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUnpaidUSD.Name = "txtUnpaidUSD"
        Me.txtUnpaidUSD.ReadOnly = True
        Me.txtUnpaidUSD.Size = New System.Drawing.Size(104, 26)
        Me.txtUnpaidUSD.TabIndex = 7
        Me.txtUnpaidUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotalPaidUSD
        '
        Me.TxtTotalPaidUSD.BackColor = System.Drawing.Color.White
        Me.TxtTotalPaidUSD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPaidUSD.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalPaidUSD.Location = New System.Drawing.Point(251, 88)
        Me.TxtTotalPaidUSD.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalPaidUSD.Name = "TxtTotalPaidUSD"
        Me.TxtTotalPaidUSD.Size = New System.Drawing.Size(100, 26)
        Me.TxtTotalPaidUSD.TabIndex = 4
        Me.TxtTotalPaidUSD.Text = "0"
        Me.TxtTotalPaidUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalUSD
        '
        Me.txtTotalUSD.BackColor = System.Drawing.Color.White
        Me.txtTotalUSD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalUSD.ForeColor = System.Drawing.Color.Red
        Me.txtTotalUSD.Location = New System.Drawing.Point(132, 88)
        Me.txtTotalUSD.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotalUSD.Name = "txtTotalUSD"
        Me.txtTotalUSD.ReadOnly = True
        Me.txtTotalUSD.Size = New System.Drawing.Size(100, 26)
        Me.txtTotalUSD.TabIndex = 3
        Me.txtTotalUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label24.Location = New System.Drawing.Point(271, 63)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(50, 22)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "ប្រាក់បង់"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label25.Location = New System.Drawing.Point(157, 63)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(58, 22)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "ចំនួនសរុប"
        '
        'TxtNote
        '
        Me.TxtNote.Location = New System.Drawing.Point(10, 353)
        Me.TxtNote.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNote.Multiline = True
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.Size = New System.Drawing.Size(594, 60)
        Me.TxtNote.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label18.Location = New System.Drawing.Point(7, 336)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 22)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "ចំណាំ"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtDateInvoice)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtInvoiceNo)
        Me.GroupBox3.Controls.Add(Me.Label7)
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
        Me.txtDateInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateInvoice.Location = New System.Drawing.Point(94, 67)
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
        Me.Label13.Size = New System.Drawing.Size(12, 15)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(8, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 22)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "ថ្ងៃ បញ្ជាទិញ:"
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNo.Location = New System.Drawing.Point(94, 32)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.ReadOnly = True
        Me.txtInvoiceNo.Size = New System.Drawing.Size(152, 26)
        Me.txtInvoiceNo.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(8, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 22)
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
        Me.Label1.Size = New System.Drawing.Size(12, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "*"
        '
        'txtCustName
        '
        Me.txtCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustName.Location = New System.Drawing.Point(93, 67)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(195, 26)
        Me.txtCustName.TabIndex = 9
        '
        'DatePaid
        '
        Me.DatePaid.Checked = False
        Me.DatePaid.CustomFormat = "dd/MM/yyyy"
        Me.DatePaid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePaid.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatePaid.Location = New System.Drawing.Point(93, 33)
        Me.DatePaid.Margin = New System.Windows.Forms.Padding(2)
        Me.DatePaid.Name = "DatePaid"
        Me.DatePaid.ShowCheckBox = True
        Me.DatePaid.Size = New System.Drawing.Size(195, 26)
        Me.DatePaid.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ថ្ងៃបង់ប្រាក់"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(292, 67)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 15)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label14.Location = New System.Drawing.Point(7, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 22)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "អតិថិជន"
        '
        'ErrSale
        '
        Me.ErrSale.ContainerControl = Me
        '
        'InvoicePayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 493)
        Me.Controls.Add(Me.UiTab1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InvoicePayment"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice Payment"
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
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ErrSale, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ChkPayAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUnpaidTHB As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCustName As System.Windows.Forms.TextBox
    Friend WithEvents DatePaid As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ErrSale As System.Windows.Forms.ErrorProvider
End Class
