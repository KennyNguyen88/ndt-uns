using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTuan1_KhaoSatDoThi
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
            Console.WriteLine("Ly thuyet do thi - Bai tap 01");
            Console.WriteLine("Chon yeu cau can thuc hien");
            Console.WriteLine("1 - Dem so luong Dinh va Canh cua Do Thi");
            Console.WriteLine("2 - Xac dinh Dinh Ke cua 1 Dinh bat ky");
            Console.WriteLine("3 - Tinh Bac cua tung Dinh");
            Console.WriteLine("4 - Dem so luong Dinh bac chan");
            Console.WriteLine("5 - Dem so luong Dinh bac le");
            Console.WriteLine("6 - Dem so luong Dinh treo");
            Console.WriteLine("7 - Dem so luong Dinh co lap");
            Console.WriteLine("8 - Chuyen doi Do Thi co huong thanh vo huong");
            Console.WriteLine("9 - Them hay bot 1 canh");
            Console.WriteLine("10 - Them hay bot 1 dinh");
            Console.WriteLine("11 - Thay doi gia tri trong so cua canh");
            Console.WriteLine("0 - Thoat chuong trinh");
        }
        static int selectRequest()
        {
            int yeucau = 0;
            try
            {
                yeucau = int.Parse(Console.ReadLine());
                if (!(yeucau == 0 || yeucau == 1 || yeucau == 2 || yeucau == 3 || yeucau == 4 || yeucau == 5 || yeucau == 6 || yeucau == 7 || yeucau == 8 || yeucau == 9 || yeucau == 10 || yeucau == 11))
                {
                    Console.WriteLine("Vui long nhap so 0 ~ 11");
                    return selectRequest();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Vui long nhap so 0 ~ 11");
                return selectRequest();
            }
            return yeucau;
        }
        static void anotherRequest()
        {
            Console.WriteLine("===Nhap so 1 ~ 11 de thuc hien yeu cau tiep theo. Nhap 0 de ket thuc.  ?");
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
                default:
                    break;
            }
        }
        static void request_01()
        {
            String input = "DOTHI1.txt";
            Console.WriteLine("Yeu cau 01 - Dem so luong Dinh va Canh cua Do Thi");
            try
            {
                GRAPH g = new GRAPH(input);
                g.writeDataConsole();
                Console.WriteLine("Do thi co " + g.getN() + " Dinh va " + g.getEdgeCount() + " canh");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            anotherRequest();
        }
        static void request_02()
        {
            String input = "DOTHI1.txt";
            Console.WriteLine("Yeu cau 02 - Xac dinh Dinh Ke cua 1 Dinh bat ky");
            try
            {
                GRAPH g = new GRAPH(input);
                int x = -1;
                Console.WriteLine("Nhap dinh can xac dinh (bat dau tu 1) !");
                x = int.Parse(Console.ReadLine());
                if (x > 0 && x <= g.getN())
                {
                    Console.WriteLine("Dinh ke cua " + (x) + " la: ");
                    g.getNeighbor(x-1);
                }
                else
                {
                    Console.WriteLine("Dinh nhap vao khong hop le ! Vui long kiem tra !");
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            anotherRequest();
        }
        static void request_03()
        {
            String input = "DOTHI1.txt";
            Console.WriteLine("Yeu cau 03 - Xac dinh Bac cua tung dinh");
            try
            {
                GRAPH g = new GRAPH(input);
                for (int i = 0; i < g.getN(); i ++)
                {
                    Console.WriteLine("Bac cua dinh " + (i + 1) + " la: " + g.getDegree(i));
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            anotherRequest();
        }
        static void request_04()
        {
            String input = "DOTHI1.txt";
            Console.WriteLine("Yeu cau 04 - Dem so luong Dinh bac chan");
            try
            {
                int dem = 0;
                GRAPH g = new GRAPH(input);
                for (int i = 0; i < g.getN(); i++)
                {
                    if (g.getDegree(i) % 2 == 0)
                    {
                        dem++;
                    }
                }
                Console.WriteLine("So luong dinh bac chan: " + dem);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
            anotherRequest();
        }
        static void request_05()
        {
            String input = "DOTHI1.txt";
            Console.WriteLine("Yeu cau 05 - Dem so luong Dinh bac le");
            try
            {
                int dem = 0;
                GRAPH g = new GRAPH(input);
                for (int i = 0; i < g.getN(); i++)
                {
                    if (g.getDegree(i) % 2 != 0)
                    {
                        dem++;
                    }
                }
                Console.WriteLine("So luong dinh bac le: " + dem);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            anotherRequest();
        }
        static void request_06()
        {
            String input = "DOTHI1.txt";
            Console.WriteLine("Yeu cau 06 - Dem so luong Dinh treo");
            try
            {
                int dem = 0;
                GRAPH g = new GRAPH(input);
                for (int i = 0; i < g.getN(); i++)
                {
                    if (g.getDegree(i) == 1)
                    {
                        dem++;
                    }
                }
                Console.WriteLine("So luong dinh bac treo: " + dem);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            anotherRequest();
        }
        static void request_07()
        {
            String input = "DOTHI1.txt";
            Console.WriteLine("Yeu cau 07 - Dem so luong Dinh co lap");
            try
            {
                int dem = 0;
                GRAPH g = new GRAPH(input);
                for (int i = 0; i < g.getN(); i++)
                {
                    if (g.getDegree(i) == 0)
                    {
                        dem++;
                    }
                }
                Console.WriteLine("So luong dinh bac co lap: " + dem);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            anotherRequest();
        }
        static void request_08()
        {
            anotherRequest();
        }
        static void request_09()
        {
            anotherRequest();
        }
        static void request_10()
        {
            anotherRequest();
        }
        static void request_11()
        {
            anotherRequest();
        }
    }
}