
Public Class MH_Tra_cuu_Nhan_vien

#Region "Biến/Đối tượng toàn cục"
    Dim Nghiep_vu As New XL_NGHIEP_VU
    Dim The_hien As New XL_THE_HIEN
    Dim Du_lieu As DataSet

#End Region

#Region "Xử lý Biến cố : Khởi động"
    Public Sub XL_Bien_co_Khoi_dong(Du_lieu As DataSet)
        Me.Du_lieu = Du_lieu
        Dim Tieu_de As String = "Tra cứu nhân viên"
        The_hien.Xuat_Chuoi(Tieu_de, Th_Tieu_de)
        The_hien.Xuat_Danh_sach_Don_vi(Du_lieu.Tables("DON_VI"), Th_Danh_sach_Don_vi,
                                        AddressOf XL_Bien_co_Chon_Don_vi)
        Dim Thong_bao As String = "Click Đơn vị, Enter Họ tên hay Mức lương == > Xem danh sách nhân viên tương ứng"
        The_hien.Xuat_Chuoi(Thong_bao, Th_Thong_bao)
        The_hien.Xuat_Chuoi("Nguyễn", Th_Chuoi_Ho_ten, AddressOf XL_Bien_co_Nhap_Chuoi_Ho_ten)
        The_hien.Xuat_Chuoi("5000000-80000000", Th_Chuoi_Muc_luong, AddressOf XL_Bien_co_Nhap_Chuoi_Muc_luong)
    End Sub

#End Region

#Region "Xử lý Biến cố : Thực hiện Yêu cầu"
    ' Chọn đối tượng
    Private Sub XL_Bien_co_Chon_Don_vi(Th_Don_vi As Control, Bc As EventArgs)
        Dim Don_vi As DataRow = Th_Don_vi.Tag
        Dim Danh_sach_Nhan_vien As DataTable = Nghiep_vu.Tra_cuu_Nhan_vien_theo_Don_vi(Du_lieu, Don_vi)
        The_hien.Xuat_Danh_sach_Nhan_vien_Tra_cuu(Danh_sach_Nhan_vien, Th_Danh_sach_Nhan_vien)
        Dim Thong_bao As String = "Danh sách " & Danh_sach_Nhan_vien.Rows.Count & " nhân viên"
        The_hien.Xuat_Chuoi(Thong_bao, Th_Thong_bao)
    End Sub

    ' Nhập chuỗi
    Private Sub XL_Bien_co_Nhap_Chuoi_Ho_ten(Th_Chuoi_Ho_ten As Control, Bc As KeyEventArgs)
        If Bc.KeyCode = Keys.Enter Then
            Dim Chuoi_Ho_ten As String = The_hien.Nhap_Chuoi(Th_Chuoi_Ho_ten)
            Dim Danh_sach_Nhan_vien As DataTable = Nghiep_vu.Tra_cuu_Nhan_vien_theo_Ho_ten(Du_lieu, Chuoi_Ho_ten)
            The_hien.Xuat_Danh_sach_Nhan_vien_Tra_cuu(Danh_sach_Nhan_vien, Th_Danh_sach_Nhan_vien)
            Dim Thong_bao As String = "Danh sách " & Danh_sach_Nhan_vien.Rows.Count & " nhân viên"
            The_hien.Xuat_Chuoi(Thong_bao, Th_Thong_bao)
        End If
    End Sub
    Private Sub XL_Bien_co_Nhap_Chuoi_Muc_luong(Th_Chuoi_Muc_luong As Control, Bc As KeyEventArgs)
        If Bc.KeyCode = Keys.Enter Then
            Dim Chuoi_Muc_luong As String = The_hien.Nhap_Chuoi(Th_Chuoi_Muc_luong)
            Dim M As String() = Chuoi_Muc_luong.Split(New String() {"-"}, StringSplitOptions.RemoveEmptyEntries)
            If M.Count = 2 AndAlso IsNumeric(M(0)) AndAlso IsNumeric(M(1)) Then
                Dim Danh_sach_Nhan_vien As DataTable = Nghiep_vu.Tra_cuu_Nhan_vien_theo_Muc_luong(Du_lieu, M(0), M(1))
                The_hien.Xuat_Danh_sach_Nhan_vien_Tra_cuu(Danh_sach_Nhan_vien, Th_Danh_sach_Nhan_vien)
                Dim Thong_bao As String = "Danh sách " & Danh_sach_Nhan_vien.Rows.Count & " nhân viên"
                The_hien.Xuat_Chuoi(Thong_bao, Th_Thong_bao)
            Else
                Dim Thong_bao As String = "Mức lương nhập không hợp lệ"
                The_hien.Xuat_Chuoi(Thong_bao, Th_Thong_bao)
            End If

        End If
    End Sub
#End Region

End Class