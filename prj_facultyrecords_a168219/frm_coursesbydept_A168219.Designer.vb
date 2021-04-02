<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_coursesbydept_A168219
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
        Me.cmb_dept = New System.Windows.Forms.ComboBox()
        CType(Me.grd_courses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(13, 13)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(333, 34)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Courses by Department"
        '
        'grd_courses
        '
        Me.grd_courses.AllowUserToAddRows = False
        Me.grd_courses.AllowUserToDeleteRows = False
        Me.grd_courses.AllowUserToOrderColumns = True
        Me.grd_courses.AllowUserToResizeColumns = False
        Me.grd_courses.AllowUserToResizeRows = False
        Me.grd_courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_courses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_courses.Location = New System.Drawing.Point(19, 97)
        Me.grd_courses.Name = "grd_courses"
        Me.grd_courses.ReadOnly = True
        Me.grd_courses.RowTemplate.Height = 24
        Me.grd_courses.Size = New System.Drawing.Size(515, 204)
        Me.grd_courses.TabIndex = 1
        '
        'cmb_dept
        '
        Me.cmb_dept.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_dept.FormattingEnabled = True
        Me.cmb_dept.Location = New System.Drawing.Point(19, 67)
        Me.cmb_dept.Name = "cmb_dept"
        Me.cmb_dept.Size = New System.Drawing.Size(515, 29)
        Me.cmb_dept.TabIndex = 2
        Me.cmb_dept.Text = "Course"
        '
        'frm_coursesbydept_A168219
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 335)
        Me.Controls.Add(Me.cmb_dept)
        Me.Controls.Add(Me.grd_courses)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_coursesbydept_A168219"
        Me.Text = "Courses by Department"
        CType(Me.grd_courses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_courses As DataGridView
    Friend WithEvents cmb_dept As ComboBox
End Class
