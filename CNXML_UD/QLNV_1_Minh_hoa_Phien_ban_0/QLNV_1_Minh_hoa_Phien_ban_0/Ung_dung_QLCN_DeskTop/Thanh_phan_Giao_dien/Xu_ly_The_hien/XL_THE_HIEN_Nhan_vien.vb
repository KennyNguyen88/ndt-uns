Partial Public Class XL_THE_HIEN
#Region "Xuất Danh_sach Biếu tượng"
    Public Sub Xuat_Danh_sach_Nhan_vien_Tra_cuu(Danh_sach As DataTable, Th_Danh_sach As FlowLayoutPanel,
                                         Optional XL_Bien_co_Chon_Doi_tuong As EventHandler = Nothing)
        Th_Danh_sach.Controls.Clear()

        For Each Doi_tuong As DataRow In Danh_sach.Rows
            '== Khởi tạo thể hiện  
            Dim Th_Doi_tuong As New Button
            Th_Danh_sach.Controls.Add(Th_Doi_tuong)
            '=== Xuất thông tin thể hiện  
            Dim Chuoi_Tom_tat As String = Doi_tuong("Ho_ten") & vbCrLf
            Th_Doi_tuong.Text = Chuoi_Tom_tat
            Dim Chuoi_Thong_tin As String = ""
            Chuoi_Thong_tin &= "Họ tên :" & Doi_tuong("Ho_ten") & vbCrLf
            Chuoi_Thong_tin &= "Tuổi :" & Doi_tuong("Tuoi") & vbCrLf
            Chuoi_Thong_tin &= "Mức lương :" & Doi_tuong("Muc_luong") & vbCrLf
            Chuoi_Thong_tin &= "Đơn vị :" & Doi_tuong("Ten_Don_vi") & vbCrLf
            Chuoi_Thong_tin &= "Chi nhánh :" & Doi_tuong("Ten_Chi_nhanh") & vbCrLf
            Dim Th_Thong_tin As New ToolTip()
            Th_Thong_tin.IsBalloon = True
            Th_Thong_tin.SetToolTip(Th_Doi_tuong, Chuoi_Thong_tin)
            '=== Dịnh dạng thể hiện
            Th_Doi_tuong.TextAlign = ContentAlignment.MiddleCenter
            Th_Doi_tuong.BackColor = Color.White
            Th_Doi_tuong.ForeColor = Color.Blue
            Th_Doi_tuong.Font = New Font("Arial", 11)
            Th_Doi_tuong.AutoSize = False
            Th_Doi_tuong.Size = New Size(170, 30)
            '===Chuẩn bị biến cố  
            Th_Doi_tuong.Tag = Doi_tuong
            If XL_Bien_co_Chon_Doi_tuong IsNot Nothing Then
                AddHandler Th_Doi_tuong.Click, XL_Bien_co_Chon_Doi_tuong
            End If

        Next
    End Sub

#End Region

#Region "Hồ sơ"
    Public Sub Khoi_dong_Ho_so_Nhan_vien(Du_lieu As DataSet, Th_Ho_so As Panel)
        Xuat_Danh_sach_Chon_Gioi_tinh(Du_lieu.Tables("GIOI_TINH"), Th_Ho_so.Controls("Th_Danh_sach_Gioi_tinh"))
        Xuat_Danh_sach_Chon_Don_vi(Du_lieu.Tables("DON_VI"), Th_Ho_so.Controls("Th_Danh_sach_Don_vi"))
    End Sub
    Public Sub Xuat_Ho_so_Nhan_vien(Nhan_vien As DataRow, Th_Ho_so As Panel)
        For Each Thuoc_tinh As DataColumn In Nhan_vien.Table.Columns
            Dim Ten As String = Thuoc_tinh.ColumnName
            If Th_Ho_so.Controls("Th_" & Ten) IsNot Nothing Then
                Th_Ho_so.Controls("Th_" & Ten).Text = Nhan_vien(Ten)
            End If
        Next
        For Each Th_Gioi_tinh As RadioButton In Th_Ho_so.Controls("Th_Danh_sach_Gioi_tinh").Controls
            Dim Gioi_tinh As DataRow = Th_Gioi_tinh.Tag
            If Gioi_tinh("ID") = Nhan_vien("ID_GIOI_TINH") Then
                Th_Gioi_tinh.Checked = True
            End If
        Next
        For Each Th_Don_vi As RadioButton In Th_Ho_so.Controls("Th_Danh_sach_Don_vi").Controls
            Dim Don_vi As DataRow = Th_Don_vi.Tag
            If Don_vi("ID") = Nhan_vien("ID_DON_VI") Then
                Th_Don_vi.Checked = True
            End If
        Next
    End Sub
    Public Function Nhap_Ho_so_Nhan_vien(Nhan_vien As DataRow, Th_Ho_so As Panel) As String
        Dim Kq As String = ""
        Try
            For Each Thuoc_tinh As DataColumn In Nhan_vien.Table.Columns
                Dim Ten As String = Thuoc_tinh.ColumnName
                If Th_Ho_so.Controls("Th_" & Ten) IsNot Nothing Then
                    Nhan_vien(Ten) = Th_Ho_so.Controls("Th_" & Ten).Text.Trim
                End If
            Next
        Catch ex As Exception
            If ex.Message.Contains("Ngay_sinh") Then
                Kq = "Ngày sinh không hợp lệ"
            End If
            If ex.Message.Contains("Muc_luong") Then
                Kq = "Mức lương không hợp lệ"
            End If
        End Try
        If Kq = "" Then
            For Each Th_Gioi_tinh As RadioButton In Th_Ho_so.Controls("Th_Danh_sach_Gioi_tinh").Controls
                Dim Gioi_tinh As DataRow = Th_Gioi_tinh.Tag
                If Th_Gioi_tinh.Checked = True Then
                    Nhan_vien("ID_GIOI_TINH") = Gioi_tinh("ID")
                End If
            Next
            For Each Th_Don_vi As RadioButton In Th_Ho_so.Controls("Th_Danh_sach_Don_vi").Controls
                Dim Don_vi As DataRow = Th_Don_vi.Tag
                If Th_Don_vi.Checked = True Then
                    Nhan_vien("ID_DON_VI") = Don_vi("ID")
                End If
            Next
        End If

        Return Kq
    End Function
#End Region
End Class
