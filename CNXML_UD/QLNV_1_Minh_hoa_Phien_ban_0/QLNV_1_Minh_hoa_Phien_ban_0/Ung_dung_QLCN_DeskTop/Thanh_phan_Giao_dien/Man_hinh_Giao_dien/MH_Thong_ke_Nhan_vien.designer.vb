<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Thong_ke_Nhan_vien
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
        Me.Th_Danh_sach_Don_vi_Thong_ke = New System.Windows.Forms.FlowLayoutPanel()
        Me.Th_Tieu_de = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Th_Danh_sach_Don_vi_Thong_ke
        '
        Me.Th_Danh_sach_Don_vi_Thong_ke.AutoScroll = True
        Me.Th_Danh_sach_Don_vi_Thong_ke.AutoSize = True
        Me.Th_Danh_sach_Don_vi_Thong_ke.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Th_Danh_sach_Don_vi_Thong_ke.Location = New System.Drawing.Point(19, 124)
        Me.Th_Danh_sach_Don_vi_Thong_ke.Name = "Th_Danh_sach_Don_vi_Thong_ke"
        Me.Th_Danh_sach_Don_vi_Thong_ke.Size = New System.Drawing.Size(850, 118)
        Me.Th_Danh_sach_Don_vi_Thong_ke.TabIndex = 61
        '
        'Th_Tieu_de
        '
        Me.Th_Tieu_de.AutoSize = True
        Me.Th_Tieu_de.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Tieu_de.Location = New System.Drawing.Point(362, 43)
        Me.Th_Tieu_de.Name = "Th_Tieu_de"
        Me.Th_Tieu_de.Size = New System.Drawing.Size(264, 32)
        Me.Th_Tieu_de.TabIndex = 0
        Me.Th_Tieu_de.Text = "Minh họa Thống kê "
        '
        'MH_Chinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1464, 646)
        Me.Controls.Add(Me.Th_Danh_sach_Don_vi_Thong_ke)
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
    Friend WithEvents Th_Danh_sach_Don_vi_Thong_ke As FlowLayoutPanel
    Friend WithEvents Th_Tieu_de As Label
End Class
