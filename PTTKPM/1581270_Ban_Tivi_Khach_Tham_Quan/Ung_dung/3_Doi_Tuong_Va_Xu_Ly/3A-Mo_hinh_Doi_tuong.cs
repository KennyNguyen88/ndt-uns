using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
public partial class XL_DU_LIEU
{
    public  List<XL_MAT_HANG> Danh_sach_Mat_hang = new List<XL_MAT_HANG>();
}
public class XL_MAT_HANG
{
    public string Ten, Ma_so = "";
    public long Don_gia_Ban;
    public XL_NHOM_MAT_HANG Nhom_Mat_hang = new XL_NHOM_MAT_HANG();
}
public class XL_NHOM_MAT_HANG
{
    public string Ten, Ma_so = "";
}