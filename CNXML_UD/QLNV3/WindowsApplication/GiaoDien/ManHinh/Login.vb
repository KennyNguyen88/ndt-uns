Public Class Login
    Protected The_hien As XL_THE_HIEN
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        The_hien = New XL_THE_HIEN
        The_hien.Dinh_Dang_Form(Me)
        The_hien.Dinh_Dang_Button_Primary(Button1)
        The_hien.Dinh_Dang_Button_Menu(Button2)
        The_hien.Dinh_Dang_Textbox_Common(TextBox1, "place")
        The_hien.Dinh_Dang_Textbox_Password(TextBox2)
        The_hien.Dinh_Dang_Combobox_Common(ComboBox1)
        The_hien.Dinh_Dang_ThongBao_Error(Label1)
        The_hien.Dinh_Dang_Title(Label2)
        The_hien.Dinh_Dang_Body(Label3)
        The_hien.Dinh_Dang_Header_h1(Label4)
        The_hien.Dinh_Dang_Header_h2(Label5)
        The_hien.Dinh_Dang_Checkbox(CheckBox1)
    End Sub
End Class
