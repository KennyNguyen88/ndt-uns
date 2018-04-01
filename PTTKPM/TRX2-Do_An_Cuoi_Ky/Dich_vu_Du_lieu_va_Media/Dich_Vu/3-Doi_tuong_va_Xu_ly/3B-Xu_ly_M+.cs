using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Helpers;
using System.Web.Hosting;
using System.Globalization;
//************************* M+ (Model for All ) **********************************
public partial class XL_DICH_VU
{
    static XL_DICH_VU Dich_vu = null;

    XL_DU_LIEU Du_lieu_Dich_vu = new XL_DU_LIEU();
    XL_NHA_HANG Cua_hang = new XL_NHA_HANG();
    List<XL_MONAN> Danh_sach_Mon_an = new List<XL_MONAN>();
    List<XL_THUCDON> Danh_sach_Thuc_don = new List<XL_THUCDON>();
    List<XL_NGUOI_DUNG> Danh_sach_Nguoi_dung = new List<XL_NGUOI_DUNG>();
    public static XL_DICH_VU Khoi_dong_Dich_vu()
    {
        Dich_vu = new XL_DICH_VU();// Tạm thời không CaChing 
        Dich_vu.Khoi_dong_Du_lieu_Dich_vu();
        return Dich_vu;
    }
    void Khoi_dong_Du_lieu_Dich_vu()
    {
        var Du_lieu_Luu_tru = XL_DU_LIEU.Doc_Du_lieu_Luu_tru();
        Du_lieu_Dich_vu = Du_lieu_Luu_tru;     
    }
    // Tạo Dữ liệu cho Phân hệ 
    public XL_DU_LIEU Tao_Du_lieu_Phan_he_Khach_Tham_quan()
    {
        var Du_lieu_Phan_he = Du_lieu_Dich_vu;
        // Cần xóa thông tin không cần thiết
        return Du_lieu_Phan_he;
    }
    public XL_DU_LIEU Tao_Du_lieu_Phan_he_Quan_ly()
    {
        var Du_lieu_Phan_he = Du_lieu_Dich_vu;
        // Cần xóa thông tin không cần thiết
        return Du_lieu_Phan_he;
    }
    public XL_DU_LIEU Tao_Du_lieu_Phan_he_Nhan_vien_Phuc_vu()
    {
        var Du_lieu_Phan_he = Du_lieu_Dich_vu;
        // Cần xóa thông tin không cần thiết
        return Du_lieu_Phan_he;
    }
    public XL_DU_LIEU Tao_Du_lieu_Phan_he_Nhan_vien_Thu_ngan()
    {
        var Du_lieu_Phan_he = Du_lieu_Dich_vu;
        // Cần xóa thông tin không cần thiết
        return Du_lieu_Phan_he;
    }
}
//************************* Business-Layers BL **********************************
public partial class XL_DICH_VU
{
    public string THEM_MON_AN(XL_MONAN Mon_An)
    {
        var Kq = "";

        var crMa_so_Mon_An = Du_lieu_Dich_vu.Danh_sach_Mon_an.OrderByDescending(p => int.Parse(p.Ma_so.Split('_')[1])).FirstOrDefault().Ma_so;
        crMa_so_Mon_An = crMa_so_Mon_An.Split('_')[1];
        Mon_An.Ma_so = "MONAN_" + (int.Parse(crMa_so_Mon_An) + 1);
        Du_lieu_Dich_vu.Danh_sach_Mon_an.Add(Mon_An);
        Kq = XL_DU_LIEU.Ghi_Mon_an(Mon_An);
        if (Kq != (Mon_An.Ma_so + ":OK"))
            Du_lieu_Dich_vu.Danh_sach_Mon_an.Remove(Mon_An);
        return Kq;
    }
    public string XOA_MON_AN(XL_MONAN Mon_An)
    {
        var Kq = "";        
        Kq = XL_DU_LIEU.Xoa_Mon_an(Mon_An);
        if (Kq != "OK")
            Kq = "Error";
        else
            Du_lieu_Dich_vu.Danh_sach_Mon_an.Remove(Mon_An);
        return Kq;
    }
    public string Cap_nhat_Mon_An(XL_MONAN Mon_An, long Don_gia_Nhap, long Don_gia_Ban, string Ten, string Trang_Thai)
    {
        var Kq = "";
        var Ten_Goc = Mon_An.Ten;
        var Don_gia_Ban_Goc = Mon_An.Don_gia_Ban;
        var Don_gia_Nhap_Goc = Mon_An.Don_gia_Nhap;        
        Mon_An.Ten = Ten;
        Mon_An.Don_gia_Nhap = Don_gia_Nhap;
        Mon_An.Don_gia_Ban = Don_gia_Ban;        
        Kq = XL_DU_LIEU.Ghi_Mon_an(Mon_An);
        if (Kq != "OK")
        {
            Mon_An.Ten = Ten_Goc;
            Mon_An.Don_gia_Nhap = Don_gia_Nhap_Goc;
            Mon_An.Don_gia_Ban = Don_gia_Ban_Goc;            
        }
        return Kq;
    }
    public string Cap_nhat_Nguoi_dung(XL_NGUOI_DUNG Nguoi_dung, string Ho_ten, string mat_khau)
    {
        var Kq = "";
        var Ho_Ten_Goc = Nguoi_dung.Ho_ten;
        var Mat_Khau_Goc = Nguoi_dung.Mat_khau;
        
        Nguoi_dung.Mat_khau = mat_khau;
        Nguoi_dung.Ho_ten = Ho_ten;
        Kq = XL_DU_LIEU.Ghi_Nguoi_dung(Nguoi_dung);
        if (Kq != "OK")
        {
            Nguoi_dung.Ho_ten = Ho_Ten_Goc;
            Nguoi_dung.Mat_khau = Mat_Khau_Goc;            
        }
        return Kq;
    }
    public string Ghi_IMAGE(string Ma_so, byte[] imgByte, string imgType)
    {
        var Kq = "";
        Kq = XL_DU_LIEU.Ghi_IMAGE(Ma_so, imgByte, imgType);

        if (Kq != "OK")
        {
            Kq = "Error";
        }
        return Kq;
    }
    public string Them_Phieu_Dat_Moi(XL_PHIEU_DAT Phieu_dat)
    {
        var So_moi = Du_lieu_Dich_vu.Danh_sach_Phieu_dat.Count + 1;

        Phieu_dat.Ma_so = "PHIEU_" + So_moi;
        Phieu_dat.Thanh_tien = Tinh_Thanh_Tien(Phieu_dat);
        return Du_lieu_Dich_vu.Ghi_Phieu_Dat(Phieu_dat);
    }
    public string Cap_nhat_Phieu_dat(XL_PHIEU_DAT Phieu_dat)
    {
        Phieu_dat.Thanh_tien = Tinh_Thanh_Tien(Phieu_dat);
        return Du_lieu_Dich_vu.Ghi_Phieu_Dat(Phieu_dat);
    }
    private long Tinh_Thanh_Tien(XL_PHIEU_DAT Phieu_dat)
    {
        long kq = 0;
        Phieu_dat.Danh_sach_Mon_an.ForEach(DS_Monan =>
        {
            XL_MONAN Monan = Tim_Mon_an_Theo_Ma(DS_Monan.Ma_so_Mon_an);
            long temp = Monan.Don_gia_Ban * DS_Monan.So_luong;
            kq += temp;
        });
        return kq;
    }
    private XL_MONAN Tim_Mon_an_Theo_Ma(String Ma_so_Mon_an)
    {        
        return Du_lieu_Dich_vu.Danh_sach_Mon_an.FirstOrDefault(Mon_an => Mon_an.Ma_so.Equals(Ma_so_Mon_an));
    }
    
}
//************************* Data-Layers DL **********************************
public partial class XL_DU_LIEU
{
    static DirectoryInfo Thu_muc_Project = new DirectoryInfo(HostingEnvironment.ApplicationPhysicalPath);
    static DirectoryInfo Thu_muc_Du_lieu = Thu_muc_Project.GetDirectories("2-Du_lieu_luu_tru")[0];
    static DirectoryInfo Thu_muc_Nha_hang = Thu_muc_Du_lieu.GetDirectories("Nha_hang")[0];
    static DirectoryInfo Thu_muc_Mon_an = Thu_muc_Du_lieu.GetDirectories("Mon_an")[0];
    static DirectoryInfo Thu_muc_Nguoi_dung = Thu_muc_Du_lieu.GetDirectories("Nguoi_dung")[0];
    static DirectoryInfo Thu_muc_Phieu_dat_mon = Thu_muc_Du_lieu.GetDirectories("Phieu_dat_mon")[0];    
    static DirectoryInfo Thu_muc_Media = Thu_muc_Project.GetDirectories("Media")[0];

    public static XL_DU_LIEU Doc_Du_lieu_Luu_tru()
    {
        var Du_lieu_Luu_tru = new XL_DU_LIEU();
        Du_lieu_Luu_tru.Nha_hang = Doc_Danh_sach_Nha_hang()[0];
        Du_lieu_Luu_tru.Danh_sach_Mon_an = Doc_Danh_sach_Mon_an();
        Du_lieu_Luu_tru.Danh_sach_Nguoi_dung = Doc_Danh_sach_Nguoi_dung();
        Du_lieu_Luu_tru.Danh_sach_Phieu_dat = Doc_Danh_sach_Phieu_dat();
        return Du_lieu_Luu_tru;
    }
    static List<XL_NGUOI_DUNG> Doc_Danh_sach_Nguoi_dung()
    {
        var Danh_sach_Nguoi_dung = new List<XL_NGUOI_DUNG>();
        var Danh_sach_Tap_tin = Thu_muc_Nguoi_dung.GetFiles("*.json").ToList();
        Danh_sach_Tap_tin.ForEach(Tap_tin =>
        {
            var Duong_dan = Tap_tin.FullName;
            var Chuoi_JSON = File.ReadAllText(Duong_dan);
            var Nguoi_dung = Json.Decode<XL_NGUOI_DUNG>(Chuoi_JSON);
            Danh_sach_Nguoi_dung.Add(Nguoi_dung);
        });
        return Danh_sach_Nguoi_dung;
    }
    static List<XL_NHA_HANG> Doc_Danh_sach_Nha_hang()
    {
        var Danh_sach_Nha_hang = new List<XL_NHA_HANG>();
        var Danh_sach_Tap_tin = Thu_muc_Nha_hang.GetFiles("*.json").ToList();
        Danh_sach_Tap_tin.ForEach(Tap_tin =>
        {
            var Duong_dan = Tap_tin.FullName;
            var Chuoi_JSON = File.ReadAllText(Duong_dan);
            var Cua_hang = Json.Decode<XL_NHA_HANG>(Chuoi_JSON);
            Danh_sach_Nha_hang.Add(Cua_hang);
        });
        return Danh_sach_Nha_hang;
    }
    static List<XL_MONAN> Doc_Danh_sach_Mon_an()
    {
        var Danh_sach_Mon_an = new List<XL_MONAN>();
        var Danh_sach_Tap_tin = Thu_muc_Mon_an.GetFiles("*.json").ToList();
        Danh_sach_Tap_tin.ForEach(Tap_tin =>
        {
            var Duong_dan = Tap_tin.FullName;
            var Chuoi_JSON = File.ReadAllText(Duong_dan);
            var Mon_an = Json.Decode<XL_MONAN>(Chuoi_JSON);
            Danh_sach_Mon_an.Add(Mon_an);
        });
        return Danh_sach_Mon_an;
    }
    static List<XL_PHIEU_DAT> Doc_Danh_sach_Phieu_dat()
    {
        var Danh_sach_Phieu_dat = new List<XL_PHIEU_DAT>();
        var Danh_sach_Tap_tin = Thu_muc_Phieu_dat_mon.GetFiles("*.json").ToList();
        Danh_sach_Tap_tin.ForEach(Tap_tin =>
        {
            var Duong_dan = Tap_tin.FullName;
            var Chuoi_JSON = File.ReadAllText(Duong_dan);
            var Phieu_dat = Json.Decode<XL_PHIEU_DAT>(Chuoi_JSON);
            Danh_sach_Phieu_dat.Add(Phieu_dat);
        });
        return Danh_sach_Phieu_dat;
    }

    public static string Ghi_Mon_an(XL_MONAN MonAn)
    {
        var Kq = "";
        var Duong_dan = $"{Thu_muc_Mon_an.FullName}\\{MonAn.Ma_so}.json";
        var Chuoi_JSON = Json.Encode(MonAn);
        try
        {
            File.WriteAllText(Duong_dan, Chuoi_JSON);
            Kq = (MonAn.Ma_so + ":OK");
        }
        catch (Exception Loi)
        {
            Kq = Loi.Message;
        }
        return Kq;

    }
    public static string Xoa_Mon_an(XL_MONAN MonAn)
    {
        var Kq = "";
        var Duong_dan = $"{Thu_muc_Mon_an.FullName}\\{MonAn.Ma_so}.json";
        var Chuoi_JSON = Json.Encode(MonAn);
        try
        {
            File.Delete(Duong_dan);
            Kq = "OK";

        }
        catch (Exception Loi)
        {
            Kq = Loi.Message;
        }
        return Kq;

    }
    public static string Ghi_Nguoi_dung(XL_NGUOI_DUNG Nguoi_dung)
    {
        var Kq = "";
        var Duong_dan = $"{Thu_muc_Nguoi_dung.FullName}\\{Nguoi_dung.Ma_so}.json";
        var Chuoi_JSON = Json.Encode(Nguoi_dung);
        try
        {
            File.WriteAllText(Duong_dan, Chuoi_JSON);
            Kq = "OK";

        }
        catch (Exception Loi)
        {
            Kq = Loi.Message;
        }
        return Kq;

    }
    public string Ghi_Phieu_Dat(XL_PHIEU_DAT Phieu_dat)
    {
        var Kq = "";
        var Duong_dan = $"{Thu_muc_Phieu_dat_mon.FullName}\\{Phieu_dat.Ma_so}.json";
        var Chuoi_JSON = Json.Encode(Phieu_dat);
        try
        {
            File.WriteAllText(Duong_dan, Chuoi_JSON);
            Kq = "OK";

        }
        catch (Exception Loi)
        {
            Kq = Loi.Message;
        }
        return Kq;

    }    
    public static string Ghi_IMAGE(string Ma_so, byte[] imgByte, string imgType)
    {
        var Kq = "";
        //var Duong_dan = $"{Thu_muc_Media.FullName}\\{Ma_so}.{imgByte.GetType()}";
        var Duong_dan = $"{Thu_muc_Media.FullName}\\{Ma_so}.{imgType}";
        try
        {
            File.WriteAllBytes(Duong_dan, imgByte);
            Kq = "OK";

        }
        catch (Exception Loi)
        {
            Kq = Loi.Message;
        }
        return Kq;

    }

}