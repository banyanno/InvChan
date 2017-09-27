Public Class FormEditQTY
    Dim MSale As NewSale
    Dim DAPreOder As New DSInventoryTableAdapters.PRE_INVOICE_DETAILSTableAdapter
    Dim _KhmerInput As InputLanguage
    Dim _englishInput As InputLanguage
    Sub New(ByVal MSale As NewSale)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MSale = MSale
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub SetKeyboardLayout(ByVal layout As InputLanguage)
        InputLanguage.CurrentInputLanguage = layout
    End Sub

    Public Shared Function GetInputLanguageByName(ByVal inputName As String) As InputLanguage
        Dim lang As InputLanguage
        For Each lang In InputLanguage.InstalledInputLanguages
            If lang.Culture.EnglishName.ToLower().StartsWith(inputName) Then
                Return lang
            End If
        Next
        Return Nothing
    End Function

    Public Sub LoadBengaliKeyboardLayout()
        If Not _KhmerInput Is Nothing Then
            InputLanguage.CurrentInputLanguage = _KhmerInput
        Else
            InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage
        End If
    End Sub

    Public Sub LoadEnglishKeyboardLayout()
        If Not _englishInput Is Nothing Then
            InputLanguage.CurrentInputLanguage = _englishInput
        Else
            InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage
        End If
    End Sub

    Private Sub FormEditQTY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _KhmerInput = GetInputLanguageByName("Khmer")
        _englishInput = GetInputLanguageByName("English")
        TxtQTY.Focus()
        TxtQTY.SelectAll()
    End Sub

    Private Sub FormEditQTY_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TxtQTY.Text <= 0 Then
                MessageBox.Show("Please enter QTY >0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            DAPreOder.UpdateQTY(CDbl(EmptyString(TxtQTY.Text)), (CDbl(EmptyString(TxtQTY.Text)) * CDbl(LblPrice.Text)), LblItemID.Text)
            Me.MSale.RefreshOrderList()
            Me.Close()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtQTY_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtQTY.GotFocus
        InputLanguage.CurrentInputLanguage = _englishInput
    End Sub

   
    Private Sub TxtQTY_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtQTY.KeyUp
        If e.KeyValue = 190 Then
            MessageBox.Show("You are can not type .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtQTY.Text = 0
            TxtQTY.Focus()
            TxtQTY.SelectAll()
            Exit Sub
        End If
    End Sub

    Private Sub TxtQTY_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtQTY.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtQTY_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQTY.TextChanged

    End Sub
End Class