<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_Store
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
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.lblHeader = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadByCategory = New System.Windows.Forms.RadioButton
        Me.RadByBarcode = New System.Windows.Forms.RadioButton
        Me.cboCategory = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBarcode
        '
        Me.txtBarcode.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(119, 32)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(212, 27)
        Me.txtBarcode.TabIndex = 25
        '
        'btnSearch
        '
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(235, 213)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(79, 31)
        Me.btnSearch.TabIndex = 23
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(320, 213)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(79, 31)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
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
        Me.lblHeader.TabIndex = 21
        Me.lblHeader.Text = "Search Item Store"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Label1.Size = New System.Drawing.Size(505, 291)
        Me.Label1.TabIndex = 20
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.RadByCategory)
        Me.GroupBox1.Controls.Add(Me.RadByBarcode)
        Me.GroupBox1.Controls.Add(Me.txtBarcode)
        Me.GroupBox1.Controls.Add(Me.cboCategory)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(68, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 122)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search By"
        '
        'RadByCategory
        '
        Me.RadByCategory.AutoSize = True
        Me.RadByCategory.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadByCategory.Location = New System.Drawing.Point(27, 75)
        Me.RadByCategory.Name = "RadByCategory"
        Me.RadByCategory.Size = New System.Drawing.Size(86, 20)
        Me.RadByCategory.TabIndex = 38
        Me.RadByCategory.TabStop = True
        Me.RadByCategory.Text = "Category"
        Me.RadByCategory.UseVisualStyleBackColor = True
        '
        'RadByBarcode
        '
        Me.RadByBarcode.AutoSize = True
        Me.RadByBarcode.Checked = True
        Me.RadByBarcode.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadByBarcode.Location = New System.Drawing.Point(27, 34)
        Me.RadByBarcode.Name = "RadByBarcode"
        Me.RadByBarcode.Size = New System.Drawing.Size(79, 20)
        Me.RadByBarcode.TabIndex = 0
        Me.RadByBarcode.TabStop = True
        Me.RadByBarcode.Text = "Barcode"
        Me.RadByBarcode.UseVisualStyleBackColor = True
        '
        'cboCategory
        '
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.Font = New System.Drawing.Font("Trebuchet MS", 11.0!)
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(119, 72)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(212, 28)
        Me.cboCategory.TabIndex = 37
        '
        'Search_Store
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 291)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Search_Store"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search_Store"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadByCategory As System.Windows.Forms.RadioButton
    Friend WithEvents RadByBarcode As System.Windows.Forms.RadioButton
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
End Class
