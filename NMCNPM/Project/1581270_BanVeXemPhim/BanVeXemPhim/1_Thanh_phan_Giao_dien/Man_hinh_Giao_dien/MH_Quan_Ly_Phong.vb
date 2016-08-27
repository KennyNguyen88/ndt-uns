Public Class MH_Quan_Ly_Phong
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
    Protected The_hien As XL_THE_HIEN
    Protected Danh_Sach_Ket_Qua As List(Of XL_PHONG)
    Protected Danh_Sach_Loai_Phong As List(Of XL_LOAI_PHONG)
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
        Dim Tieu_de As String = "Quản Lý Phòng Chiếu"
        lbTieuDe.Text = Tieu_de.ToUpper

        ''==Tìm
        The_hien.dinhDangTextBox(txtTen_Tim, 177)
        The_hien.dinhDangCombobox(cbLoaiPhong_Tim, 170)
        The_hien.dinhDangButton(btnTim)
        AddHandler btnTim.Click, AddressOf XL_Tim

        '==Thêm
        The_hien.dinhDangTextBox(txtTen_Them, 177)
        The_hien.dinhDangCombobox(cbLoaiPhong_Them, 170)
        The_hien.dinhDangButton(btnThem)
        AddHandler btnThem.Click, AddressOf XL_Them

        '''==KetQua
        Danh_Sach_Ket_Qua = New List(Of XL_PHONG)
        Danh_Sach_Loai_Phong = New List(Of XL_LOAI_PHONG)
        Danh_Sach_Loai_Phong = Ung_dung.Danh_sach_Loai_Phong
        KhoiDongLoaiPhong()
        xuatThongBao("")
        KhoiDongKetQua()
    End Sub
    Public Sub KhoiDongLoaiPhong()
        'Tim
        cbLoaiPhong_Tim.Items.AddRange(Danh_Sach_Loai_Phong.ToArray)
        cbLoaiPhong_Tim.SelectedIndex = 0
        cbLoaiPhong_Tim.ValueMember = "ID"
        cbLoaiPhong_Tim.DisplayMember = "Ten"
        'Them
        cbLoaiPhong_Them.Items.AddRange(Danh_Sach_Loai_Phong.ToArray)
        cbLoaiPhong_Them.SelectedIndex = 0
        cbLoaiPhong_Them.ValueMember = "ID"
        cbLoaiPhong_Them.DisplayMember = "Ten"
    End Sub
    Public Sub xuatThongBao(thongBao As String)
        lbThongBao.Text = thongBao
    End Sub
    Public Sub KhoiDongKetQua()
        'Tất cả phòng chiếu
        Danh_Sach_Ket_Qua = Ung_dung.Danh_sach_Phong()
        XuatKetQua()
    End Sub
    Public Sub XuatKetQua()
        flResult.Controls.Clear()
        If Danh_Sach_Ket_Qua.Count > 0 Then

            For Each ketqua As XL_PHONG In Danh_Sach_Ket_Qua
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

                Dim cbLoaiPhong_result As New ComboBox
                The_hien.dinhDangCombobox(cbLoaiPhong_result, 170)
                cbLoaiPhong_result.Name = "cbLoaiPhong_result"
                cbLoaiPhong_result.ValueMember = "ID"
                cbLoaiPhong_result.DisplayMember = "Ten"
                cbLoaiPhong_result.Items.AddRange(Danh_Sach_Loai_Phong.ToArray)
                cbLoaiPhong_result.SelectedIndex = cbLoaiPhong_result.FindString(Ung_dung.Loai_Phong(ketqua.ID_LOAI_PHONG).Ten)
                item.Controls.Add(cbLoaiPhong_result)

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
        Dim dsKetQua As List(Of XL_PHONG)
        dsKetQua = Ung_dung.Danh_sach_Phong_Theo_Ten_LoaiPhong(txtTen_Tim.Text, cbLoaiPhong_Tim.SelectedItem.ID)
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
        Dim phong = Ung_dung.Tao_Phong_Moi()
        phong.Ten = txtTen_Them.Text
        phong.ID_LOAI_PHONG = cbLoaiPhong_Them.SelectedItem.ID

        If phong.Kiem_Tra_Ghi_Moi().Equals("") Then
            Return Luu_tru.Ghi(phong.Dong, LOAI_GHI.Ghi_moi)
        Else
            Return phong.Kiem_Tra_Ghi_Moi()
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

    Public Function Xoa(phong As XL_PHONG) As String
        If phong.Kiem_Tra_Xoa().Equals("") Then
            Return Luu_tru.Ghi(phong.Dong, LOAI_GHI.Xoa)
        Else
            Return phong.Kiem_Tra_Xoa()
        End If
    End Function
#End Region
#Region "Xử lý biến cố chính - Sửa"
    Sub XL_Sua(btnSua As Button, Bc As EventArgs)
        Dim phong As XL_PHONG = btnSua.Tag
        Dim ten As TextBox = btnSua.Parent.Controls("txtTen_result")
        phong.Ten = ten.Text
        Dim loaiphong As ComboBox = btnSua.Parent.Controls("cbLoaiPhong_result")
        phong.ID_LOAI_PHONG = loaiphong.SelectedItem.ID

        Dim kqSua = Sua(phong)
        If kqSua.Equals("") Then
            'Sua thanh cong
            xuatThongBao("Cập nhật thành công thông tin có ID = " & phong.ID)
            'research
            btnTim.PerformClick()
        Else
            xuatThongBao(kqSua)
        End If
    End Sub
    Public Function Sua(phong As XL_PHONG) As String
        If phong.Kiem_Tra_Sua().Equals("") Then
            Return Luu_tru.Ghi(phong.Dong, LOAI_GHI.Cap_nhat)
        Else
            Return phong.Kiem_Tra_Sua()
        End If
    End Function
#End Region
End Class