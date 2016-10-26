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
        public String ISBM;
        public String Ten;
        public String TacGia;
        public String NhaXuatBan;
        public String NamXuatBan;
        public String TheLoai;
        public Double Gia;
        public int SoQuyen;

        public SACH()
        {
            this.ISBM = issueISBM();
        }
        public SACH(String filename)
        {
            try
            {
                StreamReader rd = new StreamReader(filename);
                this.ISBM = rd.ReadLine();
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
                this.ISBM = null;
            }
        }
        private String issueISBM()
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


    }
}
