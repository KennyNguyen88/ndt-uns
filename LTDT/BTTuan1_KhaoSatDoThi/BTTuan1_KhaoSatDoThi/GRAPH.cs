using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTuan1_KhaoSatDoThi
{
    class GRAPH
    {
        int n; //so dinh
        int[,] a; //bieu dien do thi

        public GRAPH()
        {
            n = 0;
            a = null;
        }
        public GRAPH(String txtInput)
        {
            a = null;
            n = 0;
            Console.WriteLine("=====Bat dau doc du lieu");
            try
            {
                Util.readMatrix(txtInput, ref a, ref n);
            }
            catch (Exception ex)
            {                
                Console.WriteLine("=====Ket thuc doc du lieu");
                Console.WriteLine("Xay ra loi khi doc du lieu ! Vui long kiem tra lai file input");
                throw ex;                
            }
            Console.WriteLine("=====Ket thuc doc du lieu");            
        }
        public void readData(String txtInput)
        {
            Console.WriteLine("=====Bat dau doc du lieu");
            try
            {
                Util.readMatrix(txtInput, ref a, ref n);
            }
            catch (Exception ex)
            {
                Console.WriteLine("=====Ket thuc doc du lieu");
                Console.WriteLine("Xay ra loi khi doc du lieu ! Vui long kiem tra lai file input");
                throw ex;
            }
            Console.WriteLine("=====Ket thuc doc du lieu");
        }
        public void writeDataFile(String txtOutput)
        {
            Console.WriteLine("=====Bat dau ghi du lieu");
            try
            {
                Util.writeMatrix(txtOutput, a, n);
            }
            catch (Exception ex)
            {
                Console.WriteLine("=====Ket thuc ghi du lieu");
                Console.WriteLine("Xay ra loi khi ghi du lieu !");
                throw ex;   
            }                       
            Console.WriteLine("=====Ket thuc ghi du lieu");
        }
        public void writeDataConsole()
        {
            Console.WriteLine("=====Bat dau ghi du lieu");
            try
            {
                Util.writeMatrix(a, n);
            }
            catch (Exception ex)
            {
                Console.WriteLine("=====Ket thuc ghi du lieu");
                Console.WriteLine("Xay ra loi khi ghi du lieu !");
                throw ex;
            }            
            Console.WriteLine("=====Ket thuc ghi du lieu");
        }
        public Boolean KiemTraVoHuong()
        {
            return Util.kiemTraDoiXung(a, n);
        }
        public Boolean KiemTraCoKhuyen()
        {
            return !Util.kiemTraCheoChinh(a, n);
        }
        public int getN()
        {
            return n;
        }
        public int getEdgeCount()
        {
            //dem so != 0 tu bieu dien do thi
            int dem = 0;
            for (int i = 0; i < n; i ++)
            {
                for (int j = 0; j < n; j ++)
                {
                    if (a[i,j] != 0)
                    {
                        dem++;
                    }
                }
            }
            if (this.KiemTraVoHuong()) //Do thi vo huong
            {
                return dem / 2;
            }
            return dem;
        }
        //Xac dinh dinh ke
        //vertex: start from 0
        public void getNeighbor(int vertex)
        {
            if (this.KiemTraVoHuong()) //Do thi vo huong
            {
                for (int i = 0; i < n; i ++)
                {
                    if (a[vertex, i] != 0)
                    {
                        Console.WriteLine("Dinh lien ke: " + (i+1));
                    }
                }
            }
            else //Do thi co huong
            {
                for (int i = 0; i < n; i++)
                {
                    if (a[i, vertex] != 0)
                    {
                        Console.WriteLine("Dinh lien ke: " + (i + 1));
                    }
                    if (a[vertex, i] != 0 && a[i, vertex] == 0)
                    {
                        Console.WriteLine("Dinh lien ke: " + (i + 1));
                    }

                }                
            }
        }
        //Xac dinh bac cua dinh
        //vertex: start from 0
        public int getDegree(int vertex)
        {
            int dem = 0;
            if (this.KiemTraVoHuong()) //Do thi vo huong
            {
                for (int i = 0; i < n; i++)
                {
                    if (a[vertex, i] != 0)
                    {
                        if (vertex == i) //co khuyen
                        {
                            dem = dem + 2;
                        }
                        else
                        {
                            dem++;
                        }
                    }
                }
            }
            else //Do thi co huong
            {
                for (int i = 0; i < n; i++)
                {
                    if (a[i, vertex] != 0) //bac vao
                    {
                        dem++;
                    }
                    if (a[vertex, i] != 0) //bac ra
                    {
                        dem++;
                    }

                }
            }
            return dem;
        }
    }
}
