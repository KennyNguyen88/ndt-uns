Imports System.Xml
Public Class XL_NGHIEP_VU

#Region "Xử lý Nghiệp vụ Cơ sở"
    '=====Trích rút Cấp 0 
    Protected Function Danh_sach_Nhan_vien(Goc As XmlElement) As List(Of XmlElement)
        Dim Kq As New List(Of XmlElement)
        For Each Nut As XmlElement In Goc.SelectNodes("NHAN_VIEN")
            Kq.Add(Nut)
        Next
        Return Kq
    End Function
    'Lưu ý PET : Đây là hàm rất quan trọng - Tại sao ? 
#End Region

#Region "Xử lý Nghiệp vụ   "
    '====== Tra cứu 
    Public Function Tra_cuu_Nhan_vien_theo_Ho_ten(Goc As XmlElement,
                                                    Chuoi_Ho_ten As String) As List(Of XmlElement)
        Dim Kq As List(Of XmlElement) = Danh_sach_Nhan_vien(Goc)
        Kq = Kq.FindAll(Function(x) x.GetAttribute("Ho_ten").ToUpper.Contains(Chuoi_Ho_ten.ToUpper))
        Return Kq
    End Function
#End Region

End Class
