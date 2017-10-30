
Public Class MH_Dang_nhap
    Private Sub MH_Dang_nhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XL_BIen_co_Khoi_dong()
    End Sub
#Region "Biến/Đối tượng toàn cục"
    Dim Nghiep_vu As New XL_NGHIEP_VU
    Dim The_hien As New XL_THE_HIEN
#End Region

#Region "Xử lý biến cố : Khởi động"

    Public Sub XL_BIen_co_Khoi_dong()
        Dim Thong_bao As String = "Đây là ứng dụng dành riêng cho Quản lý chi nhánh "
        The_hien.Xuat_Chuoi(Thong_bao, Th_Thong_bao)
        Nghiep_vu.Xu_ly_PET(Me)
    End Sub
#End Region

#Region "Xử lý biến cố : Thực hiện Yêu cầu  "
    Private Sub Th_Yeu_cau_Dang_nhap_Click(sender As Object, e As EventArgs) Handles Th_Yeu_cau_Dang_nhap.Click
        Dim Ten_Dang_nhap As String = The_hien.Nhap_Chuoi(Th_Ten_Dang_nhap)
        Dim Mat_khau As String = The_hien.Nhap_Chuoi(Th_Mat_khau)

        Dim Du_lieu As DataSet = Nghiep_vu.Dang_nhap_QLCN(Ten_Dang_nhap, Mat_khau)
        If Du_lieu.Tables.Count > 0 Then
            Dim Mh As New MH_Chinh
            Mh.XL_Bien_co_Khoi_dong(Du_lieu)
            Mh.ShowDialog()
        Else
            The_hien.Xuat_Chuoi("Đăng nhập không hợp lệ", Th_Thong_bao)
        End If
    End Sub




#End Region
End Class