﻿Public Class XL_PHIM
#Region "Biến/Đối tượng toàn cục"
    Public ReadOnly Ung_dung As XL_UNG_DUNG
    Public ReadOnly Dong As DataRow

#End Region
#Region "Khởi động"
    Public Sub New(Ud As XL_UNG_DUNG, x As DataRow)
        Ung_dung = Ud
        Dong = x
    End Sub
#End Region
#Region "Thuộc tính"

    Public Property ID As Integer
        Get
            Return Dong("ID")
        End Get
        Set(value As Integer)
            Dong("ID") = value
        End Set
    End Property
    Public Property Ten As String
        Get
            Return Dong("Ten")
        End Get
        Set(value As String)
            Dong("Ten") = value
        End Set
    End Property

#End Region
#Region "Thuộc tính tính toán "
#End Region
#Region "Trích rút Đối tượng liên kết"
    '====== Liên kết thuận ========


    '====== Liên kết nghịch ========

    Public ReadOnly Property Danh_sach_Xuat_Chieu As List(Of XL_XUAT_CHIEU)
        Get
            Dim Kq As New List(Of XL_XUAT_CHIEU)
            Kq = Ung_dung.Danh_sach_Xuat_Chieu.FindAll(Function(x) x.ID_PHIM = ID)
            Return Kq
        End Get
    End Property

#End Region
#Region "Tạo Chuỗi"
    '======  Xem Thông tin =====
    Public Function Tao_Chuoi_Tom_tat() As String
        Dim Kq As String = ""
        Kq &= Ten
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_tin(Optional Co_ID As Boolean = False) As String
        Dim Kq As String = ""
        If Co_ID Then
            Kq &= "ID :" & ID & vbCrLf  '=== Chỉ phục vụ thử nghiệm
        End If
        Kq &= "Phim : " & Ten & vbCrLf
        Return Kq
    End Function

    '====== Nhập liệu ======
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Ghi_moi() As String
        Dim Kq As String = ""
        'TODO Tao_Chuoi_Thong_bao_Luu_y_Ghi_moi
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Cap_nhat() As String
        Dim Kq As String = ""
        'TODO Tao_Chuoi_Thong_bao_Luu_y_Cap_nhat
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Xoa() As String
        Dim Kq As String = ""
        'TODO Tao_Chuoi_Thong_bao_Luu_y_Xoa
        Return Kq
    End Function
#End Region

#Region "Kiểm tra"
    Public Function Kiem_Tra_Ghi_Moi() As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean
        '===Tên Phim khác trống
        Hop_le = Not "".Equals(Ten)
        If Not Hop_le Then
            Kq = "Tên Phim không được rỗng" & vbCrLf
        End If
        Return Kq
    End Function
    Public Function Kiem_Tra_Xoa() As String
        Dim kq As String = ""
        Dim Hop_le As Boolean
        '===Có phòng tham chiếu tới loại phòng ?
        If (Danh_sach_Xuat_Chieu.Count > 0) Then
            'Có
            Hop_le = False
            kq = "Có suất chiếu tham chiếu đến. Vui lòng hủy (các) suất chiếu trước khi tiến hành xóa !"
        Else
            'Không
            Hop_le = True
        End If
        Return kq
    End Function
    Public Function Kiem_Tra_Sua() As String
        Dim kq As String = ""
        Dim Hop_le As Boolean
        If Not Kiem_Tra_Ghi_Moi().Equals("") Then 'Fail
            Hop_le = False
            kq = Kiem_Tra_Ghi_Moi()
        Else 'Success
            Hop_le = True
        End If
        Return kq
    End Function
#End Region
End Class
