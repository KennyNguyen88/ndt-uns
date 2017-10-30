using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    class SACH
    {
        //properties
        public String ISBN { get; set; }
        public String TenSach { get; set; }
        public String TacGia { get; set; }
        public String NXB { get; set; }
        public int NamXB { get; set; }
        public String TheLoai { get; set; }
        public Double Gia { get; set; }
        public int SoQuyen { get; set; }
        //constructor
        public SACH() { }
        public SACH(String ISBN)
        {
            this.ISBN = ISBN;
        }
        //methods
        public void printShortDesc()
        {
            Console.WriteLine("Ten sach: " + this.TenSach);
            Console.WriteLine("Tac gia: " + this.TacGia);
        }
        public void printLongDesc()
        {
            Console.WriteLine("Ten sach: " + this.TenSach);
            Console.WriteLine("Tac gia: " + this.TacGia);
            Console.WriteLine("Nha Xuat Ban: " + this.NXB);
            Console.WriteLine("Nam Xuat Ban: " + this.NamXB);
            Console.WriteLine("The Loai: " + this.TheLoai);
            Console.WriteLine("Gia: " + this.Gia);
            Console.WriteLine("So Luong: " + this.SoQuyen);
        }
        public bool input()
        {
            try
            {
                Console.WriteLine("Nhap thong tin cho sach");
                Console.Write("Ten Sach: ");
                String TenSach = Console.ReadLine();
                Console.Write("Tac Gia: ");
                String TacGia = Console.ReadLine();
                Console.Write("Nha Xuat Ban: ");
                String NXB = Console.ReadLine();
                Console.Write("Nam Xuat Ban [yyyy]: ");
                int NamXB = int.Parse(Console.ReadLine());
                Console.Write("The Loai: ");
                String TheLoai = Console.ReadLine();
                Console.Write("Gia: ");
                double Gia = double.Parse(Console.ReadLine());
                Console.Write("So Quyen: ");
                int SoQuyen = int.Parse(Console.ReadLine());
                if (validate())
                {
                    this.TenSach = TenSach;
                    this.TacGia = TacGia;
                    this.NXB = NXB;
                    this.NamXB = NamXB;
                    this.TheLoai = TheLoai;
                    this.Gia = Gia;
                    this.SoQuyen = SoQuyen;
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }                        
        }
        public bool modify()
        {
            String input;
            try
            {                
                Console.WriteLine("Nhap Ten Sach moi (Nhap Enter de bo qua): ");
                input = Console.ReadLine();
                String nTenSach = this.TenSach;
                if (!input.Equals(""))
                {
                    nTenSach = input;
                }

                Console.WriteLine("Nhap Tac Gia moi (Nhap Enter de bo qua): ");
                input = Console.ReadLine();
                String nTacGia = this.TacGia;
                if (!input.Equals(""))
                {
                    nTacGia = input;
                }

                Console.WriteLine("Nhap Nha Xuat Ban moi (Nhap Enter de bo qua): ");
                input = Console.ReadLine();
                String nNXB = this.NXB;
                if (!input.Equals(""))
                {
                    nNXB = input;
                }

                Console.WriteLine("Nhap Nam Xuat Ban moi (Nhap Enter de bo qua): ");
                input = Console.ReadLine();
                int nNamXB = this.NamXB;
                if (!input.Equals(""))
                {
                    nNamXB = int.Parse(input);
                }

                Console.WriteLine("Nhap The Loai moi (Nhap Enter de bo qua): ");
                input = Console.ReadLine();
                String nTheLoai = this.TheLoai;
                if (!input.Equals(""))
                {
                    nTheLoai = input;
                }

                Console.WriteLine("Nhap Gia moi (Nhap Enter de bo qua): ");
                input = Console.ReadLine();
                double nGia = this.Gia;
                if (!input.Equals(""))
                {
                    nGia = double.Parse(input);
                }

                Console.WriteLine("Nhap So Quyen moi (Nhap Enter de bo qua): ");
                input = Console.ReadLine();
                int nSoQuyen = this.SoQuyen;
                if (!input.Equals(""))
                {
                    nSoQuyen = int.Parse(input);
                }
                if (validate())
                {
                    this.TenSach = nTenSach;
                    this.TacGia = nTacGia;
                    this.NXB = nNXB;
                    this.NamXB = nNamXB;
                    this.TheLoai = nTheLoai;
                    this.Gia = nGia;
                    this.SoQuyen = nSoQuyen;                    
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }                                    
        }        
        public bool validate()
        {
            //TODO
            return true;
        }
        //Ghi ra file
        public bool write()
        {
            try
            {
                String fileName = UTIL.THU_MUC_SACH + "\\" + this.ISBN + ".txt";
                StreamWriter file = new StreamWriter(fileName);
                file.AutoFlush = true;
                file.WriteLine(this.ISBN);
                file.WriteLine(this.TenSach);
                file.WriteLine(this.TacGia);
                file.WriteLine(this.NXB);
                file.WriteLine(this.NamXB);
                file.WriteLine(this.TheLoai);
                file.WriteLine(this.Gia);
                file.WriteLine(this.SoQuyen);
                return true;
            }
            catch(Exception)
            {
                return false;
            }            
        }
        //Xoa file
        public bool delete()
        {
            try
            {
                String fileName = UTIL.THU_MUC_SACH + "\\" + this.ISBN + ".txt";
                File.Delete(fileName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }            
        }
    }
}
