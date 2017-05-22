using System;
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
        String _maPhieu;
        String _maDocGia;
        String _ngayMuon;
        String _ngayTraDuKien;
        String _ngayTraThucTe;
        ArrayList _sachMuon;
        //constructor
        public PHIEU()
        {
            _sachMuon = new ArrayList();
        }
        //methods
        public void input()
        {

        }
        public void getListPhieuMa()
        {

        }
        public void getListPhieuMaDocGia()
        {

        }
        public String MaPhieu { get; set; }
        public String MaDocGia { get; set; }
        public String NgayMuon { get; set; }
        public String NgayTraDuKien { get; set; }
        public String NgayTraThucTe { get; set; }
        public ArrayList SachMuon { get; set;}

            
    }
}
