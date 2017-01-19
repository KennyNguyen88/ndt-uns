using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTuan02
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
        public int getN()
        {
            return n;
        }
        //true: Do thi vo huong
        public Boolean KiemTraVoHuong()
        {
            return Util.kiemTraDoiXung(a, n);
        }
        //Xac dinh tong bac cua dinh
        //Dinh bat dau tu 0
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
                            dem += a[vertex, i];
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
                        dem += a[vertex, i];
                    }
                    if (a[vertex, i] != 0) //bac ra
                    {
                        dem += a[vertex, i];
                    }

                }
            }
            return dem;
        }
        //Xac dinh chi tiet bac cua dinh
        //Dinh bat dau tu 0
        public int[] getDegreeDetail(int vertex)
        {
            int dem1 = 0;
            int dem2 = 0;
            int[] result = new int[2];
            if (this.KiemTraVoHuong()) //Do thi vo huong
            {
                for (int i = 0; i < n; i++)
                {
                    if (a[vertex, i] != 0)
                    {
                        if (vertex == i) //co khuyen
                        {
                            dem1 = dem1 + 2;
                        }
                        else
                        {
                            dem1 += a[vertex, i];
                        }
                    }
                }
                result[0] = dem1;
                result[1] = dem1;

            }
            else //Do thi co huong
            {
                for (int i = 0; i < n; i++)
                {

                    if (a[i, vertex] != 0) //bac vao
                    {
                        dem1 += a[i, vertex];

                    }
                    if (a[vertex, i] != 0) //bac ra
                    {
                        dem2 += a[vertex, i];
                    }
                }
                result[0] = dem1;
                result[1] = dem2;
            }
            return result;
        }
        //Xac dinh tnog so canh
        public int getEdgeCount()
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (KiemTraVoHuong())
                {
                    sum += getDegree(i);
                }
                else
                {
                    sum += getDegreeDetail(i)[0];
                }
            }
            if (KiemTraVoHuong())
            {
                return sum / 2;
            }
            else
            {
                return sum;
            }
        }
        //so canh khuyen
        public int getEdgeCircleCount()
        {
            int result = 0;
            for (int i = 0; i< n; i ++)
            {
                if (a[i,i] != 0)
                {
                    result++;
                }
            }
            return result;
        }
        //so canh boi
        public int getEdgeDupCount()
        {
            int result = 0;
            for (int i = 0;i < n; i++)
            {
                for (int j = 0; j < n; j ++)
                {
                    if (a[i,j] > 1)
                    {
                        result+=a[i,j];
                    }
                }
            }
            if (KiemTraVoHuong())
            {
                return result / 2;
            }
            return result;
        }        
        
    }
    

}
