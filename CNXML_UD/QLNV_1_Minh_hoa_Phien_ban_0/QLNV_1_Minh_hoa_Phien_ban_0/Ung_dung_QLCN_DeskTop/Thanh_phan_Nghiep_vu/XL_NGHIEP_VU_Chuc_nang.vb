Partial Public Class XL_NGHIEP_VU
    Public Function Danh_sach_Chuc_nang(Du_lieu As DataSet) As DataTable
        Dim Kq As New DataTable
        Kq.Columns.Add("Ten")
        Kq.Columns.Add("Ma_so")
        Dim Danh_sach_Ten As String() = New String() {"Xem " & vbCrLf & "Báo cáo thống kê",
                                             "Tra cứu " & vbCrLf & "Nhân viên",
                                            "Tiếp nhận " & vbCrLf & "Nhân viên mới",
                                            "Cập nhật " & vbCrLf & "hồ sơ Nhân viên",
                                            "Thanh lý " & vbCrLf & "hợp đồng Nhân viên",
                                            "Kết thúc" & vbCrLf & "Ứng đụng"}

        Dim Danh_sach_Ma_so As String() = New String() {"THONG_KE_NHAN_VIEN",
                                       "TRA_CUU_NHAN_VIEN",
                                        "GHI_MOI_NHAN_VIEN",
                                               "CAP_NHAT_NHAN_VIEN",
                                                 "XOA_NHAN_VIEN",
                                                 "KET_THUC"}

        For i As Integer = 0 To Danh_sach_Ten.Length - 1
            Dim Chuc_nang As DataRow = Kq.NewRow
            Kq.Rows.Add(Chuc_nang)
            Chuc_nang("Ten") = Danh_sach_Ten(i)
            Chuc_nang("Ma_so") = Danh_sach_Ma_so(i)
        Next
        Return Kq
    End Function
End Class
