Public Class XL_XUAT_CHIEU
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
    Public Property ID_PHONG As Integer
        Get
            Return Dong("ID_PHONG")
        End Get
        Set(value As Integer)
            Dong("ID_PHONG") = value
        End Set
    End Property
    Public Property ID_PHIM As Integer
        Get
            Return Dong("ID_PHIM")
        End Get
        Set(value As Integer)
            Dong("ID_PHIM") = value
        End Set
    End Property
    Public Property ID_CA_CHIEU As Integer
        Get
            Return Dong("ID_CA_CHIEU")
        End Get
        Set(value As Integer)
            Dong("ID_CA_CHIEU") = value
        End Set
    End Property
    Public Property Ngay As DateTime
        Get
            Return Dong("ID_PHIM")
        End Get
        Set(value As DateTime)
            Dong("Ngay") = value
        End Set
    End Property
#End Region
#Region "Thuộc tính tính toán "
#End Region
#Region "Trích rút Đối tượng liên kết"
    '====== Liên kết thuận ========
    Public ReadOnly Property Phong As XL_PHONG
        Get
            Dim Kq As XL_PHONG = Nothing
            Kq = Ung_dung.Danh_sach_Phong.FirstOrDefault(Function(x) x.ID = ID_PHONG)
            Return Kq
        End Get
    End Property

    Public ReadOnly Property Phim As XL_PHIM
        Get
            Dim Kq As XL_PHIM = Nothing
            Kq = Ung_dung.Danh_sach_Phim.FirstOrDefault(Function(x) x.ID = ID_PHIM)
            Return Kq
        End Get
    End Property

    Public ReadOnly Property Ca_Chieu As XL_CA_CHIEU
        Get
            Dim Kq As XL_CA_CHIEU = Nothing
            Kq = Ung_dung.Danh_sach_Ca_Chieu.FirstOrDefault(Function(x) x.ID = ID_CA_CHIEU)
            Return Kq
        End Get
    End Property
    '====== Liên kết nghịch ========    
    Public ReadOnly Property Danh_sach_Ve As List(Of XL_VE)
        Get
            Dim Kq As New List(Of XL_VE)
            Kq = Ung_dung.Danh_sach_Ve.FindAll(Function(x) x.ID_XUAT_CHIEU = ID)
            Return Kq
        End Get
    End Property
#End Region
#Region "Tạo Chuỗi"
    '======  Xem Thông tin =====
    Public Function Tao_Chuoi_Tom_tat() As String
        Dim Kq As String = ""
        Kq &= "Phim : " & Phim.Ten & vbCrLf
        Kq &= "Ngày chiếu: " & Ngay.ToShortDateString & vbCrLf
        Kq &= "Phòng : " & Phong.Ten & vbCrLf
        Kq &= "Ca Chiếu: " & Ca_Chieu.Ten & vbCrLf
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_tin(Optional Co_ID As Boolean = False) As String
        Dim Kq As String = ""
        If Co_ID Then
            Kq &= "ID :" & ID & vbCrLf  '=== Chỉ phục vụ thử nghiệm
        End If
        Kq &= "Phim : " & Phim.Ten & vbCrLf
        Kq &= "Phòng : " & Phong.Ten & vbCrLf
        Kq &= "Loại Phòng : " & Phong.Loai_Phong.Ten & vbCrLf
        Kq &= "Ngày chiếu: " & Ngay.ToShortDateString & vbCrLf
        Kq &= "Bắt đầu lúc: " & Ca_Chieu.BAT_DAU.ToShortTimeString & vbCrLf
        Kq &= "Kết thúc lúc: " & Ca_Chieu.KET_THUC.ToShortTimeString & vbCrLf
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
