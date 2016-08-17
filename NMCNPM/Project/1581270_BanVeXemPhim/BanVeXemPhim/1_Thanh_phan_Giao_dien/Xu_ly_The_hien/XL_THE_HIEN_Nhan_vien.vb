Partial Public Class XL_THE_HIEN
    ' Hàm xử lý liên quan loại đối tượng NHAN_VIEN 
    '        có thể tái sử dụng trên tất cả các màn hình của ứng dụng  : Rất cần thiết 
    ' Câu hỏi PET : Tại sao lại rất cần thiết ? 

#Region "Danh sách - Biểu tượng"
    ' Lưu ý PET : Đây là hàm tạm thời và sẽ cải tiến trong phiên bản khác 
    ' Câu hỏi PET : Tại sao là hàm tạm thời ? 
    Sub Xuat_Danh_sach_Nhan_vien(Danh_sach_Nhan_vien As List(Of XL_NHAN_VIEN),
                                          Th_Danh_sach_Nhan_vien As FlowLayoutPanel, XL_Chon_Nhan_vien As EventHandler)
        Th_Danh_sach_Nhan_vien.Controls.Clear()
        For Each Nhan_vien As XL_NHAN_VIEN In Danh_sach_Nhan_vien
            '=== Tạo thể hiện : Nhan_vien --> Th_Nhan_vien
            Dim Th_Nhan_vien As New Button
            Th_Danh_sach_Nhan_vien.Controls.Add(Th_Nhan_vien)
            '=== Xuất Tóm tắt

            Th_Nhan_vien.Text = Nhan_vien.Tao_Chuoi_Tom_tat()
            '=== Xuất Thông tin dạng ghi chú 
            Dim Chuoi_Thong_tin As String = Nhan_vien.Tao_Chuoi_Thong_tin()
            Dim Th_Thong_tin As New ToolTip
            Th_Thong_tin.IsBalloon = True
            Th_Thong_tin.SetToolTip(Th_Nhan_vien, Chuoi_Thong_tin)
            '=== Xuất Hình 
            Dim Du_lieu_Hinh As Byte() = Luu_tru.Doc_Media(Nhan_vien.Dong, LOAI_MEDIA.Hinh)
            Dim Luong As New IO.MemoryStream(Du_lieu_Hinh)
            Dim Hinh As Bitmap = Bitmap.FromStream(Luong)
            Th_Nhan_vien.Image = New Bitmap(Hinh, 30, 30)

            '==Định dạng thể hiện 
            Th_Nhan_vien.TextImageRelation = TextImageRelation.ImageAboveText
            Th_Nhan_vien.Size = New Size(220, 85)
            Th_Nhan_vien.Font = New Font("Arial", 14)
            Th_Nhan_vien.BackColor = Color.White
            Th_Nhan_vien.ForeColor = Color.Navy
            '===Chuẩn bị biến cố chọn 
            Th_Nhan_vien.Tag = Nhan_vien
            If XL_Chon_Nhan_vien IsNot Nothing Then
                AddHandler Th_Nhan_vien.Click, XL_Chon_Nhan_vien
            End If
        Next

    End Sub
    Sub Xuat_Danh_sach_Thong_ke_Nhan_vien_theo_Don_vi(Th_Danh_sach_Thong_ke As FlowLayoutPanel, XL_Chon_Don_vi As EventHandler)
        Th_Danh_sach_Thong_ke.Controls.Clear()
        Dim Danh_sach_Don_vi As List(Of XL_DON_VI) = Ung_dung.Danh_sach_Don_vi
        Th_Danh_sach_Thong_ke.FlowDirection = FlowDirection.TopDown

        For Each Don_vi As XL_DON_VI In Danh_sach_Don_vi
            Dim Th_Don_vi As New Label
            Th_Danh_sach_Thong_ke.Controls.Add(Th_Don_vi)
            '=== Xuất Tóm tắt
            Dim Ten As String = Don_vi.Tao_Chuoi_Tom_tat()
            Dim So_luong As Integer = Don_vi.Danh_sach_Nhan_vien.Count
            Dim Tong_so As Integer = Ung_dung.Danh_sach_Nhan_vien().Count
            Dim Ty_le As Double = So_luong * 100 / Tong_so
            Dim Chuoi_Thong_ke As String = String.Format("{0,-15} {1,-10} {2,-5} %", Ten, So_luong.ToString, Math.Round(Ty_le, 2).ToString)
            Th_Don_vi.Text = Chuoi_Thong_ke
            ' Câu hỏi PET : Có nên tạo hàm Tao_Chuoi_Thong_ke của XL_UNG_DUNG ? 
            '=== Xuất Thông tin dạng ghi chú 
            Dim Thong_tin As String = Don_vi.Tao_Chuoi_Tom_tat
            Dim Th_Thong_tin As New ToolTip
            Th_Thong_tin.IsBalloon = True
            Th_Thong_tin.SetToolTip(Th_Don_vi, Thong_tin)
            '=== Xuất Hình 
            Dim Du_lieu_Hinh As Byte() = Luu_tru.Doc_Media(Don_vi.Dong, LOAI_MEDIA.Hinh)
            Dim Luong As New IO.MemoryStream(Du_lieu_Hinh)
            Dim Hinh As Bitmap = Bitmap.FromStream(Luong)
            Th_Don_vi.Image = New Bitmap(Hinh, 30, 30)


            '=== Định dạng thể hiện
            Th_Don_vi.Size = New Size(320, 40)
            Th_Don_vi.Font = New Font("Arial", 14)
            Th_Don_vi.BackColor = Color.Black
            Th_Don_vi.ForeColor = Color.White
            Th_Don_vi.ImageAlign = ContentAlignment.MiddleLeft
            Th_Don_vi.TextAlign = ContentAlignment.MiddleRight
            Th_Don_vi.BorderStyle = BorderStyle.FixedSingle
            '=== Chuẩn bị biến cố chọn
            Th_Don_vi.Tag = Don_vi
            If XL_Chon_Don_vi IsNot Nothing Then
                AddHandler Th_Don_vi.Click, XL_Chon_Don_vi
            End If

        Next
    End Sub
#End Region

#Region "Hồ sơ"
    Public Sub Xuat_Ho_so_Nhan_vien(Nhan_vien As XL_NHAN_VIEN, Th_Nhan_vien As Control)
        Dim Th_Ho_ten As Control = Th_Nhan_vien.Controls("Th_Ho_ten")
        Th_Ho_ten.Text = Nhan_vien.Ho_ten
        Dim Th_Ngay_sinh As Control = Th_Nhan_vien.Controls("Th_Ngay_sinh")
        Th_Ngay_sinh.Text = Nhan_vien.Ngay_sinh
        Dim Th_CMND As Control = Th_Nhan_vien.Controls("Th_CMND")
        Th_CMND.Text = Nhan_vien.CMND
        Dim Th_Muc_luong As Control = Th_Nhan_vien.Controls("Th_Muc_luong")
        Th_Muc_luong.Text = Nhan_vien.Muc_luong
        Dim Th_Dien_thoai As Control = Th_Nhan_vien.Controls("Th_Dien_thoai")
        Th_Dien_thoai.Text = Nhan_vien.Dien_thoai
        Dim Th_Mail As Control = Th_Nhan_vien.Controls("Th_Mail")
        Th_Mail.Text = Nhan_vien.Mail
        Dim Th_Dia_chi As Control = Th_Nhan_vien.Controls("Th_Dia_chi")
        Th_Dia_chi.Text = Nhan_vien.Dia_chi
        Dim Th_Hinh As Control = Th_Nhan_vien.Controls("Th_Hinh")
        Dim Du_lieu_Hinh As Byte() = Luu_tru.Doc_Media(Nhan_vien.Dong, LOAI_MEDIA.Hinh)
        Dim Luong As New IO.MemoryStream(Du_lieu_Hinh)
        Dim Hinh As Bitmap = Bitmap.FromStream(Luong)
        Th_Hinh.BackgroundImage = Hinh
        Th_Hinh.BackgroundImageLayout = ImageLayout.Stretch
        Th_Hinh.Tag = Du_lieu_Hinh
        For Each Th_Gioi_tinh As RadioButton In Th_Nhan_vien.Controls("Th_Danh_sach_Gioi_tinh").Controls
            Dim Gioi_tinh As XL_GIOI_TINH = New XL_GIOI_TINH(Ung_dung, Th_Gioi_tinh.Tag)
            If Gioi_tinh.ID = Nhan_vien.ID_GIOI_TINH Then
                Th_Gioi_tinh.Checked = True
            End If
        Next
        For Each Th_Don_vi As RadioButton In Th_Nhan_vien.Controls("Th_Danh_sach_Don_vi").Controls
            Dim Don_vi As XL_DON_VI = New XL_DON_VI(Ung_dung, Th_Don_vi.Tag)
            If Don_vi.ID = Nhan_vien.ID_DON_VI Then
                Th_Don_vi.Checked = True
            End If
        Next
    End Sub

    Public Function Nhap_Ho_so_Nhan_vien(Nhan_vien As XL_NHAN_VIEN, Th_Nhan_vien As Control) As String
        Dim Kq As String = Kiem_Tra_Nhap_Ho_so_Nhan_vien(Th_Nhan_vien)
        If Kq = "" Then
            Dim Th_Ho_ten As Control = Th_Nhan_vien.Controls("Th_Ho_ten")
            Nhan_vien.Ho_ten = Th_Ho_ten.Text.Trim
            Dim Th_Ngay_sinh As Control = Th_Nhan_vien.Controls("Th_Ngay_sinh")
            Nhan_vien.Ngay_sinh = Th_Ngay_sinh.Text.Trim
            Dim Th_CMND As Control = Th_Nhan_vien.Controls("Th_CMND")
            Nhan_vien.CMND = Th_CMND.Text.Trim
            Dim Th_Muc_luong As Control = Th_Nhan_vien.Controls("Th_Muc_luong")
            Nhan_vien.Muc_luong = Th_Muc_luong.Text.Trim
            Dim Th_Dien_thoai As Control = Th_Nhan_vien.Controls("Th_Dien_thoai")
            Nhan_vien.Dien_thoai = Th_Dien_thoai.Text
            Dim Th_Mail As Control = Th_Nhan_vien.Controls("Th_Mail")
            Nhan_vien.Mail = Th_Mail.Text.Trim
            Dim Th_Dia_chi As Control = Th_Nhan_vien.Controls("Th_Dia_chi")
            Nhan_vien.Dia_chi = Th_Dia_chi.Text.Trim
            For Each Th_Gioi_tinh As RadioButton In Th_Nhan_vien.Controls("Th_Danh_sach_Gioi_tinh").Controls
                Dim Gioi_tinh As XL_GIOI_TINH = New XL_GIOI_TINH(Ung_dung, Th_Gioi_tinh.Tag)
                If Th_Gioi_tinh.Checked Then
                    Nhan_vien.ID_GIOI_TINH = Gioi_tinh.ID
                End If
            Next
            For Each Th_Don_vi As RadioButton In Th_Nhan_vien.Controls("Th_Danh_sach_Don_vi").Controls
                Dim Don_vi As XL_DON_VI = New XL_DON_VI(Ung_dung, Th_Don_vi.Tag)
                If Th_Don_vi.Checked Then
                    Nhan_vien.ID_DON_VI = Don_vi.ID
                End If
            Next
        End If
        Return Kq
    End Function

    Function Kiem_Tra_Nhap_Ho_so_Nhan_vien(Th_Nhan_vien As Control) As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean
        Dim Ngay As Date
        Dim So_nguyen As Integer
        Dim Th_Ngay_sinh As Control = Th_Nhan_vien.Controls("Th_Ngay_sinh")
        Hop_le = DateTime.TryParse(Th_Ngay_sinh.Text.Trim, Ngay)
        If Not Hop_le Then
            Kq &= "Ngày sinh phải có dạng dd/mm/yy " & vbCrLf
        End If
        Dim Th_Muc_luong As Control = Th_Nhan_vien.Controls("Th_Muc_luong")
        Hop_le = Integer.TryParse(Th_Muc_luong.Text.Trim, So_nguyen)
        If Not Hop_le Then
            Kq &= "Mức lương phải là số nguyên " & vbCrLf
        End If
        Return Kq
    End Function
#End Region


End Class
