using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Helpers;
using System.Web.Hosting;
using System.Globalization;
using System.Net;
//************************* M+ (Model for All ) **********************************
public partial class XL_DU_LIEU
{
    public static XL_DU_LIEU Khoi_dong_Du_lieu_Ung_dung()
    {
        return Doc_Du_lieu();
    }
}
//************************* View Layers/Presentation Layers  VL/PL **********************************
public partial class XL_DU_LIEU
{
    public string Dia_chi_Media = $"{Dia_chi_Dich_vu}/Media";
    public CultureInfo Dinh_dang_VN = CultureInfo.GetCultureInfo("vi-VN");

    public string Tao_Chuoi_HTML(List<XL_NHAN_VIEN> DSNhanVien)
    {
        var Chuoi_HTML_Ket_Qua = "";

        DSNhanVien.ForEach(NhanVien =>
        {
            Chuoi_HTML_Ket_Qua += Tao_Chuoi_HTML_Nhan_Vien(NhanVien);
        });
    
        return Chuoi_HTML_Ket_Qua;
    }

    public string Tao_Chuoi_HTML_Nhan_Vien(XL_NHAN_VIEN NhanVien)
    {
        String HoTen = NhanVien.Ho_ten;
        String MaNV = NhanVien.Ma_so;

        String TenDonVi = NhanVien.Don_vi.Ten;
        String TenChiNhanh = NhanVien.Don_vi.Chi_nhanh.Ten;
        List<XL_DON_XIN_NGHI> dons = NhanVien.Danh_sach_Don_xin_nghi.FindAll(dxn => dxn.Y_kien.Da_co_Y_kien == false);

        var Chuoi_HTML_Hinh = $"<img src='{Dia_chi_Media}/{NhanVien.Ma_so}.png' " +
                             "style='width:90px;height:90px;' />";
        var Chuoi_HTML_Ho_Ten = "<p> Họ tên: " + HoTen + "</p>";
        var Chuoi_HTML_MaNV = "<p> Mã Nhân Viên: " + MaNV + "</p>";
        var Chuoi_HTML_Ten_Don_Vi = "<p> Tên Đơn Vị: " + TenDonVi + "</p>";
        var Chuoi_HTML_Ten_Chi_Nhanh = "<p> Tên Chi Nhánh: " + TenChiNhanh + "</p>";

        var Chuoi_HTML_Ket_Qua = "<div class='row'>";
        Chuoi_HTML_Ket_Qua += "<div class='col'>";
        Chuoi_HTML_Ket_Qua += Chuoi_HTML_Hinh;
        Chuoi_HTML_Ket_Qua += "</div>";
        Chuoi_HTML_Ket_Qua += "<div class='col'>";
        Chuoi_HTML_Ket_Qua += Chuoi_HTML_Ho_Ten;
        Chuoi_HTML_Ket_Qua += Chuoi_HTML_MaNV;
        Chuoi_HTML_Ket_Qua += Chuoi_HTML_Ten_Don_Vi;
        Chuoi_HTML_Ket_Qua += Chuoi_HTML_Ten_Chi_Nhanh;
        Chuoi_HTML_Ket_Qua += "</div>";
        Chuoi_HTML_Ket_Qua += "</div>";
        Chuoi_HTML_Ket_Qua += "<div class='row'>";
        Chuoi_HTML_Ket_Qua += "<div class='col'>";
        Chuoi_HTML_Ket_Qua += "<p> Có <span style='font-weight: bold'>" + dons.Count + "</span> Đơn xin nghĩ chưa cho ý kiến</p>";

        Chuoi_HTML_Ket_Qua += "<ol style='display: flex'>";
        dons.ForEach(don =>
        {
            String NgayNopDon = don.Ngay_Nop_don.ToShortDateString();
            String NgayBatDauNghi = don.Ngay_Bat_dau.ToShortDateString();
            String Lydo = don.Ly_do;
            String NgayYKien = don.Y_kien.Ngay.ToShortDateString();
            String NoiDungYKien = don.Y_kien.Noi_dung;

            var Chuoi_li = "<li style='margin: 10px;'>";
            Chuoi_li += "<form method='post'>";
            Chuoi_li += "<p> Ngày nộp đơn: " + NgayNopDon + "</p>";
            Chuoi_li += "<p> Ngày bắt đầu nghỉ: " + NgayBatDauNghi + "</p>";
            Chuoi_li += "<p> Lý do: " + Lydo + "</p>";
            Chuoi_li += "<p> Ngày ý kiến: " + NgayYKien + "</p>";
            Chuoi_li += $"<p> Nội dung ý kiến: <input required type='text' name='TH_Y_Kien' value='{NoiDungYKien}'/></p>";
            Chuoi_li += $"<input type='hidden' name='TH_Ma_Nhan_Vien' value='{NhanVien.Ma_so}'/>";
            Chuoi_li += $"<input type='hidden' name='TH_NgayNopDon' value='{NgayNopDon}'/>";
            Chuoi_li += $"<input type='hidden' name='TH_NgayBatDauNghi' value='{NgayBatDauNghi}'/>";
            Chuoi_li += "</form>";
            Chuoi_li += "</li>";

            Chuoi_HTML_Ket_Qua += Chuoi_li;
        });
        Chuoi_HTML_Ket_Qua += "</ol>";

        Chuoi_HTML_Ket_Qua += "</div>";
        Chuoi_HTML_Ket_Qua += "</div>";
        return Chuoi_HTML_Ket_Qua;
    }


}
//************************* Business-Layers BL **********************************

public partial class XL_DU_LIEU
{

    public XL_QUAN_LY Dang_Nhap(String TenDangNhap, String MatKhau)
    {
        var Danh_sach_Quan_ly = this.Cong_ty.Danh_sach_Quan_ly;

        var Quan_Ly = Danh_sach_Quan_ly.FirstOrDefault(
                                x => x.Ten_Dang_nhap == TenDangNhap
                                      && x.Mat_khau == MatKhau);
        return Quan_Ly;
    }

}

//************************* Data-Layers DL **********************************
public partial class XL_DU_LIEU
{
    static string Dia_chi_Dich_vu = "http://localhost:50900";
    static string Dia_chi_Dich_vu_Du_lieu = $"{Dia_chi_Dich_vu}/1-Dich_vu_Giao_tiep/DV_Chinh.cshtml";

    static XL_DU_LIEU Doc_Du_lieu()
    {
        var Xu_ly = new WebClient();
        Xu_ly.Encoding = System.Text.Encoding.UTF8;
        var Tham_so = "Ma_so_Xu_ly=KHOI_DONG_DU_LIEU_QUAN_LY_CHI_NHANH";
        var Dia_chi_Xu_ly = $"{Dia_chi_Dich_vu_Du_lieu}?{Tham_so}";
        var Chuoi_JSON = Xu_ly.DownloadString(Dia_chi_Xu_ly);        
        //var Du_lieu = Json.Decode<XL_DU_LIEU>(Chuoi_JSON);
        var Du_lieu = Newtonsoft.Json.JsonConvert.DeserializeObject<XL_DU_LIEU>(Chuoi_JSON);
        return Du_lieu;
    }

    public List<XL_NHAN_VIEN> Loc_DS_Nhan_Vien(XL_QUAN_LY QuanLy)
    {
        var DanhSach = new List<XL_NHAN_VIEN>();
        if (QuanLy.Ma_so == "QLCN_1")
        {
            this.Danh_sach_Nhan_vien.ForEach(NV =>
            {
                if (NV.Don_vi.Ma_so.Substring(0,8) == "DON_VI_A")
                {
                    DanhSach.Add(NV);
                }                
            });
        }
        else
        {
            this.Danh_sach_Nhan_vien.ForEach(NV =>
            {
                if (NV.Don_vi.Ma_so.Substring(0, 8) == "DON_VI_B")
                {
                    DanhSach.Add(NV);
                }
            });
        }
        return DanhSach;
    }

    public string Ghi_Y_Kien(String MaNhanVien, String Y_Kien, String NgayNopDon, String NgayBatDau)
    {        
        var Kq = "";
        XL_NHAN_VIEN NhanVien = this.Danh_sach_Nhan_vien.FirstOrDefault(nv => nv.Ma_so == MaNhanVien);
        XL_DON_XIN_NGHI dxn = NhanVien.Danh_sach_Don_xin_nghi.FirstOrDefault(don => (don.Ngay_Bat_dau.ToShortDateString() == NgayBatDau && don.Ngay_Nop_don.ToShortDateString() == NgayNopDon));
        var Xu_ly = new WebClient();
        Xu_ly.Encoding = System.Text.Encoding.UTF8;
        var Tham_so = $"Ma_so_Xu_ly=GHI_Y_KIEN&Ma_so_Nhan_vien=" + MaNhanVien + "&Y_kien=" + Y_Kien;
        var Dia_chi_Xu_ly = $"{Dia_chi_Dich_vu_Du_lieu}?{Tham_so}";
        
        var Chuoi_JSON = Newtonsoft.Json.JsonConvert.SerializeObject(dxn, Newtonsoft.Json.Formatting.Indented);
        try
        {
            Kq = Xu_ly.UploadString(Dia_chi_Xu_ly, Chuoi_JSON).Trim();
        }
        catch (Exception Loi)
        {
            Kq = Loi.Message;
        }
        if (Kq == "OK")
        {
            //TODO
            dxn.Y_kien.Noi_dung = Y_Kien;
        }
        return Kq;
    }

}