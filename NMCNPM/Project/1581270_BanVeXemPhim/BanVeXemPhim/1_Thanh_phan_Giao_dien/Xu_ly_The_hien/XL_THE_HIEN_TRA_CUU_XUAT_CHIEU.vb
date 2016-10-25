Partial Public Class XL_THE_HIEN
    Sub Xuat_Danh_sach_Xuat_Chieu(Danh_sach_Doi_tuong As List(Of XL_XUAT_CHIEU),
                              Th_Danh_sach_Doi_tuong As FlowLayoutPanel)

        For Each xuatchieu In Danh_sach_Doi_tuong
            '==== Tạo thể hiện đối tượng 
            Dim Th_Doi_tuong As New Button
            Th_Doi_tuong.BackColor = Color.White
            Th_Doi_tuong.ForeColor = Color.Black
            Th_Doi_tuong.FlatStyle = FlatStyle.Flat
            Th_Doi_tuong.Font = New Font(Th_Doi_tuong.Font.Name, 14, Th_Doi_tuong.Font.Style)
            Th_Doi_tuong.TextAlign = ContentAlignment.MiddleLeft
            Th_Doi_tuong.AutoSize = True

            Th_Danh_sach_Doi_tuong.Controls.Add(Th_Doi_tuong)
            '=== Xuất Tóm tắt
            Th_Doi_tuong.Text = xuatchieu.Tao_Chuoi_Tom_tat
            '=== Xuất Thông tin dạng ghi chú 
            Dim Th_Thong_tin As New ToolTip
            Th_Thong_tin.IsBalloon = True
            Th_Thong_tin.SetToolTip(Th_Doi_tuong, xuatchieu.Tao_Chuoi_Thong_tin)
        Next
    End Sub

    Sub Xuat_Danh_sach_Xuat_Chieu_Beta(Danh_sach_Doi_tuong As List(Of XL_XUAT_CHIEU),
                              Th_Danh_sach_Doi_tuong As FlowLayoutPanel, XL_Chon_Doi_tuong_Chi_Tiet As EventHandler)
        For Each xuatchieu In Danh_sach_Doi_tuong
            'Panel
            Dim pnel As New FlowLayoutPanel
            pnel.FlowDirection = FlowDirection.LeftToRight
            pnel.AutoSize = True
            '==== Tạo thể hiện chi tiết
            Dim Th_Doi_tuong_Chi_Tiet As New Button
            Th_Doi_tuong_Chi_Tiet.Text = xuatchieu.Tao_Chuoi_Tom_tat
            Th_Doi_tuong_Chi_Tiet.Tag = xuatchieu
            Dinh_Dang_Button(Th_Doi_tuong_Chi_Tiet)
            AddHandler Th_Doi_tuong_Chi_Tiet.Click, XL_Chon_Doi_tuong_Chi_Tiet
            pnel.Controls.Add(Th_Doi_tuong_Chi_Tiet)

            ''==== Tạo thể hiện xóa
            'Dim Th_Doi_tuong_Xoa As New Button
            'Th_Doi_tuong_Xoa.Text = "Xóa"
            'Th_Doi_tuong_Xoa.Tag = xuatchieu
            'Dinh_Dang_Button(Th_Doi_tuong_Xoa)
            'AddHandler Th_Doi_tuong_Xoa.Click, XL_Chon_Doi_tuong_Xoa
            'pnel.Controls.Add(Th_Doi_tuong_Xoa)

            ''==== Tạo thể hiện cập nhật
            'Dim Th_Doi_tuong_CapNhat As New Button
            'Th_Doi_tuong_CapNhat.Text = "Cập Nhật"
            'Th_Doi_tuong_CapNhat.Tag = xuatchieu
            'Dinh_Dang_Button(Th_Doi_tuong_CapNhat)
            'AddHandler Th_Doi_tuong_CapNhat.Click, XL_Chon_Doi_tuong_CapNhat
            'pnel.Controls.Add(Th_Doi_tuong_CapNhat)

            Th_Danh_sach_Doi_tuong.Controls.Add(pnel)
        Next
    End Sub

    Sub Dinh_Dang_Button(_button As Button)
        _button.BackColor = Color.White
        _button.ForeColor = Color.Black
        _button.FlatStyle = FlatStyle.Flat
        _button.Font = New Font(_button.Font.Name, 14, _button.Font.Style)
        _button.TextAlign = ContentAlignment.MiddleLeft
        _button.AutoSize = True
    End Sub

    Sub Xuat_Chi_Tiet_Suat_Chieu(suatChieu As XL_XUAT_CHIEU, Th_Chi_Tiet As FlowLayoutPanel, XL_Chon_Doi_tuong As EventHandler)
        Th_Chi_Tiet.Controls.Clear()
        Dim chiTiet As Label
        chiTiet.Text = suatChieu.Tao_Chuoi_Thong_tin
        chiTiet.ForeColor = Color.Black
        chiTiet.Font = New Font(chiTiet.Font.Name, 14, chiTiet.Font.Style)
        Th_Chi_Tiet.Controls.Add(chiTiet)
    End Sub

    Sub Xuat_Danh_Sach_Phim(Danh_Sach_Phim As List(Of XL_PHIM), Th_Danh_Sach_Phim As ComboBox)
        Th_Danh_Sach_Phim.Items.Clear()
        If Danh_Sach_Phim.Count > 0 Then
            Th_Danh_Sach_Phim.Items.Add("-----Tất cả Phim-----")
            Th_Danh_Sach_Phim.SelectedIndex = 0
            Th_Danh_Sach_Phim.Items.AddRange(Danh_Sach_Phim.ToArray)
            Th_Danh_Sach_Phim.ValueMember = "ID"
            Th_Danh_Sach_Phim.DisplayMember = "Ten"
        End If
    End Sub

    Sub Xuat_Danh_Sach_Phim(Danh_Sach_Phim As List(Of XL_PHIM), Th_Danh_Sach_Phim As FlowLayoutPanel, XL_Chon_Doi_tuong As EventHandler)
        For Each phim As XL_PHIM In Danh_Sach_Phim
            Dim chb As New CheckBox
            chb.Tag = phim
            chb.Text = phim.Ten
            Dinh_Dang_Checkbox(chb)
            chb.Checked = True
            Th_Danh_Sach_Phim.Controls.Add(chb)
            AddHandler chb.CheckedChanged, XL_Chon_Doi_tuong
        Next
    End Sub

    Sub Xuat_Danh_Sach_Ca_Chieu(Danh_Sach_Ca_Chieu As List(Of XL_CA_CHIEU), Th_Danh_Sach_Ca_Chieu As FlowLayoutPanel, XL_Chon_Doi_tuong As EventHandler)

        For Each ca_chieu As XL_CA_CHIEU In Danh_Sach_Ca_Chieu
                Dim chb As New CheckBox
                chb.Tag = ca_chieu
                chb.Text = ca_chieu.Ten
            Dinh_Dang_Checkbox(chb)
            chb.Checked = True
            Th_Danh_Sach_Ca_Chieu.Controls.Add(chb)
            AddHandler chb.CheckedChanged, XL_Chon_Doi_tuong
        Next

    End Sub

    Sub Xuat_Danh_Sach_Ca_Chieu(Danh_Sach_Ca_Chieu As List(Of XL_CA_CHIEU), Th_Danh_Sach_Ca_Chieu As ComboBox)
        Th_Danh_Sach_Ca_Chieu.Items.Clear()
        If Danh_Sach_Ca_Chieu.Count > 0 Then
            Th_Danh_Sach_Ca_Chieu.Items.Add("-----Tất cả Ca Chiếu-----")
            Th_Danh_Sach_Ca_Chieu.SelectedIndex = 0
        End If
        Th_Danh_Sach_Ca_Chieu.Items.AddRange(Danh_Sach_Ca_Chieu.ToArray)
        Th_Danh_Sach_Ca_Chieu.ValueMember = "ID"
        Th_Danh_Sach_Ca_Chieu.DisplayMember = "Ten"
    End Sub

    Sub Dinh_Dang_Checkbox(chb As CheckBox)
        chb.ForeColor = Color.Black
        chb.FlatStyle = FlatStyle.Flat
        chb.AutoSize = False
        chb.Anchor = AnchorStyles.Top And AnchorStyles.Left And AnchorStyles.Right
    End Sub



    Sub Dinh_Dang_Ca_Chieu_Button(btn As Button)
        Dinh_Dang_Button(btn)
    End Sub
End Class
