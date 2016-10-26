using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTLT
{
    class DOC_GIA
    {
        public String ID;
        public String HoTen;
        public String CMND;
        public String NgaySinh;
        public String GioiTinh;
        public String Email;
        public String DiaChi;
        public String NgayLapThe;
        public String NgayHetHan;

        public DOC_GIA()
        {
            this.ID = issueID();
            this.NgayLapThe = issueNgayLapThe();
            this.NgayHetHan = issueNgayHetHan();
        }
        public DOC_GIA(String filename)
        {
            try
            {
                StreamReader rd = new StreamReader(filename);
                this.ID = rd.ReadLine();
                this.HoTen = rd.ReadLine();
                this.CMND = rd.ReadLine();
                this.NgaySinh = rd.ReadLine();
                this.GioiTinh = rd.ReadLine();
                this.Email = rd.ReadLine();
                this.DiaChi = rd.ReadLine();
                this.NgayLapThe = rd.ReadLine();
                this.NgayHetHan = rd.ReadLine();
                rd.Close();
            }
            catch (Exception ex)
            {
                this.ID = null;
            }
        }
        private String issueID()
        {
            String filename = QUY_DINH.DOC_GIA_MAXID;
            String result = "";
            try
            {
                StreamReader rd = Util.getStreamReaderDocGia(filename);
                result = (int.Parse(rd.ReadLine()) + 1).ToString();
                rd.Close();
            }
            catch(Exception ex)
            {
                return "";
            }
            
            return result;
        }
        private String issueNgayLapThe()
        {            
            String result = DateTime.Now.ToString("yyyyMMdd");
            return result;
        }
        private String issueNgayHetHan()
        {
            String result = DateTime.Now.AddMonths(QUY_DINH.NgayHetHanThe).ToString("yyyyMMdd");            
            return result;
        }
        public void Input_Console()
        {
            String HoTen = this.Input_DocGia_HoTen();
            String CMND = this.Input_DocGia_CMND();
            String GioiTinh = this.Input_DocGia_GioiTinh();
            String NgaySinh = this.Input_DocGia_NgaySinh();
            String Email = this.Input_DocGia_Email();
            String DiaChi = this.Input_DocGia_DiaChi();
            this.HoTen = HoTen;
            this.CMND = CMND;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh;
            this.Email = Email;
            this.DiaChi = DiaChi;
        }
        private String Input_DocGia_HoTen()
        {
            Console.Write("Nhap ho ten doc gia: ");
            String result = Console.ReadLine();
            if (this.KiemTra_DocGia_HoTen(result))
            {
                return result;
            }
            return "";
        }
        private bool KiemTra_DocGia_HoTen(String hoten)
        {
            //Xuat thong bao neu fail
            return true;
        }
        private String Input_DocGia_CMND()
        {
            Console.Write("Nhap CMND cua doc gia: ");
            String result = Console.ReadLine();
            if (this.KiemTra_DocGia_CMND(result))
            {
                return result;
            }
            return "";
        }
        private bool KiemTra_DocGia_CMND(String cmnd)
        {
            //Xuat thong bao neu fail
            return true;
        }
        private String Input_DocGia_GioiTinh()
        {
            Console.WriteLine("Chon gioi tinh cua doc gia: ");
            Console.WriteLine("1 - Nam / 2 - Nu");
            int select = 0;
            try
            {
                select = int.Parse(Console.ReadLine());
                if (!this.KiemTra_DocGia_GioiTinh(select))
                {
                    Console.WriteLine("Vui long nhap so 1 hoac 2");
                    return "";
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Vui long nhap so 1 hoac 2");
                return "";
            }
            if (select == 1)
            {
                return QUY_DINH.GIOI_TINH_NAM;
            }
            else
            {
                return QUY_DINH.GIOI_TINH_NU;
            }
        }
        private bool KiemTra_DocGia_GioiTinh(int gioitinh)
        {
            if (gioitinh == 1 || gioitinh == 2)
            {                
                return true;
            }
            return false;
        }
        private String Input_DocGia_NgaySinh()
        {
            Console.Write("Nhap ngay thang nam sinh cua doc gia (dinh dang yyyymmdd) : ");
            String result = Console.ReadLine();
            if (this.KiemTra_DocGia_NgaySinh(result))
            {
                return result;
            }
            return "";
        }
        private bool KiemTra_DocGia_NgaySinh(String ngaysinh)
        {
            try
            {
                DateTime dt = DateTime.ParseExact(ngaysinh, "yyyyMMdd",null);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Loi nhap ngay thang nam sinh, vui long nhap theo dinh dang yyyyMMdd ");
                return false;
            }
        }
        private String Input_DocGia_Email()
        {
            Console.Write("Nhap email cua doc gia: ");
            String result = Console.ReadLine();
            if (this.KiemTra_DocGia_Email(result))
            {
                return result;
            }
            return "";
        }
        private bool KiemTra_DocGia_Email(String email)
        {
            //Xuat loi neu false
            return true;
        }
        private String Input_DocGia_DiaChi()
        {
            Console.Write("Nhap dia chi cua doc gia: ");
            String result = Console.ReadLine();
            if (this.KiemTra_DocGia_DiaChi(result))
            {
                return result;
            }
            return "";
        }
        private bool KiemTra_DocGia_DiaChi(String diachi)
        {
            //Xuat loi neu false
            return true;
        }
        public void Output_Console_DocGia()
        {
            Console.WriteLine("Thong tin doc gia: ");
            Console.WriteLine("Ho ten: " + this.HoTen);
            Console.WriteLine("CMND: " + this.CMND);
            Console.WriteLine("Ngay sinh: " + this.NgaySinh);
            Console.WriteLine("Gioi tinh: " + this.GioiTinh);
            Console.WriteLine("Email: " + this.Email);
            Console.WriteLine("Dia chi: " + this.DiaChi);
            Console.WriteLine("Ngay lap the: " + this.NgayLapThe);
            Console.WriteLine("Ngay het han: " + this.NgayHetHan);
        }
        public String Output_File_DocGia()
        {
            String filename;
            String result = "";
            if (this.ID != "")
            {
                filename = "DG_" + this.ID + ".txt";
                StreamWriter wr = Util.getStreamWriterDocGia(filename);
                wr.WriteLine(this.ID);
                wr.WriteLine(this.HoTen);
                wr.WriteLine(this.CMND);
                wr.WriteLine(this.NgaySinh);
                wr.WriteLine(this.GioiTinh);
                wr.WriteLine(this.Email);
                wr.WriteLine(this.DiaChi);
                wr.WriteLine(this.NgayLapThe);
                wr.WriteLine(this.NgayHetHan);
                wr.Close();
                result = this.ID;
            }            
            return result;
        }
        public String Delete()
        {
            String filename = Util.getDirectoryPath(QUY_DINH.DOC_GIA_DIRECTORY) + @"\" + "DG_" + this.ID + ".txt";
            try
            {
                File.Delete(filename);
                return this.ID;
            }
            catch (Exception ex)
            {
                return "";
            }
            
        }
        public void Edit()
        {
            Console.WriteLine("Ho Ten hien tai: " + this.HoTen) ;
            String HoTen = this.Input_DocGia_HoTen();
            Console.WriteLine("CMND hien tai: " + this.CMND);
            String CMND = this.Input_DocGia_CMND();
            Console.WriteLine("Gioi tinh hien tai: " + this.GioiTinh);
            String GioiTinh = this.Input_DocGia_GioiTinh();
            Console.WriteLine("Ngay sinh hien tai: " + this.NgaySinh);
            String NgaySinh = this.Input_DocGia_NgaySinh();
            Console.WriteLine("Email hien tai: " + this.Email);
            String Email = this.Input_DocGia_Email();
            Console.WriteLine("Dia chi hien tai: " + this.DiaChi);
            String DiaChi = this.Input_DocGia_DiaChi();
            this.HoTen = HoTen;
            this.CMND = CMND;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh;
            this.Email = Email;
            this.DiaChi = DiaChi;
        }

    }
}
