<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_splashscreen_A168219
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
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(49, 156)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(203, 17)
        Me.lbl_name.TabIndex = 0
        Me.lbl_name.Text = "Please enter your name below:"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(52, 196)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(329, 22)
        Me.txt_name.TabIndex = 1
        Me.txt_name.Text = "Aina"
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(166, 267)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(75, 23)
        Me.btn_start.TabIndex = 2
        Me.btn_start.Text = "START"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Blue
        Me.lbl_title.Location = New System.Drawing.Point(12, 96)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(387, 43)
        Me.lbl_title.TabIndex = 3
        Me.lbl_title.Text = "UKM Faculty Records"
        '
        'frm_splashscreen_A168219
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(427, 361)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lbl_name)
        Me.Name = "frm_splashscreen_A168219"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UKM Faculty Record"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_name As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents btn_start As Button
    Friend WithEvents lbl_title As Label
End Class
