Partial Public Class XL_NGHIEP_VU


#Region "Xử lý Thống kê "
    Public Function Thong_ke_So_luong_Nhan_vien_theo_Don_vi(Du_lieu As DataSet) As DataTable
        Dim Kq As DataTable = Danh_sach_Don_vi(Du_lieu).CopyToDataTable
        Kq.TableName = "DON_VI"
        Kq.Columns.Add("So_luong")
        Kq.Columns.Add("Ty_le")
        Dim Tong_so As Integer = Danh_sach_Nhan_vien(Du_lieu).Count
        For Each Don_vi As DataRow In Kq.Rows
            Dim So_luong As Integer = Trich_rut_Danh_sach_Nhan_vien_theo_ID_DON_VI(Du_lieu, Don_vi("ID")).Count
            Dim Ty_le As Double = Math.Round(100 * So_luong / Tong_so, 2)
            Don_vi("So_luong") = So_luong
            Don_vi("Ty_le") = Ty_le
        Next
        Return Kq
    End Function
#End Region

End Class
