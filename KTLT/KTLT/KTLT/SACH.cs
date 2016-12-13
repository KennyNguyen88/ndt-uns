using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTLT
{
    class SACH
    {
        public String ISBN;
        public String Ten;
        public String TacGia;
        public String NhaXuatBan;
        public String NamXuatBan;
        public String TheLoai;
        public Double Gia;
        public int SoQuyen;

        public SACH()
        {
            this.ISBN = issueISBN();
        }
        public SACH(String filename)
        {
            try
            {
                StreamReader rd = new StreamReader(filename);
                this.ISBN = rd.ReadLine();
                this.Ten = rd.ReadLine();
                this.TacGia = rd.ReadLine();
                this.NhaXuatBan = rd.ReadLine();
                this.NamXuatBan = rd.ReadLine();
                this.TheLoai = rd.ReadLine();
                this.Gia = double.Parse(rd.ReadLine());
                this.SoQuyen = int.Parse(rd.ReadLine());
                rd.Close();
            }
            catch (Exception ex)
            {
                this.ISBN = null;
            }
        }
        private String issueISBN()
        {
            String filename = QUY_DINH.SACH_MAXID;
            String result = "";
            try
            {
                StreamReader rd = Util.getStreamReaderSach(filename);
                result = (int.Parse(rd.ReadLine()) + 1).ToString();
                rd.Close();
            }
            catch (Exception ex)
            {
                return "";
            }
            return result;
        }
        public void Input_Console()
        {
            String Ten = this.Input_Sach_Ten();
            String TacGia = this.Input_Sach_TacGia();
            String NhaXuatBan = this.Input_Sach_NhaXuatBan();
            String NamXuatBan = this.Input_Sach_NamXuatBan();
            String TheLoai = this.Input_Sach_TheLoai();
            Double Gia = this.Input_Sach_Gia();
            int SoQuyen = this.Input_Sach_SoQuyen();

            this.Ten = Ten;
            this.TacGia = TacGia;
            this.NhaXuatBan = NhaXuatBan;
            this.NamXuatBan = NamXuatBan;
            this.TheLoai = TheLoai;
            this.Gia = Gia;
            this.SoQuyen = SoQuyen;                                    
        }
        private String Input_Sach_Ten()
        {
            Console.Write("Nhap ten sach: ");
            String result = Console.ReadLine();
            if (this.KiemTra_Sach_Ten(result))
            {
                return result;
            }
            return "";
        }
        private bool KiemTra_Sach_Ten(String ten)
        {
            //Xuat thong bao neu fail
            return true;
        }
        private String Input_Sach_TacGia()
        {
            Console.Write("Nhap ten tac gia: ");
            String result = Console.ReadLine();
            if (this.KiemTra_Sach_TacGia(result))
            {
                return result;
            }
            return "";
        }
        private bool KiemTra_Sach_TacGia(String tacgia)
        {
            //Xuat thong bao neu fail
            return true;
        }
        private String Input_Sach_NhaXuatBan()
        {
            Console.Write("Nhap ten nha xuat ban: ");
            String result = Console.ReadLine();
            if (this.KiemTra_Sach_NhaXuatBan(result))
            {
                return result;
            }
            return "";
        }
        private bool KiemTra_Sach_NhaXuatBan(String nhaxuatban)
        {
            //Xuat thong bao neu fail
            return true;
        }
        private String Input_Sach_NamXuatBan()
        {
            Console.Write("Nhap nam xuat ban: ");
            String result = Console.ReadLine();
            try
            {
                int nam = int.Parse(result);
                //input nhap vao la so
                if (this.KiemTra_Sach_NamXuatBan(result))
                {
                    return result;
                }
            }
            catch (Exception ex)
            {
                return "";
            }
            return "";
        }
        private bool KiemTra_Sach_NamXuatBan(String namxuatban)
        {
            //Xuat thong bao neu fail
            return true;
        }
        private String Input_Sach_TheLoai()
        {
            Console.Write("Nhap the loai sach: ");
            String result = Console.ReadLine();
            if (this.KiemTra_Sach_TheLoai(result))
            {
                return result;
            }
            return "";
        }
        private bool KiemTra_Sach_TheLoai(String theloai)
        {
            //Xuat thong bao neu fail
            return true;
        }
        private Double Input_Sach_Gia()
        {
            Console.Write("Nhap gia sach: ");
            try
            {
                Double result = Double.Parse(Console.ReadLine());
                if (this.KiemTra_Sach_Gia(result))
                {
                    return result;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }            
            return 0;
        }
        private bool KiemTra_Sach_Gia(Double gia)
        {
            //Xuat thong bao neu fail
            return true;
        }
        private int Input_Sach_SoQuyen()
        {
            Console.Write("Nhap so luong sach: ");
            try
            {
                int result = int.Parse(Console.ReadLine());
                if (this.KiemTra_Sach_SoQuyen(result))
                {
                    return result;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
            return 0;
        }
        private bool KiemTra_Sach_SoQuyen(int gia)
        {
            //Xuat thong bao neu fail
            return true;
        }
        public void Output_Console_Sach()
        {
            Console.WriteLine("Thong tin sach: ");
            Console.WriteLine("Ten: " + this.Ten);
            Console.WriteLine("Tac Gia: " + this.TacGia);
            Console.WriteLine("Nha xuat ban: " + this.NhaXuatBan);
            Console.WriteLine("Nam xuat ban: " + this.NamXuatBan);
            Console.WriteLine("The Loai: " + this.TheLoai);
            Console.WriteLine("Gia : " + this.Gia);
            Console.WriteLine("So Luong: " + this.SoQuyen);
        }
        public String Output_File_Sach()
        {
            String filename;
            String result = "";
            if (this.ISBN != "")
            {
                filename = "S_" + this.ISBN + ".txt";
                StreamWriter wr = Util.getStreamWriterSach(filename);
                wr.WriteLine(this.ISBN);
                wr.WriteLine(this.Ten);
                wr.WriteLine(this.TacGia);
                wr.WriteLine(this.NhaXuatBan);
                wr.WriteLine(this.NamXuatBan);
                wr.WriteLine(this.TheLoai);
                wr.WriteLine(this.Gia);
                wr.WriteLine(this.SoQuyen);                
                wr.Close();
                result = this.ISBN;
            }            
            return result;
        }
        public String Delete()
        {
            String filename = Util.getDirectoryPath(QUY_DINH.SACH_DIRECTORY) + @"\" + "S_" + this.ISBN + ".txt";
            try
            {
                File.Delete(filename);
                return this.ISBN;
            }
            catch (Exception ex)
            {
                return "";
            }

        }
        public void Edit()
        {
            Console.WriteLine("Ten sach hien tai: " + this.Ten);
            if (!Util.isEnter())
            {
                String Ten = this.Input_Sach_Ten();
                this.Ten = Ten;
            }            
            Console.WriteLine("Tac Gia hien tai: " + this.TacGia);
            if (!Util.isEnter())
            {
                String TacGia = this.Input_Sach_TacGia();
                this.TacGia = TacGia;
            }            
            Console.WriteLine("Nha Xuat Ban hien tai: " + this.NhaXuatBan);
            if (!Util.isEnter())
            {
                String NhaXuatBan = this.Input_Sach_NhaXuatBan();
                this.NhaXuatBan = NhaXuatBan;
            }
            
            Console.WriteLine("Nam Xuat Ban hien tai: " + this.NamXuatBan);
            if (!Util.isEnter())
            {
                String NamXuatBan = this.Input_Sach_NamXuatBan();
                this.NamXuatBan = NamXuatBan;
            }
            
            Console.WriteLine("The Loai hien tai: " + this.TheLoai);
            if (!Util.isEnter())
            {
                String TheLoai = this.Input_Sach_TheLoai();
                this.TheLoai = TheLoai;
            }
            
            Console.WriteLine("Gia hien tai: " + this.Gia);
            if (!Util.isEnter())
            {
                double Gia = this.Input_Sach_Gia();
                this.Gia = Gia;
            }
            
            Console.WriteLine("So luong sach hien tai: " + this.SoQuyen);
            if (!Util.isEnter())
            {
                int SoQuyen = this.Input_Sach_SoQuyen();
                this.SoQuyen = SoQuyen;
            }            
        }
    }
}
