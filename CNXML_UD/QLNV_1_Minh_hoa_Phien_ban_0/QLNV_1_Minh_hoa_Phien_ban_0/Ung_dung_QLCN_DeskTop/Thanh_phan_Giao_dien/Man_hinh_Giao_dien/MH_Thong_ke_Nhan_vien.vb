
Public Class MH_Thong_ke_Nhan_vien

#Region "Biến/Đối tượng toàn cục"
    Dim Nghiep_vu As New XL_NGHIEP_VU
    Dim The_hien As New XL_THE_HIEN


#End Region

#Region "Xử lý Biến cố : Khởi động"
    Public Sub XL_Bien_co_Khoi_dong(Du_lieu As DataSet)
        Dim Loi_chao As String = "Xin chào Quản lý " & Du_lieu.Tables("CHI_NHANH").Rows(0)("Ten")
        The_hien.Xuat_Chuoi(Loi_chao, Th_Tieu_de)
        Dim Danh_sach_Don_vi_Thong_ke As DataTable = Nghiep_vu.Thong_ke_So_luong_Nhan_vien_theo_Don_vi(Du_lieu)
        The_hien.Xuat_Danh_sach_Don_vi_Thong_ke(Danh_sach_Don_vi_Thong_ke,
                                         Th_Danh_sach_Don_vi_Thong_ke)


    End Sub

#End Region

#Region "Xử lý Biến cố : Thực hiện Yêu cầu"
    ' Hiện nay không có 
#End Region
End Class