Partial Public Class XL_NGHIEP_VU
#Region "Biến/Đối tượng toàn cục"
    Protected Shared Dich_vu As New DV_ASMX_Thu_nghiem.XL_DICH_VU_ASMXSoapClient
#End Region

#Region "Xử lý Nghiệp vụ "
    '==== Đăng nhập
    Public Function Dang_nhap_QLCN(Ten_Dang_nhap As String, Mat_khau As String) As DataSet
        Dim Kq As New DataSet
        Try
            Kq = Dich_vu.Dang_nhap_QLCN(Ten_Dang_nhap, Mat_khau)
        Catch ex As Exception
            Kq = New DataSet
        End Try
        Return Kq
    End Function


#End Region

End Class
