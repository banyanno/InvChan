Public Class Item
    'Declare the variables
    Dim DAItem As New DSItemTableAdapters.ITEMTableAdapter
    Dim DACategory As New DSItemTableAdapters.CATEGORYTableAdapter
    Dim PItem As UC_Item
    Dim StrFileName As String
    Dim myImage() As Byte

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Sub New(ByVal MyPanel As UC_Item)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PItem = MyPanel
        Me.CboCategory.DataSource = DACategory.SelectCategories
        Me.CboCategory.DisplayMember = "CATE_NAME_CHN"
        Me.CboCategory.ValueMember = "CATE_ID"
        Me.txtBarCode.Focus()
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

    Private Sub txtBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBrowse.Click
        Dim OpenFD As New OpenFileDialog
        Dim DidWork As Integer = OpenFD.ShowDialog()
        OpenFD.Filter = "jpegs|*.jpg|gifs|*.gif|Bitmaps|*.bmp"
        OpenFD.Title = "Open an Image"
        If DidWork <> DialogResult.Cancel Then
            StrFileName = OpenFD.FileName
            PicItem.Image = Image.FromFile(StrFileName)
            OpenFD.Reset()
        End If
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim ItemID As String = Me.txtid.Text.Trim.Replace("'", "''")
        Dim EnglishName As String = Me.txtEngName.Text.Trim.Replace("'", "''")
        Dim ChineseName As String = Me.txtChnName.Text.Trim.Replace("'", "''")
        Dim Barcode As String = Me.txtBarCode.Text.Trim.Replace("'", "''")
        Dim CategoryID As Integer = Me.CboCategory.SelectedValue
        If ItemID = "" Then
            MsgBox("Please enter Item ID", MsgBoxStyle.Information)
            Me.txtid.Focus()
            Exit Sub
        End If
        If ChineseName = "" Then
            MsgBox("Please enter Chinese Name", MsgBoxStyle.Information)
            Me.txtChnName.Focus()
            Exit Sub
        End If

        If Not Me.PicItem.Image Is Nothing Then
            Dim MS As New IO.MemoryStream
            PicItem.Image.Save(MS, PicItem.Image.RawFormat)
            myImage = MS.GetBuffer
        End If

        If Me.lblstatus.Text = 1 Then
            'INSERT
            If DAItem.ExistingBarcode(Barcode) >= 1 Then
                MsgBox("This item barcode already exits", MsgBoxStyle.Information)
                Exit Sub
            End If
            If DAItem.ExistingName(EnglishName, ChineseName) >= 1 Then
                MsgBox("This item name already exists", MsgBoxStyle.Information)
                Exit Sub
            Else
                DAItem.InsertItem(ItemID, Barcode, EnglishName, ChineseName, CategoryID, myImage)
                MsgBox("Item added", MsgBoxStyle.Information)
                ClearBox()
                PItem.RefreshList()
                Me.txtBarCode.Focus()
            End If
        Else
            'UPDATE
            If DAItem.ExistingBarcode(Barcode) >= 1 And Barcode <> PItem.ItemList.CurrentRow.Cells("ITEM_BARCODE").Value.ToString Then
                MsgBox("This item barcode already exits", MsgBoxStyle.Information)
                Exit Sub
            End If

            DAItem.UpdateItem(ItemID, Barcode, EnglishName, ChineseName, CategoryID, myImage, CInt(PItem.ItemList.CurrentRow.Cells("ITEM_ID").Value))
            MsgBox("Item updated", MsgBoxStyle.Information)
            ClearBox()
            Me.Close()
            PItem.RefreshList()
        End If
    End Sub
    Sub ClearBox()
        Me.txtBarCode.Text = ""
        Me.txtChnName.Text = ""
        Me.txtEngName.Text = ""
        Me.CboCategory.SelectedIndex = 0
        Me.PicItem.Image = Nothing
    End Sub

    Private Sub PicItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicItem.Click

    End Sub

    Private Sub lblstatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblstatus.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub txtChnName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChnName.TextChanged

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtEngName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEngName.TextChanged

    End Sub

    Private Sub CboCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCategory.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtBarCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarCode.TextChanged

    End Sub

    Private Sub Item_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.txtBarCode.Focus()
    End Sub
End Class