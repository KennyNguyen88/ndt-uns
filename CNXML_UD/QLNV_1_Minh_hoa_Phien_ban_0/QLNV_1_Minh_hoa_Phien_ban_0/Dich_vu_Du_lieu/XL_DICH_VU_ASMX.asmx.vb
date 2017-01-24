Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class XL_DICH_VU_ASMX
    Inherits System.Web.Services.WebService
#Region "Biến/Đối tượng Toàn cục "

    Shared Du_lieu As New DataSet
    Shared Luu_tru As New XL_LUU_TRU
    Shared Nghiep_vu As New XL_NGHIEP_VU
#End Region

#Region "Xử lý Khởi động"
    Public Sub New()
        If Du_lieu.Tables.Count = 0 Then ' Chưa đọc 
            Du_lieu = Luu_tru.Doc_Du_lieu
        End If
    End Sub
#End Region

#Region "Xử lý Đăng nhập"
    ' DataSet Kết quả khi QLCT đăng nhập 
    ' CONG_TY :1
    ' CHI_NHANH : Tất cả
    ' DON_VI : Tất cả
    ' NHAN_VIEN : Tất cả
    ' GIOI_TINH : Tất cả
    <WebMethod()>
    Public Function Dang_nhap_QLCT(Ten_Dang_nhap As String, Mat_khau As String) As DataSet
        Dim Kq As New DataSet
        Dim QLCT As DataRow = Nghiep_vu.Trich_rut_QLCT_khi_Dang_nhap(Du_lieu, Ten_Dang_nhap, Mat_khau)
        If QLCT IsNot Nothing Then
            Kq = Du_lieu.Clone 'Tạo DataSet chỉ có cấu trúc các bảng 
            Dim Cong_ty As DataRow = Nghiep_vu.Danh_sach_Cong_ty(Du_lieu)(0)
            Kq.Tables("CONG_TY").ImportRow(Cong_ty)
            For Each Chi_nhanh As DataRow In Nghiep_vu.Danh_sach_Chi_nhanh(Du_lieu)
                Kq.Tables("CHI_NHANH").ImportRow(Chi_nhanh)
            Next
            For Each Don_vi As DataRow In Nghiep_vu.Danh_sach_Don_vi(Du_lieu)
                Kq.Tables("DON_VI").ImportRow(Don_vi)
            Next
            For Each Nhan_vien As DataRow In Nghiep_vu.Danh_sach_Nhan_vien(Du_lieu)
                Kq.Tables("NHAN_VIEN").ImportRow(Nhan_vien)
            Next

            For Each Gioi_tinh As DataRow In Nghiep_vu.Danh_sach_Gioi_tinh(Du_lieu)
                Kq.Tables("GIOI_TINH").ImportRow(Gioi_tinh)
            Next
        End If
        Return Kq
    End Function
    '========================================
    ' DataSet Kết quả khi QLCN đăng nhập 
    ' CONG_TY :1
    ' CHI_NHANH : 1
    ' DON_VI : Tương ứng Chi nhánh
    ' NHAN_VIEN : Tương ứng Chi nhánh
    ' GIOI_TINH : Tất cả
    <WebMethod()>
    Public Function Dang_nhap_QLCN(Ten_Dang_nhap As String, Mat_khau As String) As DataSet
        Dim Kq As New DataSet
        Dim QLCN As DataRow = Nghiep_vu.Trich_rut_QLCN_khi_Dang_nhap(Du_lieu, Ten_Dang_nhap, Mat_khau)
        If QLCN IsNot Nothing Then
            Kq = Du_lieu.Clone  'Tạo DataSet chỉ có cấu trúc các bảng 

            Dim Chi_nhanh As DataRow = Nghiep_vu.Trich_rut_Chi_nhanh_theo_ID(Du_lieu, QLCN("ID_CHI_NHANH"))
            Kq.Tables("CHI_NHANH").ImportRow(Chi_nhanh)

            For Each Don_vi As DataRow In Nghiep_vu.Trich_rut_Danh_sach_Don_vi_theo_ID_CHI_NHANH(Du_lieu, QLCN("ID_CHI_NHANH"))
                Kq.Tables("DON_VI").ImportRow(Don_vi)
                For Each Nhan_vien As DataRow In Nghiep_vu.Trich_rut_Danh_sach_Nhan_vien_theo_ID_DON_VI(Du_lieu, Don_vi("ID"))
                    Kq.Tables("NHAN_VIEN").ImportRow(Nhan_vien)
                Next
            Next

            Dim Cong_ty As DataRow = Nghiep_vu.Danh_sach_Cong_ty(Du_lieu)(0)
            Kq.Tables("CONG_TY").ImportRow(Cong_ty)
            For Each Gioi_tinh As DataRow In Nghiep_vu.Danh_sach_Gioi_tinh(Du_lieu)
                Kq.Tables("GIOI_TINH").ImportRow(Gioi_tinh)
            Next


        End If
        Return Kq
    End Function

#End Region

#Region "Xử lý Ghi"

    <WebMethod()>
    Public Function Ghi_moi_Nhan_vien(Du_lieu_He_khach As DataSet) As String

        Dim Bang_He_khach As DataTable = Du_lieu_He_khach.Tables(0)
        Dim Nhan_vien_He_khach As DataRow = Bang_He_khach.Rows(0)
        Dim Kq As String = Nghiep_vu.Kiem_tra_Ghi_moi_Nhan_vien(Du_lieu, Nhan_vien_He_khach)
        If Kq = "" Then
            Dim Nhan_vien As DataRow = Du_lieu.Tables("NHAN_VIEN").NewRow
            For Each Thuoc_tinh As DataColumn In Du_lieu.Tables("NHAN_VIEN").Columns
                Dim Ten As String = Thuoc_tinh.ColumnName
                If Ten <> "ID" Then
                    Nhan_vien(Ten) = Nhan_vien_He_khach(Ten)
                End If
            Next
            Kq = Luu_tru.Ghi_moi(Nhan_vien)
            '  Xử lý cấp ID cho hệ khách ???
        End If

        Return Kq
    End Function

    <WebMethod()>
    Public Function Cap_nhat_Nhan_vien(Du_lieu_He_khach As DataSet) As String
        Dim Bang_He_khach As DataTable = Du_lieu_He_khach.Tables(0)
        Dim Nhan_vien_He_khach As DataRow = Bang_He_khach.Rows(0)
        Dim Kq As String = Nghiep_vu.Kiem_tra_Cap_nhat_Nhan_vien(Du_lieu, Nhan_vien_He_khach)
        If Kq = "" Then
            Dim Nhan_vien As DataRow = Nghiep_vu.Trich_rut_Nhan_vien_theo_ID(Du_lieu, Nhan_vien_He_khach("ID"))
            For Each Thuoc_tinh As DataColumn In Du_lieu.Tables("NHAN_VIEN").Columns
                Dim Ten As String = Thuoc_tinh.ColumnName
                If Ten <> "ID" Then
                    Nhan_vien(Ten) = Nhan_vien_He_khach(Ten)
                End If
            Next
            Kq = Luu_tru.Cap_nhat(Nhan_vien)
        End If
        Return Kq
    End Function

    <WebMethod()>
    Public Function Xoa_Nhan_vien(Du_lieu_He_khach As DataSet) As String
        Dim Bang_He_khach As DataTable = Du_lieu_He_khach.Tables(0)
        Dim Nhan_vien_He_khach As DataRow = Bang_He_khach.Rows(0)
        Dim Kq As String = Nghiep_vu.Kiem_tra_Xoa_Nhan_vien(Du_lieu, Nhan_vien_He_khach)
        If Kq = "" Then
            Dim Nhan_vien As DataRow = Nghiep_vu.Trich_rut_Nhan_vien_theo_ID(Du_lieu, Nhan_vien_He_khach("ID"))
            Kq = Luu_tru.Xoa(Nhan_vien)
        End If

        Return Kq
    End Function

#End Region


End Class