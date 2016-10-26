using System;
using System.Collections;
using System.IO;

namespace KTLT
{
    class Program
    {
        static ArrayList dsDocGia;
        static ArrayList dsSach;
        static ArrayList dsPhieu;

        static void Main(string[] args)
        {
            int request;
            khoidong();            
            welcomeMessage();
            request = selectRequest();
            doRequest(request);
        }
        static void khoidong()
        {
            dsDocGia = getDanhSachDocGia();
            dsSach = getDanhSachSach();
            dsPhieu = getDanhSachPhieu();
        }
        static ArrayList getDanhSachDocGia()
        {
            ArrayList list = new ArrayList();
            String path = Util.getDirectoryPath(QUY_DINH.DOC_GIA_DIRECTORY);
            DirectoryInfo d = new DirectoryInfo(path);
            FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files            
            foreach (FileInfo file in Files)
            {
                String filename = path + @"\" + file.Name;
                DOC_GIA docgia = new DOC_GIA(filename);
                if (docgia.ID != null)
                {
                    list.Add(docgia);
                }

            }
            return list;
        }
        static ArrayList getDanhSachSach()
        {
            ArrayList list = new ArrayList();
            String path = Util.getDirectoryPath(QUY_DINH.SACH_DIRECTORY);
            DirectoryInfo d = new DirectoryInfo(path);
            FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files            
            foreach (FileInfo file in Files)
            {
                String filename = path + @"\" + file.Name;
                //Sach sach = new SACH(filename);
                //if (docgia.ID != null)
                //{
                //    list.Add(docgia);
                //}

            }
            return list;
        }
        static ArrayList getDanhSachPhieu()
        {
            ArrayList list = new ArrayList();
            String path = Util.getDirectoryPath(QUY_DINH.PHIEU_DIRECTORY);
            DirectoryInfo d = new DirectoryInfo(path);
            FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files            
            foreach (FileInfo file in Files)
            {
                String filename = path + @"\" + file.Name;
                //Sach sach = new SACH(filename);
                //if (docgia.ID != null)
                //{
                //    list.Add(docgia);
                //}

            }
            return list;
        }
        static void doRequest(int request)
        {
            switch (request)
            {
                case 1:
                    request_01(); break;
                case 2:
                    request_02(); break;
                case 3:
                    request_03(); break;
                case 4:
                    request_04(); break;
                case 5:
                    request_05(); break;
                case 6:
                    request_06(); break;
                case 7:
                    request_07(); break;
                case 8:
                    request_08(); break;
                case 9:
                    request_09(); break;
                case 10:
                    request_10(); break;
                case 11:
                    request_11(); break;
                case 12:
                    request_12(); break;
                case 13:
                    request_13(); break;
                case 14:
                    request_14(); break;
                case 15:
                    request_15(); break;
                case 16:
                    request_16(); break;
                case 17:
                    request_17(); break;
                case 18:
                    request_18(); break;
                case 19:
                    request_19(); break;
                case 20:
                    request_20(); break;
                default:
                    break;
            }
        }
        static void welcomeMessage()
        {
            Console.WriteLine("********** KTLT - Quan ly thu vien **********");
            Console.WriteLine("*****Chon yeu cau can thuc hien*****");
            Console.WriteLine("***Quan ly doc gia***");
            Console.WriteLine("1 - Xem danh sach doc gia");
            Console.WriteLine("2 - Them doc gia");
            Console.WriteLine("3 - Chinh sua thong tin doc gia");
            Console.WriteLine("4 - Xoa thong tin doc gia");
            Console.WriteLine("5 - Tim kiem doc gia theo CMND");
            Console.WriteLine("6 - Tim kiem doc gia theo ho ten");
            Console.WriteLine("***Quan ly sach***");            
            Console.WriteLine("7 - Xem danh sach cac sach trong thu vien");
            Console.WriteLine("8 - Them sach");
            Console.WriteLine("9 - Chinh sua thong tin sach");
            Console.WriteLine("10 - Xoa thong tin sach");
            Console.WriteLine("11 - Tim kiem sach theo ISBN");
            Console.WriteLine("12 - Tiem kiem sach theo ten");
            Console.WriteLine("13 - Lap phieu muon sach");
            Console.WriteLine("14 - Lap phieu tra sach");
            Console.WriteLine("***Thong ke***");
            Console.WriteLine("15 - Thong ke so luong sach trong thu vien");
            Console.WriteLine("16 - Thong ke so luong sach theo the loai");
            Console.WriteLine("17 - Thong ke so luong doc gia");
            Console.WriteLine("18 - Thong ke so luong doc gia theo gioi tinh");            
            Console.WriteLine("19 - Thong ke so luong sach dang muon");
            Console.WriteLine("20 - Thong ke danh sach doc gia bi tre han");
            Console.WriteLine("0 - Thoat chuong trinh");
        }
        static int selectRequest()
        {
            int yeucau = 0;
            try
            {
                yeucau = int.Parse(Console.ReadLine());
                if (yeucau < 0 || yeucau > 20)
                {
                    Console.WriteLine("Vui long nhap so tu 0 ~ 20");
                    return selectRequest();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Vui long nhap so tu 0 ~ 20");
                return selectRequest();
            }
            return yeucau;
        }
        static void anotherRequest()
        {
            Console.WriteLine("===Nhap so tu 1 ~ 20 de thuc hien yeu cau tiep theo. Nhap 0 de ket thuc.  ?");
            int request = selectRequest();
            doRequest(request);
        }        
        static void request_01()
        {
            do_request01();
            anotherRequest();
        }
        static void do_request01()
        {
            Console.WriteLine("===Tien hanh yeu cau 01...");            
            if (dsDocGia.Count > 0)
            {
                Console.WriteLine("So doc gia trong thu vien la: " + dsDocGia.Count);
                foreach (DOC_GIA docgia in dsDocGia)
                {
                    Console.WriteLine(docgia.HoTen);
                }
            }
            else
            {
                Console.WriteLine("So doc gia trong thu vien la: 0");
            }            
            Console.WriteLine("===Ket thuc yeu cau 01...");
        }
        static void request_02()
        {            
            doRequest_02();
            anotherRequest();
        }
        static void doRequest_02()
        {
            Console.WriteLine("===Tien hanh yeu cau 02...");
            //Nhap thong tin
            DOC_GIA docgia = new DOC_GIA();
            docgia.Input_Console();
            //Kiem tra thong tin da nhap
            Console.WriteLine("Vui long kiem tra thong tin da nhap ");
            docgia.Output_Console_DocGia();
            //Luu xuong o cung
            Console.WriteLine("Ban co muon luu lai thong tin doc gia ? Y / N");
            String select = Console.ReadLine();
            if (select.ToUpper().Equals("Y"))
            {
                String result = docgia.Output_File_DocGia();
                if (result != "")
                {
                    Console.WriteLine("== Them doc gia thanh cong ! ==");
                    Console.WriteLine("== Ma doc gia vua them: " + result + " ==");
                    //Cap nhat file maxID
                    String filename = QUY_DINH.DOC_GIA_MAXID;
                    StreamWriter wt = Util.getStreamWriterDocGia(filename);
                    wt.WriteLine(result);
                    wt.Close();
                }
            }
            Console.WriteLine("===Ket thuc yeu cau 02...");
        }
        static void request_03()
        {
            do_request03();
            anotherRequest();
        }
        static void do_request03()
        {
            Console.WriteLine("===Tien hanh yeu cau 03...");
            Console.WriteLine("Ban muon chon doc gia can sua bang cach nhap ");
            Console.WriteLine("1 - CMND");
            Console.WriteLine("2 - Ho Ten");
            int select = int.Parse(Console.ReadLine());
            if (select == 1)
            {
                Console.WriteLine("Nhap so CMND cua doc gia can tim: ");
                String input = Console.ReadLine();
                DOC_GIA docgia = search_docgia_cmnd(input);
                if (docgia != null)
                {
                    SuaDocGia(docgia);
                }
                else
                {
                    Console.WriteLine("Khong tim thay doc gia thoa dieu kien!!!");
                }
            }
            else if (select == 2)
            {
                Console.WriteLine("Nhap hoten cua doc gia can tim: ");
                String input = Console.ReadLine();
                DOC_GIA docgia = search_docgia_hoten(input);
                if (docgia != null)
                {
                    SuaDocGia(docgia);
                }
                else
                {
                    Console.WriteLine("Khong tim thay doc gia thoa dieu kien!!!");
                }
            }
            else
            {
                Console.WriteLine("Vui long chon 1 hoac 2");
            }
            Console.WriteLine("===Ket thuc yeu cau 03...");
        }
        static void SuaDocGia(DOC_GIA docgia)
        {
            docgia.Edit();
            Console.WriteLine("Vui long kiem tra thong tin doc gia moi dieu chinh");
            docgia.Output_Console_DocGia();
            Console.WriteLine("Ban co muon luu lai thong tin vua dieu chinh ? Y / N");
            String select = Console.ReadLine();
            if (select.ToUpper().Equals("Y"))
            {
                String result = docgia.Output_File_DocGia();
                if (result != "")
                {
                    Console.WriteLine("== Sua doc gia thanh cong ! ==");                    
                }
                else
                {
                    Console.WriteLine("== Sua doc gia khong thanh cong ! Vui long kiem tra lai he thong");
                }
            }
        }
        static void request_04()
        {            
            do_request04();
            anotherRequest();
        }
        static void do_request04()
        {
            Console.WriteLine("===Tien hanh yeu cau 04...");
            Console.WriteLine("Ban muon chon doc gia can xoa bang cach nhap ");
            Console.WriteLine("1 - CMND");
            Console.WriteLine("2 - Ho Ten");
            int select = int.Parse(Console.ReadLine());
            if (select == 1)
            {
                Console.WriteLine("Nhap so CMND cua doc gia can tim: ");
                String input = Console.ReadLine();
                DOC_GIA docgia = search_docgia_cmnd(input);
                if (docgia != null)
                {
                    XoaDocGia(docgia);
                }
                else
                {
                    Console.WriteLine("Khong tim thay doc gia thoa dieu kien!!!");
                }
            }
            else if (select == 2)
            {
                Console.WriteLine("Nhap hoten cua doc gia can tim: ");
                String input = Console.ReadLine();
                DOC_GIA docgia = search_docgia_hoten(input);
                if (docgia != null)
                {
                    XoaDocGia(docgia);
                }
                else
                {
                    Console.WriteLine("Khong tim thay doc gia thoa dieu kien!!!");
                }
            }
            else
            {
                Console.WriteLine("Vui long chon 1 hoac 2");
            }
            Console.WriteLine("===Ket thuc yeu cau 04...");
        }
        static void XoaDocGia(DOC_GIA docgia)
        {
            String result = docgia.Delete();
            if (result != "")
            {
                Console.WriteLine("Xoa thanh cong doc gia co ID: " + result);
            }
            else
            {
                Console.WriteLine("Xoa that bai");
            }
        }
        static void request_05()
        {
            do_request05();
            anotherRequest();
        }
        static void do_request05()
        {
            Console.WriteLine("===Tien hanh yeu cau 05...");
            Console.WriteLine("Nhap so CMND cua doc gia can tim: ");
            String input = Console.ReadLine();
            DOC_GIA docgia = search_docgia_cmnd(input);
            if (docgia != null)
            {
                Console.WriteLine("Tim thay doc gia !!!");
                docgia.Output_Console_DocGia();
            }
            else
            {
                Console.WriteLine("Khong tim thay doc gia thoa dieu kien!!!");
            }
            Console.WriteLine("===Ket thuc yeu cau 05...");
        }
        static DOC_GIA search_docgia_cmnd(String CMND)
        {
            foreach (DOC_GIA docgia in dsDocGia)
            {
                if (docgia.CMND.ToUpper().Equals(CMND.ToUpper())) return docgia;
            }
            return null;
        }        
        static void request_06()
        {
            do_request06();
            anotherRequest();
        }
        static void do_request06()
        {
            Console.WriteLine("===Tien hanh yeu cau 06...");
            Console.WriteLine("Nhap hoten cua doc gia can tim: ");
            String input = Console.ReadLine();
            DOC_GIA docgia = search_docgia_hoten(input);
            if (docgia != null)
            {
                Console.WriteLine("Tim thay doc gia !!!");
                docgia.Output_Console_DocGia();
            }
            else
            {
                Console.WriteLine("Khong tim thay doc gia thoa dieu kien!!!");
            }
            Console.WriteLine("===Ket thuc yeu cau 06...");
        }
        static DOC_GIA search_docgia_hoten(String hoten)
        {
            foreach (DOC_GIA docgia in dsDocGia)
            {
                if (docgia.HoTen.ToUpper().Equals(hoten.ToUpper())) return docgia;
            }
            return null;
        }
        static void request_07()
        {
            Console.WriteLine("7 - Xem danh sach cac sach trong thu vien");
            //do_request07
            anotherRequest();
        }
        static void request_08()
        {
            Console.WriteLine("8 - Them sach");
            //do_request08
            anotherRequest();
        }
        static void request_09()
        {
            Console.WriteLine("9 - Chinh sua thong tin sach");
            //do_request09
            anotherRequest();
        }
        static void request_10()
        {
            Console.WriteLine("10 - Xoa thong tin sach");
            //do_request10
            anotherRequest();
        }
        static void request_11()
        {
            Console.WriteLine("11 - Tim kiem sach theo ISBN");
            //do_request11
            anotherRequest();
        }
        static void request_12()
        {
            Console.WriteLine("12 - Tiem kiem sach theo ten");
            //do_request11
            anotherRequest();
        }
        static void request_13()
        {
            Console.WriteLine("13 - Lap phieu muon sach");
            //do_request11
            anotherRequest();
        }
        static void request_14()
        {
            Console.WriteLine("14 - Lap phieu tra sach");
            //do_request11
            anotherRequest();
        }
        static void request_15()
        {
            Console.WriteLine("15 - Thong ke so luong sach trong thu vien");
            //do_request11
            anotherRequest();
        }
        static void request_16()
        {
            Console.WriteLine("16 - Thong ke so luong sach theo the loai");
            //do_request11
            anotherRequest();
        }
        static void request_17()
        {
            Console.WriteLine("17 - Thong ke so luong doc gia");
            //do_request11
            anotherRequest();
        }
        static void request_18()
        {
            Console.WriteLine("18 - Thong ke so luong doc gia theo gioi tinh");
            //do_request11
            anotherRequest();
        }
        static void request_19()
        {
            Console.WriteLine("19 - Thong ke so luong sach dang muon");
            //do_request11
            anotherRequest();
        }
        static void request_20()
        {
            Console.WriteLine("20 - Thong ke danh sach doc gia bi tre han");
            //do_request11
            anotherRequest();
        }

    }                
}
