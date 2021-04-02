Public Class frm_mainmenu_A168219
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click

        End

    End Sub

    Private Sub lbl_date_Click(sender As Object, e As EventArgs) Handles lbl_date.Click

    End Sub

    Private Sub frm_mainmenu_A168219_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim current_date As String = Date.Now
        lbl_date.Text = current_date
        lbl_welcome.Text = "Welcome " & username & " to the UKM Faculty Records System"


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_welcome.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_studentlist.Click
        frm_studentlist.Show()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_registration.Click
        frm_registration.Show()

    End Sub

    Private Sub btn_course_Click(sender As Object, e As EventArgs) Handles btn_course.Click
        frm_coursesbydept_A168219.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_department.Click
        frm_department.Show()

    End Sub
End Class