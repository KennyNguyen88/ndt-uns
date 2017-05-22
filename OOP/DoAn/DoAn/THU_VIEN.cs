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
        public String _nextMaDocGia;
        public String _nextPhieu;
        //constructor
        public THU_VIEN()
        {
            _listDocGia = this.getListDocGia();
            _listSach = this.getListSach();
            _listPhieu = this.getListPhieu();
            _nextMaDocGia = this.getNextMaDocGia();
            _nextPhieu = this.getNextMaPhieu();
        }
        //methods
        public void MuonSach()
        {

        }
        public void TraSach()
        {

        }
        public void doMuonSach(PHIEU phieu)
        {

        }
        public void doTraSach(PHIEU phieu)
        {

        }
        public void ThongKeSoLuongSach()
        {

        }
        public void ThongKeSoLuongSachTheoTheLoai()
        {

        }
        public void ThongKeSoLuongDocGia()
        {

        }
        public void ThongKeSoLuongDocGiaTheoGioiTinh()
        {

        }
        public void ThongKeSoSachDangMuon()
        {

        }
        public void ThongKeDocGiaTreHan()
        {

        }
        //In tat ca dau sach hien co trong thu vien
        public void printListSach()
        {
            if (this._listSach != null & this._listSach.Count > 0)
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
        //Tat ca sach tu thu vien
        public ArrayList getListSach()
        {
            ArrayList result = new ArrayList();
            result = UTIL.getFilesSach();
            return result;
        }
        //Tat ca doc gia trong thu vien
        public ArrayList getListDocGia()
        {
            ArrayList result = new ArrayList();
            result = UTIL.getFilesDocGia();
            return result;
        }
        //Tat ca phieu muon/tra sach
        public ArrayList getListPhieu()
        {
            //TODO
            ArrayList result = new ArrayList();
            return result;
        }
        public String getNextMaDocGia()
        {
            //TODO
            String result = "";
            return result;
        }
        public String getNextMaPhieu()
        {
            //TODO
            String result = "";
            return result;
        }
    }
}
