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

    //Danh sach tat ca dien thoai
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

    //Xử lý tra cứu
    //Danh sach phieu dat thoa dieu kien
    // 1. Trang thai CHO_GIAO
    // 2. Duoc phan cong cho nhan vien (MaSoNhanVien)
    public XmlElement DS_PhieuDat_ChoGiao_PhanCong(string _MaSoNhanVien)
    {
        var Tai_lieu = new XmlDocument();// khai bao
        Tai_lieu.LoadXml("<DANH_SACH_PHIEU_DAT />"); //khoi tao
        var Danh_sach = Tai_lieu.DocumentElement; //node root DANH_SACH_PHIEU_DAT

        var DS_PhieuDat_ChoGiao = DS_Phieu_Dat_ChoGiao();
        foreach (XmlElement Phieu_Dat in DS_PhieuDat_ChoGiao)
        {
            var Nhan_Vien = (XmlElement)Phieu_Dat.GetElementsByTagName("Nhan_vien")[0];
            var MaSoNhanVien = Nhan_Vien.GetAttribute("Ma_so");
            if (MaSoNhanVien == _MaSoNhanVien)
            {                
                var PhieuDatMoi = Tai_lieu.ImportNode(Phieu_Dat, true);                
                Danh_sach.AppendChild(PhieuDatMoi);
            }            
        }
        return Danh_sach;
    }
    
    public XmlElement DS_Phieu_Dat_Trang_Thai(string _TrangThai)
    {
        var Tai_lieu = new XmlDocument();// khai bao
        Tai_lieu.LoadXml("<DANH_SACH_PHIEU_DAT />"); //khoi tao
        var Danh_sach = Tai_lieu.DocumentElement; //node root DANH_SACH_PHIEU_DAT
        foreach (XmlElement Dien_Thoai_Nguon in Danh_Sach_Dien_Thoai.GetElementsByTagName("DIEN_THOAI"))
        {
            var MaDienThoai = Dien_Thoai_Nguon.GetAttribute("Ma_so");
            var TenDienThoai = Dien_Thoai_Nguon.GetAttribute("Ten");
            var DonGiaDienThoai = Dien_Thoai_Nguon.GetAttribute("Don_gia_Ban");
            var NodeNhomDienThoai = (XmlElement)Dien_Thoai_Nguon.GetElementsByTagName("NHOM_DIEN_THOAI")[0];
            var MaNhomDienThoai = NodeNhomDienThoai.GetAttribute("Ma_so");
            foreach (XmlElement Phieu_Dat in Dien_Thoai_Nguon.GetElementsByTagName("PHIEU_DAT"))
            {
                var TrangThai = Phieu_Dat.GetAttribute("Trang_thai");
                if (_TrangThai == "%" || TrangThai == _TrangThai)
                {
                    var PhieuDatMoi = Tai_lieu.ImportNode(Phieu_Dat, true);
                    XmlElement ThongTin = taoNodeThongTin(Tai_lieu, MaDienThoai, TenDienThoai, DonGiaDienThoai, MaNhomDienThoai);
                    PhieuDatMoi.AppendChild(ThongTin);
                    Danh_sach.AppendChild(PhieuDatMoi);
                }
            }
        }
        return Danh_sach;
    }
    public XmlElement DS_Phieu_Dat_TatCa()
    {
        return DS_Phieu_Dat_Trang_Thai("%");
    }
    public XmlElement DS_Phieu_Dat_ChoPhanCong()
    {
        return DS_Phieu_Dat_Trang_Thai("CHO_PHAN_CONG");
    }
    public XmlElement DS_Phieu_Dat_ChoGiao()
    {
        return DS_Phieu_Dat_Trang_Thai("CHO_GIAO");
    }
    public XmlElement DS_Phieu_Dat_DaGiao()
    {
        return DS_Phieu_Dat_Trang_Thai("DA_GIAO");
    }
    public XmlElement taoNodeThongTin(XmlDocument Tai_lieu, string MaDienThoai, string TenDienThoai, string DonGiaDienThoai, string MaNhomDienThoai)
    {
        XmlElement ThongTin = Tai_lieu.CreateElement("TT_Dien_Thoai");
        ThongTin.SetAttribute("Ma_So_Dien_Thoai", MaDienThoai);
        ThongTin.SetAttribute("Ten_Dien_Thoai", TenDienThoai);
        ThongTin.SetAttribute("Don_Gia_Dien_Thoai", DonGiaDienThoai);
        ThongTin.SetAttribute("Ma_Nhom_Dien_Thoai", MaNhomDienThoai);
        return ThongTin;
    }
    
    //// Xử lý Ghi 
    //public string Cap_Nhat_Thi_sinh(XmlElement Thi_Sinh)
    //{
    //    var Kq = "";
    //    var Dia_chi = Dia_chi_Dich_vu + "?Ma_so_Xu_ly=GHI_CHUOI"
    //                           + "&Loai_Doi_tuong=THI_SINH"
    //                              + "&SBD=" + Thi_Sinh.GetAttribute("SBD")
    //                           ;
    //    var Dich_vu = new WebClient();
    //    Dich_vu.Encoding = System.Text.Encoding.UTF8;
    //    Kq = Dich_vu.UploadString(Dia_chi, Thi_Sinh.OuterXml);
    //    Kq = Kq.Trim();
    //    return Kq;
    //}
    //public string Them_Thi_sinh(XmlDocument Thi_Sinh)
    //{
    //    var Kq = "";
    //    var Dia_chi = Dia_chi_Dich_vu + "?Ma_so_Xu_ly=GHI_CHUOI"
    //                           + "&Loai_Doi_tuong=THI_SINH"
    //                              + "&SBD=" + Thi_Sinh.DocumentElement.GetAttribute("SBD")
    //                           ;
    //    var Dich_vu = new WebClient();
    //    Dich_vu.Encoding = System.Text.Encoding.UTF8;
    //    Kq = Dich_vu.UploadString(Dia_chi, Thi_Sinh.OuterXml);
    //    Kq = Kq.Trim();
    //    return Kq;
    //}
    //public XmlDocument Khoi_Tao_Thi_sinh(
    //    string SBD
    //    , string HoTen
    //    , string DiemToan
    //    , string DiemVan
    //    , string DiemAnhVan
    //    , string DiemThuong
    //    , string DiemXetTuyen
    //    , string TenTruongCap2 = ""
    //    , string MaTruongCap2 = ""
    //    , string TenTruongCap3_1 = ""
    //    , string MaTruongCap3_1 = ""
    //    , string TenTruongCap3_2 = ""
    //    , string MaTruongCap3_2 = ""
    //    , string TenTruongCap3_3 = ""
    //    , string MaTruongCap3_3 = ""
    //    , string TenTruongCap3_4 = ""
    //    , string MaTruongCap3_5 = ""
    //    )
    //{
    //    var Tai_lieu = new XmlDocument();
    //    Tai_lieu.LoadXml("<THI_SINH />");
    //    var Thi_Sinh = Tai_lieu.DocumentElement;
    //    Thi_Sinh.SetAttribute("Ho_ten", HoTen);
    //    Thi_Sinh.SetAttribute("SBD", SBD);
    //    Thi_Sinh.SetAttribute("Diem_Toan", DiemToan);
    //    Thi_Sinh.SetAttribute("Diem_Van", DiemVan);
    //    Thi_Sinh.SetAttribute("Diem_Anh_van", DiemAnhVan);
    //    Thi_Sinh.SetAttribute("Diem_Thuong", DiemThuong);
    //    Thi_Sinh.SetAttribute("Diem_Xet_tuyen", DiemXetTuyen);

    //    XmlElement ETruongCap2 = Tai_lieu.CreateElement("TRUONG_CAP_2");
    //    ETruongCap2.SetAttribute("Ten", TenTruongCap2);
    //    ETruongCap2.SetAttribute("Ma_so", MaTruongCap2);
    //    Tai_lieu.DocumentElement.AppendChild(ETruongCap2);

    //    XmlElement ETruongCap3_1 = Tai_lieu.CreateElement("TRUONG_CAP_3");
    //    ETruongCap3_1.SetAttribute("Ten", TenTruongCap2);
    //    ETruongCap3_1.SetAttribute("Ma_so", MaTruongCap2);
    //    Tai_lieu.DocumentElement.AppendChild(ETruongCap3_1);

    //    XmlElement ETruongCap3_2 = Tai_lieu.CreateElement("TRUONG_CAP_3");
    //    ETruongCap3_2.SetAttribute("Ten", TenTruongCap2);
    //    ETruongCap3_2.SetAttribute("Ma_so", MaTruongCap2);
    //    Tai_lieu.DocumentElement.AppendChild(ETruongCap3_2);

    //    XmlElement ETruongCap3_3 = Tai_lieu.CreateElement("TRUONG_CAP_3");
    //    ETruongCap3_3.SetAttribute("Ten", TenTruongCap2);
    //    ETruongCap3_3.SetAttribute("Ma_so", MaTruongCap2);
    //    Tai_lieu.DocumentElement.AppendChild(ETruongCap3_3);

    //    XmlElement ETruongCap3_4 = Tai_lieu.CreateElement("TRUONG_CAP_3");
    //    ETruongCap3_4.SetAttribute("Ten", TenTruongCap2);
    //    ETruongCap3_4.SetAttribute("Ma_so", MaTruongCap2);
    //    Tai_lieu.DocumentElement.AppendChild(ETruongCap3_4);


    //    return Tai_lieu;
    //}
    //// Xử lý Tra cứu 
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

    // Xử lý Tạo chuỗi HTML 
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
    //public string Tao_Chuoi_HTML_Cap_nhat_Diem_Toan(XmlElement Thi_Sinh)
    //{
    //    var Duong_dan_XSLT = Thu_muc_XSLT.FullName + "\\Tao_Chuoi_HTML_Cap_Nhat_Diem_Toan.xslt";
    //    return Tao_Chuoi_HTML_Dung_Chung(Duong_dan_XSLT, Thi_Sinh);
    //}
    //public string Tao_Chuoi_HTML_Thi_Sinh(XmlElement Thi_Sinh)
    //{
    //    var Duong_dan_XSLT = Thu_muc_XSLT.FullName + "\\Tao_Chuoi_HTML_Thi_Sinh.xslt";
    //    return Tao_Chuoi_HTML_Dung_Chung(Duong_dan_XSLT, Thi_Sinh);
    //}
    public string Tao_Chuoi_HTML_Danh_Sach(XmlElement Danh_sach)
    {
        var Duong_dan_XSLT = Thu_muc_XSLT.FullName + "\\Tao_Chuoi_HTML_Danh_Sach.xslt";
        return Tao_Chuoi_HTML_Dung_Chung(Duong_dan_XSLT, Danh_sach);
    }
}
