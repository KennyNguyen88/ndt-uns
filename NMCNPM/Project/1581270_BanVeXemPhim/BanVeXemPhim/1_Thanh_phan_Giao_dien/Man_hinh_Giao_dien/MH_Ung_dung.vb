
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
        Luu_tru = New XL_LUU_TRU("DO_AN")
        Dim Du_lieu As DataSet = Luu_tru.Doc_Du_lieu
        Ung_dung = New XL_UNG_DUNG(Du_lieu)
        The_hien = New XL_THE_HIEN(Ung_dung)

        Dong_ho.Tao_Chuoi_Thoi_gian_do("Đọc dữ liệu :")
        Khoi_dong()
        'Th_Thong_bao.Text &= Dong_ho.Tao_Chuoi_Thoi_gian_do("Khởi động màn hình:")


    End Sub

    Sub Khoi_dong()
        '1 ==== Khởi động dữ liệu

        '2 ===== Khởi động thể hiện
        ' ==== Màn hình 
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Black
        Me.ForeColor = Color.White
        '===Tiêu đề 
        Dim Tieu_de As String = "Quản lý Bán Vé 1"
        Th_Tieu_de.Text = Tieu_de
        '===Thực đơn tỉnh
        The_hien.Xuat_Thuc_don_Ttnh_cua_Ung_dung(Thuc_don, AddressOf XL_Chon_Chuc_nang)
        '===Thực đơn động 
        The_hien.Tao_Thuc_don_dong_cua_Ung_dung(Me, AddressOf XL_Chon_Chuc_nang)
        '=== Thông báo 
        Th_Thong_bao.Padding = New Padding(10)
        Dim Thong_bao As String = ""
        Th_Thong_bao.Text = Thong_bao
    End Sub
#End Region

#Region "Xử lý Biến cố Chính - Chọn chức năng "
    Sub XL_Chon_Chuc_nang(Th_Chuc_nang As ToolStripItem, Bc As EventArgs)
        Dim Ma_so_Chon As String = Th_Chuc_nang.Tag
        If Ma_so_Chon = "KET_THUC" Then
            Me.Close()
            '=== Chức năng Tra Cứu
        ElseIf Ma_so_Chon = "TRA_CUU_SUAT_CHIEU" Then
            Dim Mh As New MH_Tra_Cuu_Suat_Chieu(Ung_dung)
            Mh.ShowDialog()
        ElseIf Ma_so_Chon = "TRA_CUU_SUAT_CHIEU_BETA" Then
            Dim Mh As New MH_Tra_Cuu_Suat_Chieu_Beta(Ung_dung)
            Mh.ShowDialog()
            '=== Chức năng Quản Lý
        ElseIf Ma_so_Chon = "QUAN_LY_RAP_CHIEU_PHIM" Then
            Dim Mh As New MH_Quan_Ly_Rap(Ung_dung)
            Mh.ShowDialog()
            'Dim Thong_bao As String = "Sẽ thực hiện chức năng" & Ma_so_Chon & " ở lần nâng cấp sau" & vbCrLf
            'Th_Thong_bao.Text = Thong_bao
        ElseIf Ma_so_Chon = "QUAN_LY_PHIM" Then
            Dim Mh As New MH_Quan_Ly_Phim(Ung_dung)
            Mh.ShowDialog()
            'Dim Thong_bao As String = "Sẽ thực hiện chức năng" & Ma_so_Chon & " ở lần nâng cấp sau" & vbCrLf
            'Th_Thong_bao.Text = Thong_bao
        ElseIf Ma_so_Chon = "QUAN_LY_CA_CHIEU" Then
            Dim Mh As New MH_Quan_Ly_Ca_Chieu(Ung_dung)
            Mh.ShowDialog()
            'Dim Thong_bao As String = "Sẽ thực hiện chức năng" & Ma_so_Chon & " ở lần nâng cấp sau" & vbCrLf
            'Th_Thong_bao.Text = Thong_bao
        ElseIf Ma_so_Chon = "QUAN_LY_XUAT_CHIEU" Then
            Dim Mh As New MH_Quan_Ly_Suat_Chieu(Ung_dung)
            Mh.ShowDialog()
            'Dim Thong_bao As String = "Sẽ thực hiện chức năng" & Ma_so_Chon & " ở lần nâng cấp sau" & vbCrLf
            'Th_Thong_bao.Text = Thong_bao
        ElseIf Ma_so_Chon = "QUAN_LY_PHONG" Then
            Dim Mh As New MH_Quan_Ly_Phong(Ung_dung)
            Mh.ShowDialog()
            'Dim Thong_bao As String = "Sẽ thực hiện chức năng" & Ma_so_Chon & " ở lần nâng cấp sau" & vbCrLf
            'Th_Thong_bao.Text = Thong_bao
        ElseIf Ma_so_Chon = "QUAN_LY_LOAI_PHONG" Then
            Dim Mh As New MH_Quan_Ly_Loai_Phong(Ung_dung)
            Mh.ShowDialog()
            'Dim Thong_bao As String = "Sẽ thực hiện chức năng" & Ma_so_Chon & " ở lần nâng cấp sau" & vbCrLf

            'Th_Thong_bao.Text = Thong_bao
        ElseIf Ma_so_Chon = "QUAN_LY_VE" Then
            Dim Mh As New MH_Chon_Suat_Chieu(Ung_dung)
            Mh.ShowDialog()
            'Dim Thong_bao As String = "Sẽ thực hiện chức năng" & Ma_so_Chon & " ở lần nâng cấp sau" & vbCrLf
            'Th_Thong_bao.Text = Thong_bao
        ElseIf Ma_so_Chon = "QUAN_LY_GHE" Then
            Dim Mh As New MH_Quan_ly_Ghe(Ung_dung)
            Mh.ShowDialog()
            'Dim Thong_bao As String = "Sẽ thực hiện chức năng" & Ma_so_Chon & " ở lần nâng cấp sau" & vbCrLf
            'Th_Thong_bao.Text = Thong_bao
        End If

    End Sub

#End Region




End Class