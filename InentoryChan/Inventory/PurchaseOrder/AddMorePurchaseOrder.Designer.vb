<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMorePurchaseOrder
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
        Dim GridProductList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddMorePurchaseOrder))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GridProductList = New Janus.Windows.GridEX.GridEX
        Me.txtSearchProduct = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LblTHBTotal = New System.Windows.Forms.Label
        Me.LblUSDTotal = New System.Windows.Forms.Label
        Me.LblKHRTotal = New System.Windows.Forms.Label
        Me.TxtProductName = New System.Windows.Forms.TextBox
        Me.ChQTYFree = New System.Windows.Forms.CheckBox
        Me.GroupQTYFree = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtQTYFree = New System.Windows.Forms.TextBox
        Me.cboUnitFree = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cboUnit = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtTotalCost = New System.Windows.Forms.TextBox
        Me.LblTotalCost = New System.Windows.Forms.Label
        Me.txtQTY = New System.Windows.Forms.TextBox
        Me.txtCost = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CboCurrency = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ErrProduct = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.lblOrderNo = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridProductList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupQTYFree.SuspendLayout()
        CType(Me.ErrProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.GridProductList)
        Me.GroupBox3.Controls.Add(Me.txtSearchProduct)
        Me.GroupBox3.Location = New System.Drawing.Point(2, 3)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(340, 432)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Product Name:"
        '
        'GridProductList
        '
        Me.GridProductList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridProductList_DesignTimeLayout.LayoutString = resources.GetString("GridProductList_DesignTimeLayout.LayoutString")
        Me.GridProductList.DesignTimeLayout = GridProductList_DesignTimeLayout
        Me.GridProductList.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.GridProductList.GroupByBoxVisible = False
        Me.GridProductList.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridProductList.Location = New System.Drawing.Point(2, 52)
        Me.GridProductList.Margin = New System.Windows.Forms.Padding(2)
        Me.GridProductList.Name = "GridProductList"
        Me.GridProductList.RecordNavigator = True
        Me.GridProductList.Size = New System.Drawing.Size(336, 378)
        Me.GridProductList.TabIndex = 3
        '
        'txtSearchProduct
        '
        Me.txtSearchProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSearchProduct.Font = New System.Drawing.Font("Kh Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchProduct.Location = New System.Drawing.Point(2, 15)
        Me.txtSearchProduct.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearchProduct.Name = "txtSearchProduct"
        Me.txtSearchProduct.Size = New System.Drawing.Size(274, 37)
        Me.txtSearchProduct.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblTHBTotal)
        Me.GroupBox1.Controls.Add(Me.LblUSDTotal)
        Me.GroupBox1.Controls.Add(Me.LblKHRTotal)
        Me.GroupBox1.Controls.Add(Me.TxtProductName)
        Me.GroupBox1.Controls.Add(Me.ChQTYFree)
        Me.GroupBox1.Controls.Add(Me.GroupQTYFree)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cboUnit)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtTotalCost)
        Me.GroupBox1.Controls.Add(Me.LblTotalCost)
        Me.GroupBox1.Controls.Add(Me.txtQTY)
        Me.GroupBox1.Controls.Add(Me.txtCost)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CboCurrency)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(347, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 431)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Info"
        '
        'LblTHBTotal
        '
        Me.LblTHBTotal.AutoSize = True
        Me.LblTHBTotal.Location = New System.Drawing.Point(106, 364)
        Me.LblTHBTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTHBTotal.Name = "LblTHBTotal"
        Me.LblTHBTotal.Size = New System.Drawing.Size(13, 13)
        Me.LblTHBTotal.TabIndex = 33
        Me.LblTHBTotal.Text = "0"
        Me.LblTHBTotal.Visible = False
        '
        'LblUSDTotal
        '
        Me.LblUSDTotal.AutoSize = True
        Me.LblUSDTotal.Location = New System.Drawing.Point(38, 381)
        Me.LblUSDTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblUSDTotal.Name = "LblUSDTotal"
        Me.LblUSDTotal.Size = New System.Drawing.Size(13, 13)
        Me.LblUSDTotal.TabIndex = 32
        Me.LblUSDTotal.Text = "0"
        Me.LblUSDTotal.Visible = False
        '
        'LblKHRTotal
        '
        Me.LblKHRTotal.AutoSize = True
        Me.LblKHRTotal.Location = New System.Drawing.Point(32, 353)
        Me.LblKHRTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblKHRTotal.Name = "LblKHRTotal"
        Me.LblKHRTotal.Size = New System.Drawing.Size(13, 13)
        Me.LblKHRTotal.TabIndex = 31
        Me.LblKHRTotal.Text = "0"
        Me.LblKHRTotal.Visible = False
        '
        'TxtProductName
        '
        Me.TxtProductName.Font = New System.Drawing.Font("Kh Battambang", 10.2!)
        Me.TxtProductName.Location = New System.Drawing.Point(101, 85)
        Me.TxtProductName.Name = "TxtProductName"
        Me.TxtProductName.Size = New System.Drawing.Size(278, 33)
        Me.TxtProductName.TabIndex = 27
        '
        'ChQTYFree
        '
        Me.ChQTYFree.AutoSize = True
        Me.ChQTYFree.ForeColor = System.Drawing.Color.Red
        Me.ChQTYFree.Location = New System.Drawing.Point(249, 224)
        Me.ChQTYFree.Margin = New System.Windows.Forms.Padding(2)
        Me.ChQTYFree.Name = "ChQTYFree"
        Me.ChQTYFree.Size = New System.Drawing.Size(66, 17)
        Me.ChQTYFree.TabIndex = 26
        Me.ChQTYFree.Text = "Qty Free"
        Me.ChQTYFree.UseVisualStyleBackColor = True
        '
        'GroupQTYFree
        '
        Me.GroupQTYFree.Controls.Add(Me.Label16)
        Me.GroupQTYFree.Controls.Add(Me.TxtQTYFree)
        Me.GroupQTYFree.Controls.Add(Me.cboUnitFree)
        Me.GroupQTYFree.Controls.Add(Me.Label15)
        Me.GroupQTYFree.Enabled = False
        Me.GroupQTYFree.Location = New System.Drawing.Point(244, 224)
        Me.GroupQTYFree.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupQTYFree.Name = "GroupQTYFree"
        Me.GroupQTYFree.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupQTYFree.Size = New System.Drawing.Size(167, 92)
        Me.GroupQTYFree.TabIndex = 25
        Me.GroupQTYFree.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Kh Battambang", 7.8!)
        Me.Label16.Location = New System.Drawing.Point(13, 60)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 19)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "ឯក្តា"
        '
        'TxtQTYFree
        '
        Me.TxtQTYFree.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtQTYFree.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQTYFree.Location = New System.Drawing.Point(46, 23)
        Me.TxtQTYFree.Name = "TxtQTYFree"
        Me.TxtQTYFree.Size = New System.Drawing.Size(99, 26)
        Me.TxtQTYFree.TabIndex = 22
        Me.TxtQTYFree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboUnitFree
        '
        Me.cboUnitFree.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnitFree.Location = New System.Drawing.Point(46, 54)
        Me.cboUnitFree.Name = "cboUnitFree"
        Me.cboUnitFree.Size = New System.Drawing.Size(99, 30)
        Me.cboUnitFree.TabIndex = 24
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(13, 33)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Qty:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(226, 270)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Kh Battambang", 7.8!)
        Me.Label14.Location = New System.Drawing.Point(56, 152)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 19)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "ឯកក្តា"
        '
        'cboUnit
        '
        Me.cboUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboUnit.Enabled = False
        Me.cboUnit.Font = New System.Drawing.Font("Kh Battambang", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnit.FormattingEnabled = True
        Me.cboUnit.Items.AddRange(New Object() {"KHR", "USD", "THB"})
        Me.cboUnit.Location = New System.Drawing.Point(101, 139)
        Me.cboUnit.Name = "cboUnit"
        Me.cboUnit.Size = New System.Drawing.Size(119, 33)
        Me.cboUnit.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(226, 309)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(226, 159)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(226, 237)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(226, 198)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(384, 99)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "*"
        '
        'TxtTotalCost
        '
        Me.TxtTotalCost.BackColor = System.Drawing.Color.White
        Me.TxtTotalCost.Enabled = False
        Me.TxtTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalCost.Location = New System.Drawing.Point(101, 297)
        Me.TxtTotalCost.Name = "TxtTotalCost"
        Me.TxtTotalCost.Size = New System.Drawing.Size(119, 26)
        Me.TxtTotalCost.TabIndex = 5
        Me.TxtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblTotalCost
        '
        Me.LblTotalCost.AutoSize = True
        Me.LblTotalCost.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.LblTotalCost.Location = New System.Drawing.Point(27, 301)
        Me.LblTotalCost.Name = "LblTotalCost"
        Me.LblTotalCost.Size = New System.Drawing.Size(65, 22)
        Me.LblTotalCost.TabIndex = 8
        Me.LblTotalCost.Text = "តំលៃសរុប៖"
        '
        'txtQTY
        '
        Me.txtQTY.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQTY.Location = New System.Drawing.Point(101, 263)
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(118, 26)
        Me.txtQTY.TabIndex = 3
        Me.txtQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCost
        '
        Me.txtCost.BackColor = System.Drawing.Color.White
        Me.txtCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(101, 225)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(119, 26)
        Me.txtCost.TabIndex = 2
        Me.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "តំលៃដើម​៖"
        '
        'CboCurrency
        '
        Me.CboCurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboCurrency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboCurrency.Font = New System.Drawing.Font("Kh Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCurrency.Items.AddRange(New Object() {"$", "៛", "B"})
        Me.CboCurrency.Location = New System.Drawing.Point(101, 183)
        Me.CboCurrency.Name = "CboCurrency"
        Me.CboCurrency.Size = New System.Drawing.Size(118, 32)
        Me.CboCurrency.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(19, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ប្រភេទប្រាក់៖"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(26, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "QTY Order:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kh Battambang", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(16, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ឈ្មោះទំនិញ៖"
        '
        'ErrProduct
        '
        Me.ErrProduct.ContainerControl = Me
        '
        'BtnAdd
        '
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.Location = New System.Drawing.Point(596, 444)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(79, 32)
        Me.BtnAdd.TabIndex = 7
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(681, 444)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(84, 32)
        Me.BtnCancel.TabIndex = 8
        Me.BtnCancel.Text = "Close"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'lblOrderNo
        '
        Me.lblOrderNo.AutoSize = True
        Me.lblOrderNo.Location = New System.Drawing.Point(23, 454)
        Me.lblOrderNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOrderNo.Name = "lblOrderNo"
        Me.lblOrderNo.Size = New System.Drawing.Size(13, 13)
        Me.lblOrderNo.TabIndex = 9
        Me.lblOrderNo.Text = "0"
        Me.lblOrderNo.Visible = False
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(279, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 34)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AddMorePurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 482)
        Me.Controls.Add(Me.lblOrderNo)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddMorePurchaseOrder"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Product"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.GridProductList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupQTYFree.ResumeLayout(False)
        Me.GroupQTYFree.PerformLayout()
        CType(Me.ErrProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GridProductList As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtSearchProduct As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtProductName As System.Windows.Forms.TextBox
    Friend WithEvents ChQTYFree As System.Windows.Forms.CheckBox
    Friend WithEvents GroupQTYFree As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtQTYFree As System.Windows.Forms.TextBox
    Friend WithEvents cboUnitFree As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents LblTotalCost As System.Windows.Forms.Label
    Friend WithEvents txtQTY As System.Windows.Forms.TextBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboCurrency As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrProduct As System.Windows.Forms.ErrorProvider
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents lblOrderNo As System.Windows.Forms.Label
    Friend WithEvents LblTHBTotal As System.Windows.Forms.Label
    Friend WithEvents LblUSDTotal As System.Windows.Forms.Label
    Friend WithEvents LblKHRTotal As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
