<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainInventoyV2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainInventoyV2))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.BtnLogout = New System.Windows.Forms.Button
        Me.ImgListDashbord = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnClosed = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.MainPanel = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1280, 84)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(353, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnLogout)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.BtnClosed)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1280, 54)
        Me.Panel2.TabIndex = 2
        '
        'BtnLogout
        '
        Me.BtnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLogout.BackColor = System.Drawing.Color.Green
        Me.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLogout.ImageIndex = 22
        Me.BtnLogout.ImageList = Me.ImgListDashbord
        Me.BtnLogout.Location = New System.Drawing.Point(1162, 6)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(52, 41)
        Me.BtnLogout.TabIndex = 24
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'ImgListDashbord
        '
        Me.ImgListDashbord.ImageStream = CType(resources.GetObject("ImgListDashbord.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgListDashbord.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgListDashbord.Images.SetKeyName(0, "Exterior_26.png")
        Me.ImgListDashbord.Images.SetKeyName(1, "Settings-50.png")
        Me.ImgListDashbord.Images.SetKeyName(2, "Checkout-50.png")
        Me.ImgListDashbord.Images.SetKeyName(3, "Accounting.png")
        Me.ImgListDashbord.Images.SetKeyName(4, "Checked Truck.png")
        Me.ImgListDashbord.Images.SetKeyName(5, "Checkout.png")
        Me.ImgListDashbord.Images.SetKeyName(6, "Closed Sign.png")
        Me.ImgListDashbord.Images.SetKeyName(7, "Exterior_2.png")
        Me.ImgListDashbord.Images.SetKeyName(8, "Google Alerts.png")
        Me.ImgListDashbord.Images.SetKeyName(9, "Hand Down.png")
        Me.ImgListDashbord.Images.SetKeyName(10, "In Transit.png")
        Me.ImgListDashbord.Images.SetKeyName(11, "Industrial Scales Connecting.png")
        Me.ImgListDashbord.Images.SetKeyName(12, "Industrial Scales Connecting_2.png")
        Me.ImgListDashbord.Images.SetKeyName(13, "NFC Sign.png")
        Me.ImgListDashbord.Images.SetKeyName(14, "Recycle Sign.png")
        Me.ImgListDashbord.Images.SetKeyName(15, "Refund.png")
        Me.ImgListDashbord.Images.SetKeyName(16, "Settings.png")
        Me.ImgListDashbord.Images.SetKeyName(17, "Sewing Tape Measure.png")
        Me.ImgListDashbord.Images.SetKeyName(18, "Theatre Mask.png")
        Me.ImgListDashbord.Images.SetKeyName(19, "Weight.png")
        Me.ImgListDashbord.Images.SetKeyName(20, "Categorize-50.png")
        Me.ImgListDashbord.Images.SetKeyName(21, "Return-96.png")
        Me.ImgListDashbord.Images.SetKeyName(22, "Logout Rounded Up-96.png")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ImageIndex = 21
        Me.Button1.ImageList = Me.ImgListDashbord
        Me.Button1.Location = New System.Drawing.Point(359, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 41)
        Me.Button1.TabIndex = 23
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnClosed
        '
        Me.BtnClosed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClosed.BackColor = System.Drawing.Color.Green
        Me.BtnClosed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClosed.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnClosed.ImageIndex = 6
        Me.BtnClosed.ImageList = Me.ImgListDashbord
        Me.BtnClosed.Location = New System.Drawing.Point(1220, 6)
        Me.BtnClosed.Name = "BtnClosed"
        Me.BtnClosed.Size = New System.Drawing.Size(52, 41)
        Me.BtnClosed.TabIndex = 22
        Me.BtnClosed.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Green
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Battambang", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(353, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(927, 54)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ប្រព័ន្ធ គ្រប់គ្រង STOCK"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dev By : បាន យ៉ាណូ Tel: 012 238 738" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Email    : ban.yanno@gmail.com"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainPanel.BackgroundImage = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.Bk2
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 138)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1280, 717)
        Me.MainPanel.TabIndex = 3
        '
        'MainInventoyV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 855)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainInventoyV2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents ImgListDashbord As System.Windows.Forms.ImageList
    Friend WithEvents BtnClosed As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
End Class
