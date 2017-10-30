Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel


' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")>
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<ToolboxItem(False)>
Public Class XL_DICH_VU_ASMX
    Inherits System.Web.Services.WebService
    Dim Thu_muc_Project As New IO.DirectoryInfo(Hosting.HostingEnvironment.ApplicationPhysicalPath)
    Dim Thu_muc_Solution As IO.DirectoryInfo = Thu_muc_Project.Parent
    Dim Thu_muc_Du_lieu As IO.DirectoryInfo = Thu_muc_Solution.GetDirectories("Du_lieu")(0)
    Dim Thu_muc_CSDL As IO.DirectoryInfo = Thu_muc_Du_lieu.GetDirectories("CSDL")(0)
    Dim Ten_Phan_mem As String = "Hoang_Hon_Som"
    Dim Phien_ban As String = "Ren_luyen_Ky_nang"

    Dim Ten_CSDL As String = Ten_Phan_mem & "_" & Phien_ban
    Dim Duong_dan_Tap_tin_CSDL As String = Thu_muc_CSDL.FullName & "\" & Ten_CSDL & ".xml"
    <WebMethod()>
    Public Function Doc_Du_lieu() As DataSet
        '=== Lưu ý PET : Đây chỉ là hàm tạm thời trước khi học về Xử lý Dịch vụ
        Dim Kq As New DataSet
        Kq.ReadXml(Duong_dan_Tap_tin_CSDL, XmlReadMode.ReadSchema)
        Kq.DataSetName = Ten_CSDL
        Return Kq
    End Function

End Class