using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    class THU_VIEN
    {
        //properties
        ArrayList _listDocGia;
        ArrayList _listSach;
        ArrayList _listPhieu;
        //constructor
        public THU_VIEN()
        {
            _listDocGia = this.getListDocGia();
            _listSach = this.getListSach();
            _listPhieu = this.getListPhieu();
        }
        //methods
        //Tat ca sach tu thu vien
        public ArrayList getListSach()
        {
            ArrayList result = new ArrayList();
            result = UTIL.getFilesSach();
            return result;
        }
        //In tat ca dau sach hien co trong thu vien
        public void printListSach()
        {
            if (this._listSach != null && this._listSach.Count > 0)
            {
                Console.WriteLine("Co tat ca " + this._listSach.Count + " dau sach trong thu vien");
                foreach (SACH sach in this._listSach)
                {
                    sach.printShortDesc();
                }
            }
            else
            {
                Console.WriteLine("Khong co sach nao trong thu vien");
            }
        }
        //true neu sach co trong thu vien
        public bool isSachExist(String ISBN)
        {
            if (this.getSachISBN(ISBN) != null)
            {
                return true;
            }            
            return false;
        }
        //true neu them sach thanh cong
        public bool ThemSach(SACH sach)
        {            
            this._listSach.Add(sach);
            return sach.write();
        }
        //true neu cap nhat sach thanh cong
        public bool CapNhatSach(SACH sach)
        {
            return sach.write();
        }
        //true neu xoa sach thanh cong
        public bool XoaSach(SACH sach)
        {            
            this._listSach.Remove(sach);            
            return sach.delete();
        }
        //Tim kiem sach theo ISBN
        public SACH getSachISBN(String ISBN)
        {
            if (this._listSach.Count > 0)
            {
                foreach (SACH sach in this._listSach)
                {
                    if (sach.ISBN.ToUpper().Equals(ISBN.ToUpper()))
                    {
                        return sach;
                    }
                }
            }
            return null;
        }        
        //Tim kiem sach theo ten sach
        public ArrayList getSachTen(String TenSach)
        {
            ArrayList result = new ArrayList();
            if (this._listSach.Count > 0)
            {
                foreach (SACH sach in this._listSach)
                {
                    if (sach.TenSach.ToUpper().Equals(TenSach.ToUpper()))
                    {
                        result.Add(sach);
                    }
                }
            }
            return result;
        }
        //Tim kiem sach
        public SACH getSach()
        {
            Console.WriteLine("Chon phuong thuc tim kiem sach: ");
            Console.WriteLine("1 - Tim kiem sach theo ISBN");
            Console.WriteLine("2 - Tim kiem sach theo Ten Sach");
            try
            {
                int method = int.Parse(Console.ReadLine());
                if (method == 1)
                {
                    Console.WriteLine("Nhap ISBN");
                    String ISBN = Console.ReadLine();
                    return this.getSachISBN(ISBN);
                }
                else if (method == 2)
                {
                    Console.WriteLine("Nhap Ten Sach");
                    String TenSach = Console.ReadLine();
                    ArrayList listSach = this.getSachTen(TenSach);

                    if (listSach != null && listSach.Count > 1)
                    {
                        Console.WriteLine("Co nhieu sach trung ten. Vui long nhap so thu tu sach can tim");
                        int step = 0;
                        foreach (SACH sach in listSach)
                        {
                            Console.WriteLine(step);
                            sach.printShortDesc();
                            step++;
                        }
                        int find = int.Parse(Console.ReadLine());
                        if (find < 0 || find > listSach.Count - 1)
                        {
                            Console.WriteLine("Du lieu chon khong chinh xac !");
                        }
                        else
                        {
                            return (SACH)listSach[find];
                        }
                    }
                    else if (listSach != null & listSach.Count == 1)
                    {
                        return (SACH)listSach[0];
                    }
                }
                else
                {
                    Console.WriteLine("Vui long nhap 1 hoac 2");                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Vui long nhap 1 hoac 2");
                
            }
            return null;

        }
        
        //Tat ca doc gia trong thu vien
        public ArrayList getListDocGia()
        {
            ArrayList result = new ArrayList();
            result = UTIL.getFilesDocGia();
            return result;
        }
        //In Tat ca doc gia trong thu vien
        public void printListDocGia()
        {
            if (this._listDocGia != null && this._listDocGia.Count > 0)
            {
                Console.WriteLine("Co tat ca " + this._listDocGia.Count + " doc gia trong thu vien");
                foreach(DOC_GIA docgia in this._listDocGia)
                {
                    docgia.printShortDesc();
                }
            }
            else
            {
                Console.WriteLine("Khong co doc gia nao trong thu vien");
            }
        }
        //true neu doc gia co trong thu vien
        public bool isDocGiaExist(String CMND)
        {
            if(this.getDocGiaCMND(CMND) != null)
            {
                return true;
            }
            return false;
        }
        //true neu ma doc gia da co
        public bool isMaDocGiaExist(String MaDocGia)
        {
            if (this.getDocGiaMa(MaDocGia) != null)
            {
                return true;
            }
            return false;
        }
        //true neu them docgia thanh cong
        public bool ThemDocGia(DOC_GIA docgia)
        {
            this._listDocGia.Add(docgia);
            return docgia.write();
        }
        //true neu cap nhat doc gia thanh cong
        public bool CapNhatDocGia(DOC_GIA docgia)
        {
            return docgia.write();
        }
        //true neu xoa doc gia thanh cong
        public bool XoaDocGia(DOC_GIA docgia)
        {
            this._listDocGia.Remove(docgia);
            return docgia.delete();
        }
        //Tim kiem doc gia theo MaDocGIa
        public DOC_GIA getDocGiaMa(String MaDocGia)
        {
            if (this._listDocGia.Count > 0)
            {
                foreach(DOC_GIA docgia in this._listDocGia)
                {
                    if (docgia.MaDocGia.ToUpper().Equals(MaDocGia.ToUpper()))
                    {
                        return docgia;
                    }
                }
            }
            return null;
        }
        //Tim kiem doc gia theo CMND
        public DOC_GIA getDocGiaCMND(String CMND)
        {
            if (this._listDocGia.Count > 0)
            {
                foreach (DOC_GIA docgia in this._listDocGia)
                {
                    if (docgia.CMND.ToUpper().Equals(CMND.ToUpper()))
                    {
                        return docgia;
                    }
                }
            }
            return null;
        }
        //Tim kiem doc gia theo ten
        public ArrayList getDocGiaTen(String TenDocGia)
        {
            ArrayList result = new ArrayList();
            if (this._listDocGia.Count > 0)
            {
                foreach (DOC_GIA docgia in this._listDocGia)
                {
                    if (docgia.HoTen.ToUpper().Equals(TenDocGia.ToUpper()))
                    {
                        result.Add(docgia);
                    }
                }
            }
            return result;
        }
        //Tim kiem doc gia
        public DOC_GIA getDocGia()
        {
            Console.WriteLine("Chon phuong thuc tim kiem doc gia: ");
            Console.WriteLine("1 - Tim kiem doc gia theo CMND");
            Console.WriteLine("2 - Tim kiem doc gia theo Ho Ten");
            try
            {
                int method = int.Parse(Console.ReadLine());
                if (method == 1)
                {
                    Console.WriteLine("Nhap CMND");
                    String CMND = Console.ReadLine();
                    return this.getDocGiaCMND(CMND);
                }
                else if (method == 2)
                {
                    Console.WriteLine("Nhap Ho Ten");
                    String HoTen = Console.ReadLine();
                    ArrayList listDocGia = this.getDocGiaTen(HoTen);

                    if (listDocGia != null && listDocGia.Count > 1)
                    {
                        Console.WriteLine("Co nhieu doc gia trung ten. Vui long nhap so thu tu doc gia can tim");
                        int step = 0;
                        foreach (DOC_GIA docgia in listDocGia)
                        {
                            Console.WriteLine(step);
                            docgia.printShortDesc();
                            step++;
                        }
                        int find = int.Parse(Console.ReadLine());
                        if (find < 0 || find > listDocGia.Count - 1)
                        {
                            Console.WriteLine("Du lieu chon khong chinh xac !");
                        }
                        else
                        {
                            return (DOC_GIA)listDocGia[find];
                        }
                    }
                    else if (listDocGia != null & listDocGia.Count == 1)
                    {
                        return (DOC_GIA)listDocGia[0];
                    }
                }
                else
                {
                    Console.WriteLine("Vui long nhap 1 hoac 2");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Vui long nhap 1 hoac 2");

            }
            return null;
        }

        //Tat ca phieu muon/tra sach
        public ArrayList getListPhieu()
        {
            //TODO
            ArrayList result = new ArrayList();
            result = UTIL.getFilesPhieu();
            return result;
        }
        //true neu phieu co trong thu vien
        public bool isPhieuExist(String MaPhieu)
        {
            if (this.getPhieuMa(MaPhieu) != null)
            {
                return true;
            }
            return false;
        }
        //true neu co phieu chua tra
        public bool havePhieuNotFinish(String MaDocGia)
        {
            ArrayList listPhieu = getPhieuDocGia(MaDocGia);
            if (listPhieu != null && listPhieu.Count > 0)
            {
                foreach(PHIEU phieu in listPhieu)
                {
                    if (phieu.NgayTraThucTe == null || phieu.NgayTraThucTe == "")
                    {
                        return true;
                    }                    
                }
            }
            return false;
        }
        //true neu danh sach cach sach muon dat yeu cau
        public bool checkSachMuon(PHIEU phieu)
        {
            foreach(String isbn in phieu.SachMuon)
            {
                SACH sach = getSachISBN(isbn);
                if (sach == null || sach.SoQuyen < 1)
                {
                    return false;
                }
            }
            return true;
        }
        //true neu them phieu thanh cong
        public bool ThemPhieu(PHIEU phieu)
        {
            this._listPhieu.Add(phieu);
            //cap nhat so luong sach trong thu vien
            foreach(String isbn in phieu.SachMuon)
            {
                SACH sach = getSachISBN(isbn);
                sach.SoQuyen = sach.SoQuyen - 1;
                if (!sach.write())
                {
                    return false;
                }
            }
            return phieu.write();
        }
        //true neu cap nhat phieu thanh cong
        public bool CapNhatPhieu(PHIEU phieu)
        {
            Console.WriteLine("Xac nhan so luong sach tra");
            try
            {
                ArrayList listMuon = new ArrayList(phieu.SachMuon);
                foreach (String isbn in listMuon)
                {
                    SACH sach = getSachISBN(isbn);               
                    Console.WriteLine("Nhap 1 neu co tra sach nay, 0 neu sach bi mat");
                    sach.printShortDesc();
                    int select = int.Parse(Console.ReadLine());
                    if (select == 1)
                    {
                        phieu.SachMuon.Remove(sach.ISBN);
                    }
                }
                return phieu.write();
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        //Tim kiem phieu theo MaPhieu
        public PHIEU getPhieuMa(String MaPhieu)
        {
            if (this._listPhieu.Count > 0)
            {
                foreach (PHIEU phieu in this._listPhieu)
                {
                    if (phieu.MaPhieu.ToUpper().Equals(MaPhieu.ToUpper()))
                    {
                        return phieu;
                    }
                }
            }
            return null;
        }
        //Tim kiem phieu theo MaDocGia
        public ArrayList getPhieuDocGia(String MaDocGia)
        {
            ArrayList result = new ArrayList();
            if (this._listPhieu.Count > 0)
            {
                foreach (PHIEU phieu in this._listPhieu)
                {
                    if (phieu.MaDocGia.ToUpper().Equals(MaDocGia.ToUpper()))
                    {
                        result.Add(phieu);
                    }
                }
            }
            return result;
        }
        //In Thong Tin Phieu Doc Gia
        public void printPhieuMuonSach(PHIEU phieu)
        {
            Console.WriteLine("Ma Phieu: " + phieu.MaPhieu);
            DOC_GIA docgia = getDocGiaMa(phieu.MaDocGia);
            docgia.printShortDesc();
            Console.WriteLine("Ngay Muon: " + UTIL.formatStringToDate(phieu.NgayMuon).ToShortDateString());
            Console.WriteLine("Ngay Tra Du Kien: " + UTIL.formatStringToDate(phieu.NgayTraDuKien).ToShortDateString());
            Console.WriteLine("Cac sach da muon: ");
            foreach (String isbn in phieu.SachMuon)
            {
                SACH sach = getSachISBN(isbn);
                sach.printShortDesc();
            }
        }
        //listSach : list sach da muon
        //phieu.SachMuon: list sach bi mat
        public void printPhieuTraSach(PHIEU phieu, ArrayList listSach)
        {
            int ngaytrehan = phieu.calculateSoNgayTreHan();
            int sachmat = phieu.SachMuon.Count;
            double tientrehan = 0;
            double tienmat = 0;
            double tong = 0;
            if (ngaytrehan > 0)
            {
                int sosachtrehan = 0;
                Console.WriteLine("So ngay tre han: " + phieu.calculateSoNgayTreHan());
                foreach(String isbn in listSach)
                {
                    if (!phieu.SachMuon.Contains(isbn))
                    {
                        sosachtrehan++;
                    }
                }
                if (sosachtrehan > 0)
                {
                    Console.WriteLine("So sach tre han: " + sosachtrehan);
                    tientrehan = sosachtrehan * ngaytrehan * 5000;
                    Console.WriteLine("So tien tre han: " + tientrehan);
                }
                
            }
            if (sachmat > 0)
            {
                Console.WriteLine("So sach mat: " + sachmat);
                foreach (String isbn in phieu.SachMuon)
                {
                    SACH sach = getSachISBN(isbn);
                    tienmat += sach.Gia * 2;
                }
            }
            tong = tientrehan + tienmat;
            Console.WriteLine("Tong tien thanh toan: " + tong);
        }
        public ArrayList getListPhieuNotFinish()
        {
            ArrayList result = new ArrayList();
            foreach(PHIEU phieu in this._listPhieu)
            {
                if (phieu.NgayTraThucTe == null || phieu.NgayTraThucTe == "")
                {
                    result.Add(phieu);
                }
            }
            return result;
        }

        public int thongKeSach()
        {
            int result = 0;
            foreach(SACH sach in this._listSach)
            {
                result += sach.SoQuyen;
            }
            return result;
        }
        public ArrayList thongKeSachTheoTheLoai()
        {
            ArrayList result = new ArrayList();
            ArrayList TheLoai = new ArrayList();
            ArrayList SLTheLoai = new ArrayList();
            try
            {
                foreach (SACH sach in this._listSach)
                {
                    if (!TheLoai.Contains(sach.TheLoai))
                    {
                        TheLoai.Add(sach.TheLoai);
                        SLTheLoai.Add(sach.SoQuyen);
                    }
                    else
                    {
                        int i = TheLoai.IndexOf(sach.TheLoai);
                        SLTheLoai[i] = (int.Parse(SLTheLoai[i].ToString()) + sach.SoQuyen);
                    }
                }
                result.Add(TheLoai);
                result.Add(SLTheLoai);
            }
            catch(Exception ex)
            {
                return null;
            }            
            return result;
        }
        public int thongKeDocGia()
        {
            int result = 0;
            result = this._listDocGia.Count;
            return result;
        }
        public ArrayList thongKeDocGiaTheoGioiTinh()
        {
            ArrayList result = new ArrayList();
            result[0] = 0;//Nam
            result[1] = 0;//Nu
            try
            {
                foreach (DOC_GIA docgia in this._listDocGia)
                {
                    if (docgia.GioiTinh.ToUpper().Equals("NAM"))
                    {
                        result[0] = (int)result[0] + 1;
                    }
                    else if (docgia.GioiTinh.ToUpper().Equals("NU"))
                    {
                        result[1] = (int)result[1] + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return result;
        }
        public int thongKeSachDangMuon()
        {
            ArrayList listPhieu = getListPhieuNotFinish();
            int tongsach = 0;
            foreach (PHIEU phieu in listPhieu)
            {
                tongsach += phieu.SachMuon.Count;
            }
            return tongsach;
        }
        public ArrayList thongkeDocGiaTreHan()
        {
            ArrayList listPhieu = getListPhieuNotFinish();
            ArrayList result = new ArrayList();
            if (listPhieu.Count > 0)
            {
                foreach (PHIEU phieu in listPhieu)
                {

                    if (UTIL.formatStringToDate(phieu.NgayTraDuKien) < DateTime.Today)
                    {
                        result.Add(phieu.MaDocGia);
                    }
                }
            }
            return result;            
        }
        

    }
}
