Public Class frm_courseregistration_A168219

    Private Sub frm_courseregistration_A168219_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()

        grd_newreg.ColumnCount = grd_reg.ColumnCount
        For i = 0 To grd_newreg.ColumnCount - 1
            grd_newreg.Columns(i).HeaderText = grd_reg.Columns(i).HeaderText
        Next
    End Sub

    Private Sub refresh_grid()
        grd_reg.DataSource = run_sql_query("SELECT * FROM TBL_REGISTRATION_A168219")
    End Sub

    Private Sub btn_addline_Click(sender As Object, e As EventArgs) Handles btn_addline.Click
        grd_newreg.RowCount = grd_newreg.RowCount + 1
    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        Dim mytransaction As OleDb.OleDbTransaction
        myconnection2.Open()
        mytransaction = myconnection2.BeginTransaction

        Try

            For i As Integer = 0 To grd_newreg.RowCount - 1
                Dim session As String = grd_newreg(0, i).Value
                Dim semester As String = grd_newreg(1, i).Value
                Dim matric As String = grd_newreg(2, i).Value
                Dim course As String = grd_newreg(3, i).Value
                Dim regdate As String = grd_newreg(4, i).Value

                Dim mysql As String = "INSERT INTO TBL_REGISTRATION_A168219 VALUES ('" & session & "', '" & semester & "', '" & matric & "', '" & course & "', '" & regdate & "')"
                Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2,
                mytransaction)
                mywriter.ExecuteNonQuery()
            Next

            mytransaction.Commit()
            myconnection2.Close()
            Beep()
            MsgBox("Transaction successful!")
            refresh_grid()
            grd_newreg.Rows.Clear()

        Catch ex As Exception
            Beep()
            MsgBox("Problem with transaction:" & vbCrLf & vbCrLf & ex.Message)
            mytransaction.Rollback()
            myconnection2.Close()
            refresh_grid()

        End Try
    End Sub
End Class