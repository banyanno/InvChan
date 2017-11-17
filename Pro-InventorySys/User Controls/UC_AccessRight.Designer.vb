<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_AccessRight
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
        Dim AccessList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_AccessRight))
        Me.Label2 = New System.Windows.Forms.Label
        Me.CboUser = New System.Windows.Forms.ComboBox
        Me.AccessList = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        CType(Me.AccessList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(6, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Select User :"
        '
        'CboUser
        '
        Me.CboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboUser.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.CboUser.FormattingEnabled = True
        Me.CboUser.Items.AddRange(New Object() {"Administrator", "User"})
        Me.CboUser.Location = New System.Drawing.Point(107, 50)
        Me.CboUser.Name = "CboUser"
        Me.CboUser.Size = New System.Drawing.Size(227, 26)
        Me.CboUser.TabIndex = 92
        '
        'AccessList
        '
        Me.AccessList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccessList.AutoEdit = True
        AccessList_DesignTimeLayout.LayoutString = resources.GetString("AccessList_DesignTimeLayout.LayoutString")
        Me.AccessList.DesignTimeLayout = AccessList_DesignTimeLayout
        Me.AccessList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.AccessList.GroupByBoxVisible = False
        Me.AccessList.Location = New System.Drawing.Point(3, 82)
        Me.AccessList.Name = "AccessList"
        Me.AccessList.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.AccessList.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AccessList.RowFormatStyle.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.AccessList.Size = New System.Drawing.Size(749, 510)
        Me.AccessList.TabIndex = 94
        Me.AccessList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(755, 44)
        Me.ToolStrip1.TabIndex = 96
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton1.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.Save
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(87, 41)
        Me.ToolStripButton1.Text = "     Save     "
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'UC_AccessRight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.AccessList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CboUser)
        Me.Name = "UC_AccessRight"
        Me.Size = New System.Drawing.Size(755, 595)
        CType(Me.AccessList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboUser As System.Windows.Forms.ComboBox
    Friend WithEvents AccessList As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton

End Class
