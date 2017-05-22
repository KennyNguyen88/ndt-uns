using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTuan04
{
    class Program
    {
        static void Main(string[] args)
        {
            int request;
            String input = "input.txt";
            welcomeMessage();
            request = selectRequest();
            doRequest(request, input);
        }
        static void welcomeMessage()
        {
            Console.WriteLine("Ly thuyet do thi - Bai tap 04");
            Console.WriteLine("Chon yeu cau can thuc hien");
            Console.WriteLine("1 - So luong thanh phan lien thong & Danh sach dinh thuoc moi thanh phan lien thong");
            //Console.WriteLine("2 - Danh sach dinh thuoc moi thanh phan lien thong");            
            Console.WriteLine("0 - Thoat chuong trinh");
        }
        static int selectRequest()
        {
            int yeucau = 0;
            try
            {
                yeucau = int.Parse(Console.ReadLine());
                if (!(yeucau == 0 || yeucau == 1))
                {
                    Console.WriteLine("Vui long nhap so 0 ~ 1");
                    return selectRequest();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Vui long nhap so 0 ~ 1");
                return selectRequest();
            }
            return yeucau;
        }
        static void anotherRequest(String input)
        {
            Console.WriteLine("===Nhap so 1 ~ 2 de thuc hien yeu cau tiep theo. Nhap 0 de ket thuc.  ?");
            int request = selectRequest();
            doRequest(request, input);
        }
        static void doRequest(int request, String input)
        {

            switch (request)
            {
                case 1:
                    request_01(input); break;                
                default:
                    break;
            }
        }
        static void request_01(String input)
        {

            Console.WriteLine("Yeu cau 01 - So luong thanh phan lien thong & Danh sach dinh thuoc moi thanh phan lien thong");
            try
            {
                GRAPH g = new GRAPH(input);
                Console.WriteLine("Du lieu cua do thi: ");
                g.writeDataConsole();
                if (validate(g)) //Do thi don
                {
                    int nLienThong = g.getConnected();                    
                    Console.WriteLine("So luong thanh phan lien thong: " + nLienThong);
                    g.printConnected();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest(input);
        }        
        //Kiem tra don do thi
        static bool validate(GRAPH g)
        {
            bool vohuong = g.KiemTraVoHuong();
            int canhboi = g.getEdgeDupCount();
            int canhkhuyen = g.getEdgeCircleCount();
            if (vohuong && canhboi == 0 && canhkhuyen == 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Do thi da cho khong la don do thi ");
                if (!vohuong)
                {
                    Console.WriteLine("Do thi da cho khong la do thi vo huong ");
                }
                else if (canhboi != 0)
                {
                    Console.WriteLine("Do thi da cho ton tai canh boi ");
                }
                else if (canhkhuyen != 0)
                {
                    Console.WriteLine("Do thi da cho ton tai canh khuyen ");
                }
                return false;
            }

        }
    }
}
