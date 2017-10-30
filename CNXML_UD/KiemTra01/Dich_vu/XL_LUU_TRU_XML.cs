using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

public class XL_LUU_TRU_XML
{
    static String forTest = "1000_Thi_sinh";
    static String forProd = "Tat_ca_Thi_sinh";
    static String DuLieu = forTest;
    static DirectoryInfo Thu_muc_Project = new DirectoryInfo(HttpContext.Current.Server.MapPath("."));
    static DirectoryInfo Thu_muc_Solution = Thu_muc_Project.Parent;
    static DirectoryInfo Thu_muc_Du_lieu = Thu_muc_Solution.GetDirectories(DuLieu)[0];
    string Loai_Luu_tru = "XML";

    public string Doc_Chuoi(string Loai_Doi_tuong, string Ma_so)
    {
        var Chuoi = "";        
        var Duong_dan = Thu_muc_Du_lieu.FullName + @"\" + Ma_so + "." + Loai_Luu_tru;
        if (File.Exists(Duong_dan))
            Chuoi = File.ReadAllText(Duong_dan);

        return Chuoi;
    }
    public string Ghi_Chuoi(string Loai_Doi_tuong, string Ma_so, string Chuoi)
    {
        var Kq = "";        
        var Duong_dan = Thu_muc_Du_lieu.FullName + @"\" + Ma_so + "." + Loai_Luu_tru;
        File.WriteAllText(Duong_dan, Chuoi);
        return Kq;
    }

    public string Doc_Chuoi_Danh_sach(string Loai_Doi_tuong)
    {
        var Chuoi_Danh_sach = "<DANH_SACH_" + Loai_Doi_tuong + ">";        
        foreach (FileInfo Tap_tin in Thu_muc_Du_lieu.GetFiles("*." + Loai_Luu_tru))
        {
            var Chuoi = File.ReadAllText(Tap_tin.FullName);
            Chuoi_Danh_sach += Chuoi;
        }
        Chuoi_Danh_sach += "</DANH_SACH_" + Loai_Doi_tuong + ">";
        return Chuoi_Danh_sach;
    }
}
