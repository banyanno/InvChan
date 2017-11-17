<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewProduct))
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.UiTab2 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage2 = New Janus.Windows.UI.Tab.UITabPage
        Me.BtnNewCategory = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnSubUnit = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.BtnMainUnit = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtSRatioQty = New System.Windows.Forms.TextBox
        Me.txtMRatioQty = New System.Windows.Forms.TextBox
        Me.CboMUnit = New System.Windows.Forms.ComboBox
        Me.CboSUnit = New System.Windows.Forms.ComboBox
        Me.CboCategory = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.UiTabPage4 = New Janus.Windows.UI.Tab.UITabPage
        Me.Label4 = New System.Windows.Forms.Label
        Me.ProdImg = New System.Windows.Forms.PictureBox
        Me.TxtBarcode = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtItemName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblStatus = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.ErrorUpdate = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.LblMeasur2 = New System.Windows.Forms.Label
        Me.LblMeasur1 = New System.Windows.Forms.Label
        Me.txtMBalance = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSBalance = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UiTab2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab2.SuspendLayout()
        Me.UiTabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.UiTabPage4.SuspendLayout()
        CType(Me.ProdImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'UiTab1
        '
        Me.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab1.Location = New System.Drawing.Point(0, 0)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom
        Me.UiTab1.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UiTab1.Size = New System.Drawing.Size(517, 451)
        Me.UiTab1.TabIndex = 1
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1})
        Me.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.GroupBox1)
        Me.UiTabPage1.Controls.Add(Me.BtnCancel)
        Me.UiTabPage1.Controls.Add(Me.BtnSave)
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(515, 429)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Product Information"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.UiTab2)
        Me.GroupBox1.Controls.Add(Me.TxtBarcode)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtItemName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(502, 379)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'UiTab2
        '
        Me.UiTab2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UiTab2.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiTab2.Location = New System.Drawing.Point(11, 124)
        Me.UiTab2.Name = "UiTab2"
        Me.UiTab2.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom
        Me.UiTab2.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UiTab2.Size = New System.Drawing.Size(477, 249)
        Me.UiTab2.TabIndex = 2
        Me.UiTab2.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage2, Me.UiTabPage4})
        Me.UiTab2.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'UiTabPage2
        '
        Me.UiTabPage2.Controls.Add(Me.BtnNewCategory)
        Me.UiTabPage2.Controls.Add(Me.GroupBox5)
        Me.UiTabPage2.Controls.Add(Me.CboCategory)
        Me.UiTabPage2.Controls.Add(Me.Label1)
        Me.UiTabPage2.Location = New System.Drawing.Point(1, 32)
        Me.UiTabPage2.Name = "UiTabPage2"
        Me.UiTabPage2.Size = New System.Drawing.Size(475, 216)
        Me.UiTabPage2.TabStop = True
        Me.UiTabPage2.Text = "ប្រភេទ / ចំនុះ"
        '
        'BtnNewCategory
        '
        Me.BtnNewCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewCategory.Location = New System.Drawing.Point(403, 21)
        Me.BtnNewCategory.Name = "BtnNewCategory"
        Me.BtnNewCategory.Size = New System.Drawing.Size(30, 31)
        Me.BtnNewCategory.TabIndex = 11
        Me.BtnNewCategory.Text = "..."
        Me.BtnNewCategory.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.BtnSubUnit)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.BtnMainUnit)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.txtSRatioQty)
        Me.GroupBox5.Controls.Add(Me.txtMRatioQty)
        Me.GroupBox5.Controls.Add(Me.CboMUnit)
        Me.GroupBox5.Controls.Add(Me.CboSUnit)
        Me.GroupBox5.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(6, 59)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(475, 94)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "ចំនុះ"
        '
        'BtnSubUnit
        '
        Me.BtnSubUnit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSubUnit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSubUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubUnit.Location = New System.Drawing.Point(431, 33)
        Me.BtnSubUnit.Name = "BtnSubUnit"
        Me.BtnSubUnit.Size = New System.Drawing.Size(30, 29)
        Me.BtnSubUnit.TabIndex = 13
        Me.BtnSubUnit.Text = "..."
        Me.BtnSubUnit.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(224, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 22)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "មាន"
        '
        'BtnMainUnit
        '
        Me.BtnMainUnit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnMainUnit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMainUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMainUnit.Location = New System.Drawing.Point(174, 35)
        Me.BtnMainUnit.Name = "BtnMainUnit"
        Me.BtnMainUnit.Size = New System.Drawing.Size(30, 27)
        Me.BtnMainUnit.TabIndex = 12
        Me.BtnMainUnit.Text = "..."
        Me.BtnMainUnit.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(206, 41)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(21, 22)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "->"
        '
        'txtSRatioQty
        '
        Me.txtSRatioQty.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!)
        Me.txtSRatioQty.Location = New System.Drawing.Point(254, 33)
        Me.txtSRatioQty.Name = "txtSRatioQty"
        Me.txtSRatioQty.Size = New System.Drawing.Size(75, 30)
        Me.txtSRatioQty.TabIndex = 1
        Me.txtSRatioQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMRatioQty
        '
        Me.txtMRatioQty.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMRatioQty.Location = New System.Drawing.Point(8, 33)
        Me.txtMRatioQty.Name = "txtMRatioQty"
        Me.txtMRatioQty.ReadOnly = True
        Me.txtMRatioQty.Size = New System.Drawing.Size(64, 30)
        Me.txtMRatioQty.TabIndex = 0
        Me.txtMRatioQty.Text = "1"
        Me.txtMRatioQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CboMUnit
        '
        Me.CboMUnit.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!)
        Me.CboMUnit.FormattingEnabled = True
        Me.CboMUnit.Location = New System.Drawing.Point(78, 33)
        Me.CboMUnit.Name = "CboMUnit"
        Me.CboMUnit.Size = New System.Drawing.Size(92, 30)
        Me.CboMUnit.TabIndex = 0
        '
        'CboSUnit
        '
        Me.CboSUnit.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!)
        Me.CboSUnit.FormattingEnabled = True
        Me.CboSUnit.Location = New System.Drawing.Point(335, 33)
        Me.CboSUnit.Name = "CboSUnit"
        Me.CboSUnit.Size = New System.Drawing.Size(92, 30)
        Me.CboSUnit.TabIndex = 2
        '
        'CboCategory
        '
        Me.CboCategory.Font = New System.Drawing.Font("Kh Battambang", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCategory.FormattingEnabled = True
        Me.CboCategory.Location = New System.Drawing.Point(118, 20)
        Me.CboCategory.Name = "CboCategory"
        Me.CboCategory.Size = New System.Drawing.Size(279, 33)
        Me.CboCategory.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(11, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ប្រភេទ​ទំនិញ *:"
        '
        'UiTabPage4
        '
        Me.UiTabPage4.Controls.Add(Me.Label4)
        Me.UiTabPage4.Controls.Add(Me.ProdImg)
        Me.UiTabPage4.Location = New System.Drawing.Point(1, 32)
        Me.UiTabPage4.Name = "UiTabPage4"
        Me.UiTabPage4.Size = New System.Drawing.Size(475, 216)
        Me.UiTabPage4.TabStop = True
        Me.UiTabPage4.Text = "រូបភាព"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(245, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Double click to find image."
        '
        'ProdImg
        '
        Me.ProdImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProdImg.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.shoping_cart
        Me.ProdImg.Location = New System.Drawing.Point(7, 15)
        Me.ProdImg.Name = "ProdImg"
        Me.ProdImg.Size = New System.Drawing.Size(203, 183)
        Me.ProdImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProdImg.TabIndex = 2
        Me.ProdImg.TabStop = False
        '
        'TxtBarcode
        '
        Me.TxtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBarcode.Font = New System.Drawing.Font("Khmer OS Battambang", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBarcode.Location = New System.Drawing.Point(136, 20)
        Me.TxtBarcode.Name = "TxtBarcode"
        Me.TxtBarcode.Size = New System.Drawing.Size(335, 40)
        Me.TxtBarcode.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 29)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "លេខ Barcode*:"
        '
        'txtItemName
        '
        Me.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemName.Font = New System.Drawing.Font("Khmer OS Battambang", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.Location = New System.Drawing.Point(136, 69)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(335, 47)
        Me.txtItemName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 29)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "ឈ.ផលិតផល*:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(477, 40)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(13, 13)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "0"
        Me.lblStatus.Visible = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Location = New System.Drawing.Point(417, 391)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(80, 32)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Location = New System.Drawing.Point(327, 391)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(85, 32)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'ErrorUpdate
        '
        Me.ErrorUpdate.ContainerControl = Me
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.LblMeasur2)
        Me.GroupBox6.Controls.Add(Me.LblMeasur1)
        Me.GroupBox6.Controls.Add(Me.txtMBalance)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.txtSBalance)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(36, 15)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Size = New System.Drawing.Size(303, 96)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "ចំនួនចាប់ផ្តើ Stock"
        '
        'LblMeasur2
        '
        Me.LblMeasur2.AutoSize = True
        Me.LblMeasur2.Location = New System.Drawing.Point(206, 62)
        Me.LblMeasur2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblMeasur2.Name = "LblMeasur2"
        Me.LblMeasur2.Size = New System.Drawing.Size(0, 22)
        Me.LblMeasur2.TabIndex = 7
        '
        'LblMeasur1
        '
        Me.LblMeasur1.AutoSize = True
        Me.LblMeasur1.Location = New System.Drawing.Point(206, 30)
        Me.LblMeasur1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblMeasur1.Name = "LblMeasur1"
        Me.LblMeasur1.Size = New System.Drawing.Size(0, 22)
        Me.LblMeasur1.TabIndex = 6
        '
        'txtMBalance
        '
        Me.txtMBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMBalance.Location = New System.Drawing.Point(91, 28)
        Me.txtMBalance.Name = "txtMBalance"
        Me.txtMBalance.Size = New System.Drawing.Size(111, 26)
        Me.txtMBalance.TabIndex = 0
        Me.txtMBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Main Stock:"
        '
        'txtSBalance
        '
        Me.txtSBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSBalance.Location = New System.Drawing.Point(91, 59)
        Me.txtSBalance.Name = "txtSBalance"
        Me.txtSBalance.Size = New System.Drawing.Size(111, 26)
        Me.txtSBalance.TabIndex = 1
        Me.txtSBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 22)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Sub Stock:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'NewProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(517, 451)
        Me.Controls.Add(Me.UiTab1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewProduct"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Product"
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UiTab2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab2.ResumeLayout(False)
        Me.UiTabPage2.ResumeLayout(False)
        Me.UiTabPage2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.UiTabPage4.ResumeLayout(False)
        Me.UiTabPage4.PerformLayout()
        CType(Me.ProdImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents ErrorUpdate As System.Windows.Forms.ErrorProvider
    Friend WithEvents TxtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UiTab2 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents BtnNewCategory As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSubUnit As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnMainUnit As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtSRatioQty As System.Windows.Forms.TextBox
    Friend WithEvents txtMRatioQty As System.Windows.Forms.TextBox
    Friend WithEvents CboMUnit As System.Windows.Forms.ComboBox
    Friend WithEvents CboSUnit As System.Windows.Forms.ComboBox
    Friend WithEvents CboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UiTabPage4 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents LblMeasur2 As System.Windows.Forms.Label
    Friend WithEvents LblMeasur1 As System.Windows.Forms.Label
    Friend WithEvents txtMBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProdImg As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
