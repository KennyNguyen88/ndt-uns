using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class XL_CHUC_NANG
{
    public string Ten, Ma_so;
}

//public class XL_BAN_HANG
//{
//    public DateTime Ngay = DateTime.Now;
//    public long Don_gia, So_luong, Tien;
//    public XL_NHAN_VIEN_THUC_HIEN Nhan_vien = new XL_NHAN_VIEN_THUC_HIEN();

//}
//public class XL_NHAN_VIEN_THUC_HIEN
//{
//    public string Ho_ten = "", Ma_so = "";
//}
//*************************** Đối tượng Dữ liệu   *********
public partial class XL_DU_LIEU
{     
    public List<XL_NGUOI_DUNG> Danh_sach_Nguoi_dung = new List<XL_NGUOI_DUNG>();
    //public List<XL_TIVI> Danh_sach_Tivi = new List<XL_TIVI>();
    public List<XL_MONAN> Danh_sach_Mon_an = new List<XL_MONAN>();
    public List<XL_THUCDON> Danh_sach_Thuc_don = new List<XL_THUCDON>();
    public XL_NHA_HANG Nha_hang = new XL_NHA_HANG();
}
//=========== Đối tượng Con người ===============
public class XL_NGUOI_DUNG
{
    public string Ho_ten, Ma_so = "", Ten_Dang_nhap, Mat_khau;
    public XL_NHOM_NGUOI_DUNG Nhom_Nguoi_dung = new XL_NHOM_NGUOI_DUNG();
    public List<XL_THUCDON> Danh_sach_Thuc_don = new List<XL_THUCDON>();
    //public long Doanh_thu;
    // Tính toán 
    public List<XL_MONAN> Danh_sach_Mon_an = new List<XL_MONAN>();
    // Chức năng 
    public XL_CHUC_NANG Chuc_nang_Khoi_dong_MH_Chinh = new XL_CHUC_NANG()
    { Ten = "Khởi động", Ma_so = "KHOI_DONG_MH_CHINH" };
    public XL_CHUC_NANG Chuc_nang_Tra_cuu_MonAn = new XL_CHUC_NANG()
    { Ten = "Tra cứu Món ăn", Ma_so = "TRA_CUU_MON_AN" };
    public XL_CHUC_NANG Chuc_nang_Chon_ThucDon = new XL_CHUC_NANG()
    { Ten = "Chọn thực đơn", Ma_so = "CHON_THUC_DON" };
    public XL_CHUC_NANG Chuc_nang_Chon_Cap_Nhat_Mon_An = new XL_CHUC_NANG()
    { Ten = "Cập nhật thông tin Món ăn", Ma_so = "CAP_NHAT_THONG_TIN_MON_AN" };
    public XL_CHUC_NANG Chuc_nang_Chon_Cap_Nhat_Ho_So = new XL_CHUC_NANG()
    { Ten = "Cập nhật Hồ sơ Cá nhân", Ma_so = "CAP_NHAT_HO_SO" };
    public XL_CHUC_NANG Chuc_nang_Chon_Xem_Mon_An_Theo_Thuc_Don = new XL_CHUC_NANG()
    { Ten = "Xem Món Ăn theo thực đơn", Ma_so = "XEM_MON_AN_THEO_THUC_DON" };
    public XL_CHUC_NANG Chuc_nang_Chon_THEM_MOI_MON_AN = new XL_CHUC_NANG()
    { Ten = "Thêm mới Món Ăn", Ma_so = "THEM_MOI_MON_AN" };
    //public XL_CHUC_NANG Chuc_nang_Ban_1_Tivi = new XL_CHUC_NANG()
    //{ Ten = "Bán 1 Tivi", Ma_so = "BAN_1_TIVI" };
    // Online
    public string Thong_bao = "";
    public List<XL_MONAN> Danh_sach_Mon_an_Xem = new List<XL_MONAN>();
   
}
//*************************** Đối tượng Xử lý Chính *********
public class XL_MONAN
{
    public string Ten, Ma_so = "";
    public long Don_gia_Ban, Don_gia_Nhap;
    public XL_THUCDON Thuc_don = new XL_THUCDON();
    //public List<XL_PHIEU_DAT> Danh_sach_Phieu_dat = new List<XL_PHIEU_DAT>();
    //public bool Trang_thai_Con_hang;//Tính toán 
    //public long So_luong_Ton, Doanh_thu;//Tính toán 
}
public class XL_PHIEU_DAT
{
    public DateTime Ngay = DateTime.Now;
    public string So_ban = "";
    public long Don_gia, So_luong, Tien;
}

//*************************** Đối tượng Tổ chức  *********
public class XL_NHA_HANG
{
    public string Ten, Ma_so = "", Dien_thoai, Mail, Dia_chi;
    public List<XL_THUCDON> Danh_sach_Thuc_don = new List<XL_THUCDON>();
    //public long So_luong_Ton, Doanh_thu;//Tính toán 

}
public class XL_THUCDON
{
    public string Ten, Ma_so = "";
}

public class XL_NHOM_NGUOI_DUNG
{
    public string Ten, Ma_so = "";
}


 
