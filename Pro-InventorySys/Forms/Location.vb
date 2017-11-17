Public Class Location
    Dim DAMainLocation As New DSItemTableAdapters.MAIN_LOCATIONTableAdapter
    Dim DALocation As New DSItemTableAdapters.LOCATIONTableAdapter
    Dim PLocation As UC_Location
    'Declare the variables

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Sub New(ByVal MyPanel As UC_Location)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.PLocation = MyPanel
        Dim MainTable As New DataTable
        Me.cboMainLocation.DataSource = DAMainLocation.SelectLocation
        Me.cboMainLocation.DisplayMember = "MLOC_NAME"
        Me.cboMainLocation.ValueMember = "MLOC_ID"
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
        Dim LocationName As String = Me.txtLocation.Text.Trim.Replace("'", "''")

        If LocationName = "" Then
            MsgBox("Please enter Location Name", MsgBoxStyle.Information)
            Me.txtLocation.Focus()
            Exit Sub
        End If
        If Me.lblstatus.Text = 1 Then
            DALocation.InsertLocation(LocationName, CInt(Me.cboMainLocation.SelectedValue))
            MsgBox("Location added", MsgBoxStyle.Information)
            ClearBox()
            PLocation.RefreshList()
            Me.txtLocation.Focus()
        Else
            ''UPDATE
            DALocation.UpdateLocation(LocationName, CInt(Me.cboMainLocation.SelectedValue), CInt(PLocation.LocationList.CurrentRow.Cells("LOCA_ID").Value))
            MsgBox("Location updated", MsgBoxStyle.Information)
            ClearBox()
            Me.Close()
            PLocation.RefreshList()
        End If
    End Sub
    Sub ClearBox()
        Me.txtLocation.Text = ""
        Me.cboMainLocation.SelectedIndex = 0
    End Sub
End Class