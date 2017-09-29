<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiveStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReceiveStock))
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnCancel = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtNote = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtInvoiceReferrent = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateReceived = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtTotalTHB = New System.Windows.Forms.TextBox
        Me.TxtTotalKHR = New System.Windows.Forms.TextBox
        Me.TxtTotalUSD = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LblPurchaseID = New System.Windows.Forms.Label
        Me.TxtDateOrder = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtPuchaseOrderNo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.LblSuppID = New System.Windows.Forms.Label
        Me.TxtSupplier = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtSupTelephone = New System.Windows.Forms.TextBox
        Me.TxtSuppAddress = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.ErrReceiveOrder = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ErrReceiveOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiTab1
        '
        Me.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab1.Location = New System.Drawing.Point(0, 0)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Size = New System.Drawing.Size(620, 580)
        Me.UiTab1.TabIndex = 2
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1})
        Me.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.ToolStrip2)
        Me.UiTabPage1.Controls.Add(Me.GroupBox1)
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(618, 558)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Received Information"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator4, Me.BtnCancel})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(618, 47)
        Me.ToolStrip2.TabIndex = 13
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton1.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.Save
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(65, 44)
        Me.ToolStripButton1.Text = "     Save     "
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.GroupBox1.Controls.Add(Me.TxtNote)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(3, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 516)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TxtNote
        '
        Me.TxtNote.Location = New System.Drawing.Point(7, 392)
        Me.TxtNote.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNote.Multiline = True
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtNote.Size = New System.Drawing.Size(594, 119)
        Me.TxtNote.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(5, 370)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 22)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "ចំណាំ"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.txtInvoiceReferrent)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.DateReceived)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.GroupBox2)
        Me.GroupBox5.Location = New System.Drawing.Point(7, 136)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(592, 232)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(322, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 22)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "លេខ យោង:"
        '
        'txtInvoiceReferrent
        '
        Me.txtInvoiceReferrent.Location = New System.Drawing.Point(401, 25)
        Me.txtInvoiceReferrent.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInvoiceReferrent.Name = "txtInvoiceReferrent"
        Me.txtInvoiceReferrent.Size = New System.Drawing.Size(152, 30)
        Me.txtInvoiceReferrent.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(296, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "*"
        '
        'DateReceived
        '
        Me.DateReceived.Checked = False
        Me.DateReceived.CustomFormat = "dd/MM/yyyy"
        Me.DateReceived.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateReceived.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateReceived.Location = New System.Drawing.Point(97, 29)
        Me.DateReceived.Margin = New System.Windows.Forms.Padding(2)
        Me.DateReceived.Name = "DateReceived"
        Me.DateReceived.ShowCheckBox = True
        Me.DateReceived.Size = New System.Drawing.Size(195, 26)
        Me.DateReceived.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ថ្ងៃ ទទួល:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.TxtTotalTHB)
        Me.GroupBox2.Controls.Add(Me.TxtTotalKHR)
        Me.GroupBox2.Controls.Add(Me.TxtTotalUSD)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(4, 70)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(584, 158)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ចំននួនទឹកប្រាក់សរុប ត្រូវបង់"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox6.Location = New System.Drawing.Point(319, 21)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Size = New System.Drawing.Size(260, 126)
        Me.GroupBox6.TabIndex = 12
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Caution"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Kh Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 34)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(246, 75)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "- និងត្រូវsave ចូលក្នុង Account Payable" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- និងត្រូវ Update inventory " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtTotalTHB
        '
        Me.TxtTotalTHB.BackColor = System.Drawing.Color.White
        Me.TxtTotalTHB.Font = New System.Drawing.Font("Kh Battambang", 10.0!)
        Me.TxtTotalTHB.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalTHB.Location = New System.Drawing.Point(103, 116)
        Me.TxtTotalTHB.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalTHB.Name = "TxtTotalTHB"
        Me.TxtTotalTHB.ReadOnly = True
        Me.TxtTotalTHB.Size = New System.Drawing.Size(185, 32)
        Me.TxtTotalTHB.TabIndex = 11
        Me.TxtTotalTHB.Text = "0"
        Me.TxtTotalTHB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotalKHR
        '
        Me.TxtTotalKHR.BackColor = System.Drawing.Color.White
        Me.TxtTotalKHR.Font = New System.Drawing.Font("Kh Battambang", 10.0!)
        Me.TxtTotalKHR.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalKHR.Location = New System.Drawing.Point(103, 72)
        Me.TxtTotalKHR.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalKHR.Name = "TxtTotalKHR"
        Me.TxtTotalKHR.ReadOnly = True
        Me.TxtTotalKHR.Size = New System.Drawing.Size(185, 32)
        Me.TxtTotalKHR.TabIndex = 10
        Me.TxtTotalKHR.Text = "0"
        Me.TxtTotalKHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotalUSD
        '
        Me.TxtTotalUSD.BackColor = System.Drawing.Color.White
        Me.TxtTotalUSD.Font = New System.Drawing.Font("Kh Battambang", 10.0!)
        Me.TxtTotalUSD.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalUSD.Location = New System.Drawing.Point(103, 28)
        Me.TxtTotalUSD.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalUSD.Name = "TxtTotalUSD"
        Me.TxtTotalUSD.ReadOnly = True
        Me.TxtTotalUSD.Size = New System.Drawing.Size(185, 32)
        Me.TxtTotalUSD.TabIndex = 9
        Me.TxtTotalUSD.Text = "0"
        Me.TxtTotalUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 125)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 22)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "តំលៃ សរុប THB:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 80)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "តំលៃ សរុប KHR:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 37)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "តំលៃ សរុប USD:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.LblPurchaseID)
        Me.GroupBox3.Controls.Add(Me.TxtDateOrder)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TxtPuchaseOrderNo)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(330, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(269, 122)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Order Info"
        '
        'LblPurchaseID
        '
        Me.LblPurchaseID.AutoSize = True
        Me.LblPurchaseID.Location = New System.Drawing.Point(20, 95)
        Me.LblPurchaseID.Name = "LblPurchaseID"
        Me.LblPurchaseID.Size = New System.Drawing.Size(17, 22)
        Me.LblPurchaseID.TabIndex = 11
        Me.LblPurchaseID.Text = "0"
        Me.LblPurchaseID.Visible = False
        '
        'TxtDateOrder
        '
        Me.TxtDateOrder.CustomFormat = "dd/MM/yyyy"
        Me.TxtDateOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtDateOrder.Location = New System.Drawing.Point(92, 67)
        Me.TxtDateOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDateOrder.Name = "TxtDateOrder"
        Me.TxtDateOrder.Size = New System.Drawing.Size(151, 30)
        Me.TxtDateOrder.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(248, 36)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 22)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 22)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "ថ្ងៃ បញ្ជាទិញ:"
        '
        'TxtPuchaseOrderNo
        '
        Me.TxtPuchaseOrderNo.BackColor = System.Drawing.Color.White
        Me.TxtPuchaseOrderNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPuchaseOrderNo.Location = New System.Drawing.Point(92, 32)
        Me.TxtPuchaseOrderNo.Name = "TxtPuchaseOrderNo"
        Me.TxtPuchaseOrderNo.ReadOnly = True
        Me.TxtPuchaseOrderNo.Size = New System.Drawing.Size(152, 26)
        Me.TxtPuchaseOrderNo.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 22)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "លេខ បញ្ជាទិញ:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.LblSuppID)
        Me.GroupBox4.Controls.Add(Me.TxtSupplier)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.TxtSupTelephone)
        Me.GroupBox4.Controls.Add(Me.TxtSuppAddress)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(7, 11)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(317, 122)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Select Supplyer"
        '
        'LblSuppID
        '
        Me.LblSuppID.AutoSize = True
        Me.LblSuppID.Location = New System.Drawing.Point(64, 41)
        Me.LblSuppID.Name = "LblSuppID"
        Me.LblSuppID.Size = New System.Drawing.Size(17, 22)
        Me.LblSuppID.TabIndex = 10
        Me.LblSuppID.Text = "0"
        Me.LblSuppID.Visible = False
        '
        'TxtSupplier
        '
        Me.TxtSupplier.BackColor = System.Drawing.Color.White
        Me.TxtSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSupplier.Location = New System.Drawing.Point(97, 22)
        Me.TxtSupplier.Name = "TxtSupplier"
        Me.TxtSupplier.ReadOnly = True
        Me.TxtSupplier.Size = New System.Drawing.Size(195, 26)
        Me.TxtSupplier.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(296, 93)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 22)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(296, 59)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 22)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(296, 25)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 22)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "*"
        '
        'TxtSupTelephone
        '
        Me.TxtSupTelephone.BackColor = System.Drawing.Color.White
        Me.TxtSupTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSupTelephone.Location = New System.Drawing.Point(97, 89)
        Me.TxtSupTelephone.Name = "TxtSupTelephone"
        Me.TxtSupTelephone.ReadOnly = True
        Me.TxtSupTelephone.Size = New System.Drawing.Size(195, 26)
        Me.TxtSupTelephone.TabIndex = 5
        '
        'TxtSuppAddress
        '
        Me.TxtSuppAddress.BackColor = System.Drawing.Color.White
        Me.TxtSuppAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSuppAddress.Location = New System.Drawing.Point(97, 55)
        Me.TxtSuppAddress.Name = "TxtSuppAddress"
        Me.TxtSuppAddress.ReadOnly = True
        Me.TxtSuppAddress.Size = New System.Drawing.Size(195, 26)
        Me.TxtSuppAddress.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 22)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Telephone:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 22)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Address:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 22)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "អ្នកផ្គត់ផ្គង់"
        '
        'ErrReceiveOrder
        '
        Me.ErrReceiveOrder.ContainerControl = Me
        '
        'ReceiveStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 580)
        Me.Controls.Add(Me.UiTab1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReceiveStock"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receive Order"
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
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ErrReceiveOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateReceived As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtTotalTHB As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalKHR As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalUSD As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPuchaseOrderNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtSupTelephone As System.Windows.Forms.TextBox
    Friend WithEvents TxtSuppAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtSupplier As System.Windows.Forms.TextBox
    Friend WithEvents LblSuppID As System.Windows.Forms.Label
    Friend WithEvents TxtDateOrder As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceReferrent As System.Windows.Forms.TextBox
    Friend WithEvents LblPurchaseID As System.Windows.Forms.Label
    Friend WithEvents ErrReceiveOrder As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
