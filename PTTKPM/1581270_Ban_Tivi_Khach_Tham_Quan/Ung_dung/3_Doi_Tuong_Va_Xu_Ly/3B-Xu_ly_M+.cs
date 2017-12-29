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

    public static XL_DU_LIEU Khoi_dong_Du_lieu_Ung_dung()
    {
        var Du_lieu_Ung_dung = new XL_DU_LIEU();
        Du_lieu_Ung_dung.Danh_sach_Mat_hang = Doc_Danh_sach_Mat_hang();// Tạm thời chưa Caching
        return Du_lieu_Ung_dung;
    }
}
//************************* View-Layers/Prsenetaition VL/PL **********************************
public partial class XL_DU_LIEU
{   // Lưu ý PET : Chỉ sử dụng khi đã có Đối tượng Du_lieu ( sau khi khởi động)
    public  string Dia_chi_Media = $"../4_Media";
    public  CultureInfo Dinh_dang_VN = CultureInfo.GetCultureInfo("vi-VN");

    public  string Tao_Chuoi_HTML_Danh_sach_Mat_hang(List<XL_MAT_HANG> Danh_sach)
    {
        var Chuoi_HTML_Danh_sach = "<div class='row'>";
        Danh_sach.ForEach(Mat_hang =>
        {
            var Chuoi_Hinh = $"<img class='SAN_PHAM' src='{Dia_chi_Media}/{Mat_hang.Ma_so}.png' />";
                             
            var Chuoi_Thong_tin = $"<div class='btn' class='THONG_TIN_SAN_PHAM'> " +
                          $"{Mat_hang.Ten}" +
                          $"<br />Đơn giá Bán { Mat_hang.Don_gia_Ban.ToString("n0", Dinh_dang_VN) }" +
                          $"</div>";
            var Chuoi_HTML = $"<div class='col-md-2 box' >" +
                               $"{Chuoi_Hinh}" + $"{Chuoi_Thong_tin}" +
                             "</div>";
            Chuoi_HTML_Danh_sach += Chuoi_HTML;
        });
        Chuoi_HTML_Danh_sach += "</div>";
        return Chuoi_HTML_Danh_sach;
    }


}
//************************* Business-Layers BL **********************************
public partial class XL_DU_LIEU
{   // Lưu ý PET : Chỉ sử dụng khi đã có Đối tượng Du_lieu ( sau khi khởi động)
    public   List<XL_MAT_HANG> Tra_cuu_Mat_hang(
         string Chuoi_Tra_cuu, List<XL_MAT_HANG> Danh_sach)
    {
        Danh_sach = Danh_sach.FindAll(
              Mat_hang => Mat_hang.Ten.ToUpper().Contains(Chuoi_Tra_cuu.ToUpper()));
        return Danh_sach;
    }
}
//************************* Data-Layers DL **********************************
public partial class XL_DU_LIEU
{   // Lưu ý PET : Chỉ sử dụng Cục bộ bên trong Đối tượng Du_lieu ==> Dễ thay thế 
    static DirectoryInfo Thu_muc_Project = new DirectoryInfo(HostingEnvironment.ApplicationPhysicalPath);
    static DirectoryInfo Thu_muc_Du_lieu = Thu_muc_Project.GetDirectories("2_Du_Lieu")[0];    
    static List<XL_MAT_HANG> Doc_Danh_sach_Mat_hang()
    {
        var Danh_sach_Mat_hang = new List<XL_MAT_HANG>();
        var Danh_sach_Tap_tin = Thu_muc_Du_lieu.GetFiles("*.json").ToList();
        Danh_sach_Tap_tin.ForEach(Tap_tin =>
        {
            var Duong_dan = Tap_tin.FullName;
            var Chuoi_JSON = File.ReadAllText(Duong_dan);
            var Mat_hang = Json.Decode<XL_MAT_HANG>(Chuoi_JSON);
            Danh_sach_Mat_hang.Add(Mat_hang);
        });
        return Danh_sach_Mat_hang;
    }

}