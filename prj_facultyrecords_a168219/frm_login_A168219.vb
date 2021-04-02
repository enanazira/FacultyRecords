Public Class frm_login_A168219
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim mysql As String = "SELECT COUNT(*) AS NUM_MATCHES FROM TBL_USER_A168219 WHERE FLD_USERNAME='" & txt_username.Text & "' and FLD_PASSWORD='" & txt_password.Text & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        Dim num_matches As String = mydatatable.Rows(0).Item("NUM_MATCHES")
        If num_matches = 1 Then
            frm_mainmenu_A168219.Show()
            Me.Hide()
        Else
            txt_username.Text = ""
            txt_password.Text = ""
            MsgBox("Incorrect Username or Password")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class