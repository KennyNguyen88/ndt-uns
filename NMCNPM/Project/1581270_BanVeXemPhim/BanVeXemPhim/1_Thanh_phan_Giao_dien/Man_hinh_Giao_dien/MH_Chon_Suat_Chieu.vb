Public Class MH_Chon_Suat_Chieu
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
    Protected The_hien As XL_THE_HIEN
    Protected Danh_Sach_Ket_Qua As List(Of XL_XUAT_CHIEU)
    Protected Danh_Sach_Phong As List(Of XL_PHONG)
    Protected Danh_Sach_Phim As List(Of XL_PHIM)
    Protected Danh_Sach_Ca_Chieu As List(Of XL_CA_CHIEU)
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
        Dim Tieu_de As String = "Chọn Suất Chiếu"
        lbTieuDe.Text = Tieu_de.ToUpper

        ''==Tìm
        The_hien.dinhDangCombobox(cbPhong_Tim, 96)
        The_hien.dinhDangCombobox(cbPhim_Tim, 136)
        The_hien.dinhDangCombobox(cbCaChieu_Tim, 117)
        The_hien.dinhDangTimePick(dtNgay_Tim, 118, "DATE")
        The_hien.dinhDangButton(btnTim)
        AddHandler btnTim.Click, AddressOf XL_Tim

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

    End Sub
    Public Sub KhoiDongPhim()
        'Tim
        cbPhim_Tim.Items.AddRange(Danh_Sach_Phim.ToArray)
        cbPhim_Tim.SelectedIndex = 0
        cbPhim_Tim.ValueMember = "ID"
        cbPhim_Tim.DisplayMember = "Ten"
    End Sub
    Public Sub KhoiDongCaChieu()
        'Tim
        cbCaChieu_Tim.Items.AddRange(Danh_Sach_Ca_Chieu.ToArray)
        cbCaChieu_Tim.SelectedIndex = 0
        cbCaChieu_Tim.ValueMember = "ID"
        cbCaChieu_Tim.DisplayMember = "Ten"
    End Sub
    Public Sub KhoiDongNgay()
        'Tim
        dtNgay_Tim.Value = DateTime.Today
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

                Dim txtPhong_result As New TextBox
                The_hien.dinhDang_ID(txtPhong_result)
                txtPhong_result.Width = 116
                txtPhong_result.Text = ketqua.Phong.Ten
                item.Controls.Add(txtPhong_result)

                Dim txtPhim_result As New TextBox
                The_hien.dinhDang_ID(txtPhim_result)
                txtPhim_result.Width = 136
                txtPhim_result.Text = ketqua.Phim.Ten
                item.Controls.Add(txtPhim_result)

                Dim txtCaChieu_result As New TextBox
                The_hien.dinhDang_ID(txtCaChieu_result)
                txtCaChieu_result.Width = 117
                txtCaChieu_result.Text = ketqua.Ca_Chieu.Ten
                item.Controls.Add(txtCaChieu_result)

                Dim txtNgay_result As New TextBox
                The_hien.dinhDang_ID(txtNgay_result)
                txtNgay_result.Width = 118
                txtNgay_result.Text = ketqua.Ngay.ToShortDateString
                item.Controls.Add(txtNgay_result)

                Dim btnChon_result As New Button
                The_hien.dinhDangButton(btnChon_result)
                btnChon_result.Text = "Chọn"
                btnChon_result.Tag = ketqua
                AddHandler btnChon_result.Click, AddressOf XL_Chon
                item.Controls.Add(btnChon_result)

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
#Region "Xử lý biến cố chính - Chọn"
    Sub XL_Chon(btnChon As Button, Bc As EventArgs)
        Dim mh As New MH_Quan_Ly_Ve(Ung_dung, btnChon.Tag)
        mh.ShowDialog()
    End Sub

#End Region
End Class