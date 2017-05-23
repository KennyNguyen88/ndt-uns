using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    class DOC_GIA
    {
        //Properties
        public String MaDocGia { get; set; }
        public String HoTen { get; set; }
        public String CMND { get; set; }
        public String NgaySinh { get; set; }
        public String GioiTinh { get; set; }
        public String Email { get; set; }
        public String DiaChi { get; set; }
        public String NgayLap { get; set; }
        public String NgayHet { get; set; }
        //Constructor
        public DOC_GIA() { }
        public DOC_GIA(String MaDocGia)
        {
            this.MaDocGia = MaDocGia;
            this.NgayLap = UTIL.formatDateToString(DateTime.Now);
            this.NgayHet = calculateNgayHet(this.NgayLap);            
        }
        //Methods
        public void printShortDesc()
        {
            Console.WriteLine("Ho Ten: " + this.HoTen);
            Console.WriteLine("Ngay Sinh: " + UTIL.formatStringToDate(this.NgaySinh).ToShortDateString());
        }
        public void printLongDesc()
        {
            Console.WriteLine("Ma Doc Gia: " + this.MaDocGia);
            Console.WriteLine("Ho Ten: " + this.HoTen);
            Console.WriteLine("CMND: " + this.CMND);
            Console.WriteLine("Ngay Sinh: " + UTIL.formatStringToDate(this.NgaySinh).ToShortDateString());
            Console.WriteLine("Gioi Tinh: " + this.GioiTinh);
            Console.WriteLine("Email: " + this.Email);
            Console.WriteLine("Dia Chi: " + this.DiaChi);
            Console.WriteLine("Ngay Lap: " + UTIL.formatStringToDate(this.NgayLap).ToShortDateString());
            Console.WriteLine("Ngay Het: " + UTIL.formatStringToDate(this.NgayHet).ToShortDateString());
        }
        public String calculateNgayHet(String NgayLap)
        {
            DateTime dt = UTIL.formatStringToDate(NgayLap);
            return UTIL.formatDateToString(dt.AddMonths(48));
        }
        public bool input()
        {
            try
            {
                Console.WriteLine("Nhap thong tin doc gia");
                Console.Write("Ho Ten: ");
                String HoTen = Console.ReadLine();
                Console.Write("Chung minh nhan dan: ");
                String CMND = Console.ReadLine();
                Console.Write("Ngay sinh [yyyymmdd]: ");
                String NgaySinh = Console.ReadLine();
                Console.Write("Gioi tinh [Nam/Nu]: ");
                String GioiTinh = Console.ReadLine();
                Console.Write("Email: ");
                String Email = Console.ReadLine();
                Console.Write("Dia Chi: ");
                String DiaChi = Console.ReadLine();
                if (validate())
                {
                    this.HoTen = HoTen;
                    this.CMND = CMND;
                    this.NgaySinh = NgaySinh;
                    this.GioiTinh = GioiTinh;
                    this.Email = Email;
                    this.DiaChi = DiaChi;
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }            
        }
        public bool modify()
        {
            String input;
            try
            {
                Console.WriteLine("Nhap Ho Ten moi (Nhap Enter de bo qua): ");
                input = Console.ReadLine();
                String nHoTen = this.HoTen;
                if (!input.Equals(""))
                {
                    nHoTen = input;
                }

                Console.WriteLine("Nhap CMND moi (Nhap Enter de bo qua): ");
                input = Console.ReadLine();
                String nCMND = this.CMND;
                if (!input.Equals(""))
                {
                    nCMND = input;
                }

                Console.WriteLine("Nhap Ngay Sinh moi [yyyymmdd] (Nhap Enter de bo qua): ");
                input = Console.ReadLine();
                String nNgaySinh = this.NgaySinh;
                if (!input.Equals(""))
                {
                    nNgaySinh = input;
                }

                Console.WriteLine("Nhap Gioi Tinh moi (Nhap Enter de bo qua): ");
                input = Console.ReadLine();
                String nGioiTinh = this.GioiTinh;
                if (!input.Equals(""))
                {
                    nGioiTinh = input;
                }

                Console.WriteLine("Nhap Email moi (Nhap Enter de bo qua): ");
                input = Console.ReadLine();
                String nEmail = this.Email;
                if (!input.Equals(""))
                {
                    nEmail = input;
                }

                Console.WriteLine("Nhap Dia Chi moi (Nhap Enter de bo qua): ");
                input = Console.ReadLine();
                String nDiaChi = this.DiaChi;
                if (!input.Equals(""))
                {
                    nDiaChi = input;
                }

                Console.WriteLine("Nhap Ngay Lap [yyyymmdd] (Nhap Enter de bo qua): ");
                input = Console.ReadLine();
                String nNgayLap = this.NgayLap;
                String nNgayHet = this.NgayHet;
                if (!input.Equals(""))
                {
                    nNgayLap = input;
                    nNgayHet = calculateNgayHet(nNgayLap);
                }                

                if (validate())
                {
                    this.HoTen = nHoTen;
                    this.CMND = nCMND;
                    this.NgaySinh = nNgaySinh;
                    this.GioiTinh = nGioiTinh;
                    this.Email = nEmail;
                    this.DiaChi = nDiaChi;
                    this.NgayLap = nNgayLap;
                    this.NgayHet = nNgayHet;
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool validate()
        {
            return true;
        }
        //Ghi ra file
        public bool write()
        {
            try
            {
                String fileName = UTIL.THU_MUC_DOCGIA + "\\" + this.MaDocGia + ".txt";
                StreamWriter file = new StreamWriter(fileName);
                file.AutoFlush = true;
                file.WriteLine(this.MaDocGia);
                file.WriteLine(this.HoTen);
                file.WriteLine(this.CMND);
                file.WriteLine(this.NgaySinh);
                file.WriteLine(this.GioiTinh);
                file.WriteLine(this.Email);
                file.WriteLine(this.DiaChi);
                file.WriteLine(this.NgayLap);
                file.WriteLine(this.NgayHet);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //Xoa file
        public bool delete()
        {
            try
            {
                String fileName = UTIL.THU_MUC_DOCGIA + "\\" + this.MaDocGia + ".txt";
                File.Delete(fileName);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
