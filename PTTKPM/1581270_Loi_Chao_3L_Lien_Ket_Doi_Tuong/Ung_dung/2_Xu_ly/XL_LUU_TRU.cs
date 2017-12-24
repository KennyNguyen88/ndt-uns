using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Script.Serialization;
 
    public partial class XL_LUU_TRU
    {   static DirectoryInfo Thu_muc_Du_lieu = new DirectoryInfo( 
             HttpContext.Current.Server.MapPath($"..\\Du_lieu"));
        static DirectoryInfo Thu_muc_Nhom_hang = Thu_muc_Du_lieu.GetDirectories("Nhom_hang")[0];
        static DirectoryInfo Thu_muc_Mat_hang = Thu_muc_Du_lieu.GetDirectories("Mat_hang")[0];
        static DirectoryInfo Thu_muc_Nhan_vien = Thu_muc_Du_lieu.GetDirectories("Nhan_vien")[0];
        static DirectoryInfo Thu_muc_Quan_ly = Thu_muc_Du_lieu.GetDirectories("Quan_ly")[0];
        public static List<XL_NHOM_HANG> Doc_Danh_sach_Nhom_hang()
        {   var Danh_sach = new List<XL_NHOM_HANG>();
            Thu_muc_Nhom_hang.GetFiles("*.json").ToList().ForEach(Tap_tin =>
            {   var Duong_dan = Tap_tin.FullName;
                var Chuoi = File.ReadAllText(Duong_dan);
                var Xu_ly = new JavaScriptSerializer();
                var Nhom_hang = new XL_NHOM_HANG();
                Nhom_hang = (XL_NHOM_HANG)Xu_ly.Deserialize(Chuoi, Nhom_hang.GetType());
                Danh_sach.Add(Nhom_hang);
            });
            return Danh_sach;
        }
        public static List<XL_MAT_HANG> Doc_Danh_sach_Mat_hang()
        {  var Danh_sach = new List<XL_MAT_HANG>();
            Thu_muc_Mat_hang.GetFiles("*.json").ToList().ForEach(Tap_tin =>
            {   var Duong_dan = Tap_tin.FullName;
                var Chuoi = File.ReadAllText(Duong_dan);
                var Xu_ly = new JavaScriptSerializer();
                var Mat_hang = new XL_MAT_HANG();
                Mat_hang = (XL_MAT_HANG)Xu_ly.Deserialize(Chuoi, Mat_hang.GetType());
                Danh_sach.Add(Mat_hang);
            });
            return Danh_sach;
        }

        public static List<XL_NHAN_VIEN> Doc_Danh_sach_Nhan_vien()
        {  var Danh_sach = new List<XL_NHAN_VIEN>();         
            Thu_muc_Nhan_vien.GetFiles("*.json").ToList().ForEach(Tap_tin =>
            {  var Duong_dan = Tap_tin.FullName;
                var Chuoi = File.ReadAllText(Duong_dan);
                var Xu_ly = new JavaScriptSerializer();
                var Nhan_vien = new XL_NHAN_VIEN();
                Nhan_vien = (XL_NHAN_VIEN)Xu_ly.Deserialize(Chuoi, Nhan_vien.GetType());
                Danh_sach.Add(Nhan_vien);
            });
            return Danh_sach;
        }
        public static List<XL_QUAN_LY> Doc_Danh_sach_Quan_ly()
        {   var Danh_sach = new List<XL_QUAN_LY>();          
            Thu_muc_Quan_ly.GetFiles("*.json").ToList().ForEach(Tap_tin =>
            {   var Duong_dan = Tap_tin.FullName;
                var Chuoi = File.ReadAllText(Duong_dan);
                var Xu_ly = new JavaScriptSerializer();
                var Quan_ly = new XL_QUAN_LY();
                Quan_ly = (XL_QUAN_LY)Xu_ly.Deserialize(Chuoi, Quan_ly.GetType());
                Danh_sach.Add(Quan_ly);
            });
            return Danh_sach;
        }
      
        public static void Ghi_Nhan_vien(XL_NHAN_VIEN Nhan_vien)
        {   var Chuoi = Newtonsoft.Json.JsonConvert.SerializeObject(Nhan_vien, Newtonsoft.Json.Formatting.Indented); ;
            var Duong_dan = Thu_muc_Nhan_vien.FullName + $"\\{Nhan_vien.Ma_so}.json";
            File.WriteAllText(Duong_dan, Chuoi);
        }
        public static void Ghi_Quan_ly(XL_QUAN_LY Quan_ly)
        {  var Chuoi =Newtonsoft.Json.JsonConvert.SerializeObject(Quan_ly,Newtonsoft.Json.Formatting.Indented);
            var Duong_dan = Thu_muc_Quan_ly.FullName + $"\\{Quan_ly.Ma_so}.json";
            File.WriteAllText(Duong_dan, Chuoi);
        }
    }


