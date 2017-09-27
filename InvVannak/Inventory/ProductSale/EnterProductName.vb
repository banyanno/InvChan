Public Class EnterProductName
    Dim Sale As NewSale
    Sub New(ByVal Sale As NewSale)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Sale = Sale
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub EnterProductName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtBarProductName.Focus()
        TxtBarProductName.SelectAll()
    End Sub

    Private Sub TxtBarProductName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBarProductName.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Sale.SearchByProductName(TxtBarProductName.Text.ToUpper)
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub
End Class