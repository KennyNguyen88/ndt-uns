using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
public partial class XL_DU_LIEU
{
    //Properties 
    public XL_CONG_TY Cong_ty = new XL_CONG_TY();
    public List<XL_NHAN_VIEN> Danh_sach_Nhan_vien = new List<XL_NHAN_VIEN>();
}
public class XL_CONG_TY
{
    public string Ten, Ma_so, Dien_thoai, Mail, Dia_chi;
    public List<XL_NHOM_QUAN_LY> Danh_sach_Nhom_Quan_ly = new List<XL_NHOM_QUAN_LY>();
    public List<XL_QUAN_LY> Danh_sach_Quan_ly = new List<XL_QUAN_LY>();

}
public class XL_NHOM_QUAN_LY
{
    public string Ten, Ma_so;
}
public class XL_QUAN_LY
{
    public string Ho_ten, Ma_so, Ten_Dang_nhap, Mat_khau;
    public XL_NHOM_QUAN_LY Nhom_Quan_ly;
}
public class XL_NHAN_VIEN
{
    public string Ho_ten, Ma_so = "", Ten_dang_nhap, Mat_khau, Gioi_tinh;
    public XL_DON_VI Don_vi = new XL_DON_VI();
    public List<XL_DON_XIN_NGHI> Danh_sach_Don_xin_nghi = new List<XL_DON_XIN_NGHI>();

}
public class XL_DON_VI
{
    public string Ten, Ma_so;
    public XL_CHI_NHANH Chi_nhanh = new XL_CHI_NHANH();
}

public class XL_CHI_NHANH
{
    public string Ten, Ma_so;
}
public class XL_DON_XIN_NGHI
{
    public DateTime Ngay_Nop_don = DateTime.Now;
    public DateTime Ngay_Bat_dau = DateTime.Now;
    public int So_ngay;
    public String Ly_do;
    public XL_Y_KIEN Y_kien = new XL_Y_KIEN();
}
public class XL_Y_KIEN
{
    public DateTime Ngay;
    public bool Da_co_Y_kien = false;
    public String Noi_dung;
}