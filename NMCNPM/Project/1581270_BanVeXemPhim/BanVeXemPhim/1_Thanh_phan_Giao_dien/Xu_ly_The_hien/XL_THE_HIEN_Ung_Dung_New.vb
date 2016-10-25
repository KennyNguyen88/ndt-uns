Partial Public Class XL_THE_HIEN
    Sub Xuat_Danh_Sach_Ca_Chieu_Button(Danh_Sach_Ca_Chieu As List(Of XL_CA_CHIEU), Th_Danh_Sach_Ca_Chieu As FlowLayoutPanel, XL_Chon_Doi_tuong As EventHandler)

        For Each ca_chieu As XL_CA_CHIEU In Danh_Sach_Ca_Chieu
            Dim btn As New Button
            Dim parentLayout As New Panel
            'Button
            btn.Tag = ca_chieu
            btn.Text = ca_chieu.Ten
            Dinh_Dang_Ca_Chieu_Button(btn)
            btn.Dock = DockStyle.Fill
            'Image
            Dim Du_lieu_Hinh As Byte() = Luu_tru.Doc_Media("Chuc_nang_24", LOAI_MEDIA.Hinh)
            Dim Luong_Hinh As IO.MemoryStream = New IO.MemoryStream(Du_lieu_Hinh)
            btn.Image = Bitmap.FromStream(Luong_Hinh)
            btn.ImageAlign = ContentAlignment.MiddleLeft
            btn.TextImageRelation = TextImageRelation.ImageBeforeText

            parentLayout.Controls.Add(btn)
            'panel
            parentLayout.Height = 40
            Th_Danh_Sach_Ca_Chieu.Controls.Add(parentLayout)
            AddHandler btn.Click, XL_Chon_Doi_tuong
            Dim FocusHandler As EventHandler = AddressOf btnFocus
            AddHandler btn.GotFocus, FocusHandler
            Dim NoFocusHandler As EventHandler = AddressOf btnNoFcus
            AddHandler btn.LostFocus, NoFocusHandler
        Next
    End Sub
    Sub btnFocus(btn As Button, Bc As EventArgs)
        btn.BackColor = Color.DarkBlue
        btn.ForeColor = Color.White
    End Sub
    Sub btnNoFcus(btn As Button, Bc As EventArgs)
        btn.BackColor = Color.White
        btn.ForeColor = Color.Black
    End Sub
    Sub Xuat_Danh_sach_Xuat_Chieu_UDN(Danh_sach_Doi_tuong As List(Of XL_XUAT_CHIEU),
                              Th_Danh_sach_Doi_tuong As FlowLayoutPanel, XL_Chon_Doi_tuong_Chi_Tiet As EventHandler)
        For Each xuatchieu In Danh_sach_Doi_tuong
            '==== Tạo thể hiện đối tượng 
            Dim Th_Doi_tuong As New Button
            Th_Doi_tuong.BackColor = Color.White
            Th_Doi_tuong.ForeColor = Color.Black
            Th_Doi_tuong.FlatStyle = FlatStyle.Flat
            Th_Doi_tuong.Font = New Font(Th_Doi_tuong.Font.Name, 14, Th_Doi_tuong.Font.Style)
            Th_Doi_tuong.TextAlign = ContentAlignment.MiddleLeft
            Th_Doi_tuong.AutoSize = True
            Th_Doi_tuong.Tag = xuatchieu
            'Image
            Dim Du_lieu_Hinh As Byte() = Luu_tru.Doc_Media("NHAN_VIEN_5", LOAI_MEDIA.Hinh)
            Dim Luong_Hinh As IO.MemoryStream = New IO.MemoryStream(Du_lieu_Hinh)
            Th_Doi_tuong.Image = Bitmap.FromStream(Luong_Hinh)
            Th_Doi_tuong.ImageAlign = ContentAlignment.MiddleLeft
            Th_Doi_tuong.TextImageRelation = TextImageRelation.ImageBeforeText
            Th_Danh_sach_Doi_tuong.Controls.Add(Th_Doi_tuong)
            '=== Xuất Tóm tắt
            Th_Doi_tuong.Text = xuatchieu.Tao_Chuoi_Tom_tat_New
            '=== Xuất Thông tin dạng ghi chú 
            Dim Th_Thong_tin As New ToolTip
            Th_Thong_tin.IsBalloon = True
            Th_Thong_tin.SetToolTip(Th_Doi_tuong, xuatchieu.Tao_Chuoi_Thong_tin)
            '===Click
            AddHandler Th_Doi_tuong.Click, XL_Chon_Doi_tuong_Chi_Tiet
        Next
    End Sub
    Sub Xuat_Danh_Sach_Ve_UDN(Danh_sach_Doi_tuong As List(Of XL_VE),
                              Th_Danh_sach_Doi_tuong As FlowLayoutPanel, XL_Chon_Doi_tuong_Chi_Tiet As EventHandler)
        For Each ve In Danh_sach_Doi_tuong
            '==== Tạo thể hiện đối tượng 
            Dim Th_Doi_tuong As New Button
            Dinh_Dang_Ve_Chua_Ban(Th_Doi_tuong)
            If ve.TRANG_THAI = "Đã bán" Then
                Dinh_Dang_Ve_Da_Ban(Th_Doi_tuong)
            End If
            Th_Doi_tuong.FlatStyle = FlatStyle.Flat
            Th_Doi_tuong.Font = New Font(Th_Doi_tuong.Font.Name, 14, Th_Doi_tuong.Font.Style)
            Th_Doi_tuong.TextAlign = ContentAlignment.MiddleLeft
            Th_Doi_tuong.AutoSize = True
            Th_Doi_tuong.Tag = ve
            Th_Danh_sach_Doi_tuong.Controls.Add(Th_Doi_tuong)
            '=== Xuất Tóm tắt
            Th_Doi_tuong.Text = ve.Tao_Chuoi_Tom_tat_New
            '=== Xuất Thông tin dạng ghi chú 
            Dim Th_Thong_tin As New ToolTip
            Th_Thong_tin.IsBalloon = True
            Th_Thong_tin.SetToolTip(Th_Doi_tuong, ve.Tao_Chuoi_Thong_tin)
            '===Click
            AddHandler Th_Doi_tuong.Click, XL_Chon_Doi_tuong_Chi_Tiet
        Next
    End Sub
    Sub Dinh_Dang_Ve_Da_Ban(btn As Button)
        btn.BackColor = Color.Brown
        btn.ForeColor = Color.White
    End Sub
    Sub Dinh_Dang_Ve_Chua_Ban(btn As Button)
        btn.BackColor = Color.White
        btn.ForeColor = Color.Brown
    End Sub

End Class
