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
    
    public XmlElement Danh_Sach_Dien_Thoai;

    public static XL_DU_LIEU Khoi_dong_Du_lieu() 
    {
        var Du_lieu = new XL_DU_LIEU();
        var Dia_chi = Dia_chi_Dich_vu + "?Ma_so_Xu_ly=DOC_CHUOI_DANH_SACH"
                                + "&Loai_Doi_tuong=DIEN_THOAI";
        var Dich_vu = new WebClient();
        Dich_vu.Encoding = System.Text.Encoding.UTF8;        
        var Chuoi_XML_Danh_Sach_Dien_Thoai = Dich_vu.UploadString(Dia_chi, "");
        var Tai_lieu_Dien_Thoai = new XmlDocument();
        Tai_lieu_Dien_Thoai.LoadXml(Chuoi_XML_Danh_Sach_Dien_Thoai);
        Du_lieu.Danh_Sach_Dien_Thoai = Tai_lieu_Dien_Thoai.DocumentElement;

        return Du_lieu;

    }

    // Xử lý Tra cứu 
    public XmlElement DS_Dien_Thoai(string Ten)
    {
        var Tai_lieu = new XmlDocument();
        Tai_lieu.LoadXml("<DANH_SACH_DIEN_THOAI />");
        var Danh_sach = Tai_lieu.DocumentElement;
        foreach (XmlElement Dien_Thoai_Nguon in Danh_Sach_Dien_Thoai.GetElementsByTagName("DIEN_THOAI"))
        {            
            var Nhom_Dien_Thoai = (XmlElement)Dien_Thoai_Nguon.GetElementsByTagName("NHOM_DIEN_THOAI")[0];
            var Ten_Nhom = Nhom_Dien_Thoai.GetAttribute("Ten");
            if (Ten_Nhom.ToUpper() == Ten.ToUpper())
            {
                var Dien_Thoai = Tai_lieu.ImportNode(Dien_Thoai_Nguon, true);
                Danh_sach.AppendChild(Dien_Thoai);
            }

        }
        return Danh_sach;
    }

    public XmlElement DS_Dien_Thoai_Iphone()
    {
        return DS_Dien_Thoai("iphone");
    }

    public XmlElement DS_Dien_Thoai_Android()
    {
        return DS_Dien_Thoai("Android");
    }

    //public XmlElement Tim_Thi_Sinh_Theo_SBD(string SBD)
    //{
    //    var Thi_Sinh = (XmlElement)null;
    //    foreach (XmlElement Thi_Sinh_Nguon in Danh_Sach_Thi_Sinh.GetElementsByTagName("THI_SINH"))
    //    {
    //        var Thoa_Dieu_kien_Tra_cuu = Thi_Sinh_Nguon.GetAttribute("SBD") == SBD;
    //        if (Thoa_Dieu_kien_Tra_cuu)
    //        {
    //            Thi_Sinh = Thi_Sinh_Nguon;

    //        }
    //    }
    //    return Thi_Sinh;
    //}
    //public XmlElement Tim_Thi_Sinh_Theo_Truong(string Ten_Truong)
    //{
    //    var Tai_lieu = new XmlDocument();
    //    Tai_lieu.LoadXml("<DANH_SACH_THI_SINH />");
    //    var Danh_sach = Tai_lieu.DocumentElement;
    //    foreach (XmlElement Thi_Sinh_Nguon in Danh_Sach_Thi_Sinh.GetElementsByTagName("THI_SINH"))
    //    {
    //        var Truong_Cap_2 = (XmlElement)Thi_Sinh_Nguon.GetElementsByTagName("TRUONG_CAP_2")[0];
    //        var Thoa_Dieu_kien_Tra_cuu = Truong_Cap_2.GetAttribute("Ten").ToUpper().Contains(Ten_Truong.ToUpper());
    //        if (Thoa_Dieu_kien_Tra_cuu)
    //        {
    //            var Thi_Sinh = Tai_lieu.ImportNode(Thi_Sinh_Nguon, true);
    //            Danh_sach.AppendChild(Thi_Sinh);
    //        }

    //    }
    //    return Danh_sach;
    //}
    //public XmlElement Tra_Cuu_Thi_Sinh_Theo_Diem_Toan(string Diem_Toan)
    //{

    //    var Tai_lieu = new XmlDocument();
    //    Tai_lieu.LoadXml("<DANH_SACH_HOC_SINH />");
    //    var Danh_sach = Tai_lieu.DocumentElement;
    //    foreach (XmlElement Thi_Sinh_Nguon in Danh_Sach_Thi_Sinh.GetElementsByTagName("THI_SINH"))
    //    {
    //        var Thoa_Dieu_kien_Tra_cuu = Thi_Sinh_Nguon.GetAttribute("Diem_Toan") == Diem_Toan;            
    //        if (Thoa_Dieu_kien_Tra_cuu)
    //        {
    //            var Hoc_sinh = Tai_lieu.ImportNode(Thi_Sinh_Nguon, true);
    //            Danh_sach.AppendChild(Hoc_sinh);
    //        }

    //    }
    //    return Danh_sach;
    //}
    //// Xử lý Tạo chuỗi HTML
    public string Tao_Chuoi_HTML_Dung_Chung(string Duong_Dan_XSLT, XmlElement xmlElement)
    {
        var Xu_ly_XSLT = new XslCompiledTransform();
        Xu_ly_XSLT.Load(Duong_Dan_XSLT);
        var Bo_Doc_XML = XmlReader.Create(new StringReader(xmlElement.OuterXml));
        var Bo_Ghi_Chuoi = new StringWriter();
        Xu_ly_XSLT.Transform(Bo_Doc_XML, null, Bo_Ghi_Chuoi);
        var Chuoi_HTML = Bo_Ghi_Chuoi.GetStringBuilder().ToString();
        return Chuoi_HTML;
    }
    //public string Tao_Chuoi_HTML_Thi_Sinh(XmlElement Thi_Sinh)
    //{
    //    var Duong_dan_XSLT = Thu_muc_XSLT.FullName + "\\Tao_Chuoi_HTML_Thi_Sinh.xslt";
    //    return Tao_Chuoi_HTML_Dung_Chung(Duong_dan_XSLT, Thi_Sinh);
    //}
    public string Tao_Chuoi_HTML_Danh_Sach_Dien_Thoai(XmlElement Danh_sach)
    {
        var Duong_dan_XSLT = Thu_muc_XSLT.FullName + "\\Tao_Chuoi_HTML_Danh_Sach_Dien_Thoai.xslt";
        return Tao_Chuoi_HTML_Dung_Chung(Duong_dan_XSLT, Danh_sach);
    }



}
