Public Class MH_Tra_Cuu_Suat_Chieu_Beta
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
        ''1.==== Khởi động các Control :  
        Khoi_Dong_Phim()
        Khoi_Dong_Ca_Chieu()
        Khoi_Dong_Ngay_Chieu()
        If Danh_Sach_Phim.Count > 0 And Danh_Sach_Ca_Chieu.Count > 0 Then
            Khoi_Dong_Ket_Qua()
        Else
            lbThongBao.Text = "Không tìm thấy phim hoặc ca chiếu phù hợp"
        End If
        ' ==== Màn hình 
        'Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Black
        Me.ForeColor = Color.White
        ''===Tiêu đề 
        Dim Tieu_de As String = "Tra cứu suất chiếu"
        lbTieuDe.Text = Tieu_de.ToUpper
        'Order
        ' flDetail.BringToFront()
    End Sub
    Sub Khoi_Dong_Phim()
        'Du lieu: Phim co suat chieu >= today
        Danh_Sach_Phim = Ung_dung.Danh_Sach_Phim_Xuat_Chieu_Sau_Ngay(Date.Today)
        If Danh_Sach_Phim.Count > 0 Then
            The_hien.Xuat_Danh_Sach_Phim(Danh_Sach_Phim, flPhim, AddressOf XL_Chon_Phim)
        End If
    End Sub
#Region "Xử lý Biến cố chính - Chọn Tên Phim"
    Sub XL_Chon_Phim(chbPhim As CheckBox, Bc As EventArgs)
        Tim_Kiem_Xuat_Chieu()
    End Sub
#End Region
    Sub Khoi_Dong_Ca_Chieu()
        'Du lieu: Phim co suat chieu >= today
        Danh_Sach_Ca_Chieu = Ung_dung.Danh_sach_Ca_Chieu()
        If Danh_Sach_Ca_Chieu.Count > 0 Then
            The_hien.Xuat_Danh_Sach_Ca_Chieu(Danh_Sach_Ca_Chieu, flCaChieu, AddressOf XL_Chon_Ca_Chieu)
        End If

    End Sub
#Region "Xử lý Biến cố chính - Chọn Ca Chiếu"
    Sub XL_Chon_Ca_Chieu(cbCaChieu As CheckBox, Bc As EventArgs)
        Tim_Kiem_Xuat_Chieu()
    End Sub
#End Region
    Sub Khoi_Dong_Ngay_Chieu()
        dtpNgayChieu.MinDate = DateTime.Today
        dtpNgayChieu.Value = DateTime.Today
        AddHandler dtpNgayChieu.ValueChanged, AddressOf XL_Chon_Ngay_Chieu
    End Sub
#Region "Xử lý Biến cố chính - Chọn Ngày Chiếu"
    Sub XL_Chon_Ngay_Chieu(dtpNgayChieu As DateTimePicker, Bc As EventArgs)
        Tim_Kiem_Xuat_Chieu()
    End Sub
#End Region
    Sub Khoi_Dong_Ket_Qua()
        Tim_Kiem_Xuat_Chieu()
    End Sub
    Sub Tim_Kiem_Xuat_Chieu()
        Danh_Sach_Xuat_Chieu.Clear()
        flResults.Controls.Clear()
        flDetail.Controls.Clear()
        For Each cbphim As CheckBox In flPhim.Controls
            For Each cbCaChieu As CheckBox In flCaChieu.Controls
                If cbphim.Checked And cbCaChieu.Checked Then
                    Danh_Sach_Xuat_Chieu.AddRange(Ung_dung.Danh_sach_Xuat_Chieu_Theo_Phim_Ca_Ngay(cbphim.Tag.ID, cbCaChieu.Tag.ID, dtpNgayChieu.Value))
                End If
            Next
        Next
        If Danh_Sach_Xuat_Chieu.Count > 0 Then
            lbThongBao.Text = "Tìm thấy " & Danh_Sach_Xuat_Chieu.Count & " suất chiếu phù hợp"
            The_hien.Xuat_Danh_sach_Xuat_Chieu_Beta(Danh_Sach_Xuat_Chieu, flResults, AddressOf XL_Chon_Xuat_Chieu_Chi_Tiet, AddressOf XL_Chon_Xuat_Chieu_Xoa, AddressOf XL_Chon_Xuat_Chieu_CapNhat)
        Else
            lbThongBao.Text = "Không tìm thấy kết quả phù hợp"
        End If
    End Sub
#Region "Xử lý Biến cố chính - Chi Tiết Suất Chiếu"
    Sub XL_Chon_Xuat_Chieu_Chi_Tiet(btnXuatChieu As Button, Bc As EventArgs)
        flDetail.Controls.Clear()
        Dim xuatchieu As XL_XUAT_CHIEU = btnXuatChieu.Tag
        Dim lbThongTin As Label = New Label
        lbThongTin.Text = xuatchieu.Tao_Chuoi_Thong_tin
        lbThongTin.AutoSize = True
        lbThongTin.Font = New Font(lbThongTin.Font.Name, 14, lbThongTin.Font.Style)
        flDetail.Controls.Add(lbThongTin)

    End Sub
    Sub XL_Chon_Xuat_Chieu_Xoa(btnXuatChieu As Button, Bc As EventArgs)


    End Sub
    Sub XL_Chon_Xuat_Chieu_CapNhat(btnXuatChieu As Button, Bc As EventArgs)


    End Sub
#End Region


End Class