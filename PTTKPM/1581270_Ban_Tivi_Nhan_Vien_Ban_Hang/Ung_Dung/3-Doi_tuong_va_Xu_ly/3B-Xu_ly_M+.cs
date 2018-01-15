using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Helpers;
using System.Web.Hosting;
using System.Globalization;
using System.Net;
//************************* M+ (Model for All ) **********************************
public partial class XL_DU_LIEU
{

    public static XL_DU_LIEU Khoi_dong_Du_lieu_Ung_dung()
    {
        var Du_lieu_Ung_dung = Doc_Du_lieu();// Tạm thời chưa Caching
        
        return Du_lieu_Ung_dung;
    }
}
//************************* View-Layers/Presentation Layers VL/PL **********************************
public partial class XL_DU_LIEU
{    
    public  string Dia_chi_Media = $"{Dia_chi_Dich_vu}/Media";
    public  CultureInfo Dinh_dang_VN = CultureInfo.GetCultureInfo("vi-VN");

    public  string Tao_Chuoi_HTML_Danh_sach_Tivi(List<XL_TIVI> Danh_sach)
    {
        var Chuoi_HTML_Danh_sach = "<div class='row'>";
        Danh_sach.ForEach(Tivi =>
        {
            var So_luong_Ton = Tinh_So_luong_Ton_Tivi(Tivi);
            var Doanh_Thu = Tinh_Doanh_Thu(Tivi);
            var Chuoi_Hinh = $"<img src='{Dia_chi_Media}/{Tivi.Ma_so}.png' " +
                             "style='width:90px;height:90px;' />";
            
            var Chuoi_Thong_tin = $"<div class='btn' style='text-align:left'> " +
                          $"{Tivi.Ma_so}<br />" +
                          $"{Tivi.Ten}" +
                          $"<br />Đơn giá Bán { Tivi.Don_gia_Ban.ToString("n0", Dinh_dang_VN) }" +
                           $"<br />Số lượng Tồn { So_luong_Ton.ToString("n0", Dinh_dang_VN)}" +
                           $"<br />Doanh Thu { Doanh_Thu.ToString("n0", Dinh_dang_VN)}" +
                          $"</div>";
            var Chuoi_HTML = $"<div class='col-md-4' style='margin-bottom:10px' >" +
                               $"{Chuoi_Hinh}" + $"{Chuoi_Thong_tin}" +
                             "</div>";
            
            Chuoi_HTML_Danh_sach += Chuoi_HTML;
        });
        Chuoi_HTML_Danh_sach += "</div>";
        return Chuoi_HTML_Danh_sach;
    }
    public string Tao_Chuoi_HTML_Danh_Sach_Nhom_Tivi(List<XL_TIVI> Danh_sach_Tivi, List<XL_NHOM_TIVI> Danh_Sach_Nhom_Tivi)
    {
        var Chuoi_HTML = "<div class='row'>";
        Danh_Sach_Nhom_Tivi.ForEach(nhom =>
        {
            var TenNhom = nhom.Ten;
            var MaSo = nhom.Ma_so;
            long SoLuongTon = 0;
            double DoanhThu = 0;
            Danh_sach_Tivi.ForEach(tivi =>
            {
                if (tivi.Nhom_Tivi.Ma_so == MaSo)
                {
                    DoanhThu = DoanhThu + Tinh_Doanh_Thu(tivi);
                    SoLuongTon = SoLuongTon + Tinh_So_luong_Ton_Tivi(tivi);
                }
            });

            var Chuoi_Thong_tin = $"<div class='col-12'>Nhóm {TenNhom} | Tồn kho: {SoLuongTon} | Doanh thu: {DoanhThu} </div>";

            Chuoi_HTML += Chuoi_Thong_tin;

        });
        Chuoi_HTML += "</div>";
        return Chuoi_HTML;
    }

    public string Tao_Chuoi_HTML_Danh_Sach_Nhan_Vien_Ban_Hang(List<XL_TIVI> Danh_sach_Tivi, List<XL_NHAN_VIEN> Danh_Sach_Nhan_Vien)
    {

        var Chuoi_HTML = $"<div class='row'>";
        Danh_Sach_Nhan_Vien.ForEach(nv =>
        {
            var HoTen = nv.Ho_ten;
            double DoanhThu = 0;
            List<XL_NHOM_TIVI> Danh_Sach_Nhom_Tivi = nv.Danh_sach_Nhom_Tivi;
            Danh_sach_Tivi.ForEach(tivi =>
            {
                if (Danh_Sach_Nhom_Tivi.FindIndex(nhom => nhom.Ma_so == tivi.Nhom_Tivi.Ma_so) > -1)
                {
                    DoanhThu += Tinh_Doanh_Thu(tivi);
                }
            });
            var Chuoi_Thong_Tin = $"<div class='col-12'>Họ tên: {HoTen} | Doanh Thu: {DoanhThu} </div>";

            Chuoi_HTML += Chuoi_Thong_Tin;

        });
        Chuoi_HTML += "</div>";
        return Chuoi_HTML;

    }

    public string Tao_Chuoi_HTML_Thong_Tin_Cong_Ty(List<XL_TIVI> Danh_sach_Tivi)
    {
        var Chuoi_HTML = "<div class='row'>";
        double DoanhThu = 0;
        long SoTon = 0;
        Danh_sach_Tivi.ForEach(tivi =>
        {            
            DoanhThu += Tinh_Doanh_Thu(tivi);
            SoTon += Tinh_So_luong_Ton_Tivi(tivi);
        });
        var Chuoi_Thong_Tin = $"<div class='col-12'>Số lượng tồn: {SoTon} | Doanh Thu: {DoanhThu} </div>";
        Chuoi_HTML += Chuoi_Thong_Tin;
        Chuoi_HTML += "</div>";
        return Chuoi_HTML;

    }

    public string Tao_Chuoi_HTML_Doanh_Thu_Nhan_Vien(List<XL_TIVI> Danh_sach_Tivi, XL_NHAN_VIEN NhanVien)        
    {
        var Chuoi_HTML = "<div class='row'>";
        var TenNhanVien = NhanVien.Ho_ten;
        double DoanhThu = 0;
        List<XL_NHOM_TIVI> Danh_Sach_Nhom_Tivi = NhanVien.Danh_sach_Nhom_Tivi;
        Danh_sach_Tivi.ForEach(tivi =>
        {
            if (Danh_Sach_Nhom_Tivi.FindIndex(nhom => nhom.Ma_so == tivi.Nhom_Tivi.Ma_so) > -1)
            {
                DoanhThu += Tinh_Doanh_Thu(tivi);
            }
        });
        var Chuoi_Thong_tin = $"<div class='col-12'>Nhân viên:  {TenNhanVien} | Doanh thu: {DoanhThu} </div>";
        Chuoi_HTML += Chuoi_Thong_tin;
        Chuoi_HTML += "</div>";
        return Chuoi_HTML;
    }
}
//************************* Business-Layers BL **********************************
public partial class XL_DU_LIEU
{   // Lưu ý PET : Chỉ sử dụng khi đã có Đối tượng Du_lieu ( sau khi khởi động)
    public   List<XL_TIVI> Tra_cuu_Tivi(
         string Chuoi_Tra_cuu, List<XL_TIVI> Danh_sach)
    {
        Danh_sach = Danh_sach.FindAll(
              Tivi => Tivi.Ten.ToUpper().Contains(Chuoi_Tra_cuu.ToUpper()));
        return Danh_sach;
    }
    public long Tinh_So_luong_Ton_Tivi(XL_TIVI Tivi)
    {
        var Tong_Nhap = Tivi.Danh_sach_Nhap_hang.Sum(Nhap_hang => Nhap_hang.So_luong);
        var Tong_Ban = Tivi.Danh_sach_Ban_hang.Sum(Ban_hang => Ban_hang.So_luong);
        var So_luong_Ton = Tong_Nhap - Tong_Ban;
        return So_luong_Ton;
    }
    public double Tinh_Doanh_Thu(XL_TIVI Tivi)
    {
        return Tivi.Danh_sach_Ban_hang.Sum(Ban_Hang => Ban_Hang.Tien);
    }

}
//************************* Data-Layers DL **********************************
public partial class XL_DU_LIEU
{
    static string Dia_chi_Dich_vu = "http://localhost:50900";
    static string Dia_chi_Dich_vu_Du_lieu = $"{Dia_chi_Dich_vu}/1-Dich_vu_Giao_tiep/DV_Chinh.cshtml";

    static XL_DU_LIEU Doc_Du_lieu()
    {
         
        var Xu_ly = new WebClient();
        Xu_ly.Encoding = System.Text.Encoding.UTF8;
        var Tham_so = "Ma_so_Xu_ly=DOC_DU_LIEU";
        var Dia_chi_Xu_ly = $"{Dia_chi_Dich_vu_Du_lieu}?{Tham_so}";
        var Chuoi_JSON = Xu_ly.DownloadString(Dia_chi_Xu_ly);
        var Du_lieu = Json.Decode<XL_DU_LIEU>(Chuoi_JSON);
        return Du_lieu;
    }
    public string Ghi_Ban_hang_Moi(XL_TIVI Tivi, XL_BAN_HANG Ban_Hang)
    {
        var Kq = "";
        var Xu_ly = new WebClient();
        Xu_ly.Encoding = System.Text.Encoding.UTF8;
        var Tham_so = $"Ma_so_Xu_ly=GHI_BAN_HANG_MOI&Ma_so_Tivi={Tivi.Ma_so}";
        var Dia_chi_Xu_ly = $"{Dia_chi_Dich_vu_Du_lieu}?{Tham_so}";
        var Chuoi_JSON = Json.Encode(Ban_Hang);
        try
        {
            Kq = Xu_ly.UploadString(Dia_chi_Xu_ly, Chuoi_JSON).Trim();
        }
        catch (Exception Loi)
        {
            Kq = Loi.Message;
        }
        if (Kq == "OK")
        {
            Tivi.Danh_sach_Ban_hang.Add(Ban_Hang);

        }
        return Kq;

    }


}