Public Class XL_CA_CHIEU
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
    Public Property BAT_DAU As DateTime
        Get
            Return Dong("BAT_DAU")
        End Get
        Set(value As DateTime)
            Dong("BAT_DAU") = value
        End Set
    End Property
    Public Property KET_THUC As DateTime
        Get
            Return Dong("KET_THUC")
        End Get
        Set(value As DateTime)
            Dong("KET_THUC") = value
        End Set
    End Property
    Public Property Buoi As String
        Get
            Return Dong("Buoi")
        End Get
        Set(value As String)
            Dong("Buoi") = value
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
            Kq = Ung_dung.Danh_sach_Xuat_Chieu.FindAll(Function(x) x.ID_CA_CHIEU = ID)
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
        Kq &= "Tên ca chiếu : " & Ten & vbCrLf
        Kq &= "Buổi : " & Buoi & vbCrLf
        Kq &= "Bắt đầu lúc: " & BAT_DAU.ToShortTimeString & vbCrLf
        Kq &= "Kết thúc lúc: " & KET_THUC.ToShortTimeString & vbCrLf
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
End Class
