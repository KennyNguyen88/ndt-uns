Imports System.Xml
Public Class MH_Minh_hoa

#Region "Biến/Đối tượng toàn cục"
    Protected Nghiep_vu As New XL_NGHIEP_VU
    Protected The_hien As New XL_THE_HIEN
    Protected Goc As XmlElement
#End Region
#Region "Xử lý "
    Public Sub Xu_ly(Goc As XmlElement)
        Me.Goc = Goc
        Me.ShowDialog()
    End Sub
#End Region
#Region "Xử lý biến cố"
    Private Sub Th_Chuoi_Ho_ten_KeyDown(sender As Object, e As KeyEventArgs) Handles Th_Ho_ten.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim Dong_ho As New PET_Dong_ho_Ho_tro_thuc_hanh.XL_DONG_HO
            Dim Ho_ten As String = The_hien.Nhap_Chuoi(Th_Ho_ten)
            Dim Danh_sach_Nhan_vien As List(Of XmlElement) = Nghiep_vu.Tra_cuu_Nhan_vien_theo_Ho_ten(Goc, Ho_ten)
            The_hien.Xuat_Danh_sach_Nhan_vien(Danh_sach_Nhan_vien, Th_Danh_sach_Nhan_vien)

            '==== Xử lý PET : Chỉ phục vụ giảng dạy 
            Dim Thong_bao_PET As String = "Lưu ý PET :   " & vbCrLf
            Thong_bao_PET &= "Đây là minh họa nền tảng về cách tổ chức xử lý Hệ khách " & vbCrLf
            Thong_bao_PET &= "== >Xem Source Code  thật kỹ   " & vbCrLf
            Thong_bao_PET &= "Lúc này các anh chị phải tự lập trình " & vbCrLf
            Thong_bao_PET &= "Tra cứu nhân viên theo Mức lương - Đơn vị   " & vbCrLf
            Thong_bao_PET &= Dong_ho.Tao_Chuoi_Thoi_gian_do("Thời gian xử lý")
            Th_Thong_bao_PET.Text = Thong_bao_PET
            '======
        End If
    End Sub
#End Region

End Class