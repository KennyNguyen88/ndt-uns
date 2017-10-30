Partial Public Class XL_NGHIEP_VU
    Public Sub Xu_ly_PET(Mh As Form)
        Dim Ten As String = Mh.Name
        Dim Th_Thong_bao_PET As Control = Mh.Controls("TH_Thong_bao_PET")
        If Ten = "MH_Dang_nhap" Then
            Th_Thong_bao_PET.Text = Tao_Thong_bao_MH_Dang_nhap()
        End If
    End Sub
    Protected Function Tao_Thong_bao_MH_Dang_nhap() As String
        Dim Thong_bao_PET As String = "Thông báo PET " & vbCrLf
        Thong_bao_PET &= " 1. Mục tiêu của ứng dụng " & vbCrLf
        Thong_bao_PET &= "  - Minh họa 1 trong số nhiều kỹ thuật cho phép áp dụng mô hình 3 lớp vào kiến trúc hướng dịch vụ " & vbCrLf
        Thong_bao_PET &= "  - Minh họa kỹ thuật tổ chức các hàm xử lý Trích rút (Rất quan trọng ) " & vbCrLf
        Thong_bao_PET &= "    == > Áp dụng vào đồ án một cách thích hợp  " & vbCrLf
        Thong_bao_PET &= " 2. Đặc điểm của ứng dụng " & vbCrLf
        Thong_bao_PET &= "  - Giao diện : Đơn giản nhất có thể có  " & vbCrLf
        Thong_bao_PET &= "  - Xử lý  : Chỉ tập trung chủ yếu vào Xử lý nghiệp vụ với ADO ( sinh viên tự chuyển sang XDO ) " & vbCrLf
        Thong_bao_PET &= "  - Lưu trữ  : Đơn giản nhất có thể có  " & vbCrLf
        Thong_bao_PET &= " - Tính đúng đắn  : Còn để lại một số lỗi !!!  " & vbCrLf
        Thong_bao_PET &= " 3. Bài tập tự rèn luyện cho sinh viên (Không cần nộp lại )" & vbCrLf
        Thong_bao_PET &= "  - Cho thực hiện ứng dụng  " & vbCrLf
        Thong_bao_PET &= "    == > Nhân xét về Tính đúng đắn và Giao diện" & vbCrLf
        Thong_bao_PET &= "  - Đọc Source Code" & vbCrLf
        Thong_bao_PET &= "    == > Xử lý lỗi ( nếu phát hiện )" & vbCrLf
        Thong_bao_PET &= "    == > Cải tiến giao diện ( Cẩn thận có thể phát sinh lỗi mới đó !!! )" & vbCrLf
        Return Thong_bao_PET
    End Function
End Class
