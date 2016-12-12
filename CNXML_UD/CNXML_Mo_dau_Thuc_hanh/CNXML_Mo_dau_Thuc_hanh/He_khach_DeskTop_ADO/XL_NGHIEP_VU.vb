Public Class XL_NGHIEP_VU

#Region "Xử lý Nghiệp vụ Cơ sở"
    '=====Trích rút Cấp 0 
    Protected Function Danh_sach_Nhan_vien(Du_lieu As DataSet) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Du_lieu.Tables("NHAN_VIEN").Select.ToList
        Return Kq
    End Function
    'Lưu ý PET : Đây là hàm rất quan trọng - Tại sao ? 
#End Region

#Region "Xử lý Nghiệp vụ   "
    '====== Tra cứu 
    Public Function Tra_cuu_Nhan_vien_theo_Ho_ten(Du_lieu As DataSet,
                                                    Chuoi_Ho_ten As String) As List(Of DataRow)
        Dim Kq As List(Of DataRow) = Danh_sach_Nhan_vien(Du_lieu)
        Kq = Kq.FindAll(Function(x) x("Ho_ten").ToString.ToUpper.Contains(Chuoi_Ho_ten.ToUpper))
        Return Kq
    End Function
#End Region

End Class
