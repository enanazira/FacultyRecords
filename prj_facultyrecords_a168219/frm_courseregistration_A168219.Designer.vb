<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_courseregistration_A168219
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
        Me.grd_reg = New System.Windows.Forms.DataGridView()
        Me.btn_addline = New System.Windows.Forms.Button()
        Me.grd_newreg = New System.Windows.Forms.DataGridView()
        Me.btn_register = New System.Windows.Forms.Button()
        CType(Me.grd_reg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_newreg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(15, 17)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(269, 33)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Register for Courses"
        '
        'grd_reg
        '
        Me.grd_reg.AllowUserToAddRows = False
        Me.grd_reg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_reg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grd_reg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_reg.Location = New System.Drawing.Point(12, 56)
        Me.grd_reg.Name = "grd_reg"
        Me.grd_reg.Size = New System.Drawing.Size(780, 188)
        Me.grd_reg.TabIndex = 1
        '
        'btn_addline
        '
        Me.btn_addline.Location = New System.Drawing.Point(353, 250)
        Me.btn_addline.Name = "btn_addline"
        Me.btn_addline.Size = New System.Drawing.Size(89, 36)
        Me.btn_addline.TabIndex = 2
        Me.btn_addline.Text = "ADD LINE"
        Me.btn_addline.UseVisualStyleBackColor = True
        '
        'grd_newreg
        '
        Me.grd_newreg.AllowUserToAddRows = False
        Me.grd_newreg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_newreg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grd_newreg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_newreg.Location = New System.Drawing.Point(12, 292)
        Me.grd_newreg.Name = "grd_newreg"
        Me.grd_newreg.Size = New System.Drawing.Size(780, 56)
        Me.grd_newreg.TabIndex = 3
        '
        'btn_register
        '
        Me.btn_register.Location = New System.Drawing.Point(353, 354)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(89, 36)
        Me.btn_register.TabIndex = 4
        Me.btn_register.Text = "REGISTER"
        Me.btn_register.UseVisualStyleBackColor = True
        '
        'frm_courseregistration_A168219
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 397)
        Me.Controls.Add(Me.btn_register)
        Me.Controls.Add(Me.grd_newreg)
        Me.Controls.Add(Me.btn_addline)
        Me.Controls.Add(Me.grd_reg)
        Me.Controls.Add(Me.lbl_title)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_courseregistration_A168219"
        Me.Text = "frm_courseregistration_A168219"
        CType(Me.grd_reg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_newreg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_reg As DataGridView
    Friend WithEvents btn_addline As Button
    Friend WithEvents grd_newreg As DataGridView
    Friend WithEvents btn_register As Button
End Class
