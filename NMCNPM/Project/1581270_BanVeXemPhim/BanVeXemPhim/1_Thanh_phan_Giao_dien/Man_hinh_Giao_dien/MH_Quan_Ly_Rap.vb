Public Class MH_Quan_Ly_Rap
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
    Protected The_hien As XL_THE_HIEN
    Protected Danh_Sach_Ket_Qua As List(Of XL_RAP_CHIEU_PHIM)
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
        Dim Tieu_de As String = "Quản Lý Rạp Chiếu Phim"
        lbTieuDe.Text = Tieu_de.ToUpper

        ''==Tìm
        The_hien.dinhDangTextBox(txtTen_Tim, 177)
        The_hien.dinhDangTextBox(txtDienThoai_Tim, 146)
        The_hien.dinhDangTextBox(txtDiaChi_Tim, 177)
        The_hien.dinhDangButton(btnTim)
        AddHandler btnTim.Click, AddressOf XL_Tim

        '==Thêm
        The_hien.dinhDangTextBox(txtTen_Them, 177)
        The_hien.dinhDangTextBox(txtDienThoai_Them, 146)
        The_hien.dinhDangTextBox(txtDiaChi_Them, 177)
        The_hien.dinhDangButton(btnThem)
        AddHandler btnThem.Click, AddressOf XL_Them

        '''==KetQua
        Danh_Sach_Ket_Qua = New List(Of XL_RAP_CHIEU_PHIM)
        xuatThongBao("")
        KhoiDongKetQua()
    End Sub
    Public Sub xuatThongBao(thongBao As String)
        lbThongBao.Text = thongBao
    End Sub
    Public Sub KhoiDongKetQua()
        'Tất cả rạp chiếu
        Danh_Sach_Ket_Qua = Ung_dung.Danh_sach_Rap_Chieu()
        XuatKetQua()
    End Sub
    Public Sub XuatKetQua()
        flResult.Controls.Clear()
        If Danh_Sach_Ket_Qua.Count > 0 Then

            For Each ketqua As XL_RAP_CHIEU_PHIM In Danh_Sach_Ket_Qua
                Dim item As New FlowLayoutPanel

                Dim txtID_result As New TextBox
                The_hien.dinhDang_ID(txtID_result)
                txtID_result.Text = ketqua.ID
                item.Controls.Add(txtID_result)

                Dim txtTen_result As New TextBox
                The_hien.dinhDangTextBox(txtTen_result, 177)
                txtTen_result.Text = ketqua.Ten
                txtTen_result.Name = "txtTen_result"
                item.Controls.Add(txtTen_result)

                Dim txtDienThoai_result As New TextBox
                The_hien.dinhDangTextBox(txtDienThoai_result, 146)
                txtDienThoai_result.Text = ketqua.Dien_Thoai
                txtDienThoai_result.Name = "txtDienThoai_result"
                item.Controls.Add(txtDienThoai_result)

                Dim txtDiaChi_result As New TextBox
                The_hien.dinhDangTextBox(txtDiaChi_result, 177)
                txtDiaChi_result.Text = ketqua.Dia_Chi
                txtDiaChi_result.Name = "txtDiaChi_result"
                item.Controls.Add(txtDiaChi_result)

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
    Public Function Tim_Kiem()
        Dim dsKetQua As List(Of XL_RAP_CHIEU_PHIM)
        dsKetQua = Ung_dung.Danh_sach_Rap_Theo_Ten_DienThoai_DiaChi(txtTen_Tim.Text, txtDienThoai_Tim.Text, txtDiaChi_Tim.Text)
        Return dsKetQua
    End Function
#End Region

#Region "Xử lý biến cố chính - Thêm"
    Sub XL_Them(btnThem As Button, Bc As EventArgs)
        Dim kqThem = Them_Moi()
        If kqThem.Equals("") Then
            'Them thanh cong            
            xuatThongBao("Đã thêm mới thành công !")
            'research
            btnTim.PerformClick()
        Else
            xuatThongBao(kqThem)
        End If
    End Sub
    Public Function Them_Moi() As String
        Dim rapChieu = Ung_dung.Tao_Rap_Moi()
        rapChieu.Ten = txtTen_Them.Text
        rapChieu.Dien_Thoai = txtDienThoai_Them.Text
        rapChieu.Dia_Chi = txtDiaChi_Them.Text

        If rapChieu.Kiem_Tra_Ghi_Moi().Equals("") Then
            Return Luu_tru.Ghi(rapChieu.Dong, LOAI_GHI.Ghi_moi)
        Else
            Return rapChieu.Kiem_Tra_Ghi_Moi()
        End If
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

    Public Function Xoa(rapChieu As XL_RAP_CHIEU_PHIM) As String
        If rapChieu.Kiem_Tra_Xoa().Equals("") Then
            Return Luu_tru.Ghi(rapChieu.Dong, LOAI_GHI.Xoa)
        Else
            Return rapChieu.Kiem_Tra_Xoa()
        End If
    End Function
#End Region
#Region "Xử lý biến cố chính - Sửa"
    Sub XL_Sua(btnSua As Button, Bc As EventArgs)
        Dim rapChieu As XL_RAP_CHIEU_PHIM = btnSua.Tag
        Dim ten As TextBox = btnSua.Parent.Controls("txtTen_result")
        rapChieu.Ten = ten.Text
        Dim diachi As TextBox = btnSua.Parent.Controls("txtDiaChi_result")
        rapChieu.Dia_Chi = diachi.Text
        Dim dienthoai As TextBox = btnSua.Parent.Controls("txtDienThoai_result")
        rapChieu.Dien_Thoai = dienthoai.Text
        Dim kqSua = Sua(rapChieu)
        If kqSua.Equals("") Then
            'Sua thanh cong
            xuatThongBao("Cập nhật thành công thông tin có ID = " & rapChieu.ID)
            'research
            btnTim.PerformClick()
        Else
            xuatThongBao(kqSua)
        End If
    End Sub
    Public Function Sua(rapChieu As XL_RAP_CHIEU_PHIM) As String
        If rapChieu.Kiem_Tra_Sua().Equals("") Then
            Return Luu_tru.Ghi(rapChieu.Dong, LOAI_GHI.Cap_nhat)
        Else
            Return rapChieu.Kiem_Tra_Sua()
        End If
    End Function
#End Region
End Class