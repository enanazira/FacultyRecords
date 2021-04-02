<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertcourses_A168219
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
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_courses = New System.Windows.Forms.DataGridView()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_credit = New System.Windows.Forms.TextBox()
        Me.txt_dept = New System.Windows.Forms.TextBox()
        Me.lbl_code = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_credit = New System.Windows.Forms.Label()
        Me.lbl_dept = New System.Windows.Forms.Label()
        Me.btn_insert = New System.Windows.Forms.Button()
        CType(Me.grd_courses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(13, 14)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(176, 23)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Add New Course"
        '
        'grd_courses
        '
        Me.grd_courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_courses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_courses.Location = New System.Drawing.Point(13, 42)
        Me.grd_courses.Name = "grd_courses"
        Me.grd_courses.RowTemplate.Height = 24
        Me.grd_courses.Size = New System.Drawing.Size(775, 333)
        Me.grd_courses.TabIndex = 1
        '
        'txt_code
        '
        Me.txt_code.Location = New System.Drawing.Point(17, 423)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(177, 23)
        Me.txt_code.TabIndex = 2
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(214, 423)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(177, 23)
        Me.txt_name.TabIndex = 3
        '
        'txt_credit
        '
        Me.txt_credit.Location = New System.Drawing.Point(410, 423)
        Me.txt_credit.Name = "txt_credit"
        Me.txt_credit.Size = New System.Drawing.Size(177, 23)
        Me.txt_credit.TabIndex = 4
        '
        'txt_dept
        '
        Me.txt_dept.Location = New System.Drawing.Point(611, 423)
        Me.txt_dept.Name = "txt_dept"
        Me.txt_dept.Size = New System.Drawing.Size(177, 23)
        Me.txt_dept.TabIndex = 5
        '
        'lbl_code
        '
        Me.lbl_code.AutoSize = True
        Me.lbl_code.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_code.Location = New System.Drawing.Point(17, 398)
        Me.lbl_code.Name = "lbl_code"
        Me.lbl_code.Size = New System.Drawing.Size(51, 20)
        Me.lbl_code.TabIndex = 6
        Me.lbl_code.Text = "Code"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(210, 398)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(53, 20)
        Me.lbl_name.TabIndex = 7
        Me.lbl_name.Text = "Name"
        '
        'lbl_credit
        '
        Me.lbl_credit.AutoSize = True
        Me.lbl_credit.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_credit.Location = New System.Drawing.Point(406, 398)
        Me.lbl_credit.Name = "lbl_credit"
        Me.lbl_credit.Size = New System.Drawing.Size(54, 20)
        Me.lbl_credit.TabIndex = 8
        Me.lbl_credit.Text = "Credit"
        '
        'lbl_dept
        '
        Me.lbl_dept.AutoSize = True
        Me.lbl_dept.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dept.Location = New System.Drawing.Point(607, 400)
        Me.lbl_dept.Name = "lbl_dept"
        Me.lbl_dept.Size = New System.Drawing.Size(97, 20)
        Me.lbl_dept.TabIndex = 9
        Me.lbl_dept.Text = "Department"
        '
        'btn_insert
        '
        Me.btn_insert.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(344, 474)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(174, 32)
        Me.btn_insert.TabIndex = 10
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'frm_insertcourses_A168219
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 509)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.lbl_dept)
        Me.Controls.Add(Me.lbl_credit)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_code)
        Me.Controls.Add(Me.txt_dept)
        Me.Controls.Add(Me.txt_credit)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_code)
        Me.Controls.Add(Me.grd_courses)
        Me.Controls.Add(Me.lbl_title)
        Me.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_insertcourses_A168219"
        Me.Text = "Insert Courses"
        CType(Me.grd_courses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_courses As DataGridView
    Friend WithEvents txt_code As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_credit As TextBox
    Friend WithEvents txt_dept As TextBox
    Friend WithEvents lbl_code As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_credit As Label
    Friend WithEvents lbl_dept As Label
    Friend WithEvents btn_insert As Button
End Class
