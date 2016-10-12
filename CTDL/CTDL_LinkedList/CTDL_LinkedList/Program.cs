using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_LinkedList
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
                case 6:
                    request_06(); break;
                case 7:
                    request_07(); break;
                case 8:
                    request_08(); break;
                default:
                    break;
            }
        }
        static void welcomeMessage()
        {
            Console.WriteLine("Project 02 - Danh sach lien ket va bai toan Josephus");
            Console.WriteLine("Chon yeu cau can thuc hien");           
            Console.WriteLine("6 - Thuc hien tro choi voi thanh vien dau danh sach");
            Console.WriteLine("7 - Thuc hien tro choi voi thanh vien do ngoi dung chon");                       
            Console.WriteLine("8 - Tong quan hoa bai toan voi N thanh vien, loai thanh vien M");
            Console.WriteLine("0 - Thoat chuong trinh");
        }
        static int selectRequest()
        {
            int yeucau = 0;
            try
            {
                yeucau = int.Parse(Console.ReadLine());
                if (!(yeucau == 0 && yeucau == 6 && yeucau == 7 && yeucau == 8))
                {
                    Console.WriteLine("Vui long nhap so 0,6,7,8");
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
            Console.WriteLine("===Nhap so 6,7,8 de thuc hien yeu cau tiep theo. Nhap 0 de ket thuc.  ?");
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
        static void request_06()
        {
            //RadixSort sorting = new RadixSort();
            //String input = "input_10000.txt";
            //Console.WriteLine("Yeu cau 06 - Sap xep theo co so - Radix sort");
            //if (sorting.DocDuLieu(input) == 1)
            //{
            //    if (!isOneOnly(sorting.size))
            //    {
            //        doRequest_06(sorting);
            //    }
            //}
            //else //error
            //{
            //    Console.WriteLine("Hay kiem tra lại file du lieu dau vao !!!");
            //}
            //anotherRequest();
        }
        //static void doRequest_06(RadixSort sortObj)
        //{
        //    String output = "radixsort.txt";
        //    Console.WriteLine("===Tien hanh yeu cau 06...");
        //    Console.WriteLine("===Dang sap xep du lieu...");
        //    sortObj.sort();
        //    Console.WriteLine("===Hoan Thanh sap xep du lieu...");
        //    sortObj.GhiDuLieu(output);
        //    Console.WriteLine("===Hoan thanh yeu cau 06...");
        //}
        static void request_07()
        {
            //Console.WriteLine("Yeu cau 07 - So sanh hieu qua cac thuat toan khi lam viec voi day so co kich thuoc tang dan");
            ////String input = "input_10000.txt";
            //String input = "input_100000.txt";
            ////String input = "input_500000.txt";

            //Console.WriteLine("Sap xep chon - Selection sort");
            //SelectionSort selectionSort = new SelectionSort();
            //if (selectionSort.DocDuLieu(input) == 1)
            //{
            //    if (!isOneOnly(selectionSort.size))
            //    {
            //        selectionSort.sort(0);
            //        Console.WriteLine("So lan swap: " + selectionSort.swapcnt);
            //    }
            //}
            //Console.WriteLine("Sap xep vun dong - Heap sort");
            //HeapSort heapSort = new HeapSort();
            //if (heapSort.DocDuLieu(input) == 1)
            //{
            //    if (!isOneOnly(heapSort.size))
            //    {
            //        heapSort.sort(0);
            //        Console.WriteLine("So lan swap: " + heapSort.swapcnt);
            //    }
            //}
            //Console.WriteLine("Sap xep nhanh - Quick sort");
            //QuickSort quickSort = new QuickSort();
            //if (quickSort.DocDuLieu(input) == 1)
            //{
            //    if (!isOneOnly(quickSort.size))
            //    {
            //        quickSort.sort(0, quickSort.size - 1, 0); ;
            //        Console.WriteLine("So lan swap: " + quickSort.swapcnt);
            //    }
            //}
            //Console.WriteLine("Sap xep tron - Merge sort");
            //MergeSort mergeSort = new MergeSort();
            //if (mergeSort.DocDuLieu(input) == 1)
            //{
            //    if (!isOneOnly(mergeSort.size))
            //    {
            //        mergeSort.sort(0, mergeSort.size - 1); ;
            //        Console.WriteLine("So lan swap: " + mergeSort.swapcnt);
            //    }
            //}
            //anotherRequest();

        }
        static void request_08()
        {
            //Console.WriteLine("Yeu cau 08 - So sanh hieu qua cac thuat toan khi lam viec voi day so co kich thuoc ban dau khac nhau");
            ////String input = "input_same.txt";
            ////String input = "input_random.txt";
            ////String input = "input_ascending.txt";
            //String input = "input_descending.txt";

            //Console.WriteLine("Sap xep chon - Selection sort");
            //SelectionSort selectionSort = new SelectionSort();
            //if (selectionSort.DocDuLieu(input) == 1)
            //{
            //    if (!isOneOnly(selectionSort.size))
            //    {
            //        selectionSort.sort(0);
            //        Console.WriteLine("So lan swap: " + selectionSort.swapcnt);
            //    }
            //}
            //Console.WriteLine("Sap xep vun dong - Heap sort");
            //HeapSort heapSort = new HeapSort();
            //if (heapSort.DocDuLieu(input) == 1)
            //{
            //    if (!isOneOnly(heapSort.size))
            //    {
            //        heapSort.sort(0);
            //        Console.WriteLine("So lan swap: " + heapSort.swapcnt);
            //    }
            //}
            //Console.WriteLine("Sap xep nhanh - Quick sort");
            //QuickSort quickSort = new QuickSort();
            //if (quickSort.DocDuLieu(input) == 1)
            //{
            //    if (!isOneOnly(quickSort.size))
            //    {
            //        quickSort.sort(0, quickSort.size - 1, 0); ;
            //        Console.WriteLine("So lan swap: " + quickSort.swapcnt);
            //    }
            //}
            //Console.WriteLine("Sap xep tron - Merge sort");
            //MergeSort mergeSort = new MergeSort();
            //if (mergeSort.DocDuLieu(input) == 1)
            //{
            //    if (!isOneOnly(mergeSort.size))
            //    {
            //        mergeSort.sort(0, mergeSort.size - 1); ;
            //        Console.WriteLine("So lan swap: " + mergeSort.swapcnt);
            //    }
            //}
            //anotherRequest();
        }        
    }
}
