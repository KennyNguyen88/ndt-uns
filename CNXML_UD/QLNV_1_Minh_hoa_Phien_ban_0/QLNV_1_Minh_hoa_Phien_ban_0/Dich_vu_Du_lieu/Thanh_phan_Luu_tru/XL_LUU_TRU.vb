Imports System.IO
Imports System.Data.OleDb
Imports System.Web.Hosting
Public Enum CONG_NGHE_LUU_TRU
    Xml
    Access_2000_2003
    Access_2013
    SQLServer_MDF
    SQLServer
    MySql
    Sqlite
End Enum


Public Class XL_LUU_TRU

#Region "Biến/Đối tượng toàn cục"
    Protected Thu_muc_Project As New DirectoryInfo(HostingEnvironment.ApplicationPhysicalPath)
    Protected Thu_muc_Solution As DirectoryInfo = Thu_muc_Project.Parent

    Protected Thu_muc_Du_lieu As String = Thu_muc_Solution.FullName & "\Du_lieu"
    Protected Thu_muc_CSDL As String = Thu_muc_Du_lieu & "\CSDL"

    Protected Thu_muc_Media As String = Thu_muc_Du_lieu & "\Media"
    Protected Thu_muc_Hinh As String = Thu_muc_Media & "\Hinh"
    Protected Thu_muc_Tai_lieu As String = Thu_muc_Media & "\Tai_lieu"
    Protected Thu_muc_Am_Thanh As String = Thu_muc_Media & "\Am_thanh"
    Protected Thu_muc_Phim As String = Thu_muc_Media & "\Phim"

    Protected Ten_Ung_dung As String = "QLNV_1"
    Protected Ten_CSDL As String


    Protected Duong_dan_Tap_tin_Xml As String
    Protected Chuoi_ket_noi_Access As String
    Protected Chuoi_ket_noi_SQLServer_MDF As String
    Protected Chuoi_ket_noi_SQLServer As String
    ' .... Các chuỗi kết nối khác 
    Protected Cong_Nghe As CONG_NGHE_LUU_TRU
#End Region

#Region "Khởi động"
    Public Sub New(Optional Loai As CONG_NGHE_LUU_TRU = CONG_NGHE_LUU_TRU.Access_2000_2003,
                   Optional Phien_ban_CSDL As String = "Cach_1")
        Ten_CSDL = Ten_Ung_dung & "_" & Phien_ban_CSDL
        Cong_Nghe = Loai
        If Cong_Nghe = CONG_NGHE_LUU_TRU.Access_2000_2003 Then
            Dim Duong_dan_Tap_tin_Access As String = Thu_muc_CSDL & "\" & Ten_CSDL & ".mdb"
            Chuoi_ket_noi_Access = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & Duong_dan_Tap_tin_Access
            ''  Thông báo PET : hay có thể sử dụng
            ''  Chuoi_ket_noi_Access = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & Duong_dan_Tap_tin_Access
            ''   === > Thực hiện tốt hơn !!!
            ''  Các anh chị có thể download Driver thư viện tại địa chỉ
            '' https://www.microsoft.com/en-us/download/details.aspx?id=13255
        ElseIf Loai = CONG_NGHE_LUU_TRU.Xml Then
            Duong_dan_Tap_tin_Xml = Thu_muc_CSDL & "\" & Ten_CSDL & ".xml"
        ElseIf Loai = CONG_NGHE_LUU_TRU.SQLServer_MDF Then
            '......
        ElseIf Loai = CONG_NGHE_LUU_TRU.SQLServer Then
            '....
        End If

    End Sub
#End Region

#Region "Đọc  "
    Public Function Doc_Du_lieu() As DataSet
        Dim Kq As New DataSet
        Dim Dong_ho As New PET_Dong_ho_Ho_tro_thuc_hanh.XL_DONG_HO
        If Cong_Nghe = CONG_NGHE_LUU_TRU.Xml Then
            Kq.ReadXml(Duong_dan_Tap_tin_Xml, XmlReadMode.ReadSchema)
        Else
            Doc_Bang("CONG_TY", "", Kq)
            Doc_Bang("DON_VI", "", Kq)
            Doc_Bang("NHAN_VIEN", "", Kq)
            Doc_Bang("CHI_NHANH", "", Kq)
            Doc_Bang("GIOI_TINH", "", Kq)
            Doc_Bang("QLCT", "", Kq)
            Doc_Bang("QLCN", "", Kq)
        End If

        Kq.DataSetName = Ten_CSDL
        Kq.ExtendedProperties("Nguon_Du_lieu") = Cong_Nghe.ToString
        Kq.ExtendedProperties("Thoi_gian_Doc_Du_lieu") = Dong_ho.Tao_Chuoi_Thoi_gian_do("")
        Kq.ExtendedProperties("Kich_thuoc_Du_lieu") = Kq.GetXml.Count & " Bytes"
        Kq.ExtendedProperties("So_Nhan_vien") = Kq.Tables("NHAN_VIEN").Rows.Count


        Return Kq
    End Function


    Public Function Doc_Bang(Ten_bang As String, Optional Dieu_kien As String = "",
                                     Optional Du_lieu As DataSet = Nothing) As DataTable
        Dim Kq As New DataTable
        If Cong_Nghe = CONG_NGHE_LUU_TRU.Access_2000_2003 Then
            Kq = Doc_Bang_Access(Ten_bang, Dieu_kien, Du_lieu)
        End If
        Return Kq
    End Function





#End Region

#Region "Ghi  "
    Public Function Ghi_bang(Bang As DataTable) As String
        Dim Kq As String = ""
        If Cong_Nghe = CONG_NGHE_LUU_TRU.Access_2000_2003 Then
            Kq = Ghi_Bang_Access(Bang)
        ElseIf Cong_Nghe = CONG_NGHE_LUU_TRU.Xml Then
            Kq = Ghi_Bang_Xml(Bang)
        End If
        Return Kq
    End Function
    Public Function Ghi_moi(Dong As DataRow) As String
        Dim Kq As String = ""
        Dim Bang As DataTable = Dong.Table
        Bang.Rows.Add(Dong)
        Kq = Ghi_bang(Bang)
        Return Kq
    End Function
    Public Function Cap_nhat(Dong As DataRow) As String
        Dim Kq As String = ""
        Dim Bang As DataTable = Dong.Table
        Kq = Ghi_bang(Bang)
        Return Kq
    End Function
    Public Function Xoa(Dong As DataRow) As String
        Dim Kq As String = ""
        Dim Bang As DataTable = Dong.Table
        If Cong_Nghe = CONG_NGHE_LUU_TRU.Xml Then
            Bang.Rows.Remove(Dong)
        Else
            Dong.Delete()
        End If

        Kq = Ghi_bang(Bang)
        Return Kq
    End Function
#End Region

#Region "Đọc ghi - Media "

    Public Function Doc_Nhi_phan_Hinh(Ma_so As String) As Byte()
        Dim Kq As Byte()
        Dim Duong_dan As String = Thu_muc_Hinh & "\" & Ma_so & ".png"
        Try
            Kq = File.ReadAllBytes(Duong_dan)
        Catch ex As Exception
            Kq = New Byte() {}
        End Try

        Return Kq
    End Function

    Public Function Ghi_Nhi_phan_Hinh(Ma_so As String, Nhi_phan As Byte()) As String
        Dim Kq As String = ""
        Dim Duong_dan As String = Thu_muc_Hinh & "\" & Ma_so & ".png"
        Try
            File.WriteAllBytes(Duong_dan, Nhi_phan)
        Catch ex As Exception
            Kq = ex.Message
        End Try
        Return Kq
    End Function
    Public Function Doc_Chuoi_Hinh_64(Ma_so As String) As String
        Dim Kq As String
        Dim Nhi_phan As Byte() = Doc_Nhi_phan_Hinh(Ma_so)
        If Nhi_phan.Count > 0 Then
            Kq = Convert.ToBase64String(Nhi_phan)
        End If
        Return Kq
    End Function

    Public Function Ghi_Chuoi_Hinh_64(Ma_so As String, Chuoi_Hinh_64 As String) As String
        Dim Kq As String = ""
        Dim Nhi_phan As Byte() = Convert.FromBase64String(Chuoi_Hinh_64)
        Kq = Ghi_Nhi_phan_Hinh(Ma_so, Nhi_phan)
        Return Kq
    End Function

#End Region

#Region "Đọc ghi Access"
    Protected Function Doc_Bang_Access(Ten_bang As String, Optional Dieu_kien As String = "",
                                  Optional Du_lieu As DataSet = Nothing) As DataTable
        Dim Kq As New DataTable(Ten_bang)
        Dim Chuoi_lenh As String = "Select * From " & Ten_bang
        If Dieu_kien <> "" Then
            Chuoi_lenh &= " Where " & Dieu_kien
        End If
        Try
            Dim Bo_thich_ung As New OleDbDataAdapter(Chuoi_lenh, Chuoi_ket_noi_Access)
            Bo_thich_ung.FillSchema(Kq, SchemaType.Source)
            Bo_thich_ung.Fill(Kq)
            If Du_lieu IsNot Nothing Then
                Du_lieu.Tables.Add(Kq)
            End If
            Kq.Columns(0).ReadOnly = False
            For Each Cot As DataColumn In Kq.Columns
                Cot.ColumnMapping = MappingType.Attribute
            Next
        Catch Loi As Exception
            Du_lieu.ExtendedProperties("Chuoi_loi") = "Lỗi đọc CSDL" & vbCrLf & Loi.Message & ":" & Chuoi_lenh & ":" & Chuoi_ket_noi_Access
        End Try
        Return Kq
    End Function


    Protected Function Ghi_Bang_Access(Bang As DataTable) As String
        Dim Kq As String = ""
        Dim Ten_bang As String = Bang.TableName
        Dim Chuoi_lenh As String = "Select  * From " & Ten_bang
        Try
            Dim Bo_thich_ung As New OleDbDataAdapter(Chuoi_lenh, Chuoi_ket_noi_Access)
            Dim Phat_sinh_lenh As New OleDbCommandBuilder(Bo_thich_ung)
            AddHandler Bo_thich_ung.RowUpdated, AddressOf Cap_nhat_ID_Access
            Bo_thich_ung.Update(Bang)
        Catch ex As Exception
            Kq = ex.Message

        End Try
        Return Kq
    End Function
    Protected Sub Cap_nhat_ID_Access(ByVal Dt As Object, ByVal Bc As OleDbRowUpdatedEventArgs)
        ' Ket_noi = Kết nối đang sử dụng 
        Dim Ket_noi As OleDbConnection = Bc.Command.Connection
        ' Kiểm tra là lệnh thêm mới 
        If Bc.StatementType = StatementType.Insert Then
            ' Lenh = Lệnh đọc mã số phát sinh tự động 
            Dim Lenh As New OleDbCommand("Select @@IDENTITY", Ket_noi)
            ' ID = Kết quả thực hiện Lenh 
            Dim ID As Integer = Lenh.ExecuteScalar()
            ' Gán ID vào cột đầu tiên của dòng vừa thêm vào 
            Bc.Row(0) = ID
        End If

    End Sub
#End Region

#Region "Đọc ghi Xml"

    Protected Function Ghi_Bang_Xml(Bang As DataTable) As String
        Dim Kq As String = ""
        Dim Du_lieu As DataSet = Bang.DataSet
        Du_lieu.WriteXml(Duong_dan_Tap_tin_Xml, XmlWriteMode.WriteSchema)
        Return Kq
    End Function
#End Region
End Class


