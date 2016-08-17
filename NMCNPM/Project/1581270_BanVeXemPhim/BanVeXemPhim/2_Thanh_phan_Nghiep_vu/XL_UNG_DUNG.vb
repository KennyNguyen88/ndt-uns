
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


    Public Function Danh_sach_Gioi_tinh() As List(Of XL_GIOI_TINH)
        Dim Kq As New List(Of XL_GIOI_TINH)
        For Each Dong As DataRow In Du_lieu.Tables("GIOI_TINH").Rows
            Dim Gioi_tinh As New XL_GIOI_TINH(Me, Dong)
            Kq.Add(Gioi_tinh)
        Next
        Return Kq
    End Function

    Public Function Danh_sach_Cong_ty() As List(Of XL_CONG_TY)
        Dim Kq As New List(Of XL_CONG_TY)
        For Each Dong As DataRow In Du_lieu.Tables("CONG_TY").Rows
            Dim Cong_ty As New XL_CONG_TY(Me, Dong)
            Kq.Add(Cong_ty)
        Next
        Return Kq
    End Function

    Public Function Danh_sach_Chi_nhanh() As List(Of XL_CHI_NHANH)
        Dim Kq As New List(Of XL_CHI_NHANH)
        For Each Dong As DataRow In Du_lieu.Tables("CHI_NHANH").Rows
            Dim Chi_nhanh As New XL_CHI_NHANH(Me, Dong)
            Kq.Add(Chi_nhanh)
        Next
        Return Kq
    End Function

    Public Function Danh_sach_Don_vi() As List(Of XL_DON_VI)
        Dim Kq As New List(Of XL_DON_VI)
        For Each Dong As DataRow In Du_lieu.Tables("DON_VI").Rows
            Dim Don_vi As New XL_DON_VI(Me, Dong)
            Kq.Add(Don_vi)
        Next
        Return Kq
    End Function

    Public Function Danh_sach_Nhan_vien() As List(Of XL_NHAN_VIEN)
        Dim Kq As New List(Of XL_NHAN_VIEN)
        For Each Dong As DataRow In Du_lieu.Tables("NHAN_VIEN").Rows
            Dim Nhan_vien As New XL_NHAN_VIEN(Me, Dong)
            Kq.Add(Nhan_vien)
        Next
        Return Kq
    End Function


#End Region


#Region "Trích rút Đối tượng"



    Public Function Gioi_tinh(ID As Integer) As XL_GIOI_TINH
        Dim Kq As XL_GIOI_TINH = Danh_sach_Gioi_tinh.FirstOrDefault(Function(x) x.ID = ID)
        Return Kq
    End Function

    Public Function Cong_ty(ID As Integer) As XL_CONG_TY
        Dim Kq As XL_CONG_TY = Danh_sach_Cong_ty.FirstOrDefault(Function(x) x.ID = ID)
        Return Kq
    End Function

    Public Function Chi_nhanh(ID As Integer) As XL_CHI_NHANH
        Dim Kq As XL_CHI_NHANH = Danh_sach_Chi_nhanh.FirstOrDefault(Function(x) x.ID = ID)
        Return Kq
    End Function

    Public Function Don_vi(ID As Integer) As XL_DON_VI
        Dim Kq As XL_DON_VI = Danh_sach_Don_vi.FirstOrDefault(Function(x) x.ID = ID)
        Return Kq
    End Function

    Public Function Nhan_vien(ID As Integer) As XL_NHAN_VIEN
        Dim Kq As XL_NHAN_VIEN = Danh_sach_Nhan_vien.FirstOrDefault(Function(x) x.ID = ID)
        Return Kq
    End Function


#End Region

#Region "Tạo Đối tượng mới"
    Public Function Tao_Gioi_tinh_moi() As XL_GIOI_TINH
        Dim Gioi_tinh As XL_GIOI_TINH
        Dim Dong As DataRow = Du_lieu.Tables("GIOI_TINH").NewRow
        Gioi_tinh = New XL_GIOI_TINH(Me, Dong)
        Gioi_tinh.Ten = "Tên " & Gioi_tinh.ID
        Gioi_tinh.Ma_so = "Mã số " & Gioi_tinh.ID
        Return Gioi_tinh
    End Function

    Public Function Tao_Cong_ty_moi() As XL_CONG_TY ' Dự trù cho tương lai
        Dim Cong_ty As XL_CONG_TY
        Dim Dong As DataRow = Du_lieu.Tables("CONG_TY").NewRow
        Cong_ty = New XL_CONG_TY(Me, Dong)
        Cong_ty.Ten = "Tên " & Cong_ty.ID
        Cong_ty.Dien_thoai = "Điện thoại " & Cong_ty.ID
        Cong_ty.Dia_chi = "Địa chỉ " & Cong_ty.ID
        Cong_ty.Tuoi_toi_thieu = 20
        Cong_ty.Tuoi_toi_da = 50
        Cong_ty.Muc_luong_toi_thieu = 3500000
        Return Cong_ty
    End Function

    Public Function Tao_Chi_nhanh_moi() As XL_CHI_NHANH
        Dim Chi_nhanh As XL_CHI_NHANH
        Dim Dong As DataRow = Du_lieu.Tables("CHI_NHANH").NewRow
        Chi_nhanh = New XL_CHI_NHANH(Me, Dong)
        Chi_nhanh.Ten = "Tên " & Chi_nhanh.ID
        Chi_nhanh.Dien_thoai = "Điện thoại " & Chi_nhanh.ID
        Chi_nhanh.Dia_chi = "Địa chỉ " & Chi_nhanh.ID
        Return Chi_nhanh
    End Function

    Public Function Tao_Don_vi_moi() As XL_DON_VI
        Dim Don_vi As XL_DON_VI
        Dim Dong As DataRow = Du_lieu.Tables("DON_VI").NewRow
        Don_vi = New XL_DON_VI(Me, Dong)
        Don_vi.Ten = "Tên " & Don_vi.ID
        Don_vi.ID_CHI_NHANH = Danh_sach_Chi_nhanh(0).ID
        Return Don_vi
    End Function
    Public Function Tao_Nhan_vien_moi() As XL_NHAN_VIEN
        Dim Nhan_vien As XL_NHAN_VIEN
        Dim Dong As DataRow = Du_lieu.Tables("NHAN_VIEN").NewRow
        Nhan_vien = New XL_NHAN_VIEN(Me, Dong)

        Nhan_vien.Ho_ten = "Họ tên " & Nhan_vien.ID
        Nhan_vien.ID_GIOI_TINH = Danh_sach_Gioi_tinh(0).ID
        Nhan_vien.CMND = "CMND " & Nhan_vien.ID
        Nhan_vien.Ngay_sinh = New DateTime(Today.Year - 30, 1, 1)
        Nhan_vien.Muc_luong = 4000000
        Nhan_vien.Dien_thoai = "Điện thoại " & Nhan_vien.ID
        Nhan_vien.Mail = "Mail " & Nhan_vien.ID
        Nhan_vien.Dia_chi = "Địa chỉ " & Nhan_vien.ID
        Nhan_vien.ID_DON_VI = Danh_sach_Don_vi(0).ID

        Return Nhan_vien
    End Function

#End Region

#Region "Trích rút Danh sách theo thuộc tính"

    '==== Trích rút Danh sách Nhân viên theo các thuộc tính====
    Public Function Danh_sach_Nhan_vien_theo_Ho_ten(Chuoi As String) As List(Of XL_NHAN_VIEN)
        Dim Kq As List(Of XL_NHAN_VIEN) = Danh_sach_Nhan_vien()
        Kq = Kq.FindAll(Function(x) x.Ho_ten.ToUpper.Contains(Chuoi.ToUpper))
        Return Kq
    End Function

    Public Function Danh_sach_Nhan_vien_theo_CMND(Chuoi As String) As List(Of XL_NHAN_VIEN)
        Dim Kq As List(Of XL_NHAN_VIEN) = Danh_sach_Nhan_vien()
        Kq = Kq.FindAll(Function(x) x.CMND.ToUpper.Contains(Chuoi.ToUpper))
        Return Kq
    End Function

    Public Function Danh_sach_Nhan_vien_theo_Ngay_sinh(Can_duoi As DateTime, Can_tren As DateTime) As List(Of XL_NHAN_VIEN)
        Dim Kq As List(Of XL_NHAN_VIEN) = Danh_sach_Nhan_vien()
        Kq = Kq.FindAll(Function(x) x.Ngay_sinh >= Can_duoi And x.Ngay_sinh <= Can_tren)
        Return Kq
    End Function

    Public Function Danh_sach_Nhan_vien_theo_Muc_luong(Can_duoi As Double, Can_tren As Double) As List(Of XL_NHAN_VIEN)
        Dim Kq As List(Of XL_NHAN_VIEN) = Danh_sach_Nhan_vien()
        Kq = Kq.FindAll(Function(x) x.Muc_luong >= Can_duoi And x.Muc_luong <= Can_tren)
        Return Kq
    End Function

    Public Function Danh_sach_Nhan_vien_theo_Dien_thoai(Chuoi As String) As List(Of XL_NHAN_VIEN)
        Dim Kq As List(Of XL_NHAN_VIEN) = Danh_sach_Nhan_vien()
        Kq = Kq.FindAll(Function(x) x.Dien_thoai.ToUpper.Contains(Chuoi.ToUpper))
        Return Kq
    End Function

    Public Function Danh_sach_Nhan_vien_theo_Mail(Chuoi As String) As List(Of XL_NHAN_VIEN)
        Dim Kq As List(Of XL_NHAN_VIEN) = Danh_sach_Nhan_vien()
        Kq = Kq.FindAll(Function(x) x.Mail.ToUpper.Contains(Chuoi.ToUpper))
        Return Kq
    End Function

    Public Function Danh_sach_Nhan_vien_theo_Dia_chi(Chuoi As String) As List(Of XL_NHAN_VIEN)
        Dim Kq As List(Of XL_NHAN_VIEN) = Danh_sach_Nhan_vien()
        Kq = Kq.FindAll(Function(x) x.Dia_chi.ToUpper.Contains(Chuoi.ToUpper))
        Return Kq
    End Function

    Public Function Danh_sach_Nhan_vien_theo_Do_tuoi(Can_duoi As Integer, Can_tren As Integer) As List(Of XL_NHAN_VIEN)
        Dim Kq As List(Of XL_NHAN_VIEN) = Danh_sach_Nhan_vien()
        Kq = Kq.FindAll(Function(x) x.Tuoi >= Can_duoi And x.Tuoi <= Can_tren)
        Return Kq
    End Function


#End Region




End Class
