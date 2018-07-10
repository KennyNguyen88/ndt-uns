Public Class MH_Tinh_Tuoi_Nhan_Vien
    Public Structure NHAN_VIEN
        Public Ho_Ten As String
        Public Gioi_Tinh As Boolean
        Public Muc_Luong As Integer
        Public Ngay_Sinh As Date
    End Structure
    Dim NV As NHAN_VIEN
    Private Sub MH_Tinh_Tuoi_Nhan_Vien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Khởi động dữ liệu
        NV.Ho_Ten = "Nguyễn Đức Trung"
        NV.Gioi_Tinh = True
        NV.Muc_Luong = 10000000
        NV.Ngay_Sinh = New Date(1988, 12, 19)

        'Kết xuất dữ liệu
        txt_HoTen.Text = NV.Ho_Ten
        cb_GioiTinh.Checked = NV.Gioi_Tinh
        txt_MucLuong.Text = NV.Muc_Luong
        dtp_NgaySinh.Value = NV.Ngay_Sinh

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        NV.Ngay_Sinh = dtp_NgaySinh.Value

        Dim Tuoi = Today.Year - dtp_NgaySinh.Value.Year

        txt_Tuoi.Text = Tuoi

    End Sub
End Class