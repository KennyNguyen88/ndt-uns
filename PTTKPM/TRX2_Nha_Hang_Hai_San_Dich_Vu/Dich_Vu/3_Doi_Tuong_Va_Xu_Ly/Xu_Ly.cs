using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Helpers;
using System.Web.Hosting;
using System.Globalization;
//************************* M+ (Model for All ) **********************************
public partial class XL_DU_LIEU
{
    static XL_DU_LIEU Du_lieu_Ung_dung;
    public static XL_DU_LIEU Khoi_dong_Du_lieu_Ung_dung()
    {   // Không Caching == > Thử nghiệm dễ và xem Tốc độ Xử lý 
        Du_lieu_Ung_dung = new XL_DU_LIEU();
        Du_lieu_Ung_dung.Cua_hang = Doc_Danh_sach_Cua_hang()[0];
        Du_lieu_Ung_dung.Danh_sach_Tivi = Doc_Danh_sach_Tivi();
        return Du_lieu_Ung_dung;
    }
}
//************************* Business-Layers BL **********************************
public partial class XL_DU_LIEU
{
    // Tạo Dữ liệu cho Phân hệ 
    public XL_DU_LIEU Tao_Du_lieu_Phan_he_Khach_Tham_quan()
    {
        var Du_lieu_Phan_he = new XL_DU_LIEU();
        Du_lieu_Phan_he.Cua_hang.Ten = Du_lieu_Ung_dung.Cua_hang.Ten;
        Du_lieu_Phan_he.Cua_hang.Ma_so = Du_lieu_Ung_dung.Cua_hang.Ma_so;
        Du_lieu_Ung_dung.Danh_sach_Tivi.ForEach(Tivi =>
        {
            var Tivi_cua_Phan_he = new XL_TIVI();
            Du_lieu_Phan_he.Danh_sach_Tivi.Add(Tivi_cua_Phan_he);
            Tivi_cua_Phan_he.Ten = Tivi.Ten;
            Tivi_cua_Phan_he.Ma_so = Tivi.Ma_so;
            Tivi_cua_Phan_he.Don_gia_Ban = Tivi.Don_gia_Ban;
            Tivi_cua_Phan_he.Trang_thai_Con_hang = Tinh_So_luong_Ton_Tivi(Tivi) > 0;

        });
        return Du_lieu_Phan_he;
    }
    public XL_DU_LIEU Tao_Du_lieu_Phan_he_Nhan_vien_Nhap_hang()
    {
        var Du_lieu_Phan_he = new XL_DU_LIEU();
        Du_lieu_Phan_he.Cua_hang.Ten = Du_lieu_Ung_dung.Cua_hang.Ten;
        Du_lieu_Phan_he.Cua_hang.Ma_so = Du_lieu_Ung_dung.Cua_hang.Ma_so;
        Du_lieu_Phan_he.Cua_hang.Danh_sach_Nhan_vien = Du_lieu_Ung_dung.Cua_hang.Danh_sach_Nhan_vien;
        Du_lieu_Phan_he.Cua_hang.Danh_sach_Nhom_Nhan_vien = Du_lieu_Ung_dung.Cua_hang.Danh_sach_Nhom_Nhan_vien;
        Du_lieu_Ung_dung.Danh_sach_Tivi.ForEach(Tivi =>
        {
            var Tivi_cua_Phan_he = new XL_TIVI();
            Du_lieu_Phan_he.Danh_sach_Tivi.Add(Tivi_cua_Phan_he);
            Tivi_cua_Phan_he.Ten = Tivi.Ten;
            Tivi_cua_Phan_he.Ma_so = Tivi.Ma_so;
            Tivi_cua_Phan_he.Don_gia_Nhap = Tivi.Don_gia_Nhap;
            Tivi_cua_Phan_he.So_luong_Ton = Tinh_So_luong_Ton_Tivi(Tivi);

        });
        return Du_lieu_Phan_he;
    }
    public XL_DU_LIEU Tao_Du_lieu_Phan_he_Nhan_vien_Ban_hang()
    {
        var Du_lieu_Phan_he = new XL_DU_LIEU();
        Du_lieu_Phan_he.Cua_hang.Ten = Du_lieu_Ung_dung.Cua_hang.Ten;
        Du_lieu_Phan_he.Cua_hang.Ma_so = Du_lieu_Ung_dung.Cua_hang.Ma_so;
        Du_lieu_Phan_he.Cua_hang.Danh_sach_Nhan_vien = Du_lieu_Ung_dung.Cua_hang.Danh_sach_Nhan_vien;
        Du_lieu_Phan_he.Cua_hang.Danh_sach_Nhom_Nhan_vien = Du_lieu_Ung_dung.Cua_hang.Danh_sach_Nhom_Nhan_vien;
        Du_lieu_Ung_dung.Danh_sach_Tivi.ForEach(Tivi =>
        {
            var Tivi_cua_Phan_he = new XL_TIVI();
            Du_lieu_Phan_he.Danh_sach_Tivi.Add(Tivi_cua_Phan_he);
            Tivi_cua_Phan_he.Ten = Tivi.Ten;
            Tivi_cua_Phan_he.Ma_so = Tivi.Ma_so;
            Tivi_cua_Phan_he.Don_gia_Ban = Tivi.Don_gia_Ban;
            Tivi_cua_Phan_he.So_luong_Ton = Tinh_So_luong_Ton_Tivi(Tivi);
            Tivi_cua_Phan_he.Doanh_thu = Tinh_Doanh_thu_Tivi(Tivi, DateTime.Today);
            Tivi_cua_Phan_he.Nhom_Tivi = Tivi.Nhom_Tivi;

        });
        return Du_lieu_Phan_he;
    }
    // Tính toán
    public long Tinh_So_luong_Ton_Tivi(XL_TIVI Tivi)
    {
        var Tong_Nhap = Tivi.Danh_sach_Nhap_hang.Sum(Nhap_hang => Nhap_hang.So_luong);
        var Tong_Ban = Tivi.Danh_sach_Ban_hang.Sum(Ban_hang => Ban_hang.So_luong);
        var So_luong_Ton = Tong_Nhap - Tong_Ban;
        return So_luong_Ton;
    }
    public long Tinh_Doanh_thu_Tivi(XL_TIVI Tivi, DateTime Ngay)
    {
        var Danh_sach_Ban_hang_Ngay = Tivi.Danh_sach_Ban_hang.FindAll(Ban_hang =>
                    Ban_hang.Ngay.Day == Ngay.Day && Ban_hang.Ngay.Month == Ngay.Month && Ban_hang.Ngay.Year == Ngay.Year);
        var Doanh_thu = Danh_sach_Ban_hang_Ngay.Sum(Ban_hang => Ban_hang.Tien);
        return Doanh_thu;
    }

}
//************************* Data-Layers DL **********************************
public partial class XL_DU_LIEU
{
    static DirectoryInfo Thu_muc_Project = new DirectoryInfo(HostingEnvironment.ApplicationPhysicalPath);
    static DirectoryInfo Thu_muc_Du_lieu = Thu_muc_Project.GetDirectories("2-Du_lieu_luu_tru")[0];
    static DirectoryInfo Thu_muc_Cua_hang = Thu_muc_Du_lieu.GetDirectories("Cua_hang")[0];
    static DirectoryInfo Thu_muc_Tivi = Thu_muc_Du_lieu.GetDirectories("Tivi")[0];
    //******** Ghi *******
    static List<XL_CUA_HANG> Doc_Danh_sach_Cua_hang()
    {
        var Danh_sach_Cua_hang = new List<XL_CUA_HANG>();
        var Danh_sach_Tap_tin = Thu_muc_Cua_hang.GetFiles("*.json").ToList();
        Danh_sach_Tap_tin.ForEach(Tap_tin =>
        {
            var Duong_dan = Tap_tin.FullName;
            var Chuoi_JSON = File.ReadAllText(Duong_dan);
            var Cua_hang = Json.Decode<XL_CUA_HANG>(Chuoi_JSON);
            Danh_sach_Cua_hang.Add(Cua_hang);
        });
        return Danh_sach_Cua_hang;
    }
    static List<XL_TIVI> Doc_Danh_sach_Tivi()
    {
        var Danh_sach_Tivi = new List<XL_TIVI>();
        var Danh_sach_Tap_tin = Thu_muc_Tivi.GetFiles("*.json").ToList();
        Danh_sach_Tap_tin.ForEach(Tap_tin =>
        {
            var Duong_dan = Tap_tin.FullName;
            var Chuoi_JSON = File.ReadAllText(Duong_dan);
            var Tivi = Json.Decode<XL_TIVI>(Chuoi_JSON);
            Danh_sach_Tivi.Add(Tivi);
        });
        return Danh_sach_Tivi;
    }

    //******** Ghi *******
    public string Ghi_Nhap_hang_Moi(XL_TIVI Tivi, XL_NHAP_HANG Nhap_hang)
    {
        var Kq = "";
        Tivi.Danh_sach_Nhap_hang.Add(Nhap_hang);
        Kq = Ghi_Tivi(Tivi);
        if (Kq != "OK")
            Tivi.Danh_sach_Nhap_hang.Remove(Nhap_hang);
        return Kq;
    }
    public string Ghi_Ban_hang_Moi(XL_TIVI Tivi, XL_BAN_HANG Ban_hang)
    {
        var Kq = "";
        Tivi.Danh_sach_Ban_hang.Add(Ban_hang);
        Kq = Ghi_Tivi(Tivi);
        if (Kq != "OK")
            Tivi.Danh_sach_Ban_hang.Remove(Ban_hang);
        return Kq;
    }
    public string Cap_nhat_Don_gia_Nhap(XL_TIVI Tivi, long Don_gia_Nhap)
    {
        var Kq = "";
        var Don_gia_Nhap_Goc = Tivi.Don_gia_Nhap;// Tại sao cần lệnh này ???
        Tivi.Don_gia_Nhap = Don_gia_Nhap;
        Kq = Ghi_Tivi(Tivi);
        if (Kq != "OK")
            Tivi.Don_gia_Nhap = Don_gia_Nhap_Goc;
        return Kq;
    }
    public string Cap_nhat_Don_gia_Ban(XL_TIVI Tivi, long Don_gia_Ban)
    {
        var Kq = "";
        var Don_gia_Ban_Goc = Tivi.Don_gia_Ban;
        Tivi.Don_gia_Nhap = Don_gia_Ban;
        Kq = Ghi_Tivi(Tivi);
        if (Kq != "OK")
            Tivi.Don_gia_Ban = Don_gia_Ban_Goc;
        return Kq;
    }
    string Ghi_Tivi(XL_TIVI Tivi)
    {
        var Kq = "";
        var Duong_dan = $"{Thu_muc_Tivi.FullName}\\{Tivi.Ma_so}.json";
        var Chuoi_JSON = Json.Encode(Tivi);
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

}