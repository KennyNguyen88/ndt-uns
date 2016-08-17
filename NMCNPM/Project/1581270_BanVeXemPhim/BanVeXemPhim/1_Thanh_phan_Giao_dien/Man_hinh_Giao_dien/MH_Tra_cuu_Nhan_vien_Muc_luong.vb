' Thông báo PET : Các màn hình  Tra cưu nhân viên theo họ tên, mức lương   rất giống nhau 
' Có cách nào chỉ lập trình 1 màn hình chung ?
Public Class MH_Tra_cuu_Nhan_vien_Muc_luong

#Region "Biến/Đối tượng toàn cục"
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
    Protected The_hien As XL_THE_HIEN
#End Region

#Region "Xử lý Biến cố Khởi động"
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

        '2.===Khởi động thể hiện ===
        ' ==== Màn hình 
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Black
        Me.ForeColor = Color.White
        '===Tiêu đề 
        Dim Tieu_de As String = "Tra cứu nhân viên theo mức lương"
        Th_Tieu_de.Text = Tieu_de
        '===Thực đơn tỉnh : Hiện nay chưa xem xét 

        '===Thực đơn động :  Hiện nay chưa xem xét 

        '=== Thông báo :  
        Dim Thong_bao As String = "Nhập mức lương có dạng Cận dưới - Cận trên và kết thúc với Enter" & vbCrLf
        Th_Thong_bao.Text = Thong_bao
        '=== Tiêu chí Tra cứu : Chuỗi Mức lương 
        Th_Chuoi_Muc_luong.Text = "4000000-7000000"
        AddHandler Th_Chuoi_Muc_luong.KeyDown, AddressOf XL_Nhap_Chuoi_Muc_luong
        '=== Kêt quả Tra cứu : Danh_sách nhân viên
        Th_Danh_sach_Nhan_vien.Size = New Size(1200, 550)
        Th_Danh_sach_Nhan_vien.AutoScroll = True
    End Sub

#End Region

#Region "Xử lý Biến cố Chính - Nhập Chuỗi Mức lương"
    Sub XL_Nhap_Chuoi_Muc_luong(Th_Nhap As TextBox, Bc As KeyEventArgs)
        If Bc.KeyCode = Keys.Enter Then
            Dim Chuoi_loi As String = Kiem_tra_Nhap_Chuoi_Muc_luong()
            If Chuoi_loi = "" Then
                Thuc_hien_Tra_cuu_Nhan_vien_Muc_luong()
            Else
                Dim Thong_bao As String = Chuoi_loi
                Th_Thong_bao.Text = Thong_bao
            End If
        End If
    End Sub
    Sub Thuc_hien_Tra_cuu_Nhan_vien_Muc_luong()
        Dim Chuoi_Muc_luong As String = Th_Chuoi_Muc_luong.Text.Trim
        Dim M As String() = Split(Chuoi_Muc_luong, "-")
        Dim Can_duoi As Double = M(0)
        Dim Can_tren As Double = M(1)

        Dim Danh_sach_Nhan_vien As List(Of XL_NHAN_VIEN) = Ung_dung.Danh_sach_Nhan_vien_theo_Muc_luong(Can_duoi, Can_tren)
        The_hien.Xuat_Danh_sach_Nhan_vien(Danh_sach_Nhan_vien, Th_Danh_sach_Nhan_vien, Nothing)
        ''=== Xử lý thông báo =================
        Dim Thong_bao As String = "Kêt quả : Tìm thấy " & Danh_sach_Nhan_vien.Count & " nhân viên có mức lương thuộc đoạn  " & Chuoi_Muc_luong
        Th_Thong_bao.Text = Thong_bao
    End Sub

    Function Kiem_tra_Nhap_Chuoi_Muc_luong() As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean
        Dim Chuoi_Muc_luong As String = Th_Chuoi_Muc_luong.Text.Trim
        Hop_le = Chuoi_Muc_luong.Contains("-")
        If Hop_le Then
            Dim M As String() = Split(Chuoi_Muc_luong, "-")
            Hop_le = M.Count = 2 AndAlso IsNumeric(M(0)) AndAlso IsNumeric(M(1))
        End If
        If Not Hop_le Then
            Kq &= "Mức lương nhập có dạng Can_duoi - Can_tren với Can_duoi,Can_tren là 2 số nguyên"
        End If
        Return Kq
    End Function
#End Region


End Class