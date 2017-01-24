
Public Class MH_Chinh

#Region "Biến/Đối tượng toàn cục"
    Dim Nghiep_vu As New XL_NGHIEP_VU
    Dim The_hien As New XL_THE_HIEN
    Dim Du_lieu As DataSet
    Dim ID_NHAN_VIEN As Integer = 0 ' ID của nhân viên được chọn 

#End Region

#Region "Xử lý Biến cố : Khởi động"
    Public Sub XL_Bien_co_Khoi_dong(Du_lieu As DataSet)
        Me.Du_lieu = Du_lieu
        Dim Loi_chao As String = "Xin chào Quản lý " & Du_lieu.Tables("CHI_NHANH").Rows(0)("Ten")
        The_hien.Xuat_Chuoi(Loi_chao, Th_Tieu_de)

        Dim Danh_sach_Chuc_nang As DataTable = Nghiep_vu.Danh_sach_Chuc_nang(Du_lieu)
        The_hien.Xuat_Danh_sach_Chuc_nang(Danh_sach_Chuc_nang,
                                         Th_Danh_sach_Chuc_nang,
                                          AddressOf XL_Bien_co_Chon_Chuc_nang)


    End Sub

#End Region

#Region "Xử lý Biến cố : Thực hiện Yêu cầu"

    ' Chọn Chức năng 
    Private Sub XL_Bien_co_Chon_Chuc_nang(Th_Chuc_nang As Control, Bc As EventArgs)
        Dim Chuc_nang As DataRow = Th_Chuc_nang.Tag
        Dim Ma_so As String = Chuc_nang("Ma_so")
        If Ma_so = "KET_THUC" Then
            Application.Exit()
        ElseIf Ma_so = "THONG_KE_NHAN_VIEN" Then
            Dim Mh As New MH_Thong_ke_Nhan_vien
            Mh.XL_Bien_co_Khoi_dong(Du_lieu)
            Mh.ShowDialog()
        ElseIf Ma_so = "TRA_CUU_NHAN_VIEN" Then
            Dim Mh As New MH_Tra_cuu_Nhan_vien
            Mh.XL_Bien_co_Khoi_dong(Du_lieu)
            Mh.ShowDialog()
        ElseIf Ma_so = "GHI_MOI_NHAN_VIEN" Then
            Dim Mh As New MH_Ghi_moi_Nhan_vien
            Mh.XL_Bien_co_Khoi_dong(Du_lieu)
            Mh.ShowDialog()
        ElseIf Ma_so = "CAP_NHAT_NHAN_VIEN" Then
            Dim Mh As New MH_Cap_nhat_Nhan_vien
            Mh.XL_Bien_co_Khoi_dong(Du_lieu)
            Mh.ShowDialog()
        ElseIf Ma_so = "XOA_NHAN_VIEN" Then
            Dim Mh As New MH_Xoa_Nhan_vien
            Mh.XL_Bien_co_Khoi_dong(Du_lieu)
            Mh.ShowDialog()
        End If
    End Sub

#End Region
End Class