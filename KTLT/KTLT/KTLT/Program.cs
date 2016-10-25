using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTLT
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
        //static void request_01()
        //{
        //    Sorting sorting = new Sorting();
        //    Console.WriteLine("Yeu cau 01 - Cho biet trang thai ban dau cua day so trong tap du lieu dau vao");
        //    String input = "input_10000.txt";
        //    if (sorting.DocDuLieu(input) == 1)
        //    {
        //        if (!isOneOnly(sorting.size))
        //        {
        //            doRequest_01(sorting.iarr, sorting.size);
        //        }
        //    }
        //    else //error
        //    {
        //        Console.WriteLine("Hay kiem tra lại file du lieu dau vao !!!");
        //    }
        //    anotherRequest();
        //}
        //static void doRequest_01(int[] a, int n)
        //{
        //    Console.WriteLine("===Tien hanh yeu cau 01...");
        //    Boolean daySoGiongNhau = true;
        //    Boolean daySoTangDan = true;
        //    Boolean daySoGiamDan = true;
        //    for (int i = 1; i < n; i++)
        //    {
        //        if (a[i - 1] < a[i] && daySoGiamDan)
        //        {
        //            daySoGiongNhau = false;
        //            daySoGiamDan = false;

        //        }
        //        if (a[i - 1] > a[i] && daySoTangDan)
        //        {
        //            daySoGiongNhau = false;
        //            daySoTangDan = false;
        //        }
        //    }
        //    Console.WriteLine("Ket qua");
        //    if (!daySoTangDan && !daySoGiamDan)
        //    {
        //        Console.WriteLine("Day so ngau nhien");
        //    }
        //    else if (daySoGiongNhau)
        //    {
        //        Console.WriteLine("Day so giong nhau");
        //    }
        //    else if (daySoTangDan)
        //    {
        //        Console.WriteLine("Day so tang dan");
        //    }
        //    else if (daySoGiamDan)
        //    {
        //        Console.WriteLine("Day so giam dan");
        //    }
        //    Console.WriteLine("===Hoan thanh yeu cau 01...");
        //}
        static void request_01()
        {
            Console.WriteLine("1 - Xem danh sach doc gia");
            //do_request01
            anotherRequest();
        }
        static void request_02()
        {
            Console.WriteLine("2 - Them Doc Gia");
            //do_request02
            anotherRequest();
        }
        static void request_03()
        {
            Console.WriteLine("3 - Chinh sua thong tin doc gia");
            //do_request03
            anotherRequest();
        }
        static void request_04()
        {
            Console.WriteLine("4 - Xoa thong tin doc gia");
            //do_request04
            anotherRequest();
        }
        static void request_05()
        {
            Console.WriteLine("5 - Tim kiem doc gia theo CMND");
            //do_request05
            anotherRequest();
        }
        static void request_06()
        {
            Console.WriteLine("6 - Tim kiem doc gia theo ho ten");
            //do_request06
            anotherRequest();
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
