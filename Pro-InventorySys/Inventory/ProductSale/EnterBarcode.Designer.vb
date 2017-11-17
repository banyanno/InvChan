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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnterBarcode))
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtBarCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtProducName = New System.Windows.Forms.TextBox
        Me.txtQTY = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtPrice = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.ErrAddProduct = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.ErrAddProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bar Code:"
        '
        'TxtBarCode
        '
        Me.TxtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBarCode.Location = New System.Drawing.Point(118, 18)
        Me.TxtBarCode.Name = "TxtBarCode"
        Me.TxtBarCode.Size = New System.Drawing.Size(345, 37)
        Me.TxtBarCode.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pro-Name:"
        '
        'TxtProducName
        '
        Me.TxtProducName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProducName.Location = New System.Drawing.Point(118, 61)
        Me.TxtProducName.Name = "TxtProducName"
        Me.TxtProducName.Size = New System.Drawing.Size(345, 37)
        Me.TxtProducName.TabIndex = 1
        '
        'txtQTY
        '
        Me.txtQTY.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtQTY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQTY.Location = New System.Drawing.Point(299, 157)
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(166, 37)
        Me.txtQTY.TabIndex = 3
        Me.txtQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(385, 125)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ចំនួន:"
        '
        'TxtPrice
        '
        Me.TxtPrice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TxtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrice.Location = New System.Drawing.Point(118, 157)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(161, 37)
        Me.TxtPrice.TabIndex = 2
        Me.TxtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(155, 125)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 29)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "តំលៃ($):"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(390, 200)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 34)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ErrAddProduct
        '
        Me.ErrAddProduct.ContainerControl = Me
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer OS Battambang", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(4, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(259, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Note: Pls select field Barcode to print product"
        '
        'EnterBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 239)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.TxtPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtQTY)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtProducName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBarCode)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EnterBarcode"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bard Code"
        CType(Me.ErrAddProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtBarCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtProducName As System.Windows.Forms.TextBox
    Friend WithEvents txtQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents ErrAddProduct As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
