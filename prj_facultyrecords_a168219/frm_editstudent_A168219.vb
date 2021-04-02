Public Class frm_editstudent_A168219
    Dim current_code As String
    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_STUDENTS_A168219"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_students.DataSource = mydatatable
    End Sub

    Private Sub frm_editstudent_A168219_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        get_current_code()
    End Sub

    Private Sub clear_fields()
        txt_name.Text = ""
        txt_matric.Text = ""
        txt_dept.Text = ""
    End Sub
    Private Sub get_current_code()
        Dim current_row As Integer = grd_students.CurrentRow.Index
        current_code = grd_students(0, current_row).Value

        txt_matric.Text = current_code
        txt_name.Text = grd_students(1, current_row).Value
        txt_dept.Text = grd_students(2, current_row).Value

    End Sub

    Private Sub grd_students_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_students.CellContentClick
        'get_current_code()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_STUDENTS_A168219 VALUES ('" & txt_matric.Text & "', '" & txt_name.Text & "', '" & txt_dept.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            refresh_grid()
            clear_fields()

        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

    End Sub
End Class