Public Class XL_LOAI_PHONG
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
    Public Property So_Ghe As Integer
        Get
            Return Dong("So_Ghe")
        End Get
        Set(value As Integer)
            Dong("So_Ghe") = value
        End Set
    End Property
    Public Property So_Day As Integer
        Get
            Return Dong("So_Day")
        End Get
        Set(value As Integer)
            Dong("So_Day") = value
        End Set
    End Property

#End Region
#Region "Thuộc tính tính toán "
#End Region
#Region "Trích rút Đối tượng liên kết"
    '====== Liên kết thuận ========    
    '====== Liên kết nghịch ========    
    Public ReadOnly Property Danh_sach_Phong As List(Of XL_PHONG)
        Get
            Dim Kq As New List(Of XL_PHONG)
            Kq = Ung_dung.Danh_sach_Phong.FindAll(Function(x) x.ID_LOAI_PHONG = ID)
            Return Kq
        End Get
    End Property
#End Region

#Region "Kiểm tra"
    Public Function Kiem_Tra_Ghi_Moi() As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean
        '===Tên Loại Phòng khác trống
        Hop_le = Not "".Equals(Ten)
        If Not Hop_le Then
            Kq = "Tên Loại Phòng không được rỗng" & vbCrLf
        End If
        Return Kq
    End Function
    Public Function Kiem_Tra_Xoa() As String
        Dim kq As String = ""
        Dim Hop_le As Boolean
        '===Có phòng tham chiếu tới loại phòng ?
        If (Danh_sach_Phong.Count > 0) Then
            'Có
            Hop_le = False
            kq = "Có phòng tham chiếu đến. Vui lòng hủy (các) phòng trước khi tiến hành xóa !"
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
