using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
 
    public partial class XL_THE_HIEN
    {   public static CultureInfo Dinh_dang_VN = CultureInfo.GetCultureInfo("vi-VN");
        // Thể hiện Đối tượng Người dùng khi Chào
        public static string Tao_Chuoi_HTML_Khach_Tham_quan_Khi_Chao(XL_KHACH_THAM_QUAN Khach_tham_quan)
        {   var Chuoi_Hinh = $"<img src='../Media/{Khach_tham_quan.Ma_so}.png'  " + $"style='width:60px;height:60px;margin:5px;'  />";
            var Chuoi_Tom_tat = $"<div class='btn'> Xin chào {Khach_tham_quan.Ho_ten}" +  $"</div>";
            var Chuoi_HTML = "<div class='btn' >"
                  + $"{Chuoi_Hinh}"
                  + $"{Chuoi_Tom_tat}"
                  + "</div>";
            return Chuoi_HTML;
        }
        public static string Tao_Chuoi_HTML_Khach_hang_Khi_Chao(XL_KHACH_HANG Khach_hang)
        {   var Chuoi_Hinh = $"<img src='../Media/{Khach_hang.Ma_so}.png'  " +$"style='width:60px;height:60px;margin:5px;'  />";
            var Chuoi_Tom_tat = $"<div class='btn'> Xin chào {Khach_hang.Ho_ten}" +$"</div>";
            var Chuoi_HTML = "<div class='btn' >"
                  + $"{Chuoi_Hinh}"
                  + $"{Chuoi_Tom_tat}"
                  + "</div>";
            return Chuoi_HTML;
        }
        public static string Tao_Chuoi_HTML_Quan_ly_Khi_Chao(XL_QUAN_LY Quan_ly)
        {   var Chuoi_Hinh = $"<img src='../Media/{Quan_ly.Ma_so}.png'  " +$"style='width:60px;height:60px;margin:5px;'  />";
            var Chuoi_Tom_tat = $"<div class='btn'> Xin Trân trọng kính chào Quản lý {Quan_ly.Ho_ten}" +
                                    $"<br />Số lần đăng nhập hiện nay là {Quan_ly.Danh_sach_Dang_nhap.Count}" +
                                 $"</div>";
            var Chuoi_HTML = "<div class='btn' >"
                  + $"{Chuoi_Hinh}"
                  + $"{Chuoi_Tom_tat}"
                  + "</div>";
            return Chuoi_HTML;
        }
        public static string Tao_Chuoi_HTML_Nhan_vien_Khi_Chao(XL_NHAN_VIEN Nhan_vien)
        {  var Chuoi_Hinh = $"<img src='../Media/{Nhan_vien.Ma_so}.png'  " + $"style='width:60px;height:60px;margin:5px;'  />";
            var Chuoi_Tom_tat = $"<div class='btn'> Xin chào Nhân viên {Nhan_vien.Ho_ten}" +
                                 $"<br />Số lần đăng nhập hiện nay là {Nhan_vien.Danh_sach_Dang_nhap.Count}" +
                                 $"</div>";
            var Chuoi_HTML = "<div class='btn' >"
                  + $"{Chuoi_Hinh}"
                  + $"{Chuoi_Tom_tat}"
                  + "</div>";
            return Chuoi_HTML;
        }
        // Thể hiện Danh sách các Đối tượng 
        public static string Tao_Chuoi_HTML_Danh_sach_Nhom_hang(
            List<XL_NHOM_HANG> Danh_sach_Nhom_hang, List<XL_MAT_HANG> Danh_sach_Tat_ca_Mat_hang )
        {  var Chuoi_HTML_Danh_sach = "<div   >";
            Danh_sach_Nhom_hang.ForEach(Nhom_hang =>
            {
                var Danh_sach_Mat_hang_cua_Nhom_hang = XL_NGHIEP_VU.Tao_Danh_sach_Mat_hang_cua_Nhom_hang(
                    Nhom_hang,Danh_sach_Tat_ca_Mat_hang);
                
                var Chuoi_Hinh = $"<img src='../Media/{Nhom_hang.Ma_so}.png' " + "style='width:40px;height:40px;margin:5px;' />"; ;
                var Chuoi_Thong_tin = $"<div class='btn 'style='border:none'> " +
                               $"{Nhom_hang.Ten} {Danh_sach_Mat_hang_cua_Nhom_hang.Count}" +
                               $"</div>";                          
                var Chuoi_HTML = "<div class='btn'  >" +
                                    $"{Chuoi_Hinh}"  + $"{Chuoi_Thong_tin}" +
                                 "</div>";
                Chuoi_HTML_Danh_sach += Chuoi_HTML;
            });
            Chuoi_HTML_Danh_sach += "</div>";
            return Chuoi_HTML_Danh_sach;
        }
        public static string Tao_Chuoi_HTML_Danh_sach_Mat_hang(List<XL_MAT_HANG> Danh_sach_Mat_hang)
        {   var Chuoi_HTML_Danh_sach = "<div class='row'>";
            Danh_sach_Mat_hang.ForEach(Mat_hang =>
            {   var Chuoi_Hinh = $"<img src='../Media/{Mat_hang.Ma_so}.png' " +"style='width:40px;height:40px;margin:5px;' />"; ;
                var Chuoi_Thong_tin = $"<div class='btn' style='text-align:left'> " + $"{Mat_hang.Ten}" +
                              $"<br />Đơn giá { Mat_hang.Don_gia_Ban.ToString("n0",Dinh_dang_VN) } </div>";
                var Chuoi_HTML = "<div class='col-md-4'  >" +
                                   $"{Chuoi_Hinh}" + $"{Chuoi_Thong_tin}" +
                                 "</div>";
                Chuoi_HTML_Danh_sach += Chuoi_HTML;
            });
            Chuoi_HTML_Danh_sach += "</div>";
            return Chuoi_HTML_Danh_sach;
        }
        public static string Tao_Chuoi_HTML_Danh_sach_Nhan_vien(List<XL_NHAN_VIEN> Danh_sach_Nhan_vien)
        {  var Chuoi_HTML_Danh_sach = "<div class='row'>";
            Danh_sach_Nhan_vien.ForEach(Nhan_vien =>
            {  var Chuoi_Hinh = $"<img src='../Media/{Nhan_vien.Ma_so}.png' " +"style='width:60px;height:60px;margin:5px;' />"; ;
                var Chuoi_Thong_tin = $"<div class='btn'  style='text-align:left'> " +$"{Nhan_vien.Ho_ten}" +
                             $"<br /> { Nhan_vien.Danh_sach_Nhom_hang.Count } Nhóm hàng</div>";
                var Chuoi_HTML = "<div class='col-md-4'  >" +
                                    $"{Chuoi_Hinh}"+ $"{Chuoi_Thong_tin}" +
                                   "</div>";
                Chuoi_HTML_Danh_sach += Chuoi_HTML;
            });
            Chuoi_HTML_Danh_sach += "</div>";
            return Chuoi_HTML_Danh_sach;
        }
    }
 

