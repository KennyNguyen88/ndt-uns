using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Helpers;
using System.Web.Hosting;
using System.Globalization;
using System.Net;
using System.Drawing;
using System.Drawing.Imaging;

public partial class XL_UNG_DUNG
{
    static XL_UNG_DUNG Ung_dung = null;

    XL_DU_LIEU Du_lieu_Ung_dung = null;
    List<XL_NGUOI_DUNG> Danh_sach_Nguoi_dung = new List<XL_NGUOI_DUNG>();
    
    public static XL_UNG_DUNG Khoi_dong_Ung_dung()
    {   if (Ung_dung == null)
        {
             Ung_dung = new XL_UNG_DUNG();
            Ung_dung.Khoi_dong_Du_lieu_Ung_dung();
        }
       
        return  Ung_dung;
    }
    void Khoi_dong_Du_lieu_Ung_dung()
    {
        var Du_lieu_tu_Dich_vu = XL_DU_LIEU.Doc_Du_lieu();
        Du_lieu_Ung_dung = Du_lieu_tu_Dich_vu;
        //Bổ sung Thông tin 
        Danh_sach_Nguoi_dung = Du_lieu_Ung_dung.Danh_sach_Nguoi_dung;
        Danh_sach_Nguoi_dung.ForEach(Nguoi_dung =>
        {
            Nguoi_dung.Danh_sach_Mon_an = Du_lieu_Ung_dung.Danh_sach_Mon_an.OrderBy(p => p.Ten).ToList(); ;//.FindAll(
                                                                        //Mon_an => Nguoi_dung.Danh_sach_Nhom_Mon_an.Any(Nhom_Mon_an => Nhom_Mon_an.Ma_so == Mon_an.Nhom_Mon_an.Ma_so)); ;
            Nguoi_dung.Danh_sach_Thuc_don = Du_lieu_Ung_dung.Nha_hang.Danh_sach_Thuc_don.OrderBy(p => p.Ten).ToList();
        });
    }  
    public XL_NGUOI_DUNG Dang_nhap(string Ten_Dang_nhap, string Mat_khau)
    {
        var Nguoi_dung = Danh_sach_Nguoi_dung.FirstOrDefault(
                                x => x.Ten_Dang_nhap == Ten_Dang_nhap
                                      && x.Mat_khau == Mat_khau 
                                      && x.Nhom_Nguoi_dung.Ma_so=="NHAN_VIEN_QUAN_LY");

        if (Nguoi_dung != null)
        {
            
            HttpContext.Current.Session["Nguoi_dung_Dang_nhap"] = Nguoi_dung;
        }
           
        return Nguoi_dung;
    }
    // Xử lý Chức năng của Người dùng Đăng nhập :
    public string Khoi_dong_MH_Chinh()
    {
        var Nguoi_dung_Dang_nhap = (XL_NGUOI_DUNG)HttpContext.Current.Session["Nguoi_dung_Dang_nhap"];
        Nguoi_dung_Dang_nhap.Thong_bao = "";
        Nguoi_dung_Dang_nhap.Danh_sach_Mon_an_Xem = Nguoi_dung_Dang_nhap.Danh_sach_Mon_an.OrderBy(p => p.Ten).ToList(); ;
        var Chuoi_HTML = Tao_Chuoi_HTML_Xem();
        return Chuoi_HTML;
    }
    public string Chon_Thuc_don(string Ma_so_Thuc_don)
    {
        var Nguoi_dung_Dang_nhap = (XL_NGUOI_DUNG)HttpContext.Current.Session["Nguoi_dung_Dang_nhap"];
        // Có thể thay đổi ( nếu muốn ) Nguoi_dung_Dang_nhap.Thong_bao  
        Nguoi_dung_Dang_nhap.Danh_sach_Mon_an_Xem =  Tra_cuu_Mon_an(Ma_so_Thuc_don, Nguoi_dung_Dang_nhap.Danh_sach_Mon_an);
        var Chuoi_HTML = Tao_Chuoi_HTML_Xem();
        return Chuoi_HTML;
    }
    public string Tra_cuu(string Chuoi_Tra_cuu)
    {
        var Nguoi_dung_Dang_nhap = (XL_NGUOI_DUNG)HttpContext.Current.Session["Nguoi_dung_Dang_nhap"];
        // Có thể thay đổi ( nếu muốn ) Nguoi_dung_Dang_nhap.Thong_bao  
        Nguoi_dung_Dang_nhap.Danh_sach_Mon_an_Xem =  Tra_cuu_Mon_an(Chuoi_Tra_cuu , Nguoi_dung_Dang_nhap.Danh_sach_Mon_an);
        var Chuoi_HTML = Tao_Chuoi_HTML_Xem();
        return Chuoi_HTML;
    }
    public XL_MONAN Tra_cuu_Mon_an_theo_Ma_so(string Ma_so_Mon_an)
    {
        var Nguoi_dung_Dang_nhap = (XL_NGUOI_DUNG)HttpContext.Current.Session["Nguoi_dung_Dang_nhap"];
        // Có thể thay đổi ( nếu muốn ) Nguoi_dung_Dang_nhap.Thong_bao  
        return Tra_cuu_Mon_an_theo_Ma_so(Ma_so_Mon_an, Nguoi_dung_Dang_nhap.Danh_sach_Mon_an);
    }

    //======= 
    public string Tao_Chuoi_HTML_Xem()
    {
        var Nguoi_dung_Dang_nhap = (XL_NGUOI_DUNG)HttpContext.Current.Session["Nguoi_dung_Dang_nhap"];
        var Chuoi_HTML = $"<div>" +
                 $"{ Tao_Chuoi_HTML_Nguoi_dung_Dang_nhap()}" +
                 $"{ Tao_Chuoi_HTML_Chuc_Nang()}" + 
                 $"{ Tao_Chuoi_HTML_Thong_bao()}" +
                 $"{ Tao_Chuoi_HTML_Danh_sach_Thuc_don_Xem(Nguoi_dung_Dang_nhap.Danh_sach_Thuc_don.OrderBy(p=>p.Ten).ToList())}" +
                 $"{ Tao_Chuoi_HTML_Danh_sach_Mon_an_Xem()}" +
             $"</div>";
        return Chuoi_HTML;
    }

    //public string Tao_Chuoi_HTML_Xin_chao()
    //{
    //    var Nguoi_dung_Dang_nhap = (XL_NGUOI_DUNG)HttpContext.Current.Session["Nguoi_dung_Dang_nhap"];
    //    var Chuoi_HTML = $"<div>" +
    //             $"{ Tao_Chuoi_HTML_Nguoi_dung_Dang_nhap()}" +
    //         $"</div>";
    //    return Chuoi_HTML;
    //}
}

//************************* View-Layers/Presentation Layers VL/PL **********************************
public partial class XL_UNG_DUNG
{    
    public  string Dia_chi_Media = $"{XL_DU_LIEU.Dia_chi_Dich_vu}/Media";
    public  CultureInfo Dinh_dang_VN = CultureInfo.GetCultureInfo("vi-VN");
    public string Tao_Chuoi_HTML_Thong_bao()
    {
        var Chuoi_HTML = "";
        var Nguoi_dung_Dang_nhap = (XL_NGUOI_DUNG)HttpContext.Current.Session["Nguoi_dung_Dang_nhap"];
        if (Nguoi_dung_Dang_nhap.Thong_bao != "")
            Chuoi_HTML = $"<div class='alert alert-info'>" +
                $"{Nguoi_dung_Dang_nhap.Thong_bao}" +
                $"</div>";
        return Chuoi_HTML;

    }
    public string Tao_Chuoi_HTML_Nguoi_dung_Dang_nhap( )
    {
        var Nguoi_dung_Dang_nhap = (XL_NGUOI_DUNG)HttpContext.Current.Session["Nguoi_dung_Dang_nhap"];
        var r = new Random(); var randomNumber = r.Next();

        var Chuoi_Hinh = $"<img src='{Dia_chi_Media}/{Nguoi_dung_Dang_nhap.Ma_so}.png?{randomNumber.ToString()}' " +
                 "style='width:50px;height:50px;float:left;' />";
        var Chuoi_Thong_tin = $"<div class='btn' style='text-align:left;margin-right:400px;'> " +
                       $"Xin chào {Nguoi_dung_Dang_nhap.Nhom_Nguoi_dung.Ten }" +
                       $"<br /><b>{Nguoi_dung_Dang_nhap.Ho_ten}</b>" +
                      //$"<br />Doanh thu {Nguoi_dung_Dang_nhap.Doanh_thu }" +
                      $"</div>";
        var Chuoi_Chuc_nang_Chon = "";
                        //$"<button class='btn btn-danger'>" +
                        //$"Thêm mới món ăn</button>";

        var Chuoi_HTML = $"<div >" +
                           $"{Chuoi_Hinh}" + $"{Chuoi_Thong_tin}" +
                           $"{Chuoi_Chuc_nang_Chon}" +
                          $"</div>";
        return Chuoi_HTML ;
    }
    public string Tao_Chuoi_HTML_Image(string Ma_so, string imageType)
    {
        return $"{Dia_chi_Media}/{Ma_so}.{imageType}";
    }
    public string Tao_Chuoi_HTML_Chuc_Nang()
    {
        var Nguoi_dung_Dang_nhap = (XL_NGUOI_DUNG)HttpContext.Current.Session["Nguoi_dung_Dang_nhap"];

        var Chuoi_HTML = $"<div class='CUA_SO_CHUC_NANG' style='background-color:gray;'>" +
         $"<div class='DANH_SACH_CHUC_NANG'>" +
         $"<div class='btn  CHUC_NANG'>" +
         $"<form method ='post'>" +
         $"<input name='Th_Ma_so_Chuc_nang' type='hidden' value='{Nguoi_dung_Dang_nhap.Chuc_nang_Chon_Cap_Nhat_Ho_So.Ma_so}' />" +
         $"<button type = 'submit' class='btn btn-primary'>Cập nhật Hồ Sơ</button>" +
         $"</form>" +
         $"</div>" +
         $"<div class='btn  CHUC_NANG'>" +
         $"<form method = 'post'>" +
         $"<input name='Th_Ma_so_Chuc_nang' type='hidden' value='{Nguoi_dung_Dang_nhap.Chuc_nang_Chon_Xem_Mon_An_Theo_Thuc_Don.Ma_so}' />" +
         $"<button type = 'submit' class='btn btn-primary'>Xem Món Ăn theo Thực đơn</button>" +
         $"</form>" +
         $"</div>" +
         $"<div class='btn  CHUC_NANG'>" +
         $"<form method = 'post'>" +
         $"<input name='Th_Ma_so_Chuc_nang' type='hidden' value='{Nguoi_dung_Dang_nhap.Chuc_nang_Chon_THEM_MOI_MON_AN.Ma_so}' />" +
         $"<button type = 'submit' class='btn btn-primary'>Thêm mới Món Ăn</button>" +
         $"</form>" +
         $"</div>" +
         $"</div>" +
         $"</div>";
        return Chuoi_HTML;
    }

    public  string Tao_Chuoi_HTML_Danh_sach_Mon_an_Xem()
    {
        var Nguoi_dung_Dang_nhap = (XL_NGUOI_DUNG)HttpContext.Current.Session["Nguoi_dung_Dang_nhap"];
        var Danh_sach = Nguoi_dung_Dang_nhap.Danh_sach_Mon_an_Xem;
        var Chuoi_HTML_Danh_sach = "<div class='row'>";
        //Chuoi_HTML_Danh_sach += "cvdvcdvds<br />";

        Danh_sach.ForEach(Mon_an =>
        {
            var r = new Random(); var randomNumber = r.Next();

            var Chuoi_Hinh = $"<img src='{Dia_chi_Media}/{Mon_an.Ma_so}.jpg?{randomNumber.ToString()}' " +
                             "style='width:100px;height:100px; margin-left:5px;' />";
            
            var Chuoi_Thong_tin = $"<div class='btn' style='text-align:left;height:100px;'> " +
                          $"<div style='width:280px;word-break:keep-all;white-space:normal;'>{Mon_an.Ten}</div>" +
                          $"<br />Đơn giá Bán { Mon_an.Don_gia_Ban.ToString("n0", Dinh_dang_VN) }" +
                          $"</div>";
            var Chuoi_Chuc_nang_Ban_1_Mon_an = $"<form method='post'>   " +
                                     $"<input name='Th_Ma_so_Chuc_nang' type='hidden' value='{Nguoi_dung_Dang_nhap.Chuc_nang_Chon_Cap_Nhat_Mon_An.Ma_so}' />  " +
                                    $"<input name='Th_Ma_so_Mon_an' type='hidden' value='{Mon_an.Ma_so}' />  " +
                                     $"<input name='Th_Ma_so_Thuc_don' type='hidden' value='{Mon_an.Thuc_don.Ma_so}' />" +
                                    $"<button type='submit' class='btn btn-primary btn-sm' style='margin:5px;'>" +
                                    $"Cập nhật thông tin" +
                                     $"</button>" +
                                 $"</form>";
            var Chuoi_HTML = $"<div class='col-md-4' style='margin-bottom:10px' >" +
                               $"{Chuoi_Hinh}" + $"{Chuoi_Thong_tin}" +
                                $"{Chuoi_Chuc_nang_Ban_1_Mon_an}"+
                             "</div>";
            Chuoi_HTML_Danh_sach += Chuoi_HTML;
        });
        Chuoi_HTML_Danh_sach += "</div>";
        return Chuoi_HTML_Danh_sach;
    }
    public  string Tao_Chuoi_HTML_Danh_sach_Thuc_don_Xem(List<XL_THUCDON> Danh_sach)
    {
        var Nguoi_dung_Dang_nhap = (XL_NGUOI_DUNG)HttpContext.Current.Session["Nguoi_dung_Dang_nhap"];

        var Chuoi_HTML_Danh_sach = "<br />Xin vui lòng chọn thực đơn muốn xem<br />";
         Chuoi_HTML_Danh_sach += "<div  style='background-color:darkgray;'>";
        
        Danh_sach.ForEach(Thuc_don =>
        {
            var Chuoi_Chuc_nang_Chon = $"<form method='post'>" +
                        $"<input name='Th_Ma_so_Chuc_nang' type='hidden' value='{Nguoi_dung_Dang_nhap.Chuc_nang_Chon_ThucDon.Ma_so}' />" +
                         $"<input name='Th_Ma_so_Thuc_don' type='hidden' value='{Thuc_don.Ma_so}' />" +
                         $"<button type='submit' class='btn btn-primary' >" +
                         $"{Thuc_don.Ten} " +
                         //$"{Thuc_don.Ten} {Thuc_don.So_luong_Ton}  {Thuc_don.Doanh_thu}  " +
                         $"</button>" +
                    "</form>";
            var Chuoi_Hinh = $"";
            var Chuoi_Thong_tin = $"<div  style='btn'> " +
                          $"{Chuoi_Chuc_nang_Chon}" +
                          $"</div>";
            var Chuoi_HTML = $"<div class='btn' style=' ' >" +
                               $"{Chuoi_Hinh}" + $"{Chuoi_Thong_tin}" +
                             "</div>";

            Chuoi_HTML_Danh_sach += Chuoi_HTML;
        });

        //Chuoi_HTML_Danh_sach += "<br />Danh sách món ăn - Thực đơn " + $"{Danh_sach.FirstOrDefault().Ten}";
        Chuoi_HTML_Danh_sach += "</div><br />";
        return Chuoi_HTML_Danh_sach;
    }

    public string Tao_Chuoi_HTML_Danh_sach_Thuc_don_Chon_Luu(List<XL_THUCDON> Danh_sach)
    {
       var Nguoi_dung_Dang_nhap = (XL_NGUOI_DUNG)HttpContext.Current.Session["Nguoi_dung_Dang_nhap"];


        var Chuoi_HTML_Danh_sach = "<select class='form-control' id='ddl_ThucDon' name='ddl_ThucDon'>";
        foreach (var item in Danh_sach)
        {
            Chuoi_HTML_Danh_sach += $"<option value='{item.Ma_so}'>{item.Ten}</option>";
        }

        //$"<option value ='1' >5-9</ option >" +
        //$"<option value ='2'>10-15</option>" +
        Chuoi_HTML_Danh_sach += $"</select>";
        Chuoi_HTML_Danh_sach += $"<input name='Th_Ma_so_Thuc_don' id='Th_Ma_so_Thuc_don' type='hidden' value='{Danh_sach.FirstOrDefault().Ma_so}' />";
        return Chuoi_HTML_Danh_sach;
    }

}
//************************* Business-Layers BL **********************************
public partial class XL_UNG_DUNG
{    
    public   List<XL_MONAN> Tra_cuu_Mon_an(
         string Chuoi_Tra_cuu, List<XL_MONAN> Danh_sach)
    {
        Danh_sach = Danh_sach.FindAll(
              MonAn => MonAn.Ten.ToUpper().Contains(Chuoi_Tra_cuu.ToUpper())
         || MonAn.Thuc_don.Ma_so==Chuoi_Tra_cuu);
        return Danh_sach.OrderBy(p=>p.Ten).ToList();
    }

    public XL_MONAN Tra_cuu_Mon_an_theo_Ma_so(
         string Ma_so_Mon_an, List<XL_MONAN> Danh_sach)
    {
        return Danh_sach.FirstOrDefault(
              MonAn =>  MonAn.Ma_so == Ma_so_Mon_an);
    }

    public void Cap_nhat_Nguoi_dung(string Ho_ten, string Mat_khau, string Img_Base64String)
    {
        var NguoiDung = (XL_NGUOI_DUNG)HttpContext.Current.Session["Nguoi_dung_Dang_Nhap"];  //Danh_sach_Nguoi_dung.FirstOrDefault(x => x.Ma_so == Ma_so_Nguoi_dung);
        XL_DU_LIEU.Cap_nhat_Nguoi_dung(NguoiDung, Ho_ten, Mat_khau, Img_Base64String);
    }

    public void Cap_nhat_Thong_tin_Mon_an(long Don_gia_Nhap, long Don_gia_Ban, string Ten, string Trang_Thai, string Img_Base64String)
    {
        var MonAn = (XL_MONAN)HttpContext.Current.Session["Mon_an_Chon"];
        XL_DU_LIEU.Cap_nhat_Thong_tin_Mon_an(MonAn, Don_gia_Nhap, Don_gia_Ban, Ten, Trang_Thai, Img_Base64String);
    }
    public string Them_moi_Mon_an(XL_MONAN Mon_an, string Img_Base64String)
    {
        var NguoiDung = (XL_NGUOI_DUNG)HttpContext.Current.Session["Nguoi_dung_Dang_Nhap"];
        string kq =  XL_DU_LIEU.Them_moi_Mon_an(Mon_an, Img_Base64String);
        if (kq.Contains(":OK"))
        {
            NguoiDung.Danh_sach_Mon_an.Add(Mon_an);
            NguoiDung.Danh_sach_Mon_an.OrderBy(p => p.Ten).ToList();
        }
        return kq;
    }

}
//************************* Data-Layers DL **********************************
public partial class XL_DU_LIEU
{
    public static string Dia_chi_Dich_vu = "http://localhost:53850";
    static string Dia_chi_Dich_vu_Du_lieu = $"{Dia_chi_Dich_vu}/1-Dich_vu_Giao_tiep/DV_Chinh.cshtml";

    public static XL_DU_LIEU Doc_Du_lieu()
    {
         
        var Xu_ly = new WebClient();
        Xu_ly.Encoding = System.Text.Encoding.UTF8;
        var Tham_so = "Ma_so_Xu_ly=KHOI_DONG_DU_LIEU_QUAN_LY";
        var Dia_chi_Xu_ly = $"{Dia_chi_Dich_vu_Du_lieu}?{Tham_so}";
        var Chuoi_JSON = Xu_ly.DownloadString(Dia_chi_Xu_ly);
        var Du_lieu = Json.Decode<XL_DU_LIEU>(Chuoi_JSON);
        return Du_lieu;
    }

    //20180327 - Truong - Create Function "ImageToBase64"
    public static string ImageToBase64(string imageURL, ImageFormat format)
    {
        string base64String;
        using (System.Drawing.Image image = System.Drawing.Image.FromFile(imageURL))
        {
            using (MemoryStream m = new MemoryStream())
            {
                image.Save(m, image.RawFormat);
                byte[] imageBytes = m.ToArray();
                base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
    }

    public static string Cap_nhat_Nguoi_dung(XL_NGUOI_DUNG Nguoi_dung, string Ho_ten, string Mat_khau, string Img_Base64String)
    {
        var Kq = "";
        byte[] imgByte = null;
        if (!string.IsNullOrEmpty(Img_Base64String))
        {

            imgByte = Convert.FromBase64String(Img_Base64String);
        }

        var Xu_ly = new WebClient();
        Xu_ly.Encoding = System.Text.Encoding.UTF8;
        var Tham_so = $"Ma_so_Xu_ly=CAP_NHAT_NGUOI_DUNG&Ho_ten={Ho_ten}&mat_khau={Mat_khau}";
        var Dia_chi_Xu_ly = $"{Dia_chi_Dich_vu_Du_lieu}?{Tham_so}";
        var Chuoi_JSON = Json.Encode(Nguoi_dung);
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
            Nguoi_dung.Ho_ten = Ho_ten;
            Nguoi_dung.Mat_khau = Mat_khau;
            if (imgByte != null)
            {
                var Xu_ly_1 = new WebClient();
                var URL = $"Ma_so_Xu_ly=UPLOAD_IMAGE&Ma_so={Nguoi_dung.Ma_so}&imgType=png"; //avatar png, monan jpg
                var URL_PRC = $"{Dia_chi_Dich_vu_Du_lieu}?{URL}";
                Xu_ly_1.UploadDataAsync(new Uri(URL_PRC), "POST", imgByte);
            }
        }
        return Kq;
    }

    public static string Cap_nhat_Thong_tin_Mon_an(XL_MONAN Mon_an, long Don_gia_Nhap, long Don_gia_Ban, string Ten, string Trang_Thai, string Img_Base64String)
    {
        var Kq = "";
        byte[] imgByte = null;
        if (!string.IsNullOrEmpty(Img_Base64String))
        {

            imgByte = Convert.FromBase64String(Img_Base64String);
        }

        var Xu_ly = new WebClient();
        Xu_ly.Encoding = System.Text.Encoding.UTF8;
        var Tham_so = $"Ma_so_Xu_ly=CAP_NHAT_THONG_TIN_MON_AN&Ten={Ten}&Don_gia_Nhap={Don_gia_Nhap}&Don_gia_Ban={Don_gia_Ban}&Trang_Thai={Trang_Thai}";
        var Dia_chi_Xu_ly = $"{Dia_chi_Dich_vu_Du_lieu}?{Tham_so}";
        var Chuoi_JSON = Json.Encode(Mon_an);
        try
        {
            Kq = Xu_ly.UploadString(Dia_chi_Xu_ly, Chuoi_JSON).Trim();
            //Xu_ly.UploadData()
        }
        catch (Exception Loi)
        {
            Kq = Loi.Message;
        }
        if (Kq.Contains(":OK"))
        {
            Mon_an.Don_gia_Nhap = Don_gia_Nhap;
            Mon_an.Don_gia_Ban = Don_gia_Ban;
            Mon_an.Ten = Ten;
            //Mon_an.Trang_Thai = Trang_Thai;
            if (imgByte != null)
            {
                var Xu_ly_1 = new WebClient();
                var URL = $"Ma_so_Xu_ly=UPLOAD_IMAGE&Ma_so={Mon_an.Ma_so}&imgType=jpg"; //avatar png, monan jpg
                var URL_PRC = $"{Dia_chi_Dich_vu_Du_lieu}?{URL}";
                Xu_ly_1.UploadDataAsync(new Uri(URL_PRC), "POST", imgByte);
            }
        }
        return Kq;
    }

    public static string Them_moi_Mon_an(XL_MONAN Mon_an, string Img_Base64String)
    {
        var Kq = "";
        byte[] imgByte = null;
        if (!string.IsNullOrEmpty(Img_Base64String))
        {

            imgByte = Convert.FromBase64String(Img_Base64String);
        }

        var Xu_ly = new WebClient();
        Xu_ly.Encoding = System.Text.Encoding.UTF8;
        var Tham_so = $"Ma_so_Xu_ly=THEM_MOI_MON_AN";
        var Dia_chi_Xu_ly = $"{Dia_chi_Dich_vu_Du_lieu}?{Tham_so}";
        var Chuoi_JSON = Json.Encode(Mon_an);
        try
        {
            Kq = Xu_ly.UploadString(Dia_chi_Xu_ly, Chuoi_JSON).Trim();
            //Xu_ly.UploadData()
        }
        catch (Exception Loi)
        {
            Kq = Loi.Message;
        }
        if (Kq.Contains(":OK"))
        {
            if (imgByte != null)
            {
                Mon_an.Ma_so = Kq.Split(':')[0];
                
                var Xu_ly_1 = new WebClient();
                var URL = $"Ma_so_Xu_ly=UPLOAD_IMAGE&Ma_so={Mon_an.Ma_so}&imgType=jpg"; //avatar png, monan jpg
                var URL_PRC = $"{Dia_chi_Dich_vu_Du_lieu}?{URL}";
                Xu_ly_1.UploadDataAsync(new Uri(URL_PRC), "POST", imgByte);
            }
        }
        return Kq;
    }
    
}