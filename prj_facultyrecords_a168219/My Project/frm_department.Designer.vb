<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_department
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
        Me.lbl_department = New System.Windows.Forms.Label()
        Me.grd_department = New System.Windows.Forms.DataGridView()
        CType(Me.grd_department, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_department
        '
        Me.lbl_department.AutoSize = True
        Me.lbl_department.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_department.Location = New System.Drawing.Point(12, 22)
        Me.lbl_department.Name = "lbl_department"
        Me.lbl_department.Size = New System.Drawing.Size(222, 34)
        Me.lbl_department.TabIndex = 0
        Me.lbl_department.Text = "Department List"
        '
        'grd_department
        '
        Me.grd_department.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_department.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grd_department.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_department.Location = New System.Drawing.Point(18, 60)
        Me.grd_department.Name = "grd_department"
        Me.grd_department.RowTemplate.Height = 24
        Me.grd_department.Size = New System.Drawing.Size(510, 367)
        Me.grd_department.TabIndex = 1
        '
        'frm_department
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 439)
        Me.Controls.Add(Me.grd_department)
        Me.Controls.Add(Me.lbl_department)
        Me.Name = "frm_department"
        Me.Text = "DEpartment List"
        CType(Me.grd_department, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_department As Label
    Friend WithEvents grd_department As DataGridView
End Class
