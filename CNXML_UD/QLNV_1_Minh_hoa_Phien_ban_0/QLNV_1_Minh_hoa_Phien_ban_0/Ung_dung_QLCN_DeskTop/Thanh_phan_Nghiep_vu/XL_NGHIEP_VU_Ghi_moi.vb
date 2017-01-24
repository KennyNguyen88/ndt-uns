Partial Public Class XL_NGHIEP_VU
    Public Function Tao_Ho_so_nhan_vien_moi(Du_lieu As DataSet) As DataRow
        Dim Nhan_vien As DataRow = Du_lieu.Tables("NHAN_VIEN").NewRow
        Nhan_vien("Ho_ten") = ""
        Nhan_vien("CMND") = ""
        Nhan_vien("Ngay_sinh") = Today.AddDays(-365 * 30)
        Nhan_vien("Muc_luong") = "3500000"
        Nhan_vien("Dien_thoai") = ""
        Nhan_vien("Mail") = ""
        Nhan_vien("Dia_chi") = ""
        Nhan_vien("ID_GIOI_TINH") = Danh_sach_Gioi_tinh(Du_lieu)(0)("ID")
        Nhan_vien("ID_DON_VI") = Danh_sach_Don_vi(Du_lieu)(0)("ID")
        Return Nhan_vien
    End Function


    Public Function Ghi_moi_Nhan_vien(Du_lieu As DataSet, Nhan_vien As DataRow) As String
        Dim Kq As String = ""
        If Kq = "" Then
            Dim Du_lieu_He_khach As New DataSet
            Dim Bang_He_khach As DataTable = Nhan_vien.Table.Clone
            Du_lieu_He_khach.Tables.Add(Bang_He_khach)
            Dim Nhan_vien_He_khach As DataRow = Bang_He_khach.NewRow
            Bang_He_khach.Rows.Add(Nhan_vien_He_khach)
            For Each Thuoc_tinh As DataColumn In Bang_He_khach.Columns
                Dim Ten As String = Thuoc_tinh.ColumnName
                If Ten <> "ID" Then
                    Nhan_vien_He_khach(Ten) = Nhan_vien(Ten)
                End If
            Next
            Kq = Dich_vu.Ghi_moi_Nhan_vien(Du_lieu_He_khach)
            If Kq = "" Then
                Nhan_vien.Table.Rows.Add(Nhan_vien)
                ' Thông báo PET : Có thể có lỗi nghiêm trọng !!!
                ' Câu hỏi PET : Lỗi gì ? trường hợp nào phát sinh ? 
            End If
        End If
        Return Kq
    End Function

End Class
