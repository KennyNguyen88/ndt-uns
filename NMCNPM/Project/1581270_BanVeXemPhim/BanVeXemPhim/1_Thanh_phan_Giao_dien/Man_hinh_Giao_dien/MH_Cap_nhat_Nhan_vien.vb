' Thông báo PET : Các màn hình  Ghi mới, Cập nhật, Xóa nhân viên rất giống nhau 
' Có cách nào chỉ lập trình 1 màn hình chung ?
Public Class MH_Cap_nhat_Nhan_vien

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

    Sub Khoi_dong() ' Trạng thái đầu 
        '1.==== Khởi động dữ liệu 
        Nhan_vien = Nothing ' Chưa chọn 

        '2.===Khởi động thể hiện ===
        '===Tiêu đề 
        Dim Tieu_de As String = "Cập nhật nhân viên "
        Th_Tieu_de.Text = Tieu_de
        '===Thực đơn tỉnh : Hiện nay chưa xem xét 

        '===Thực đơn động :   
        Dim Danh_sach_Ten_Chuc_nang As List(Of String) = New String() {
                                                       "Chọn nhân viên", "Chọn hình", "Kết thúc"}.ToList
        Dim Danh_sach_Ma_so_Chuc_nang As List(Of String) = New String() {
                                                          "CHON_NHAN_VIEN", "CHON_HINH", "KET_THUC"}.ToList
        The_hien.Tao_Thuc_don_dong(Danh_sach_Ten_Chuc_nang, Danh_sach_Ma_so_Chuc_nang,
                                   Th_Nhan_vien, AddressOf XL_Chon_Chuc_nang)
        '=== Thông báo :   
        Dim Thong_bao As String = ""
        Thong_bao &= "Hướng dẩn nhập liệu " & vbCrLf
        Thong_bao &= " - Sử dụng thực đơn động để chọn nhân viên cần cập nhật" & vbCrLf
        Th_Thong_bao.Text = Thong_bao
        '===== Đối tượng liên kết : Danh sách giới tính 
        Th_Danh_sach_Gioi_tinh.AutoSize = True
        'Thông báo PET : Sẽ còn tiếp tục cải tiến trong  phiên bản sau
        Dim Danh_sach_Gioi_tinh As List(Of XL_GIOI_TINH) = Ung_dung.Danh_sach_Gioi_tinh
        Dim Danh_sach_Chuoi_Tom_tat_Gioi_tinh As List(Of String) = Danh_sach_Gioi_tinh.Select(
                                                                            Function(x) x.Tao_Chuoi_Tom_tat).ToList
        Dim Danh_sach_Chuoi_Thong_tin_Gioi_tinh As List(Of String) = Danh_sach_Gioi_tinh.Select(
                                                                            Function(x) x.Tao_Chuoi_Thong_tin).ToList

        The_hien.Xuat_Danh_sach_Chon_Doi_tuong(Danh_sach_Gioi_tinh.Select(Function(x) x.Dong).ToList,
                                                                                            Danh_sach_Chuoi_Tom_tat_Gioi_tinh,
                                                                                            Danh_sach_Chuoi_Thong_tin_Gioi_tinh,
                                                                                            Th_Danh_sach_Gioi_tinh, Nothing)
        '===== Đối tượng liên kết : Danh sách đơn vị
        Th_Danh_sach_Don_vi.Size = New Size(500, 120)
        'Thông báo PET : Sẽ còn tiếp tục cải tiến trong  phiên bản sau
        Dim Danh_sach_Don_vi As List(Of XL_DON_VI) = Ung_dung.Danh_sach_Don_vi
        Dim Danh_sach_Chuoi_Tom_tat_Don_vi As List(Of String) = Danh_sach_Don_vi.Select(
                                                                            Function(x) x.Tao_Chuoi_Tom_tat).ToList
        Dim Danh_sach_Chuoi_Thong_tin_Don_vi As List(Of String) = Danh_sach_Don_vi.Select(
                                                                            Function(x) x.Tao_Chuoi_Thong_tin).ToList

        The_hien.Xuat_Danh_sach_Chon_Doi_tuong(Danh_sach_Don_vi.Select(Function(x) x.Dong).ToList,
                                                                                          Danh_sach_Chuoi_Tom_tat_Don_vi,
                                                                                           Danh_sach_Chuoi_Thong_tin_Don_vi,
                                                                                           Th_Danh_sach_Don_vi, Nothing)


        '===Hồ sơ nhập liệu : Nhân viên
        Th_Nhan_vien.BorderStyle = BorderStyle.FixedSingle
        ' ******** ( Không xuất hồ sơ vì chưa chọn nhân viên) 
        '=== Yêu cầu thực hiện : Đồng ý 
        Th_Dong_y.Visible = False
        AddHandler Th_Dong_y.Click, AddressOf XL_Dong_y
    End Sub


#End Region

#Region "Xử lý Biến cố Chính - Click Đồng ý"
    Sub XL_Dong_y(Th_Dong_y As Control, Bc As EventArgs)
        Dim Chuoi_loi As String = The_hien.Nhap_Ho_so_Nhan_vien(Nhan_vien, Th_Nhan_vien)
        If Chuoi_loi = "" Then
            Thuc_hien_Cap_nhat_Nhan_vien()
        Else
            Dim Thong_bao As String = "Lỗi nhập liệu" & vbCrLf
            Thong_bao &= Chuoi_loi
            Th_Thong_bao.Text = Thong_bao
        End If
    End Sub
    Sub Thuc_hien_Cap_nhat_Nhan_vien()
        Dim Chuoi_loi As String = Nhan_vien.Kiem_tra_Cap_nhat
        If Chuoi_loi = "" Then
            Chuoi_loi = Luu_tru.Ghi(Nhan_vien.Dong, LOAI_GHI.Cap_nhat)
            If Chuoi_loi = "" Then
                Chuoi_loi = Luu_tru.Ghi_Media(Nhan_vien.Dong, LOAI_MEDIA.Hinh, Th_Hinh.Tag)
            End If
        End If
        '===== Xử lý Thông báo & Trạng thái  =====
        If Chuoi_loi = "" Then
            Dim Thong_bao As String = "Đã cập nhật hồ sơ nhân viên" & vbCrLf
            Thong_bao &= Nhan_vien.Tao_Chuoi_Thong_tin
            Thong_bao &= "======" & vbCrLf
            Thong_bao &= "Các tùy chọn của người dùng : " & vbCrLf
            Thong_bao &= "- Nhập liệu lại thông tin của nhân viên này và Click Đồng ý "
            Thong_bao &= "- Chọn nhân viên khácđể cập nhật  với thực đơn động "
            Th_Thong_bao.Text = Thong_bao

        Else
            Dim Thong_bao As String = "Lỗi nhập liệu" & vbCrLf
            Thong_bao &= Chuoi_loi
            Th_Thong_bao.Text = Thong_bao
        End If
    End Sub
#End Region

#Region "Xử lý Biến cố Phụ - Chọn chức năng"
    Sub XL_Chon_Chuc_nang(Th_Chuc_nang As ToolStripItem, Bc As EventArgs)
        Dim Ma_so_Chon As String = Th_Chuc_nang.Tag
        If Ma_so_Chon = "KET_THUC" Then
            Me.Close()
        ElseIf Ma_so_Chon = "CHON_NHAN_VIEN" Then
            Thuc_hien_Chuc_nang_Chon_Nhan_vien()
        ElseIf Ma_so_Chon = "CHON_HINH" Then
            Dim Chuoi_loi As String = The_hien.Chon_Hinh(Th_Hinh)
            Dim Thong_bao As String = Chuoi_loi
            Th_Thong_bao.Text = Thong_bao
        End If
    End Sub
    '==== Thực hiện chức năng con 
    Sub Thuc_hien_Chuc_nang_Chon_Nhan_vien()
        Dim Mh As New MH_Chon_Nhan_vien(Ung_dung)
        Mh.ShowDialog()
        If Mh.Nhan_vien_Chon Is Nothing Then
            '===== Xử lý thông báo
            Dim Thong_bao As String = "Chưa  chọn nhân viên để cập nhật"
            Th_Thong_bao.Text = Thong_bao
        Else
            ' ********* Khởi động  lại với trạng thái mới ***********
            '1 ==== Khởi động dữ liệu
            Nhan_vien = Mh.Nhan_vien_Chon ' Có vấn đề ?
            '2.===Khởi động thể hiện ===
            '===Tiêu đề  : Không thay đổi
            '===Thực đơn tỉnh : Hiện nay chưa xem xét 
            '===Thực đơn động :   Không thay đổi
            '=== Thông báo :   
            Dim Thong_bao As String = "Hướng dẩn nhập liệu " & vbCrLf
            Thong_bao &= " - Sử dụng thực đơn động để chọn hình" & vbCrLf
            Thong_bao &= Nhan_vien.Tao_Chuoi_Thong_bao_Luu_y_Cap_nhat
            Th_Thong_bao.Text = Thong_bao
            '===== Danh sách giới tính : Không thay đổi
            '===== Danh sách đơn vị : Không thay đổi
            '=== Đồng ý 
            Th_Dong_y.Visible = True
            '==== Nhân viên 
            The_hien.Xuat_Ho_so_Nhan_vien(Nhan_vien, Th_Nhan_vien)
        End If
    End Sub
#End Region





End Class