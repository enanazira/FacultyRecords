Public Class frm_studentlist
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_title.Click

    End Sub

    Private Sub frm_studentlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = DB_FACULTYRECORDS_A168219.accdb;Persist Security Info=False"
        Dim mysql As String = "SELECT * FROM TBL_STUDENTS_A168219"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_students.DataSource = mydatatable
    End Sub
End Class