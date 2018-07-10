Public Class MH_Xu_Ly_Danh_Sach
    Dim DanhSachA As List(Of Integer)
    Dim DanhSachB As List(Of Integer)
    Function Chuyen_Sang_Chuoi() As String
        Dim KetQua As String = ""
        For Each item As Integer In DanhSachB
            KetQua &= item & ","
        Next
        Return KetQua
    End Function
    Private Sub MH_Xu_Ly_Danh_Sach_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Khoi dong du lieu
        DanhSachA = New Integer() {1, 2, 3, 4, 5, -10, -11, -12, -13}.ToList()
        DanhSachB = New Integer() {100, 200, -300, -400}.ToList()

        'Xuat du lieu
        For Each item As Integer In DanhSachA
            cb_A.Items.Add(item)
        Next

        txt_B.Text = Chuyen_Sang_Chuoi()

    End Sub

    Private Sub cb_A_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_A.SelectedIndexChanged

        'So duoc chon
        Dim ChiSo As Integer = cb_A.SelectedIndex
        Dim SoChon As Integer = DanhSachA(ChiSo)

        'Them vao danh sach B
        DanhSachB.Add(SoChon)

        'Xuat ra man hinh
        txt_B.Text = Chuyen_Sang_Chuoi()

    End Sub

End Class