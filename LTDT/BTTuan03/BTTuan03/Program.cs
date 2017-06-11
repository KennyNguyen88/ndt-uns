using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTuan03
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
            Console.WriteLine("Ly thuyet do thi - Bai tap 03");
            Console.WriteLine("Chon yeu cau can thuc hien");
            Console.WriteLine("1 - Kiem tra do thi day du");
            Console.WriteLine("2 - Kiem tra do thi chinh quy");
            Console.WriteLine("3 - Kiem tra do thi vong");
            Console.WriteLine("4 - Kiem tra do thi phan doi");
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
            
            Console.WriteLine("Yeu cau 01 - Kiem tra do thi day du");
            try
            {
                GRAPH g = new GRAPH(input);
                Console.WriteLine("Du lieu cua do thi: ");
                g.writeDataConsole();                
                if (validate(g)) //Do thi don
                {                    
                    //Bac cua moi dinh la n-1
                    bool result = true;
                    for (int i = 0; i < g.getN(); i++)
                    {
                        if (g.getDegree(i) != (g.getN() - 1))
                        {                            
                            result = false;
                        }
                    }
                    //Output result
                    if (result)
                    {
                        Console.WriteLine("Day la do thi day du K" + g.getN());
                    }
                    else
                    {
                        Console.WriteLine("Khong phai la do thi day du");
                    }
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
            
            Console.WriteLine("Yeu cau 02 - Kiem tra do thi chinh quy");
            try
            {
                GRAPH g = new GRAPH(input);                
                Console.WriteLine("Du lieu cua do thi: ");
                g.writeDataConsole();
                if (validate(g)) //Do thi don
                {                    
                    //Bac cua moi dinh bang nhau
                    bool result = true;
                    int d0 = g.getDegree(0);
                    for (int i = 1; i < g.getN(); i++)
                    {
                        if (g.getDegree(i) != d0)
                        {
                            result = false;
                        }
                    }
                    //Output result
                    if (result)
                    {
                        Console.WriteLine("Day la do thi " + d0 + "-chinh quy");
                    }
                    else
                    {
                        Console.WriteLine("Khong phai la do thi chinh quy");
                    }
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            anotherRequest(input);
        }
        static void request_03(String input)
        {            
            Console.WriteLine("Yeu cau 03 - Kiem tra do thi vong");
            try
            {
                GRAPH g = new GRAPH(input);
                Console.WriteLine("Du lieu cua do thi: ");
                g.writeDataConsole();
                if (validate(g)) //Do thi don
                {
                    //Bac cua moi dinh bang = 2
                    bool result = true;                    
                    for (int i = 0; i < g.getN(); i++)
                    {
                        if (g.getDegree(i) != 2)
                        {
                            result = false;
                        }
                    }
                    //Output result
                    if (result)
                    {
                        Console.WriteLine("Day la do thi vong C" + g.getN());
                    }
                    else
                    {
                        Console.WriteLine("Khong phai la do thi vong");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            anotherRequest(input);
        }
        static void request_04(String input)
        {
            
            Console.WriteLine("Yeu cau 04 - Kiem tra do thi phan doi");
            try
            {
                GRAPH g = new GRAPH(input);
                Console.WriteLine("Du lieu cua do thi: ");
                g.writeDataConsole();
                if (validate(g)) //Do thi don
                {                                        
                    List<int> v1 = new List<int>();
                    List<int> v2 = new List<int>();
                    EDGE[] elst = g.getListEdge();
                    bool phandoi = true;
                    bool daydu = true;
                    //Do thi phan doi 
                    foreach(EDGE ed in elst)
                    {
                        if(ed != null)
                        {
                            if (v1.IndexOf(ed.vertex_start) == -1)
                            {
                                v1.Add(ed.vertex_start);
                            }
                            if (v2.IndexOf(ed.vertex_end) == -1)
                            {
                                v2.Add(ed.vertex_end);
                            }
                        }
                    }                  
                    foreach (int j in v1)
                    {
                        if (v2.IndexOf(j) > -1)
                        {
                            phandoi = false;
                        }
                    }
                    //Do thi phan doi day du
                    if(phandoi)
                    {
                        int socanh = v1.ToArray().Length * v2.ToArray().Length;
                        int en = 0;
                        foreach (EDGE ed in elst)
                        {
                            if (ed != null)
                            {
                                en++;
                            }
                        }
                        if (en != socanh)
                        {
                            daydu = false;
                        }
                    }
                    //Output Result
                    if(!phandoi)
                    {
                        Console.WriteLine("Khong phai la do thi phan doi");
                    }
                    else
                    {
                        if (daydu)
                        {
                            Console.WriteLine("Day la do thi phan doi day du");
                        }
                        else
                        {
                            Console.WriteLine("Day la do thi phan doi");
                        }
                        Console.WriteLine("V1: ");
                        foreach (int item in v1)
                        {
                            Console.WriteLine(item);
                        }                            

                        Console.WriteLine("V2: ");

                        foreach (int item in v2)
                        {
                            Console.WriteLine(item);
                        }                            
                    }                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
