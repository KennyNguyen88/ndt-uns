﻿' Thông báo PET : Các màn hình  Tra cưu nhân viên theo họ tên, mức lương   rất giống nhau 
' Có cách nào chỉ lập trình 1 màn hình chung ?
Public Class MH_Tra_cuu_Nhan_vien_theo_Ho_ten
#Region "Biến/Đối tượng toàn cục"
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
    Protected The_hien As XL_THE_HIEN
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

        '2.===Khởi động thể hiện ===
        ' ==== Màn hình 
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Black
        Me.ForeColor = Color.White
        '===Tiêu đề 
        Dim Tieu_de As String = "Tra cứu nhân viên theo họ tên"
        Th_Tieu_de.Text = Tieu_de
        '===Thực đơn tỉnh : Hiện nay chưa xem xét 

        '===Thực đơn động :  Hiện nay chưa xem xét 

        '=== Thông báo :  
        Dim Thong_bao As String = "Nhập chuỗi họ tên ( không được chứa ' hay "" ) và kết thúc  với Enter" & vbCrLf
        Th_Thong_bao.Text = Thong_bao
        '=== Tiêu chí Tra cứu : Chuỗi Họ tên
        Th_Chuoi_Ho_ten.Text = "Nguyễn"
        AddHandler Th_Chuoi_Ho_ten.KeyDown, AddressOf XL_Nhap_Chuoi_Ho_ten
        '=== Kết quả Tra cứu : Danh sách nhân viên
        Th_Danh_sach_Nhan_vien.Size = New Size(1200, 550)
        Th_Danh_sach_Nhan_vien.AutoScroll = True
    End Sub

#End Region

#Region "Xử lý Biến cố chính - Nhập Chuỗi Họ tên"
    Sub XL_Nhap_Chuoi_Ho_ten(Th_Nhap As TextBox, Bc As KeyEventArgs)
        If Bc.KeyCode = Keys.Enter Then
            Dim Chuoi_loi As String = Kiem_tra_Nhap_Chuoi_Ho_ten()
            If Chuoi_loi = "" Then
                Thuc_hien_Tra_cuu_Nhan_vien_Ho_ten()
            Else
                Dim Thong_bao As String = Chuoi_loi
                Th_Thong_bao.Text = Thong_bao
            End If
        End If
    End Sub
    Sub Thuc_hien_Tra_cuu_Nhan_vien_Ho_ten()
        Dim Dong_ho As New XL_DONG_HO_PET

        Dim Chuoi_Ho_ten As String = Th_Chuoi_Ho_ten.Text.Trim
        Dim Danh_sach_Nhan_vien As List(Of XL_NHAN_VIEN) = Ung_dung.Danh_sach_Nhan_vien_theo_Ho_ten(Chuoi_Ho_ten)
        Dong_ho.Tao_Chuoi_Thoi_gian_do("Xử lý BL :")
        The_hien.Xuat_Danh_sach_Nhan_vien(Danh_sach_Nhan_vien, Th_Danh_sach_Nhan_vien, Nothing)
        Dim Thong_bao As String = "Kêt quả : Tìm thấy " & Danh_sach_Nhan_vien.Count & " nhân viên có họ tên chứa chuỗi  " & Chuoi_Ho_ten
        Th_Thong_bao.Text = Thong_bao
        Th_Thong_bao.Text &= Dong_ho.Tao_Chuoi_Thoi_gian_do("Xử lý VL :")
    End Sub
    Function Kiem_tra_Nhap_Chuoi_Ho_ten() As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean
        Dim Chuoi_Ho_ten As String = Th_Chuoi_Ho_ten.Text.Trim
        Hop_le = Not Chuoi_Ho_ten.Contains("'") And Not Chuoi_Ho_ten.Contains("""")
        If Not Hop_le Then
            Kq &= "Chuỗi nhập không được chứa ' hay """
        End If
        Return Kq
    End Function
#End Region



End Class