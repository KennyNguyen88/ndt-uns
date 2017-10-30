Imports System.Xml
Public Class XL_THE_HIEN
#Region "Biến/Đối tượng toàn cục"
    Protected Nghiep_vu As New XL_NGHIEP_VU
#End Region
#Region "Nhập-Xuất Chuỗi"
    '==Câu hỏi PET : Tại sao phải tạo các hàm quá đơn giản như thế này ( 1 lệnh duy nhất )
    Public Sub Xuat_Chuoi(Chuoi As String, Th_Chuoi As Control)
        Th_Chuoi.Text = Chuoi
    End Sub
    Public Function Nhap_Chuoi(Th_Chuoi As TextBox) As String
        Dim Chuoi As String = Th_Chuoi.Text.Trim
        Return Chuoi
    End Function
#End Region

#Region "Xuất Danh_sach"
    '==Câu hỏi PET : Hàm này cần cải tiến gì không ? 
    Public Sub Xuat_Danh_sach_Nhan_vien(Danh_sach As List(Of XmlElement), Th_Danh_sach As FlowLayoutPanel)
        Th_Danh_sach.Controls.Clear()
        For Each Nhan_vien As XmlElement In Danh_sach
            '=== Tạo thể hiện : Nhan_vien -- > Th_Nhan_vien
            Dim Th_Nhan_vien As New Label ' (Có thể thay với Control khác == > Quan sát cách thể hiện và Tốc độ)
            Th_Danh_sach.Controls.Add(Th_Nhan_vien)
            '=== Xuất thông tin 
            Th_Nhan_vien.Text = Nhan_vien.GetAttribute("Ho_ten")
            '=== Định dạng thể hiện 
            Th_Nhan_vien.AutoSize = True
            Th_Nhan_vien.ForeColor = Color.White ' ( Có rất nhiều định dạng khác nhưng không phải mục tiêu của minh họa này)
        Next
    End Sub
#End Region
End Class
