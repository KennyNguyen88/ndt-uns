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
        Me.Text = FormatIF.QLCTy_TrangChu_form_title
        Me.ActiveControl = logo
        'controls
        'aside
        Label1.Text = FormatIF.string_info1
        Label2.Text = FormatIF.string_info2
        TheHien.Dinh_Dang_InfoHeThong(Label1)
        TheHien.Dinh_Dang_InfoHeThong(Label2)
        TheHien.Dinh_Dang_Textbox_Common(txtSearch, FormatIF.string_search_placeholder)
        TheHien.Dinh_Dang_Button_Menu(btnHSCT)
        btnHSCT.Text = FormatIF.string_menu_01
        TheHien.Dinh_Dang_Button_Menu(btnHSCN)
        btnHSCN.Text = FormatIF.string_menu_02
        TheHien.Dinh_Dang_Button_Menu(btnHSDV)
        btnHSDV.Text = FormatIF.string_menu_03
        TheHien.Dinh_Dang_Button_Menu(btnTCDV)
        btnTCDV.Text = FormatIF.string_menu_04
        'main
        'top
        pnTop.BackColor = FormatIF.color_light_blue
        pnTop_Info.BackColor = Color.Transparent
        pnTop_Dia.BackColor = Color.Transparent
        pnTop_lbTitle.Text = FormatIF.QLCTy_TrangChu_pnTop_title
        TheHien.Dinh_Dang_Header_h1(pnTop_lbTitle)
        'bot
        pnBot.BackColor = FormatIF.color_light_blue
        pnBot_info.BackColor = Color.Transparent
        pnBot_Dia.BackColor = Color.Transparent
        pnBot_lbTitle.Text = FormatIF.QLCTy_TrangChu_pnBot_title
        TheHien.Dinh_Dang_Header_h1(pnBot_lbTitle)
    End Sub
End Class