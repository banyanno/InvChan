<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterBarcode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnterBarcode))
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtBarCode = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bar Code:"
        '
        'TxtBarCode
        '
        Me.TxtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBarCode.Location = New System.Drawing.Point(104, 18)
        Me.TxtBarCode.Name = "TxtBarCode"
        Me.TxtBarCode.Size = New System.Drawing.Size(359, 37)
        Me.TxtBarCode.TabIndex = 1
        '
        'EnterBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 70)
        Me.Controls.Add(Me.TxtBarCode)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EnterBarcode"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bard Code"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtBarCode As System.Windows.Forms.TextBox
End Class
