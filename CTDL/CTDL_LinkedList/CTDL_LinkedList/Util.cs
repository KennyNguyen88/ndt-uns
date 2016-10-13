using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_LinkedList
{
    class Util
    {
        public static int ReadFile(string filename, ref String[] a, ref int n)
        {
            string line;
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            _filePath = Directory.GetParent(Directory.GetParent(_filePath).FullName).FullName;
            _filePath += @"\" + filename;
            StreamReader file = new StreamReader(_filePath);
            line = file.ReadLine();
            n = int.Parse(line);
            a = new String[n];            
            if ((line = file.ReadLine().Trim()) != null)
            {
                a = line.Split(' ');
            }            
            file.Close();
            int i = 0;
            foreach(String str in a)
            {
                if (str != "" && str != null)
                    {
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
        ////static public void WriteFile(string filename, int[] a, int n)
        ////{
        ////    string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
        ////    _filePath = Directory.GetParent(Directory.GetParent(_filePath).FullName).FullName;
        ////    _filePath += @"\" + filename;
        ////    System.IO.StreamWriter file = new System.IO.StreamWriter(_filePath);
        ////    file.WriteLine(n);
        ////    for (int i = 0; i < n; i ++)
        ////    {
        ////        file.WriteLine(a[i]);

        ////    }
        ////    file.Close();
        ////}
        //static public void ReadInput(string filename, CIRCLE list)
        //{
        //    int n = 0;
        //    String[] a = null;
        //    int x = ReadFile(filename, ref a, ref n);
        //    for (int i = 0; i < n; i++)
        //    {
        //        MEMBER member = new MEMBER(a[i]);
        //        list.AddLast(member);
        //    }
        //}

    }
}
