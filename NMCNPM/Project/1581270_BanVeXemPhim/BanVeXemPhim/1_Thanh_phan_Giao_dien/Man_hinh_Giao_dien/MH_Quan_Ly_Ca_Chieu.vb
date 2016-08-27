Public Class MH_Quan_Ly_Ca_Chieu
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
    Protected The_hien As XL_THE_HIEN
    Protected Danh_Sach_Ket_Qua As List(Of XL_CA_CHIEU)
    Protected Buoi_Trong_Ngay As List(Of String)
    Public Sub New(Ung_dung As XL_UNG_DUNG)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Luu_tru = New XL_LUU_TRU("DO_AN")
        Me.Ung_dung = Ung_dung
        The_hien = New XL_THE_HIEN(Ung_dung)
        Buoi_Trong_Ngay = New List(Of String)
        Buoi_Trong_Ngay.Add("Sáng")
        Buoi_Trong_Ngay.Add("Chiều")
        Buoi_Trong_Ngay.Add("Tối")
        Khoi_dong()
    End Sub
    Public Sub Khoi_dong()
        ''===Tiêu đề 
        Dim Tieu_de As String = "Quản Lý Ca Chiếu"
        lbTieuDe.Text = Tieu_de.ToUpper

        ''==Tìm
        The_hien.dinhDangTextBox(txtTen_Tim, 177)
        The_hien.dinhDangCombobox(cbBuoi_Tim, 66)
        'The_hien.dinhDangTimePick(dtBatDau_Tim, 109, "TIME")
        'The_hien.dinhDangTimePick(dtKetThuc_Tim, 109, "TIME")
        The_hien.dinhDangButton(btnTim)
        AddHandler btnTim.Click, AddressOf XL_Tim

        '==Thêm
        The_hien.dinhDangTextBox(txtTen_Them, 177)
        The_hien.dinhDangCombobox(cbBuoi_Them, 66)
        The_hien.dinhDangTimePick(dtBatDau_Them, 109, "TIME")
        The_hien.dinhDangTimePick(dtKetThuc_Them, 109, "TIME")
        The_hien.dinhDangButton(btnThem)
        AddHandler btnThem.Click, AddressOf XL_Them

        KhoiDongBuoi()
        KhoiDongBatDau()
        KhoiDongKetThuc()

        '''==KetQua
        Danh_Sach_Ket_Qua = New List(Of XL_CA_CHIEU)
        xuatThongBao("")
        KhoiDongKetQua()
    End Sub
    Public Sub xuatThongBao(thongBao As String)
        lbThongBao.Text = thongBao
    End Sub
    Public Sub KhoiDongKetQua()
        'Tất cả ca chiếu
        Danh_Sach_Ket_Qua = Ung_dung.Danh_sach_Ca_Chieu()
        XuatKetQua()
    End Sub
    Public Sub KhoiDongBuoi()
        'Tim        
        cbBuoi_Tim.Items.AddRange(Buoi_Trong_Ngay.ToArray)
        cbBuoi_Tim.SelectedIndex = 0
        'Them
        cbBuoi_Them.Items.AddRange(Buoi_Trong_Ngay.ToArray)
        cbBuoi_Them.SelectedIndex = 0
    End Sub
    Public Sub KhoiDongBatDau()
        'Tim
        'dtBatDau_Tim.Value = DateTime.Today.AddHours(8)
        'Them
        dtBatDau_Them.Value = DateTime.Today.AddHours(8)
    End Sub
    Public Sub KhoiDongKetThuc()
        'Tim
        'dtKetThuc_Tim.Value = DateTime.Today.AddHours(10)
        'Them
        dtKetThuc_Them.Value = DateTime.Today.AddHours(10)
    End Sub

    Public Sub XuatKetQua()
        flResult.Controls.Clear()
        If Danh_Sach_Ket_Qua.Count > 0 Then

            For Each ketqua As XL_CA_CHIEU In Danh_Sach_Ket_Qua
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

                Dim cbBuoi_result As New ComboBox
                The_hien.dinhDangCombobox(cbBuoi_result, 66)
                cbBuoi_result.Items.AddRange(Buoi_Trong_Ngay.ToArray)
                cbBuoi_result.SelectedIndex = cbBuoi_result.FindString(ketqua.Buoi)
                cbBuoi_result.Name = "cbBuoi_result"
                item.Controls.Add(cbBuoi_result)

                Dim pdtBatDau_result As New DateTimePicker
                The_hien.dinhDangTimePick(pdtBatDau_result, 109, "TIME")
                pdtBatDau_result.Value = ketqua.BAT_DAU
                pdtBatDau_result.Name = "pdtBatDau_result"
                item.Controls.Add(pdtBatDau_result)

                Dim pdtKetThuc_result As New DateTimePicker
                The_hien.dinhDangTimePick(pdtKetThuc_result, 109, "TIME")
                pdtKetThuc_result.Value = ketqua.KET_THUC
                pdtKetThuc_result.Name = "pdtKetThuc_result"
                item.Controls.Add(pdtKetThuc_result)

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
        Dim dsKetQua As List(Of XL_CA_CHIEU)
        dsKetQua = Ung_dung.Danh_sach_Ca_Chieu_Theo_Ten_Buoi(txtTen_Tim.Text, cbBuoi_Tim.SelectedItem)
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
        Dim caChieu = Ung_dung.Tao_Ca_Chieu_Moi()
        caChieu.Ten = txtTen_Them.Text
        caChieu.Buoi = cbBuoi_Them.SelectedItem
        caChieu.BAT_DAU = dtBatDau_Them.Value
        caChieu.KET_THUC = dtKetThuc_Them.Value
        If caChieu.Kiem_Tra_Ghi_Moi().Equals("") Then
            Return Luu_tru.Ghi(caChieu.Dong, LOAI_GHI.Ghi_moi)
        Else
            Return caChieu.Kiem_Tra_Ghi_Moi()
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

    Public Function Xoa(caChieu As XL_CA_CHIEU) As String
        If caChieu.Kiem_Tra_Xoa().Equals("") Then
            Return Luu_tru.Ghi(caChieu.Dong, LOAI_GHI.Xoa)
        Else
            Return caChieu.Kiem_Tra_Xoa()
        End If
    End Function
#End Region
#Region "Xử lý biến cố chính - Sửa"
    Sub XL_Sua(btnSua As Button, Bc As EventArgs)
        Dim caChieu As XL_CA_CHIEU = btnSua.Tag
        Dim ten As TextBox = btnSua.Parent.Controls("txtTen_result")
        caChieu.Ten = ten.Text
        Dim buoi As ComboBox = btnSua.Parent.Controls("cbBuoi_result")
        caChieu.Buoi = buoi.SelectedItem
        Dim batdau As DateTimePicker = btnSua.Parent.Controls("pdtBatDau_result")
        caChieu.BAT_DAU = batdau.Value
        Dim ketthuc As DateTimePicker = btnSua.Parent.Controls("pdtKetThuc_result")
        caChieu.KET_THUC = ketthuc.Value
        Dim kqSua = Sua(caChieu)
        If kqSua.Equals("") Then
            'Sua thanh cong
            xuatThongBao("Cập nhật thành công thông tin có ID = " & caChieu.ID)
            'research
            btnTim.PerformClick()
        Else
            xuatThongBao(kqSua)
        End If
    End Sub
    Public Function Sua(caChieu As XL_CA_CHIEU) As String
        If caChieu.Kiem_Tra_Sua().Equals("") Then
            Return Luu_tru.Ghi(caChieu.Dong, LOAI_GHI.Cap_nhat)
        Else
            Return caChieu.Kiem_Tra_Sua()
        End If
    End Function
#End Region
End Class