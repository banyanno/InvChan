<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportReceivable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReportReceivable))
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.ChIsSummary = New System.Windows.Forms.CheckBox
        Me.ChCustomer = New System.Windows.Forms.CheckBox
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.RadStatusComplet = New System.Windows.Forms.RadioButton
        Me.RadStatusNotyet = New System.Windows.Forms.RadioButton
        Me.RadAllStatus = New System.Windows.Forms.RadioButton
        Me.BtnPrintPreview = New System.Windows.Forms.Button
        Me.CboCustomerReport = New System.Windows.Forms.ComboBox
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.DTo = New System.Windows.Forms.DateTimePicker
        Me.DFrom = New System.Windows.Forms.DateTimePicker
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.AxAcroPDF1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.AutoScroll = True
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox7)
        Me.SplitContainer3.Size = New System.Drawing.Size(1039, 501)
        Me.SplitContainer3.SplitterDistance = 755
        Me.SplitContainer3.SplitterWidth = 3
        Me.SplitContainer3.TabIndex = 1
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(0, 0)
        Me.AxAcroPDF1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(753, 499)
        Me.AxAcroPDF1.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.ChIsSummary)
        Me.GroupBox7.Controls.Add(Me.ChCustomer)
        Me.GroupBox7.Controls.Add(Me.GroupBox9)
        Me.GroupBox7.Controls.Add(Me.BtnPrintPreview)
        Me.GroupBox7.Controls.Add(Me.CboCustomerReport)
        Me.GroupBox7.Controls.Add(Me.GroupBox10)
        Me.GroupBox7.Font = New System.Drawing.Font("Kh Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox7.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox7.Size = New System.Drawing.Size(266, 367)
        Me.GroupBox7.TabIndex = 13
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "របាយការណ៏"
        '
        'ChIsSummary
        '
        Me.ChIsSummary.AutoSize = True
        Me.ChIsSummary.Checked = True
        Me.ChIsSummary.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChIsSummary.Location = New System.Drawing.Point(8, 249)
        Me.ChIsSummary.Name = "ChIsSummary"
        Me.ChIsSummary.Size = New System.Drawing.Size(255, 29)
        Me.ChIsSummary.TabIndex = 17
        Me.ChIsSummary.Text = "(Summary Or Detail)Acc-Receivable"
        Me.ChIsSummary.UseVisualStyleBackColor = True
        '
        'ChCustomer
        '
        Me.ChCustomer.AutoSize = True
        Me.ChCustomer.Location = New System.Drawing.Point(8, 288)
        Me.ChCustomer.Name = "ChCustomer"
        Me.ChCustomer.Size = New System.Drawing.Size(81, 29)
        Me.ChCustomer.TabIndex = 16
        Me.ChCustomer.Text = "អតិថិជន"
        Me.ChCustomer.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.RadStatusComplet)
        Me.GroupBox9.Controls.Add(Me.RadStatusNotyet)
        Me.GroupBox9.Controls.Add(Me.RadAllStatus)
        Me.GroupBox9.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox9.Location = New System.Drawing.Point(8, 20)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(216, 113)
        Me.GroupBox9.TabIndex = 15
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Status Paid"
        '
        'RadStatusComplet
        '
        Me.RadStatusComplet.AutoSize = True
        Me.RadStatusComplet.Location = New System.Drawing.Point(10, 72)
        Me.RadStatusComplet.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadStatusComplet.Name = "RadStatusComplet"
        Me.RadStatusComplet.Size = New System.Drawing.Size(95, 29)
        Me.RadStatusComplet.TabIndex = 12
        Me.RadStatusComplet.Text = "Completed"
        Me.RadStatusComplet.UseVisualStyleBackColor = True
        '
        'RadStatusNotyet
        '
        Me.RadStatusNotyet.AutoSize = True
        Me.RadStatusNotyet.Location = New System.Drawing.Point(10, 47)
        Me.RadStatusNotyet.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadStatusNotyet.Name = "RadStatusNotyet"
        Me.RadStatusNotyet.Size = New System.Drawing.Size(104, 29)
        Me.RadStatusNotyet.TabIndex = 11
        Me.RadStatusNotyet.Text = "Not yet paid"
        Me.RadStatusNotyet.UseVisualStyleBackColor = True
        '
        'RadAllStatus
        '
        Me.RadAllStatus.AutoSize = True
        Me.RadAllStatus.Checked = True
        Me.RadAllStatus.Location = New System.Drawing.Point(10, 23)
        Me.RadAllStatus.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadAllStatus.Name = "RadAllStatus"
        Me.RadAllStatus.Size = New System.Drawing.Size(48, 29)
        Me.RadAllStatus.TabIndex = 10
        Me.RadAllStatus.TabStop = True
        Me.RadAllStatus.Text = "All "
        Me.RadAllStatus.UseVisualStyleBackColor = True
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrintPreview.Location = New System.Drawing.Point(8, 324)
        Me.BtnPrintPreview.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(94, 33)
        Me.BtnPrintPreview.TabIndex = 13
        Me.BtnPrintPreview.Text = "Print Preview"
        Me.BtnPrintPreview.UseVisualStyleBackColor = True
        '
        'CboCustomerReport
        '
        Me.CboCustomerReport.Enabled = False
        Me.CboCustomerReport.FormattingEnabled = True
        Me.CboCustomerReport.Location = New System.Drawing.Point(94, 284)
        Me.CboCustomerReport.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CboCustomerReport.Name = "CboCustomerReport"
        Me.CboCustomerReport.Size = New System.Drawing.Size(165, 32)
        Me.CboCustomerReport.TabIndex = 14
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.DTo)
        Me.GroupBox10.Controls.Add(Me.DFrom)
        Me.GroupBox10.Controls.Add(Me.Label15)
        Me.GroupBox10.Controls.Add(Me.Label16)
        Me.GroupBox10.Location = New System.Drawing.Point(8, 132)
        Me.GroupBox10.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox10.Size = New System.Drawing.Size(216, 102)
        Me.GroupBox10.TabIndex = 12
        Me.GroupBox10.TabStop = False
        '
        'DTo
        '
        Me.DTo.CustomFormat = "dd/MM/yyyy"
        Me.DTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTo.Location = New System.Drawing.Point(63, 64)
        Me.DTo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DTo.Name = "DTo"
        Me.DTo.Size = New System.Drawing.Size(128, 32)
        Me.DTo.TabIndex = 3
        '
        'DFrom
        '
        Me.DFrom.CustomFormat = "dd/MM/yyyy"
        Me.DFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom.Location = New System.Drawing.Point(63, 26)
        Me.DFrom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DFrom.Name = "DFrom"
        Me.DFrom.Size = New System.Drawing.Size(128, 32)
        Me.DFrom.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 69)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 25)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "To:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(11, 33)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 25)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "From:"
        '
        'FormReportReceivable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 501)
        Me.Controls.Add(Me.SplitContainer3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FormReportReceivable"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Receive Able"
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents ChIsSummary As System.Windows.Forms.CheckBox
    Friend WithEvents ChCustomer As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents RadStatusComplet As System.Windows.Forms.RadioButton
    Friend WithEvents RadStatusNotyet As System.Windows.Forms.RadioButton
    Friend WithEvents RadAllStatus As System.Windows.Forms.RadioButton
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents CboCustomerReport As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents DTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
