
Public Class XL_CONG_TY

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
    Public Property Dien_thoai As String
        Get
            Return Dong("Dien_thoai")
        End Get
        Set(value As String)
            Dong("Dien_thoai") = value
        End Set
    End Property
    Public Property Dia_chi As String
        Get
            Return Dong("Dia_chi")
        End Get
        Set(value As String)
            Dong("Dia_chi") = value
        End Set
    End Property
    Public Property Tuoi_toi_thieu As Integer
        Get
            Return Dong("Tuoi_toi_thieu")
        End Get
        Set(value As Integer)
            Dong("Tuoi_toi_thieu") = value
        End Set
    End Property
    Public Property Tuoi_toi_da As Integer
        Get
            Return Dong("Tuoi_toi_da")
        End Get
        Set(value As Integer)
            Dong("Tuoi_toi_da") = value
        End Set
    End Property
    Public Property Muc_luong_toi_thieu As Integer
        Get
            Return Dong("Muc_luong_toi_thieu")
        End Get
        Set(value As Integer)
            Dong("Muc_luong_toi_thieu") = value
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

        Kq &= "Tên : " & Ten & vbCrLf
        Kq &= "Điện thoại : " & Dien_thoai & vbCrLf
        Kq &= "Địa chỉ : " & Dia_chi & vbCrLf
        Kq &= "Tuoi_toi_thieu : " & Tuoi_toi_thieu & vbCrLf
        Kq &= "Tuoi_toi_da : " & Tuoi_toi_da & vbCrLf
        Kq &= "Muc_luong_toi_thieu : " & Muc_luong_toi_thieu & vbCrLf

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
