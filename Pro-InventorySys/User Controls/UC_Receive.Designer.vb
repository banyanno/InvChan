<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Receive
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ReceiveList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_Receive))
        Me.ReceiveList = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.BtnAdd = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton
        CType(Me.ReceiveList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReceiveList
        '
        Me.ReceiveList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        ReceiveList_DesignTimeLayout.LayoutString = resources.GetString("ReceiveList_DesignTimeLayout.LayoutString")
        Me.ReceiveList.DesignTimeLayout = ReceiveList_DesignTimeLayout
        Me.ReceiveList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReceiveList.GroupByBoxVisible = False
        Me.ReceiveList.Location = New System.Drawing.Point(0, 32)
        Me.ReceiveList.Name = "ReceiveList"
        Me.ReceiveList.Size = New System.Drawing.Size(842, 535)
        Me.ReceiveList.TabIndex = 36
        Me.ReceiveList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.AliceBlue
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAdd, Me.ToolStripSeparator1, Me.btnRefresh})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip2.Size = New System.Drawing.Size(842, 32)
        Me.ToolStrip2.TabIndex = 35
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnAdd.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.Receive
        Me.BtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(123, 29)
        Me.BtnAdd.Text = "Receive Item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRefresh.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.refresh
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(91, 29)
        Me.btnRefresh.Text = "Refresh "
        '
        'UC_Receive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ReceiveList)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "UC_Receive"
        Me.Size = New System.Drawing.Size(842, 567)
        CType(Me.ReceiveList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReceiveList As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator

End Class
