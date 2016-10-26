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
        static public String getDirectoryPath(String directory)
        {
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            _filePath = Directory.GetParent(Directory.GetParent(_filePath).FullName).FullName;
            _filePath += @"\DATA\" + directory;
            return _filePath;
        }
        static public StreamReader getStreamReaderDocGia(string filename)
        {
            return getStreamReader(filename, QUY_DINH.DOC_GIA_DIRECTORY);
        }
        static public StreamReader getStreamReaderSach(string filename)
        {
            return getStreamReader(filename, QUY_DINH.SACH_DIRECTORY);
        }
        static public StreamReader getStreamReaderPhieu(string filename)
        {
            return getStreamReader(filename, QUY_DINH.PHIEU_DIRECTORY);
        }
        static StreamReader getStreamReader(string filename, String directory)
        {
            String _filePath = getDirectoryPath(directory);
            _filePath +=  @"\" + filename;
            StreamReader file = new StreamReader(_filePath);
            return file;
            //string line;
            //line = file.ReadLine();
            //file.Close();           
        }
        static public StreamWriter getStreamWriterDocGia(string filename)
        {
            return getStreamWriter(filename, QUY_DINH.DOC_GIA_DIRECTORY);
        }
        static public StreamWriter getStreamWriterSach(string filename)
        {
            return getStreamWriter(filename, QUY_DINH.SACH_DIRECTORY);
        }
        static public StreamWriter getStreamWriterPhieu(string filename)
        {
            return getStreamWriter(filename, QUY_DINH.PHIEU_DIRECTORY);
        }
        static StreamWriter getStreamWriter(string filename, String directory)
        {
            String _filePath = getDirectoryPath(directory);
            _filePath += @"\" + filename;
            System.IO.StreamWriter file = new System.IO.StreamWriter(_filePath);
            return file;
            //file.WriteLine(n);
            //file.Close();
        }               
    }
}
