﻿using System;
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
    public XmlElement DS_Dien_Thoai(string _MaSoNhom)
    {
        var Tai_lieu = new XmlDocument();
        Tai_lieu.LoadXml("<DANH_SACH_DIEN_THOAI />");
        var Danh_sach = Tai_lieu.DocumentElement;
        foreach (XmlElement Dien_Thoai_Nguon in Danh_Sach_Dien_Thoai.GetElementsByTagName("DIEN_THOAI"))
        {
            var Nhom_Dien_Thoai = (XmlElement)Dien_Thoai_Nguon.GetElementsByTagName("NHOM_DIEN_THOAI")[0];
            var MaSoNhom = Nhom_Dien_Thoai.GetAttribute("Ma_so");
            if (MaSoNhom.ToUpper() == _MaSoNhom.ToUpper())
            {
                var Dien_Thoai = Tai_lieu.ImportNode(Dien_Thoai_Nguon, true);
                Danh_sach.AppendChild(Dien_Thoai);
            }

        }
        return Danh_sach;
    }
    public XmlElement DS_Dien_Thoai_Iphone()
    {
        return DS_Dien_Thoai("IPHONE");
    }
    public XmlElement DS_Dien_Thoai_Android()
    {
        return DS_Dien_Thoai("ANDROID");
    }
    public XmlElement Tra_DT_Theo_Ma(string _MaDienThoai)
    {
        var DienThoai = (XmlElement)null;
        foreach (XmlElement Dien_Thoai_Nguon in Danh_Sach_Dien_Thoai.GetElementsByTagName("DIEN_THOAI"))
        {
            var MaDienThoai = Dien_Thoai_Nguon.GetAttribute("Ma_so");
            if (MaDienThoai.ToUpper() == _MaDienThoai.ToUpper())
            {
                DienThoai = Dien_Thoai_Nguon;
            }
        }
        return DienThoai;
    }
    public XmlElement Tra_DT_Theo_Ten(string _TenDienThoai)
    {
        var Tai_lieu = new XmlDocument();
        Tai_lieu.LoadXml("<DANH_SACH_DIEN_THOAI />");
        var Danh_sach = Tai_lieu.DocumentElement;
        foreach (XmlElement Dien_Thoai_Nguon in Danh_Sach_Dien_Thoai.GetElementsByTagName("DIEN_THOAI"))
        {
            var TenDienThoai = Dien_Thoai_Nguon.GetAttribute("Ten");
            if (TenDienThoai.ToUpper() == _TenDienThoai.ToUpper())
            {
                var DienThoai = Tai_lieu.ImportNode(Dien_Thoai_Nguon, true);
                Danh_sach.AppendChild(DienThoai);
            }
        }
        return Danh_sach;
    }
    public XmlElement DS_Dien_Thoai_TheoTrangThaiPhieuDat(string _TrangThai)
    {
        var Tai_lieu = new XmlDocument();// khai bao
        Tai_lieu.LoadXml("<DANH_SACH_DIEN_THOAI />"); //khoi tao
        var Danh_sach = Tai_lieu.DocumentElement; //node root DANH_SACH_DIEN_THOAI
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
                if (TrangThai == _TrangThai)
                {
                    var Dien_Thoai = Tai_lieu.ImportNode(Dien_Thoai_Nguon, true);
                    Danh_sach.AppendChild(Dien_Thoai);
                }
            }
        }
        return Danh_sach;
    }
    public XmlElement DS_Dien_Thoai_TheoTrangThaiPhieuDat_ChoPhanCong()
    {
        return DS_Dien_Thoai_TheoTrangThaiPhieuDat("CHO_PHAN_CONG");
    }
    public XmlElement DS_Dien_Thoai_TheoTrangThaiPhieuDat_ChoGiao()
    {
        return DS_Dien_Thoai_TheoTrangThaiPhieuDat("CHO_GIAO");
    }
    public XmlElement DS_Dien_Thoai_TheoTrangThaiPhieuDat_DaGiao()
    {
        return DS_Dien_Thoai_TheoTrangThaiPhieuDat("DA_GIAO");
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

    public XmlElement DS_ThongKe_Thang(int _thang, int _nam)
    {
        var Tai_lieu = new XmlDocument();// khai bao
        Tai_lieu.LoadXml("<DANH_SACH_NGAY />"); //khoi tao
        var Danh_sach = Tai_lieu.DocumentElement; //node root DANH_SACH_NGAY
        var DS_PhieuDat_DaGiao = DS_Phieu_Dat_DaGiao();

        int days = DateTime.DaysInMonth(_nam, _thang); //so ngay trong thang
        double sum = 0;
        double[] dsNgay = new double[days];

        foreach (XmlElement Phieu_Dat in DS_PhieuDat_DaGiao.GetElementsByTagName("PHIEU_DAT"))
        {
            var Ngay = Phieu_Dat.GetAttribute("Ngay");
            var Tien = int.Parse(Phieu_Dat.GetAttribute("Tien"));
            //extract Ngay
            DateTime dtNgay = DateTime.Parse(Ngay);            
            int iNgay = dtNgay.Day;
            int iMonth = dtNgay.Month;
            int iNam = dtNgay.Year;
            if (iMonth == _thang && iNam == _nam)
            {
                sum += Tien;
                dsNgay[(iNgay - 1)] += Tien;
            }
        }

        for (int i = 0; i < days; i++)
        {
            double percent = Math.Round(((dsNgay[i] / sum) * 100));
            var ele = taoNodeThongKeNgay(Tai_lieu, (i + 1).ToString(), dsNgay[i].ToString(), percent.ToString());
            Danh_sach.AppendChild(ele);
        }

        //Tong Thu
        XmlElement Tong_Thu = Tai_lieu.CreateElement("Tong_Thu");
        Tong_Thu.SetAttribute("Thang", _thang.ToString()+"/"+_nam.ToString());
        Tong_Thu.SetAttribute("Tien", sum.ToString());
        Danh_sach.AppendChild(Tong_Thu);
        return Danh_sach;
    }
    public XmlElement taoNodeThongKeNgay(XmlDocument Tai_lieu, string ngay, string doanhThu, string percent)
    {
        XmlElement ThongTin = Tai_lieu.CreateElement("Thong_Ke_Ngay");
        ThongTin.SetAttribute("Ngay", ngay);
        ThongTin.SetAttribute("Doanh_Thu", doanhThu);
        ThongTin.SetAttribute("Ti_Le", percent);        
        return ThongTin;
    }

    public XmlElement DS_ThongKe_Nam(int _nam)
    {
        var Tai_lieu = new XmlDocument();// khai bao
        Tai_lieu.LoadXml("<DANH_SACH_THANG />"); //khoi tao
        var Danh_sach = Tai_lieu.DocumentElement; //node root DANH_SACH_NGAY
        var DS_PhieuDat_DaGiao = DS_Phieu_Dat_DaGiao();

        //int days = DateTime.DaysInMonth(_nam, _thang); //so ngay trong thang
        int months = 12;
        double sum = 0;
        double[] dsThang = new double[months];

        foreach (XmlElement Phieu_Dat in DS_PhieuDat_DaGiao.GetElementsByTagName("PHIEU_DAT"))
        {
            var Ngay = Phieu_Dat.GetAttribute("Ngay");
            var Tien = int.Parse(Phieu_Dat.GetAttribute("Tien"));
            //extract Ngay
            DateTime dtNgay = DateTime.Parse(Ngay);
            int iNgay = dtNgay.Day;
            int iMonth = dtNgay.Month;
            int iNam = dtNgay.Year;
            if (iNam == _nam)
            {
                sum += Tien;
                dsThang[(iMonth - 1)] += Tien;
            }
        }

        for (int i = 0; i < months; i++)
        {
            double percent = Math.Round(((dsThang[i] / sum) * 100));
            var ele = taoNodeThongKeThang(Tai_lieu, (i + 1).ToString(), dsThang[i].ToString(), percent.ToString());
            Danh_sach.AppendChild(ele);
        }

        //Tong Thu
        XmlElement Tong_Thu = Tai_lieu.CreateElement("Tong_Thu");
        Tong_Thu.SetAttribute("Nam", _nam.ToString());
        Tong_Thu.SetAttribute("Tien", sum.ToString());
        Danh_sach.AppendChild(Tong_Thu);
        return Danh_sach;
    }
    public XmlElement taoNodeThongKeThang(XmlDocument Tai_lieu, string thang, string doanhThu, string percent)
    {
        XmlElement ThongTin = Tai_lieu.CreateElement("Thong_Ke_Thang");
        ThongTin.SetAttribute("Thang", thang);
        ThongTin.SetAttribute("Doanh_Thu", doanhThu);
        ThongTin.SetAttribute("Ti_Le", percent);
        return ThongTin;
    }    

    //Xử lý Cập Nhật
    public String doCapNhatDonGia(String MaDT, String DonGia)
    {
        var DienThoai = Tra_DT_Theo_Ma(MaDT);
        DienThoai.SetAttribute("Don_gia_Ban", DonGia);
        return Cap_Nhat_Dien_Thoai(DienThoai);

    }
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
    public string Tao_Chuoi_HTML_Danh_Sach_Dien_Thoai(XmlElement Danh_sach)
    {
        var Duong_dan_XSLT = Thu_muc_XSLT.FullName + "\\Tao_Chuoi_HTML_Danh_Sach_Dien_Thoai.xslt";
        return Tao_Chuoi_HTML_Dung_Chung(Duong_dan_XSLT, Danh_sach);
    }
    public string Tao_Chuoi_HTML_Danh_Sach_Phan_Cong(XmlElement Danh_sach)
    {
        var Duong_dan_XSLT = Thu_muc_XSLT.FullName + "\\Tao_Chuoi_HTML_Danh_Sach_Phan_Cong.xslt";
        return Tao_Chuoi_HTML_Dung_Chung(Duong_dan_XSLT, Danh_sach);
    }
    public string Tao_Chuoi_HTML_Danh_Sach_Don_Hang(XmlElement Danh_sach)
    {
        var Duong_dan_XSLT = Thu_muc_XSLT.FullName + "\\Tao_Chuoi_HTML_Danh_Sach_Don_Hang.xslt";
        return Tao_Chuoi_HTML_Dung_Chung(Duong_dan_XSLT, Danh_sach);
    }
    public string Tao_Chuoi_HTML_Cap_Nhat_Don_gia(XmlElement Dien_Thoai)
    {
        var Duong_dan_XSLT = Thu_muc_XSLT.FullName + "\\Tao_Chuoi_HTML_Cap_Nhat_Don_gia.xslt";
        return Tao_Chuoi_HTML_Dung_Chung(Duong_dan_XSLT, Dien_Thoai);
    }
    public string Tao_Chuoi_HTML_Thong_Ke_Thang(XmlElement Danh_sach)
    {
        var Duong_dan_XSLT = Thu_muc_XSLT.FullName + "\\Tao_Chuoi_HTML_Thong_Ke_Thang.xslt";
        return Tao_Chuoi_HTML_Dung_Chung(Duong_dan_XSLT, Danh_sach);
    }
    public string Tao_Chuoi_HTML_Thong_Ke_Nam(XmlElement Danh_sach)
    {
        var Duong_dan_XSLT = Thu_muc_XSLT.FullName + "\\Tao_Chuoi_HTML_Thong_Ke_Nam.xslt";
        return Tao_Chuoi_HTML_Dung_Chung(Duong_dan_XSLT, Danh_sach);
    }
}
