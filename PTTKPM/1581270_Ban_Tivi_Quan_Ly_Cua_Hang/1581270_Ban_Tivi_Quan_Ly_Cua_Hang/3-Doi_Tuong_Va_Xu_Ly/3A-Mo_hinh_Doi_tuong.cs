using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
public partial class XL_DU_LIEU
{
    public XL_CUA_HANG Cua_hang = new XL_CUA_HANG();
    public List<XL_TIVI> Danh_sach_Tivi = new List<XL_TIVI>();
}
public class XL_CUA_HANG
{
    public string Ten, Ma_so = "";
    public List<XL_NHOM_NHAN_VIEN> Danh_sach_Nhom_Nhan_vien = new List<XL_NHOM_NHAN_VIEN>();
    public List<XL_NHOM_TIVI> Danh_Sach_Nhom_Tivi = new List<XL_NHOM_TIVI>();
    public List<XL_NHAN_VIEN> Danh_sach_Nhan_vien = new List<XL_NHAN_VIEN>();
    public List<XL_QUAN_LY> Danh_sach_Quan_ly = new List<XL_QUAN_LY>();
}
public class XL_NHOM_TIVI
{
    public string Ten, Ma_so = "";
}
public class XL_NHOM_NHAN_VIEN
{
    public string Ten, Ma_so = "";
}
public class XL_NHOM_QUAN_LY
{
    public string Ten, Ma_so = "";
}
public class XL_NHAN_VIEN
{
    public string Ho_ten, Ma_so = "", Ten_Dang_nhap, Mat_khau;
    public XL_NHOM_NHAN_VIEN Nhom_Nhan_vien = new XL_NHOM_NHAN_VIEN();
    public List<XL_NHOM_TIVI> Danh_sach_Nhom_Tivi = new List<XL_NHOM_TIVI>();
}
public class XL_QUAN_LY
{
    public string Ho_ten, Ma_so = "", Ten_Dang_nhap, Mat_khau;
    public XL_NHOM_QUAN_LY Nhom_Quan_Ly = new XL_NHOM_QUAN_LY();
}
public class XL_TIVI
{
    public string Ten, Ma_so = "";
    public long Don_gia_Ban, Don_gia_Nhap;
    public XL_NHOM_TIVI Nhom_Tivi = new XL_NHOM_TIVI();
    public List<XL_NHAP_HANG> Danh_sach_Nhap_hang = new List<XL_NHAP_HANG>();
    public List<XL_BAN_HANG> Danh_sach_Ban_hang = new List<XL_BAN_HANG>();
}
public class XL_NHAP_HANG
{
    public DateTime Ngay = DateTime.Today;
    public long Don_gia, So_luong, Tien;
    public XL_NHAN_VIEN Nhan_vien = new XL_NHAN_VIEN();

}
public class XL_BAN_HANG
{
    public DateTime Ngay = DateTime.Today;
    public long Don_gia, So_luong, Tien;
    public XL_NHAN_VIEN Nhan_vien = new XL_NHAN_VIEN();

}