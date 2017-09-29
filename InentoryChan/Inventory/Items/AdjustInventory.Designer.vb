<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdjustInventory
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdjustInventory))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtnewsubstock = New System.Windows.Forms.TextBox
        Me.TxtSubStock = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtnote = New System.Windows.Forms.TextBox
        Me.dtAdjust = New System.Windows.Forms.DateTimePicker
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtnewmainstock = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtMainStock = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CboProductName = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtnewsubstock)
        Me.GroupBox1.Controls.Add(Me.TxtSubStock)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtnote)
        Me.GroupBox1.Controls.Add(Me.dtAdjust)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.CboProductName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(669, 478)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adjustment Info"
        '
        'txtnewsubstock
        '
        Me.txtnewsubstock.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewsubstock.Location = New System.Drawing.Point(534, 265)
        Me.txtnewsubstock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtnewsubstock.Name = "txtnewsubstock"
        Me.txtnewsubstock.Size = New System.Drawing.Size(148, 26)
        Me.txtnewsubstock.TabIndex = 1
        Me.txtnewsubstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtnewsubstock.Visible = False
        '
        'TxtSubStock
        '
        Me.TxtSubStock.BackColor = System.Drawing.Color.White
        Me.TxtSubStock.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSubStock.Location = New System.Drawing.Point(534, 231)
        Me.TxtSubStock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtSubStock.Name = "TxtSubStock"
        Me.TxtSubStock.ReadOnly = True
        Me.TxtSubStock.Size = New System.Drawing.Size(148, 26)
        Me.TxtSubStock.TabIndex = 1
        Me.TxtSubStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtSubStock.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(432, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 27)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "ចំនួនរាយ"
        Me.Label6.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(330, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 27)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(388, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 27)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ចំនួនរាយក្នុង Stock:"
        Me.Label5.Visible = False
        '
        'txtnote
        '
        Me.txtnote.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnote.Location = New System.Drawing.Point(15, 299)
        Me.txtnote.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtnote.Multiline = True
        Me.txtnote.Name = "txtnote"
        Me.txtnote.Size = New System.Drawing.Size(648, 147)
        Me.txtnote.TabIndex = 4
        '
        'dtAdjust
        '
        Me.dtAdjust.Checked = False
        Me.dtAdjust.CustomFormat = "dd/MM/yyyy"
        Me.dtAdjust.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtAdjust.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtAdjust.Location = New System.Drawing.Point(140, 232)
        Me.dtAdjust.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtAdjust.Name = "dtAdjust"
        Me.dtAdjust.ShowCheckBox = True
        Me.dtAdjust.Size = New System.Drawing.Size(180, 26)
        Me.dtAdjust.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtnewmainstock)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Red
        Me.GroupBox3.Location = New System.Drawing.Point(362, 108)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(298, 99)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ចំនួន កែ"
        '
        'txtnewmainstock
        '
        Me.txtnewmainstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnewmainstock.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewmainstock.Location = New System.Drawing.Point(121, 46)
        Me.txtnewmainstock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtnewmainstock.Name = "txtnewmainstock"
        Me.txtnewmainstock.Size = New System.Drawing.Size(148, 37)
        Me.txtnewmainstock.TabIndex = 0
        Me.txtnewmainstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 27)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ចំនួន ត្រូវកែ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 27)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "កំណត់សំគាល់"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ថ្ងៃកែ"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtMainStock)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 108)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(332, 99)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ចំនួន ក្នុង Stock"
        '
        'TxtMainStock
        '
        Me.TxtMainStock.BackColor = System.Drawing.Color.White
        Me.TxtMainStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMainStock.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMainStock.Location = New System.Drawing.Point(130, 46)
        Me.TxtMainStock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtMainStock.Name = "TxtMainStock"
        Me.TxtMainStock.ReadOnly = True
        Me.TxtMainStock.Size = New System.Drawing.Size(174, 37)
        Me.TxtMainStock.TabIndex = 0
        Me.TxtMainStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 27)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ចំនួនក្នុង Stock:"
        '
        'CboProductName
        '
        Me.CboProductName.Font = New System.Drawing.Font("Kh Battambang", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboProductName.Location = New System.Drawing.Point(140, 52)
        Me.CboProductName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CboProductName.Name = "CboProductName"
        Me.CboProductName.Size = New System.Drawing.Size(337, 33)
        Me.CboProductName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "មុខទំនិញ:"
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Location = New System.Drawing.Point(453, 501)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(118, 41)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save Adjust"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Location = New System.Drawing.Point(577, 501)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(102, 41)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'AdjustInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(682, 546)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdjustInventory"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Adjustment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboProductName As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtAdjust As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtnewsubstock As System.Windows.Forms.TextBox
    Friend WithEvents txtnewmainstock As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtSubStock As System.Windows.Forms.TextBox
    Friend WithEvents TxtMainStock As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnote As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
