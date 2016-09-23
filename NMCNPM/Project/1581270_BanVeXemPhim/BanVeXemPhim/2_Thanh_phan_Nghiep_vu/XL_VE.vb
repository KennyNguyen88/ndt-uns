Public Class XL_VE
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
    Public Property ID_GHE As Integer
        Get
            Return Dong("ID_GHE")
        End Get
        Set(value As Integer)
            Dong("ID_GHE") = value
        End Set
    End Property
    Public Property ID_XUAT_CHIEU As Integer
        Get
            Return Dong("ID_XUAT_CHIEU")
        End Get
        Set(value As Integer)
            Dong("ID_XUAT_CHIEU") = value
        End Set
    End Property
    Public Property TRANG_THAI As String
        Get
            Return Dong("TRANG_THAI")
        End Get
        Set(value As String)
            Dong("TRANG_THAI") = value
        End Set
    End Property

#End Region
#Region "Thuộc tính tính toán "
#End Region
#Region "Trích rút Đối tượng liên kết"
    '====== Liên kết thuận ========   
    Public ReadOnly Property Ghe As XL_GHE
        Get
            Dim Kq As XL_GHE = Nothing
            Kq = Ung_dung.Danh_sach_Ghe.FirstOrDefault(Function(x) x.ID = ID_GHE)
            Return Kq
        End Get
    End Property

    Public ReadOnly Property Xuat_Chieu As XL_XUAT_CHIEU
        Get
            Dim Kq As XL_XUAT_CHIEU = Nothing
            Kq = Ung_dung.Danh_sach_Xuat_Chieu.FirstOrDefault(Function(x) x.ID = ID_XUAT_CHIEU)
            Return Kq
        End Get
    End Property
    '====== Liên kết nghịch ========
#End Region
#Region "Tạo Chuỗi"
    '======  Xem Thông tin =====
    Public Function Tao_Chuoi_Tom_tat() As String
        Dim Kq As String = ""
        Kq &= "Tên Phim : " & Xuat_Chieu.Phim.Ten & vbCrLf
        Kq &= "Tên Ca : " & Xuat_Chieu.Ca_Chieu.Ten & vbCrLf
        Kq &= "Tên Phòng : " & Xuat_Chieu.Phong.Ten & vbCrLf
        Kq &= "Tên Ghế : " & Ghe.Ten & vbCrLf
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_tin(Optional Co_ID As Boolean = False) As String
        Dim Kq As String = ""
        If Co_ID Then
            Kq &= "ID :" & ID & vbCrLf  '=== Chỉ phục vụ thử nghiệm
        End If
        Kq &= "Tên Phim : " & Xuat_Chieu.Phim.Ten & vbCrLf
        Kq &= "Ngày Chiếu : " & Xuat_Chieu.Ngay.ToShortDateString & vbCrLf
        Kq &= "Bắt đầu lúc: " & Xuat_Chieu.Ca_Chieu.BAT_DAU.ToShortTimeString & vbCrLf
        Kq &= "Kết thúc lúc: " & Xuat_Chieu.Ca_Chieu.KET_THUC.ToShortTimeString & vbCrLf
        Kq &= "Tên Phòng : " & Xuat_Chieu.Phong.Ten & vbCrLf
        Kq &= "Loại Phòng : " & Xuat_Chieu.Phong.Loai_Phong.Ten & vbCrLf
        Kq &= "Tên Ghế : " & Ghe.Ten & vbCrLf
        Kq &= "Hàng số : " & Ghe.x & vbCrLf
        Kq &= "Dãy số: " & Ghe.y & vbCrLf
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
        '[Ghe, Xuat Chieu] duy nhất
        Dim existedVe As List(Of XL_VE)
        existedVe = Ung_dung.Danh_Sach_Ve_Ghe_Suat_Chieu(ID_GHE, ID_XUAT_CHIEU)
        If existedVe.Count > 0 Then
            Hop_le = False
            Kq = "Vé đã tồn tại" & vbCrLf
        Else
            Hop_le = True
        End If
        Return Kq
    End Function
    Public Function Kiem_Tra_Xoa() As String
        Dim kq As String = ""
        Dim Hop_le As Boolean
        '===Vé đã bán không được xóa ?
        If TRANG_THAI.ToUpper.Equals("YES") Then
            Hop_le = False
            kq = "Vé đã bán, không được xóa !"
        Else
            Hop_le = True
        End If
        Return kq
    End Function
    Public Function Kiem_Tra_Sua() As String
        Dim kq As String = ""
        Return kq
    End Function
#End Region
End Class
