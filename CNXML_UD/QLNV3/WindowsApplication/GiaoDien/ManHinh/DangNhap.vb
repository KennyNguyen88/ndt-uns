Public Class DangNhap
    Protected TheHien As New XL_THE_HIEN
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        KhoiDong()
    End Sub
    Sub KhoiDong()
        'form
        Me.Text = "Đăng Nhập"
        'controls
        lbError.Text = ""
        TheHien.Dinh_Dang_ThongBao_Error(lbError)
        TheHien.Dinh_Dang_Textbox_Common(txtUsername, "Tên Đăng Nhập")
        TheHien.Dinh_Dang_Textbox_Password(txtPassword)
        TheHien.Dinh_Dang_Button_Primary(btnSubmit)
        btnSubmit.Text = "Đăng Nhập"
        Me.ActiveControl = lbError
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

    End Sub
End Class