Public Class EnterBarcode
    Dim FNewSale As NewSale
    Dim _KhmerInput As InputLanguage
    Dim _englishInput As InputLanguage
    Sub New(ByVal FNewSale As NewSale)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.FNewSale = FNewSale
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    

    Private Sub TxtBarCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtBarCode.GotFocus
        SetEnglishLanguage()
    End Sub
    Private Sub TxtBarCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBarCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub EnterBarcode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtBarCode.Focus()
        TxtBarCode.SelectAll()
    End Sub

    Private Sub EnterBarcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtBarCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBarCode.TextChanged

    End Sub
End Class