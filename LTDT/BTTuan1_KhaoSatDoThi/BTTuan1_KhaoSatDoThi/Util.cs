using System;
using System.IO;

namespace BTTuan1_KhaoSatDoThi
{
    class Util
    {
        public static StreamWriter getFileWrite(string filename)
        {
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            _filePath = Directory.GetParent(Directory.GetParent(_filePath).FullName).FullName;
            _filePath += @"\" + filename;
            StreamWriter file = new StreamWriter(_filePath);
            return file;
        }
        public static StreamReader getFileRead(string filename)
        {
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            _filePath = Directory.GetParent(Directory.GetParent(_filePath).FullName).FullName;
            _filePath += @"\" + filename;
            StreamReader file = new StreamReader(_filePath);
            return file;
        }
        public static void readMatrix(string filename, ref int[,] a, ref int n)
        {
            string line;
            try
            {
                StreamReader file = getFileRead(filename);
                line = file.ReadLine();
                n = int.Parse(line);
                a = new int[n, n];
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
                            a[r, i] = int.Parse(str);
                            i++;
                            dem++;
                        }
                    }
                }
                file.Close();
                if (dem < (n * n))
                {                    
                    throw new Exception("Du lieu mo ta khong day du");                    
                }                
            }
            catch(Exception ex)
            {
                throw ex;
            }            
        }
        public static void writeMatrix(String filename, int[,] a, int n)
        {
            try
            {
                StreamWriter file = getFileWrite(filename);
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        file.Write(a[i, j] + " ");
                    }
                    file.WriteLine();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public static void writeMatrix(int[,] a, int n)
        {
            try
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //true: doi xung
        public static Boolean kiemTraDoiXung(int[,] a, int n)
        {
            bool flag = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j) //khong nam tren cheo chinh
                    {
                        if (a[i, j] != a[j, i])
                        {
                            flag = false;                            
                        }
                    }
                }

            }
            return flag;
        }
        //true: cheo chinh tat ca = 0
        public static Boolean kiemTraCheoChinh(int[,] a, int n)
        {
            bool flag = true;
            for (int i = 0; i < n; i++)
            {
               if (a[i,i] != 0)
                {
                    flag = false;
                }
            }
            return flag;
        }
    }
}
