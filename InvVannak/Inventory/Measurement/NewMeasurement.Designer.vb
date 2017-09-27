<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewMeasurement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewMeasurement))
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.lblStatus = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.ErrSupler = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrSupler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.ForeColor = System.Drawing.Color.DarkBlue
        Me.BtnCancel.Location = New System.Drawing.Point(302, 78)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(80, 31)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'UiTab1
        '
        Me.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab1.Location = New System.Drawing.Point(0, 0)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom
        Me.UiTab1.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UiTab1.Size = New System.Drawing.Size(393, 138)
        Me.UiTab1.TabIndex = 0
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1})
        Me.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.lblStatus)
        Me.UiTabPage1.Controls.Add(Me.GroupBox1)
        Me.UiTabPage1.Controls.Add(Me.BtnCancel)
        Me.UiTabPage1.Controls.Add(Me.BtnSave)
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(391, 116)
        Me.UiTabPage1.TabStop = True
        Me.UiTabPage1.Text = "Unit Information"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(19, 87)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(13, 13)
        Me.lblStatus.TabIndex = 18
        Me.lblStatus.Text = "0"
        Me.lblStatus.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 69)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Khmer OS Battambang", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(79, 16)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(274, 45)
        Me.txtname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ចំនុះ:"
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.ForeColor = System.Drawing.Color.DarkBlue
        Me.BtnSave.Location = New System.Drawing.Point(212, 78)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(85, 31)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'ErrSupler
        '
        Me.ErrSupler.ContainerControl = Me
        '
        'NewMeasurement
        '
        Me.AcceptButton = Me.BtnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(393, 138)
        Me.Controls.Add(Me.UiTab1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewMeasurement"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unit"
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage1.ResumeLayout(False)
        Me.UiTabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrSupler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents ErrSupler As System.Windows.Forms.ErrorProvider
End Class
