<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SecondScreen
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
        Dim OrderList_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SecondScreen))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.OrderList = New Janus.Windows.GridEX.GridEX
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.LblTotalR = New System.Windows.Forms.Label
        Me.LblTotalD = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.OrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.OrderList)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(977, 524)
        Me.SplitContainer1.SplitterDistance = 602
        Me.SplitContainer1.TabIndex = 0
        '
        'OrderList
        '
        Me.OrderList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.OrderList.BackColor = System.Drawing.SystemColors.Control
        Me.OrderList.CardCaptionFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.OrderList.CardCaptionFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.OrderList.CardCaptionPrefix = "Product"
        Me.OrderList.CardColumnHeaderFormatStyle.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!)
        Me.OrderList.CardColumnHeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.OrderList.CardSpacing = 5
        Me.OrderList.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.Horizontal
        Me.OrderList.ColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.OrderList.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.OrderList.ContinuousScroll = False
        OrderList_DesignTimeLayout.LayoutString = resources.GetString("OrderList_DesignTimeLayout.LayoutString")
        Me.OrderList.DesignTimeLayout = OrderList_DesignTimeLayout
        Me.OrderList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.OrderList.GroupByBoxVisible = False
        Me.OrderList.HeaderFormatStyle.FontSize = 9.0!
        Me.OrderList.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.OrderList.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.OrderList.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.OrderList.Location = New System.Drawing.Point(0, 52)
        Me.OrderList.Name = "OrderList"
        Me.OrderList.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.OrderList.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.OrderList.RowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.OrderList.SelectOnExpand = False
        Me.OrderList.Size = New System.Drawing.Size(602, 472)
        Me.OrderList.TabIndex = 3
        Me.OrderList.TableViewHorizontalScrollIncrement = 4
        Me.OrderList.View = Janus.Windows.GridEX.View.CardView
        Me.OrderList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.OrderList.WatermarkImage.Alpha = 250
        Me.OrderList.WatermarkImage.Image = CType(resources.GetObject("OrderList.WatermarkImage.Image"), System.Drawing.Image)
        Me.OrderList.WatermarkImage.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.OrderList.WatermarkImage.Size = New System.Drawing.Size(500, 500)
        Me.OrderList.WatermarkImage.WashMode = Janus.Windows.GridEX.WashMode.UseWashColor
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Image = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.pull_down_48
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(602, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "All products"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImage = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.color_background
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.LblTotalD)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(3, 470)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(362, 47)
        Me.Panel1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Battambang", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 41)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total​ $:"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackgroundImage = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.color_background
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.LblTotalR)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(3, 417)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(362, 47)
        Me.Panel2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Khmer OS Battambang", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(5, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 41)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total ៛:"
        '
        'LblTotalR
        '
        Me.LblTotalR.BackColor = System.Drawing.Color.Transparent
        Me.LblTotalR.Font = New System.Drawing.Font("Khmer OS Battambang", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalR.ForeColor = System.Drawing.Color.White
        Me.LblTotalR.Location = New System.Drawing.Point(133, 1)
        Me.LblTotalR.Name = "LblTotalR"
        Me.LblTotalR.Size = New System.Drawing.Size(223, 42)
        Me.LblTotalR.TabIndex = 3
        Me.LblTotalR.Text = "៛​ 0"
        Me.LblTotalR.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblTotalD
        '
        Me.LblTotalD.BackColor = System.Drawing.Color.Transparent
        Me.LblTotalD.Font = New System.Drawing.Font("Khmer OS Battambang", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalD.ForeColor = System.Drawing.Color.White
        Me.LblTotalD.Location = New System.Drawing.Point(140, 0)
        Me.LblTotalD.Name = "LblTotalD"
        Me.LblTotalD.Size = New System.Drawing.Size(218, 45)
        Me.LblTotalD.TabIndex = 3
        Me.LblTotalD.Text = "$ 0"
        Me.LblTotalD.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SecondScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 524)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SecondScreen"
        Me.Text = "SecondScreen"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.OrderList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OrderList As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblTotalR As System.Windows.Forms.Label
    Friend WithEvents LblTotalD As System.Windows.Forms.Label
End Class
