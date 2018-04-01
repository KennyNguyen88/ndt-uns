using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Globalization;
using System.Net;

public partial class XL_UNG_DUNG
{
    static XL_UNG_DUNG Ung_dung = null;

    XL_DU_LIEU Du_lieu_Ung_dung = null;
    List<XL_NGUOI_DUNG> Danh_sach_Nguoi_dung = new List<XL_NGUOI_DUNG>();    

    public static XL_UNG_DUNG Khoi_dong_Ung_dung()
    {

        Ung_dung = new XL_UNG_DUNG(); // Không caching 
        Ung_dung.Khoi_dong_Du_lieu_Ung_dung();
        return Ung_dung;

    }

    void Khoi_dong_Du_lieu_Ung_dung()
    {

        var Du_lieu_tu_Dich_vu = XL_DU_LIEU.Doc_Du_lieu();
        Du_lieu_Ung_dung = Du_lieu_tu_Dich_vu;         
        Danh_sach_Nguoi_dung = Du_lieu_Ung_dung.Danh_sach_Nguoi_dung;

    }    

    public XL_NGUOI_DUNG Dang_nhap(string Ten_Dang_nhap, string Mat_khau)
    {
        var Nguoi_dung = Danh_sach_Nguoi_dung.FirstOrDefault(
                                x => x.Ten_Dang_nhap == Ten_Dang_nhap
                                      && x.Mat_khau == Mat_khau
                                      && x.Nhom_Nguoi_dung.Ma_so == "NHAN_VIEN_PHUC_VU");

        if (Nguoi_dung != null)
        {
            Nguoi_dung.Danh_sach_Phieu_dat_Nhan_vien = Du_lieu_Ung_dung.Danh_sach_Phieu_dat.FindAll(PhieuDat => PhieuDat.Ma_Nhan_vien_Phuc_vu.Equals(Nguoi_dung.Ma_so) && PhieuDat.Trang_thai.Equals("CHUA_THANH_TOAN"));
            HttpContext.Current.Session["Nguoi_dung_Dang_nhap"] = Nguoi_dung;
        }
            
        return Nguoi_dung;
    }

    public string Khoi_dong_Danh_sach_Thuc_don()
    {
        List<XL_THUCDON> Danh_sach_Thuc_don = Du_lieu_Ung_dung.Nha_hang.Danh_sach_Thuc_don;

        Danh_sach_Thuc_don.ForEach(ThucDon =>
        {
            var Danh_sach_Mon_an_Cua_Thuc_Don = Du_lieu_Ung_dung.Danh_sach_Mon_an.FindAll(MonAn =>
                MonAn.Thuc_don.Ma_so.Equals(ThucDon.Ma_so)
            );
            ThucDon.Danh_sach_Mon_an = Danh_sach_Mon_an_Cua_Thuc_Don;
        });

        return Tao_Chuoi_HTML_Danh_sach_Thuc_don(Danh_sach_Thuc_don);
    }

    public string Khoi_dong_Man_hinh_Chinh()
    {

        var Nhan_vien = get_Nhan_vien();
        
        var Du_lieu_tu_Dich_vu = XL_DU_LIEU.Doc_Du_lieu();
        Du_lieu_Ung_dung = Du_lieu_tu_Dich_vu;
        Nhan_vien.Danh_sach_Phieu_dat_Nhan_vien = Du_lieu_Ung_dung.Danh_sach_Phieu_dat.FindAll(PhieuDat => PhieuDat.Ma_Nhan_vien_Phuc_vu.Equals(Nhan_vien.Ma_so) && PhieuDat.Trang_thai.Equals("CHUA_THANH_TOAN"));

        var Chuoi_HTML = $"<div>";
        Chuoi_HTML += Tao_Chuoi_HTML_Danh_sach_Phieu_Dat(Nhan_vien.Danh_sach_Phieu_dat_Nhan_vien);
        Chuoi_HTML += $"</div>";
        return Chuoi_HTML;

    }

    public string Chon_Thuc_don(string Ma_so_Thuc_don)
    {        
        var Thuc_don = (XL_THUCDON)Tim_Thuc_don_Theo_Ma(Ma_so_Thuc_don);

        return Tao_Chuoi_HTML_Danh_Sach_Mon_An_Xem(Thuc_don.Danh_sach_Mon_an);

    }

    public string Sua_Phieu_dat(string Ma_so_Phieu_dat)
    {
        XL_PHIEU_DAT Phieu_dat = Tim_Phieu_dat_Theo_Ma(Ma_so_Phieu_dat);
        HttpContext.Current.Session["Phieu_dat_Dang_Sua"] = Phieu_dat;

        return Tao_Chuoi_HTML_Sua_Phieu_dat();
    }

    public string Khoi_dong_Them_Phieu_dat(string Ma_so_Mon_an)
    {
        var Nhan_vien = get_Nhan_vien();
        var Danh_sach_Chon = Nhan_vien.Danh_sach_Mon_an_Chon;
        var Mon_an = (XL_DANH_SACH_MON_AN)Danh_sach_Chon.FirstOrDefault(Ds_Chon => Ds_Chon.Ma_so_Mon_an.Equals(Ma_so_Mon_an));

        if (Mon_an != null && Mon_an.So_luong > 0)
        {
            Mon_an.So_luong += 1;
        }
        else
        {
            XL_DANH_SACH_MON_AN Mon_an_Them = new XL_DANH_SACH_MON_AN();
            Mon_an_Them.Ma_so_Mon_an = Ma_so_Mon_an;
            Mon_an_Them.So_luong = 1;
            Nhan_vien.Danh_sach_Mon_an_Chon.Add(Mon_an_Them);
        }

        return Tao_Chuoi_HTML_Tao_Moi_Phieu_dat();
    }

    public string Them_Phieu_dat(string So_ban)
    {
        var Chuoi_HTML = $"";

        XL_NGUOI_DUNG Nhan_vien = get_Nhan_vien();
        XL_PHIEU_DAT Phieu_dat_moi = new XL_PHIEU_DAT();
        Phieu_dat_moi.Ban = int.Parse(So_ban);
        Phieu_dat_moi.Ma_Nhan_vien_Phuc_vu = Nhan_vien.Ma_so;
        Phieu_dat_moi.Danh_sach_Mon_an = Nhan_vien.Danh_sach_Mon_an_Chon;

        if (XL_DU_LIEU.Ghi_Phieu_dat(Phieu_dat_moi).Equals("OK")){
            
            Nhan_vien.Danh_sach_Mon_an_Chon.Clear();

            Chuoi_HTML += $"<div class='mb-5'> Thêm thành công </div>";            
        }
        else
        {
            Chuoi_HTML += $"<div class='mb-5'> Thêm thất bại </div>";
        }

        Chuoi_HTML += Khoi_dong_Man_hinh_Chinh();
        return Chuoi_HTML;
    }

    public string Xoa_Mon_an_Da_chon(string Ma_so_Mon_an)
    {
        var Nhan_vien = get_Nhan_vien();
        var Danh_sach_Chon = Nhan_vien.Danh_sach_Mon_an_Chon;
        var Mon_an = (XL_DANH_SACH_MON_AN)Danh_sach_Chon.FirstOrDefault(Ds_Chon => Ds_Chon.Ma_so_Mon_an.Equals(Ma_so_Mon_an));

        if (Mon_an != null && Mon_an.So_luong > 1)
        {
            Mon_an.So_luong -= 1;
        }
        else
        {
            Nhan_vien.Danh_sach_Mon_an_Chon.Remove(Mon_an);
        }

        return Tao_Chuoi_HTML_Tao_Moi_Phieu_dat();
    }

    public string Xoa_Mon_an_Phieu_dat(string Ma_so_Mon_an)
    {
        XL_PHIEU_DAT Phieu = get_Phieu_dat();
        var Mon_an = (XL_DANH_SACH_MON_AN)Phieu.Danh_sach_Mon_an.FirstOrDefault(Ds_Chon => Ds_Chon.Ma_so_Mon_an.Equals(Ma_so_Mon_an));
        if (Mon_an != null && Mon_an.So_luong > 1)
        {
            Mon_an.So_luong -= 1;
        }
        else
        {
            Phieu.Danh_sach_Mon_an.Remove(Mon_an);
        }
        return Tao_Chuoi_HTML_Sua_Phieu_dat();
    }

    public string Them_Mon_an_Phieu_dat(string Ma_so_Mon_an)
    {
        XL_PHIEU_DAT Phieu = get_Phieu_dat();
        var Mon_an = (XL_DANH_SACH_MON_AN)Phieu.Danh_sach_Mon_an.FirstOrDefault(Ds_Chon => Ds_Chon.Ma_so_Mon_an.Equals(Ma_so_Mon_an));
        if (Mon_an != null)
        {
            Mon_an.So_luong += 1;
        }
        return Tao_Chuoi_HTML_Sua_Phieu_dat();
    }

    public string Tra_cuu(string Chuoi_Tra_cuu)
    {
        var Chuoi_HTML = $"";
        List<XL_MONAN> Danh_sach_Mon_an = Tim_Mon_an_Theo_Ten(Chuoi_Tra_cuu);
        if (Danh_sach_Mon_an != null && Danh_sach_Mon_an.Count > 0)
        {
            Chuoi_HTML = Tao_Chuoi_HTML_Danh_Sach_Mon_An_Xem(Danh_sach_Mon_an);
        }
        else
        {
            Chuoi_HTML = $"<h1> Không thìm thấy món ăn phù hợp </h1>";
        }        
        return Chuoi_HTML;
    }

    public string Cap_nhat_Phieu_dat(string So_ban)
    {
        var Chuoi_HTML = $"";

        XL_PHIEU_DAT Phieu = get_Phieu_dat();
        Phieu.Ban = int.Parse(So_ban);

        if (XL_DU_LIEU.Cap_nhat_Phieu_dat(Phieu).Equals("OK")) {
            Chuoi_HTML += $"<div class='mb-5'> Cập nhật thành công </div>";
        }
        else
        {
            Chuoi_HTML += $"<div class='mb-5'> Cập nhật thất bại </div>";
        }
        Chuoi_HTML += Khoi_dong_Man_hinh_Chinh();
        return Chuoi_HTML;
    }
}
//************************* Business-Layers BL **********************************
public partial class XL_UNG_DUNG
{

    public XL_THUCDON Tim_Thuc_don_Theo_Ma(String Ma_so_Thuc_don)
    {
        List<XL_THUCDON> Danh_sach_Thuc_Don = Du_lieu_Ung_dung.Nha_hang.Danh_sach_Thuc_don;

        return Danh_sach_Thuc_Don.FirstOrDefault(ThucDon => ThucDon.Ma_so.Equals(Ma_so_Thuc_don));

    }

    public XL_MONAN Tim_Mon_an_Theo_Ma(String Ma_so_Mon_an)
    {
        List<XL_MONAN> Danh_sach_Mon_an = Du_lieu_Ung_dung.Danh_sach_Mon_an;
        return Danh_sach_Mon_an.FirstOrDefault(Mon_an => Mon_an.Ma_so.Equals(Ma_so_Mon_an));
    }

    public XL_PHIEU_DAT Tim_Phieu_dat_Theo_Ma(String Ma_Phieu)
    {
        List<XL_PHIEU_DAT> Danh_sach_Phieu_dat = Du_lieu_Ung_dung.Danh_sach_Phieu_dat;
        return Danh_sach_Phieu_dat.FirstOrDefault(Phieu => Phieu.Ma_so.Equals(Ma_Phieu));
    }

    public List<XL_MONAN> Tim_Mon_an_Theo_Ten(String Ten_Mon_an)
    {
        List<XL_MONAN> Danh_sach_Mon_an = Du_lieu_Ung_dung.Danh_sach_Mon_an;
        return Danh_sach_Mon_an.FindAll(Mon_an => Mon_an.Ten.ToUpper().Contains(Ten_Mon_an.ToUpper()));
    }

    public XL_NGUOI_DUNG get_Nhan_vien()
    {

        return (XL_NGUOI_DUNG)HttpContext.Current.Session["Nguoi_dung_Dang_nhap"];

    }

    public XL_PHIEU_DAT get_Phieu_dat()
    {
        return (XL_PHIEU_DAT)HttpContext.Current.Session["Phieu_dat_Dang_Sua"];
    }


}
//************************* View-Layers/Presentation Layers VL/PL **********************************
public partial class XL_UNG_DUNG
{
    public string Dia_chi_Media = $"{XL_DU_LIEU.Dia_chi_Dich_vu}/Media";
    public CultureInfo Dinh_dang_VN = CultureInfo.GetCultureInfo("vi-VN");

    public string Tao_Chuoi_HTML_Danh_sach_Thuc_don(List<XL_THUCDON> Danh_sach)
    {
        var Nguoi_dung = (XL_NGUOI_DUNG) HttpContext.Current.Session["Nguoi_dung_Dang_nhap"];
        var Chuoi_HTML_Nguoi_dung = Tao_Chuoi_HTML_Nguoi_dung_Dang_nhap();
        var Chuoi_HTML_Tra_cuu = Tao_Chuoi_HTML_Tra_Cuu();

        var Chuoi_HTML_Danh_sach = $"<ul class='navbar-nav side-nav'>";
        Chuoi_HTML_Danh_sach += Chuoi_HTML_Nguoi_dung;
        Chuoi_HTML_Danh_sach += Chuoi_HTML_Tra_cuu;

        Danh_sach.ForEach(ThucDon =>
        {
            var Chuoi_HTML = $"<li class='nav-item'>" +
            $"<form method='post'>" +
            $"<input name='Th_Ma_so_Chuc_nang' type='hidden' value='{Nguoi_dung.Chuc_nang_Chon_Thuc_don.Ma_so}' />" +
            $"<input name='Th_Ma_so_Thuc_don' type='hidden' value='{ThucDon.Ma_so}' />" +
            $"<button type='submit' class='nav-link' style='background: transparent; width: 100%; border: 0; text-align: left;'>{ThucDon.Ten} ({ThucDon.Danh_sach_Mon_an.Count})</button> " +
            $"</form>" +
            $"</li>";
            Chuoi_HTML_Danh_sach += Chuoi_HTML;
        });
        Chuoi_HTML_Danh_sach += $"</ul>";

        return Chuoi_HTML_Danh_sach;
    }

    public string Tao_Chuoi_HTML_Nguoi_dung_Dang_nhap()
    {
        var Nguoi_dung = get_Nhan_vien();

        var Chuoi_HTML = $"<li style='padding: 5px;border-bottom: 1px solid white;'>" +
            $"<img src='https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSYoOFL8ckGQwuuNVJjbw60zt7asA1mxErH0cTGP3w3YzWdI6eu-w' class='img-fluid' />" +
            $"<p style='text-align: center; color: white; margin: 5px 0;'>{Nguoi_dung.Ho_ten} <br> {Nguoi_dung.Nhom_Nguoi_dung.Ten} </p> " +
            $"</li>";
        return Chuoi_HTML;
    }

    public string Tao_Chuoi_HTML_Tra_Cuu()
    {
        var Nhan_vien = get_Nhan_vien();

        var Chuoi_HTML = $"<li style='border-bottom: 1px solid white;'>" +
            $"<form method='post' class='form-inline'>" +
            $"<input name='Th_Ma_so_Chuc_nang' type='hidden' value='{Nhan_vien.Chuc_nang_Tra_cuu.Ma_so}' />" +
            $"<input name='Th_Chuoi_Tra_cuu' spellcheck='false' autocomplete='off' placeholder='Tìm món ăn' />" +
            $"</form>" +
            $"</li>";
        return Chuoi_HTML;
    }

    public string Tao_Chuoi_HTML_Danh_Sach_Mon_An_Xem(List<XL_MONAN> Danh_sach_Mon_an)
    {
        var Chuoi_HTML = $"<div class='row'>";

        Danh_sach_Mon_an.ForEach(Monan =>
        {
            Chuoi_HTML += Tao_Chuoi_HTML_Mon_an_Xem(Monan);
        });

        Chuoi_HTML += $"</div>";

        return Chuoi_HTML;
    }

    public string Tao_Chuoi_HTML_Mon_an_Xem(XL_MONAN Mon_an)
    {    
        var Nhan_vien = get_Nhan_vien();

        var Chuoi_HTML = $"<div class='col-md-4 col-sm-12'>" +
            $"<div class='card'>" +
            $"<img class='card-img-top' src='{Dia_chi_Media}/{Mon_an.Ma_so}.jpg'>" +
            $"<div class='card-body'>" +
            $"<h5 class='card-title'>{Mon_an.Ten}</h5>" +
            $"<h6 class='card-subtitle mb-2 text-muted'>{Mon_an.Don_gia_Ban} VND</h6>" +
            $"<p> <form method='post'>" +
            $"<input type='hidden' name='TH_Ma_Mon_an' value='{Mon_an.Ma_so}'/>" +
            $"<input type='hidden' name='Th_Ma_so_Chuc_nang' value='{Nhan_vien.Chuc_nang_Chon_Mon_an.Ma_so}' /> <button type='submit' class='submit-link' style='color: red;'> Chọn </button>" +
            $"</form> " +
            $"</p>";    
        Chuoi_HTML += $"</div></div></div>";

        return Chuoi_HTML;
    }
    
    public string Tao_Chuoi_HTML_Mon_an_Ghi(XL_MONAN Mon_an, int So_luong)
    {
        var Nhan_vien = get_Nhan_vien();

        var Chuoi_HTML = $"<div class='col-12 mb-2'>" +
            $"<div class='media' style='align-items: center;'>" +
            $"<img style='width: 150px;' class='mr-3' src='{Dia_chi_Media}/{Mon_an.Ma_so}.jpg'>" +
            $"<div style='display: flex; justify-content: space-between;' class='media-body'>" +
            $"<h5 class='mt-0'>{Mon_an.Ten}</h5>" +
            $"<h5 class='mt-0'>{So_luong} x {Mon_an.Don_gia_Ban}</h5>" +
            $"<form method='post'>" +
            $"<input type='hidden' name='Th_Ma_so_Chuc_nang' value='{Nhan_vien.Chuc_nang_Xoa_Mon_an.Ma_so}' />" +
            $"<input type='hidden' name='TH_Ma_Mon_an' value='{Mon_an.Ma_so}' />" +
            $"<button class='btn btn-primary' type='submit'>Xóa</button>" +
            $"</form>" +
            $"<form method='post'>" +
            $"<input type='hidden' name='Th_Ma_so_Chuc_nang' value='{Nhan_vien.Chuc_nang_Them_Mon_an.Ma_so}' />" +
            $"<input type='hidden' name='TH_Ma_Mon_an' value='{Mon_an.Ma_so}' />" +
            $"<button class='btn btn-primary' type='submit'>Thêm</button>" +
            $"</form>" +
            $"</div>" +
            $"</div>";           
        Chuoi_HTML += $"</div>";

        return Chuoi_HTML;
    }

    public string Tao_Chuoi_HTML_Danh_sach_Phieu_Dat(List<XL_PHIEU_DAT> Danh_sach)
    {
        var Chuoi_HTML = $"<div class='row'>";
       
        Danh_sach.ForEach(Phieu =>
        {
            Chuoi_HTML += Tao_Chuoi_HTML_Phieu_Dat(Phieu);
        });
        
        Chuoi_HTML += $"</div>";

        return Chuoi_HTML;
    }

    public string Tao_Chuoi_HTML_Phieu_Dat(XL_PHIEU_DAT Phieu)
    {
        var Nhan_vien = get_Nhan_vien();

        var Chuoi_HTML = $"<div class='col-md-4 col-sm-12'>" +
            $"<form method='post'>" +
            $"<input name='Th_Ma_so_Chuc_nang' type='hidden' value='{Nhan_vien.Chuc_nang_Sua_Phieu_dat.Ma_so}' />" +
            $"<input name='Th_Ma_so_Phieu_dat' type='hidden' value='{Phieu.Ma_so}' />" +
            $"<div class='card' style='position: relative'>" +
            $"<div style='font-size: 2rem;position: absolute; left: 50%; width: 50px; height: 50px; background-color: red; border-radius: 100%; color: white; margin-left: -25px; top: -25px; text-align: center;'>{Phieu.Ban} </div>" +
            $"<div class='card-body'>" +
            $"<h5 style='display: flex; justify-content: space-between;' class='card-title'>{Phieu.Thanh_tien} <span> <button style='color: blue;' class='submit-link' type='submit'>Sửa</button> </span></h5>" +            
            $"<h6 class='card-subtitle mb-2 text-muted'>{Phieu.Thoi_gian_dat}</h6>" +
            $"</form>" +
            $"</div>";

        Chuoi_HTML += $"<ul class='list-group list-group-flush'>";

        Phieu.Danh_sach_Mon_an.ForEach(DS_Mon_An =>
        {
            XL_MONAN Mon_an = Tim_Mon_an_Theo_Ma(DS_Mon_An.Ma_so_Mon_an);
            Chuoi_HTML += $"<li style='display: flex; justify-content: space-between;' class='list-group-item'>{Mon_an.Ten} <div><span class='badge badge-secondary'>{DS_Mon_An.So_luong}</span> x <span class='badge badge-secondary'>{Mon_an.Don_gia_Ban}</span><div></li>";
        });

        Chuoi_HTML += $"</ul>";
        Chuoi_HTML += $"</div></div>";

        return Chuoi_HTML;
    }

    public string Tao_Chuoi_HTML_Tao_Moi_Phieu_dat()
    {
        var Nhan_vien = get_Nhan_vien();

        var Chuoi_HTML = $"<div class='row'>";

        Nhan_vien.Danh_sach_Mon_an_Chon.ForEach(MonAnDS =>
        {
            XL_MONAN Monan = Tim_Mon_an_Theo_Ma(MonAnDS.Ma_so_Mon_an);

            Chuoi_HTML += Tao_Chuoi_HTML_Mon_an_Ghi(Monan, (int) MonAnDS.So_luong);
        });

        Chuoi_HTML += $"<div class='col-12'> " +
            $"<form method='post' style='display: flex; justify-content: flex-end;'>" +
            $"<input type='hidden' name='Th_Ma_so_Chuc_nang' value='{Nhan_vien.Chuc_nang_Them_Phieu_dat.Ma_so}' />" +
            $"<select name='Th_So_ban' id='Th_So_ban'>" +
            $"<option value='' selected> Chọn số bàn </option>" +
            $"<option value='1'> 1 </option>" +
            $"<option value='2'> 2 </option>" +
            $"<option value='3'> 3 </option>" +
            $"<option value='4'> 4 </option>" +
            $"<option value='5'> 5 </option>" +
            $"<option value='6'> 6 </option>" +
            $"<option value='7'> 7 </option>" +
            $"<option value='8'> 8 </option>" +
            $"<option value='9'> 9 </option>" +
            $"<option value='10'> 10 </option>" +
            $"</select>" +
            $"<button type='submit' class='btn btn-primary ml-5 disabled' id='btn_Them_phieu_dat'> Tạo phiếu đặt </button> " +
            $"</form> " +
            $"</div> ";

        Chuoi_HTML += $"</row>";

        return Chuoi_HTML;
    }
    
    public string Tao_Chuoi_HTML_Sua_Phieu_dat()
    {
        var Nhan_vien = get_Nhan_vien();
        var Phieu_dat = get_Phieu_dat();
        var Chuoi_HTML = $"<div class='row'>";

        Phieu_dat.Danh_sach_Mon_an.ForEach(MonAnDS =>
        {
            XL_MONAN Monan = Tim_Mon_an_Theo_Ma(MonAnDS.Ma_so_Mon_an);

            Chuoi_HTML += Tao_Chuoi_HTML_Mon_an_Sua(Monan, (int)MonAnDS.So_luong);
        });

        Chuoi_HTML += $"<div class='col-12'> " +
            $"<form method='post' style='display: flex; justify-content: flex-end;'>" +
            $"<input type='hidden' name='Th_Ma_so_Chuc_nang' value='{Nhan_vien.Chuc_nang_Cap_nhat_Phieu_dat.Ma_so}' />" +
            $"<input type='hidden' name='Th_Ma_so_Phieu_dat' value='{Phieu_dat.Ma_so}' />" +
            $"<select name='Th_So_ban' id='Th_So_ban'>" +            
            $"<option value='1' " + (Phieu_dat.Ban == 1 ? "selected" : "") + $"> 1 </option>" +
            $"<option value='2' " + (Phieu_dat.Ban == 2 ? "selected" : "") + $"> 2 </option>" +
            $"<option value='3' " + (Phieu_dat.Ban == 3 ? "selected" : "") + $"> 3 </option>" +
            $"<option value='4' " + (Phieu_dat.Ban == 4 ? "selected" : "") + $"> 4 </option>" +
            $"<option value='5' " + (Phieu_dat.Ban == 5 ? "selected" : "") + $"> 5 </option>" +
            $"<option value='6' " + (Phieu_dat.Ban == 6 ? "selected" : "") + $"> 6 </option>" +
            $"<option value='7' " + (Phieu_dat.Ban == 7 ? "selected" : "") + $"> 7 </option>" +
            $"<option value='8' " + (Phieu_dat.Ban == 8 ? "selected" : "") + $"> 8 </option>" +
            $"<option value='9' " + (Phieu_dat.Ban == 9 ? "selected" : "") + $"> 9 </option>" +
            $"<option value='10' " + (Phieu_dat.Ban == 10 ? "selected" : "") + $"> 10 </option>" +
            $"</select>" +
            $"<button type='submit' class='btn btn-primary ml-5' id='btn_Them_phieu_dat'> Sửa phiếu đặt </button> " +
            $"</form> " +
            $"</div> ";

        Chuoi_HTML += $"</row>";

        return Chuoi_HTML;
    }

    public string Tao_Chuoi_HTML_Mon_an_Sua(XL_MONAN Mon_an, int So_luong)
    {
        var Nhan_vien = get_Nhan_vien();
        var Phieu_dat = get_Phieu_dat();

        var Chuoi_HTML = $"<div class='col-12 mb-2'>" +
            $"<div class='media' style='align-items: center;'>" +
            $"<img style='width: 150px;' class='mr-3' src='{Dia_chi_Media}/{Mon_an.Ma_so}.jpg'>" +
            $"<div style='display: flex; justify-content: space-between;' class='media-body'>" +
            $"<h5 class='mt-0'>{Mon_an.Ten}</h5>" +
            $"<h5 class='mt-0'>{So_luong} x {Mon_an.Don_gia_Ban}</h5>" +
            $"<form method='post'>" +
            $"<input type='hidden' name='Th_Ma_so_Chuc_nang' value='{Nhan_vien.Chuc_nang_Xoa_Mon_an_Phieu_dat.Ma_so}' />" +
            $"<input type='hidden' name='TH_Ma_Mon_an' value='{Mon_an.Ma_so}' />" +
            $"<input type='hidden' name='TH_Ma_Phieu_dat' value='{Phieu_dat.Ma_so}' />" +
            $"<button class='btn btn-primary' type='submit'>Xóa</button>" +
            $"</form>" +
            $"<form method='post'>" +
            $"<input type='hidden' name='Th_Ma_so_Chuc_nang' value='{Nhan_vien.Chuc_nang_Them_Mon_an_Phieu_dat.Ma_so}' />" +
            $"<input type='hidden' name='TH_Ma_Mon_an' value='{Mon_an.Ma_so}' />" +
            $"<input type='hidden' name='TH_Ma_Phieu_dat' value='{Phieu_dat.Ma_so}' />" +
            $"<button class='btn btn-primary' type='submit'>Thêm</button>" +
            $"</form>" +
            $"</div>" +
            $"</div>";
        Chuoi_HTML += $"</div>";

        return Chuoi_HTML;
    }
}

//************************* Data-Layers DL **********************************
public partial class XL_DU_LIEU
{
    public static string Dia_chi_Dich_vu = "http://localhost:53850";
    static string Dia_chi_Dich_vu_Du_lieu = $"{Dia_chi_Dich_vu}/1-Dich_vu_Giao_tiep/DV_Chinh.cshtml";

    public static XL_DU_LIEU Doc_Du_lieu()
    {

        var Xu_ly = new WebClient();
        Xu_ly.Encoding = System.Text.Encoding.UTF8;
        var Tham_so = "Ma_so_Xu_ly=KHOI_DONG_DU_LIEU_NHAN_VIEN_PHUC_VU";
        var Dia_chi_Xu_ly = $"{Dia_chi_Dich_vu_Du_lieu}?{Tham_so}";
        var Chuoi_JSON = Xu_ly.DownloadString(Dia_chi_Xu_ly);
        var Du_lieu = Json.Decode<XL_DU_LIEU>(Chuoi_JSON);
        return Du_lieu;
    }

    public static string Ghi_Phieu_dat(XL_PHIEU_DAT Phieu_dat)
    {
        var Kq = "";
        var Xu_ly = new WebClient();
        Xu_ly.Encoding = System.Text.Encoding.UTF8;
        var Tham_so = $"Ma_so_Xu_ly=GHI_PHIEU_DAT_MOI";
        var Dia_chi_Xu_ly = $"{Dia_chi_Dich_vu_Du_lieu}?{Tham_so}";
        var Chuoi_JSON = Json.Encode(Phieu_dat);
        try
        {
            Kq = Xu_ly.UploadString(Dia_chi_Xu_ly, Chuoi_JSON).Trim();
        }
        catch (Exception Loi)
        {
            Kq = Loi.Message;
        }        
        return Kq;
    }

    public static string Cap_nhat_Phieu_dat(XL_PHIEU_DAT Phieu_dat)
    {
        var Kq = "";
        var Xu_ly = new WebClient();
        Xu_ly.Encoding = System.Text.Encoding.UTF8;
        var Tham_so = $"Ma_so_Xu_ly=CAP_NHAT_PHIEU_DAT";
        var Dia_chi_Xu_ly = $"{Dia_chi_Dich_vu_Du_lieu}?{Tham_so}";
        var Chuoi_JSON = Json.Encode(Phieu_dat);
        try
        {
            Kq = Xu_ly.UploadString(Dia_chi_Xu_ly, Chuoi_JSON).Trim();
        }
        catch (Exception Loi)
        {
            Kq = Loi.Message;
        }
        return Kq;
    }

}