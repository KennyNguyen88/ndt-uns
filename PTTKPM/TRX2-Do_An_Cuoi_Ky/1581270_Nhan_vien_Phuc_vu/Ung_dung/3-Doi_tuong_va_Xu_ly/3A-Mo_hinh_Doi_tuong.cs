using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class XL_CHUC_NANG
{
    public string Ten, Ma_so;
}

//*************************** Đối tượng Dữ liệu   *********
public partial class XL_DU_LIEU
{
    // Con Người - Đối tượng Xử lý chính và Hoạt động - Tổ chức      
    public XL_NHA_HANG Nha_hang = new XL_NHA_HANG();
    public List<XL_MONAN> Danh_sach_Mon_an = new List<XL_MONAN>();
    public List<XL_NGUOI_DUNG> Danh_sach_Nguoi_dung = new List<XL_NGUOI_DUNG>();
    public List<XL_PHIEU_DAT> Danh_sach_Phieu_dat = new List<XL_PHIEU_DAT>();

}
//=========== Đối tượng  Con người ===============
public class XL_NGUOI_DUNG
{

    public string Ho_ten, Ma_so = "", Ten_Dang_nhap, Mat_khau;
    public XL_NHOM_NGUOI_DUNG Nhom_Nguoi_dung = new XL_NHOM_NGUOI_DUNG();

    //Chức năng
    public XL_CHUC_NANG Chuc_nang_Khoi_dong_MH_Chinh = new XL_CHUC_NANG() { Ten = "Khởi động", Ma_so = "KHOI_DONG_MH_CHINH" };
    public XL_CHUC_NANG Chuc_nang_Chon_Thuc_don = new XL_CHUC_NANG() { Ten = "Chọn thực đơn", Ma_so = "CHON_THUC_DON" };
    public XL_CHUC_NANG Chuc_nang_Chon_Mon_an = new XL_CHUC_NANG() { Ten = "Chọn món ăn", Ma_so = "CHON_MON_AN" };
    public XL_CHUC_NANG Chuc_nang_Xoa_Mon_an = new XL_CHUC_NANG() { Ten = "Xóa món ăn", Ma_so = "XOA_MON_AN" };
    public XL_CHUC_NANG Chuc_nang_Them_Mon_an = new XL_CHUC_NANG() { Ten = "Thêm món ăn", Ma_so = "THEM_MON_AN" };
    public XL_CHUC_NANG Chuc_nang_Xoa_Mon_an_Phieu_dat = new XL_CHUC_NANG() { Ten = "Xóa món ăn phiếu đặt", Ma_so = "XOA_MON_AN_PHIEU_DAT" };
    public XL_CHUC_NANG Chuc_nang_Them_Mon_an_Phieu_dat = new XL_CHUC_NANG() { Ten = "Thêm món ăn phiếu đặt", Ma_so = "THEM_MON_AN_PHIEU_DAT" };
    public XL_CHUC_NANG Chuc_nang_Them_Phieu_dat = new XL_CHUC_NANG() { Ten = "Thêm Phiếu đặt", Ma_so = "THEM_PHIEU_DAT" };
    public XL_CHUC_NANG Chuc_nang_Sua_Phieu_dat = new XL_CHUC_NANG() { Ten = "Sửa Phiếu đặt", Ma_so = "SUA_PHIEU_DAT" };
    public XL_CHUC_NANG Chuc_nang_Cap_nhat_Phieu_dat = new XL_CHUC_NANG() { Ten = "Cập nhật Phiếu đặt", Ma_so = "CAP_NHAT_PHIEU_DAT" };
    public XL_CHUC_NANG Chuc_nang_Tra_cuu = new XL_CHUC_NANG() { Ten = "Tra cứu", Ma_so = "TRA_CUU" };
    
    public List<XL_PHIEU_DAT> Danh_sach_Phieu_dat_Nhan_vien = new List<XL_PHIEU_DAT>();
    public List<XL_DANH_SACH_MON_AN> Danh_sach_Mon_an_Chon = new List<XL_DANH_SACH_MON_AN>();

}
//*************************** Đối tượng Sự vật : Xử lý Chính *********
public class XL_MONAN
{

    public string Ten, Ma_so = "";
    public long Don_gia_Ban, Don_gia_Nhap;
    public XL_THUCDON Thuc_don = new XL_THUCDON();    

}
//*** Đối tượng Hoạt động : Phát sinh theo thời gian ==>Khối lượng lớn *********
public class XL_PHIEU_DAT
{

    public string Ma_so = "";
    public int Ban;
    public DateTime Thoi_gian_dat = DateTime.Now;
    public string Ma_Nhan_vien_Phuc_vu = "";
    public string Trang_thai = "CHUA_THANH_TOAN";
    public long Thanh_tien;
    public DateTime Thoi_gian_dong;
    public List<XL_DANH_SACH_MON_AN> Danh_sach_Mon_an = new List<XL_DANH_SACH_MON_AN>();

}
public class XL_DANH_SACH_MON_AN
{

    public string Ma_so_Mon_an;
    public int So_luong;

}
//*************************** Đối tượng Tổ chức  *********
public class XL_NHA_HANG
{

    public string Ten, Ma_so = "", Dien_thoai, Mail, Dia_chi;
    public List<XL_THUCDON> Danh_sach_Thuc_don = new List<XL_THUCDON>();    

}
//=========== Danh mục Nhóm  ===============
public class XL_THUCDON
{

    public string Ten, Ma_so = "";
    public List<XL_MONAN> Danh_sach_Mon_an = new List<XL_MONAN>(); //Tính toán

}
public class XL_NHOM_NGUOI_DUNG
{

    public string Ten, Ma_so = "";    

}


