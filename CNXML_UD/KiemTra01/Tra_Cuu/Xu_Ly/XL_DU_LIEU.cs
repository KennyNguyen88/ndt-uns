using System.Web;
using System.IO;
using System.Net;
using System.Xml;
using System.Xml.Xsl;
public class XL_DU_LIEU
{
    static string Dia_chi_Dich_vu = "http://localhost:57926/XL_DICH_VU_XML.cshtml";
    static DirectoryInfo Thu_muc_Project = new DirectoryInfo(HttpContext.Current.Server.MapPath("/"));
    static DirectoryInfo Thu_muc_XSLT = Thu_muc_Project.GetDirectories("Xu_Ly")[0];

    public XmlElement Danh_Sach_Thi_Sinh;
    public static XL_DU_LIEU Khoi_dong_Du_lieu() 
    {
        var Du_lieu = new XL_DU_LIEU();
        var Dia_chi = Dia_chi_Dich_vu + "?Ma_so_Xu_ly=DOC_CHUOI_DANH_SACH"
                                + "&Loai_Doi_tuong=THI_SINH";
        var Dich_vu = new WebClient();
        Dich_vu.Encoding = System.Text.Encoding.UTF8;
        var Chuoi_XML_Danh_Sach_Thi_Sinh = Dich_vu.UploadString(Dia_chi, "");
        var Tai_lieu_Thi_Sinh = new XmlDocument();
        Tai_lieu_Thi_Sinh.LoadXml(Chuoi_XML_Danh_Sach_Thi_Sinh);
        Du_lieu.Danh_Sach_Thi_Sinh = Tai_lieu_Thi_Sinh.DocumentElement;

        return Du_lieu;

    }
   
    // Xử lý Tra cứu 
    public XmlElement Tim_Thi_Sinh_Theo_SBD(string SBD)
    {
        var Thi_Sinh = (XmlElement)null;
        foreach (XmlElement Thi_Sinh_Nguon in Danh_Sach_Thi_Sinh.GetElementsByTagName("THI_SINH"))
        {
            var Thoa_Dieu_kien_Tra_cuu = Thi_Sinh_Nguon.GetAttribute("SBD") == SBD;
            if (Thoa_Dieu_kien_Tra_cuu)
            {
                Thi_Sinh = Thi_Sinh_Nguon;

            }
        }
        return Thi_Sinh;
    }
    //public XmlElement Tra_cuu_Hoc_sinh_theo_Ho_ten( string Ho_ten)
    //{
    //    var Tai_lieu = new XmlDocument();
    //    Tai_lieu.LoadXml("<DANH_SACH_HOC_SINH />");
    //    var Danh_sach = Tai_lieu.DocumentElement;
    //    foreach (XmlElement Hoc_sinh_Nguon in Danh_Sach_Thi_Sinh.GetElementsByTagName("HOC_SINH"))
    //    {
    //        var Thoa_Dieu_kien_Tra_cuu = Hoc_sinh_Nguon.GetAttribute("Ho_ten").ToUpper().Contains(Ho_ten.ToUpper()) ;
    //        if (Thoa_Dieu_kien_Tra_cuu)
    //        {
    //            var Hoc_sinh = Tai_lieu.ImportNode(Hoc_sinh_Nguon, true);
    //            Danh_sach.AppendChild(Hoc_sinh);
    //        }

    //    }
    //    return Danh_sach;
    //}
    //public XmlElement Tra_cuu_Hoc_sinh_theo_Lop( string Chuoi_Tra_cuu)
    //{
   
    //    var Tai_lieu = new XmlDocument();
    //    Tai_lieu.LoadXml("<DANH_SACH_HOC_SINH />");
    //    var Danh_sach = Tai_lieu.DocumentElement;
    //    foreach (XmlElement Hoc_sinh_Nguon in Danh_sach_Hoc_sinh.GetElementsByTagName("HOC_SINH"))
    //    {
    //        var Lop = (XmlElement) Hoc_sinh_Nguon.GetElementsByTagName("LOP")[0];
    //        var Thoa_Dieu_kien_Tra_cuu =   Lop.GetAttribute("Ma_so").ToUpper().Contains(Chuoi_Tra_cuu.ToUpper()) ;
    //        if (Thoa_Dieu_kien_Tra_cuu)
    //        {
    //            var Hoc_sinh = Tai_lieu.ImportNode(Hoc_sinh_Nguon, true);
    //            Danh_sach.AppendChild(Hoc_sinh);
    //        }

    //    }
    //    return Danh_sach;
    //}
    // Xử lý Tạo chuỗi HTML
    public string Tao_Chuoi_HTML_Thi_Sinh(XmlElement Thi_Sinh)
    {
        var Duong_dan_XSLT = Thu_muc_XSLT.FullName + "\\Tao_Chuoi_HTML_Thi_Sinh.xslt";
        var Xu_ly_XSLT = new XslCompiledTransform();
        Xu_ly_XSLT.Load(Duong_dan_XSLT);
        var Bo_Doc_XML = XmlReader.Create(new StringReader(Thi_Sinh.OuterXml));
        var Bo_Ghi_Chuoi = new StringWriter();
        Xu_ly_XSLT.Transform(Bo_Doc_XML, null, Bo_Ghi_Chuoi);
        var Chuoi_HTML = Bo_Ghi_Chuoi.GetStringBuilder().ToString();
        return Chuoi_HTML;
    }
    //public string Tao_Chuoi_HTML_Danh_sach_Hoc_sinh(XmlElement Danh_sach)
    //{
    //    var Duong_dan_XSLT = Thu_muc_XSLT.FullName + "\\Tao_Chuoi_HTML_Danh_sach_Hoc_sinh.xslt";
    //    var Xu_ly_XSLT = new XslCompiledTransform();
    //    Xu_ly_XSLT.Load(Duong_dan_XSLT);
    //    var Bo_Doc_XML = XmlReader.Create(new StringReader(Danh_sach.OuterXml));
    //    var Bo_Ghi_Chuoi = new StringWriter();
    //    Xu_ly_XSLT.Transform(Bo_Doc_XML, null, Bo_Ghi_Chuoi);
    //    var Chuoi_HTML = Bo_Ghi_Chuoi.GetStringBuilder().ToString();
    //    return Chuoi_HTML;
    //}
     


}
