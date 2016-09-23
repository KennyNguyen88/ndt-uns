Public Class MH_Quan_Ly_Ve
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
    Protected The_hien As XL_THE_HIEN
    Protected SuatChieu As XL_XUAT_CHIEU
    Protected Danh_Sach_Ket_Qua As List(Of XL_VE)
    Public Sub New(Ung_dung As XL_UNG_DUNG, _SuatChieu As XL_XUAT_CHIEU)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Luu_tru = New XL_LUU_TRU("DO_AN")
        Me.Ung_dung = Ung_dung
        The_hien = New XL_THE_HIEN(Ung_dung)
        SuatChieu = _SuatChieu
        Khoi_dong()
    End Sub
    Public Sub Khoi_dong()
        ''===Tiêu đề 
        Dim Tieu_de As String = "Quản Lý Vé"
        lbTieuDe.Text = Tieu_de.ToUpper

        '===Tìm
        txtPhong.Text = SuatChieu.Phong.Ten
        txtPhim.Text = SuatChieu.Phim.Ten
        txtCaChieu.Text = SuatChieu.Ca_Chieu.Ten
        txtNgay.Text = SuatChieu.Ngay.ToShortDateString

        '==KetQua
        Danh_Sach_Ket_Qua = New List(Of XL_VE)
        KhoiDongKetQua()
    End Sub
    Public Sub KhoiDongKetQua()
        'Tất cả suất chiếu
        Danh_Sach_Ket_Qua = Ung_dung.Danh_Sach_Ve_Suat_Chieu(SuatChieu.ID)
        XuatKetQua()
    End Sub
    Public Sub xuatThongBao(thongBao As String)
        lbThongBao.Text = thongBao
    End Sub
    Public Sub XuatKetQua()
        flResult.Controls.Clear()
        If Danh_Sach_Ket_Qua.Count > 0 Then

            For Each ketqua As XL_VE In Danh_Sach_Ket_Qua
                Dim item As New FlowLayoutPanel

                Dim txtID_result As New TextBox
                The_hien.dinhDang_ID(txtID_result)
                txtID_result.Text = ketqua.ID
                item.Controls.Add(txtID_result)

                Dim txtGhe_result As New TextBox
                The_hien.dinhDang_ID(txtGhe_result)
                txtGhe_result.Width = 116
                txtGhe_result.Text = ketqua.Ghe.Ten
                item.Controls.Add(txtGhe_result)

                Dim lbX_result As New Label
                The_hien.dinhDangLabel(lbX_result)
                lbX_result.Text = "X"
                item.Controls.Add(lbX_result)

                Dim txtX_result As New TextBox
                The_hien.dinhDang_ID(txtX_result)
                txtX_result.Text = ketqua.Ghe.x
                item.Controls.Add(txtX_result)

                Dim lbY_result As New Label
                The_hien.dinhDangLabel(lbY_result)
                lbY_result.Text = "Y"
                item.Controls.Add(lbY_result)

                Dim txtY_result As New TextBox
                The_hien.dinhDang_ID(txtY_result)
                txtY_result.Text = ketqua.Ghe.y
                item.Controls.Add(txtY_result)

                Dim rdYes_result As New RadioButton
                rdYes_result.Name = "rdYes_result"
                The_hien.dinhDangradio(rdYes_result)
                rdYes_result.Text = "Đã bán"
                If (ketqua.TRANG_THAI.ToUpper.Equals("ĐÃ BÁN")) Then
                    rdYes_result.Checked = True
                End If
                item.Controls.Add(rdYes_result)

                Dim rdNo_result As New RadioButton
                The_hien.dinhDangradio(rdNo_result)
                rdNo_result.Text = "Chưa bán"
                If (ketqua.TRANG_THAI.ToUpper.Equals("CHƯA BÁN")) Then
                    rdNo_result.Checked = True
                End If
                item.Controls.Add(rdNo_result)

                Dim btnSua_result As New Button
                The_hien.dinhDangButton(btnSua_result)
                btnSua_result.Text = "Cập Nhật"
                btnSua_result.Tag = ketqua
                btnSua_result.Width = 200
                AddHandler btnSua_result.Click, AddressOf XL_Sua
                item.Controls.Add(btnSua_result)

                The_hien.dinhDang_item(item, 850, 50)
                flResult.Controls.Add(item)
            Next
        End If
    End Sub
#Region "Xử lý biến cố chính - Sửa"
    Sub XL_Sua(btnSua As Button, Bc As EventArgs)
        Dim ve As XL_VE = btnSua.Tag
        Dim daBan As RadioButton = btnSua.Parent.Controls("rdYes_result")
        If daBan.Checked = True Then
            ve.TRANG_THAI = "Đã bán"
        Else
            ve.TRANG_THAI = "Chưa bán"
        End If
        Dim kqSua = Sua(ve)
        If kqSua.Equals("") Then
            'Sua success
            xuatThongBao("Đã cập nhật vé thành công !")
        Else
            'Sua fail
            xuatThongBao(kqSua)
        End If
    End Sub
    Public Function Sua(ve As XL_VE) As String
        If ve.Kiem_Tra_Sua().Equals("") Then
            Return Luu_tru.Ghi(ve.Dong, LOAI_GHI.Cap_nhat)
        Else
            Return ve.Kiem_Tra_Sua()
        End If
    End Function
#End Region
End Class