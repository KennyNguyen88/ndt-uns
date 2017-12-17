using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

public partial class XL_THE_HIEN
{
    public static CultureInfo Dinh_dang_VN = CultureInfo.GetCultureInfo("vi-VN");
    // Thể hiện Đối tượng Người dùng khi Chào
    public static string Tao_Chuoi_HTML_Khach_Tham_quan_Khi_Chao(XL_KHACH_THAM_QUAN Khach_tham_quan)
    {
        var Chuoi_Hinh = $"<img src='../4_Media/{Khach_tham_quan.Ma_so}.png'  " + $"style='width:60px;height:60px;margin:5px;'  />";
        var Chuoi_Tom_tat = $"<div class='btn'> Xin chào {Khach_tham_quan.Ho_ten}" + $"</div>";
        var Chuoi_HTML = "<div class='btn' >"
              + $"{Chuoi_Hinh}"
              + $"{Chuoi_Tom_tat}"
              + "</div>";
        return Chuoi_HTML;
    }
    public static string Tao_Chuoi_HTML_Khach_hang_Khi_Chao(XL_KHACH_HANG Khach_hang)
    {
        var Chuoi_Hinh = $"<img src='../4_Media/{Khach_hang.Ma_so}.png'  " + $"style='width:60px;height:60px;margin:5px;'  />";
        var Chuoi_Tom_tat = $"<div class='btn'> Xin chào {Khach_hang.Ho_ten}" + $"</div>";
        var Chuoi_HTML = "<div class='btn' >"
              + $"{Chuoi_Hinh}"
              + $"{Chuoi_Tom_tat}"
              + "</div>";
        return Chuoi_HTML;
    }
    public static string Tao_Chuoi_HTML_Quan_ly_Khi_Chao(XL_QUAN_LY Quan_ly)
    {
        var Chuoi_Hinh = $"<img class='align-self-center mr-3' src='../4_Media/{Quan_ly.Ma_so}.png' style='width:60px;height:60px;margin:5px;'/> ";
        var HoTen = Quan_ly.Ho_ten.ToUpper();
        var LastestDangNhap = Quan_ly.Danh_sach_Dang_nhap.Last();
        var TongSoLanDangNhap = Quan_ly.Danh_sach_Dang_nhap.Count;

        var Chuoi_HTML = "<div class='media'>" + Chuoi_Hinh + "<div class='media-body'>" + $"<h5 class='mt-0'> {HoTen} </h5> <p> Tổng số lần đăng nhập: {TongSoLanDangNhap} </p> <p> Lần đăng nhập cuối cùng của bạn là <small> {LastestDangNhap} </small> </p> </div> </div>"; 
        return Chuoi_HTML;
    }
    public static string Tao_Chuoi_HTML_Nhan_vien_Khi_Chao(XL_NHAN_VIEN Nhan_vien)
    {
        var Chuoi_Hinh = $"<img src='../4_Media/{Nhan_vien.Ma_so}.png'  " + $"style='width:60px;height:60px;margin:5px;'  />";
        var Chuoi_HTML = "";
        var HoTen = Nhan_vien.Ho_ten.ToUpper();
        var LastestDangNhap = Nhan_vien.Danh_sach_Dang_nhap.Last();
        var TongSoLanDangNhap = Nhan_vien.Danh_sach_Dang_nhap.Count;

        Chuoi_HTML = Chuoi_Hinh + $"Xin Chào {HoTen} <br> Tổng số lần đăng nhập: {TongSoLanDangNhap} <br> Lần đăng nhập cuối cùng của bạn là <small> {LastestDangNhap} </small>";
        return Chuoi_HTML;
    }
    // Thể hiện Danh sách các Đối tượng 
    public static string Tao_Chuoi_HTML_Danh_sach_Nhom_hang(List<XL_NHOM_HANG> Danh_sach_Nhom_hang)
    {
        var Chuoi_HTML_Danh_sach = "<div>";
        Danh_sach_Nhom_hang.ForEach(Nhom_hang =>
        {
            var Chuoi_Hinh = $"<img src='../4_Media/{Nhom_hang.Ma_so}.png' " + "style='width:40px;height:40px;margin:5px;' />"; ;
            var Chuoi_Thong_tin = $"<div class='btn 'style='border:none'> " + $"{Nhom_hang.Ten}</div>";
            var Chuoi_HTML = "<div class='btn'  >" +
                                $"{Chuoi_Hinh}" + $"{Chuoi_Thong_tin}" +
                             "</div>";
            Chuoi_HTML_Danh_sach += Chuoi_HTML;
        });
        Chuoi_HTML_Danh_sach += "</div>";
        return Chuoi_HTML_Danh_sach;
    }
    public static string Tao_Chuoi_HTML_Danh_sach_Nhom_hang_New(List<XL_NHOM_HANG> Danh_sach_Nhom_hang, List<XL_MAT_HANG> danhSachMatHang)
    {
        var dict = XL_NGHIEP_VU.Thong_Ke_So_Luong_Mat_Hang_Theo_Nhom(danhSachMatHang);
        var Chuoi_HTML_Danh_sach = "<ul class='list - unstyled'>";
        Danh_sach_Nhom_hang.ForEach(Nhom_hang =>
        {
            Chuoi_HTML_Danh_sach += "<li class='media'>";
            Chuoi_HTML_Danh_sach += $"<img style='width:40px;height:40px;margin:5px;' class='align-self-start mr-3' src='../4_Media/{Nhom_hang.Ma_so}.png'>";
            Chuoi_HTML_Danh_sach += "<div class='media-body'>";
            Chuoi_HTML_Danh_sach += $"<h5 class='mt-0'>{Nhom_hang.Ten}</h5>";
            Chuoi_HTML_Danh_sach += $"<p> Số Lượng: {dict[Nhom_hang.Ma_so]} </p>";
            Chuoi_HTML_Danh_sach += "</div>";
            Chuoi_HTML_Danh_sach += "</li>";                           
        });
        Chuoi_HTML_Danh_sach += "</ul>";

        return Chuoi_HTML_Danh_sach;
    }

    public static string Tao_Chuoi_HTML_Danh_sach_Mat_hang(List<XL_MAT_HANG> Danh_sach_Mat_hang)
    {
        var Chuoi_HTML_Danh_sach = "Sinh viên Phải tự thực hiện";
        return Chuoi_HTML_Danh_sach;
    }
    public static string Tao_Chuoi_HTML_Danh_sach_Nhan_vien(List<XL_NHAN_VIEN> Danh_sach_Nhan_vien)
    {
        var Chuoi_HTML_Danh_sach = "<div>";
        Danh_sach_Nhan_vien.ForEach(nhanvien =>
        {
            Chuoi_HTML_Danh_sach += "<div>";
            var Chuoi_Hinh = $"<img src='../4_Media/{nhanvien.Ma_so}.png' " + "style='width:40px;height:40px;margin:5px;' />"; ;
            Chuoi_HTML_Danh_sach +=Chuoi_Hinh + "</div>";
            var Ten = nhanvien.Ho_ten.ToUpper();
            var SoNhomHang = nhanvien.Danh_sach_Ma_so_Nhom_hang.Count;
            var SoLanDangNhap = nhanvien.Danh_sach_Dang_nhap.Count;
            var latest = nhanvien.Danh_sach_Dang_nhap.Last();
            Chuoi_HTML_Danh_sach += $"<div> <h3>{Ten}</h3> <h6>Số Nhóm Hàng: {SoNhomHang}</h6> <h6>Số Lần Đăng Nhập: {SoLanDangNhap}</h6> <h6>Lần Đăng Nhập Cuối Cùng: {latest}</h6> </div>";                        
        });
        Chuoi_HTML_Danh_sach += "</div>";
        return Chuoi_HTML_Danh_sach;
    }
}


