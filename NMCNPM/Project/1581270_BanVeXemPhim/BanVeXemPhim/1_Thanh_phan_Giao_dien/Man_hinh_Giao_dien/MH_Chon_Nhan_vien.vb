﻿Public Class MH_Chon_Nhan_vien
    ' Thông báo PET : Các màn hình Chọn , Tra cưu nhân viên theo đơn vị  rất giống nhau 
    ' Có cách nào chỉ lập trình 1 màn hình chung ?
#Region "Biến/Đối tượng toàn cục"
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
    Protected The_hien As XL_THE_HIEN

    Protected Nhan_vien As XL_NHAN_VIEN
#End Region

#Region "Xử lý Biến cố Khởi động"
    Public Sub New(Ung_dung As XL_UNG_DUNG)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Luu_tru = New XL_LUU_TRU
        Me.Ung_dung = Ung_dung
        The_hien = New XL_THE_HIEN(Ung_dung)
        Khoi_dong()

    End Sub

    Sub Khoi_dong()
        '1.==== Khởi động dữ liệu :  
        Nhan_vien = Nothing

        '2.===Khởi động thể hiện ===
        ' ==== Màn hình 
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Black
        Me.ForeColor = Color.White
        '===Tiêu đề 
        Dim Tieu_de As String = "Chọn nhân viên theo đơn vị"
        Th_Tieu_de.Text = Tieu_de
        '===Thực đơn tỉnh : Hiện nay chưa xem xét 

        '===Thực đơn động :  Hiện nay chưa xem xét 

        '=== Thông báo :   
        Dim Thong_bao As String = "Click Đơn vị để xem danh sách nhân viên" & "  -  "
        Thong_bao &= "Click Nhân viên để kết thúc việc chọn "
        Th_Thong_bao.Text = Thong_bao
        '=== Tiêu chí Tra cứu : Danh sách đơn vị 
        Th_Danh_sach_Don_vi.AutoSize = True
        'Thông báo PET : Sẽ còn tiếp tục cải tiến trong phiên bản sauL
        Dim Danh_sach_Don_vi As List(Of XL_DON_VI) = Ung_dung.Danh_sach_Don_vi
        Dim Danh_sach_Chuoi_Tom_tat_Don_vi As List(Of String) = Danh_sach_Don_vi.Select(
                                                                            Function(x) x.Tao_Chuoi_Tom_tat).ToList
        Dim Danh_sach_Chuoi_Thong_tin_Don_vi As List(Of String) = Danh_sach_Don_vi.Select(
                                                                            Function(x) x.Tao_Chuoi_Thong_tin).ToList

        The_hien.Xuat_Danh_sach_Doi_tuong(Danh_sach_Don_vi.Select(Function(x) x.Dong).ToList,
                                                                                          Danh_sach_Chuoi_Tom_tat_Don_vi,
                                                                                           Danh_sach_Chuoi_Thong_tin_Don_vi,
                                                                                           Th_Danh_sach_Don_vi, AddressOf XL_Chon_Don_vi)
        '=== Kết quả Tra cứu: Danh_sách nhân viên
        Th_Danh_sach_Nhan_vien.Size = New Size(1200, 550)
        Th_Danh_sach_Nhan_vien.AutoScroll = True

    End Sub

#End Region


#Region "Xử lý Biến cố Chính - Chọn Đơn vị  "
    Sub XL_Chon_Don_vi(Th_Don_vi As Control, Bc As EventArgs)
        Dim Chuoi_loi As String = Kiem_tra_Chon_Don_vi()
        If Chuoi_loi = "" Then
            Thuc_hien_Tra_cuu_Nhan_vien_Don_vi(Th_Don_vi)
        Else
            Dim Thong_bao As String = Chuoi_loi
            Th_Thong_bao.Text = Chuoi_loi
        End If

    End Sub
    Function Kiem_tra_Chon_Don_vi() As String
        Dim Kq As String = ""
        Return Kq
    End Function
    Sub Thuc_hien_Tra_cuu_Nhan_vien_Don_vi(Th_Don_vi As Control)
        '=== Nhập liệu : Xác định Đối tượng được chọn 
        Dim Don_vi_Chon As XL_DON_VI = New XL_DON_VI(Ung_dung, Th_Don_vi.Tag)
        '=== Xử lý : Tạo Kêt quả  dựa  ( Sử dụng đối tượng Nghiep_vu  )
        Dim Danh_sach_Nhan_vien As List(Of XL_NHAN_VIEN) = Don_vi_Chon.Danh_sach_Nhan_vien()
        '===Kết xuất : Xuất  Kết quả cùng với Thông báo  ( Sử dụng đối tượng The_hien )
        The_hien.Xuat_Danh_sach_Nhan_vien(Danh_sach_Nhan_vien, Th_Danh_sach_Nhan_vien, AddressOf XL_Chon_Nhan_vien)
        ''=== Xử lý thông báo =================
        Dim Thong_bao As String = "Kêt quả : Tìm thấy " & Danh_sach_Nhan_vien.Count & " nhân viên của " &
                                                Don_vi_Chon.Tao_Chuoi_Tom_tat
        Th_Thong_bao.Text = Thong_bao
    End Sub

#End Region

#Region "Xử lý Biến cố phụ - Chọn nhân viên "
    Sub XL_Chon_Nhan_vien(Th_Nhan_vien As Control, Bc As EventArgs)
        Nhan_vien = Th_Nhan_vien.Tag
        Me.Close()
    End Sub

#End Region
#Region "Xử lý Trả kết quả - Nhân viên được chọn "
    Public Function Nhan_vien_Chon() As XL_NHAN_VIEN
        Dim Kq As XL_NHAN_VIEN = Nhan_vien
        Return Kq
    End Function

#End Region
End Class