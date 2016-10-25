using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTLT
{
    class Util
    {
        static public StreamReader getStreamReader(string filename)
        {            
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            _filePath = Directory.GetParent(Directory.GetParent(_filePath).FullName).FullName;
            _filePath += @"\" + filename;
            StreamReader file = new StreamReader(_filePath);
            return file;
            //string line;
            //line = file.ReadLine();
            //file.Close();           
        }

        static public StreamWriter getStreamWriter(string filename)
        {
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            _filePath = Directory.GetParent(Directory.GetParent(_filePath).FullName).FullName;
            _filePath += @"\" + filename;
            System.IO.StreamWriter file = new System.IO.StreamWriter(_filePath);
            return file;
            //file.WriteLine(n);
            //file.Close();
        }
    }
}
