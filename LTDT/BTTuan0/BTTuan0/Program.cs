using System;
using System.IO;

namespace BTTuan0
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
            Console.WriteLine("Ly thuyet do thi - Bai tap 00");
            Console.WriteLine("Chon yeu cau can thuc hien");
            Console.WriteLine("1 - readArray");
            Console.WriteLine("2 - readMatrix");
            Console.WriteLine("3 - computeArray");
            Console.WriteLine("4 - computeMatrix");
            Console.WriteLine("5 - Thoat chuong trinh");
        }
        static int selectRequest()
        {
            int yeucau = 0;
            try
            {
                yeucau = int.Parse(Console.ReadLine());
                if (!(yeucau == 1 || yeucau == 2 || yeucau == 3 || yeucau == 4 || yeucau == 5))
                {
                    Console.WriteLine("Vui long nhap so 1,2,3,4,5");
                    return selectRequest();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Vui long nhap so 1,2,3,4,5");
                return selectRequest();
            }
            return yeucau;
        }
        static void anotherRequest()
        {
            Console.WriteLine("===Nhap so 1,2,3,4 de thuc hien yeu cau tiep theo. Nhap 5 de ket thuc.  ?");
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
                default:
                    break;
            }
        }
        static void request_01()
        {
            String input = "input1.txt";
            int[] a = null;
            int n = 0;
            Console.WriteLine("Yeu cau 01 - Doc tap tin van ban, luu vao mang 1 chieu, in ra theo thu tu nguoc ");
            Console.WriteLine("=====Dang doc du lieu...");
            int x = readArray(input,ref a,ref n);
            if (x == 0)
            {
                Console.WriteLine("Xay ra loi khi doc file. Vui long kiem tra lai file input !");
                return;
            }
            Console.WriteLine("=====Ket thuc doc du lieu");
            Console.WriteLine("=====Xu ly theo yeu cau");
            Console.WriteLine(n);
            for (int i = n-1; i > -1; i --)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("=====Ket thuc Xu ly");
            anotherRequest();
        }
        static void request_02()
        {
            String input = "input2.txt";
            int[,] a = null;
            int n = 0;
            Console.WriteLine("Yeu cau 02 - Doc tap tin van ban, luu vao mang 2 chieu, in ma tran chuyen vi");
            Console.WriteLine("=====Dang doc du lieu...");
            int x = readMatrix(input, ref a, ref n);
            if (x == 0)
            {
                Console.WriteLine("Xay ra loi khi doc file. Vui long kiem tra lai file input !");
                return;
            }
            Console.WriteLine("=====Ket thuc doc du lieu");
            Console.WriteLine("=====Xu ly theo yeu cau");
            Console.WriteLine(n);

            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++ )
                {
                    Console.Write(a[j,i] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("=====Ket thuc Xu ly");
            anotherRequest();
        }
        static void request_03()
        {
            String input = "input1.txt";
            String output = "output3.txt";
            int tongChan = 0;
            int tichLe = 1;
            int[] a = null;
            int n = 0;
            Console.WriteLine("Yeu cau 03 - Doc tap tin van ban, luu vao mang 1 chieu, tinh toan va ghi ra theo yeu cau ");
            Console.WriteLine("=====Dang doc du lieu...");
            int x = readArray(input, ref a, ref n);
            if (x == 0)
            {
                Console.WriteLine("Xay ra loi khi doc file. Vui long kiem tra lai file input !");
                return;
            }
            Console.WriteLine("=====Ket thuc doc du lieu");
            Console.WriteLine("=====Xu ly theo yeu cau");
            foreach(int i in a)
            {
                if(i % 2 == 0)
                {
                    tongChan += i;
                }
                else
                {
                    tichLe *= i;
                }
            }
            StreamWriter file = getFile(output);
            file.WriteLine(n);
            for (int i = n - 1; i > -1; i--)
            {
                file.Write(a[i] + " ");
            }
            file.WriteLine();
            file.WriteLine(tongChan);
            file.WriteLine(tichLe);
            file.Close();
            anotherRequest();
        }
        static void request_04()
        {
            String input = "input2.txt";
            String output = "output4.txt";
            int[,] a = null;
            int n = 0;
            int[] cheo = null;
            Console.WriteLine("Yeu cau 04 - Doc tap tin van ban, luu vao mang 2 chieu, tinh toan va ghi ra theo yeu cau");
            Console.WriteLine("=====Dang doc du lieu...");
            int x = readMatrix(input, ref a, ref n);
            if (x == 0)
            {
                Console.WriteLine("Xay ra loi khi doc file. Vui long kiem tra lai file input !");
                return;
            }
            Console.WriteLine("=====Ket thuc doc du lieu");
            Console.WriteLine("=====Xu ly theo yeu cau");
            cheo = new int[n];
            int dem = 0;
            for(int i = 0; i < n; i++)
            {
                for (int j =0; j < n; j++)
                {
                    if (i==j) //cheo chinh
                    {
                        cheo[dem] = a[i, j];
                        dem++;
                    }
                }
            }
            String thongbao;
            if (kiemTraDoiXung(a,n) == 1)
            {
                thongbao = "Day la ma tran doi xung";
            }
            else
            {
                thongbao = "Day la ma tran khong doi xung";
            }


            StreamWriter file = getFile(output);
            file.WriteLine(n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    file.Write(a[j, i] + " ");
                }
                file.WriteLine();
            }
            for (int k = 0; k < n; k ++)
            {
                file.Write(cheo[k] + " ");
            }
            file.WriteLine();
            file.WriteLine(thongbao);
            file.Close();
            anotherRequest();
        }
        public static StreamWriter getFile(string filename)
        {
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            _filePath = Directory.GetParent(Directory.GetParent(_filePath).FullName).FullName;
            _filePath += @"\" + filename;
            StreamWriter file = new StreamWriter(_filePath);
            return file;
        }
        public static int kiemTraDoiXung(int[,] a,int n)
        {
            bool flag = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(i != j) //khong nam tren cheo chinh
                    {
                        if (a[i,j] != a[j, i])
                        {
                            flag = false;
                            return 0;
                        }
                    }
                }
                
            }
            return 1;
        }
        public static int readArray(string filename, ref int[] a, ref int n)
        {
            string line;
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            _filePath = Directory.GetParent(Directory.GetParent(_filePath).FullName).FullName;
            _filePath += @"\" + filename;
            StreamReader file = new StreamReader(_filePath);
            line = file.ReadLine();
            n = int.Parse(line);
            a = new int[n];
            String[] b = new String[n];
            if ((line = file.ReadLine().Trim()) != null)
            {
                b = line.Split(' ');
            }
            file.Close();
            int i = 0;
            foreach (String str in b)
            {
                if (str != "" && str != null)
                {
                    a[i] = int.Parse(str);
                    i++;
                }
            }
            if (i < n)
            {
                Console.WriteLine("Số lượng phần tử thực tế < n");
                return 0;
            }
            return 1;

        }
        public static int readMatrix(string filename, ref int[,] a, ref int n)
        {
            string line;
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            _filePath = Directory.GetParent(Directory.GetParent(_filePath).FullName).FullName;
            _filePath += @"\" + filename;
            StreamReader file = new StreamReader(_filePath);
            line = file.ReadLine();
            n = int.Parse(line);
            a = new int[n,n];
            int dem = 0;
            for (int r = 0; r < n; r++)
            {
                String[] b = new String[n];
                if ((line = file.ReadLine().Trim()) != null)
                {
                    b = line.Split(' ');
                }
                int i = 0;
                foreach (String str in b)
                {
                    if (str != "" && str != null)
                    {
                        a[r,i] = int.Parse(str);
                        i++;
                        dem++;
                    }
                }
            }            
            file.Close();
            
            if (dem < n*2)
            {
                Console.WriteLine("Số lượng phần tử thực tế < n");
                return 0;
            }
            return 1;

        }        
        
    }
}
