Public Class MH_Quan_ly_Ghe
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
    Protected The_hien As XL_THE_HIEN
    Protected Danh_Sach_Ket_Qua As List(Of XL_GHE)
    Protected Danh_Sach_Phong As List(Of XL_PHONG)
    Public Const Y As Integer = 1
    Public Const X As Integer = 1
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
        Dim Tieu_de As String = "Quản Lý Ghế"
        lbTieuDe.Text = Tieu_de.ToUpper

        '==Tìm
        The_hien.dinhDangTextBox(txtTen_Tim, 199)
        The_hien.dinhDangCombobox(cbPhong_Tim, 136)
        The_hien.dinhDangButton(btnTim)
        AddHandler btnTim.Click, AddressOf XL_Tim
        '==Thêm        
        The_hien.dinhDangTextBox(txtTen_Them, 199)
        The_hien.dinhDangCombobox(cbPhong_Them, 136)
        The_hien.dinhDangNumBox(X_Them, 66, 999, 1)
        The_hien.dinhDangNumBox(Y_Them, 66, 999, 1)
        The_hien.dinhDangButton(btnThem)
        AddHandler btnThem.Click, AddressOf XL_Them
        AddHandler cbPhong_Them.SelectedValueChanged, AddressOf XL_ThayDoi_Phong
        '==KetQua
        Danh_Sach_Ket_Qua = New List(Of XL_GHE)
        Danh_Sach_Phong = New List(Of XL_PHONG)
        Danh_Sach_Phong = Ung_dung.Danh_sach_Phong()
        KhoiDongPhong()
        KhoiDongX()
        KhoiDongY()
        xuatThongBao("")
        KhoiDongKetQua()
    End Sub
    Public Sub xuatThongBao(thongBao As String)
        lbThongBao.Text = thongBao
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
    Public Sub KhoiDongX()
        X_Them.Value = X
        X_Them.Maximum = Ung_dung.Loai_Phong(cbPhong_Them.SelectedItem.ID_LOAI_PHONG).So_Day
    End Sub
    Public Sub KhoiDongY()
        Y_Them.Value = Y
        Y_Them.Maximum = Ung_dung.Loai_Phong(cbPhong_Them.SelectedItem.ID_LOAI_PHONG).So_Ghe
    End Sub
    Public Sub KhoiDongKetQua()
        'Tất cả ghế
        Danh_Sach_Ket_Qua = Ung_dung.Danh_sach_Ghe()
        XuatKetQua()
    End Sub
    Public Sub XuatKetQua()
        flResult.Controls.Clear()
        If Danh_Sach_Ket_Qua.Count > 0 Then

            For Each ketqua As XL_GHE In Danh_Sach_Ket_Qua
                Dim item As New FlowLayoutPanel

                Dim txtID_result As New TextBox
                The_hien.dinhDang_ID(txtID_result)
                txtID_result.Text = ketqua.ID
                item.Controls.Add(txtID_result)

                Dim txtTen_result As New TextBox
                The_hien.dinhDangTextBox(txtTen_result, 199)
                txtTen_result.Text = ketqua.Ten
                txtTen_result.Name = "txtTen_result"
                item.Controls.Add(txtTen_result)

                Dim cbPhong_result As New ComboBox
                The_hien.dinhDangCombobox(cbPhong_result, 136)
                cbPhong_result.Name = "cbPhong_result"
                cbPhong_result.ValueMember = "ID"
                cbPhong_result.DisplayMember = "Ten"
                cbPhong_result.Items.AddRange(Danh_Sach_Phong.ToArray)
                cbPhong_result.SelectedIndex = cbPhong_result.FindString(Ung_dung.Phong(ketqua.ID_PHONG).Ten)
                AddHandler cbPhong_result.SelectedValueChanged, AddressOf XL_ThayDoi_Phong
                item.Controls.Add(cbPhong_result)

                Dim X_result As New NumericUpDown
                The_hien.dinhDangNumBox(X_result, 66, 999, 1)
                X_result.Value = ketqua.x
                X_result.Name = "X_result"
                item.Controls.Add(X_result)

                Dim Y_result As New NumericUpDown
                The_hien.dinhDangNumBox(Y_result, 66, 999, 1)
                Y_result.Value = ketqua.y
                Y_result.Name = "Y_result"
                item.Controls.Add(Y_result)

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

                The_hien.dinhDang_item(item, 870, 50)
                flResult.Controls.Add(item)
            Next
        End If
    End Sub
#Region "Xử lý Biến cố chính - Tìm Ghế"
    Sub XL_Tim(btnTim As Button, Bc As EventArgs)
        'TODO: kiem tra co du lieu dang edit
        Danh_Sach_Ket_Qua = Tim_Kiem()
        XuatKetQua()
        'TODO: xuat thong bao khi research ?
        'xuatThongBao()
    End Sub
    Public Function Tim_Kiem()
        Dim dsKetQua As List(Of XL_GHE)
        dsKetQua = Ung_dung.Danh_sach_Ghe_Theo_Ten_Phong(txtTen_Tim.Text, cbPhong_Tim.SelectedItem.ID)
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
        Dim ghe = Ung_dung.Tao_Ghe_Moi()
        ghe.Ten = txtTen_Them.Text
        ghe.x = X_Them.Value
        ghe.y = Y_Them.Value
        ghe.ID_PHONG = cbPhong_Them.SelectedItem.ID
        If ghe.Kiem_Tra_Ghi_Moi().Equals("") Then
            Return Luu_tru.Ghi(ghe.Dong, LOAI_GHI.Ghi_moi)
        Else
            Return ghe.Kiem_Tra_Ghi_Moi()
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

    Public Function Xoa(ghe As XL_GHE) As String
        If ghe.Kiem_Tra_Xoa().Equals("") Then
            Return Luu_tru.Ghi(ghe.Dong, LOAI_GHI.Xoa)
        Else
            Return ghe.Kiem_Tra_Xoa()
        End If
    End Function
#End Region
#Region "Xử lý biến cố phụ - Thay đổi phòng"
    Sub XL_ThayDoi_Phong(cbPhong As ComboBox, Bc As EventArgs)
        Dim phong As XL_PHONG = cbPhong.SelectedItem
        Dim maxX As Integer = Ung_dung.Loai_Phong(phong.ID_LOAI_PHONG).So_Day
        Dim maxY As Integer = Ung_dung.Loai_Phong(phong.ID_LOAI_PHONG).So_Ghe
        If cbPhong.Name = "cbPhong_Them" Then
            X_Them.Maximum = maxX
            X_Them.Value = 1
            Y_Them.Maximum = maxY
            Y_Them.Value = 1
        Else 'result
            'find x
            Dim x_result As NumericUpDown = cbPhong.Parent.Controls("X_result")
            Dim y_result As NumericUpDown = cbPhong.Parent.Controls("Y_result")
            x_result.Value = 1
            x_result.Maximum = maxX
            y_result.Value = 1
            y_result.Maximum = maxY
        End If
    End Sub
#End Region
#Region "Xử lý biến cố chính - Sửa"
    Sub XL_Sua(btnSua As Button, Bc As EventArgs)
        Dim ghe As XL_GHE = btnSua.Tag
        Dim ten As TextBox = btnSua.Parent.Controls("txtTen_result")
        ghe.Ten = ten.Text
        Dim phong As ComboBox = btnSua.Parent.Controls("cbPhong_result")
        ghe.ID_PHONG = phong.SelectedItem.ID
        Dim X_result As NumericUpDown = btnSua.Parent.Controls("X_result")
        ghe.x = X_result.Value
        Dim Y_result As NumericUpDown = btnSua.Parent.Controls("Y_result")
        ghe.y = Y_result.Value
        Dim kqSua = Sua(ghe)
        If kqSua.Equals("") Then
            'Sua thanh cong
            xuatThongBao("Cập nhật thành công thông tin ghế có ID = " & ghe.ID)
            'research
            btnTim.PerformClick()
        Else
            xuatThongBao(kqSua)
        End If
    End Sub
    Public Function Sua(ghe As XL_GHE) As String
        If ghe.Kiem_Tra_Sua().Equals("") Then
            Return Luu_tru.Ghi(ghe.Dong, LOAI_GHI.Cap_nhat)
        Else
            Return ghe.Kiem_Tra_Sua()
        End If
    End Function
#End Region
End Class