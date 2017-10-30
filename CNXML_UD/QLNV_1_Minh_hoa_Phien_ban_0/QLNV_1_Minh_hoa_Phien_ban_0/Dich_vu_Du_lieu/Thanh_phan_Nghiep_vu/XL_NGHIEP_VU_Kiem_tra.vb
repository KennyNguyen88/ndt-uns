Partial Public Class XL_NGHIEP_VU


#Region "Xử lý Kiểm tra "
#Region "NHAN_VIEN(ID,Ho_ten,CMND,Ngay_sinh,Muc_luong,Dien_thoai,Mail,Dia_chi,ID_GIOI_TINH,ID_DON_VI)"
    '==== Kiểm tra
    ' Họ tên ,CMND, Điển thoại, Mail, Dịa chỉ: Khác trống
    ' CMND phải duy nhất
    ' Ngày sinh và mức lương theo qui định 
    Public Function Kiem_tra_Ghi_moi_Nhan_vien(Du_lieu As DataSet,
                                           Nhan_vien_He_khach As DataRow) As String
        Dim Kq As String = ""

        Dim Cong_ty As DataRow = Danh_sach_Cong_ty(Du_lieu)(0)
        Dim Hop_le As Boolean
        '=== Kiểm tra Họ tên ====
        Hop_le = Nhan_vien_He_khach("Ho_ten") <> ""
        If Not Hop_le Then
            Kq &= "Họ tên phải khác trống" & vbCrLf
        End If
        '=== Kiểm tra CMND ==== 
        Hop_le = Nhan_vien_He_khach("CMND") <> "" AndAlso Danh_sach_Nhan_vien(Du_lieu).FindAll(
                Function(x) x("CMND") = Nhan_vien_He_khach("CMND")).Count = 0
        If Not Hop_le Then
            Kq &= "CMND phải khác trống và duy nhất" & vbCrLf
        End If
        '=== Kiểm tra Mức lương ====
        Hop_le = Nhan_vien_He_khach("Muc_luong") >= Cong_ty("Muc_luong_toi_thieu")
        If Not Hop_le Then
            Kq &= "Mức lương  là số nguyên >=" & Cong_ty("Muc_luong_toi_thieu") & vbCrLf
        End If
        '=== Kiểm tra Ngày sinh ====
        Dim Ngay_sinh As DateTime = Nhan_vien_He_khach("Ngay_sinh")
        Dim Tuoi As Integer = Today.Year - Ngay_sinh.Year
        Hop_le = Tuoi >= Cong_ty("Tuoi_Toi_thieu") And Tuoi <= Cong_ty("Tuoi_Toi_da")
        If Not Hop_le Then
            Kq &= "Tuổi nhân viên từ " & Cong_ty("Tuoi_Toi_thieu") & " đến " & Cong_ty("Tuoi_Toi_da") & vbCrLf
        End If
        '=== Kiểm tra điện thoại====
        Hop_le = Nhan_vien_He_khach("Dien_thoai") <> ""
        If Not Hop_le Then
            Kq &= "Điện thoại phải khác trống" & vbCrLf
        End If
        '=== Kiểm tra Mail ====
        Hop_le = Nhan_vien_He_khach("Mail") <> ""
        If Not Hop_le Then
            Kq &= "Mail phải khác trống" & vbCrLf
        End If
        '=== Kiểm tra Địa chỉ ====
        Hop_le = Nhan_vien_He_khach("Dia_chi") <> ""
        If Not Hop_le Then
            Kq &= "Địa chỉ phải khác trống" & vbCrLf
        End If
        Return Kq
    End Function

    Public Function Kiem_tra_Cap_nhat_Nhan_vien(Du_lieu As DataSet,
                                                Nhan_vien_He_khach As DataRow) As String
        Dim Kq As String = Kiem_tra_Ghi_moi_Nhan_vien(Du_lieu, Nhan_vien_He_khach)


        Return Kq
    End Function
    Public Function Kiem_tra_Xoa_Nhan_vien(Du_lieu As DataSet,
                                                Nhan_vien_He_khach As DataRow) As String
        Dim Kq As String = ""


        Return Kq
    End Function
#End Region
#End Region


End Class
