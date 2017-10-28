<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISSUE_INVOICE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISSUE_INVOICE))
        Me.LblInvoice = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtReceivedR = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtTotalUSD = New System.Windows.Forms.Label
        Me.TxtTotalKHR = New System.Windows.Forms.Label
        Me.TxtExchangeKHR = New System.Windows.Forms.Label
        Me.TxtExchangeUSD = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label13 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblRate = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtReceiveDollar = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblInvoice
        '
        Me.LblInvoice.AutoSize = True
        Me.LblInvoice.BackColor = System.Drawing.Color.Transparent
        Me.LblInvoice.Location = New System.Drawing.Point(348, 22)
        Me.LblInvoice.Name = "LblInvoice"
        Me.LblInvoice.Size = New System.Drawing.Size(20, 27)
        Me.LblInvoice.TabIndex = 17
        Me.LblInvoice.Text = "0"
        Me.LblInvoice.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Khmer OS Battambang", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(94, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 34)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "ប្រាក់អាប់ (៛):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Khmer OS Battambang", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(417, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 34)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ចំនួនលុយ សរុប($):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Battambang", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(417, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 34)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ប្រាក់អាប់ ($):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Khmer OS Battambang", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(98, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 34)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ចំនួនលុយ សរុប(៛):"
        '
        'TxtReceivedR
        '
        Me.TxtReceivedR.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TxtReceivedR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtReceivedR.Enabled = False
        Me.TxtReceivedR.Font = New System.Drawing.Font("Khmer OS Battambang", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReceivedR.Location = New System.Drawing.Point(8, 176)
        Me.TxtReceivedR.Name = "TxtReceivedR"
        Me.TxtReceivedR.Size = New System.Drawing.Size(305, 55)
        Me.TxtReceivedR.TabIndex = 9
        Me.TxtReceivedR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Battambang", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 34)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ប្រាក់ទទួល (៛):"
        '
        'TxtTotalUSD
        '
        Me.TxtTotalUSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalUSD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TxtTotalUSD.Font = New System.Drawing.Font("Khmer OS Battambang", 19.0!)
        Me.TxtTotalUSD.Location = New System.Drawing.Point(344, 84)
        Me.TxtTotalUSD.Name = "TxtTotalUSD"
        Me.TxtTotalUSD.Size = New System.Drawing.Size(285, 55)
        Me.TxtTotalUSD.TabIndex = 20
        Me.TxtTotalUSD.Text = "0"
        Me.TxtTotalUSD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtTotalKHR
        '
        Me.TxtTotalKHR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalKHR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TxtTotalKHR.Font = New System.Drawing.Font("Khmer OS Battambang", 19.0!)
        Me.TxtTotalKHR.Location = New System.Drawing.Point(9, 85)
        Me.TxtTotalKHR.Name = "TxtTotalKHR"
        Me.TxtTotalKHR.Size = New System.Drawing.Size(304, 55)
        Me.TxtTotalKHR.TabIndex = 21
        Me.TxtTotalKHR.Text = "0"
        Me.TxtTotalKHR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtExchangeKHR
        '
        Me.TxtExchangeKHR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtExchangeKHR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TxtExchangeKHR.Font = New System.Drawing.Font("Khmer OS Battambang", 19.0!)
        Me.TxtExchangeKHR.Location = New System.Drawing.Point(9, 271)
        Me.TxtExchangeKHR.Name = "TxtExchangeKHR"
        Me.TxtExchangeKHR.Size = New System.Drawing.Size(304, 55)
        Me.TxtExchangeKHR.TabIndex = 22
        Me.TxtExchangeKHR.Text = "0"
        Me.TxtExchangeKHR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtExchangeUSD
        '
        Me.TxtExchangeUSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtExchangeUSD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TxtExchangeUSD.Font = New System.Drawing.Font("Khmer OS Battambang", 19.0!)
        Me.TxtExchangeUSD.Location = New System.Drawing.Point(344, 272)
        Me.TxtExchangeUSD.Name = "TxtExchangeUSD"
        Me.TxtExchangeUSD.Size = New System.Drawing.Size(285, 55)
        Me.TxtExchangeUSD.TabIndex = 23
        Me.TxtExchangeUSD.Text = "0"
        Me.TxtExchangeUSD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.BackgroundImage = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.Golf_Shirt_Grey_Seamless_Pattern_For_Website_Background
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(634, 43)
        Me.Panel2.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Khmer OS Battambang", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(254, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 34)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Issue Invoice"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.Asia_Garden_Inventory_Management_System.My.Resources.Resources.Golf_Shirt_Grey_Seamless_Pattern_For_Website_Background
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblRate)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.LblInvoice)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 329)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(634, 59)
        Me.Panel1.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label9.Location = New System.Drawing.Point(5, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(281, 25)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "ចុច Key D=ទទួលលុយ$,  Key R=ទទួលលុយ ៛"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.BackColor = System.Drawing.Color.Transparent
        Me.lblRate.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.lblRate.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblRate.Location = New System.Drawing.Point(572, 24)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(49, 25)
        Me.lblRate.TabIndex = 18
        Me.lblRate.Text = "4100៛"
        Me.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label7.Location = New System.Drawing.Point(5, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(337, 25)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "ចុច Key Enter=ចេញ Invoice,  Key Esc=Cancel Issue"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(451, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "អត្រាប្តូរប្រាក់ 1$="
        '
        'TxtReceiveDollar
        '
        Me.TxtReceiveDollar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TxtReceiveDollar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtReceiveDollar.Enabled = False
        Me.TxtReceiveDollar.Font = New System.Drawing.Font("Khmer OS Battambang", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReceiveDollar.Location = New System.Drawing.Point(344, 176)
        Me.TxtReceiveDollar.Name = "TxtReceiveDollar"
        Me.TxtReceiveDollar.Size = New System.Drawing.Size(285, 55)
        Me.TxtReceiveDollar.TabIndex = 24
        Me.TxtReceiveDollar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Khmer OS Battambang", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(420, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 34)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "ប្រាក់ទទួល ($):"
        '
        'ISSUE_INVOICE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(634, 388)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtReceiveDollar)
        Me.Controls.Add(Me.TxtExchangeUSD)
        Me.Controls.Add(Me.TxtExchangeKHR)
        Me.Controls.Add(Me.TxtTotalKHR)
        Me.Controls.Add(Me.TxtTotalUSD)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtReceivedR)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ISSUE_INVOICE"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Issue Invoice"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtReceivedR As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblInvoice As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents TxtTotalUSD As System.Windows.Forms.Label
    Friend WithEvents TxtTotalKHR As System.Windows.Forms.Label
    Friend WithEvents TxtExchangeKHR As System.Windows.Forms.Label
    Friend WithEvents TxtExchangeUSD As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtReceiveDollar As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
