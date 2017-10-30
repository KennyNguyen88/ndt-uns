using System.Web;
using System.IO;
using System.Net;
using System.Xml;
using System.Xml.Xsl;
public class XL_DU_LIEU
{
    static string Dia_chi_Dich_vu = "http://localhost:57929/XL_DICH_VU_XML.cshtml";
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
    public XmlElement Tra_DT_Theo_Ma(string _MaDienThoai)
    {
        var Dien_Thoai = (XmlElement)null;
        foreach (XmlElement Dien_Thoai_Nguon in Danh_Sach_Dien_Thoai.GetElementsByTagName("DIEN_THOAI"))
        {
            var Thoa_Dieu_kien_Tra_cuu = Dien_Thoai_Nguon.GetAttribute("Ma_so") == _MaDienThoai;
            if (Thoa_Dieu_kien_Tra_cuu)
            {
                Dien_Thoai = Dien_Thoai_Nguon;
            }
        }
        return Dien_Thoai;
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

    //Xử lý cập nhật
    public string Cap_Nhat_Dien_Thoai(XmlElement DienThoai)
    {
        var Kq = "";
        var Dia_chi = Dia_chi_Dich_vu + "?Ma_So_Xu_Ly=GHI_CHUOI"
                               + "&Loai_Doi_Tuong=DIEN_THOAI"
                                  + "&Ma_So=" + DienThoai.GetAttribute("Ma_so")
                               ;
        var Dich_vu = new WebClient();
        Dich_vu.Encoding = System.Text.Encoding.UTF8;
        Kq = Dich_vu.UploadString(Dia_chi, DienThoai.OuterXml);
        Kq = Kq.Trim();
        return Kq;
    }
    public string doGiaoHang(string MaNV, string MaDT, string SoDT)
    {
        var DienThoai = Tra_DT_Theo_Ma(MaDT);
        var Phieu_Dat_List = DienThoai.GetElementsByTagName("PHIEU_DAT");
        foreach (XmlElement PhieuDatNguon in Phieu_Dat_List)
        {
            var NodeKhachHang = (XmlElement)PhieuDatNguon.GetElementsByTagName("Khach_hang")[0];
            if (NodeKhachHang.GetAttribute("Dien_thoai") == SoDT)
            {
                PhieuDatNguon.SetAttribute("Trang_thai", "DA_GIAO");
            }
        }
        return Cap_Nhat_Dien_Thoai(DienThoai);
    }

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
    public string Tao_Chuoi_HTML_Danh_Sach(XmlElement Danh_sach)
    {
        var Duong_dan_XSLT = Thu_muc_XSLT.FullName + "\\Tao_Chuoi_HTML_Danh_Sach.xslt";
        return Tao_Chuoi_HTML_Dung_Chung(Duong_dan_XSLT, Danh_sach);
    }
}
