<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashbordRevenue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashbordRevenue))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TxtNetIncomeR = New System.Windows.Forms.TextBox
        Me.TxtNetIncomeB = New System.Windows.Forms.TextBox
        Me.TxtNetIncomeD = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.BtnPrintPreview = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TxtCashOutR = New System.Windows.Forms.TextBox
        Me.TxtCashOutB = New System.Windows.Forms.TextBox
        Me.TxtCashOutD = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtCashInR = New System.Windows.Forms.TextBox
        Me.TxtCashInB = New System.Windows.Forms.TextBox
        Me.TxtCashinD = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.AxAcroPDF1)
        Me.SplitContainer1.Size = New System.Drawing.Size(942, 635)
        Me.SplitContainer1.SplitterDistance = 300
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.BtnPrintPreview)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.DateTo)
        Me.GroupBox1.Controls.Add(Me.DateFrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(298, 633)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Revenue(ប្រាក់ចំណូល)"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtNetIncomeR)
        Me.GroupBox4.Controls.Add(Me.TxtNetIncomeB)
        Me.GroupBox4.Controls.Add(Me.TxtNetIncomeD)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 449)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(269, 151)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Net Income(ប្រាក់ចំណេញ)"
        '
        'TxtNetIncomeR
        '
        Me.TxtNetIncomeR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNetIncomeR.Location = New System.Drawing.Point(102, 106)
        Me.TxtNetIncomeR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtNetIncomeR.Name = "TxtNetIncomeR"
        Me.TxtNetIncomeR.Size = New System.Drawing.Size(158, 30)
        Me.TxtNetIncomeR.TabIndex = 5
        '
        'TxtNetIncomeB
        '
        Me.TxtNetIncomeB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNetIncomeB.Location = New System.Drawing.Point(102, 67)
        Me.TxtNetIncomeB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtNetIncomeB.Name = "TxtNetIncomeB"
        Me.TxtNetIncomeB.Size = New System.Drawing.Size(158, 30)
        Me.TxtNetIncomeB.TabIndex = 4
        '
        'TxtNetIncomeD
        '
        Me.TxtNetIncomeD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNetIncomeD.Location = New System.Drawing.Point(101, 28)
        Me.TxtNetIncomeD.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtNetIncomeD.Name = "TxtNetIncomeD"
        Me.TxtNetIncomeD.Size = New System.Drawing.Size(158, 30)
        Me.TxtNetIncomeD.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 112)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 22)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "ប្រក់ចំណេញ(៛):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 73)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 22)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "ប្រាក់ចំណេញ(B):"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 34)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 22)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "ប្រាក់ចំណេញ($):"
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrintPreview.Location = New System.Drawing.Point(181, 28)
        Me.BtnPrintPreview.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(104, 65)
        Me.BtnPrintPreview.TabIndex = 6
        Me.BtnPrintPreview.Text = "Print Preview"
        Me.BtnPrintPreview.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtCashOutR)
        Me.GroupBox3.Controls.Add(Me.TxtCashOutB)
        Me.GroupBox3.Controls.Add(Me.TxtCashOutD)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 284)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(269, 151)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ប្រាក់ចំណាយពីកាទិញ"
        '
        'TxtCashOutR
        '
        Me.TxtCashOutR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCashOutR.Location = New System.Drawing.Point(102, 106)
        Me.TxtCashOutR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtCashOutR.Name = "TxtCashOutR"
        Me.TxtCashOutR.Size = New System.Drawing.Size(158, 30)
        Me.TxtCashOutR.TabIndex = 5
        '
        'TxtCashOutB
        '
        Me.TxtCashOutB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCashOutB.Location = New System.Drawing.Point(102, 67)
        Me.TxtCashOutB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtCashOutB.Name = "TxtCashOutB"
        Me.TxtCashOutB.Size = New System.Drawing.Size(158, 30)
        Me.TxtCashOutB.TabIndex = 4
        '
        'TxtCashOutD
        '
        Me.TxtCashOutD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCashOutD.Location = New System.Drawing.Point(101, 28)
        Me.TxtCashOutD.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtCashOutD.Name = "TxtCashOutD"
        Me.TxtCashOutD.Size = New System.Drawing.Size(158, 30)
        Me.TxtCashOutD.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 112)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 22)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "ប្រាក់ចំណាយ(៛):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 73)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 22)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "ប្រាក់ចំណាយ(B):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 34)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 22)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ប្រាក់ចំណាយ($):"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtCashInR)
        Me.GroupBox2.Controls.Add(Me.TxtCashInB)
        Me.GroupBox2.Controls.Add(Me.TxtCashinD)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 106)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(269, 153)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ប្រាក់ចំណូលពីកាលក់"
        '
        'TxtCashInR
        '
        Me.TxtCashInR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCashInR.Location = New System.Drawing.Point(102, 106)
        Me.TxtCashInR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtCashInR.Name = "TxtCashInR"
        Me.TxtCashInR.Size = New System.Drawing.Size(158, 30)
        Me.TxtCashInR.TabIndex = 5
        '
        'TxtCashInB
        '
        Me.TxtCashInB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCashInB.Location = New System.Drawing.Point(102, 67)
        Me.TxtCashInB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtCashInB.Name = "TxtCashInB"
        Me.TxtCashInB.Size = New System.Drawing.Size(158, 30)
        Me.TxtCashInB.TabIndex = 4
        '
        'TxtCashinD
        '
        Me.TxtCashinD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCashinD.Location = New System.Drawing.Point(101, 28)
        Me.TxtCashinD.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtCashinD.Name = "TxtCashinD"
        Me.TxtCashinD.Size = New System.Drawing.Size(158, 30)
        Me.TxtCashinD.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 112)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 22)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "ប្រាក់ចំណូល(៛):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 73)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 22)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ប្រាក់ចំណូល(B):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ប្រាក់ចំណូល($):"
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd-MM-yyyy"
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(80, 64)
        Me.DateTo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(98, 30)
        Me.DateTo.TabIndex = 3
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd-MM-yyyy"
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(80, 26)
        Me.DateFrom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(98, 30)
        Me.DateFrom.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date From:"
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(0, 0)
        Me.AxAcroPDF1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(637, 633)
        Me.AxAcroPDF1.TabIndex = 0
        '
        'DashbordRevenue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Controls.Add(Me.SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "DashbordRevenue"
        Me.Size = New System.Drawing.Size(942, 635)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtCashInR As System.Windows.Forms.TextBox
    Friend WithEvents TxtCashInB As System.Windows.Forms.TextBox
    Friend WithEvents TxtCashinD As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtCashOutR As System.Windows.Forms.TextBox
    Friend WithEvents TxtCashOutB As System.Windows.Forms.TextBox
    Friend WithEvents TxtCashOutD As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNetIncomeR As System.Windows.Forms.TextBox
    Friend WithEvents TxtNetIncomeB As System.Windows.Forms.TextBox
    Friend WithEvents TxtNetIncomeD As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF

End Class
