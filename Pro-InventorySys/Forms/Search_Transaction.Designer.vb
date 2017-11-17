<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_Transaction
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
        Me.lblChoose = New System.Windows.Forms.Label
        Me.lblHeader = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.DtTo = New System.Windows.Forms.DateTimePicker
        Me.DtFrom = New System.Windows.Forms.DateTimePicker
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboCategory = New System.Windows.Forms.ComboBox
        Me.RadByItem = New System.Windows.Forms.RadioButton
        Me.RadByCategory = New System.Windows.Forms.RadioButton
        Me.RadByAll = New System.Windows.Forms.RadioButton
        Me.CboItem = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblChoose
        '
        Me.lblChoose.AutoSize = True
        Me.lblChoose.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.lblChoose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.lblChoose.Location = New System.Drawing.Point(91, 114)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(67, 16)
        Me.lblChoose.TabIndex = 84
        Me.lblChoose.Text = "Choose :"
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHeader.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeader.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(505, 46)
        Me.lblHeader.TabIndex = 62
        Me.lblHeader.Text = "Search Store Transactions"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(340, 243)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(79, 31)
        Me.btnClose.TabIndex = 63
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(263, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 16)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "To"
        '
        'DtTo
        '
        Me.DtTo.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.DtTo.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.DtTo.CustomFormat = "dd/MM/yyyy"
        Me.DtTo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtTo.Location = New System.Drawing.Point(290, 32)
        Me.DtTo.Name = "DtTo"
        Me.DtTo.Size = New System.Drawing.Size(95, 23)
        Me.DtTo.TabIndex = 82
        '
        'DtFrom
        '
        Me.DtFrom.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.DtFrom.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.DtFrom.CustomFormat = "dd/MM/yyyy"
        Me.DtFrom.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtFrom.Location = New System.Drawing.Point(164, 32)
        Me.DtFrom.Name = "DtFrom"
        Me.DtFrom.Size = New System.Drawing.Size(95, 23)
        Me.DtFrom.TabIndex = 81
        '
        'btnSearch
        '
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(255, 243)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(79, 31)
        Me.btnSearch.TabIndex = 64
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(25, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 16)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Transaction Date :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cboCategory)
        Me.GroupBox1.Controls.Add(Me.lblChoose)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DtTo)
        Me.GroupBox1.Controls.Add(Me.DtFrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.RadByItem)
        Me.GroupBox1.Controls.Add(Me.RadByCategory)
        Me.GroupBox1.Controls.Add(Me.RadByAll)
        Me.GroupBox1.Controls.Add(Me.CboItem)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(34, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 161)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search By"
        '
        'cboCategory
        '
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.Font = New System.Drawing.Font("Trebuchet MS", 11.0!)
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(164, 108)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(221, 28)
        Me.cboCategory.TabIndex = 85
        '
        'RadByItem
        '
        Me.RadByItem.AutoSize = True
        Me.RadByItem.Checked = True
        Me.RadByItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadByItem.Location = New System.Drawing.Point(186, 71)
        Me.RadByItem.Name = "RadByItem"
        Me.RadByItem.Size = New System.Drawing.Size(77, 20)
        Me.RadByItem.TabIndex = 40
        Me.RadByItem.TabStop = True
        Me.RadByItem.Text = "By Item"
        Me.RadByItem.UseVisualStyleBackColor = True
        '
        'RadByCategory
        '
        Me.RadByCategory.AutoSize = True
        Me.RadByCategory.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadByCategory.Location = New System.Drawing.Point(278, 71)
        Me.RadByCategory.Name = "RadByCategory"
        Me.RadByCategory.Size = New System.Drawing.Size(107, 20)
        Me.RadByCategory.TabIndex = 38
        Me.RadByCategory.Text = "By Category"
        Me.RadByCategory.UseVisualStyleBackColor = True
        '
        'RadByAll
        '
        Me.RadByAll.AutoSize = True
        Me.RadByAll.Checked = True
        Me.RadByAll.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadByAll.Location = New System.Drawing.Point(86, 71)
        Me.RadByAll.Name = "RadByAll"
        Me.RadByAll.Size = New System.Drawing.Size(83, 20)
        Me.RadByAll.TabIndex = 0
        Me.RadByAll.TabStop = True
        Me.RadByAll.Text = "All Items"
        Me.RadByAll.UseVisualStyleBackColor = True
        '
        'CboItem
        '
        Me.CboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboItem.Font = New System.Drawing.Font("Trebuchet MS", 11.0!)
        Me.CboItem.FormattingEnabled = True
        Me.CboItem.Location = New System.Drawing.Point(164, 108)
        Me.CboItem.Name = "CboItem"
        Me.CboItem.Size = New System.Drawing.Size(221, 28)
        Me.CboItem.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(505, 300)
        Me.Label1.TabIndex = 61
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Search_Transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 300)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Search_Transaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search_Transaction"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblChoose As System.Windows.Forms.Label
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents RadByItem As System.Windows.Forms.RadioButton
    Friend WithEvents RadByCategory As System.Windows.Forms.RadioButton
    Friend WithEvents RadByAll As System.Windows.Forms.RadioButton
    Friend WithEvents CboItem As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
