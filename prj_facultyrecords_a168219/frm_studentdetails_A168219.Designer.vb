<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_studentdetails_A168219
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lst_matric = New System.Windows.Forms.ListBox()
        Me.txt_matric = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_dept = New System.Windows.Forms.TextBox()
        Me.pic_student = New System.Windows.Forms.PictureBox()
        CType(Me.pic_student, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student List"
        '
        'lst_matric
        '
        Me.lst_matric.FormattingEnabled = True
        Me.lst_matric.ItemHeight = 16
        Me.lst_matric.Location = New System.Drawing.Point(13, 51)
        Me.lst_matric.Name = "lst_matric"
        Me.lst_matric.Size = New System.Drawing.Size(208, 356)
        Me.lst_matric.TabIndex = 1
        '
        'txt_matric
        '
        Me.txt_matric.Location = New System.Drawing.Point(249, 286)
        Me.txt_matric.Name = "txt_matric"
        Me.txt_matric.Size = New System.Drawing.Size(161, 22)
        Me.txt_matric.TabIndex = 2
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(425, 286)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(161, 22)
        Me.txt_name.TabIndex = 3
        '
        'txt_dept
        '
        Me.txt_dept.Location = New System.Drawing.Point(592, 286)
        Me.txt_dept.Name = "txt_dept"
        Me.txt_dept.Size = New System.Drawing.Size(161, 22)
        Me.txt_dept.TabIndex = 4
        '
        'pic_student
        '
        Me.pic_student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_student.Location = New System.Drawing.Point(403, 39)
        Me.pic_student.Name = "pic_student"
        Me.pic_student.Size = New System.Drawing.Size(195, 222)
        Me.pic_student.TabIndex = 5
        Me.pic_student.TabStop = False
        '
        'frm_studentdetails_A168219
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 421)
        Me.Controls.Add(Me.pic_student)
        Me.Controls.Add(Me.txt_dept)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_matric)
        Me.Controls.Add(Me.lst_matric)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_studentdetails_A168219"
        Me.Text = "Student Details"
        CType(Me.pic_student, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lst_matric As ListBox
    Friend WithEvents txt_matric As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_dept As TextBox
    Friend WithEvents pic_student As PictureBox
End Class
