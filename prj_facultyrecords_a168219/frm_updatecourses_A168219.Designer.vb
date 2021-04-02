<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updatecourses_A168219
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
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        CType(Me.grd_courses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(15, 16)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(247, 37)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Update Courses"
        '
        'grd_courses
        '
        Me.grd_courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_courses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grd_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_courses.Location = New System.Drawing.Point(22, 70)
        Me.grd_courses.Name = "grd_courses"
        Me.grd_courses.RowTemplate.Height = 24
        Me.grd_courses.Size = New System.Drawing.Size(866, 403)
        Me.grd_courses.TabIndex = 1
        '
        'txt_code
        '
        Me.txt_code.Location = New System.Drawing.Point(24, 509)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(206, 26)
        Me.txt_code.TabIndex = 2
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(236, 509)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(214, 26)
        Me.txt_name.TabIndex = 3
        '
        'txt_credit
        '
        Me.txt_credit.Location = New System.Drawing.Point(456, 509)
        Me.txt_credit.Name = "txt_credit"
        Me.txt_credit.Size = New System.Drawing.Size(214, 26)
        Me.txt_credit.TabIndex = 4
        '
        'txt_dept
        '
        Me.txt_dept.Location = New System.Drawing.Point(676, 509)
        Me.txt_dept.Name = "txt_dept"
        Me.txt_dept.Size = New System.Drawing.Size(214, 26)
        Me.txt_dept.TabIndex = 5
        '
        'lbl_code
        '
        Me.lbl_code.AutoSize = True
        Me.lbl_code.Location = New System.Drawing.Point(24, 486)
        Me.lbl_code.Name = "lbl_code"
        Me.lbl_code.Size = New System.Drawing.Size(51, 20)
        Me.lbl_code.TabIndex = 6
        Me.lbl_code.Text = "Code"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(232, 486)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(53, 20)
        Me.lbl_name.TabIndex = 7
        Me.lbl_name.Text = "Name"
        '
        'lbl_credit
        '
        Me.lbl_credit.AutoSize = True
        Me.lbl_credit.Location = New System.Drawing.Point(452, 486)
        Me.lbl_credit.Name = "lbl_credit"
        Me.lbl_credit.Size = New System.Drawing.Size(54, 20)
        Me.lbl_credit.TabIndex = 8
        Me.lbl_credit.Text = "Credit"
        '
        'lbl_dept
        '
        Me.lbl_dept.AutoSize = True
        Me.lbl_dept.Location = New System.Drawing.Point(672, 486)
        Me.lbl_dept.Name = "lbl_dept"
        Me.lbl_dept.Size = New System.Drawing.Size(97, 20)
        Me.lbl_dept.TabIndex = 9
        Me.lbl_dept.Text = "Department"
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(368, 553)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(171, 32)
        Me.btn_update.TabIndex = 10
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_delete.Location = New System.Drawing.Point(368, 591)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(171, 32)
        Me.btn_delete.TabIndex = 11
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'frm_updatecourses_A168219
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 633)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
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
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_updatecourses_A168219"
        Me.Text = "frm_updatecourses_A168219"
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
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
End Class
