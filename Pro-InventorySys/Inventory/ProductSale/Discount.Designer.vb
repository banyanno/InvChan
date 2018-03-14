<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Discount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Discount))
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtDiscount = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtItemName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblItemID = New System.Windows.Forms.Label
        Me.LblPrice = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(9, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 22)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Key: Enter=add, Esc=close"
        '
        'TxtDiscount
        '
        Me.TxtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDiscount.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!)
        Me.TxtDiscount.ForeColor = System.Drawing.Color.Red
        Me.TxtDiscount.Location = New System.Drawing.Point(72, 52)
        Me.TxtDiscount.Name = "TxtDiscount"
        Me.TxtDiscount.Size = New System.Drawing.Size(276, 30)
        Me.TxtDiscount.TabIndex = 6
        Me.TxtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(9, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 22)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "បញ្ចុះតំលៃ:"
        '
        'TxtItemName
        '
        Me.TxtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtItemName.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!)
        Me.TxtItemName.ForeColor = System.Drawing.Color.Blue
        Me.TxtItemName.Location = New System.Drawing.Point(72, 12)
        Me.TxtItemName.Name = "TxtItemName"
        Me.TxtItemName.Size = New System.Drawing.Size(276, 30)
        Me.TxtItemName.TabIndex = 9
        Me.TxtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(9, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 22)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "មុខទំនិញ:"
        '
        'LblItemID
        '
        Me.LblItemID.AutoSize = True
        Me.LblItemID.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!)
        Me.LblItemID.Location = New System.Drawing.Point(339, 7)
        Me.LblItemID.Name = "LblItemID"
        Me.LblItemID.Size = New System.Drawing.Size(17, 22)
        Me.LblItemID.TabIndex = 7
        Me.LblItemID.Text = "0"
        Me.LblItemID.Visible = False
        '
        'LblPrice
        '
        Me.LblPrice.AutoSize = True
        Me.LblPrice.Location = New System.Drawing.Point(200, 94)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(13, 13)
        Me.LblPrice.TabIndex = 12
        Me.LblPrice.Text = "0"
        Me.LblPrice.Visible = False
        '
        'Discount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(360, 124)
        Me.Controls.Add(Me.LblPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtDiscount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtItemName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblItemID)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Discount"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Discount"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtItemName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblItemID As System.Windows.Forms.Label
    Friend WithEvents LblPrice As System.Windows.Forms.Label
End Class
