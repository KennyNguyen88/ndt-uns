Public Class MH_Ung_dung_New
#Region "Biến/Đối tượng toàn cục"
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
    Protected The_hien As XL_THE_HIEN
    Dim CaChieuList As List(Of XL_CA_CHIEU)

#End Region

#Region "Xử lý Biến cố Khởi động"
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.        
        Luu_tru = New XL_LUU_TRU("DO_AN")
        Dim Du_lieu As DataSet = Luu_tru.Doc_Du_lieu
        Ung_dung = New XL_UNG_DUNG(Du_lieu)
        The_hien = New XL_THE_HIEN(Ung_dung)
        CaChieuList = New List(Of XL_CA_CHIEU)
        Khoi_dong()
    End Sub
    Sub Khoi_dong()
        '1 ==== Khởi động dữ liệu        
        CaChieuList = Ung_dung.Danh_sach_Ca_Chieu()
        '2 ===== Khởi động thể hiện       
        '===Tiêu đề 
        Dim Tieu_de As String = "Bán vé xem phim 1"
        Th_Tieu_de.Text = Tieu_de
        '===Thực đơn tỉnh
        The_hien.Xuat_Thuc_don_Ttnh_cua_Ung_dung(Thuc_don, AddressOf XL_Chon_Chuc_nang)
        '===Thực đơn động 
        The_hien.Tao_Thuc_don_dong_cua_Ung_dung(Me, AddressOf XL_Chon_Chuc_nang)
        '=== Thông báo 
        Th_Thong_bao.Padding = New Padding(10)
        Dim Thong_bao As String = ""
        Th_Thong_bao.Text = Thong_bao
        '=== Ca Chieu
        The_hien.Xuat_Danh_Sach_Ca_Chieu_Button(CaChieuList, flowCaChieu, AddressOf XL_Chon_Ca_Chieu)
    End Sub
#End Region
#Region "Xử lý Biến cố Chính - Chọn chức năng "
    Sub XL_Chon_Chuc_nang(Th_Chuc_nang As ToolStripItem, Bc As EventArgs)
        Dim Ma_so_Chon As String = Th_Chuc_nang.Tag
        If Ma_so_Chon = "KET_THUC" Then
            Me.Close()
            '=== Chức năng Tra Cứu
        ElseIf Ma_so_Chon = "TRA_CUU_SUAT_CHIEU" Then
            Dim Mh As New MH_Tra_Cuu_Suat_Chieu_Beta(Ung_dung)
            Mh.ShowDialog()
            '=== Chức năng Quản Lý
        ElseIf Ma_so_Chon = "QUAN_LY_RAP_CHIEU_PHIM" Then
            Dim Mh As New MH_Quan_Ly_Rap(Ung_dung)
            Mh.ShowDialog()

        ElseIf Ma_so_Chon = "QUAN_LY_PHIM" Then
            Dim Mh As New MH_Quan_Ly_Phim(Ung_dung)
            Mh.ShowDialog()

        ElseIf Ma_so_Chon = "QUAN_LY_CA_CHIEU" Then
            Dim Mh As New MH_Quan_Ly_Ca_Chieu(Ung_dung)
            Mh.ShowDialog()

        ElseIf Ma_so_Chon = "QUAN_LY_XUAT_CHIEU" Then
            Dim Mh As New MH_Quan_Ly_Suat_Chieu(Ung_dung)
            Mh.ShowDialog()

        ElseIf Ma_so_Chon = "QUAN_LY_PHONG" Then
            Dim Mh As New MH_Quan_Ly_Phong(Ung_dung)
            Mh.ShowDialog()

        ElseIf Ma_so_Chon = "QUAN_LY_LOAI_PHONG" Then
            Dim Mh As New MH_Quan_Ly_Loai_Phong(Ung_dung)
            Mh.ShowDialog()

        ElseIf Ma_so_Chon = "QUAN_LY_VE" Then
            Dim Mh As New MH_Chon_Suat_Chieu(Ung_dung)
            Mh.ShowDialog()

        ElseIf Ma_so_Chon = "QUAN_LY_GHE" Then
            Dim Mh As New MH_Quan_ly_Ghe(Ung_dung)
            Mh.ShowDialog()
        ElseIf Ma_so_Chon = "THONG_KE" Then
            Dim Mh As New MH_Thong_Ke(Ung_dung)
            Mh.ShowDialog()
        End If

    End Sub
    Sub XL_Chon_Ca_Chieu(Th_Ca_Chieu As Button, Bc As EventArgs)
        Dim CaChieu As XL_CA_CHIEU = Th_Ca_Chieu.Tag
        Dim SuatChieuList As List(Of XL_XUAT_CHIEU) = New List(Of XL_XUAT_CHIEU)
        SuatChieuList = Ung_dung.Danh_sach_Xuat_Chieu_Theo_Ngay(Date.Today)
        Dim SuatChieuTheoCaList As List(Of XL_XUAT_CHIEU) = New List(Of XL_XUAT_CHIEU)
        For Each suatChieu As XL_XUAT_CHIEU In SuatChieuList
            If suatChieu.Ca_Chieu.Ten = CaChieu.Ten Then
                SuatChieuTheoCaList.Add(suatChieu)
            End If
        Next
        flowSuatChieu.Controls.Clear()
        flowGhe.Controls.Clear()
        The_hien.Xuat_Danh_sach_Xuat_Chieu_UDN(SuatChieuTheoCaList, flowSuatChieu, AddressOf XL_Chon_Suat_Chieu)
    End Sub

    Sub XL_Chon_Suat_Chieu(Th_Suat_Chieu As Button, Bc As EventArgs)
        Dim SuatChieu As XL_XUAT_CHIEU = Th_Suat_Chieu.Tag
        'Xuat Danh Sach Ve theo suat chieu
        Dim VeList As List(Of XL_VE) = New List(Of XL_VE)
        VeList = Ung_dung.Danh_Sach_Ve_Suat_Chieu(SuatChieu.ID)
        flowGhe.Controls.Clear()
        The_hien.Xuat_Danh_Sach_Ve_UDN(VeList, flowGhe, AddressOf XL_Chon_Ve)
    End Sub

    Sub XL_Chon_Ve(Th_Ve As Button, Bc As EventArgs)
        Dim ve As XL_VE = Th_Ve.Tag
        If ve.TRANG_THAI = "Đã bán" Then
            Dim result As Integer = MessageBox.Show("Bạn muốn trả vé", "", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                'Do Trả vé
                ve.TRANG_THAI = "Chưa bán"
                Dim kqSua = Sua(ve)
                If kqSua.Equals("") Then
                    MessageBox.Show("Đã trả vé thành công !")
                    The_hien.Dinh_Dang_Ve_Chua_Ban(Th_Ve)
                Else
                    MessageBox.Show("Trả vé không thành công !")
                End If
            End If
        Else
            Dim result As Integer = MessageBox.Show("Bạn muốn bán vé", "", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                'Do Bán vé
                ve.TRANG_THAI = "Đã bán"
                Dim kqSua = Sua(ve)
                If kqSua.Equals("") Then
                    MessageBox.Show("Đã bán vé thành công !")
                    The_hien.Dinh_Dang_Ve_Da_Ban(Th_Ve)
                Else
                    MessageBox.Show("Bán vé không thành công !")
                End If
            End If
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