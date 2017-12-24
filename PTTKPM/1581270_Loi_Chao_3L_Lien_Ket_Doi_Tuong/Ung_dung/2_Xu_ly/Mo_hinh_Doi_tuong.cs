using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
   //Mô hình Đối tượng sử dụng Liên kết với Mã số 
    public class XL_NHAN_VIEN
    {   public string Ma_so, Ho_ten;
        public string Ten_dang_nhap, Mat_khau;
        public List<XL_NHOM_HANG> Danh_sach_Nhom_hang = new List<XL_NHOM_HANG>();
        public List<DateTime> Danh_sach_Dang_nhap = new List<DateTime>();
    }
    public class XL_QUAN_LY
    {   public string Ma_so, Ho_ten;
        public string Ten_dang_nhap, Mat_khau;
        public List<DateTime> Danh_sach_Dang_nhap = new List<DateTime>();
    }
    public class XL_NHOM_HANG
    {  public string Ma_so, Ten;
    }
    public class XL_MAT_HANG
    {   public string Ma_so, Ten;
        public int Don_gia_Ban;
        public XL_NHOM_HANG Nhom_hang = new XL_NHOM_HANG();
    }
    public class XL_KHACH_THAM_QUAN
    {   public string Ma_so = "KHACH_THAM_QUAN", Ho_ten = "Khách tham quan";
    }
    public class XL_KHACH_HANG
    {   public string Ma_so = "KHACH_HANG",Ho_ten;
    }

