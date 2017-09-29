Public Class FormCompanyProfile
    Dim DA_ComProfile As New DSRevenueTableAdapters.COMPANY_PROFILETableAdapter

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        DA_ComProfile.DeleteProfile()
        If MessageBox.Show("Do you want to save new profile?", "Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_ComProfile.InsertCompanyProfile(TxtProfile.Text, TxtAddress.Text, TxtNote.Text) = 1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub FormCompanyProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim TblComProfile As DataTable = DA_ComProfile.GetData
            For Each row As DataRow In TblComProfile.Rows
                TxtProfile.Text = row("PROFILE_NAME")
                TxtAddress.Text = row("ADDRESS")
                TxtNote.Text = row("DESCRIPTION")
            Next
        Catch ex As Exception

        End Try
        
    End Sub
End Class