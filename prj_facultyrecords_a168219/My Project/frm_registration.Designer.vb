<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registration
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
        Me.lbl_registration = New System.Windows.Forms.Label()
        Me.grd_registration = New System.Windows.Forms.DataGridView()
        CType(Me.grd_registration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_registration
        '
        Me.lbl_registration.AutoSize = True
        Me.lbl_registration.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_registration.Location = New System.Drawing.Point(12, 9)
        Me.lbl_registration.Name = "lbl_registration"
        Me.lbl_registration.Size = New System.Drawing.Size(218, 34)
        Me.lbl_registration.TabIndex = 0
        Me.lbl_registration.Text = "Registration List"
        '
        'grd_registration
        '
        Me.grd_registration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_registration.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grd_registration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_registration.Location = New System.Drawing.Point(18, 47)
        Me.grd_registration.Name = "grd_registration"
        Me.grd_registration.RowTemplate.Height = 24
        Me.grd_registration.Size = New System.Drawing.Size(489, 386)
        Me.grd_registration.TabIndex = 1
        '
        'frm_registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 445)
        Me.Controls.Add(Me.grd_registration)
        Me.Controls.Add(Me.lbl_registration)
        Me.Name = "frm_registration"
        Me.Text = "Registration List"
        CType(Me.grd_registration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_registration As Label
    Friend WithEvents grd_registration As DataGridView
End Class
