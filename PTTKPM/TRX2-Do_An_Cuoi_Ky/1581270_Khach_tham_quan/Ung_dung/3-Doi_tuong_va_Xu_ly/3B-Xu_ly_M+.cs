using System.Collections.Generic;
using System.Web.Helpers;
using System.Globalization;
using System.Net;

public partial class XL_UNG_DUNG
{
    static XL_UNG_DUNG Ung_dung = null;

    XL_DU_LIEU Du_lieu_Ung_dung = null;    

    public static XL_UNG_DUNG Khoi_dong_Ung_dung()
    {
        Ung_dung = new XL_UNG_DUNG(); // Không caching 
        Ung_dung.Khoi_dong_Du_lieu_Ung_dung();
        return Ung_dung;
    }
    void Khoi_dong_Du_lieu_Ung_dung()
    {
        var Du_lieu_tu_Dich_vu = XL_DU_LIEU.Doc_Du_lieu();
        Du_lieu_Ung_dung = Du_lieu_tu_Dich_vu;
    }
    // Xử lý Chức năng 
    public string Khoi_dong_Danh_sach_Thuc_don()
    {
        List<XL_THUCDON> Danh_sach_Thuc_don = Du_lieu_Ung_dung.Nha_hang.Danh_sach_Thuc_don;
        Danh_sach_Thuc_don.ForEach(ThucDon =>
        {
            var Danh_sach_Mon_an_Cua_Thuc_Don = Du_lieu_Ung_dung.Danh_sach_Mon_an.FindAll(MonAn =>
                MonAn.Thuc_don.Ma_so.Equals(ThucDon.Ma_so)
            );
            ThucDon.Danh_sach_Mon_an = Danh_sach_Mon_an_Cua_Thuc_Don;
        });
        return Tao_Chuoi_HTML_Danh_sach_Thuc_don(Danh_sach_Thuc_don);       
    }

    public string Khoi_dong_Danh_sach_Mon_an()
    {
        List<XL_MONAN> Danh_sach_Mon_an = Du_lieu_Ung_dung.Danh_sach_Mon_an;
        return Tao_Chuoi_HTML_Danh_sach_Mon_an(Danh_sach_Mon_an);
    }
    
    public string Khoi_dong_Thong_tin_Lien_he()
    {
        return Tao_Chuoi_HTML_Thong_tin_Lien_he();
    }
}

//************************* View-Layers/Presentation Layers VL/PL **********************************
public partial class XL_UNG_DUNG
{
    public string Dia_chi_Media = $"{XL_DU_LIEU.Dia_chi_Dich_vu}/Media";
    public CultureInfo Dinh_dang_VN = CultureInfo.GetCultureInfo("vi-VN");

    public string Tao_Chuoi_HTML_Danh_sach_Thuc_don(List<XL_THUCDON> Danh_sach)
    {
    
        var Chuoi_HTML_Danh_sach = $"<ul><li class='filter' data-filter='*'>Tất Cả</li>";

        Danh_sach.ForEach(ThucDon =>
        {
            var Chuoi_HTML = $"<li class='filter' data-filter='.{ThucDon.Ma_so}'> {ThucDon.Ten} ({ThucDon.Danh_sach_Mon_an.Count})</li>";
            Chuoi_HTML_Danh_sach += Chuoi_HTML;
        });
        Chuoi_HTML_Danh_sach += $"</ul>";

        return Chuoi_HTML_Danh_sach;
    }

    public string Tao_Chuoi_HTML_Danh_sach_Mon_an(List<XL_MONAN> Danh_sach)
    {
        var Chuoi_HTML_Danh_sach = $"<div id='projects' class='gallery-col-4'>";

        Danh_sach.ForEach(MonAn =>
        {
            var Chuoi_HTML = $"<div class='gallery-items project-item {MonAn.Thuc_don.Ma_so}'>";
            Chuoi_HTML += $"<div class='gallery-item animated' data-animation='fadeInUp' data-animation-delay='600'>";
            Chuoi_HTML += $"<div class='gallery-item-inner effects clearfix effect1'>";
            Chuoi_HTML += $"<div class='img'>";
            Chuoi_HTML += $"<img src='{Dia_chi_Media}/{MonAn.Ma_so}.jpg' width='255' height='217' class='img-responsive'/>";
            Chuoi_HTML += $"</div>";
            Chuoi_HTML += $"<div class='item-details'>";
            Chuoi_HTML += $"<h5>{MonAn.Ten}</h5>";
            Chuoi_HTML += $"<div class='buy-now'>";
            Chuoi_HTML += $"<span>{MonAn.Don_gia_Ban} đ</span>";                        
            Chuoi_HTML += $"</div>";
            Chuoi_HTML += $"</div>";
            Chuoi_HTML += $"</div>";
            Chuoi_HTML += $"</div>";
            Chuoi_HTML += $"</div>";
            Chuoi_HTML_Danh_sach += Chuoi_HTML;
        });

        Chuoi_HTML_Danh_sach += $"</div>";
        return Chuoi_HTML_Danh_sach;
    }
    
    public string Tao_Chuoi_HTML_Thong_tin_Lien_he()
    {
        return $"<div class='copyright'> {Du_lieu_Ung_dung.Nha_hang.Ten} - {Du_lieu_Ung_dung.Nha_hang.Dia_chi} <br> {Du_lieu_Ung_dung.Nha_hang.Dien_thoai} - {Du_lieu_Ung_dung.Nha_hang.Mail} </div>";
    }
}
//************************* Business-Layers BL **********************************
//public partial class XL_UNG_DUNG
//{


//}
//************************* Data-Layers DL **********************************
public partial class XL_DU_LIEU
{
    public static string Dia_chi_Dich_vu = "http://localhost:53850";
    static string Dia_chi_Dich_vu_Du_lieu = $"{Dia_chi_Dich_vu}/1-Dich_vu_Giao_tiep/DV_Chinh.cshtml";

    public static XL_DU_LIEU Doc_Du_lieu()
    {

        var Xu_ly = new WebClient();
        Xu_ly.Encoding = System.Text.Encoding.UTF8;
        var Tham_so = "Ma_so_Xu_ly=KHOI_DONG_DU_LIEU_KHACH_THAM_QUAN";
        var Dia_chi_Xu_ly = $"{Dia_chi_Dich_vu_Du_lieu}?{Tham_so}";
        var Chuoi_JSON = Xu_ly.DownloadString(Dia_chi_Xu_ly);
        var Du_lieu = Json.Decode<XL_DU_LIEU>(Chuoi_JSON);
        return Du_lieu;
    }



}