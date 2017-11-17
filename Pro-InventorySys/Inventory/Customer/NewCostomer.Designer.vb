<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCostomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewCostomer))
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtnote = New System.Windows.Forms.TextBox
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblStatus = New System.Windows.Forms.Label
        Me.txtwebsite = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbolocation = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtphone = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbogender = New System.Windows.Forms.ComboBox
        Me.txtshop = New System.Windows.Forms.TextBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.ErrCustomer = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.UiTabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        CType(Me.ErrCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 261)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Note:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(528, 44)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Website:"
        Me.Label8.Visible = False
        '
        'txtnote
        '
        Me.txtnote.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnote.Location = New System.Drawing.Point(17, 280)
        Me.txtnote.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnote.Multiline = True
        Me.txtnote.Name = "txtnote"
        Me.txtnote.Size = New System.Drawing.Size(608, 77)
        Me.txtnote.TabIndex = 8
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.GroupBox1)
        Me.UiTabPage1.Controls.Add(Me.BtnCancel)
        Me.UiTabPage1.Controls.Add(Me.BtnSave)
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 25)
        Me.UiTabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(658, 418)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Customer Information"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtnote)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtwebsite)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbolocation)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtphone)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbogender)
        Me.GroupBox1.Controls.Add(Me.txtshop)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, -4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(644, 372)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(350, 83)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(16, 17)
        Me.lblStatus.TabIndex = 17
        Me.lblStatus.Text = "0"
        Me.lblStatus.Visible = False
        '
        'txtwebsite
        '
        Me.txtwebsite.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwebsite.Location = New System.Drawing.Point(599, 23)
        Me.txtwebsite.Margin = New System.Windows.Forms.Padding(4)
        Me.txtwebsite.Name = "txtwebsite"
        Me.txtwebsite.Size = New System.Drawing.Size(48, 38)
        Me.txtwebsite.TabIndex = 6
        Me.txtwebsite.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(538, 187)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "E-Mail:"
        Me.Label7.Visible = False
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(597, 177)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(55, 38)
        Me.txtemail.TabIndex = 5
        Me.txtemail.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 143)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Telephone *:"
        '
        'cbolocation
        '
        Me.cbolocation.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!)
        Me.cbolocation.FormattingEnabled = True
        Me.cbolocation.Location = New System.Drawing.Point(594, 132)
        Me.cbolocation.Margin = New System.Windows.Forms.Padding(4)
        Me.cbolocation.Name = "cbolocation"
        Me.cbolocation.Size = New System.Drawing.Size(95, 37)
        Me.cbolocation.TabIndex = 3
        Me.cbolocation.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(508, 139)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Location:"
        Me.Label6.Visible = False
        '
        'txtphone
        '
        Me.txtphone.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphone.Location = New System.Drawing.Point(141, 122)
        Me.txtphone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(364, 38)
        Me.txtphone.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(508, 93)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Shop's Name:"
        Me.Label5.Visible = False
        '
        'cbogender
        '
        Me.cbogender.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!)
        Me.cbogender.FormattingEnabled = True
        Me.cbogender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbogender.Location = New System.Drawing.Point(141, 73)
        Me.cbogender.Margin = New System.Windows.Forms.Padding(4)
        Me.cbogender.Name = "cbogender"
        Me.cbogender.Size = New System.Drawing.Size(185, 37)
        Me.cbogender.TabIndex = 1
        '
        'txtshop
        '
        Me.txtshop.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtshop.Location = New System.Drawing.Point(594, 86)
        Me.txtshop.Margin = New System.Windows.Forms.Padding(4)
        Me.txtshop.Name = "txtshop"
        Me.txtshop.Size = New System.Drawing.Size(53, 38)
        Me.txtshop.TabIndex = 2
        Me.txtshop.Visible = False
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(17, 208)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(608, 38)
        Me.txtaddress.TabIndex = 7
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(141, 23)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(364, 38)
        Me.txtname.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 188)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 93)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Gender:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name *:"
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(544, 376)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(107, 38)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(424, 376)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(113, 38)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'UiTab1
        '
        Me.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab1.Location = New System.Drawing.Point(0, 0)
        Me.UiTab1.Margin = New System.Windows.Forms.Padding(4)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Size = New System.Drawing.Size(660, 444)
        Me.UiTab1.TabIndex = 0
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1})
        Me.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'ErrCustomer
        '
        Me.ErrCustomer.ContainerControl = Me
        '
        'NewCostomer
        '
        Me.AcceptButton = Me.BtnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 444)
        Me.Controls.Add(Me.UiTab1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewCostomer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Costomer"
        Me.UiTabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        CType(Me.ErrCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtnote As System.Windows.Forms.TextBox
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtwebsite As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbolocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtphone As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbogender As System.Windows.Forms.ComboBox
    Friend WithEvents txtshop As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents ErrCustomer As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblStatus As System.Windows.Forms.Label
End Class
