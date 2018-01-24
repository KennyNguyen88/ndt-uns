using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
public partial class XL_DU_LIEU
{
    //Properties 
    public XL_NHAN_VIEN Nhan_vien = new XL_NHAN_VIEN();
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
    public DateTime Ngay = DateTime.Now;
    public bool Da_co_Y_kien;
    public String Noi_dung;
}