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
            Sorting sorting = new Sorting();            
            Console.WriteLine("Yeu cau 01 - Cho biet trang thai ban dau cua day so trong tap du lieu dau vao");
            String input = "input_10000.txt";            
            if (sorting.DocDuLieu(input) == 1)
            {                
                if (!isOneOnly(sorting.size))
                {
                    doRequest_01(sorting.iarr, sorting.size);
                }               
            }
            else //error
            {
                Console.WriteLine("Hay kiem tra lại file du lieu dau vao !!!");
            }
            anotherRequest();
        }
        static void doRequest_01(int[] a, int n)
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
            SelectionSort sorting = new SelectionSort();
            String input = "input_10000.txt";
            Console.WriteLine("Yeu cau 02 - Sap xep chon - Selection sort");
            if (sorting.DocDuLieu(input) == 1)
            {
                if (!isOneOnly(sorting.size))
                {
                    doRequest_02(sorting);
                }
            }
            else //error
            {
                Console.WriteLine("Hay kiem tra lại file du lieu dau vao !!!");
            }
            anotherRequest();

        }
        static void doRequest_02(SelectionSort sortObj)
        {
            String output = "selectionsort.txt";
            Console.WriteLine("===Tien hanh yeu cau 02...");
            sortObj.sort(0);
            Console.WriteLine("So lan swap: " + sortObj.swapcnt);
            sortObj.GhiDuLieu(output);
            Console.WriteLine("===Hoan thanh yeu cau 02...");
        }                
        static void request_03()
        {
            HeapSort sorting = new HeapSort();
            String input = "input_10000.txt";
            Console.WriteLine("Yeu cau 03 - Sap xep vun dong - Heap sort");
            if (sorting.DocDuLieu(input) == 1)
            {
                if (!isOneOnly(sorting.size))
                {
                    doRequest_03(sorting);
                }
            }
            else //error
            {
                Console.WriteLine("Hay kiem tra lại file du lieu dau vao !!!");
            }
            anotherRequest();
        }
        static void doRequest_03(HeapSort sortObj)
        {
            String output = "heapsort.txt";
            Console.WriteLine("===Tien hanh yeu cau 03...");
            Console.WriteLine("===Dang sap xep du lieu...");
            sortObj.sort();
            Console.WriteLine("So lan swap: " + sortObj.swapcnt);
            Console.WriteLine("===Hoan Thanh sap xep du lieu...");
            sortObj.GhiDuLieu(output);
            Console.WriteLine("===Hoan thanh yeu cau 03...");
        }       
        static void request_04()
        {
            QuickSort sorting = new QuickSort();
            String input = "input_10000.txt";
            Console.WriteLine("Yeu cau 04 - Sap xep nhanh - Quick sort");            
            if (sorting.DocDuLieu(input) == 1)
            {
                if (!isOneOnly(sorting.size))
                {
                    doRequest_04(sorting);
                }
            }
            else //error
            {
                Console.WriteLine("Hay kiem tra lại file du lieu dau vao !!!");
            }
            anotherRequest();
        }
        static void doRequest_04(QuickSort sortObj)
        {
            String output = "quicksort.txt";
            Console.WriteLine("===Tien hanh yeu cau 04...");
            Console.WriteLine("===Dang sap xep du lieu...");
            //quickSort(a, ref swapcnt, 0, n - 1, 0);
            sortObj.sort(0, sortObj.size - 1, 0);
            Console.WriteLine("So lan swap: " + sortObj.swapcnt);
            Console.WriteLine("===Hoan Thanh sap xep du lieu...");
            sortObj.GhiDuLieu(output);
            Console.WriteLine("===Hoan thanh yeu cau 04...");
        }
        static void request_05()
        {
            MergeSort sorting = new MergeSort();
            String input = "input_10000.txt";
            Console.WriteLine("Yeu cau 05 - Sap xep tron - Merge sort");
            if (sorting.DocDuLieu(input) == 1)
            {
                if (!isOneOnly(sorting.size))
                {
                    doRequest_05(sorting);
                }
            }
            else //error
            {
                Console.WriteLine("Hay kiem tra lại file du lieu dau vao !!!");
            }
            anotherRequest();
        }
        static void doRequest_05(MergeSort sortObj)
        {
            String output = "mergesort.txt";
            Console.WriteLine("===Tien hanh yeu cau 05...");
            Console.WriteLine("===Dang sap xep du lieu...");
            sortObj.iarr = sortObj.sort(sortObj.iarr, sortObj.size, 0);
            Console.WriteLine("So lan swap: " + sortObj.swapcnt);
            Console.WriteLine("===Hoan Thanh sap xep du lieu...");
            sortObj.GhiDuLieu(output);
            Console.WriteLine("===Hoan thanh yeu cau 05...");
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
