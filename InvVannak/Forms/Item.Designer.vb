<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Item
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtBarCode = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lblHeader = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CboCategory = New System.Windows.Forms.ComboBox
        Me.txtBrowse = New System.Windows.Forms.Button
        Me.txtEngName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtChnName = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblstatus = New System.Windows.Forms.Label
        Me.PicItem = New System.Windows.Forms.PictureBox
        Me.txtid = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.PicItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(72, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Barcode :"
        '
        'txtBarCode
        '
        Me.txtBarCode.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarCode.Location = New System.Drawing.Point(158, 72)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(219, 27)
        Me.txtBarCode.TabIndex = 21
        '
        'btnSave
        '
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(213, 257)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 31)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(298, 257)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 31)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = True
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
        Me.lblHeader.Size = New System.Drawing.Size(580, 46)
        Me.lblHeader.TabIndex = 17
        Me.lblHeader.Text = "Item Information"
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
        Me.Label1.Size = New System.Drawing.Size(580, 356)
        Me.Label1.TabIndex = 16
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CboCategory
        '
        Me.CboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCategory.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.CboCategory.FormattingEnabled = True
        Me.CboCategory.Location = New System.Drawing.Point(158, 207)
        Me.CboCategory.Name = "CboCategory"
        Me.CboCategory.Size = New System.Drawing.Size(219, 26)
        Me.CboCategory.TabIndex = 26
        '
        'txtBrowse
        '
        Me.txtBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.txtBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.txtBrowse.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrowse.ForeColor = System.Drawing.Color.Black
        Me.txtBrowse.Location = New System.Drawing.Point(426, 204)
        Me.txtBrowse.Name = "txtBrowse"
        Me.txtBrowse.Size = New System.Drawing.Size(79, 29)
        Me.txtBrowse.TabIndex = 29
        Me.txtBrowse.Text = "Browse"
        Me.txtBrowse.UseVisualStyleBackColor = True
        '
        'txtEngName
        '
        Me.txtEngName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEngName.Location = New System.Drawing.Point(517, 249)
        Me.txtEngName.Name = "txtEngName"
        Me.txtEngName.Size = New System.Drawing.Size(34, 27)
        Me.txtEngName.TabIndex = 31
        Me.txtEngName.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(65, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Category :"
        '
        'txtChnName
        '
        Me.txtChnName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChnName.Location = New System.Drawing.Point(158, 161)
        Me.txtChnName.Name = "txtChnName"
        Me.txtChnName.Size = New System.Drawing.Size(219, 27)
        Me.txtChnName.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(54, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 16)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Item Name :"
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Location = New System.Drawing.Point(433, 268)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(13, 13)
        Me.lblstatus.TabIndex = 35
        Me.lblstatus.Text = "1"
        Me.lblstatus.Visible = False
        '
        'PicItem
        '
        Me.PicItem.Location = New System.Drawing.Point(395, 71)
        Me.PicItem.Name = "PicItem"
        Me.PicItem.Size = New System.Drawing.Size(146, 116)
        Me.PicItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicItem.TabIndex = 27
        Me.PicItem.TabStop = False
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(158, 116)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(219, 27)
        Me.txtid.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(76, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Item ID :"
        '
        'Item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 356)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtChnName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEngName)
        Me.Controls.Add(Me.txtBrowse)
        Me.Controls.Add(Me.PicItem)
        Me.Controls.Add(Me.CboCategory)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBarCode)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Item"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item"
        CType(Me.PicItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBarCode As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents PicItem As System.Windows.Forms.PictureBox
    Friend WithEvents txtBrowse As System.Windows.Forms.Button
    Friend WithEvents txtEngName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtChnName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblstatus As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
