using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    class Program
    {
        static void Main(string[] args)
        {
            int request;
            welcomeMessage();
            request = selectRequest();
            doRequest(request);
        }
        static void welcomeMessage()
        {
            Console.WriteLine("Lap trinh huong doi tuong - Do An Cuoi Ki");
            Console.WriteLine("Chon yeu cau can thuc hien");

            Console.WriteLine("Quan ly Doc Gia");
            Console.WriteLine("1 - Xem danh sach doc gia");
            Console.WriteLine("2 - Them doc gia");
            Console.WriteLine("3 - Chinh sua thong tin doc gia");
            Console.WriteLine("4 - Xoa thong tin doc gia");
            Console.WriteLine("5 - Tim kiem doc gia theo CMND");
            Console.WriteLine("6 - Tim kiem doc gia theo ho ten");

            Console.WriteLine("Quan ly Sach");
            Console.WriteLine("7 - Xem danh sach cac sach");
            Console.WriteLine("8 - Them sach");
            Console.WriteLine("9 - Chinh sua thong tin sach");
            Console.WriteLine("10 - Xoa thong tin sach");
            Console.WriteLine("11 - Tim kiem sach theo ISBN");
            Console.WriteLine("12 - Tim kiem sach theo ten");

            Console.WriteLine("Quan ly phieu");
            Console.WriteLine("13 - Lap phieu muon sach");
            Console.WriteLine("14 - Lap phieu tra sach");

            Console.WriteLine("Thong ke");
            Console.WriteLine("15 - Thong ke so luong sach trong thu vien");
            Console.WriteLine("16 - Thong ke so luong sach theo the loai");
            Console.WriteLine("17 - Thong ke so luong doc gia");
            Console.WriteLine("18 - Thong ke so luong doc gia theo gioi tinh");
            Console.WriteLine("19 - Thong ke so sach dang duoc muon");
            Console.WriteLine("20 - Thong ke danh sach doc gia bi tre han");
        }        
        static int selectRequest()
        {
            int yeucau = 0;
            try
            {
                yeucau = int.Parse(Console.ReadLine());
                if (!(yeucau >= 0 && yeucau <= 8))
                {
                    Console.WriteLine("Vui long nhap so 0 ~ 20");
                    return selectRequest();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Vui long nhap so 0 ~ 20");
                return selectRequest();
            }
            return yeucau;
        }
        static void anotherRequest()
        {
            Console.WriteLine("===Nhap so 1 ~ 20 de thuc hien yeu cau tiep theo. Nhap 0 de ket thuc.  ?");
            int request = selectRequest();
            doRequest(request);
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
        static void request_01()
        {
            Console.WriteLine("Xem danh sach doc gia");
            try
            {                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();
        }
        static void request_02()
        {
            Console.WriteLine("Them doc gia");
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();
        }
        static void request_03()
        {
            Console.WriteLine("Chinh sua thong tin doc gia");
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();
        }
        static void request_04()
        {
            Console.WriteLine("Xoa thong tin doc gia");
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();
        }
        static void request_05()
        {
            Console.WriteLine("Tim kiem doc gia theo CMND");
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();
        }
        static void request_06()
        {
            Console.WriteLine("Tim kiem doc gia theo ho ten");
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();
        }
        static void request_07()
        {
            Console.WriteLine("Xem danh sach cac sach");
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();
        }
        static void request_08()
        {
            Console.WriteLine("Them sach");
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();
        }
        static void request_09()
        {
            Console.WriteLine("Chinh sua thong tin sach");
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();
        }
        static void request_10()
        {
            Console.WriteLine("Xoa thong tin sach");
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();
        }
        static void request_11()
        {
            Console.WriteLine("Tim kiem sach theo ISBN");
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();
        }
        static void request_12()
        {
            Console.WriteLine("Tim kiem sach theo ten");
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();
        }
        static void request_13()
        {
            Console.WriteLine("Lap phieu muon sach");
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();
        }
        static void request_14()
        {
            Console.WriteLine("Lap phieu tra sach");
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();
        }
        static void request_15()
        {
            Console.WriteLine("Thong ke so luong sach trong thu vien");
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();
        }
        static void request_16()
        {
            Console.WriteLine("Thong ke so luong sach theo the loai");
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();
        }
        static void request_17()
        {
            Console.WriteLine("Thong ke so luong doc gia");
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();
        }
        static void request_18()
        {
            Console.WriteLine("Thong ke so luong doc gia theo gioi tinh");
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();
        }
        static void request_19()
        {
            Console.WriteLine("Thong ke so sach dang duoc muon");
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();
        }
        static void request_20()
        {
            Console.WriteLine("Thong ke danh sach doc gia bi tre han");
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();
        }
    }
}
