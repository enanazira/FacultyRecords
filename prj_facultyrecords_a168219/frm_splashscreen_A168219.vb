Public Class frm_splashscreen_A168219
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox("Welcome!")'

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_name.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_name.TextChanged

    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        username = txt_name.Text


        ' MsgBox("Welcome " & txt_name.Text _'
        ' & " to the UKM Faculty Record System")'

        frm_mainmenu_A168219.Show()
        Me.Hide()





    End Sub

    Private Sub lbl_title_Click(sender As Object, e As EventArgs) Handles lbl_title.Click

    End Sub
End Class
