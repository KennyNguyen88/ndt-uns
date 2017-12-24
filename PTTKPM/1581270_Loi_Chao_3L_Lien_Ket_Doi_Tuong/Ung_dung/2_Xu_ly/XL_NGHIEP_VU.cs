using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 public partial class XL_NGHIEP_VU
 {
    // Tạo Danh sách dựa vào Liên kết 
    public static List<XL_MAT_HANG> Tao_Danh_sach_Mat_hang_cua_Nhom_hang(XL_NHOM_HANG Nhom_hang,
       List<XL_MAT_HANG> Danh_sach_Tat_ca_Mat_hang)
    {
        var Danh_sach = new List<XL_MAT_HANG>();
        Danh_sach = Danh_sach_Tat_ca_Mat_hang.FindAll(Mat_hang => Mat_hang.Nhom_hang.Ma_so == Nhom_hang.Ma_so);
        return Danh_sach;
    } 
    public static List<XL_NHOM_HANG> Tao_Danh_sach_Nhom_hang_cua_Nhan_vien(XL_NHAN_VIEN Nhan_vien,
                              List<XL_NHOM_HANG> Danh_sach_Tat_ca_Nhom_hang)
        {
            var Danh_sach = Nhan_vien.Danh_sach_Nhom_hang;            
            return Danh_sach;
        }
    public static List<XL_MAT_HANG> Tao_Danh_sach_Mat_hang_cua_Nhan_vien(XL_NHAN_VIEN Nhan_vien,
            List<XL_MAT_HANG> Danh_sach_Tat_ca_Mat_hang)
        {
            var Danh_sach = new List<XL_MAT_HANG>();
            Nhan_vien.Danh_sach_Nhom_hang.ForEach(Nhom_hang =>
            {  var DS_Mat_hang = Danh_sach_Tat_ca_Mat_hang.FindAll(Mat_hang => Mat_hang.Nhom_hang.Ma_so == Nhom_hang.Ma_so);
                Danh_sach.AddRange(DS_Mat_hang);
            });
        
            return Danh_sach;
        }
 }
