using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTuan05
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
            Console.WriteLine("Ly thuyet do thi - Bai tap 05");
            Console.WriteLine("Chon yeu cau can thuc hien");
            Console.WriteLine("1 - Ap dung thuat toan Kruskal tim cay khung nho nhat cua do thi");             
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
            Console.WriteLine("===Nhap so 1 de thuc hien yeu cau tiep theo. Nhap 0 de ket thuc.  ?");
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

            Console.WriteLine("Ap dung thuat toan Kruskal tim cay khung nho nhat cua do thi");
            try
            {
                GRAPH g = new GRAPH(input);
                Console.WriteLine("Du lieu cua do thi: ");
                g.writeDataConsole();
                if (validate(g)) //Do thi don
                {
                    EDGE[] x = g.getMinSpanningTreeKruskal();
                    int sum = 0;
                    Console.WriteLine("Tap canh cua cay khung: ");
                    foreach (EDGE e in x)
                    {
                        if (e != null)
                        {
                            e.print();
                            sum += e.value;
                        }
                            
                    }
                    Console.WriteLine("Trong so cua cay khung: " + sum);
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
            //do thi trong so > 1 --> khong can kiem tra canh boi
            int canhboi = g.getEdgeDupCount();
            canhboi = 0;
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
