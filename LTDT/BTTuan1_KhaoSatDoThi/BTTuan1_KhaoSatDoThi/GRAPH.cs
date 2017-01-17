using System;
using System.Collections;
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
        public int[] getNeighbor(int vertex)
        {
            int[] b = new int[n];
            int dem = 0;
            if (this.KiemTraVoHuong()) //Do thi vo huong
            {                
                for (int i = 0; i < n; i ++)
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
        // Chuyen thanh do thi vo huong
        // Giu lai trong so nho nhat trong truong hop canh boi
        public GRAPH transform()
        {
            if (KiemTraVoHuong())
            {
                return this;
            }
            else
            {
                GRAPH tg = new GRAPH();
                tg.n = n;                
                int[,] b = new int[n, n];
                int run = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = run; j < n; j++)
                    {
                        if (i != j)
                        {                            
                            int min = Util.getMin(a[i, j] , a[j, i]);
                            b[i, j] = min;
                            b[j, i] = min;
                            
                        }
                        else
                        {
                            b[i, j] = a[i, j];
                        }
                        
                    }
                    run++;
                }
                tg.a = b;
                return tg;
            }            
        }
        //Thay doi gia tri trong so canh (i,j)
        //Dinh bat dau = 0
        public void updateValue(int vertex_start, int vertex_end, int value)
        {
            if (vertex_start > -1 && vertex_start < n) //dinh bat dau phai ton tai
            {
                if (vertex_end > -1 && vertex_end < n) //dinh ket thuc phai ton tai
                {
                    if (a[vertex_start, vertex_end] != 0) //canh ton tai
                    {                        
                        if (KiemTraVoHuong()) 
                        {
                            a[vertex_start, vertex_end] = value;
                            a[vertex_end, vertex_start] = value;
                        }
                        else
                        {
                            a[vertex_start, vertex_end] = value;
                        }                                                                       
                    }
                    else
                    {
                        throw new Exception("Canh khong ton tai !");
                    }                    
                }
                else
                {
                    throw new Exception("Dinh ket thuc khong ton tai !");
                }
            }
            else
            {
                throw new Exception("Dinh bat dau khong ton tai !");
            }            
        }
        //Them 1 dinh        
        public GRAPH addVertex()
        {
            GRAPH ng = new GRAPH();
            ng.n = n + 1;
            int[,] b = new int[n + 1, n + 1];
            for (int i = 0; i < n+1; i ++)
            {
                for (int j = 0; j < n+1; j ++)
                {
                    if (i == n || j == n)
                    {
                        b[i, j] = 0;
                    }
                    else
                    {
                        b[i, j] = a[i, j];
                    }
                }
            }
            ng.a = b;
            return ng;
        }
        //Xoa 1 dinh
        //Dinh bat dau tu 0
        public GRAPH deleteVertex(int vertex)
        {
            GRAPH ng = new GRAPH();
            ng.n = n - 1;
            int[,] b = new int[n - 1, n - 1];
            if (vertex > -1 && vertex < n)
            {
                if (vertex == 0) //dinh dau
                {
                    for(int i = 1; i < n; i ++)
                    {
                        for (int j = 1; j < n; j ++)
                        {
                            b[i - 1, j - 1] = a[i, j];
                        }
                    }
                }
                else if (vertex == (n-1)) //dinh cuoi
                {
                    for (int i = 0; i < n-1; i++)
                    {
                        for (int j = 0; j < n-1; j++)
                        {
                            b[i, j] = a[i, j];
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < vertex; i++)
                    {
                        for (int j = 0; j < vertex; j++)
                        {
                            b[i, j] = a[i, j];
                        }
                    }
                    for (int i = vertex + 1; i < n; i++)
                    {
                        for (int j = vertex + 1; j < n; j++)
                        {
                            b[i-1, j-1] = a[i, j];
                        }
                    }
                }
            }
            else
            {
                throw new Exception("Dinh khong ton tai !");
            }
            ng.a = b;
            return ng;
        }
        //Them 1 canh
        //canh da ton tai ==> khong them ==> them trong so
        //dinh khong ton tai ==> them dinh ==> them canh
        //Dinh bat dau tu 0
        public GRAPH addEdge(int vertex_start, int vertex_end, int value)
        {
            GRAPH gh = new GRAPH();
            gh.n = this.n;
            gh.a = this.a;
            //kiem tra dinh
            if (vertex_start < 0 || vertex_start > n - 1 || vertex_end < 0 || vertex_end > n - 1)
            {
                gh = addVertex();
            }            
            //kiem tra canh
            if (gh.a[vertex_start, vertex_end] != 0) //canh da ton tai
            {
                int newVal = gh.a[vertex_start, vertex_end] + value;
                gh.updateValue(vertex_start, vertex_end, newVal);
            }
            else //canh chua ton tai
            {
                gh.a[vertex_start, vertex_end] = 1; //lam cho canh ton tai
                gh.updateValue(vertex_start, vertex_end, value); //cap nhat trong so
            }
            return gh;

        }
        //Xoa 1 canh
        //Dinh bat dau tu 0
        public GRAPH deleteEdge(int vertex_start, int vertex_end)
        {
            GRAPH gh = new GRAPH();
            gh.n = this.n;
            try
            {
                this.updateValue(vertex_start, vertex_end, 0);
                gh.a = this.a;
            }
            catch(Exception ex)
            {
                throw ex;
            }                        
            return gh;
        }
        public int[] traverseDFS(int vertex)
        {
            Stack myS = new Stack();
            int[] visited = new int[n]; //all 0 --> not visisted
            myS.Push(vertex);
            while(myS.Count > 0)
            {
                int u = Convert.ToInt32(myS.Pop());
                if (visited[u] == 0)
                {
                    visited[u] = 1;
                    //Console.WriteLine("Tham dinh u: " + u);
                    foreach(int i in getNeighbor(u))
                    {
                        myS.Push(i);
                    }
                }
            }
            return visited;

        }
        public int[] traverseBFS(int vertex)
        {
            int[] visited = new int[n]; //all 0 --> not visisted
            Queue myQ = new Queue();
            visited[vertex] = 1;
            myQ.Enqueue(vertex);
            while(myQ.Count != 0)
            {
                int s = Convert.ToInt32(myQ.Dequeue());
                //Console.WriteLine("Tham dinh s: " + s);
                foreach (int i in getNeighbor(s))
                {
                   if(visited[i] == 0)
                    {
                        visited[i] = 1;
                        myQ.Enqueue(i);
                    }
                }
            }
            return visited;
        }
        // =1 ==> do thi lien thong
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
                        for (int k = 0; k <n; k ++)
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
        //Prism
        public EDGE[] getMinSpanningTree(int init=0)
        {
            EDGE[] result = new EDGE[n-1];
            int nresult = 0;
            int[] lblVertex = new int[n]; //all 0 --> not visited
            int nLbl = 0;
            lblVertex[init] = 1; //bat dau tu dinh init
            while (nresult < n-1) //n-1 phan tu
            {
                EDGE edgeMin = new EDGE();
                int nMinWeight = -1;
                int run = -1;
                for (int i = 0; i < n; i++)
                {
                    if (lblVertex[i] == 0) // Dinh i chua dc xet
                    {
                        for (int j = 0;j<n;j++)
                        {
                            if (lblVertex[j] != 0 && a[i,j] != 0) //Dinh j da xet va co canh noi den i
                            {
                                if (nMinWeight < 0 || a[i,j] < nMinWeight)
                                {
                                    edgeMin.vertex_start = i;
                                    edgeMin.vertex_end = j;
                                    edgeMin.value = a[i, j];
                                    nMinWeight = a[i, j];
                                    run = i;
                                }
                            }
                        }
                    }
                }
                result[nresult] = edgeMin;
                nresult++;
                lblVertex[run] = 1;

            }
            return result;
        }
    }
}
