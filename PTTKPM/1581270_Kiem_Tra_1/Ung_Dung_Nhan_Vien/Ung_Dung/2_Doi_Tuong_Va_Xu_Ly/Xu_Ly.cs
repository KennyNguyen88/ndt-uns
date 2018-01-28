﻿using System;
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
    
    public string Tao_Chuoi_HTML(XL_NHAN_VIEN NhanVien)
    {
        String HoTen = NhanVien.Ho_ten;
        
        String TenDonVi = NhanVien.Don_vi.Ten;
        String TenChiNhanh = NhanVien.Don_vi.Chi_nhanh.Ten;
        List <XL_DON_XIN_NGHI> dons = NhanVien.Danh_sach_Don_xin_nghi;

        var Chuoi_HTML_Hinh = $"<img src='{Dia_chi_Media}/{NhanVien.Ma_so}.png' " +
                             "style='width:90px;height:90px;' />";
        var Chuoi_HTML_Ho_Ten = "<p> Họ tên: " + HoTen + "</p>";
        var Chuoi_HTML_Ten_Don_Vi = "<p> Tên Đơn Vị: " + TenDonVi + "</p>";
        var Chuoi_HTML_Ten_Chi_Nhanh = "<p> Tên Chi Nhánh: " + TenChiNhanh + "</p>";

        var Chuoi_HTML_Ket_Qua = "<div class='row'>";
        Chuoi_HTML_Ket_Qua += "<div class='col'>";
        Chuoi_HTML_Ket_Qua += Chuoi_HTML_Hinh;
        Chuoi_HTML_Ket_Qua += "</div>";
        Chuoi_HTML_Ket_Qua += "<div class='col'>";
        Chuoi_HTML_Ket_Qua += Chuoi_HTML_Ho_Ten;
        Chuoi_HTML_Ket_Qua += Chuoi_HTML_Ten_Don_Vi;
        Chuoi_HTML_Ket_Qua += Chuoi_HTML_Ten_Chi_Nhanh;
        Chuoi_HTML_Ket_Qua += "</div>";
        Chuoi_HTML_Ket_Qua += "</div>";
        Chuoi_HTML_Ket_Qua += "<div class='row'>";
        Chuoi_HTML_Ket_Qua += "<div class='col'>";
        Chuoi_HTML_Ket_Qua += "<p> Có <span style='font-weight: bold'>"+ dons.Count +"</span> Đơn xin nghĩ đã nộp</p>";

        Chuoi_HTML_Ket_Qua += "<ol style='display: flex'>";
        dons.ForEach(don =>
        {
            String NgayNopDon = don.Ngay_Nop_don.ToShortDateString();
            String NgayBatDauNghi = don.Ngay_Bat_dau.ToShortDateString();
            String Lydo = don.Ly_do;
            String NgayYKien = don.Y_kien.Ngay.ToShortDateString();
            String NoiDungYKien = don.Y_kien.Noi_dung;

            var Chuoi_li = "<li style='margin: 10px;'>";
            Chuoi_li += "<p> Ngày nộp đơn: " + NgayNopDon + "</p>";
            Chuoi_li += "<p> Ngày bắt đầu nghỉ: " + NgayBatDauNghi + "</p>";
            Chuoi_li += "<p> Lý do: " + Lydo + "</p>";
            Chuoi_li += "<p> Ngày ý kiến: " + NgayYKien + "</p>";
            Chuoi_li += "<p> Nội dung ý kiến: " + NoiDungYKien + "</p>";        
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

    public XL_NHAN_VIEN Dang_Nhap(String TenDangNhap, String MatKhau)
    {
        var DSNhanVien = this.Danh_sach_Nhan_vien;

        var Nhan_Vien = DSNhanVien.FirstOrDefault(
                                x => x.Ten_dang_nhap == TenDangNhap
                                      && x.Mat_khau == MatKhau);
        return Nhan_Vien;
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
        var Tham_so = "Ma_so_Xu_ly=KHOI_DONG_DU_LIEU_NHAN_VIEN";
        var Dia_chi_Xu_ly = $"{Dia_chi_Dich_vu_Du_lieu}?{Tham_so}";
        var Chuoi_JSON = Xu_ly.DownloadString(Dia_chi_Xu_ly);
        var Du_lieu = Json.Decode<XL_DU_LIEU>(Chuoi_JSON);
        return Du_lieu;
    }

    public string Ghi_Nop_Don_Moi(XL_NHAN_VIEN NhanVien,String NgayBatDauNghi,int SoNgay, String LyDoNghi)
    {
        var Kq = "";
        XL_DON_XIN_NGHI dxn = new XL_DON_XIN_NGHI();
        var Xu_ly = new WebClient();
        Xu_ly.Encoding = System.Text.Encoding.UTF8;
        var Tham_so = $"Ma_so_Xu_ly=GHI_NOP_DON&Ma_so_Nhan_vien=" + NhanVien.Ma_so;
        var Dia_chi_Xu_ly = $"{Dia_chi_Dich_vu_Du_lieu}?{Tham_so}";

        dxn.Ngay_Bat_dau = Convert.ToDateTime(NgayBatDauNghi);
        dxn.So_ngay = SoNgay;
        dxn.Ngay_Nop_don = DateTime.Now;
        dxn.Ly_do = LyDoNghi;


        var Chuoi_JSON = Json.Encode(dxn);
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
            NhanVien.Danh_sach_Don_xin_nghi.Add(dxn);
        }
        return Kq;

    }

}