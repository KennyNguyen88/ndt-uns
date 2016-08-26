Public Class MH_Quan_Ly_Loai_Phong
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
    Protected The_hien As XL_THE_HIEN
    Public Const SoGhe As Integer = 5
    Public Const SoDay As Integer = 5
    Protected Danh_Sach_Ket_Qua As List(Of XL_LOAI_PHONG)
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
        Dim Tieu_de As String = "Quản Lý Loại Phòng"
        lbTieuDe.Text = Tieu_de.ToUpper
        '==Tìm
        The_hien.dinhDangTextBox(txtTen_Tim, 199)
        The_hien.dinhDangButton(btnTim)
        AddHandler btnTim.Click, AddressOf XL_Tim_Loai_Phong
        '==Thêm        
        The_hien.dinhDangTextBox(txtTen_Them, 199)
        The_hien.dinhDangNumBox(numSoGhe_Them, 66, 999, 1)
        The_hien.dinhDangNumBox(numSoDay_Them, 66, 999, 1)
        The_hien.dinhDangButton(btnThem)
        KhoiDongSoGhe()
        KhoiDongSoDay()
        AddHandler btnThem.Click, AddressOf XL_Them_Loai_Phong
        '==KetQua
        Danh_Sach_Ket_Qua = New List(Of XL_LOAI_PHONG)
        xuatThongBao("")
        KhoiDongKetQua()
    End Sub
    Public Sub KhoiDongSoGhe()
        numSoGhe_Them.Value = SoGhe
    End Sub
    Public Sub KhoiDongSoDay()
        numSoDay_Them.Value = SoDay
    End Sub
    Public Sub KhoiDongKetQua()
        'Tất cả loại phòng
        Danh_Sach_Ket_Qua = Ung_dung.Danh_sach_Loai_Phong()
        XuatKetQua()
    End Sub
    Public Sub XuatKetQua()
        flResult.Controls.Clear()
        If Danh_Sach_Ket_Qua.Count > 0 Then

            For Each ketqua As XL_LOAI_PHONG In Danh_Sach_Ket_Qua
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

                Dim numSoGhe_result As New NumericUpDown
                The_hien.dinhDangNumBox(numSoGhe_result, 66, 999, 1)
                numSoGhe_result.Value = ketqua.So_Ghe
                numSoGhe_result.Name = "numSoGhe_result"
                item.Controls.Add(numSoGhe_result)

                Dim numSoDay_result As New NumericUpDown
                The_hien.dinhDangNumBox(numSoDay_result, 66, 999, 1)
                numSoDay_result.Value = ketqua.So_Day
                numSoDay_result.Name = "numSoDay_result"
                item.Controls.Add(numSoDay_result)

                Dim btnSua_result As New Button
                The_hien.dinhDangButton(btnSua_result)
                btnSua_result.Text = "Sửa"
                btnSua_result.Tag = ketqua
                AddHandler btnSua_result.Click, AddressOf XL_Sua_Loai_Phong
                item.Controls.Add(btnSua_result)

                Dim btnXoa_result As New Button
                The_hien.dinhDangButton(btnXoa_result)
                btnXoa_result.Text = "Xóa"
                btnXoa_result.Tag = ketqua
                AddHandler btnXoa_result.Click, AddressOf XL_Xoa_Loai_Phong
                item.Controls.Add(btnXoa_result)

                The_hien.dinhDang_item(item, 720, 50)
                flResult.Controls.Add(item)
            Next
        End If
    End Sub
    Public Sub xuatThongBao(thongBao As String)
        lbThongBao.Text = thongBao
    End Sub
#Region "Xử lý Biến cố chính - Tìm Loại Phòng"
    Sub XL_Tim_Loai_Phong(btnTim As Button, Bc As EventArgs)
        'TODO: kiem tra co du lieu dang edit
        Danh_Sach_Ket_Qua = Tim_Kiem_Loai_Phong()
        XuatKetQua()
        'TODO: xuat thong bao khi research ?
        'xuatThongBao()
    End Sub
    Public Function Tim_Kiem_Loai_Phong()
        Dim dsKetQua As List(Of XL_LOAI_PHONG)
        dsKetQua = Ung_dung.Danh_sach_Loai_Phong_Theo_Ten(txtTen_Tim.Text)
        Return dsKetQua
    End Function
#End Region

#Region "Xử lý biến cố chính - Thêm Loại Phòng"
    Sub XL_Them_Loai_Phong(btnThem As Button, Bc As EventArgs)
        Dim kqThem = Them_Loai_Phong()
        If kqThem.Equals("") Then
            'Them thanh cong            
            xuatThongBao("Đã thêm mới thành công !")
            'research
            btnTim.PerformClick()
        Else
            xuatThongBao(kqThem)
        End If
    End Sub
    Public Function Them_Loai_Phong() As String
        Dim loaiPhong = Ung_dung.Tao_Loai_Phong_Moi()
        loaiPhong.Ten = txtTen_Them.Text
        loaiPhong.So_Ghe = numSoGhe_Them.Value
        loaiPhong.So_Day = numSoDay_Them.Value
        If loaiPhong.Kiem_Tra_Ghi_Moi().Equals("") Then
            Return Luu_tru.Ghi(loaiPhong.Dong, LOAI_GHI.Ghi_moi)
        Else
            Return loaiPhong.Kiem_Tra_Ghi_Moi()
        End If
    End Function
#End Region

#Region "Xử lý biến cố chính - Xóa Loại Phòng"
    Sub XL_Xoa_Loai_Phong(btnXoa As Button, Bc As EventArgs)
        Dim kqXoa = Xoa_Loai_Phong(btnXoa.Tag)
        If kqXoa.Equals("") Then
            'Xoa Thanh Cong
            xuatThongBao("Đã xóa thành công ! ")
            'research
            btnTim.PerformClick()
        Else
            xuatThongBao(kqXoa)
        End If
    End Sub

    Public Function Xoa_Loai_Phong(loaiPhong As XL_LOAI_PHONG) As String
        If loaiPhong.Kiem_Tra_Xoa().Equals("") Then
            Return Luu_tru.Ghi(loaiPhong.Dong, LOAI_GHI.Xoa)
        Else
            Return loaiPhong.Kiem_Tra_Xoa()
        End If
    End Function
#End Region
#Region "Xử lý biến cố chính - Sửa Loại phòng"
    Sub XL_Sua_Loai_Phong(btnSua As Button, Bc As EventArgs)
        Dim loaiPhong As XL_LOAI_PHONG = btnSua.Tag
        Dim ten As TextBox = btnSua.Parent.Controls("txtTen_result")
        loaiPhong.Ten = ten.Text
        Dim soghe As NumericUpDown = btnSua.Parent.Controls("numSoGhe_result")
        loaiPhong.So_Ghe = soghe.Value
        Dim soday As NumericUpDown = btnSua.Parent.Controls("numSoDay_result")
        loaiPhong.So_Ghe = soday.Value
        Dim kqSua = Sua_Loai_Phong(loaiPhong)
        If kqSua.Equals("") Then
            'Sua thanh cong
            xuatThongBao("Cập nhật thành công thông tin loại phòng có ID = " & loaiPhong.ID)
            'research
            btnTim.PerformClick()
        Else
            xuatThongBao(kqSua)
        End If
    End Sub
    Public Function Sua_Loai_Phong(loaiPhong As XL_LOAI_PHONG) As String
        If loaiPhong.Kiem_Tra_Sua().Equals("") Then
            Return Luu_tru.Ghi(loaiPhong.Dong, LOAI_GHI.Cap_nhat)
        Else
            Return loaiPhong.Kiem_Tra_Sua()
        End If
    End Function
#End Region

End Class