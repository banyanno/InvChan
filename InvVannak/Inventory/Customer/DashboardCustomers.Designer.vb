<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardCustomers
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
        Dim CustomerList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardCustomers))
        Me.ToolCostomers = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.CustomerList = New Janus.Windows.GridEX.GridEX
        Me.ToolCostomers.SuspendLayout()
        CType(Me.CustomerList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolCostomers
        '
        Me.ToolCostomers.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolCostomers.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolCostomers.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolCostomers.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton3, Me.ToolStripSeparator2, Me.ToolStripButton2, Me.ToolStripSeparator3, Me.ToolStripButton4, Me.ToolStripSeparator4, Me.ToolStripButton5, Me.ToolStripSeparator5})
        Me.ToolCostomers.Location = New System.Drawing.Point(0, 0)
        Me.ToolCostomers.Name = "ToolCostomers"
        Me.ToolCostomers.Size = New System.Drawing.Size(854, 54)
        Me.ToolCostomers.TabIndex = 0
        Me.ToolCostomers.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton1.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.Users_icon
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(62, 51)
        Me.ToolStripButton1.Text = "អតិថិជនថ្មី"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 54)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton3.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.edit_find_replace
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(86, 51)
        Me.ToolStripButton3.Text = "កែប្រែ អតិថិជន"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 54)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton2.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.Search1
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(94, 51)
        Me.ToolStripButton2.Text = "ស្វែងរក អតិថិជន"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.ToolStripButton4.Size = New System.Drawing.Size(78, 51)
        Me.ToolStripButton4.Text = "លប់ អតិថិជន"
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
        'CustomerList
        '
        Me.CustomerList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.CustomerList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CustomerList.BlendColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        CustomerList_DesignTimeLayout.LayoutString = resources.GetString("CustomerList_DesignTimeLayout.LayoutString")
        Me.CustomerList.DesignTimeLayout = CustomerList_DesignTimeLayout
        Me.CustomerList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomerList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.CustomerList.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.CustomerList.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.CustomerList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerList.GroupByBoxVisible = False
        Me.CustomerList.HeaderFormatStyle.FontSize = 10.0!
        Me.CustomerList.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.CustomerList.Location = New System.Drawing.Point(0, 54)
        Me.CustomerList.Name = "CustomerList"
        Me.CustomerList.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.CustomerList.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CustomerList.RecordNavigator = True
        Me.CustomerList.Size = New System.Drawing.Size(854, 443)
        Me.CustomerList.TabIndex = 1
        Me.CustomerList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'DashboardCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CustomerList)
        Me.Controls.Add(Me.ToolCostomers)
        Me.Name = "DashboardCustomers"
        Me.Size = New System.Drawing.Size(854, 497)
        Me.ToolCostomers.ResumeLayout(False)
        Me.ToolCostomers.PerformLayout()
        CType(Me.CustomerList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolCostomers As System.Windows.Forms.ToolStrip
    Friend WithEvents CustomerList As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator

End Class
