using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_Sorting
{
    class Util
    {
        static public int ReadFile(string filename, ref int[] a, ref int n)
        {
            string line;
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            _filePath = Directory.GetParent(Directory.GetParent(_filePath).FullName).FullName;
            _filePath += @"\" + filename;
            StreamReader file = new StreamReader(_filePath);
            line = file.ReadLine();
            n = int.Parse(line);
            a = new int[n];
            int i = 0;
            while((line = file.ReadLine()) != null)
            {
                a[i] = int.Parse(line);
                i++;
            }
            file.Close();
            if (i < n)
            {
                Console.WriteLine("Số lượng phần tử thực tế < n");
                return 0;
            }
            return 1;
                     
        }
        static public void WriteFile(string filename, int[] a, int n)
        {
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            _filePath = Directory.GetParent(Directory.GetParent(_filePath).FullName).FullName;
            _filePath += @"\" + filename;
            System.IO.StreamWriter file = new System.IO.StreamWriter(_filePath);
            file.WriteLine(n);
            for (int i = 0; i < n; i ++)
            {
                file.WriteLine(a[i]);

            }
            file.Close();
        }
    }
}
