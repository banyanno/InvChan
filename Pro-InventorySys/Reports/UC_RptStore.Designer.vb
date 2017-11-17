<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_RptStore
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
        Dim StoreList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_RptStore))
        Me.StoreList = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnSearch = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        CType(Me.StoreList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StoreList
        '
        Me.StoreList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        StoreList_DesignTimeLayout.LayoutString = resources.GetString("StoreList_DesignTimeLayout.LayoutString")
        Me.StoreList.DesignTimeLayout = StoreList_DesignTimeLayout
        Me.StoreList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StoreList.GroupByBoxVisible = False
        Me.StoreList.Location = New System.Drawing.Point(0, 32)
        Me.StoreList.Name = "StoreList"
        Me.StoreList.Size = New System.Drawing.Size(654, 319)
        Me.StoreList.TabIndex = 40
        Me.StoreList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.AliceBlue
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRefresh, Me.ToolStripSeparator1, Me.BtnSearch, Me.ToolStripSeparator2})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip2.Size = New System.Drawing.Size(654, 32)
        Me.ToolStrip2.TabIndex = 39
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRefresh.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.refresh
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(88, 29)
        Me.btnRefresh.Text = "View All"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'BtnSearch
        '
        Me.BtnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSearch.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.Preview
        Me.BtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(168, 29)
        Me.BtnSearch.Text = "Search and Preview"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 32)
        '
        'UC_RptStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.StoreList)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "UC_RptStore"
        Me.Size = New System.Drawing.Size(654, 351)
        CType(Me.StoreList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StoreList As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator

End Class
