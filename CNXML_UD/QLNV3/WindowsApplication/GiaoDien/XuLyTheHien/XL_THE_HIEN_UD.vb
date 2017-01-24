Partial Public Class XL_THE_HIEN
    Sub Dinh_Dang_Form(form As Form, Optional ByVal w As Integer = 1366, Optional ByVal h As Integer = 768)
        form.Size = New Size(w, h)
        form.StartPosition = FormStartPosition.CenterScreen
    End Sub
    Sub Dinh_Dang_Button_Common(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.Cursor = Cursors.Hand
        btn.FlatAppearance.BorderSize = 0
        btn.AutoSize = True

    End Sub
    Sub Dinh_Dang_Button_Primary(btn As Button)
        Dinh_Dang_Button_Common(btn)
        btn.BackColor = FormatIF.color_dark_blue
        btn.ForeColor = FormatIF.color_white
        btn.FlatAppearance.MouseOverBackColor = FormatIF.color_dark_blue
        btn.Font = New Font(btn.Font.Name, FormatIF.font_size_button, btn.Font.Style)
    End Sub
    Sub Dinh_Dang_Button_Menu(btn As Button)
        Dinh_Dang_Button_Common(btn)
        btn.BackColor = FormatIF.color_light_grey
        btn.ForeColor = FormatIF.color_black
        btn.FlatAppearance.MouseOverBackColor = FormatIF.color_light_grey
        btn.FlatAppearance.MouseDownBackColor = FormatIF.color_grey
        btn.Font = New Font(btn.Font.Name, FormatIF.font_size_button, btn.Font.Style)
        btn.TextAlign = ContentAlignment.MiddleLeft
        btn.ImageAlign = ContentAlignment.MiddleRight
        btn.Height = 50
    End Sub
    Sub Dinh_Dang_Button_Menu_Active(btn As Button)
        Dinh_Dang_Button_Common(btn)
        btn.BackColor = FormatIF.color_dark_blue
        btn.ForeColor = FormatIF.color_white
        btn.FlatAppearance.MouseOverBackColor = FormatIF.color_dark_blue
        btn.Font = New Font(btn.Font.Name, FormatIF.font_size_button, btn.Font.Style)
        btn.TextAlign = ContentAlignment.MiddleLeft
        btn.ImageAlign = ContentAlignment.MiddleRight
        btn.Height = 50
    End Sub
    'TODO Dinh_Dang_Button_Delete
    Sub Dinh_Dang_Button_Delete(btn As Button)
        Dinh_Dang_Button_Common(btn)
    End Sub
    'TODO Dinh_Dang_Button_Insert
    Sub Dinh_Dang_Button_Insert(btn As Button)
        Dinh_Dang_Button_Common(btn)
    End Sub
    'TODO Dinh_Dang_Button_Update
    Sub Dinh_Dang_Button_Update(btn As Button)
        Dinh_Dang_Button_Common(btn)
    End Sub

    Sub Dinh_Dang_Textbox_Common(tb As TextBox, Optional ByVal ph_text As String = "")
        tb.Font = New Font(tb.Font.Name, FormatIF.font_size_placeholder, tb.Font.Style)
        tb.ForeColor = FormatIF.color_light_grey
        'placeholder text
        tb.Text = ph_text
        If Not ph_text.Equals("") Then
            'on focus clear placeholder text
            AddHandler tb.GotFocus, AddressOf XL_PlaceHolder
        End If
    End Sub
    Sub Dinh_Dang_Textbox_Password(tb As TextBox)
        Dinh_Dang_Textbox_Common(tb, "MatKhau")
        tb.UseSystemPasswordChar = True
    End Sub
    Sub XL_PlaceHolder(tb As TextBox, Bc As EventArgs)
        If Not tb.Modified Then
            tb.Text = ""
        End If
    End Sub
    Sub Dinh_Dang_Combobox_Common(cb As ComboBox)
        cb.Font = New Font(cb.Font.Name, FormatIF.font_size_placeholder, cb.Font.Style)
        cb.ForeColor = FormatIF.color_light_grey
    End Sub
    Sub Dinh_Dang_ThongBao_Error(lb As Label)
        lb.ForeColor = FormatIF.color_error
        lb.Font = New Font(lb.Font.Name, FormatIF.font_size_body, lb.Font.Style)
    End Sub
    Sub Dinh_Dang_Title(lb As Label)
        lb.ForeColor = FormatIF.color_white
        lb.Font = New Font(lb.Font.Name, FormatIF.font_size_title, lb.Font.Style)
    End Sub
    Sub Dinh_Dang_Body(lb As Label)
        lb.ForeColor = FormatIF.color_white
        lb.Font = New Font(lb.Font.Name, FormatIF.font_size_body, lb.Font.Style)
    End Sub
    Sub Dinh_Dang_Header_h1(lb As Label)
        lb.ForeColor = FormatIF.color_white
        lb.Font = New Font(lb.Font.Name, FormatIF.font_size_h1, lb.Font.Style)
    End Sub
    Sub Dinh_Dang_Header_h2(lb As Label)
        lb.ForeColor = FormatIF.color_white
        lb.Font = New Font(lb.Font.Name, FormatIF.font_size_h2, lb.Font.Style)
    End Sub
    Sub Dinh_Dang_InfoHeThong(lb As Label)
        lb.ForeColor = FormatIF.color_grey
        lb.Font = New Font(lb.Font.Name, FormatIF.font_size_body, lb.Font.Style)
    End Sub
    Sub Dinh_Dang_Checkbox(cb As CheckBox)
        cb.Font = New Font(cb.Font.Name, FormatIF.font_size_placeholder, cb.Font.Style)
        cb.ForeColor = FormatIF.color_white
        cb.FlatStyle = FlatStyle.Flat
        cb.FlatAppearance.CheckedBackColor = FormatIF.color_dark_blue
        cb.UseVisualStyleBackColor = False
    End Sub


End Class
