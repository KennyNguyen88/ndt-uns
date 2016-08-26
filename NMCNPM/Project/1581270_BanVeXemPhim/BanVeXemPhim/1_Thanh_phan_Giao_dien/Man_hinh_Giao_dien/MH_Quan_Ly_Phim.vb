Public Class MH_Quan_Ly_Phim
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
    Protected The_hien As XL_THE_HIEN
    Protected Danh_Sach_Ket_Qua As List(Of XL_PHIM)
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
        ''==Tìm
        The_hien.dinhDangTextBox(txtTen_Tim, 199)
        The_hien.dinhDangButton(btnTim)
        AddHandler btnTim.Click, AddressOf XL_Tim_Phim

        ''==Thêm
        The_hien.dinhDangTextBox(txtTen_Them, 199)
        The_hien.dinhDangButton(btnThem)
        AddHandler btnThem.Click, AddressOf XL_Them_Phim

        ''==KetQua
        Danh_Sach_Ket_Qua = New List(Of XL_PHIM)
        xuatThongBao("")
        KhoiDongKetQua()
    End Sub
    Public Sub xuatThongBao(thongBao As String)
        lbThongBao.Text = thongBao
    End Sub
    Public Sub KhoiDongKetQua()
        'Tất cả phim
        Danh_Sach_Ket_Qua = Ung_dung.Danh_sach_Phim()
        XuatKetQua()
    End Sub
    Public Sub XuatKetQua()
        flResult.Controls.Clear()
        If Danh_Sach_Ket_Qua.Count > 0 Then

            For Each ketqua As XL_PHIM In Danh_Sach_Ket_Qua
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

                Dim btnSua_result As New Button
                The_hien.dinhDangButton(btnSua_result)
                btnSua_result.Text = "Sửa"
                btnSua_result.Tag = ketqua
                AddHandler btnSua_result.Click, AddressOf XL_Sua_Phim
                item.Controls.Add(btnSua_result)

                Dim btnXoa_result As New Button
                The_hien.dinhDangButton(btnXoa_result)
                btnXoa_result.Text = "Xóa"
                btnXoa_result.Tag = ketqua
                AddHandler btnXoa_result.Click, AddressOf XL_Xoa_Phim
                item.Controls.Add(btnXoa_result)

                The_hien.dinhDang_item(item, 520, 50)
                flResult.Controls.Add(item)
            Next
        End If
    End Sub

#Region "Xử lý Biến cố chính - Tìm Phim Theo Tên"
    Sub XL_Tim_Phim(btnTim As Button, Bc As EventArgs)
        'TODO: kiem tra co du lieu dang edit
        Danh_Sach_Ket_Qua = Tim_Kiem_Phim()
        XuatKetQua()
        'TODO: xuat thong bao khi research ?
        'xuatThongBao()
    End Sub
    Public Function Tim_Kiem_Phim()
        Dim dsKetQua As List(Of XL_PHIM)
        dsKetQua = Ung_dung.Danh_sach_Phim_Theo_Ten(txtTen_Tim.Text)
        Return dsKetQua
    End Function
#End Region

#Region "Xử lý biến cố chính - Thêm Phim"
    Sub XL_Them_Phim(btnThem As Button, Bc As EventArgs)
        Dim kqThem = Them_Phim()
        If kqThem.Equals("") Then
            'Them thanh cong            
            xuatThongBao("Đã thêm mới thành công !")
            'research
            btnTim.PerformClick()
        Else
            xuatThongBao(kqThem)
        End If
    End Sub
    Public Function Them_Phim() As String
        Dim Phim = Ung_dung.Tao_Phim_Moi()
        Phim.Ten = txtTen_Them.Text
        If Phim.Kiem_Tra_Ghi_Moi().Equals("") Then
            Return Luu_tru.Ghi(Phim.Dong, LOAI_GHI.Ghi_moi)
        Else
            Return Phim.Kiem_Tra_Ghi_Moi()
        End If
    End Function
#End Region

#Region "Xử lý biến cố chính - Xóa Phim"
    Sub XL_Xoa_Phim(btnXoa As Button, Bc As EventArgs)
        Dim kqXoa = Xoa_Phim(btnXoa.Tag)
        If kqXoa.Equals("") Then
            'Xoa Thanh Cong
            xuatThongBao("Đã xóa thành công ! ")
            'research
            btnTim.PerformClick()
        Else
            xuatThongBao(kqXoa)
        End If
    End Sub

    Public Function Xoa_Phim(phim As XL_PHIM) As String
        If phim.Kiem_Tra_Xoa().Equals("") Then
            Return Luu_tru.Ghi(phim.Dong, LOAI_GHI.Xoa)
        Else
            Return phim.Kiem_Tra_Xoa()
        End If
    End Function
#End Region

#Region "Xử lý biến cố chính - Sửa Phim"
    Sub XL_Sua_Phim(btnSua As Button, Bc As EventArgs)
        Dim phim As XL_PHIM = btnSua.Tag
        Dim ten As TextBox = btnSua.Parent.Controls("txtTen_result")
        phim.Ten = ten.Text
        Dim kqSua = Sua_Phim(phim)
        If kqSua.Equals("") Then
            'Sua thanh cong
            xuatThongBao("Cập nhật thành công thông tin loại phòng có ID = " & phim.ID)
            'research
            btnTim.PerformClick()
        Else
            xuatThongBao(kqSua)
        End If
    End Sub
    Public Function Sua_Phim(phim As XL_PHIM) As String
        If phim.Kiem_Tra_Sua().Equals("") Then
            Return Luu_tru.Ghi(phim.Dong, LOAI_GHI.Cap_nhat)
        Else
            Return phim.Kiem_Tra_Sua()
        End If
    End Function
#End Region
End Class