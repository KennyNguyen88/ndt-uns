' Thông báo PET : 
'   Đây  là các hàm xử lý thể hiện có thể tái sử dụng trên tất cả các màn hình của ứng dụng  
'   Các hàm xử lý này rất cần thiết 
' Câu hỏi PET : Tại sao lại rất cần thiết ? 

' Lưu ý PET : Đây là hàm tạm thời và sẽ cải tiến trong phiên bản khác 
' Câu hỏi PET : Tại sao là hàm tạm thời ? 
Partial Public Class XL_THE_HIEN


#Region "Thực đơn của ứng dụng"
    Public Sub Xuat_Thuc_don_Ttnh_cua_Ung_dung(
                                               Thuc_don As MenuStrip, XL_Chon_Chuc_nang As EventHandler)
        Dim Danh_sach_Ten_Chuc_nang As List(Of String) = New String() {
                                     "Tra cứu", "Quản lý", "Kết thúc"}.ToList
        Dim Danh_sach_Ma_so_Chuc_nang As List(Of String) = New String() {
                                      "TRA_CUU", "QUAN_LY", "KET_THUC"}.ToList
        Xuat_Thuc_don_tinh(Danh_sach_Ten_Chuc_nang, Danh_sach_Ma_so_Chuc_nang,
                           Thuc_don, XL_Chon_Chuc_nang)

        Xuat_Chuc_nang_Con_cua_Tra_Cuu(Thuc_don.Items("TRA_CUU"), XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_Con_cua_Quan_Ly(Thuc_don.Items("QUAN_LY"), XL_Chon_Chuc_nang)
    End Sub

    Public Function Tao_Thuc_don_dong_cua_Ung_dung(
                                                   Th_Lien_ket As Control,
                                                   XL_Chon_Chuc_nang As EventHandler) As ContextMenuStrip
        Dim Danh_sach_Ten_Chuc_nang As List(Of String) = New String() {
                                     "Tra cứu", "Quản lý", "Kết thúc"}.ToList
        Dim Danh_sach_Ma_so_Chuc_nang As List(Of String) = New String() {
                                      "TRA_CUU", "QUAN_LY", "KET_THUC"}.ToList
        Dim Thuc_don_dong As ContextMenuStrip = Tao_Thuc_don_dong(Danh_sach_Ten_Chuc_nang,
                                                                                    Danh_sach_Ma_so_Chuc_nang,
                                                                                      Th_Lien_ket, XL_Chon_Chuc_nang)

        Xuat_Chuc_nang_Con_cua_Tra_Cuu(Thuc_don_dong.Items("TRA_CUU"), XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_Con_cua_Quan_Ly(Thuc_don_dong.Items("QUAN_LY"), XL_Chon_Chuc_nang)
        Return Thuc_don_dong
    End Function

#End Region

#Region "Chức năng con theo từng loại đối tượng "

    Protected Sub Xuat_Chuc_nang_Con_cua_Tra_Cuu(Chuc_nang As ToolStripMenuItem,
                                                              XL_Chon_Chuc_nang As EventHandler)
        'Dim Loai_doi_tuong As String = "TRA_CUU" ' Loại đối tượng Tổ chức cấp 0 ( Cấp cao nhất của ứng dụng )
        Dim Danh_sach_Ten As List(Of String) = New String() {"Tra cứu suất chiếu", "Tra cứu suất chiếu Beta"}.ToList
        Dim Danh_sach_Ma_so As List(Of String) = New String() {"TRA_CUU_SUAT_CHIEU", "TRA_CUU_SUAT_CHIEU_BETA"}.ToList
        Xuat_Chuc_nang_con_cua_Chuc_nang(Danh_sach_Ten, Danh_sach_Ma_so, Chuc_nang, XL_Chon_Chuc_nang)
    End Sub
    Protected Sub Xuat_Chuc_nang_Con_cua_Quan_Ly(Chuc_nang As ToolStripMenuItem,
                                                              XL_Chon_Chuc_nang As EventHandler)
        'Dim Loai_doi_tuong As String = "QUAN_LY"  'Loại đối tượng Tổ chức  - Danh mục 
        Dim Danh_sach_Ten As List(Of String) = New String() {"Rạp Chiếu Phim", "Phim", "Ca Chiếu", "Xuất Chiếu", "Phòng", "Loại Phòng", "Vé", "Ghế"}.ToList
        Dim Danh_sach_Ma_so As List(Of String) = New String() {
                                      "QUAN_LY_RAP_CHIEU_PHIM", "QUAN_LY_PHIM", "QUAN_LY_CA_CHIEU", "QUAN_LY_XUAT_CHIEU", "QUAN_LY_PHONG", "QUAN_LY_LOAI_PHONG", "QUAN_LY_VE", "QUAN_LY_GHE"}.ToList
        Xuat_Chuc_nang_con_cua_Chuc_nang(Danh_sach_Ten, Danh_sach_Ma_so,
                           Chuc_nang, XL_Chon_Chuc_nang)
    End Sub
#End Region



End Class
