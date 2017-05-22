using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    class DOC_GIA
    {
        //Properties
        //String _maDocGIa;
        //String _hoTen;
        //String _cMND;
        //String _ngaySinh;
        //String _gioiTinh;
        //String _email;
        //String _diaChi;
        //String _ngayLap;
        //String _ngayHet;
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
            //TODO
            //ngaylap
            //ngayhet = ngay lap + 48 thang
        }
        //Methods
        public void printShortDesc()
        {
            //TODO
        }
        public void printLongDesc()
        {
            //TODO
        }
        public void input()
        {
            Console.WriteLine("Nhap thong tin doc gia");
            Console.Write("Ho Ten: ");
            String HoTen = Console.ReadLine();
            Console.Write("Chung minh nhan dan: ");
            String CMND = Console.ReadLine();
            Console.Write("Ngay sinh [yyyy/mm/dd]: ");
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
            }
        }
        public void insert()
        {

        }
        public void modify()
        {

        }
        public void delete()
        {

        }
        public bool validate()
        {
            return true;
        }


    }
}
