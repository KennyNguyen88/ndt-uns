using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    class PHIEU
    {
        //properties
        public String MaPhieu { get; set; }
        public String MaDocGia { get; set; }
        public String NgayMuon { get; set; }
        public String NgayTraDuKien { get; set; }
        public String NgayTraThucTe { get; set; }
        public ArrayList SachMuon { get; set; }
        //constructor
        public PHIEU()
        {
            this.SachMuon = new ArrayList();
        }
        public PHIEU(String MaPhieu, String MaDocGia)
        {            
            this.MaPhieu = MaPhieu;
            this.MaDocGia = MaDocGia;
            this.NgayMuon = UTIL.formatDateToString(DateTime.Now);
            this.NgayTraDuKien = calculateNgayTraDuKien(this.NgayMuon);
            this.SachMuon = new ArrayList();
        }
        //methods
        public String calculateNgayTraDuKien(String NgayMuon)
        {
            DateTime dt = UTIL.formatStringToDate(NgayMuon);
            return UTIL.formatDateToString(dt.AddDays(7));
        }
        public int calculateSoNgayTreHan()
        {
            return UTIL.formatStringToDate(this.NgayTraThucTe).Day - UTIL.formatStringToDate(this.NgayTraDuKien).Day;
        }        
        public bool input()
        {
            try
            {
                Console.WriteLine("Nhap so luong dau sach can muon"); //moi dau sach chi duoc muon toi da 1 cuon
                int sl = int.Parse(Console.ReadLine());
                if (sl > 0)
                {
                    for (int i = 0; i < sl; i++)
                    {
                        Console.WriteLine("Nhap ma ISBN");
                        String ISBN = Console.ReadLine();
                        this.SachMuon.Add(ISBN);
                    }
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                return false;
            }                        
        }
        //Ghi ra file
        public bool write()
        {
            try
            {
                String fileName = UTIL.THU_MUC_PHIEU + "\\" + this.MaPhieu + ".txt";
                StreamWriter file = new StreamWriter(fileName);
                file.AutoFlush = true;
                file.WriteLine(this.MaPhieu);
                file.WriteLine(this.MaDocGia);
                file.WriteLine(this.NgayMuon);
                file.WriteLine(this.NgayTraDuKien);
                file.WriteLine(this.NgayTraThucTe);
                foreach(String isbn in SachMuon)
                {
                    file.WriteLine(isbn);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //Cap nhat Ngay Tra Thuc Te
        public void setNgayTraThucTe()
        {
            this.NgayTraThucTe = UTIL.formatDateToString(DateTime.Now);
        }



    }
}
