using System;
using System.Collections;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DoAn
{
    class UTIL
    {

        public static String THU_MUC_SOLUTION = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        public static String THU_MUC_DU_LIEU = THU_MUC_SOLUTION + "\\DuLieu";
        public static String THU_MUC_SACH = THU_MUC_DU_LIEU + "\\SACH";
        public static String THU_MUC_DOCGIA = THU_MUC_DU_LIEU + "\\DOCGIA";
        public static String THU_MUC_PHIEU = THU_MUC_DU_LIEU + "\\PHIEU";

        protected static String[] getFiles(String dir)
        {
            String[] fileEntries = Directory.GetFiles(dir);
            return fileEntries;
        }
        public static ArrayList getFilesSach()
        {
            ArrayList result = new ArrayList();
            String[] fileEntries = getFiles(THU_MUC_SACH);
            if (fileEntries.Length > 0)
            {
                foreach(String fileName in fileEntries)
                {
                    SACH sach = readSACH(fileName);
                    if (sach != null)
                    {
                        result.Add(sach);
                    }
                }
            }
            return result;
        }
        protected static SACH readSACH(String fileName)
        {
            String[] lines = System.IO.File.ReadAllLines(fileName);
            try
            {
                SACH sach = new SACH();
                sach.ISBN = lines[0];
                sach.TenSach = lines[1];
                sach.TacGia = lines[2];
                sach.NXB = lines[3];
                sach.NamXB = int.Parse(lines[4]);
                sach.TheLoai = lines[5];
                sach.Gia = double.Parse(lines[6]);
                sach.SoQuyen = int.Parse(lines[7]);
                return sach;
            }
            catch(Exception)
            {
                return null;
            }                        
        }

        public static ArrayList getFilesDocGia()
        {
            ArrayList result = new ArrayList();
            String[] fileEntries = getFiles(THU_MUC_DOCGIA);
            if (fileEntries.Length > 0)
            {
                foreach (String fileName in fileEntries)
                {
                    DOC_GIA docgia = readDOCGIA(fileName);
                    if (docgia != null)
                    {
                        result.Add(docgia);
                    }
                }
            }
            return result;
        }
        protected static DOC_GIA readDOCGIA(String fileName)
        {
            String[] lines = System.IO.File.ReadAllLines(fileName);
            try
            {
                DOC_GIA docgia = new DOC_GIA();
                docgia.MaDocGia = lines[0];
                docgia.HoTen = lines[1];
                docgia.CMND = lines[2];
                docgia.NgaySinh = lines[3];
                docgia.GioiTinh = lines[4];
                docgia.Email = lines[5];
                docgia.DiaChi = lines[6];
                docgia.NgayLap = lines[7];
                docgia.NgayHet = lines[8];
                return docgia;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static ArrayList getFilesPhieu()
        {
            ArrayList result = new ArrayList();
            String[] fileEntries = getFiles(THU_MUC_PHIEU);
            if (fileEntries.Length > 0)
            {
                foreach (String fileName in fileEntries)
                {
                    PHIEU phieu = readPHIEU(fileName);
                    if (phieu != null)
                    {
                        result.Add(phieu);
                    }
                }
            }
            return result;
        }
        protected static PHIEU readPHIEU(String fileName)
        {
            String[] lines = System.IO.File.ReadAllLines(fileName);
            try
            {
                PHIEU phieu = new PHIEU();
                phieu.MaPhieu = lines[0];
                phieu.MaDocGia = lines[1];
                phieu.NgayMuon = lines[2];
                phieu.NgayTraDuKien = lines[3];
                phieu.NgayTraThucTe = lines[4];
                for (int i = 5; i <lines.Length; i++)
                {
                    phieu.SachMuon.Add(lines[i]);
                }                
                return phieu;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //return yyyymmdd
        public static String formatDateToString(DateTime dt)
        {
            DateTimeFormatInfo dtfi = CultureInfo.CreateSpecificCulture("en-US").DateTimeFormat;
            dtfi.DateSeparator = "";
            dtfi.ShortDatePattern = @"yyyy/MM/dd";
            return dt.ToString("d", dtfi);
        }
        public static DateTime formatStringToDate(String dt)
        {
            try
            {
                DateTimeFormatInfo dtfi = CultureInfo.CreateSpecificCulture("en-US").DateTimeFormat;
                int year = int.Parse(dt.Substring(0, 4));
                int month = int.Parse(dt.Substring(4, 2));
                int day = int.Parse(dt.Substring(6, 2));
                DateTime result = new DateTime(year, month, day);
                return result;
            }
            catch (Exception)
            {
                return DateTime.MinValue;
            }
            
        }


    }
}
