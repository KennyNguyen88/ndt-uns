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
            //test();
        }
        static void test()
        {
            CIRCLE circle = new CIRCLE();
            circle.ReadInput("input.txt");
            circle.circlePrint();
            Console.ReadLine();
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
            Console.WriteLine("8 - Tong quan hoa bai toan voi N thanh vien, loai thanh vien cach M");
            Console.WriteLine("0 - Thoat chuong trinh");
        }
        static int selectRequest()
        {
            int yeucau = 0;
            try
            {
                yeucau = int.Parse(Console.ReadLine());
                if (!(yeucau == 0 || yeucau == 6 || yeucau == 7 || yeucau == 8))
                {
                    Console.WriteLine("Vui long nhap so 0,6,7,8");
                    return selectRequest();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Vui long nhap so 0,6,7,8");
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
            String input = "input.txt";
            CIRCLE circle = new CIRCLE();            
            Console.WriteLine("Yeu cau 06 - Thuc hien tro choi voi thanh vien dau danh sach");
            Console.WriteLine("=====Dang doc du lieu...");
            circle.ReadInput(input);
            Console.WriteLine("=====Ket thuc doc du lieu...");
            MEMBER firstReq = circle.head;
            int distance = 2;
            circle.play(firstReq, distance);
            Console.WriteLine("=====Ket qua");
            circle.circlePrint();
            anotherRequest();
        }
        static void request_07()
        {
            String input = "input.txt";
            CIRCLE circle = new CIRCLE();
            Console.WriteLine("Yeu cau 07 - Thuc hien tro choi voi thanh vien do ngoi dung chon");
            Console.WriteLine("=====Dang doc du lieu...");
            circle.ReadInput(input);
            Console.WriteLine("=====Ket thuc doc du lieu...");
            Console.WriteLine("Danh sach thanh vien");
            circle.circlePrint();
            Console.WriteLine("Chon thanh vien khoi dong bang cach nhap so tuong ung");
            int select = int.Parse(Console.ReadLine());
            MEMBER firstReq = circle.find(select);
            int distance = 2;
            circle.play(firstReq, distance);
            Console.WriteLine("=====Ket qua");
            circle.circlePrint();
            anotherRequest();

        }
        static void request_08()
        {
            String input = "input.txt";
            CIRCLE circle = new CIRCLE();
            Console.WriteLine("Yeu cau 08 - Tong quan hoa bai toan voi N thanh vien, loai thanh vien cach M");
            Console.WriteLine("=====Dang doc du lieu...");
            circle.ReadInput(input);
            Console.WriteLine("=====Ket thuc doc du lieu...");
            Console.WriteLine("Danh sach thanh vien");
            circle.circlePrint();
            Console.WriteLine("Chon thanh vien khoi dong bang cach nhap so tuong ung");
            int select = int.Parse(Console.ReadLine());
            MEMBER firstReq = circle.find(select);
            Console.WriteLine("Nhap khoang cach M");
            int distance = int.Parse(Console.ReadLine());            
            circle.play(firstReq, distance);
            Console.WriteLine("=====Ket qua");
            circle.circlePrint();
            anotherRequest();
        }        
    }
}
