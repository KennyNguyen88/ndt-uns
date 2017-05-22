using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTuan02
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
            Console.WriteLine("Ly thuyet do thi - Bai tap 02");
            Console.WriteLine("Chon yeu cau can thuc hien");
            Console.WriteLine("1 - Kiem tra tinh co huong cua do thi");
            Console.WriteLine("2 - Xac dinh so luong dinh");
            Console.WriteLine("3 - Xac dinh so luong canh");
            Console.WriteLine("4 - Xac dinh bac cua tung dinh");
            Console.WriteLine("0 - Thoat chuong trinh");
        }
        static int selectRequest()
        {
            int yeucau = 0;
            try
            {
                yeucau = int.Parse(Console.ReadLine());
                if (!(yeucau == 0 || yeucau == 1 || yeucau == 2 || yeucau == 3 || yeucau == 4))
                {
                    Console.WriteLine("Vui long nhap so 0 ~ 4");
                    return selectRequest();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Vui long nhap so 0 ~ 4");
                return selectRequest();
            }
            return yeucau;
        }
        static void anotherRequest(String input)
        {
            Console.WriteLine("===Nhap so 1 ~ 4 de thuc hien yeu cau tiep theo. Nhap 0 de ket thuc.  ?");
            int request = selectRequest();
            doRequest(request, input);
        }
        static void doRequest(int request, String input)
        {
            
            switch (request)
            {
                case 1:
                    request_01(input); break;
                case 2:
                    request_02(input); break;
                case 3:
                    request_03(input); break;
                case 4:
                    request_04(input); break;
                default:
                    break;
            }
        }
        static void request_01(String input)
        {
            
            Console.WriteLine("Yeu cau 01 - Kiem tra tinh co huong cua do thi");
            try
            {
                GRAPH g = new GRAPH(input);
                Console.WriteLine("Du lieu cua do thi: ");
                g.writeDataConsole();
                if(g.KiemTraVoHuong())
                {
                    Console.WriteLine("Do thi vo huong");
                }
                else
                {
                    Console.WriteLine("Do thi co huong");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest(input);
        }
        static void request_02(String input)
        {
            
            Console.WriteLine("Yeu cau 02 - Xac dinh so luong dinh");
            try
            {
                GRAPH g = new GRAPH(input);
                int nchan = 0;
                int nle = 0;
                int ntreo = 0;
                int ncolap = 0;
                Console.WriteLine("Du lieu cua do thi: ");
                g.writeDataConsole();
                for (int i = 0; i < g.getN(); i++)
                {
                    if (g.getDegree(i) > 0)
                    {
                        if (g.getDegree(i) % 2 == 0)
                        {
                            nchan++;
                        }
                        else
                        {
                            nle++;
                            if (g.getDegree(i) == 1)
                            {
                                ntreo++;
                            }
                        }
                    }
                    else
                    {
                        ncolap++;
                    }
                }
                Console.WriteLine("Tong so luong dinh: " + g.getN());
                Console.WriteLine("Tong so luong dinh bac chan: " + nchan);
                Console.WriteLine("Tong so luong dinh bac le: " + nle);
                Console.WriteLine("Tong so luong dinh treo: " + ntreo);
                Console.WriteLine("Tong so luong dinh co lap: " + ncolap);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            anotherRequest(input);
        }
        static void request_03(String input)
        {            
            Console.WriteLine("Yeu cau 03 - Xac dinh so luong canh");
            try
            {
                GRAPH g = new GRAPH(input);
                Console.WriteLine("Du lieu cua do thi: ");
                g.writeDataConsole();
                Console.WriteLine("Tong so canh: " + g.getEdgeCount());
                Console.WriteLine("Tong so canh khuyen: " + g.getEdgeCircleCount());
                Console.WriteLine("Tong so canh boi: " + g.getEdgeDupCount());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            anotherRequest(input);
        }
        static void request_04(String input)
        {
            
            Console.WriteLine("Yeu cau 04 - Xac dinh bac cua tung dinh");
            try
            {
                
                GRAPH g = new GRAPH(input);
                Console.WriteLine("Du lieu cua do thi: ");
                g.writeDataConsole();
                for (int i = 0; i < g.getN(); i++)
                {
                    if (g.KiemTraVoHuong())
                    {
                        Console.WriteLine("Bac cua dinh " + (i + 1) + " la: " + g.getDegreeDetail(i)[0]);
                    }
                    else
                    {
                        Console.WriteLine("Bac vao cua " + (i + 1) + " la: " + g.getDegreeDetail(i)[0]);
                        Console.WriteLine("Bac ra cua " + (i + 1) + " la: " + g.getDegreeDetail(i)[1]);
                    }
                }                                                                                  
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            anotherRequest(input);
        }        
    }
}
