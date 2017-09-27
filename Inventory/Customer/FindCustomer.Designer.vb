<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FindCustomer))
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtphone = New System.Windows.Forms.TextBox
        Me.cbolocation = New System.Windows.Forms.ComboBox
        Me.cbogender = New System.Windows.Forms.ComboBox
        Me.RadByLocation = New System.Windows.Forms.RadioButton
        Me.RadBySex = New System.Windows.Forms.RadioButton
        Me.RadByPhone = New System.Windows.Forms.RadioButton
        Me.RadByName = New System.Windows.Forms.RadioButton
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnStart = New System.Windows.Forms.Button
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UiTab1
        '
        Me.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab1.Location = New System.Drawing.Point(0, 0)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Size = New System.Drawing.Size(356, 247)
        Me.UiTab1.TabIndex = 4
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1})
        Me.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.GroupBox1)
        Me.UiTabPage1.Controls.Add(Me.BtnClose)
        Me.UiTabPage1.Controls.Add(Me.BtnStart)
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(354, 225)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Search/Filter By"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.txtphone)
        Me.GroupBox1.Controls.Add(Me.cbolocation)
        Me.GroupBox1.Controls.Add(Me.cbogender)
        Me.GroupBox1.Controls.Add(Me.RadByLocation)
        Me.GroupBox1.Controls.Add(Me.RadBySex)
        Me.GroupBox1.Controls.Add(Me.RadByPhone)
        Me.GroupBox1.Controls.Add(Me.RadByName)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 183)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(112, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(208, 32)
        Me.txtName.TabIndex = 12
        '
        'txtphone
        '
        Me.txtphone.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphone.Location = New System.Drawing.Point(111, 57)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(208, 32)
        Me.txtphone.TabIndex = 11
        '
        'cbolocation
        '
        Me.cbolocation.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!)
        Me.cbolocation.FormattingEnabled = True
        Me.cbolocation.Location = New System.Drawing.Point(111, 136)
        Me.cbolocation.Name = "cbolocation"
        Me.cbolocation.Size = New System.Drawing.Size(208, 32)
        Me.cbolocation.TabIndex = 10
        '
        'cbogender
        '
        Me.cbogender.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!)
        Me.cbogender.FormattingEnabled = True
        Me.cbogender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbogender.Location = New System.Drawing.Point(112, 97)
        Me.cbogender.Name = "cbogender"
        Me.cbogender.Size = New System.Drawing.Size(207, 32)
        Me.cbogender.TabIndex = 7
        '
        'RadByLocation
        '
        Me.RadByLocation.AutoSize = True
        Me.RadByLocation.Location = New System.Drawing.Point(14, 141)
        Me.RadByLocation.Name = "RadByLocation"
        Me.RadByLocation.Size = New System.Drawing.Size(66, 17)
        Me.RadByLocation.TabIndex = 3
        Me.RadByLocation.Text = "Location"
        Me.RadByLocation.UseVisualStyleBackColor = True
        '
        'RadBySex
        '
        Me.RadBySex.AutoSize = True
        Me.RadBySex.Location = New System.Drawing.Point(14, 102)
        Me.RadBySex.Name = "RadBySex"
        Me.RadBySex.Size = New System.Drawing.Size(43, 17)
        Me.RadBySex.TabIndex = 2
        Me.RadBySex.Text = "Sex"
        Me.RadBySex.UseVisualStyleBackColor = True
        '
        'RadByPhone
        '
        Me.RadByPhone.AutoSize = True
        Me.RadByPhone.Location = New System.Drawing.Point(14, 64)
        Me.RadByPhone.Name = "RadByPhone"
        Me.RadByPhone.Size = New System.Drawing.Size(76, 17)
        Me.RadByPhone.TabIndex = 1
        Me.RadByPhone.Text = "Telephone"
        Me.RadByPhone.UseVisualStyleBackColor = True
        '
        'RadByName
        '
        Me.RadByName.AutoSize = True
        Me.RadByName.Checked = True
        Me.RadByName.Location = New System.Drawing.Point(14, 30)
        Me.RadByName.Name = "RadByName"
        Me.RadByName.Size = New System.Drawing.Size(53, 17)
        Me.RadByName.TabIndex = 0
        Me.RadByName.TabStop = True
        Me.RadByName.Text = "Name"
        Me.RadByName.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.Location = New System.Drawing.Point(265, 190)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(80, 31)
        Me.BtnClose.TabIndex = 5
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnStart
        '
        Me.BtnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStart.Location = New System.Drawing.Point(175, 190)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(85, 31)
        Me.BtnStart.TabIndex = 4
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'FindCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 247)
        Me.Controls.Add(Me.UiTab1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FindCustomer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search and Filter Customer"
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents RadByLocation As System.Windows.Forms.RadioButton
    Friend WithEvents RadBySex As System.Windows.Forms.RadioButton
    Friend WithEvents RadByPhone As System.Windows.Forms.RadioButton
    Friend WithEvents RadByName As System.Windows.Forms.RadioButton
    Friend WithEvents cbogender As System.Windows.Forms.ComboBox
    Friend WithEvents cbolocation As System.Windows.Forms.ComboBox
    Friend WithEvents txtphone As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
End Class
