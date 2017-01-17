using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTuan1_KhaoSatDoThi
{
    class EDGE
    {
        public int vertex_start;
        public int vertex_end;
        public int value;
        public EDGE()
        {
            vertex_start = -1;
            vertex_end = -1;
            value = -1;
        }
        public void print()
        {
            Console.WriteLine(vertex_start + " --> " + vertex_end + " : " + value);
        }
    }
}
