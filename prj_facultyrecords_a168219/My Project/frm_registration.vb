Public Class frm_registration
    Private Sub frm_registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = DB_FACULTYRECORDS_A168219.accdb;Persist Security Info=False"'
        Dim mysql As String = "SELECT * FROM TBL_REGISTRATION_A168219"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_registration.DataSource = mydatatable
    End Sub
End Class