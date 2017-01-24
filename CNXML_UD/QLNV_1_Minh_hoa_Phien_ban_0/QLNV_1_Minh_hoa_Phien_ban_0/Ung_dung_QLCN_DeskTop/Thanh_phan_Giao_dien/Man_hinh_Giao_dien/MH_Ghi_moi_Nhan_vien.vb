
Public Class MH_Ghi_moi_Nhan_vien

#Region "Biến/Đối tượng toàn cục"
    Dim Nghiep_vu As New XL_NGHIEP_VU
    Dim The_hien As New XL_THE_HIEN
    Dim Du_lieu As DataSet
    Dim Nhan_vien As DataRow

#End Region

#Region "Xử lý Biến cố : Khởi động"
    Public Sub XL_Bien_co_Khoi_dong(Du_lieu As DataSet)
        Me.Du_lieu = Du_lieu
        Dim Tieu_de As String = "Tiếp nhận nhân viên mới"
        The_hien.Xuat_Chuoi(Tieu_de, Th_Tieu_de)
        The_hien.Khoi_dong_Ho_so_Nhan_vien(Du_lieu, Th_Ho_so)
        Nhan_vien = Nghiep_vu.Tao_Ho_so_nhan_vien_moi(Du_lieu)
        The_hien.Xuat_Ho_so_Nhan_vien(Nhan_vien, Th_Ho_so)
        Dim Thong_bao As String = "Nhập liệu hồ sơ và Click Đồng ý" & vbCrLf
        Thong_bao &= " == > Phần mềm sẽ kiểm tra và ghi nếu hợp lệ "
        The_hien.Xuat_Chuoi(Thong_bao, Th_Thong_bao)
    End Sub



#End Region

#Region "Xử lý Biến cố : Thực hiện Yêu cầu"
    Private Sub Th_Yeu_cau_Ghi_moi_Click(sender As Object, e As EventArgs) Handles Th_Yeu_cau_Ghi_moi.Click
        Dim Chuoi_loi As String = The_hien.Nhap_Ho_so_Nhan_vien(Nhan_vien, Th_Ho_so)
        If Chuoi_loi = "" Then
            Chuoi_loi = Nghiep_vu.Ghi_moi_Nhan_vien(Du_lieu, Nhan_vien)
        End If
        Dim Thong_bao As String = ""
        If Chuoi_loi <> "" Then
            Thong_bao = "Lỗi nhập liệu :" & vbCrLf & Chuoi_loi
        Else
            Nhan_vien = Nghiep_vu.Tao_Ho_so_nhan_vien_moi(Du_lieu)
            The_hien.Xuat_Ho_so_Nhan_vien(Nhan_vien, Th_Ho_so)
            Thong_bao = "Đã ghi hồ sơ "

        End If
        The_hien.Xuat_Chuoi(Thong_bao, Th_Thong_bao)
    End Sub
#End Region

End Class