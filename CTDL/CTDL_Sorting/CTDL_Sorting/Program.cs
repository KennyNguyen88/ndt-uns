using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_Sorting
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
                    request_01();                    
                    break;
                case 2:
                    request_02();
                    break;
                case 3:
                    request_03();
                    break;
                case 4:
                    request_04();
                    break;
                case 5:
                    request_05();
                    break;
                case 6:
                    request_06();
                    break;
                case 7:
                    request_07();
                    break;
                case 8:
                    request_08();
                    break;
                case 9:
                    request_09();
                    break;
                case 10:
                    request_10();
                    break;
                default:
                    break;
            }
        }
        static void welcomeMessage()
        {            
            Console.WriteLine("Project 01 - Sorting");
            Console.WriteLine("Chon yeu cau can thuc hien");
            Console.WriteLine("1 - Cho biet trang thai ban dau cua day so trong tap du lieu dau vao");
            Console.WriteLine("2 - Sap xep chon - Selection sort");
            Console.WriteLine("3 - Sap xep vun dong - Heap sort");
            Console.WriteLine("4 - Sap xep nhanh - Quick sort");
            Console.WriteLine("5 - Sap xep tron - Merge sort");
            Console.WriteLine("6 - Sap xep theo co so - Radix sort");
            Console.WriteLine("7 - So sanh hieu qua cac thuat toan khi lam viec voi da so co kich thuoc tang dan");
            Console.WriteLine("8 - So sanh hieu qua cac thuat toan khi lam viec voi day so co kich thuoc ban dau khac nhau");
            Console.WriteLine("9 - Hieu chinh thuat toan sap xep vun dong - radix sort");
            Console.WriteLine("10 - Khu de quy thuat toan sap xep nhanh");
            Console.WriteLine("0 - Thoat chuong trinh");
        }
        static int selectRequest()
        {
            int yeucau = 0;
            try
            {
                yeucau = int.Parse(Console.ReadLine());
                if (yeucau < 0 || yeucau > 10)
                {
                    Console.WriteLine("Vui long nhap so tu 0 ~ 10");
                    return selectRequest();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Vui long nhap so tu 0 ~ 10");
                return selectRequest();
            }
            return yeucau;
        }
        static void anotherRequest()
        {
            Console.WriteLine("===Nhap so tu 1 ~ 10 de thuc hien yeu cau tiep theo. Nhap 0 de ket thuc.  ?");
            int request = selectRequest();
            doRequest(request);
        }
        static Boolean isOneOnly(int n)
        {
            if (n == 1)
            {
                Console.WriteLine("Day chi co 1 phan tu");
                return true;
            }
            return false;
        }
        static void request_01()
        {
            int[] a = new int[] { };
            int n = 0;
            Console.WriteLine("Yeu cau 01 - Cho biet trang thai ban dau cua day so trong tap du lieu dau vao");
            String filename = "input_10000.txt";
            //String filename = "selectionsort.txt";
            Console.WriteLine("===Doc du lieu dau vao...");
            if (Util.ReadFile(filename,ref a,ref n) == 1)
            {
                Console.WriteLine("So luong phan tu: " + n);
                Console.WriteLine("===Hoan thanh doc du lieu dau vao...");
                if (!isOneOnly(n))
                {
                    doRequest_01(ref a, ref n);
                }               
            }
            else //error
            {
                Console.WriteLine("Hay kiem tra lại file du lieu dau vao !!!");
            }
            anotherRequest();
        }
        static void doRequest_01(ref int[] a, ref int n)
        {
            Console.WriteLine("===Tien hanh yeu cau 01...");
            Boolean daySoGiongNhau = true;
            Boolean daySoTangDan = true;
            Boolean daySoGiamDan = true;
            for (int i = 1; i < n; i++)
            {
                if (a[i - 1] < a[i] && daySoGiamDan)
                {
                    daySoGiongNhau = false;
                    daySoGiamDan = false;

                }
                if (a[i - 1] > a[i] && daySoTangDan)
                {
                    daySoGiongNhau = false;
                    daySoTangDan = false;
                }
            }
            Console.WriteLine("Ket qua");
            if (!daySoTangDan && !daySoGiamDan)
            {
                Console.WriteLine("Day so ngau nhien");
            }
            else if (daySoGiongNhau)
            {
                Console.WriteLine("Day so giong nhau");
            }
            else if (daySoTangDan)
            {
                Console.WriteLine("Day so tang dan");
            }
            else if (daySoGiamDan)
            {
                Console.WriteLine("Day so giam dan");                    
            }                    
            Console.WriteLine("===Hoan thanh yeu cau 01...");
        }
        static void request_02()
        {
            int[] a = new int[] { };
            int n = 0;            
            String input = "input_10000.txt";
            Console.WriteLine("Yeu cau 02 - Sap xep chon - Selection sort");
            Console.WriteLine("===Doc du lieu dau vao...");
            if (Util.ReadFile(input, ref a, ref n) == 1)
            {
                Console.WriteLine("So luong phan tu: " + n);
                Console.WriteLine("===Hoan thanh doc du lieu dau vao...");
                if (!isOneOnly(n))
                {
                    doRequest_02(ref a, ref n);
                }                
            }
            else //error
            {
                Console.WriteLine("Hay kiem tra lại file du lieu dau vao !!!");
            }
            anotherRequest();

        }
        static void doRequest_02(ref int[] a, ref int n)
        {
            String output = "selectionsort.txt";
            Console.WriteLine("===Tien hanh yeu cau 02...");
            Console.WriteLine("===Dang sap xep du lieu...");
            Console.WriteLine("So lan swap: " + selectionSort(0, ref a, ref n));
            Console.WriteLine("===Hoan Thanh sap xep du lieu...");
            Console.WriteLine("===Dang ghi du lieu...");
            Util.WriteFile(output, a, n);
            Console.WriteLine("===Hoan thanh ghi du lieu...");
            //code
            Console.WriteLine("===Hoan thanh yeu cau 02...");
        }
        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static int selectionSort(int sort, ref int[] a, ref int n)
        {
            int swapcnt = 0;
            if (sort == 0) //Sap xep tang dan
            {
                
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (a[i] > a[j])
                        {
                            swap(ref a[i], ref a[j]);
                            swapcnt++;
                        }
                    }
                }                
            }
            else //Sap xep giam dan
            {
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (a[i] < a[j])
                        {
                            swap(ref a[i], ref a[j]);
                            swapcnt++;
                        }
                    }
                }
            }
            return swapcnt;
        }


        static void request_03()
        {

        }
        static void request_04()
        {

        }
        static void request_05()
        {

        }
        static void request_06()
        {

        }
        static void request_07()
        {

        }
        static void request_08()
        {

        }
        static void request_09()
        {

        }
        static void request_10()
        {

        }

    }
}
