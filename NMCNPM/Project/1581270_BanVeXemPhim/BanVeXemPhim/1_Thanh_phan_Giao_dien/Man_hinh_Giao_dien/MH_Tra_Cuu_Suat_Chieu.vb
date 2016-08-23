Public Class MH_Tra_Cuu_Suat_Chieu
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
    Protected The_hien As XL_THE_HIEN
    Protected Danh_Sach_Phim As List(Of XL_PHIM)
    Protected Danh_Sach_Ca_Chieu As List(Of XL_CA_CHIEU)
    Protected Danh_Sach_Xuat_Chieu As List(Of XL_XUAT_CHIEU)

    Public Sub New(Ung_dung As XL_UNG_DUNG)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Luu_tru = New XL_LUU_TRU
        Me.Ung_dung = Ung_dung
        The_hien = New XL_THE_HIEN(Ung_dung)
        Danh_Sach_Phim = New List(Of XL_PHIM)
        Danh_Sach_Ca_Chieu = New List(Of XL_CA_CHIEU)
        Danh_Sach_Xuat_Chieu = New List(Of XL_XUAT_CHIEU)
        Khoi_dong()
    End Sub
    Sub Khoi_dong()
        '1.==== Khởi động các Control :  
        Khoi_Dong_Phim()
        Khoi_Dong_Ca_Chieu()
        Khoi_Dong_Ngay_Chieu()
        Khoi_Dong_Ket_Qua()
        ' ==== Màn hình 
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Black
        Me.ForeColor = Color.White
        '===Tiêu đề 
        Dim Tieu_de As String = "Tra cứu suất chiếu"
        Th_Tieu_de.Text = Tieu_de.ToUpper
        '===Thực đơn tỉnh : Hiện nay chưa xem xét 
        '===Thực đơn động :  Hiện nay chưa xem xét 
        '=== Tiêu chí Tra cứu : Tên Phim
        AddHandler cbPhim.SelectedIndexChanged, AddressOf XL_Chon_Phim
        '=== Tiêu chí Tra cứu : Tên Ca Chiếu
        AddHandler cbCaChieu.SelectedIndexChanged, AddressOf XL_Chon_Ca_Chieu
        '=== Tiêu chí Tra cứu : Ngày Chiếu
        AddHandler dtpNgayChieu.ValueChanged, AddressOf XL_Chon_Ngay_Chieu
    End Sub

    Sub Khoi_Dong_Phim()
        'Du lieu: Phim co suat chieu >= today
        Danh_Sach_Phim = Ung_dung.Danh_Sach_Phim_Xuat_Chieu_Sau_Ngay(Date.Today)
        'The hien
        The_hien.Xuat_Danh_Sach_Phim(Danh_Sach_Phim, cbPhim)
    End Sub

    Sub Khoi_Dong_Ca_Chieu()
        'Du lieu: toan bo Ca Chieu
        Danh_Sach_Ca_Chieu = Ung_dung.Danh_sach_Ca_Chieu()
        'The hien
        The_hien.Xuat_Danh_Sach_Ca_Chieu(Danh_Sach_Ca_Chieu, cbCaChieu)
    End Sub

    Sub Khoi_Dong_Ngay_Chieu()
        dtpNgayChieu.MinDate = DateTime.Today
        dtpNgayChieu.Value = DateTime.Today
    End Sub

    Sub Khoi_Dong_Ket_Qua()
        Tim_Kiem_Xuat_Chieu()
    End Sub
#Region "Xử lý Biến cố chính - Chọn Tên Phim"
    Sub XL_Chon_Phim(cbPhim As ComboBox, Bc As EventArgs)
        Tim_Kiem_Xuat_Chieu()
    End Sub
#End Region
#Region "Xử lý Biến cố chính - Chọn Ca Chiếu"
    Sub XL_Chon_Ca_Chieu(cbCaChieu As ComboBox, Bc As EventArgs)
        Tim_Kiem_Xuat_Chieu()
    End Sub
#End Region
#Region "Xử lý Biến cố chính - Chọn Ngày Chiếu"
    Sub XL_Chon_Ngay_Chieu(cbNgayChieu As DateTimePicker, Bc As EventArgs)
        Tim_Kiem_Xuat_Chieu()
    End Sub
#End Region


    Sub Tim_Kiem_Xuat_Chieu()
        Danh_Sach_Xuat_Chieu.Clear()
        flResult.Controls.Clear()
        If Danh_Sach_Phim.Count <= 0 Or Danh_Sach_Ca_Chieu.Count <= 0 Then
            Th_Thong_bao.Text = "Không tìm thấy kết quả phù hợp"
            Return
        End If
        If cbPhim.SelectedIndex = 0 Then 'All
            For Each phim As XL_PHIM In Danh_Sach_Phim
                If cbCaChieu.SelectedIndex = 0 Then 'All
                    For Each cachieu As XL_CA_CHIEU In Danh_Sach_Ca_Chieu
                        Danh_Sach_Xuat_Chieu.AddRange(Ung_dung.Danh_sach_Xuat_Chieu_Theo_Phim_Ca_Ngay(phim.ID, cachieu.ID, dtpNgayChieu.Value))
                    Next
                Else
                    Danh_Sach_Xuat_Chieu.AddRange(Ung_dung.Danh_sach_Xuat_Chieu_Theo_Phim_Ca_Ngay(phim.ID, cbCaChieu.SelectedItem.ID, dtpNgayChieu.Value))
                End If
            Next
        ElseIf cbPhim.SelectedIndex > 0 Then
            If cbCaChieu.SelectedIndex = 0 Then 'All
                For Each cachieu As XL_CA_CHIEU In Danh_Sach_Ca_Chieu
                    Danh_Sach_Xuat_Chieu.AddRange(Ung_dung.Danh_sach_Xuat_Chieu_Theo_Phim_Ca_Ngay(cbPhim.SelectedItem.ID, cachieu.ID, dtpNgayChieu.Value))
                Next
            Else
                Danh_Sach_Xuat_Chieu.AddRange(Ung_dung.Danh_sach_Xuat_Chieu_Theo_Phim_Ca_Ngay(cbPhim.SelectedItem.ID, cbCaChieu.SelectedItem.ID, dtpNgayChieu.Value))
            End If
        End If
        If Danh_Sach_Xuat_Chieu.Count > 0 Then
            Th_Thong_bao.Text = "Tìm thấy " & Danh_Sach_Xuat_Chieu.Count & " suất chiếu phù hợp"
            The_hien.Xuat_Danh_sach_Xuat_Chieu(Danh_Sach_Xuat_Chieu, flResult)
        Else
            Th_Thong_bao.Text = "Không tìm thấy kết quả phù hợp"
        End If
    End Sub
End Class