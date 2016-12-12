<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Minh_hoa
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
        Me.Th_Ho_ten = New System.Windows.Forms.TextBox()
        Me.Th_Danh_sach_Nhan_vien = New System.Windows.Forms.FlowLayoutPanel()
        Me.Ghi_chu_Ten_Dang_nhap = New System.Windows.Forms.Label()
        Me.Th_Nguoi_dung = New System.Windows.Forms.Label()
        Me.Th_Thong_bao_PET = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Th_Ho_ten
        '
        Me.Th_Ho_ten.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Ho_ten.Location = New System.Drawing.Point(115, 94)
        Me.Th_Ho_ten.Name = "Th_Ho_ten"
        Me.Th_Ho_ten.Size = New System.Drawing.Size(235, 30)
        Me.Th_Ho_ten.TabIndex = 56
        Me.Th_Ho_ten.Text = "Nguyễn"
        '
        'Th_Danh_sach_Nhan_vien
        '
        Me.Th_Danh_sach_Nhan_vien.AutoScroll = True
        Me.Th_Danh_sach_Nhan_vien.BackColor = System.Drawing.Color.Black
        Me.Th_Danh_sach_Nhan_vien.ForeColor = System.Drawing.Color.Navy
        Me.Th_Danh_sach_Nhan_vien.Location = New System.Drawing.Point(22, 139)
        Me.Th_Danh_sach_Nhan_vien.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Th_Danh_sach_Nhan_vien.Name = "Th_Danh_sach_Nhan_vien"
        Me.Th_Danh_sach_Nhan_vien.Size = New System.Drawing.Size(696, 556)
        Me.Th_Danh_sach_Nhan_vien.TabIndex = 59
        Me.Th_Danh_sach_Nhan_vien.Tag = "50,40"
        '
        'Ghi_chu_Ten_Dang_nhap
        '
        Me.Ghi_chu_Ten_Dang_nhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ghi_chu_Ten_Dang_nhap.ForeColor = System.Drawing.Color.Yellow
        Me.Ghi_chu_Ten_Dang_nhap.Location = New System.Drawing.Point(17, 91)
        Me.Ghi_chu_Ten_Dang_nhap.Name = "Ghi_chu_Ten_Dang_nhap"
        Me.Ghi_chu_Ten_Dang_nhap.Padding = New System.Windows.Forms.Padding(5)
        Me.Ghi_chu_Ten_Dang_nhap.Size = New System.Drawing.Size(105, 33)
        Me.Ghi_chu_Ten_Dang_nhap.TabIndex = 55
        Me.Ghi_chu_Ten_Dang_nhap.Text = "Họ tên"
        Me.Ghi_chu_Ten_Dang_nhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Th_Nguoi_dung
        '
        Me.Th_Nguoi_dung.AutoSize = True
        Me.Th_Nguoi_dung.BackColor = System.Drawing.Color.Black
        Me.Th_Nguoi_dung.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Nguoi_dung.ForeColor = System.Drawing.Color.Yellow
        Me.Th_Nguoi_dung.Location = New System.Drawing.Point(110, 39)
        Me.Th_Nguoi_dung.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Th_Nguoi_dung.Name = "Th_Nguoi_dung"
        Me.Th_Nguoi_dung.Size = New System.Drawing.Size(670, 29)
        Me.Th_Nguoi_dung.TabIndex = 58
        Me.Th_Nguoi_dung.Text = "Hệ khách DeskTop XDO  - Minh họa theo Công nghệ PET 2.5"
        Me.Th_Nguoi_dung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Th_Thong_bao_PET
        '
        Me.Th_Thong_bao_PET.AutoSize = True
        Me.Th_Thong_bao_PET.BackColor = System.Drawing.Color.Black
        Me.Th_Thong_bao_PET.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Thong_bao_PET.ForeColor = System.Drawing.Color.White
        Me.Th_Thong_bao_PET.Location = New System.Drawing.Point(744, 97)
        Me.Th_Thong_bao_PET.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Th_Thong_bao_PET.Name = "Th_Thong_bao_PET"
        Me.Th_Thong_bao_PET.Size = New System.Drawing.Size(151, 25)
        Me.Th_Thong_bao_PET.TabIndex = 57
        Me.Th_Thong_bao_PET.Text = "Thông báo PET"
        '
        'MH_Minh_hoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1197, 449)
        Me.Controls.Add(Me.Th_Ho_ten)
        Me.Controls.Add(Me.Th_Danh_sach_Nhan_vien)
        Me.Controls.Add(Me.Ghi_chu_Ten_Dang_nhap)
        Me.Controls.Add(Me.Th_Nguoi_dung)
        Me.Controls.Add(Me.Th_Thong_bao_PET)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MH_Minh_hoa"
        Me.Text = "MH_Minh_hoa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Th_Ho_ten As TextBox
    Friend WithEvents Th_Danh_sach_Nhan_vien As FlowLayoutPanel
    Friend WithEvents Ghi_chu_Ten_Dang_nhap As Label
    Friend WithEvents Th_Nguoi_dung As Label
    Friend WithEvents Th_Thong_bao_PET As Label
End Class
