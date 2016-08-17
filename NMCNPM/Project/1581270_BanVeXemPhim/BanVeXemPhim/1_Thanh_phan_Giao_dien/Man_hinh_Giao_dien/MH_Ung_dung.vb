
' Thông báo PET :  Màn hình này và tất cả các màn hình khác đều có cùng cấu trúc tổ chức hàm xử lý
' 1. Xử lý Biến cố Khởi động : Luôn luôn có 
' 2. Xử lý Biến cố Chính : Luôn luôn có 
' 3. Xử lý Biến cố Phụ :  Tùy vào thiết kế riêng của màn hình 
'      - Xử lý Biến cố phụ thông dụng nhất là xử lý biến cố chọn chức năng con của riêng màn hình 

Public Class MH_Ung_dung

#Region "Biến/Đối tượng toàn cục"
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
    Protected The_hien As XL_THE_HIEN

#End Region

#Region "Xử lý Biến cố Khởi động"
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Dim Dong_ho As New XL_DONG_HO_PET
        Luu_tru = New XL_LUU_TRU
        Dim Du_lieu As DataSet = Luu_tru.Doc_Du_lieu
        Ung_dung = New XL_UNG_DUNG(Du_lieu)
        The_hien = New XL_THE_HIEN(Ung_dung)

        Dong_ho.Tao_Chuoi_Thoi_gian_do("Đọc dữ liệu :")
        Khoi_dong()
        Th_Thong_bao.Text &= Dong_ho.Tao_Chuoi_Thoi_gian_do("Khởi động màn hình:")


    End Sub

    Sub Khoi_dong()
        '1 ==== Khởi động dữ liệu

        '2 ===== Khởi động thể hiện
        ' ==== Màn hình 
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Black
        Me.ForeColor = Color.White
        '===Tiêu đề 
        Dim Tieu_de As String = "Quản lý nhân viên 1 - UDO -  Ứng dụng minh họa theo Công nghệ giảng dạy PET  2.2"
        Th_Tieu_de.Text = Tieu_de
        '===Thực đơn tỉnh
        The_hien.Xuat_Thuc_don_Ttnh_cua_Ung_dung(Thuc_don, AddressOf XL_Chon_Chuc_nang)
        '===Thực đơn động 
        The_hien.Tao_Thuc_don_dong_cua_Ung_dung(Me, AddressOf XL_Chon_Chuc_nang)
        '=== Thông báo 
        Th_Thong_bao.Padding = New Padding(10)
        Dim Thong_bao As String = ""
        Thong_bao &= "Thông báo PET : Đây vẫn là phiên bản 1 nhưng với công nghệ UDO " & vbCrLf
        Thong_bao &= " - Cải tiến quan trọng của phiên bản là việc sử dụng các hàm  class XL_X cho loại đối tượng X" & vbCrLf
        Thong_bao &= "  == > Lập trình đơn giản,dễ mở rộng  hợn rất nhiều so với ADO " & vbCrLf
        Thong_bao &= " - Phiên bản này chỉ là phiên bản mở đầu về UDO và còn rất thô sơ" & vbCrLf
        Thong_bao &= " == > Sẽ còn tiếp tục cải tiến đến phiên bản 2   " & vbCrLf
        Thong_bao &= "   Cải tiến XL_THE_HIEN, bổ sung XL_CHUC_NANG   " & vbCrLf
        Thong_bao &= " Kết thúc thông báo PET  " & vbCrLf & vbCrLf & vbCrLf

        Thong_bao &= "Có thể chọn chức năng của ứng dụng theo 2 cách " & vbCrLf
        Thong_bao &= "1. Sử dụng thực đơn tỉnh " & vbCrLf
        Thong_bao &= "2. Sử dụng thực đơn động " & vbCrLf
        Th_Thong_bao.Text = Thong_bao
    End Sub
#End Region

#Region "Xử lý Biến cố Chính - Chọn chức năng "
    Sub XL_Chon_Chuc_nang(Th_Chuc_nang As ToolStripItem, Bc As EventArgs)
        Dim Ma_so_Chon As String = Th_Chuc_nang.Tag
        If Ma_so_Chon = "KET_THUC" Then
            Me.Close()



        ElseIf Ma_so_Chon = "TRA_CUU_NHAN_VIEN_DON_VI" Then
            Dim Mh As New MH_Tra_cuu_Nhan_vien_Don_vi(Ung_dung)
            Mh.ShowDialog()
        ElseIf Ma_so_Chon = "TRA_CUU_NHAN_VIEN_HO_TEN" Then
            Dim Mh As New MH_Tra_cuu_Nhan_vien_theo_Ho_ten(Ung_dung)
            Mh.ShowDialog()
        ElseIf Ma_so_Chon = "TRA_CUU_NHAN_VIEN_MUC_LUONG" Then
            Dim Mh As New MH_Tra_cuu_Nhan_vien_Muc_luong(Ung_dung)
            Mh.ShowDialog()
        ElseIf Ma_so_Chon = "GHI_MOI_NHAN_VIEN" Then
            Dim Mh As New MH_Ghi_moi_Nhan_vien(Ung_dung)
            Mh.ShowDialog()
        ElseIf Ma_so_Chon = "CAP_NHAT_NHAN_VIEN" Then
            Dim Mh As New MH_Cap_nhat_Nhan_vien(Ung_dung)
            Mh.ShowDialog()
        ElseIf Ma_so_Chon = "XOA_NHAN_VIEN" Then
            Dim Mh As New MH_Xoa_Nhan_vien(Ung_dung)
            Mh.ShowDialog()
        ElseIf Ma_so_Chon = "THONG_KE_NHAN_VIEN_DON_VI" Then
            Dim Mh As New MH_Thong_ke_Nhan_vien_Don_vi(Ung_dung)
            Mh.ShowDialog()

            '=== Chức năng của Loại đối tượng Giới tính 
        ElseIf Ma_so_Chon = "GHI_MOI_GIOI_TINH" Then
            Dim Thong_bao As String = "Sẽ thực hiện chức năng " & Th_Chuc_nang.Text & vbCrLf
            Thong_bao &= "Thông báo PET : Khi nào ?"
            Th_Thong_bao.Text = Thong_bao
        ElseIf Ma_so_Chon = "CAP_NHAT_GIOI_TINH" Then
            Dim Thong_bao As String = "Sẽ thực hiện chức năng " & Th_Chuc_nang.Text & vbCrLf
            Thong_bao &= "Thông báo PET : Khi nào ?"
            Th_Thong_bao.Text = Thong_bao
        ElseIf Ma_so_Chon = "XOA_GIOI_TINH" Then
            Dim Thong_bao As String = "Sẽ thực hiện chức năng " & Th_Chuc_nang.Text & vbCrLf
            Thong_bao &= "Thông báo PET : Khi nào ?"
            Th_Thong_bao.Text = Thong_bao
            '=== Chức năng của Loại đối tượng Công ty
        ElseIf Ma_so_Chon = "CAP_NHAT_CONG_TY" Then
            Dim Thong_bao As String = "Chắc chắn sẽ phải thực hiện chức năng " & Th_Chuc_nang.Text & vbCrLf
            Thong_bao &= "Thông báo PET : Khi nào ?"
            Th_Thong_bao.Text = Thong_bao
            '=== Chức năng của Loại đối tượng Chi nhánh
        ElseIf Ma_so_Chon = "GHI_MOI_CHI_NHANH" Then
            Dim Thong_bao As String = "Thông báo PET :  Lập trình chức năng  " & Th_Chuc_nang.Text & vbCrLf
            Thong_bao &= "tương tự như ghi mới nhân viên nhưng dễ hơn rất nhiều"
            Th_Thong_bao.Text = Thong_bao
        ElseIf Ma_so_Chon = "CAP_NHAT_CHI_NHANH" Then
            Dim Thong_bao As String = "Thông báo PET :  Lập trình chức năng  " & Th_Chuc_nang.Text & vbCrLf
            Thong_bao &= "tương tự như cập nhật nhân viên nhưng dễ hơn rất nhiều"
            Th_Thong_bao.Text = Thong_bao
        ElseIf Ma_so_Chon = "XOA_CHI_NHANH" Then
            Dim Thong_bao As String = "Thông báo PET :  Lập trình chức năng  " & Th_Chuc_nang.Text & vbCrLf
            Thong_bao &= "tương tự như xóa  nhân viên nhưng phải kiểm tra xóa "
            Th_Thong_bao.Text = Thong_bao
            '=== Chức năng của Loại đối tượng Đơn vị
        ElseIf Ma_so_Chon = "GHI_MOI_DON_VI" Then
            Dim Thong_bao As String = "Thông báo PET :  Lập trình chức năng  " & Th_Chuc_nang.Text & vbCrLf
            Thong_bao &= "tương tự như ghi mới nhân viên nhưng dễ hơn rất nhiều"
            Th_Thong_bao.Text = Thong_bao
        ElseIf Ma_so_Chon = "CAP_NHAT_DON_VI" Then
            Dim Thong_bao As String = "Thông báo PET :  Lập trình chức năng  " & Th_Chuc_nang.Text & vbCrLf
            Thong_bao &= "tương tự như cập nhật nhân viên nhưng dễ hơn rất nhiều"
            Th_Thong_bao.Text = Thong_bao
        ElseIf Ma_so_Chon = "XOA_DON_VI" Then
            Dim Thong_bao As String = "Thông báo PET :  Lập trình chức năng  " & Th_Chuc_nang.Text & vbCrLf
            Thong_bao &= "tương tự như xóa  nhân viên nhưng phải kiểm tra xóa "
            Th_Thong_bao.Text = Thong_bao
        End If

    End Sub

#End Region




End Class