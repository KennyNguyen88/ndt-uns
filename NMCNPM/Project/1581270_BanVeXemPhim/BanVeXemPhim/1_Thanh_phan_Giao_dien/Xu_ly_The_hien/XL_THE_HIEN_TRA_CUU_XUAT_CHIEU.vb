Partial Public Class XL_THE_HIEN
    Sub Xuat_Danh_sach_Xuat_Chieu(Danh_sach_Doi_tuong As List(Of XL_XUAT_CHIEU),
                              Th_Danh_sach_Doi_tuong As FlowLayoutPanel, XL_Chon_Doi_tuong As EventHandler)
        Th_Danh_sach_Doi_tuong.Controls.Clear()
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
End Class
