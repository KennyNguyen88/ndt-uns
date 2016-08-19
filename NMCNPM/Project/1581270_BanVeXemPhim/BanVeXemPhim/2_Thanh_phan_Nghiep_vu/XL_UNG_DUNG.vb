
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
    Public Function Danh_sach_Xuat_Chieu_Theo_Ten_Phim(Chuoi As String) As List(Of XL_XUAT_CHIEU)
        Dim Kq As List(Of XL_XUAT_CHIEU) = Danh_sach_Xuat_Chieu()
        Dim dsPhim As List(Of XL_PHIM) = Danh_sach_Phim_Theo_Ten(Chuoi)
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

    Public Function Danh_sach_Xuat_Chieu_Theo_Ngay(NgayChieu As DateTime) As List(Of XL_XUAT_CHIEU)
        Dim Kq As List(Of XL_XUAT_CHIEU) = Danh_sach_Xuat_Chieu()
        Kq = Kq.FindAll(Function(x) x.Ngay.Equals(NgayChieu))
        Return Kq
    End Function


    '==== Trích rút Danh sách Phim theo các thuộc tính====
    Public Function Danh_sach_Phim_Theo_Ten(Chuoi As String) As List(Of XL_PHIM)
        Dim Kq As List(Of XL_PHIM) = Danh_sach_Phim()
        Kq = Kq.FindAll(Function(x) x.Ten.ToUpper.Contains(Chuoi.ToUpper))
        Return Kq
    End Function

    Public Function Danh_Sach_Phim_Xuat_Chieu_Sau_Ngay(Ngay As DateTime) As List(Of XL_PHIM)
        Dim Kq As List(Of XL_PHIM) = Danh_sach_Phim()
        Kq = Kq.FindAll(Function(x) x.Danh_sach_Xuat_Chieu.FindAll(Function(y) y.Ngay >= Ngay).Count > 0)
        Return Kq
    End Function

    '==== Trích rút Danh sách Phòng theo các thuộc tính====
    Public Function Danh_sach_Phong_Theo_Ten(Chuoi As String) As List(Of XL_PHONG)
        Dim Kq As List(Of XL_PHONG) = Danh_sach_Phong()
        Kq = Kq.FindAll(Function(x) x.Ten.ToUpper.Contains(Chuoi.ToUpper))
        Return Kq
    End Function

    '==== Trích rút Danh sách Ca Chiếu theo các thuộc tính====
    Public Function Danh_sach_Ca_Chieu_Theo_Ten(Chuoi As String) As List(Of XL_CA_CHIEU)
        Dim Kq As List(Of XL_CA_CHIEU) = Danh_sach_Ca_Chieu()
        Kq = Kq.FindAll(Function(x) x.Ten.ToUpper.Contains(Chuoi.ToUpper))
        Return Kq
    End Function

    'TODO trich rut danh sach theo cac thuoc tinh rap chieu phim, loai phong, ve, ghe    

#End Region

End Class
