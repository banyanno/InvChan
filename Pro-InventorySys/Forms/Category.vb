Public Class Category

    Dim DACategory As New DSItemTableAdapters.CATEGORYTableAdapter
    Dim PCategory As UC_Category
    'Declare the variables

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Sub New(ByVal MyPanel As UC_Category)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.PCategory = MyPanel

    End Sub

    Private Sub lblHeader_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblHeader.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub lblHeader_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblHeader.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub lblHeader_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblHeader.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub lblHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHeader.Click

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim EnglishName As String = Me.txtEngName.Text.Trim.Replace("'", "''")
        Dim ChineseName As String = Me.txtChnName.Text.Trim.Replace("'", "''")
        Dim UCategory As New UC_Category
        If ChineseName = "" Then
            MsgBox("Please enter Chinese Name", MsgBoxStyle.Information)
            Me.txtChnName.Focus()
            Exit Sub
        End If
        If Me.lblstatus.Text = 1 Then
            ''INSERT
            If DACategory.ExistingName(EnglishName, ChineseName) >= 1 Then
                MsgBox("This category name already exists", MsgBoxStyle.Information)
                Exit Sub
            Else
                DACategory.InsertCategory(EnglishName, ChineseName)
                MsgBox("Category added", MsgBoxStyle.Information)
                ClearBox()
                PCategory.RefreshList()
                Me.txtEngName.Focus()
            End If
        Else
            ''UPDATE
            DACategory.UpdateCategory(EnglishName, ChineseName, CInt(PCategory.CategoryList.CurrentRow.Cells("CATE_ID").Value))
            MsgBox("Category updated", MsgBoxStyle.Information)
            ClearBox()
            Me.Close()
            PCategory.RefreshList()
        End If
    End Sub
    Sub ClearBox()
        Me.txtEngName.Text = ""
        Me.txtChnName.Text = ""
    End Sub

    Private Sub lblstatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblstatus.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtChnName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChnName.TextChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtEngName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEngName.TextChanged

    End Sub
End Class