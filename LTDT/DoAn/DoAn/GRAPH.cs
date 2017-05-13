using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
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
            //Console.WriteLine("=====Bat dau doc du lieu");
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
            //Console.WriteLine("=====Ket thuc doc du lieu");            
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
        public Boolean KiemTraVoHuong()
        {
            return Util.kiemTraDoiXung(a, n);
        }
        public Boolean KiemTraCoKhuyen()
        {
            return !Util.kiemTraCheoChinh(a, n);
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
            for (int i = 0; i < n; i++)
            {
                if (a[i, i] != 0)
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
            foreach (EDGE ed in this.getListEdge())
            {
                foreach (EDGE ed1 in this.getListEdge())
                {
                    if (ed != null & ed1 != null)
                    {
                        if (ed.vertex_start == ed1.vertex_end && ed.vertex_end == ed1.vertex_start)
                        {
                            result++;
                        }
                    }
                }
            }
            return result;
        }
        public EDGE[] getListEdge()
        {
            EDGE[] result = new EDGE[n * (n - 1) / 2];
            int nResult = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j) //khong tinh canh boi
                    {
                        if (a[i, j] != 0)
                        {
                            EDGE ed = new EDGE(i, j, a[i, j]);
                            result[nResult] = ed;
                            nResult++;
                        }
                    }
                }
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
            ArrayList v = new ArrayList();
            foreach (EDGE ie in ed)
            {
                if (ie != null)
                {
                    if (v.IndexOf(ie.vertex_start) < 0) // not exsit
                    {
                        v.Add(ie.vertex_start);
                    }
                    if (v.IndexOf(ie.vertex_end) < 0)
                    {
                        v.Add(ie.vertex_end);
                    }
                }
            }

            if (v.IndexOf(e.vertex_start) > -1 && v.IndexOf(e.vertex_end) > -1)
            {
                return true;
            }
            return false;
        }

        //Dijkstra
        public ArrayList getMinRouteDijkstra(int vertex_start = 0, int vertex_end = 0)
        {
            ArrayList result = new ArrayList();
            int RouteLength = 0;
            int[] T = new int[n];
            int[] Route = new int[n];
            int[] Label = new int[n];
            //Khoi tao thong so
            for (int i = 0; i < n; i++)
            {
                T[i] = 1; //tat ca canh dinh deu nam trong T
                Route[i] = Util.VOCUC;
                Label[i] = -1;
            }
            Route[vertex_start] = 0; //dinh bat dau

            while (T[vertex_end] == 1)
            {
                int min = Util.VOCUC;
                int v = -1;
                for (int i = 0; i < n; i++)
                {
                    if (T[i] != 0 && min >= Route[i])
                    {
                        min = Route[i];
                        v = i;
                    }
                }
                if (v == -1)
                {
                    RouteLength = -1;
                    break;
                }
                T[v] = 0;
                for (int k = 0; k < n; k++)
                {
                    if (a[v, k] != 0 && T[k] != 0)
                    {
                        if (Route[k] > (Route[v] + a[v, k]))
                        {
                            Route[k] = Route[v] + a[v, k];
                            Label[k] = v;
                        }
                    }

                }
            }
            if (RouteLength != -1) //ton tai duong di ngan nhat
            {
                RouteLength = Route[vertex_end];
            }
            result.Add(Label);
            result.Add(RouteLength);
            return result;
        }
        public void printDijkstra(int[] Label, int vertex_start, int vertext_end)
        {
            if (Label[vertext_end] != Label[vertex_start])
            {
                Console.Write(vertext_end);
            }
            else
            {
                Console.Write("Khong-co-duong-di");
            }
            while (Label[vertext_end] != Label[vertex_start])
            {
                Console.Write("<--" + Label[vertext_end]);
                vertext_end = Label[vertext_end];
            }
            //Console.WriteLine(vertex_start);
        }
        //Bellman
        public ArrayList getMinRouteBellman(int vertex_start = 0)
        {
            ArrayList result = new ArrayList();
            int[,] mincost = new int[n + 1, n];
            int[,] previous = new int[n + 1, n];

            //khoi tao
            int step = 0;
            for (int i = 0; i < n; i++)
            {
                mincost[step, i] = Util.VOCUC;
                previous[step, i] = i;
            }
            mincost[step, vertex_start] = 0;
            bool success = true;

            for (step = 1; step <= n; step++)
            {
                for (int i = 0; i < n; i++)
                {
                    mincost[step, i] = mincost[step - 1, i];
                    previous[step, i] = previous[step - 1, i];
                    for (int j = 0; j < n; j++)
                    {
                        if (a[j, i] != 0 && mincost[step - 1, j] != Util.VOCUC)
                        {
                            if (mincost[step, i] == Util.VOCUC || (mincost[step - 1, j] + a[j, i]) < mincost[step - 1, i])
                            {
                                mincost[step, i] = mincost[step - 1, j] + a[j, i];
                                previous[step, i] = j;
                            }
                        }
                    }
                }
                bool bsame = true;
                for (int i = 0; i < n; i++)
                {
                    if (mincost[step, i] != mincost[step - 1, i])
                    {
                        bsame = false;
                        break;
                    }
                }
                if (bsame)
                {
                    break;
                }

            }
            if (step == n)
            {
                success = false; //chu trinh am
            }
            result.Add(success);
            result.Add(step);
            result.Add(previous);
            result.Add(mincost);
            return result;
        }
        public void printBellman(int[,] previous, int step, int vertex_start, int vertex_end)
        {
            if (previous[step, vertex_end] == vertex_end)
            {
                Console.Write("Khong-co-duong-di");
                return;
            }
            Console.Write(vertex_end);
            while (previous[step, vertex_end] != vertex_start)
            {
                Console.Write("<--");
                Console.Write(previous[step, vertex_end]);
                vertex_end = previous[step, vertex_end];

            }
            Console.Write("<--");
            Console.Write(vertex_start);
        }        
        //Floyd
        public int[,] getMinRouteFloyd()
        {
            int[,] sau_nut = new int[n, n];
            //init sau_nut
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] > 0)
                    {
                        sau_nut[i, j] = j;
                    }
                    else
                    {
                        sau_nut[i, j] = -1;
                    }
                }
            }
            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (a[i, k] > 0)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (a[k, j] > 0)
                            {
                                if ((a[i, j] == 0 && i != j) || (a[i, j] > a[i, k] + a[k, j]))
                                {
                                    a[i, j] = a[i, k] + a[k, j];
                                    sau_nut[i, j] = sau_nut[i, k];
                                }
                            }
                        }
                    }
                }

            }
            return sau_nut;

        }
        public void printFloyd(int[,] path, int vertex_start, int vertex_end)
        {

            if (a[vertex_start, vertex_end] > 0)
            {
                int s, t;
                Console.WriteLine(vertex_start + " -> " + vertex_end + " = " + a[vertex_start, vertex_end]);
                s = vertex_start;
                t = vertex_end;
                Console.Write(s );
                do
                {

                    Console.Write("->" + path[s, t] );
                    s = path[s, t];
                }
                while (s != t);

                if (t != vertex_end)
                {
                    Console.WriteLine(vertex_end);
                }
                Console.WriteLine();
            }

        }
    }


}
