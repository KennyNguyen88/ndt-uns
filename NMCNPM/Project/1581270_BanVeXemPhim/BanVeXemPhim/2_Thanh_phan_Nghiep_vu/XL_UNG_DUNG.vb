
Partial Public Class XL_UNG_DUNG
#Region "Biến/Đối tượng toàn cục"
    Public ReadOnly Du_lieu As DataSet
#End Region
#Region "Khởi động"
    Public Sub New(x as DataSet)
        Du_lieu = x
    End Sub
#End Region

#Region "Trích rút Danh sách Đối tượng"

    Public Function Danh_sach_Xuat_Chieu() As List(Of XL_XUAT_CHIEU)
        Dim Kq As New List(Of XL_XUAT_CHIEU)
        For Each Dong As DataRow In Du_lieu.Tables("XUAT_CHIEU").Rows
            Dim Xuat_Chieu As New XL_XUAT_CHIEU(Me, Dong)
            Kq.Add(Xuat_Chieu)
        Next
        Return Kq
    End Function

    Public Function Danh_sach_Phim() As List(Of XL_PHIM)
        Dim Kq As New List(Of XL_PHIM)
        For Each Dong As DataRow In Du_lieu.Tables("PHIM").Rows
            Dim Phim As New XL_PHIM(Me, Dong)
            Kq.Add(Phim)
        Next
        Return Kq
    End Function

    Public Function Danh_sach_Phong() As List(Of XL_PHONG)
        Dim Kq As New List(Of XL_PHONG)
        For Each Dong As DataRow In Du_lieu.Tables("PHONG").Rows
            Dim Phong As New XL_PHONG(Me, Dong)
            Kq.Add(Phong)
        Next
        Return Kq
    End Function

    Public Function Danh_sach_Ca_Chieu() As List(Of XL_CA_CHIEU)
        Dim Kq As New List(Of XL_CA_CHIEU)
        For Each Dong As DataRow In Du_lieu.Tables("CA_CHIEU").Rows
            Dim Ca_Chieu As New XL_CA_CHIEU(Me, Dong)
            Kq.Add(Ca_Chieu)
        Next
        Return Kq
    End Function

    Public Function Danh_sach_Ve() As List(Of XL_VE)
        Dim Kq As New List(Of XL_VE)
        For Each Dong As DataRow In Du_lieu.Tables("VE").Rows
            Dim Ve As New XL_VE(Me, Dong)
            Kq.Add(Ve)
        Next
        Return Kq
    End Function

    Public Function Danh_sach_Ghe() As List(Of XL_GHE)
        Dim Kq As New List(Of XL_GHE)
        For Each Dong As DataRow In Du_lieu.Tables("GHE").Rows
            Dim Ghe As New XL_GHE(Me, Dong)
            Kq.Add(Ghe)
        Next
        Return Kq
    End Function

    Public Function Danh_sach_Loai_Phong() As List(Of XL_LOAI_PHONG)
        Dim Kq As New List(Of XL_LOAI_PHONG)
        For Each Dong As DataRow In Du_lieu.Tables("LOAI_PHONG").Rows
            Dim Loai_Phong As New XL_LOAI_PHONG(Me, Dong)
            Kq.Add(Loai_Phong)
        Next
        Return Kq
    End Function

    Public Function Danh_sach_Rap_Chieu() As List(Of XL_RAP_CHIEU_PHIM)
        Dim Kq As New List(Of XL_RAP_CHIEU_PHIM)
        For Each Dong As DataRow In Du_lieu.Tables("RAP_CHIEU_PHIM").Rows
            Dim Rap_Chieu As New XL_RAP_CHIEU_PHIM(Me, Dong)
            Kq.Add(Rap_Chieu)
        Next
        Return Kq
    End Function
#End Region
#Region "Trích rút Đối tượng theo ID"
    Public Function Xuat_Chieu(ID As Integer) As XL_XUAT_CHIEU
        Dim Kq As XL_XUAT_CHIEU = Danh_sach_Xuat_Chieu.FirstOrDefault(Function(x) x.ID = ID)
        Return Kq
    End Function
    Public Function Phim(ID As Integer) As XL_PHIM
        Dim Kq As XL_PHIM = Danh_sach_Phim.FirstOrDefault(Function(x) x.ID = ID)
        Return Kq
    End Function
    Public Function Phong(ID As Integer) As XL_PHONG
        Dim Kq As XL_PHONG = Danh_sach_Phong.FirstOrDefault(Function(x) x.ID = ID)
        Return Kq
    End Function
    Public Function Ca_Chieu(ID As Integer) As XL_CA_CHIEU
        Dim Kq As XL_CA_CHIEU = Danh_sach_Ca_Chieu.FirstOrDefault(Function(x) x.ID = ID)
        Return Kq
    End Function
    Public Function Ve(ID As Integer) As XL_VE
        Dim Kq As XL_VE = Danh_sach_Ve.FirstOrDefault(Function(x) x.ID = ID)
        Return Kq
    End Function
    Public Function Ghe(ID As Integer) As XL_GHE
        Dim Kq As XL_GHE = Danh_sach_Ghe.FirstOrDefault(Function(x) x.ID = ID)
        Return Kq
    End Function
    Public Function Loai_Phong(ID As Integer) As XL_LOAI_PHONG
        Dim Kq As XL_LOAI_PHONG = Danh_sach_Loai_Phong.FirstOrDefault(Function(x) x.ID = ID)
        Return Kq
    End Function
    Public Function Rap_Chieu(ID As Integer) As XL_RAP_CHIEU_PHIM
        Dim Kq As XL_RAP_CHIEU_PHIM = Danh_sach_Rap_Chieu.FirstOrDefault(Function(x) x.ID = ID)
        Return Kq
    End Function
#End Region

#Region "Tạo Đối tượng mới"

    Public Function Tao_Loai_Phong_Moi() As XL_LOAI_PHONG
        Dim LoaiPhong As XL_LOAI_PHONG
        Dim Dong As DataRow = Du_lieu.Tables("LOAI_PHONG").NewRow
        LoaiPhong = New XL_LOAI_PHONG(Me, Dong)
        Return LoaiPhong
    End Function

    Public Function Tao_Phim_Moi() As XL_PHIM
        Dim Phim As XL_PHIM
        Dim Dong As DataRow = Du_lieu.Tables("PHIM").NewRow
        Phim = New XL_PHIM(Me, Dong)
        Return Phim
    End Function

    Public Function Tao_Ca_Chieu_Moi() As XL_CA_CHIEU
        Dim Ca_Chieu As XL_CA_CHIEU
        Dim Dong As DataRow = Du_lieu.Tables("CA_CHIEU").NewRow
        Ca_Chieu = New XL_CA_CHIEU(Me, Dong)
        Return Ca_Chieu
    End Function

    Public Function Tao_Rap_Moi() As XL_RAP_CHIEU_PHIM
        Dim Rap As XL_RAP_CHIEU_PHIM
        Dim Dong As DataRow = Du_lieu.Tables("RAP_CHIEU_PHIM").NewRow
        Rap = New XL_RAP_CHIEU_PHIM(Me, Dong)
        Return Rap
    End Function

    Public Function Tao_Phong_Moi() As XL_PHONG
        Dim Phong As XL_PHONG
        Dim Dong As DataRow = Du_lieu.Tables("PHONG").NewRow
        Phong = New XL_PHONG(Me, Dong)
        Return Phong
    End Function

    Public Function Tao_Ghe_Moi() As XL_GHE
        Dim Ghe As XL_GHE
        Dim Dong As DataRow = Du_lieu.Tables("GHE").NewRow
        Ghe = New XL_GHE(Me, Dong)
        Return Ghe
    End Function

    Public Function Tao_Suat_Chieu_Moi() As XL_XUAT_CHIEU
        Dim SuatChieu As XL_XUAT_CHIEU
        Dim Dong As DataRow = Du_lieu.Tables("XUAT_CHIEU").NewRow
        SuatChieu = New XL_XUAT_CHIEU(Me, Dong)
        Return SuatChieu
    End Function

    Public Function Tao_Ve_Moi() As XL_VE
        Dim Ve As XL_VE
        Dim Dong As DataRow = Du_lieu.Tables("VE").NewRow
        Ve = New XL_VE(Me, Dong)
        Return Ve
    End Function
    'Public Function Tao_Xuat_Chieu_moi() As XL_XUAT_CHIEU
    '    Dim Xuat_Chieu As XL_XUAT_CHIEU
    '    Dim Dong As DataRow = Du_lieu.Tables("XUAT_CHIEU").NewRow
    '    Xuat_Chieu = New XL_XUAT_CHIEU(Me, Dong)
    '    Xuat_Chieu.ID_PHONG = "Tên " & Gioi_tinh.ID
    '    Gioi_tinh.Ma_so = "Mã số " & Gioi_tinh.ID
    '    Return Gioi_tinh
    'End Function

    'Public Function Tao_Gioi_tinh_moi() As XL_GIOI_TINH
    '    Dim Gioi_tinh As XL_GIOI_TINH
    '    Dim Dong As DataRow = Du_lieu.Tables("GIOI_TINH").NewRow
    '    Gioi_tinh = New XL_GIOI_TINH(Me, Dong)
    '    Gioi_tinh.Ten = "Tên " & Gioi_tinh.ID
    '    Gioi_tinh.Ma_so = "Mã số " & Gioi_tinh.ID
    '    Return Gioi_tinh
    'End Function

    'Public Function Tao_Cong_ty_moi() As XL_CONG_TY ' Dự trù cho tương lai
    '    Dim Cong_ty As XL_CONG_TY
    '    Dim Dong As DataRow = Du_lieu.Tables("CONG_TY").NewRow
    '    Cong_ty = New XL_CONG_TY(Me, Dong)
    '    Cong_ty.Ten = "Tên " & Cong_ty.ID
    '    Cong_ty.Dien_thoai = "Điện thoại " & Cong_ty.ID
    '    Cong_ty.Dia_chi = "Địa chỉ " & Cong_ty.ID
    '    Cong_ty.Tuoi_toi_thieu = 20
    '    Cong_ty.Tuoi_toi_da = 50
    '    Cong_ty.Muc_luong_toi_thieu = 3500000
    '    Return Cong_ty
    'End Function

    'Public Function Tao_Chi_nhanh_moi() As XL_CHI_NHANH
    '    Dim Chi_nhanh As XL_CHI_NHANH
    '    Dim Dong As DataRow = Du_lieu.Tables("CHI_NHANH").NewRow
    '    Chi_nhanh = New XL_CHI_NHANH(Me, Dong)
    '    Chi_nhanh.Ten = "Tên " & Chi_nhanh.ID
    '    Chi_nhanh.Dien_thoai = "Điện thoại " & Chi_nhanh.ID
    '    Chi_nhanh.Dia_chi = "Địa chỉ " & Chi_nhanh.ID
    '    Return Chi_nhanh
    'End Function

    'Public Function Tao_Don_vi_moi() As XL_DON_VI
    '    Dim Don_vi As XL_DON_VI
    '    Dim Dong As DataRow = Du_lieu.Tables("DON_VI").NewRow
    '    Don_vi = New XL_DON_VI(Me, Dong)
    '    Don_vi.Ten = "Tên " & Don_vi.ID
    '    Don_vi.ID_CHI_NHANH = Danh_sach_Chi_nhanh(0).ID
    '    Return Don_vi
    'End Function
    'Public Function Tao_Nhan_vien_moi() As XL_NHAN_VIEN
    '    Dim Nhan_vien As XL_NHAN_VIEN
    '    Dim Dong As DataRow = Du_lieu.Tables("NHAN_VIEN").NewRow
    '    Nhan_vien = New XL_NHAN_VIEN(Me, Dong)

    '    Nhan_vien.Ho_ten = "Họ tên " & Nhan_vien.ID
    '    Nhan_vien.ID_GIOI_TINH = Danh_sach_Gioi_tinh(0).ID
    '    Nhan_vien.CMND = "CMND " & Nhan_vien.ID
    '    Nhan_vien.Ngay_sinh = New DateTime(Today.Year - 30, 1, 1)
    '    Nhan_vien.Muc_luong = 4000000
    '    Nhan_vien.Dien_thoai = "Điện thoại " & Nhan_vien.ID
    '    Nhan_vien.Mail = "Mail " & Nhan_vien.ID
    '    Nhan_vien.Dia_chi = "Địa chỉ " & Nhan_vien.ID
    '    Nhan_vien.ID_DON_VI = Danh_sach_Don_vi(0).ID

    '    Return Nhan_vien
    'End Function

#End Region

#Region "Trích rút Danh sách theo thuộc tính"
    '==== Trích rút Danh sách Xuất Chiếu theo các thuộc tính====
    Public Function Danh_sach_Xuat_Chieu_Theo_Ten_Phim(TenPhim As String) As List(Of XL_XUAT_CHIEU)
        Dim Kq As List(Of XL_XUAT_CHIEU) = Danh_sach_Xuat_Chieu()
        Dim dsPhim As List(Of XL_PHIM) = Danh_sach_Phim_Theo_Ten(TenPhim)
        For Each objPhim In dsPhim
            Kq.AddRange(Kq.FindAll(Function(x) x.ID_PHIM.Equals(objPhim.ID)))
        Next
        Return Kq
    End Function

    Public Function Danh_sach_Xuat_Chieu_Theo_Ten_Phong(Chuoi As String) As List(Of XL_XUAT_CHIEU)
        Dim Kq As List(Of XL_XUAT_CHIEU) = Danh_sach_Xuat_Chieu()
        Dim dsPhong As List(Of XL_PHONG) = Danh_sach_Phong_Theo_Ten(Chuoi)
        For Each objPhong In dsPhong
            Kq.AddRange(Kq.FindAll(Function(x) x.ID_PHIM.Equals(objPhong.ID)))
        Next
        Return Kq
    End Function

    Public Function Danh_sach_Xuat_Chieu_Theo_Ten_Ca_Chieu(Chuoi As String) As List(Of XL_XUAT_CHIEU)
        Dim Kq As List(Of XL_XUAT_CHIEU) = Danh_sach_Xuat_Chieu()
        Dim dsCaChieu As List(Of XL_CA_CHIEU) = Danh_sach_Ca_Chieu_Theo_Ten(Chuoi)
        For Each objCaChieu In dsCaChieu
            Kq.AddRange(Kq.FindAll(Function(x) x.ID_PHIM.Equals(objCaChieu.ID)))
        Next
        Return Kq
    End Function

    Public Function Danh_sach_Xuat_Chieu_Theo_Ngay(NgayChieu As Date) As List(Of XL_XUAT_CHIEU)
        Dim Kq As List(Of XL_XUAT_CHIEU) = Danh_sach_Xuat_Chieu()
        Kq = Kq.FindAll(Function(x) x.Ngay.Equals(NgayChieu))
        Return Kq
    End Function

    Public Function Danh_sach_Xuat_Chieu_Theo_Ngay_From_To(fromDate As Date) As List(Of XL_XUAT_CHIEU)
        Return Danh_sach_Xuat_Chieu_Theo_Ngay_From_To(fromDate, fromDate.AddDays(7))
    End Function

    Public Function Danh_sach_Xuat_Chieu_Theo_Ngay_From_To(fromDate As Date, toDate As Date) As List(Of XL_XUAT_CHIEU)
        Dim Kq As List(Of XL_XUAT_CHIEU) = Danh_sach_Xuat_Chieu()
        Kq = Kq.FindAll(Function(x) x.Ngay >= fromDate.Date And x.Ngay <= toDate.Date)
        Return Kq
    End Function

    Public Function Danh_sach_Xuat_Chieu_Theo_Phim_Ca_Ngay(ID_PHIM As Integer, ID_Ca_Chieu As Integer, Ngay As Date) As List(Of XL_XUAT_CHIEU)
        Dim Kq As List(Of XL_XUAT_CHIEU) = Danh_sach_Xuat_Chieu()
        Kq = Kq.FindAll(Function(x) x.ID_PHIM = ID_PHIM And x.ID_CA_CHIEU = ID_Ca_Chieu And x.Ngay = Ngay)
        Return Kq
    End Function


    '==== Trích rút Danh sách Phim theo các thuộc tính====
    Public Function Danh_sach_Phim_Theo_Ten(Chuoi As String) As List(Of XL_PHIM)
        Dim Kq As List(Of XL_PHIM) = Danh_sach_Phim()
        Kq = Kq.FindAll(Function(x) x.Ten.ToUpper.Contains(Chuoi.ToUpper))
        Return Kq
    End Function

    Public Function Danh_Sach_Phim_Xuat_Chieu_Sau_Ngay(Ngay As Date) As List(Of XL_PHIM)
        Dim Kq As List(Of XL_PHIM) = Danh_sach_Phim()
        Kq = Kq.FindAll(Function(x) x.Danh_sach_Xuat_Chieu.FindAll(Function(y) y.Ngay >= Ngay.Date).Count > 0)
        Return Kq
    End Function

    '==== Trích rút Danh sách Phòng theo các thuộc tính====
    Public Function Danh_sach_Phong_Theo_Ten(Chuoi As String) As List(Of XL_PHONG)
        Dim Kq As List(Of XL_PHONG) = Danh_sach_Phong()
        Kq = Kq.FindAll(Function(x) x.Ten.ToUpper.Contains(Chuoi.ToUpper))
        Return Kq
    End Function

    Public Function Danh_sach_Phong_Theo_Ten_LoaiPhong(ten As String, idLoaiPhong As Integer) As List(Of XL_PHONG)
        Dim Kq As List(Of XL_PHONG) = Danh_sach_Phong()
        Kq = Kq.FindAll(Function(x) x.Ten.ToUpper.Contains(ten.ToUpper) And x.ID_LOAI_PHONG = idLoaiPhong)
        Return Kq
    End Function

    '==== Trích rút Danh sách Ca Chiếu theo các thuộc tính====
    Public Function Danh_sach_Ca_Chieu_Theo_Ten(Chuoi As String) As List(Of XL_CA_CHIEU)
        Dim Kq As List(Of XL_CA_CHIEU) = Danh_sach_Ca_Chieu()
        Kq = Kq.FindAll(Function(x) x.Ten.ToUpper.Contains(Chuoi.ToUpper))
        Return Kq
    End Function

    Public Function Danh_sach_Ca_Chieu_Theo_Ten_Buoi(Ten As String, Buoi As String) As List(Of XL_CA_CHIEU)
        Dim Kq As List(Of XL_CA_CHIEU) = Danh_sach_Ca_Chieu()
        Kq = Kq.FindAll(Function(x) x.Ten.ToUpper.Contains(Ten.ToUpper) And x.Buoi.Equals(Buoi))
        Return Kq
    End Function

    '==== Trích rút Danh sách Loại Phòng theo các thuộc tính====
    Public Function Danh_sach_Loai_Phong_Theo_Ten(Chuoi As String) As List(Of XL_LOAI_PHONG)
        Dim kq As List(Of XL_LOAI_PHONG) = Danh_sach_Loai_Phong()
        kq = kq.FindAll(Function(x) x.Ten.ToUpper.Contains(Chuoi.ToUpper))
        Return kq
    End Function

    '==== Trích rút Danh sách Rạp chiếu theo các thuộc tính====
    Public Function Danh_sach_Rap_Theo_Ten_DienThoai_DiaChi(ten As String, dienthoai As String, diachi As String) As List(Of XL_RAP_CHIEU_PHIM)
        Dim kq As List(Of XL_RAP_CHIEU_PHIM) = Danh_sach_Rap_Chieu()
        kq = kq.FindAll(Function(x) x.Ten.ToUpper.Contains(ten.ToUpper) And x.Dien_Thoai.ToUpper.Contains(dienthoai.ToUpper) And x.Dia_Chi.ToUpper.Contains(diachi.ToUpper))
        Return kq
    End Function

    '==== Trích rút Danh sách Ghế theo các thuộc tính====
    Public Function Danh_sach_Ghe_Theo_Ten_Phong(ten As String, phong As Integer) As List(Of XL_GHE)
        Dim kq As List(Of XL_GHE) = Danh_sach_Ghe()
        kq = kq.FindAll(Function(x) x.Ten.ToUpper.Contains(ten.ToUpper) And x.ID_PHONG = phong)
        Return kq
    End Function


    'TODO trich rut danh sach theo cac thuoc tinh rap chieu phim, loai phong, ve, ghe



#End Region
End Class
