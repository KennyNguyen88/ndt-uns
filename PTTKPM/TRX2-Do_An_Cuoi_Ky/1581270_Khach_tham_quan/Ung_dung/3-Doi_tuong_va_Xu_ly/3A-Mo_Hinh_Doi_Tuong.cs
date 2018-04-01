using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public partial class XL_DU_LIEU
{
    public XL_NHA_HANG Nha_hang = new XL_NHA_HANG();
    public List<XL_MONAN> Danh_sach_Mon_an = new List<XL_MONAN>();
}
//*************************** Đối tượng Tổ chức  *********
public class XL_NHA_HANG
{
    public string Ten, Ma_so = "", Dien_thoai, Mail, Dia_chi;
    public List<XL_THUCDON> Danh_sach_Thuc_don = new List<XL_THUCDON>();    
}
//*************************** Đối tượng Sự vật : Xử lý Chính *********
public class XL_MONAN
{
    public string Ten, Ma_so = "";
    public long Don_gia_Ban, Don_gia_Nhap;
    public XL_THUCDON Thuc_don = new XL_THUCDON();
}
//=========== Danh mục Nhóm  ===============
public class XL_THUCDON
{
    public string Ten, Ma_so = "";
    public List<XL_MONAN> Danh_sach_Mon_an = new List<XL_MONAN>(); //Tính toán
}