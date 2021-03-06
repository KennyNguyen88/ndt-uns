
Public Class XL_DON_VI

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
    Public Property ID_CHI_NHANH As Integer
        Get
            Return Dong("ID_CHI_NHANH")
        End Get
        Set(value As Integer)
            Dong("ID_CHI_NHANH") = value
        End Set
    End Property
#End Region
#Region "Thuộc tính tính toán "
#End Region

#Region "Trích rút Đối tượng liên kết"
    '====== Liên kết thuận ========

    Public ReadOnly Property Chi_nhanh As XL_CHI_NHANH
        Get
            Dim Kq As XL_CHI_NHANH = Nothing
            Kq = Ung_dung.Danh_sach_Chi_nhanh.FirstOrDefault(Function(x) x.ID = ID_CHI_NHANH)
            Return Kq
        End Get
    End Property

    '====== Liên kết nghịch ========

    Public ReadOnly Property Danh_sach_Nhan_vien As List(Of XL_NHAN_VIEN)
        Get
            Dim Kq As New List(Of XL_NHAN_VIEN)
            Kq = Ung_dung.Danh_sach_Nhan_vien.FindAll(Function(x) x.ID_DON_VI = ID)
            Return Kq
        End Get
    End Property



    Public ReadOnly Property Danh_sach_Gioi_tinh As List(Of XL_GIOI_TINH)
        Get
            Dim Kq As New List(Of XL_GIOI_TINH)
            For Each Nhan_vien As XL_NHAN_VIEN In Danh_sach_Nhan_vien
                Dim Gioi_tinh As XL_GIOI_TINH = Nhan_vien.Gioi_tinh
                If Not Kq.Contains(Gioi_tinh) Then
                    Kq.Add(Gioi_tinh)
                End If
            Next
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

        Kq &= "Tên : " & Ten & vbCrLf
        Kq &= "Chi nhánh : " & Chi_nhanh().Tao_Chuoi_Tom_tat() & vbCrLf

        Return Kq
    End Function

    '====== Nhập liệu ======
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Ghi_moi() As String
        Dim Kq As String = ""
        '====== Tự thực hiện =====
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Cap_nhat() As String
        Dim Kq As String = ""
        '====== Tự thực hiện =====
        Return Kq
    End Function
    Public Function Tao_Chuoi_Thong_bao_Luu_y_Xoa() As String
        Dim Kq As String = ""
        '====== Tự thực hiện =====
        Return Kq
    End Function
#End Region
#Region "Kiểm tra "
    Public Function Kiem_tra_Ghi_moi() As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean = True
        '====== Tự thực hiện =====
        Return Kq
    End Function
    Public Function Kiem_tra_Cap_nhat() As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean = True
        '====== Tự thực hiện =====
        Return Kq
    End Function
    Public Function Kiem_tra_Xoa() As String
        Dim Kq As String = ""
        Dim Hop_le As Boolean = True
        '====== Tự thực hiện =====
        Return Kq
    End Function
#End Region

End Class
