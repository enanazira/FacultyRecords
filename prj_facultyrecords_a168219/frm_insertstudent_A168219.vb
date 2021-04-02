Public Class frm_insertstudent_A168219
    Dim defaultpicture As String = Application.StartupPath & "\pictures\no-photo-1.png"

    Private Sub frm_insertstudent_A168219_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_students.DataSource = run_sql_query("SELECT * FROM TBL_STUDENTS_A168219")
        txt_matric.Text = generate_matric()
        txt_picture.Text = defaultpicture
        pic_student.BackgroundImage = Image.FromFile(defaultpicture)
    End Sub

    Private Function generate_matric() As String
        Dim lastmatric As String = run_sql_query("SELECT MAX(FLD_MATRIC) AS LASTMATRIC FROM TBL_STUDENTS_A168219").Rows(0).Item("LASTMATRIC")
        MsgBox(lastmatric)
        Dim newmatric As String = "A" & Mid(lastmatric, 2) + 1
        Return newmatric
    End Function

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_STUDENTS_A168219 VALUES ('" & txt_matric.Text & "', '" & txt_name.Text & "', '" & txt_dept.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_matric.Text & ".jpg")


            grd_students.DataSource = run_sql_query("SELECT * FROM TBL_STUDENTS_A168219")
            txt_matric.Text = generate_matric()
            txt_name.Text = ""
            txt_dept.Text = ""
            txt_picture.Text = defaultpicture
            pic_student.BackgroundImage = Image.FromFile(defaultpicture)

        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_picture.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        pic_student.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        txt_picture.Text = OpenFileDialog1.FileName

    End Sub


End Class