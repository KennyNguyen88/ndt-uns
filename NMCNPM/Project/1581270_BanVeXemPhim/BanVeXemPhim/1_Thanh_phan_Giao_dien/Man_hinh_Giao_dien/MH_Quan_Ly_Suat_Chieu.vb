Public Class MH_Quan_Ly_Suat_Chieu
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
    Protected The_hien As XL_THE_HIEN
    Protected Danh_Sach_Ket_Qua As List(Of XL_XUAT_CHIEU)
    Protected Danh_Sach_Phong As List(Of XL_PHONG)
    Protected Danh_Sach_Phim As List(Of XL_PHIM)
    Protected Danh_Sach_Ca_Chieu As List(Of XL_CA_CHIEU)
    Protected SuatChieuMoi As XL_XUAT_CHIEU
    Protected SuatChieuCu As XL_XUAT_CHIEU
    Public Sub New(Ung_dung As XL_UNG_DUNG)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Luu_tru = New XL_LUU_TRU("DO_AN")
        Me.Ung_dung = Ung_dung
        The_hien = New XL_THE_HIEN(Ung_dung)
        Khoi_dong()
    End Sub
    Public Sub Khoi_dong()
        ''===Tiêu đề 
        Dim Tieu_de As String = "Quản Lý Suất Chiếu"
        lbTieuDe.Text = Tieu_de.ToUpper

        ''==Tìm
        The_hien.dinhDangCombobox(cbPhong_Tim, 96)
        The_hien.dinhDangCombobox(cbPhim_Tim, 136)
        The_hien.dinhDangCombobox(cbCaChieu_Tim, 117)
        The_hien.dinhDangTimePick(dtNgay_Tim, 118, "DATE")
        The_hien.dinhDangButton(btnTim)
        AddHandler btnTim.Click, AddressOf XL_Tim

        '==Thêm
        The_hien.dinhDangCombobox(cbPhong_Them, 96)
        The_hien.dinhDangCombobox(cbPhim_Them, 136)
        The_hien.dinhDangCombobox(cbCaChieu_Them, 117)
        The_hien.dinhDangTimePick(dtNgay_Them, 118, "DATE")
        The_hien.dinhDangButton(btnThem)
        AddHandler btnThem.Click, AddressOf XL_Them

        '==KetQua
        Danh_Sach_Ket_Qua = New List(Of XL_XUAT_CHIEU)
        Danh_Sach_Phong = New List(Of XL_PHONG)
        Danh_Sach_Phong = Ung_dung.Danh_sach_Phong
        Danh_Sach_Phim = New List(Of XL_PHIM)
        Danh_Sach_Phim = Ung_dung.Danh_sach_Phim
        Danh_Sach_Ca_Chieu = New List(Of XL_CA_CHIEU)
        Danh_Sach_Ca_Chieu = Ung_dung.Danh_sach_Ca_Chieu
        KhoiDongPhong()
        KhoiDongPhim()
        KhoiDongCaChieu()
        KhoiDongNgay()
        xuatThongBao("")
        KhoiDongKetQua()
    End Sub
    Public Sub KhoiDongPhong()
        'Tim
        cbPhong_Tim.Items.AddRange(Danh_Sach_Phong.ToArray)
        cbPhong_Tim.SelectedIndex = 0
        cbPhong_Tim.ValueMember = "ID"
        cbPhong_Tim.DisplayMember = "Ten"

        'Them
        cbPhong_Them.Items.AddRange(Danh_Sach_Phong.ToArray)
        cbPhong_Them.SelectedIndex = 0
        cbPhong_Them.ValueMember = "ID"
        cbPhong_Them.DisplayMember = "Ten"
    End Sub
    Public Sub KhoiDongPhim()
        'Tim
        cbPhim_Tim.Items.AddRange(Danh_Sach_Phim.ToArray)
        cbPhim_Tim.SelectedIndex = 0
        cbPhim_Tim.ValueMember = "ID"
        cbPhim_Tim.DisplayMember = "Ten"
        'Them
        cbPhim_Them.Items.AddRange(Danh_Sach_Phim.ToArray)
        cbPhim_Them.SelectedIndex = 0
        cbPhim_Them.ValueMember = "ID"
        cbPhim_Them.DisplayMember = "Ten"
    End Sub
    Public Sub KhoiDongCaChieu()
        'Tim
        cbCaChieu_Tim.Items.AddRange(Danh_Sach_Ca_Chieu.ToArray)
        cbCaChieu_Tim.SelectedIndex = 0
        cbCaChieu_Tim.ValueMember = "ID"
        cbCaChieu_Tim.DisplayMember = "Ten"
        'Them
        cbCaChieu_Them.Items.AddRange(Danh_Sach_Ca_Chieu.ToArray)
        cbCaChieu_Them.SelectedIndex = 0
        cbCaChieu_Them.ValueMember = "ID"
        cbCaChieu_Them.DisplayMember = "Ten"
    End Sub
    Public Sub KhoiDongNgay()
        'Tim
        dtNgay_Tim.Value = DateTime.Today
        'Them
        dtNgay_Them.Value = DateTime.Today
    End Sub
    Public Sub xuatThongBao(thongBao As String)
        lbThongBao.Text = thongBao
    End Sub
    Public Sub KhoiDongKetQua()
        'Tất cả suất chiếu
        Danh_Sach_Ket_Qua = Ung_dung.Danh_sach_Xuat_Chieu()
        XuatKetQua()
    End Sub
    Public Sub XuatKetQua()
        flResult.Controls.Clear()
        If Danh_Sach_Ket_Qua.Count > 0 Then

            For Each ketqua As XL_XUAT_CHIEU In Danh_Sach_Ket_Qua
                Dim item As New FlowLayoutPanel

                Dim txtID_result As New TextBox
                The_hien.dinhDang_ID(txtID_result)
                txtID_result.Text = ketqua.ID
                item.Controls.Add(txtID_result)

                Dim cbPhong_result As New ComboBox
                The_hien.dinhDangCombobox(cbPhong_result, 116)
                cbPhong_result.Name = "cbPhong_result"
                cbPhong_result.ValueMember = "ID"
                cbPhong_result.DisplayMember = "Ten"
                cbPhong_result.Items.AddRange(Danh_Sach_Phong.ToArray)
                cbPhong_result.SelectedIndex = cbPhong_result.FindString(Ung_dung.Phong(ketqua.ID_PHONG).Ten)
                item.Controls.Add(cbPhong_result)

                Dim cbPhim_result As New ComboBox
                The_hien.dinhDangCombobox(cbPhim_result, 136)
                cbPhim_result.Name = "cbPhim_result"
                cbPhim_result.ValueMember = "ID"
                cbPhim_result.DisplayMember = "Ten"
                cbPhim_result.Items.AddRange(Danh_Sach_Phim.ToArray)
                cbPhim_result.SelectedIndex = cbPhim_result.FindString(Ung_dung.Phim(ketqua.ID_PHIM).Ten)
                item.Controls.Add(cbPhim_result)

                Dim cbCaChieu_result As New ComboBox
                The_hien.dinhDangCombobox(cbCaChieu_result, 117)
                cbCaChieu_result.Name = "cbCaChieu_result"
                cbCaChieu_result.ValueMember = "ID"
                cbCaChieu_result.DisplayMember = "Ten"
                cbCaChieu_result.Items.AddRange(Danh_Sach_Ca_Chieu.ToArray)
                cbCaChieu_result.SelectedIndex = cbCaChieu_result.FindString(Ung_dung.Ca_Chieu(ketqua.ID_CA_CHIEU).Ten)
                item.Controls.Add(cbCaChieu_result)

                Dim dtpNgayChieu_result As New DateTimePicker
                The_hien.dinhDangTimePick(dtpNgayChieu_result, 118, "DATE")
                dtpNgayChieu_result.Name = "dtpNgayChieu_result"
                dtpNgayChieu_result.Value = ketqua.Ngay
                item.Controls.Add(dtpNgayChieu_result)

                Dim btnSua_result As New Button
                The_hien.dinhDangButton(btnSua_result)
                btnSua_result.Text = "Sửa"
                btnSua_result.Tag = ketqua
                AddHandler btnSua_result.Click, AddressOf XL_Sua
                item.Controls.Add(btnSua_result)

                Dim btnXoa_result As New Button
                The_hien.dinhDangButton(btnXoa_result)
                btnXoa_result.Text = "Xóa"
                btnXoa_result.Tag = ketqua
                AddHandler btnXoa_result.Click, AddressOf XL_Xoa
                item.Controls.Add(btnXoa_result)

                The_hien.dinhDang_item(item, 850, 50)
                flResult.Controls.Add(item)
            Next
        End If
    End Sub
#Region "Xử lý biến cố chính - Tìm"
    Sub XL_Tim(btnTim As Button, Bc As EventArgs)
        'TODO: kiem tra co du lieu dang edit
        Danh_Sach_Ket_Qua = Tim_Kiem()
        XuatKetQua()
        'TODO: xuat thong bao khi research ?
        'xuatThongBao()
    End Sub
    Public Function Tim_Kiem() As List(Of XL_XUAT_CHIEU)
        Dim dsKetQua As List(Of XL_XUAT_CHIEU)
        Dim phong As Integer = cbPhong_Tim.SelectedItem.ID
        Dim phim As Integer = cbPhim_Tim.SelectedItem.ID
        Dim cachieu As Integer = cbCaChieu_Tim.SelectedItem.ID
        Dim ngay As Date = dtNgay_Tim.Value
        dsKetQua = Ung_dung.Danh_sach_Xuat_Chieu_Theo_Phong_Phim_Ca_Ngay(phong, phim, cachieu, ngay)
        Return dsKetQua
    End Function
#End Region
#Region "Xử lý biến cố chính - Thêm"
    Sub XL_Them(btnThem As Button, Bc As EventArgs)
        Dim kqThem = Them_Moi()
        If kqThem.Equals("") Then
            'Them success
            If Phat_Sinh_Ve().Equals("") Then
                'Phat sinh ve success
                xuatThongBao("Đã thêm mới suất chiếu và phát sinh vé thành công !")
                'research
                btnTim.PerformClick()
            Else
                'Phat sinh ve fail
                'Xoa suat chieu
                Dim kqXoa = Xoa(SuatChieuMoi)
                If kqXoa.Equals("") Then
                    xuatThongBao("Phát sinh vé không thành công ! Suất chiếu đã được xóa")
                Else
                    xuatThongBao("Phát sinh vé không thành công ! Xóa suất chiếu không thành công")
                End If
            End If
        Else
            'Them fail
            xuatThongBao(kqThem)
        End If
    End Sub
    Public Function Them_Moi() As String
        Dim suatChieu = Ung_dung.Tao_Suat_Chieu_Moi()
        suatChieu.ID_PHONG = cbPhong_Them.SelectedItem.ID
        suatChieu.ID_PHIM = cbPhim_Them.SelectedItem.ID
        suatChieu.ID_CA_CHIEU = cbCaChieu_Them.SelectedItem.ID
        suatChieu.Ngay = dtNgay_Them.Value

        If suatChieu.Kiem_Tra_Ghi_Moi().Equals("") Then
            SuatChieuMoi = suatChieu
            Return Luu_tru.Ghi(suatChieu.Dong, LOAI_GHI.Ghi_moi)
        Else
            Return suatChieu.Kiem_Tra_Ghi_Moi()
        End If
    End Function
    Public Function Phat_Sinh_Ve() As String
        'TODO PhatSinhVe
        Dim kq = ""
        Dim ID_Phong = cbPhong_Them.SelectedItem.ID
        Dim dsGhe As List(Of XL_GHE) = Ung_dung.Danh_sach_Ghe_Theo_Phong(ID_Phong)
        For Each objGhe As XL_GHE In dsGhe
            Dim objVe = Ung_dung.Tao_Ve_Moi
            objVe.ID_GHE = objGhe.ID
            objVe.ID_XUAT_CHIEU = SuatChieuMoi.ID
            objVe.TRANG_THAI = "Chưa bán"
            If objVe.Kiem_Tra_Ghi_Moi().Equals("") Then
                Luu_tru.Ghi(objVe.Dong, LOAI_GHI.Ghi_moi)
            Else
                kq = objVe.Kiem_Tra_Ghi_Moi()
                Return kq
            End If
        Next
        Return kq
    End Function
#End Region
#Region "Xử lý biến cố chính - Xóa"
    Sub XL_Xoa(btnXoa As Button, Bc As EventArgs)
        Dim kqXoa = Xoa(btnXoa.Tag)
        If kqXoa.Equals("") Then
            'Xoa Thanh Cong
            xuatThongBao("Đã xóa thành công ! ")
            'research
            btnTim.PerformClick()
        Else
            xuatThongBao(kqXoa)
        End If
    End Sub

    Public Function Xoa(suatChieu As XL_XUAT_CHIEU) As String
        If suatChieu.Kiem_Tra_Xoa().Equals("") Then
            Return Luu_tru.Ghi(suatChieu.Dong, LOAI_GHI.Xoa)
        Else
            Return suatChieu.Kiem_Tra_Xoa()
        End If
    End Function
#End Region
#Region "Xử lý biến cố chính - Sửa"
    Sub XL_Sua(btnSua As Button, Bc As EventArgs)
        Dim suatChieu As XL_XUAT_CHIEU = btnSua.Tag
        SuatChieuCu = btnSua.Tag
        Dim phong As ComboBox = btnSua.Parent.Controls("cbPhong_result")
        suatChieu.ID_PHONG = phong.SelectedItem.ID
        Dim phim As ComboBox = btnSua.Parent.Controls("cbPhim_result")
        suatChieu.ID_PHIM = phim.SelectedItem.ID
        Dim caChieu As ComboBox = btnSua.Parent.Controls("cbCaChieu_result")
        suatChieu.ID_CA_CHIEU = caChieu.SelectedItem.ID
        Dim ngay As DateTimePicker = btnSua.Parent.Controls("dtpNgayChieu_result")
        suatChieu.Ngay = ngay.Value
        Dim kqSua = Sua(suatChieu)
        If kqSua.Equals("") Then
            'Sua success
            If Phat_Sinh_Ve().Equals("") Then
                'Phat sinh ve success
                xuatThongBao("Đã cập nhật và phát sinh vé thành công thông tin suất chiếu có ID " & suatChieu.ID)
                'research
                btnTim.PerformClick()
            Else
                'Phat sinh ve fail
                'undo Sua
                Dim kqUndo = Sua(SuatChieuCu)
                If kqUndo.Equals("") Then
                    xuatThongBao("Phát sinh vé không thành công ! Suất chiếu đã được hoàn tác")
                Else
                    xuatThongBao("Phát sinh vé không thành công ! Hoàn tác suất chiếu không thành công")
                End If
            End If
        Else
            'Sua fail
            xuatThongBao(kqSua)
        End If
    End Sub
    Public Function Sua(suatChieu As XL_XUAT_CHIEU) As String
        If suatChieu.Kiem_Tra_Sua().Equals("") Then
            Return Luu_tru.Ghi(suatChieu.Dong, LOAI_GHI.Cap_nhat)
        Else
            Return suatChieu.Kiem_Tra_Sua()
        End If
    End Function
#End Region
End Class