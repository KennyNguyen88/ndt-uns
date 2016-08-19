Public Class MH_Tra_Cuu_Suat_Chieu
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
    Protected The_hien As XL_THE_HIEN

    Public Sub New(Ung_dung As XL_UNG_DUNG)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Luu_tru = New XL_LUU_TRU
        Me.Ung_dung = Ung_dung
        The_hien = New XL_THE_HIEN(Ung_dung)
        Khoi_dong()
    End Sub
    Sub Khoi_dong()
        '1.==== Khởi động dữ liệu :  
        Khoi_Dong_Phim()
        Khoi_Dong_Ca_Chieu()
        Khoi_Dong_Ngay_Chieu()
        Khoi_Dong_Ket_Qua()
        '2.===Khởi động thể hiện ===
        ' ==== Màn hình 
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Black
        Me.ForeColor = Color.White
        '===Tiêu đề 
        Dim Tieu_de As String = "Tra cứu suất chiếu"
        Th_Tieu_de.Text = Tieu_de.ToUpper
        '===Thực đơn tỉnh : Hiện nay chưa xem xét 
        '===Thực đơn động :  Hiện nay chưa xem xét 
        '=== Thông báo :  
        Dim Thong_bao As String = "" & vbCrLf
        Th_Thong_bao.Text = Thong_bao
        '=== Tiêu chí Tra cứu : Tên Phim
        AddHandler cbPhim.SelectedIndexChanged, AddressOf XL_Chon_Phim
        '=== Tiêu chí Tra cứu : Tên Ca Chiếu
        AddHandler cbCaChieu.SelectedIndexChanged, AddressOf XL_Chon_Ca_Chieu
        '=== Tiêu chí Tra cứu : Ngày Chiếu
        AddHandler dtpNgayChieu.ValueChanged, AddressOf XL_Chon_Ngay_Chieu
    End Sub

    Sub Khoi_Dong_Phim()
        Dim Danh_Sach_Phim As List(Of XL_PHIM)
        'TODO Khoi_Dong_Du_Lieu_Phim
        'TODO khoi dong the hien cho phim - selected index
    End Sub

    Sub Khoi_Dong_Ca_Chieu()
        Dim Danh_Sach_Ca_Chieu As List(Of XL_CA_CHIEU)
        'TODO Khoi_Dong_Du_Lieu_Ca_Chieu
        'TODO khoi dong the hien cho ca chieu - selected index
    End Sub

    Sub Khoi_Dong_Ngay_Chieu()
        dtpNgayChieu.MinDate = DateTime.Today
        dtpNgayChieu.Value = DateTime.Today
    End Sub

    Sub Khoi_Dong_Ket_Qua()
        Dim Danh_Sach_Xuat_Chieu As List(Of XL_XUAT_CHIEU)
        'TODO Khoi_Dong_Danh_Sach_Ket_Qua
    End Sub
#Region "Xử lý Biến cố chính - Chọn Tên Phim"
    Sub XL_Chon_Phim(cbPhim As ComboBox, Bc As KeyEventArgs)
        'If Bc.KeyCode = Keys.Enter Then
        '    Dim Chuoi_loi As String = Kiem_tra_Nhap_Chuoi_Ho_ten()
        '    If Chuoi_loi = "" Then
        '        Thuc_hien_Tra_cuu_Nhan_vien_Ho_ten()
        '    Else
        '        Dim Thong_bao As String = Chuoi_loi
        '        Th_Thong_bao.Text = Thong_bao
        '    End If
        'End If
    End Sub
    'Sub Thuc_hien_Tra_cuu_Nhan_vien_Ho_ten()
    '    Dim Dong_ho As New XL_DONG_HO_PET

    '    Dim Chuoi_Ho_ten As String = Th_Chuoi_Ho_ten.Text.Trim
    '    Dim Danh_sach_Nhan_vien As List(Of XL_NHAN_VIEN) = Ung_dung.Danh_sach_Nhan_vien_theo_Ho_ten(Chuoi_Ho_ten)
    '    Dong_ho.Tao_Chuoi_Thoi_gian_do("Xử lý BL :")
    '    The_hien.Xuat_Danh_sach_Nhan_vien(Danh_sach_Nhan_vien, Th_Danh_sach_Nhan_vien, Nothing)
    '    Dim Thong_bao As String = "Kêt quả : Tìm thấy " & Danh_sach_Nhan_vien.Count & " nhân viên có họ tên chứa chuỗi  " & Chuoi_Ho_ten
    '    Th_Thong_bao.Text = Thong_bao
    '    Th_Thong_bao.Text &= Dong_ho.Tao_Chuoi_Thoi_gian_do("Xử lý VL :")
    'End Sub
    'Function Kiem_tra_Nhap_Chuoi_Ho_ten() As String
    '    Dim Kq As String = ""
    '    Dim Hop_le As Boolean
    '    Dim Chuoi_Ho_ten As String = Th_Chuoi_Ho_ten.Text.Trim
    '    Hop_le = Not Chuoi_Ho_ten.Contains("'") And Not Chuoi_Ho_ten.Contains("""")
    '    If Not Hop_le Then
    '        Kq &= "Chuỗi nhập không được chứa ' hay """
    '    End If
    '    Return Kq
    'End Function
#End Region

#Region "Xử lý Biến cố chính - Chọn Ca Chiếu"
    Sub XL_Chon_Ca_Chieu(cbCaChieu As ComboBox, Bc As KeyEventArgs)
        'If Bc.KeyCode = Keys.Enter Then
        '    Dim Chuoi_loi As String = Kiem_tra_Nhap_Chuoi_Ho_ten()
        '    If Chuoi_loi = "" Then
        '        Thuc_hien_Tra_cuu_Nhan_vien_Ho_ten()
        '    Else
        '        Dim Thong_bao As String = Chuoi_loi
        '        Th_Thong_bao.Text = Thong_bao
        '    End If
        'End If
    End Sub
#End Region
#Region "Xử lý Biến cố chính - Chọn Ngày Chiếu"
    Sub XL_Chon_Ngay_Chieu(cbNgayChieu As DateTimePicker, Bc As KeyEventArgs)
        'If Bc.KeyCode = Keys.Enter Then
        '    Dim Chuoi_loi As String = Kiem_tra_Nhap_Chuoi_Ho_ten()
        '    If Chuoi_loi = "" Then
        '        Thuc_hien_Tra_cuu_Nhan_vien_Ho_ten()
        '    Else
        '        Dim Thong_bao As String = Chuoi_loi
        '        Th_Thong_bao.Text = Thong_bao
        '    End If
        'End If
    End Sub
#End Region
End Class