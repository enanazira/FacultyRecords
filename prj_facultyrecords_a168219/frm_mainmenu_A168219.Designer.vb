<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainmenu_A168219
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
        Me.lbl_menutitle = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_welcome = New System.Windows.Forms.Label()
        Me.btn_studentlist = New System.Windows.Forms.Button()
        Me.btn_course = New System.Windows.Forms.Button()
        Me.btn_department = New System.Windows.Forms.Button()
        Me.btn_registration = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_menutitle
        '
        Me.lbl_menutitle.AutoSize = True
        Me.lbl_menutitle.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_menutitle.Location = New System.Drawing.Point(122, 62)
        Me.lbl_menutitle.Name = "lbl_menutitle"
        Me.lbl_menutitle.Size = New System.Drawing.Size(188, 37)
        Me.lbl_menutitle.TabIndex = 0
        Me.lbl_menutitle.Text = "MAIN MENU"
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.White
        Me.btn_exit.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.DarkRed
        Me.btn_exit.Location = New System.Drawing.Point(129, 295)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(174, 32)
        Me.btn_exit.TabIndex = 1
        Me.btn_exit.Text = "EXIT "
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(293, 339)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(28, 13)
        Me.lbl_date.TabIndex = 2
        Me.lbl_date.Text = "date"
        '
        'lbl_welcome
        '
        Me.lbl_welcome.AutoSize = True
        Me.lbl_welcome.Location = New System.Drawing.Point(51, 139)
        Me.lbl_welcome.Name = "lbl_welcome"
        Me.lbl_welcome.Size = New System.Drawing.Size(77, 17)
        Me.lbl_welcome.TabIndex = 3
        Me.lbl_welcome.Text = "Label1 jdjd"
        '
        'btn_studentlist
        '
        Me.btn_studentlist.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_studentlist.Location = New System.Drawing.Point(47, 193)
        Me.btn_studentlist.Name = "btn_studentlist"
        Me.btn_studentlist.Size = New System.Drawing.Size(171, 32)
        Me.btn_studentlist.TabIndex = 4
        Me.btn_studentlist.Text = "STUDENT LIST"
        Me.btn_studentlist.UseVisualStyleBackColor = True
        '
        'btn_course
        '
        Me.btn_course.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_course.Location = New System.Drawing.Point(224, 193)
        Me.btn_course.Name = "btn_course"
        Me.btn_course.Size = New System.Drawing.Size(171, 32)
        Me.btn_course.TabIndex = 5
        Me.btn_course.Text = "COURSE LIST"
        Me.btn_course.UseVisualStyleBackColor = True
        '
        'btn_department
        '
        Me.btn_department.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_department.Location = New System.Drawing.Point(47, 231)
        Me.btn_department.Name = "btn_department"
        Me.btn_department.Size = New System.Drawing.Size(171, 32)
        Me.btn_department.TabIndex = 6
        Me.btn_department.Text = "DEPARTMENT LIST"
        Me.btn_department.UseVisualStyleBackColor = True
        '
        'btn_registration
        '
        Me.btn_registration.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registration.Location = New System.Drawing.Point(224, 231)
        Me.btn_registration.Name = "btn_registration"
        Me.btn_registration.Size = New System.Drawing.Size(171, 32)
        Me.btn_registration.TabIndex = 7
        Me.btn_registration.Text = "REGISTRATION LIST"
        Me.btn_registration.UseVisualStyleBackColor = True
        '
        'frm_mainmenu_A168219
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 376)
        Me.Controls.Add(Me.btn_registration)
        Me.Controls.Add(Me.btn_department)
        Me.Controls.Add(Me.btn_course)
        Me.Controls.Add(Me.btn_studentlist)
        Me.Controls.Add(Me.lbl_welcome)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.lbl_menutitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frm_mainmenu_A168219"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_menutitle As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_welcome As Label
    Friend WithEvents btn_studentlist As Button
    Friend WithEvents btn_course As Button
    Friend WithEvents btn_department As Button
    Friend WithEvents btn_registration As Button
End Class
