Public Class QLCTy_QLHoSoCongTy
    Protected TheHien As New XL_THE_HIEN
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        KhoiDong()
    End Sub
    Sub KhoiDong()
        'form
        Me.Text = FormatIF.QLCTy_QLHoSoCongTy_form_title
        Me.ActiveControl = logo
        'controls
        'aside
        Label1.Text = FormatIF.string_info1
        Label2.Text = FormatIF.string_info2
        TheHien.Dinh_Dang_InfoHeThong(Label1)
        TheHien.Dinh_Dang_InfoHeThong(Label2)
        TheHien.Dinh_Dang_Textbox_Common(txtSearch, FormatIF.string_search_placeholder)
        TheHien.Dinh_Dang_Button_Menu_Active(btnHSCT)
        btnHSCT.Text = FormatIF.string_menu_01
        TheHien.Dinh_Dang_Button_Menu(btnHSCN)
        btnHSCN.Text = FormatIF.string_menu_02
        TheHien.Dinh_Dang_Button_Menu(btnHSDV)
        btnHSDV.Text = FormatIF.string_menu_03
        TheHien.Dinh_Dang_Button_Menu(btnTCDV)
        btnTCDV.Text = FormatIF.string_menu_04


        'main
        lbTitle.Text = FormatIF.QLCTy_QLHoSoCongTy_pnTop_title
        pnTop.BackColor = FormatIF.color_light_blue
        TheHien.Dinh_Dang_Title(lbTitle)
        TheHien.Dinh_Dang_Body(lb_txtTenCongTy)
        TheHien.Dinh_Dang_Textbox_Common(txtTenCongTy)
        TheHien.Dinh_Dang_Button_Primary(btnCapNhat)
        btnCapNhat.Text = FormatIF.string_update
    End Sub
End Class