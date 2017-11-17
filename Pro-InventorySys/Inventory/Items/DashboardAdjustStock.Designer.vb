<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardAdjustStock
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
        Dim StoreTransaction_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardAdjustStock))
        Dim AdjustList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolProduct = New System.Windows.Forms.ToolStrip
        Me.BtnAdjustment = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefreshProduct = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage2 = New Janus.Windows.UI.Tab.UITabPage
        Me.StoreTransaction = New Janus.Windows.GridEX.GridEX
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.AdjustList = New Janus.Windows.GridEX.GridEX
        Me.BtnPrintPreview = New System.Windows.Forms.Button
        Me.CboProduct = New System.Windows.Forms.ComboBox
        Me.ChProduct = New System.Windows.Forms.CheckBox
        Me.BtnFind = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ToolProduct.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage2.SuspendLayout()
        CType(Me.StoreTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPage1.SuspendLayout()
        CType(Me.AdjustList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolProduct
        '
        Me.ToolProduct.ImageScalingSize = New System.Drawing.Size(26, 26)
        Me.ToolProduct.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAdjustment, Me.ToolStripSeparator6, Me.BtnRefreshProduct})
        Me.ToolProduct.Location = New System.Drawing.Point(0, 0)
        Me.ToolProduct.Name = "ToolProduct"
        Me.ToolProduct.Size = New System.Drawing.Size(734, 48)
        Me.ToolProduct.TabIndex = 3
        Me.ToolProduct.Text = "ToolStrip1"
        '
        'BtnAdjustment
        '
        Me.BtnAdjustment.ForeColor = System.Drawing.Color.Blue
        Me.BtnAdjustment.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources._1407932551_Tag
        Me.BtnAdjustment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAdjustment.Name = "BtnAdjustment"
        Me.BtnAdjustment.Size = New System.Drawing.Size(132, 45)
        Me.BtnAdjustment.Text = "New Stock Adjustment"
        Me.BtnAdjustment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 48)
        '
        'BtnRefreshProduct
        '
        Me.BtnRefreshProduct.ForeColor = System.Drawing.Color.Blue
        Me.BtnRefreshProduct.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.refresh
        Me.BtnRefreshProduct.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefreshProduct.Name = "BtnRefreshProduct"
        Me.BtnRefreshProduct.Size = New System.Drawing.Size(95, 45)
        Me.BtnRefreshProduct.Text = "Refresh Product"
        Me.BtnRefreshProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.UiTab1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolProduct)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnPrintPreview)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CboProduct)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChProduct)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnFind)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(974, 540)
        Me.SplitContainer1.SplitterDistance = 734
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 4
        '
        'UiTab1
        '
        Me.UiTab1.BackColor = System.Drawing.SystemColors.Control
        Me.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiTab1.ForeColor = System.Drawing.Color.Red
        Me.UiTab1.Location = New System.Drawing.Point(0, 48)
        Me.UiTab1.Margin = New System.Windows.Forms.Padding(2)
        Me.UiTab1.MultiLine = True
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom
        Me.UiTab1.Size = New System.Drawing.Size(734, 492)
        Me.UiTab1.TabIndex = 1
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage2, Me.UiTabPage1})
        Me.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'UiTabPage2
        '
        Me.UiTabPage2.Controls.Add(Me.StoreTransaction)
        Me.UiTabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiTabPage2.Location = New System.Drawing.Point(1, 25)
        Me.UiTabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.UiTabPage2.Name = "UiTabPage2"
        Me.UiTabPage2.PanelFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.UiTabPage2.Size = New System.Drawing.Size(732, 466)
        Me.UiTabPage2.TabStop = True
        Me.UiTabPage2.Text = "Product Transaction"
        '
        'StoreTransaction
        '
        Me.StoreTransaction.BackColor = System.Drawing.SystemColors.Control
        StoreTransaction_DesignTimeLayout.LayoutString = resources.GetString("StoreTransaction_DesignTimeLayout.LayoutString")
        Me.StoreTransaction.DesignTimeLayout = StoreTransaction_DesignTimeLayout
        Me.StoreTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StoreTransaction.GroupByBoxVisible = False
        Me.StoreTransaction.HeaderFormatStyle.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StoreTransaction.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.StoreTransaction.Location = New System.Drawing.Point(0, 0)
        Me.StoreTransaction.Margin = New System.Windows.Forms.Padding(2)
        Me.StoreTransaction.Name = "StoreTransaction"
        Me.StoreTransaction.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.StoreTransaction.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.StoreTransaction.RecordNavigator = True
        Me.StoreTransaction.Size = New System.Drawing.Size(732, 466)
        Me.StoreTransaction.TabIndex = 1
        Me.StoreTransaction.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.AdjustList)
        Me.UiTabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 25)
        Me.UiTabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(732, 466)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Stock Adjustment"
        '
        'AdjustList
        '
        AdjustList_DesignTimeLayout.LayoutString = resources.GetString("AdjustList_DesignTimeLayout.LayoutString")
        Me.AdjustList.DesignTimeLayout = AdjustList_DesignTimeLayout
        Me.AdjustList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdjustList.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.AdjustList.GroupByBoxVisible = False
        Me.AdjustList.HeaderFormatStyle.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdjustList.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.AdjustList.Location = New System.Drawing.Point(0, 0)
        Me.AdjustList.Margin = New System.Windows.Forms.Padding(2)
        Me.AdjustList.Name = "AdjustList"
        Me.AdjustList.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.AdjustList.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AdjustList.RecordNavigator = True
        Me.AdjustList.Size = New System.Drawing.Size(732, 466)
        Me.AdjustList.TabIndex = 0
        Me.AdjustList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrintPreview.ForeColor = System.Drawing.Color.Blue
        Me.BtnPrintPreview.Location = New System.Drawing.Point(129, 183)
        Me.BtnPrintPreview.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(92, 33)
        Me.BtnPrintPreview.TabIndex = 6
        Me.BtnPrintPreview.Text = "Print Preview"
        Me.BtnPrintPreview.UseVisualStyleBackColor = True
        '
        'CboProduct
        '
        Me.CboProduct.Enabled = False
        Me.CboProduct.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboProduct.FormattingEnabled = True
        Me.CboProduct.Location = New System.Drawing.Point(10, 149)
        Me.CboProduct.Margin = New System.Windows.Forms.Padding(2)
        Me.CboProduct.Name = "CboProduct"
        Me.CboProduct.Size = New System.Drawing.Size(212, 30)
        Me.CboProduct.TabIndex = 5
        '
        'ChProduct
        '
        Me.ChProduct.AutoSize = True
        Me.ChProduct.Location = New System.Drawing.Point(10, 124)
        Me.ChProduct.Margin = New System.Windows.Forms.Padding(2)
        Me.ChProduct.Name = "ChProduct"
        Me.ChProduct.Size = New System.Drawing.Size(96, 17)
        Me.ChProduct.TabIndex = 4
        Me.ChProduct.Text = "Select Product"
        Me.ChProduct.UseVisualStyleBackColor = True
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFind.ForeColor = System.Drawing.Color.Blue
        Me.BtnFind.Location = New System.Drawing.Point(10, 183)
        Me.BtnFind.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(92, 33)
        Me.BtnFind.TabIndex = 3
        Me.BtnFind.Text = "Find"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTo)
        Me.GroupBox1.Controls.Add(Me.DateFrom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(215, 102)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaction and Adjustment"
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd-MM-yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(68, 65)
        Me.DateTo.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(144, 26)
        Me.DateTo.TabIndex = 3
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd-MM-yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(68, 28)
        Me.DateFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(144, 26)
        Me.DateFrom.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date To:"
        '
        'DashboardAdjustStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "DashboardAdjustStock"
        Me.Size = New System.Drawing.Size(974, 540)
        Me.ToolProduct.ResumeLayout(False)
        Me.ToolProduct.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage2.ResumeLayout(False)
        CType(Me.StoreTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPage1.ResumeLayout(False)
        CType(Me.AdjustList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolProduct As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnAdjustment As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefreshProduct As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents AdjustList As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents ChProduct As System.Windows.Forms.CheckBox
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents CboProduct As System.Windows.Forms.ComboBox
    Friend WithEvents StoreTransaction As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button

End Class
