<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_User
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
        Dim UserList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_User))
        Me.UserList = New Janus.Windows.GridEX.GridEX
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.BtnAdd = New System.Windows.Forms.ToolStripButton
        Me.BtnEdit = New System.Windows.Forms.ToolStripButton
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton
        CType(Me.UserList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserList
        '
        Me.UserList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        UserList_DesignTimeLayout.LayoutString = resources.GetString("UserList_DesignTimeLayout.LayoutString")
        Me.UserList.DesignTimeLayout = UserList_DesignTimeLayout
        Me.UserList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserList.GroupByBoxVisible = False
        Me.UserList.Location = New System.Drawing.Point(0, 48)
        Me.UserList.Name = "UserList"
        Me.UserList.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.UserList.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UserList.RowFormatStyle.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.UserList.Size = New System.Drawing.Size(768, 380)
        Me.UserList.TabIndex = 36
        Me.UserList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 48)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 48)
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAdd, Me.ToolStripSeparator1, Me.BtnEdit, Me.ToolStripSeparator2, Me.BtnDelete})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip2.Size = New System.Drawing.Size(768, 48)
        Me.ToolStrip2.TabIndex = 35
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnAdd.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.add
        Me.BtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(100, 45)
        Me.BtnAdd.Text = "   Add New   "
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnEdit.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.edit
        Me.BtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(77, 45)
        Me.BtnEdit.Text = "    Edit    "
        Me.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnDelete.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.delete_appointment
        Me.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(94, 45)
        Me.BtnDelete.Text = "    Delete    "
        Me.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'UC_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Controls.Add(Me.UserList)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "UC_User"
        Me.Size = New System.Drawing.Size(768, 428)
        CType(Me.UserList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserList As Janus.Windows.GridEX.GridEX
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnDelete As System.Windows.Forms.ToolStripButton

End Class
