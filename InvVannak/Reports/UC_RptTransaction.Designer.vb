<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_RptTransaction
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
        Dim TransactionList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_RptTransaction))
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.TransactionList = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.BtnSearch = New System.Windows.Forms.ToolStripButton
        CType(Me.TransactionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'TransactionList
        '
        Me.TransactionList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        TransactionList_DesignTimeLayout.LayoutString = resources.GetString("TransactionList_DesignTimeLayout.LayoutString")
        Me.TransactionList.DesignTimeLayout = TransactionList_DesignTimeLayout
        Me.TransactionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransactionList.GroupByBoxVisible = False
        Me.TransactionList.Location = New System.Drawing.Point(0, 32)
        Me.TransactionList.Name = "TransactionList"
        Me.TransactionList.Size = New System.Drawing.Size(729, 354)
        Me.TransactionList.TabIndex = 40
        Me.TransactionList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.AliceBlue
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.BtnSearch})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip2.Size = New System.Drawing.Size(729, 32)
        Me.ToolStrip2.TabIndex = 39
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStripButton1.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.refresh
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(86, 29)
        Me.ToolStripButton1.Text = "Refresh"
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
        'UC_RptTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TransactionList)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "UC_RptTransaction"
        Me.Size = New System.Drawing.Size(729, 386)
        CType(Me.TransactionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TransactionList As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip

End Class
