<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardSupplier
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
        Dim SupplierList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardSupplier))
        Me.ToolSupplier = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton
        Me.SupplierList = New Janus.Windows.GridEX.GridEX
        Me.ToolSupplier.SuspendLayout()
        CType(Me.SupplierList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolSupplier
        '
        Me.ToolSupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolSupplier.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolSupplier.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolSupplier.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripSeparator3, Me.ToolStripButton4, Me.ToolStripSeparator4, Me.ToolStripButton5, Me.ToolStripSeparator5, Me.ToolStripButton6})
        Me.ToolSupplier.Location = New System.Drawing.Point(0, 0)
        Me.ToolSupplier.Name = "ToolSupplier"
        Me.ToolSupplier.Size = New System.Drawing.Size(740, 54)
        Me.ToolSupplier.TabIndex = 1
        Me.ToolSupplier.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton1.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.Supplier_Icon_Transparent_120_x_120
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(74, 51)
        Me.ToolStripButton1.Text = "អ្នកផ្គត់ផ្គង់ ថ្មី"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 54)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton2.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.Search1
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(102, 51)
        Me.ToolStripButton2.Text = "ស្វែងរក អ្នកផ្គត់ផ្គង់"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 54)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton3.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.edit_find_replace
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(94, 51)
        Me.ToolStripButton3.Text = "កែប្រែ អ្នកផ្គត់ផ្គង់"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 54)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton4.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.delete_appointment
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(86, 51)
        Me.ToolStripButton4.Text = "លប់ អ្នកផ្គត់ផ្គង់"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 54)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton5.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.refresh
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(87, 51)
        Me.ToolStripButton5.Text = "Refresh Data"
        Me.ToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 54)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton6.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.History_Icons_1106084718
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(130, 51)
        Me.ToolStripButton6.Text = "History Product Order"
        Me.ToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SupplierList
        '
        Me.SupplierList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.SupplierList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        SupplierList_DesignTimeLayout.LayoutString = resources.GetString("SupplierList_DesignTimeLayout.LayoutString")
        Me.SupplierList.DesignTimeLayout = SupplierList_DesignTimeLayout
        Me.SupplierList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SupplierList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.SupplierList.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.SupplierList.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.SupplierList.GroupByBoxVisible = False
        Me.SupplierList.HeaderFormatStyle.FontSize = 10.0!
        Me.SupplierList.Location = New System.Drawing.Point(0, 54)
        Me.SupplierList.Name = "SupplierList"
        Me.SupplierList.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.SupplierList.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SupplierList.RecordNavigator = True
        Me.SupplierList.Size = New System.Drawing.Size(740, 416)
        Me.SupplierList.TabIndex = 2
        Me.SupplierList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'DashboardSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Controls.Add(Me.SupplierList)
        Me.Controls.Add(Me.ToolSupplier)
        Me.Name = "DashboardSupplier"
        Me.Size = New System.Drawing.Size(740, 470)
        Me.ToolSupplier.ResumeLayout(False)
        Me.ToolSupplier.PerformLayout()
        CType(Me.SupplierList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolSupplier As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SupplierList As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton

End Class
