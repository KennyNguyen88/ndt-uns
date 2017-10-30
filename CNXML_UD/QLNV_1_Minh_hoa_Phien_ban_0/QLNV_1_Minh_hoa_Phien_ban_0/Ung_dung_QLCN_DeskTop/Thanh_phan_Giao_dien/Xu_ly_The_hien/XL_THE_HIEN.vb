Partial Public Class XL_THE_HIEN
#Region "Nhập - Xuất Chuỗi"
    Public Sub Xuat_Chuoi(Chuoi As String, Th_Chuoi As Control,
                          Optional XL_Bien_co_Nhap_Chuoi As KeyEventHandler = Nothing)
        Th_Chuoi.Text = Chuoi
        If XL_Bien_co_Nhap_Chuoi IsNot Nothing Then
            AddHandler Th_Chuoi.KeyDown, XL_Bien_co_Nhap_Chuoi
        End If
    End Sub
    Public Function Nhap_Chuoi(Th_Chuoi As TextBox) As String
        Dim Chuoi As String = Th_Chuoi.Text.Trim
        Return Chuoi
    End Function
#End Region
End Class
