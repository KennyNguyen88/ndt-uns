Partial Public Class XL_NGHIEP_VU

    Public Function Xoa_Nhan_vien(Du_lieu As DataSet, Nhan_vien As DataRow) As String
        Dim Kq As String = ""
        If Kq = "" Then
            Dim Du_lieu_He_khach As New DataSet
            Dim Bang_He_khach As DataTable = Nhan_vien.Table.Clone
            Du_lieu_He_khach.Tables.Add(Bang_He_khach)
            Dim Nhan_vien_He_khach As DataRow = Bang_He_khach.NewRow
            Bang_He_khach.Rows.Add(Nhan_vien_He_khach)
            For Each Thuoc_tinh As DataColumn In Bang_He_khach.Columns
                Dim Ten As String = Thuoc_tinh.ColumnName
                Nhan_vien_He_khach(Ten) = Nhan_vien(Ten)
            Next
            Kq = Dich_vu.Xoa_Nhan_vien(Du_lieu_He_khach)
            If Kq = "" Then
                Nhan_vien.Table.Rows.Remove(Nhan_vien)
            End If
        End If
        Return Kq
    End Function

End Class
