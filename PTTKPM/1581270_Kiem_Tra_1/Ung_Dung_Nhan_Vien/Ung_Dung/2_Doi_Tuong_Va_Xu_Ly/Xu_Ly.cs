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

    public static XL_DU_LIEU Khoi_dong_Du_lieu_Ung_dung(String pMaNV)
    {
        //var Du_lieu_Ung_dung = Doc_Du_lieu(pMaNV);
        //return Du_lieu_Ung_dung;

        return new XL_DU_LIEU(); //for test
    }
}
//************************* View Layers/Presentation Layers  VL/PL **********************************
public partial class XL_DU_LIEU
{
    public string Dia_chi_Media = $"{Dia_chi_Dich_vu}/Media";
    public CultureInfo Dinh_dang_VN = CultureInfo.GetCultureInfo("vi-VN");
    
    public string Tao_Chuoi_HTML(XL_NHAN_VIEN NhanVien)
    {
        var Chuoi_HTML_Ho_Ten = "<p> Họ tên: " + NhanVien.Ho_ten + "</p>";
        //Hinh
        var Chuoi_HTML_Ten_Don_Vi = "<p> Tên Đơn Vị: " + NhanVien.Don_vi.Ten + "</p>";
        var Chuoi_HTML_Ten_Chi_Nhanh = "<p> Tên Chi Nhánh: " + NhanVien.Don_vi.Chi_nhanh.Ten + "</p>";


        var Chuoi_HTML_Ket_Qua = "<div class='row'>";
        
        Chuoi_HTML_Ket_Qua += Chuoi_HTML_Ho_Ten;
        Chuoi_HTML_Ket_Qua += Chuoi_HTML_Ten_Don_Vi;
        Chuoi_HTML_Ket_Qua += Chuoi_HTML_Ten_Chi_Nhanh;
        //Danh_sach.ForEach(Tivi =>
        //{

        //    var Chuoi_Hinh = $"<img src='{Dia_chi_Media}/{Tivi.Ma_so}.png' " +
        //                     "style='width:150px;height:150px;' />";
        //    var Trang_thai = "Còn hàng";
        //    if (!Tivi.Trang_thai_Con_hang)
        //        Trang_thai = "Vừa hết hàng !";
        //    var Chuoi_Thong_tin = $"<div class='btn' style='text-align:left'> " +
        //                  $"{Tivi.Ten}" + $"{Tivi.Ma_so}" +
        //                  $"<br />Đơn giá Bán { Tivi.Don_gia_Ban.ToString("n0", Dinh_dang_VN) }" +
        //                   $"<br />Trạng thái { Trang_thai}" +
        //                  $"</div>";
        //    var Chuoi_HTML = $"<div class='col-md-5' style='margin-bottom:10px' >" +
        //                       $"{Chuoi_Hinh}" + $"{Chuoi_Thong_tin}" +
        //                     "</div>";
        //    Chuoi_HTML_Danh_sach += Chuoi_HTML;
        //});

        Chuoi_HTML_Ket_Qua += "</div>";
        return Chuoi_HTML_Ket_Qua;
    }


}
//************************* Business-Layers BL **********************************

//************************* Data-Layers DL **********************************
public partial class XL_DU_LIEU
{
    static string Dia_chi_Dich_vu = "http://localhost:50900";
    static string Dia_chi_Dich_vu_Du_lieu = $"{Dia_chi_Dich_vu}/1-Dich_vu_Giao_tiep/DV_Chinh.cshtml";

    static XL_DU_LIEU Doc_Du_lieu(String pMaNV)
    {

        var Xu_ly = new WebClient();
        Xu_ly.Encoding = System.Text.Encoding.UTF8;
        var Tham_so = "Ma_so_Xu_ly=KHOI_DONG_DU_LIEU_KHACH_NHAN_VIEN?Ma_NV="+pMaNV;
        var Dia_chi_Xu_ly = $"{Dia_chi_Dich_vu_Du_lieu}?{Tham_so}";
        var Chuoi_JSON = Xu_ly.DownloadString(Dia_chi_Xu_ly);
        var Du_lieu = Json.Decode<XL_DU_LIEU>(Chuoi_JSON);
        return Du_lieu;
    }


}