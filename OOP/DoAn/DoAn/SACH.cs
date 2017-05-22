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
        //String _iSBN;
        //String _tenSach;
        //String _tacGia;
        //String _nXB;
        //int _namXB;
        //String _theLoai;
        //Double _gia;
        //int _soQuyen;
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
        public void input()
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
            }
        }
        public bool modify()
        {
            //TODO
            return true;
        }
        public bool delete()
        {
            //TODO
            return true;
        }
        public bool validate()
        {
            //TODO
            return true;
        }
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
            catch(Exception ex)
            {
                return false;
            }            
        }

    }
}
