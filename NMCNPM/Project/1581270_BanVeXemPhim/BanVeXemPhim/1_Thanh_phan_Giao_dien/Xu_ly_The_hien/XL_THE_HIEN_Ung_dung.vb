' Thông báo PET : 
'   Đây  là các hàm xử lý thể hiện có thể tái sử dụng trên tất cả các màn hình của ứng dụng  
'   Các hàm xử lý này rất cần thiết 
' Câu hỏi PET : Tại sao lại rất cần thiết ? 

' Lưu ý PET : Đây là hàm tạm thời và sẽ cải tiến trong phiên bản khác 
' Câu hỏi PET : Tại sao là hàm tạm thời ? 
Partial Public Class XL_THE_HIEN


#Region "Thực đơn của ứng dụng"
    ' Câu hỏi PET : Tại sao Xuat_Thuc_don_tinh nhưng lại Tao_thuc_don_dong ? 
    ' Có nên bổ sung hàm Hàm Tao_Thuc_don_tinh , Xuat_Thuc_don_dong  không ? khi nào nên bổ sung ?
    Public Sub Xuat_Thuc_don_Ttnh_cua_Ung_dung(
                                               Thuc_don As MenuStrip, XL_Chon_Chuc_nang As EventHandler)
        Dim Danh_sach_Ten_Chuc_nang As List(Of String) = New String() {
                                     "Công ty", "Giới tính", "Chi nhánh", "Đơn vị", "Nhân viên", "Kết thúc"}.ToList
        Dim Danh_sach_Ma_so_Chuc_nang As List(Of String) = New String() {
                                      "CONG_TY", "GIOI_TINH", "CHI_NHANH", "DON_VI", "NHAN_VIEN", "KET_THUC"}.ToList
        Xuat_Thuc_don_tinh(Danh_sach_Ten_Chuc_nang, Danh_sach_Ma_so_Chuc_nang,
                           Thuc_don, XL_Chon_Chuc_nang)

        Xuat_Chuc_nang_Con_cua_Cong_ty(Thuc_don.Items("CONG_TY"), XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_Con_cua_Gioi_tinh(Thuc_don.Items("GIOI_TINH"), XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_Con_cua_Chi_Nhanh(Thuc_don.Items("CHI_NHANH"), XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_Con_cua_Don_vi(Thuc_don.Items("DON_VI"), XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_Con_cua_Nhan_vien(Thuc_don.Items("NHAN_VIEN"), XL_Chon_Chuc_nang)
    End Sub

    Public Function Tao_Thuc_don_dong_cua_Ung_dung(
                                                   Th_Lien_ket As Control,
                                                   XL_Chon_Chuc_nang As EventHandler) As ContextMenuStrip
        Dim Danh_sach_Ten_Chuc_nang As List(Of String) = New String() {
                                     "Công ty", "Giới tính", "Chi nhánh", "Đơn vị", "Nhân viên", "Kết thúc"}.ToList
        Dim Danh_sach_Ma_so_Chuc_nang As List(Of String) = New String() {
                                      "CONG_TY", "GIOI_TINH", "CHI_NHANH", "DON_VI", "NHAN_VIEN", "KET_THUC"}.ToList
        Dim Thuc_don_dong As ContextMenuStrip = Tao_Thuc_don_dong(Danh_sach_Ten_Chuc_nang,
                                                                                    Danh_sach_Ma_so_Chuc_nang,
                                                                                      Th_Lien_ket, XL_Chon_Chuc_nang)

        Xuat_Chuc_nang_Con_cua_Cong_ty(Thuc_don_dong.Items("CONG_TY"), XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_Con_cua_Gioi_tinh(Thuc_don_dong.Items("GIOI_TINH"), XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_Con_cua_Chi_Nhanh(Thuc_don_dong.Items("CHI_NHANH"), XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_Con_cua_Don_vi(Thuc_don_dong.Items("DON_VI"), XL_Chon_Chuc_nang)
        Xuat_Chuc_nang_Con_cua_Nhan_vien(Thuc_don_dong.Items("NHAN_VIEN"), XL_Chon_Chuc_nang)
        Return Thuc_don_dong
    End Function

#End Region

#Region "Chứng năng con theo từng loại đối tượng "

    Protected Sub Xuat_Chuc_nang_Con_cua_Cong_ty(Chuc_nang As ToolStripMenuItem,
                                                              XL_Chon_Chuc_nang As EventHandler)
        Dim Loai_doi_tuong As String = "CONG_TY" ' Loại đối tượng Tổ chức cấp 0 ( Cấp cao nhất của ứng dụng )
        Dim Danh_sach_Ten As List(Of String) = New String() {"Thống kê  số lượng nhân viên của từng đơn vị", "Cập nhật thông tin"}.ToList
        Dim Danh_sach_Ma_so As List(Of String) = New String() {"THONG_KE_NHAN_VIEN_DON_VI", "CAP_NHAT_" & Loai_doi_tuong}.ToList
        Xuat_Chuc_nang_con_cua_Chuc_nang(Danh_sach_Ten, Danh_sach_Ma_so, Chuc_nang, XL_Chon_Chuc_nang)
    End Sub
    Protected Sub Xuat_Chuc_nang_Con_cua_Gioi_tinh(Chuc_nang As ToolStripMenuItem,
                                                              XL_Chon_Chuc_nang As EventHandler)
        Dim Loai_doi_tuong As String = "GIOI_TINH"  'Loại đối tượng Tổ chức  - Danh mục 
        Dim Danh_sach_Ten As List(Of String) = New String() {"Thêm mới", "Cập nhật", "Xóa"}.ToList
        Dim Danh_sach_Ma_so As List(Of String) = New String() {
                                      "GHI_MOI_" & Loai_doi_tuong, "CAP_NHAT_" & Loai_doi_tuong, "XOA_" & Loai_doi_tuong}.ToList
        Xuat_Chuc_nang_con_cua_Chuc_nang(Danh_sach_Ten, Danh_sach_Ma_so,
                           Chuc_nang, XL_Chon_Chuc_nang)
    End Sub
    Protected Sub Xuat_Chuc_nang_Con_cua_Chi_Nhanh(Chuc_nang As ToolStripMenuItem,
                                                              XL_Chon_Chuc_nang As EventHandler)
        Dim Loai_doi_tuong As String = "CHI_NHANH" 'Loại đối tượng Tổ chức cấp 1
        Dim Danh_sach_Ten As List(Of String) = New String() {"Thêm mới", "Cập nhật", "Xóa"}.ToList
        Dim Danh_sach_Ma_so As List(Of String) = New String() {
                                      "GHI_MOI_" & Loai_doi_tuong, "CAP_NHAT_" & Loai_doi_tuong, "XOA_" & Loai_doi_tuong}.ToList
        Xuat_Chuc_nang_con_cua_Chuc_nang(Danh_sach_Ten, Danh_sach_Ma_so,
                           Chuc_nang, XL_Chon_Chuc_nang)
    End Sub
    Protected Sub Xuat_Chuc_nang_Con_cua_Don_vi(Chuc_nang As ToolStripMenuItem,
                                                              XL_Chon_Chuc_nang As EventHandler)
        Dim Loai_doi_tuong As String = "DON_VI" 'Loại đối tượng Tổ chức cấp 2
        Dim Danh_sach_Ten As List(Of String) = New String() {"Thêm mới", "Cập nhật", "Xóa"}.ToList
        Dim Danh_sach_Ma_so As List(Of String) = New String() {
                                      "GHI_MOI_" & Loai_doi_tuong, "CAP_NHAT_" & Loai_doi_tuong, "XOA_" & Loai_doi_tuong}.ToList
        Xuat_Chuc_nang_con_cua_Chuc_nang(Danh_sach_Ten, Danh_sach_Ma_so,
                           Chuc_nang, XL_Chon_Chuc_nang)
    End Sub
    Protected Sub Xuat_Chuc_nang_Con_cua_Nhan_vien(Chuc_nang As ToolStripMenuItem,
                                                                XL_Chon_Chuc_nang As EventHandler)
        Dim Loai_doi_tuong As String = "NHAN_VIEN" ' Loại đối tượng Con người - Đối tượng Quản lý chính của ứng dụng
        Dim Danh_sach_Ten As List(Of String) = New String() {
                            "Tra cứu theo đơn vị", "Tra cứu theo họ tên", "Tra cứu theo mức lương",
                            "Thêm mới", "Cập nhật", "Xóa",
                              "Thống kê  theo đơn vị"}.ToList
        Dim Danh_sach_Ma_so As List(Of String) = New String() {
                          "TRA_CUU_" & Loai_doi_tuong & "_DON_VI", "TRA_CUU_" & Loai_doi_tuong & "_HO_TEN", "TRA_CUU_" & Loai_doi_tuong & "_MUC_LUONG",
                           "GHI_MOI_" & Loai_doi_tuong, "CAP_NHAT_" & Loai_doi_tuong, "XOA_" & Loai_doi_tuong,
                           "THONG_KE_" & Loai_doi_tuong & "_DON_VI"}.ToList
        Xuat_Chuc_nang_con_cua_Chuc_nang(Danh_sach_Ten, Danh_sach_Ma_so,
                           Chuc_nang, XL_Chon_Chuc_nang)

    End Sub
#End Region



End Class
