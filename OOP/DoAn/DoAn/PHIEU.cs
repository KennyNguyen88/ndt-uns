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
        //String _maPhieu;
        //String _maDocGia;
        //String _ngayMuon;
        //String _ngayTraDuKien;
        //String _ngayTraThucTe;
        //ArrayList _sachMuon;
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
        //methods
        public void input()
        {

        }


            
    }
}
