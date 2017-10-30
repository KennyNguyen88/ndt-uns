Public Class MH_Xoa_Nhan_vien
#Region "Biến/Đối tượng toàn cục"
    Dim Nghiep_vu As New XL_NGHIEP_VU
    Dim The_hien As New XL_THE_HIEN
    Dim Du_lieu As DataSet
    Dim Nhan_vien As DataRow

#End Region

#Region "Xử lý Biến cố : Khởi động"
    Public Sub XL_Bien_co_Khoi_dong(Du_lieu As DataSet)
        Me.Du_lieu = Du_lieu
        Dim Tieu_de As String = "Thanh lý hợp đồng nhân viên "
        The_hien.Xuat_Chuoi(Tieu_de, Th_Tieu_de)
        The_hien.Khoi_dong_Ho_so_Nhan_vien(Du_lieu, Th_Ho_so)
        Dim Thong_bao As String = "Click Chọn nhân viên cần thanh lý hợp đồng" & vbCrLf
        The_hien.Xuat_Chuoi(Thong_bao, Th_Thong_bao)
        Th_Yeu_cau_Xoa.Visible = False
    End Sub



#End Region

#Region "Xử lý Biến cố : Thực hiện Yêu cầu"
    Private Sub Th_Yeu_cau_Xoa_Click(sender As Object, e As EventArgs) Handles Th_Yeu_cau_Xoa.Click
        Dim Chuoi_loi As String = The_hien.Nhap_Ho_so_Nhan_vien(Nhan_vien, Th_Ho_so)
        If Chuoi_loi = "" Then
            Chuoi_loi = Nghiep_vu.Xoa_Nhan_vien(Du_lieu, Nhan_vien)
        End If
        Dim Thong_bao As String = ""
        If Chuoi_loi <> "" Then
            Thong_bao = "Lỗi nhập liệu :" & vbCrLf & Chuoi_loi
            The_hien.Xuat_Chuoi(Thong_bao, Th_Thong_bao)
        Else
            Thong_bao = "Đã xóa hồ sơ "
            MsgBox(Thong_bao)
            Me.Close()
        End If

    End Sub

    Private Sub Th_Yeu_cau_Chon_Nhan_vien_Click(sender As Object, e As EventArgs) Handles Th_Yeu_cau_Chon_Nhan_vien.Click
        Dim Mh As New MH_Chon_Nhan_vien
        Mh.XL_Bien_co_Khoi_dong(Du_lieu)
        Mh.ShowDialog()
        If Mh.ID_NHAN_VIEN > 0 Then
            Nhan_vien = Nghiep_vu.Trich_rut_Nhan_vien_theo_ID(Du_lieu, Mh.ID_NHAN_VIEN)
            The_hien.Xuat_Ho_so_Nhan_vien(Nhan_vien, Th_Ho_so)
            Th_Yeu_cau_Xoa.Visible = True
            Dim Thong_bao As String = "Click Đồng ý" & vbCrLf
            Thong_bao &= " == > Phần mềm sẽ thực hiện xóa hồ sơ nhân viên  " & Nhan_vien("Ho_ten")
            The_hien.Xuat_Chuoi(Thong_bao, Th_Thong_bao)
        Else
            Dim Thong_bao As String = "Chưa chọn nhân viên" & vbCrLf
            The_hien.Xuat_Chuoi(Thong_bao, Th_Thong_bao)
        End If

    End Sub


#End Region
End Class