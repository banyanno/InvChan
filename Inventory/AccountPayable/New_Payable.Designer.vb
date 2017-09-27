<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Payable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(New_Payable))
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.BtnSave = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnCancel = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ChAllPaid = New System.Windows.Forms.CheckBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtMoreTHB = New System.Windows.Forms.TextBox
        Me.TxtMoreKHR = New System.Windows.Forms.TextBox
        Me.TxtMoreUSD = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtUnPaidTHB = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtTotalPaidTHB = New System.Windows.Forms.TextBox
        Me.TxtTotalTHB = New System.Windows.Forms.TextBox
        Me.TxtUnPaidKHR = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.TxtTotalPaidKHR = New System.Windows.Forms.TextBox
        Me.TxtTotalKHR = New System.Windows.Forms.TextBox
        Me.TxtUnPaidUSD = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.TxtTotalPaidUSD = New System.Windows.Forms.TextBox
        Me.TxtTotalUSD = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.TxtNote = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LblAccountPayID = New System.Windows.Forms.Label
        Me.TxtDateOrder = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtPuchaseOrderNo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtSupplier = New System.Windows.Forms.TextBox
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
        Me.UiTab1.Size = New System.Drawing.Size(616, 446)
        Me.UiTab1.TabIndex = 3
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1})
        Me.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.ToolStrip2)
        Me.UiTabPage1.Controls.Add(Me.GroupBox1)
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(614, 424)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Payable Information"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnSave, Me.ToolStripSeparator4, Me.BtnCancel})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(614, 47)
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
        Me.GroupBox1.Controls.Add(Me.ChAllPaid)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.TxtNote)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(3, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 380)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ChAllPaid
        '
        Me.ChAllPaid.AutoSize = True
        Me.ChAllPaid.Location = New System.Drawing.Point(224, -17)
        Me.ChAllPaid.Margin = New System.Windows.Forms.Padding(2)
        Me.ChAllPaid.Name = "ChAllPaid"
        Me.ChAllPaid.Size = New System.Drawing.Size(85, 26)
        Me.ChAllPaid.TabIndex = 5
        Me.ChAllPaid.Text = "បង់ទាំងអស់"
        Me.ChAllPaid.UseVisualStyleBackColor = True
        Me.ChAllPaid.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TxtMoreTHB)
        Me.GroupBox5.Controls.Add(Me.TxtMoreKHR)
        Me.GroupBox5.Controls.Add(Me.GroupBox2)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.TxtUnPaidTHB)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.TxtTotalPaidTHB)
        Me.GroupBox5.Controls.Add(Me.TxtTotalTHB)
        Me.GroupBox5.Controls.Add(Me.TxtUnPaidKHR)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.TxtTotalPaidKHR)
        Me.GroupBox5.Controls.Add(Me.TxtTotalKHR)
        Me.GroupBox5.Controls.Add(Me.TxtUnPaidUSD)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.TxtTotalPaidUSD)
        Me.GroupBox5.Controls.Add(Me.TxtTotalUSD)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(7, 136)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(595, 120)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Paid Detail"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtMoreUSD)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(374, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(215, 75)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "បង់បន្ថែម"
        '
        'TxtMoreTHB
        '
        Me.TxtMoreTHB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMoreTHB.ForeColor = System.Drawing.Color.Red
        Me.TxtMoreTHB.Location = New System.Drawing.Point(325, 96)
        Me.TxtMoreTHB.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtMoreTHB.Name = "TxtMoreTHB"
        Me.TxtMoreTHB.Size = New System.Drawing.Size(104, 26)
        Me.TxtMoreTHB.TabIndex = 10
        Me.TxtMoreTHB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtMoreTHB.Visible = False
        '
        'TxtMoreKHR
        '
        Me.TxtMoreKHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMoreKHR.ForeColor = System.Drawing.Color.Red
        Me.TxtMoreKHR.Location = New System.Drawing.Point(324, 96)
        Me.TxtMoreKHR.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtMoreKHR.Name = "TxtMoreKHR"
        Me.TxtMoreKHR.Size = New System.Drawing.Size(104, 26)
        Me.TxtMoreKHR.TabIndex = 9
        Me.TxtMoreKHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtMoreKHR.Visible = False
        '
        'TxtMoreUSD
        '
        Me.TxtMoreUSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMoreUSD.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMoreUSD.ForeColor = System.Drawing.Color.Red
        Me.TxtMoreUSD.Location = New System.Drawing.Point(8, 31)
        Me.TxtMoreUSD.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtMoreUSD.Name = "TxtMoreUSD"
        Me.TxtMoreUSD.Size = New System.Drawing.Size(202, 37)
        Me.TxtMoreUSD.TabIndex = 8
        Me.TxtMoreUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 135)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 22)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "តំលៃ សរុប THB:"
        Me.Label5.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Kh Battambang", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(280, 32)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 19)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "ចំនួននៅសល់"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 133)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "តំលៃ សរុប KHR:"
        Me.Label4.Visible = False
        '
        'TxtUnPaidTHB
        '
        Me.TxtUnPaidTHB.Enabled = False
        Me.TxtUnPaidTHB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUnPaidTHB.ForeColor = System.Drawing.Color.Blue
        Me.TxtUnPaidTHB.Location = New System.Drawing.Point(337, 129)
        Me.TxtUnPaidTHB.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtUnPaidTHB.Name = "TxtUnPaidTHB"
        Me.TxtUnPaidTHB.Size = New System.Drawing.Size(104, 26)
        Me.TxtUnPaidTHB.TabIndex = 19
        Me.TxtUnPaidTHB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtUnPaidTHB.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(321, 131)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 22)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "="
        Me.Label9.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(200, 131)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 22)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "-"
        Me.Label8.Visible = False
        '
        'TxtTotalPaidTHB
        '
        Me.TxtTotalPaidTHB.BackColor = System.Drawing.Color.White
        Me.TxtTotalPaidTHB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPaidTHB.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalPaidTHB.Location = New System.Drawing.Point(217, 129)
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
        Me.TxtTotalTHB.Location = New System.Drawing.Point(98, 129)
        Me.TxtTotalTHB.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalTHB.Name = "TxtTotalTHB"
        Me.TxtTotalTHB.ReadOnly = True
        Me.TxtTotalTHB.Size = New System.Drawing.Size(100, 26)
        Me.TxtTotalTHB.TabIndex = 15
        Me.TxtTotalTHB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTotalTHB.Visible = False
        '
        'TxtUnPaidKHR
        '
        Me.TxtUnPaidKHR.Enabled = False
        Me.TxtUnPaidKHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUnPaidKHR.ForeColor = System.Drawing.Color.Blue
        Me.TxtUnPaidKHR.Location = New System.Drawing.Point(335, 126)
        Me.TxtUnPaidKHR.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtUnPaidKHR.Name = "TxtUnPaidKHR"
        Me.TxtUnPaidKHR.Size = New System.Drawing.Size(104, 26)
        Me.TxtUnPaidKHR.TabIndex = 13
        Me.TxtUnPaidKHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtUnPaidKHR.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(319, 129)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(17, 22)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "="
        Me.Label19.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(198, 129)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 22)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "-"
        Me.Label20.Visible = False
        '
        'TxtTotalPaidKHR
        '
        Me.TxtTotalPaidKHR.BackColor = System.Drawing.Color.White
        Me.TxtTotalPaidKHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPaidKHR.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalPaidKHR.Location = New System.Drawing.Point(215, 126)
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
        Me.TxtTotalKHR.Location = New System.Drawing.Point(96, 126)
        Me.TxtTotalKHR.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalKHR.Name = "TxtTotalKHR"
        Me.TxtTotalKHR.ReadOnly = True
        Me.TxtTotalKHR.Size = New System.Drawing.Size(100, 26)
        Me.TxtTotalKHR.TabIndex = 9
        Me.TxtTotalKHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTotalKHR.Visible = False
        '
        'TxtUnPaidUSD
        '
        Me.TxtUnPaidUSD.BackColor = System.Drawing.Color.Red
        Me.TxtUnPaidUSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUnPaidUSD.Enabled = False
        Me.TxtUnPaidUSD.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUnPaidUSD.ForeColor = System.Drawing.Color.Blue
        Me.TxtUnPaidUSD.Location = New System.Drawing.Point(265, 58)
        Me.TxtUnPaidUSD.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtUnPaidUSD.Name = "TxtUnPaidUSD"
        Me.TxtUnPaidUSD.Size = New System.Drawing.Size(104, 37)
        Me.TxtUnPaidUSD.TabIndex = 7
        Me.TxtUnPaidUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(244, 60)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(22, 29)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "="
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(119, 60)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(18, 29)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "-"
        '
        'TxtTotalPaidUSD
        '
        Me.TxtTotalPaidUSD.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTotalPaidUSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalPaidUSD.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPaidUSD.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalPaidUSD.Location = New System.Drawing.Point(142, 58)
        Me.TxtTotalPaidUSD.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalPaidUSD.Name = "TxtTotalPaidUSD"
        Me.TxtTotalPaidUSD.ReadOnly = True
        Me.TxtTotalPaidUSD.Size = New System.Drawing.Size(100, 37)
        Me.TxtTotalPaidUSD.TabIndex = 4
        Me.TxtTotalPaidUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotalUSD
        '
        Me.TxtTotalUSD.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTotalUSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalUSD.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalUSD.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalUSD.Location = New System.Drawing.Point(13, 58)
        Me.TxtTotalUSD.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalUSD.Name = "TxtTotalUSD"
        Me.TxtTotalUSD.ReadOnly = True
        Me.TxtTotalUSD.Size = New System.Drawing.Size(100, 37)
        Me.TxtTotalUSD.TabIndex = 3
        Me.TxtTotalUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(159, 29)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(70, 22)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "ចំនួនបានបង់"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(18, 29)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(79, 22)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "ចំនួនសរុប($)"
        '
        'TxtNote
        '
        Me.TxtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNote.Location = New System.Drawing.Point(10, 286)
        Me.TxtNote.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNote.Multiline = True
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.Size = New System.Drawing.Size(594, 89)
        Me.TxtNote.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 258)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 22)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "កំណត់សំគាល់"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.LblAccountPayID)
        Me.GroupBox3.Controls.Add(Me.TxtDateOrder)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TxtPuchaseOrderNo)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(330, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(269, 110)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Order Info"
        '
        'LblAccountPayID
        '
        Me.LblAccountPayID.AutoSize = True
        Me.LblAccountPayID.Location = New System.Drawing.Point(29, 26)
        Me.LblAccountPayID.Name = "LblAccountPayID"
        Me.LblAccountPayID.Size = New System.Drawing.Size(17, 22)
        Me.LblAccountPayID.TabIndex = 10
        Me.LblAccountPayID.Text = "0"
        Me.LblAccountPayID.Visible = False
        '
        'TxtDateOrder
        '
        Me.TxtDateOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDateOrder.Location = New System.Drawing.Point(94, 67)
        Me.TxtDateOrder.Name = "TxtDateOrder"
        Me.TxtDateOrder.Size = New System.Drawing.Size(152, 26)
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
        Me.Label6.Location = New System.Drawing.Point(8, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 22)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "ថ្ងៃ បញ្ជាទិញ:"
        '
        'TxtPuchaseOrderNo
        '
        Me.TxtPuchaseOrderNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPuchaseOrderNo.Location = New System.Drawing.Point(94, 32)
        Me.TxtPuchaseOrderNo.Name = "TxtPuchaseOrderNo"
        Me.TxtPuchaseOrderNo.ReadOnly = True
        Me.TxtPuchaseOrderNo.Size = New System.Drawing.Size(152, 26)
        Me.TxtPuchaseOrderNo.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 22)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "លេខ បញ្ជាទិញ:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.TxtSupplier)
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
        Me.GroupBox4.Text = "Select Supplyer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(292, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "*"
        '
        'TxtSupplier
        '
        Me.TxtSupplier.Font = New System.Drawing.Font("Kh Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSupplier.Location = New System.Drawing.Point(93, 67)
        Me.TxtSupplier.Name = "TxtSupplier"
        Me.TxtSupplier.Size = New System.Drawing.Size(195, 36)
        Me.TxtSupplier.TabIndex = 9
        '
        'DatePaid
        '
        Me.DatePaid.Checked = False
        Me.DatePaid.CustomFormat = "dd/MM/yyyy"
        Me.DatePaid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePaid.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatePaid.Location = New System.Drawing.Point(93, 28)
        Me.DatePaid.Margin = New System.Windows.Forms.Padding(2)
        Me.DatePaid.Name = "DatePaid"
        Me.DatePaid.ShowCheckBox = True
        Me.DatePaid.Size = New System.Drawing.Size(195, 26)
        Me.DatePaid.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ថ្ងៃបង់ប្រាក់"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(292, 80)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 22)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(7, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 22)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "អ្នកផ្គត់ផ្គង់"
        '
        'ErrPaid
        '
        Me.ErrPaid.ContainerControl = Me
        '
        'New_Payable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 446)
        Me.Controls.Add(Me.UiTab1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "New_Payable"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New_Payable"
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
    Friend WithEvents TxtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ChAllPaid As System.Windows.Forms.CheckBox
    Friend WithEvents DatePaid As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDateOrder As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPuchaseOrderNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtSupplier As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ErrPaid As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblAccountPayID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtUnPaidTHB As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalPaidTHB As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalTHB As System.Windows.Forms.TextBox
    Friend WithEvents TxtUnPaidKHR As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalPaidKHR As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalKHR As System.Windows.Forms.TextBox
    Friend WithEvents TxtUnPaidUSD As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalPaidUSD As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalUSD As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtMoreTHB As System.Windows.Forms.TextBox
    Friend WithEvents TxtMoreKHR As System.Windows.Forms.TextBox
    Friend WithEvents TxtMoreUSD As System.Windows.Forms.TextBox
End Class
