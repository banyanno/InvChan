<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainDashBaord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainDashBaord))
        Me.ImgListDashbord = New System.Windows.Forms.ImageList(Me.components)
        Me.LblComProfile = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnComProfile = New System.Windows.Forms.Button
        Me.BtnPayAble = New System.Windows.Forms.Button
        Me.BtnCustomer = New System.Windows.Forms.Button
        Me.BtnRevenue = New System.Windows.Forms.Button
        Me.BtnMeaser = New System.Windows.Forms.Button
        Me.BtnSupplyer = New System.Windows.Forms.Button
        Me.BtnProducts = New System.Windows.Forms.Button
        Me.BtnAccReAble = New System.Windows.Forms.Button
        Me.BtnTransact = New System.Windows.Forms.Button
        Me.BtnCategory = New System.Windows.Forms.Button
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnAccessRight = New System.Windows.Forms.Button
        Me.btnuser = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnProductOrder = New System.Windows.Forms.Button
        Me.BtnSale = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.ImgListDashbord.Images.SetKeyName(25, "Login.png")
        Me.ImgListDashbord.Images.SetKeyName(26, "Shopping.png")
        Me.ImgListDashbord.Images.SetKeyName(27, "receive.png")
        '
        'LblComProfile
        '
        Me.LblComProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblComProfile.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblComProfile.ForeColor = System.Drawing.Color.Blue
        Me.LblComProfile.Location = New System.Drawing.Point(15, 23)
        Me.LblComProfile.Name = "LblComProfile"
        Me.LblComProfile.Size = New System.Drawing.Size(329, 422)
        Me.LblComProfile.TabIndex = 0
        Me.LblComProfile.Text = resources.GetString("LblComProfile.Text")
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Brown
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 768)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1642, 30)
        Me.Panel4.TabIndex = 38
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnComProfile)
        Me.GroupBox1.Controls.Add(Me.BtnPayAble)
        Me.GroupBox1.Controls.Add(Me.BtnCustomer)
        Me.GroupBox1.Controls.Add(Me.BtnRevenue)
        Me.GroupBox1.Controls.Add(Me.BtnMeaser)
        Me.GroupBox1.Controls.Add(Me.BtnSupplyer)
        Me.GroupBox1.Controls.Add(Me.BtnProducts)
        Me.GroupBox1.Controls.Add(Me.BtnAccReAble)
        Me.GroupBox1.Controls.Add(Me.BtnTransact)
        Me.GroupBox1.Controls.Add(Me.BtnCategory)
        Me.GroupBox1.Controls.Add(Me.BtnClose)
        Me.GroupBox1.Controls.Add(Me.BtnAccessRight)
        Me.GroupBox1.Controls.Add(Me.btnuser)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(354, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(923, 324)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'BtnComProfile
        '
        Me.BtnComProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnComProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnComProfile.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComProfile.ForeColor = System.Drawing.Color.Green
        Me.BtnComProfile.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnComProfile.ImageIndex = 25
        Me.BtnComProfile.ImageList = Me.ImgListDashbord
        Me.BtnComProfile.Location = New System.Drawing.Point(520, 129)
        Me.BtnComProfile.Name = "BtnComProfile"
        Me.BtnComProfile.Size = New System.Drawing.Size(178, 77)
        Me.BtnComProfile.TabIndex = 12
        Me.BtnComProfile.Text = "Company Profile"
        Me.BtnComProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnComProfile.UseVisualStyleBackColor = True
        '
        'BtnPayAble
        '
        Me.BtnPayAble.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPayAble.Enabled = False
        Me.BtnPayAble.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPayAble.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPayAble.ForeColor = System.Drawing.Color.Green
        Me.BtnPayAble.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPayAble.ImageIndex = 3
        Me.BtnPayAble.ImageList = Me.ImgListDashbord
        Me.BtnPayAble.Location = New System.Drawing.Point(520, 229)
        Me.BtnPayAble.Name = "BtnPayAble"
        Me.BtnPayAble.Size = New System.Drawing.Size(178, 77)
        Me.BtnPayAble.TabIndex = 10
        Me.BtnPayAble.Text = "បញ្ជីប្រាក់ជំពាក់"
        Me.BtnPayAble.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPayAble.UseVisualStyleBackColor = True
        '
        'BtnCustomer
        '
        Me.BtnCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCustomer.Enabled = False
        Me.BtnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCustomer.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCustomer.ForeColor = System.Drawing.Color.Green
        Me.BtnCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCustomer.ImageIndex = 18
        Me.BtnCustomer.ImageList = Me.ImgListDashbord
        Me.BtnCustomer.Location = New System.Drawing.Point(15, 32)
        Me.BtnCustomer.Name = "BtnCustomer"
        Me.BtnCustomer.Size = New System.Drawing.Size(147, 77)
        Me.BtnCustomer.TabIndex = 0
        Me.BtnCustomer.Text = "អតិថិជន"
        Me.BtnCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCustomer.UseVisualStyleBackColor = True
        '
        'BtnRevenue
        '
        Me.BtnRevenue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRevenue.Enabled = False
        Me.BtnRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRevenue.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRevenue.ForeColor = System.Drawing.Color.Green
        Me.BtnRevenue.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnRevenue.ImageIndex = 21
        Me.BtnRevenue.ImageList = Me.ImgListDashbord
        Me.BtnRevenue.Location = New System.Drawing.Point(520, 32)
        Me.BtnRevenue.Name = "BtnRevenue"
        Me.BtnRevenue.Size = New System.Drawing.Size(178, 77)
        Me.BtnRevenue.TabIndex = 3
        Me.BtnRevenue.Text = "អត្រាប្តូរប្រាក់"
        Me.BtnRevenue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnRevenue.UseVisualStyleBackColor = True
        '
        'BtnMeaser
        '
        Me.BtnMeaser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMeaser.Enabled = False
        Me.BtnMeaser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnMeaser.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMeaser.ForeColor = System.Drawing.Color.Green
        Me.BtnMeaser.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnMeaser.ImageIndex = 11
        Me.BtnMeaser.ImageList = Me.ImgListDashbord
        Me.BtnMeaser.Location = New System.Drawing.Point(181, 129)
        Me.BtnMeaser.Name = "BtnMeaser"
        Me.BtnMeaser.Size = New System.Drawing.Size(147, 77)
        Me.BtnMeaser.TabIndex = 5
        Me.BtnMeaser.Text = "រង្វាស់/ខ្នាត"
        Me.BtnMeaser.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnMeaser.UseVisualStyleBackColor = True
        '
        'BtnSupplyer
        '
        Me.BtnSupplyer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSupplyer.Enabled = False
        Me.BtnSupplyer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSupplyer.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSupplyer.ForeColor = System.Drawing.Color.Green
        Me.BtnSupplyer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSupplyer.ImageIndex = 4
        Me.BtnSupplyer.ImageList = Me.ImgListDashbord
        Me.BtnSupplyer.Location = New System.Drawing.Point(181, 32)
        Me.BtnSupplyer.Name = "BtnSupplyer"
        Me.BtnSupplyer.Size = New System.Drawing.Size(145, 77)
        Me.BtnSupplyer.TabIndex = 1
        Me.BtnSupplyer.Text = "អ្នកផ្គត់ផ្គង"
        Me.BtnSupplyer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSupplyer.UseVisualStyleBackColor = True
        '
        'BtnProducts
        '
        Me.BtnProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProducts.Enabled = False
        Me.BtnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnProducts.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProducts.ForeColor = System.Drawing.Color.Green
        Me.BtnProducts.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnProducts.ImageIndex = 22
        Me.BtnProducts.ImageList = Me.ImgListDashbord
        Me.BtnProducts.Location = New System.Drawing.Point(17, 129)
        Me.BtnProducts.Name = "BtnProducts"
        Me.BtnProducts.Size = New System.Drawing.Size(145, 77)
        Me.BtnProducts.TabIndex = 4
        Me.BtnProducts.Text = "មុខទំនិញ"
        Me.BtnProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnProducts.UseVisualStyleBackColor = True
        '
        'BtnAccReAble
        '
        Me.BtnAccReAble.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAccReAble.Enabled = False
        Me.BtnAccReAble.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAccReAble.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAccReAble.ForeColor = System.Drawing.Color.Green
        Me.BtnAccReAble.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAccReAble.ImageIndex = 3
        Me.BtnAccReAble.ImageList = Me.ImgListDashbord
        Me.BtnAccReAble.Location = New System.Drawing.Point(343, 229)
        Me.BtnAccReAble.Name = "BtnAccReAble"
        Me.BtnAccReAble.Size = New System.Drawing.Size(154, 77)
        Me.BtnAccReAble.TabIndex = 9
        Me.BtnAccReAble.Text = "បញ្ជីប្រាក់ចំណូល"
        Me.BtnAccReAble.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAccReAble.UseVisualStyleBackColor = True
        '
        'BtnTransact
        '
        Me.BtnTransact.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTransact.Enabled = False
        Me.BtnTransact.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnTransact.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransact.ForeColor = System.Drawing.Color.Green
        Me.BtnTransact.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnTransact.ImageIndex = 13
        Me.BtnTransact.ImageList = Me.ImgListDashbord
        Me.BtnTransact.Location = New System.Drawing.Point(343, 32)
        Me.BtnTransact.Name = "BtnTransact"
        Me.BtnTransact.Size = New System.Drawing.Size(154, 77)
        Me.BtnTransact.TabIndex = 2
        Me.BtnTransact.Text = "Tran/Adjust Stock"
        Me.BtnTransact.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnTransact.UseVisualStyleBackColor = True
        '
        'BtnCategory
        '
        Me.BtnCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCategory.Enabled = False
        Me.BtnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCategory.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCategory.ForeColor = System.Drawing.Color.Green
        Me.BtnCategory.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCategory.ImageIndex = 20
        Me.BtnCategory.ImageList = Me.ImgListDashbord
        Me.BtnCategory.Location = New System.Drawing.Point(343, 129)
        Me.BtnCategory.Name = "BtnCategory"
        Me.BtnCategory.Size = New System.Drawing.Size(154, 77)
        Me.BtnCategory.TabIndex = 6
        Me.BtnCategory.Text = "ប្រភេទទំនិញ"
        Me.BtnCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCategory.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnClose.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.Green
        Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnClose.ImageIndex = 6
        Me.BtnClose.ImageList = Me.ImgListDashbord
        Me.BtnClose.Location = New System.Drawing.Point(714, 129)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(178, 77)
        Me.BtnClose.TabIndex = 11
        Me.BtnClose.Text = "បិត"
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnClose.UseVisualStyleBackColor = True
        Me.BtnClose.Visible = False
        '
        'BtnAccessRight
        '
        Me.BtnAccessRight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAccessRight.Enabled = False
        Me.BtnAccessRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAccessRight.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAccessRight.ForeColor = System.Drawing.Color.Green
        Me.BtnAccessRight.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAccessRight.ImageIndex = 1
        Me.BtnAccessRight.ImageList = Me.ImgListDashbord
        Me.BtnAccessRight.Location = New System.Drawing.Point(15, 229)
        Me.BtnAccessRight.Name = "BtnAccessRight"
        Me.BtnAccessRight.Size = New System.Drawing.Size(147, 77)
        Me.BtnAccessRight.TabIndex = 7
        Me.BtnAccessRight.Text = "Sys-Previlage"
        Me.BtnAccessRight.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAccessRight.UseVisualStyleBackColor = True
        '
        'btnuser
        '
        Me.btnuser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnuser.Enabled = False
        Me.btnuser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnuser.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnuser.ForeColor = System.Drawing.Color.Green
        Me.btnuser.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnuser.ImageIndex = 23
        Me.btnuser.ImageList = Me.ImgListDashbord
        Me.btnuser.Location = New System.Drawing.Point(181, 229)
        Me.btnuser.Name = "btnuser"
        Me.btnuser.Size = New System.Drawing.Size(145, 77)
        Me.btnuser.TabIndex = 8
        Me.btnuser.Text = "អ្នកប្រប្រាស់"
        Me.btnuser.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnuser.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(695, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 39)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Inventory Setting"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnProductOrder
        '
        Me.BtnProductOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProductOrder.Enabled = False
        Me.BtnProductOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnProductOrder.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductOrder.ForeColor = System.Drawing.Color.Green
        Me.BtnProductOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnProductOrder.ImageIndex = 27
        Me.BtnProductOrder.ImageList = Me.ImgListDashbord
        Me.BtnProductOrder.Location = New System.Drawing.Point(535, 23)
        Me.BtnProductOrder.Name = "BtnProductOrder"
        Me.BtnProductOrder.Size = New System.Drawing.Size(145, 67)
        Me.BtnProductOrder.TabIndex = 2
        Me.BtnProductOrder.Text = "ទទួល/បញ្ចាទិញ"
        Me.BtnProductOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnProductOrder.UseVisualStyleBackColor = True
        '
        'BtnSale
        '
        Me.BtnSale.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSale.Enabled = False
        Me.BtnSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSale.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSale.ForeColor = System.Drawing.Color.Green
        Me.BtnSale.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSale.ImageIndex = 26
        Me.BtnSale.ImageList = Me.ImgListDashbord
        Me.BtnSale.Location = New System.Drawing.Point(369, 23)
        Me.BtnSale.Name = "BtnSale"
        Me.BtnSale.Size = New System.Drawing.Size(147, 67)
        Me.BtnSale.TabIndex = 1
        Me.BtnSale.Text = "លក់ ដុំ/រាយ"
        Me.BtnSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSale.UseVisualStyleBackColor = True
        '
        'MainDashBaord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.LblComProfile)
        Me.Controls.Add(Me.BtnProductOrder)
        Me.Controls.Add(Me.BtnSale)
        Me.Name = "MainDashBaord"
        Me.Size = New System.Drawing.Size(1642, 798)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImgListDashbord As System.Windows.Forms.ImageList
    Friend WithEvents LblComProfile As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnAccessRight As System.Windows.Forms.Button
    Friend WithEvents BtnRevenue As System.Windows.Forms.Button
    Friend WithEvents BtnProducts As System.Windows.Forms.Button
    Friend WithEvents btnuser As System.Windows.Forms.Button
    Friend WithEvents BtnCategory As System.Windows.Forms.Button
    Friend WithEvents BtnTransact As System.Windows.Forms.Button
    Friend WithEvents BtnMeaser As System.Windows.Forms.Button
    Friend WithEvents BtnAccReAble As System.Windows.Forms.Button
    Friend WithEvents BtnSupplyer As System.Windows.Forms.Button
    Friend WithEvents BtnCustomer As System.Windows.Forms.Button
    Friend WithEvents BtnProductOrder As System.Windows.Forms.Button
    Friend WithEvents BtnSale As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnPayAble As System.Windows.Forms.Button
    Friend WithEvents BtnComProfile As System.Windows.Forms.Button

End Class
