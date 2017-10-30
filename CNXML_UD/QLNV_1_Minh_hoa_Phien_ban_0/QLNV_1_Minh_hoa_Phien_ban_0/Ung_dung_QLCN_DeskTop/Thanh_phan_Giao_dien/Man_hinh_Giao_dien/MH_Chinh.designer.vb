<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Chinh
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
        Me.Th_Tieu_de = New System.Windows.Forms.Label()
        Me.Th_Danh_sach_Chuc_nang = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'Th_Tieu_de
        '
        Me.Th_Tieu_de.AutoSize = True
        Me.Th_Tieu_de.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Tieu_de.Location = New System.Drawing.Point(404, 9)
        Me.Th_Tieu_de.Name = "Th_Tieu_de"
        Me.Th_Tieu_de.Size = New System.Drawing.Size(110, 32)
        Me.Th_Tieu_de.TabIndex = 0
        Me.Th_Tieu_de.Text = "Tiêu đề"
        '
        'Th_Danh_sach_Chuc_nang
        '
        Me.Th_Danh_sach_Chuc_nang.AutoScroll = True
        Me.Th_Danh_sach_Chuc_nang.BackColor = System.Drawing.Color.Black
        Me.Th_Danh_sach_Chuc_nang.Location = New System.Drawing.Point(12, 54)
        Me.Th_Danh_sach_Chuc_nang.Name = "Th_Danh_sach_Chuc_nang"
        Me.Th_Danh_sach_Chuc_nang.Size = New System.Drawing.Size(1397, 101)
        Me.Th_Danh_sach_Chuc_nang.TabIndex = 62
        '
        'MH_Chinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1464, 646)
        Me.Controls.Add(Me.Th_Danh_sach_Chuc_nang)
        Me.Controls.Add(Me.Th_Tieu_de)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MH_Chinh"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Th_Tieu_de As Label
    Friend WithEvents Th_Danh_sach_Chuc_nang As FlowLayoutPanel
End Class
