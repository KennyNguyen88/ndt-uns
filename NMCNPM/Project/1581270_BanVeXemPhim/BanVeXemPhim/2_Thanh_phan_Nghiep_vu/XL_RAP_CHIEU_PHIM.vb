Public Class XL_RAP_CHIEU_PHIM
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
    Public Property Dien_Thoai As String
        Get
            Return Dong("Dien_Thoai")
        End Get
        Set(value As String)
            Dong("Dien_Thoai") = value
        End Set
    End Property
    Public Property Dia_Chi As String
        Get
            Return Dong("Dia_Chi")
        End Get
        Set(value As String)
            Dong("Dia_Chi") = value
        End Set
    End Property

#End Region
#Region "Thuộc tính tính toán "
#End Region
#Region "Trích rút Đối tượng liên kết"
    '====== Liên kết thuận ========

    '====== Liên kết nghịch ========

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
        Kq &= "Tên: " & Ten & vbCrLf
        Kq &= "Điện Thoại: " & Dien_Thoai & vbCrLf
        Kq &= "Địa Chỉ: " & Dia_Chi & vbCrLf
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
        '===Tên Rạp Chiếu khác trống
        Hop_le = Not "".Equals(Ten)
        If Not Hop_le Then
            Kq = "Tên Rạp Chiếu không được rỗng" & vbCrLf
        End If

        '===Địa chỉ khác trống
        Hop_le = Not "".Equals(Dia_Chi)
        If Not Hop_le Then
            Kq = "Địa chỉ không được rỗng" & vbCrLf
        End If
        Return Kq
    End Function
    Public Function Kiem_Tra_Xoa() As String
        Dim kq As String = ""
        Dim Hop_le As Boolean = True
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
