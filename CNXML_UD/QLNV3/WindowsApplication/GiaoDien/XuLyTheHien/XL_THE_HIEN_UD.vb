Partial Public Class XL_THE_HIEN
    Sub Dinh_Dang_Form(form As Form, Optional ByVal w As Integer = 1366, Optional ByVal h As Integer = 768)
        form.Size = New Size(w, h)
        form.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Sub Dinh_Dang_Button_Primary(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.BackColor = FormatIF.color_dark_blue
        btn.ForeColor = FormatIF.color_white
        btn.Font = New Font(btn.Font.Name, FormatIF.font_size_button, btn.Font.Style)
    End Sub
    Sub Dinh_Dang_Button_Menu(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.BackColor = FormatIF.color_light_grey
        btn.ForeColor = FormatIF.color_black
        btn.Font = New Font(btn.Font.Name, FormatIF.font_size_button, btn.Font.Style)
    End Sub
End Class
