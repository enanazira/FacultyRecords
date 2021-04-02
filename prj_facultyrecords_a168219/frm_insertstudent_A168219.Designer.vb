<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertstudent_A168219
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_dept = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_matric = New System.Windows.Forms.TextBox()
        Me.grd_students = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.pic_student = New System.Windows.Forms.PictureBox()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_picture = New System.Windows.Forms.Button()
        CType(Me.grd_students, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_student, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_dept
        '
        Me.txt_dept.Location = New System.Drawing.Point(557, 452)
        Me.txt_dept.Name = "txt_dept"
        Me.txt_dept.Size = New System.Drawing.Size(231, 23)
        Me.txt_dept.TabIndex = 9
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(281, 452)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(231, 23)
        Me.txt_name.TabIndex = 8
        '
        'txt_matric
        '
        Me.txt_matric.Location = New System.Drawing.Point(18, 452)
        Me.txt_matric.Name = "txt_matric"
        Me.txt_matric.Size = New System.Drawing.Size(231, 23)
        Me.txt_matric.TabIndex = 7
        '
        'grd_students
        '
        Me.grd_students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_students.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_students.Location = New System.Drawing.Point(18, 154)
        Me.grd_students.Name = "grd_students"
        Me.grd_students.RowTemplate.Height = 24
        Me.grd_students.Size = New System.Drawing.Size(770, 273)
        Me.grd_students.TabIndex = 6
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(13, 3)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(236, 28)
        Me.lbl_title.TabIndex = 5
        Me.lbl_title.Text = "Insert New Students"
        '
        'btn_insert
        '
        Me.btn_insert.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(281, 550)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(227, 34)
        Me.btn_insert.TabIndex = 10
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'pic_student
        '
        Me.pic_student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_student.Location = New System.Drawing.Point(18, 34)
        Me.pic_student.Name = "pic_student"
        Me.pic_student.Size = New System.Drawing.Size(108, 114)
        Me.pic_student.TabIndex = 11
        Me.pic_student.TabStop = False
        '
        'txt_picture
        '
        Me.txt_picture.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_picture.Location = New System.Drawing.Point(142, 123)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.Size = New System.Drawing.Size(457, 16)
        Me.txt_picture.TabIndex = 12
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_picture
        '
        Me.btn_picture.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_picture.Location = New System.Drawing.Point(18, 497)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(118, 37)
        Me.btn_picture.TabIndex = 13
        Me.btn_picture.Text = "Select Picture"
        Me.btn_picture.UseVisualStyleBackColor = True
        '
        'frm_insertstudent_A168219
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 593)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.pic_student)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.txt_dept)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_matric)
        Me.Controls.Add(Me.grd_students)
        Me.Controls.Add(Me.lbl_title)
        Me.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_insertstudent_A168219"
        Me.Text = "frm_insertstudent_A168219"
        CType(Me.grd_students, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_student, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_dept As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_matric As TextBox
    Friend WithEvents grd_students As DataGridView
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_insert As Button
    Friend WithEvents pic_student As PictureBox
    Friend WithEvents txt_picture As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_picture As Button
End Class
