Public Class frm_updatecourses_A168219
    Dim current_code As String

    Private Sub frm_updatecourses_A168219_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        get_current_code()
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_COURSES_A168219"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_courses.DataSource = mydatatable
    End Sub

    Private Sub clear_fields()
        txt_code.Text = ""
        txt_name.Text = ""
        txt_credit.Text = ""
        txt_dept.Text = ""
    End Sub

    Private Sub get_current_code()
        Dim current_row As Integer = grd_courses.CurrentRow.Index
        current_code = grd_courses(0, current_row).Value

        txt_code.Text = current_code
        txt_name.Text = grd_courses(1, current_row).Value
        txt_credit.Text = grd_courses(2, current_row).Value
        txt_dept.Text = grd_courses(3, current_row).Value

    End Sub

    Private Sub grd_courses_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_courses.CellContentClick
        get_current_code()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_COURSES_A168219 SET FLD_COURSE_NAME='" &
                       txt_name.Text & "' WHERE FLD_COURSE_CODE='" & current_code & "'")
        run_sql_command("UPDATE TBL_COURSES_A168219 SET FLD_CREDITS='" &
                      txt_credit.Text & "' WHERE FLD_COURSE_CODE='" & current_code & "'")
        run_sql_command("UPDATE TBL_COURSES_A168219 SET FLD_MANAGING_DEPT='" &
                      txt_dept.Text & "' WHERE FLD_COURSE_CODE='" & current_code & "'")

        Beep()
        MsgBox("You have successfully updated the course""" & current_code & """.")
        refresh_grid()
        clear_fields()
        get_current_code()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the course""" & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_COURSES_A168219 WHERE FLD_COURSE_CODE='" & current_code & "'")

            Beep()
            MsgBox("The course """ & current_code & """has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_code()
        End If

    End Sub
End Class