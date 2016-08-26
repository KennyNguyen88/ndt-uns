Public Class MH_Quan_Ly_Ca_Chieu
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
    Protected The_hien As XL_THE_HIEN
    Protected Danh_Sach_Ket_Qua As List(Of XL_CA_CHIEU)
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
        Dim Tieu_de As String = "Quản Lý Ca Chiếu"
        lbTieuDe.Text = Tieu_de.ToUpper

        ''==Tìm
        The_hien.dinhDangTextBox(txtTen_Tim, 177)
        The_hien.dinhDangCombobox(cbBuoi_Tim, 66)
        The_hien.dinhDangTimePick(dtBatDau_Tim, 109, "TIME")
        The_hien.dinhDangTimePick(dtKetThuc_Tim, 109, "TIME")
        The_hien.dinhDangButton(btnTim)
        'AddHandler btnTim.Click, AddressOf XL_Tim_Phim

        '==Thêm
        The_hien.dinhDangTextBox(txtTen_Them, 177)
        The_hien.dinhDangCombobox(cbBuoi_Them, 66)
        The_hien.dinhDangTimePick(dtBatDau_Them, 109, "TIME")
        The_hien.dinhDangTimePick(dtKetThuc_Them, 109, "TIME")
        The_hien.dinhDangButton(btnThem)
        'AddHandler btnThem.Click, AddressOf XL_Them_Phim

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

        'Them
    End Sub
    Public Sub KhoiDongBatDau()
        'Tim

        'Them
    End Sub
    Public Sub KhoiDongKetThuc()
        'Tim

        'Them
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

                'Dim cbBuoi_result As New ComboBox
                'The_hien.dinhDangCombobox(cbBuoi_result, 66)
                'cbBuoi_result.

                Dim btnSua_result As New Button
                The_hien.dinhDangButton(btnSua_result)
                btnSua_result.Text = "Sửa"
                btnSua_result.Tag = ketqua
                'AddHandler btnSua_result.Click, AddressOf XL_Sua_Phim
                item.Controls.Add(btnSua_result)

                Dim btnXoa_result As New Button
                The_hien.dinhDangButton(btnXoa_result)
                btnXoa_result.Text = "Xóa"
                btnXoa_result.Tag = ketqua
                'AddHandler btnXoa_result.Click, AddressOf XL_Xoa_Phim
                item.Controls.Add(btnXoa_result)

                The_hien.dinhDang_item(item, 520, 50)
                flResult.Controls.Add(item)
            Next
        End If
    End Sub
End Class