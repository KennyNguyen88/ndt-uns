using System;
using System.Collections;
using System.Diagnostics;
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
            Console.WriteLine("Ly thuyet do thi - Do An Cuoi Ki");
            Console.WriteLine("Chon yeu cau can thuc hien");
            Console.WriteLine("1 - Dijkstra do thi khong co canh chi phi am");
            Console.WriteLine("2 - Bellman do thi khong co canh chi phi am");
            Console.WriteLine("3 - Dijkstra do thi co canh chi phi am");
            Console.WriteLine("4 - Bellman do thi co canh chi phi am");

            Console.WriteLine("5 - Do thoi gian Dijkstra");
            Console.WriteLine("6 - Do thoi gian Bellman");

            Console.WriteLine("7 - Floy do thi khong co canh chi phi am");
            Console.WriteLine("8 - Do thoi gian Floy");            
            Console.WriteLine("0 - Thoat chuong trinh");
        }
        static int selectRequest()
        {
            int yeucau = 0;
            try
            {
                yeucau = int.Parse(Console.ReadLine());
                if (!(yeucau >=0 && yeucau <=8))
                {
                    Console.WriteLine("Vui long nhap so 0 ~ 8");
                    return selectRequest();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Vui long nhap so 0 ~ 8");
                return selectRequest();
            }
            return yeucau;
        }
        static void anotherRequest()
        {
            Console.WriteLine("===Nhap so 1 ~ 8 de thuc hien yeu cau tiep theo. Nhap 0 de ket thuc.  ?");
            int request = selectRequest();
            doRequest(request);
        }
        static void doRequest(int request)
        {
            String inputPositive = "inputPositive.txt";
            String inputNegative = "inputNegative.txt";
            String inputPositiveLarge = "inputPositiveLarge.txt";
            switch (request)
            {
                case 1:
                    request_01(inputPositive); break;                    
                case 2:
                    request_02(inputPositive); break;                    
                case 3:
                    request_03(inputNegative); break;                    
                case 4:
                    request_04(inputNegative); break;
                case 5:
                    request_05(inputPositiveLarge); break;
                case 6:
                    request_06(inputPositiveLarge); break;
                case 7:
                    request_07(inputPositive); break;
                case 8:
                    request_08(inputPositiveLarge); break;
                default:
                    break;
            }
        }
        static void request_01(String input)
        {
            Console.WriteLine("Dijkstra do thi khong co canh chi phi am");
            try
            {
                GRAPH g = new GRAPH(input);
                Console.WriteLine("Du lieu cua do thi: ");
                g.writeDataConsole();
                int s = -1;
                int t = -1;
                if (validate(g))
                {
                    //get input
                    Console.WriteLine("Nhap dinh bat dau s [Tap dinh bat dau tu 0]");
                    s = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap dinh ket thuc t [Tap dinh bat dau tu 0]");
                    t = int.Parse(Console.ReadLine());
                    if ((s > -1 && s < g.getN() - 1) && (t > -1 && t < g.getN()))
                    {
                        //validate input success
                        ArrayList result = new ArrayList();
                        result = g.getMinRouteDijkstra(s, t);
                        int[] label = result[0] as int[];
                        int length = int.Parse(result[1].ToString());
                        g.printDijkstra(label, s, t);
                        if (length > Util.VOCUC/2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Do dai: " + 0);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Do dai: " + length);
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Vui long kiem tra lai input !");
                    }                                                            
                }
                else
                {
                    validateFail(g);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();
        }
        static void request_02(String input)
        {
            Console.WriteLine("Bellman do thi khong co canh chi phi am");
            try
            {
                GRAPH g = new GRAPH(input);
                Console.WriteLine("Du lieu cua do thi: ");
                g.writeDataConsole();
                int s = -1;
                int t = -1;
                if (validate(g))
                {
                    //get input
                    Console.WriteLine("Nhap dinh bat dau s [Tap dinh bat dau tu 0]");
                    s = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap dinh ket thuc t [Tap dinh bat dau tu 0]");
                    t = int.Parse(Console.ReadLine());
                    if ((s > -1 && s < g.getN() - 1) && (t > -1 && t < g.getN()))
                    {
                        //validate input success
                        ArrayList result = new ArrayList();
                        result = g.getMinRouteBellman(s);
                        int step = int.Parse(result[1].ToString());
                        int[,] previous = result[2] as int[,];
                        int[,] mincost = result[3] as int[,];
                        g.printBellman(previous, step, s, t);
                        if (mincost[step, t] > Util.VOCUC / 2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Do dai: " + 0);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Do dai: " + mincost[step, t]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Vui long kiem tra lai input !");
                    }
                }
                else
                {
                    validateFail(g);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();
        }
        static void request_03(String input)
        {
            Console.WriteLine("Dijkstra do thi co canh chi phi am");
            try
            {
                GRAPH g = new GRAPH(input);
                Console.WriteLine("Du lieu cua do thi: ");
                g.writeDataConsole();
                int s = -1;
                int t = -1;
                if (validate(g))
                {
                    //get input
                    Console.WriteLine("Nhap dinh bat dau s [Tap dinh bat dau tu 0]");
                    s = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap dinh ket thuc t [Tap dinh bat dau tu 0]");
                    t = int.Parse(Console.ReadLine());
                    if ((s > -1 && s < g.getN() - 1) && (t > -1 && t < g.getN()))
                    {
                        //validate input success
                        ArrayList result = new ArrayList();
                        result = g.getMinRouteDijkstra(s, t);
                        int[] label = result[0] as int[];
                        int length = int.Parse(result[1].ToString());
                        g.printDijkstra(label, s, t);
                        if (length > Util.VOCUC / 2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Do dai: " + 0);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Do dai: " + length);
                        }
                    }
                    else
                    {

                        Console.WriteLine("Vui long kiem tra lai input !");
                    }
                }
                else
                {
                    validateFail(g);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();

        }
        static void request_04(String input)
        {

            Console.WriteLine("Bellman do thi co canh chi phi am");
            try
            {
                GRAPH g = new GRAPH(input);
                Console.WriteLine("Du lieu cua do thi: ");
                g.writeDataConsole();
                int s = -1;
                int t = -1;
                if (validate(g))
                {
                    //get input
                    Console.WriteLine("Nhap dinh bat dau s [Tap dinh bat dau tu 0]");
                    s = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap dinh ket thuc t [Tap dinh bat dau tu 0]");
                    t = int.Parse(Console.ReadLine());
                    if ((s > -1 && s < g.getN() - 1) && (t > -1 && t < g.getN()))
                    {
                        //validate input success
                        ArrayList result = new ArrayList();
                        result = g.getMinRouteBellman(s);
                        int step = int.Parse(result[1].ToString());
                        int[,] previous = result[2] as int[,];
                        int[,] mincost = result[3] as int[,];
                        g.printBellman(previous, step, s, t);
                        if (mincost[step, t] > Util.VOCUC / 2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Do dai: " + 0);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Do dai: " + mincost[step, t]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Vui long kiem tra lai input !");
                    }
                }
                else
                {
                    validateFail(g);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();

        }

        static void request_05(String input)
        {

            Console.WriteLine("Do thoi gian Dijkstra");
            try
            {
                GRAPH g = new GRAPH(input);
                Console.WriteLine("Du lieu cua do thi: ");
                g.writeDataConsole();
                int s = -1;
                int t = -1;
                if (validate(g))
                {
                    //get input
                    Console.WriteLine("Nhap dinh bat dau s [Tap dinh bat dau tu 0]");
                    s = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap dinh ket thuc t [Tap dinh bat dau tu 0]");
                    t = int.Parse(Console.ReadLine());
                    if ((s > -1 && s < g.getN() - 1) && (t > -1 && t < g.getN()))
                    {
                        //validate input success                        
                        ArrayList result = new ArrayList();
                        Stopwatch sw = Stopwatch.StartNew(); //Bat dau do thoi gian
                        result = g.getMinRouteDijkstra(s, t);
                        sw.Stop(); //Ket thuc do thoi gian
                        long elapsedMs = sw.ElapsedTicks;
                        int[] label = result[0] as int[];
                        int length = int.Parse(result[1].ToString());
                        g.printDijkstra(label, s, t);
                        if (length > Util.VOCUC / 2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Do dai: " + 0);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Do dai: " + length);
                        }
                        Console.WriteLine("Tong Thoi Gian: " + elapsedMs);

                    }
                    else
                    {
                        Console.WriteLine("Vui long kiem tra lai input !");
                    }
                }
                else
                {
                    validateFail(g);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();

        }        
        static void request_06(String input)
        {

            Console.WriteLine("Do thoi gian Bellman");
            try
            {
                GRAPH g = new GRAPH(input);
                Console.WriteLine("Du lieu cua do thi: ");
                g.writeDataConsole();
                int s = -1;
                int t = -1;
                if (validate(g))
                {
                    //get input
                    Console.WriteLine("Nhap dinh bat dau s [Tap dinh bat dau tu 0]");
                    s = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap dinh ket thuc t [Tap dinh bat dau tu 0]");
                    t = int.Parse(Console.ReadLine());
                    if ((s > -1 && s < g.getN() - 1) && (t > -1 && t < g.getN()))
                    {
                        //validate input success
                        ArrayList result = new ArrayList();
                        Stopwatch sw = Stopwatch.StartNew(); //Bat dau do thoi gian
                        result = g.getMinRouteBellman(s);
                        sw.Stop(); //Ket thuc do thoi gian
                        long elapsedMs = sw.ElapsedTicks;
                        int step = int.Parse(result[1].ToString());
                        int[,] previous = result[2] as int[,];
                        int[,] mincost = result[3] as int[,];
                        g.printBellman(previous, step, s, t);
                        if (mincost[step, t] > Util.VOCUC / 2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Do dai: " + 0);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Do dai: " + mincost[step, t]);
                        }
                        Console.WriteLine("Tong Thoi Gian: " + elapsedMs);
                    }
                    else
                    {
                        Console.WriteLine("Vui long kiem tra lai input !");
                    }
                }
                else
                {
                    validateFail(g);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();

        }          

        static void request_07(String input)
        {

            Console.WriteLine("Floy do thi khong co canh chi phi am");
            try
            {
                GRAPH g = new GRAPH(input);
                Console.WriteLine("Du lieu cua do thi: ");
                g.writeDataConsole();
                int s = -1;
                int t = -1;
                if (validate(g))
                {
                    //get input
                    Console.WriteLine("Nhap dinh bat dau s [Tap dinh bat dau tu 0]");
                    s = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap dinh ket thuc t [Tap dinh bat dau tu 0]");
                    t = int.Parse(Console.ReadLine());
                    if ((s > -1 && s < g.getN() - 1) && (t > -1 && t < g.getN()))
                    {
                        //validate input success
                        int[,] path = g.getMinRouteFloyd();
                        g.printFloyd(path,s,t);

                    }
                    else
                    {
                        Console.WriteLine("Vui long kiem tra lai input !");
                    }
                }
                else
                {
                    validateFail(g);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();

        }
        static void request_08(String input)
        {

            Console.WriteLine("Do thoi gian Floy");
            try
            {
                GRAPH g = new GRAPH(input);
                Console.WriteLine("Du lieu cua do thi: ");
                g.writeDataConsole();
                int s = -1;
                int t = -1;
                if (validate(g))
                {
                    //get input
                    Console.WriteLine("Nhap dinh bat dau s [Tap dinh bat dau tu 0]");
                    s = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap dinh ket thuc t [Tap dinh bat dau tu 0]");
                    t = int.Parse(Console.ReadLine());
                    if ((s > -1 && s < g.getN() - 1) && (t > -1 && t < g.getN()))
                    {
                        //validate input success
                        Stopwatch sw = Stopwatch.StartNew(); //Bat dau do thoi gian
                        int[,] path = g.getMinRouteFloyd();
                        sw.Stop(); //Ket thuc do thoi gian
                        long elapsedMs = sw.ElapsedTicks;
                        g.printFloyd(path, s, t);
                        Console.WriteLine("Tong Thoi Gian: " + elapsedMs);
                    }
                    else
                    {
                        Console.WriteLine("Vui long kiem tra lai input !");
                    }
                    
                }
                else
                {
                    validateFail(g);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            anotherRequest();

        }        

        //static void test(String input)
        //{
        //    GRAPH g = new GRAPH(input);
        //    for (int s = 0; s < g.getN(); s++)
        //    {
        //        for (int t = 0; t < g.getN(); t++)
        //        {
        //            Console.Write("[s,t] : " + "[" + s + "," + t + "] \t");
        //            ///* TEST Dijkstra */
        //            //ArrayList result = new ArrayList();
        //            //result = g.getMinRouteDijkstra(s, t);
        //            //int[] label = result[0] as int[];
        //            //int length = int.Parse(result[1].ToString());
        //            //g.printDijkstra(label, s, t);
        //            //Console.Write("\t");
        //            //Console.WriteLine("Do dai: " + length);

        //            /* TEST Bellman */
        //            ArrayList result = new ArrayList();
        //            result = g.getMinRouteBellman(s);
        //            int step = int.Parse(result[1].ToString());
        //            int[,] previous = result[2] as int[,];
        //            int[,] mincost = result[3] as int[,];
        //            g.printBellman(previous, step, s, t);
        //            Console.Write("\t");
        //            Console.WriteLine("Do dai: " + mincost[step, t]);
        //        }
        //    }
        //    Console.ReadLine();
        //}

        //Kiem tra do thi co huong, khong chua canh boi, khong chua canh khuyen
        static bool validate(GRAPH g)
        {
            bool bCoHuong = false;
            bool bCanhKhuyen = false;
            bool bCanhBoi = false;
            bCoHuong = !g.KiemTraVoHuong();            
            bCanhKhuyen = !g.KiemTraCoKhuyen();
            bCanhBoi = g.getEdgeDupCount() == 0 ? true : false;
            return bCoHuong && bCanhBoi & bCanhKhuyen;
        }
        static void validateFail(GRAPH g)
        {
            if (g.KiemTraVoHuong())
            {
                Console.WriteLine("Do thi vo huong");
            }
            if (g.KiemTraCoKhuyen())
            {
                Console.WriteLine("Do thi co khuyen");
            }
            if (g.getEdgeDupCount() != 0)
            {
                Console.WriteLine("Do thi co canh boi");
            }
        }
    }
}
