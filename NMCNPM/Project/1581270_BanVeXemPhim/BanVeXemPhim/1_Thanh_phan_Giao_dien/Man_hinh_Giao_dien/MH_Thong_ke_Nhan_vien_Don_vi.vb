Public Class MH_Thong_ke_Nhan_vien_Don_vi
#Region "Biến/Đối tượng toàn cục"
    Protected Luu_tru As XL_LUU_TRU
    Protected Ung_dung As XL_UNG_DUNG
    Protected The_hien As XL_THE_HIEN


#End Region

#Region "Xử lý Biến cố Khởi động"
    Public Sub New(Ung_dung As XL_UNG_DUNG)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Luu_tru = New XL_LUU_TRU
        Me.Ung_dung = Ung_dung
        The_hien = New XL_THE_HIEN(Ung_dung)
        Khoi_dong()

    End Sub

    Sub Khoi_dong()
        '1.==== Khởi động dữ liệu :  


        '2.===Khởi động thể hiện ===
        ' ==== Màn hình 
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Black
        Me.ForeColor = Color.White
        Me.Font = New Font("Arial", 12)
        '===Tiêu đề 
        Th_Tieu_de.Font = New Font("Arial", 18)
        Th_Tieu_de.TextAlign = ContentAlignment.MiddleCenter
        Th_Tieu_de.Padding = New Padding(100, 10, 0, 10)
        Th_Tieu_de.AutoSize = True
        Dim Tieu_de As String = "Thống kê số lượng nhân viên theo đơn vị"
        Th_Tieu_de.Text = Tieu_de
        '===Thực đơn tỉnh : Hiện nay chưa xem xét 

        '===Thực đơn động :  Hiện nay chưa xem xét 

        '=== Thông báo :  
        Th_Thong_bao.Font = New Font("Arial", 14)
        Th_Thong_bao.TextAlign = ContentAlignment.MiddleLeft
        Th_Thong_bao.Padding = New Padding(10)
        Th_Thong_bao.ForeColor = Color.Yellow
        Th_Thong_bao.AutoSize = True
        Dim Thong_bao As String = "Tổng số nhân viên :" & Ung_dung.Danh_sach_Nhan_vien().Count
        Th_Thong_bao.Text = Thong_bao
        '=== Tiêu chí Thông kê  : Hiện nay chưa xem xét 

        '=== Kêt quả Tra cứu : Danh_sách thống kê 
        The_hien.Xuat_Danh_sach_Thong_ke_Nhan_vien_theo_Don_vi(Th_Danh_sach_Thong_ke, Nothing)

    End Sub

#End Region


End Class