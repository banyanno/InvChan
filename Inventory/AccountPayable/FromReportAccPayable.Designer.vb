<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FromReportAccPayable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FromReportAccPayable))
        Dim ButtonBar1_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup
        Me.ButtonBarContainerControl1 = New Janus.Windows.ButtonBar.ButtonBarContainerControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ChReportSummary = New System.Windows.Forms.CheckBox
        Me.GroupD1 = New System.Windows.Forms.GroupBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.DTo1 = New System.Windows.Forms.DateTimePicker
        Me.DFrom1 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.RadCompletPaid = New System.Windows.Forms.RadioButton
        Me.RadNotPaid = New System.Windows.Forms.RadioButton
        Me.RadPaidAll = New System.Windows.Forms.RadioButton
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.RadViewAll = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.CboSupplierReport = New System.Windows.Forms.ComboBox
        Me.RadBySupplier = New System.Windows.Forms.RadioButton
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF
        Me.ButtonBar1 = New Janus.Windows.ButtonBar.ButtonBar
        Me.ButtonBarContainerControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupD1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ButtonBar1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonBarContainerControl1
        '
        Me.ButtonBarContainerControl1.Controls.Add(Me.Panel1)
        Me.ButtonBarContainerControl1.Location = New System.Drawing.Point(1, 23)
        Me.ButtonBarContainerControl1.Name = "ButtonBarContainerControl1"
        Me.ButtonBarContainerControl1.Size = New System.Drawing.Size(247, 540)
        Me.ButtonBarContainerControl1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.ChReportSummary)
        Me.Panel1.Controls.Add(Me.GroupD1)
        Me.Panel1.Controls.Add(Me.GroupBox9)
        Me.Panel1.Controls.Add(Me.GroupBox7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(247, 540)
        Me.Panel1.TabIndex = 2
        '
        'ChReportSummary
        '
        Me.ChReportSummary.AutoSize = True
        Me.ChReportSummary.Checked = True
        Me.ChReportSummary.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChReportSummary.Location = New System.Drawing.Point(14, 239)
        Me.ChReportSummary.Margin = New System.Windows.Forms.Padding(2)
        Me.ChReportSummary.Name = "ChReportSummary"
        Me.ChReportSummary.Size = New System.Drawing.Size(157, 17)
        Me.ChReportSummary.TabIndex = 4
        Me.ChReportSummary.Text = " Summary Or Detail Payable"
        Me.ChReportSummary.UseVisualStyleBackColor = True
        '
        'GroupD1
        '
        Me.GroupD1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupD1.Controls.Add(Me.Label17)
        Me.GroupD1.Controls.Add(Me.Label18)
        Me.GroupD1.Controls.Add(Me.DTo1)
        Me.GroupD1.Controls.Add(Me.DFrom1)
        Me.GroupD1.Font = New System.Drawing.Font("Kh Battambang", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupD1.ForeColor = System.Drawing.Color.Blue
        Me.GroupD1.Location = New System.Drawing.Point(8, 135)
        Me.GroupD1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupD1.Name = "GroupD1"
        Me.GroupD1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupD1.Size = New System.Drawing.Size(206, 96)
        Me.GroupD1.TabIndex = 7
        Me.GroupD1.TabStop = False
        Me.GroupD1.Text = "ថ្ងៃជំពាក់"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 63)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 25)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "To:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 24)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 25)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "From:"
        '
        'DTo1
        '
        Me.DTo1.CustomFormat = "dd/MM/yyyy"
        Me.DTo1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTo1.Location = New System.Drawing.Point(65, 56)
        Me.DTo1.Margin = New System.Windows.Forms.Padding(2)
        Me.DTo1.Name = "DTo1"
        Me.DTo1.Size = New System.Drawing.Size(138, 33)
        Me.DTo1.TabIndex = 1
        '
        'DFrom1
        '
        Me.DFrom1.CustomFormat = "dd/MM/yyyy"
        Me.DFrom1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom1.Location = New System.Drawing.Point(65, 20)
        Me.DFrom1.Margin = New System.Windows.Forms.Padding(2)
        Me.DFrom1.Name = "DFrom1"
        Me.DFrom1.Size = New System.Drawing.Size(138, 33)
        Me.DFrom1.TabIndex = 0
        '
        'GroupBox9
        '
        Me.GroupBox9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox9.Controls.Add(Me.RadCompletPaid)
        Me.GroupBox9.Controls.Add(Me.RadNotPaid)
        Me.GroupBox9.Controls.Add(Me.RadPaidAll)
        Me.GroupBox9.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox9.Location = New System.Drawing.Point(6, 4)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox9.Size = New System.Drawing.Size(208, 119)
        Me.GroupBox9.TabIndex = 6
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Payable Status"
        '
        'RadCompletPaid
        '
        Me.RadCompletPaid.AutoSize = True
        Me.RadCompletPaid.Location = New System.Drawing.Point(14, 85)
        Me.RadCompletPaid.Name = "RadCompletPaid"
        Me.RadCompletPaid.Size = New System.Drawing.Size(87, 17)
        Me.RadCompletPaid.TabIndex = 4
        Me.RadCompletPaid.Text = "Complet Paid"
        Me.RadCompletPaid.UseVisualStyleBackColor = True
        '
        'RadNotPaid
        '
        Me.RadNotPaid.AutoSize = True
        Me.RadNotPaid.Location = New System.Drawing.Point(14, 55)
        Me.RadNotPaid.Name = "RadNotPaid"
        Me.RadNotPaid.Size = New System.Drawing.Size(65, 17)
        Me.RadNotPaid.TabIndex = 3
        Me.RadNotPaid.Text = "Not paid"
        Me.RadNotPaid.UseVisualStyleBackColor = True
        '
        'RadPaidAll
        '
        Me.RadPaidAll.AutoSize = True
        Me.RadPaidAll.Checked = True
        Me.RadPaidAll.Location = New System.Drawing.Point(14, 25)
        Me.RadPaidAll.Name = "RadPaidAll"
        Me.RadPaidAll.Size = New System.Drawing.Size(131, 17)
        Me.RadPaidAll.TabIndex = 2
        Me.RadPaidAll.TabStop = True
        Me.RadPaidAll.Text = "All (Paid and Not Paid)"
        Me.RadPaidAll.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.RadViewAll)
        Me.GroupBox7.Controls.Add(Me.Button1)
        Me.GroupBox7.Controls.Add(Me.CboSupplierReport)
        Me.GroupBox7.Controls.Add(Me.RadBySupplier)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox7.Location = New System.Drawing.Point(7, 240)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Size = New System.Drawing.Size(207, 168)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        '
        'RadViewAll
        '
        Me.RadViewAll.AutoSize = True
        Me.RadViewAll.Checked = True
        Me.RadViewAll.Location = New System.Drawing.Point(14, 27)
        Me.RadViewAll.Name = "RadViewAll"
        Me.RadViewAll.Size = New System.Drawing.Size(92, 17)
        Me.RadViewAll.TabIndex = 3
        Me.RadViewAll.TabStop = True
        Me.RadViewAll.Text = "By All Supplier"
        Me.RadViewAll.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(15, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Print Preview"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CboSupplierReport
        '
        Me.CboSupplierReport.Enabled = False
        Me.CboSupplierReport.Font = New System.Drawing.Font("Kh Battambang", 10.2!)
        Me.CboSupplierReport.FormattingEnabled = True
        Me.CboSupplierReport.Location = New System.Drawing.Point(14, 94)
        Me.CboSupplierReport.Name = "CboSupplierReport"
        Me.CboSupplierReport.Size = New System.Drawing.Size(181, 33)
        Me.CboSupplierReport.TabIndex = 2
        '
        'RadBySupplier
        '
        Me.RadBySupplier.AutoSize = True
        Me.RadBySupplier.Location = New System.Drawing.Point(14, 64)
        Me.RadBySupplier.Name = "RadBySupplier"
        Me.RadBySupplier.Size = New System.Drawing.Size(78, 17)
        Me.RadBySupplier.TabIndex = 1
        Me.RadBySupplier.Text = "By Supplier"
        Me.RadBySupplier.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.AxAcroPDF1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.ButtonBar1)
        Me.SplitContainer3.Size = New System.Drawing.Size(981, 566)
        Me.SplitContainer3.SplitterDistance = 726
        Me.SplitContainer3.TabIndex = 1
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(0, 0)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(724, 564)
        Me.AxAcroPDF1.TabIndex = 0
        '
        'ButtonBar1
        '
        Me.ButtonBar1.Controls.Add(Me.ButtonBarContainerControl1)
        Me.ButtonBar1.Dock = System.Windows.Forms.DockStyle.Fill
        ButtonBar1_Group_0.Container = True
        ButtonBar1_Group_0.ContainerControl = Me.ButtonBarContainerControl1
        ButtonBar1_Group_0.Key = "Group1"
        ButtonBar1_Group_0.Text = "Report Payable By"
        Me.ButtonBar1.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {ButtonBar1_Group_0})
        Me.ButtonBar1.Location = New System.Drawing.Point(0, 0)
        Me.ButtonBar1.Name = "ButtonBar1"
        Me.ButtonBar1.Size = New System.Drawing.Size(249, 564)
        Me.ButtonBar1.TabIndex = 0
        Me.ButtonBar1.Text = "ButtonBar1"
        '
        'FromReportAccPayable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 566)
        Me.Controls.Add(Me.SplitContainer3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FromReportAccPayable"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Acc-Payable"
        Me.ButtonBarContainerControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupD1.ResumeLayout(False)
        Me.GroupD1.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ButtonBar1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents ButtonBar1 As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents ButtonBarContainerControl1 As Janus.Windows.ButtonBar.ButtonBarContainerControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ChReportSummary As System.Windows.Forms.CheckBox
    Friend WithEvents GroupD1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DTo1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DFrom1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents RadCompletPaid As System.Windows.Forms.RadioButton
    Friend WithEvents RadNotPaid As System.Windows.Forms.RadioButton
    Friend WithEvents RadPaidAll As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents RadViewAll As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CboSupplierReport As System.Windows.Forms.ComboBox
    Friend WithEvents RadBySupplier As System.Windows.Forms.RadioButton
End Class
