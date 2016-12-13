using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTLT
{
    class PHIEU
    {
        public String ID;
        public String ID_Doc_GIa;
        public String NgayMuon;
        public String NgayTraDuKien;
        public String NgayTraThucTe;
        public ArrayList ListISBN;
        public PHIEU()
        {
            this.ID = issueID();
            this.NgayMuon = issueNgayMuon();
            this.NgayTraDuKien = issueNgayTraDuKien();
            ListISBN = new ArrayList();
        }
        public PHIEU(String filename)
        {
            this.ListISBN = new ArrayList();
            try
            {
                StreamReader rd = new StreamReader(filename);
                this.ID = rd.ReadLine();
                this.ID_Doc_GIa = rd.ReadLine();
                this.NgayMuon = rd.ReadLine();
                this.NgayTraDuKien = rd.ReadLine();
                this.NgayTraThucTe = rd.ReadLine();
                while(!rd.EndOfStream)
                {
                    this.ListISBN.Add(rd.ReadLine());
                }
                rd.Close();
            }
            catch (Exception ex)
            {
                this.ID = null;
                this.ListISBN = null;
            }
        }
        private String issueID()
        {
            String filename = QUY_DINH.PHIEU_MAXID;
            String result = "";
            try
            {
                StreamReader rd = Util.getStreamReaderPhieu(filename);
                result = (int.Parse(rd.ReadLine()) + 1).ToString();
                rd.Close();
            }
            catch (Exception ex)
            {
                return "";
            }

            return result;
        }
        private String issueNgayMuon()
        {
            String result = DateTime.Now.ToString("yyyyMMdd");
            return result;
        }
        private String issueNgayTraDuKien()
        {
            String result = DateTime.Now.AddDays(QUY_DINH.NgayMuonToiDa).ToString("yyyyMMdd");
            return result;
        }
        public void setNgayTraThucTe()
        {
            this.NgayTraThucTe = issueNgayMuon();
        }
        public String setSachMuon(SACH sach)
        {
            if (sach.SoQuyen > 0)
            {
                ListISBN.Add(sach.ISBN);
                Console.WriteLine("Muon sach co ma ISBN: " + sach.ISBN);
                return sach.ISBN;
            }
            else
            {
                return "";
            }
        }
        public void Output_Console()
        {
            Console.WriteLine("Thong tin phieu: ");
            Console.WriteLine("Ma doc gia: " + this.ID_Doc_GIa);
            Console.WriteLine("Ngay muon: " + this.NgayMuon);
            Console.WriteLine("Ngay tra du kien: " + this.NgayTraDuKien);
            Console.WriteLine("Ngay tra thuc te : " + this.NgayTraThucTe);            
            if (this.ListISBN.Count > 0)
            {
                Console.WriteLine("So luong sach muon : " + this.ListISBN.Count);
                foreach (String str in this.ListISBN)
                {
                    Console.WriteLine("Ma sach: " + str);
                }
            }
            
        }
        public String Output_File()
        {
            String filename;
            String result = "";
            if (ListISBN.Count > 0)
            {
                filename = "PMS_" + this.ID + ".txt";
                StreamWriter wr = Util.getStreamWriterPhieu(filename);
                wr.WriteLine(this.ID);
                wr.WriteLine(this.ID_Doc_GIa);
                wr.WriteLine(this.NgayMuon);
                wr.WriteLine(this.NgayTraDuKien);
                wr.WriteLine(this.NgayTraThucTe);
                if (this.ListISBN.Count > 0)
                {
                    foreach (String str in ListISBN)
                    {
                        wr.WriteLine(str);
                    }
                }
                wr.Close();
                result = this.ID;
            }
            return result;
        }

    }
}
