Public Class XL_HE_KHACH
    Public Shared Sub Main()
        Dim He_khach As New XL_HE_KHACH
    End Sub
    Protected Sub New()

        Dim Dich_vu As New DV_ASMX_Thu_nghiem.XL_DICH_VU_ASMXSoapClient
        Dim Du_lieu As DataSet = Dich_vu.Doc_Du_lieu
        Dim Mh As New MH_Minh_hoa
        Mh.Xu_ly(Du_lieu)
    End Sub
End Class
