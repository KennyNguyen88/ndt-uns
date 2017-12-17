using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
public partial class XL_NGHIEP_VU
{   // Tạo Danh sách Đối tượng của Người dùng khi có Phân công 
    public static List<XL_NHOM_HANG> Tao_Danh_sach_Nhom_hang_cua_Nhan_vien(XL_NHAN_VIEN Nhan_vien,
                          List<XL_NHOM_HANG> Danh_sach_Tat_ca_Nhom_hang)
    {
        var Danh_sach = new List<XL_NHOM_HANG>();
        Nhan_vien.Danh_sach_Ma_so_Nhom_hang.ForEach(Ma_so_Nhom_hang =>
        {
            var Nhom_hang = Danh_sach_Tat_ca_Nhom_hang.FirstOrDefault(x => x.Ma_so == Ma_so_Nhom_hang);
            if (Nhom_hang != null)
                Danh_sach.Add(Nhom_hang);
        });
        return Danh_sach;
    }
    public static List<XL_MAT_HANG> Tao_Danh_sach_Mat_hang_cua_Nhan_vien(XL_NHAN_VIEN Nhan_vien,
        List<XL_MAT_HANG> Danh_sach_Tat_ca_Mat_hang)
    {
        var Danh_sach = new List<XL_MAT_HANG>();
        Nhan_vien.Danh_sach_Ma_so_Nhom_hang.ForEach(Ma_so_Nhom_hang =>
        {
            var DS_Mat_hang = Danh_sach_Tat_ca_Mat_hang.FindAll(Mat_hang => Mat_hang.Ma_so_Nhom_hang == Ma_so_Nhom_hang);
            Danh_sach.AddRange(DS_Mat_hang);
        });

        return Danh_sach;
    }

    public static IDictionary<string, int> Thong_Ke_So_Luong_Mat_Hang_Theo_Nhom(List<XL_MAT_HANG> danhSachMatHang)
    {
        IDictionary<string, int> dict = new Dictionary<string, int>();
        danhSachMatHang.ForEach(mathang =>
        {

            if (dict.ContainsKey(mathang.Ma_so_Nhom_hang))
            {
                dict[mathang.Ma_so_Nhom_hang]++;
            }
            else
            {
                dict[mathang.Ma_so_Nhom_hang] = 1;
            }

        });
        return dict;
    }

}
