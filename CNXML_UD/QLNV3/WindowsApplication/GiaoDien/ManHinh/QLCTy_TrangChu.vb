Public Class QLCTy_TrangChu
    Protected TheHien As New XL_THE_HIEN
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        KhoiDong()
    End Sub
    Sub KhoiDong()
        'form
        Me.Text = "Trang Chủ - Quản lý Công Ty"
        Me.ActiveControl = logo
        'controls
        'aside
        Label1.Text = FormatIF.string_info1
        Label2.Text = FormatIF.string_info2
        TheHien.Dinh_Dang_InfoHeThong(Label1)
        TheHien.Dinh_Dang_InfoHeThong(Label2)
        TheHien.Dinh_Dang_Textbox_Common(txtSearch, "Tra Cứu...")
        TheHien.Dinh_Dang_Button_Menu(btnHSCT)
        btnHSCT.Text = "Hồ Sơ Công Ty"
        TheHien.Dinh_Dang_Button_Menu(btnHSCN)
        btnHSCN.Text = "Hồ Sơ Chi Nhánh"
        TheHien.Dinh_Dang_Button_Menu(btnHSDV)
        btnHSDV.Text = "Hồ Sơ Đơn Vị"
        TheHien.Dinh_Dang_Button_Menu(btnTCDV)
        btnTCDV.Text = "Thuyên Chuyển Đơn Vị"
    End Sub
End Class