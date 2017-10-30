Partial Public Class XL_NGHIEP_VU
#Region "Xử lý Trích rút"

#Region "CONG_TY(ID,Ten,Dien_thoai,Mail,Dia_chi, Muc_luong_Toi_thieu,Tuoi_Toi_thieu,Tuoi_Toi_da)"
    Public Function Danh_sach_Cong_ty(Du_lieu As DataSet) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Du_lieu.Tables("CONG_TY").Select.ToList
        Return Kq
    End Function
    Public Function Trich_rut_Cong_ty_theo_ID(Du_lieu As DataSet, ID As Integer) As DataRow
        Dim Kq As DataRow = Danh_sach_Cong_ty(Du_lieu).FirstOrDefault(Function(x) x("ID") = ID)
        Return Kq
    End Function

#End Region

#Region "CHI_NHANH(ID,Ten,Dien_thoai,Mail,Dia_chi,ID_CONG_TY)"
    Public Function Danh_sach_Chi_nhanh(Du_lieu As DataSet) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Du_lieu.Tables("CHI_NHANH").Select.ToList
        Return Kq
    End Function
    Public Function Trich_rut_Chi_nhanh_theo_ID(Du_lieu As DataSet, ID As Integer) As DataRow
        Dim Kq As DataRow
        Kq = Danh_sach_Chi_nhanh(Du_lieu).FirstOrDefault(Function(x) x("ID") = ID)
        Return Kq
    End Function
    Public Function Trich_rut_Danh_sach_Chi_nhanh_theo_ID_CONG_TY(Du_lieu As DataSet, ID_CONG_TY As Integer) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Danh_sach_Chi_nhanh(Du_lieu)
        Kq = Kq.FindAll(Function(x) x("ID_CONG_TY") = ID_CONG_TY)
        Return Kq
    End Function
#End Region

#Region "DON_VI(ID,Ten,ID_CHI_NHANH"
    Public Function Danh_sach_Don_vi(Du_lieu As DataSet) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Du_lieu.Tables("DON_VI").Select.ToList
        Return Kq
    End Function
    Public Function Trich_rut_Don_vi_theo_ID(Du_lieu As DataSet, ID As Integer) As DataRow
        Dim Kq As DataRow
        Kq = Danh_sach_Don_vi(Du_lieu).FirstOrDefault(Function(x) x("ID") = ID)
        Return Kq
    End Function
    Public Function Trich_rut_Danh_sach_Don_vi_theo_ID_CHI_NHANH(Du_lieu As DataSet, ID_CHI_NHANH As Integer) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Danh_sach_Don_vi(Du_lieu)
        Kq = Kq.FindAll(Function(x) x("ID_CHI_NHANH") = ID_CHI_NHANH)
        Return Kq
    End Function
#End Region

#Region "NHAN_VIEN(ID,Ho_ten,CMND,Ngay_sinh,Muc_luong,Dien_thoai,Mail,Dia_chi,ID_GIOI_TINH,ID_DON_VI)"
    Public Function Danh_sach_Nhan_vien(Du_lieu As DataSet) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Du_lieu.Tables("NHAN_VIEN").Select.ToList
        Return Kq
    End Function
    Public Function Trich_rut_Nhan_vien_theo_ID(Du_lieu As DataSet, ID As Integer) As DataRow
        Dim Kq As DataRow
        Kq = Danh_sach_Nhan_vien(Du_lieu).FirstOrDefault(Function(x) x("ID") = ID)
        Return Kq
    End Function
    Public Function Trich_rut_Danh_sach_Nhan_vien_theo_ID_DON_VI(Du_lieu As DataSet, ID_DON_VI As Integer) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Danh_sach_Nhan_vien(Du_lieu)
        Kq = Kq.FindAll(Function(x) x("ID_DON_VI") = ID_DON_VI)
        Return Kq
    End Function
    Public Function Trich_rut_Danh_sach_Nhan_vien_theo_ID_GIOI_TINH(Du_lieu As DataSet, ID_GIOI_TINH As Integer) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Danh_sach_Nhan_vien(Du_lieu)
        Kq = Kq.FindAll(Function(x) x("ID_GIOI_TINH") = ID_GIOI_TINH)
        Return Kq
    End Function
    Public Function Trich_rut_Danh_sach_Nhan_vien_theo_Ho_ten(Du_lieu As DataSet, Chuoi_Ho_ten As String) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Danh_sach_Nhan_vien(Du_lieu)
        Kq = Kq.FindAll(Function(x) x("Ho_ten").ToString.ToUpper.Contains(Chuoi_Ho_ten.ToUpper))
        Return Kq
    End Function
    Public Function Trich_rut_Danh_sach_Nhan_vien_theo_Muc_luong(Du_lieu As DataSet,
                                                                 Can_duoi As Double, Can_tren As Double) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Danh_sach_Nhan_vien(Du_lieu)
        Kq = Kq.FindAll(Function(x) x("Muc_luong") >= Can_duoi AndAlso x("Muc_luong") <= Can_tren)
        Return Kq
    End Function
#End Region

#Region "GIOI_TINH(ID,Ten,Ma_so)"
    Public Function Danh_sach_Gioi_tinh(Du_lieu As DataSet) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Du_lieu.Tables("GIOI_TINH").Select.ToList
        Return Kq
    End Function
    Public Function Trich_rut_Gioi_tinh_theo_ID(Du_lieu As DataSet, ID As Integer) As DataRow
        Dim Kq As DataRow = Danh_sach_Gioi_tinh(Du_lieu).FirstOrDefault(Function(x) x("ID") = ID)
        Return Kq
    End Function

#End Region


#Region "QLCT(ID,Ten_Dang_nhap,Mat_khau,ID_CONG_TY)"
    Public Function Danh_sach_QLCT(Du_lieu As DataSet) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Du_lieu.Tables("QLCT").Select.ToList
        Return Kq
    End Function
    Public Function Trich_rut_QLCT_theo_ID(Du_lieu As DataSet, ID As Integer) As DataRow
        Dim Kq As DataRow = Danh_sach_QLCT(Du_lieu).FirstOrDefault(Function(x) x("ID") = ID)
        Return Kq
    End Function
    Public Function Trich_rut_Danh_sach_QLCT_theo_ID_CONG_TY(Du_lieu As DataSet, ID_CONG_TY As Integer) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Danh_sach_Nhan_vien(Du_lieu)
        Kq = Kq.FindAll(Function(x) x("ID_CONG_TY") = ID_CONG_TY)
        Return Kq
    End Function
    Public Function Trich_rut_QLCT_khi_Dang_nhap(Du_lieu As DataSet,
                                                 Ten_Dang_nhap As String, Mat_khau As String) As DataRow
        Dim Kq As DataRow = Danh_sach_QLCT(Du_lieu).FirstOrDefault(
                        Function(x) x("Ten_Dang_nhap") = Ten_Dang_nhap And x("Mat_khau") = Mat_khau)

        Return Kq
    End Function
#End Region
#Region "QLCN(ID,Ten_Dang_nhap,Mat_khau,ID_CHI_NHANH)"
    Public Function Danh_sach_QLCN(Du_lieu As DataSet) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Du_lieu.Tables("QLCN").Select.ToList
        Return Kq
    End Function
    Public Function Trich_rut_QLCN_theo_ID(Du_lieu As DataSet, ID As Integer) As DataRow
        Dim Kq As DataRow = Danh_sach_QLCN(Du_lieu).FirstOrDefault(Function(x) x("ID") = ID)
        Return Kq
    End Function
    Public Function Trich_rut_Danh_sach_QLCN_theo_ID_CHI_NHANH(Du_lieu As DataSet, ID_CHI_NHANH As Integer) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Danh_sach_Nhan_vien(Du_lieu)
        Kq = Kq.FindAll(Function(x) x("ID_CONG_TY") = ID_CHI_NHANH)
        Return Kq
    End Function
    Public Function Trich_rut_QLCN_khi_Dang_nhap(Du_lieu As DataSet,
                                                 Ten_Dang_nhap As String, Mat_khau As String) As DataRow
        Dim Kq As DataRow = Danh_sach_QLCN(Du_lieu).FirstOrDefault(
                        Function(x) x("Ten_Dang_nhap") = Ten_Dang_nhap And x("Mat_khau") = Mat_khau)

        Return Kq
    End Function
#End Region

#End Region


End Class
