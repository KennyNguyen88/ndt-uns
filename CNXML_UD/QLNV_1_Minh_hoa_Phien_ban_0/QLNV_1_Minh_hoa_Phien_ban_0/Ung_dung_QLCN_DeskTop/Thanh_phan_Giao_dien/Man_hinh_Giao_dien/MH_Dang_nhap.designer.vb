<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MH_Dang_nhap
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
        Me.Th_Ho_so = New System.Windows.Forms.Panel()
        Me.Th_Mat_khau = New System.Windows.Forms.TextBox()
        Me.Th_Ten_Dang_nhap = New System.Windows.Forms.TextBox()
        Me.Ghi_chu_Mat_khau = New System.Windows.Forms.Label()
        Me.Ghi_chu_Ten_Dang_nhap = New System.Windows.Forms.Label()
        Me.Th_Tieu_de = New System.Windows.Forms.Label()
        Me.Th_Yeu_cau_Dang_nhap = New System.Windows.Forms.Button()
        Me.Th_Thong_bao = New System.Windows.Forms.Label()
        Me.Th_Thong_bao_PET = New System.Windows.Forms.Label()
        Me.Th_Ho_so.SuspendLayout()
        Me.SuspendLayout()
        '
        'Th_Ho_so
        '
        Me.Th_Ho_so.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Th_Ho_so.Controls.Add(Me.Th_Mat_khau)
        Me.Th_Ho_so.Controls.Add(Me.Th_Ten_Dang_nhap)
        Me.Th_Ho_so.Controls.Add(Me.Ghi_chu_Mat_khau)
        Me.Th_Ho_so.Controls.Add(Me.Ghi_chu_Ten_Dang_nhap)
        Me.Th_Ho_so.Location = New System.Drawing.Point(18, 85)
        Me.Th_Ho_so.Margin = New System.Windows.Forms.Padding(5)
        Me.Th_Ho_so.Name = "Th_Ho_so"
        Me.Th_Ho_so.Size = New System.Drawing.Size(571, 122)
        Me.Th_Ho_so.TabIndex = 5
        '
        'Th_Mat_khau
        '
        Me.Th_Mat_khau.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Mat_khau.Location = New System.Drawing.Point(248, 69)
        Me.Th_Mat_khau.Name = "Th_Mat_khau"
        Me.Th_Mat_khau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Th_Mat_khau.Size = New System.Drawing.Size(249, 40)
        Me.Th_Mat_khau.TabIndex = 5
        Me.Th_Mat_khau.Text = "QLCN_1"
        '
        'Th_Ten_Dang_nhap
        '
        Me.Th_Ten_Dang_nhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Ten_Dang_nhap.Location = New System.Drawing.Point(248, 15)
        Me.Th_Ten_Dang_nhap.Name = "Th_Ten_Dang_nhap"
        Me.Th_Ten_Dang_nhap.Size = New System.Drawing.Size(249, 40)
        Me.Th_Ten_Dang_nhap.TabIndex = 4
        Me.Th_Ten_Dang_nhap.Text = "QLCN_1"
        '
        'Ghi_chu_Mat_khau
        '
        Me.Ghi_chu_Mat_khau.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ghi_chu_Mat_khau.ForeColor = System.Drawing.Color.Yellow
        Me.Ghi_chu_Mat_khau.Location = New System.Drawing.Point(3, 66)
        Me.Ghi_chu_Mat_khau.Name = "Ghi_chu_Mat_khau"
        Me.Ghi_chu_Mat_khau.Padding = New System.Windows.Forms.Padding(5)
        Me.Ghi_chu_Mat_khau.Size = New System.Drawing.Size(162, 48)
        Me.Ghi_chu_Mat_khau.TabIndex = 3
        Me.Ghi_chu_Mat_khau.Text = "Mật khẩu"
        '
        'Ghi_chu_Ten_Dang_nhap
        '
        Me.Ghi_chu_Ten_Dang_nhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ghi_chu_Ten_Dang_nhap.ForeColor = System.Drawing.Color.Yellow
        Me.Ghi_chu_Ten_Dang_nhap.Location = New System.Drawing.Point(3, 15)
        Me.Ghi_chu_Ten_Dang_nhap.Name = "Ghi_chu_Ten_Dang_nhap"
        Me.Ghi_chu_Ten_Dang_nhap.Padding = New System.Windows.Forms.Padding(5)
        Me.Ghi_chu_Ten_Dang_nhap.Size = New System.Drawing.Size(225, 51)
        Me.Ghi_chu_Ten_Dang_nhap.TabIndex = 2
        Me.Ghi_chu_Ten_Dang_nhap.Text = "Tên đăng nhập"
        '
        'Th_Tieu_de
        '
        Me.Th_Tieu_de.AutoSize = True
        Me.Th_Tieu_de.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Tieu_de.Location = New System.Drawing.Point(228, 23)
        Me.Th_Tieu_de.Name = "Th_Tieu_de"
        Me.Th_Tieu_de.Padding = New System.Windows.Forms.Padding(5)
        Me.Th_Tieu_de.Size = New System.Drawing.Size(185, 47)
        Me.Th_Tieu_de.TabIndex = 4
        Me.Th_Tieu_de.Text = "Đăng nhập"
        '
        'Th_Yeu_cau_Dang_nhap
        '
        Me.Th_Yeu_cau_Dang_nhap.BackColor = System.Drawing.Color.Red
        Me.Th_Yeu_cau_Dang_nhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Yeu_cau_Dang_nhap.Location = New System.Drawing.Point(219, 227)
        Me.Th_Yeu_cau_Dang_nhap.Name = "Th_Yeu_cau_Dang_nhap"
        Me.Th_Yeu_cau_Dang_nhap.Size = New System.Drawing.Size(141, 52)
        Me.Th_Yeu_cau_Dang_nhap.TabIndex = 7
        Me.Th_Yeu_cau_Dang_nhap.Text = "Đồng ý"
        Me.Th_Yeu_cau_Dang_nhap.UseVisualStyleBackColor = False
        '
        'Th_Thong_bao
        '
        Me.Th_Thong_bao.AutoSize = True
        Me.Th_Thong_bao.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Thong_bao.Location = New System.Drawing.Point(597, 85)
        Me.Th_Thong_bao.Name = "Th_Thong_bao"
        Me.Th_Thong_bao.Padding = New System.Windows.Forms.Padding(5)
        Me.Th_Thong_bao.Size = New System.Drawing.Size(168, 42)
        Me.Th_Thong_bao.TabIndex = 6
        Me.Th_Thong_bao.Text = " Thông báo"
        '
        'Th_Thong_bao_PET
        '
        Me.Th_Thong_bao_PET.AutoSize = True
        Me.Th_Thong_bao_PET.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Th_Thong_bao_PET.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Thong_bao_PET.Location = New System.Drawing.Point(23, 324)
        Me.Th_Thong_bao_PET.Name = "Th_Thong_bao_PET"
        Me.Th_Thong_bao_PET.Padding = New System.Windows.Forms.Padding(5)
        Me.Th_Thong_bao_PET.Size = New System.Drawing.Size(232, 44)
        Me.Th_Thong_bao_PET.TabIndex = 8
        Me.Th_Thong_bao_PET.Text = " Thông báo PET"
        '
        'MH_Dang_nhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1360, 652)
        Me.Controls.Add(Me.Th_Thong_bao_PET)
        Me.Controls.Add(Me.Th_Yeu_cau_Dang_nhap)
        Me.Controls.Add(Me.Th_Ho_so)
        Me.Controls.Add(Me.Th_Tieu_de)
        Me.Controls.Add(Me.Th_Thong_bao)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MH_Dang_nhap"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Th_Ho_so.ResumeLayout(False)
        Me.Th_Ho_so.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Th_Ho_so As Panel
    Friend WithEvents Th_Mat_khau As TextBox
    Friend WithEvents Th_Ten_Dang_nhap As TextBox
    Friend WithEvents Ghi_chu_Mat_khau As Label
    Friend WithEvents Ghi_chu_Ten_Dang_nhap As Label
    Friend WithEvents Th_Tieu_de As Label
    Friend WithEvents Th_Yeu_cau_Dang_nhap As Button
    Friend WithEvents Th_Thong_bao As Label
    Friend WithEvents Th_Thong_bao_PET As Label
End Class
