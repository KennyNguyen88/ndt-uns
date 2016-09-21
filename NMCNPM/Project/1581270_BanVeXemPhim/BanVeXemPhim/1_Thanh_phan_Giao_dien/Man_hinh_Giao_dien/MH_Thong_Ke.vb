Public Class MH_Thong_Ke
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
    Protected The_hien As XL_THE_HIEN
    Protected Danh_Sach_Ket_Qua As List(Of XL_THONGKE_VE)
    Protected tongSoVe As Integer
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
        Dim Tieu_de As String = "Thống kê số vé bán"
        lbTieuDe.Text = Tieu_de.ToUpper

        ''==Tìm                
        The_hien.dinhDangButton(btnTim)
        AddHandler btnTim.Click, AddressOf XL_Tim


        '''==KetQua
        Danh_Sach_Ket_Qua = New List(Of XL_THONGKE_VE)
        KhoiDongThang()
        KhoiDongKetQua()
    End Sub
    Public Sub KhoiDongThang()
        dtNgay.Value = DateTime.Now
    End Sub
    Public Sub xuatThongBao(thongBao As String)
        lbThongBao.Text = thongBao
    End Sub
    Public Sub KhoiDongKetQua()
        Tim_Kiem()
        XuatKetQua()
    End Sub
    Public Sub XuatKetQua()
        flResult.Controls.Clear()
        If Danh_Sach_Ket_Qua.Count > 0 Then
            For Each ketqua As XL_THONGKE_VE In Danh_Sach_Ket_Qua
                Dim item As New FlowLayoutPanel

                Dim txtCaChieuTitle_result As New Label
                The_hien.dinhDangLabel(txtCaChieuTitle_result)
                txtCaChieuTitle_result.Text = "Ca Chiếu"
                item.Controls.Add(txtCaChieuTitle_result)

                Dim txtCaChieu_result As New Label
                The_hien.dinhDangLabel(txtCaChieu_result)
                txtCaChieu_result.Text = ketqua.caChieu
                item.Controls.Add(txtCaChieu_result)

                Dim txtSoVeTitle_result As New Label
                The_hien.dinhDangLabel(txtSoVeTitle_result)
                txtSoVeTitle_result.Text = "Số Vé"
                item.Controls.Add(txtSoVeTitle_result)

                Dim txtSoVe_result As New Label
                The_hien.dinhDangLabel(txtSoVe_result)
                txtSoVe_result.Text = ketqua.soVe
                item.Controls.Add(txtSoVe_result)

                Dim txtTileTitle_result As New Label
                The_hien.dinhDangLabel(txtTileTitle_result)
                txtTileTitle_result.Text = "Tỉ Lệ"
                item.Controls.Add(txtTileTitle_result)

                Dim txtTiLe_result As New Label
                The_hien.dinhDangLabel(txtTiLe_result)
                txtTiLe_result.Text = ketqua.tiLe
                item.Controls.Add(txtTiLe_result)

                The_hien.dinhDang_item(item, 850, 50)
                flResult.Controls.Add(item)
            Next
        End If
        lbThongBao.Text = "Tổng số vé: " & tongSoVe

    End Sub
#Region "Xử lý biến cố chính - Tìm"
    Sub XL_Tim(btnTim As Button, Bc As EventArgs)
        'TODO: kiem tra co du lieu dang edit
        'TODO: xuat thong bao khi research ?
        'xuatThongBao()
        If (Danh_Sach_Ket_Qua.Count > 0) Then
            Danh_Sach_Ket_Qua.Clear()
        End If
        Tim_Kiem()
        XuatKetQua()
    End Sub
    Public Function Tim_Kiem()
        'Dim dsKetQua As List(Of XL_THONGKE_VE)
        'dsKetQua = Ung_dung.Danh_sach_Phong_Theo_Ten_LoaiPhong(txtTen_Tim.Text, cbLoaiPhong_Tim.SelectedItem.ID)
        'Return dsKetQua
        Dim dsVeTrongThang = Ung_dung.Danh_Sach_Ve_Theo_Thang_Nam(dtNgay.Value.Month, dtNgay.Value.Year)
        Dim dsVeDaDat = Ung_dung.Danh_sach_Ve_Da_Dat(dsVeTrongThang)
        tongSoVe = dsVeDaDat.Count
        Dim dsCaChieu = Ung_dung.Danh_sach_Ca_Chieu
        For Each caChieu As XL_CA_CHIEU In dsCaChieu

            Dim tongVe As Integer = 0
            For Each ve As XL_VE In dsVeDaDat
                If ve.Xuat_Chieu.Ca_Chieu.ID = caChieu.ID Then
                    tongVe = tongVe + 1
                End If
            Next
            Dim tile As Double
            If (tongSoVe > 0) Then
                tile = (tongVe / tongSoVe) * 100
            Else
                tile = 0
            End If

            Dim xlThongKeVe As New XL_THONGKE_VE(caChieu.Ten, tongVe, tile)
            Danh_Sach_Ket_Qua.Add(xlThongKeVe)
        Next
    End Function
#End Region
    Public Class XL_THONGKE_VE
        Public caChieu As String
        Public soVe As Double
        Public tiLe As Double
        Public Sub New(_caChieu As String, _soVe As Double, _tiLe As Double)
            caChieu = _caChieu
            soVe = _soVe
            tiLe = _tiLe
        End Sub
    End Class
End Class