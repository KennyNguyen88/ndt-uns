using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTuan05
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
        //result[0] : bac vao; result[1] : bac ra
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
        //Xac dinh tong so canh
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
        public EDGE[] getListEdge()
        {
            EDGE[] result = new EDGE[n * (n - 1) / 2];
            int nResult = 0;
            int run = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = run; j < n; j++)
                {
                    if (i != j)
                    {
                        if (a[i, j] != 0)
                        {
                            EDGE ed = new EDGE(i, j, a[i, j]);
                            result[nResult] = ed;
                            nResult++;
                        }
                    }
                }
                run++;
            }
            return result;
        }
        //Xac dinh dinh ke
        //vertex: start from 0
        public int[] getNeighbor(int vertex)
        {
            int[] b = new int[n];
            int dem = 0;
            if (this.KiemTraVoHuong()) //Do thi vo huong
            {
                for (int i = 0; i < n; i++)
                {
                    if (a[vertex, i] != 0)
                    {
                        b[dem] = i;
                        dem++;
                        //Console.WriteLine("Dinh lien ke: " + (i+1));
                    }
                }
            }
            else //Do thi co huong
            {
                for (int i = 0; i < n; i++)
                {
                    if (a[i, vertex] != 0)
                    {
                        b[dem] = i;
                        dem++;
                        //Console.WriteLine("Dinh lien ke: " + (i + 1));
                    }
                    if (a[vertex, i] != 0 && a[i, vertex] == 0)
                    {
                        b[dem] = i;
                        dem++;
                        //Console.WriteLine("Dinh lien ke: " + (i + 1));
                    }

                }
            }
            return b;
        }
        //duyet theo chieu sau
        public int[] traverseDFS(int vertex)
        {
            Stack myS = new Stack();
            int[] visited = new int[n]; //all 0 --> not visisted
            myS.Push(vertex);
            while (myS.Count > 0)
            {
                int u = Convert.ToInt32(myS.Pop());
                if (visited[u] == 0)
                {
                    visited[u] = 1;
                    //Console.WriteLine("Tham dinh u: " + u);
                    foreach (int i in getNeighbor(u))
                    {
                        myS.Push(i);
                    }
                }
            }
            return visited;

        }
        // 1 ==> do thi lien thong
        public int getConnected()
        {
            int label = 0;
            //int start_vertex = 0;
            int[] labelarr = new int[n]; //all 0

            for (int i = 0; i < n; i++)
            {
                if (labelarr[i] == 0)
                {
                    int[] x1 = traverseDFS(i);
                    if (x1.Length > 0)
                    {
                        label++;
                        for (int k = 0; k < n; k++)
                        {
                            if (x1[k] != 0)
                            {
                                labelarr[k] = label;
                            }
                        }
                    }
                }
            }
            return label;
        }
        public void printConnected()
        {
            int label = 0;
            //int start_vertex = 0;
            int[] labelarr = new int[n]; //all 0

            for (int i = 0; i < n; i++)
            {
                if (labelarr[i] == 0)
                {
                    int[] x1 = traverseDFS(i);
                    if (x1.Length > 0)
                    {
                        label++;
                        Console.WriteLine("Thanh phan lien thong thu: " + label);
                        for (int k = 0; k < n; k++)
                        {
                            if (x1[k] != 0)
                            {
                                labelarr[k] = label;
                            }
                        }
                        
                    }
                    for (int z = 0; z < n; z++)
                    {
                        if (labelarr[z] == label)
                        {
                            Console.Write(" " + z + ", ");
                        }
                    }
                    Console.WriteLine();

                }
            }
            
            //for (int j = 1; j <= label; j++)
            //{
            //    Console.WriteLine("Thanh phan lien thong thu: " + j);
            //    for (int k = 0; k < n; k++)
            //    {
            //        if (labelarr[k] == j)
            //        {
            //            Console.Write(" " + (k + 1) + ", ");
            //        }
            //    }
            //    Console.WriteLine();                
            //}            
        }
        public void doHoanVi(ref EDGE a, ref EDGE b)
        {
            EDGE temp = null;
            temp = a;
            a = b;
            b = temp;
        }
        public EDGE[] doSortAsc(EDGE[] a)
        {
            if (a.Length > 0)
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[j] != null && a[j].value < a[i].value)
                        {
                            doHoanVi(ref a[j], ref a[i]);
                        }
                    }
                }
            }
            return a;
        }
        public EDGE[] getListEdgeSortAsc()
        {
            return doSortAsc(getListEdge());
        }
        public bool isCircle(EDGE[] ed, EDGE e)
        {
            //int flag = 0;
            foreach (EDGE ie in ed)
            {
                if (ie != null)
                {
                    if ((ie.vertex_end == e.vertex_end && ie.vertex_start == e.vertex_start) || (ie.vertex_start == e.vertex_end && ie.vertex_end == e.vertex_start))
                    {
                        return true;
                    }
                    //if (e.vertex_start == ie.vertex_start || e.vertex_start == ie.vertex_end)
                    //{
                    //    flag += 1;
                    //}
                    //if (e.vertex_end == ie.vertex_start || e.vertex_end == ie.vertex_end)
                    //{
                    //    flag += 1;
                    //}
                    //if (flag == 2)
                    //{
                    //    return true;
                    //}
                }
            }
            return false;
        }
        public EDGE[] getMinSpanningTreeKruskal(int init = 0)
        {
            EDGE[] result = new EDGE[n - 1];
            int nresult = 0;
            EDGE[] edges = getListEdgeSortAsc();
            foreach (EDGE e in edges)
            {
                if (e != null && nresult < n - 1)
                {
                    if (!isCircle(result, e))
                    {
                        result[nresult] = e;
                        nresult++;
                    }
                }
            }

            return result;
        }

    }
    

}
