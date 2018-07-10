<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Tinh_Tuoi_Nhan_Vien
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_HoTen = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_GioiTinh = New System.Windows.Forms.CheckBox()
        Me.dtp_NgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_MucLuong = New System.Windows.Forms.TextBox()
        Me.txt_Tuoi = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(776, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MÀN HÌNH TÍNH TUỔI NHÂN VIÊN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(26, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Họ Tên"
        '
        'txt_HoTen
        '
        Me.txt_HoTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_HoTen.Location = New System.Drawing.Point(140, 17)
        Me.txt_HoTen.Name = "txt_HoTen"
        Me.txt_HoTen.Size = New System.Drawing.Size(466, 26)
        Me.txt_HoTen.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.txt_Tuoi)
        Me.Panel1.Controls.Add(Me.txt_MucLuong)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.dtp_NgaySinh)
        Me.Panel1.Controls.Add(Me.cb_GioiTinh)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_HoTen)
        Me.Panel1.Location = New System.Drawing.Point(81, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(637, 232)
        Me.Panel1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(26, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Giới tính"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(26, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ngày Sinh"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(26, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tuổi"
        '
        'cb_GioiTinh
        '
        Me.cb_GioiTinh.AutoSize = True
        Me.cb_GioiTinh.BackColor = System.Drawing.Color.Transparent
        Me.cb_GioiTinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_GioiTinh.ForeColor = System.Drawing.Color.White
        Me.cb_GioiTinh.Location = New System.Drawing.Point(140, 73)
        Me.cb_GioiTinh.Name = "cb_GioiTinh"
        Me.cb_GioiTinh.Size = New System.Drawing.Size(61, 24)
        Me.cb_GioiTinh.TabIndex = 5
        Me.cb_GioiTinh.Text = "Nam"
        Me.cb_GioiTinh.UseVisualStyleBackColor = False
        '
        'dtp_NgaySinh
        '
        Me.dtp_NgaySinh.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_NgaySinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_NgaySinh.Location = New System.Drawing.Point(140, 127)
        Me.dtp_NgaySinh.Name = "dtp_NgaySinh"
        Me.dtp_NgaySinh.Size = New System.Drawing.Size(200, 26)
        Me.dtp_NgaySinh.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(346, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Mức lương"
        '
        'txt_MucLuong
        '
        Me.txt_MucLuong.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MucLuong.Location = New System.Drawing.Point(434, 127)
        Me.txt_MucLuong.Name = "txt_MucLuong"
        Me.txt_MucLuong.Size = New System.Drawing.Size(172, 26)
        Me.txt_MucLuong.TabIndex = 8
        '
        'txt_Tuoi
        '
        Me.txt_Tuoi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tuoi.Location = New System.Drawing.Point(140, 182)
        Me.txt_Tuoi.Name = "txt_Tuoi"
        Me.txt_Tuoi.ReadOnly = True
        Me.txt_Tuoi.Size = New System.Drawing.Size(94, 26)
        Me.txt_Tuoi.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(344, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 33)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Đồng ý"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MH_Tinh_Tuoi_Nhan_Vien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MH_Tinh_Tuoi_Nhan_Vien"
        Me.Text = "MH_Tinh_Tuoi_Nhan_Vien"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_HoTen As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_Tuoi As TextBox
    Friend WithEvents txt_MucLuong As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtp_NgaySinh As DateTimePicker
    Friend WithEvents cb_GioiTinh As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
