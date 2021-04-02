<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_searchcourses_A168219
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
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.grd_courses = New System.Windows.Forms.DataGridView()
        CType(Me.grd_courses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(12, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(203, 23)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Search for a Course"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(16, 36)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(631, 22)
        Me.txt_search.TabIndex = 1
        '
        'grd_courses
        '
        Me.grd_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_courses.Location = New System.Drawing.Point(16, 65)
        Me.grd_courses.Name = "grd_courses"
        Me.grd_courses.RowTemplate.Height = 24
        Me.grd_courses.Size = New System.Drawing.Size(631, 293)
        Me.grd_courses.TabIndex = 2
        '
        'frm_searchcourses_A168219
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 368)
        Me.Controls.Add(Me.grd_courses)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_searchcourses_A168219"
        Me.Text = "frm_searchcourses_A168219"
        CType(Me.grd_courses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents grd_courses As DataGridView
End Class
