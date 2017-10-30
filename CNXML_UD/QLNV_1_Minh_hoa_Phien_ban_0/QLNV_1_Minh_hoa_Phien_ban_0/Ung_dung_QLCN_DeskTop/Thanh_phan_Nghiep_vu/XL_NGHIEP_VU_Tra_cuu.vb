Partial Public Class XL_NGHIEP_VU
    Public Function Tra_cuu_Nhan_vien_theo_Don_vi(Du_lieu As DataSet, Don_vi As DataRow) As DataTable
        Dim Kq As New DataTable
        Dim Ds As List(Of DataRow) = Trich_rut_Danh_sach_Nhan_vien_theo_ID_DON_VI(Du_lieu, Don_vi("ID"))
        If Ds.Count > 0 Then
            Kq = Ds.CopyToDataTable()
            Kq.TableName = "NHAN_VIEN"
            Kq.Columns.Add("Tuoi")
            Kq.Columns.Add("Ten_Don_vi")
            Kq.Columns.Add("Ten_Chi_nhanh")
            For Each Nhan_vien As DataRow In Kq.Rows
                Dim Ngay_sinh As DateTime = Nhan_vien("Ngay_sinh")
                Dim Chi_nhanh As DataRow = Trich_rut_Chi_nhanh_theo_ID(Du_lieu, Don_vi("ID_CHI_NHANH"))
                Nhan_vien("Tuoi") = Today.Year - Ngay_sinh.Year
                Nhan_vien("Ten_Don_vi") = Don_vi("Ten")
                Nhan_vien("Ten_Chi_nhanh") = Chi_nhanh("Ten")
            Next
        End If
        Return Kq
    End Function
    Public Function Tra_cuu_Nhan_vien_theo_Ho_ten(Du_lieu As DataSet, Chuoi_Ho_ten As String) As DataTable
        Dim Kq As New DataTable
        Dim Ds As List(Of DataRow) = Trich_rut_Danh_sach_Nhan_vien_theo_Ho_ten(Du_lieu, Chuoi_Ho_ten)
        If Ds.Count > 0 Then
            Kq.TableName = "NHAN_VIEN"
            Kq = Ds.CopyToDataTable()
            Kq.Columns.Add("Tuoi")
            Kq.Columns.Add("Ten_Don_vi")
            Kq.Columns.Add("Ten_Chi_nhanh")
            For Each Nhan_vien As DataRow In Kq.Rows
                Dim Ngay_sinh As DateTime = Nhan_vien("Ngay_sinh")
                Dim Don_vi As DataRow = Trich_rut_Don_vi_theo_ID(Du_lieu, Nhan_vien("ID_DON_VI"))
                Dim Chi_nhanh As DataRow = Trich_rut_Chi_nhanh_theo_ID(Du_lieu, Don_vi("ID_CHI_NHANH"))
                Nhan_vien("Tuoi") = Today.Year - Ngay_sinh.Year
                Nhan_vien("Ten_Don_vi") = Don_vi("Ten")
                Nhan_vien("Ten_Chi_nhanh") = Chi_nhanh("Ten")
            Next
        End If
        Return Kq
    End Function
    Public Function Tra_cuu_Nhan_vien_theo_Muc_luong(Du_lieu As DataSet, Can_duoi As Double, Can_tren As Double) As DataTable
        Dim Kq As New DataTable
        Dim Ds As List(Of DataRow) = Trich_rut_Danh_sach_Nhan_vien_theo_Muc_luong(Du_lieu, Can_duoi, Can_tren)
        If Ds.Count > 0 Then
            Kq = Ds.CopyToDataTable()
            Kq.TableName = "NHAN_VIEN"
            Kq.Columns.Add("Tuoi")
            Kq.Columns.Add("Ten_Don_vi")
            Kq.Columns.Add("Ten_Chi_nhanh")
            For Each Nhan_vien As DataRow In Kq.Rows
                Dim Ngay_sinh As DateTime = Nhan_vien("Ngay_sinh")
                Dim Don_vi As DataRow = Trich_rut_Don_vi_theo_ID(Du_lieu, Nhan_vien("ID_DON_VI"))
                Dim Chi_nhanh As DataRow = Trich_rut_Chi_nhanh_theo_ID(Du_lieu, Don_vi("ID_CHI_NHANH"))
                Nhan_vien("Tuoi") = Today.Year - Ngay_sinh.Year
                Nhan_vien("Ten_Don_vi") = Don_vi("Ten")
                Nhan_vien("Ten_Chi_nhanh") = Chi_nhanh("Ten")
            Next
        End If
        Return Kq
    End Function

End Class
