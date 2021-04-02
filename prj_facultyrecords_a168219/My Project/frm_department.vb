Public Class frm_department
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_department.Click

    End Sub

    Private Sub grd_department_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_department.CellContentClick

    End Sub

    Private Sub frm_department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = DB_FACULTYRECORDS_A168219.accdb;Persist Security Info=False"
        Dim mysql As String = "SELECT * FROM TBL_DEPARTMENT_A168219"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_department.DataSource = mydatatable
    End Sub
End Class