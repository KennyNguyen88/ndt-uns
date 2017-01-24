Partial Public Class XL_THE_HIEN
#Region "Biếu tượng"
    Public Sub Xuat_Danh_sach_Chuc_nang(Danh_sach As DataTable, Th_Danh_sach As FlowLayoutPanel,
                                           Optional XL_Bien_co_Chon_Doi_tuong As EventHandler = Nothing)
        Th_Danh_sach.Controls.Clear()
        For Each Doi_tuong As DataRow In Danh_sach.Rows
            '== Khởi tạo thể hiện  
            Dim Th_Doi_tuong As New Button
            Th_Danh_sach.Controls.Add(Th_Doi_tuong)
            '=== Xuất thông tin thể hiện  
            Dim Chuoi_Tom_tat As String = Doi_tuong("Ten") & vbCrLf
            Th_Doi_tuong.Text = Chuoi_Tom_tat
            '=== Dịnh dạng thể hiện
            Th_Doi_tuong.TextAlign = ContentAlignment.MiddleCenter
            Th_Doi_tuong.BackColor = Color.White
            Th_Doi_tuong.ForeColor = Color.Red
            Th_Doi_tuong.Font = New Font("Arial", 12)
            Th_Doi_tuong.AutoSize = True
            Th_Doi_tuong.Size = New Size(120, 50)
            '===Chuẩn bị biến cố  
            Th_Doi_tuong.Tag = Doi_tuong
            If XL_Bien_co_Chon_Doi_tuong IsNot Nothing Then
                AddHandler Th_Doi_tuong.Click, XL_Bien_co_Chon_Doi_tuong
            End If
        Next
    End Sub

#End Region
End Class
